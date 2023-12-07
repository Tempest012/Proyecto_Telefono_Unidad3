using Proyecto_Telefono_Unidad3.Sansung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Telefono_Unidad3
{
    public partial class TelefonoSansung : Form
    {
        public TelefonoSansung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PilasSansung pilasSansung = new PilasSansung();
            pilasSansung.Show();
            this.Hide();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArreglosSansung arreglosSansung = new ArreglosSansung();
            arreglosSansung.Show();
            this.Hide();
        }

        private void TelefonoSansung_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListasSansung listasSansung = new  ListasSansung();
            listasSansung.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColasSansung colasSansung = new ColasSansung();
            colasSansung.Show();
            this.Hide();
        }
    }
}
