namespace View
{
    partial class FrmBloque
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
            components = new System.ComponentModel.Container();
            btnCancelar = new Button();
            btnAceptar = new Button();
            groupBox1 = new GroupBox();
            txtNombre = new TextBox();
            bloqueBindingSource = new BindingSource(components);
            txtId = new TextBox();
            dgLectura = new DataGridView();
            lecturasBindingSource = new BindingSource(components);
            lblNombre = new Label();
            lblId = new Label();
            descripcionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            temperaturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bloqueBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgLectura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lecturasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(194, 402);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(113, 402);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(dgLectura);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 384);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle";
            // 
            // txtNombre
            // 
            txtNombre.DataBindings.Add(new Binding("Text", bloqueBindingSource, "Nombre", true));
            txtNombre.Location = new Point(131, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(186, 23);
            txtNombre.TabIndex = 4;
            // 
            // bloqueBindingSource
            // 
            bloqueBindingSource.DataSource = typeof(Model.Bloque);
            // 
            // txtId
            // 
            txtId.DataBindings.Add(new Binding("Text", bloqueBindingSource, "Id", true));
            txtId.Location = new Point(131, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(186, 23);
            txtId.TabIndex = 3;
            // 
            // dgLectura
            // 
            dgLectura.AllowUserToAddRows = false;
            dgLectura.AllowUserToDeleteRows = false;
            dgLectura.AutoGenerateColumns = false;
            dgLectura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLectura.Columns.AddRange(new DataGridViewColumn[] { descripcionDataGridViewTextBoxColumn, temperaturaDataGridViewTextBoxColumn });
            dgLectura.DataSource = lecturasBindingSource;
            dgLectura.Location = new Point(6, 135);
            dgLectura.Name = "dgLectura";
            dgLectura.ReadOnly = true;
            dgLectura.Size = new Size(323, 229);
            dgLectura.TabIndex = 2;
            // 
            // lecturasBindingSource
            // 
            lecturasBindingSource.DataSource = typeof(Model.Lecturas);
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(28, 37);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temperaturaDataGridViewTextBoxColumn
            // 
            temperaturaDataGridViewTextBoxColumn.DataPropertyName = "Temperatura";
            temperaturaDataGridViewTextBoxColumn.HeaderText = "Temperatura";
            temperaturaDataGridViewTextBoxColumn.Name = "temperaturaDataGridViewTextBoxColumn";
            temperaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmBloque
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(359, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FrmBloque";
            Text = "Bloque";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bloqueBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgLectura).EndInit();
            ((System.ComponentModel.ISupportInitialize)lecturasBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private GroupBox groupBox1;
        private Label lblNombre;
        private Label lblId;
        private BindingSource bloqueBindingSource;
        private DataGridView dgLectura;
        private TextBox txtNombre;
        private TextBox txtId;
        private BindingSource lecturasBindingSource;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn temperaturaDataGridViewTextBoxColumn;
    }
}