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
    /// GraphVertices
    /// </summary>
    [DataContract]
    public partial class GraphVertices :  IEquatable<GraphVertices>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphVertices" /> class.
        /// </summary>
        public GraphVertices()
        {
            
        }
        


        /// <summary>
        /// The list of contact vertices in the cluster
        /// </summary>
        /// <value>The list of contact vertices in the cluster</value>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<ContactVertex> Contacts { get; private set; }



        /// <summary>
        /// The list of identifier vertices in the cluster
        /// </summary>
        /// <value>The list of identifier vertices in the cluster</value>
        [DataMember(Name="identifiers", EmitDefaultValue=false)]
        public List<IdentifierVertex> Identifiers { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GraphVertices {\n");

            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
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
            return this.Equals(obj as GraphVertices);
        }

        /// <summary>
        /// Returns true if GraphVertices instances are equal
        /// </summary>
        /// <param name="other">Instance of GraphVertices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GraphVertices other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Contacts == other.Contacts ||
                    this.Contacts != null &&
                    this.Contacts.SequenceEqual(other.Contacts)
                ) &&
                (
                    this.Identifiers == other.Identifiers ||
                    this.Identifiers != null &&
                    this.Identifiers.SequenceEqual(other.Identifiers)
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
                if (this.Contacts != null)
                    hash = hash * 59 + this.Contacts.GetHashCode();

                if (this.Identifiers != null)
                    hash = hash * 59 + this.Identifiers.GetHashCode();

                return hash;
            }
        }
    }

}
