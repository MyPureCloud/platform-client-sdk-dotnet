using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// TrunkBaseMetrics
    /// </summary>
    [DataContract]
    public partial class TrunkBaseMetrics :  IEquatable<TrunkBaseMetrics>
    {
        /// <summary>
        /// The type of the TrunkBase
        /// </summary>
        /// <value>The type of the TrunkBase</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TrunkTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum External for "EXTERNAL"
            /// </summary>
            [EnumMember(Value = "EXTERNAL")]
            External,
            
            /// <summary>
            /// Enum Phone for "PHONE"
            /// </summary>
            [EnumMember(Value = "PHONE")]
            Phone,
            
            /// <summary>
            /// Enum Edge for "EDGE"
            /// </summary>
            [EnumMember(Value = "EDGE")]
            Edge
        }
        /// <summary>
        /// The type of the TrunkBase
        /// </summary>
        /// <value>The type of the TrunkBase</value>
        [DataMember(Name="trunkType", EmitDefaultValue=false)]
        public TrunkTypeEnum? TrunkType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkBaseMetrics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrunkBaseMetrics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunkBaseMetrics" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="TrunkBase">TrunkBase resource identifier (required).</param>
        /// <param name="TrunkType">The type of the TrunkBase.</param>
        /// <param name="InboundCallCount">The number of inbound calls.</param>
        /// <param name="OutboundCallCount">The number of outbound calls.</param>
        /// <param name="EventTime">The timestamp of the data publication. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="QosMismatchCount">The number of QoS mismatch events.</param>
        public TrunkBaseMetrics(string Name = null, AddressableEntityRef TrunkBase = null, TrunkTypeEnum? TrunkType = null, int? InboundCallCount = null, int? OutboundCallCount = null, DateTime? EventTime = null, int? QosMismatchCount = null)
        {
            this.Name = Name;
            this.TrunkBase = TrunkBase;
            this.TrunkType = TrunkType;
            this.InboundCallCount = InboundCallCount;
            this.OutboundCallCount = OutboundCallCount;
            this.EventTime = EventTime;
            this.QosMismatchCount = QosMismatchCount;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// TrunkBase resource identifier
        /// </summary>
        /// <value>TrunkBase resource identifier</value>
        [DataMember(Name="trunkBase", EmitDefaultValue=false)]
        public AddressableEntityRef TrunkBase { get; set; }





        /// <summary>
        /// The number of inbound calls
        /// </summary>
        /// <value>The number of inbound calls</value>
        [DataMember(Name="inboundCallCount", EmitDefaultValue=false)]
        public int? InboundCallCount { get; set; }



        /// <summary>
        /// The number of outbound calls
        /// </summary>
        /// <value>The number of outbound calls</value>
        [DataMember(Name="outboundCallCount", EmitDefaultValue=false)]
        public int? OutboundCallCount { get; set; }



        /// <summary>
        /// The timestamp of the data publication. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The timestamp of the data publication. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }



        /// <summary>
        /// The number of QoS mismatch events
        /// </summary>
        /// <value>The number of QoS mismatch events</value>
        [DataMember(Name="qosMismatchCount", EmitDefaultValue=false)]
        public int? QosMismatchCount { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrunkBaseMetrics {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TrunkBase: ").Append(TrunkBase).Append("\n");
            sb.Append("  TrunkType: ").Append(TrunkType).Append("\n");
            sb.Append("  InboundCallCount: ").Append(InboundCallCount).Append("\n");
            sb.Append("  OutboundCallCount: ").Append(OutboundCallCount).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  QosMismatchCount: ").Append(QosMismatchCount).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TrunkBaseMetrics);
        }

        /// <summary>
        /// Returns true if TrunkBaseMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of TrunkBaseMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrunkBaseMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.TrunkBase == other.TrunkBase ||
                    this.TrunkBase != null &&
                    this.TrunkBase.Equals(other.TrunkBase)
                ) &&
                (
                    this.TrunkType == other.TrunkType ||
                    this.TrunkType != null &&
                    this.TrunkType.Equals(other.TrunkType)
                ) &&
                (
                    this.InboundCallCount == other.InboundCallCount ||
                    this.InboundCallCount != null &&
                    this.InboundCallCount.Equals(other.InboundCallCount)
                ) &&
                (
                    this.OutboundCallCount == other.OutboundCallCount ||
                    this.OutboundCallCount != null &&
                    this.OutboundCallCount.Equals(other.OutboundCallCount)
                ) &&
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) &&
                (
                    this.QosMismatchCount == other.QosMismatchCount ||
                    this.QosMismatchCount != null &&
                    this.QosMismatchCount.Equals(other.QosMismatchCount)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.TrunkBase != null)
                    hash = hash * 59 + this.TrunkBase.GetHashCode();

                if (this.TrunkType != null)
                    hash = hash * 59 + this.TrunkType.GetHashCode();

                if (this.InboundCallCount != null)
                    hash = hash * 59 + this.InboundCallCount.GetHashCode();

                if (this.OutboundCallCount != null)
                    hash = hash * 59 + this.OutboundCallCount.GetHashCode();

                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();

                if (this.QosMismatchCount != null)
                    hash = hash * 59 + this.QosMismatchCount.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
