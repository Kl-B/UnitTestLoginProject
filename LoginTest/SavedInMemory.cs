using System.Collections.Generic;
using Logic;


namespace LoginTest
{
    public class SavedInMemory : ISave
    {
        private List<User> _users;

        public List<User> Load()
        {
            if (_users == null)
            {
                _users = new List<User>();
            }

            return _users;
        }

        public void Save(List<User> users)
        {
            _users = users;
        }
    }
}