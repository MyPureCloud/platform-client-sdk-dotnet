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
    /// WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification
    /// </summary>
    [DataContract]
    public partial class WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification :  IEquatable<WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification>
    {
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
            /// Enum Runplan for "RunPlan"
            /// </summary>
            [EnumMember(Value = "RunPlan")]
            Runplan,
            
            /// <summary>
            /// Enum Deleteoccurrence for "DeleteOccurrence"
            /// </summary>
            [EnumMember(Value = "DeleteOccurrence")]
            Deleteoccurrence
        }
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
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type.</param>
        /// <param name="ActivityPlan">ActivityPlan.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Exceptions">Exceptions.</param>
        /// <param name="Error">Error.</param>
        public WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification(string Id = null, TypeEnum? Type = null, WfmActivityPlanRunJobCompleteTopicActivityPlanReference ActivityPlan = null, StatusEnum? Status = null, List<WfmActivityPlanRunJobCompleteTopicActivityPlanJobException> Exceptions = null, WfmActivityPlanRunJobCompleteTopicErrorBody Error = null)
        {
            this.Id = Id;
            this.Type = Type;
            this.ActivityPlan = ActivityPlan;
            this.Status = Status;
            this.Exceptions = Exceptions;
            this.Error = Error;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// Gets or Sets ActivityPlan
        /// </summary>
        [DataMember(Name="activityPlan", EmitDefaultValue=false)]
        public WfmActivityPlanRunJobCompleteTopicActivityPlanReference ActivityPlan { get; set; }





        /// <summary>
        /// Gets or Sets Exceptions
        /// </summary>
        [DataMember(Name="exceptions", EmitDefaultValue=false)]
        public List<WfmActivityPlanRunJobCompleteTopicActivityPlanJobException> Exceptions { get; set; }



        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public WfmActivityPlanRunJobCompleteTopicErrorBody Error { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ActivityPlan: ").Append(ActivityPlan).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Exceptions: ").Append(Exceptions).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(obj as WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification);
        }

        /// <summary>
        /// Returns true if WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmActivityPlanRunJobCompleteTopicActivityPlanRunJobCompleteNotification other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ActivityPlan == other.ActivityPlan ||
                    this.ActivityPlan != null &&
                    this.ActivityPlan.Equals(other.ActivityPlan)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Exceptions == other.Exceptions ||
                    this.Exceptions != null &&
                    this.Exceptions.SequenceEqual(other.Exceptions)
                ) &&
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.ActivityPlan != null)
                    hash = hash * 59 + this.ActivityPlan.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Exceptions != null)
                    hash = hash * 59 + this.Exceptions.GetHashCode();

                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();

                return hash;
            }
        }
    }

}
