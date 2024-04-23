using System;
using System.Collections.Generic;

#nullable disable

namespace Models.db
{
    public partial class MaintenanceCategory
    {
        public int Id { get; set; }
        public int CatMaintenanceCategoryId { get; set; }
        public int MaintenanceId { get; set; }

        public virtual CatMaintenanceCategory CatMaintenanceCategory { get; set; }
        public virtual Maintenance Maintenance { get; set; }
    }
}
