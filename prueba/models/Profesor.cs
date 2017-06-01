using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.models
{
    class Profesor :Persona
    {
        private float sueldo;

        public Profesor(float sueldo, string nombre, string apellidos, int edad)
            :base(nombre, apellidos, edad)
        {
            this.sueldo = sueldo;
        }

        public float Sueldo
        {
            get
            {
                return sueldo;
            }

            set
            {
                sueldo = value;
            }
        }

        public void Regañar(string a) {
            Console.WriteLine(a);
        }
        public void Evaluar(Alumno a, float nota) {
            a.Nota = nota;
        }
        public override void Saludar(string msg){
            Console.WriteLine(msg);
        }

    }
}
