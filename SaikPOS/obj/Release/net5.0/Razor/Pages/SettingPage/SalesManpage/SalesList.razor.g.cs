#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\SalesManpage\SalesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2c32a2cdab829fb2c06e457514cc9d774e5bbf3"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.SettingPage.SalesManpage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/salesmanlist")]
    public partial class SalesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Product</a></li>
                <li class=""active"">Manage SalesMan</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(9, @"<div class=""panel-heading""><div class=""panel-title""><span>Manage SalesMan</span>
                           <span class=""padding-lefttitle""><a href=""/product/salesmanadd"" class=""btn btn-primary m-b-5 m-r-2""><i class=""ti-plus""></i>  Add Counter </a></span></div></div>
                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "panel-body");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "table-responsive");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "id", "dataTableExample3");
            __builder.AddAttribute(16, "class", "table table-bordered table-striped table-hover");
            __builder.AddMarkupContent(17, "<thead><tr><th>S.No</th>\r\n                            <th class=\"text-center\">SalesMan</th></tr></thead>\r\n                                ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 40 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\SalesManpage\SalesList.razor"
                                      
                                    int sno = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\SalesManpage\SalesList.razor"
                                           foreach(var item in listModel)
                                          {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
#nullable restore
#line 46 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\SalesManpage\SalesList.razor"
                                         sno++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\SalesManpage\SalesList.razor"
__builder.AddContent(21, sno);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                                    ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "class", "text-center");
#nullable restore
#line 48 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\SalesManpage\SalesList.razor"
__builder.AddContent(25, item.SalesmanName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                    ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "center");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", "/product/salesmanedit/" + (
#nullable restore
#line 51 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\SalesManpage\SalesList.razor"
                                                                     item.SalesManId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(32, "data-toggle", "tooltip");
            __builder.AddAttribute(33, "data-placement", "left");
            __builder.AddAttribute(34, "title");
            __builder.AddAttribute(35, "data-original-title", "Update");
            __builder.AddMarkupContent(36, "<i class=\"fa fa-pencil\" aria-hidden=\"true\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                          ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\SalesManpage\SalesList.razor"
                                                       () => Delete(item.SalesManId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(41, "data-toggle", "tooltip");
            __builder.AddAttribute(42, "data-placement", "right");
            __builder.AddAttribute(43, "title", "");
            __builder.AddAttribute(44, "data-original-title", "Delete ");
            __builder.AddMarkupContent(45, "<i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\SalesManpage\SalesList.razor"
                                    }

#line default
#line hidden
#nullable disable
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
#line 67 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\SettingPage\SalesManpage\SalesList.razor"
       
    List<SalesMan> listModel;
    protected override void OnInitialized()
    {
        LoadData();
    }
    private async void LoadData()
    {
        listModel = salesman.GetAll();
    }
    async Task Delete(long id)
    {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
            if (confirmed)
            {
                if (id != 1)
                {
                    bool isSave = false;
                    isSave = salesman.Delete(id);
                    if (isSave == true)
                    {
                        Snackbar.Add("Delete Successfully.", Severity.Success);
                        LoadData();
                    }
                    else
                    {
                        Snackbar.Add("Cannot be delete. already in used.", Severity.Info);
                    }
                }
                else
                {
                    Snackbar.Add("Default data cannot be delete.", Severity.Info);
                }
            }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISalesMan salesman { get; set; }
    }
}
#pragma warning restore 1591
