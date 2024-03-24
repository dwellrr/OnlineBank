using BankData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankData;

public class BankDbContext : DbContext
{
    public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
    {
		AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
	}

    public DbSet<Tag> Tags { get; set; }
    public DbSet<Balance> Balances { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        modelBuilder.Entity<Tag>().HasData(
            new Tag { Id = 1, Name = "MainSalary" },
            new Tag { Id = 2, Name = "Food" },
            new Tag { Id = 3, Name = "PartTimeJob" },
            new Tag { Id = 4, Name = "Rental" }
            );

        modelBuilder.Entity<Balance>().HasData(
            new Balance { Id = 1, Amount = 100m });
	}
}
