using Newtonsoft.Json;

namespace Adapter
{
    public class JsonConverter
    {
        public string GetJson()
        {
            return JsonConvert.SerializeObject(ProductDataProvider.GetProducts(), Formatting.Indented);
        }
    }
}
