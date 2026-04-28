namespace Adapter
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private readonly XMLConverter _xmlConverter;
        public XmlToJsonAdapter(XMLConverter converter)
        {
            _xmlConverter = converter;
        }

        public void ConvertXmlToJson()
        {
            var products = _xmlConverter.GetXml()
                .Root.Elements("Products")
                .Select(p => new Product
                {
                    Name = p.Attribute("Name").Value,
                    Price = Convert.ToInt32(p.Attribute("Price").Value)
                });
            new JsonConverter(products).ConverToJson();
        }
    }
}
