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
    /// UpdateDecisionTableRequest
    /// </summary>
    [DataContract]
    public partial class UpdateDecisionTableRequest :  IEquatable<UpdateDecisionTableRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDecisionTableRequest" /> class.
        /// </summary>
        /// <param name="Name">The decision table name..</param>
        /// <param name="Description">The decision table description..</param>
        /// <param name="Columns">The column definitions for this decision table..</param>
        public UpdateDecisionTableRequest(string Name = null, string Description = null, UpdateDecisionTableColumnsRequest Columns = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Columns = Columns;
            
        }
        


        /// <summary>
        /// The decision table name.
        /// </summary>
        /// <value>The decision table name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The decision table description.
        /// </summary>
        /// <value>The decision table description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The column definitions for this decision table.
        /// </summary>
        /// <value>The column definitions for this decision table.</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public UpdateDecisionTableColumnsRequest Columns { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDecisionTableRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
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
            return this.Equals(obj as UpdateDecisionTableRequest);
        }

        /// <summary>
        /// Returns true if UpdateDecisionTableRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateDecisionTableRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDecisionTableRequest other)
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
                ) &&
                (
                    this.Columns == other.Columns ||
                    this.Columns != null &&
                    this.Columns.Equals(other.Columns)
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

                if (this.Columns != null)
                    hash = hash * 59 + this.Columns.GetHashCode();

                return hash;
            }
        }
    }

}
