using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4C2017_Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            p1.asignaNombre = this.txtNombre.Text;
            p1.asignaEdad = Convert.ToInt16(this.txtEdad.Text);

             MessageBox.Show("la persona es: " + p1.obtenerEstatus);
        }
    }
}
