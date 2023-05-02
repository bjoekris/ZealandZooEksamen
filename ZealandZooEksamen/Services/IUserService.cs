namespace ZealandZooEksamen.Services
{
    public interface IUserService
    {
        bool IsUserAdmin { get; }
        string UserName { get; }
        bool IsLoggedIn { get; }

        void SetUserLoggedIn(string name, bool isAdmin);
        void UserLoggedOut();

    }
}
