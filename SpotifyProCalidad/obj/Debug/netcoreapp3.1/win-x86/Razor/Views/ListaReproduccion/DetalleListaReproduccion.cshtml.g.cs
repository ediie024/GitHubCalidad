#pragma checksum "D:\Upn 2020-2\Calidad\gitgub\Calidad\SpotifyProCalidad\SpotifyProCalidad\Views\ListaReproduccion\DetalleListaReproduccion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd9d74ed3e724c5cc0cd404df4cc7e73a0c19618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListaReproduccion_DetalleListaReproduccion), @"mvc.1.0.view", @"/Views/ListaReproduccion/DetalleListaReproduccion.cshtml")]
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
#line 1 "D:\Upn 2020-2\Calidad\gitgub\Calidad\SpotifyProCalidad\SpotifyProCalidad\Views\_ViewImports.cshtml"
using SpotifyProCalidad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Upn 2020-2\Calidad\gitgub\Calidad\SpotifyProCalidad\SpotifyProCalidad\Views\_ViewImports.cshtml"
using SpotifyProCalidad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd9d74ed3e724c5cc0cd404df4cc7e73a0c19618", @"/Views/ListaReproduccion/DetalleListaReproduccion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b36fccfd95d5b6614409874ae07930960782390", @"/Views/_ViewImports.cshtml")]
    public class Views_ListaReproduccion_DetalleListaReproduccion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "D:\Upn 2020-2\Calidad\gitgub\Calidad\SpotifyProCalidad\SpotifyProCalidad\Views\ListaReproduccion\DetalleListaReproduccion.cshtml"
  
    Layout = "~/Views/Shared/Principal.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Listas de Canciones </h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd9d74ed3e724c5cc0cd404df4cc7e73a0c196183778", async() => {
                WriteLiteral(@"
  

        
        <style>
        #Playerlist{
                list-style: none;
                }
                #Playerlist li a{
                color: #1b1e21;
                text-decoration: none;
                }
                #Playerlist .current-song a{
                color: blue;
                }
        </style>
   
    ");
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
            WriteLiteral("\r\n \r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd9d74ed3e724c5cc0cd404df4cc7e73a0c196185114", async() => {
                WriteLiteral("\r\n<audio");
                BeginWriteAttribute("src", " src=\"", 493, "\"", 499, 0);
                EndWriteAttribute();
                WriteLiteral(" controls id=\"audioPlayer\">\r\n    \r\n</audio>\r\n<ul id=\"playlist\">\r\n");
#nullable restore
#line 34 "D:\Upn 2020-2\Calidad\gitgub\Calidad\SpotifyProCalidad\SpotifyProCalidad\Views\ListaReproduccion\DetalleListaReproduccion.cshtml"
         foreach (var item in @ViewBag.DetalleDeCanciones)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("         <li class=\"current-song\">\r\n    \r\n                \r\n           <a");
                BeginWriteAttribute("href", " href=", 709, "", 727, 1);
#nullable restore
#line 39 "D:\Upn 2020-2\Calidad\gitgub\Calidad\SpotifyProCalidad\SpotifyProCalidad\Views\ListaReproduccion\DetalleListaReproduccion.cshtml"
WriteAttributeValue("", 715, item.Musica, 715, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 39 "D:\Upn 2020-2\Calidad\gitgub\Calidad\SpotifyProCalidad\SpotifyProCalidad\Views\ListaReproduccion\DetalleListaReproduccion.cshtml"
                           Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n    \r\n          </li>\r\n");
#nullable restore
#line 42 "D:\Upn 2020-2\Calidad\gitgub\Calidad\SpotifyProCalidad\SpotifyProCalidad\Views\ListaReproduccion\DetalleListaReproduccion.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("</ul>\r\n\r\n");
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
            WriteLiteral(@"
<script>
    audioPlayer();
        function audioPlayer(){
            var currentSong = 0;
            $(""#audioPlayer"")[0].src = $(""#playlist li a"")[0];
            $(""#audioPlayer"")[0].play();
            $(""#playlist li a"").click(function(e){
               e.preventDefault(); 
               $(""#audioPlayer"")[0].src = this;
               $(""#audioPlayer"")[0].play();
               $(""#playlist li"").removeClass(""current-song"");
                currentSong = $(this).parent().index();
                $(this).parent().addClass(""current-song"");
            });
            
            $(""#audioPlayer"")[0].addEventListener(""ended"", function(){
               currentSong++;
                if(currentSong == $(""#playlist li a"").length)
                    currentSong = 0;
                $(""#playlist li"").removeClass(""current-song"");
                $(""#playlist li:eq(""+currentSong+"")"").addClass(""current-song"");
                $(""#audioPlayer"")[0].src = $(""#playlist li a"")[currentSong].");
            WriteLiteral("href;\r\n                $(\"#audioPlayer\")[0].play();\r\n            });\r\n        }\r\n\r\n</script>");
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
