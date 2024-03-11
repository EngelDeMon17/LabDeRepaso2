
namespace LabDeRepaso2
{
    partial class Form1
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
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewVehiculo = new System.Windows.Forms.DataGridView();
            this.dataGridViewAlquiler = new System.Windows.Forms.DataGridView();
            this.buttonMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(27, 73);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCliente.TabIndex = 0;
            // 
            // dataGridViewVehiculo
            // 
            this.dataGridViewVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculo.Location = new System.Drawing.Point(273, 73);
            this.dataGridViewVehiculo.Name = "dataGridViewVehiculo";
            this.dataGridViewVehiculo.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewVehiculo.TabIndex = 1;
            // 
            // dataGridViewAlquiler
            // 
            this.dataGridViewAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquiler.Location = new System.Drawing.Point(519, 73);
            this.dataGridViewAlquiler.Name = "dataGridViewAlquiler";
            this.dataGridViewAlquiler.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewAlquiler.TabIndex = 2;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(273, 275);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(240, 23);
            this.buttonMostrar.TabIndex = 3;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dataGridViewAlquiler);
            this.Controls.Add(this.dataGridViewVehiculo);
            this.Controls.Add(this.dataGridViewCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridView dataGridViewVehiculo;
        private System.Windows.Forms.DataGridView dataGridViewAlquiler;
        private System.Windows.Forms.Button buttonMostrar;
    }
}

