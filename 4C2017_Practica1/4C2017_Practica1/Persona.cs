using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4C2017_Practica1
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string estatus;

        public string asignaNombre
        {
            set
            {
                nombre = value;
            }
        }
        public int asignaEdad
        {
            set
            {
                edad = value;
            }
        }
        public string obtenerEstatus
        {
            get
            {
                if (edad >= 18)
                {
                    estatus = "mayor de edad";
                }
                else 
                {
                    estatus = "menor de edad";
                }
                return estatus; 
            }
        }
    }
}
