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
    public partial class PilasSansung : Form
    {
        private Nodo Primero = new Nodo();
        public PilasSansung()
        {
            Primero = null;
            InitializeComponent();
        }
        
        private void PilasSansung_Load(object sender, EventArgs e)
        {

        }
        public void Insertar()
        {
            Nodo Nuevo=new Nodo();
            Nuevo.Dato = Convert.ToString(textNumero.Text);
            Nuevo.Model = Convert.ToString(MDeModelo.Text);
            Nuevo.Memoria = Convert.ToString(Memoriasafhoaehef.Text);
            Nuevo.Precios = Convert.ToString(estabienbaratojoven.Text);

            Nuevo.Siguiente = Primero;
            Primero=Nuevo;

            MessageBox.Show("Elemento ingresado");
        }
        public void Mostrar()
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
                while(Actual != null)
                {
                    DatosTable.Rows.Add(Actual.Dato, Actual.Model, Actual.Memoria, Actual.Precios);

                    Actual = Actual.Siguiente;
                }
            }
        }
        public void EditarPila()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            string nodoBuscado = Convert.ToString(textBuscar.Text);

            if(Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Actual.Dato = Convert.ToString(textNumero.Text);
                        Actual.Model = Convert.ToString(MDeModelo.Text);
                        Actual.Memoria = Convert.ToString(Memoriasafhoaehef.Text);
                        Actual.Precios = Convert.ToString(estabienbaratojoven.Text);


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
        public void EliminarPilas()
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
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        Encontrado = true;
                    }
                    Anterior = Actual;
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
            Insertar();
            Mostrar();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            EditarPila();
            Mostrar();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            EliminarPilas();
            Mostrar();
        }

        private void DatosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelefonoSansung telefonoSansung = new TelefonoSansung();
            telefonoSansung.Show();
            this.Hide();
        }
    }
}
