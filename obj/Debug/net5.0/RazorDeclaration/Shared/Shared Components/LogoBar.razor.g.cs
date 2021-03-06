// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
