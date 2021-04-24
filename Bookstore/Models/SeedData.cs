using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDb context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDb>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                //seed data from table
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        Isbn = "978-0451419439",
                        Class = "Fiction, Classic",
                        Price = 9.95,
                        PageCount = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        Isbn = "978-0743270755",
                        Class = "Non-Fiction, Biography",
                        Price = 14.58,
                        PageCount = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        Isbn = "978-0553384611",
                        Class = "Non-Fiction, Biography",
                        Price = 21.54,
                        PageCount = 832
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White ",
                        Publisher = "Random House",
                        Isbn = "978-0812981254",
                        Class = "Non-Fiction, Biography",
                        Price = 11.61,
                        PageCount = 864
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        Isbn = "978-0812974492",
                        Class = "Non-Fiction, Historical",
                        Price = 13.33,
                        PageCount = 528
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        Isbn = "978-0804171281",
                        Class = "Fiction, Historical Fiction",
                        Price = 15.95,
                        PageCount = 288
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        Isbn = "978-1455586691",
                        Class = "Non-Fiction, Self-Help",
                        Price = 14.99,
                        PageCount = 304
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        Isbn = "978-1455523023",
                        Class = "Non-Fiction, Self-Help",
                        Price = 21.66,
                        PageCount = 240
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        Isbn = "978-1591847984",
                        Class = "Non-Fiction, Business",
                        Price = 29.16,
                        PageCount = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        Publisher = "Bantam",
                        Isbn = "978-0553393613",
                        Class = "Fiction, Thrillers",
                        Price = 15.03,
                        PageCount = 642
                    },

                    new Book
                    {
                        Title = "The Princess Bride",
                        Author = "William Goldman",
                        Publisher = "HMH",
                        Isbn = "978-1328948854",
                        Class = "Fiction, Fantasy",
                        Price = 17.96,
                        PageCount = 392
                    },

                    new Book
                    {
                        Title = "The Hunger Games",
                        Author = "Suzanne Collins",
                        Publisher = "Scholastic Press",
                        Isbn = "978-0439023528",
                        Class = "Fiction, YA",
                        Price = 9.11,
                        PageCount = 374
                    },

                    new Book
                    {
                        Title = "Catching Fire",
                        Author = "Suzanne Collins",
                        Publisher = "Scholastic Press",
                        Isbn = "978-0545586177",
                        Class = "Fiction, YA",
                        Price = 7.98,
                        PageCount = 391
                    }

                );

                context.SaveChanges();
            }
        }
    }
}

