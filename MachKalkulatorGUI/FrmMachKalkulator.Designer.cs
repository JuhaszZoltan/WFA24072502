namespace MachKalkulatorGUI
{
    partial class FrmMachKalkulator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            c = new Label();
            tbxStatikus = new TextBox();
            btnSzamol = new Button();
            lsbEredmenyek = new ListBox();
            lblUI02 = new Label();
            lblUI03 = new Label();
            tbxTorlo = new TextBox();
            SuspendLayout();
            // 
            // c
            // 
            c.AutoSize = true;
            c.Location = new Point(12, 21);
            c.Name = "c";
            c.Size = new Size(97, 20);
            c.TabIndex = 0;
            c.Text = "Torlónyomás:";
            // 
            // tbxStatikus
            // 
            tbxStatikus.Location = new Point(150, 51);
            tbxStatikus.Name = "tbxStatikus";
            tbxStatikus.Size = new Size(142, 27);
            tbxStatikus.TabIndex = 1;
            // 
            // btnSzamol
            // 
            btnSzamol.Location = new Point(311, 18);
            btnSzamol.Name = "btnSzamol";
            btnSzamol.Size = new Size(99, 60);
            btnSzamol.TabIndex = 2;
            btnSzamol.Text = "Számol";
            btnSzamol.UseVisualStyleBackColor = true;
            // 
            // lsberedmenyek
            // 
            lsbEredmenyek.FormattingEnabled = true;
            lsbEredmenyek.Location = new Point(12, 117);
            lsbEredmenyek.Name = "lsberedmenyek";
            lsbEredmenyek.Size = new Size(398, 424);
            lsbEredmenyek.TabIndex = 3;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(12, 54);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(118, 20);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Statikus nyomás:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(12, 94);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(93, 20);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "Eredmények:";
            // 
            // tbxTorlo
            // 
            tbxTorlo.Location = new Point(150, 18);
            tbxTorlo.Name = "tbxTorlo";
            tbxTorlo.Size = new Size(142, 27);
            tbxTorlo.TabIndex = 1;
            // 
            // FrmMachKalkulator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 553);
            Controls.Add(lsbEredmenyek);
            Controls.Add(btnSzamol);
            Controls.Add(tbxTorlo);
            Controls.Add(tbxStatikus);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(c);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMachKalkulator";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Mach-szám Kalkulátor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label c;
        private TextBox tbxStatikus;
        private Button btnSzamol;
        private ListBox lsbEredmenyek;
        private Label lblUI02;
        private Label lblUI03;
        private TextBox tbxTorlo;
    }
}
