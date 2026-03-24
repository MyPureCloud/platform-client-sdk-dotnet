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
    /// CaseAssociationCreate
    /// </summary>
    [DataContract]
    public partial class CaseAssociationCreate :  IEquatable<CaseAssociationCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseAssociationCreate" /> class.
        /// </summary>
        /// <param name="WorkitemId">The ID of the workitem to associate with the case..</param>
        /// <param name="ConversationId">The ID of the conversation to associate with the case..</param>
        public CaseAssociationCreate(string WorkitemId = null, string ConversationId = null)
        {
            this.WorkitemId = WorkitemId;
            this.ConversationId = ConversationId;
            
        }
        


        /// <summary>
        /// The ID of the workitem to associate with the case.
        /// </summary>
        /// <value>The ID of the workitem to associate with the case.</value>
        [DataMember(Name="workitemId", EmitDefaultValue=false)]
        public string WorkitemId { get; set; }



        /// <summary>
        /// The ID of the conversation to associate with the case.
        /// </summary>
        /// <value>The ID of the conversation to associate with the case.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseAssociationCreate {\n");

            sb.Append("  WorkitemId: ").Append(WorkitemId).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
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
            return this.Equals(obj as CaseAssociationCreate);
        }

        /// <summary>
        /// Returns true if CaseAssociationCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseAssociationCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseAssociationCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WorkitemId == other.WorkitemId ||
                    this.WorkitemId != null &&
                    this.WorkitemId.Equals(other.WorkitemId)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
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
                if (this.WorkitemId != null)
                    hash = hash * 59 + this.WorkitemId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                return hash;
            }
        }
    }

}
