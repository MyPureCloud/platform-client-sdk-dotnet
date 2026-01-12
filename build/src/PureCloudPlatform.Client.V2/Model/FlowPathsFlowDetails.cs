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
    /// FlowPathsFlowDetails
    /// </summary>
    [DataContract]
    public partial class FlowPathsFlowDetails :  IEquatable<FlowPathsFlowDetails>
    {
        /// <summary>
        /// The type of the flow.
        /// </summary>
        /// <value>The type of the flow.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Digitalbot for "DigitalBot"
            /// </summary>
            [EnumMember(Value = "DigitalBot")]
            Digitalbot,
            
            /// <summary>
            /// Enum Bot for "Bot"
            /// </summary>
            [EnumMember(Value = "Bot")]
            Bot,
            
            /// <summary>
            /// Enum Inboundcall for "InboundCall"
            /// </summary>
            [EnumMember(Value = "InboundCall")]
            Inboundcall,
            
            /// <summary>
            /// Enum Securecall for "SecureCall"
            /// </summary>
            [EnumMember(Value = "SecureCall")]
            Securecall,
            
            /// <summary>
            /// Enum Inboundshortmessage for "InboundShortMessage"
            /// </summary>
            [EnumMember(Value = "InboundShortMessage")]
            Inboundshortmessage,
            
            /// <summary>
            /// Enum Inboundemail for "InboundEmail"
            /// </summary>
            [EnumMember(Value = "InboundEmail")]
            Inboundemail,
            
            /// <summary>
            /// Enum Outboundcall for "OutboundCall"
            /// </summary>
            [EnumMember(Value = "OutboundCall")]
            Outboundcall
        }
        /// <summary>
        /// The type of the flow.
        /// </summary>
        /// <value>The type of the flow.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlowPathsFlowDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlowPathsFlowDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowPathsFlowDetails" /> class.
        /// </summary>
        /// <param name="Flow">The identifier of the flow. (required).</param>
        /// <param name="Version">The version of the flow. (required).</param>
        /// <param name="Type">The type of the flow. (required).</param>
        /// <param name="Count">Count of all journeys that include this element in the given flow. (required).</param>
        public FlowPathsFlowDetails(AddressableEntityRef Flow = null, string Version = null, TypeEnum? Type = null, int? Count = null)
        {
            this.Flow = Flow;
            this.Version = Version;
            this.Type = Type;
            this.Count = Count;
            
        }
        


        /// <summary>
        /// The identifier of the flow.
        /// </summary>
        /// <value>The identifier of the flow.</value>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public AddressableEntityRef Flow { get; set; }



        /// <summary>
        /// The version of the flow.
        /// </summary>
        /// <value>The version of the flow.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }





        /// <summary>
        /// Count of all journeys that include this element in the given flow.
        /// </summary>
        /// <value>Count of all journeys that include this element in the given flow.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowPathsFlowDetails {\n");

            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as FlowPathsFlowDetails);
        }

        /// <summary>
        /// Returns true if FlowPathsFlowDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowPathsFlowDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowPathsFlowDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
