#pragma checksum "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2100353b7b6cc913cf41b15782f79fcab1a8011c"
// <auto-generated/>
#pragma warning disable 1591
namespace CugemderPortal.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using CugemderPortal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using CugemderPortal.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
using CugemderPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n");
#nullable restore
#line 15 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
         if (forecasts == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(5, "            ");
                __builder2.AddMarkupContent(6, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 18 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(7, "            ");
                __builder2.OpenElement(8, "table");
                __builder2.AddAttribute(9, "class", "table");
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.AddMarkupContent(11, @"<thead>
                    <tr>
                        <th>Date</th>
                        <th>Temp. (C)</th>
                        <th>Temp. (F)</th>
                        <th>Summary</th>
                    </tr>
                </thead>
                ");
                __builder2.OpenElement(12, "tbody");
                __builder2.AddMarkupContent(13, "\r\n");
#nullable restore
#line 31 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
                     foreach (var forecast in forecasts)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(14, "                        ");
                __builder2.OpenElement(15, "tr");
                __builder2.AddMarkupContent(16, "\r\n                            ");
                __builder2.OpenElement(17, "td");
                __builder2.AddContent(18, 
#nullable restore
#line 34 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
                                 forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                            ");
                __builder2.OpenElement(20, "td");
                __builder2.AddContent(21, 
#nullable restore
#line 35 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
                                 forecast.TemperatureC

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                            ");
                __builder2.OpenElement(23, "td");
                __builder2.AddContent(24, 
#nullable restore
#line 36 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
                                 forecast.TemperatureF

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 37 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
                                 forecast.Summary

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n");
#nullable restore
#line 39 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(30, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 42 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(33, "    ");
            }
            ));
            __builder.AddAttribute(34, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n        Not Authorized\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
