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
            LimpiarCasillas();
        }
        public void insertar()
        {
            if (textNumero.Text != string.Empty && MDeModelo.Text != string.Empty && Memoriasafhoaehef.Text != string.Empty) 
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
        }
        public void mostrarDG()
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
                    DatosTable.Rows.Add(Actual.Dato,Actual.Model,Actual.Memoria,Actual.Precios);
             
                    Actual = Actual.Siguiente;
                }
            }
            

        }
        public void ModificarNodo()
        {
            if (textNumero.Text != string.Empty && MDeModelo.Text != string.Empty && Memoriasafhoaehef.Text != string.Empty)
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
           
        }
        public void EliminarNodo()
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
            else
            {
                MessageBox.Show("Esta Vacía");
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
            LimpiarCasillas();
        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            TelefonoSansung telefonoSansung = new TelefonoSansung();
            telefonoSansung.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void InsertarAlPrincipio()
        {
            if (textNumero.Text != string.Empty && MDeModelo.Text != string.Empty && Memoriasafhoaehef.Text != string.Empty)
            {


                Nodo Nuevo = new Nodo();
                Nuevo.Dato = Convert.ToString(textNumero.Text);
                Nuevo.Model = Convert.ToString(MDeModelo.Text);
                Nuevo.Memoria = Convert.ToString(Memoriasafhoaehef.Text);
                Nuevo.Precios = Convert.ToDouble(estabienbaratojoven.Text);

                Nuevo.Siguiente = Primero;
                Primero = Nuevo;

                if (Ultimo == null)
                {
                    Ultimo = Primero;
                }
            }
            LimpiarCasillas();
            mostrarDG();
        }

        public void InsertarEnMedio()
        {
            int posicion = 2;
            if (textNumero.Text != string.Empty && MDeModelo.Text != string.Empty && Memoriasafhoaehef.Text != string.Empty)
            {

            
                Nodo Nuevo = new Nodo();
                Nuevo.Dato = Convert.ToString(textNumero.Text);
                Nuevo.Model = Convert.ToString(MDeModelo.Text);
                Nuevo.Memoria = Convert.ToString(Memoriasafhoaehef.Text);
                Nuevo.Precios = Convert.ToDouble(estabienbaratojoven.Text);

                if (Primero == null)
                {
                    Primero = Nuevo;
                    Ultimo = Nuevo;
                }
                else if (posicion == 1)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    Nodo Actual = Primero;
                    for (int i = 1; i < posicion - 1 && Actual != null; i++)
                    {
                        Actual = Actual.Siguiente;
                    }

                    if (Actual != null)
                    {
                        Nuevo.Siguiente = Actual.Siguiente;
                        Actual.Siguiente = Nuevo;
                    }
                    else
                    {
                        MessageBox.Show("La posición especificada no es válida.");
                        return;
                    }
                }

                if (Nuevo.Siguiente == null)
                {
                Ultimo = Nuevo;
                }
            }
            LimpiarCasillas();
            mostrarDG();
        }

        public void InsertarAlFinal()
        {
            if(textNumero.Text != string.Empty && MDeModelo.Text != string.Empty && Memoriasafhoaehef.Text != string.Empty)
            {

            
                Nodo Nuevo = new Nodo();
                Nuevo.Dato = Convert.ToString(textNumero.Text);
                Nuevo.Model = Convert.ToString(MDeModelo.Text);
                Nuevo.Memoria = Convert.ToString(Memoriasafhoaehef.Text);
                Nuevo.Precios = Convert.ToDouble(estabienbaratojoven.Text);

                if (Primero == null)
                {
                    Primero = Nuevo;
                    Ultimo = Nuevo;
                }
                else
                {
                    Ultimo.Siguiente = Nuevo;
                    Ultimo = Nuevo;
                }
            }

            LimpiarCasillas();
            mostrarDG();
        }

        public void LimpiarCasillas()
        {
            textNumero.Clear();
            MDeModelo.Clear();
            Memoriasafhoaehef.Clear();
            estabienbaratojoven.Clear();
        }
        public void OordenDescendente()
        {
            
        }

        private void btnInsertarAlPrincipio_Click(object sender, EventArgs e)
        {
            InsertarAlPrincipio();
            mostrarDG();
        }

        private void btnInsertarEnMedio_Click(object sender, EventArgs e)
        {
            InsertarEnMedio();
            mostrarDG();
        }
      
        private void btnInsertarAlFinal_Click_1(object sender, EventArgs e)
        {
            InsertarAlFinal();
            mostrarDG();
        }
        public void OrdenarDescendente()
        {
            if (Primero == null || Primero.Siguiente == null)
            {
                return;
            }

            Nodo i, j;
            bool intercambio;

            for (i = Primero; i != null; i = i.Siguiente)
            {
                intercambio = false;

                for (j = Primero; j.Siguiente != null; j = j.Siguiente)
                {
                    if (j.Precios < j.Siguiente.Precios)
                    {
                        Nodo temp = new Nodo
                        {
                            Dato = j.Dato,
                            Model = j.Model,
                            Memoria = j.Memoria,
                            Precios = j.Precios
                        };

                        j.Dato = j.Siguiente.Dato;
                        j.Model = j.Siguiente.Model;
                        j.Memoria = j.Siguiente.Memoria;
                        j.Precios = j.Siguiente.Precios;

                        j.Siguiente.Dato = temp.Dato;
                        j.Siguiente.Model = temp.Model;
                        j.Siguiente.Memoria = temp.Memoria;
                        j.Siguiente.Precios = temp.Precios;

                        intercambio = true;
                    }
                }

                if (!intercambio)
                {
                    break;
                }
            }

            mostrarDG();
        }
        public void OrdenarAscendente()
        {
            if (Primero == null || Primero.Siguiente == null)
            {
                return;
            }

            Nodo i, j;
            bool intercambio;

            for (i = Primero; i != null; i = i.Siguiente)
            {
                intercambio = false;

                for (j = Primero; j.Siguiente != null; j = j.Siguiente)
                {
                    if (j.Precios > j.Siguiente.Precios)
                    {
                        Nodo temp = new Nodo
                        {
                            Dato = j.Dato,
                            Model = j.Model,
                            Memoria = j.Memoria,
                            Precios = j.Precios
                        };

                        j.Dato = j.Siguiente.Dato;
                        j.Model = j.Siguiente.Model;
                        j.Memoria = j.Siguiente.Memoria;
                        j.Precios = j.Siguiente.Precios;

                        j.Siguiente.Dato = temp.Dato;
                        j.Siguiente.Model = temp.Model;
                        j.Siguiente.Memoria = temp.Memoria;
                        j.Siguiente.Precios = temp.Precios;

                        intercambio = true;
                    }
                }

                if (!intercambio)
                {
                    break;
                }
            }

            mostrarDG();
        }

        
        private void btnOrdenarDescendente_Click(object sender, EventArgs e)
        {
            OrdenarDescendente();
        }

        private void btnOrdenarAscendente_Click(object sender, EventArgs e)
        {
            OrdenarAscendente();
        }
    }
}
