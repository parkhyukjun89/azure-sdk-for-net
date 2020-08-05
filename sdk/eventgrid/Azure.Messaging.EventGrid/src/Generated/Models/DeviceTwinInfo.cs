// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Information about the device twin, which is the cloud representation of application device metadata. </summary>
    public partial class DeviceTwinInfo
    {
        /// <summary> Initializes a new instance of DeviceTwinInfo. </summary>
        internal DeviceTwinInfo()
        {
        }

        /// <summary> Initializes a new instance of DeviceTwinInfo. </summary>
        /// <param name="authenticationType"> Authentication type used for this device: either SAS, SelfSigned, or CertificateAuthority. </param>
        /// <param name="cloudToDeviceMessageCount"> Count of cloud to device messages sent to this device. </param>
        /// <param name="connectionState"> Whether the device is connected or disconnected. </param>
        /// <param name="deviceId"> The unique identifier of the device twin. </param>
        /// <param name="etag"> A piece of information that describes the content of the device twin. Each etag is guaranteed to be unique per device twin. </param>
        /// <param name="lastActivityTime"> The ISO8601 timestamp of the last activity. </param>
        /// <param name="properties"> Properties JSON element. </param>
        /// <param name="status"> Whether the device twin is enabled or disabled. </param>
        /// <param name="statusUpdateTime"> The ISO8601 timestamp of the last device twin status update. </param>
        /// <param name="version"> An integer that is incremented by one each time the device twin is updated. </param>
        /// <param name="x509Thumbprint"> The thumbprint is a unique value for the x509 certificate, commonly used to find a particular certificate in a certificate store. The thumbprint is dynamically generated using the SHA1 algorithm, and does not physically exist in the certificate. </param>
        internal DeviceTwinInfo(string authenticationType, float? cloudToDeviceMessageCount, string connectionState, string deviceId, string etag, string lastActivityTime, DeviceTwinInfoProperties properties, string status, string statusUpdateTime, float? version, DeviceTwinInfoX509Thumbprint x509Thumbprint)
        {
            AuthenticationType = authenticationType;
            CloudToDeviceMessageCount = cloudToDeviceMessageCount;
            ConnectionState = connectionState;
            DeviceId = deviceId;
            Etag = etag;
            LastActivityTime = lastActivityTime;
            Properties = properties;
            Status = status;
            StatusUpdateTime = statusUpdateTime;
            Version = version;
            X509Thumbprint = x509Thumbprint;
        }

        /// <summary> Authentication type used for this device: either SAS, SelfSigned, or CertificateAuthority. </summary>
        public string AuthenticationType { get; }
        /// <summary> Count of cloud to device messages sent to this device. </summary>
        public float? CloudToDeviceMessageCount { get; }
        /// <summary> Whether the device is connected or disconnected. </summary>
        public string ConnectionState { get; }
        /// <summary> The unique identifier of the device twin. </summary>
        public string DeviceId { get; }
        /// <summary> A piece of information that describes the content of the device twin. Each etag is guaranteed to be unique per device twin. </summary>
        public string Etag { get; }
        /// <summary> The ISO8601 timestamp of the last activity. </summary>
        public string LastActivityTime { get; }
        /// <summary> Properties JSON element. </summary>
        public DeviceTwinInfoProperties Properties { get; }
        /// <summary> Whether the device twin is enabled or disabled. </summary>
        public string Status { get; }
        /// <summary> The ISO8601 timestamp of the last device twin status update. </summary>
        public string StatusUpdateTime { get; }
        /// <summary> An integer that is incremented by one each time the device twin is updated. </summary>
        public float? Version { get; }
        /// <summary> The thumbprint is a unique value for the x509 certificate, commonly used to find a particular certificate in a certificate store. The thumbprint is dynamically generated using the SHA1 algorithm, and does not physically exist in the certificate. </summary>
        public DeviceTwinInfoX509Thumbprint X509Thumbprint { get; }
    }
}