using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Applicationn.Dto
{
    public class ProductDto
    {
        public int? Id { get; set; }
        public string TenSanPham { get; set; }
        public long Gia { get; set; }
        public long SoLuong { get; set; }
        public string MoTa { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
    }
}
