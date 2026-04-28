using Newtonsoft.Json;

namespace Adapter
{
    public class JsonConverter
    {
        private IEnumerable<Product> _listProducts;

        public JsonConverter(IEnumerable<Product> listProducts)
        {
            _listProducts = listProducts;
        }
        public void ConverToJson()
        {
            var result = JsonConvert.SerializeObject(_listProducts, Formatting.Indented);
            Console.WriteLine(result);
        }
    }
}
