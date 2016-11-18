using Nancy;
using FriendLetter.Objects;
namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {


      Get["/"] = _ => {
    LetterVariables myLetterVariables = new LetterVariables();
    myLetterVariables.SetRecipient("Eric");
    myLetterVariables.SetSender("John");
    myLetterVariables.SetDate(2016);
    return View["hello.cshtml", myLetterVariables];
      };
      Get["/favorite_photos"] = _ => View["favorite_photos.cshtml"];

      Get["/form"] = _ => {
        return View["form.cshtml"];
      };

      Get["/greeting_card"] = _ => {
      LetterVariables myLetterVariables = new LetterVariables();
      myLetterVariables.SetRecipient(Request.Query["recipient"]);
      myLetterVariables.SetSender(Request.Query["sender"]);
      myLetterVariables.SetDate(Request.Query["date"]);
      return View["hello.cshtml", myLetterVariables];
    };
      }
      }
    }
