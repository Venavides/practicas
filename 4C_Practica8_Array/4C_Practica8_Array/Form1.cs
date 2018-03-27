using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _4C_Practica8_Array
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] Valores;
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int cantidad = Convert.ToInt32(this.txtCantidad.Text);

            Valores = new int[cantidad];
            this.lstValores.Items.Clear();//limpia los valores 

            for (int x = 0; x < cantidad; x++)
            {
                int numero = rnd.Next(Convert.ToInt32(this.txtIntervalo.Text));
                Valores[x] = numero;
                this.lstValores.Items.Add(Valores[x]);
            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            StreamReader archivo = new StreamReader("C:\\ED4C\\valores.txt");

            int cantidad = Valores.Count();
            for (int x = 0; x < cantidad; x++) ;
            {
                archivo.writeLine(valores[x]);

            }
            archivo.flush();
            archivo.Close();
           
            System.Diagnostics.Process.Start("C:\\ED4C\\valores.txt");

        }
    }
}
