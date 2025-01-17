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
    /// Invoice.
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="version">version.</param>
        /// <param name="locationId">location_id.</param>
        /// <param name="orderId">order_id.</param>
        /// <param name="primaryRecipient">primary_recipient.</param>
        /// <param name="paymentRequests">payment_requests.</param>
        /// <param name="deliveryMethod">delivery_method.</param>
        /// <param name="invoiceNumber">invoice_number.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="scheduledAt">scheduled_at.</param>
        /// <param name="publicUrl">public_url.</param>
        /// <param name="nextPaymentAmountMoney">next_payment_amount_money.</param>
        /// <param name="status">status.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="acceptedPaymentMethods">accepted_payment_methods.</param>
        /// <param name="customFields">custom_fields.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        public Invoice(
            string id = null,
            int? version = null,
            string locationId = null,
            string orderId = null,
            Models.InvoiceRecipient primaryRecipient = null,
            IList<Models.InvoicePaymentRequest> paymentRequests = null,
            string deliveryMethod = null,
            string invoiceNumber = null,
            string title = null,
            string description = null,
            string scheduledAt = null,
            string publicUrl = null,
            Models.Money nextPaymentAmountMoney = null,
            string status = null,
            string timezone = null,
            string createdAt = null,
            string updatedAt = null,
            Models.InvoiceAcceptedPaymentMethods acceptedPaymentMethods = null,
            IList<Models.InvoiceCustomField> customFields = null,
            string subscriptionId = null)
        {
            this.Id = id;
            this.Version = version;
            this.LocationId = locationId;
            this.OrderId = orderId;
            this.PrimaryRecipient = primaryRecipient;
            this.PaymentRequests = paymentRequests;
            this.DeliveryMethod = deliveryMethod;
            this.InvoiceNumber = invoiceNumber;
            this.Title = title;
            this.Description = description;
            this.ScheduledAt = scheduledAt;
            this.PublicUrl = publicUrl;
            this.NextPaymentAmountMoney = nextPaymentAmountMoney;
            this.Status = status;
            this.Timezone = timezone;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.AcceptedPaymentMethods = acceptedPaymentMethods;
            this.CustomFields = customFields;
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// The Square-assigned ID of the invoice.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; }

        /// <summary>
        /// The Square-assigned version number, which is incremented each time an update is committed to the invoice.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; }

        /// <summary>
        /// The ID of the location that this invoice is associated with.
        /// This field is required when creating an invoice.
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; }

        /// <summary>
        /// The ID of the [order]($m/Order) for which the invoice is created.
        /// This order must be in the `OPEN` state and must belong to the `location_id`
        /// specified for this invoice. This field is required when creating an invoice.
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; }

        /// <summary>
        /// Provides customer data that Square uses to deliver an invoice.
        /// </summary>
        [JsonProperty("primary_recipient", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceRecipient PrimaryRecipient { get; }

        /// <summary>
        /// The payment schedule for the invoice, represented by one or more payment requests that
        /// define payment settings, such as amount due and due date. You can specify a maximum of 13
        /// payment requests, with up to 12 `INSTALLMENT` request types. For more information, see
        /// [Payment requests](https://developer.squareup.com/docs/invoices-api/overview#payment-requests).
        /// This field is required when creating an invoice. It must contain at least one payment request.
        /// </summary>
        [JsonProperty("payment_requests", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.InvoicePaymentRequest> PaymentRequests { get; }

        /// <summary>
        /// Indicates how Square delivers the [invoice]($m/Invoice) to the customer.
        /// </summary>
        [JsonProperty("delivery_method", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveryMethod { get; }

        /// <summary>
        /// A user-friendly invoice number. The value is unique within a location.
        /// If not provided when creating an invoice, Square assigns a value.
        /// It increments from 1 and padded with zeros making it 7 characters long
        /// (for example, 0000001 and 0000002).
        /// </summary>
        [JsonProperty("invoice_number", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceNumber { get; }

        /// <summary>
        /// The title of the invoice.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; }

        /// <summary>
        /// The description of the invoice. This is visible to the customer receiving the invoice.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; }

        /// <summary>
        /// The timestamp when the invoice is scheduled for processing, in RFC 3339 format.
        /// After the invoice is published, Square processes the invoice on the specified date,
        /// according to the delivery method and payment request settings.
        /// If the field is not set, Square processes the invoice immediately after it is published.
        /// </summary>
        [JsonProperty("scheduled_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledAt { get; }

        /// <summary>
        /// The URL of the Square-hosted invoice page.
        /// After you publish the invoice using the `PublishInvoice` endpoint, Square hosts the invoice
        /// page and returns the page URL in the response.
        /// </summary>
        [JsonProperty("public_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicUrl { get; }

        /// <summary>
        /// Represents an amount of money. `Money` fields can be signed or unsigned.
        /// Fields that do not explicitly define whether they are signed or unsigned are
        /// considered unsigned and can only hold positive amounts. For signed fields, the
        /// sign of the value indicates the purpose of the money transfer. See
        /// [Working with Monetary Amounts](https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts)
        /// for more information.
        /// </summary>
        [JsonProperty("next_payment_amount_money", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Money NextPaymentAmountMoney { get; }

        /// <summary>
        /// Indicates the status of an invoice.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; }

        /// <summary>
        /// The time zone used to interpret calendar dates on the invoice, such as `due_date`.
        /// When an invoice is created, this field is set to the `timezone` specified for the seller
        /// location. The value cannot be changed.
        /// For example, a payment `due_date` of 2021-03-09 with a `timezone` of America/Los\_Angeles
        /// becomes overdue at midnight on March 9 in America/Los\_Angeles (which equals a UTC timestamp
        /// of 2021-03-10T08:00:00Z).
        /// </summary>
        [JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
        public string Timezone { get; }

        /// <summary>
        /// The timestamp when the invoice was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; }

        /// <summary>
        /// The timestamp when the invoice was last updated, in RFC 3339 format.
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; }

        /// <summary>
        /// The payment methods that customers can use to pay an invoice on the Square-hosted invoice page.
        /// </summary>
        [JsonProperty("accepted_payment_methods", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceAcceptedPaymentMethods AcceptedPaymentMethods { get; }

        /// <summary>
        /// Additional seller-defined fields to render on the invoice. These fields are visible to sellers and buyers
        /// on the Square-hosted invoice page and in emailed or PDF copies of invoices. For more information, see
        /// [Custom fields](https://developer.squareup.com/docs/invoices-api/overview#custom-fields).
        /// Max: 2 custom fields
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.InvoiceCustomField> CustomFields { get; }

        /// <summary>
        /// The ID of the [subscription]($m/Subscription) associated with the invoice.
        /// This field is present only on subscription billing invoices.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Invoice : ({string.Join(", ", toStringOutput)})";
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

            return obj is Invoice other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                ((this.OrderId == null && other.OrderId == null) || (this.OrderId?.Equals(other.OrderId) == true)) &&
                ((this.PrimaryRecipient == null && other.PrimaryRecipient == null) || (this.PrimaryRecipient?.Equals(other.PrimaryRecipient) == true)) &&
                ((this.PaymentRequests == null && other.PaymentRequests == null) || (this.PaymentRequests?.Equals(other.PaymentRequests) == true)) &&
                ((this.DeliveryMethod == null && other.DeliveryMethod == null) || (this.DeliveryMethod?.Equals(other.DeliveryMethod) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ScheduledAt == null && other.ScheduledAt == null) || (this.ScheduledAt?.Equals(other.ScheduledAt) == true)) &&
                ((this.PublicUrl == null && other.PublicUrl == null) || (this.PublicUrl?.Equals(other.PublicUrl) == true)) &&
                ((this.NextPaymentAmountMoney == null && other.NextPaymentAmountMoney == null) || (this.NextPaymentAmountMoney?.Equals(other.NextPaymentAmountMoney) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Timezone == null && other.Timezone == null) || (this.Timezone?.Equals(other.Timezone) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.AcceptedPaymentMethods == null && other.AcceptedPaymentMethods == null) || (this.AcceptedPaymentMethods?.Equals(other.AcceptedPaymentMethods) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1880042028;

            if (this.Id != null)
            {
               hashCode += this.Id.GetHashCode();
            }

            if (this.Version != null)
            {
               hashCode += this.Version.GetHashCode();
            }

            if (this.LocationId != null)
            {
               hashCode += this.LocationId.GetHashCode();
            }

            if (this.OrderId != null)
            {
               hashCode += this.OrderId.GetHashCode();
            }

            if (this.PrimaryRecipient != null)
            {
               hashCode += this.PrimaryRecipient.GetHashCode();
            }

            if (this.PaymentRequests != null)
            {
               hashCode += this.PaymentRequests.GetHashCode();
            }

            if (this.DeliveryMethod != null)
            {
               hashCode += this.DeliveryMethod.GetHashCode();
            }

            if (this.InvoiceNumber != null)
            {
               hashCode += this.InvoiceNumber.GetHashCode();
            }

            if (this.Title != null)
            {
               hashCode += this.Title.GetHashCode();
            }

            if (this.Description != null)
            {
               hashCode += this.Description.GetHashCode();
            }

            if (this.ScheduledAt != null)
            {
               hashCode += this.ScheduledAt.GetHashCode();
            }

            if (this.PublicUrl != null)
            {
               hashCode += this.PublicUrl.GetHashCode();
            }

            if (this.NextPaymentAmountMoney != null)
            {
               hashCode += this.NextPaymentAmountMoney.GetHashCode();
            }

            if (this.Status != null)
            {
               hashCode += this.Status.GetHashCode();
            }

            if (this.Timezone != null)
            {
               hashCode += this.Timezone.GetHashCode();
            }

            if (this.CreatedAt != null)
            {
               hashCode += this.CreatedAt.GetHashCode();
            }

            if (this.UpdatedAt != null)
            {
               hashCode += this.UpdatedAt.GetHashCode();
            }

            if (this.AcceptedPaymentMethods != null)
            {
               hashCode += this.AcceptedPaymentMethods.GetHashCode();
            }

            if (this.CustomFields != null)
            {
               hashCode += this.CustomFields.GetHashCode();
            }

            if (this.SubscriptionId != null)
            {
               hashCode += this.SubscriptionId.GetHashCode();
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
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version.ToString())}");
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId == string.Empty ? "" : this.LocationId)}");
            toStringOutput.Add($"this.OrderId = {(this.OrderId == null ? "null" : this.OrderId == string.Empty ? "" : this.OrderId)}");
            toStringOutput.Add($"this.PrimaryRecipient = {(this.PrimaryRecipient == null ? "null" : this.PrimaryRecipient.ToString())}");
            toStringOutput.Add($"this.PaymentRequests = {(this.PaymentRequests == null ? "null" : $"[{string.Join(", ", this.PaymentRequests)} ]")}");
            toStringOutput.Add($"this.DeliveryMethod = {(this.DeliveryMethod == null ? "null" : this.DeliveryMethod.ToString())}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber == string.Empty ? "" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
            toStringOutput.Add($"this.ScheduledAt = {(this.ScheduledAt == null ? "null" : this.ScheduledAt == string.Empty ? "" : this.ScheduledAt)}");
            toStringOutput.Add($"this.PublicUrl = {(this.PublicUrl == null ? "null" : this.PublicUrl == string.Empty ? "" : this.PublicUrl)}");
            toStringOutput.Add($"this.NextPaymentAmountMoney = {(this.NextPaymentAmountMoney == null ? "null" : this.NextPaymentAmountMoney.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Timezone = {(this.Timezone == null ? "null" : this.Timezone == string.Empty ? "" : this.Timezone)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt == string.Empty ? "" : this.UpdatedAt)}");
            toStringOutput.Add($"this.AcceptedPaymentMethods = {(this.AcceptedPaymentMethods == null ? "null" : this.AcceptedPaymentMethods.ToString())}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId == string.Empty ? "" : this.SubscriptionId)}");
        }

        /// <summary>
        /// Converts to builder object.
        /// </summary>
        /// <returns> Builder. </returns>
        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Id(this.Id)
                .Version(this.Version)
                .LocationId(this.LocationId)
                .OrderId(this.OrderId)
                .PrimaryRecipient(this.PrimaryRecipient)
                .PaymentRequests(this.PaymentRequests)
                .DeliveryMethod(this.DeliveryMethod)
                .InvoiceNumber(this.InvoiceNumber)
                .Title(this.Title)
                .Description(this.Description)
                .ScheduledAt(this.ScheduledAt)
                .PublicUrl(this.PublicUrl)
                .NextPaymentAmountMoney(this.NextPaymentAmountMoney)
                .Status(this.Status)
                .Timezone(this.Timezone)
                .CreatedAt(this.CreatedAt)
                .UpdatedAt(this.UpdatedAt)
                .AcceptedPaymentMethods(this.AcceptedPaymentMethods)
                .CustomFields(this.CustomFields)
                .SubscriptionId(this.SubscriptionId);
            return builder;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string id;
            private int? version;
            private string locationId;
            private string orderId;
            private Models.InvoiceRecipient primaryRecipient;
            private IList<Models.InvoicePaymentRequest> paymentRequests;
            private string deliveryMethod;
            private string invoiceNumber;
            private string title;
            private string description;
            private string scheduledAt;
            private string publicUrl;
            private Models.Money nextPaymentAmountMoney;
            private string status;
            private string timezone;
            private string createdAt;
            private string updatedAt;
            private Models.InvoiceAcceptedPaymentMethods acceptedPaymentMethods;
            private IList<Models.InvoiceCustomField> customFields;
            private string subscriptionId;

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
             /// Version.
             /// </summary>
             /// <param name="version"> version. </param>
             /// <returns> Builder. </returns>
            public Builder Version(int? version)
            {
                this.version = version;
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
             /// OrderId.
             /// </summary>
             /// <param name="orderId"> orderId. </param>
             /// <returns> Builder. </returns>
            public Builder OrderId(string orderId)
            {
                this.orderId = orderId;
                return this;
            }

             /// <summary>
             /// PrimaryRecipient.
             /// </summary>
             /// <param name="primaryRecipient"> primaryRecipient. </param>
             /// <returns> Builder. </returns>
            public Builder PrimaryRecipient(Models.InvoiceRecipient primaryRecipient)
            {
                this.primaryRecipient = primaryRecipient;
                return this;
            }

             /// <summary>
             /// PaymentRequests.
             /// </summary>
             /// <param name="paymentRequests"> paymentRequests. </param>
             /// <returns> Builder. </returns>
            public Builder PaymentRequests(IList<Models.InvoicePaymentRequest> paymentRequests)
            {
                this.paymentRequests = paymentRequests;
                return this;
            }

             /// <summary>
             /// DeliveryMethod.
             /// </summary>
             /// <param name="deliveryMethod"> deliveryMethod. </param>
             /// <returns> Builder. </returns>
            public Builder DeliveryMethod(string deliveryMethod)
            {
                this.deliveryMethod = deliveryMethod;
                return this;
            }

             /// <summary>
             /// InvoiceNumber.
             /// </summary>
             /// <param name="invoiceNumber"> invoiceNumber. </param>
             /// <returns> Builder. </returns>
            public Builder InvoiceNumber(string invoiceNumber)
            {
                this.invoiceNumber = invoiceNumber;
                return this;
            }

             /// <summary>
             /// Title.
             /// </summary>
             /// <param name="title"> title. </param>
             /// <returns> Builder. </returns>
            public Builder Title(string title)
            {
                this.title = title;
                return this;
            }

             /// <summary>
             /// Description.
             /// </summary>
             /// <param name="description"> description. </param>
             /// <returns> Builder. </returns>
            public Builder Description(string description)
            {
                this.description = description;
                return this;
            }

             /// <summary>
             /// ScheduledAt.
             /// </summary>
             /// <param name="scheduledAt"> scheduledAt. </param>
             /// <returns> Builder. </returns>
            public Builder ScheduledAt(string scheduledAt)
            {
                this.scheduledAt = scheduledAt;
                return this;
            }

             /// <summary>
             /// PublicUrl.
             /// </summary>
             /// <param name="publicUrl"> publicUrl. </param>
             /// <returns> Builder. </returns>
            public Builder PublicUrl(string publicUrl)
            {
                this.publicUrl = publicUrl;
                return this;
            }

             /// <summary>
             /// NextPaymentAmountMoney.
             /// </summary>
             /// <param name="nextPaymentAmountMoney"> nextPaymentAmountMoney. </param>
             /// <returns> Builder. </returns>
            public Builder NextPaymentAmountMoney(Models.Money nextPaymentAmountMoney)
            {
                this.nextPaymentAmountMoney = nextPaymentAmountMoney;
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
             /// UpdatedAt.
             /// </summary>
             /// <param name="updatedAt"> updatedAt. </param>
             /// <returns> Builder. </returns>
            public Builder UpdatedAt(string updatedAt)
            {
                this.updatedAt = updatedAt;
                return this;
            }

             /// <summary>
             /// AcceptedPaymentMethods.
             /// </summary>
             /// <param name="acceptedPaymentMethods"> acceptedPaymentMethods. </param>
             /// <returns> Builder. </returns>
            public Builder AcceptedPaymentMethods(Models.InvoiceAcceptedPaymentMethods acceptedPaymentMethods)
            {
                this.acceptedPaymentMethods = acceptedPaymentMethods;
                return this;
            }

             /// <summary>
             /// CustomFields.
             /// </summary>
             /// <param name="customFields"> customFields. </param>
             /// <returns> Builder. </returns>
            public Builder CustomFields(IList<Models.InvoiceCustomField> customFields)
            {
                this.customFields = customFields;
                return this;
            }

             /// <summary>
             /// SubscriptionId.
             /// </summary>
             /// <param name="subscriptionId"> subscriptionId. </param>
             /// <returns> Builder. </returns>
            public Builder SubscriptionId(string subscriptionId)
            {
                this.subscriptionId = subscriptionId;
                return this;
            }

            /// <summary>
            /// Builds class object.
            /// </summary>
            /// <returns> Invoice. </returns>
            public Invoice Build()
            {
                return new Invoice(
                    this.id,
                    this.version,
                    this.locationId,
                    this.orderId,
                    this.primaryRecipient,
                    this.paymentRequests,
                    this.deliveryMethod,
                    this.invoiceNumber,
                    this.title,
                    this.description,
                    this.scheduledAt,
                    this.publicUrl,
                    this.nextPaymentAmountMoney,
                    this.status,
                    this.timezone,
                    this.createdAt,
                    this.updatedAt,
                    this.acceptedPaymentMethods,
                    this.customFields,
                    this.subscriptionId);
            }
        }
    }
}