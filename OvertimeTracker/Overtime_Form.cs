using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OvertimeTracker {
    public partial class Overtime_Form : Form {

        private double availableOvertime = 0; //MINUTES
        private bool[] clearTextBox = new bool[4];

        public Overtime_Form () {
            InitializeComponent();
            tbxNewOvertimeDate.Text = ("" + DateTime.Today).Substring(0, 10);
            tbxTakeOvertimeDate.Text = ("" + DateTime.Today).Substring(0, 10);

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

                    var dateString = tbxNewOvertimeDate.Text;

                    var durationHour = endTimeHour - startTimeHour;
                    double durationMinute = 0;

                    if (endTimeMinute < startTimeMinute) {
                        durationMinute = startTimeMinute - endTimeMinute;
                        durationMinute = 60 - durationMinute;
                    } else
                        durationMinute = endTimeMinute - startTimeMinute;

                    if (durationMinute > 0 && durationMinute <= 30)
                        durationMinute = 30;
                    else {
                        durationHour++;
                        durationMinute = 0;
                    }

                    lbxCurrentOvertime.Items.Add(durationHour + "." + durationMinute + '\t' + tbxNewOvertimeDate.Text);

                    availableOvertime += (durationHour * 60) + durationMinute;
                    RefreshEntries();
                }
            }
            catch (FormatException) {
                MessageBox.Show("Bitte gültige Uhrzeiten im Format HH:MM eingeben.", "Hinweis", MessageBoxButtons.OK);
            }
        }


        private void btnTakeOvertime_Click (object sender, EventArgs e) {
            var result = MessageBox.Show("Soll der Ausgleich eingetragen werden?", "Hinweis", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                var startTimeHour = Convert.ToInt32(tbxTakeOvertimeStartTime.Text.Substring(0, 2));
                var startTimeMinute = Convert.ToInt32(tbxTakeOvertimeStartTime.Text.Substring(3));

                var endTimeHour = Convert.ToInt32(tbxTakeOvertimeEndTime.Text.Substring(0, 2));
                var endTimeMinute = Convert.ToInt32(tbxTakeOvertimeEndTime.Text.Substring(3));

                var dateString = tbxTakeOvertimeDate.Text;

                var durationHour = endTimeHour - startTimeHour;
                double durationMinute = 0;

                if (endTimeMinute < startTimeMinute) {
                    durationMinute = startTimeMinute - endTimeMinute;
                    durationMinute = 60 - durationMinute;
                } else
                    durationMinute = endTimeMinute - startTimeMinute;

                if (durationMinute > 0 && durationMinute <= 30)
                    durationMinute = 30;
                else {
                    durationHour++;
                    durationMinute = 0;
                }

                if (durationHour > 0 || durationMinute > 0) {
                    lbxTakenOvertime.Items.Add(durationHour + "." + durationMinute + '\t' + tbxNewOvertimeDate.Text);

                    availableOvertime -= (durationHour * 60) + durationMinute;
                    RefreshEntries();
                } else
                    MessageBox.Show("Nicht ausreichend Ausgleich verfügbar.", "Hinweis", MessageBoxButtons.OK);
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
