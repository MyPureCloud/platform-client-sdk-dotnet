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
    /// DispositionParameters
    /// </summary>
    [DataContract]
    public partial class DispositionParameters :  IEquatable<DispositionParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DispositionParameters" /> class.
        /// </summary>
        /// <param name="AdjustableLiveSpeakerDetection">ALSD evaluation inputs and output (isPersonalLikely) of the ALSD detector the last time it ran on the call (could be multiple times).</param>
        public DispositionParameters(AdjustableLiveSpeakerDetection AdjustableLiveSpeakerDetection = null)
        {
            this.AdjustableLiveSpeakerDetection = AdjustableLiveSpeakerDetection;
            
        }
        


        /// <summary>
        /// ALSD evaluation inputs and output (isPersonalLikely) of the ALSD detector the last time it ran on the call (could be multiple times)
        /// </summary>
        /// <value>ALSD evaluation inputs and output (isPersonalLikely) of the ALSD detector the last time it ran on the call (could be multiple times)</value>
        [DataMember(Name="adjustableLiveSpeakerDetection", EmitDefaultValue=false)]
        public AdjustableLiveSpeakerDetection AdjustableLiveSpeakerDetection { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DispositionParameters {\n");

            sb.Append("  AdjustableLiveSpeakerDetection: ").Append(AdjustableLiveSpeakerDetection).Append("\n");
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
            return this.Equals(obj as DispositionParameters);
        }

        /// <summary>
        /// Returns true if DispositionParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of DispositionParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DispositionParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AdjustableLiveSpeakerDetection == other.AdjustableLiveSpeakerDetection ||
                    this.AdjustableLiveSpeakerDetection != null &&
                    this.AdjustableLiveSpeakerDetection.Equals(other.AdjustableLiveSpeakerDetection)
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
                if (this.AdjustableLiveSpeakerDetection != null)
                    hash = hash * 59 + this.AdjustableLiveSpeakerDetection.GetHashCode();

                return hash;
            }
        }
    }

}
