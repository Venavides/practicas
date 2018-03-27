using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4C2017_Practica2TDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calcular persona = new Calcular();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
            persona.asignaNombre = this.txtNombre.Text;
            persona.asignaFecha = this.dtpFecha.Value;
            MessageBox.Show("la persona: " + persona.asignaNombre + "\n" + "tiene: " + persona.calcularEdad + "años la persona es " + persona.obtenerEstatus);
            this.btnImprimir.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imprimir print = new Imprimir();

            print.asignaUbicacionArchivo = "C:\\ED4C\\edad.txt";
            print.escribir = "informacion de la persona:";
            print.escribir = "Nombre:" + persona.asignaNombre;
            print.escribir = "fecha de nacimiento:" + this.dtpFecha.Value;
            print.escribir = "edad:" + persona.calcularEdad.ToString();
            print.escribir = "La persona es " + persona.obtenerEstatus;
            print.liberar();
            print.cerar();
            print.abrirArchivo();
        }
    }
}
