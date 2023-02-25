namespace Dogs.Api.Models
{
    public class Dog
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public Breed Breed { get; set; }
        public string ShortDescription { get; set; }
        public double MaxHeight { get; set; }
        public double MinHeight { get; set; }
        public double MinWeight { get; set; }
        public double MaxWeight { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
    }
}
