using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace TestProject.Products
{
    public partial class Product
    {
        [AutoMapFrom(typeof(Product))]
        public class ProductDto : EntityDto<int>
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
        }
    }
}
