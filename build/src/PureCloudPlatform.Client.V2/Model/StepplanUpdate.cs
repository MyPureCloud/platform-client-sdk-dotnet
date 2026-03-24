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
    /// StepplanUpdate
    /// </summary>
    [DataContract]
    public partial class StepplanUpdate :  IEquatable<StepplanUpdate>
    {
        /// <summary>
        /// The activityType of the Stepplan.
        /// </summary>
        /// <value>The activityType of the Stepplan.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActivityTypeEnum
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
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Workitem for "Workitem"
            /// </summary>
            [EnumMember(Value = "Workitem")]
            Workitem
        }
        /// <summary>
        /// The activityType of the Stepplan.
        /// </summary>
        /// <value>The activityType of the Stepplan.</value>
        [DataMember(Name="activityType", EmitDefaultValue=false)]
        public ActivityTypeEnum? ActivityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StepplanUpdate" /> class.
        /// </summary>
        /// <param name="Name">The name of the Stepplan. Valid length between 3 and 256 characters..</param>
        /// <param name="Description">The description of the Stepplan. Maximum length of 512 characters..</param>
        /// <param name="WorkitemSettings">The workitemSettings of the Stepplan..</param>
        /// <param name="ActivityType">The activityType of the Stepplan..</param>
        public StepplanUpdate(string Name = null, string Description = null, WorkitemSettings WorkitemSettings = null, ActivityTypeEnum? ActivityType = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.WorkitemSettings = WorkitemSettings;
            this.ActivityType = ActivityType;
            
        }
        


        /// <summary>
        /// The name of the Stepplan. Valid length between 3 and 256 characters.
        /// </summary>
        /// <value>The name of the Stepplan. Valid length between 3 and 256 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of the Stepplan. Maximum length of 512 characters.
        /// </summary>
        /// <value>The description of the Stepplan. Maximum length of 512 characters.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The workitemSettings of the Stepplan.
        /// </summary>
        /// <value>The workitemSettings of the Stepplan.</value>
        [DataMember(Name="workitemSettings", EmitDefaultValue=false)]
        public WorkitemSettings WorkitemSettings { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StepplanUpdate {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WorkitemSettings: ").Append(WorkitemSettings).Append("\n");
            sb.Append("  ActivityType: ").Append(ActivityType).Append("\n");
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
            return this.Equals(obj as StepplanUpdate);
        }

        /// <summary>
        /// Returns true if StepplanUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of StepplanUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepplanUpdate other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.WorkitemSettings == other.WorkitemSettings ||
                    this.WorkitemSettings != null &&
                    this.WorkitemSettings.Equals(other.WorkitemSettings)
                ) &&
                (
                    this.ActivityType == other.ActivityType ||
                    this.ActivityType != null &&
                    this.ActivityType.Equals(other.ActivityType)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.WorkitemSettings != null)
                    hash = hash * 59 + this.WorkitemSettings.GetHashCode();

                if (this.ActivityType != null)
                    hash = hash * 59 + this.ActivityType.GetHashCode();

                return hash;
            }
        }
    }

}
