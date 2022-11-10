using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class SalesorderDetail
    {
        [Required]
        public int SalesorderDetailId { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Orderedqty { get; set; }


        [Required]
        public decimal Taxamount { get; set; }


        [Required]
        public decimal Total { get { return Orderedqty * Price; } }




        public Sales Sales { get; set; }
        public string SalesId { get; set; }

        public Product Product { get; set; }
        public string ProductId { get; set; }
    }

}
