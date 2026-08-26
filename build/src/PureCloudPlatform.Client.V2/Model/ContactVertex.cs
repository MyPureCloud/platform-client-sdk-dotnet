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
    /// ContactVertex
    /// </summary>
    [DataContract]
    public partial class ContactVertex :  IEquatable<ContactVertex>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactVertex" /> class.
        /// </summary>
        public ContactVertex()
        {
            
        }
        


        /// <summary>
        /// The ID of the vertex in the cluster graph. This ID is only unique within the graph!
        /// </summary>
        /// <value>The ID of the vertex in the cluster graph. This ID is only unique within the graph!</value>
        [DataMember(Name="vertexId", EmitDefaultValue=false)]
        public string VertexId { get; private set; }



        /// <summary>
        /// The contact found
        /// </summary>
        /// <value>The contact found</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ExternalContact Contact { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactVertex {\n");

            sb.Append("  VertexId: ").Append(VertexId).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
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
            return this.Equals(obj as ContactVertex);
        }

        /// <summary>
        /// Returns true if ContactVertex instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactVertex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactVertex other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.VertexId == other.VertexId ||
                    this.VertexId != null &&
                    this.VertexId.Equals(other.VertexId)
                ) &&
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
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
                if (this.VertexId != null)
                    hash = hash * 59 + this.VertexId.GetHashCode();

                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();

                return hash;
            }
        }
    }

}
