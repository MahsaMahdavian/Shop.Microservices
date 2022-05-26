using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Domain.Base
{
    public class PaginitionResDto<T>
    {
        public T Data { get; set; } 
        public  int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int PageIndex { get; set; }
    }
}
