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
    /// V2WemEngagementCelebrationUpdatesTopicContestPrizes
    /// </summary>
    [DataContract]
    public partial class V2WemEngagementCelebrationUpdatesTopicContestPrizes :  IEquatable<V2WemEngagementCelebrationUpdatesTopicContestPrizes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicContestPrizes" /> class.
        /// </summary>
        /// <param name="Tier">Tier.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ImageId">ImageId.</param>
        public V2WemEngagementCelebrationUpdatesTopicContestPrizes(int? Tier = null, string Name = null, string ImageId = null)
        {
            this.Tier = Tier;
            this.Name = Name;
            this.ImageId = ImageId;
            
        }
        


        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public int? Tier { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        [DataMember(Name="imageId", EmitDefaultValue=false)]
        public string ImageId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2WemEngagementCelebrationUpdatesTopicContestPrizes {\n");

            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
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
            return this.Equals(obj as V2WemEngagementCelebrationUpdatesTopicContestPrizes);
        }

        /// <summary>
        /// Returns true if V2WemEngagementCelebrationUpdatesTopicContestPrizes instances are equal
        /// </summary>
        /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicContestPrizes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2WemEngagementCelebrationUpdatesTopicContestPrizes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ImageId == other.ImageId ||
                    this.ImageId != null &&
                    this.ImageId.Equals(other.ImageId)
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
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ImageId != null)
                    hash = hash * 59 + this.ImageId.GetHashCode();

                return hash;
            }
        }
    }

}
