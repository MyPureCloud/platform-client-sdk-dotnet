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
    /// AgentOwnedMappingPreview
    /// </summary>
    [DataContract]
    public partial class AgentOwnedMappingPreview :  IEquatable<AgentOwnedMappingPreview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOwnedMappingPreview" /> class.
        /// </summary>
        public AgentOwnedMappingPreview()
        {
            
        }
        


        /// <summary>
        /// The raw value of the agent-owned column
        /// </summary>
        /// <value>The raw value of the agent-owned column</value>
        [DataMember(Name="agentOwnedColumn", EmitDefaultValue=false)]
        public string AgentOwnedColumn { get; private set; }



        /// <summary>
        /// The email address of the user, if it exists
        /// </summary>
        /// <value>The email address of the user, if it exists</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; private set; }



        /// <summary>
        /// The id of the user, if it exists
        /// </summary>
        /// <value>The id of the user, if it exists</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; private set; }



        /// <summary>
        /// Whether the user exists
        /// </summary>
        /// <value>Whether the user exists</value>
        [DataMember(Name="exists", EmitDefaultValue=false)]
        public bool? Exists { get; private set; }



        /// <summary>
        /// Whether the user is a member of the campaign&#39;s queue
        /// </summary>
        /// <value>Whether the user is a member of the campaign&#39;s queue</value>
        [DataMember(Name="isQueueMember", EmitDefaultValue=false)]
        public bool? IsQueueMember { get; private set; }



        /// <summary>
        /// The number of contact records whose agent-owned column matches the raw value
        /// </summary>
        /// <value>The number of contact records whose agent-owned column matches the raw value</value>
        [DataMember(Name="recordCount", EmitDefaultValue=false)]
        public int? RecordCount { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentOwnedMappingPreview {\n");

            sb.Append("  AgentOwnedColumn: ").Append(AgentOwnedColumn).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Exists: ").Append(Exists).Append("\n");
            sb.Append("  IsQueueMember: ").Append(IsQueueMember).Append("\n");
            sb.Append("  RecordCount: ").Append(RecordCount).Append("\n");
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
            return this.Equals(obj as AgentOwnedMappingPreview);
        }

        /// <summary>
        /// Returns true if AgentOwnedMappingPreview instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentOwnedMappingPreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentOwnedMappingPreview other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AgentOwnedColumn == other.AgentOwnedColumn ||
                    this.AgentOwnedColumn != null &&
                    this.AgentOwnedColumn.Equals(other.AgentOwnedColumn)
                ) &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.Exists == other.Exists ||
                    this.Exists != null &&
                    this.Exists.Equals(other.Exists)
                ) &&
                (
                    this.IsQueueMember == other.IsQueueMember ||
                    this.IsQueueMember != null &&
                    this.IsQueueMember.Equals(other.IsQueueMember)
                ) &&
                (
                    this.RecordCount == other.RecordCount ||
                    this.RecordCount != null &&
                    this.RecordCount.Equals(other.RecordCount)
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
                if (this.AgentOwnedColumn != null)
                    hash = hash * 59 + this.AgentOwnedColumn.GetHashCode();

                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.Exists != null)
                    hash = hash * 59 + this.Exists.GetHashCode();

                if (this.IsQueueMember != null)
                    hash = hash * 59 + this.IsQueueMember.GetHashCode();

                if (this.RecordCount != null)
                    hash = hash * 59 + this.RecordCount.GetHashCode();

                return hash;
            }
        }
    }

}
