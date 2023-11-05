using learningReactWithAspDotNet.Models;
using Newtonsoft.Json;

namespace learningReactWithAspDotNet.Utilities
{
    public class EmojiJsonReader
    {
        // TODO: This is not the right location.  Need to figure out the relative path .NET uses.
        public const String FileLocation = "emoji.json";
        public static void LoadJson(IEnumerable<Emoji>? list)
        {
            using StreamReader streamReader = new(FileLocation);
            string jsonData = streamReader.ReadToEnd();
            list = JsonConvert.DeserializeObject<IEnumerable<Emoji>>(jsonData);
        }
    }
}
