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
    /// BulkResult
    /// </summary>
    [DataContract]
    public partial class BulkResult :  IEquatable<BulkResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResult" /> class.
        /// </summary>
        /// <param name="Error">Error details if the operation failed..</param>
        /// <param name="Entity">The result of the operation if it succeeded..</param>
        public BulkResult(BulkError Error = null, Object Entity = null)
        {
            this.Error = Error;
            this.Entity = Entity;
            
        }
        


        /// <summary>
        /// Error details if the operation failed.
        /// </summary>
        /// <value>Error details if the operation failed.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public BulkError Error { get; set; }



        /// <summary>
        /// The result of the operation if it succeeded.
        /// </summary>
        /// <value>The result of the operation if it succeeded.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Object Entity { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkResult {\n");

            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
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
            return this.Equals(obj as BulkResult);
        }

        /// <summary>
        /// Returns true if BulkResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
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
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.Entity != null)
                    hash = hash * 59 + this.Entity.GetHashCode();

                return hash;
            }
        }
    }

}
