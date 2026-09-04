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
    /// ContactSimpleSearch
    /// </summary>
    [DataContract]
    public partial class ContactSimpleSearch :  IEquatable<ContactSimpleSearch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactSimpleSearch" /> class.
        /// </summary>
        /// <param name="Query">User supplied search keywords (no special syntax is currently supported).</param>
        /// <param name="SortOrder">The External Contact field to sort by. Any of: [firstName, lastName, middleName, title]. Direction: [asc, desc]. e.g. \&quot;firstName:asc\&quot;, \&quot;title:desc\&quot;.</param>
        /// <param name="Ids">List of External Contact ids to exact match in search result. Optional filter, up to 100.</param>
        public ContactSimpleSearch(string Query = null, List<string> SortOrder = null, List<string> Ids = null)
        {
            this.Query = Query;
            this.SortOrder = SortOrder;
            this.Ids = Ids;
            
        }
        


        /// <summary>
        /// User supplied search keywords (no special syntax is currently supported)
        /// </summary>
        /// <value>User supplied search keywords (no special syntax is currently supported)</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }



        /// <summary>
        /// The External Contact field to sort by. Any of: [firstName, lastName, middleName, title]. Direction: [asc, desc]. e.g. \&quot;firstName:asc\&quot;, \&quot;title:desc\&quot;
        /// </summary>
        /// <value>The External Contact field to sort by. Any of: [firstName, lastName, middleName, title]. Direction: [asc, desc]. e.g. \&quot;firstName:asc\&quot;, \&quot;title:desc\&quot;</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public List<string> SortOrder { get; set; }



        /// <summary>
        /// List of External Contact ids to exact match in search result. Optional filter, up to 100
        /// </summary>
        /// <value>List of External Contact ids to exact match in search result. Optional filter, up to 100</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactSimpleSearch {\n");

            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
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
            return this.Equals(obj as ContactSimpleSearch);
        }

        /// <summary>
        /// Returns true if ContactSimpleSearch instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactSimpleSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactSimpleSearch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) &&
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.SequenceEqual(other.SortOrder)
                ) &&
                (
                    this.Ids == other.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(other.Ids)
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
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();

                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();

                if (this.Ids != null)
                    hash = hash * 59 + this.Ids.GetHashCode();

                return hash;
            }
        }
    }

}
