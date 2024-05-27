namespace AMST4_Carousel.MVC.Models
{
    public class Size
    {
        public Guid Id { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string Description { get; set; } 
    }
}
