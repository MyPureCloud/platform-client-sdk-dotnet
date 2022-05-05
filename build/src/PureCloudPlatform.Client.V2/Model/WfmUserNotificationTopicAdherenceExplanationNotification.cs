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
    /// WfmUserNotificationTopicAdherenceExplanationNotification
    /// </summary>
    [DataContract]
    public partial class WfmUserNotificationTopicAdherenceExplanationNotification :  IEquatable<WfmUserNotificationTopicAdherenceExplanationNotification>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
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
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Denied for "Denied"
            /// </summary>
            [EnumMember(Value = "Denied")]
            Denied
        }
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum Late for "Late"
            /// </summary>
            [EnumMember(Value = "Late")]
            Late
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmUserNotificationTopicAdherenceExplanationNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Agent">Agent.</param>
        /// <param name="ManagementUnit">ManagementUnit.</param>
        /// <param name="BusinessUnit">BusinessUnit.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="LengthMinutes">LengthMinutes.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Notes">Notes.</param>
        public WfmUserNotificationTopicAdherenceExplanationNotification(string Id = null, WfmUserNotificationTopicUserReference Agent = null, WfmUserNotificationTopicManagementUnit ManagementUnit = null, WfmUserNotificationTopicBusinessUnit BusinessUnit = null, DateTime? StartDate = null, int? LengthMinutes = null, StatusEnum? Status = null, TypeEnum? Type = null, string Notes = null)
        {
            this.Id = Id;
            this.Agent = Agent;
            this.ManagementUnit = ManagementUnit;
            this.BusinessUnit = BusinessUnit;
            this.StartDate = StartDate;
            this.LengthMinutes = LengthMinutes;
            this.Status = Status;
            this.Type = Type;
            this.Notes = Notes;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public WfmUserNotificationTopicUserReference Agent { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ManagementUnit
        /// </summary>
        [DataMember(Name="managementUnit", EmitDefaultValue=false)]
        public WfmUserNotificationTopicManagementUnit ManagementUnit { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets BusinessUnit
        /// </summary>
        [DataMember(Name="businessUnit", EmitDefaultValue=false)]
        public WfmUserNotificationTopicBusinessUnit BusinessUnit { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets LengthMinutes
        /// </summary>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmUserNotificationTopicAdherenceExplanationNotification {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
            sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(obj as WfmUserNotificationTopicAdherenceExplanationNotification);
        }

        /// <summary>
        /// Returns true if WfmUserNotificationTopicAdherenceExplanationNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmUserNotificationTopicAdherenceExplanationNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmUserNotificationTopicAdherenceExplanationNotification other)
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
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) &&
                (
                    this.ManagementUnit == other.ManagementUnit ||
                    this.ManagementUnit != null &&
                    this.ManagementUnit.Equals(other.ManagementUnit)
                ) &&
                (
                    this.BusinessUnit == other.BusinessUnit ||
                    this.BusinessUnit != null &&
                    this.BusinessUnit.Equals(other.BusinessUnit)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
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
                
                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();
                
                if (this.ManagementUnit != null)
                    hash = hash * 59 + this.ManagementUnit.GetHashCode();
                
                if (this.BusinessUnit != null)
                    hash = hash * 59 + this.BusinessUnit.GetHashCode();
                
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                
                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                return hash;
            }
        }
    }

}
