#pragma checksum "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e930008974f1b0f1f3411b00a85291d12a7f54a"
// <auto-generated/>
#pragma warning disable 1591
namespace SaikPOS.Pages.SettingPage
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/setting/mailconfiguration")]
    public partial class MailConfigurationPage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""#""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""#"">dashboard</a></li>
                <li class=""active"">Mail Setting</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                            ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(9, "<div class=\"panel-heading\"><div class=\"panel-title\"><h4>Mail Configuration </h4></div></div>\r\n                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "panel-body");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-sm-6");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group row");
            __builder.AddMarkupContent(18, "<label for=\"protocol\" class=\"col-sm-3 col-form-label text-right\">Protocol <i class=\"text-danger\">*</i></label>\r\n                                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-sm-6");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor"
                                                                                   master.Protocal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Protocal = __value, master.Protocal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                    <input type=\"hidden\" name=\"id\" value=\"1\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group row");
            __builder.AddMarkupContent(30, "<label for=\"smtp_host\" class=\"col-sm-3 col-form-label  text-right\">SMTP Host <i class=\"text-danger\">*</i></label>\r\n                                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-sm-6");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor"
                                                                                   master.Smpthost

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Smpthost = __value, master.Smpthost));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group row");
            __builder.AddMarkupContent(41, "<label for=\"smtp_port\" class=\"col-sm-3 col-form-label  text-right\">SMTP Port<i class=\"text-danger\">*</i></label>\r\n                                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-sm-6");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "class", "form-control");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor"
                                                                                   master.Smptport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Smptport = __value, master.Smptport));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group row");
            __builder.AddMarkupContent(52, "<label for=\"smtp_user\" class=\"col-sm-3 col-form-label text-right\">Sender Mail <i class=\"text-danger\">*</i></label>\r\n                                ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-sm-6");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "type", "email");
            __builder.AddAttribute(58, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor"
                                                                                    master.SenderMail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.SenderMail = __value, master.SenderMail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group row");
            __builder.AddMarkupContent(63, "<label for=\"smtp_pass\" class=\"col-sm-3 col-form-label  text-right\">Password <i class=\"text-danger\">*</i></label>\r\n                                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-sm-6");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "class", "form-control");
            __builder.AddAttribute(68, "type", "password");
            __builder.AddAttribute(69, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor"
                                                                                       master.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Password = __value, master.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group row");
            __builder.AddMarkupContent(74, "<label for=\"mailtype\" class=\"col-sm-3 col-form-label  text-right\">Mail Type <i class=\"text-danger\">*</i></label>\r\n                                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col-sm-6");
            __builder.OpenElement(77, "select");
            __builder.AddAttribute(78, "class", "form-control");
            __builder.AddAttribute(79, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor"
                                                                        master.MailType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.MailType = __value, master.MailType));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(81, "option");
            __builder.AddAttribute(82, "value", "HTML");
            __builder.AddAttribute(83, "selected");
            __builder.AddContent(84, "HTML");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                        ");
            __builder.OpenElement(86, "option");
            __builder.AddAttribute(87, "value", "TEXT");
            __builder.AddContent(88, "TEXT");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                            ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-sm-6");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "form-group row");
            __builder.AddMarkupContent(94, "<label for=\"invoice\" class=\"col-sm-3 col-form-label\">Sale <i class=\"text-danger\"></i></label>\r\n                      ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "switch col-sm-6");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "type", "checkbox");
            __builder.AddAttribute(99, "checked", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor"
                                                              master.Sales

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Sales = __value, master.Sales));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "form-group row");
            __builder.AddMarkupContent(104, "<label for=\"service\" class=\"col-sm-3 col-form-label\">Purchase <i class=\"text-danger\"></i></label>\r\n                      ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "switch col-sm-6");
            __builder.OpenElement(107, "input");
            __builder.AddAttribute(108, "type", "checkbox");
            __builder.AddAttribute(109, "checked", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor"
                                                              master.Purchase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Purchase = __value, master.Purchase));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                            ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "form-group row");
            __builder.AddMarkupContent(114, "<label for=\"example-text-input\" class=\"col-sm-3 col-form-label\"></label>\r\n                                ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-sm-6 text-right");
            __builder.OpenElement(117, "input");
            __builder.AddAttribute(118, "type", "button");
            __builder.AddAttribute(119, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor"
                                                                   (() =>Save())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "class", "btn btn-success btn-large");
            __builder.AddAttribute(121, "value", "Save Changes");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\SettingPage\MailConfigurationPage.razor"
       
    MailConfigurations master = new MailConfigurations();
    protected override void OnInitialized()
    {
        master = configuration.Edit(1);
    }
    public async Task Save()
    {
            configuration.Update(master);
            Snackbar.Add("Updated Successfully.", Severity.Success);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMailConfiguration configuration { get; set; }
    }
}
#pragma warning restore 1591
