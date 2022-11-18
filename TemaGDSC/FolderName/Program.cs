using TemaGDSC.FolderName;

double medie = 0;

User firstUser = new User("Sergiu","parolaSmecheroasa","sergiuandronic@yahoo.com");
User secondUser = new User("Leo","parolanebuna","hatzculapte@yahoo.com");
User thirdUser = new User("Andrei","theweeknd","andrei27@gmail.com");

Console.WriteLine(firstUser.ToString());
Console.WriteLine(secondUser.ToString());
Console.WriteLine(thirdUser.ToString());

List<User> listOfUsers = new List<User>();
listOfUsers.Add(firstUser);
listOfUsers.Add(secondUser);
listOfUsers.Add(thirdUser);

secondUser.ChangePassword("SaNuItiMaiUitiParola");

WebApp firstApp = new WebApp("Skribbl", 8, new List<User>());
    
firstApp.HttpRequest(firstUser);
firstApp.HttpRequest(secondUser);
firstApp.HttpRequest(thirdUser);

MobileApp secondApp = new MobileApp("Clash of clans", 1000, new List<User>());

medie = secondApp.Rate();
Console.WriteLine($"media e {medie}");





