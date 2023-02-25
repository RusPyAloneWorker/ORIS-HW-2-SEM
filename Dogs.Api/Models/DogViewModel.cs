namespace Dogs.Api.Models
{
    public class DogViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public Breed Breed { get; set; }
    }
}
