namespace Varianta7.UserControls
{
    partial class ProgramareControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNumeClient;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblDataProgramarii;
        private System.Windows.Forms.Label lblOraProgramarii;
        private System.Windows.Forms.Label lblServiciu;
        private System.Windows.Forms.Label lblMester;

        private System.Windows.Forms.Label lblNumeClientValue;
        private System.Windows.Forms.Label lblTelefonValue;
        private System.Windows.Forms.Label lblDataProgramariiValue;
        private System.Windows.Forms.Label lblOraProgramariiValue;
        private System.Windows.Forms.Label lblServiciuValue;
        private System.Windows.Forms.Label lblMesterValue;
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumeClient = new Label();
            lblTelefon = new Label();
            lblDataProgramarii = new Label();
            lblOraProgramarii = new Label();
            lblServiciu = new Label();
            lblMester = new Label();
            lblNumeClientValue = new Label();
            lblTelefonValue = new Label();
            lblDataProgramariiValue = new Label();
            lblOraProgramariiValue = new Label();
            lblServiciuValue = new Label();
            lblMesterValue = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // lblNumeClient
            // 
            lblNumeClient.Location = new Point(10, 10);
            lblNumeClient.Name = "lblNumeClient";
            lblNumeClient.Size = new Size(100, 20);
            lblNumeClient.TabIndex = 0;
            lblNumeClient.Text = "Nume Client:";
            // 
            // lblTelefon
            // 
            lblTelefon.Location = new Point(10, 40);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(100, 20);
            lblTelefon.TabIndex = 1;
            lblTelefon.Text = "Telefon:";
            // 
            // lblDataProgramarii
            // 
            lblDataProgramarii.Location = new Point(10, 70);
            lblDataProgramarii.Name = "lblDataProgramarii";
            lblDataProgramarii.Size = new Size(100, 20);
            lblDataProgramarii.TabIndex = 2;
            lblDataProgramarii.Text = "Data Programarii:";
            // 
            // lblOraProgramarii
            // 
            lblOraProgramarii.Location = new Point(10, 100);
            lblOraProgramarii.Name = "lblOraProgramarii";
            lblOraProgramarii.Size = new Size(100, 20);
            lblOraProgramarii.TabIndex = 3;
            lblOraProgramarii.Text = "Ora Programarii:";
            // 
            // lblServiciu
            // 
            lblServiciu.Location = new Point(10, 130);
            lblServiciu.Name = "lblServiciu";
            lblServiciu.Size = new Size(100, 20);
            lblServiciu.TabIndex = 4;
            lblServiciu.Text = "Serviciu:";
            // 
            // lblMester
            // 
            lblMester.Location = new Point(10, 160);
            lblMester.Name = "lblMester";
            lblMester.Size = new Size(100, 20);
            lblMester.TabIndex = 5;
            lblMester.Text = "Mester:";
            // 
            // lblNumeClientValue
            // 
            lblNumeClientValue.Location = new Point(120, 10);
            lblNumeClientValue.Name = "lblNumeClientValue";
            lblNumeClientValue.Size = new Size(200, 20);
            lblNumeClientValue.TabIndex = 6;
            // 
            // lblTelefonValue
            // 
            lblTelefonValue.Location = new Point(120, 40);
            lblTelefonValue.Name = "lblTelefonValue";
            lblTelefonValue.Size = new Size(200, 20);
            lblTelefonValue.TabIndex = 7;
            // 
            // lblDataProgramariiValue
            // 
            lblDataProgramariiValue.Location = new Point(120, 70);
            lblDataProgramariiValue.Name = "lblDataProgramariiValue";
            lblDataProgramariiValue.Size = new Size(200, 20);
            lblDataProgramariiValue.TabIndex = 8;
            // 
            // lblOraProgramariiValue
            // 
            lblOraProgramariiValue.Location = new Point(120, 100);
            lblOraProgramariiValue.Name = "lblOraProgramariiValue";
            lblOraProgramariiValue.Size = new Size(200, 20);
            lblOraProgramariiValue.TabIndex = 9;
            // 
            // lblServiciuValue
            // 
            lblServiciuValue.Location = new Point(120, 130);
            lblServiciuValue.Name = "lblServiciuValue";
            lblServiciuValue.Size = new Size(200, 20);
            lblServiciuValue.TabIndex = 10;
            // 
            // lblMesterValue
            // 
            lblMesterValue.Location = new Point(120, 160);
            lblMesterValue.Name = "lblMesterValue";
            lblMesterValue.Size = new Size(200, 20);
            lblMesterValue.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(422, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(422, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // ProgramareControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lblNumeClient);
            Controls.Add(lblTelefon);
            Controls.Add(lblDataProgramarii);
            Controls.Add(lblOraProgramarii);
            Controls.Add(lblServiciu);
            Controls.Add(lblMester);
            Controls.Add(lblNumeClientValue);
            Controls.Add(lblTelefonValue);
            Controls.Add(lblDataProgramariiValue);
            Controls.Add(lblOraProgramariiValue);
            Controls.Add(lblServiciuValue);
            Controls.Add(lblMesterValue);
            Name = "ProgramareControl";
            Size = new Size(500, 194);
            ResumeLayout(false);
        }

        #endregion

        public Button btnDelete;
        public Button btnEdit;
    }
}
