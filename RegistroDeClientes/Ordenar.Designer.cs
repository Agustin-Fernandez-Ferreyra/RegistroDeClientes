namespace RegistroDeClientes
{
    partial class FrmListadoOrdenado
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
            this.GrbConsultarDatos = new System.Windows.Forms.GroupBox();
            this.BtnListar = new System.Windows.Forms.Button();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmbmodo = new System.Windows.Forms.ComboBox();
            this.CmbCampo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrbConsultarDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbConsultarDatos
            // 
            this.GrbConsultarDatos.Controls.Add(this.BtnListar);
            this.GrbConsultarDatos.Controls.Add(this.DgvClientes);
            this.GrbConsultarDatos.Controls.Add(this.Cmbmodo);
            this.GrbConsultarDatos.Controls.Add(this.CmbCampo);
            this.GrbConsultarDatos.Controls.Add(this.label2);
            this.GrbConsultarDatos.Controls.Add(this.label1);
            this.GrbConsultarDatos.Location = new System.Drawing.Point(62, 25);
            this.GrbConsultarDatos.Name = "GrbConsultarDatos";
            this.GrbConsultarDatos.Size = new System.Drawing.Size(693, 413);
            this.GrbConsultarDatos.TabIndex = 0;
            this.GrbConsultarDatos.TabStop = false;
            this.GrbConsultarDatos.Text = "Consultar Datos";
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(523, 355);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(121, 41);
            this.BtnListar.TabIndex = 5;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvClientes.Location = new System.Drawing.Point(22, 111);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(639, 213);
            this.DgvClientes.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Listado de credito";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Cmbmodo
            // 
            this.Cmbmodo.FormattingEnabled = true;
            this.Cmbmodo.Items.AddRange(new object[] {
            "Acendente ",
            "Decendente"});
            this.Cmbmodo.Location = new System.Drawing.Point(523, 62);
            this.Cmbmodo.Name = "Cmbmodo";
            this.Cmbmodo.Size = new System.Drawing.Size(121, 21);
            this.Cmbmodo.TabIndex = 3;
            // 
            // CmbCampo
            // 
            this.CmbCampo.FormattingEnabled = true;
            this.CmbCampo.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Limite",
            "Dueda"});
            this.CmbCampo.Location = new System.Drawing.Point(175, 59);
            this.CmbCampo.Name = "CmbCampo";
            this.CmbCampo.Size = new System.Drawing.Size(121, 21);
            this.CmbCampo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MODO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMPO";
            // 
            // FrmListadoOrdenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrbConsultarDatos);
            this.Name = "FrmListadoOrdenado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenar";
            this.Load += new System.EventHandler(this.FrmListadoOrdenado_Load);
            this.GrbConsultarDatos.ResumeLayout(false);
            this.GrbConsultarDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbConsultarDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.ComboBox Cmbmodo;
        private System.Windows.Forms.ComboBox CmbCampo;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}