using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _10_API_TechStore.Models
{
    [Table("clients")]
    public class Client
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}
        [Column("name")]
        public string? name {get; set;}
        [Column("phoneNumber")]
        public string? phoneNumber {get; set;}
        [Column("email")]
        public string? email {get; set;}
        [Column("id_rol")]
        public int rolId {get; set;}
        [ForeignKey(nameof(rolId))] 
        public UserRol? UserRol {get; set;}
        
    }
}