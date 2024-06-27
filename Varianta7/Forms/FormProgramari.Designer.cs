namespace Varianta7.Forms
{
    partial class FormProgramari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNumeClient;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.DateTimePicker dtpDataProgramarii;
        private System.Windows.Forms.ComboBox cmbServiciu;
        private System.Windows.Forms.TextBox txtMester;
        private Label lblNumeClient;
        private Label lblTelefon;
        private Label lblDataProgramarii;
        private Label lblServiciu;
        private Label lblMester;
        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumeClient = new TextBox();
            txtTelefon = new TextBox();
            dtpDataProgramarii = new DateTimePicker();
            cmbServiciu = new ComboBox();
            txtMester = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblDataProgramarii = new Label();
            lblMester = new Label();
            lblNumeClient = new Label();
            lblServiciu = new Label();
            lblTelefon = new Label();
            label1 = new Label();
            dtpOraProgramarii = new DateTimePicker();
            SuspendLayout();
            // 
            // txtNumeClient
            // 
            txtNumeClient.Location = new Point(100, 24);
            txtNumeClient.Name = "txtNumeClient";
            txtNumeClient.Size = new Size(200, 27);
            txtNumeClient.TabIndex = 6;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(98, 57);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 27);
            txtTelefon.TabIndex = 7;
            // 
            // dtpDataProgramarii
            // 
            dtpDataProgramarii.Format = DateTimePickerFormat.Short;
            dtpDataProgramarii.Location = new Point(100, 90);
            dtpDataProgramarii.Name = "dtpDataProgramarii";
            dtpDataProgramarii.Size = new Size(200, 27);
            dtpDataProgramarii.TabIndex = 8;
            // 
            // cmbServiciu
            // 
            cmbServiciu.Location = new Point(100, 156);
            cmbServiciu.Name = "cmbServiciu";
            cmbServiciu.Size = new Size(200, 28);
            cmbServiciu.TabIndex = 10;
            // 
            // txtMester
            // 
            txtMester.Location = new Point(100, 190);
            txtMester.Name = "txtMester";
            txtMester.Size = new Size(200, 27);
            txtMester.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 234);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 35);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(236, 234);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 35);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblDataProgramarii
            // 
            lblDataProgramarii.Location = new Point(12, 95);
            lblDataProgramarii.Name = "lblDataProgramarii";
            lblDataProgramarii.Size = new Size(80, 20);
            lblDataProgramarii.TabIndex = 2;
            lblDataProgramarii.Text = "Data Programării:";
            // 
            // lblMester
            // 
            lblMester.Location = new Point(12, 193);
            lblMester.Name = "lblMester";
            lblMester.Size = new Size(80, 20);
            lblMester.TabIndex = 5;
            lblMester.Text = "Meșter:";
            // 
            // lblNumeClient
            // 
            lblNumeClient.Location = new Point(12, 27);
            lblNumeClient.Name = "lblNumeClient";
            lblNumeClient.Size = new Size(80, 20);
            lblNumeClient.TabIndex = 0;
            lblNumeClient.Text = "Nume Client:";
            // 
            // lblServiciu
            // 
            lblServiciu.Location = new Point(12, 159);
            lblServiciu.Name = "lblServiciu";
            lblServiciu.Size = new Size(80, 20);
            lblServiciu.TabIndex = 4;
            lblServiciu.Text = "Serviciu:";
            // 
            // lblTelefon
            // 
            lblTelefon.Location = new Point(12, 60);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(80, 20);
            lblTelefon.TabIndex = 1;
            lblTelefon.Text = "Telefon:";
            // 
            // label1
            // 
            label1.Location = new Point(10, 128);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 14;
            label1.Text = "Data Programării:";
            // 
            // dtpOraProgramarii
            // 
            dtpOraProgramarii.Format = DateTimePickerFormat.Time;
            dtpOraProgramarii.Location = new Point(100, 123);
            dtpOraProgramarii.Name = "dtpOraProgramarii";
            dtpOraProgramarii.Size = new Size(200, 27);
            dtpOraProgramarii.TabIndex = 15;
            // 
            // FormProgramari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 280);
            Controls.Add(label1);
            Controls.Add(dtpOraProgramarii);
            Controls.Add(lblNumeClient);
            Controls.Add(lblTelefon);
            Controls.Add(lblDataProgramarii);
            Controls.Add(lblServiciu);
            Controls.Add(lblMester);
            Controls.Add(txtNumeClient);
            Controls.Add(txtTelefon);
            Controls.Add(dtpDataProgramarii);
            Controls.Add(cmbServiciu);
            Controls.Add(txtMester);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "FormProgramari";
            Text = "FormProgramari";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpOraProgramarii;
        public Button btnSave;
        public Button btnCancel;
    }
}