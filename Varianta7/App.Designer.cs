namespace Varianta7
{
    partial class App
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
            tabControl = new TabControl();
            tabServicii = new TabPage();
            tbxQueryServiciu = new TextBox();
            btnCautaServiciu = new Button();
            btnAddServiciu = new Button();
            flpServicii = new FlowLayoutPanel();
            tabProgramari = new TabPage();
            tbxQuery = new TextBox();
            btnCauta = new Button();
            btnAddProgramari = new Button();
            flpProgramari = new FlowLayoutPanel();
            tabRapoarte = new TabPage();
            lblRaport = new Label();
            tabControl.SuspendLayout();
            tabServicii.SuspendLayout();
            tabProgramari.SuspendLayout();
            tabRapoarte.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabServicii);
            tabControl.Controls.Add(tabProgramari);
            tabControl.Controls.Add(tabRapoarte);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(534, 361);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabServicii
            // 
            tabServicii.Controls.Add(tbxQueryServiciu);
            tabServicii.Controls.Add(btnCautaServiciu);
            tabServicii.Controls.Add(btnAddServiciu);
            tabServicii.Controls.Add(flpServicii);
            tabServicii.Location = new Point(4, 29);
            tabServicii.Name = "tabServicii";
            tabServicii.Padding = new Padding(3);
            tabServicii.Size = new Size(526, 328);
            tabServicii.TabIndex = 0;
            tabServicii.Text = "Servicii";
            tabServicii.UseVisualStyleBackColor = true;
            // 
            // tbxQueryServiciu
            // 
            tbxQueryServiciu.Location = new Point(6, 8);
            tbxQueryServiciu.Name = "tbxQueryServiciu";
            tbxQueryServiciu.Size = new Size(181, 27);
            tbxQueryServiciu.TabIndex = 7;
            // 
            // btnCautaServiciu
            // 
            btnCautaServiciu.Location = new Point(193, 6);
            btnCautaServiciu.Name = "btnCautaServiciu";
            btnCautaServiciu.Size = new Size(75, 30);
            btnCautaServiciu.TabIndex = 6;
            btnCautaServiciu.Text = "Cauta";
            btnCautaServiciu.UseVisualStyleBackColor = true;
            btnCautaServiciu.Click += btnCautaServiciu_Click;
            // 
            // btnAddServiciu
            // 
            btnAddServiciu.Location = new Point(443, 6);
            btnAddServiciu.Name = "btnAddServiciu";
            btnAddServiciu.Size = new Size(75, 30);
            btnAddServiciu.TabIndex = 1;
            btnAddServiciu.Text = "Adauga";
            btnAddServiciu.UseVisualStyleBackColor = true;
            btnAddServiciu.Click += btnAddServiciu_Click;
            // 
            // flpServicii
            // 
            flpServicii.BackColor = Color.Transparent;
            flpServicii.Dock = DockStyle.Bottom;
            flpServicii.FlowDirection = FlowDirection.TopDown;
            flpServicii.Location = new Point(3, 42);
            flpServicii.Name = "flpServicii";
            flpServicii.Size = new Size(520, 283);
            flpServicii.TabIndex = 0;
            flpServicii.WrapContents = false;
            // 
            // tabProgramari
            // 
            tabProgramari.Controls.Add(tbxQuery);
            tabProgramari.Controls.Add(btnCauta);
            tabProgramari.Controls.Add(btnAddProgramari);
            tabProgramari.Controls.Add(flpProgramari);
            tabProgramari.Location = new Point(4, 29);
            tabProgramari.Name = "tabProgramari";
            tabProgramari.Padding = new Padding(3);
            tabProgramari.Size = new Size(526, 328);
            tabProgramari.TabIndex = 1;
            tabProgramari.Text = "Programari";
            tabProgramari.UseVisualStyleBackColor = true;
            // 
            // tbxQuery
            // 
            tbxQuery.Location = new Point(8, 8);
            tbxQuery.Name = "tbxQuery";
            tbxQuery.Size = new Size(181, 27);
            tbxQuery.TabIndex = 5;
            // 
            // btnCauta
            // 
            btnCauta.Location = new Point(195, 6);
            btnCauta.Name = "btnCauta";
            btnCauta.Size = new Size(75, 30);
            btnCauta.TabIndex = 4;
            btnCauta.Text = "Cauta";
            btnCauta.UseVisualStyleBackColor = true;
            btnCauta.Click += btnCauta_Click;
            // 
            // btnAddProgramari
            // 
            btnAddProgramari.Location = new Point(443, 5);
            btnAddProgramari.Name = "btnAddProgramari";
            btnAddProgramari.Size = new Size(75, 30);
            btnAddProgramari.TabIndex = 3;
            btnAddProgramari.Text = "Adauga";
            btnAddProgramari.UseVisualStyleBackColor = true;
            btnAddProgramari.Click += btnAddProgramari_Click;
            // 
            // flpProgramari
            // 
            flpProgramari.BackColor = Color.Transparent;
            flpProgramari.Dock = DockStyle.Bottom;
            flpProgramari.FlowDirection = FlowDirection.TopDown;
            flpProgramari.Location = new Point(3, 42);
            flpProgramari.Name = "flpProgramari";
            flpProgramari.Size = new Size(520, 283);
            flpProgramari.TabIndex = 2;
            flpProgramari.WrapContents = false;
            // 
            // tabRapoarte
            // 
            tabRapoarte.Controls.Add(lblRaport);
            tabRapoarte.Location = new Point(4, 29);
            tabRapoarte.Name = "tabRapoarte";
            tabRapoarte.Size = new Size(526, 328);
            tabRapoarte.TabIndex = 2;
            tabRapoarte.Text = "Rapoarte";
            tabRapoarte.UseVisualStyleBackColor = true;
            // 
            // lblRaport
            // 
            lblRaport.AutoSize = true;
            lblRaport.Location = new Point(8, 9);
            lblRaport.Name = "lblRaport";
            lblRaport.Size = new Size(50, 20);
            lblRaport.TabIndex = 0;
            lblRaport.Text = "label1";
            lblRaport.Click += lblRaport_Click;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 361);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "App";
            Text = "Salon";
            tabControl.ResumeLayout(false);
            tabServicii.ResumeLayout(false);
            tabServicii.PerformLayout();
            tabProgramari.ResumeLayout(false);
            tabProgramari.PerformLayout();
            tabRapoarte.ResumeLayout(false);
            tabRapoarte.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabServicii;
        private FlowLayoutPanel flpServicii;
        private Button btnAddServiciu;
        private TabPage tabProgramari;
        private TabPage tabPage1;
        private Button btnAddProgramari;
        private FlowLayoutPanel flpProgramari;
        private TextBox tbxQuery;
        private Button btnCauta;
        private TextBox tbxQueryServiciu;
        private Button btnCautaServiciu;
        private TabPage tabRapoarte;
        private Label lblRaport;
    }
}
