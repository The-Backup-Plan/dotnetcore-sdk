﻿using Newtonsoft.Json;

namespace Thenewboston.Validator.Api.Models
{
    internal class UpgradeRequestMessage
    {
        [JsonProperty(PropertyName = "validator_node_identifier")]
        public string ValidatorNodeIdentifier { get; set; }
    }
}
