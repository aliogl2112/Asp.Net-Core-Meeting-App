using System.Net.Mail;

namespace MeetingApp.Models{
public class UserInfo{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
     private string phone;
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    private string email;
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    private bool willAttend;
    public bool WillAttend
    {
        get { return willAttend; }
        set { willAttend = value; }
    }
    
    
}

}