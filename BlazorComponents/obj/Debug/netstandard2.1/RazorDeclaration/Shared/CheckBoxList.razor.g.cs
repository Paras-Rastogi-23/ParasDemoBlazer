#pragma checksum "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\Shared\CheckBoxList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f368d02b95d8cbca59ce22f56bc0f5ffb75597e"
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
    public partial class CheckBoxList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "P:\ayuLearn\TrBlazorEx-master-o\BlazorComponents\Shared\CheckBoxList.razor"
       
    //Data for the Checkbox 
    [Parameter] public IEnumerable<TItem> Data { get; set; }
    // The field to be shown adjacent to checkbox
    [Parameter] public Func<TItem, string> TextField { get; set; }
    // The Value which checkbox will return when checked 
    [Parameter] public Func<TItem, object> ValueField { get; set; }
    // CSS Style for the Checkbox container 
    [Parameter] public string Style { get; set; }
    // Any childd content for the control (if needed)
    [Parameter] public RenderFragment ChildContent { get; set; }
    // The array which contains the list of selected checkboxs 
    [Parameter] public List<string> SelectedValues { get; set; }

    //Method to update the selected value on click on checkbox 
    public void CheckboxClicked(string aSelectedId, object aChecked)
    {
        if ((bool)aChecked)
        {
            if (!SelectedValues.Contains(aSelectedId))
            {
                SelectedValues.Add(aSelectedId);
            }
        }
        else
        {
            if (SelectedValues.Contains(aSelectedId))
            {
                SelectedValues.Remove(aSelectedId);
            }
        }
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
