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
    /// BulkRemoveSourceIntentsRequest
    /// </summary>
    [DataContract]
    public partial class BulkRemoveSourceIntentsRequest :  IEquatable<BulkRemoveSourceIntentsRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkRemoveSourceIntentsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkRemoveSourceIntentsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkRemoveSourceIntentsRequest" /> class.
        /// </summary>
        /// <param name="Items">List of ids to delete (required).</param>
        public BulkRemoveSourceIntentsRequest(List<string> Items = null)
        {
            this.Items = Items;
            
        }
        


        /// <summary>
        /// List of ids to delete
        /// </summary>
        /// <value>List of ids to delete</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<string> Items { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkRemoveSourceIntentsRequest {\n");

            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(obj as BulkRemoveSourceIntentsRequest);
        }

        /// <summary>
        /// Returns true if BulkRemoveSourceIntentsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkRemoveSourceIntentsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkRemoveSourceIntentsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();

                return hash;
            }
        }
    }

}
