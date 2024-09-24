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
        private Model.Bloque Bloque;
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
        private void Cargar() {
            this.bloqueBindingSource.Clear();
            this.bloqueBindingSource.DataSource = this.Bloque;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
