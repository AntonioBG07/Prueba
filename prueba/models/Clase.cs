using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.models
{
    class Clase
    {
        public Profesor profe { get; set; }
        public IList<Alumno> alumnos { get; set; }

        public Clase(Profesor profe, IList<Alumno> alumnos)
        {
            this.profe = profe;
            this.alumnos = alumnos;
        }

        public float CalcularMedia() {
            return alumnos.Average(x => x.Nota);
                                    //x => x.Nota Quiere decir que para todo alumno "x" usa su campo Nota
        }

        public void EvaluarTodos(){
            Console.WriteLine("-[EVALUANDO]-");
            foreach (var a in alumnos) {
                var nota = LeerNota(a);
                profe.Evaluar(a, nota);
                    
            }

        public float LeerNota(Alumno a) {
            Console.WriteLine(String.Format("{0} nota ->", a));
            var notaStr = Console.ReadLine();
            var nota = 0f;
            float.TryParse(notaStr, out nota);
            return nota;
        }
        }

    }
}
