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
    /// ContestDataPrizes
    /// </summary>
    [DataContract]
    public partial class ContestDataPrizes :  IEquatable<ContestDataPrizes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestDataPrizes" /> class.
        /// </summary>
        /// <param name="Tier">Tier of the prize.</param>
        /// <param name="Name">Name of the prize.</param>
        /// <param name="ImageId">Id of the prize image.</param>
        public ContestDataPrizes(int? Tier = null, string Name = null, string ImageId = null)
        {
            this.Tier = Tier;
            this.Name = Name;
            this.ImageId = ImageId;
            
        }
        


        /// <summary>
        /// Tier of the prize
        /// </summary>
        /// <value>Tier of the prize</value>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public int? Tier { get; set; }



        /// <summary>
        /// Name of the prize
        /// </summary>
        /// <value>Name of the prize</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Id of the prize image
        /// </summary>
        /// <value>Id of the prize image</value>
        [DataMember(Name="imageId", EmitDefaultValue=false)]
        public string ImageId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestDataPrizes {\n");

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
            return this.Equals(obj as ContestDataPrizes);
        }

        /// <summary>
        /// Returns true if ContestDataPrizes instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestDataPrizes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestDataPrizes other)
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
