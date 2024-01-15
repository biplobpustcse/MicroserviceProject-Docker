using UserMicroservice.Data;
using UserMicroservice.Model;
using UserMicroservice.Services.Interface;

namespace UserMicroservice.Services
{
    public class UserService:IUserService
    {
        private readonly DbContextClass _dbContext;

        public UserService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> AddUser(User product)
        {
            var result = _dbContext.Users.Add(product);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> DeleteUser(int Id)
        {
            var filteredData = _dbContext.Users.Where(x => x.UserId == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            await _dbContext.SaveChangesAsync();
            return result != null ? true : false;
        }

        public async Task<User> GetUserById(int id)
        {
            return _dbContext.Users.Where(x => x.UserId == id).FirstOrDefault();
        }

        public async Task<IEnumerable<User>> GetUserList()
        {
            return _dbContext.Users.ToList();
        }

        public async Task<User> UpdateUser(User product)
        {
            var result = _dbContext.Users.Update(product);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
