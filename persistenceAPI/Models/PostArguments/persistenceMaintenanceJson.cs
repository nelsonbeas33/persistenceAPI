using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.db.postModels
{
    public class persistenceMaintenanceJson
    {
        public int line_element_id { get; set; }
        public string user_id { get; set; } //cambia a int cuando se tengan usuarios
        public string name { get; set; }
        public string root_cause { get; set; }
        public string sub_cause { get; set; }
        public int date_day { get; set; }
        public int date_year { get; set; }
        public int date_month { get; set; }
        public string desc { get; set; }
        public string success { get; set; }
        public int maintenance_category_id { get; set; }


    }
}
