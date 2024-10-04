using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _10_API_TechStore.Models
{
    public class ProductCategory
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}
        [Column("name")]
        public string? name {get; set;}
        [Column("description")]
        public string? description {get; set;}

    }
}