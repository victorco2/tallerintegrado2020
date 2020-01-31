using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Calificacion
    {
        public int Id_Semestre { get; set; }
        public int Id_Curso { get; set; }
        public int Id_Seccion { get; set; }
        public int Id_Asignatura { get; set; }
        public int Id_Estudiante { get; set; }
        public float N1{ get; set; }
        public float N2 { get; set; }
        public float N3 { get; set; }
        public float N4 { get; set; }
        public float N5 { get; set; }

        public float Promedio { get; set; }



    }
}
