namespace TemaGDSC.FolderName;

public class WebApp : Application
{
    public WebApp(string NumeAplicatie, int numberOfUsers, List<User> listOfUsers):base(NumeAplicatie,numberOfUsers,listOfUsers) {}

    public void HttpRequest(User user)
    {
        var case1 = listOfUsers.FirstOrDefault(utilizator => (utilizator.GetUsername()).Equals(user.GetUsername()));
        var case2 = listOfUsers.FirstOrDefault(utilizator => (utilizator.GetMail()).Equals(user.GetUsername()));

        if (case1 is null || case2 is null)
        {
            Console.WriteLine("Nu a fost gasit niciun utilizator cu acest nume sau aceasta adresa de email\n");
            Console.WriteLine("BAD REQUEST");
        }
        else
        {
            Console.WriteLine("OK REQUEST");
        }




    }
}