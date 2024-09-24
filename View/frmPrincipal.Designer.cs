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
            gCelsius = new DevExpress.XtraGauges.Win.GaugeControl();
            lGauge1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            linearScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            linearScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            linearScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            linearScaleLevelComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            gFahrenheit = new DevExpress.XtraGauges.Win.GaugeControl();
            linearGauge1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            linearScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            linearScaleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            linearScaleLevelComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            linearScaleComponent4 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            ((System.ComponentModel.ISupportInitialize)lGauge1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleBackgroundLayerComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleLevelComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearGauge1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleBackgroundLayerComponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleLevelComponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent4).BeginInit();
            SuspendLayout();
            // 
            // gCelsius
            // 
            gCelsius.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] { lGauge1 });
            gCelsius.Location = new Point(178, 60);
            gCelsius.Name = "gCelsius";
            gCelsius.Size = new Size(258, 262);
            gCelsius.TabIndex = 0;
            // 
            // lGauge1
            // 
            lGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] { linearScaleBackgroundLayerComponent1 });
            lGauge1.Bounds = new Rectangle(6, 6, 246, 250);
            lGauge1.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] { linearScaleLevelComponent1 });
            lGauge1.Name = "lGauge1";
            lGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] { linearScaleComponent1, linearScaleComponent2 });
            // 
            // linearScaleComponent1
            // 
            linearScaleComponent1.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            linearScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            linearScaleComponent1.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F);
            linearScaleComponent1.MajorTickCount = 6;
            linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            linearScaleComponent1.MajorTickmark.ShapeOffset = 6F;
            linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_2;
            linearScaleComponent1.MajorTickmark.TextOffset = 35F;
            linearScaleComponent1.MaxValue = 500F;
            linearScaleComponent1.MinorTickCount = 4;
            linearScaleComponent1.MinorTickmark.ShapeOffset = 6F;
            linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_1;
            linearScaleComponent1.Name = "scale1";
            linearScaleComponent1.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F);
            linearScaleComponent1.Value = 250F;
            // 
            // linearScaleComponent2
            // 
            linearScaleComponent2.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            linearScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            linearScaleComponent2.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F);
            linearScaleComponent2.MajorTickCount = 6;
            linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            linearScaleComponent2.MajorTickmark.ShapeOffset = -18F;
            linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_3;
            linearScaleComponent2.MajorTickmark.TextOffset = -32F;
            linearScaleComponent2.MaxValue = 50F;
            linearScaleComponent2.MinorTickCount = 4;
            linearScaleComponent2.MinorTickmark.ShapeOffset = -12F;
            linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_4;
            linearScaleComponent2.Name = "scale2";
            linearScaleComponent2.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F);
            // 
            // linearScaleBackgroundLayerComponent1
            // 
            linearScaleBackgroundLayerComponent1.LinearScale = linearScaleComponent1;
            linearScaleBackgroundLayerComponent1.Name = "bg1";
            linearScaleBackgroundLayerComponent1.ScaleEndPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5075F, 0.08F);
            linearScaleBackgroundLayerComponent1.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5075F, 0.92F);
            linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style11;
            linearScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // linearScaleLevelComponent1
            // 
            linearScaleLevelComponent1.LinearScale = linearScaleComponent1;
            linearScaleLevelComponent1.Name = "level1";
            linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style11;
            linearScaleLevelComponent1.ZOrder = -50;
            // 
            // gFahrenheit
            // 
            gFahrenheit.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] { linearGauge1 });
            gFahrenheit.Location = new Point(455, 60);
            gFahrenheit.Name = "gFahrenheit";
            gFahrenheit.Size = new Size(258, 262);
            gFahrenheit.TabIndex = 1;
            // 
            // linearGauge1
            // 
            linearGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] { linearScaleBackgroundLayerComponent2 });
            linearGauge1.Bounds = new Rectangle(6, 6, 246, 250);
            linearGauge1.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] { linearScaleLevelComponent2 });
            linearGauge1.Name = "linearGauge1";
            linearGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] { linearScaleComponent3, linearScaleComponent4 });
            // 
            // linearScaleBackgroundLayerComponent2
            // 
            linearScaleBackgroundLayerComponent2.LinearScale = linearScaleComponent3;
            linearScaleBackgroundLayerComponent2.Name = "bg1";
            linearScaleBackgroundLayerComponent2.ScaleEndPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5075F, 0.08F);
            linearScaleBackgroundLayerComponent2.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5075F, 0.92F);
            linearScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style11;
            linearScaleBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // linearScaleComponent3
            // 
            linearScaleComponent3.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent3.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent3.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent3.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent3.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            linearScaleComponent3.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            linearScaleComponent3.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F);
            linearScaleComponent3.MajorTickCount = 6;
            linearScaleComponent3.MajorTickmark.FormatString = "{0:F0}";
            linearScaleComponent3.MajorTickmark.ShapeOffset = 6F;
            linearScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_2;
            linearScaleComponent3.MajorTickmark.TextOffset = 35F;
            linearScaleComponent3.MaxValue = 500F;
            linearScaleComponent3.MinorTickCount = 4;
            linearScaleComponent3.MinorTickmark.ShapeOffset = 6F;
            linearScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_1;
            linearScaleComponent3.Name = "scale1";
            linearScaleComponent3.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F);
            linearScaleComponent3.Value = 250F;
            // 
            // linearScaleLevelComponent2
            // 
            linearScaleLevelComponent2.LinearScale = linearScaleComponent3;
            linearScaleLevelComponent2.Name = "level1";
            linearScaleLevelComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style11;
            linearScaleLevelComponent2.ZOrder = -50;
            // 
            // linearScaleComponent4
            // 
            linearScaleComponent4.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent4.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent4.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent4.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            linearScaleComponent4.AppearanceTickmarkText.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            linearScaleComponent4.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            linearScaleComponent4.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F);
            linearScaleComponent4.MajorTickCount = 6;
            linearScaleComponent4.MajorTickmark.FormatString = "{0:F0}";
            linearScaleComponent4.MajorTickmark.ShapeOffset = -18F;
            linearScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_3;
            linearScaleComponent4.MajorTickmark.TextOffset = -32F;
            linearScaleComponent4.MaxValue = 50F;
            linearScaleComponent4.MinorTickCount = 4;
            linearScaleComponent4.MinorTickmark.ShapeOffset = -12F;
            linearScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_4;
            linearScaleComponent4.Name = "scale2";
            linearScaleComponent4.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 475);
            Controls.Add(gFahrenheit);
            Controls.Add(gCelsius);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)lGauge1).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleBackgroundLayerComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleLevelComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearGauge1).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleBackgroundLayerComponent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent3).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleLevelComponent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)linearScaleComponent4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gCelsius;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge lGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent2;
        private DevExpress.XtraGauges.Win.GaugeControl gFahrenheit;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge linearGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent4;
    }
}