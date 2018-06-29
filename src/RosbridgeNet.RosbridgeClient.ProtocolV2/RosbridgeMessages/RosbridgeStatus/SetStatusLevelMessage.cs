﻿namespace RosbridgeNet.RosbridgeClient.ProtocolV2.RosbridgeMessages.RosbridgeStatus
{
    using System.Runtime.Serialization;
    using Enums;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [DataContract]
    public class SetStatusLevelMessage : RosbridgeMessageBase
    {
        [DataMember(Name = "id", IsRequired = false)]
        public string Id { get; set; }

        [DataMember(Name = "level", IsRequired = true)]
        [JsonConverter(typeof(StringEnumConverter))]
        public StatusMessageLevel StatusLevel { get; set; }

        public SetStatusLevelMessage() : base("set_level")
        {
        }

        protected SetStatusLevelMessage(string operation) : base(operation)
        {
        }
    }
}
