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
    /// Activity code data
    /// </summary>
    [DataContract]
    public partial class ActivityCode :  IEquatable<ActivityCode>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The activity code's category.
        /// </summary>
        /// <value>The activity code's category.</value>
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
            /// Enum Onqueuework for "OnQueueWork"
            /// </summary>
            [EnumMember(Value = "OnQueueWork")]
            Onqueuework,
            
            /// <summary>
            /// Enum Break for "Break"
            /// </summary>
            [EnumMember(Value = "Break")]
            Break,
            
            /// <summary>
            /// Enum Meal for "Meal"
            /// </summary>
            [EnumMember(Value = "Meal")]
            Meal,
            
            /// <summary>
            /// Enum Meeting for "Meeting"
            /// </summary>
            [EnumMember(Value = "Meeting")]
            Meeting,
            
            /// <summary>
            /// Enum Offqueuework for "OffQueueWork"
            /// </summary>
            [EnumMember(Value = "OffQueueWork")]
            Offqueuework,
            
            /// <summary>
            /// Enum Timeoff for "TimeOff"
            /// </summary>
            [EnumMember(Value = "TimeOff")]
            Timeoff,
            
            /// <summary>
            /// Enum Training for "Training"
            /// </summary>
            [EnumMember(Value = "Training")]
            Training,
            
            /// <summary>
            /// Enum Unavailable for "Unavailable"
            /// </summary>
            [EnumMember(Value = "Unavailable")]
            Unavailable,
            
            /// <summary>
            /// Enum Unscheduled for "Unscheduled"
            /// </summary>
            [EnumMember(Value = "Unscheduled")]
            Unscheduled
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The activity code's category.
        /// </summary>
        /// <value>The activity code's category.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityCode() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCode" /> class.
        /// </summary>
        /// <param name="Name">The name of the activity code. Default activity codes will be created with an empty name.</param>
        /// <param name="IsActive">Whether this activity code is active or has been deleted.</param>
        /// <param name="IsDefault">Whether this is a default activity code.</param>
        /// <param name="Category">The activity code&#39;s category..</param>
        /// <param name="LengthInMinutes">The default length of the activity in minutes.</param>
        /// <param name="CountsAsPaidTime">Whether an agent is paid while performing this activity.</param>
        /// <param name="CountsAsWorkTime">Indicates whether or not the activity should be counted as contiguous work time for calculating daily constraints.</param>
        /// <param name="AgentTimeOffSelectable">Whether an agent can select this activity code when creating or editing a time off request. Null if the activity&#39;s category is not time off..</param>
        /// <param name="Metadata">Version metadata for the associated management unit&#39;s list of activity codes (required).</param>
        public ActivityCode(string Name = null, bool? IsActive = null, bool? IsDefault = null, CategoryEnum? Category = null, int? LengthInMinutes = null, bool? CountsAsPaidTime = null, bool? CountsAsWorkTime = null, bool? AgentTimeOffSelectable = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Name = Name;
            this.IsActive = IsActive;
            this.IsDefault = IsDefault;
            this.Category = Category;
            this.LengthInMinutes = LengthInMinutes;
            this.CountsAsPaidTime = CountsAsPaidTime;
            this.CountsAsWorkTime = CountsAsWorkTime;
            this.AgentTimeOffSelectable = AgentTimeOffSelectable;
            this.Metadata = Metadata;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        
        /// <summary>
        /// The name of the activity code. Default activity codes will be created with an empty name
        /// </summary>
        /// <value>The name of the activity code. Default activity codes will be created with an empty name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Whether this activity code is active or has been deleted
        /// </summary>
        /// <value>Whether this activity code is active or has been deleted</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }
        
        
        
        /// <summary>
        /// Whether this is a default activity code
        /// </summary>
        /// <value>Whether this is a default activity code</value>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }
        
        
        
        
        
        /// <summary>
        /// The default length of the activity in minutes
        /// </summary>
        /// <value>The default length of the activity in minutes</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }
        
        
        
        /// <summary>
        /// Whether an agent is paid while performing this activity
        /// </summary>
        /// <value>Whether an agent is paid while performing this activity</value>
        [DataMember(Name="countsAsPaidTime", EmitDefaultValue=false)]
        public bool? CountsAsPaidTime { get; set; }
        
        
        
        /// <summary>
        /// Indicates whether or not the activity should be counted as contiguous work time for calculating daily constraints
        /// </summary>
        /// <value>Indicates whether or not the activity should be counted as contiguous work time for calculating daily constraints</value>
        [DataMember(Name="countsAsWorkTime", EmitDefaultValue=false)]
        public bool? CountsAsWorkTime { get; set; }
        
        
        
        /// <summary>
        /// Whether an agent can select this activity code when creating or editing a time off request. Null if the activity&#39;s category is not time off.
        /// </summary>
        /// <value>Whether an agent can select this activity code when creating or editing a time off request. Null if the activity&#39;s category is not time off.</value>
        [DataMember(Name="agentTimeOffSelectable", EmitDefaultValue=false)]
        public bool? AgentTimeOffSelectable { get; set; }
        
        
        
        /// <summary>
        /// Version metadata for the associated management unit&#39;s list of activity codes
        /// </summary>
        /// <value>Version metadata for the associated management unit&#39;s list of activity codes</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityCode {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
            sb.Append("  CountsAsWorkTime: ").Append(CountsAsWorkTime).Append("\n");
            sb.Append("  AgentTimeOffSelectable: ").Append(AgentTimeOffSelectable).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as ActivityCode);
        }

        /// <summary>
        /// Returns true if ActivityCode instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityCode other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) &&
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.LengthInMinutes == other.LengthInMinutes ||
                    this.LengthInMinutes != null &&
                    this.LengthInMinutes.Equals(other.LengthInMinutes)
                ) &&
                (
                    this.CountsAsPaidTime == other.CountsAsPaidTime ||
                    this.CountsAsPaidTime != null &&
                    this.CountsAsPaidTime.Equals(other.CountsAsPaidTime)
                ) &&
                (
                    this.CountsAsWorkTime == other.CountsAsWorkTime ||
                    this.CountsAsWorkTime != null &&
                    this.CountsAsWorkTime.Equals(other.CountsAsWorkTime)
                ) &&
                (
                    this.AgentTimeOffSelectable == other.AgentTimeOffSelectable ||
                    this.AgentTimeOffSelectable != null &&
                    this.AgentTimeOffSelectable.Equals(other.AgentTimeOffSelectable)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();
                
                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();
                
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                
                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();
                
                if (this.CountsAsPaidTime != null)
                    hash = hash * 59 + this.CountsAsPaidTime.GetHashCode();
                
                if (this.CountsAsWorkTime != null)
                    hash = hash * 59 + this.CountsAsWorkTime.GetHashCode();
                
                if (this.AgentTimeOffSelectable != null)
                    hash = hash * 59 + this.AgentTimeOffSelectable.GetHashCode();
                
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                
                return hash;
            }
        }
    }

}
