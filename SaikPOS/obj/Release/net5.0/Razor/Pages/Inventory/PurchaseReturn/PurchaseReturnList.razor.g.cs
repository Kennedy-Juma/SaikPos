#pragma checksum "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c702aa316e0321fc1bb6a6f74dccbe842862200a"
// <auto-generated/>
#pragma warning disable 1591
namespace Dreamer.Pages.Inventory.PurchaseReturn
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
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
using NPOI.SS.UserModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
using NPOI.XSSF.UserModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchase/purchasereturnlist")]
    public partial class PurchaseReturnList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content");
            __builder.AddMarkupContent(2, @"<ol class=""breadcrumb""><li><a href=""/""><i class=""pe-7s-home""></i> Home</a></li>
                <li><a href=""/"">Purchase Return</a></li>
        <li class=""active"">Manage Purchase Return</li></ol>



                    
                                        <div class=""se-pre-con"" style=""display: none;""></div>
                    
                    			
		        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "panel panel-default");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "panel-body");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-sm-7");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-sm-6");
            __builder.AddMarkupContent(11, "<label class=\"col-sm-4\" for=\"from_date\">Start Date</label>\r\n                            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-sm-8");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "date");
            __builder.AddAttribute(16, "class", "form-control datepicker hasDatepicker");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                                                    fromDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fromDate = __value, fromDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-sm-6");
            __builder.AddMarkupContent(22, "<label class=\"col-sm-4\" for=\"to_date\">End Date</label>\r\n                            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-sm-8");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "date");
            __builder.AddAttribute(27, "class", "form-control datepicker hasDatepicker");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                                                    toDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => toDate = __value, toDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-sm-5");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                          async ()=> {await GenerateExcel();}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-info");
            __builder.AddMarkupContent(37, "<i class=\"i-File-Excel\"></i> EXCEL\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                  ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-success");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                                          Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.AddMarkupContent(45, "<a class=\"btn btn-primary\" href=\"/purchase/purchasereturnadd\">Add PurchaseReturn</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-sm-12");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "panel panel-bd lobidrag");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "panel-body");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "table-responsive");
            __Blazor.Dreamer.Pages.Inventory.PurchaseReturn.PurchaseReturnList.TypeInference.CreateMudTable_0(__builder, 57, 58, 
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                              listModel

#line default
#line hidden
#nullable disable
            , 59, 
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                 dense

#line default
#line hidden
#nullable disable
            , 60, 
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                                hover

#line default
#line hidden
#nullable disable
            , 61, 
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                                                  bordered

#line default
#line hidden
#nullable disable
            , 62, 
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                                                                      striped

#line default
#line hidden
#nullable disable
            , 63, 
#nullable restore
#line 58 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                                                                                       new Func<PurchaseReturnView,bool>(Search)

#line default
#line hidden
#nullable disable
            , 64, (__builder2) => {
                __Blazor.Dreamer.Pages.Inventory.PurchaseReturn.PurchaseReturnList.TypeInference.CreateMudTextField_1(__builder2, 65, 66, "Search", 67, 
#nullable restore
#line 60 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                                  Adornment.Start

#line default
#line hidden
#nullable disable
                , 68, 
#nullable restore
#line 60 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                                                                   Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 69, 
#nullable restore
#line 60 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                                                                                                                           Size.Medium

#line default
#line hidden
#nullable disable
                , 70, "mt-0", 71, 
#nullable restore
#line 60 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                   searchString1

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString1 = __value, searchString1)));
            }
            , 73, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(74);
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(76, "VoucherNo");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(78);
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(80, "Date");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(82);
                __builder2.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(84, "SupplierName");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(86);
                __builder2.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(88, "VoucherType");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(90);
                __builder2.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(92, "Amount");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(94);
                __builder2.CloseComponent();
            }
            , 95, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(96);
                __builder2.AddAttribute(97, "DataLabel", "LedgerName");
                __builder2.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 71 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
__builder3.AddContent(99, context.VoucherNo);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(101);
                __builder2.AddAttribute(102, "DataLabel", "LedgerCode");
                __builder2.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 72 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
__builder3.AddContent(104, context.Date);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(106);
                __builder2.AddAttribute(107, "DataLabel", "AccountGroupName");
                __builder2.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 73 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
__builder3.AddContent(109, context.LedgerName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(111);
                __builder2.AddAttribute(112, "DataLabel", "Address");
                __builder2.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 74 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
__builder3.AddContent(114, context.VoucherTypeName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(116);
                __builder2.AddAttribute(117, "DataLabel", "Email");
                __builder2.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 75 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
__builder3.AddContent(119, context.GrandTotal);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(120, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(121);
                __builder2.AddAttribute(122, "DataLabel", "");
                __builder2.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(124, "a");
                    __builder3.AddAttribute(125, "href", "/purchase/purchasereturndetails/" + (
#nullable restore
#line 77 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                      context.PurchaseReturnMasterId

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(126, "class", "btn btn-success btn-sm");
                    __builder3.AddAttribute(127, "data-toggle", "tooltip");
                    __builder3.AddAttribute(128, "data-placement", "left");
                    __builder3.AddAttribute(129, "title");
                    __builder3.AddAttribute(130, "data-original-title", "Purchase Details");
                    __builder3.AddMarkupContent(131, "<i class=\"fa fa-pencil\" aria-hidden=\"true\"></i>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(132, "\r\n                                    ");
                    __builder3.OpenElement(133, "a");
                    __builder3.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
                                                 () => Delete(context.PurchaseReturnMasterId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(135, "class", "btn btn-info btn-sm");
                    __builder3.AddAttribute(136, "data-toggle", "tooltip");
                    __builder3.AddAttribute(137, "data-placement", "left");
                    __builder3.AddAttribute(138, "title", "Update");
                    __builder3.AddMarkupContent(139, "<i class=\"fa fa-trash-o\" aria-hidden=\"true\"></i>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            , 140, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTablePager>(141);
                __builder2.AddAttribute(142, "PageSizeOptions", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 83 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
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
#line 92 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\PurchaseReturn\PurchaseReturnList.razor"
       
    private bool dense = true;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private string searchString2 = "";
    DateTime fromDate = DateTime.Now;
    DateTime toDate = DateTime.Now;
    List<PurchaseReturnView> listModel = new List<PurchaseReturnView>();
    protected override void OnInitialized()
    {
        LoadData();
    }
    private async void LoadData()
    {
        listModel = purchaseInvoice.ViewAllPurchaseMasterDetails(1);
        
    }
    async Task Delete(long id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
        if (confirmed)
        {
            PurchaseReturnMaster view = new PurchaseReturnMaster();
            view = purchaseInvoice.EditPurchaseMaster(id);
            //view = purchaseInvoice.EditPurchaseMaster(id , view.VoucherNo, 1 , 1);
            bool isSave = false;
            isSave = purchaseInvoice.DeletePurchseReturnInvoice(id, view.VoucherNo, 1, 1);
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
    }
    private bool Search(PurchaseReturnView element)
    {
        if (string.IsNullOrWhiteSpace(searchString1))
            return true;
        if (element.LedgerName.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.VoucherNo.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    private async void Search()
    {
        listModel = purchaseInvoice.ViewAllPurchseInvoice(1, fromDate , toDate);
    }
        protected async Task GenerateExcel()
    {
        IWorkbook workbook = new XSSFWorkbook();
        var dataFormat = workbook.CreateDataFormat();
        var dataStyle = workbook.CreateCellStyle();
        dataStyle.DataFormat = dataFormat.GetFormat("MM/yy/dddd HH:mm:ss");
        ISheet worksheet = workbook.CreateSheet("Sheet1");



        int rowNumber1 = 0;
        IRow row1 = worksheet.CreateRow(rowNumber1++);
        //TbleHeder
        ICell cell1 = row1.CreateCell(3);
        cell1.SetCellValue("PurchaseInvoice");

        int rowNumber = 1;
        IRow row = worksheet.CreateRow(rowNumber++);
        //TbleHeder
        ICell cell = row.CreateCell(0);
        cell.SetCellValue("Voucher No");

        cell = row.CreateCell(1);
        cell.SetCellValue("Date");

        cell = row.CreateCell(2);
        cell.SetCellValue("Supplier Name");

        cell = row.CreateCell(3);
        cell.SetCellValue("Voucher Type");

        cell = row.CreateCell(4);
        cell.SetCellValue("Amount");


        //Tble Body
        foreach (var objDue in listModel)
    {
            row = worksheet.CreateRow(rowNumber++);

            cell = row.CreateCell(0);
            cell.SetCellValue(objDue.VoucherNo);

            cell = row.CreateCell(1);
            cell.SetCellValue(objDue.Date.ToString());

            cell = row.CreateCell(2);
            cell.SetCellValue(objDue.LedgerName);

            cell = row.CreateCell(3);
            cell.SetCellValue(objDue.VoucherTypeName);

            cell = row.CreateCell(4);
            cell.SetCellValue(objDue.GrandTotal.ToString());

        }
        MemoryStream ms = new MemoryStream();
        workbook.Write(ms);
        byte[] bytes = ms.ToArray();
        ms.Close();

        await JsRuntime.SaveAsFileAsync("PurchaseReturn", bytes, "application/vnd.ms-excel");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPurchaseReturn purchaseInvoice { get; set; }
    }
}
namespace __Blazor.Dreamer.Pages.Inventory.PurchaseReturn.PurchaseReturnList
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
