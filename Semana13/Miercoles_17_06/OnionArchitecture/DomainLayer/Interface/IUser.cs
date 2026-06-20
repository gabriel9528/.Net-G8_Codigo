using DomainLayer.Dtos;
using DomainLayer.Models;

namespace DomainLayer.Interface
{
    public interface IUser
    {
        List<User> GetListUsers();
        User GetUserById(int id);
        string AddUser(UserDto userDto);
        string UpdateUser(UserDto userDto);
        string DeleteUser(int id);
    }
}
