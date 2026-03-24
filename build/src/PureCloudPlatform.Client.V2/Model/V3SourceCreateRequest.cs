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
    /// V3SourceCreateRequest
    /// </summary>
    [DataContract]
    public partial class V3SourceCreateRequest :  IEquatable<V3SourceCreateRequest>
    {
        /// <summary>
        /// The type of the source. Required if connectionId is not specified, inherits the connection type otherwise.
        /// </summary>
        /// <value>The type of the source. Required if connectionId is not specified, inherits the connection type otherwise.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sharepoint for "Sharepoint"
            /// </summary>
            [EnumMember(Value = "Sharepoint")]
            Sharepoint,
            
            /// <summary>
            /// Enum Fileupload for "FileUpload"
            /// </summary>
            [EnumMember(Value = "FileUpload")]
            Fileupload
        }
        /// <summary>
        /// The trigger type of the source. Default is Manual.
        /// </summary>
        /// <value>The trigger type of the source. Default is Manual.</value>
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
            Manual
        }
        /// <summary>
        /// The type of the source. Required if connectionId is not specified, inherits the connection type otherwise.
        /// </summary>
        /// <value>The type of the source. Required if connectionId is not specified, inherits the connection type otherwise.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The trigger type of the source. Default is Manual.
        /// </summary>
        /// <value>The trigger type of the source. Default is Manual.</value>
        [DataMember(Name="triggerType", EmitDefaultValue=false)]
        public TriggerTypeEnum? TriggerType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V3SourceCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V3SourceCreateRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the source. (required).</param>
        /// <param name="Type">The type of the source. Required if connectionId is not specified, inherits the connection type otherwise..</param>
        /// <param name="ConnectionId">The id of the connection related to the source. Required if type is Sharepoint..</param>
        /// <param name="TriggerType">The trigger type of the source. Default is Manual..</param>
        /// <param name="ScheduleSettings">Settings that determine when the source starts a sync. Required if triggerType is Scheduled..</param>
        /// <param name="Filters">Filters that determine what documents are synced..</param>
        public V3SourceCreateRequest(string Name = null, TypeEnum? Type = null, string ConnectionId = null, TriggerTypeEnum? TriggerType = null, V3SourceScheduleSettings ScheduleSettings = null, V3SourceFilter Filters = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.ConnectionId = ConnectionId;
            this.TriggerType = TriggerType;
            this.ScheduleSettings = ScheduleSettings;
            this.Filters = Filters;
            
        }
        


        /// <summary>
        /// The name of the source.
        /// </summary>
        /// <value>The name of the source.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// The id of the connection related to the source. Required if type is Sharepoint.
        /// </summary>
        /// <value>The id of the connection related to the source. Required if type is Sharepoint.</value>
        [DataMember(Name="connectionId", EmitDefaultValue=false)]
        public string ConnectionId { get; set; }





        /// <summary>
        /// Settings that determine when the source starts a sync. Required if triggerType is Scheduled.
        /// </summary>
        /// <value>Settings that determine when the source starts a sync. Required if triggerType is Scheduled.</value>
        [DataMember(Name="scheduleSettings", EmitDefaultValue=false)]
        public V3SourceScheduleSettings ScheduleSettings { get; set; }



        /// <summary>
        /// Filters that determine what documents are synced.
        /// </summary>
        /// <value>Filters that determine what documents are synced.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public V3SourceFilter Filters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V3SourceCreateRequest {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ConnectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  ScheduleSettings: ").Append(ScheduleSettings).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(obj as V3SourceCreateRequest);
        }

        /// <summary>
        /// Returns true if V3SourceCreateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of V3SourceCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V3SourceCreateRequest other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ConnectionId == other.ConnectionId ||
                    this.ConnectionId != null &&
                    this.ConnectionId.Equals(other.ConnectionId)
                ) &&
                (
                    this.TriggerType == other.TriggerType ||
                    this.TriggerType != null &&
                    this.TriggerType.Equals(other.TriggerType)
                ) &&
                (
                    this.ScheduleSettings == other.ScheduleSettings ||
                    this.ScheduleSettings != null &&
                    this.ScheduleSettings.Equals(other.ScheduleSettings)
                ) &&
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.Equals(other.Filters)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.ConnectionId != null)
                    hash = hash * 59 + this.ConnectionId.GetHashCode();

                if (this.TriggerType != null)
                    hash = hash * 59 + this.TriggerType.GetHashCode();

                if (this.ScheduleSettings != null)
                    hash = hash * 59 + this.ScheduleSettings.GetHashCode();

                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();

                return hash;
            }
        }
    }

}
