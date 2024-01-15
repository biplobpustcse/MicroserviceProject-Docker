using UserMicroservice.Model;

namespace UserMicroservice.Services.Interface
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetUserList();
        public Task<User> GetUserById(int id);
        public Task<User> AddUser(User product);
        public Task<User> UpdateUser(User product);
        public Task<bool> DeleteUser(int Id);
    }
}
