namespace Varianta7.Forms
{
    partial class FormServiciu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtDurata;
        private System.Windows.Forms.Button btnCancel;
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDenumire = new Label();
            txtDenumire = new TextBox();
            lblPret = new Label();
            txtPret = new TextBox();
            lblDurata = new Label();
            txtDurata = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblDenumire
            // 
            lblDenumire.AutoSize = true;
            lblDenumire.Location = new Point(11, 22);
            lblDenumire.Name = "lblDenumire";
            lblDenumire.Size = new Size(77, 20);
            lblDenumire.TabIndex = 0;
            lblDenumire.Text = "Denumire:";
            // 
            // txtDenumire
            // 
            txtDenumire.Location = new Point(94, 19);
            txtDenumire.Name = "txtDenumire";
            txtDenumire.Size = new Size(178, 27);
            txtDenumire.TabIndex = 1;
            // 
            // lblPret
            // 
            lblPret.AutoSize = true;
            lblPret.Location = new Point(13, 55);
            lblPret.Name = "lblPret";
            lblPret.Size = new Size(38, 20);
            lblPret.TabIndex = 2;
            lblPret.Text = "Pret:";
            // 
            // txtPret
            // 
            txtPret.Location = new Point(94, 52);
            txtPret.Name = "txtPret";
            txtPret.Size = new Size(100, 27);
            txtPret.TabIndex = 3;
            // 
            // lblDurata
            // 
            lblDurata.AutoSize = true;
            lblDurata.Location = new Point(13, 88);
            lblDurata.Name = "lblDurata";
            lblDurata.Size = new Size(57, 20);
            lblDurata.TabIndex = 4;
            lblDurata.Text = "Durata:";
            // 
            // txtDurata
            // 
            txtDurata.Location = new Point(94, 85);
            txtDurata.Name = "txtDurata";
            txtDurata.Size = new Size(100, 27);
            txtDurata.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(11, 125);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Adauga";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(197, 125);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Anulare";
            btnCancel.Click += btnCancel_Click;
            // 
            // FormServiciu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 181);
            Controls.Add(lblDenumire);
            Controls.Add(txtDenumire);
            Controls.Add(lblPret);
            Controls.Add(txtPret);
            Controls.Add(lblDurata);
            Controls.Add(txtDurata);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "FormServiciu";
            Text = "Adauga serviciu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Button btnSave;
    }
}