#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92a8f6f24144225d467f6d2049dc732b5c85f5c7"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.SettingPage.CurrencyPage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/currencyadd")]
    public partial class CurrencyAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Product</a></li>
                <li class=""active"">Add Currency</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                     ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(9, "<div class=\"panel-heading\"><div class=\"panel-title\"><h4>Add Currency </h4></div></div>\r\n                   \r\n                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "panel-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 31 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
                                                  master

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 31 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
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
                __builder2.AddMarkupContent(20, "<label for=\"unit_name\" class=\"col-sm-2 text-right col-form-label\">Currency Name<i class=\"text-danger\"> * </i>:</label>\r\n                                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-sm-4");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "text");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "placeholder", "Currency Name");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
                                                                                   master.CurrencyName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.CurrencyName = __value, master.CurrencyName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                                    ");
                __Blazor.Dreamer.Pages.SettingPage.CurrencyPage.CurrencyAdd.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 38 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
                                                              () => master.CurrencyName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group row");
                __builder2.AddMarkupContent(35, "<label for=\"unit_name\" class=\"col-sm-2 text-right col-form-label\">Symbol<i class=\"text-danger\"> * </i>:</label>\r\n                                    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-sm-4");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "type", "text");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "placeholder", "Currency Symbol");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
                                                                                   master.CurrencySymbol

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.CurrencySymbol = __value, master.CurrencySymbol));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                                    ");
                __Blazor.Dreamer.Pages.SettingPage.CurrencyPage.CurrencyAdd.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 47 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
                                                              () => master.CurrencySymbol

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group row");
                __builder2.AddMarkupContent(50, "<label for=\"unit_name\" class=\"col-sm-2 text-right col-form-label\">No.Of decimal<i class=\"text-danger\"> * </i>:</label>\r\n                                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-sm-4");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "text");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "placeholder", "Currency Symbol");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
                                                                                   master.noOfDecimalPlaces

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.noOfDecimalPlaces = __value, master.noOfDecimalPlaces));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                    ");
                __Blazor.Dreamer.Pages.SettingPage.CurrencyPage.CurrencyAdd.TypeInference.CreateValidationMessage_2(__builder2, 60, 61, 
#nullable restore
#line 56 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
                                                              () => master.noOfDecimalPlaces

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                                ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group row");
                __builder2.AddMarkupContent(65, "<label for=\"unit_name\" class=\"col-sm-2 text-right col-form-label\">Narration:</label>\r\n                                    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-sm-4");
                __builder2.OpenElement(68, "input");
                __builder2.AddAttribute(69, "type", "text");
                __builder2.AddAttribute(70, "class", "form-control");
                __builder2.AddAttribute(71, "placeholder", "Narration");
                __builder2.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
                                                                                   master.Narration

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Narration = __value, master.Narration));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                                    ");
                __Blazor.Dreamer.Pages.SettingPage.CurrencyPage.CurrencyAdd.TypeInference.CreateValidationMessage_3(__builder2, 75, 76, 
#nullable restore
#line 65 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
                                                              () => master.Narration

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n\r\n                         ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group row");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-sm-6 text-right");
                __builder2.AddMarkupContent(82, "<button type=\"submit\" class=\"btn btn-success \">Save</button>\r\n                                      ");
                __builder2.OpenElement(83, "button");
                __builder2.AddAttribute(84, "type", "button");
                __builder2.AddAttribute(85, "class", "btn btn-danger");
                __builder2.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
                                                                                              Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(87, "Back to List");
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
#line 88 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\CurrencyPage\CurrencyAdd.razor"
       
    Currency master = new Currency();
    protected async override void OnInitialized()
    {
        
    }
    public async Task HandleValidSubmit()
    {
            var isCheck = currency.CheckName(master.CurrencyName);
            if (isCheck == true)
            {
                Snackbar.Add("Already Exists.", Severity.Info);
            }
            else
            {
                master.IsDefault = true;
                master.AddedDate = DateTime.Now;
                currency.Save(master);
                Snackbar.Add("Saved Successfully.", Severity.Success);
                navManager.NavigateTo("/product/currencylist");
            }
    }
    void Cancel()
    {
        navManager.NavigateTo("/product/currencylist");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICurrency currency { get; set; }
    }
}
namespace __Blazor.Dreamer.Pages.SettingPage.CurrencyPage.CurrencyAdd
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
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
