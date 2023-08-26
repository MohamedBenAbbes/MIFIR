
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class MiFirProject
{

    private string[] controlNumberField;

    private string reportStatusField;

    private string transactionReferenceNumberField;

    private string executingEntityIdentificationCodeField;

    private string investmentFirmField;

    private string buyerIdentificationCodeField;

    private string countryOfTheBranchForTheBuyerField;

    private object buyerFirstNameField;

    private object buyerSurnameField;

    private object buyerDateOfBirthField;

    private string buyerDecisionMakerCodeField;

    private object buyDecisionMakerFirstNameField;

    private object buyDecisionMakerSurnameField;

    private object buyDecisionMakerDateOfBirthField;

    private string sellerIdentificationCodeField;

    private string countryOfTheBranchForTheSellerField;

    private string sellerFirstNameField;

    private string sellerSurnameField;

    private object sellerDateOfBirthField;

    private string sellerDecisionMakerCodeField;

    private object sellDecisionMakerFirstNameField;

    private object sellDecisionMakerSurnameField;

    private object sellDecisionMakerDateOfBirthField;

    private bool transmissionOfOrderIndicatorField;

    private System.DateTime tradingDateTimeField;

    private string tradingCapacityField;

    private byte quantityField;

    private string quantityCurrencyField;

    private byte priceField;

    private string priceCurrencyField;

    private string venueField;

    private string instrumentIdentificationCodeField;

    private string investmentDecisionWithinFirmField;

    private string countryOfTheBranchSuperVisingThePersonResponsibleForTheInvestmentDecisionField;

    private string executionWithinFirmField;

    private string securitiesFinancingTransactionIndicatorField;

    private object tradingVenueTransactionIdentificationCodeField;

    private object transmittingFirmIdentificationCodeForTheBuyerField;

    private object transmittingFirmIdentificationCodeForTheSellerField;

    private object derivativeNotionalIncreaseDecreaseField;

    private object netAmountField;

    private object countryOfTheBranchMembershipField;

    private object upfrontPaymentField;

    private object upfrontPaymentCurrencyField;

    private object complexTradeComponentIdField;

    private object instrumentFullNameField;

    private object instrumentClassificationField;

    private object notionalCurrency1Field;

    private object notionalCurrency2Field;

    private object priceMultiplierField;

    private object underlyingInstrumentCodeField;

    private object underlyingIndexNameField;

    private object termOfTheUnderlyingIndexField;

    private object optionTypeField;

    private object strikePriceField;

    private object strikePriceCurrencyField;

    private object optionExerciseStyleField;

    private object maturityDateField;

    private object expiryDateField;

    private object deliveryTypeField;

    private object countryOfTheBranchSupervisingThePersonResponsibleForTheExecutionField;

    private object waiverIndicatorField;

    private object shortSellingIndicatorField;

    private object oTCPostTradeIndicatorField;

    private object commodityDerivativeIndicatorField;

    private string submittingEntityIdentificationCodeField;

    private byte buyerIDTypeField;

    private string buyerIDSubTypeField;

    private byte buyerDecisionMakerIDTypeField;

    private string buyerDecisionMakerIDSubTypeField;

    private byte sellerIDTypeField;

    private string sellerIDSubTypeField;

    private byte sellerDecisionMakerIDTypeField;

    private string sellerDecisionMakerIDSubTypeField;

    private string quantityTypeField;

    private string priceTypeField;

    private string instrumentIDTypeField;

    private string notionalCurrency2TypeField;

    private string uVInstrumentClassificationField;

    private string uVIndexClassificationField;

    private string underlyingIndexIDField;

    private string strikePriceTypeField;

    private byte investmentDecisionIDTypeField;

    private string investmentDecisionIDSubTypeField;

    private byte firmExecutionIDTypeField;

    private string firmExecutionIDSubTypeField;

    private string dataCategoryField;

    private string internalClientIdentificationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ControlNumber")]
    public string[] ControlNumber
    {
        get
        {
            return this.controlNumberField;
        }
        set
        {
            this.controlNumberField = value;
        }
    }

    /// <remarks/>
    public string ReportStatus
    {
        get
        {
            return this.reportStatusField;
        }
        set
        {
            this.reportStatusField = value;
        }
    }

    /// <remarks/>
    public string TransactionReferenceNumber
    {
        get
        {
            return this.transactionReferenceNumberField;
        }
        set
        {
            this.transactionReferenceNumberField = value;
        }
    }

    /// <remarks/>
    public string ExecutingEntityIdentificationCode
    {
        get
        {
            return this.executingEntityIdentificationCodeField;
        }
        set
        {
            this.executingEntityIdentificationCodeField = value;
        }
    }

    /// <remarks/>
    public string InvestmentFirm
    {
        get
        {
            return this.investmentFirmField;
        }
        set
        {
            this.investmentFirmField = value;
        }
    }

    /// <remarks/>
    public string BuyerIdentificationCode
    {
        get
        {
            return this.buyerIdentificationCodeField;
        }
        set
        {
            this.buyerIdentificationCodeField = value;
        }
    }

    /// <remarks/>
    public string CountryOfTheBranchForTheBuyer
    {
        get
        {
            return this.countryOfTheBranchForTheBuyerField;
        }
        set
        {
            this.countryOfTheBranchForTheBuyerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object BuyerFirstName
    {
        get
        {
            return this.buyerFirstNameField;
        }
        set
        {
            this.buyerFirstNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object BuyerSurname
    {
        get
        {
            return this.buyerSurnameField;
        }
        set
        {
            this.buyerSurnameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object BuyerDateOfBirth
    {
        get
        {
            return this.buyerDateOfBirthField;
        }
        set
        {
            this.buyerDateOfBirthField = value;
        }
    }

    /// <remarks/>
    public string BuyerDecisionMakerCode
    {
        get
        {
            return this.buyerDecisionMakerCodeField;
        }
        set
        {
            this.buyerDecisionMakerCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object BuyDecisionMakerFirstName
    {
        get
        {
            return this.buyDecisionMakerFirstNameField;
        }
        set
        {
            this.buyDecisionMakerFirstNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object BuyDecisionMakerSurname
    {
        get
        {
            return this.buyDecisionMakerSurnameField;
        }
        set
        {
            this.buyDecisionMakerSurnameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object BuyDecisionMakerDateOfBirth
    {
        get
        {
            return this.buyDecisionMakerDateOfBirthField;
        }
        set
        {
            this.buyDecisionMakerDateOfBirthField = value;
        }
    }

    /// <remarks/>
    public string SellerIdentificationCode
    {
        get
        {
            return this.sellerIdentificationCodeField;
        }
        set
        {
            this.sellerIdentificationCodeField = value;
        }
    }

    /// <remarks/>
    public string CountryOfTheBranchForTheSeller
    {
        get
        {
            return this.countryOfTheBranchForTheSellerField;
        }
        set
        {
            this.countryOfTheBranchForTheSellerField = value;
        }
    }

    /// <remarks/>
    public string SellerFirstName
    {
        get
        {
            return this.sellerFirstNameField;
        }
        set
        {
            this.sellerFirstNameField = value;
        }
    }

    /// <remarks/>
    public string SellerSurname
    {
        get
        {
            return this.sellerSurnameField;
        }
        set
        {
            this.sellerSurnameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object SellerDateOfBirth
    {
        get
        {
            return this.sellerDateOfBirthField;
        }
        set
        {
            this.sellerDateOfBirthField = value;
        }
    }

    /// <remarks/>
    public string SellerDecisionMakerCode
    {
        get
        {
            return this.sellerDecisionMakerCodeField;
        }
        set
        {
            this.sellerDecisionMakerCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object SellDecisionMakerFirstName
    {
        get
        {
            return this.sellDecisionMakerFirstNameField;
        }
        set
        {
            this.sellDecisionMakerFirstNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object SellDecisionMakerSurname
    {
        get
        {
            return this.sellDecisionMakerSurnameField;
        }
        set
        {
            this.sellDecisionMakerSurnameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object SellDecisionMakerDateOfBirth
    {
        get
        {
            return this.sellDecisionMakerDateOfBirthField;
        }
        set
        {
            this.sellDecisionMakerDateOfBirthField = value;
        }
    }

    /// <remarks/>
    public bool TransmissionOfOrderIndicator
    {
        get
        {
            return this.transmissionOfOrderIndicatorField;
        }
        set
        {
            this.transmissionOfOrderIndicatorField = value;
        }
    }

    /// <remarks/>
    public System.DateTime TradingDateTime
    {
        get
        {
            return this.tradingDateTimeField;
        }
        set
        {
            this.tradingDateTimeField = value;
        }
    }

    /// <remarks/>
    public string TradingCapacity
    {
        get
        {
            return this.tradingCapacityField;
        }
        set
        {
            this.tradingCapacityField = value;
        }
    }

    /// <remarks/>
    public byte Quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    public string QuantityCurrency
    {
        get
        {
            return this.quantityCurrencyField;
        }
        set
        {
            this.quantityCurrencyField = value;
        }
    }

    /// <remarks/>
    public byte Price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    /// <remarks/>
    public string PriceCurrency
    {
        get
        {
            return this.priceCurrencyField;
        }
        set
        {
            this.priceCurrencyField = value;
        }
    }

    /// <remarks/>
    public string Venue
    {
        get
        {
            return this.venueField;
        }
        set
        {
            this.venueField = value;
        }
    }

    /// <remarks/>
    public string InstrumentIdentificationCode
    {
        get
        {
            return this.instrumentIdentificationCodeField;
        }
        set
        {
            this.instrumentIdentificationCodeField = value;
        }
    }

    /// <remarks/>
    public string InvestmentDecisionWithinFirm
    {
        get
        {
            return this.investmentDecisionWithinFirmField;
        }
        set
        {
            this.investmentDecisionWithinFirmField = value;
        }
    }

    /// <remarks/>
    public string CountryOfTheBranchSuperVisingThePersonResponsibleForTheInvestmentDecision
    {
        get
        {
            return this.countryOfTheBranchSuperVisingThePersonResponsibleForTheInvestmentDecisionField;
        }
        set
        {
            this.countryOfTheBranchSuperVisingThePersonResponsibleForTheInvestmentDecisionField = value;
        }
    }

    /// <remarks/>
    public string ExecutionWithinFirm
    {
        get
        {
            return this.executionWithinFirmField;
        }
        set
        {
            this.executionWithinFirmField = value;
        }
    }

    /// <remarks/>
    public string SecuritiesFinancingTransactionIndicator
    {
        get
        {
            return this.securitiesFinancingTransactionIndicatorField;
        }
        set
        {
            this.securitiesFinancingTransactionIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object TradingVenueTransactionIdentificationCode
    {
        get
        {
            return this.tradingVenueTransactionIdentificationCodeField;
        }
        set
        {
            this.tradingVenueTransactionIdentificationCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object TransmittingFirmIdentificationCodeForTheBuyer
    {
        get
        {
            return this.transmittingFirmIdentificationCodeForTheBuyerField;
        }
        set
        {
            this.transmittingFirmIdentificationCodeForTheBuyerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object TransmittingFirmIdentificationCodeForTheSeller
    {
        get
        {
            return this.transmittingFirmIdentificationCodeForTheSellerField;
        }
        set
        {
            this.transmittingFirmIdentificationCodeForTheSellerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object DerivativeNotionalIncreaseDecrease
    {
        get
        {
            return this.derivativeNotionalIncreaseDecreaseField;
        }
        set
        {
            this.derivativeNotionalIncreaseDecreaseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object NetAmount
    {
        get
        {
            return this.netAmountField;
        }
        set
        {
            this.netAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object CountryOfTheBranchMembership
    {
        get
        {
            return this.countryOfTheBranchMembershipField;
        }
        set
        {
            this.countryOfTheBranchMembershipField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Up-frontPayment", IsNullable = true)]
    public object UpfrontPayment
    {
        get
        {
            return this.upfrontPaymentField;
        }
        set
        {
            this.upfrontPaymentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Up-frontPaymentCurrency", IsNullable = true)]
    public object UpfrontPaymentCurrency
    {
        get
        {
            return this.upfrontPaymentCurrencyField;
        }
        set
        {
            this.upfrontPaymentCurrencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object ComplexTradeComponentId
    {
        get
        {
            return this.complexTradeComponentIdField;
        }
        set
        {
            this.complexTradeComponentIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object InstrumentFullName
    {
        get
        {
            return this.instrumentFullNameField;
        }
        set
        {
            this.instrumentFullNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object InstrumentClassification
    {
        get
        {
            return this.instrumentClassificationField;
        }
        set
        {
            this.instrumentClassificationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object NotionalCurrency1
    {
        get
        {
            return this.notionalCurrency1Field;
        }
        set
        {
            this.notionalCurrency1Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object NotionalCurrency2
    {
        get
        {
            return this.notionalCurrency2Field;
        }
        set
        {
            this.notionalCurrency2Field = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object PriceMultiplier
    {
        get
        {
            return this.priceMultiplierField;
        }
        set
        {
            this.priceMultiplierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object UnderlyingInstrumentCode
    {
        get
        {
            return this.underlyingInstrumentCodeField;
        }
        set
        {
            this.underlyingInstrumentCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object UnderlyingIndexName
    {
        get
        {
            return this.underlyingIndexNameField;
        }
        set
        {
            this.underlyingIndexNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object TermOfTheUnderlyingIndex
    {
        get
        {
            return this.termOfTheUnderlyingIndexField;
        }
        set
        {
            this.termOfTheUnderlyingIndexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object OptionType
    {
        get
        {
            return this.optionTypeField;
        }
        set
        {
            this.optionTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object StrikePrice
    {
        get
        {
            return this.strikePriceField;
        }
        set
        {
            this.strikePriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object StrikePriceCurrency
    {
        get
        {
            return this.strikePriceCurrencyField;
        }
        set
        {
            this.strikePriceCurrencyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object OptionExerciseStyle
    {
        get
        {
            return this.optionExerciseStyleField;
        }
        set
        {
            this.optionExerciseStyleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object MaturityDate
    {
        get
        {
            return this.maturityDateField;
        }
        set
        {
            this.maturityDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object ExpiryDate
    {
        get
        {
            return this.expiryDateField;
        }
        set
        {
            this.expiryDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object DeliveryType
    {
        get
        {
            return this.deliveryTypeField;
        }
        set
        {
            this.deliveryTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object CountryOfTheBranchSupervisingThePersonResponsibleForTheExecution
    {
        get
        {
            return this.countryOfTheBranchSupervisingThePersonResponsibleForTheExecutionField;
        }
        set
        {
            this.countryOfTheBranchSupervisingThePersonResponsibleForTheExecutionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object WaiverIndicator
    {
        get
        {
            return this.waiverIndicatorField;
        }
        set
        {
            this.waiverIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object ShortSellingIndicator
    {
        get
        {
            return this.shortSellingIndicatorField;
        }
        set
        {
            this.shortSellingIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OTCPost-TradeIndicator", IsNullable = true)]
    public object OTCPostTradeIndicator
    {
        get
        {
            return this.oTCPostTradeIndicatorField;
        }
        set
        {
            this.oTCPostTradeIndicatorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
    public object CommodityDerivativeIndicator
    {
        get
        {
            return this.commodityDerivativeIndicatorField;
        }
        set
        {
            this.commodityDerivativeIndicatorField = value;
        }
    }

    /// <remarks/>
    public string SubmittingEntityIdentificationCode
    {
        get
        {
            return this.submittingEntityIdentificationCodeField;
        }
        set
        {
            this.submittingEntityIdentificationCodeField = value;
        }
    }

    /// <remarks/>
    public byte BuyerIDType
    {
        get
        {
            return this.buyerIDTypeField;
        }
        set
        {
            this.buyerIDTypeField = value;
        }
    }

    /// <remarks/>
    public string BuyerIDSubType
    {
        get
        {
            return this.buyerIDSubTypeField;
        }
        set
        {
            this.buyerIDSubTypeField = value;
        }
    }

    /// <remarks/>
    public byte BuyerDecisionMakerIDType
    {
        get
        {
            return this.buyerDecisionMakerIDTypeField;
        }
        set
        {
            this.buyerDecisionMakerIDTypeField = value;
        }
    }

    /// <remarks/>
    public string BuyerDecisionMakerIDSubType
    {
        get
        {
            return this.buyerDecisionMakerIDSubTypeField;
        }
        set
        {
            this.buyerDecisionMakerIDSubTypeField = value;
        }
    }

    /// <remarks/>
    public byte SellerIDType
    {
        get
        {
            return this.sellerIDTypeField;
        }
        set
        {
            this.sellerIDTypeField = value;
        }
    }

    /// <remarks/>
    public string SellerIDSubType
    {
        get
        {
            return this.sellerIDSubTypeField;
        }
        set
        {
            this.sellerIDSubTypeField = value;
        }
    }

    /// <remarks/>
    public byte SellerDecisionMakerIDType
    {
        get
        {
            return this.sellerDecisionMakerIDTypeField;
        }
        set
        {
            this.sellerDecisionMakerIDTypeField = value;
        }
    }

    /// <remarks/>
    public string SellerDecisionMakerIDSubType
    {
        get
        {
            return this.sellerDecisionMakerIDSubTypeField;
        }
        set
        {
            this.sellerDecisionMakerIDSubTypeField = value;
        }
    }

    /// <remarks/>
    public string QuantityType
    {
        get
        {
            return this.quantityTypeField;
        }
        set
        {
            this.quantityTypeField = value;
        }
    }

    /// <remarks/>
    public string PriceType
    {
        get
        {
            return this.priceTypeField;
        }
        set
        {
            this.priceTypeField = value;
        }
    }

    /// <remarks/>
    public string InstrumentIDType
    {
        get
        {
            return this.instrumentIDTypeField;
        }
        set
        {
            this.instrumentIDTypeField = value;
        }
    }

    /// <remarks/>
    public string NotionalCurrency2Type
    {
        get
        {
            return this.notionalCurrency2TypeField;
        }
        set
        {
            this.notionalCurrency2TypeField = value;
        }
    }

    /// <remarks/>
    public string UVInstrumentClassification
    {
        get
        {
            return this.uVInstrumentClassificationField;
        }
        set
        {
            this.uVInstrumentClassificationField = value;
        }
    }

    /// <remarks/>
    public string UVIndexClassification
    {
        get
        {
            return this.uVIndexClassificationField;
        }
        set
        {
            this.uVIndexClassificationField = value;
        }
    }

    /// <remarks/>
    public string UnderlyingIndexID
    {
        get
        {
            return this.underlyingIndexIDField;
        }
        set
        {
            this.underlyingIndexIDField = value;
        }
    }

    /// <remarks/>
    public string StrikePriceType
    {
        get
        {
            return this.strikePriceTypeField;
        }
        set
        {
            this.strikePriceTypeField = value;
        }
    }

    /// <remarks/>
    public byte InvestmentDecisionIDType
    {
        get
        {
            return this.investmentDecisionIDTypeField;
        }
        set
        {
            this.investmentDecisionIDTypeField = value;
        }
    }

    /// <remarks/>
    public string InvestmentDecisionIDSubType
    {
        get
        {
            return this.investmentDecisionIDSubTypeField;
        }
        set
        {
            this.investmentDecisionIDSubTypeField = value;
        }
    }

    /// <remarks/>
    public byte FirmExecutionIDType
    {
        get
        {
            return this.firmExecutionIDTypeField;
        }
        set
        {
            this.firmExecutionIDTypeField = value;
        }
    }

    /// <remarks/>
    public string FirmExecutionIDSubType
    {
        get
        {
            return this.firmExecutionIDSubTypeField;
        }
        set
        {
            this.firmExecutionIDSubTypeField = value;
        }
    }

    /// <remarks/>
    public string DataCategory
    {
        get
        {
            return this.dataCategoryField;
        }
        set
        {
            this.dataCategoryField = value;
        }
    }

    /// <remarks/>
    public string InternalClientIdentification
    {
        get
        {
            return this.internalClientIdentificationField;
        }
        set
        {
            this.internalClientIdentificationField = value;
        }
    }
}

