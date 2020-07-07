using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExerciesMCCApp.Models
{
    [Table("TB_M_Transaction")]
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public DateTimeOffset OrderDate { get; set; }
    }
}