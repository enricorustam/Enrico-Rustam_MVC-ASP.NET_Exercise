using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExerciesMCCApp.Models
{
    [Table("TB_M_Supplier")]
    public class Supplier
    {
        [Key]
        public int supp_Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset JoinDate { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}