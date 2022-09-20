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
    /// BuSchedulingSettingsRequest
    /// </summary>
    [DataContract]
    public partial class BuSchedulingSettingsRequest :  IEquatable<BuSchedulingSettingsRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuSchedulingSettingsRequest" /> class.
        /// </summary>
        /// <param name="MessageSeverities">Schedule generation message severity configuration.</param>
        public BuSchedulingSettingsRequest(List<SchedulerMessageTypeSeverity> MessageSeverities = null)
        {
            this.MessageSeverities = MessageSeverities;
            
        }
        


        /// <summary>
        /// Schedule generation message severity configuration
        /// </summary>
        /// <value>Schedule generation message severity configuration</value>
        [DataMember(Name="messageSeverities", EmitDefaultValue=false)]
        public List<SchedulerMessageTypeSeverity> MessageSeverities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuSchedulingSettingsRequest {\n");

            sb.Append("  MessageSeverities: ").Append(MessageSeverities).Append("\n");
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
            return this.Equals(obj as BuSchedulingSettingsRequest);
        }

        /// <summary>
        /// Returns true if BuSchedulingSettingsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BuSchedulingSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuSchedulingSettingsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MessageSeverities == other.MessageSeverities ||
                    this.MessageSeverities != null &&
                    this.MessageSeverities.SequenceEqual(other.MessageSeverities)
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
                if (this.MessageSeverities != null)
                    hash = hash * 59 + this.MessageSeverities.GetHashCode();

                return hash;
            }
        }
    }

}
