// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace P5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using P5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using P5.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using P5.Game;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\git\AP99002\Project\P5\P5\_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\git\AP99002\Project\P5\P5\Pages\Index.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\git\AP99002\Project\P5\P5\Pages\Index.razor"
using Blazor.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "c:\git\AP99002\Project\P5\P5\Pages\Index.razor"
 
    BECanvasComponent _canvas;
    static ElementReference _spritesheet;
    static ElementReference _spritesheet2;
    public ElementReference[] images= {_spritesheet,_spritesheet2};
    
    GameContext _game;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JsRuntime.InvokeAsync<object>("initGame", DotNetObjectReference.Create(this));

            _game = await CatWalkGame.Create(_canvas, _spritesheet);

            // this will make sure that the viewport is correctly initialized
            await JsRuntime.InvokeAsync<object>("gameWindowResize", DotNetObjectReference.Create(this));
        }
    }

    [JSInvokable]
    public async ValueTask GameLoop(float timeStamp)
    {
        if (null == _game) return;
        await _game.Step(timeStamp);
        StateHasChanged();
    }

    [JSInvokable]
    public async ValueTask OnResize(int screenWidth, int screenHeight)
    {
        if (null == _game) return;
        _game.Display.Size = new Size(screenWidth, screenHeight);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
