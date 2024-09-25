using Model;
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
    public partial class FrmBloque : Form
    {
        public Model.Bloque Bloque;
        public FrmBloque()
        {
            InitializeComponent();
            this.Bloque = new Model.Bloque();
            this.Cargar();
        }
        public FrmBloque(Model.Bloque bloque)
        {
            InitializeComponent();
            this.Bloque = bloque;
            this.Cargar();
        }
        private void Cargar()
        {
            this.bloqueBindingSource.Clear();
            this.bloqueBindingSource.DataSource = this.Bloque;
            this.temperaturaBindingSource.Clear();
            this.temperaturaBindingSource.DataSource = this.Bloque.Lecturas;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTemperatura_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            if (frm.ShowDialog() == DialogResult.OK) {
                Model.Lecturas a = new Model.Lecturas();
                a.Descripcion = frm.IdTemperatura;
                a.Temperatura = frm.Temperatura;
                this.temperaturaBindingSource.EndEdit();
                ((List<Model.Lecturas>)(this.temperaturaBindingSource.DataSource)).Add(a);
                this.temperaturaBindingSource.ResetBindings(true);
            } else {
                this.Cargar();
            
            }
        }
    }
}
