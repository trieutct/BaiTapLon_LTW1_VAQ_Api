using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public long Gia { get; set; }
        public long SoLuong { get; set; }
        public string MoTa { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
