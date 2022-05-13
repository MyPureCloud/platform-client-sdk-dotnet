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
    /// Knowledge
    /// </summary>
    [DataContract]
    public partial class Knowledge :  IEquatable<Knowledge>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Knowledge" /> class.
        /// </summary>
        /// <param name="Enabled">whether or not knowledge base is enabled.</param>
        /// <param name="KnowledgeBase">The knowledge base for messenger.</param>
        public Knowledge(bool? Enabled = null, AddressableEntityRef KnowledgeBase = null)
        {
            this.Enabled = Enabled;
            this.KnowledgeBase = KnowledgeBase;
            
        }
        


        /// <summary>
        /// whether or not knowledge base is enabled
        /// </summary>
        /// <value>whether or not knowledge base is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The knowledge base for messenger
        /// </summary>
        /// <value>The knowledge base for messenger</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public AddressableEntityRef KnowledgeBase { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Knowledge {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
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
            return this.Equals(obj as Knowledge);
        }

        /// <summary>
        /// Returns true if Knowledge instances are equal
        /// </summary>
        /// <param name="other">Instance of Knowledge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Knowledge other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.KnowledgeBase == other.KnowledgeBase ||
                    this.KnowledgeBase != null &&
                    this.KnowledgeBase.Equals(other.KnowledgeBase)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.KnowledgeBase != null)
                    hash = hash * 59 + this.KnowledgeBase.GetHashCode();

                return hash;
            }
        }
    }

}
