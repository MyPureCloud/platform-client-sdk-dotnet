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
    /// BuSchedulerSettingsResponse
    /// </summary>
    [DataContract]
    public partial class BuSchedulerSettingsResponse :  IEquatable<BuSchedulerSettingsResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BuSchedulerSettingsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuSchedulerSettingsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuSchedulerSettingsResponse" /> class.
        /// </summary>
        /// <param name="ConsistentServiceLevelSmoothing">Indicates whether to provide consistent service level smoothing in schedule generation for this business unit (required).</param>
        /// <param name="Metadata">Version metadata for this business unit&#39;s scheduler settings (required).</param>
        public BuSchedulerSettingsResponse(bool? ConsistentServiceLevelSmoothing = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.ConsistentServiceLevelSmoothing = ConsistentServiceLevelSmoothing;
            this.Metadata = Metadata;
            
        }
        


        /// <summary>
        /// Indicates whether to provide consistent service level smoothing in schedule generation for this business unit
        /// </summary>
        /// <value>Indicates whether to provide consistent service level smoothing in schedule generation for this business unit</value>
        [DataMember(Name="consistentServiceLevelSmoothing", EmitDefaultValue=false)]
        public bool? ConsistentServiceLevelSmoothing { get; set; }



        /// <summary>
        /// Version metadata for this business unit&#39;s scheduler settings
        /// </summary>
        /// <value>Version metadata for this business unit&#39;s scheduler settings</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuSchedulerSettingsResponse {\n");

            sb.Append("  ConsistentServiceLevelSmoothing: ").Append(ConsistentServiceLevelSmoothing).Append("\n");
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
            return this.Equals(obj as BuSchedulerSettingsResponse);
        }

        /// <summary>
        /// Returns true if BuSchedulerSettingsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BuSchedulerSettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuSchedulerSettingsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConsistentServiceLevelSmoothing == other.ConsistentServiceLevelSmoothing ||
                    this.ConsistentServiceLevelSmoothing != null &&
                    this.ConsistentServiceLevelSmoothing.Equals(other.ConsistentServiceLevelSmoothing)
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
                if (this.ConsistentServiceLevelSmoothing != null)
                    hash = hash * 59 + this.ConsistentServiceLevelSmoothing.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                return hash;
            }
        }
    }

}
