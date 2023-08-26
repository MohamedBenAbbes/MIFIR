namespace MifirDesktop
{
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class MiFirProject
    {
        private List<MiFirProjectMiFir> miFirField = null!;

        [System.Xml.Serialization.XmlElementAttribute("MiFir")]
        public List<MiFirProjectMiFir> MiFir
        {
            get => miFirField;
            set => miFirField = value;
        }
    }

    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class MiFirProjectMiFir
    {
        private string[]? controlNumberField;

        private string? reportStatusField;

        private string? transactionReferenceNumberField;

        private string? executingEntityIdentificationCodeField;

        private string? investmentFirmField;

        private string? buyerIdentificationCodeField;

        private string? countryOfTheBranchForTheBuyerField;

        private string? buyerFirstNameField;

        private string? buyerSurnameField;

        private DateTime buyerDateOfBirthField;

        private string? buyerDecisionMakerCodeField;

        private string? buyDecisionMakerFirstNameField;

        private string? buyDecisionMakerSurnameField;

        private DateTime buyDecisionMakerDateOfBirthField;

        private string? sellerIdentificationCodeField;

        private string? countryOfTheBranchForTheSellerField;

        private string? sellerFirstNameField;

        private string? sellerSurnameField;

        private DateTime sellerDateOfBirthField;

        private string? sellerDecisionMakerCodeField;

        private string? sellDecisionMakerFirstNameField;

        private string? sellDecisionMakerSurnameField;

        private DateTime sellDecisionMakerDateOfBirthField;

        private string? transmissionOfOrderIndicatorField;

        private DateTime tradingDateTimeField;

        private string? tradingCapacityField;

        private decimal quantityField;

        private string? quantityCurrencyField;

        private string? priceField;

        private string? priceCurrencyField;

        private string? venueField;

        private string? instrumentIdentificationCodeField;

        private string? investmentDecisionWithinFirmField;

        private string? countryOfTheBranchSuperVisingThePersonResponsibleForTheInvestmentDecisionField;

        private string? executionWithinFirmField;

        private string? securitiesFinancingTransactionIndicatorField;

        private string? tradingVenueTransactionIdentificationCodeField;

        private string? transmittingFirmIdentificationCodeForTheBuyerField;

        private string? transmittingFirmIdentificationCodeForTheSellerField;

        private string? derivativeNotionalIncreaseDecreaseField;

        private string? netAmountField;

        private string? countryOfTheBranchMembershipField;

        private string? upfrontPaymentField;

        private string? upfrontPaymentCurrencyField;

        private string? complexTradeComponentIdField;

        private string? instrumentFullNameField;

        private string? instrumentClassificationField;

        private string? notionalCurrency1Field;

        private string? notionalCurrency2Field;

        private string? priceMultiplierField;

        private string? underlyingInstrumentCodeField;

        private string? underlyingIndexNameField;

        private string? termOfTheUnderlyingIndexField;

        private string? optionTypeField;

        private string? strikePriceField;

        private string? strikePriceCurrencyField;

        private string? optionExerciseStyleField;

        private string? maturityDateField;

        private string? expiryDateField;

        private string? deliveryTypeField;

        private string? countryOfTheBranchSupervisingThePersonResponsibleForTheExecutionField;

        private string? waiverIndicatorField;

        private string? shortSellingIndicatorField;

        private string? oTcPostTradeIndicatorField;

        private string? commodityDerivativeIndicatorField;

        private string? submittingEntityIdentificationCodeField;

        [System.Xml.Serialization.XmlElementAttribute("ControlNumber")]
        public string[]? ControlNumber
        {
            get => controlNumberField;
            set => controlNumberField = value;
        }

        public string? ReportStatus
        {
            get => reportStatusField;
            set => reportStatusField = value;
        }

        public string? TransactionReferenceNumber
        {
            get => transactionReferenceNumberField;
            set => transactionReferenceNumberField = value;
        }

        public string? ExecutingEntityIdentificationCode
        {
            get => executingEntityIdentificationCodeField;
            set => executingEntityIdentificationCodeField = value;
        }

        public string? InvestmentFirm
        {
            get => investmentFirmField;
            set => investmentFirmField = value;
        }

        public string? BuyerIdentificationCode
        {
            get => buyerIdentificationCodeField;
            set => buyerIdentificationCodeField = value;
        }

        public string? CountryOfTheBranchForTheBuyer
        {
            get => countryOfTheBranchForTheBuyerField;
            set => countryOfTheBranchForTheBuyerField = value;
        }

        public string? BuyerFirstName
        {
            get => buyerFirstNameField;
            set => buyerFirstNameField = value;
        }

        public string? BuyerSurname
        {
            get => buyerSurnameField;
            set => buyerSurnameField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public DateTime BuyerDateOfBirth
        {
            get => buyerDateOfBirthField;
            set => buyerDateOfBirthField = value;
        }

        public string? BuyerDecisionMakerCode
        {
            get => buyerDecisionMakerCodeField;
            set => buyerDecisionMakerCodeField = value;
        }

        public string? BuyDecisionMakerFirstName
        {
            get => buyDecisionMakerFirstNameField;
            set => buyDecisionMakerFirstNameField = value;
        }

        public string? BuyDecisionMakerSurname
        {
            get => buyDecisionMakerSurnameField;
            set => buyDecisionMakerSurnameField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public DateTime BuyDecisionMakerDateOfBirth
        {
            get => buyDecisionMakerDateOfBirthField;
            set => buyDecisionMakerDateOfBirthField = value;
        }

        public string? SellerIdentificationCode
        {
            get => sellerIdentificationCodeField;
            set => sellerIdentificationCodeField = value;
        }

        public string? CountryOfTheBranchForTheSeller
        {
            get => countryOfTheBranchForTheSellerField;
            set => countryOfTheBranchForTheSellerField = value;
        }

        public string? SellerFirstName
        {
            get => sellerFirstNameField;
            set => sellerFirstNameField = value;
        }

        public string? SellerSurname
        {
            get => sellerSurnameField;
            set => sellerSurnameField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public DateTime SellerDateOfBirth
        {
            get => sellerDateOfBirthField;
            set => sellerDateOfBirthField = value;
        }

        public string? SellerDecisionMakerCode
        {
            get => sellerDecisionMakerCodeField;
            set => sellerDecisionMakerCodeField = value;
        }

        public string? SellDecisionMakerFirstName
        {
            get => sellDecisionMakerFirstNameField;
            set => sellDecisionMakerFirstNameField = value;
        }

        public string? SellDecisionMakerSurname
        {
            get => sellDecisionMakerSurnameField;
            set => sellDecisionMakerSurnameField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public DateTime SellDecisionMakerDateOfBirth
        {
            get => sellDecisionMakerDateOfBirthField;
            set => sellDecisionMakerDateOfBirthField = value;
        }

        public string? TransmissionOfOrderIndicator
        {
            get => transmissionOfOrderIndicatorField;
            set => transmissionOfOrderIndicatorField = value;
        }

        public DateTime TradingDateTime
        {
            get => tradingDateTimeField;
            set => tradingDateTimeField = value;
        }

        public string? TradingCapacity
        {
            get => tradingCapacityField;
            set => tradingCapacityField = value;
        }

        public decimal Quantity
        {
            get => quantityField;
            set => quantityField = value;
        }

        public string? QuantityCurrency
        {
            get => quantityCurrencyField;
            set => quantityCurrencyField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string? Price
        {
            get => priceField;
            set => priceField = value;
        }

        public string? PriceCurrency
        {
            get => priceCurrencyField;
            set => priceCurrencyField = value;
        }

        public string? Venue
        {
            get => venueField;
            set => venueField = value;
        }

        public string? InstrumentIdentificationCode
        {
            get => instrumentIdentificationCodeField;
            set => instrumentIdentificationCodeField = value;
        }

        public string? InvestmentDecisionWithinFirm
        {
            get => investmentDecisionWithinFirmField;
            set => investmentDecisionWithinFirmField = value;
        }

        public string? CountryOfTheBranchSuperVisingThePersonResponsibleForTheInvestmentDecision
        {
            get => countryOfTheBranchSuperVisingThePersonResponsibleForTheInvestmentDecisionField;
            set => countryOfTheBranchSuperVisingThePersonResponsibleForTheInvestmentDecisionField = value;
        }

        public string? ExecutionWithinFirm
        {
            get => executionWithinFirmField;
            set => executionWithinFirmField = value;
        }

        public string? SecuritiesFinancingTransactionIndicator
        {
            get => securitiesFinancingTransactionIndicatorField;
            set => securitiesFinancingTransactionIndicatorField = value;
        }

        public string? TradingVenueTransactionIdentificationCode
        {
            get => tradingVenueTransactionIdentificationCodeField;
            set => tradingVenueTransactionIdentificationCodeField = value;
        }

        public string? TransmittingFirmIdentificationCodeForTheBuyer
        {
            get => transmittingFirmIdentificationCodeForTheBuyerField;
            set => transmittingFirmIdentificationCodeForTheBuyerField = value;
        }

        public string? TransmittingFirmIdentificationCodeForTheSeller
        {
            get => transmittingFirmIdentificationCodeForTheSellerField;
            set => transmittingFirmIdentificationCodeForTheSellerField = value;
        }

        public string? DerivativeNotionalIncreaseDecrease
        {
            get => derivativeNotionalIncreaseDecreaseField;
            set => derivativeNotionalIncreaseDecreaseField = value;
        }

        public string? NetAmount
        {
            get => netAmountField;
            set => netAmountField = value;
        }

        public string? CountryOfTheBranchMembership
        {
            get => countryOfTheBranchMembershipField;
            set => countryOfTheBranchMembershipField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute("Up-frontPayment")]
        public string? UpfrontPayment
        {
            get => upfrontPaymentField;
            set => upfrontPaymentField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute("Up-frontPaymentCurrency")]
        public string? UpfrontPaymentCurrency
        {
            get => upfrontPaymentCurrencyField;
            set => upfrontPaymentCurrencyField = value;
        }

        public string? ComplexTradeComponentId
        {
            get => complexTradeComponentIdField;
            set => complexTradeComponentIdField = value;
        }

        public string? InstrumentFullName
        {
            get => instrumentFullNameField;
            set => instrumentFullNameField = value;
        }

        public string? InstrumentClassification
        {
            get => instrumentClassificationField;
            set => instrumentClassificationField = value;
        }

        public string? NotionalCurrency1
        {
            get => notionalCurrency1Field;
            set => notionalCurrency1Field = value;
        }

        public string? NotionalCurrency2
        {
            get => notionalCurrency2Field;
            set => notionalCurrency2Field = value;
        }

        public string? PriceMultiplier
        {
            get => priceMultiplierField;
            set => priceMultiplierField = value;
        }

        public string? UnderlyingInstrumentCode
        {
            get => underlyingInstrumentCodeField;
            set => underlyingInstrumentCodeField = value;
        }

        public string? UnderlyingIndexName
        {
            get => underlyingIndexNameField;
            set => underlyingIndexNameField = value;
        }

        public string? TermOfTheUnderlyingIndex
        {
            get => termOfTheUnderlyingIndexField;
            set => termOfTheUnderlyingIndexField = value;
        }

        public string? OptionType
        {
            get => optionTypeField;
            set => optionTypeField = value;
        }

        public string? StrikePrice
        {
            get => strikePriceField;
            set => strikePriceField = value;
        }

        public string? StrikePriceCurrency
        {
            get => strikePriceCurrencyField;
            set => strikePriceCurrencyField = value;
        }

        public string? OptionExerciseStyle
        {
            get => optionExerciseStyleField;
            set => optionExerciseStyleField = value;
        }

        public string? MaturityDate
        {
            get => maturityDateField;
            set => maturityDateField = value;
        }

        public string? ExpiryDate
        {
            get => expiryDateField;
            set => expiryDateField = value;
        }

        public string? DeliveryType
        {
            get => deliveryTypeField;
            set => deliveryTypeField = value;
        }

        public string? CountryOfTheBranchSupervisingThePersonResponsibleForTheExecution
        {
            get => countryOfTheBranchSupervisingThePersonResponsibleForTheExecutionField;
            set => countryOfTheBranchSupervisingThePersonResponsibleForTheExecutionField = value;
        }

        public string? WaiverIndicator
        {
            get => waiverIndicatorField;
            set => waiverIndicatorField = value;
        }

        public string? ShortSellingIndicator
        {
            get => shortSellingIndicatorField;
            set => shortSellingIndicatorField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute("OTCPost-TradeIndicator")]
        public string? OtcPostTradeIndicator
        {
            get => oTcPostTradeIndicatorField;
            set => oTcPostTradeIndicatorField = value;
        }

        public string? CommodityDerivativeIndicator
        {
            get => commodityDerivativeIndicatorField;
            set => commodityDerivativeIndicatorField = value;
        }

        public string? SubmittingEntityIdentificationCode
        {
            get => submittingEntityIdentificationCodeField;
            set => submittingEntityIdentificationCodeField = value;
        }
    }
}