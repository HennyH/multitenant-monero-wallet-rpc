using System.Text.Json.Serialization;

namespace MoneroPay.API.Models.Monero
{
    public class GetAddressRpcParameters
    {
        public GetAddressRpcParameters(ulong accountIndex, ulong[]? addressIndex = null)
        {
            this.AccountIndex = accountIndex;
            this.AddressIndex = addressIndex;
        }

        [JsonPropertyName("account_index")]
        public ulong AccountIndex { get; set; }

        [JsonPropertyName("address_index")]
        public ulong[]? AddressIndex { get; set; }
    }
}