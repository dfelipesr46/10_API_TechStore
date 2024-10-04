using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _10_API_TechStore.Models
{
    public class OrderProduct
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}
        [Column("amount")]
        public int amount {get; set;}
        [Column("productId")]
        public int productId {get; set;}
        [Column("orderId")]
        public int orderId {get; set;}
        [ForeignKey(nameof(orderId))]
        public Order? Order{get; set;}
        
    }
}