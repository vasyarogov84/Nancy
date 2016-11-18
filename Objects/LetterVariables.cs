namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;
    private string _sender;
    private int _date;

    public string GetRecipient()
    {
      return _recipient;
    }

    public string GetSender()
  {
    return _sender;
  }

  public int GetDate()
  {
    return  _date;
  }

  public void SetSender(string newSender)
  {
    _sender = newSender;
  }



    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public void SetDate( int newDate)
    {
      _date =  newDate;
    }
  }
}
