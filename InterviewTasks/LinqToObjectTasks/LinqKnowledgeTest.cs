using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace LinqToObjectTest
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public User(string username, string password)
        {
            Id = Guid.NewGuid();
            Username = username;
            Password = password;
        }

        public User(User user)
        {
            Id = user.Id;
            Username = user.Username;
            Password = user.Password;
        }
    }

    interface IUsersManager
    {
        List<User> GetChangedUsers(List<User> initialUsers, List<User> newUsers);
        List<User> GetRemovedUsers(List<User> initialUsers, List<User> newUsers);
        List<User> GetAddedUsers  (List<User> initialUsers, List<User> newUsers);
    }

    //Implement methods, using Collections extension methods or Linq to Object (up to you). 
    public class UsersManager : IUsersManager
    {
        public List<User> GetChangedUsers(List<User> initialUsers, List<User> newUsers)
        {
            throw new NotImplementedException();
        }

        public List<User> GetRemovedUsers(List<User> initialUsers, List<User> newUsers)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAddedUsers(List<User> initialUsers, List<User> newUsers)
        {
            throw new NotImplementedException();
        }
    }


    [TestFixture]
    public class UsersManagerTest
    {
        private IUsersManager UsersManager;

        public class UsersFactory
        {
            private static readonly User U1 = new User("user1", "pass1");
            private static readonly User U2 = new User("user2", "pass2");
            private static readonly User U3 = new User("user3", "pass3");
            private static readonly User U4 = new User("user4", "pass4");
            private static readonly User U5 = new User("user5", "pass5");
            
            private static readonly User U3Change = new User(U3);
            private static readonly User U4Change = new User(U4);


            public static IEnumerable TestCasesRemove
            {
                get
                {
                    yield return new TestCaseData(new List<User> { U1, U2, U3 }, new List<User> { U3, U4, U5 }).Returns(new List<User> { U1, U2 })
                        .SetDescription("We have removed users U1 and U2, test ensures that we getting them to remove from storage");
                    yield return new TestCaseData(new List<User> { U1, U2, U3 }, new List<User> { U4, U5 }).Returns(new List<User> { U1, U2, U3 })
                        .SetDescription("We have removed users U1, U2 and U3, test ensures that we getting them to remove from storage");
                }
            }

            public static IEnumerable TestCasesAdd
            {
                get
                {
                    yield return new TestCaseData(new List<User>{U1, U2, U3}, new List<User>{U3, U4, U5}).Returns(new List<User>{U4, U5})
                        .SetDescription("We have added users U4 and U5, test ensures that we getting these users to add them into storage");
                }
            }

            public static IEnumerable TestCasesChanged
            {
                get
                {
                    U3Change.Password = "passNew3";
                    U4Change.Password = "passNew4";
                    yield return new TestCaseData(new List<User> { U1, U2, U3 }, new List<User> { U2, U3Change, U4, U5 }).Returns(new List<User> { U3Change })
                        .SetDescription("We have changed user U3, test ensures that we getting it to change in storage");
                    yield return new TestCaseData(new List<User> { U1, U2, U3, U4 }, new List<User> { U2, U3Change, U4Change, U5 }).Returns(new List<User> { U3Change, U4Change })
                        .SetDescription("We have changed users U3 and U4, test ensures that we getting it to change in storage");
                }
            }
        }

        [TestFixtureSetUp]
        public void Setup()
        {
            UsersManager = new UsersManager();
        }

        [Test, TestCaseSource(typeof(UsersFactory), "TestCasesRemove")]
        public IEnumerable<User> GetRemovedUsers_Test(List<User> initialUsers, List<User> newUsers)
        {
            return UsersManager.GetRemovedUsers(initialUsers, newUsers);
        }

        [Test, TestCaseSource(typeof(UsersFactory), "TestCasesAdd")]
        public IEnumerable<User> CheckingAdd(List<User> initialUsers, List<User> newUsers)
        {
            return UsersManager.GetAddedUsers(initialUsers, newUsers);
        }

        [Test, TestCaseSource(typeof(UsersFactory), "TestCasesChanged")]
        public IEnumerable<User> CheckingChange(List<User> initialUsers, List<User> newUsers)
        {
            return UsersManager.GetChangedUsers(initialUsers, newUsers);
        }

    }
}