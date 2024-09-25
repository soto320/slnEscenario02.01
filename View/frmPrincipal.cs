using Controller;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Win.Gauges.Linear;
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
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        private readonly GestorTemperatura GestorTemperatura;
        public double Temperatura;
        public string IdTemperatura;
        public frmPrincipal()
        {
            InitializeComponent();
            this.GestorTemperatura = new GestorTemperatura();
            this.Temperatura = 0;
            this.IdTemperatura = "C";
            this.Cargar(0);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

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
                        this.Temperatura = this.GestorTemperatura.ObtenerTemperatura();
                        MostrarDatos(this.Temperatura);
                        Cargar((float)(this.Temperatura));
                        this.IdTemperatura = "C";
                    }
                    break;
                case 2:
                    if (this.ckFahrenheit.Checked)
                    {
                        this.ckCelsius.Checked = false;
                        var termometroFahrenheit = new TermometroFahrenheit();
                        var adaptadorFahrenheit = new AdaptadorFahrenheit(termometroFahrenheit);
                        this.GestorTemperatura.AgregarDispositivo(adaptadorFahrenheit);
                        this.Temperatura = this.GestorTemperatura.ObtenerTemperatura();
                        MostrarDatos(this.Temperatura);
                        Cargar((float)(this.Temperatura));
                        this.IdTemperatura = "F";
                    }
                    break;
                default:
                    this.lblRespuesta.Text = $"Parametro: {temp} no implementado";
                    break;
            }
        }
        public void MostrarDatos(double temperatura)
        {
            // Debug.Write($"La temperatura actual es: {temperatura}°");
            this.lblRespuesta.Text = $"La temperatura actual es: {temperatura}°";
        }
        private void Cargar(float temperatura)
        {
            LinearGauge? linearGauge = this.gCelsius.Gauges[0] as LinearGauge;
            LinearScaleComponent scale = linearGauge!.Scales[0];
           scale.Value= temperatura;
            this.gCelsius.Parent = this;
        }

        private void ckCelsius_Click(object sender, EventArgs e)
        {
            GetTemperatura(1);
        }

        private void ckFahrenheit_Click(object sender, EventArgs e)
        {
            GetTemperatura(2);
        }
    }
}