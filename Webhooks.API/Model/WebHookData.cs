using System;
using Newtonsoft.Json;
namespace Webhooks.API.Model
{
    public class WebHookData
    {
        public DateTime When { get; }

        public string Payload { get; }

        public string Type { get; }

        public WebHookData(WebhookType hookType, object data)
        {
            When = DateTime.UtcNow;
            Type = hookType.ToString();
            Payload = JsonConvert.SerializeObject(data);
        }

    }
}
