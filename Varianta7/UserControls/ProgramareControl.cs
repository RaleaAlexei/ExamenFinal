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

namespace Varianta7.UserControls
{
    internal partial class ProgramareControl : UserControl
    {
        private Programari programari;
        public ProgramareControl(Programari programari)
        {
            InitializeComponent();
            this.programari = programari;
            lblNumeClientValue.Text = programari.NumeClient;
            lblTelefonValue.Text = programari.Telefon;
            lblDataProgramariiValue.Text = programari.DataProgramarii.ToShortDateString();
            lblOraProgramariiValue.Text = programari.OraProgramarii.ToString(@"hh\:mm");
            lblServiciuValue.Text = programari.Serviciu.Denumirea;
            lblMesterValue.Text = programari.Mester;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
