using Colo_Shop.Models;

namespace Colo_Shop.IServices;

public interface IUserServices
{
    public bool CreateNewUsers(User User);
    public bool UpdateUser(User User);
    public bool DeleteUser(Guid id);
    public User GetUserById(Guid id);
    public IEnumerable<User> GetAllUsers(Guid? currentUserId = null);
    public List<User> GetUserByUserName(string name);
    public List<User> GetAllUsers();
}