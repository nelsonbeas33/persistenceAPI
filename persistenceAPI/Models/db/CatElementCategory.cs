using System;
using System.Collections.Generic;

#nullable disable

namespace Models.db
{
    public partial class CatElementCategory
    {
        public CatElementCategory()
        {
            ElementCategories = new HashSet<ElementCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<ElementCategory> ElementCategories { get; set; }
    }
}
