namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;
    private string _sender;

    public string GetRecipient()
    {
      return _recipient;
    }

    public string GetSender()
  {
    return _sender;
  }

  public void SetSender(string newSender)
  {
    _sender = newSender;
  }



    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }
  }
}
