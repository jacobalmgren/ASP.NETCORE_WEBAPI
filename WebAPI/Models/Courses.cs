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




    }
}
