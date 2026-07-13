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
    /// ConversationAccessAttributesResponse
    /// </summary>
    [DataContract]
    public partial class ConversationAccessAttributesResponse :  IEquatable<ConversationAccessAttributesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationAccessAttributesResponse" /> class.
        /// </summary>
        /// <param name="AccessAttributes">The attributes that define which users may access a conversation.</param>
        public ConversationAccessAttributesResponse(List<string> AccessAttributes = null)
        {
            this.AccessAttributes = AccessAttributes;
            
        }
        


        /// <summary>
        /// The attributes that define which users may access a conversation
        /// </summary>
        /// <value>The attributes that define which users may access a conversation</value>
        [DataMember(Name="accessAttributes", EmitDefaultValue=false)]
        public List<string> AccessAttributes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationAccessAttributesResponse {\n");

            sb.Append("  AccessAttributes: ").Append(AccessAttributes).Append("\n");
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
            return this.Equals(obj as ConversationAccessAttributesResponse);
        }

        /// <summary>
        /// Returns true if ConversationAccessAttributesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationAccessAttributesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationAccessAttributesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AccessAttributes == other.AccessAttributes ||
                    this.AccessAttributes != null &&
                    this.AccessAttributes.SequenceEqual(other.AccessAttributes)
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
                if (this.AccessAttributes != null)
                    hash = hash * 59 + this.AccessAttributes.GetHashCode();

                return hash;
            }
        }
    }

}
