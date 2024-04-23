using conn;
using Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace persistenceAPI.conn
{
    public class db
    {
        public static Boolean insertLineElements(int lineId, int ElementId, string Top, string Left)
        {
            mantenimientoContext context = new();

            LineElement le = new() { LineId = lineId, ElementId = ElementId, Top = Top, Left = Left };
            context.Add(le);
            return true;
        }

    }
}
