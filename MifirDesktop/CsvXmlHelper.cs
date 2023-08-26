using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MifirDesktop
{
    /* A class that contains methods that are used to read from a CSV file, save the data to a list,
    save the list to an XML file, read from an XML file, read from a remote XML file, read from an
    XML file and validate it against an XSD schema. */

    public static class CsvXmlHelper
    {
        private static string _verificationResult = "";
        private static int _counter;
        public static int _length = 0;
        public static BackgroundWorker workerBG;

        /// <summary>
        /// It reads from a CSV file and adds the data to a list
        /// </summary>
        /// <returns>
        /// A list of objects of type Sample.
        /// </returns>
        public static MiFirProject SaveToListFromCsv(string fileName, BackgroundWorker worker)
        {
          
                worker.WorkerReportsProgress = true;
                var mifirDataFromCsv = new MiFirProject
                {
                    MiFir = new List<MiFirProjectMiFir>()
                };
                var file = new StreamReader(fileName).ReadToEnd();
                _length = file.Split(new[] { '\n' }).Length - 1;
                using var reader = new StreamReader(fileName);
                reader.ReadLine();
         
                var csvLineCounter = 0;
            try
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null) continue;
                    var values = line.Split(',');
                    mifirDataFromCsv.MiFir.Add(new MiFirProjectMiFir
                    {
                        ControlNumber = new[] { "Test" },
                        ReportStatus = values[0],
                        TransactionReferenceNumber = values[1],
                        TradingVenueTransactionIdentificationCode = values[2],
                        ExecutingEntityIdentificationCode = values[3],
                        InvestmentFirm = values[4],
                        SubmittingEntityIdentificationCode = values[5],
                        BuyerIdentificationCode = values[6],
                        CountryOfTheBranchForTheBuyer = values[7],
                        BuyerFirstName = values[8],
                        BuyerSurname = values[9],
                        BuyerDateOfBirth = DateTime.TryParse(values[10], out DateTime date) ? date : DateTime.MinValue,
                        BuyerDecisionMakerCode = values[11],
                        BuyDecisionMakerFirstName = values[12],
                        BuyDecisionMakerSurname = values[13],
                        BuyDecisionMakerDateOfBirth = DateTime.TryParse(values[14], out DateTime date2) ? date2 : DateTime.MinValue,
                        SellerIdentificationCode = values[15],
                        CountryOfTheBranchForTheSeller = values[16],
                        SellerFirstName = values[17],
                        SellerSurname = values[18],
                        SellerDateOfBirth = DateTime.TryParse(values[19], out DateTime date3) ? date3 : DateTime.MinValue,
                        SellerDecisionMakerCode = values[20],
                        SellDecisionMakerFirstName = values[21],
                        SellDecisionMakerSurname = values[22],
                        SellDecisionMakerDateOfBirth = DateTime.TryParse(values[23], out DateTime date4) ? date4 : DateTime.MinValue,
                        TransmissionOfOrderIndicator = values[24],
                        TransmittingFirmIdentificationCodeForTheBuyer = values[25],
                        TransmittingFirmIdentificationCodeForTheSeller = values[26],
                        TradingDateTime = DateTime.TryParse(values[27], out DateTime date5) ? date5 : DateTime.MinValue,
                        TradingCapacity = values[28],
                        Quantity = decimal.Parse(values[29].Replace(".", ",")),
                        QuantityCurrency = values[30],
                        DerivativeNotionalIncreaseDecrease = values[31],
                        Price = values[32],
                        PriceCurrency = values[33],
                        NetAmount = values[34],
                        Venue = values[35],
                        CountryOfTheBranchMembership = values[36],
                        UpfrontPayment = values[37],
                        UpfrontPaymentCurrency = values[38],
                        ComplexTradeComponentId = values[39],
                        InstrumentIdentificationCode = values[40],
                        InstrumentFullName = values[41],
                        InstrumentClassification = values[42],
                        NotionalCurrency1 = values[43],
                        NotionalCurrency2 = values[44],
                        PriceMultiplier = values[45],
                        UnderlyingInstrumentCode = values[46],
                        UnderlyingIndexName = values[47],
                        TermOfTheUnderlyingIndex = values[48],
                        OptionType = values[49],
                        StrikePrice = values[50],
                        StrikePriceCurrency = values[51],
                        OptionExerciseStyle = values[52],
                        MaturityDate = values[53],
                        ExpiryDate = values[54],
                        DeliveryType = values[55],
                        InvestmentDecisionWithinFirm = values[56],
                        CountryOfTheBranchSuperVisingThePersonResponsibleForTheInvestmentDecision = values[57],
                        ExecutionWithinFirm = values[58],
                        CountryOfTheBranchSupervisingThePersonResponsibleForTheExecution = values[59],
                        WaiverIndicator = values[60],
                        ShortSellingIndicator = values[61],
                        OtcPostTradeIndicator = values[62],
                        CommodityDerivativeIndicator = values[63],
                        SecuritiesFinancingTransactionIndicator = values[64]
                    });
                    csvLineCounter++;
                    worker.ReportProgress(((csvLineCounter + 1) * 100) / (2 * _length));
                }
                return mifirDataFromCsv;
            }
            catch (Exception ex)
            {

                throw ex ;
            }
          
        }

        // Serializing simple object to xml
        // result will be saved under \bin\Debug\net6.0\
        public static void SimpleSaveAsXmlFormat<T>(T objGraph, string fileName)
        {
            var xmlFormat = new XmlSerializer(typeof(T));
            using Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            xmlFormat.Serialize(fStream, objGraph);
        }

        /// <summary>
        /// It reads the XML file and displays the value of the element "ReportStatus" and the value of
        /// the attribute "type" of the root element
        /// </summary>
        public static void ReadElementFromXml()
        {
            try
            {
                var doc = new XmlDocument();

                doc.Load("Constrainte.xml");

                // Get and display all the book titles.
                var root = doc.DocumentElement;
                Debug.Assert(root != null, nameof(root) + " != null");
                var elemList = root.GetElementsByTagName("ReportStatus");

                for (var i = 0; i < elemList.Count; i++)
                {
                    Console.WriteLine(elemList[i]?.InnerXml);
                }
                Console.WriteLine(root.GetAttribute("type"));
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                using var writer = File.CreateText("log.txt");
                writer.WriteLine($"Date : {DateTime.Now}");
                writer.WriteLine($"Member name: {e.TargetSite}");
                writer.WriteLine($"Class defining member: {e.TargetSite?.DeclaringType}");
                if (e.TargetSite != null) writer.WriteLine($"Member type: {e.TargetSite.MemberType}");
                writer.WriteLine($"Message: {e.Message}");
                writer.WriteLine($"Source: {e.Source}");
                writer.Write(writer.NewLine);
            }
        }

        /// <summary>
        /// It reads the log file and prints it to the console
        /// </summary>
        public static void ReadLogFile()
        {
            Console.WriteLine($@"Reading from the log file:");
            try
            {
                using (var sr = File.OpenText("log.txt"))
                {
                    while (sr.ReadLine() is { } input)
                    {
                        Console.WriteLine(input);
                    }
                }
                Console.ReadLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message + @" Creating the log file now");
                using (File.CreateText("log.txt"))
                {
                }
            }
        }

        /// <summary>
        /// > This function reads the value of a key from the appsettings.json file
        /// </summary>
        /// <param name="key">The key of the appSettings value you want to read.</param>
        /// <returns>
        /// The value of the key in the appSettings section of the web.config file.
        /// </returns>
        public static string ReadFomAppSettings(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            var result = appSettings[key] ?? "Not Found";
            return result;
        }

        /// <summary>
        /// It takes an object of type T and returns a string representation of the object
        /// </summary>
        /// <returns>
        /// A string
        /// </returns>
        public static string SerializeObject<T>(T toSerialize)
        {
            var textWriter = new StringWriter();
            if (toSerialize == null) return textWriter.ToString();
            var xmlSerializer = new XmlSerializer(toSerialize.GetType());
            xmlSerializer.Serialize(textWriter, toSerialize);

            return textWriter.ToString();
        }

        /// <summary>
        /// Load the XML document and validate it against the schema
        /// </summary>
        /// <param name="doc">the xml document to be validated</param>
        /// <param name="xsdSchema">the xsd schema file that contains the rules to validate the xml document</param>
        public static string XmlSchemaVerification(string doc, string xsdSchema, BackgroundWorker worker)
        {
            //worker.ReportProgress(60);

            var xmlDocument = new XmlDocument
            {
                Schemas = new XmlSchemaSet()
            };
            xmlDocument.Schemas.Add(null, XmlReader.Create(new StringReader(xsdSchema)));

            ValidationEventHandler eventHandler = new ValidationEventHandler((sender,e)=> ValidationEventHandlers(sender,e,worker));
            TextReader textReader = new StringReader(doc);
            xmlDocument.Load(textReader);
            xmlDocument.Validate(eventHandler);
            //worker.ReporctProgress(100); 
            return _verificationResult;
        }

    

        public static void ValidationEventHandlers(object? sender, ValidationEventArgs e, BackgroundWorker worker)
        {

            var currentBloc = ((XmlElement)((XmlSchemaValidationException)e.Exception).SourceObject!).Name;

            if (e.Severity == XmlSeverityType.Error && currentBloc != "ControlNumber")
            {
                _verificationResult += $"Line: {_counter.ToString()} : Error: {e.Message} \r\n ";
            }
            else
            {
                // todo progress bar + count variable
                _counter++;
                 
                worker.ReportProgress((((_length + _counter) * 100)) / (2 * _length));

            }
        }

        //private static void ValidationEventHandler(object sender, ValidationEventArgs e,BackgroundWorker worker  )
        //{
        //    var currentBloc = ((XmlElement)((XmlSchemaValidationException)e.Exception).SourceObject!).Name;

        //    if (e.Severity == XmlSeverityType.Error && currentBloc != "ControlNumber")
        //    {
        //        _verificationResult += $"Line: {_counter.ToString()} : Error: {e.Message} \r\n ";
        //    }
        //    else
        //    {
        //        // todo progress bar + count variable
        //        _counter++;
        //        worker.ReportProgress(((_length + _counter) * 100) / 2 * _length);
        //    }

        //}
    }
}