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
    /// Used to retrieve a set of executionData history by the respective ids
    /// </summary>
    [DataContract]
    public partial class ExecutionDataRequest :  IEquatable<ExecutionDataRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionDataRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExecutionDataRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionDataRequest" /> class.
        /// </summary>
        /// <param name="Ids">A list of ids to retrieve (required).</param>
        public ExecutionDataRequest(List<string> Ids = null)
        {
            this.Ids = Ids;
            
        }
        


        /// <summary>
        /// A list of ids to retrieve
        /// </summary>
        /// <value>A list of ids to retrieve</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionDataRequest {\n");

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
            return this.Equals(obj as ExecutionDataRequest);
        }

        /// <summary>
        /// Returns true if ExecutionDataRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ExecutionDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecutionDataRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                if (this.Ids != null)
                    hash = hash * 59 + this.Ids.GetHashCode();

                return hash;
            }
        }
    }

}
