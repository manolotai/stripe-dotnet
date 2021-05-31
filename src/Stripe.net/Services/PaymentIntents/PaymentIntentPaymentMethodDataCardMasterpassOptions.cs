namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataCardMasterpassOptions : INestedOptions
    {
        [JsonProperty("cart_id")]
        public string CartId { get; set; }

        /// <summary>
        /// Provided by the checkout as a query parameter <c>oauth_verifier</c>.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
