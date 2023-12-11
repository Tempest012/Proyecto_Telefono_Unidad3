using Proyecto_Telefono_Unidad3.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Telefono_Unidad3.Sansung
{
    public partial class ColasSansung : Form
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();



        public ColasSansung()
        {
            Primero = null;
            Ultimo = null;
            InitializeComponent();
        }

        private void ColasSansung_Load(object sender, EventArgs e)
        {

        }
        public void InsertaCola()
        {
            Nodo Nuevo = new Nodo();
            Nuevo.Dato = Convert.ToString(textNumero.Text);
            Nuevo.Model = Convert.ToString(MDeModelo.Text);
            Nuevo.Memoria = Convert.ToString(Memoriasafhoaehef.Text);
            Nuevo.Precios = Convert.ToDouble(estabienbaratojoven.Text);

            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }

        }
        public void MostraCola()
        {
            DatosTable.Columns.Clear();
            DatosTable.ColumnCount = 4;
            DatosTable.Columns[0].Name = "Nombre";
            DatosTable.Columns[1].Name = "Modelo";
            DatosTable.Columns[2].Name = "Memoria";
            DatosTable.Columns[3].Name = "Precios";


            Nodo Actual = Primero;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    DatosTable.Rows.Add(Actual.Dato, Actual.Model, Actual.Memoria, Actual.Precios);

                    Actual = Actual.Siguiente;
                }
            }
        }
        public void ModificaCola()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            string nodoBuscado = Convert.ToString(textBuscar.Text);
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Actual.Dato = Convert.ToString(textNumero.Text);
                        Actual.Model = Convert.ToString(MDeModelo.Text);
                        Actual.Memoria = Convert.ToString(Memoriasafhoaehef.Text);
                        Actual.Precios = Convert.ToDouble(estabienbaratojoven.Text);


                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    MessageBox.Show("No se encontró");
                }
            }
        } 
        public void EditarCola()
        {

        }
        public void EliminarCola()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            Anterior = null;

            bool Encontrado = false;
            string nodoBuscado = Convert.ToString(textBuscar.Text);
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {

                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (Actual == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    MessageBox.Show("No se encontró");
                }
            }
        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void MDeModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Memoriasafhoaehef_TextChanged(object sender, EventArgs e)
        {

        }

        private void estabienbaratojoven_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            InsertaCola();
            MostraCola();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            ModificaCola();
            MostraCola();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            EliminarCola();
            MostraCola();
        }

        private void DatosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelefonoSansung telefonoSansung = new TelefonoSansung();
            telefonoSansung.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
