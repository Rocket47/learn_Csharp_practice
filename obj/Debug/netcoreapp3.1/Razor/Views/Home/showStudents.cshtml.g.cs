#pragma checksum "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08e5200a98933fc90add11549ecaadeee0a4501b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_showStudents), @"mvc.1.0.view", @"/Views/Home/showStudents.cshtml")]
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
#line 1 "D:\foxminded\learn_csharp\MVCApps\Views\_ViewImports.cshtml"
using MVCApps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\foxminded\learn_csharp\MVCApps\Views\_ViewImports.cshtml"
using MVCApps.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e5200a98933fc90add11549ecaadeee0a4501b", @"/Views/Home/showStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7601f375a7a0d404c010144d67f44d4f7074e5a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_showStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCApps.Models.Student>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
  
  //  ViewData["Title"] = "Course list";
  Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e5200a98933fc90add11549ecaadeee0a4501b3637", async() => {
                WriteLiteral("\r\n    <title>University</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e5200a98933fc90add11549ecaadeee0a4501b4636", async() => {
                WriteLiteral("\r\n    <h3>Groups</h3>\r\n    <table>\r\n      <tr>\r\n            <td>STUDENT ID</td>\r\n            <td>GROUP ID</td>\r\n            <td>FIRST NAME</td>\r\n            <td>LAST NAME</td>            \r\n            <td></td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
           foreach (var student in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
                 if (student.group_ID == ViewBag.student_ID)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>                \r\n                <td>");
#nullable restore
#line 28 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
               Write(student.student_ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
               Write(student.group_ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
               Write(student.first_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>  \r\n                <td>");
#nullable restore
#line 31 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
               Write(student.last_Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>                     \r\n                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e5200a98933fc90add11549ecaadeee0a4501b6709", async() => {
                    WriteLiteral("Изменить имя студента");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 827, "~/Home/changeNameOfStudent/?studentName=", 827, 40, true);
#nullable restore
#line 32 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
AddHtmlAttributeValue("", 867, student.first_Name, 867, 19, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 886, "&studentLastName=", 886, 17, true);
#nullable restore
#line 32 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
AddHtmlAttributeValue("", 903, student.last_Name, 903, 18, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 921, "&student_id=", 921, 12, true);
#nullable restore
#line 32 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
AddHtmlAttributeValue("", 933, student.student_ID, 933, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>                                              \r\n            </tr>            \r\n");
#nullable restore
#line 34 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\foxminded\learn_csharp\MVCApps\Views\Home\showStudents.cshtml"
             
        }              

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCApps.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
