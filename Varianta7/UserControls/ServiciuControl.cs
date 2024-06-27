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
    internal partial class ServiciuControl : UserControl
    {
        public ServiciuControl(Serviciu serviciu)
        {
            InitializeComponent();
            this.lblDenumire.Text = serviciu.Denumirea;
            this.lblDurata.Text = serviciu.Durata.ToString();
            this.lblPret.Text = serviciu.Pret.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
