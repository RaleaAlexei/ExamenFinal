using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Varianta7.Classes;

namespace Varianta7.Forms
{
    internal partial class FormServiciu : Form
    {
        private int CodServiciu;
        public FormServiciu()
        {
            InitializeComponent();
            Utils.AttachNumericInputEvent(txtDurata);
            Utils.AttachDecimalInputEvent(txtPret);
        }
        public void FromServiciu(Serviciu s)
        {
            CodServiciu = s.CodServiciu;
            txtDenumire.Text = s.Denumirea;
            txtPret.Text = s.Pret.ToString("0.00", CultureInfo.InvariantCulture);
            txtDurata.Text = s.Durata.ToString();
        }
        public Serviciu ToServiciu()
        {
            return new()
            {
                CodServiciu = this.CodServiciu,
                Denumirea = txtDenumire.Text,
                Pret = decimal.Parse(txtPret.Text, CultureInfo.InvariantCulture),
                Durata = Convert.ToInt32(txtDurata.Text)
            };

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
