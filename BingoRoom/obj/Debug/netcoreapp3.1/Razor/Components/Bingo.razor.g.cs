#pragma checksum "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3007e3da9521a286f7df8287f4a7d93b00ce4c"
// <auto-generated/>
#pragma warning disable 1591
namespace BingoRoom.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
using Bingo75;

#line default
#line hidden
#nullable disable
    public partial class Bingo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"display-4 w-100 text-center\">Bingo!</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "btn-group w-100 my-4");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                      CallBall

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "btn btn-success");
            __builder.AddContent(7, "Call Ball");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                      RestartGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "btn btn-danger");
            __builder.AddContent(12, "Restart Game");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                      HandCard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn btn-info");
            __builder.AddContent(17, "Hand Card");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenComponent<BingoRoom.Components.CalledBallList>(20);
            __builder.AddAttribute(21, "CalledBalls", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Int32>>(
#nullable restore
#line 11 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                              MyGame.CalledNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 13 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
     foreach (var card in MyGame.Cards)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-md-6");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "bg-secondary p-2 m-2 rounded");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "class", "alert alert-info");
            __builder.AddContent(35, "Remaining: ");
            __builder.AddContent(36, 
#nullable restore
#line 17 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                                                         card.CountSquaresRemaining

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenComponent<BingoRoom.Components.Card>(38);
            __builder.AddAttribute(39, "MyCard", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BingoRoom.IGame.ICard>(
#nullable restore
#line 18 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                               card

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 19 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                 if (card.CountSquaresRemaining <= 1)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                    ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                                        e => CallBingo(card)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "class", "btn btn-success btn-block");
            __builder.AddContent(45, "Call Bingo");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 22 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 25 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 27 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
 if(_winMessage != String.Empty)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "p");
            __builder.AddAttribute(52, "class", "my-4 alert alert-info");
            __builder.AddContent(53, 
#nullable restore
#line 29 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                                  _winMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 30 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "\r\n");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "row");
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-md-12");
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "input-group w-100");
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.AddMarkupContent(65, "<div class=\"input-group-prepend\">\r\n                <span class=\"input-group-text\">Check Number</span>\r\n            </div>\r\n            ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "number");
            __builder.AddAttribute(68, "class", "form-control");
            __builder.AddAttribute(69, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                                                                ClearNumberCheckMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "value", 
#nullable restore
#line 38 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                                                                                                _numberToCheck

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                                                                                                                           e => SetNumberToCheck(e.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "min", "1");
            __builder.AddAttribute(73, "max", "75");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "input-group-append");
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 40 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                 if(MyGame.CalledNumbers.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "                    ");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                                      CheckNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "class", "btn btn-success");
            __builder.AddContent(82, "Check Number");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 43 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "                    ");
            __builder.AddMarkupContent(85, "<button class=\"btn btn-success\" disabled>Check Number</button>\r\n");
#nullable restore
#line 47 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n");
#nullable restore
#line 53 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
 if (_checkMessage != String.Empty)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "    ");
            __builder.OpenElement(92, "p");
            __builder.AddAttribute(93, "class", "alert alert-info");
            __builder.AddContent(94, 
#nullable restore
#line 55 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
                                 _checkMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 56 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\thill\Documents\homework\InsightsNowAssessment\BingoRoom\Components\Bingo.razor"
       
    private Bingo75.Game MyGame;
    private int _numberToCheck = 1;
    private string _checkMessage = String.Empty;
    private string _winMessage = String.Empty;

    private void CallBall()
    {
        try
        {
            MyGame.CallBall();
            foreach (var card in MyGame.Cards)
            {
                card.Check(MyGame.CalledNumbers.Last());
            }
        }
        catch (Exception e)
        {
        }
    }

    private void RestartGame()
    {
        MyGame.Restart();
        _winMessage = String.Empty;
    }

    private void HandCard()
    {
        MyGame.HandCard();
    }

    private void CallBingo(IGame.ICard card)
    {
        var winner = MyGame.CallBingo(card);
        _winMessage = winner ? "You won!" : "Try again...";
    }

    private void CheckNumber()
    {
        _checkMessage = MyGame.CalledNumbers.Contains(_numberToCheck) ? "Number Found!" : "Number Not Found.";
    }

    private void SetNumberToCheck(string number)
    {
        int.TryParse(number, out _numberToCheck);
    }

    private void ClearNumberCheckMessage()
    {
        _checkMessage = String.Empty;
    }

    protected override void OnInitialized()
    {
        MyGame = (Bingo75.Game)Game;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGame Game { get; set; }
    }
}
#pragma warning restore 1591
