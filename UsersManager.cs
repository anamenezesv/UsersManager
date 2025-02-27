namespace UsersManager
{
    public class UsersManager
    {
        private List<User> users = new List<User>();

        public void AddUser(User newUser)
        {
            users.Add(newUser);
        }

        public void UpdateUser(User user) 
        {
            var userToUpdate = users.FirstOrDefault(u => u.Id == user.Id);
            if (userToUpdate != null)
                userToUpdate.Name = user.Name;
            else
                throw new Exception();
        }

        public void DeleteUser(User user)
        {
            users.Remove(user);
        }

        public List<User> GetUsers() 
        {
            return users;
        }
    }

    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
