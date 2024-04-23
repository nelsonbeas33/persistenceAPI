using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.PostArguments
{
    public class LineJsonelement
    {
        //id de la tabla que relaciona elemento - linea
        //a pesar que el id es int, se maneja como string ya que los nuevos elementos vienen con formato: N1_1 -> N + elementoid_counter
        public string Id { get; set; }
        public string Top { get; set; }
        public string Left { get; set; }
    }
}
