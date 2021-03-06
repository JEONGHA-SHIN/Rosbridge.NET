﻿namespace RosbridgeNet.RosbridgeClient.ProtocolV2.Interfaces
{
    using RosbridgeNet.RosbridgeClient.ProtocolV2.RosbridgeMessages.Enums;

    public interface IFragmentedMessageOperator
    {
        MessageCompressionLevel? MessageCompressionLevel { get; set; }

        int? FragmentSize { get; set; }
    }
}
