using Controller;
using Model;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        private readonly GestorTemperatura GestorTemperatura;
        public Form1()
        {
            InitializeComponent();
            this.GestorTemperatura = new GestorTemperatura();
            this.CagarDatos();
        }
        private void CagarDatos()
        {
            this.bloqueBindingSource.Clear();
            var bloque = new Bloque();
            bloque.Id = 1;
            bloque.Nombre = "Boque 1";
            Model.Lecturas a = new Model.Lecturas();
            a.Descripcion = "C";
            a.Temperatura = 20;
            bloque.Lecturas.Add(a);
            this.bloqueBindingSource.DataSource = new List<Model.Bloque>() { bloque, new Model.Bloque(2, "Boque 2") };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private Model.Bloque? GetBloque()
        {
            return (this.bloqueBindingSource.Current != null) ? (Model.Bloque)(this.bloqueBindingSource.Current) : null;
        }

        private void ckCelsius_Click(object sender, EventArgs e)
        {
            // Scenario 1: Using Celsius thermometer
            // this.GetTemperatura(1);
        }

        private void ckFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            // Scenario 2: Using Fahrenheit thermometer
            //this.GetTemperatura(2);

        }

        private void dgLista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var bloque = this.GetBloque() ?? null;
            FrmBloque frm = new FrmBloque(bloque!);
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                this.CagarDatos();
            }
        }

        private void dgLista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var bloque = this.GetBloque() ?? null;
        }
        private void nuevo()
        {
            var bloque = new Bloque();
            bloque.Id = ((List<Model.Bloque>)(this.bloqueBindingSource.DataSource)).Count>0? ((List<Model.Bloque>)(this.bloqueBindingSource.DataSource)).Max(x=>x.Id)+1:0;
            bloque.Nombre = "";
             //var bloque = this.GetBloque() ?? null;
            FrmBloque frm = new FrmBloque(bloque);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.bloqueBindingSource.EndEdit();
                ((List<Model.Bloque>)(this.bloqueBindingSource.DataSource)).Add(frm.Bloque);
                this.bloqueBindingSource.ResetBindings(true);
            }
            else
            {
                this.CagarDatos();
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.nuevo();
        }
    }
}
