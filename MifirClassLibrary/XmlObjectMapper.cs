using MifirClassLibrary;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace MifirVerificationClassLibrary
{
    [Serializable, XmlRoot("XmlObjectMapper")]
    public class XmlObjectMapper
    {
        private const string? _equal = "Equality";
        private const string? _notEqual = "Not";
        private const string? _regex = "RegX";
        private const string? _notRegex = "Not RegX";
        private const string? _null = "NULL";
        private const string? _notNull = "Not NULL";
        private const string? _inInterval = "In Interval";
        private const string? _notInInterval= "Not In Interval";

        //elements that will be mapped from the XML File
        [XmlElement(ElementName = "FirstOperand")]
        public string? FirstOperandFromXml{ get; set; }

        [XmlElement(ElementName = "FistOperandValue")]
        public string? FistOperandValueFromXml { get; set; }

        [XmlElement(ElementName = "SecondOperand")]
        public string? SecondOperandFromXml { get; set; }

        [XmlElement(ElementName = "SecondOperandValue")]
        public string? SecondOperandValueFromXml { get; set; }

        [XmlElement(ElementName = "FirstOperator")]
        public string? FirstOperatorFromXml { get; set; }

        [XmlElement(ElementName = "FirstTypeOperation")]
        public string? FirstTypeOperationFromXml { get; set; }

        [XmlElement(ElementName = "SecondTypeOperation")]
        public string? SecondTypeOperationFromXml { get; set; }

        [XmlElement(ElementName = "ErrorMessage")]
        public string? ErrorMessageFromXml { get; set; }


        //private Class Attributes that will be used for verification
        private string? FirstOperandValueFromCsv
        {
            get => mifirObject.GetType().GetProperty(FirstOperandFromXml.Trim()).GetValue(mifirObject, null).ToString();
        }
        private string? SecondOperandValueFromCsv
        {
            get => mifirObject.GetType().GetProperty(SecondOperandFromXml.Trim()).GetValue(mifirObject, null).ToString();
        }

        public bool FirstOperationResult { get => TypeOperators(FirstOperandValueFromCsv, FistOperandValueFromXml, FirstTypeOperationFromXml); }
        public bool SecondOperationResult { get => TypeOperators(SecondOperandValueFromCsv, SecondOperandValueFromXml, SecondTypeOperationFromXml);}

    //the mifir object used for the validation
    public MifirClassLibrary.MiFirProject? mifirObject;

        //default Consutructor
        public XmlObjectMapper() { }

        private bool TypeOperators(string? CsvData, string? XmlData, string? Operation)
        {
            switch (Operation)
            {
                case _equal:
                    return CsvData.Equals(XmlData);
                case _notEqual:
                    return !CsvData.Equals(XmlData);
                case _regex:
                    return Regex.Match(CsvData, XmlData).Success;
                case _notRegex:
                    return !Regex.Match(CsvData, XmlData).Success;
                case _null:
                    return String.IsNullOrEmpty(CsvData.ToString());
                case _notNull:
                    return !String.IsNullOrEmpty(CsvData.ToString());
                case _inInterval:
                    return XmlData.Split(";").Contains(CsvData);
                case _notInInterval:
                    return !XmlData.Split(";").Contains(CsvData);
            }
            return false;
        }
    }
}
