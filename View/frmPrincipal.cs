using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Win.Gauges.Linear;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            LinearGauge? linearGauge = this.gCelsius.Gauges[0] as LinearGauge;
            //linearGauge.AddDefaultElements();
            LinearScaleComponent scale = linearGauge!.Scales[0];
            scale.Value = 20;
            this.gCelsius.Parent = this;
        }
    }
}