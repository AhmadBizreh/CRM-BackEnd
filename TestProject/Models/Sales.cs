using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Sales
    {
        [Required]
        public int SalesId { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public decimal Ordertax = 14 * 100 / 100 ;
        [Required]
        public decimal Subtotal { get; set; }
        [Required]
        public decimal Grandtotal{ get { return Subtotal - Ordertax; }}



        public Customer Customer { get; set; }
        public string CustomerId { get; set; }


        public Address Address { get; set; }
        public string AddressId { get; set; }

    }
}
