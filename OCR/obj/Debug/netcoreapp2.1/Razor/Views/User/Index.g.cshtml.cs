#pragma checksum "C:\Users\Endrit\Desktop\OCR\OCR\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf622add63b3dc6cab8c025245f3ca7d97fe497"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "C:\Users\Endrit\Desktop\OCR\OCR\Views\_ViewImports.cshtml"
using OCR;

#line default
#line hidden
#line 2 "C:\Users\Endrit\Desktop\OCR\OCR\Views\_ViewImports.cshtml"
using OCR.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cf622add63b3dc6cab8c025245f3ca7d97fe497", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1ef6e074d485e85d76aff7760ec867db3e4f42", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Endrit\Desktop\OCR\OCR\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 470, true);
            WriteLiteral(@"

<div>
    <div class=""col"">
        <input id=""id"" type=""number"" />ID:
        <input id=""emri"" type=""text"" /> Emri:

      
        
        <button onclick=""newUser()"">Krijo</button>
        <button onclick=""fshij()"">Fshij</button>
    </div>

</div>

<script type=""text/javascript"">
    function newUser() {
        var user = {
            Id: $(""#id"").val(),
            Emri : $(""#emri"").val()
        };
        $.ajax({
            url: """);
            EndContext();
            BeginContext(514, 27, false);
#line 27 "C:\Users\Endrit\Desktop\OCR\OCR\Views\User\Index.cshtml"
             Write(Url.Action("Create","User"));

#line default
#line hidden
            EndContext();
            BeginContext(541, 909, true);
            WriteLiteral(@""",
            type: ""POST"",
            dataType: ""json"",
            contentType: ""application/json"",
            data: JSON.stringify(user),
            statusCode: {
                200: function () {
                    swal(""Success"", ""Useri u shtua."", ""success"");
                },
                400: function (data) {
                    swal(""Error"", ""Bad request error (HTTP 400)."", ""error"");
                },
                401: function () {
                    swal(""Error"", ""Unauthorized error (HTTP 401)"", ""error"");
                },
                500: function (data) {
                    swal(""Error"", ""Internal server error (HTTP 500)"", ""error"");
                }
            },
            error: function (request, status, error) {
                swal(""Error"", request.status + "": "" + error, ""error"");
            }

        });
    }


</script>

");
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
