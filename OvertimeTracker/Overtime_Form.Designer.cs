namespace OvertimeTracker {
    partial class Overtime_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.lblCurrentOvertime = new System.Windows.Forms.Label();
            this.lblTakenOvertime = new System.Windows.Forms.Label();
            this.lbxCurrentOvertime = new System.Windows.Forms.ListBox();
            this.lbxTakenOvertime = new System.Windows.Forms.ListBox();
            this.gbxNewOvertime = new System.Windows.Forms.GroupBox();
            this.btnAddOvertime = new System.Windows.Forms.Button();
            this.tbxNewOvertimeEndTime = new System.Windows.Forms.TextBox();
            this.tbxNewOvertimeStartTime = new System.Windows.Forms.TextBox();
            this.tbxNewOvertimeDate = new System.Windows.Forms.TextBox();
            this.lblNewOvertimeStartTime = new System.Windows.Forms.Label();
            this.lblNewOvertimeDate = new System.Windows.Forms.Label();
            this.lblNewOvertimeEndTime = new System.Windows.Forms.Label();
            this.gbxTakeOvertime = new System.Windows.Forms.GroupBox();
            this.btnTakeOvertime = new System.Windows.Forms.Button();
            this.tbxTakeOvertimeEndTime = new System.Windows.Forms.TextBox();
            this.tbxTakeOvertimeStartTime = new System.Windows.Forms.TextBox();
            this.tbxTakeOvertimeDate = new System.Windows.Forms.TextBox();
            this.lblTakeOvertimeStartTime = new System.Windows.Forms.Label();
            this.lblTakeOvertimeDate = new System.Windows.Forms.Label();
            this.lblTakeOvertimeEndTime = new System.Windows.Forms.Label();
            this.lblAvailableOvertime = new System.Windows.Forms.Label();
            this.tbxAvailableOvertime = new System.Windows.Forms.TextBox();
            this.gbxNewOvertime.SuspendLayout();
            this.gbxTakeOvertime.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentOvertime
            // 
            this.lblCurrentOvertime.AutoSize = true;
            this.lblCurrentOvertime.Location = new System.Drawing.Point(13, 13);
            this.lblCurrentOvertime.Name = "lblCurrentOvertime";
            this.lblCurrentOvertime.Size = new System.Drawing.Size(132, 13);
            this.lblCurrentOvertime.TabIndex = 0;
            this.lblCurrentOvertime.Text = "Vorhandene Überstunden:";
            // 
            // lblTakenOvertime
            // 
            this.lblTakenOvertime.AutoSize = true;
            this.lblTakenOvertime.Location = new System.Drawing.Point(270, 13);
            this.lblTakenOvertime.Name = "lblTakenOvertime";
            this.lblTakenOvertime.Size = new System.Drawing.Size(122, 13);
            this.lblTakenOvertime.TabIndex = 1;
            this.lblTakenOvertime.Text = "Genommener Ausgleich:";
            // 
            // lbxCurrentOvertime
            // 
            this.lbxCurrentOvertime.FormattingEnabled = true;
            this.lbxCurrentOvertime.Location = new System.Drawing.Point(16, 30);
            this.lbxCurrentOvertime.Name = "lbxCurrentOvertime";
            this.lbxCurrentOvertime.Size = new System.Drawing.Size(218, 316);
            this.lbxCurrentOvertime.TabIndex = 2;
            // 
            // lbxTakenOvertime
            // 
            this.lbxTakenOvertime.FormattingEnabled = true;
            this.lbxTakenOvertime.Location = new System.Drawing.Point(273, 30);
            this.lbxTakenOvertime.Name = "lbxTakenOvertime";
            this.lbxTakenOvertime.Size = new System.Drawing.Size(218, 316);
            this.lbxTakenOvertime.TabIndex = 3;
            // 
            // gbxNewOvertime
            // 
            this.gbxNewOvertime.Controls.Add(this.btnAddOvertime);
            this.gbxNewOvertime.Controls.Add(this.tbxNewOvertimeEndTime);
            this.gbxNewOvertime.Controls.Add(this.tbxNewOvertimeStartTime);
            this.gbxNewOvertime.Controls.Add(this.tbxNewOvertimeDate);
            this.gbxNewOvertime.Controls.Add(this.lblNewOvertimeStartTime);
            this.gbxNewOvertime.Controls.Add(this.lblNewOvertimeDate);
            this.gbxNewOvertime.Controls.Add(this.lblNewOvertimeEndTime);
            this.gbxNewOvertime.Location = new System.Drawing.Point(508, 13);
            this.gbxNewOvertime.Name = "gbxNewOvertime";
            this.gbxNewOvertime.Size = new System.Drawing.Size(154, 133);
            this.gbxNewOvertime.TabIndex = 4;
            this.gbxNewOvertime.TabStop = false;
            this.gbxNewOvertime.Text = "Neue Überstunden";
            // 
            // btnAddOvertime
            // 
            this.btnAddOvertime.Location = new System.Drawing.Point(11, 99);
            this.btnAddOvertime.Name = "btnAddOvertime";
            this.btnAddOvertime.Size = new System.Drawing.Size(137, 23);
            this.btnAddOvertime.TabIndex = 6;
            this.btnAddOvertime.Text = "Stunden hinzufügen";
            this.btnAddOvertime.UseVisualStyleBackColor = true;
            this.btnAddOvertime.Click += new System.EventHandler(this.btnAddOvertime_Click);
            // 
            // tbxNewOvertimeEndTime
            // 
            this.tbxNewOvertimeEndTime.Location = new System.Drawing.Point(85, 73);
            this.tbxNewOvertimeEndTime.Name = "tbxNewOvertimeEndTime";
            this.tbxNewOvertimeEndTime.Size = new System.Drawing.Size(60, 20);
            this.tbxNewOvertimeEndTime.TabIndex = 5;
            this.tbxNewOvertimeEndTime.Text = "HH:MM";
            this.tbxNewOvertimeEndTime.Click += new System.EventHandler(this.tbxNewOvertimeEndTime_Click);
            // 
            // tbxNewOvertimeStartTime
            // 
            this.tbxNewOvertimeStartTime.Location = new System.Drawing.Point(11, 73);
            this.tbxNewOvertimeStartTime.Name = "tbxNewOvertimeStartTime";
            this.tbxNewOvertimeStartTime.Size = new System.Drawing.Size(60, 20);
            this.tbxNewOvertimeStartTime.TabIndex = 4;
            this.tbxNewOvertimeStartTime.Text = "HH:MM";
            this.tbxNewOvertimeStartTime.Click += new System.EventHandler(this.tbxNewOvertimeStartTime_Click);
            // 
            // tbxNewOvertimeDate
            // 
            this.tbxNewOvertimeDate.Location = new System.Drawing.Point(53, 25);
            this.tbxNewOvertimeDate.Name = "tbxNewOvertimeDate";
            this.tbxNewOvertimeDate.Size = new System.Drawing.Size(90, 20);
            this.tbxNewOvertimeDate.TabIndex = 3;
            this.tbxNewOvertimeDate.Text = "DD.MM.YYYY";
            // 
            // lblNewOvertimeStartTime
            // 
            this.lblNewOvertimeStartTime.AutoSize = true;
            this.lblNewOvertimeStartTime.Location = new System.Drawing.Point(8, 57);
            this.lblNewOvertimeStartTime.Name = "lblNewOvertimeStartTime";
            this.lblNewOvertimeStartTime.Size = new System.Drawing.Size(29, 13);
            this.lblNewOvertimeStartTime.TabIndex = 2;
            this.lblNewOvertimeStartTime.Text = "Von:";
            // 
            // lblNewOvertimeDate
            // 
            this.lblNewOvertimeDate.AutoSize = true;
            this.lblNewOvertimeDate.Location = new System.Drawing.Point(6, 28);
            this.lblNewOvertimeDate.Name = "lblNewOvertimeDate";
            this.lblNewOvertimeDate.Size = new System.Drawing.Size(41, 13);
            this.lblNewOvertimeDate.TabIndex = 1;
            this.lblNewOvertimeDate.Text = "Datum:";
            // 
            // lblNewOvertimeEndTime
            // 
            this.lblNewOvertimeEndTime.AutoSize = true;
            this.lblNewOvertimeEndTime.Location = new System.Drawing.Point(82, 57);
            this.lblNewOvertimeEndTime.Name = "lblNewOvertimeEndTime";
            this.lblNewOvertimeEndTime.Size = new System.Drawing.Size(24, 13);
            this.lblNewOvertimeEndTime.TabIndex = 0;
            this.lblNewOvertimeEndTime.Text = "Bis:";
            // 
            // gbxTakeOvertime
            // 
            this.gbxTakeOvertime.Controls.Add(this.btnTakeOvertime);
            this.gbxTakeOvertime.Controls.Add(this.tbxTakeOvertimeEndTime);
            this.gbxTakeOvertime.Controls.Add(this.tbxTakeOvertimeStartTime);
            this.gbxTakeOvertime.Controls.Add(this.tbxTakeOvertimeDate);
            this.gbxTakeOvertime.Controls.Add(this.lblTakeOvertimeStartTime);
            this.gbxTakeOvertime.Controls.Add(this.lblTakeOvertimeDate);
            this.gbxTakeOvertime.Controls.Add(this.lblTakeOvertimeEndTime);
            this.gbxTakeOvertime.Location = new System.Drawing.Point(508, 161);
            this.gbxTakeOvertime.Name = "gbxTakeOvertime";
            this.gbxTakeOvertime.Size = new System.Drawing.Size(154, 129);
            this.gbxTakeOvertime.TabIndex = 6;
            this.gbxTakeOvertime.TabStop = false;
            this.gbxTakeOvertime.Text = "Ausgleich nehmen";
            // 
            // btnTakeOvertime
            // 
            this.btnTakeOvertime.Location = new System.Drawing.Point(11, 99);
            this.btnTakeOvertime.Name = "btnTakeOvertime";
            this.btnTakeOvertime.Size = new System.Drawing.Size(137, 23);
            this.btnTakeOvertime.TabIndex = 7;
            this.btnTakeOvertime.Text = "Stunden nehmen";
            this.btnTakeOvertime.UseVisualStyleBackColor = true;
            this.btnTakeOvertime.Click += new System.EventHandler(this.btnTakeOvertime_Click);
            // 
            // tbxTakeOvertimeEndTime
            // 
            this.tbxTakeOvertimeEndTime.Location = new System.Drawing.Point(85, 73);
            this.tbxTakeOvertimeEndTime.Name = "tbxTakeOvertimeEndTime";
            this.tbxTakeOvertimeEndTime.Size = new System.Drawing.Size(60, 20);
            this.tbxTakeOvertimeEndTime.TabIndex = 5;
            this.tbxTakeOvertimeEndTime.Text = "HH:MM";
            this.tbxTakeOvertimeEndTime.Click += new System.EventHandler(this.tbxTakeOvertimeEndTime_Click);
            // 
            // tbxTakeOvertimeStartTime
            // 
            this.tbxTakeOvertimeStartTime.Location = new System.Drawing.Point(11, 73);
            this.tbxTakeOvertimeStartTime.Name = "tbxTakeOvertimeStartTime";
            this.tbxTakeOvertimeStartTime.Size = new System.Drawing.Size(60, 20);
            this.tbxTakeOvertimeStartTime.TabIndex = 4;
            this.tbxTakeOvertimeStartTime.Text = "HH:MM";
            this.tbxTakeOvertimeStartTime.Click += new System.EventHandler(this.tbxTakeOvertimeStartTime_Click);
            // 
            // tbxTakeOvertimeDate
            // 
            this.tbxTakeOvertimeDate.Location = new System.Drawing.Point(53, 25);
            this.tbxTakeOvertimeDate.Name = "tbxTakeOvertimeDate";
            this.tbxTakeOvertimeDate.Size = new System.Drawing.Size(90, 20);
            this.tbxTakeOvertimeDate.TabIndex = 3;
            this.tbxTakeOvertimeDate.Text = "DD.MM.YYYY";
            // 
            // lblTakeOvertimeStartTime
            // 
            this.lblTakeOvertimeStartTime.AutoSize = true;
            this.lblTakeOvertimeStartTime.Location = new System.Drawing.Point(8, 57);
            this.lblTakeOvertimeStartTime.Name = "lblTakeOvertimeStartTime";
            this.lblTakeOvertimeStartTime.Size = new System.Drawing.Size(29, 13);
            this.lblTakeOvertimeStartTime.TabIndex = 2;
            this.lblTakeOvertimeStartTime.Text = "Von:";
            // 
            // lblTakeOvertimeDate
            // 
            this.lblTakeOvertimeDate.AutoSize = true;
            this.lblTakeOvertimeDate.Location = new System.Drawing.Point(6, 28);
            this.lblTakeOvertimeDate.Name = "lblTakeOvertimeDate";
            this.lblTakeOvertimeDate.Size = new System.Drawing.Size(41, 13);
            this.lblTakeOvertimeDate.TabIndex = 1;
            this.lblTakeOvertimeDate.Text = "Datum:";
            // 
            // lblTakeOvertimeEndTime
            // 
            this.lblTakeOvertimeEndTime.AutoSize = true;
            this.lblTakeOvertimeEndTime.Location = new System.Drawing.Point(82, 57);
            this.lblTakeOvertimeEndTime.Name = "lblTakeOvertimeEndTime";
            this.lblTakeOvertimeEndTime.Size = new System.Drawing.Size(24, 13);
            this.lblTakeOvertimeEndTime.TabIndex = 0;
            this.lblTakeOvertimeEndTime.Text = "Bis:";
            // 
            // lblAvailableOvertime
            // 
            this.lblAvailableOvertime.AutoSize = true;
            this.lblAvailableOvertime.Location = new System.Drawing.Point(505, 309);
            this.lblAvailableOvertime.Name = "lblAvailableOvertime";
            this.lblAvailableOvertime.Size = new System.Drawing.Size(148, 13);
            this.lblAvailableOvertime.TabIndex = 7;
            this.lblAvailableOvertime.Text = "Noch vorhandener Ausgleich:";
            // 
            // tbxAvailableOvertime
            // 
            this.tbxAvailableOvertime.Location = new System.Drawing.Point(508, 325);
            this.tbxAvailableOvertime.Name = "tbxAvailableOvertime";
            this.tbxAvailableOvertime.ReadOnly = true;
            this.tbxAvailableOvertime.Size = new System.Drawing.Size(154, 20);
            this.tbxAvailableOvertime.TabIndex = 8;
            this.tbxAvailableOvertime.Text = "0";
            // 
            // Overtime_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 365);
            this.Controls.Add(this.tbxAvailableOvertime);
            this.Controls.Add(this.lblAvailableOvertime);
            this.Controls.Add(this.gbxTakeOvertime);
            this.Controls.Add(this.gbxNewOvertime);
            this.Controls.Add(this.lbxTakenOvertime);
            this.Controls.Add(this.lbxCurrentOvertime);
            this.Controls.Add(this.lblTakenOvertime);
            this.Controls.Add(this.lblCurrentOvertime);
            this.Name = "Overtime_Form";
            this.Text = "Überstunden Übersicht";
            this.gbxNewOvertime.ResumeLayout(false);
            this.gbxNewOvertime.PerformLayout();
            this.gbxTakeOvertime.ResumeLayout(false);
            this.gbxTakeOvertime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentOvertime;
        private System.Windows.Forms.Label lblTakenOvertime;
        private System.Windows.Forms.ListBox lbxCurrentOvertime;
        private System.Windows.Forms.ListBox lbxTakenOvertime;
        private System.Windows.Forms.GroupBox gbxNewOvertime;
        private System.Windows.Forms.TextBox tbxNewOvertimeEndTime;
        private System.Windows.Forms.TextBox tbxNewOvertimeStartTime;
        private System.Windows.Forms.TextBox tbxNewOvertimeDate;
        private System.Windows.Forms.Label lblNewOvertimeStartTime;
        private System.Windows.Forms.Label lblNewOvertimeDate;
        private System.Windows.Forms.Label lblNewOvertimeEndTime;
        private System.Windows.Forms.GroupBox gbxTakeOvertime;
        private System.Windows.Forms.TextBox tbxTakeOvertimeEndTime;
        private System.Windows.Forms.TextBox tbxTakeOvertimeStartTime;
        private System.Windows.Forms.TextBox tbxTakeOvertimeDate;
        private System.Windows.Forms.Label lblTakeOvertimeStartTime;
        private System.Windows.Forms.Label lblTakeOvertimeDate;
        private System.Windows.Forms.Label lblTakeOvertimeEndTime;
        private System.Windows.Forms.Label lblAvailableOvertime;
        private System.Windows.Forms.TextBox tbxAvailableOvertime;
        private System.Windows.Forms.Button btnAddOvertime;
        private System.Windows.Forms.Button btnTakeOvertime;
    }
}

