namespace RegistroDeClientes
{
    partial class FrmClientesDeudores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteDeCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTotalDeuda = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblPromedioDeuda = new System.Windows.Forms.Label();
            this.LblcantidadClientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnListarDeudores = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Usuario,
            this.LimiteDeCredito,
            this.Deuda});
            this.DgvClientes.Location = new System.Drawing.Point(2, 19);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(585, 259);
            this.DgvClientes.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Nombre y Apellido";
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 150;
            // 
            // LimiteDeCredito
            // 
            this.LimiteDeCredito.HeaderText = "Limite de credito";
            this.LimiteDeCredito.Name = "LimiteDeCredito";
            this.LimiteDeCredito.Width = 150;
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            this.Deuda.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total de Deuda";
            // 
            // LblTotalDeuda
            // 
            this.LblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalDeuda.Location = new System.Drawing.Point(382, 326);
            this.LblTotalDeuda.Name = "LblTotalDeuda";
            this.LblTotalDeuda.Size = new System.Drawing.Size(169, 34);
            this.LblTotalDeuda.TabIndex = 7;
            this.LblTotalDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblPromedioDeuda);
            this.groupBox2.Controls.Add(this.LblcantidadClientes);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnListarDeudores);
            this.groupBox2.Controls.Add(this.DgvClientes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.BtnListar);
            this.groupBox2.Controls.Add(this.LblTotalDeuda);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 581);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar Datos";
            // 
            // LblPromedioDeuda
            // 
            this.LblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPromedioDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPromedioDeuda.Location = new System.Drawing.Point(382, 442);
            this.LblPromedioDeuda.Name = "LblPromedioDeuda";
            this.LblPromedioDeuda.Size = new System.Drawing.Size(169, 32);
            this.LblPromedioDeuda.TabIndex = 13;
            this.LblPromedioDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblcantidadClientes
            // 
            this.LblcantidadClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblcantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblcantidadClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblcantidadClientes.Location = new System.Drawing.Point(382, 381);
            this.LblcantidadClientes.Name = "LblcantidadClientes";
            this.LblcantidadClientes.Size = new System.Drawing.Size(169, 32);
            this.LblcantidadClientes.TabIndex = 12;
            this.LblcantidadClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Promedio de deuda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cantidad de clientes";
            // 
            // BtnListarDeudores
            // 
            this.BtnListarDeudores.Location = new System.Drawing.Point(369, 514);
            this.BtnListarDeudores.Name = "BtnListarDeudores";
            this.BtnListarDeudores.Size = new System.Drawing.Size(218, 46);
            this.BtnListarDeudores.TabIndex = 9;
            this.BtnListarDeudores.Text = "Listar Deudores";
            this.BtnListarDeudores.UseVisualStyleBackColor = true;
            this.BtnListarDeudores.Click += new System.EventHandler(this.BtnListarDeudores_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(31, 524);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(218, 36);
            this.BtnListar.TabIndex = 8;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Visible = false;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // FrmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 605);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmClientesDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesDeudores";
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblTotalDeuda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnListarDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteDeCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Label LblPromedioDeuda;
        private System.Windows.Forms.Label LblcantidadClientes;
    }
}

