#pragma checksum "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28a3c4131bd933dc4b8d53324d6622fcfb722afd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\_ViewImports.cshtml"
using Last_Fhir;

#line default
#line hidden
#line 2 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\_ViewImports.cshtml"
using Last_Fhir.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28a3c4131bd933dc4b8d53324d6622fcfb722afd", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e6705cf679feb45965ee30e4a4d51e5c0cd35aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\About.cshtml"
  
    ViewData["Title"] = "À propos";

#line default
#line hidden
            BeginContext(44, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(49, 17, false);
#line 4 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(66, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(78, 19, false);
#line 5 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(97, 127, true);
            WriteLiteral("</h3>\r\n\r\n\r\n<div class=\"badge\">\r\n    <p>Groupe d\'étudiants en MIAGE à Polytech LYON </p>\r\n \r\n\r\n</div>\r\n\r\n<p>Miage M2 2019.</p>\r\n");
            EndContext();
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
