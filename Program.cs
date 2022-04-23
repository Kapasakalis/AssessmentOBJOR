using Assessement.Models;
using Assessement.Service;
using System.Collections.Generic;
using ClosedXML.Excel;


public class Program
{
    static void Main(string[] args)
    {
        BasicService basicService = new BasicService();
        List<User> UserList = new List<User>();
        basicService.ImportExcel(UserList, "D:\\Object Orienteed Programming\\Assessement\\UserFile.xlsx", "Clients");

        Game dota = new Game("Dota", 2);
        Game lol = new Game("League of Legends", 100);
        Game lineage = new Game("Lineage", 68);
        List<Game> games = new List<Game>() { dota, lol , lineage };

        foreach (Game game in games)
        {
           
        }


        
        Console.WriteLine("Welcome tho the GameService. You will now be asked to Log In Provide your Username");
        
        basicService.Login(UserList);
        basicService.Export<User>(UserList, "D:\\Object Orienteed Programming\\Assessement\\UserFile.xlsx", "Clients");
        

        User SuperAdmin = new User("kapazzz", "alexandros", "Kapasakalis","kapazzz@hotmail.com","Greece", Assessement.Enum.Role.Admin);
        UserList.Add(SuperAdmin);
        
    }

 
}