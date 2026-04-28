using System.Xml.Linq;

namespace Adapter
{
    public class XMLConverter
    {
        public XDocument GetXml()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Products");

            var xAtributos = ProductDataProvider.GetProducts()
                .Select(p => new XElement("Products",
                new XAttribute("Name", p.Name),
                new XAttribute("Price", p.Price)
                ));

            xElement.Add(xAtributos);
            xDocument.Add(xElement);
            return xDocument;
        }
    }
}
