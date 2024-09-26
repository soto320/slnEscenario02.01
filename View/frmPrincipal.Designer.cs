namespace View
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange4 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange5 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange6 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            gpTempera = new GroupBox();
            lblRespuesta = new Label();
            ckFahrenheit = new CheckBox();
            ckCelsius = new CheckBox();
            gCelsius = new DevExpress.XtraGauges.Win.GaugeControl();
            btnCancelar = new Button();
            btnAceptar = new Button();
            linearGauge3 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            linearScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            linearScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            linearScaleLevelComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            gpTempera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)linearGauge3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleBackgroundLayerComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleLevelComponent1).BeginInit();
            SuspendLayout();
            // 
            // gpTempera
            // 
            gpTempera.Controls.Add(lblRespuesta);
            gpTempera.Controls.Add(ckFahrenheit);
            gpTempera.Controls.Add(ckCelsius);
            gpTempera.Location = new Point(12, 12);
            gpTempera.Name = "gpTempera";
            gpTempera.Size = new Size(202, 221);
            gpTempera.TabIndex = 1;
            gpTempera.TabStop = false;
            gpTempera.Text = "Panel de Temperatura";
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(28, 134);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(74, 13);
            lblRespuesta.TabIndex = 2;
            lblRespuesta.Text = "Sin resultados";
            // 
            // ckFahrenheit
            // 
            ckFahrenheit.AutoSize = true;
            ckFahrenheit.Location = new Point(28, 84);
            ckFahrenheit.Name = "ckFahrenheit";
            ckFahrenheit.Size = new Size(139, 17);
            ckFahrenheit.TabIndex = 1;
            ckFahrenheit.Text = "Termometro Fahrenheit";
            ckFahrenheit.UseVisualStyleBackColor = true;
            ckFahrenheit.Click += ckFahrenheit_Click;
            // 
            // ckCelsius
            // 
            ckCelsius.AutoSize = true;
            ckCelsius.Location = new Point(28, 49);
            ckCelsius.Name = "ckCelsius";
            ckCelsius.Size = new Size(120, 17);
            ckCelsius.TabIndex = 0;
            ckCelsius.Text = "Termometro Celsius";
            ckCelsius.UseVisualStyleBackColor = true;
            ckCelsius.Click += ckCelsius_Click;
            // 
            // gCelsius
            // 
            gCelsius.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] { linearGauge3 });
            gCelsius.Location = new Point(220, 21);
            gCelsius.Name = "gCelsius";
            gCelsius.Size = new Size(165, 212);
            gCelsius.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(203, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(122, 239);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // linearGauge3
            // 
            linearGauge3.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] { linearScaleBackgroundLayerComponent1 });
            linearGauge3.Bounds = new Rectangle(6, 6, 153, 200);
            linearGauge3.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] { linearScaleLevelComponent1 });
            linearGauge3.Name = "linearGauge3";
            linearGauge3.OptionsToolTip.TooltipTitleFormat = "{0}";
            linearGauge3.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] { linearScaleComponent1 });
            // 
            // linearScaleComponent1
            // 
            linearScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent1.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Pixel);
            linearScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            linearScaleComponent1.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            linearScaleComponent1.MajorTickCount = 6;
            linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            linearScaleComponent1.MajorTickmark.ShapeOffset = -23F;
            linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style16_1;
            linearScaleComponent1.MajorTickmark.TextOffset = -33F;
            linearScaleComponent1.MaxValue = 100F;
            linearScaleComponent1.MinorTickCount = 4;
            linearScaleComponent1.MinorTickmark.ShapeOffset = -17F;
            linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style16_2;
            linearScaleComponent1.Name = "scale1";
            linearScaleRange4.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#8CBE5C");
            linearScaleRange4.EndThickness = 13F;
            linearScaleRange4.EndValue = 33F;
            linearScaleRange4.Name = "Range0";
            linearScaleRange4.ShapeOffset = -23F;
            linearScaleRange4.StartThickness = 13F;
            linearScaleRange5.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F1C05D");
            linearScaleRange5.EndThickness = 13F;
            linearScaleRange5.EndValue = 66F;
            linearScaleRange5.Name = "Range1";
            linearScaleRange5.ShapeOffset = -23F;
            linearScaleRange5.StartThickness = 13F;
            linearScaleRange5.StartValue = 33F;
            linearScaleRange6.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#ED8D77");
            linearScaleRange6.EndThickness = 13F;
            linearScaleRange6.EndValue = 100F;
            linearScaleRange6.Name = "Range2";
            linearScaleRange6.ShapeOffset = -23F;
            linearScaleRange6.StartThickness = 13F;
            linearScaleRange6.StartValue = 66F;
            linearScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { linearScaleRange4, linearScaleRange5, linearScaleRange6 });
            linearScaleComponent1.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            linearScaleComponent1.Value = 50F;
            // 
            // linearScaleBackgroundLayerComponent1
            // 
            linearScaleBackgroundLayerComponent1.LinearScale = linearScaleComponent1;
            linearScaleBackgroundLayerComponent1.Name = "bg1";
            linearScaleBackgroundLayerComponent1.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style16;
            linearScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // linearScaleLevelComponent1
            // 
            linearScaleLevelComponent1.LinearScale = linearScaleComponent1;
            linearScaleLevelComponent1.Name = "level1";
            linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style26;
            linearScaleLevelComponent1.ZOrder = -50;
            // 
            // frmPrincipal
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(397, 271);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(gCelsius);
            Controls.Add(gpTempera);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            gpTempera.ResumeLayout(false);
            gpTempera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)linearGauge3).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleBackgroundLayerComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleLevelComponent1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gpTempera;
        private Label lblRespuesta;
        private CheckBox ckFahrenheit;
        private CheckBox ckCelsius;
        private DevExpress.XtraGauges.Win.GaugeControl gCelsius;
        private Button btnCancelar;
        private Button btnAceptar;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge linearGauge3;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent1;
    }
}