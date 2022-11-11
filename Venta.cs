using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloProyectoFinal_VictorPolo
{
    public class Venta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }

        public Venta() { }

        public Venta(int id, string comentarios)
        {
            Id = id;
            Comentarios = comentarios;
        }
    }  
    
}
