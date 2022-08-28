using Microsoft.EntityFrameworkCore;
using RazorPagesUsers.Data;
using RazorPagesUsers.UserModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesUsers.Services
{
    public interface IUserService
    {
        Task<List<User>> GetPaginatedResult(int currentPage, int pageSize);
        Task<int> GetCount();
    }

    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetPaginatedResult(int currentPage, int pageSize)
        {
            var data = await GetData();
            return data.OrderBy(d => d.Id).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public async Task<int> GetCount()
        {
            var data = await GetData();
            return data.Count;
        }

        private async Task<List<User>> GetData()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }   
    }
}
