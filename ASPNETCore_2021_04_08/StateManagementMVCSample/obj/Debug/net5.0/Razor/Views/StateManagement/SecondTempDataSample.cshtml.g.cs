#pragma checksum "C:\Aktueller Kurs\ASPNETCore5_2021_04_08\ASPNETCore_2021_04_08\StateManagementMVCSample\Views\StateManagement\SecondTempDataSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d741948c723701c30e176e77d9ff02a316ed71c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StateManagement_SecondTempDataSample), @"mvc.1.0.view", @"/Views/StateManagement/SecondTempDataSample.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Aktueller Kurs\ASPNETCore5_2021_04_08\ASPNETCore_2021_04_08\StateManagementMVCSample\Views\_ViewImports.cshtml"
using StateManagementMVCSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore5_2021_04_08\ASPNETCore_2021_04_08\StateManagementMVCSample\Views\_ViewImports.cshtml"
using StateManagementMVCSample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d741948c723701c30e176e77d9ff02a316ed71c", @"/Views/StateManagement/SecondTempDataSample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df46e40df80757cef87a6bdcda14238c9adfabb", @"/Views/_ViewImports.cshtml")]
    public class Views_StateManagement_SecondTempDataSample : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Aktueller Kurs\ASPNETCore5_2021_04_08\ASPNETCore_2021_04_08\StateManagementMVCSample\Views\StateManagement\SecondTempDataSample.cshtml"
  
    ViewData["Title"] = "SecondTempDataSample";

    //string email = TempData["EmailAddress"].ToString();
    //int id = Convert.ToInt32(TempData["Id"]);

    /*TempData.Keep();*/ //Alle Einträge

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SecondTempDataSample</h1>\r\n\r\n");
#nullable restore
#line 13 "C:\Aktueller Kurs\ASPNETCore5_2021_04_08\ASPNETCore_2021_04_08\StateManagementMVCSample\Views\StateManagement\SecondTempDataSample.cshtml"
Write(TempData.Peek("EmailAddress"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Aktueller Kurs\ASPNETCore5_2021_04_08\ASPNETCore_2021_04_08\StateManagementMVCSample\Views\StateManagement\SecondTempDataSample.cshtml"
Write(TempData.Peek("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
