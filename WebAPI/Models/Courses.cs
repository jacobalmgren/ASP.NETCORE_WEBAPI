namespace WebAPI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Instructor { get; set; } 
        public string Price { get; set; }      
        public string Duration { get; set; }
        public string SatisfactionRate { get; set; } 
        public string ImageUrl { get; set; } 
        public string SImage { get; set; } 
        public string durationImage { get; set; } 
        public string satisfactionImage { get; set; } 
        public bool IsBestSeller { get; set; } 
        public bool IsOnSale { get; set; } 
        public string OriginalPrice { get; set; } 
        public string SalePrice { get; set; } 
    }
}
