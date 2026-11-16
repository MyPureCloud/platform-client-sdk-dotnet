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
    /// A WhatsAppBusinessScopedId record
    /// </summary>
    [DataContract]
    public partial class WhatsAppBusinessScopedId :  IEquatable<WhatsAppBusinessScopedId>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppBusinessScopedId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WhatsAppBusinessScopedId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppBusinessScopedId" /> class.
        /// </summary>
        /// <param name="Bsuid">The Whatsapp Business Scoped Id associated with a WhatsApp User. (required).</param>
        /// <param name="Parent">True if this is a parent BSUID, false if it is a regular BSUID..</param>
        /// <param name="PortfolioId">The portfolio id associated with the WhatsApp bsuid..</param>
        public WhatsAppBusinessScopedId(string Bsuid = null, bool? Parent = null, string PortfolioId = null)
        {
            this.Bsuid = Bsuid;
            this.Parent = Parent;
            this.PortfolioId = PortfolioId;
            
        }
        


        /// <summary>
        /// The Whatsapp Business Scoped Id associated with a WhatsApp User.
        /// </summary>
        /// <value>The Whatsapp Business Scoped Id associated with a WhatsApp User.</value>
        [DataMember(Name="bsuid", EmitDefaultValue=false)]
        public string Bsuid { get; set; }



        /// <summary>
        /// True if this is a parent BSUID, false if it is a regular BSUID.
        /// </summary>
        /// <value>True if this is a parent BSUID, false if it is a regular BSUID.</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public bool? Parent { get; set; }



        /// <summary>
        /// The portfolio id associated with the WhatsApp bsuid.
        /// </summary>
        /// <value>The portfolio id associated with the WhatsApp bsuid.</value>
        [DataMember(Name="portfolioId", EmitDefaultValue=false)]
        public string PortfolioId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsAppBusinessScopedId {\n");

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
            return this.Equals(obj as WhatsAppBusinessScopedId);
        }

        /// <summary>
        /// Returns true if WhatsAppBusinessScopedId instances are equal
        /// </summary>
        /// <param name="other">Instance of WhatsAppBusinessScopedId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppBusinessScopedId other)
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
