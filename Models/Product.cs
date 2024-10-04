using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _10_API_TechStore.Models
{
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}
        [Column("name")]
        public string? name {get; set;}
        [Column("description")]
        public string? description {get; set;}
        [Column("price")]
        public int price {get; set;}
        [Column("stock")]
        public int stock {get; set;}
        [Column("categoryId")]
        public int categoryId {get; set;}
        [ForeignKey(nameof(categoryId))]
        public ProductCategory? ProductCategory{get; set;}
    }
}