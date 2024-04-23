using System;
using System.Collections.Generic;

#nullable disable

namespace Models.db
{
    public partial class CatMaintenanceCategory
    {
        public CatMaintenanceCategory()
        {
            MaintenanceCategories = new HashSet<MaintenanceCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<MaintenanceCategory> MaintenanceCategories { get; set; }
    }
}
