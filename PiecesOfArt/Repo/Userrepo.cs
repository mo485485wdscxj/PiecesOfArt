using Microsoft.EntityFrameworkCore;
using PiecesOfArt.DTOs;
using PiecesOfArt.Interface;
using PiecesOfArt.Models;
namespace PiecesOfArt.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly ApppDbContext _context;

        public UserRepository(ApppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users
                .Include(u => u.LoyaltyCard)
                .Include(u => u.PiecesOfArt)
                .ThenInclude(p => p.Category)
                .ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _context.Users
                .Include(u => u.LoyaltyCard)
                .Include(u => u.PiecesOfArt)
                .ThenInclude(p => p.Category)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Add(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
        //public DTO_User GetUser(int id)
        //{
        //    var user = _Context.Users.FirstOrDefault(x => x.Id == id);
        //    DTO_User dTO_User = new DTO_User
        //    {
        //        Name = user.Name,
        //        Age = user.Age,
        //        Email = user.Email,
        //        LoyaltyCardId = user.LoyaltyCardId
        //    };
        //    return dTO_User;
        //}