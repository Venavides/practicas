using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//libreria permite trabajar entradeas y salidas de datos en pc


namespace _4C2017_Practica2TDA
{
    class Imprimir
    {
        private string ubicacionArchivo; //se guarda el archivo
        StreamWriter archivo;// clase stream permite crear un archivo

        public string asignaUbicacionArchivo
        {
            set
            {
                ubicacionArchivo = value;
                archivo = new StreamWriter(ubicacionArchivo);
            }
        }
        public string escribir
        {
            set
            {
                archivo.WriteLine(value);
            }
        }
        public void liberar()
        {
            archivo.Flush();
        }

        public void cerar()
        {
            archivo.Close();
        }
        public void abrirArchivo()
        {
            System.Diagnostics.Process.Start(ubicacionArchivo);
        }

    }
}
