// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WeatherForecast.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\_Imports.razor"
using WeatherForecast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\_Imports.razor"
using WeatherForecast.Shared;

#line default
#line hidden
#nullable disable
    public partial class DailyForecast : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\Shared\DailyForecast.razor"
       
    [Parameter] public long Seconds { get; set; }
    [Parameter] public double HighTemp { get; set; }
    [Parameter] public double LowTemp { get; set; }
    [Parameter] public string Description { get; set; }
    [Parameter] public string Icon { get; set; }
    private string Date;
    private string IconUrl;

    protected override void OnInitialized()
    {
        Date = DateTimeOffset
        .FromUnixTimeSeconds(Seconds)
        .LocalDateTime
        .ToLongDateString();

        IconUrl = String.Format("https://openweathermap.org/img/wn/{0}@2x.png", Icon);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
