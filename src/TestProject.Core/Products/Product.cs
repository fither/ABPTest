using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Products
{
    public partial class Product: Entity<int>
    {

        public string Name { get; set; }
        public int Quantity{ get; set; }
    }
}
