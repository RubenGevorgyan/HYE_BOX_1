using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HYE_BOX.Models
{
    [Table("Data")]
    public class DataModel 
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Child_name { get; set; }
        [Required]
        public string Child_age { get; set; }
    }
}