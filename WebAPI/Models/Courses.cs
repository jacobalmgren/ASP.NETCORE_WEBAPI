namespace WebAPI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Instructor { get; set; } // Nytt fält
        public string Price { get; set; }      // Nytt fält
        public string Duration { get; set; }   // Nytt fält
        public string SatisfactionRate { get; set; } // Nytt fält
        public string ImageUrl { get; set; } // Nytt fält för bildlänk
        public string SImage { get; set; } // Add this property
        public string durationImage { get; set; } // Add this property
        public string satisfactionImage { get; set; } // Add this property
        public bool IsBestSeller { get; set; } // Add this property
        public bool IsOnSale { get; set; } // Indicates if the course is on sale
        public string OriginalPrice { get; set; } // The original price before the sale
        public string SalePrice { get; set; } // The sale price
    }
}
