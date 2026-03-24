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
    /// V3SourceLastSynchronization
    /// </summary>
    [DataContract]
    public partial class V3SourceLastSynchronization :  IEquatable<V3SourceLastSynchronization>
    {
        /// <summary>
        /// The trigger type of the synchronization.
        /// </summary>
        /// <value>The trigger type of the synchronization.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TriggerTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Scheduled for "Scheduled"
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Manual for "Manual"
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The status of the synchronization.
        /// </summary>
        /// <value>The status of the synchronization.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inqueue for "InQueue"
            /// </summary>
            [EnumMember(Value = "InQueue")]
            Inqueue,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Postprocessing for "PostProcessing"
            /// </summary>
            [EnumMember(Value = "PostProcessing")]
            Postprocessing,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The status of the ingestion.
        /// </summary>
        /// <value>The status of the ingestion.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum IngestionStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Inqueue for "InQueue"
            /// </summary>
            [EnumMember(Value = "InQueue")]
            Inqueue,
            
            /// <summary>
            /// Enum Starting for "Starting"
            /// </summary>
            [EnumMember(Value = "Starting")]
            Starting,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Stopping for "Stopping"
            /// </summary>
            [EnumMember(Value = "Stopping")]
            Stopping,
            
            /// <summary>
            /// Enum Stopped for "Stopped"
            /// </summary>
            [EnumMember(Value = "Stopped")]
            Stopped
        }
        /// <summary>
        /// The trigger type of the synchronization.
        /// </summary>
        /// <value>The trigger type of the synchronization.</value>
        [DataMember(Name="triggerType", EmitDefaultValue=false)]
        public TriggerTypeEnum? TriggerType { get; set; }
        /// <summary>
        /// The status of the synchronization.
        /// </summary>
        /// <value>The status of the synchronization.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The status of the ingestion.
        /// </summary>
        /// <value>The status of the ingestion.</value>
        [DataMember(Name="ingestionStatus", EmitDefaultValue=false)]
        public IngestionStatusEnum? IngestionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceLastSynchronization" /> class.
        /// </summary>
        /// <param name="DateStart">The start time of the synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateEnd">The end time of the synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateSourceIntervalStart">The start time of the interval to be synchronized from the source. Source item changes during that interval are included in this synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateSourceIntervalEnd">The end time of the interval to be synchronized from the source. Source item changes during that interval are included in this synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="TriggerType">The trigger type of the synchronization..</param>
        /// <param name="Status">The status of the synchronization..</param>
        /// <param name="Statistics">Statistics of the synchronization..</param>
        /// <param name="Error">The error that occurred during the synchronization..</param>
        /// <param name="IngestionStatus">The status of the ingestion..</param>
        public V3SourceLastSynchronization(DateTime? DateStart = null, DateTime? DateEnd = null, DateTime? DateSourceIntervalStart = null, DateTime? DateSourceIntervalEnd = null, TriggerTypeEnum? TriggerType = null, StatusEnum? Status = null, V3SynchronizationStatistics Statistics = null, ErrorBody Error = null, IngestionStatusEnum? IngestionStatus = null)
        {
            this.DateStart = DateStart;
            this.DateEnd = DateEnd;
            this.DateSourceIntervalStart = DateSourceIntervalStart;
            this.DateSourceIntervalEnd = DateSourceIntervalEnd;
            this.TriggerType = TriggerType;
            this.Status = Status;
            this.Statistics = Statistics;
            this.Error = Error;
            this.IngestionStatus = IngestionStatus;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The start time of the synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start time of the synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateStart", EmitDefaultValue=false)]
        public DateTime? DateStart { get; set; }



        /// <summary>
        /// The end time of the synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The end time of the synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateEnd", EmitDefaultValue=false)]
        public DateTime? DateEnd { get; set; }



        /// <summary>
        /// The start time of the interval to be synchronized from the source. Source item changes during that interval are included in this synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The start time of the interval to be synchronized from the source. Source item changes during that interval are included in this synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateSourceIntervalStart", EmitDefaultValue=false)]
        public DateTime? DateSourceIntervalStart { get; set; }



        /// <summary>
        /// The end time of the interval to be synchronized from the source. Source item changes during that interval are included in this synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The end time of the interval to be synchronized from the source. Source item changes during that interval are included in this synchronization. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateSourceIntervalEnd", EmitDefaultValue=false)]
        public DateTime? DateSourceIntervalEnd { get; set; }







        /// <summary>
        /// Statistics of the synchronization.
        /// </summary>
        /// <value>Statistics of the synchronization.</value>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public V3SynchronizationStatistics Statistics { get; set; }



        /// <summary>
        /// The error that occurred during the synchronization.
        /// </summary>
        /// <value>The error that occurred during the synchronization.</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorBody Error { get; set; }





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
            sb.Append("class V3SourceLastSynchronization {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateStart: ").Append(DateStart).Append("\n");
            sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
            sb.Append("  DateSourceIntervalStart: ").Append(DateSourceIntervalStart).Append("\n");
            sb.Append("  DateSourceIntervalEnd: ").Append(DateSourceIntervalEnd).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  IngestionStatus: ").Append(IngestionStatus).Append("\n");
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
            return this.Equals(obj as V3SourceLastSynchronization);
        }

        /// <summary>
        /// Returns true if V3SourceLastSynchronization instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceLastSynchronization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceLastSynchronization other)
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
                    this.DateStart == other.DateStart ||
                    this.DateStart != null &&
                    this.DateStart.Equals(other.DateStart)
                ) &&
                (
                    this.DateEnd == other.DateEnd ||
                    this.DateEnd != null &&
                    this.DateEnd.Equals(other.DateEnd)
                ) &&
                (
                    this.DateSourceIntervalStart == other.DateSourceIntervalStart ||
                    this.DateSourceIntervalStart != null &&
                    this.DateSourceIntervalStart.Equals(other.DateSourceIntervalStart)
                ) &&
                (
                    this.DateSourceIntervalEnd == other.DateSourceIntervalEnd ||
                    this.DateSourceIntervalEnd != null &&
                    this.DateSourceIntervalEnd.Equals(other.DateSourceIntervalEnd)
                ) &&
                (
                    this.TriggerType == other.TriggerType ||
                    this.TriggerType != null &&
                    this.TriggerType.Equals(other.TriggerType)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Statistics == other.Statistics ||
                    this.Statistics != null &&
                    this.Statistics.Equals(other.Statistics)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) &&
                (
                    this.IngestionStatus == other.IngestionStatus ||
                    this.IngestionStatus != null &&
                    this.IngestionStatus.Equals(other.IngestionStatus)
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

                if (this.DateStart != null)
                    hash = hash * 59 + this.DateStart.GetHashCode();

                if (this.DateEnd != null)
                    hash = hash * 59 + this.DateEnd.GetHashCode();

                if (this.DateSourceIntervalStart != null)
                    hash = hash * 59 + this.DateSourceIntervalStart.GetHashCode();

                if (this.DateSourceIntervalEnd != null)
                    hash = hash * 59 + this.DateSourceIntervalEnd.GetHashCode();

                if (this.TriggerType != null)
                    hash = hash * 59 + this.TriggerType.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Statistics != null)
                    hash = hash * 59 + this.Statistics.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                if (this.IngestionStatus != null)
                    hash = hash * 59 + this.IngestionStatus.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
