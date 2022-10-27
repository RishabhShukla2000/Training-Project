using System;
using System.Collections.Generic;

namespace Training_Project.Models
{
    public partial class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; } = null!;
        public int? CategoryId { get; set; }

        public virtual Book? Category { get; set; }
    }
}
