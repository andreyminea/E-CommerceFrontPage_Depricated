#pragma checksum "P:\Store\IzonStore\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f14de8f19523100b48ee0eed7b9ee4cb571a51f"
// <auto-generated/>
#pragma warning disable 1591
namespace IzonStore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "P:\Store\IzonStore\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\Store\IzonStore\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "P:\Store\IzonStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "P:\Store\IzonStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "P:\Store\IzonStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "P:\Store\IzonStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "P:\Store\IzonStore\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "P:\Store\IzonStore\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "P:\Store\IzonStore\_Imports.razor"
using IzonStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "P:\Store\IzonStore\_Imports.razor"
using IzonStore.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "P:\Store\IzonStore\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "P:\Store\IzonStore\_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "P:\Store\IzonStore\_Imports.razor"
using IzonStore.Components.Products_Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "P:\Store\IzonStore\_Imports.razor"
using IzonStore.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "P:\Store\IzonStore\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-left:3em; margin-right:3em;");
            __builder.OpenComponent<MudBlazor.MudGrid>(2);
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(4);
                __builder2.AddAttribute(5, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "P:\Store\IzonStore\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "P:\Store\IzonStore\Pages\Index.razor"
                             3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "<div style=\"width:inherit; height:1000px; background-color:ghostwhite\">\r\n                hello\r\n            </div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudItem>(10);
                __builder2.AddAttribute(11, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "P:\Store\IzonStore\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "P:\Store\IzonStore\Pages\Index.razor"
                             9

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 11 "P:\Store\IzonStore\Pages\Index.razor"
             if (!displayLoading)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudGrid>(14);
                    __builder3.AddAttribute(15, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "P:\Store\IzonStore\Pages\Index.razor"
                                  4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 14 "P:\Store\IzonStore\Pages\Index.razor"
                     for (int i = 0; i < 20; i++)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudItem>(17);
                        __builder4.AddAttribute(18, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "P:\Store\IzonStore\Pages\Index.razor"
                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "P:\Store\IzonStore\Pages\Index.razor"
                                             6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "P:\Store\IzonStore\Pages\Index.razor"
                                                    4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "P:\Store\IzonStore\Pages\Index.razor"
                                                           3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "xl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "P:\Store\IzonStore\Pages\Index.razor"
                                                                  2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<IzonStore.Components.Products_Components.ItemShowcase>(24);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 19 "P:\Store\IzonStore\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 21 "P:\Store\IzonStore\Pages\Index.razor"
            }else
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudGrid>(25);
                    __builder3.AddAttribute(26, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "P:\Store\IzonStore\Pages\Index.razor"
                                  2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 24 "P:\Store\IzonStore\Pages\Index.razor"
                     for (int i = 0; i < 5; i++)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudItem>(28);
                        __builder4.AddAttribute(29, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "P:\Store\IzonStore\Pages\Index.razor"
                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "P:\Store\IzonStore\Pages\Index.razor"
                                             6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "P:\Store\IzonStore\Pages\Index.razor"
                                                    4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(32, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "P:\Store\IzonStore\Pages\Index.razor"
                                                           3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "xl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "P:\Store\IzonStore\Pages\Index.razor"
                                                                  2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<IzonStore.Components.Products_Components.ItemLoading>(35);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 29 "P:\Store\IzonStore\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 31 "P:\Store\IzonStore\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "P:\Store\IzonStore\Pages\Index.razor"
      
    bool displayLoading = false;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
