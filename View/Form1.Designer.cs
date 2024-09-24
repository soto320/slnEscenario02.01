namespace View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            gpTempera = new GroupBox();
            lblRespuesta = new Label();
            ckFahrenheit = new CheckBox();
            ckCelsius = new CheckBox();
            dgLista = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            bloqueBindingSource = new BindingSource(components);
            gpTempera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bloqueBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gpTempera
            // 
            gpTempera.Controls.Add(lblRespuesta);
            gpTempera.Controls.Add(ckFahrenheit);
            gpTempera.Controls.Add(ckCelsius);
            gpTempera.Location = new Point(617, 217);
            gpTempera.Name = "gpTempera";
            gpTempera.Size = new Size(146, 221);
            gpTempera.TabIndex = 0;
            gpTempera.TabStop = false;
            gpTempera.Text = "Panel de Temperatura";
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(28, 134);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(80, 15);
            lblRespuesta.TabIndex = 2;
            lblRespuesta.Text = "Sin resultados";
            // 
            // ckFahrenheit
            // 
            ckFahrenheit.AutoSize = true;
            ckFahrenheit.Location = new Point(28, 84);
            ckFahrenheit.Name = "ckFahrenheit";
            ckFahrenheit.Size = new Size(82, 19);
            ckFahrenheit.TabIndex = 1;
            ckFahrenheit.Text = "Fahrenheit";
            ckFahrenheit.UseVisualStyleBackColor = true;
            ckFahrenheit.CheckedChanged += ckFahrenheit_CheckedChanged;
            // 
            // ckCelsius
            // 
            ckCelsius.AutoSize = true;
            ckCelsius.Location = new Point(28, 49);
            ckCelsius.Name = "ckCelsius";
            ckCelsius.Size = new Size(63, 19);
            ckCelsius.TabIndex = 0;
            ckCelsius.Text = "Celsius";
            ckCelsius.UseVisualStyleBackColor = true;
            ckCelsius.Click += ckCelsius_Click;
            // 
            // dgLista
            // 
            dgLista.AllowUserToAddRows = false;
            dgLista.AllowUserToDeleteRows = false;
            dgLista.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, Nombre });
            dgLista.DataSource = bloqueBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgLista.DefaultCellStyle = dataGridViewCellStyle2;
            dgLista.Location = new Point(0, 48);
            dgLista.Name = "dgLista";
            dgLista.ReadOnly = true;
            dgLista.Size = new Size(800, 403);
            dgLista.TabIndex = 1;
            dgLista.CellContentDoubleClick += dgLista_CellContentDoubleClick;
            dgLista.CellDoubleClick += dgLista_CellDoubleClick;
            dgLista.CellMouseDoubleClick += dgLista_CellMouseDoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // bloqueBindingSource
            // 
            bloqueBindingSource.DataSource = typeof(Model.Bloque);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgLista);
            Controls.Add(gpTempera);
            Name = "Form1";
            Text = "Bloques del Edificio ";
            Load += Form1_Load;
            gpTempera.ResumeLayout(false);
            gpTempera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)bloqueBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpTempera;
        private CheckBox ckFahrenheit;
        private CheckBox ckCelsius;
        private Label lblRespuesta;
        private DataGridView dgLista;
        private DataGridViewTextBoxColumn blockNameDataGridViewTextBoxColumn;
        private BindingSource bloqueBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Nombre;
    }
}
