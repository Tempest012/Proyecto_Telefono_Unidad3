namespace Proyecto_Telefono_Unidad3.Sansung
{
    partial class ColasSansung
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
            this.label5 = new System.Windows.Forms.Label();
            this.estabienbaratojoven = new System.Windows.Forms.TextBox();
            this.Memoriasafhoaehef = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MDeModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.DatosTable = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ingrese el precio";
            // 
            // estabienbaratojoven
            // 
            this.estabienbaratojoven.Location = new System.Drawing.Point(78, 360);
            this.estabienbaratojoven.Name = "estabienbaratojoven";
            this.estabienbaratojoven.Size = new System.Drawing.Size(100, 22);
            this.estabienbaratojoven.TabIndex = 40;
            this.estabienbaratojoven.TextChanged += new System.EventHandler(this.estabienbaratojoven_TextChanged);
            // 
            // Memoriasafhoaehef
            // 
            this.Memoriasafhoaehef.Location = new System.Drawing.Point(78, 287);
            this.Memoriasafhoaehef.Name = "Memoriasafhoaehef";
            this.Memoriasafhoaehef.Size = new System.Drawing.Size(100, 22);
            this.Memoriasafhoaehef.TabIndex = 39;
            this.Memoriasafhoaehef.TextChanged += new System.EventHandler(this.Memoriasafhoaehef_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ingresa la memoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ingresa el modelo";
            // 
            // MDeModelo
            // 
            this.MDeModelo.Location = new System.Drawing.Point(78, 207);
            this.MDeModelo.Name = "MDeModelo";
            this.MDeModelo.Size = new System.Drawing.Size(100, 22);
            this.MDeModelo.TabIndex = 36;
            this.MDeModelo.TextChanged += new System.EventHandler(this.MDeModelo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Elemento a buscar para editar o eliminar";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(78, 454);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(100, 22);
            this.textBuscar.TabIndex = 34;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // DatosTable
            // 
            this.DatosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosTable.Location = new System.Drawing.Point(415, 73);
            this.DatosTable.Name = "DatosTable";
            this.DatosTable.RowHeadersWidth = 51;
            this.DatosTable.RowTemplate.Height = 24;
            this.DatosTable.Size = new System.Drawing.Size(481, 354);
            this.DatosTable.TabIndex = 33;
            this.DatosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosTable_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(300, 525);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(100, 23);
            this.Eliminar.TabIndex = 32;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(171, 525);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(100, 23);
            this.Editar.TabIndex = 31;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Elemento al ingresar el nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(78, 127);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 22);
            this.textNumero.TabIndex = 29;
            this.textNumero.TextChanged += new System.EventHandler(this.textNumero_TextChanged);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(53, 525);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(100, 23);
            this.Guardar.TabIndex = 28;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(891, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Telefono_Unidad3.Properties.Resources._158515;
            this.pictureBox1.Location = new System.Drawing.Point(3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1061, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ColasSansung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 626);
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
            this.Name = "ColasSansung";
            this.Text = "ColasSansung";
            this.Load += new System.EventHandler(this.ColasSansung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox estabienbaratojoven;
        private System.Windows.Forms.TextBox Memoriasafhoaehef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MDeModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.DataGridView DatosTable;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}