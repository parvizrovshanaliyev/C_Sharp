using System.Collections.Generic;
using WindowsFormsApp.TransferDataBetweenForms3.Models;

namespace WindowsFormsApp.TransferDataBetweenForms3
{
    internal class VirtualDatabase
    {
        public static List<User> userList = new List<User>();


        static VirtualDatabase()
        {
            userList.AddRange(new List<User>
            {
                new User
                {
                    Id=1,
                    Name="User1",
                    Surname="User1",
                    Username="User1",
                    Password="1234",
                    Desc="1 nomreli istifadeci"
                },
                new User
                {
                    Id=2,
                    Name="User2",
                    Surname="User2",
                    Username="User2",
                    Password="12345",
                    Desc="2 nomreli istifadeci"
                },
                new User
                {
                    Id=3,
                    Name="User3",
                    Surname="User3",
                    Username="User3",
                    Password="123456",
                    Desc="2 nomreli istifadeci"
                },
            });
        }

    }
}