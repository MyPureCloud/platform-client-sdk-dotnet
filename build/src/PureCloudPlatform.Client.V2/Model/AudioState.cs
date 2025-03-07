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
    /// AudioState
    /// </summary>
    [DataContract]
    public partial class AudioState :  IEquatable<AudioState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioState" /> class.
        /// </summary>
        /// <param name="CanHear">Indicates that this communication&#39;s audio allows its participant to hear others..</param>
        /// <param name="CanSpeak">Indicates that this communication&#39;s audio allows others to hear this participant..</param>
        public AudioState(bool? CanHear = null, bool? CanSpeak = null)
        {
            this.CanHear = CanHear;
            this.CanSpeak = CanSpeak;
            
        }
        


        /// <summary>
        /// Indicates that this communication&#39;s audio allows its participant to hear others.
        /// </summary>
        /// <value>Indicates that this communication&#39;s audio allows its participant to hear others.</value>
        [DataMember(Name="canHear", EmitDefaultValue=false)]
        public bool? CanHear { get; set; }



        /// <summary>
        /// Indicates that this communication&#39;s audio allows others to hear this participant.
        /// </summary>
        /// <value>Indicates that this communication&#39;s audio allows others to hear this participant.</value>
        [DataMember(Name="canSpeak", EmitDefaultValue=false)]
        public bool? CanSpeak { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioState {\n");

            sb.Append("  CanHear: ").Append(CanHear).Append("\n");
            sb.Append("  CanSpeak: ").Append(CanSpeak).Append("\n");
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
            return this.Equals(obj as AudioState);
        }

        /// <summary>
        /// Returns true if AudioState instances are equal
        /// </summary>
        /// <param name="other">Instance of AudioState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AudioState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.CanHear == other.CanHear ||
                    this.CanHear != null &&
                    this.CanHear.Equals(other.CanHear)
                ) &&
                (
                    this.CanSpeak == other.CanSpeak ||
                    this.CanSpeak != null &&
                    this.CanSpeak.Equals(other.CanSpeak)
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
                if (this.CanHear != null)
                    hash = hash * 59 + this.CanHear.GetHashCode();

                if (this.CanSpeak != null)
                    hash = hash * 59 + this.CanSpeak.GetHashCode();

                return hash;
            }
        }
    }

}
