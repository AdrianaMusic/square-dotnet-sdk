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
    /// Subscription.
    /// </summary>
    public class Subscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="locationId">location_id.</param>
        /// <param name="planId">plan_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="canceledDate">canceled_date.</param>
        /// <param name="status">status.</param>
        /// <param name="taxPercentage">tax_percentage.</param>
        /// <param name="invoiceIds">invoice_ids.</param>
        /// <param name="priceOverrideMoney">price_override_money.</param>
        /// <param name="version">version.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="cardId">card_id.</param>
        /// <param name="paidUntilDate">paid_until_date.</param>
        /// <param name="timezone">timezone.</param>
        public Subscription(
            string id = null,
            string locationId = null,
            string planId = null,
            string customerId = null,
            string startDate = null,
            string canceledDate = null,
            string status = null,
            string taxPercentage = null,
            IList<string> invoiceIds = null,
            Models.Money priceOverrideMoney = null,
            long? version = null,
            string createdAt = null,
            string cardId = null,
            string paidUntilDate = null,
            string timezone = null)
        {
            this.Id = id;
            this.LocationId = locationId;
            this.PlanId = planId;
            this.CustomerId = customerId;
            this.StartDate = startDate;
            this.CanceledDate = canceledDate;
            this.Status = status;
            this.TaxPercentage = taxPercentage;
            this.InvoiceIds = invoiceIds;
            this.PriceOverrideMoney = priceOverrideMoney;
            this.Version = version;
            this.CreatedAt = createdAt;
            this.CardId = cardId;
            this.PaidUntilDate = paidUntilDate;
            this.Timezone = timezone;
        }

        /// <summary>
        /// The Square-assigned ID of the subscription.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; }

        /// <summary>
        /// The ID of the location associated with the subscription.
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; }

        /// <summary>
        /// The ID of the associated [subscription plan]($m/CatalogSubscriptionPlan).
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; }

        /// <summary>
        /// The ID of the associated [customer]($m/Customer) profile.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; }

        /// <summary>
        /// The start date of the subscription, in YYYY-MM-DD format (for example,
        /// 2013-01-15).
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; }

        /// <summary>
        /// The subscription cancellation date, in YYYY-MM-DD format (for
        /// example, 2013-01-15). On this date, the subscription status changes
        /// to `CANCELED` and the subscription billing stops.
        /// If you don't set this field, the subscription plan dictates if and
        /// when subscription ends.
        /// You cannot update this field, you can only clear it.
        /// </summary>
        [JsonProperty("canceled_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CanceledDate { get; }

        /// <summary>
        /// Possible subscription status values.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; }

        /// <summary>
        /// The tax amount applied when billing the subscription. The
        /// percentage is expressed in decimal form, using a `'.'` as the decimal
        /// separator and without a `'%'` sign. For example, a value of `7.5`
        /// corresponds to 7.5%.
        /// </summary>
        [JsonProperty("tax_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxPercentage { get; }

        /// <summary>
        /// The IDs of the [invoices]($m/Invoice) created for the
        /// subscription, listed in order when the invoices were created
        /// (oldest invoices appear first).
        /// </summary>
        [JsonProperty("invoice_ids", NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> InvoiceIds { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("price_override_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money PriceOverrideMoney { get; }

        /// <summary>
        /// The version of the object. When updating an object, the version
        /// supplied must match the version in the database, otherwise the write will
        /// be rejected as conflicting.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; }

        /// <summary>
        /// The timestamp when the subscription was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; }

        /// <summary>
        /// The ID of the [customer]($m/Customer) [card]($m/Card)
        /// that is charged for the subscription.
        /// </summary>
        [JsonProperty("card_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardId { get; }

        /// <summary>
        /// The date up to which the customer is invoiced for the
        /// subscription, in YYYY-MM-DD format (for example, 2013-01-15).
        /// After the invoice is paid for a given billing period,
        /// this date will be the last day of the billing period.
        /// For example,
        /// suppose for the month of May a customer gets an invoice
        /// (or charged the card) on May 1. For the monthly billing scenario,
        /// this date is then set to May 31.
        /// </summary>
        [JsonProperty("paid_until_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PaidUntilDate { get; }

        /// <summary>
        /// Timezone that will be used in date calculations for the subscription.
        /// Defaults to the timezone of the location based on `location_id`.
        /// Format: the IANA Timezone Database identifier for the location timezone (for example, `America/Los_Angeles`).
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Subscription : ({string.Join(", ", toStringOutput)})";
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

            return obj is Subscription other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                ((this.PlanId == null && other.PlanId == null) || (this.PlanId?.Equals(other.PlanId) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.CanceledDate == null && other.CanceledDate == null) || (this.CanceledDate?.Equals(other.CanceledDate) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.TaxPercentage == null && other.TaxPercentage == null) || (this.TaxPercentage?.Equals(other.TaxPercentage) == true)) &&
                ((this.InvoiceIds == null && other.InvoiceIds == null) || (this.InvoiceIds?.Equals(other.InvoiceIds) == true)) &&
                ((this.PriceOverrideMoney == null && other.PriceOverrideMoney == null) || (this.PriceOverrideMoney?.Equals(other.PriceOverrideMoney) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.PaidUntilDate == null && other.PaidUntilDate == null) || (this.PaidUntilDate?.Equals(other.PaidUntilDate) == true)) &&
                ((this.Timezone == null && other.Timezone == null) || (this.Timezone?.Equals(other.Timezone) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1265150766;

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.LocationId != null)
            {
               hashCode += this.LocationId.GetHashCode();
            }

            if (this.PlanId != null)
            {
               hashCode += this.PlanId.GetHashCode();
            }

            if (this.CustomerId != null)
            {
               hashCode += this.CustomerId.GetHashCode();
            }

            if (this.StartDate != null)
            {
               hashCode += this.StartDate.GetHashCode();
            }

            if (this.CanceledDate != null)
            {
               hashCode += this.CanceledDate.GetHashCode();
            }

            if (this.Status != null)
            {
               hashCode += this.Status.GetHashCode();
            }

            if (this.TaxPercentage != null)
            {
               hashCode += this.TaxPercentage.GetHashCode();
            }

            if (this.InvoiceIds != null)
            {
               hashCode += this.InvoiceIds.GetHashCode();
            }

            if (this.PriceOverrideMoney != null)
            {
               hashCode += this.PriceOverrideMoney.GetHashCode();
            }

            if (this.Version != null)
            {
               hashCode += this.Version.GetHashCode();
            }

            if (this.CreatedAt != null)
            {
               hashCode += this.CreatedAt.GetHashCode();
            }

            if (this.CardId != null)
            {
               hashCode += this.CardId.GetHashCode();
            }

            if (this.PaidUntilDate != null)
            {
               hashCode += this.PaidUntilDate.GetHashCode();
            }

            if (this.Timezone != null)
            {
               hashCode += this.Timezone.GetHashCode();
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
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId == string.Empty ? "" : this.LocationId)}");
            toStringOutput.Add($"this.PlanId = {(this.PlanId == null ? "null" : this.PlanId == string.Empty ? "" : this.PlanId)}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId == string.Empty ? "" : this.CustomerId)}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate == string.Empty ? "" : this.StartDate)}");
            toStringOutput.Add($"this.CanceledDate = {(this.CanceledDate == null ? "null" : this.CanceledDate == string.Empty ? "" : this.CanceledDate)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.TaxPercentage = {(this.TaxPercentage == null ? "null" : this.TaxPercentage == string.Empty ? "" : this.TaxPercentage)}");
            toStringOutput.Add($"this.InvoiceIds = {(this.InvoiceIds == null ? "null" : $"[{string.Join(", ", this.InvoiceIds)} ]")}");
            toStringOutput.Add($"this.PriceOverrideMoney = {(this.PriceOverrideMoney == null ? "null" : this.PriceOverrideMoney.ToString())}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId == string.Empty ? "" : this.CardId)}");
            toStringOutput.Add($"this.PaidUntilDate = {(this.PaidUntilDate == null ? "null" : this.PaidUntilDate == string.Empty ? "" : this.PaidUntilDate)}");
            toStringOutput.Add($"this.Timezone = {(this.Timezone == null ? "null" : this.Timezone == string.Empty ? "" : this.Timezone)}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Id(this.Id)
                .LocationId(this.LocationId)
                .PlanId(this.PlanId)
                .CustomerId(this.CustomerId)
                .StartDate(this.StartDate)
                .CanceledDate(this.CanceledDate)
                .Status(this.Status)
                .TaxPercentage(this.TaxPercentage)
                .InvoiceIds(this.InvoiceIds)
                .PriceOverrideMoney(this.PriceOverrideMoney)
                .Version(this.Version)
                .CreatedAt(this.CreatedAt)
                .CardId(this.CardId)
                .PaidUntilDate(this.PaidUntilDate)
                .Timezone(this.Timezone);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string id;
            private string locationId;
            private string planId;
            private string customerId;
            private string startDate;
            private string canceledDate;
            private string status;
            private string taxPercentage;
            private IList<string> invoiceIds;
            private Models.Money priceOverrideMoney;
            private long? version;
            private string createdAt;
            private string cardId;
            private string paidUntilDate;
            private string timezone;

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
             /// LocationId.
             /// </summary>
             /// <param name="locationId"> locationId. </param>
             /// <returns> Builder. </returns>
            public Builder LocationId(string locationId)
            {
                this.locationId = locationId;
                return this;
            }

             /// <summary>
             /// PlanId.
             /// </summary>
             /// <param name="planId"> planId. </param>
             /// <returns> Builder. </returns>
            public Builder PlanId(string planId)
            {
                this.planId = planId;
                return this;
            }

             /// <summary>
             /// CustomerId.
             /// </summary>
             /// <param name="customerId"> customerId. </param>
             /// <returns> Builder. </returns>
            public Builder CustomerId(string customerId)
            {
                this.customerId = customerId;
                return this;
            }

             /// <summary>
             /// StartDate.
             /// </summary>
             /// <param name="startDate"> startDate. </param>
             /// <returns> Builder. </returns>
            public Builder StartDate(string startDate)
            {
                this.startDate = startDate;
                return this;
            }

             /// <summary>
             /// CanceledDate.
             /// </summary>
             /// <param name="canceledDate"> canceledDate. </param>
             /// <returns> Builder. </returns>
            public Builder CanceledDate(string canceledDate)
            {
                this.canceledDate = canceledDate;
                return this;
            }

             /// <summary>
             /// Status.
             /// </summary>
             /// <param name="status"> status. </param>
             /// <returns> Builder. </returns>
            public Builder Status(string status)
            {
                this.status = status;
                return this;
            }

             /// <summary>
             /// TaxPercentage.
             /// </summary>
             /// <param name="taxPercentage"> taxPercentage. </param>
             /// <returns> Builder. </returns>
            public Builder TaxPercentage(string taxPercentage)
            {
                this.taxPercentage = taxPercentage;
                return this;
            }

             /// <summary>
             /// InvoiceIds.
             /// </summary>
             /// <param name="invoiceIds"> invoiceIds. </param>
             /// <returns> Builder. </returns>
            public Builder InvoiceIds(IList<string> invoiceIds)
            {
                this.invoiceIds = invoiceIds;
                return this;
            }

             /// <summary>
             /// PriceOverrideMoney.
             /// </summary>
             /// <param name="priceOverrideMoney"> priceOverrideMoney. </param>
             /// <returns> Builder. </returns>
            public Builder PriceOverrideMoney(Models.Money priceOverrideMoney)
            {
                this.priceOverrideMoney = priceOverrideMoney;
                return this;
            }

             /// <summary>
             /// Version.
             /// </summary>
             /// <param name="version"> version. </param>
             /// <returns> Builder. </returns>
            public Builder Version(long? version)
            {
                this.version = version;
                return this;
            }

             /// <summary>
             /// CreatedAt.
             /// </summary>
             /// <param name="createdAt"> createdAt. </param>
             /// <returns> Builder. </returns>
            public Builder CreatedAt(string createdAt)
            {
                this.createdAt = createdAt;
                return this;
            }

             /// <summary>
             /// CardId.
             /// </summary>
             /// <param name="cardId"> cardId. </param>
             /// <returns> Builder. </returns>
            public Builder CardId(string cardId)
            {
                this.cardId = cardId;
                return this;
            }

             /// <summary>
             /// PaidUntilDate.
             /// </summary>
             /// <param name="paidUntilDate"> paidUntilDate. </param>
             /// <returns> Builder. </returns>
            public Builder PaidUntilDate(string paidUntilDate)
            {
                this.paidUntilDate = paidUntilDate;
                return this;
            }

             /// <summary>
             /// Timezone.
             /// </summary>
             /// <param name="timezone"> timezone. </param>
             /// <returns> Builder. </returns>
            public Builder Timezone(string timezone)
            {
                this.timezone = timezone;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> Subscription. </returns>
            public Subscription Build()
            {
                return new Subscription(
                    this.id,
                    this.locationId,
                    this.planId,
                    this.customerId,
                    this.startDate,
                    this.canceledDate,
                    this.status,
                    this.taxPercentage,
                    this.invoiceIds,
                    this.priceOverrideMoney,
                    this.version,
                    this.createdAt,
                    this.cardId,
                    this.paidUntilDate,
                    this.timezone);
            }
        }
    }
}