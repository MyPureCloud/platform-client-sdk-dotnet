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
    /// AdminBulkUpdateAlternativeShiftTradeState
    /// </summary>
    [DataContract]
    public partial class AdminBulkUpdateAlternativeShiftTradeState :  IEquatable<AdminBulkUpdateAlternativeShiftTradeState>
    {
        /// <summary>
        /// The new alternative shift trade state
        /// </summary>
        /// <value>The new alternative shift trade state</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Denied for "Denied"
            /// </summary>
            [EnumMember(Value = "Denied")]
            Denied
        }
        /// <summary>
        /// The new alternative shift trade state
        /// </summary>
        /// <value>The new alternative shift trade state</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBulkUpdateAlternativeShiftTradeState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdminBulkUpdateAlternativeShiftTradeState() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminBulkUpdateAlternativeShiftTradeState" /> class.
        /// </summary>
        /// <param name="TradeId">The ID of the trade for this alternative shift trade (required).</param>
        /// <param name="State">The new alternative shift trade state (required).</param>
        /// <param name="Metadata">Version metadata for this alternative shift trade (required).</param>
        public AdminBulkUpdateAlternativeShiftTradeState(string TradeId = null, StateEnum? State = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.TradeId = TradeId;
            this.State = State;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The ID of the trade for this alternative shift trade
        /// </summary>
        /// <value>The ID of the trade for this alternative shift trade</value>
        [DataMember(Name="tradeId", EmitDefaultValue=false)]
        public string TradeId { get; set; }





        /// <summary>
        /// Version metadata for this alternative shift trade
        /// </summary>
        /// <value>Version metadata for this alternative shift trade</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminBulkUpdateAlternativeShiftTradeState {\n");

            sb.Append("  TradeId: ").Append(TradeId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as AdminBulkUpdateAlternativeShiftTradeState);
        }

        /// <summary>
        /// Returns true if AdminBulkUpdateAlternativeShiftTradeState instances are equal
        /// </summary>
        /// <param name="other">Instance of AdminBulkUpdateAlternativeShiftTradeState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdminBulkUpdateAlternativeShiftTradeState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TradeId == other.TradeId ||
                    this.TradeId != null &&
                    this.TradeId.Equals(other.TradeId)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.TradeId != null)
                    hash = hash * 59 + this.TradeId.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
