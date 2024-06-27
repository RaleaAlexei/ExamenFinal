namespace Varianta7.UserControls
{
    partial class ServiciuControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// 
        private Label label1;
        private Label label2;
        private Label label3;
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            lblDurata = new Label();
            lblPret = new Label();
            lblDenumire = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Denumire:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 40);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Pret: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 70);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Durata: ";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(422, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(422, 42);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblDurata
            // 
            lblDurata.AutoSize = true;
            lblDurata.Location = new Point(106, 70);
            lblDurata.Name = "lblDurata";
            lblDurata.Size = new Size(54, 20);
            lblDurata.TabIndex = 7;
            lblDurata.Text = "Durata";
            // 
            // lblPret
            // 
            lblPret.AutoSize = true;
            lblPret.Location = new Point(106, 40);
            lblPret.Name = "lblPret";
            lblPret.Size = new Size(35, 20);
            lblPret.TabIndex = 6;
            lblPret.Text = "Pret";
            // 
            // lblDenumire
            // 
            lblDenumire.AutoSize = true;
            lblDenumire.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDenumire.Location = new Point(106, 10);
            lblDenumire.Name = "lblDenumire";
            lblDenumire.Size = new Size(86, 21);
            lblDenumire.TabIndex = 5;
            lblDenumire.Text = "Denumire";
            // 
            // ServiciuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(lblDurata);
            Controls.Add(lblPret);
            Controls.Add(lblDenumire);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ServiciuControl";
            Size = new Size(500, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDurata;
        private Label lblPret;
        private Label lblDenumire;
        public Button btnEdit;
        public Button btnDelete;
    }
}
