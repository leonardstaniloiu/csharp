namespace TemaGDSC.FolderName;

public class User
{
    protected string Username;
    protected string Password;
    protected string Email;
    
    public User(string Username, string Password, string Email)
    {
        this.Username = Username;
        this.Password = Password;
        this.Email = Email;
    }

    public string GetUsername()
    {
        return Username;
    }

    public string ChangePassword(string newPassword)
    {
        return newPassword;
    }

    public string returnNewPassword()
    {
        return Password;
    }
    
    public string GetMail()
    {
        return Email;
    }

    public override string ToString()
    {
        return "Username: " + Username + "\n Email: " + Email;
    }
    
        
        
}