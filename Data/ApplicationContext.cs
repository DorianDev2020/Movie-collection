﻿using Microsoft.EntityFrameworkCore;
using WebAPISample.Models;

namespace WebAPISample.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>()
                .HasData(
                    new Movie
                    {
                        MovieId = 1,
                        Title = "The Departed",
                        Genre = "Drama",
                        Director = "Martin Scorsese",
                        LeadRole = "Leonardo DiCaprio",
                        SupportingRole = "Jack Nicholson",
                    },
                    new Movie
                    {
                        MovieId = 2,
                        Title = "The Dark Knight",
                        Genre = "Drama",
                        Director = "Christopher Nolan",
                        LeadRole = "Christian Bale",
                        SupportingRole = "Heath Ledger",
                    },
                    new Models.Movie
                    {
                        MovieId = 3,
                        Title = "Inception",
                        Genre = "Drama",
                        Director = "Christopher Nolan",
                        LeadRole = "Leonardo DiCaprio",
                    },
                    new Models.Movie
                    {
                        MovieId = 4,
                        Title = "Pineapple Express",
                        Genre = "Comedy",
                        Director = "David Gordon Green",
                        LeadRole = "Seth Rogan",
                        SupportingRole = "James Franco",
                    },
                    new Models.Movie
                    {
                        MovieId = 5,
                        Title = "Die Hard",
                        Genre = "Action",
                        Director = "John McTiernan",
                        LeadRole = "Bruce Wilice",
                    }
                        );
        }

        public DbSet<Movie> Movies { get; set; }
    }
}

