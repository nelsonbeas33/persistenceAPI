using System;
using System.Collections.Generic;

#nullable disable

namespace Models.db
{
    public partial class LineCategory
    {
        public int Id { get; set; }
        public int CatLineCategoryId { get; set; }
        public int LineId { get; set; }

        public virtual CatLineCategory CatLineCategory { get; set; }
        public virtual Line Line { get; set; }
    }
}
