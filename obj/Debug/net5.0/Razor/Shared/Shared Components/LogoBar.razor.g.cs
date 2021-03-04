#pragma checksum "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b9455b1df68ecad71e23e2c66b8513a9921ed2c"
// <auto-generated/>
#pragma warning disable 1591
namespace IzonStore.Shared.Shared_Components
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
    public partial class LogoBar : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                  10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Justify", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Justify>(
#nullable restore
#line 5 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                               Justify.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(4);
                __builder2.AddAttribute(5, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                         12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                 4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                        4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "xl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                               4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "<img src=\"images/logo.png\" style=\"width:210px; height:70px;\">");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(13);
                __builder2.AddAttribute(14, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                       4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "xl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                              4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Style", "vertical-align:central");
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudInput<string>>(21);
                    __builder3.AddAttribute(22, "Style", "margin-top:10px; border:outset; border-color: gray; border-width: 1px; border-radius:20px; padding:5px; padding-left:20px; padding-right:20px; width: 300px");
                    __builder3.AddAttribute(23, "AdornmentIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                  Icons.Material.Search

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Adornment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Adornment>(
#nullable restore
#line 11 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                                    Adornment.End

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "DisableUnderLine", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "FullWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "Placeholder", "Cauta ce iti doresti");
                    __builder3.AddAttribute(28, "OnAdornmentClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                    ()=> { }

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(29, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 13 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                        Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(31);
                __builder2.AddAttribute(32, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                         6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "lg", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                       4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "xl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                              4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Style", "vertical-align: central; text-align:end;");
                __builder2.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudBadge>(39);
                    __builder3.AddAttribute(40, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                         Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                                 fav.GetDataCount()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(44);
                        __builder4.AddAttribute(45, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                  Icons.Material.Favorite

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(46, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 17 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                                 Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(47, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 17 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                                                    Color.Error

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudBadge>(49);
                    __builder3.AddAttribute(50, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                         Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "Overlap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                 true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                                 cart.GetDataCount()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(54);
                        __builder4.AddAttribute(55, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                  Icons.Material.ShoppingCart

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(56, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 20 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                                     Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(57, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 20 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
                                                                                        Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "P:\Store\IzonStore\Shared\Shared Components\LogoBar.razor"
       
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        await cart.GetAllDataAsync();
        await fav.GetAllDataAsync();
        cart.ChangeNotification += Refresh;
        fav.ChangeNotification += Refresh;
        this.StateHasChanged();
    }
    // 

    public void Refresh()
    {
        this.StateHasChanged();
    }

    public void Dispose()
    {
        cart.ChangeNotification -= Refresh;
        fav.ChangeNotification -= Refresh;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FavoritesService fav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CartService cart { get; set; }
    }
}
#pragma warning restore 1591