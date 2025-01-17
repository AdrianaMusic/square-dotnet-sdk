namespace Square.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Square;
    using Square.Utilities;

    /// <summary>
    /// Card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="cardBrand">card_brand.</param>
        /// <param name="last4">last_4.</param>
        /// <param name="expMonth">exp_month.</param>
        /// <param name="expYear">exp_year.</param>
        /// <param name="cardholderName">cardholder_name.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="fingerprint">fingerprint.</param>
        /// <param name="cardType">card_type.</param>
        /// <param name="prepaidType">prepaid_type.</param>
        /// <param name="bin">bin.</param>
        public Card(
            string id = null,
            string cardBrand = null,
            string last4 = null,
            long? expMonth = null,
            long? expYear = null,
            string cardholderName = null,
            Models.Address billingAddress = null,
            string fingerprint = null,
            string cardType = null,
            string prepaidType = null,
            string bin = null)
        {
            this.Id = id;
            this.CardBrand = cardBrand;
            this.Last4 = last4;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.CardholderName = cardholderName;
            this.BillingAddress = billingAddress;
            this.Fingerprint = fingerprint;
            this.CardType = cardType;
            this.PrepaidType = prepaidType;
            this.Bin = bin;
        }

        /// <summary>
        /// Unique ID for this card. Generated by Square.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; }

        /// <summary>
        /// Indicates a card's brand, such as `VISA` or `MASTERCARD`.
        /// </summary>
        [JsonProperty("card_brand", NullValueHandling = NullValueHandling.Ignore)]
        public string CardBrand { get; }

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("last_4", NullValueHandling = NullValueHandling.Ignore)]
        public string Last4 { get; }

        /// <summary>
        /// The expiration month of the associated card as an integer between 1 and 12.
        /// </summary>
        [JsonProperty("exp_month", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpMonth { get; }

        /// <summary>
        /// The four-digit year of the card's expiration date.
        /// </summary>
        [JsonProperty("exp_year", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpYear { get; }

        /// <summary>
        /// The name of the cardholder.
        /// </summary>
        [JsonProperty("cardholder_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CardholderName { get; }

        /// <summary>
        /// Represents a physical address.
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; }

        /// <summary>
        /// __Not currently set.__ Intended as a Square-assigned identifier, based
        /// on the card number, to identify the card across multiple locations within a
        /// single application.
        /// </summary>
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string Fingerprint { get; }

        /// <summary>
        /// Indicates a card's type, such as `CREDIT` or `DEBIT`.
        /// </summary>
        [JsonProperty("card_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CardType { get; }

        /// <summary>
        /// Indicates a card's prepaid type, such as `NOT_PREPAID` or `PREPAID`.
        /// </summary>
        [JsonProperty("prepaid_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PrepaidType { get; }

        /// <summary>
        /// The first six digits of the card number, known as the Bank Identification Number (BIN). Only the Payments API
        /// returns this field.
        /// </summary>
        [JsonProperty("bin", NullValueHandling = NullValueHandling.Ignore)]
        public string Bin { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Card : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is Card other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CardBrand == null && other.CardBrand == null) || (this.CardBrand?.Equals(other.CardBrand) == true)) &&
                ((this.Last4 == null && other.Last4 == null) || (this.Last4?.Equals(other.Last4) == true)) &&
                ((this.ExpMonth == null && other.ExpMonth == null) || (this.ExpMonth?.Equals(other.ExpMonth) == true)) &&
                ((this.ExpYear == null && other.ExpYear == null) || (this.ExpYear?.Equals(other.ExpYear) == true)) &&
                ((this.CardholderName == null && other.CardholderName == null) || (this.CardholderName?.Equals(other.CardholderName) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.Fingerprint == null && other.Fingerprint == null) || (this.Fingerprint?.Equals(other.Fingerprint) == true)) &&
                ((this.CardType == null && other.CardType == null) || (this.CardType?.Equals(other.CardType) == true)) &&
                ((this.PrepaidType == null && other.PrepaidType == null) || (this.PrepaidType?.Equals(other.PrepaidType) == true)) &&
                ((this.Bin == null && other.Bin == null) || (this.Bin?.Equals(other.Bin) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1370361237;

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.CardBrand != null)
            {
               hashCode += this.CardBrand.GetHashCode();
            }

            if (this.Last4 != null)
            {
               hashCode += this.Last4.GetHashCode();
            }

            if (this.ExpMonth != null)
            {
               hashCode += this.ExpMonth.GetHashCode();
            }

            if (this.ExpYear != null)
            {
               hashCode += this.ExpYear.GetHashCode();
            }

            if (this.CardholderName != null)
            {
               hashCode += this.CardholderName.GetHashCode();
            }

            if (this.BillingAddress != null)
            {
               hashCode += this.BillingAddress.GetHashCode();
            }

            if (this.Fingerprint != null)
            {
               hashCode += this.Fingerprint.GetHashCode();
            }

            if (this.CardType != null)
            {
               hashCode += this.CardType.GetHashCode();
            }

            if (this.PrepaidType != null)
            {
               hashCode += this.PrepaidType.GetHashCode();
            }

            if (this.Bin != null)
            {
               hashCode += this.Bin.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.CardBrand = {(this.CardBrand == null ? "null" : this.CardBrand.ToString())}");
            toStringOutput.Add($"this.Last4 = {(this.Last4 == null ? "null" : this.Last4 == string.Empty ? "" : this.Last4)}");
            toStringOutput.Add($"this.ExpMonth = {(this.ExpMonth == null ? "null" : this.ExpMonth.ToString())}");
            toStringOutput.Add($"this.ExpYear = {(this.ExpYear == null ? "null" : this.ExpYear.ToString())}");
            toStringOutput.Add($"this.CardholderName = {(this.CardholderName == null ? "null" : this.CardholderName == string.Empty ? "" : this.CardholderName)}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.Fingerprint = {(this.Fingerprint == null ? "null" : this.Fingerprint == string.Empty ? "" : this.Fingerprint)}");
            toStringOutput.Add($"this.CardType = {(this.CardType == null ? "null" : this.CardType.ToString())}");
            toStringOutput.Add($"this.PrepaidType = {(this.PrepaidType == null ? "null" : this.PrepaidType.ToString())}");
            toStringOutput.Add($"this.Bin = {(this.Bin == null ? "null" : this.Bin == string.Empty ? "" : this.Bin)}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Id(this.Id)
                .CardBrand(this.CardBrand)
                .Last4(this.Last4)
                .ExpMonth(this.ExpMonth)
                .ExpYear(this.ExpYear)
                .CardholderName(this.CardholderName)
                .BillingAddress(this.BillingAddress)
                .Fingerprint(this.Fingerprint)
                .CardType(this.CardType)
                .PrepaidType(this.PrepaidType)
                .Bin(this.Bin);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string id;
            private string cardBrand;
            private string last4;
            private long? expMonth;
            private long? expYear;
            private string cardholderName;
            private Models.Address billingAddress;
            private string fingerprint;
            private string cardType;
            private string prepaidType;
            private string bin;

             /// <summary>
             /// Id.
             /// </summary>
             /// <param name="id"> id. </param>
             /// <returns> Builder. </returns>
            public Builder Id(string id)
            {
                this.id = id;
                return this;
            }

             /// <summary>
             /// CardBrand.
             /// </summary>
             /// <param name="cardBrand"> cardBrand. </param>
             /// <returns> Builder. </returns>
            public Builder CardBrand(string cardBrand)
            {
                this.cardBrand = cardBrand;
                return this;
            }

             /// <summary>
             /// Last4.
             /// </summary>
             /// <param name="last4"> last4. </param>
             /// <returns> Builder. </returns>
            public Builder Last4(string last4)
            {
                this.last4 = last4;
                return this;
            }

             /// <summary>
             /// ExpMonth.
             /// </summary>
             /// <param name="expMonth"> expMonth. </param>
             /// <returns> Builder. </returns>
            public Builder ExpMonth(long? expMonth)
            {
                this.expMonth = expMonth;
                return this;
            }

             /// <summary>
             /// ExpYear.
             /// </summary>
             /// <param name="expYear"> expYear. </param>
             /// <returns> Builder. </returns>
            public Builder ExpYear(long? expYear)
            {
                this.expYear = expYear;
                return this;
            }

             /// <summary>
             /// CardholderName.
             /// </summary>
             /// <param name="cardholderName"> cardholderName. </param>
             /// <returns> Builder. </returns>
            public Builder CardholderName(string cardholderName)
            {
                this.cardholderName = cardholderName;
                return this;
            }

             /// <summary>
             /// BillingAddress.
             /// </summary>
             /// <param name="billingAddress"> billingAddress. </param>
             /// <returns> Builder. </returns>
            public Builder BillingAddress(Models.Address billingAddress)
            {
                this.billingAddress = billingAddress;
                return this;
            }

             /// <summary>
             /// Fingerprint.
             /// </summary>
             /// <param name="fingerprint"> fingerprint. </param>
             /// <returns> Builder. </returns>
            public Builder Fingerprint(string fingerprint)
            {
                this.fingerprint = fingerprint;
                return this;
            }

             /// <summary>
             /// CardType.
             /// </summary>
             /// <param name="cardType"> cardType. </param>
             /// <returns> Builder. </returns>
            public Builder CardType(string cardType)
            {
                this.cardType = cardType;
                return this;
            }

             /// <summary>
             /// PrepaidType.
             /// </summary>
             /// <param name="prepaidType"> prepaidType. </param>
             /// <returns> Builder. </returns>
            public Builder PrepaidType(string prepaidType)
            {
                this.prepaidType = prepaidType;
                return this;
            }

             /// <summary>
             /// Bin.
             /// </summary>
             /// <param name="bin"> bin. </param>
             /// <returns> Builder. </returns>
            public Builder Bin(string bin)
            {
                this.bin = bin;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> Card. </returns>
            public Card Build()
            {
                return new Card(
                    this.id,
                    this.cardBrand,
                    this.last4,
                    this.expMonth,
                    this.expYear,
                    this.cardholderName,
                    this.billingAddress,
                    this.fingerprint,
                    this.cardType,
                    this.prepaidType,
                    this.bin);
            }
        }
    }
}