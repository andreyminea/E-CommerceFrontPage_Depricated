#pragma checksum "P:\Store\IzonStore\Components\FirstPage Components\ImageWheel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6766b3ed8f84936af0deac896af8e84996f445c8"
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
    public partial class ImageWheel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudGrid>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(4, "div");
                    __builder3.AddAttribute(5, "class", "pic-ctn");
                    __builder3.AddAttribute(6, "style");
#nullable restore
#line 6 "P:\Store\IzonStore\Components\FirstPage Components\ImageWheel.razor"
             foreach (ImgSliderItem obj in items)
            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(7, "img");
                    __builder3.AddAttribute(8, "src", 
#nullable restore
#line 8 "P:\Store\IzonStore\Components\FirstPage Components\ImageWheel.razor"
                           obj.Source

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(9, "alt");
                    __builder3.AddAttribute(10, "class", "pic");
                    __builder3.CloseElement();
#nullable restore
#line 10 "P:\Store\IzonStore\Components\FirstPage Components\ImageWheel.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n\r\n<link href=\"/css/Components.css\" rel=\"stylesheet\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "P:\Store\IzonStore\Components\FirstPage Components\ImageWheel.razor"
       

    IList<ImgSliderItem> items = new List<ImgSliderItem>
    {
        new ImgSliderItem
        {
            Source = "/images/asus.jpg",
            Alt = "First Slide",
            Caption = "Slide 1",
            Header = "Slide 1 Header"

        },
        new ImgSliderItem
        {
            Source = "/images/intel.jpg",
            Alt = "Second Slide",
            Caption = "Slide 2",
            Header = "Slide 2 Header"

        },
        new ImgSliderItem
        {
            Source = "/images/rtx.jpg",
            Alt = "Third Slide",
            Caption = "Slide 3",
            Header = "Slide 3 Header"

        }
    };


    class ImgSliderItem
    {
        public String Source { get; set; } = "";
        public String Alt { get; set; } = "";
        public String Caption { get; set; } = "";
        public String Header { get; set; } = "";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
