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
    /// AgentStateIsOutOfOfficeCount
    /// </summary>
    [DataContract]
    public partial class AgentStateIsOutOfOfficeCount :  IEquatable<AgentStateIsOutOfOfficeCount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStateIsOutOfOfficeCount" /> class.
        /// </summary>
        /// <param name="IsOutOfOffice">The out of office state.</param>
        /// <param name="Count">Count of users with this out of office state.</param>
        public AgentStateIsOutOfOfficeCount(bool? IsOutOfOffice = null, int? Count = null)
        {
            this.IsOutOfOffice = IsOutOfOffice;
            this.Count = Count;
            
        }
        


        /// <summary>
        /// The out of office state
        /// </summary>
        /// <value>The out of office state</value>
        [DataMember(Name="isOutOfOffice", EmitDefaultValue=false)]
        public bool? IsOutOfOffice { get; set; }



        /// <summary>
        /// Count of users with this out of office state
        /// </summary>
        /// <value>Count of users with this out of office state</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentStateIsOutOfOfficeCount {\n");

            sb.Append("  IsOutOfOffice: ").Append(IsOutOfOffice).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as AgentStateIsOutOfOfficeCount);
        }

        /// <summary>
        /// Returns true if AgentStateIsOutOfOfficeCount instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentStateIsOutOfOfficeCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentStateIsOutOfOfficeCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IsOutOfOffice == other.IsOutOfOffice ||
                    this.IsOutOfOffice != null &&
                    this.IsOutOfOffice.Equals(other.IsOutOfOffice)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.IsOutOfOffice != null)
                    hash = hash * 59 + this.IsOutOfOffice.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}
