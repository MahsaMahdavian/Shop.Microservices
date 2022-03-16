using products.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products.Domain.Categories
{
    public class CategoryReqDto : CategoryDtos
    {
        public int CategoryId { get; set; }
    }
    public class CategoryResDto : CategoryDtos
    {
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
    }
    public class CategoryDtos: BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Permalink { get; set; }
        public bool Active { get; set; }
        public int Priority { get; set; }
        public string BannerUrl { get; set; }
        public string IconUrl { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
