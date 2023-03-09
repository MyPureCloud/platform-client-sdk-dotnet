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
    /// JsonCursorSearchResponse
    /// </summary>
    [DataContract]
    public partial class JsonCursorSearchResponse :  IEquatable<JsonCursorSearchResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonCursorSearchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JsonCursorSearchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonCursorSearchResponse" /> class.
        /// </summary>
        /// <param name="Types">Resource types the search was performed against (required).</param>
        /// <param name="Results">Search results (required).</param>
        /// <param name="Aggregations">Aggregations.</param>
        /// <param name="Cursor">The page cursor.</param>
        public JsonCursorSearchResponse(List<string> Types = null, Object Results = null, Object Aggregations = null, string Cursor = null)
        {
            this.Types = Types;
            this.Results = Results;
            this.Aggregations = Aggregations;
            this.Cursor = Cursor;
            
        }
        


        /// <summary>
        /// Resource types the search was performed against
        /// </summary>
        /// <value>Resource types the search was performed against</value>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }



        /// <summary>
        /// Search results
        /// </summary>
        /// <value>Search results</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public Object Results { get; set; }



        /// <summary>
        /// Gets or Sets Aggregations
        /// </summary>
        [DataMember(Name="aggregations", EmitDefaultValue=false)]
        public Object Aggregations { get; set; }



        /// <summary>
        /// The page cursor
        /// </summary>
        /// <value>The page cursor</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonCursorSearchResponse {\n");

            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
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
            return this.Equals(obj as JsonCursorSearchResponse);
        }

        /// <summary>
        /// Returns true if JsonCursorSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonCursorSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonCursorSearchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) &&
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.Equals(other.Results)
                ) &&
                (
                    this.Aggregations == other.Aggregations ||
                    this.Aggregations != null &&
                    this.Aggregations.Equals(other.Aggregations)
                ) &&
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
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
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();

                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();

                if (this.Aggregations != null)
                    hash = hash * 59 + this.Aggregations.GetHashCode();

                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();

                return hash;
            }
        }
    }

}
