#pragma checksum "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5f8111d1813836392b032aa17c8c11c6834a28d"
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
#line 1 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using CugemderPortal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using CugemderPortal.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using CugemderPortal.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/claims")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\Pages\Index.razor"
 if (roles == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p> Loading</p>\r\n");
#nullable restore
#line 11 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\Pages\Index.razor"
}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\Pages\Index.razor"
     foreach (var role in roles)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 17 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\Pages\Index.razor"
         role

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 17 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\Pages\Index.razor"
             
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\Pages\Index.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Kaan\Desktop\Cugemder Portal\Cugemder Portal Final\CugemderPortal\Client\Pages\Index.razor"
       

            string[] roles;

    protected override async Task OnInitializedAsync()
        {
            roles = await http.GetFromJsonAsync<string[]>("roles");
        }


    //private string _authMessage;
    //private string _userId;
    //private AspNetUsers _username;
    //private string name;
    //private IEnumerable<Claim> _claims = Enumerable.Empty<Claim>();

    //protected override async Task OnParametersSetAsync()
    //{
    //    await GetClaimsPrincipalData();
    //    await base.OnParametersSetAsync();
    //}

    //private async Task GetClaimsPrincipalData()
    //{
    //    var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
    //    var user = authState.User;

    //    if (user.Identity.IsAuthenticated)
    //    {
    //        _authMessage = $"{user.Identity.Name} is authenticated.";
    //        _claims = user.Claims;
    //        _userId = $"User Id: {user.FindFirst(c => c.Type == "sub")?.Value}";

    //        _username = await http.GetFromJsonAsync<AspNetUsers>($"api/AspNetUsers/username/{_userId}");

    //        name = _username.FirstName + ' ' + _username.SurName;
    //    }
    //    else
    //    {
    //        _authMessage = "The user is NOT authenticated.";
    //    }
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
