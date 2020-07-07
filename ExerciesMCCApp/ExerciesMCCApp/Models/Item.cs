using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExerciesMCCApp.Models
{
    [Table("TB_M_Item")]
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int SupplierId { get; set; }

        [ForeignKey("Supplier")]
        public int supp_Id { get; set; }
        public Supplier Supplier { get; set; }
    }
}