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
    public partial class ListasSansung : Form
    {
        public ListasSansung()
        {

            Primero = null;
            Ultimo = null;

            InitializeComponent();
        }

        private void ListasSansung_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        //Boton de guardar
        private void button1_Click(object sender, EventArgs e)
        {
            insertar();
            mostrarDG();
        }
        public void insertar()
        {
            Nodo Nuevo = new Nodo();
            Nuevo.Dato = Convert.ToString(textNumero.Text);
            
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
        public void mostrarDG()
        {
            DatosTable.Columns.Clear();
            DatosTable.ColumnCount = 1;
            DatosTable.Columns[0].Name = "Nombre";
            Nodo Actual = Primero;
            if (Primero != null)
            {
                while (Actual != null)
                {
                    DatosTable.Rows.Add(Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {

            }

        }
        public void ModificarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            string nodoBuscado = Convert.ToString(textNumero.Text);
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Actual.Dato = Convert.ToString(textNumero.Text);
                        

                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    
                }
            }
            else
            {
                
            }
        }
        public void EliminarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            Anterior = null;

            bool Encontrado = false;
            string nodoBuscado = Convert.ToString(textNumero.Text);
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
                }
            }
            else
            {
            }
        }

        //Boton de eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            EliminarNodo();
            mostrarDG();
        }
        //Boton De editar
        private void Editar_Click(object sender, EventArgs e)
        {
            ModificarNodo();
            mostrarDG();
        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
