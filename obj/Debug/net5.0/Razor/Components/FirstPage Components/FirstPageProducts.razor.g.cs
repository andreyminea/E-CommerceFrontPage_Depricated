#pragma checksum "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98f3b86628260170c8df7e09670d90e1286bbad7"
// <auto-generated/>
#pragma warning disable 1591
namespace IzonStore.Components.FirstPage_Components
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
    public partial class FirstPageProducts : Microsoft.AspNetCore.Components.ComponentBase
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
#line 3 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 4 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
             if (!displayLoading)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudGrid>(7);
                    __builder3.AddAttribute(8, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                  4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 7 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                     for (int i = 0; i < 20; i++)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudItem>(10);
                        __builder4.AddAttribute(11, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                             6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(13, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                                    4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                                           3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "xl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                                                  2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<IzonStore.Components.Products_Components.ItemShowcase>(17);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 12 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 14 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudGrid>(18);
                    __builder3.AddAttribute(19, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                  2

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 18 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                     for (int i = 0; i < 20; i++)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudItem>(21);
                        __builder4.AddAttribute(22, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                     12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(23, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                             6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(24, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                                    4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(25, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                                           3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(26, "xl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                                                                  2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<IzonStore.Components.Products_Components.ItemLoading>(28);
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 23 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 25 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
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
#line 30 "P:\Store\IzonStore\Components\FirstPage Components\FirstPageProducts.razor"
 
        bool displayLoading = false ;

        protected override async void OnInitialized()
        {
            this.StateHasChanged();
        }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
