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
    /// BusinessUnitActivityCode
    /// </summary>
    [DataContract]
    public partial class BusinessUnitActivityCode :  IEquatable<BusinessUnitActivityCode>
    {
        /// <summary>
        /// The category of the activity code
        /// </summary>
        /// <value>The category of the activity code</value>
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
        /// The category of the activity code
        /// </summary>
        /// <value>The category of the activity code</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessUnitActivityCode" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Active">Whether this activity code is active or has been deleted.</param>
        /// <param name="DefaultCode">Whether this is a default activity code.</param>
        /// <param name="Category">The category of the activity code.</param>
        /// <param name="LengthInMinutes">The default length of the activity in minutes.</param>
        /// <param name="CountsAsPaidTime">Whether an agent is paid while performing this activity.</param>
        /// <param name="CountsAsWorkTime">Indicates whether or not the activity should be counted as contiguous work time for calculating daily constraints.</param>
        /// <param name="AgentTimeOffSelectable">Whether an agent can select this activity code when creating or editing a time off request. Null if the activity's category is not time off..</param>
        /// <param name="CountsTowardShrinkage">Whether or not this activity code counts toward shrinkage calculations.</param>
        /// <param name="PlannedShrinkage">Whether this activity code is considered planned or unplanned shrinkage.</param>
        /// <param name="Interruptible">Whether this activity code is considered interruptible.</param>
        /// <param name="SecondaryPresences">The secondary presences of this activity code.</param>
        /// <param name="Metadata">Version metadata of this activity code.</param>
        public BusinessUnitActivityCode(string Name = null, bool? Active = null, bool? DefaultCode = null, CategoryEnum? Category = null, int? LengthInMinutes = null, bool? CountsAsPaidTime = null, bool? CountsAsWorkTime = null, bool? AgentTimeOffSelectable = null, bool? CountsTowardShrinkage = null, bool? PlannedShrinkage = null, bool? Interruptible = null, List<SecondaryPresence> SecondaryPresences = null, WfmVersionedEntityMetadata Metadata = null)
        {
            this.Name = Name;
            this.Active = Active;
            this.DefaultCode = DefaultCode;
            this.Category = Category;
            this.LengthInMinutes = LengthInMinutes;
            this.CountsAsPaidTime = CountsAsPaidTime;
            this.CountsAsWorkTime = CountsAsWorkTime;
            this.AgentTimeOffSelectable = AgentTimeOffSelectable;
            this.CountsTowardShrinkage = CountsTowardShrinkage;
            this.PlannedShrinkage = PlannedShrinkage;
            this.Interruptible = Interruptible;
            this.SecondaryPresences = SecondaryPresences;
            this.Metadata = Metadata;
            
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
        /// Whether this activity code is active or has been deleted
        /// </summary>
        /// <value>Whether this activity code is active or has been deleted</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }



        /// <summary>
        /// Whether this is a default activity code
        /// </summary>
        /// <value>Whether this is a default activity code</value>
        [DataMember(Name="defaultCode", EmitDefaultValue=false)]
        public bool? DefaultCode { get; set; }





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
        /// Whether an agent can select this activity code when creating or editing a time off request. Null if the activity's category is not time off.
        /// </summary>
        /// <value>Whether an agent can select this activity code when creating or editing a time off request. Null if the activity's category is not time off.</value>
        [DataMember(Name="agentTimeOffSelectable", EmitDefaultValue=false)]
        public bool? AgentTimeOffSelectable { get; set; }



        /// <summary>
        /// Whether or not this activity code counts toward shrinkage calculations
        /// </summary>
        /// <value>Whether or not this activity code counts toward shrinkage calculations</value>
        [DataMember(Name="countsTowardShrinkage", EmitDefaultValue=false)]
        public bool? CountsTowardShrinkage { get; set; }



        /// <summary>
        /// Whether this activity code is considered planned or unplanned shrinkage
        /// </summary>
        /// <value>Whether this activity code is considered planned or unplanned shrinkage</value>
        [DataMember(Name="plannedShrinkage", EmitDefaultValue=false)]
        public bool? PlannedShrinkage { get; set; }



        /// <summary>
        /// Whether this activity code is considered interruptible
        /// </summary>
        /// <value>Whether this activity code is considered interruptible</value>
        [DataMember(Name="interruptible", EmitDefaultValue=false)]
        public bool? Interruptible { get; set; }



        /// <summary>
        /// The secondary presences of this activity code
        /// </summary>
        /// <value>The secondary presences of this activity code</value>
        [DataMember(Name="secondaryPresences", EmitDefaultValue=false)]
        public List<SecondaryPresence> SecondaryPresences { get; set; }



        /// <summary>
        /// Version metadata of this activity code
        /// </summary>
        /// <value>Version metadata of this activity code</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public WfmVersionedEntityMetadata Metadata { get; set; }



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
            sb.Append("class BusinessUnitActivityCode {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  DefaultCode: ").Append(DefaultCode).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
            sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
            sb.Append("  CountsAsWorkTime: ").Append(CountsAsWorkTime).Append("\n");
            sb.Append("  AgentTimeOffSelectable: ").Append(AgentTimeOffSelectable).Append("\n");
            sb.Append("  CountsTowardShrinkage: ").Append(CountsTowardShrinkage).Append("\n");
            sb.Append("  PlannedShrinkage: ").Append(PlannedShrinkage).Append("\n");
            sb.Append("  Interruptible: ").Append(Interruptible).Append("\n");
            sb.Append("  SecondaryPresences: ").Append(SecondaryPresences).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as BusinessUnitActivityCode);
        }

        /// <summary>
        /// Returns true if BusinessUnitActivityCode instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessUnitActivityCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessUnitActivityCode other)
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
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) &&
                (
                    this.DefaultCode == other.DefaultCode ||
                    this.DefaultCode != null &&
                    this.DefaultCode.Equals(other.DefaultCode)
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
                    this.CountsTowardShrinkage == other.CountsTowardShrinkage ||
                    this.CountsTowardShrinkage != null &&
                    this.CountsTowardShrinkage.Equals(other.CountsTowardShrinkage)
                ) &&
                (
                    this.PlannedShrinkage == other.PlannedShrinkage ||
                    this.PlannedShrinkage != null &&
                    this.PlannedShrinkage.Equals(other.PlannedShrinkage)
                ) &&
                (
                    this.Interruptible == other.Interruptible ||
                    this.Interruptible != null &&
                    this.Interruptible.Equals(other.Interruptible)
                ) &&
                (
                    this.SecondaryPresences == other.SecondaryPresences ||
                    this.SecondaryPresences != null &&
                    this.SecondaryPresences.SequenceEqual(other.SecondaryPresences)
                ) &&
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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

                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();

                if (this.DefaultCode != null)
                    hash = hash * 59 + this.DefaultCode.GetHashCode();

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

                if (this.CountsTowardShrinkage != null)
                    hash = hash * 59 + this.CountsTowardShrinkage.GetHashCode();

                if (this.PlannedShrinkage != null)
                    hash = hash * 59 + this.PlannedShrinkage.GetHashCode();

                if (this.Interruptible != null)
                    hash = hash * 59 + this.Interruptible.GetHashCode();

                if (this.SecondaryPresences != null)
                    hash = hash * 59 + this.SecondaryPresences.GetHashCode();

                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
