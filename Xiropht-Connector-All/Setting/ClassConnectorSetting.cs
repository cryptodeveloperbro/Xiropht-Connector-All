﻿using System.Collections.Generic;

namespace Xiropht_Connector_All.Setting
{
    public class ClassConnectorSetting
    {
        public const int SeedNodePort = 18000;
        public const int RemoteNodePort = 18002;

        /// <summary>
        ///     UPDATES - First Major Update done at 10/08/2018
        /// </summary>
        public const bool
            MAJOR_UPDATE_1 =
                true; // Implementation of: Timestamp recv transaction (for wallet), link blockchain height for transaction, last block found.

        public const bool
            MAJOR_UPDATE_1_SECURITY = true; // Implementation of: Certificate for include a new layer of protection.

        public const int
            MAJOR_UPDATE_1_SECURITY_CERTIFICATE_SIZE =
                256; // Size of Certificate encryption [Between tools and seed nodes]

        public const string NETWORK_GENESIS_DEFAULT_KEY = "XIROPHTKEY"; // DEFAULT GENESIS KEY [Small static part of dynamic key encryption between tools and blockchain.]

        /// <summary>
        ///     UPDATES - Update done at 17/10/2018
        /// </summary>
        public static string
            NETWORK_GENESIS_KEY =
                "XIROPHTKEY"; // GENESIS KEY [Small static part of dynamic key encryption between tools and blockchain, updated by the blockchain in real time.]

        public const string
            NETWORK_GENESIS_SECONDARY_KEY =
                "XIROPHTSEED"; // GENESIS SECONDARY KEY [Layer encryption key include on dynamic certificate key between tools and seed nodes]

        public static List<string> SeedNodeIp = new List<string> {"87.98.156.228"};

        public const int MaxTimeoutConnect = 500;
        public const int MaxNetworkPacketSize = 8192;
        public const int MaxRemoteNodeInvalidPacket = 10;
        public const int MaxDelayRemoteNodeTrust = 60; // 60 seconds.
        public const string CoinName = "Xiropht";
        public const string CoinNameMin = "XIR";
        public const string NetworkPhase = "Private Test";
    }
}