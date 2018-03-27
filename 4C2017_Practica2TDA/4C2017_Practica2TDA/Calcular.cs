using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4C2017_Practica2TDA
{
    class Calcular
    {
        private string nombre;
        private DateTime fechaNac;
        private int edad;
        private string estatus;

        public string asignaNombre
        {
            set 
            { 
                nombre = value; 
            }
            get 
            {
                return nombre; 
            }
        }
        public DateTime asignaFecha
        {
            set
            {
                fechaNac = value;
            }
        }
        public int calcularEdad
        {
            get
            {
                TimeSpan direfencia;
                direfencia = DateTime.Now - fechaNac;
                edad = (direfencia.Days / 365);
                return edad;
            }
        }
        public string obtenerEstatus
        {
            get
            {
                if (edad >= 18)
                {
                    estatus = "mayor de edad ";
                }
                else
                {
                    estatus = "menor de edad ";
                }
                return estatus;
            }
        }
       
    }

    
}
