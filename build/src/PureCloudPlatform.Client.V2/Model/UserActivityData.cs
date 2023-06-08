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
    /// UserActivityData
    /// </summary>
    [DataContract]
    public partial class UserActivityData :  IEquatable<UserActivityData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActivityData" /> class.
        /// </summary>
        /// <param name="Group">A mapping from grouping dimension to value.</param>
        /// <param name="Data">Data for metrics.</param>
        /// <param name="Truncated">Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities..</param>
        /// <param name="Entities">Details for active entities.</param>
        public UserActivityData(Dictionary<string, string> Group = null, List<UserActivityMetricValue> Data = null, bool? Truncated = null, List<UserActivityEntityData> Entities = null)
        {
            this.Group = Group;
            this.Data = Data;
            this.Truncated = Truncated;
            this.Entities = Entities;
            
        }
        


        /// <summary>
        /// A mapping from grouping dimension to value
        /// </summary>
        /// <value>A mapping from grouping dimension to value</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public Dictionary<string, string> Group { get; set; }



        /// <summary>
        /// Data for metrics
        /// </summary>
        /// <value>Data for metrics</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<UserActivityMetricValue> Data { get; set; }



        /// <summary>
        /// Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities.
        /// </summary>
        /// <value>Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities.</value>
        [DataMember(Name="truncated", EmitDefaultValue=false)]
        public bool? Truncated { get; set; }



        /// <summary>
        /// Details for active entities
        /// </summary>
        /// <value>Details for active entities</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<UserActivityEntityData> Entities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserActivityData {\n");

            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Truncated: ").Append(Truncated).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(obj as UserActivityData);
        }

        /// <summary>
        /// Returns true if UserActivityData instances are equal
        /// </summary>
        /// <param name="other">Instance of UserActivityData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserActivityData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.SequenceEqual(other.Group)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) &&
                (
                    this.Truncated == other.Truncated ||
                    this.Truncated != null &&
                    this.Truncated.Equals(other.Truncated)
                ) &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
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
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();

                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();

                if (this.Truncated != null)
                    hash = hash * 59 + this.Truncated.GetHashCode();

                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                return hash;
            }
        }
    }

}
