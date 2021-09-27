// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using Bunit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using Bunit.TestDoubles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/limistah/work/dotnet/BlazorApp/_Imports.razor"
using Xunit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/limistah/work/dotnet/BlazorApp/Pages/Index.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 159 "/Users/limistah/work/dotnet/BlazorApp/Pages/Index.razor"
       
    private bool showCareGiverForm;
    private bool showPetForm;
    private CareGiver[] careGivers;
    private Pet[] pets;

    private string petName;
    private string careGiverName;
    private string careGiverEmail;
    private bool formHasError;
    private string addCareGiverError;
    private string addPetError;
    protected override async Task OnInitializedAsync()
    {
        careGivers = await CareGiverService.GetCareGiverAsync();
        pets = await PetService.GetPetAsync();
    }
    private void CreateCareGiver () 
    {
        CareGiver _careGiver = new CareGiver();
        _careGiver.Name = careGiverName;
        _careGiver.Email = careGiverEmail;
        _careGiver.ID = DateTime.Now.Millisecond;
        careGivers.Append(_careGiver);
        careGiverName = "";
        careGiverEmail = "";
        showCareGiverForm = false;
    }

    private void ShowCareGiverForm () 
    {
        showCareGiverForm = true;
    }

    
    private void ShowPetForm () 
    {
        showPetForm = true;
    }

    private void CreatePet () 
    {
        Pet _pet = new Pet();
        _pet.Name = petName;
        _pet.ID = DateTime.Now.Millisecond;
        pets.Append(_pet);
        petName = "";
        showPetForm = false;
    }

    private void SetCareGiverName () 
    {
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CareGiverService CareGiverService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PetService PetService { get; set; }
    }
}
#pragma warning restore 1591
