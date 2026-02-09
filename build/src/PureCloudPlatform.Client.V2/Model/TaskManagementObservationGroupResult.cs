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
    /// TaskManagementObservationGroupResult
    /// </summary>
    [DataContract]
    public partial class TaskManagementObservationGroupResult :  IEquatable<TaskManagementObservationGroupResult>
    {
        /// <summary>
        /// The status category for this group. Present when group includes statusCategory.
        /// </summary>
        /// <value>The status category for this group. Present when group includes statusCategory.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusCategoryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Waiting for "Waiting"
            /// </summary>
            [EnumMember(Value = "Waiting")]
            Waiting,
            
            /// <summary>
            /// Enum Closed for "Closed"
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The status category for this group. Present when group includes statusCategory.
        /// </summary>
        /// <value>The status category for this group. Present when group includes statusCategory.</value>
        [DataMember(Name="statusCategory", EmitDefaultValue=false)]
        public StatusCategoryEnum? StatusCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskManagementObservationGroupResult" /> class.
        /// </summary>
        /// <param name="QueueId">The queueId for this group..</param>
        /// <param name="TypeId">The typeId for this group. Present when group includes typeId..</param>
        /// <param name="AssigneeId">The assigneeId for this group. Present when group includes assigneeId..</param>
        /// <param name="StatusCategory">The status category for this group. Present when group includes statusCategory..</param>
        public TaskManagementObservationGroupResult(string QueueId = null, string TypeId = null, string AssigneeId = null, StatusCategoryEnum? StatusCategory = null)
        {
            this.QueueId = QueueId;
            this.TypeId = TypeId;
            this.AssigneeId = AssigneeId;
            this.StatusCategory = StatusCategory;
            
        }
        


        /// <summary>
        /// The queueId for this group.
        /// </summary>
        /// <value>The queueId for this group.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// The typeId for this group. Present when group includes typeId.
        /// </summary>
        /// <value>The typeId for this group. Present when group includes typeId.</value>
        [DataMember(Name="typeId", EmitDefaultValue=false)]
        public string TypeId { get; set; }



        /// <summary>
        /// The assigneeId for this group. Present when group includes assigneeId.
        /// </summary>
        /// <value>The assigneeId for this group. Present when group includes assigneeId.</value>
        [DataMember(Name="assigneeId", EmitDefaultValue=false)]
        public string AssigneeId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskManagementObservationGroupResult {\n");

            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
            sb.Append("  StatusCategory: ").Append(StatusCategory).Append("\n");
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
            return this.Equals(obj as TaskManagementObservationGroupResult);
        }

        /// <summary>
        /// Returns true if TaskManagementObservationGroupResult instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskManagementObservationGroupResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskManagementObservationGroupResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.TypeId == other.TypeId ||
                    this.TypeId != null &&
                    this.TypeId.Equals(other.TypeId)
                ) &&
                (
                    this.AssigneeId == other.AssigneeId ||
                    this.AssigneeId != null &&
                    this.AssigneeId.Equals(other.AssigneeId)
                ) &&
                (
                    this.StatusCategory == other.StatusCategory ||
                    this.StatusCategory != null &&
                    this.StatusCategory.Equals(other.StatusCategory)
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
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.TypeId != null)
                    hash = hash * 59 + this.TypeId.GetHashCode();

                if (this.AssigneeId != null)
                    hash = hash * 59 + this.AssigneeId.GetHashCode();

                if (this.StatusCategory != null)
                    hash = hash * 59 + this.StatusCategory.GetHashCode();

                return hash;
            }
        }
    }

}
