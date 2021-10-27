#pragma checksum "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\_TablePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4619be61faca2f2ae4ad3cb3cf36170b988a0413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TodoApp__TablePartial), @"mvc.1.0.view", @"/Views/TodoApp/_TablePartial.cshtml")]
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
#line 1 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\_ViewImports.cshtml"
using TodoList_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\_ViewImports.cshtml"
using TodoList_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4619be61faca2f2ae4ad3cb3cf36170b988a0413", @"/Views/TodoApp/_TablePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e9dc37c3f9ec6adf1ef4a1df03265c38247c469", @"/Views/_ViewImports.cshtml")]
    public class Views_TodoApp__TablePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TodoList_App.Models.Todo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"table-responsive-sm\">\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr class=\"text-center\">\r\n                <th>To-do</th>\r\n                <th>Actions</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\_TablePartial.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-primary h6\">You have no Todo in list</p>\r\n");
#nullable restore
#line 15 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\_TablePartial.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\_TablePartial.cshtml"
                 foreach (var todo in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\_TablePartial.cshtml"
                       Write(todo.TodoTask);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <button class=\"btn btn-warning\" data-url=\"");
#nullable restore
#line 23 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\_TablePartial.cshtml"
                                                                 Write(Url.Action("GetTodo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"ajax-model\" data-target=\"#modalpop\"><i class=\"fas fa-pen\"></i></button>\r\n                            <button class=\"btn btn-danger\"><i class=\"fas fa-trash\"></i></button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\_TablePartial.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\_TablePartial.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TodoList_App.Models.Todo>> Html { get; private set; }
    }
}
#pragma warning restore 1591