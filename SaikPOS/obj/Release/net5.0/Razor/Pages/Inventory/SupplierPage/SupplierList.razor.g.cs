#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bd9e3626b1de18a79a8282a3800f1332ad0cd8e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchase/supplierlist")]
    public partial class SupplierList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Purchase</a></li>
                <li class=""active"">Manage Supplier</li></ol>
            
                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "panel panel-bd lobidrag");
            __builder.AddMarkupContent(9, @"<div class=""panel-heading""><div class=""panel-title""><span>Manage Supplier</span>
                           <span class=""padding-lefttitle""><a href=""/purchase/supplieradd"" class=""btn btn-primary m-b-5 m-r-2""><i class=""ti-plus""></i>  Add Supplier </a></span></div></div>
                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "panel-body");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "table-responsive");
            __Blazor.Dreamer.Pages.Inventory.SupplierPage.SupplierList.TypeInference.CreateMudTable_0(__builder, 14, 15, 
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                              listModel

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                                                 dense

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                                                                hover

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                                                                                  bordered

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                                                                                                      striped

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                                                                                                                       new Func<AccountLedgerView,bool>(Search)

#line default
#line hidden
#nullable disable
            , 21, (__builder2) => {
                __Blazor.Dreamer.Pages.Inventory.SupplierPage.SupplierList.TypeInference.CreateMudTextField_1(__builder2, 22, 23, "Search", 24, 
#nullable restore
#line 34 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                                                                  Adornment.Start

#line default
#line hidden
#nullable disable
                , 25, 
#nullable restore
#line 34 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                                                                                                   Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 26, 
#nullable restore
#line 34 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                                                                                                                                           Size.Medium

#line default
#line hidden
#nullable disable
                , 27, "mt-0", 28, 
#nullable restore
#line 34 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                   searchString1

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 30, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(31);
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(33, "Supplier Name");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(35);
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, "Code");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(41, "Account Group");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(45, "Email");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(47);
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(49, "Mobile");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(51);
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(53, "Opening Balance");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(55);
                __builder2.CloseComponent();
            }
            , 56, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(57);
                __builder2.AddAttribute(58, "DataLabel", "LedgerName");
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 47 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
__builder3.AddContent(60, context.LedgerName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(62);
                __builder2.AddAttribute(63, "DataLabel", "LedgerCode");
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 48 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
__builder3.AddContent(65, context.LedgerCode);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(67);
                __builder2.AddAttribute(68, "DataLabel", "AccountGroupName");
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 49 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
__builder3.AddContent(70, context.AccountGroupName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(72);
                __builder2.AddAttribute(73, "DataLabel", "Email");
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 51 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
__builder3.AddContent(75, context.Email);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(77);
                __builder2.AddAttribute(78, "DataLabel", "Mobile");
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 52 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
__builder3.AddContent(80, context.Mobile);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(82);
                __builder2.AddAttribute(83, "DataLabel", "OpeningBalance");
                __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 53 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
__builder3.AddContent(85, context.OpeningBalance);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(87);
                __builder2.AddAttribute(88, "DataLabel", "");
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(90, "center");
                    __builder3.OpenElement(91, "a");
                    __builder3.AddAttribute(92, "href", "/purchase/supplieredit/" + (
#nullable restore
#line 56 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                                                      context.LedgerId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "class", "btn btn-info btn-sm");
                    __builder3.AddAttribute(94, "data-toggle", "tooltip");
                    __builder3.AddAttribute(95, "data-placement", "left");
                    __builder3.AddAttribute(96, "title");
                    __builder3.AddAttribute(97, "data-original-title", "Update");
                    __builder3.AddMarkupContent(98, "<i class=\"fa fa-pencil\" aria-hidden=\"true\"></i>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\r\n                                          ");
                    __builder3.OpenElement(100, "a");
                    __builder3.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                                       () => Delete(context.LedgerId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(102, "class", "btn btn-danger btn-sm");
                    __builder3.AddAttribute(103, "data-toggle", "tooltip");
                    __builder3.AddAttribute(104, "data-placement", "right");
                    __builder3.AddAttribute(105, "title", "");
                    __builder3.AddAttribute(106, "data-original-title", "Delete ");
                    __builder3.AddMarkupContent(107, "<i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            , 108, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(109);
                __builder2.AddAttribute(110, "PageSizeOptions", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 64 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
                                        new int[] {10, 20, 50, 100}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\SupplierPage\SupplierList.razor"
       
    private bool dense = true;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private string searchString2 = "";
    List<AccountLedgerView> listModel;
    protected override void OnInitialized()
    {
        LoadData();
    }
    private async void LoadData()
    {
        listModel = accountLedger.ViewAllSupplier(1);
    }
    async Task Delete(long id)
    {
            bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
            if (confirmed)
            {
                if (id != 1)
                {
                    bool isSave = false;
                    isSave = accountLedger.Delete(id);
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
    private bool Search(AccountLedgerView element)
    {
        if (string.IsNullOrWhiteSpace(searchString1))
            return true;
        if (element.LedgerName.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.AccountGroupName.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountLedger accountLedger { get; set; }
    }
}
namespace __Blazor.Dreamer.Pages.Inventory.SupplierPage.SupplierList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Func<T, global::System.Boolean> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Dense", __arg1);
        __builder.AddAttribute(__seq2, "Hover", __arg2);
        __builder.AddAttribute(__seq3, "Bordered", __arg3);
        __builder.AddAttribute(__seq4, "Striped", __arg4);
        __builder.AddAttribute(__seq5, "Filter", __arg5);
        __builder.AddAttribute(__seq6, "ToolBarContent", __arg6);
        __builder.AddAttribute(__seq7, "HeaderContent", __arg7);
        __builder.AddAttribute(__seq8, "RowTemplate", __arg8);
        __builder.AddAttribute(__seq9, "PagerContent", __arg9);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", __arg2);
        __builder.AddAttribute(__seq3, "IconSize", __arg3);
        __builder.AddAttribute(__seq4, "Class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591