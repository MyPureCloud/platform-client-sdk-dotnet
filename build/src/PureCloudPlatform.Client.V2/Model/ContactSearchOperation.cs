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
    /// ContactSearchOperation
    /// </summary>
    [DataContract]
    public partial class ContactSearchOperation :  IEquatable<ContactSearchOperation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactSearchOperation" /> class.
        /// </summary>
        /// <param name="SimpleSearch">Simple Search operation to execute.</param>
        public ContactSearchOperation(ContactSimpleSearch SimpleSearch = null)
        {
            this.SimpleSearch = SimpleSearch;
            
        }
        


        /// <summary>
        /// Simple Search operation to execute
        /// </summary>
        /// <value>Simple Search operation to execute</value>
        [DataMember(Name="simpleSearch", EmitDefaultValue=false)]
        public ContactSimpleSearch SimpleSearch { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactSearchOperation {\n");

            sb.Append("  SimpleSearch: ").Append(SimpleSearch).Append("\n");
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
            return this.Equals(obj as ContactSearchOperation);
        }

        /// <summary>
        /// Returns true if ContactSearchOperation instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactSearchOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactSearchOperation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SimpleSearch == other.SimpleSearch ||
                    this.SimpleSearch != null &&
                    this.SimpleSearch.Equals(other.SimpleSearch)
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
                if (this.SimpleSearch != null)
                    hash = hash * 59 + this.SimpleSearch.GetHashCode();

                return hash;
            }
        }
    }

}
