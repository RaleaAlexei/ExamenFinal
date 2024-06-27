using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Varianta7.Classes;

namespace Varianta7.Forms
{
    internal partial class FormProgramari : Form
    {
        private Programari currentProgramare;
        public FormProgramari()
        {
            InitializeComponent();
            PopulateServiciiComboBox();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void InitializeNewProgramare()
        {
            currentProgramare = new Programari();
        }
        public void InitializeEditProgramare(Programari programare)
        {
            currentProgramare = programare;
            LoadProgramareData(programare);
        }
        private void LoadProgramareData(Programari programare)
        {
            txtNumeClient.Text = programare.NumeClient;
            txtTelefon.Text = programare.Telefon;
            dtpDataProgramarii.Value = programare.DataProgramarii;
            dtpOraProgramarii.Value = DateTime.Today.Add(programare.OraProgramarii);
            cmbServiciu.SelectedValue = programare.CodServiciu;
            txtMester.Text = programare.Mester;
        }
        private void PopulateServiciiComboBox()
        {
            using (var context = new SalonContext())
            {
                cmbServiciu.DataSource = context.Servicii.ToList();
                cmbServiciu.DisplayMember = "Denumirea";
                cmbServiciu.ValueMember = "CodServiciu";
            }
        }
        public void FromProgramari(Programari programare)
        {
            LoadProgramareData(programare);
        }

        public Programari ToProgramari()
        {
            Programari programare = new Programari
            {
                NumeClient = txtNumeClient.Text.Trim(),
                Telefon = txtTelefon.Text.Trim(),
                DataProgramarii = dtpDataProgramarii.Value.Date,
                OraProgramarii = dtpOraProgramarii.Value.TimeOfDay,
                CodServiciu = (int)cmbServiciu.SelectedValue,
                Mester = txtMester.Text.Trim()
            };
            return programare;
        }
    }
}
