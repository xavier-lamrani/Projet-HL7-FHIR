#pragma checksum "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7a3789b63a2f31353a0da0673031654ba97871b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7a3789b63a2f31353a0da0673031654ba97871b", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e6705cf679feb45965ee30e4a4d51e5c0cd35aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Hl7.Fhir.Model.Patient>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Accueil";

#line default
#line hidden
            BeginContext(89, 263, true);
            WriteLiteral(@"
<h2>Application de gestion de Patients</h2>
<div class=""container"">
    <div class=""panel panel-primary"">
        <div class=""panel-heading"">Liste des Patient</div>
        <div class=""panel-default"">
            <div class=""container"">

                ");
            EndContext();
            BeginContext(352, 294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e57595956944c89bdc402c0e261eb4", async() => {
                BeginContext(409, 100, true);
                WriteLiteral("\r\n                    <label>Mot Clé :</label>\r\n                    <input type=\"text\" name=\"motCle\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 509, "\"", 532, 1);
#line 16 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
WriteAttributeValue("", 517, ViewBag.motCle, 517, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(533, 106, true);
                WriteLiteral(" />\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Chercher</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(646, 47, true);
            WriteLiteral(" \r\n                <hr />\r\n                <p> ");
            EndContext();
            BeginContext(693, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a2ab513d1144b3e98ca00df550d1174", async() => {
                BeginContext(716, 21, true);
                WriteLiteral("Créer nouveau patient");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(741, 977, true);
            WriteLiteral(@"</p>
            </div>

           
           

            <table class=""table table-striped"">
                <thead>
                    <tr>

                        <th>
                            Nom complet

                        </th>
                        <th>
                            Date de naissance
                        </th>
                        <th>
                            Sexe
                        </th>
                        <th>
                            Status marital
                        </th>
                        <th>
                            Téléphone
                        </th>
                        <th>
                            Adresse
                        </th>
                        <th>
                            Ville
                        </th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 56 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1791, 60, true);
            WriteLiteral("                        <tr>\r\n\r\n                            ");
            EndContext();
            BeginContext(1852, 36, false);
#line 60 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                       Write(Html.HiddenFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 77, true);
            WriteLiteral("\r\n\r\n                            <td>\r\n\r\n                                <p>\r\n");
            EndContext();
#line 65 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                                       var Prefix = item.Name[0].Prefix;
                                        

#line default
#line hidden
            BeginContext(2080, 36, false);
#line 66 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                                   Write(Html.DisplayFor(modelItem => Prefix));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(2156, 49, false);
#line 67 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name[0].Family));

#line default
#line hidden
            EndContext();
            BeginContext(2205, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2244, 48, false);
#line 68 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name[0].Given));

#line default
#line hidden
            EndContext();
            BeginContext(2292, 143, true);
            WriteLiteral("\r\n                                </p>\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2436, 44, false);
#line 73 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                           Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(2480, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2584, 47, false);
#line 76 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Gender.Value));

#line default
#line hidden
            EndContext();
            BeginContext(2631, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2735, 66, false);
#line 79 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                           Write(Html.DisplayFor(modelItem => item.MaritalStatus.Coding[0].Display));

#line default
#line hidden
            EndContext();
            BeginContext(2801, 105, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2907, 51, false);
#line 83 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Telecom[0].Value));

#line default
#line hidden
            EndContext();
            BeginContext(2958, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3062, 50, false);
#line 86 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Address[0].Line));

#line default
#line hidden
            EndContext();
            BeginContext(3112, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3216, 50, false);
#line 89 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Address[0].City));

#line default
#line hidden
            EndContext();
            BeginContext(3266, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3370, 53, false);
#line 92 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3423, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(3460, 127, false);
#line 93 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new { onclick = "return confirm('êtes vous sure de supprimer ?');" }));

#line default
#line hidden
            EndContext();
            BeginContext(3587, 70, true);
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 97 "C:\Users\MIAGE\source\repos\HL7-FHIR\Last_Fhir\Views\Home\Home.cshtml"
                    }

#line default
#line hidden
            BeginContext(3680, 106, true);
            WriteLiteral("\r\n\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n            </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Hl7.Fhir.Model.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
