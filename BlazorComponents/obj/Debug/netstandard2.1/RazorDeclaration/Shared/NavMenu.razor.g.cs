#pragma checksum "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b2ee0f90ccd53a5bfa0252d19507530bd4f913c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorComponents.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\_Imports.razor"
using BlazorComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\_Imports.razor"
using BlazorComponents.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\_Imports.razor"
using BlazorComponents.Pages;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
