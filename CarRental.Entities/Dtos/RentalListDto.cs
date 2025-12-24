using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Dtos
{
    public class RentalListDto
    {
        public int Id { get; set; }        
        public string Plate { get; set; }
        public string CustomerFullName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
