#pragma checksum "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e505137ab836641aed6ccfcd3f50481f5adb034d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp_Smple.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using BlazorApp_Smple;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using BlazorApp_Smple.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Prosot\source\repos\BlazorApp Smple\BlazorApp Smple\Pages\Index.razor"
      


    /// <summary>
    /// For seting Time to time picker
    /// </summary>
    ///
    public DateTime tTime { get; set; } = new DateTime(2020, 2, 5, 1, 25, 00);
    public DateTime minTime { get; set; } = new DateTime(2020, 2, 5, 1, 00, 00);
    public DateTime maxTime { get; set; } = new DateTime(2020, 2, 5, 12, 25, 00);

    /// <summary>
    /// For DataGrid
    /// </summary>
    public class temp
    {
        public int no { get; set; }
        public int number { get; set; }
        public int age { get; set; }
    }
    public List<temp> employeeData { get; set; }
    protected override void OnInitialized()
    {
        employeeData = Enumerable.Range(1, 10).Select(x => new temp()
        {
            no = 100 + x,
            number = 100 * x,
            age = (100 + x) - 5
        }).ToList();

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
