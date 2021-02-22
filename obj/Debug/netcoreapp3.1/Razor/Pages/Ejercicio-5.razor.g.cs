#pragma checksum "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5202cfeb46934e8eed33e3e3971715dce85b814"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Consulta #5</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"row justify-content-center\">\r\n        <p>Las unidades vendidas de cada producto, mostradas de mayor a menor: producto y cantidad de unidades vendidas.</p>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col justify-content-center");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-hover table-bordered border-dark");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<thead>\r\n                <th>Product Id</th>\r\n                <th>Quantity</th>\r\n            </thead>\r\n            ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 17 "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor"
                 foreach (OrderDetails order in GetOrderDetails()) 
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                    ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 20 "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor"
                             order.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 21 "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor"
                             order.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 23 "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor"
       
    List<Products> GetProducts() => new northwindContext().Products.ToList();
    List<OrderDetails> GetOrderDetails() => new northwindContext().OrderDetails.ToList();
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\crist\Desktop\Programacion III\Tarea-5\Pages\Ejercicio-5.razor"
                       

    protected override async Task OnInitializedAsync()
    {
        var information = from o in GetOrderDetails()
                                join p in GetProducts()
                                on o.ProductId equals p.Id
                                select new {
                                    Quantity = o.Quantity,
                                    ProductName = p.ProductName
                                }; 
    }

    public class Query
    {
        public string ProductName {get; set;}
        public decimal Quatity {get; set;}
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
