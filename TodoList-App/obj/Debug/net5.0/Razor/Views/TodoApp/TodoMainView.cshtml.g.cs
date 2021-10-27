#pragma checksum "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\TodoMainView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f7f413eed767ab13d2d8bde54f451611eec5b35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TodoApp_TodoMainView), @"mvc.1.0.view", @"/Views/TodoApp/TodoMainView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f7f413eed767ab13d2d8bde54f451611eec5b35", @"/Views/TodoApp/TodoMainView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e9dc37c3f9ec6adf1ef4a1df03265c38247c469", @"/Views/_ViewImports.cshtml")]
    public class Views_TodoApp_TodoMainView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Todo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row mt-5"">
    <div class=""col-sm-12 container w-50 overflow-auto"">
        <nav class=""sticky-md-top"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <p class=""display-6 text-center"">Todo-List App</p>
                </div>
            </div>
            <div class=""row mt-5"">
                <div class=""col-md-12"">
                    <button class=""btn btn-outline-primary"" onclick=""showModal('/TodoApp/GetModalView','#modal-placeholder','Add-todo')""><i class=""fa fa-plus fa-xs""></i> Add Todo</button>
                    <button class=""btn btn-outline-danger""><i class=""fa fa-trash fa-xs""></i> Remove All</button>
                </div>
            </div>
        </nav>
        <div class=""row mt-5"" id=""table-holder"">

            <div class=""table-responsive-sm"">
                <table class=""table table-hover"">
                    <thead>
                        <tr class=""text-center"">
                            <th>To-do</th>
    ");
            WriteLiteral("                        <th>Actions</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody >\r\n");
#nullable restore
#line 28 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\TodoMainView.cshtml"
                         if (Model.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-primary h6\">You have no Todo in list</p>\r\n");
#nullable restore
#line 31 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\TodoMainView.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\TodoMainView.cshtml"
                             foreach (var todo in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 37 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\TodoMainView.cshtml"
                                   Write(todo.TodoTask);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <button class=\"btn btn-warning\" data-url=\"");
#nullable restore
#line 39 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\TodoMainView.cshtml"
                                                                             Write(Url.Action("GetTodo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-toggle=""ajax-model"" data-target=""#modalpop""><i class=""fas fa-pen""></i></button>
                                        <button class=""btn btn-danger""><i class=""fas fa-trash""></i></button>
                                    </td>
                                </tr>
");
#nullable restore
#line 43 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\TodoMainView.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Boss\source\repos\TodoList-App\TodoList-App\Views\TodoApp\TodoMainView.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
            </table>
        </div>
        </div>

    </div>
</div>

<div class=""toast hide position-fixed top-0 end-0""  id=""live-toast"" style=""z-index:11"">

    <div class=""-toast-header pt-1 px-1"">
        <p class=""text-muted"">Notification <i class=""fa fa-bell""></i></p>
        <button class=""btn-close text-white float-end px-1"" data-bs-dismiss=""toast""></button>
    </div>
    <div class=""toast-body"">
        <p>New thing added!</p>
    </div>

</div>


<div id=""modal-placeholder""></div>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0f7f413eed767ab13d2d8bde54f451611eec5b357811", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Todo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
