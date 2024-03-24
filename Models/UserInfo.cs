using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace MeetingApp.Models{
public class UserInfo{
    private int id;
    [Required]
    public int ID
    {
        get { return id; }
        set { id = value; }
    }
    private string? name;
    [Required(ErrorMessage ="İsim alanı boş bırakılamaz.")]
    public string? Name
    {
        get { return name; }
        set { name = value; }
    }
    private string? phone;
    [Required(ErrorMessage ="Telefon alanı boş bırakılamaz.")]
    [StringLength(10)]
    [RegularExpression(@"^(?!0)\d{10}$", ErrorMessage = "Geçerli bir telefon numarası girin.")]
    public string? Phone
{
    get { return phone; }
    set { phone = value; }
}
    private string? email;
    [Required(ErrorMessage ="Email alanı boş bırakılamaz.")]
    [EmailAddress(ErrorMessage ="Lütfen geçerli bir mail adresi girin. (Örnek: example@xyz.com)")]
    public string? Email
    {
        get { return email; }
        set { email = value; }
    }
    private bool? willAttend;
    [Required(ErrorMessage ="Katılım durumu alanı boş bırakılamaz.")]
    public bool? WillAttend
    {
        get { return willAttend; }
        set { willAttend = value; }
    }
    
    
}

}