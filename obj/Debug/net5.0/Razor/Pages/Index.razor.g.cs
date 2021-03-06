#pragma checksum "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e5147aea900a41c70df88b67adeb057f123afd0"
// <auto-generated/>
#pragma warning disable 1591
namespace web_tic_tac_toe_game.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/_Imports.razor"
using web_tic_tac_toe_game;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/_Imports.razor"
using web_tic_tac_toe_game.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h2");
            __builder.AddContent(1, "Current Player is ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
                        game.GetCurrentPlayer()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<web_tic_tac_toe_game.Shared.Board>(4);
            __builder.AddAttribute(5, "CurrentGame", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Game>(
#nullable restore
#line 4 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
                    game

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "UpdateGame", new System.Action(
#nullable restore
#line 4 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
                                      Update

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 5 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
 if(game.won) 
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<br>\r\n  ");
            __builder.OpenElement(8, "h2");
            __builder.AddAttribute(9, "class", "game-over-message");
            __builder.AddContent(10, 
#nullable restore
#line 8 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
                                 game.ShowWinMessage()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n  ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
                    Reset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "New Game");
            __builder.CloseElement();
#nullable restore
#line 10 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
} 
else if(game.IsBoardFull())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<br>\r\n  ");
            __builder.OpenElement(16, "h2");
            __builder.AddAttribute(17, "class", "game-over-message");
            __builder.AddContent(18, 
#nullable restore
#line 14 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
                                 game.ShowGameOver()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n  ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
                    Reset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "New Game");
            __builder.CloseElement();
#nullable restore
#line 16 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "/Users/roberttate/Documents/programming/web-tic-tac-toe-game/Pages/Index.razor"
       
  Game game = new Game(Output.Web);
  bool showWinMessage = false;

  public void HandleMove(int position) {
    game.TryMove(position);
  }

  private void Update() {
    StateHasChanged();
  }

  private void Reset() {
    game.Reset();
    StateHasChanged();
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
