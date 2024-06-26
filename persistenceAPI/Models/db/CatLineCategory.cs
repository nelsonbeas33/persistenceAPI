﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Models.db
{
    public partial class CatLineCategory
    {
        public CatLineCategory()
        {
            LineCategories = new HashSet<LineCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<LineCategory> LineCategories { get; set; }
    }
}
