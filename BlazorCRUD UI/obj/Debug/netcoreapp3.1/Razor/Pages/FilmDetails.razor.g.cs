#pragma checksum "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2227d6930f3f91c76b95ce8ee42cfc2705089cd1"
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
#line 2 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDetails.razor"
using BlazorCRUD.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/filmdetails")]
    public partial class FilmDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Film details</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDetails.razor"
                  film

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "tr");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<td>Title: </td>\r\n            ");
                __builder2.OpenElement(11, "td");
                __builder2.AddContent(12, " ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDetails.razor"
                                                                film.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.Title = __value, film.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddContent(18, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\r\n        ");
                __builder2.OpenElement(21, "tr");
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.AddMarkupContent(23, "<td>Director: </td>\r\n            ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, " ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "type", "text");
                __builder2.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDetails.razor"
                                                                film.Director

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.Director = __value, film.Director));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddContent(31, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n\r\n        ");
                __builder2.OpenElement(34, "tr");
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.AddMarkupContent(36, "<td>Release date: </td>\r\n            ");
                __builder2.OpenElement(37, "td");
                __builder2.AddContent(38, " ");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "type", "text");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDetails.razor"
                                                                film.ReleaseDate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film.ReleaseDate = __value, film.ReleaseDate));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddContent(44, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n        ");
                __builder2.OpenElement(47, "tr");
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.OpenElement(49, "td");
                __builder2.AddAttribute(50, "colspan", "2");
                __builder2.AddAttribute(51, "style", "text-align:center");
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "submit");
                __builder2.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDetails.razor"
                                               SaveFilm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "value", "Save");
                __builder2.AddAttribute(57, "class", "btn btn-success");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "input");
                __builder2.AddAttribute(60, "type", "button");
                __builder2.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDetails.razor"
                                               Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "value", "Cancel");
                __builder2.AddAttribute(63, "class", "btn btn-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\ENDERSSONMENDOZA\source\repos\BlazorCRUD\BlazorCRUD UI\Pages\FilmDetails.razor"
       
    Film film = new Film();

    protected void Cancel() {

    }

    protected async Task SaveFilm()
    {
        await FilmService.SaveFilm(film);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFilmService FilmService { get; set; }
    }
}
#pragma warning restore 1591
