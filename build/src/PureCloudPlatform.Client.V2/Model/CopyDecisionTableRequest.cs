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
    /// CopyDecisionTableRequest
    /// </summary>
    [DataContract]
    public partial class CopyDecisionTableRequest :  IEquatable<CopyDecisionTableRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyDecisionTableRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CopyDecisionTableRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyDecisionTableRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the newly created decision table. Must be unique (required).</param>
        /// <param name="Description">The description of newly created decision table..</param>
        public CopyDecisionTableRequest(string Name = null, string Description = null)
        {
            this.Name = Name;
            this.Description = Description;
            
        }
        


        /// <summary>
        /// The name of the newly created decision table. Must be unique
        /// </summary>
        /// <value>The name of the newly created decision table. Must be unique</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of newly created decision table.
        /// </summary>
        /// <value>The description of newly created decision table.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyDecisionTableRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as CopyDecisionTableRequest);
        }

        /// <summary>
        /// Returns true if CopyDecisionTableRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CopyDecisionTableRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopyDecisionTableRequest other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                return hash;
            }
        }
    }

}
