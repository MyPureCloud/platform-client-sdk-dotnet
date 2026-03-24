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
    /// CaseSummaryUpdate
    /// </summary>
    [DataContract]
    public partial class CaseSummaryUpdate :  IEquatable<CaseSummaryUpdate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CaseSummaryUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseSummaryUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseSummaryUpdate" /> class.
        /// </summary>
        /// <param name="Summary">Overview information for the Case. Valid length between 3 and 512 characters. (required).</param>
        public CaseSummaryUpdate(string Summary = null)
        {
            this.Summary = Summary;
            
        }
        


        /// <summary>
        /// Overview information for the Case. Valid length between 3 and 512 characters.
        /// </summary>
        /// <value>Overview information for the Case. Valid length between 3 and 512 characters.</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseSummaryUpdate {\n");

            sb.Append("  Summary: ").Append(Summary).Append("\n");
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
            return this.Equals(obj as CaseSummaryUpdate);
        }

        /// <summary>
        /// Returns true if CaseSummaryUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseSummaryUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseSummaryUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
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
                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();

                return hash;
            }
        }
    }

}
