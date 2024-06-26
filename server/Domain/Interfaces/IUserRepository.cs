﻿using Server.Domain.Entities;

namespace Server.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserBySteamIdAsync(ulong steamId);

        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<IEnumerable<User>> GetBannedUsersAsync();

        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
        
    }
}
