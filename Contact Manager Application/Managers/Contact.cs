using Contact_Manager_Application.Models;

namespace Contact_Manager_Application.Managers
{
    public class Contact
    {
        private List<User> _users;

        public Contact()
        {
            _users = new List<User>();
        }
        public User FindUserById(int id)
        {
            return _users.FirstOrDefault(u => u.ID == id);
        }
        public void AddUser(User user)
        {
            _users.Add(user);
        }
        public void EditUser(int id, User newUser)
        {
            User existingUser = FindUserById(id);

            if (existingUser != null)
            {
                throw new ArgumentNullException($"user with {id} was not found");
            }
            int index = _users.IndexOf(existingUser);
            _users[index] = newUser;
        }
        public bool RemoveUser(int id)
        {
            User userToRemove = FindUserById(id);

            if (userToRemove != null)
            {
                throw new ArgumentNullException($"user with {id} was not found");
                return false;
            }
            _users.Remove(userToRemove);
            return true;
        }
        // here
        public List<User> SearchUser(string Query)
        {
            return _users.Where(u => u.Search(Query) == 1).ToList();
        }

        public int Count()
        {
            return _users.Count;
        }
        public void ShowAll()
        {
            if (_users.Count == 0)
            {
                Console.WriteLine("No users available.");
                return;
            }

            Console.WriteLine($"Total users: {_users.Count}");

            foreach (var user in _users)
            {
                Console.WriteLine(user.ShowInfo());
            }

            Console.WriteLine(new string('-', 30));
        }

    }
}
