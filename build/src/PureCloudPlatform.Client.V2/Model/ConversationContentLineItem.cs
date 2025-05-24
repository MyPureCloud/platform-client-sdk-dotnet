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
    /// Item included in an order.
    /// </summary>
    [DataContract]
    public partial class ConversationContentLineItem :  IEquatable<ConversationContentLineItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentLineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentLineItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentLineItem" /> class.
        /// </summary>
        /// <param name="Name">The display name for the item. (required).</param>
        /// <param name="Price">The price of the item. (required).</param>
        /// <param name="Description">Additional details about the item (e.g. the length of time to deliver for shipping options)..</param>
        /// <param name="Identifier">A client defined value used to identify the item..</param>
        public ConversationContentLineItem(string Name = null, double? Price = null, string Description = null, string Identifier = null)
        {
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
            this.Identifier = Identifier;
            
        }
        


        /// <summary>
        /// The display name for the item.
        /// </summary>
        /// <value>The display name for the item.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The price of the item.
        /// </summary>
        /// <value>The price of the item.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }



        /// <summary>
        /// Additional details about the item (e.g. the length of time to deliver for shipping options).
        /// </summary>
        /// <value>Additional details about the item (e.g. the length of time to deliver for shipping options).</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// A client defined value used to identify the item.
        /// </summary>
        /// <value>A client defined value used to identify the item.</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentLineItem {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
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
            return this.Equals(obj as ConversationContentLineItem);
        }

        /// <summary>
        /// Returns true if ConversationContentLineItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentLineItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Identifier == other.Identifier ||
                    this.Identifier != null &&
                    this.Identifier.Equals(other.Identifier)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Identifier != null)
                    hash = hash * 59 + this.Identifier.GetHashCode();

                return hash;
            }
        }
    }

}
