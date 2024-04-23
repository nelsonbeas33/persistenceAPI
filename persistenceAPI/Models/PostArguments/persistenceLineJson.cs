using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.PostArguments
{
    public class persistenceLineJson
    {
        public int lineId { get; set; }
        public List<LineJsonelement> elements { get; set; }
    }
}
