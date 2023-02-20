using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budweg_Sprint1_Test.Models

{
     public class Order
        {
            public int OrderId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsCompleted { get; set; }

        }
}

