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
        private NodoPila Primero = new NodoPila();
        NodoPila _tope;
        public NodoPila Tope()
        {
            return _tope;
        }
        public PilasSansung()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Model", "Modelo");
            dataGridView1.Columns.Add("Memoria", "Memoria");
            dataGridView1.Columns.Add("Precios", "Precios");
        }


        private void PilasSansung_Load(object sender, EventArgs e)
        {

        }
        public void Insertar(NodoPila unNodo)
        {
            if (_tope == null)
            {
                _tope = unNodo;
            }
            else
            {
                NodoPila auxiliar = _tope;
                _tope = unNodo;
                _tope.Siguiente= auxiliar;
            }

        }
        void Mostrar()
        {
            dataGridView1.Rows.Clear();

            if (Tope() != null)
            {
                MostrarPila(Tope());
            }
        }

        void MostrarPila(NodoPila unNodo)
        {
            dataGridView1.Rows.Add(unNodo.Nombre, unNodo.Model, unNodo.Memoria, unNodo.Precios);

            if (unNodo.Siguiente != null)
            {
                MostrarPila(unNodo.Siguiente);
            }
        }
        public void EditarPila()
        {
            if (_tope != null)
            {
                NodoPila nodoEditado = new NodoPila();
                nodoEditado.Nombre = textNumero.Text;
                nodoEditado.Model = MDeModelo.Text;
                nodoEditado.Memoria = Memoriasafhoaehef.Text;

                if (double.TryParse(estabienbaratojoven.Text, out double precios))
                {
                    nodoEditado.Precios = precios;
                }
                else
                {
                    MessageBox.Show("El valor de Precios no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _tope = _tope.Siguiente;

                Insertar(nodoEditado);

                Mostrar();
            }
            else
            {
                MessageBox.Show("La pila está vacía. No hay elementos para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void EliminarPilas()
        {
            if(_tope != null)
            {
                _tope = _tope.Siguiente;
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
            if (textNumero.Text != string.Empty && MDeModelo.Text != string.Empty && Memoriasafhoaehef.Text != string.Empty)
            {
                NodoPila unNuevoNodo = new NodoPila();
                unNuevoNodo.Nombre = textNumero.Text;
                unNuevoNodo.Model = MDeModelo.Text;
                unNuevoNodo.Memoria = Memoriasafhoaehef.Text;

                if (double.TryParse(estabienbaratojoven.Text, out double precios))
                {
                    unNuevoNodo.Precios = precios;
                }
                else
                {

                    MessageBox.Show("El valor de Precios no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Insertar(unNuevoNodo);
                Mostrar();
                LimpiarCasillas();
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            EditarPila();
            Mostrar();
            LimpiarCasillas();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            EliminarPilas();
            Mostrar();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LimpiarCasillas()
        {
            textNumero.Clear();
            MDeModelo.Clear();
            Memoriasafhoaehef.Clear();
            estabienbaratojoven.Clear();
        }
    }
}
