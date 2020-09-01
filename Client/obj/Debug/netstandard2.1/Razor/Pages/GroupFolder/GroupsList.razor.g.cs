#pragma checksum "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2a1c9b62b22fb10ac4fdbb69145a5f2c9f4912"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/groups")]
    public partial class GroupsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Groups</h3>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\r\n    <a class=\"btn btn-success\" href=\"groups/create\"><i class=\"oi oi-plus\"></i> Create New</a>\r\n</div>\r\n<br>\r\n");
#nullable restore
#line 10 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
 if (groups == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "Loading...");
#nullable restore
#line 12 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
                           
}
else if (groups.Length == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "No Records Found.");
#nullable restore
#line 16 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
                                  
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-striped");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Group Name</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 29 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
             foreach (Groups group in groups)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 32 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
                         group.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 33 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
                         group.GroupName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "btn btn-success");
            __builder.AddAttribute(24, "href", "groups/edit/" + (
#nullable restore
#line 35 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
                                                                      group.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-danger");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
                                                                   () => Delete(group.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 39 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 42 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsList.razor"
       
    Groups[] groups { get; set; }
    protected override async Task OnInitializedAsync()
    {
        groups = await client.GetFromJsonAsync<Groups[]>("api/groups");
    }
    async Task Delete(int groupsId)
    {
        var grp = groups.First(x => x.Id == groupsId);
        if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {grp.GroupName}'s ({grp.Id}) Record?"))
        {
            await client.DeleteAsync($"api/groups/{groupsId}");
            await OnInitializedAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
