using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.models
{
    abstract class Persona
    {

        public string nombre;
        public string apellidos;
        private int edad;

        
        public Persona(string nombre, string apellidos, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            Edad = this.edad;
        }

        public int Edad{
            get{
                return edad;
            }
            set{
                if (value < 0) {
                    throw new Exception("No puede ser menos de 0");
                }
                edad = value;
            }
        }
        abstract public void Saludar(string msg);
        public void Andar() {
            Console.WriteLine("Estoy andando");
        }
    }
}
