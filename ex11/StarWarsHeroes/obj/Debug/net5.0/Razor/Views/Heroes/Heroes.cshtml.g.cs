#pragma checksum "/Users/saltdev/Desktop/personal_exercises/C-Sharp_exercises/ex10/StarWarsHeroes/Views/Heroes/Heroes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ad6ef2d8d37c943c45f778b2b538e7732decdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Heroes_Heroes), @"mvc.1.0.view", @"/Views/Heroes/Heroes.cshtml")]
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
#line 1 "/Users/saltdev/Desktop/personal_exercises/C-Sharp_exercises/ex10/StarWarsHeroes/Views/_ViewImports.cshtml"
using StarWarsHeroes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/saltdev/Desktop/personal_exercises/C-Sharp_exercises/ex10/StarWarsHeroes/Views/_ViewImports.cshtml"
using StarWarsHeroes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ad6ef2d8d37c943c45f778b2b538e7732decdc", @"/Views/Heroes/Heroes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd66ef2e43e284969660811112ff9f3d3f9f6da4", @"/Views/_ViewImports.cshtml")]
    public class Views_Heroes_Heroes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StarWarsHeroes.Models.Heroes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/saltdev/Desktop/personal_exercises/C-Sharp_exercises/ex10/StarWarsHeroes/Views/Heroes/Heroes.cshtml"
  
    ViewBag.Title = "Star Wars Heroes";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Star Wars Heroes</h2>\n");
#nullable restore
#line 9 "/Users/saltdev/Desktop/personal_exercises/C-Sharp_exercises/ex10/StarWarsHeroes/Views/Heroes/Heroes.cshtml"
 foreach (var hero in Model.HeroesList)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 11 "/Users/saltdev/Desktop/personal_exercises/C-Sharp_exercises/ex10/StarWarsHeroes/Views/Heroes/Heroes.cshtml"
  Write(hero.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : Gender: ");
#nullable restore
#line 11 "/Users/saltdev/Desktop/personal_exercises/C-Sharp_exercises/ex10/StarWarsHeroes/Views/Heroes/Heroes.cshtml"
                       Write(hero.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ; Hair Color: ");
#nullable restore
#line 11 "/Users/saltdev/Desktop/personal_exercises/C-Sharp_exercises/ex10/StarWarsHeroes/Views/Heroes/Heroes.cshtml"
                                                  Write(hero.HairColor);

#line default
#line hidden
#nullable disable
            WriteLiteral(";  Skin Color: ");
#nullable restore
#line 11 "/Users/saltdev/Desktop/personal_exercises/C-Sharp_exercises/ex10/StarWarsHeroes/Views/Heroes/Heroes.cshtml"
                                                                                Write(hero.SkinColor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 12 "/Users/saltdev/Desktop/personal_exercises/C-Sharp_exercises/ex10/StarWarsHeroes/Views/Heroes/Heroes.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StarWarsHeroes.Models.Heroes> Html { get; private set; }
    }
}
#pragma warning restore 1591
