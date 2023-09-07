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
    /// HrisTimeOffTypeResponse
    /// </summary>
    [DataContract]
    public partial class HrisTimeOffTypeResponse :  IEquatable<HrisTimeOffTypeResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="HrisTimeOffTypeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HrisTimeOffTypeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HrisTimeOffTypeResponse" /> class.
        /// </summary>
        /// <param name="Id">ID of the time off type configured in integration (required).</param>
        /// <param name="Name">Name of the time off type configured in integration (required).</param>
        /// <param name="SecondaryId">Secondary ID of the time off type, if configured in integration.</param>
        public HrisTimeOffTypeResponse(string Id = null, string Name = null, string SecondaryId = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.SecondaryId = SecondaryId;
            
        }
        


        /// <summary>
        /// ID of the time off type configured in integration
        /// </summary>
        /// <value>ID of the time off type configured in integration</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Name of the time off type configured in integration
        /// </summary>
        /// <value>Name of the time off type configured in integration</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Secondary ID of the time off type, if configured in integration
        /// </summary>
        /// <value>Secondary ID of the time off type, if configured in integration</value>
        [DataMember(Name="secondaryId", EmitDefaultValue=false)]
        public string SecondaryId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HrisTimeOffTypeResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SecondaryId: ").Append(SecondaryId).Append("\n");
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
            return this.Equals(obj as HrisTimeOffTypeResponse);
        }

        /// <summary>
        /// Returns true if HrisTimeOffTypeResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HrisTimeOffTypeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HrisTimeOffTypeResponse other)
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
                    this.SecondaryId == other.SecondaryId ||
                    this.SecondaryId != null &&
                    this.SecondaryId.Equals(other.SecondaryId)
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

                if (this.SecondaryId != null)
                    hash = hash * 59 + this.SecondaryId.GetHashCode();

                return hash;
            }
        }
    }

}
