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
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange1 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange2 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange3 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            gpTempera = new GroupBox();
            lblRespuesta = new Label();
            ckFahrenheit = new CheckBox();
            ckCelsius = new CheckBox();
            gCelsius = new DevExpress.XtraGauges.Win.GaugeControl();
            linearGauge3 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            linearScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            linearScaleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            linearScaleLevelComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            btnCancelar = new Button();
            btnAceptar = new Button();
            gpTempera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)linearGauge3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleBackgroundLayerComponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleLevelComponent2).BeginInit();
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
            ckFahrenheit.Size = new Size(78, 17);
            ckFahrenheit.TabIndex = 1;
            ckFahrenheit.Text = "Fahrenheit";
            ckFahrenheit.UseVisualStyleBackColor = true;
            ckFahrenheit.Click += ckFahrenheit_Click;
            // 
            // ckCelsius
            // 
            ckCelsius.AutoSize = true;
            ckCelsius.Location = new Point(28, 49);
            ckCelsius.Name = "ckCelsius";
            ckCelsius.Size = new Size(59, 17);
            ckCelsius.TabIndex = 0;
            ckCelsius.Text = "Celsius";
            ckCelsius.UseVisualStyleBackColor = true;
            ckCelsius.Click += ckCelsius_Click;
            // 
            // gCelsius
            // 
            gCelsius.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] { linearGauge3 });
            gCelsius.Location = new Point(220, 21);
            gCelsius.Name = "gCelsius";
            gCelsius.Size = new Size(154, 212);
            gCelsius.TabIndex = 3;
            // 
            // linearGauge3
            // 
            linearGauge3.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] { linearScaleBackgroundLayerComponent2 });
            linearGauge3.Bounds = new Rectangle(6, 6, 142, 200);
            linearGauge3.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] { linearScaleLevelComponent2 });
            linearGauge3.Name = "linearGauge3";
            linearGauge3.OptionsToolTip.TooltipTitleFormat = "{0}";
            linearGauge3.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] { linearScaleComponent3 });
            // 
            // linearScaleBackgroundLayerComponent2
            // 
            linearScaleBackgroundLayerComponent2.LinearScale = linearScaleComponent3;
            linearScaleBackgroundLayerComponent2.Name = "bg1";
            linearScaleBackgroundLayerComponent2.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            linearScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style16;
            linearScaleBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // linearScaleComponent3
            // 
            linearScaleComponent3.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent3.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent3.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent3.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent3.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Pixel);
            linearScaleComponent3.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            linearScaleComponent3.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            linearScaleComponent3.MajorTickCount = 6;
            linearScaleComponent3.MajorTickmark.FormatString = "{0:F0}";
            linearScaleComponent3.MajorTickmark.ShapeOffset = -23F;
            linearScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style16_1;
            linearScaleComponent3.MajorTickmark.TextOffset = -33F;
            linearScaleComponent3.MaxValue = 100.1F;
            linearScaleComponent3.MinorTickCount = 4;
            linearScaleComponent3.MinorTickmark.ShapeOffset = -17F;
            linearScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style16_2;
            linearScaleComponent3.Name = "scale1";
            linearScaleRange1.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#8CBE5C");
            linearScaleRange1.EndThickness = 13F;
            linearScaleRange1.EndValue = 33F;
            linearScaleRange1.Name = "Range0";
            linearScaleRange1.ShapeOffset = -23F;
            linearScaleRange1.StartThickness = 13F;
            linearScaleRange2.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F1C05D");
            linearScaleRange2.EndThickness = 13F;
            linearScaleRange2.EndValue = 66F;
            linearScaleRange2.Name = "Range1";
            linearScaleRange2.ShapeOffset = -23F;
            linearScaleRange2.StartThickness = 13F;
            linearScaleRange2.StartValue = 33F;
            linearScaleRange3.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#ED8D77");
            linearScaleRange3.EndThickness = 13F;
            linearScaleRange3.EndValue = 100F;
            linearScaleRange3.Name = "Range2";
            linearScaleRange3.ShapeOffset = -23F;
            linearScaleRange3.StartThickness = 13F;
            linearScaleRange3.StartValue = 66F;
            linearScaleComponent3.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] { linearScaleRange1, linearScaleRange2, linearScaleRange3 });
            linearScaleComponent3.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            linearScaleComponent3.Value = 50F;
            // 
            // linearScaleLevelComponent2
            // 
            linearScaleLevelComponent2.LinearScale = linearScaleComponent3;
            linearScaleLevelComponent2.Name = "level1";
            linearScaleLevelComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style16;
            linearScaleLevelComponent2.ZOrder = -50;
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
            ((System.ComponentModel.ISupportInitialize)linearScaleBackgroundLayerComponent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent3).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleLevelComponent2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gpTempera;
        private Label lblRespuesta;
        private CheckBox ckFahrenheit;
        private CheckBox ckCelsius;
        private DevExpress.XtraGauges.Win.GaugeControl gCelsius;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge linearGauge3;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent2;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}