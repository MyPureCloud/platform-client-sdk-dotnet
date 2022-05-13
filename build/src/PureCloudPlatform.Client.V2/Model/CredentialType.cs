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
    /// CredentialType
    /// </summary>
    [DataContract]
    public partial class CredentialType :  IEquatable<CredentialType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialType" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        public CredentialType(string Name = null)
        {
            this.Name = Name;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Properties describing credentials of this type.
        /// </summary>
        /// <value>Properties describing credentials of this type.</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Object Properties { get; private set; }



        /// <summary>
        /// Order in which properties should be displayed in the UI.
        /// </summary>
        /// <value>Order in which properties should be displayed in the UI.</value>
        [DataMember(Name="displayOrder", EmitDefaultValue=false)]
        public List<string> DisplayOrder { get; private set; }



        /// <summary>
        /// Properties that are required fields.
        /// </summary>
        /// <value>Properties that are required fields.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public List<string> Required { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CredentialType {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
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
            return this.Equals(obj as CredentialType);
        }

        /// <summary>
        /// Returns true if CredentialType instances are equal
        /// </summary>
        /// <param name="other">Instance of CredentialType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CredentialType other)
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
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
                ) &&
                (
                    this.DisplayOrder == other.DisplayOrder ||
                    this.DisplayOrder != null &&
                    this.DisplayOrder.SequenceEqual(other.DisplayOrder)
                ) &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.SequenceEqual(other.Required)
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

                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();

                if (this.DisplayOrder != null)
                    hash = hash * 59 + this.DisplayOrder.GetHashCode();

                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();

                return hash;
            }
        }
    }

}
