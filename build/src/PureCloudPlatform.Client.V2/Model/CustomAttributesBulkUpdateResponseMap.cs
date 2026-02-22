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
    /// CustomAttributesBulkUpdateResponseMap
    /// </summary>
    [DataContract]
    public partial class CustomAttributesBulkUpdateResponseMap :  IEquatable<CustomAttributesBulkUpdateResponseMap>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttributesBulkUpdateResponseMap" /> class.
        /// </summary>
        /// <param name="Results">The map of Custom Attributes record ids to their results after updating..</param>
        public CustomAttributesBulkUpdateResponseMap(Dictionary<string, CustomAttributesBulkUpdateResponse> Results = null)
        {
            this.Results = Results;
            
        }
        


        /// <summary>
        /// The map of Custom Attributes record ids to their results after updating.
        /// </summary>
        /// <value>The map of Custom Attributes record ids to their results after updating.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public Dictionary<string, CustomAttributesBulkUpdateResponse> Results { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomAttributesBulkUpdateResponseMap {\n");

            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as CustomAttributesBulkUpdateResponseMap);
        }

        /// <summary>
        /// Returns true if CustomAttributesBulkUpdateResponseMap instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomAttributesBulkUpdateResponseMap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomAttributesBulkUpdateResponseMap other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                return hash;
            }
        }
    }

}
