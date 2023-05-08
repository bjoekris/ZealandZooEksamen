using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public class UserService : IUserService
    {

        // hack til menu bar
        public static bool iAmAdmin = false;
        public static bool LoggedIn = false;

        private LoggedInUser _user;




        public UserService()
        {
            _user = new LoggedInUser();
        }

        public void SetUserLoggedIn(String name, bool isAdmin)
        {
            _user.Name = name;
            _user.IsAdmin = isAdmin;
            iAmAdmin = isAdmin;
            LoggedIn = true;
        }

        public void UserLoggedOut()
        {
            _user.Name = "";
            _user.IsAdmin = false;
            iAmAdmin = false;
            LoggedIn = false;
        }

        public bool IsLoggedIn
        {
            get
            {
                return !string.IsNullOrEmpty(_user.Name);
            }
        }

        public bool IsUserAdmin => _user.IsAdmin;

        public String UserName => _user.Name;

    }
}
