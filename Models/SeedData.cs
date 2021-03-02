using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_IS413_Assignment7.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AmazonBooksDBContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AmazonBooksDBContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    //Book Ids are not defined here. They are auto generated values.
                    //Middle name/initial is not required, so it can be defined or empty.
                    new Book //Book #1
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        NumOfPages = 1488
                    },
                    new Book //Book 2
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        NumOfPages = 944
                    },
                    new Book //Book 3
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        NumOfPages = 832
                    },
                    new Book //Book 4
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        NumOfPages = 864
                    },
                    new Book //Book 5
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        NumOfPages = 528
                    },
                    new Book //Book 6
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        NumOfPages = 288
                    },
                    new Book //Book 7
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        NumOfPages = 304
                    },
                    new Book //Book 8
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        NumOfPages = 240
                    },
                    new Book //Book 9
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        NumOfPages = 400
                    },
                    new Book //Book 10
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        NumOfPages = 642
                    },
                    new Book //Book 11
                    {
                        Title = "Battlefront II: Inferno Squad",
                        AuthorFirst = "Christie",
                        AuthorLast = "Golden",
                        Publisher = "Del Rey",
                        ISBN = "978-1524796808",
                        Classification = "Fiction",
                        Category = "Action",
                        Price = 17.12,
                        NumOfPages = 336
                    },
                    new Book //Book 12
                    {
                        Title = "How to Win Friends & Influence People",
                        AuthorFirst = "Dale",
                        AuthorLast = "Carnegie",
                        Publisher = "Pocket Books",
                        ISBN = "978-0671027032",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 11.85,
                        NumOfPages = 288
                    },
                    new Book //Book 13
                    {
                        Title = "Percy Jackson and the Olympians: The Lightning Thief",
                        AuthorFirst = "Rick",
                        AuthorLast = "Riordan",
                        Publisher = "Disney-Hyperion",
                        ISBN = "978-0786838653",
                        Classification = "Fiction",
                        Category = "Action",
                        Price = 5.98,
                        NumOfPages = 416
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
