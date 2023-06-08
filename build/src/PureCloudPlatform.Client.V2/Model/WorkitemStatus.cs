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
    /// WorkitemStatus
    /// </summary>
    [DataContract]
    public partial class WorkitemStatus :  IEquatable<WorkitemStatus>
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
        /// Initializes a new instance of the <see cref="WorkitemStatus" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Category">The Category of the Status..</param>
        /// <param name="DestinationStatuses">The Statuses the Status can transition to..</param>
        /// <param name="Description">The description of the Status..</param>
        /// <param name="DefaultDestinationStatus">Default destination status to which this Status will transition to if auto status transition enabled..</param>
        /// <param name="StatusTransitionDelaySeconds">Delay in seconds for auto status transition.</param>
        /// <param name="StatusTransitionTime">Time in HH:MM:SS format at which auto status transition will occur after statusTransitionDelaySeconds delay. To set Time, the statusTransitionDelaySeconds must be equal to or greater than 86400 i.e. a day.</param>
        /// <param name="Worktype">The Worktype containing the Status..</param>
        public WorkitemStatus(string Name = null, CategoryEnum? Category = null, List<WorkitemStatusReference> DestinationStatuses = null, string Description = null, WorkitemStatusReference DefaultDestinationStatus = null, int? StatusTransitionDelaySeconds = null, DateTime? StatusTransitionTime = null, WorktypeReference Worktype = null)
        {
            this.Name = Name;
            this.Category = Category;
            this.DestinationStatuses = DestinationStatuses;
            this.Description = Description;
            this.DefaultDestinationStatus = DefaultDestinationStatus;
            this.StatusTransitionDelaySeconds = StatusTransitionDelaySeconds;
            this.StatusTransitionTime = StatusTransitionTime;
            this.Worktype = Worktype;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// The Statuses the Status can transition to.
        /// </summary>
        /// <value>The Statuses the Status can transition to.</value>
        [DataMember(Name="destinationStatuses", EmitDefaultValue=false)]
        public List<WorkitemStatusReference> DestinationStatuses { get; set; }



        /// <summary>
        /// The description of the Status.
        /// </summary>
        /// <value>The description of the Status.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Default destination status to which this Status will transition to if auto status transition enabled.
        /// </summary>
        /// <value>Default destination status to which this Status will transition to if auto status transition enabled.</value>
        [DataMember(Name="defaultDestinationStatus", EmitDefaultValue=false)]
        public WorkitemStatusReference DefaultDestinationStatus { get; set; }



        /// <summary>
        /// Delay in seconds for auto status transition
        /// </summary>
        /// <value>Delay in seconds for auto status transition</value>
        [DataMember(Name="statusTransitionDelaySeconds", EmitDefaultValue=false)]
        public int? StatusTransitionDelaySeconds { get; set; }



        /// <summary>
        /// Time in HH:MM:SS format at which auto status transition will occur after statusTransitionDelaySeconds delay. To set Time, the statusTransitionDelaySeconds must be equal to or greater than 86400 i.e. a day
        /// </summary>
        /// <value>Time in HH:MM:SS format at which auto status transition will occur after statusTransitionDelaySeconds delay. To set Time, the statusTransitionDelaySeconds must be equal to or greater than 86400 i.e. a day</value>
        [DataMember(Name="statusTransitionTime", EmitDefaultValue=false)]
        public DateTime? StatusTransitionTime { get; set; }



        /// <summary>
        /// The Worktype containing the Status.
        /// </summary>
        /// <value>The Worktype containing the Status.</value>
        [DataMember(Name="worktype", EmitDefaultValue=false)]
        public WorktypeReference Worktype { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemStatus {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DestinationStatuses: ").Append(DestinationStatuses).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultDestinationStatus: ").Append(DefaultDestinationStatus).Append("\n");
            sb.Append("  StatusTransitionDelaySeconds: ").Append(StatusTransitionDelaySeconds).Append("\n");
            sb.Append("  StatusTransitionTime: ").Append(StatusTransitionTime).Append("\n");
            sb.Append("  Worktype: ").Append(Worktype).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as WorkitemStatus);
        }

        /// <summary>
        /// Returns true if WorkitemStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkitemStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkitemStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
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
                    this.DestinationStatuses == other.DestinationStatuses ||
                    this.DestinationStatuses != null &&
                    this.DestinationStatuses.SequenceEqual(other.DestinationStatuses)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DefaultDestinationStatus == other.DefaultDestinationStatus ||
                    this.DefaultDestinationStatus != null &&
                    this.DefaultDestinationStatus.Equals(other.DefaultDestinationStatus)
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
                ) &&
                (
                    this.Worktype == other.Worktype ||
                    this.Worktype != null &&
                    this.Worktype.Equals(other.Worktype)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();

                if (this.DestinationStatuses != null)
                    hash = hash * 59 + this.DestinationStatuses.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DefaultDestinationStatus != null)
                    hash = hash * 59 + this.DefaultDestinationStatus.GetHashCode();

                if (this.StatusTransitionDelaySeconds != null)
                    hash = hash * 59 + this.StatusTransitionDelaySeconds.GetHashCode();

                if (this.StatusTransitionTime != null)
                    hash = hash * 59 + this.StatusTransitionTime.GetHashCode();

                if (this.Worktype != null)
                    hash = hash * 59 + this.Worktype.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
