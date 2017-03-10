using System;
using System.Windows.Forms;

namespace OvertimeTracker {
    public partial class Overtime_Form : Form {

        private double availableOvertime = 0; //MINUTES
        private bool[] clearTextBox = new bool[4];

        public Overtime_Form () {
            InitializeComponent();
            RefreshEntries();

            for (int i = 0; i < clearTextBox.Length; i++)
                clearTextBox[i] = true;
        }

        private void RefreshEntries () {
            tbxNewOvertimeDate.Text = ("" + DateTime.Today).Substring(0, 10);
            tbxNewOvertimeEndTime.Text = "HH:MM";
            tbxNewOvertimeStartTime.Text = "HH:MM";

            tbxTakeOvertimeDate.Text = ("" + DateTime.Today).Substring(0, 10);
            tbxTakeOvertimeEndTime.Text = "HH:MM";
            tbxTakeOvertimeStartTime.Text = "HH:MM";

            for (int i = 0; i < clearTextBox.Length; i++)
                clearTextBox[i] = true;

            tbxAvailableOvertime.Text = (availableOvertime / 60) + " Stunden";
        }

        private void btnAddOvertime_Click (object sender, EventArgs e) {
            try {
                var result = MessageBox.Show("Soll der Ausgleich eingetragen werden?", "Hinweis", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {
                    var startTimeHour = Convert.ToInt32(tbxNewOvertimeStartTime.Text.Substring(0, 2));
                    var startTimeMinute = Convert.ToInt32(tbxNewOvertimeStartTime.Text.Substring(3));

                    var endTimeHour = Convert.ToInt32(tbxNewOvertimeEndTime.Text.Substring(0, 2));
                    var endTimeMinute = Convert.ToInt32(tbxNewOvertimeEndTime.Text.Substring(3));

                    var negativeOvertime = false;

                    if (startTimeHour > endTimeHour)
                        negativeOvertime = true;
                    else if (startTimeHour == endTimeHour && startTimeMinute > endTimeMinute)
                        negativeOvertime = true;
                    else if (startTimeHour == endTimeHour && startTimeMinute == endTimeMinute)
                        negativeOvertime = true;

                    var dateString = tbxNewOvertimeDate.Text;
                    var currentDate = ("" + DateTime.Today).Substring(0, 10);

                    if (!negativeOvertime) {
                        var durationHour = endTimeHour - startTimeHour;
                        var durationMinute = durationHour * 60;

                        if (startTimeMinute > endTimeMinute) {
                            durationMinute += 60 - (startTimeMinute - endTimeMinute);
                            durationMinute -= 60;
                        } else if (startTimeMinute < endTimeMinute)
                            durationMinute += endTimeMinute - startTimeMinute;
                        else if (startTimeMinute == endTimeMinute)
                            durationMinute += 0;


                        if (durationMinute < 30) {
                            MessageBox.Show("Weniger als 30 Minuten werden nicht als Überstunden gewertet", "Hinweis", MessageBoxButtons.OK);
                            negativeOvertime = true;
                        }

                        if (!negativeOvertime) {
                            durationHour = durationMinute / 60;
                            if ((durationMinute % 60) <= 30)
                                durationMinute = 30;
                            else if ((durationMinute % 60) > 30) {
                                durationHour++;
                                durationMinute = 0;
                            }

                            lbxCurrentOvertime.Items.Add(dateString + '\t' + startTimeHour + ":" + startTimeMinute +
                                " bis " + endTimeHour + ":" + endTimeMinute);
                            lbxCurrentOvertime.Items.Add(durationHour + " Stunden " 
                                + durationMinute + " Minuten" + '\t' + "Eingetragen: " + currentDate);

                            availableOvertime += (durationMinute + (durationHour * 60));
                            RefreshEntries();
                        }
                    } else
                        MessageBox.Show("Negative Überstunden können nicht eingetragen werden.", "Hinweis", MessageBoxButtons.OK);
                }
            }
            catch (Exception) {
                MessageBox.Show("Bitte gültige Uhrzeiten im Format HH:MM eingeben.", "Hinweis", MessageBoxButtons.OK);
                RefreshEntries();
            }
        }


        private void btnTakeOvertime_Click (object sender, EventArgs e) {
            try {
                var result = MessageBox.Show("Soll der Ausgleich eingetragen werden?", "Hinweis", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {
                    var startTimeHour = Convert.ToInt32(tbxTakeOvertimeStartTime.Text.Substring(0, 2));
                    var startTimeMinute = Convert.ToInt32(tbxTakeOvertimeStartTime.Text.Substring(3));

                    var endTimeHour = Convert.ToInt32(tbxTakeOvertimeEndTime.Text.Substring(0, 2));
                    var endTimeMinute = Convert.ToInt32(tbxTakeOvertimeEndTime.Text.Substring(3));

                    var dateString = tbxTakeOvertimeDate.Text;
                    var currentDate = ("" + DateTime.Today).Substring(0, 10);

                    var durationHour = endTimeHour - startTimeHour;
                    var durationMinute = durationHour * 60;

                    if (startTimeMinute > endTimeMinute) {
                        durationMinute += 60 - (startTimeMinute - endTimeMinute);
                        durationMinute -= 60;
                    } else if (startTimeMinute < endTimeMinute)
                        durationMinute += endTimeMinute - startTimeMinute;
                    else if (startTimeMinute == endTimeMinute)
                        durationMinute += 0;

                    if (durationHour > 0 || durationMinute > 0) {
                        durationHour = durationMinute / 60;
                        if ((durationMinute % 60) <= 30)
                            durationMinute = 30;
                        else if ((durationMinute % 60) > 30) {
                            durationHour++;
                            durationMinute = 0;
                        }

                        if (availableOvertime >= (durationMinute + (durationHour * 60))) {

                            lbxTakenOvertime.Items.Add(dateString + '\t' + startTimeHour + ":" + startTimeMinute +
                                " bis " + endTimeHour + ":" + endTimeMinute);
                            lbxTakenOvertime.Items.Add(durationHour + " Stunden "
                                + durationMinute + " Minuten" + '\t' + "Eingetragen: " + currentDate);

                            availableOvertime -= (durationMinute + (durationHour * 60));
                            RefreshEntries();
                        } else
                            MessageBox.Show("Nicht genügend Ausgleich verfügbar.", "Hinweis", MessageBoxButtons.OK);
                    } else
                        MessageBox.Show("Der Ausgleich kann nicht eingetragen werden.", "Hinweis", MessageBoxButtons.OK);
                }
            } catch (Exception) {
                MessageBox.Show("Bitte gültige Uhrzeiten im Format HH:MM eingeben.", "Hinweis", MessageBoxButtons.OK);
                RefreshEntries();
            }
        }

        private void tbxNewOvertimeStartTime_Click (object sender, EventArgs e) {
            if (clearTextBox[0]) {
                tbxNewOvertimeStartTime.Clear();
                clearTextBox[0] = false;
            }
        }

        private void tbxNewOvertimeEndTime_Click (object sender, EventArgs e) {
            if (clearTextBox[1]) {
                tbxNewOvertimeEndTime.Clear();
                clearTextBox[1] = false;
            }
        }

        private void tbxTakeOvertimeStartTime_Click (object sender, EventArgs e) {
            if (clearTextBox[2]) {
                tbxTakeOvertimeStartTime.Clear();
                clearTextBox[2] = false;
            }
        }

        private void tbxTakeOvertimeEndTime_Click (object sender, EventArgs e) {
            if (clearTextBox[3]) {
                tbxTakeOvertimeEndTime.Clear();
                clearTextBox[3] = false;
            }
        }
    }
}
