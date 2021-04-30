using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concreate
{
    public class Category
    {
        [Key]
        public int categoryID { get; set; }
        [StringLength(50)]
        public  string categoryName { get; set; }
        [StringLength(200)]
        public  string categoryDescription { get; set; }
        public bool categoryStatus { get; set; }

         public ICollection<Heading> Headings { get; set; }
    }
}
