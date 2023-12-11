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
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoriaRam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MDeModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Memoriasafhoaehef = new System.Windows.Forms.TextBox();
            this.estabienbaratojoven = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(15, 395);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(100, 23);
            this.Guardar.TabIndex = 0;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(74, 62);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 22);
            this.textNumero.TabIndex = 1;
            this.textNumero.TextChanged += new System.EventHandler(this.textNumero_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elemento al ingresar a la lista";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(141, 395);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(100, 23);
            this.Editar.TabIndex = 3;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(267, 395);
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
            this.DatosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Modelo,
            this.MemoriaRam});
            this.DatosTable.Location = new System.Drawing.Point(306, 59);
            this.DatosTable.Name = "DatosTable";
            this.DatosTable.RowHeadersWidth = 51;
            this.DatosTable.RowTemplate.Height = 24;
            this.DatosTable.Size = new System.Drawing.Size(733, 283);
            this.DatosTable.TabIndex = 5;
            this.DatosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 125;
            // 
            // MemoriaRam
            // 
            this.MemoriaRam.HeaderText = "MemoriaRam";
            this.MemoriaRam.MinimumWidth = 6;
            this.MemoriaRam.Name = "MemoriaRam";
            this.MemoriaRam.Width = 125;
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(74, 355);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(100, 22);
            this.textBuscar.TabIndex = 6;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elemento a buscar para editar o eliminar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MDeModelo
            // 
            this.MDeModelo.Location = new System.Drawing.Point(74, 139);
            this.MDeModelo.Name = "MDeModelo";
            this.MDeModelo.Size = new System.Drawing.Size(100, 22);
            this.MDeModelo.TabIndex = 8;
            this.MDeModelo.TextChanged += new System.EventHandler(this.MDeModelo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingresa el modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingresa la memoria";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Memoriasafhoaehef
            // 
            this.Memoriasafhoaehef.Location = new System.Drawing.Point(74, 207);
            this.Memoriasafhoaehef.Name = "Memoriasafhoaehef";
            this.Memoriasafhoaehef.Size = new System.Drawing.Size(100, 22);
            this.Memoriasafhoaehef.TabIndex = 11;
            this.Memoriasafhoaehef.TextChanged += new System.EventHandler(this.Memoriasafhoaehef_TextChanged);
            // 
            // estabienbaratojoven
            // 
            this.estabienbaratojoven.Location = new System.Drawing.Point(74, 272);
            this.estabienbaratojoven.Name = "estabienbaratojoven";
            this.estabienbaratojoven.Size = new System.Drawing.Size(100, 22);
            this.estabienbaratojoven.TabIndex = 12;
            this.estabienbaratojoven.TextChanged += new System.EventHandler(this.estabienbaratojoven_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ingrese el precio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Telefono_Unidad3.Properties.Resources.e9e8755ea46b70379c483aaa886bc759;
            this.pictureBox1.Location = new System.Drawing.Point(0, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1085, 620);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListasSansung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.estabienbaratojoven);
            this.Controls.Add(this.Memoriasafhoaehef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MDeModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.DatosTable);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListasSansung";
            this.Text = "ListasSansung";
            this.Load += new System.EventHandler(this.ListasSansung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MDeModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Memoriasafhoaehef;
        private System.Windows.Forms.TextBox estabienbaratojoven;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoriaRam;
    }
}