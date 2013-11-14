using System.Collections.Generic;
using System.Linq;

namespace LinqToObjectTest.Solutions
{
    internal class UsersManager : IUsersManager
    {
        public List<User> GetRemovedUsers(List<User> initialUsers, List<User> newUsers)
        {
            return initialUsers.Except(newUsers, new UserIdComparer()).ToList();
        }

        public List<User> GetAddedUsers(List<User> initialUsers, List<User> newUsers)
        {
            return newUsers.Except(initialUsers, new UserIdComparer()).ToList();
        }

        public List<User> GetChangedUsers(List<User> initialUsers, List<User> newUsers)
        {
            return newUsers.Intersect(initialUsers, new UserIdComparer())
                .Except(newUsers.Intersect(initialUsers, new UserFullComparer())).ToList();
        }
    }


    public class UserIdComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(User obj)
        {
            return obj.Id.GetHashCode();
        }
    }

    public class UserFullComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y)
        {
            return x.Password == y.Password || x.Username == y.Username;
        }

        public int GetHashCode(User obj)
        {
            int hash = 17;
            hash = hash*23 + (obj.Username ?? "").GetHashCode();
            hash = hash*23 + (obj.Password ?? "").GetHashCode();
            return hash;
        }
    }
}
