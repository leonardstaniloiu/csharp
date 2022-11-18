namespace TemaGDSC.FolderName;

public abstract class Application
{
    protected string NumeAplicatie;
    protected int numberOfUsers;
    protected int contor;
    protected List<User> listOfUsers = new List<User>();


    public Application(string NumeAplicatie, int numberOfUsers, List<User>listOfUsers)
    {
        this.NumeAplicatie = NumeAplicatie;
        this.numberOfUsers = numberOfUsers;
        this.listOfUsers = listOfUsers;
        
    }

    public string GetNameOfApp()
    {
        return NumeAplicatie;
    }

    public int GetNumberOfUsers()
    {
        return contor;
    }
    
    public override string ToString()
    {
        return "Numele aplicatiei: " + NumeAplicatie + "\nAvand un numar de utilizatori de: " + numberOfUsers;
    }
    
}