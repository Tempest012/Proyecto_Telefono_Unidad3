namespace Proyecto_Telefono_Unidad3.Sansung
{
    partial class ListasSansung
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
            this.Guardar = new System.Windows.Forms.Button();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.DatosTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(74, 156);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(100, 23);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(74, 101);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 22);
            this.textNumero.TabIndex = 1;
            this.textNumero.TextChanged += new System.EventHandler(this.textNumero_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elemento al ingresar a la lista";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(74, 203);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(100, 23);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(74, 253);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(100, 23);
            this.Eliminar.TabIndex = 4;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // DatosTable
            // 
            this.DatosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosTable.Location = new System.Drawing.Point(287, 110);
            this.DatosTable.Name = "DatosTable";
            this.DatosTable.RowHeadersWidth = 51;
            this.DatosTable.RowTemplate.Height = 24;
            this.DatosTable.Size = new System.Drawing.Size(347, 150);
            this.DatosTable.TabIndex = 5;
            this.DatosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ListasSansung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatosTable);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.Guardar);
            this.Name = "ListasSansung";
            this.Text = "ListasSansung";
            this.Load += new System.EventHandler(this.ListasSansung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridView DatosTable;
    }
}