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
    /// HrisTimeOffType
    /// </summary>
    [DataContract]
    public partial class HrisTimeOffType :  IEquatable<HrisTimeOffType>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="HrisTimeOffType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HrisTimeOffType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HrisTimeOffType" /> class.
        /// </summary>
        /// <param name="Id">The ID of the time off type configured in integration. (required).</param>
        /// <param name="Name">The name of the time off type configured in integration. (required).</param>
        /// <param name="HrisIntegrationId">The ID of the integration. (required).</param>
        /// <param name="SecondaryId">Secondary ID of the time off type, if configured in integration..</param>
        public HrisTimeOffType(string Id = null, string Name = null, string HrisIntegrationId = null, string SecondaryId = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.HrisIntegrationId = HrisIntegrationId;
            this.SecondaryId = SecondaryId;
            
        }
        


        /// <summary>
        /// The ID of the time off type configured in integration.
        /// </summary>
        /// <value>The ID of the time off type configured in integration.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The name of the time off type configured in integration.
        /// </summary>
        /// <value>The name of the time off type configured in integration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The ID of the integration.
        /// </summary>
        /// <value>The ID of the integration.</value>
        [DataMember(Name="hrisIntegrationId", EmitDefaultValue=false)]
        public string HrisIntegrationId { get; set; }



        /// <summary>
        /// Secondary ID of the time off type, if configured in integration.
        /// </summary>
        /// <value>Secondary ID of the time off type, if configured in integration.</value>
        [DataMember(Name="secondaryId", EmitDefaultValue=false)]
        public string SecondaryId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HrisTimeOffType {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HrisIntegrationId: ").Append(HrisIntegrationId).Append("\n");
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
            return this.Equals(obj as HrisTimeOffType);
        }

        /// <summary>
        /// Returns true if HrisTimeOffType instances are equal
        /// </summary>
        /// <param name="other">Instance of HrisTimeOffType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HrisTimeOffType other)
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
                    this.HrisIntegrationId == other.HrisIntegrationId ||
                    this.HrisIntegrationId != null &&
                    this.HrisIntegrationId.Equals(other.HrisIntegrationId)
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

                if (this.HrisIntegrationId != null)
                    hash = hash * 59 + this.HrisIntegrationId.GetHashCode();

                if (this.SecondaryId != null)
                    hash = hash * 59 + this.SecondaryId.GetHashCode();

                return hash;
            }
        }
    }

}
