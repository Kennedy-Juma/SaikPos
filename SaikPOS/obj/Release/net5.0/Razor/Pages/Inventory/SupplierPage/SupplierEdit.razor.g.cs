#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "061538d00a5633a2e75d82cba34130421b51fc77"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.Inventory.SupplierPage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchase/supplieredit/{id}")]
    public partial class SupplierEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Purchase</a></li>
                <li class=""active"">Edit Supplier</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                     ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(9, "<div class=\"panel-heading\"><div class=\"panel-title\"><h4>Edit Supplier </h4></div></div>\r\n                   \r\n                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "panel-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 33 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                  master

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 33 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
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
                __builder2.AddMarkupContent(20, "<label for=\"customer_mobile\" class=\"col-sm-2 text-right col-form-label\">Supplier Name <i class=\"text-danger\"></i>:</label>\r\n                                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-sm-12");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "type", "text");
                __builder2.AddAttribute(27, "class", "form-control input-mask-trigger text-left");
                __builder2.AddAttribute(28, "placeholder", "Supplier Name");
                __builder2.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                      master.LedgerName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.LedgerName = __value, master.LedgerName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                                 ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group row");
                __builder2.AddMarkupContent(34, "<label for=\"customer_email\" class=\"col-sm-2 text-right col-form-label\">Supplier Code:</label>\r\n                                    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-sm-4");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "type", "text");
                __builder2.AddAttribute(41, "class", "form-control input-mask-trigger");
                __builder2.AddAttribute(42, "placeholder", "LedgerCode");
                __builder2.AddAttribute(43, "readonly");
                __builder2.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                                              master.LedgerCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.LedgerCode = __value, master.LedgerCode));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                    ");
                __builder2.AddMarkupContent(47, "<label for=\"phone\" class=\"col-sm-2 text-right col-form-label\">Area:</label>\r\n                                    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-sm-4");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class");
                __builder2.OpenElement(52, "select");
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                master.AreaId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.AreaId = __value, master.AreaId));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 60 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                foreach(var item in listArea)
                                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(56, "option");
                __builder2.AddAttribute(57, "value", 
#nullable restore
#line 62 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                        item.AreaId

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 62 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
__builder2.AddContent(58, item.AreaName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 63 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"

                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group row");
                __builder2.AddMarkupContent(62, "<label for=\"fax\" class=\"col-sm-2 text-right col-form-label\">WebSite:</label>\r\n                                    ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col-sm-4");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class");
                __builder2.OpenElement(67, "input");
                __builder2.AddAttribute(68, "type", "text");
                __builder2.AddAttribute(69, "class", "form-control");
                __builder2.AddAttribute(70, "placeholder", "WebSite Code");
                __builder2.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                           master.Website

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Website = __value, master.Website));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                                    ");
                __builder2.AddMarkupContent(74, "<label for=\"city\" class=\"col-sm-2 text-right col-form-label\">Phone:</label>\r\n                                    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-sm-4");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "type", "text");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "placeholder", "Phone");
                __builder2.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 80 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                           master.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Phone = __value, master.Phone));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                                ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group row");
                __builder2.AddMarkupContent(88, "<label for=\"state\" class=\"col-sm-2 text-right col-form-label\">Mobile:</label>\r\n                                    ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "col-sm-4");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class");
                __builder2.OpenElement(93, "input");
                __builder2.AddAttribute(94, "type", "text");
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "placeholder", "Mobile");
                __builder2.AddAttribute(97, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                           master.Mobile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Mobile = __value, master.Mobile));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                                    ");
                __builder2.AddMarkupContent(100, "<label for=\"zip\" class=\"col-sm-2 text-right col-form-label\">Email:</label>\r\n                                    ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "col-sm-4");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class");
                __builder2.OpenElement(105, "input");
                __builder2.AddAttribute(106, "type", "text");
                __builder2.AddAttribute(107, "class", "form-control");
                __builder2.AddAttribute(108, "placeholder", "Email");
                __builder2.AddAttribute(109, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 96 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                           master.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(110, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Email = __value, master.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                                ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group row");
                __builder2.AddMarkupContent(114, "<label for=\"country\" class=\"col-sm-2 text-right col-form-label\">Credit Period:</label>\r\n                                    ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "col-sm-4");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class");
                __builder2.OpenElement(119, "input");
                __builder2.AddAttribute(120, "type", "number");
                __builder2.AddAttribute(121, "class", "form-control");
                __builder2.AddAttribute(122, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 105 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                             master.CreditPeriod

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(123, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.CreditPeriod = __value, master.CreditPeriod, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                                    \r\n                                     ");
                __builder2.AddMarkupContent(125, "<label for=\"previous_balance\" class=\"col-sm-2 text-right col-form-label\">Credit Limit:</label>\r\n                                    ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "col-sm-4");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class");
                __builder2.OpenElement(130, "input");
                __builder2.AddAttribute(131, "type", "number");
                __builder2.AddAttribute(132, "class", "form-control");
                __builder2.AddAttribute(133, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 113 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                             master.CreditLimit

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(134, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.CreditLimit = __value, master.CreditLimit, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n\r\n                                 ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "form-group row");
                __builder2.AddMarkupContent(138, "<label for=\"country\" class=\"col-sm-2 text-right col-form-label\">Country:</label>\r\n                                    ");
                __builder2.OpenElement(139, "div");
                __builder2.AddAttribute(140, "class", "col-sm-4");
                __builder2.OpenElement(141, "div");
                __builder2.AddAttribute(142, "class");
                __builder2.OpenElement(143, "input");
                __builder2.AddAttribute(144, "type", "text");
                __builder2.AddAttribute(145, "class", "form-control");
                __builder2.AddAttribute(146, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 124 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                           master.Country

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(147, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Country = __value, master.Country));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n                                    \r\n                                     ");
                __builder2.AddMarkupContent(149, "<label for=\"previous_balance\" class=\"col-sm-2 text-right col-form-label\">State:</label>\r\n                                    ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "col-sm-4");
                __builder2.OpenElement(152, "div");
                __builder2.AddAttribute(153, "class");
                __builder2.OpenElement(154, "input");
                __builder2.AddAttribute(155, "type", "text");
                __builder2.AddAttribute(156, "class", "form-control");
                __builder2.AddAttribute(157, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 132 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                           master.State

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(158, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.State = __value, master.State));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n\r\n                                ");
                __builder2.OpenElement(160, "div");
                __builder2.AddAttribute(161, "class", "form-group row");
                __builder2.AddMarkupContent(162, "<label for=\"country\" class=\"col-sm-2 text-right col-form-label\">City:</label>\r\n                                    ");
                __builder2.OpenElement(163, "div");
                __builder2.AddAttribute(164, "class", "col-sm-4");
                __builder2.OpenElement(165, "div");
                __builder2.AddAttribute(166, "class");
                __builder2.OpenElement(167, "input");
                __builder2.AddAttribute(168, "type", "text");
                __builder2.AddAttribute(169, "class", "form-control");
                __builder2.AddAttribute(170, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 143 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                           master.Mnucapality

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(171, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Mnucapality = __value, master.Mnucapality));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n                                    \r\n                                     ");
                __builder2.AddMarkupContent(173, "<label for=\"previous_balance\" class=\"col-sm-2 text-right col-form-label\">Refer From:</label>\r\n                                    ");
                __builder2.OpenElement(174, "div");
                __builder2.AddAttribute(175, "class", "col-sm-4");
                __builder2.OpenElement(176, "div");
                __builder2.AddAttribute(177, "class");
                __builder2.OpenElement(178, "select");
                __builder2.AddAttribute(179, "class", "form-control");
                __builder2.AddAttribute(180, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 151 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                master.Referfrom

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(181, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Referfrom = __value, master.Referfrom));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(182, "option");
                __builder2.AddAttribute(183, "value", "Previous Customer");
                __builder2.AddContent(184, "Previous Customer");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(185, "\r\n                                        ");
                __builder2.OpenElement(186, "option");
                __builder2.AddAttribute(187, "value", "Facebook");
                __builder2.AddContent(188, "Facebook");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(189, "\r\n                                        ");
                __builder2.OpenElement(190, "option");
                __builder2.AddAttribute(191, "value", "Twitter");
                __builder2.AddContent(192, "Twitter");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(193, "\r\n                                        ");
                __builder2.OpenElement(194, "option");
                __builder2.AddAttribute(195, "value", "Instagram");
                __builder2.AddContent(196, "Instagram");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(197, "\r\n                                        ");
                __builder2.OpenElement(198, "option");
                __builder2.AddAttribute(199, "value", "Instagram");
                __builder2.AddContent(200, "Friend");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(201, "\r\n                                        ");
                __builder2.OpenElement(202, "option");
                __builder2.AddAttribute(203, "value", "Other");
                __builder2.AddContent(204, "Other");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(205, "\r\n\r\n                                ");
                __builder2.OpenElement(206, "div");
                __builder2.AddAttribute(207, "class", "form-group row");
                __builder2.AddMarkupContent(208, "<label for=\"country\" class=\"col-sm-2 text-right col-form-label\">Remarks:</label>\r\n                                    ");
                __builder2.OpenElement(209, "div");
                __builder2.AddAttribute(210, "class", "col-sm-4");
                __builder2.OpenElement(211, "div");
                __builder2.AddAttribute(212, "class");
                __builder2.OpenElement(213, "textarea");
                __builder2.AddAttribute(214, "type", "text");
                __builder2.AddAttribute(215, "class", "form-control");
                __builder2.AddAttribute(216, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 169 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                              master.Narration

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(217, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.Narration = __value, master.Narration));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(218, "\r\n                                    \r\n                                     ");
                __builder2.AddMarkupContent(219, "<label for=\"previous_balance\" class=\"col-sm-2 text-right col-form-label\">Active:</label>\r\n                                    ");
                __builder2.OpenElement(220, "div");
                __builder2.AddAttribute(221, "class", "col-sm-4");
                __builder2.OpenElement(222, "div");
                __builder2.AddAttribute(223, "class");
                __builder2.OpenElement(224, "input");
                __builder2.AddAttribute(225, "type", "checkbox");
                __builder2.AddAttribute(226, "class", "form-control");
                __builder2.AddAttribute(227, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 177 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                               master.IsDefault

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(228, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => master.IsDefault = __value, master.IsDefault));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(229, "\r\n                         ");
                __builder2.OpenElement(230, "div");
                __builder2.AddAttribute(231, "class", "form-group row");
                __builder2.AddMarkupContent(232, "<div class=\"col-sm-6 text-right\"></div>\r\n                                     ");
                __builder2.OpenElement(233, "div");
                __builder2.AddAttribute(234, "class", "col-sm-6 text-right");
                __builder2.OpenElement(235, "div");
                __builder2.AddAttribute(236, "class");
                __builder2.AddMarkupContent(237, "<button type=\"submit\" class=\"btn btn-success \">Save</button>\r\n                                      ");
                __builder2.OpenElement(238, "button");
                __builder2.AddAttribute(239, "type", "button");
                __builder2.AddAttribute(240, "class", "btn btn-danger");
                __builder2.AddAttribute(241, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 189 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
                                                                                              Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(242, "Back to List");
                __builder2.CloseElement();
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
#line 203 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierEdit.razor"
       
    [Parameter]
    public string id { get; set; }
    AccountLedger master = new AccountLedger();
    List<Area> listArea = new List<Area>();
    protected async override void OnInitialized()
    {
        LoadData();
    }
    private void LoadData()
    {
        master = accountLedger.Edit(Convert.ToInt64(id));
        master.Referfrom = "Previous Customer";
        listArea = area.GetAll();
    }
    public void HandleValidSubmit()
    {
            master.AccountGroupId = 22;
            master.LogoPathC = string.Empty;
            master.PricinglevelId = 1;
            master.RouteId = 1;
            master.SkypeID = string.Empty;
            master.Twitter = string.Empty;
            master.Facebook = string.Empty;
            master.instagram = string.Empty;
            master.MailingName = string.Empty;
            master.BranchCode = string.Empty;
            master.BankAccountNumber = string.Empty;
            master.Street = string.Empty;
            master.ZipCode = string.Empty;
            master.Map = string.Empty;
            master.ModifyDate = DateTime.Now;
            master.CompanyId = 1;
            master.ModifyBy = 1;
            bool isSave = false;
            isSave = accountLedger.Update(master);
            if (isSave == true)
            {
                Snackbar.Add("Updated Successfully.", Severity.Success);
                LoadData();
                navManager.NavigateTo("purchase/supplierlist");
            }
            else
            {
                Snackbar.Add("Already Exists.", Severity.Info);
            }
    }
    void Cancel()
    {
        navManager.NavigateTo("purchase/supplierlist");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArea area { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountGroup accountGroup { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger accountLedger { get; set; }
    }
}
#pragma warning restore 1591
