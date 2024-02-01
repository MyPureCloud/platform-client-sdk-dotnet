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
    /// WorkitemStatusCreate
    /// </summary>
    [DataContract]
    public partial class WorkitemStatusCreate :  IEquatable<WorkitemStatusCreate>
    {
        /// <summary>
        /// The Category of the Status.
        /// </summary>
        /// <value>The Category of the Status.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CategoryEnum
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
        /// The Category of the Status.
        /// </summary>
        /// <value>The Category of the Status.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemStatusCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkitemStatusCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkitemStatusCreate" /> class.
        /// </summary>
        /// <param name="Name">The name of the Status. Valid length between 3 and 256 characters. (required).</param>
        /// <param name="Category">The Category of the Status. (required).</param>
        /// <param name="DestinationStatusIds">A list of destination Statuses where a Workitem with this Status can transition to. If the list is empty Workitems with this Status can transition to all other Statuses defined on the Worktype. A Status can have a maximum of 24 destinations..</param>
        /// <param name="Description">The description of the Status. Maximum length of 4096 characters..</param>
        /// <param name="DefaultDestinationStatusId">Default destination status to which this Status will transition to if auto status transition enabled..</param>
        /// <param name="StatusTransitionDelaySeconds">Delay in seconds for auto status transition. Required if defaultDestinationStatusId is provided..</param>
        /// <param name="StatusTransitionTime">Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS.</param>
        public WorkitemStatusCreate(string Name = null, CategoryEnum? Category = null, List<string> DestinationStatusIds = null, string Description = null, string DefaultDestinationStatusId = null, int? StatusTransitionDelaySeconds = null, string StatusTransitionTime = null)
        {
            this.Name = Name;
            this.Category = Category;
            this.DestinationStatusIds = DestinationStatusIds;
            this.Description = Description;
            this.DefaultDestinationStatusId = DefaultDestinationStatusId;
            this.StatusTransitionDelaySeconds = StatusTransitionDelaySeconds;
            this.StatusTransitionTime = StatusTransitionTime;
            
        }
        


        /// <summary>
        /// The name of the Status. Valid length between 3 and 256 characters.
        /// </summary>
        /// <value>The name of the Status. Valid length between 3 and 256 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// A list of destination Statuses where a Workitem with this Status can transition to. If the list is empty Workitems with this Status can transition to all other Statuses defined on the Worktype. A Status can have a maximum of 24 destinations.
        /// </summary>
        /// <value>A list of destination Statuses where a Workitem with this Status can transition to. If the list is empty Workitems with this Status can transition to all other Statuses defined on the Worktype. A Status can have a maximum of 24 destinations.</value>
        [DataMember(Name="destinationStatusIds", EmitDefaultValue=false)]
        public List<string> DestinationStatusIds { get; set; }



        /// <summary>
        /// The description of the Status. Maximum length of 4096 characters.
        /// </summary>
        /// <value>The description of the Status. Maximum length of 4096 characters.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Default destination status to which this Status will transition to if auto status transition enabled.
        /// </summary>
        /// <value>Default destination status to which this Status will transition to if auto status transition enabled.</value>
        [DataMember(Name="defaultDestinationStatusId", EmitDefaultValue=false)]
        public string DefaultDestinationStatusId { get; set; }



        /// <summary>
        /// Delay in seconds for auto status transition. Required if defaultDestinationStatusId is provided.
        /// </summary>
        /// <value>Delay in seconds for auto status transition. Required if defaultDestinationStatusId is provided.</value>
        [DataMember(Name="statusTransitionDelaySeconds", EmitDefaultValue=false)]
        public int? StatusTransitionDelaySeconds { get; set; }



        /// <summary>
        /// Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS
        /// </summary>
        /// <value>Time is represented as an ISO-8601 string without a timezone. For example: HH:mm:ss.SSS</value>
        [DataMember(Name="statusTransitionTime", EmitDefaultValue=false)]
        public string StatusTransitionTime { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemStatusCreate {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DestinationStatusIds: ").Append(DestinationStatusIds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultDestinationStatusId: ").Append(DefaultDestinationStatusId).Append("\n");
            sb.Append("  StatusTransitionDelaySeconds: ").Append(StatusTransitionDelaySeconds).Append("\n");
            sb.Append("  StatusTransitionTime: ").Append(StatusTransitionTime).Append("\n");
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
            return this.Equals(obj as WorkitemStatusCreate);
        }

        /// <summary>
        /// Returns true if WorkitemStatusCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemStatusCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemStatusCreate other)
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
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.DestinationStatusIds == other.DestinationStatusIds ||
                    this.DestinationStatusIds != null &&
                    this.DestinationStatusIds.SequenceEqual(other.DestinationStatusIds)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DefaultDestinationStatusId == other.DefaultDestinationStatusId ||
                    this.DefaultDestinationStatusId != null &&
                    this.DefaultDestinationStatusId.Equals(other.DefaultDestinationStatusId)
                ) &&
                (
                    this.StatusTransitionDelaySeconds == other.StatusTransitionDelaySeconds ||
                    this.StatusTransitionDelaySeconds != null &&
                    this.StatusTransitionDelaySeconds.Equals(other.StatusTransitionDelaySeconds)
                ) &&
                (
                    this.StatusTransitionTime == other.StatusTransitionTime ||
                    this.StatusTransitionTime != null &&
                    this.StatusTransitionTime.Equals(other.StatusTransitionTime)
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

                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                if (this.DestinationStatusIds != null)
                    hash = hash * 59 + this.DestinationStatusIds.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DefaultDestinationStatusId != null)
                    hash = hash * 59 + this.DefaultDestinationStatusId.GetHashCode();

                if (this.StatusTransitionDelaySeconds != null)
                    hash = hash * 59 + this.StatusTransitionDelaySeconds.GetHashCode();

                if (this.StatusTransitionTime != null)
                    hash = hash * 59 + this.StatusTransitionTime.GetHashCode();

                return hash;
            }
        }
    }

}
