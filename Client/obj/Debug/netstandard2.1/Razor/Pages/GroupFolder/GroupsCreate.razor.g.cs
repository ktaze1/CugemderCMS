#pragma checksum "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\Pages\GroupFolder\GroupsCreate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1f8fee2ccac15400c7aaa173b5aa60fb91d1e29"
// <auto-generated/>
#pragma warning disable 1591
namespace CugemderPortal.Client.Pages.GroupFolder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using CugemderPortal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using CugemderPortal.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using CugemderPortal.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class GroupsCreate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2> Create Group </h2>\r\n\r\n");
            __builder.OpenComponent<CugemderPortal.Client.Pages.GroupFolder.GroupsForm>(1);
            __builder.AddAttribute(2, "ButtonText", "Create Group");
            __builder.AddAttribute(3, "group", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CugemderPortal.Shared.Models.Groups>(
#nullable restore
#line 7 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\Pages\GroupFolder\GroupsCreate.razor"
                                      group

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\Pages\GroupFolder\GroupsCreate.razor"
                                                             CreateGroup

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Kaan\Desktop\CugemderPortal\CugemderPortalFinal\CugemderPortal\Client\Pages\GroupFolder\GroupsCreate.razor"
       
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
