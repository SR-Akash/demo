#pragma checksum "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08b61c959dee46c6ec06237a8afe29dacfef7155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Search), @"mvc.1.0.view", @"/Views/Student/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Search.cshtml", typeof(AspNetCore.Views_Student_Search))]
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
#line 1 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\_ViewImports.cshtml"
using CAC_Management;

#line default
#line hidden
#line 2 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\_ViewImports.cshtml"
using CAC_Management.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b61c959dee46c6ec06237a8afe29dacfef7155", @"/Views/Student/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d480e88fc2ea1a4d87350da6cf5607cfa8fe1ad9", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CAC_Management.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #45CD93;align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
  
    ViewData["Title"] = "Student Details";
    Layout = "_LayoutForAdmin";

#line default
#line hidden
            BeginContext(122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(124, 2772, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7479983ba22842589d80a2ec44b98de0", async() => {
                BeginContext(187, 1544, true);
                WriteLiteral(@"
    <h1 style=""text-align:center"">Student Information Details</h1>

    <div class=""container"">
        <table border=""1"" class=""table table-bordered"" cellpadding=""1"" cellspacing=""1"">
            <thead>
                <tr>
                    <td style=""text-align:center; font-weight: bold;"">Student Id</td>
                    <td style=""text-align:center; font-weight: bold;"">Student Name</td>
                    <td style=""text-align:center; font-weight: bold;"">Father Name</td>
                    <td style=""text-align:center; font-weight: bold;"">Mother Name</td>
                    <td style=""text-align:center; font-weight: bold;"">DOB</td>
                    <td style=""text-align:center; font-weight: bold;"">Gender</td>
                    <td style=""text-align:center; font-weight: bold;"">Address</td>
                    <td style=""text-align:center; font-weight: bold;"">Contact</td>
                    <td style=""text-align:center; font-weight: bold;"">Email</td>
                    <td st");
                WriteLiteral(@"yle=""text-align:center; font-weight: bold;"">Password</td>
                    <td style=""text-align:center; font-weight: bold;"">Tution Fee</td>
                    <td style=""text-align:center; font-weight: bold;"">Pay Amount</td>
                    <td style=""text-align:center; font-weight: bold;"">Due Amount</td>
                    <td style=""text-align:center; font-weight: bold;"">Payment Status</td>
                </tr>
            </thead>
            <tr>
                <td style=""text-align:center"">");
                EndContext();
                BeginContext(1732, 15, false);
#line 31 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.StudentId);

#line default
#line hidden
                EndContext();
                BeginContext(1747, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1801, 17, false);
#line 32 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.StudentName);

#line default
#line hidden
                EndContext();
                BeginContext(1818, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1872, 16, false);
#line 33 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.FatherName);

#line default
#line hidden
                EndContext();
                BeginContext(1888, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(1942, 16, false);
#line 34 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.MotherName);

#line default
#line hidden
                EndContext();
                BeginContext(1958, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(2012, 9, false);
#line 35 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.DOB);

#line default
#line hidden
                EndContext();
                BeginContext(2021, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(2075, 12, false);
#line 36 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.Gender);

#line default
#line hidden
                EndContext();
                BeginContext(2087, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(2141, 13, false);
#line 37 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.Address);

#line default
#line hidden
                EndContext();
                BeginContext(2154, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(2208, 13, false);
#line 38 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.Contact);

#line default
#line hidden
                EndContext();
                BeginContext(2221, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(2275, 11, false);
#line 39 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.Email);

#line default
#line hidden
                EndContext();
                BeginContext(2286, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(2340, 14, false);
#line 40 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.Password);

#line default
#line hidden
                EndContext();
                BeginContext(2354, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(2408, 16, false);
#line 41 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.TuitionFee);

#line default
#line hidden
                EndContext();
                BeginContext(2424, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(2478, 15, false);
#line 42 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.PayAmount);

#line default
#line hidden
                EndContext();
                BeginContext(2493, 53, true);
                WriteLiteral("</td>\r\n                <td style=\"text-align:center\">");
                EndContext();
                BeginContext(2547, 15, false);
#line 43 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                                         Write(Model.DueAmount);

#line default
#line hidden
                EndContext();
                BeginContext(2562, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 44 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                 if (Model.PaymentStatus == 0)
                {

#line default
#line hidden
                BeginContext(2636, 61, true);
                WriteLiteral("                    <td style=\"text-align:center\">Paid</td>\r\n");
                EndContext();
#line 47 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(2757, 60, true);
                WriteLiteral("                    <td style=\"text-align:center\">Due</td>\r\n");
                EndContext();
#line 51 "E:\I U B A T\PPRROOJJEECCTT\A4\Project\CAC Management\CAC Management\Views\Student\Search.cshtml"
                }

#line default
#line hidden
                BeginContext(2836, 53, true);
                WriteLiteral("            </tr>\r\n        </table>\r\n    </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2896, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CAC_Management.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591