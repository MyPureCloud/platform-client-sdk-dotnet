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
    /// ContestPrizes
    /// </summary>
    [DataContract]
    public partial class ContestPrizes :  IEquatable<ContestPrizes>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ContestPrizes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContestPrizes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestPrizes" /> class.
        /// </summary>
        /// <param name="Tier">The Contest Prize tier (required).</param>
        /// <param name="Name">The Contest Prize name (required).</param>
        /// <param name="Description">The Contest Prize description (required).</param>
        /// <param name="ImageId">The Contest Prize image id (required).</param>
        /// <param name="WinnersCount">The Contest Prize winner Count (required).</param>
        public ContestPrizes(int? Tier = null, string Name = null, string Description = null, string ImageId = null, int? WinnersCount = null)
        {
            this.Tier = Tier;
            this.Name = Name;
            this.Description = Description;
            this.ImageId = ImageId;
            this.WinnersCount = WinnersCount;
            
        }
        


        /// <summary>
        /// The Contest Prize tier
        /// </summary>
        /// <value>The Contest Prize tier</value>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public int? Tier { get; set; }



        /// <summary>
        /// The Contest Prize name
        /// </summary>
        /// <value>The Contest Prize name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The Contest Prize description
        /// </summary>
        /// <value>The Contest Prize description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The Contest Prize image id
        /// </summary>
        /// <value>The Contest Prize image id</value>
        [DataMember(Name="imageId", EmitDefaultValue=false)]
        public string ImageId { get; set; }



        /// <summary>
        /// The Contest Prize image url
        /// </summary>
        /// <value>The Contest Prize image url</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; private set; }



        /// <summary>
        /// The Contest Prize winner Count
        /// </summary>
        /// <value>The Contest Prize winner Count</value>
        [DataMember(Name="winnersCount", EmitDefaultValue=false)]
        public int? WinnersCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestPrizes {\n");

            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  WinnersCount: ").Append(WinnersCount).Append("\n");
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
            return this.Equals(obj as ContestPrizes);
        }

        /// <summary>
        /// Returns true if ContestPrizes instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestPrizes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestPrizes other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.ImageId == other.ImageId ||
                    this.ImageId != null &&
                    this.ImageId.Equals(other.ImageId)
                ) &&
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) &&
                (
                    this.WinnersCount == other.WinnersCount ||
                    this.WinnersCount != null &&
                    this.WinnersCount.Equals(other.WinnersCount)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.ImageId != null)
                    hash = hash * 59 + this.ImageId.GetHashCode();

                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();

                if (this.WinnersCount != null)
                    hash = hash * 59 + this.WinnersCount.GetHashCode();

                return hash;
            }
        }
    }

}
