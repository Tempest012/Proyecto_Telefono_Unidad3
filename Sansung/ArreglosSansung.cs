﻿using Proyecto_Telefono_Unidad3.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Telefono_Unidad3.Sansung
{
    public partial class ArreglosSansung : Form
    {
        string[] nombres = new string[100];
        string[] modelos = new string[100];
        int[] memoria = new int[100];
        int indice = 0;

        public ArreglosSansung()
        {

            InitializeComponent();




        }




        public void insertar()
        {
            // Verificar si hay espacio disponible en los arreglos
            if (indice < nombres.Length)
            {
                // Almacenar el nombre, modelo y memoria en los arreglos
                nombres[indice] = Convert.ToString(textBox1.Text);
                modelos[indice] = Convert.ToString(textBox2.Text);
                memoria[indice] = Convert.ToInt32(textBox3.Text);

                // Incrementar el índice
                indice++;

                // Puedes imprimir los arreglos o realizar otras operaciones según tus necesidades
                ImprimirArreglos();
            }
            else
            {
                MessageBox.Show("Se ha alcanzado el límite de los arreglos. No se pueden agregar más datos.");
            }

        }
        public void ImprimirArreglos()
        {
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine($"Nombre {i + 1}: {nombres[i]}, Modelo {i + 1}: {modelos[i]}, Memoria {i + 1}: {memoria[i]} GB");
            }

        }

        public void mostrarTS()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Modelo";
            dataGridView1.Columns[2].Name = "Memoria";


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = false;
            }

            // Verificar si la lista de teléfonos no está vacía
            if (indice > 0)
            {
                // Agregar filas al DataGridView con los datos correspondientes
                for (int i = 0; i < indice; i++)
                {
                    // int nuevoprecio = Console.ReadLine;
                    // arreglo [nuevoprecio] = conver.toint32(Console.Readline);
                    dataGridView1.Rows.Add(nombres[i], modelos[i], memoria[i]);
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar en el DataGridView.");
            }



        }




        private void ArreglosSansung_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            insertar();
            mostrarTS();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }



        public void Editar_Click(object sender, EventArgs e)
        {
            int Indice = 0;
            bool Encontrado = false;
            string Buscado = pato.Text;

            while (Indice < indice && !Encontrado)
            {
                if (nombres[Indice] == Buscado)
                {
                    nombres[Indice] = textBox1.Text;
                    modelos[Indice] = textBox2.Text;

                    // Asegurémonos de manejar la conversión de manera segura para evitar excepciones
                    if (int.TryParse(textBox3.Text, out int nuevaMemoria))
                    {
                        memoria[Indice] = nuevaMemoria;
                        Encontrado = true;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor válido para la memoria (número entero).");
                        return; // Salir del método si la conversión falla
                    }
                }
                Indice++;
            }

            if (!Encontrado)
            {
                MessageBox.Show("No se encontró el nombre proporcionado en el arreglo.");
            }
            else
            {
                // Puedes imprimir los arreglos o realizar otras operaciones según tus necesidades
                ImprimirArreglos();
            }
            mostrarTS();
        }



        public void Eliminar_Click(object sender, EventArgs e)
        {
            int Indice = 0;
            bool Encontrado = false;
            string Buscado = pato.Text;

            while (Indice < indice && !Encontrado)
            {
                if (nombres[Indice] == Buscado)
                {
                    // Desplazar los elementos restantes para llenar el espacio eliminado
                    for (int i = Indice; i < indice - 1; i++)
                    {
                        nombres[i] = null;
                        modelos[i] = null;
                        memoria[i] = 0;
                    }

                    // Decrementar el índice
                    indice--;

                    Encontrado = true;
                    MessageBox.Show($"El elemento {Buscado} ha sido eliminado correctamente.");

                    // Puedes imprimir los arreglos o realizar otras operaciones según tus necesidades
                    ImprimirArreglos();

                    break; // Salir del bucle una vez que se ha encontrado y eliminado el elemento
                }
                Indice++;
            }

            if (!Encontrado)
            {
                MessageBox.Show("No se encontró el nombre proporcionado en el arreglo. No se realizó la eliminación.");
            }

            mostrarTS(); // Mostrar los datos actualizados después de la eliminación
        }


        public void EditarArrglo()
        { 
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pato_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
