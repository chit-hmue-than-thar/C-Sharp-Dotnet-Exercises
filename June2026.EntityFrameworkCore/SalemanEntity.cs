using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Model First Approach in Entity Framework Core
namespace June2026.EntityFrameworkCore
{
    [Table("Tbl_Saleman")] //mapping
    public class SalemanEntity
    {
        [Key]
        [Column("SalemanId")]
        public int Id { get; set; }

        [Column("SalemanName")]
        public string Name { get; set; }
    }
}
