
using MifirVerificationClassLibrary;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MifirClassLibrary;

public class MifirVerification
{
    /// <summary>
    /// It takes an object of type T and returns a string representation of the object
    /// </summary>
    /// <returns>
    /// A string
    /// </returns>
    public static string SerializeObject<T>(T toSerialize)
    {
        var textWriter = new StringWriter();
        try
        {
            if (toSerialize == null) return textWriter.ToString();
            var xmlSerializer = new XmlSerializer(toSerialize.GetType());
            xmlSerializer.Serialize(textWriter, toSerialize);

            return textWriter.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    /// <summary>
    /// Verification method to verify the 
    /// </summary>
    /// <param name="doc"></param>
    /// <param name="xsdSchema"></param>
    /// <returns> vide</returns>
    public static string XmlSchemaVerification(string doc, string xsdSchema)
    {
        ValidationEventHandler? eventHandler = null;

        var xmlDocument = new XmlDocument
        {
            Schemas = new XmlSchemaSet()
        };
        xmlDocument.Schemas.Add(null, XmlReader.Create(new StringReader(xsdSchema)));
        TextReader textReader = new StringReader(doc);
        xmlDocument.Load(textReader);
        eventHandler += new ValidationEventHandler(ValidationEventHandler!);
        xmlDocument.Validate(eventHandler);

        return _verificationResult;
    }

    public static string CheckDependency(MiFirProject mifir)
    {
        XmlSerializer deserializer = new(typeof(List<XmlObjectMapper>), new XmlRootAttribute("XmlObjectMapper"));
        TextReader textReader = new StreamReader(@Resource.FieldsDependencyConstraintFile);

        var ListXmlObject = (List<XmlObjectMapper>)deserializer.Deserialize(textReader);
        textReader.Close();

        foreach (var element in ListXmlObject)
        {
            element.mifirObject = mifir;
            if (element.FirstOperationResult && element.SecondOperationResult)
            {
                _verificationResult += $"Line: {_counter} : Error: {element.ErrorMessageFromXml} \r\n \r\n ";
            }
        }

        return _verificationResult;
    }

    private static string _verificationResult = "";
    public static int _counter = 1;

    private static void ValidationEventHandler(object sender, ValidationEventArgs e)
    {
        if (e.Severity == XmlSeverityType.Error)
        {
            _verificationResult += $"Line: {_counter} : Error: {e.Message} \r\n \r\n ";
        }
    }
}