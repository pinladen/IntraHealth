#pragma checksum "D:\DoAnHocKi3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36e31c14ffad91d4c7d8a36c855563cb49feb3e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36e31c14ffad91d4c7d8a36c855563cb49feb3e7", @"/Areas/Admin/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\DoAnHocKi3\C1908I3_White_NGO\C1908I3_White_NGO\IntraHealth\IntraHealth\Areas\Admin\Views\Home\index.cshtml"
  
    ViewData["Title"] = "index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"page-wrapper\">\r\n    <div class=\"header\">\r\n        <h1 class=\"page-header\">\r\n            Dashboard <small>Welcome John Doe</small>\r\n        </h1>\r\n        <ol class=\"breadcrumb\">\r\n            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36e31c14ffad91d4c7d8a36c855563cb49feb3e74240", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            <li class=""active"">Data</li>
        </ol>

    </div>
    <div id=""page-inner"">

        <!-- /. ROW  -->

        <div class=""row"">
            <div class=""col-md-3 col-sm-12 col-xs-12"">
                <div class=""board"">
                    <div class=""panel panel-primary"">
                        <div class=""number"">
                            <h3>
                                44,023
                                <small>User</small>
                            </h3>
                        </div>
                        <div class=""icon"">
                            <i class=""fa fa-eye fa-5x red""></i>
                        </div>

                    </div>
                </div>
            </div>

            <div class=""col-md-3 col-sm-12 col-xs-12"">
                <div class=""board"">
                    <div class=""panel panel-primary"">
                        <div class=""number"">
                            <h3>
                             ");
            WriteLiteral(@"   32,850
                                <small>Sales</small>
                            </h3>
                        </div>
                        <div class=""icon"">
                            <i class=""fa fa-shopping-cart fa-5x blue""></i>
                        </div>

                    </div>
                </div>
            </div>

            <div class=""col-md-3 col-sm-12 col-xs-12"">
                <div class=""board"">
                    <div class=""panel panel-primary"">
                        <div class=""number"">
                            <h3>
                                56,150
                                <small>Comments</small>
                            </h3>
                        </div>
                        <div class=""icon"">
                            <i class=""fa fa-comments fa-5x green""></i>
                        </div>

                    </div>
                </div>
            </div>

            <div class=""col-md-3 col-sm-12 col-x");
            WriteLiteral(@"s-12"">
                <div class=""board"">
                    <div class=""panel panel-primary"">
                        <div class=""number"">
                            <h3>
                                89,645
                                <small>Daily Profits</small>
                            </h3>
                        </div>
                        <div class=""icon"">
                            <i class=""fa fa-user fa-5x yellow""></i>
                        </div>

                    </div>
                </div>
            </div>

        </div>
        <div class=""row"">
            <div class=""col-sm-6 col-xs-12"">
                <div class=""panel panel-default chartJs"">
                    <div class=""panel-heading"">
                        <div class=""card-title"">
                            <div class=""title"">Line Chart</div>
                        </div>
                    </div>
                    <div class=""panel-body"">
                        <canvas id=""");
            WriteLiteral(@"line-chart"" class=""chart""></canvas>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6 col-xs-12"">
                <div class=""panel panel-default chartJs"">
                    <div class=""panel-heading"">
                        <div class=""card-title"">
                            <div class=""title"">Bar Chart</div>
                        </div>
                    </div>
                    <div class=""panel-body"">
                        <canvas id=""bar-chart"" class=""chart""></canvas>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-xs-6 col-md-3"">
                <div class=""panel panel-default"">
                    <div class=""panel-body easypiechart-panel"">
                        <h4>Profit</h4>
                        <div class=""easypiechart"" id=""easypiechart-blue"" data-percent=""82"">
                            <span class=""percent"">82%</sp");
            WriteLiteral(@"an>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xs-6 col-md-3"">
                <div class=""panel panel-default"">
                    <div class=""panel-body easypiechart-panel"">
                        <h4>Sales</h4>
                        <div class=""easypiechart"" id=""easypiechart-orange"" data-percent=""55"">
                            <span class=""percent"">55%</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xs-6 col-md-3"">
                <div class=""panel panel-default"">
                    <div class=""panel-body easypiechart-panel"">
                        <h4>Customers</h4>
                        <div class=""easypiechart"" id=""easypiechart-teal"" data-percent=""84"">
                            <span class=""percent"">84%</span>
                        </div>
                    </div>
                </div>
         ");
            WriteLiteral(@"   </div>
            <div class=""col-xs-6 col-md-3"">
                <div class=""panel panel-default"">
                    <div class=""panel-body easypiechart-panel"">
                        <h4>No. of Visits</h4>
                        <div class=""easypiechart"" id=""easypiechart-red"" data-percent=""46"">
                            <span class=""percent"">46%</span>
                        </div>
                    </div>
                </div>
            </div>
        </div><!--/.row-->


        <div class=""row"">
            <div class=""col-md-5"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        Line Chart
                    </div>
                    <div class=""panel-body"">
                        <div id=""morris-line-chart""></div>
                    </div>
                </div>
            </div>

            <div class=""col-md-7"">
                <div class=""panel panel-default"">
                    ");
            WriteLiteral(@"<div class=""panel-heading"">
                        Bar Chart Example
                    </div>
                    <div class=""panel-body"">
                        <div id=""morris-bar-chart""></div>
                    </div>

                </div>
            </div>

        </div>



        <div class=""row"">
            <div class=""col-md-9 col-sm-12 col-xs-12"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        Area Chart
                    </div>
                    <div class=""panel-body"">
                        <div id=""morris-area-chart""></div>
                    </div>
                </div>
            </div>
            <div class=""col-md-3 col-sm-12 col-xs-12"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        Donut Chart Example
                    </div>
                    <div class=""panel-body"">
                     ");
            WriteLiteral(@"   <div id=""morris-donut-chart""></div>
                    </div>
                </div>
            </div>

        </div>
        <div class=""row"">
            <div class=""col-md-12"">

            </div>
        </div>
        <!-- /. ROW  -->
        <div class=""row"">
            <div class=""col-md-12    col-sm-12 col-xs-12"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        Tasks Panel
                    </div>
                    <div class=""panel-body"">
                        <div class=""list-group"">

                            <a href=""#"" class=""list-group-item"">
                                <span class=""badge"">7 minutes ago</span>
                                <i class=""fa fa-fw fa-comment""></i> Commented on a post
                            </a>
                            <a href=""#"" class=""list-group-item"">
                                <span class=""badge"">16 minutes ago</span>
            ");
            WriteLiteral(@"                    <i class=""fa fa-fw fa-truck""></i> Order 392 shipped
                            </a>
                            <a href=""#"" class=""list-group-item"">
                                <span class=""badge"">36 minutes ago</span>
                                <i class=""fa fa-fw fa-globe""></i> Invoice 653 has paid
                            </a>
                            <a href=""#"" class=""list-group-item"">
                                <span class=""badge"">1 hour ago</span>
                                <i class=""fa fa-fw fa-user""></i> A new user has been added
                            </a>
                            <a href=""#"" class=""list-group-item"">
                                <span class=""badge"">1.23 hour ago</span>
                                <i class=""fa fa-fw fa-user""></i> A new user has added
                            </a>
                            <a href=""#"" class=""list-group-item"">
                                <span class=""badge"">yesterday</s");
            WriteLiteral(@"pan>
                                <i class=""fa fa-fw fa-globe""></i> Saved the world
                            </a>
                        </div>
                        <div class=""text-right"">
                            <a href=""#"">More Tasks <i class=""fa fa-arrow-circle-right""></i></a>
                        </div>
                    </div>
                </div>

            </div>
            <div class=""col-md-8 col-sm-12 col-xs-12"">

                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        Responsive Table Example
                    </div>
                    <div class=""panel-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-striped table-bordered table-hover"">
                                <thead>
                                    <tr>
                                        <th>S No.</th>
                                        <th>Fir");
            WriteLiteral(@"st Name</th>
                                        <th>Last Name</th>
                                        <th>User Name</th>
                                        <th>Email ID.</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>1</td>
                                        <td>John</td>
                                        <td>Doe</td>
                                        <td>John15482</td>
                                        <td>name@site.com</td>
                                    </tr>
                                    <tr>
                                        <td>2</td>
                                        <td>Kimsila</td>
                                        <td>Marriye</td>
                                        <td>Kim1425</td>
                                        <td>name@site.com</td>
  ");
            WriteLiteral(@"                                  </tr>
                                    <tr>
                                        <td>3</td>
                                        <td>Rossye</td>
                                        <td>Nermal</td>
                                        <td>Rossy1245</td>
                                        <td>name@site.com</td>
                                    </tr>
                                    <tr>
                                        <td>4</td>
                                        <td>Richard</td>
                                        <td>Orieal</td>
                                        <td>Rich5685</td>
                                        <td>name@site.com</td>
                                    </tr>
                                    <tr>
                                        <td>5</td>
                                        <td>Jacob</td>
                                        <td>Hielsar</td>
                         ");
            WriteLiteral(@"               <td>Jac4587</td>
                                        <td>name@site.com</td>
                                    </tr>
                                    <tr>
                                        <td>6</td>
                                        <td>Wrapel</td>
                                        <td>Dere</td>
                                        <td>Wrap4585</td>
                                        <td>name@site.com</td>
                                    </tr>

                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <footer>
            <p>All right reserved. Template by: <a href=""http://webthemez.com"">WebThemez.com</a></p>


        </footer>
    </div>
    <!-- /. PAGE INNER  -->
</div>
<!-- /. PAGE WRAPPER  -->
");
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
