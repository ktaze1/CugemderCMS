#pragma checksum "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4735796422c5189f851796076d2273e169ab811"
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
    public partial class GroupsForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsForm.razor"
                  group

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 2 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsForm.razor"
                                         OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label>Group Name :</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsForm.razor"
                                     group.GroupName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => group.GroupName = __value, group.GroupName))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => group.GroupName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __Blazor.CugemderPortal.Client.Pages.GroupFolder.GroupsForm.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 8 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsForm.razor"
                                      () => group.GroupName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "button");
                __builder2.AddAttribute(24, "type", "submit");
                __builder2.AddAttribute(25, "class", "btn btn-success");
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.AddContent(27, 
#nullable restore
#line 12 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsForm.razor"
         ButtonText

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Kaan\Desktop\CUGEMDER\CugemderPortal\CugemderCMS\Client\Pages\GroupFolder\GroupsForm.razor"
       
    [Parameter] public Groups group { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

    DateTime time = DateTime.UtcNow;

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.CugemderPortal.Client.Pages.GroupFolder.GroupsForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
