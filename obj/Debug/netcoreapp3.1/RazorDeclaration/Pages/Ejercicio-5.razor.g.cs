#pragma checksum "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2788d061f9289b978d87b3d5a2d62b38e4dcdc7d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea_5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\crist\Desktop\Programacion III\Tarea-5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Programacion III\Tarea-5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\crist\Desktop\Programacion III\Tarea-5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\crist\Desktop\Programacion III\Tarea-5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\crist\Desktop\Programacion III\Tarea-5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\crist\Desktop\Programacion III\Tarea-5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\crist\Desktop\Programacion III\Tarea-5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\crist\Desktop\Programacion III\Tarea-5\_Imports.razor"
using Tarea_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\crist\Desktop\Programacion III\Tarea-5\_Imports.razor"
using Tarea_5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor"
using Tarea_5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor"
using Tarea_5.Dbcontext;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio-5")]
    public partial class Ejercicio_5 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor"
       
    public static List<OrderDetails> Order {get; set;}
    public static List<Products> Product {get; set;}
    public static IEnumerable<Query> query {get; set;}

    protected override async Task OnInitializedAsync()
    {
        Order = new northwindContext().OrderDetails.ToList();
        Product = new northwindContext().Products.ToList();

        query = Order.OrderByDescending(o => o.Quantity).GroupJoin(
            Product,
            order => order.ProductId,
            product => product.Id,
            (order, product) => new Query {
                OrderDetails = order,
                Products = product
            }).AsEnumerable();
    }

    public class Query
    {
        public IEnumerable<Products> Products {get; set;}
        public OrderDetails OrderDetails {get; set;}
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
