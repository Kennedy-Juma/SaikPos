#pragma checksum "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebfd7523ca10a8819e4b866e72ca4270f215c0b1"
// <auto-generated/>
#pragma warning disable 1591
namespace SaikPOS.Pages.SettingPage.UnitPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Data.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Data.Transaction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Data.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Services.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.PdfReport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using SaikPOS.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Personal Projects\SaikPOS\SaikPOS\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/product/unitedit/{id}")]
    public partial class UnitEdit : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Product</a></li>
                <li class=""active"">Edit Unit</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                     ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(9, "<div class=\"panel-heading\"><div class=\"panel-title\"><h4>Edit Unit </h4></div></div>\r\n                   \r\n                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "panel-body");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 31 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor"
                                                  master

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 31 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor"
                                                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(15, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group row");
                __builder2.AddMarkupContent(20, "<label for=\"unit_name\" class=\"col-sm-2 text-right col-form-label\">Unit Name <i class=\"text-danger\"> * </i>:</label>\r\n                                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-sm-4");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "text");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "placeholder", "Unit Name");
                __builder2.AddAttribute(27, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor"
                                                                                   master.UnitName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.UnitName = __value, master.UnitName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                                    ");
                global::__Blazor.SaikPOS.Pages.SettingPage.UnitPage.UnitEdit.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 38 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor"
                                                              () => master.UnitName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group row");
                __builder2.AddMarkupContent(35, "<label for=\"unit_name\" class=\"col-sm-2 text-right col-form-label\">Formal Name <i class=\"text-danger\"> * </i>:</label>\r\n                                    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-sm-4");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "text");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "placeholder", "Formal Name");
                __builder2.AddAttribute(42, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor"
                                                                                   master.FormalName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.FormalName = __value, master.FormalName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                                    ");
                global::__Blazor.SaikPOS.Pages.SettingPage.UnitPage.UnitEdit.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 47 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor"
                                                              () => master.FormalName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group row");
                __builder2.AddMarkupContent(50, "<label for=\"unit_name\" class=\"col-sm-2 text-right col-form-label\">No. of. Decimal Places<i class=\"text-danger\"> * </i>:</label>\r\n                                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-sm-4");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "text");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "placeholder", "No. of. Decimal Places");
                __builder2.AddAttribute(57, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor"
                                                                                   master.NoOfDecimalplaces

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.NoOfDecimalplaces = __value, master.NoOfDecimalplaces));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                    ");
                global::__Blazor.SaikPOS.Pages.SettingPage.UnitPage.UnitEdit.TypeInference.CreateValidationMessage_2(__builder2, 60, 61, 
#nullable restore
#line 56 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor"
                                                              () => master.NoOfDecimalplaces

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n                         ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group row");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col-sm-6 text-right");
                __builder2.AddMarkupContent(67, "<button type=\"submit\" class=\"btn btn-success \">Save</button>\r\n                                      ");
                __builder2.OpenElement(68, "button");
                __builder2.AddAttribute(69, "type", "button");
                __builder2.AddAttribute(70, "class", "btn btn-danger");
                __builder2.AddAttribute(71, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor"
                                                                                              Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(72, "Back to List");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\UnitPage\UnitEdit.razor"
       
    [Parameter]
    public string id { get; set; }
    Unit master = new Unit();
    protected async override void OnInitialized()
    {
        master = unit.Edit(Convert.ToInt64(id));
    }
    public async Task HandleValidSubmit()
    {
        var isCheck = unit.CheckNameId(master.UnitName);
        if (isCheck == master.UnitId || isCheck == 0)
        {
            master.CompanyId = 1;
            master.ModifyDate = DateTime.Now;
            unit.Update(master);
            Snackbar.Add("Updated Successfully.", Severity.Success);
            navManager.NavigateTo("/product/unitlist");
        }
        else
         {
             Snackbar.Add("Already Exists.", Severity.Info);
          }
    }
    void Cancel()
    {
        navManager.NavigateTo("/product/unitlist");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUnit unit { get; set; }
    }
}
namespace __Blazor.SaikPOS.Pages.SettingPage.UnitPage.UnitEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
