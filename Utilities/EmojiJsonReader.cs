using learningReactWithAspDotNet.Models;
using Newtonsoft.Json;

namespace learningReactWithAspDotNet.Utilities
{
    public class EmojiJsonReader
    {        
        public const String FileLocation = "./emojis.json";

        /* Oh yeah, C# pass by value.  Have to use ref for the reference.  Rewrote to just return a IEnumerable */
        public static IEnumerable<Emoji> LoadJson()
        {
            /* Null checks */
            List<Emoji> appendable = new();
            using StreamReader streamReader = new(FileLocation);
            string jsonData = streamReader.ReadToEnd();            
            /* I just realized the json data from the file is a key/value pair.  Best convert to a Dictionary first. */
            IDictionary<String, String>? dictionary = JsonConvert.DeserializeObject<Dictionary<String, String>>(jsonData);
            if (dictionary != null)
            {
                foreach (KeyValuePair<String, String> entry in dictionary)
                {
                    /* 
                     * IEnumerable append returns a new IEnumerable of the list with the single appended element.  
                     * Not sure if this is the most optimized. 
                     */
                    //list.Append(new Emoji(entry.Key, entry.Value));
                    appendable.Add(item: new Emoji(entry.Key, entry.Value));
                }
            }
            return appendable;
        }
    }
}
