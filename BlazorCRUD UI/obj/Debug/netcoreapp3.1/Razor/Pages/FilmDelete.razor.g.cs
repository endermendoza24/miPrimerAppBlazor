#pragma checksum "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5120e584f908a5d3dc7d6df0106c5315df183c86"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD_UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\_Imports.razor"
using BlazorCRUD_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\_Imports.razor"
using BlazorCRUD_UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDelete.razor"
using BlazorCRUD.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/filmdelete/{id:int}")]
    public partial class FilmDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>FilmDelete</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"alert alert-danger\" role=\"alert\">\r\n    <h4 class=\"alert-heading\">Are you sure?</h4>\r\n    <p>Are  you sure you want to delete this films?</p>\r\n    <hr>\r\n    <p class=\"mb-0\">Will be permanently delete!!!</p>\r\n</div>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDelete.razor"
                  film

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "table");
                __builder2.AddAttribute(7, "class", "table");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "tr");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.AddMarkupContent(11, "<td>Title: </td>\r\n            ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, " ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDelete.razor"
                                                                film.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.Title = __value, film.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddContent(19, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n        ");
                __builder2.OpenElement(22, "tr");
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.AddMarkupContent(24, "<td>Director: </td>\r\n            ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, " ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "type", "text");
                __builder2.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDelete.razor"
                                                                film.Director

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.Director = __value, film.Director));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddContent(32, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n        ");
                __builder2.OpenElement(35, "tr");
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.AddMarkupContent(37, "<td>Release date: </td>\r\n            ");
                __builder2.OpenElement(38, "td");
                __builder2.AddContent(39, " ");
                __builder2.OpenElement(40, "input");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "type", "text");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDelete.razor"
                                                                film.ReleaseDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.ReleaseDate = __value, film.ReleaseDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddContent(45, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n        ");
                __builder2.OpenElement(48, "tr");
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "td");
                __builder2.AddAttribute(51, "colspan", "2");
                __builder2.AddAttribute(52, "style", "text-align:center");
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "type", "submit");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDelete.razor"
                                               DeleteFilm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "value", "Delete");
                __builder2.AddAttribute(58, "class", "btn btn-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                ");
                __builder2.OpenElement(60, "input");
                __builder2.AddAttribute(61, "type", "button");
                __builder2.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDelete.razor"
                                               Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "value", "Cancel");
                __builder2.AddAttribute(64, "class", "btn btn-primary");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDelete.razor"
       
    Film film = new Film();

    [Parameter]
    public int id { get; set; }

    protected async Task DeleteFilm()
    {
        await FilmService.DeleteFilm(id);
        NavigationManager.NavigateTo("/filmlist");

    }

    //protected override async Task OnInitalizedAsync()
    //{
    //    film = await FilmService.GetDetails(id);
    //}

    protected override async Task OnInitializedAsync()
    {
        film = await FilmService.GetDetails(id);
    }

    protected void Cancel()
    {
        NavigationManager.NavigateTo("/filmlist");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFilmService FilmService { get; set; }
    }
}
#pragma warning restore 1591
