#pragma checksum "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0867a6c07ff473931a92bf5b1a3f8dc55c03315"
// <auto-generated/>
#pragma warning disable 1591
namespace IzonStore.Components.Products_Components
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
    public partial class ItemShowcase : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                    3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Class", "productcard");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCardHeader>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.AddMarkupContent(6, "<div style=\"height:200px;\"><img src=\"https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.lowyat.net%2Fwp-content%2Fuploads%2F2017%2F08%2Fhp-omen-x-laptop-2.jpg&f=1&nofb=1\" style=\"height:inherit; display:block; margin:auto\"></div>\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardContent>(7);
                __builder2.AddAttribute(8, "Style", "text-align:center");
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(10);
                    __builder3.AddAttribute(11, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 11 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                       Typo.subtitle1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Class", "tooltip");
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(14, "div");
                        __builder4.AddAttribute(15, "class", "cardTitle");
                        __builder4.AddContent(16, 
#nullable restore
#line 13 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                 title

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(17, "\r\n            ");
                        __builder4.OpenElement(18, "span");
                        __builder4.AddAttribute(19, "class", "tooltiptext");
                        __builder4.AddContent(20, 
#nullable restore
#line 16 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                 title

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(22);
                    __builder3.AddAttribute(23, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 19 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Class", "price");
                    __builder3.AddAttribute(25, "Style", "margin-top:20px;");
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(27, "4300 Lei");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardActions>(29);
                __builder2.AddAttribute(30, "Style", "justify-content:center;");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudButton>(32);
                    __builder3.AddAttribute(33, "Class", "cartbutton");
                    __builder3.AddAttribute(34, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 22 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                                               Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                                                                           Icons.Material.AddShoppingCart

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                                                                                                                    OnAddToCart

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(38, "\r\n            Adauga in cos\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(40);
                    __builder3.AddAttribute(41, "Style", "margin-top:-20px; margin-left:10px");
                    __builder3.AddAttribute(42, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                                                                          Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                                                                                              Icons.Material.Favorite

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 25 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                                                                                                                             Size.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
                                                                                                                                                   OnAddToFavorites

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n\r\n<link href=\"/css/Components.css\" rel=\"stylesheet\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "P:\Store\IzonStore\Components\Products Components\ItemShowcase.razor"
       
    string title = @"Laptop Gaming ASUS ROG Strix G15 G512LI cu procesor Intel® Core™ i7-10750H pana la 5.00 GHz, 15.6', Full HD, 144Hz, 8GB, 1TB SSD, NVIDIA® GeForce® GTX 1650 Ti 4GB, Free DOS, Black";

    private async Task OnAddToCart()
    {
        await cart.AddDataAsync("Laptop");
    }

    private async Task OnAddToFavorites()
    {
        await favorite.AddDataAsync("Laptop");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FavoritesService favorite { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CartService cart { get; set; }
    }
}
#pragma warning restore 1591
