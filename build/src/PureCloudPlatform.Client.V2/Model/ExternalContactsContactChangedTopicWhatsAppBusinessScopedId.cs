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
    /// ExternalContactsContactChangedTopicWhatsAppBusinessScopedId
    /// </summary>
    [DataContract]
    public partial class ExternalContactsContactChangedTopicWhatsAppBusinessScopedId :  IEquatable<ExternalContactsContactChangedTopicWhatsAppBusinessScopedId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsContactChangedTopicWhatsAppBusinessScopedId" /> class.
        /// </summary>
        /// <param name="Bsuid">Bsuid.</param>
        /// <param name="Parent">Parent.</param>
        /// <param name="PortfolioId">PortfolioId.</param>
        public ExternalContactsContactChangedTopicWhatsAppBusinessScopedId(string Bsuid = null, bool? Parent = null, string PortfolioId = null)
        {
            this.Bsuid = Bsuid;
            this.Parent = Parent;
            this.PortfolioId = PortfolioId;
            
        }
        


        /// <summary>
        /// Gets or Sets Bsuid
        /// </summary>
        [DataMember(Name="bsuid", EmitDefaultValue=false)]
        public string Bsuid { get; set; }



        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public bool? Parent { get; set; }



        /// <summary>
        /// Gets or Sets PortfolioId
        /// </summary>
        [DataMember(Name="portfolioId", EmitDefaultValue=false)]
        public string PortfolioId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsContactChangedTopicWhatsAppBusinessScopedId {\n");

            sb.Append("  Bsuid: ").Append(Bsuid).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
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
            return this.Equals(obj as ExternalContactsContactChangedTopicWhatsAppBusinessScopedId);
        }

        /// <summary>
        /// Returns true if ExternalContactsContactChangedTopicWhatsAppBusinessScopedId instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsContactChangedTopicWhatsAppBusinessScopedId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsContactChangedTopicWhatsAppBusinessScopedId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Bsuid == other.Bsuid ||
                    this.Bsuid != null &&
                    this.Bsuid.Equals(other.Bsuid)
                ) &&
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) &&
                (
                    this.PortfolioId == other.PortfolioId ||
                    this.PortfolioId != null &&
                    this.PortfolioId.Equals(other.PortfolioId)
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
                if (this.Bsuid != null)
                    hash = hash * 59 + this.Bsuid.GetHashCode();

                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();

                if (this.PortfolioId != null)
                    hash = hash * 59 + this.PortfolioId.GetHashCode();

                return hash;
            }
        }
    }

}
