// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.Inventory.ProductPage
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
#line 3 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\ProductPage\QrCodePage.razor"
using QRCoder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\ProductPage\QrCodePage.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\ProductPage\QrCodePage.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\ProductPage\QrCodePage.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/qrcode/{id}")]
    public partial class QrCodePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "D:\CodecanonProject\Dotnet5\BusinessPro\Dreamer\Dreamer\Pages\Inventory\ProductPage\QrCodePage.razor"
       
    [Parameter]
    public string id { get; set; }
    Product master = new Product();
    string InputText { get; set; } = "";
    string QRCodeStr { get; set; } = "";
    protected async override void OnInitialized()
    {
        master = product.Edit(Convert.ToInt64(id));
        GenerateQRCode();
        StateHasChanged();
    }

    public void GenerateQRCode()
    {
        QRCodeStr = "";
        if(!string.IsNullOrEmpty(master.ProductName))
        {
            using(MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator oQRCodeGenerate = new QRCodeGenerator();
                QRCodeData oQRCodeData = oQRCodeGenerate.CreateQrCode(master.ProductName, QRCodeGenerator.ECCLevel.Q);
                QRCode oQRCode = new QRCode(oQRCodeData);
                using(Bitmap oBitmap = oQRCode.GetGraphic(20))
                {
                    oBitmap.Save(ms,ImageFormat.Png);
                    QRCodeStr = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());

                }
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProduct product { get; set; }
    }
}
#pragma warning restore 1591