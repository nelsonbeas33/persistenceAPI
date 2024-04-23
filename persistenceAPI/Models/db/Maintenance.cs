using System;
using System.Collections.Generic;

#nullable disable

namespace Models.db
{
    public partial class Maintenance
    {
        public Maintenance()
        {
            MaintenanceCategories = new HashSet<MaintenanceCategory>();
        }

        public int Id { get; set; }
        public int LineElementId { get; set; }
        public int? UserId { get; set; }
        public DateTime? FinalDate { get; set; }
        public DateTime InicialDate { get; set; }
        public bool Success { get; set; }
        public string RootCause { get; set; }
        public string SubCause { get; set; }
        public string Desc { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MaintenanceCategory> MaintenanceCategories { get; set; }
    }
}
