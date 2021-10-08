﻿using Newtonsoft.Json;

namespace Okex.Net.RestObjects.Account
{
    public class OkexInterestRate
    {
        [JsonProperty("ccy")]
        public string Currency { get; set; }

        [JsonProperty("interestRate")]
        public decimal? InterestRate { get; set; }
    }
}
