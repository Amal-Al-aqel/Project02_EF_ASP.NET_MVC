#pragma checksum "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eb331fec60afec0f66eec8e8f3b5ab04a0594f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_Index), @"mvc.1.0.view", @"/Views/Session/Index.cshtml")]
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
#line 1 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\_ViewImports.cshtml"
using Tuwaiq_Student_Life;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\_ViewImports.cshtml"
using Tuwaiq_Student_Life.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb331fec60afec0f66eec8e8f3b5ab04a0594f5", @"/Views/Session/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d50ac0b9957e69b0a494d6132ae43f5ac4e006d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Session_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml"
  
    var Sessions = (List<SessionModel>)ViewData["Sessions"];
    var Instructors = (List<InstructorModel>)ViewData["Instructors"];
    InstructorModel myInstructor = null;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Available Sessions</h1>

<div class=""div-background"">
    <table class=""table"">
        <tr>
            <th>Session</th>
            <th>Duration</th>
            <th>Location</th>
            <th>Instructor</th>
        </tr>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml"
             foreach (var Session in Sessions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml"
               Write(Session.SessionTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml"
               Write(Session.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml"
               Write(Session.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 28 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml"
                  myInstructor = Instructors.Find(I => I.Id == Session.InstructorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 29 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml"
           Write(myInstructor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 29 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml"
                                    Write(myInstructor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 986, "\"", 1023, 2);
            WriteAttributeValue("", 993, "Session/Delete/?id=", 993, 19, true);
#nullable restore
#line 31 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml"
WriteAttributeValue("", 1012, Session.Id, 1012, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-info\">Delete</a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\96655\source\repos\Tuwaiq Student Life1\Tuwaiq Student Life\Views\Session\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    </div>");
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
