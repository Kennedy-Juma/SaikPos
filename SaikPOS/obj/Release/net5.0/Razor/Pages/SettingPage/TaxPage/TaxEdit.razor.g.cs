#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cab58fc80347e496c2f7f79f331b0c1eb92b7fd"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.SettingPage.TaxPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Transaction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.PdfReport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/taxedit/{id}")]
    public partial class TaxEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Product</a></li>
                <li class=""active"">Add Edit</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                     ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(9, "<div class=\"panel-heading\"><div class=\"panel-title\"><h4>Edit Tax </h4></div></div>\r\n                   \r\n                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "panel-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor"
                                                  master

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 31 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor"
                                                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group row");
                __builder2.AddMarkupContent(20, "<label for=\"unit_name\" class=\"col-sm-2 text-right col-form-label\">Tax Name <i class=\"text-danger\"> * </i>:</label>\r\n                                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-sm-4");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "text");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "placeholder", "Tax Name");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor"
                                                                                   master.TaxName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.TaxName = __value, master.TaxName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                                    ");
                __Blazor.Dreamer.Pages.SettingPage.TaxPage.TaxEdit.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 38 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor"
                                                              () => master.TaxName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group row");
                __builder2.AddMarkupContent(35, "<label for=\"unit_name\" class=\"col-sm-2 text-right col-form-label\">Percentage(%) <i class=\"text-danger\"> * </i>:</label>\r\n                                    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-sm-4");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "number");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "placeholder", "Narration");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor"
                                                                                     master.Rate

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Rate = __value, master.Rate, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                                    ");
                __Blazor.Dreamer.Pages.SettingPage.TaxPage.TaxEdit.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 47 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor"
                                                              () => master.Rate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group row");
                __builder2.AddMarkupContent(50, "<label for=\"unit_name\" class=\"col-sm-2 text-right col-form-label\">Active <i class=\"text-danger\"> * </i>:</label>\r\n                                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-sm-4");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "checkbox");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor"
                                                                                       master.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.IsActive = __value, master.IsActive));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                                    ");
                __Blazor.Dreamer.Pages.SettingPage.TaxPage.TaxEdit.TypeInference.CreateValidationMessage_2(__builder2, 59, 60, 
#nullable restore
#line 56 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor"
                                                              () => master.IsActive

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                         ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "form-group row");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-sm-6 text-right");
                __builder2.AddMarkupContent(66, "<button type=\"submit\" class=\"btn btn-success \">Save</button>\r\n                                      ");
                __builder2.OpenElement(67, "button");
                __builder2.AddAttribute(68, "type", "button");
                __builder2.AddAttribute(69, "class", "btn btn-danger");
                __builder2.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor"
                                                                                              Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(71, "Back to List");
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
#line 77 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\TaxPage\TaxEdit.razor"
       
    [Parameter]
    public string id { get; set; }
    Tax master = new Tax();
    protected async override void OnInitialized()
    {
        master = tax.Edit(Convert.ToInt64(id));
    }
    public async Task HandleValidSubmit()
    {
        var isCheck = tax.CheckNameId(master.TaxName);
        if (isCheck == master.TaxId || isCheck == 0)
        {
            master.CompanyId = 1;
            master.ApplicableOn = "Bill";
            master.CalculatingMode = "Rate";
            master.Narration = string.Empty;
            master.ModifyDate = DateTime.Now;
            tax.Update(master);
            Snackbar.Add("Updated Successfully.", Severity.Success);
            navManager.NavigateTo("/product/taxlist");
        }
        else
         {
             Snackbar.Add("Already Exists.", Severity.Info);
          }
    }
    void Cancel()
    {
        navManager.NavigateTo("/product/taxlist");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITax tax { get; set; }
    }
}
namespace __Blazor.Dreamer.Pages.SettingPage.TaxPage.TaxEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
