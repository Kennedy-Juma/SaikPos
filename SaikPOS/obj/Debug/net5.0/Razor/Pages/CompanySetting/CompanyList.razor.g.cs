#pragma checksum "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6db4af187902e86ec29f92f177bc0277a131f860"
// <auto-generated/>
#pragma warning disable 1591
namespace SaikPOS.Pages.CompanySetting
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/setting/companylist")]
    public partial class CompanyList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Product</a></li>
                <li class=""active"">Manage Company</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(9, "<div class=\"panel-heading\"><div class=\"panel-title\"><span>Manage Company</span></div></div>\r\n                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "panel-body");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "table-responsive");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "id", "dataTableExample3");
            __builder.AddAttribute(16, "class", "table table-bordered table-striped table-hover");
            __builder.AddMarkupContent(17, @"<thead><tr><th>S.No</th>
                            <th class=""text-center"">Name</th>
                            <th class=""text-center"">Address</th>
                            <th class=""text-center"">Mobile</th>
                            <th class=""text-center"">Website</th>
                            <th class=""text-center"">Photo</th></tr></thead>
                                ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 40 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
                                      
                                    int sno = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
                                           foreach(var item in listModel)
                                          {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
#nullable restore
#line 46 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
                                         sno++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
__builder.AddContent(21, sno);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                                    ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "class", "text-center");
#nullable restore
#line 48 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
__builder.AddContent(25, item.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                  ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "class", "text-center");
#nullable restore
#line 49 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
__builder.AddContent(29, item.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                  ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "class", "text-center");
#nullable restore
#line 50 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
__builder.AddContent(33, item.Mobile);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                  ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "class", "text-center");
#nullable restore
#line 51 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
__builder.AddContent(37, item.Web);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                  ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "class", "text-center");
            __builder.OpenElement(41, "img");
            __builder.AddAttribute(42, "src", 
#nullable restore
#line 52 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
                                                                     convertImageToDisplay(item.LogoPath)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "width", "40");
            __builder.AddAttribute(44, "height", "40");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                    ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "center");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "href", "/setting/companyedit/" + (
#nullable restore
#line 55 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
                                                                    item.CompanyId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(51, "data-toggle", "tooltip");
            __builder.AddAttribute(52, "data-placement", "left");
            __builder.AddAttribute(53, "title");
            __builder.AddAttribute(54, "data-original-title", "Update");
            __builder.AddMarkupContent(55, "<i class=\"fa fa-pencil\" aria-hidden=\"true\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
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
#line 69 "E:\Personal Projects\SaikPOS\SaikPOS\Pages\CompanySetting\CompanyList.razor"
       
    List<Company> listModel;
    protected override void OnInitialized()
    {
        LoadData();
    }
    private async void LoadData()
    {
        listModel = company.GetAll();
    }
    string convertImageToDisplay(byte[] image)
    {
        if (image != null)
        {
            var base64 = Convert.ToBase64String(image);
            var finalStr = string.Format("data:image/jpg;base64,{0}", base64);
            return finalStr;
        }
        return "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany company { get; set; }
    }
}
#pragma warning restore 1591
