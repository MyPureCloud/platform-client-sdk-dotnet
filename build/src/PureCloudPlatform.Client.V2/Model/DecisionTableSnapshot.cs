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
    /// DecisionTableSnapshot
    /// </summary>
    [DataContract]
    public partial class DecisionTableSnapshot :  IEquatable<DecisionTableSnapshot>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionTableSnapshot" /> class.
        /// </summary>
        /// <param name="Name">Snapshot name.</param>
        /// <param name="Notes">Optional snapshot notes.</param>
        public DecisionTableSnapshot(string Name = null, string Notes = null)
        {
            this.Name = Name;
            this.Notes = Notes;
            
        }
        


        /// <summary>
        /// Snapshot name
        /// </summary>
        /// <value>Snapshot name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Optional snapshot notes
        /// </summary>
        /// <value>Optional snapshot notes</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }



        /// <summary>
        /// UTC date time when the snapshot was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>UTC date time when the snapshot was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// The user who created the snapshot.
        /// </summary>
        /// <value>The user who created the snapshot.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public AddressableEntityRef CreatedBy { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DecisionTableSnapshot {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return this.Equals(obj as DecisionTableSnapshot);
        }

        /// <summary>
        /// Returns true if DecisionTableSnapshot instances are equal
        /// </summary>
        /// <param name="other">Instance of DecisionTableSnapshot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DecisionTableSnapshot other)
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
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
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

                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                return hash;
            }
        }
    }

}
