using DomainLayer.Dtos;
using DomainLayer.Interface;
using DomainLayer.Models;
using InfraestructureLayer.DataAccessLayer;

namespace ServiceLayer.Implementations
{
    public class UserService : IUser
    {
        private readonly AppDbContext _dbContext;
        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string AddUser(UserDto userDto)
        {
            var newUser = new User();
            try
            {
                newUser.Name = userDto.Name;
                newUser.Phone = userDto.Phone;
                newUser.Email = userDto.Email;
                newUser.Address = userDto.Address;
                newUser.CreatedDate = DateTime.UtcNow;

                _dbContext.Users.Add(newUser);
                _dbContext.SaveChanges();

                return "Usuario " + newUser.Name + " registrado con exito" ;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdateUser(UserDto userDto)
        {
            try
            {
                var userToUpdate = _dbContext.Users.Find(userDto.Id);
                if (userToUpdate != null)
                {
                    userToUpdate.Name = userDto.Name;
                    userToUpdate.Phone = userDto.Phone;
                    userToUpdate.Email = userDto.Email;
                    userToUpdate.Address = userDto.Address;
                    userToUpdate.UpdatedDate = DateTime.UtcNow;

                    _dbContext.SaveChanges();

                    return "Usuario " + userToUpdate.Name + " actualizado con exito";
                }

                return "Usuario no encontrado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteUser(int id)
        {
            try
            {
                var userToDelete = _dbContext.Users.Find(id);
                if (userToDelete != null)
                {
                    userToDelete.IsDeleted = true;

                    _dbContext.SaveChanges();
                    return "Usuario " + userToDelete.Name + " eliminado con exito";
                }
                return "Usuario no encontrado";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<User> GetListUsers()
        {
            return _dbContext.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _dbContext.Users.Where(x=>x.Id== id).FirstOrDefault() ?? null;
        }

        
    }
}
