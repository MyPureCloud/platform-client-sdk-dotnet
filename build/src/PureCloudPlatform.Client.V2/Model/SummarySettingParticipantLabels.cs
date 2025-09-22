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
    /// SummarySettingParticipantLabels
    /// </summary>
    [DataContract]
    public partial class SummarySettingParticipantLabels :  IEquatable<SummarySettingParticipantLabels>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SummarySettingParticipantLabels" /> class.
        /// </summary>
        /// <param name="Internal">Specify how to refer the internal participant of the interaction..</param>
        /// <param name="External">Specify how to refer the external participant of the interaction..</param>
        public SummarySettingParticipantLabels(string Internal = null, string External = null)
        {
            this.Internal = Internal;
            this.External = External;
            
        }
        


        /// <summary>
        /// Specify how to refer the internal participant of the interaction.
        /// </summary>
        /// <value>Specify how to refer the internal participant of the interaction.</value>
        [DataMember(Name="internal", EmitDefaultValue=false)]
        public string Internal { get; set; }



        /// <summary>
        /// Specify how to refer the external participant of the interaction.
        /// </summary>
        /// <value>Specify how to refer the external participant of the interaction.</value>
        [DataMember(Name="external", EmitDefaultValue=false)]
        public string External { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummarySettingParticipantLabels {\n");

            sb.Append("  Internal: ").Append(Internal).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
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
            return this.Equals(obj as SummarySettingParticipantLabels);
        }

        /// <summary>
        /// Returns true if SummarySettingParticipantLabels instances are equal
        /// </summary>
        /// <param name="other">Instance of SummarySettingParticipantLabels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummarySettingParticipantLabels other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Internal == other.Internal ||
                    this.Internal != null &&
                    this.Internal.Equals(other.Internal)
                ) &&
                (
                    this.External == other.External ||
                    this.External != null &&
                    this.External.Equals(other.External)
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
                if (this.Internal != null)
                    hash = hash * 59 + this.Internal.GetHashCode();

                if (this.External != null)
                    hash = hash * 59 + this.External.GetHashCode();

                return hash;
            }
        }
    }

}
