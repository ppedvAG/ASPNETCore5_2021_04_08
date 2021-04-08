#pragma checksum "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\Operations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "138a5529261287480bf278bfd817836eb3cd198a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operations_Index), @"mvc.1.0.view", @"/Views/Operations/Index.cshtml")]
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
#line 1 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\_ViewImports.cshtml"
using DIScopeVsTransientVsSingletonSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\_ViewImports.cshtml"
using DIScopeVsTransientVsSingletonSample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"138a5529261287480bf278bfd817836eb3cd198a", @"/Views/Operations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dfbbc7c988d63a59b689b4e348e1faa7b01856c", @"/Views/_ViewImports.cshtml")]
    public class Views_Operations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\Operations\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

    string transient = ViewBag.Transient.OperationId.ToString();
    string scope = ViewBag.Scoped.OperationId.ToString();
    string singleton = ViewBag.Singleton.OperationId.ToString();
    string instance = ViewBag.Instance != null ? ViewBag.Instance.OperationId.ToString() : Guid.Empty.ToString();

    string serviceTansientOperation = ViewBag.Service.TransientOperation.OperationId.ToString(); ;
    string serviceScopeOperation = ViewBag.Service.ScopedOperation.OperationId.ToString(); ;
    string serviceSingletonOperation = ViewBag.Service.SingletonOperation.OperationId.ToString(); ;
    string serviceInstanceOperation = ViewBag.Service.SingletonInstanceOperation != null ? ViewBag.Service.SingletonInstanceOperation.OperationId.ToString() : Guid.Empty.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Singleton / Transient / Scope - Sample</h1>\r\n\r\n\r\n<h2><b>First Call</b></h2>\r\n<p>Transient: ");
#nullable restore
#line 21 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\Operations\Index.cshtml"
         Write(transient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Scoped: ");
#nullable restore
#line 22 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\Operations\Index.cshtml"
      Write(scope);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Singleton: ");
#nullable restore
#line 23 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\Operations\Index.cshtml"
         Write(singleton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Instance: ");
#nullable restore
#line 24 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\Operations\Index.cshtml"
        Write(instance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<hr />\r\n<h2><b>Second Call</b></h2>\r\n<p>Service Transient: ");
#nullable restore
#line 28 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\Operations\Index.cshtml"
                 Write(serviceTansientOperation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Service Scoped: ");
#nullable restore
#line 29 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\Operations\Index.cshtml"
              Write(serviceScopeOperation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Service Singleton: ");
#nullable restore
#line 30 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\Operations\Index.cshtml"
                 Write(serviceSingletonOperation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Service Instance: ");
#nullable restore
#line 31 "C:\Meine Vorlagen\ASPNETCORE5_MVC_TEMPLATE\DIScopeVsTransientVsSingletonSample\Views\Operations\Index.cshtml"
                Write(serviceInstanceOperation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n");
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
