namespace TemaGDSC.FolderName;

public class MobileApp : Application
{
    public MobileApp(string NumeAplicatie, int numberOfUsers, List<User> listOfUsers):base(NumeAplicatie,numberOfUsers,listOfUsers) {}
    

    private double rating;
    private double currentRating = 0;
    private double sumOfRatings = 0;

    public double Rate()
    {
        foreach (var utilizatori in listOfUsers)
        {
            Console.WriteLine("Dati un rating: ");
            
            currentRating = Convert.ToDouble(Console.ReadLine());
            sumOfRatings += currentRating;

        }

        return sumOfRatings / numberOfUsers;
    }
}