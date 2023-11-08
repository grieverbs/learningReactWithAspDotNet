using Microsoft.Extensions.DependencyInjection;
using System.Net;

namespace learningReactWithAspDotNet.Services
{
    public class EmojiService : IEmojiService
    {
        public EmojiService() { }
        public async Task<String> GetEmojiAsync()
        {
            String? results = null;
            HttpClient client = new();
            System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            HttpResponseMessage response = await client.GetAsync("api.github.com/emojis");
            if (response.IsSuccessStatusCode)
            {
                results = await response.Content.ReadAsStringAsync();
            }
            
            return results ?? String.Empty;
        }
    }
}
