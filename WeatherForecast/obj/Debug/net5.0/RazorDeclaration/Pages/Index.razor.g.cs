// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WeatherForecast.Pages
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
#nullable restore
#line 2 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\Pages\Index.razor"
using WeatherForecast.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\Pages\Index.razor"
using System.Text;

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
#line 27 "D:\Projects\C#\BlazorWasmBook\WeatherForecast\WeatherForecast\Pages\Index.razor"
       
    string message = "Loading...";
    Position pos;
    OpenWeather forecast;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await GetPosition();
            await GetForecast();
        }
        catch (Exception e)
        {
            message = "Error encountered: " + e.Message;
        }
    }

    private async Task GetPosition()
    {
        pos = await js.InvokeAsync<Position>("rsdInterop.getPosition");
    }

    private async Task GetForecast()
    {
        string APIKey = "f1806b131373ef76ea0698117ed38999";

        StringBuilder url = new StringBuilder();
        url.Append("https://api.openweathermap.org");
        url.Append("/data/2.5/onecall?");
        url.Append("lat=");
        url.Append(pos.Latitude);
        url.Append("&lon=");
        url.Append(pos.Longitude);
        url.Append("&exclude=");
        url.Append("current,minutely,hourly,alerts");
        url.Append("&units=imperial");
        url.Append("&appid=");
        url.Append(APIKey);

        forecast = await Http.GetFromJsonAsync<OpenWeather>(url.ToString());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
