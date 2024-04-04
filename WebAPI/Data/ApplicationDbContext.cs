using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using static System.Net.Mime.MediaTypeNames;

namespace WebbAPI.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Title = "Fullstack Web Developer Course from Scratch",
                    Instructor = "Robert Fox",
                    Price = "$12.50",
                    Duration = "220 hours",
                    SatisfactionRate = "94% (4.2K)",
                    ImageUrl = "https://localhost:7279/images/fullstack.svg",
                    SImage = "https://localhost:7279/images/S.svg", 
                    durationImage = "https://localhost:7279/images/bx-time-five.svg", 
                    satisfactionImage = "https://localhost:7279/images/bx-like.svg",
                    IsBestSeller = true,
                    IsOnSale = false,
                    OriginalPrice = "$12.50",
                    SalePrice = "$12.50" 


                },
                new Course
                {
                    Id = 2,
                    Title = "HTML, CSS, JavaScript Web Developer",
                    Instructor = "Jenny Wilson & Marvin McKinney",
                    Price = "$15.99",
                    Duration = "160 hours",
                    SatisfactionRate = "92% (3.1K)",
                    ImageUrl = "https://localhost:7279/images/htmlcss.svg",
                    SImage = "https://localhost:7279/images/S.svg",
                    durationImage = "https://localhost:7279/images/bx-time-five.svg",
                    satisfactionImage = "https://localhost:7279/images/bx-like.svg",
                    IsOnSale = false,
                    OriginalPrice = "$15.99",
                    SalePrice = "$15.99" 



                },
                new Course
                {
                    Id = 3,
                    Title = "The Complete Front-End Web Development Course",
                    Instructor = "Albert Flores",
                    Price = "$9.99",
                    Duration = "100 hours",
                    SatisfactionRate = "98% (2.7K)",
                    ImageUrl = "https://localhost:7279/images/thecomplete.svg",
                    SImage = "https://localhost:7279/images/S.svg",
                    durationImage = "https://localhost:7279/images/bx-time-five.svg",
                    satisfactionImage = "https://localhost:7279/images/bx-like.svg",
                    IsOnSale = true,
                    OriginalPrice = "$44.99",
                    SalePrice = "$9.99",




                },
                new Course
                {
                    Id = 4,
                    Title = "iOS & Swift - The Complete iOS App Development Course",
                    Instructor = "Marvin McKinney",
                    Price = "$15.99",
                    Duration = "160 hours",
                    SatisfactionRate = "92% (3.1K)",
                    ImageUrl = "https://localhost:7279/images/iosswift.svg",
                    SImage = "https://localhost:7279/images/S.svg",
                    durationImage = "https://localhost:7279/images/bx-time-five.svg",
                    satisfactionImage = "https://localhost:7279/images/bx-like.svg",
                    IsOnSale = false,
                    OriginalPrice = "$15.99", 
                    SalePrice = "$15.99"  





                },
                new Course
                {
                    Id = 5,
                    Title = "Data Science & Machine Learning with Python",
                    Instructor = "Esther Howard",
                    Price = "$11.20",
                    Duration = "160 hours",
                    SatisfactionRate = "92% (3.1K)",
                    ImageUrl = "https://localhost:7279/images/datascience.svg",
                    SImage = "https://localhost:7279/images/S.svg",
                    durationImage = "https://localhost:7279/images/bx-time-five.svg",
                    satisfactionImage = "https://localhost:7279/images/bx-like.svg",
                    IsBestSeller = true,
                    IsOnSale = false,
                    OriginalPrice = "$11.20", 
                    SalePrice = "$12.20"  




                },
                new Course
                {
                    Id = 6,
                    Title = "Creative CSS Drawing Course: Make Art With CSS",
                    Instructor = "Robert Fox",
                    Price = "$10.50",
                    Duration = "220 hours",
                    SatisfactionRate = "94% (4.2K)",
                    ImageUrl = "https://localhost:7279/images/creativecss.svg",
                    SImage = "https://localhost:7279/images/S.svg",
                    durationImage = "https://localhost:7279/images/bx-time-five.svg",
                    satisfactionImage = "https://localhost:7279/images/bx-like.svg",
                    IsOnSale = false,
                    OriginalPrice = "$10.50", 
                    SalePrice = "$10.50"  



                },
                        new Course
                        {
                            Id = 7,
                            Title = "Blender Character Creator v2.0 for Video Games Design",
                            Instructor = "Ralph Edwards",
                            Price = "$18.99",
                            Duration = "160 hours",
                            SatisfactionRate = "92% (3.1K)",
                            ImageUrl = "https://localhost:7279/images/blender.svg",
                            SImage = "https://localhost:7279/images/S.svg",
                            durationImage = "https://localhost:7279/images/bx-time-five.svg",
                            satisfactionImage = "https://localhost:7279/images/bx-like.svg",
                            IsOnSale = false,
                            OriginalPrice = "$18.99", 
                            SalePrice = "$18.99"  





                        },
                new Course
                {
                    Id = 8,
                    Title = "The Ultimate Guide to 2D Mobile Game Development with Unity",
                    Instructor = "Albert Flores",
                    Price = "$12.99",
                    Duration = "100 hours",
                    SatisfactionRate = "98% (2.7K)",
                    ImageUrl = "https://localhost:7279/images/ultimate.svg",
                    SImage = "https://localhost:7279/images/S.svg",
                    durationImage = "https://localhost:7279/images/bx-time-five.svg",
                    satisfactionImage = "https://localhost:7279/images/bx-like.svg",
                    IsOnSale = true,
                    OriginalPrice = "$44.99",
                    SalePrice = "$12.99",



                },
                new Course
                {
                    Id = 9,
                    Title = "Learn JMETER from Scratch on Live Apps-Performance Testing",
                    Instructor = "Jenny Wilson",
                    Price = "$14.50",
                    Duration = "160 hours",
                    SatisfactionRate = "92% (3.1K)",
                    ImageUrl = "https://localhost:7044/images/jmeter.svg",
                    SImage = "https://localhost:7279/images/S.svg",
                    durationImage = "https://localhost:7279/images/bx-time-five.svg",
                    satisfactionImage = "https://localhost:7279/images/bx-like.svg",
                    IsOnSale = false,
                    OriginalPrice = "$14.50", 
                    SalePrice = "$14.50"  




                }
            );
        }
    }
}
