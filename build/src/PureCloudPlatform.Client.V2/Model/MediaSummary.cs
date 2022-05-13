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
    /// MediaSummary
    /// </summary>
    [DataContract]
    public partial class MediaSummary :  IEquatable<MediaSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaSummary" /> class.
        /// </summary>
        /// <param name="ContactCenter">ContactCenter.</param>
        /// <param name="Enterprise">Enterprise.</param>
        public MediaSummary(MediaSummaryDetail ContactCenter = null, MediaSummaryDetail Enterprise = null)
        {
            this.ContactCenter = ContactCenter;
            this.Enterprise = Enterprise;
            
        }
        


        /// <summary>
        /// Gets or Sets ContactCenter
        /// </summary>
        [DataMember(Name="contactCenter", EmitDefaultValue=false)]
        public MediaSummaryDetail ContactCenter { get; set; }



        /// <summary>
        /// Gets or Sets Enterprise
        /// </summary>
        [DataMember(Name="enterprise", EmitDefaultValue=false)]
        public MediaSummaryDetail Enterprise { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaSummary {\n");

            sb.Append("  ContactCenter: ").Append(ContactCenter).Append("\n");
            sb.Append("  Enterprise: ").Append(Enterprise).Append("\n");
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
            return this.Equals(obj as MediaSummary);
        }

        /// <summary>
        /// Returns true if MediaSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContactCenter == other.ContactCenter ||
                    this.ContactCenter != null &&
                    this.ContactCenter.Equals(other.ContactCenter)
                ) &&
                (
                    this.Enterprise == other.Enterprise ||
                    this.Enterprise != null &&
                    this.Enterprise.Equals(other.Enterprise)
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
                if (this.ContactCenter != null)
                    hash = hash * 59 + this.ContactCenter.GetHashCode();

                if (this.Enterprise != null)
                    hash = hash * 59 + this.Enterprise.GetHashCode();

                return hash;
            }
        }
    }

}
