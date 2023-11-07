namespace learningReactWithAspDotNet.Models
{
    public class Emoji
    {
        public Emoji() { }
        public Emoji(string name, string imageUrl)
        {
            this.Name = name;
            this.ImageUrl = imageUrl;
        }

        public String? Name { get; set; }
        public String? ImageUrl { get; set; }
    }
}
