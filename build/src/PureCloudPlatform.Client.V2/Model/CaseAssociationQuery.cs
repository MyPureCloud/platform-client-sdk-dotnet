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
    /// CaseAssociationQuery
    /// </summary>
    [DataContract]
    public partial class CaseAssociationQuery :  IEquatable<CaseAssociationQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseAssociationQuery" /> class.
        /// </summary>
        /// <param name="PageSize">The number of entities to return in the response..</param>
        /// <param name="After">The cursor that points to the end of the set of entities that has been returned..</param>
        /// <param name="WorkitemId">The Workitem ID to query by..</param>
        /// <param name="ConversationId">The conversation ID to query by..</param>
        public CaseAssociationQuery(int? PageSize = null, string After = null, string WorkitemId = null, string ConversationId = null)
        {
            this.PageSize = PageSize;
            this.After = After;
            this.WorkitemId = WorkitemId;
            this.ConversationId = ConversationId;
            
        }
        


        /// <summary>
        /// The number of entities to return in the response.
        /// </summary>
        /// <value>The number of entities to return in the response.</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }



        /// <summary>
        /// The cursor that points to the end of the set of entities that has been returned.
        /// </summary>
        /// <value>The cursor that points to the end of the set of entities that has been returned.</value>
        [DataMember(Name="after", EmitDefaultValue=false)]
        public string After { get; set; }



        /// <summary>
        /// The Workitem ID to query by.
        /// </summary>
        /// <value>The Workitem ID to query by.</value>
        [DataMember(Name="workitemId", EmitDefaultValue=false)]
        public string WorkitemId { get; set; }



        /// <summary>
        /// The conversation ID to query by.
        /// </summary>
        /// <value>The conversation ID to query by.</value>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseAssociationQuery {\n");

            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  After: ").Append(After).Append("\n");
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
            return this.Equals(obj as CaseAssociationQuery);
        }

        /// <summary>
        /// Returns true if CaseAssociationQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseAssociationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseAssociationQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) &&
                (
                    this.After == other.After ||
                    this.After != null &&
                    this.After.Equals(other.After)
                ) &&
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
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                if (this.After != null)
                    hash = hash * 59 + this.After.GetHashCode();

                if (this.WorkitemId != null)
                    hash = hash * 59 + this.WorkitemId.GetHashCode();

                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                return hash;
            }
        }
    }

}
