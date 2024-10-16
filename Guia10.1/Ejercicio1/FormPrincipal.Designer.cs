namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxEmpleados = new System.Windows.Forms.ListBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnVerEmpleados = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRecibos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxEmpleados);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 493);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de empleados";
            // 
            // lbxEmpleados
            // 
            this.lbxEmpleados.FormattingEnabled = true;
            this.lbxEmpleados.ItemHeight = 20;
            this.lbxEmpleados.Location = new System.Drawing.Point(6, 25);
            this.lbxEmpleados.Name = "lbxEmpleados";
            this.lbxEmpleados.Size = new System.Drawing.Size(326, 464);
            this.lbxEmpleados.TabIndex = 0;
            this.lbxEmpleados.SelectedIndexChanged += new System.EventHandler(this.lbxEmpleados_SelectedIndexChanged);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(360, 118);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(127, 73);
            this.btnImportar.TabIndex = 16;
            this.btnImportar.Text = "(2) Importar Empleados";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(360, 197);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(127, 73);
            this.btnExportar.TabIndex = 17;
            this.btnExportar.Text = "(3) Exportar Empleados";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnVerEmpleados
            // 
            this.btnVerEmpleados.Location = new System.Drawing.Point(360, 39);
            this.btnVerEmpleados.Name = "btnVerEmpleados";
            this.btnVerEmpleados.Size = new System.Drawing.Size(127, 73);
            this.btnVerEmpleados.TabIndex = 18;
            this.btnVerEmpleados.Text = "(1) Ver Listado";
            this.btnVerEmpleados.UseVisualStyleBackColor = true;
            this.btnVerEmpleados.Click += new System.EventHandler(this.btnVerEmpleados_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRecibos
            // 
            this.btnRecibos.Location = new System.Drawing.Point(360, 276);
            this.btnRecibos.Name = "btnRecibos";
            this.btnRecibos.Size = new System.Drawing.Size(127, 73);
            this.btnRecibos.TabIndex = 20;
            this.btnRecibos.Text = "(5) Generar Recibos";
            this.btnRecibos.UseVisualStyleBackColor = true;
            this.btnRecibos.Click += new System.EventHandler(this.btnRecibos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 511);
            this.Controls.Add(this.btnRecibos);
            this.Controls.Add(this.btnVerEmpleados);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ListBox lbxEmpleados;
        private System.Windows.Forms.Button btnVerEmpleados;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRecibos;
    }
}

