using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.models
{
    class Alumno :Persona
    {
        private string NumMatricula;
        private float nota;

        public Alumno(string nombre, string apellidos, int edad, string numMatricula, float nota):
            base(nombre, apellidos, edad)
        {
            NumMatricula = numMatricula;
            Nota = 0;
        }

        public string NumMatricula1
        {
            get
            {
                return NumMatricula;
            }

            set
            {
                NumMatricula = value;
            }
        }

        public float Nota
        {
            get
            {
                return nota;
            }

            set
            {
                if (value < 0 || value > 10) {
                    throw new Exception("[ERROR].-la nota debe estar entre 0-10");
                }
                this.nota = value;
            }
        }

        public void Quejarse(string queja) {
            Console.WriteLine(queja);
        }

        public override void Saludar(string msg){
            Console.WriteLine(msg);
        }

    }
}
