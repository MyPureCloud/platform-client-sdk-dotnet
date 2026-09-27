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
    /// UpdateAdherenceAdjustmentsReasonCodesBulkItem
    /// </summary>
    [DataContract]
    public partial class UpdateAdherenceAdjustmentsReasonCodesBulkItem :  IEquatable<UpdateAdherenceAdjustmentsReasonCodesBulkItem>
    {
        /// <summary>
        /// The state of the reason code
        /// </summary>
        /// <value>The state of the reason code</value>
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
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "Inactive"
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive
        }
        /// <summary>
        /// The state of the reason code
        /// </summary>
        /// <value>The state of the reason code</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAdherenceAdjustmentsReasonCodesBulkItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAdherenceAdjustmentsReasonCodesBulkItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAdherenceAdjustmentsReasonCodesBulkItem" /> class.
        /// </summary>
        /// <param name="Id">The ID of the reason code to update (required).</param>
        /// <param name="Name">The display name of the reason code.</param>
        /// <param name="State">The state of the reason code.</param>
        /// <param name="Metadata">Version metadata for the reason code (required).</param>
        public UpdateAdherenceAdjustmentsReasonCodesBulkItem(string Id = null, string Name = null, StateEnum? State = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.State = State;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// The ID of the reason code to update
        /// </summary>
        /// <value>The ID of the reason code to update</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The display name of the reason code
        /// </summary>
        /// <value>The display name of the reason code</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// Version metadata for the reason code
        /// </summary>
        /// <value>Version metadata for the reason code</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAdherenceAdjustmentsReasonCodesBulkItem {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as UpdateAdherenceAdjustmentsReasonCodesBulkItem);
        }

        /// <summary>
        /// Returns true if UpdateAdherenceAdjustmentsReasonCodesBulkItem instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateAdherenceAdjustmentsReasonCodesBulkItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAdherenceAdjustmentsReasonCodesBulkItem other)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
