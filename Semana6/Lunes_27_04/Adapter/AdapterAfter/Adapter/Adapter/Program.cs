using Adapter;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(new JsonConverter().GetJson());
        Console.WriteLine("----Prueba solo con Json Convert-----");
        var jsonConvert = new JsonConverter(ProductDataProvider.GetProducts());
        jsonConvert.ConverToJson();

        var xmlConverter = new XMLConverter();
        Console.WriteLine("Adapter Before");
        Console.WriteLine(xmlConverter.GetXml());
        Console.WriteLine("-------------------");
        Console.WriteLine("Adapter After");
        Console.WriteLine("Converting XML To Json");
        var adapter = new XmlToJsonAdapter(xmlConverter);
        adapter.ConvertXmlToJson();
        Console.ReadLine();
    }
}