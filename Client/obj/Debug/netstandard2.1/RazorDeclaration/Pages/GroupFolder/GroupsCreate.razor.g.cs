#pragma checksum "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8041503587c008f788611591d02c71b948cfc7ba"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CugemderPortal.Client.Pages.GroupFolder
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
#line 11 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\_Imports.razor"
using CugemderPortal.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/groups/create")]
    public partial class GroupsCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsCreate.razor"
       
    Groups group = new Groups();
    async Task CreateGroup()
    {
        group.CreatedAt = DateTime.UtcNow;
        await http.PostAsJsonAsync<Groups>("api/Groups", group);
        uriHelper.NavigateTo("groups");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
