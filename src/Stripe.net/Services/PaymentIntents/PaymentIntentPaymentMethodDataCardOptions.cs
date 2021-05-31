namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataCardOptions : INestedOptions
    {
        /// <summary>
        /// If Secure Remote Commerce is needed.
        /// </summary>
        [JsonProperty("masterpass")]
        public PaymentIntentPaymentMethodDataCardMasterpassOptions Masterpass { get; set; }
    }
}
