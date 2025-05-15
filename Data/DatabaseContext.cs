using Microsoft.EntityFrameworkCore;
using Internship_Test.Models;
using Internship_Test.Data;

namespace Internship_Test.Data 
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){}
        public DbSet<Favourite>Favourites {get; set;}
        public DbSet<Order>Orders {get; set;}
        public DbSet<Payment>Payments {get; set;}
        public DbSet<Account>Accounts {get; set;}
        public DbSet<Address>Addresses {get; set;}
        public DbSet<Reward>Rewards {get; set;}
        public DbSet<Refund>Refunds {get; set;}
        public DbSet<Wallet>Wallets {get; set;}
        public DbSet <App_Update> App_Updates {get; set;}  
        public DbSet <Benefit> Benefits {get; set;}
        public DbSet<Admin> Admins {get; set;}
        public DbSet<User>Users {get; set;}
        public DbSet<Menu_Items> Menu_Items {get ; set;}
    }
}