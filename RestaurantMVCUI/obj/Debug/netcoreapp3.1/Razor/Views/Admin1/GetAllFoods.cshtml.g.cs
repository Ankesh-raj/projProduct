#pragma checksum "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4919d713ff26c06600da5124d671711031cd45c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin1_GetAllFoods), @"mvc.1.0.view", @"/Views/Admin1/GetAllFoods.cshtml")]
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
#line 1 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\_ViewImports.cshtml"
using RestaurantMVCUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\_ViewImports.cshtml"
using RestaurantMVCUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4919d713ff26c06600da5124d671711031cd45c2", @"/Views/Admin1/GetAllFoods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3d282d11171782d64e6461b1948706aa7dabf3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin1_GetAllFoods : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RestaurantEntity.Food>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditFood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#5A3B5D;color:white;padding-bottom:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin1.cshtml";


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4919d713ff26c06600da5124d671711031cd45c26265", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4919d713ff26c06600da5124d671711031cd45c26527", async() => {
                    WriteLiteral("<img class=\"img-fluid\" style=\"height:35px\" src=\"https://www.svgrepo.com/show/163122/backward-arrow.svg\">");
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <div class=""container"">
  

        <h2 class=""text-center text-uppercase font-weight-bolder"" style=""color:#1e88e5; font-size:36px"">All Food </h2>



<div class=""row"">
    <div class=""col-12 text-white"">
 
        <hr />
        <table class=""table  table-bordered table-hover"">
            <thead>
                <tr style=""color:white"">
                    
                    <th>Food Id</th>
                    <th>Food Name</th>
                    <th>Food Type</th>
                    <th>Food Cost</th>
                    <th>Food Cuisine</th>
                    <th>Food Image</th>
                   

                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 36 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
                 foreach (var Food in Model) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
                  
                {
                     string imageBase64Data = Convert.ToBase64String(Food.FoodImage);
                    string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr style=\"color:white\">\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
                       Write(Food.FoodId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
                       Write(Food.FoodName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
                       Write(Food.FoodType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
                       Write(Food.FoodCost);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
                       Write(Food.FoodCuisine);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                  \r\n                          <td><img height=\"50\" width=\"50\"");
                BeginWriteAttribute("src", " src=\"", 2133, "\"", 2152, 1);
#nullable restore
#line 49 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
WriteAttributeValue("", 2139, imageDataURL, 2139, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n\r\n                        <td>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4919d713ff26c06600da5124d671711031cd45c212207", async() => {
                    WriteLiteral("<img class=\"img-fluid\" style=\"height:40px\" src=\"https://www.svgrepo.com/show/241804/edit.svg\" />");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-FoodId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
                                         WriteLiteral(Food.FoodId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["FoodId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-FoodId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["FoodId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4919d713ff26c06600da5124d671711031cd45c214925", async() => {
                    WriteLiteral("<img class=\"img-fluid\" style=\"height:50px\" src=\"https://www.svgrepo.com/show/243864/delete.svg\" />");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-FoodId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"
                                         WriteLiteral(Food.FoodId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["FoodId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-FoodId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["FoodId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 61 "C:\Users\ankesh.raj\Desktop\Resturant1\Restaurant_All\RestaurantManagement\RestaurantMVCUI\Views\Admin1\GetAllFoods.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RestaurantEntity.Food>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
