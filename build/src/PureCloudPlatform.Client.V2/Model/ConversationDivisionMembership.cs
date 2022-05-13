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
    /// ConversationDivisionMembership
    /// </summary>
    [DataContract]
    public partial class ConversationDivisionMembership :  IEquatable<ConversationDivisionMembership>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationDivisionMembership" /> class.
        /// </summary>
        /// <param name="Division">A division the conversation belongs to..</param>
        /// <param name="Entities">The entities on the conversation within the division. These are the users, queues, work flows, etc. that can be on conversations and and be assigned to different divisions..</param>
        public ConversationDivisionMembership(DomainEntityRef Division = null, List<DomainEntityRef> Entities = null)
        {
            this.Division = Division;
            this.Entities = Entities;
            
        }
        


        /// <summary>
        /// A division the conversation belongs to.
        /// </summary>
        /// <value>A division the conversation belongs to.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public DomainEntityRef Division { get; set; }



        /// <summary>
        /// The entities on the conversation within the division. These are the users, queues, work flows, etc. that can be on conversations and and be assigned to different divisions.
        /// </summary>
        /// <value>The entities on the conversation within the division. These are the users, queues, work flows, etc. that can be on conversations and and be assigned to different divisions.</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<DomainEntityRef> Entities { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationDivisionMembership {\n");

            sb.Append("  Division: ").Append(Division).Append("\n");
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
            return this.Equals(obj as ConversationDivisionMembership);
        }

        /// <summary>
        /// Returns true if ConversationDivisionMembership instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationDivisionMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationDivisionMembership other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
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
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                return hash;
            }
        }
    }

}
