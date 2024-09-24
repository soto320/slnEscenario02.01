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
            this.bloqueBindingSource.DataSource = new List<Model.Bloque>() { new Bloque(1, "Boque 1"), new Bloque(2, "Boque 2") };
        }
        public void MostrarDatos(double temperatura)
        {
            // Debug.Write($"La temperatura actual es: {temperatura}°");
            this.lblRespuesta.Text = $"La temperatura actual es: {temperatura}°";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private Model.Bloque? GetBloque()
        {
            return (this.bloqueBindingSource.Current != null) ? (Model.Bloque)(this.bloqueBindingSource.Current) : null;
        }
        private void GetTemperatura(int temp)
        {

            switch (temp)
            {
                case 1:
                    if (this.ckCelsius.Checked)
                    {
                        this.ckFahrenheit.Checked = false;
                        var termometroCelsius = new TermometroCelsius();
                        var adaptadorCelsius = new AdaptadorCelsius(termometroCelsius);
                        this.GestorTemperatura.AgregarDispositivo(adaptadorCelsius);
                        double temperaturaCelsius = this.GestorTemperatura.ObtenerTemperatura();
                        this.MostrarDatos(temperaturaCelsius);
                    }
                    break;
                case 2:
                    if (this.ckFahrenheit.Checked)
                    {
                        this.ckCelsius.Checked = false;
                        var termometroFahrenheit = new TermometroFahrenheit();
                        var adaptadorFahrenheit = new AdaptadorFahrenheit(termometroFahrenheit);
                        this.GestorTemperatura.AgregarDispositivo(adaptadorFahrenheit);
                        double temperaturaFahrenheit = this.GestorTemperatura.ObtenerTemperatura();
                        this.MostrarDatos(temperaturaFahrenheit);
                    }
                    break;
                default:
                    this.lblRespuesta.Text = $"Parametro: {temp} no implementado";
                    break;
            }
        }
        private void ckCelsius_Click(object sender, EventArgs e)
        {
            // Scenario 1: Using Celsius thermometer
            this.GetTemperatura(1);
        }

        private void ckFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            // Scenario 2: Using Fahrenheit thermometer
            this.GetTemperatura(2);

        }

        private void dgLista_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var bloque = this.GetBloque() ?? null;
            FrmBloque frm =new FrmBloque(bloque!);
            if (frm.ShowDialog() == DialogResult.OK) {
            
            } else {
                this.CagarDatos();
            }
        }

        private void dgLista_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var bloque = this.GetBloque() ?? null;
        }
    }
}
