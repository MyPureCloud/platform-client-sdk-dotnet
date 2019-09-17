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
    /// RecordingJobsQuery
    /// </summary>
    [DataContract]
    public partial class RecordingJobsQuery :  IEquatable<RecordingJobsQuery>
    {
        
        
        /// <summary>
        /// Operation to perform bulk task
        /// </summary>
        /// <value>Operation to perform bulk task</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Delete for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            Delete,
            
            /// <summary>
            /// Enum Export for "EXPORT"
            /// </summary>
            [EnumMember(Value = "EXPORT")]
            Export
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Operation to perform bulk task
        /// </summary>
        /// <value>Operation to perform bulk task</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingJobsQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecordingJobsQuery() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingJobsQuery" /> class.
        /// </summary>
        /// <param name="Action">Operation to perform bulk task (required).</param>
        /// <param name="ActionDate">The date when the action will be performed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        /// <param name="IntegrationId">Integration ID (Required only for EXPORT action).</param>
        /// <param name="IncludeScreenRecordings">Include Screen recordings for export action, default value = true .</param>
        /// <param name="ConversationQuery">Conversation Query. Note: After the recording is created, it might take up to 48 hours for the recording to be included in the submitted job query. (required).</param>
        public RecordingJobsQuery(ActionEnum? Action = null, DateTime? ActionDate = null, string IntegrationId = null, bool? IncludeScreenRecordings = null, AsyncConversationQuery ConversationQuery = null)
        {
            this.Action = Action;
            this.ActionDate = ActionDate;
            this.IntegrationId = IntegrationId;
            this.IncludeScreenRecordings = IncludeScreenRecordings;
            this.ConversationQuery = ConversationQuery;
            
        }
        
        
        
        
        
        /// <summary>
        /// The date when the action will be performed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date when the action will be performed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="actionDate", EmitDefaultValue=false)]
        public DateTime? ActionDate { get; set; }
        
        
        
        /// <summary>
        /// Integration ID (Required only for EXPORT action)
        /// </summary>
        /// <value>Integration ID (Required only for EXPORT action)</value>
        [DataMember(Name="integrationId", EmitDefaultValue=false)]
        public string IntegrationId { get; set; }
        
        
        
        /// <summary>
        /// Include Screen recordings for export action, default value = true 
        /// </summary>
        /// <value>Include Screen recordings for export action, default value = true </value>
        [DataMember(Name="includeScreenRecordings", EmitDefaultValue=false)]
        public bool? IncludeScreenRecordings { get; set; }
        
        
        
        /// <summary>
        /// Conversation Query. Note: After the recording is created, it might take up to 48 hours for the recording to be included in the submitted job query.
        /// </summary>
        /// <value>Conversation Query. Note: After the recording is created, it might take up to 48 hours for the recording to be included in the submitted job query.</value>
        [DataMember(Name="conversationQuery", EmitDefaultValue=false)]
        public AsyncConversationQuery ConversationQuery { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingJobsQuery {\n");
            
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionDate: ").Append(ActionDate).Append("\n");
            sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
            sb.Append("  IncludeScreenRecordings: ").Append(IncludeScreenRecordings).Append("\n");
            sb.Append("  ConversationQuery: ").Append(ConversationQuery).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RecordingJobsQuery);
        }

        /// <summary>
        /// Returns true if RecordingJobsQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingJobsQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingJobsQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.ActionDate == other.ActionDate ||
                    this.ActionDate != null &&
                    this.ActionDate.Equals(other.ActionDate)
                ) &&
                (
                    this.IntegrationId == other.IntegrationId ||
                    this.IntegrationId != null &&
                    this.IntegrationId.Equals(other.IntegrationId)
                ) &&
                (
                    this.IncludeScreenRecordings == other.IncludeScreenRecordings ||
                    this.IncludeScreenRecordings != null &&
                    this.IncludeScreenRecordings.Equals(other.IncludeScreenRecordings)
                ) &&
                (
                    this.ConversationQuery == other.ConversationQuery ||
                    this.ConversationQuery != null &&
                    this.ConversationQuery.Equals(other.ConversationQuery)
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
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.ActionDate != null)
                    hash = hash * 59 + this.ActionDate.GetHashCode();
                
                if (this.IntegrationId != null)
                    hash = hash * 59 + this.IntegrationId.GetHashCode();
                
                if (this.IncludeScreenRecordings != null)
                    hash = hash * 59 + this.IncludeScreenRecordings.GetHashCode();
                
                if (this.ConversationQuery != null)
                    hash = hash * 59 + this.ConversationQuery.GetHashCode();
                
                return hash;
            }
        }
    }

}
