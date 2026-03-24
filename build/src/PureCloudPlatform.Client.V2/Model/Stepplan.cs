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
    /// Stepplan
    /// </summary>
    [DataContract]
    public partial class Stepplan :  IEquatable<Stepplan>
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
        /// Initializes a new instance of the <see cref="Stepplan" /> class.
        /// </summary>
        /// <param name="Name">The name of the Stepplan..</param>
        /// <param name="Description">The description of the Stepplan..</param>
        /// <param name="Caseplan">The Caseplan of the Stepplan..</param>
        /// <param name="Stageplan">The Stageplan of the Stepplan..</param>
        /// <param name="DateCreated">The Stepplan creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The Stepplan modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ModifiedBy">The ID of the User who modified the Stepplan..</param>
        /// <param name="ActivityType">The activityType of the Stepplan..</param>
        /// <param name="WorkitemSettings">The workitemSettings of the Stepplan..</param>
        public Stepplan(string Name = null, string Description = null, CaseplanReference Caseplan = null, StageplanReference Stageplan = null, DateTime? DateCreated = null, DateTime? DateModified = null, UserReference ModifiedBy = null, ActivityTypeEnum? ActivityType = null, WorkitemSettingsResponse WorkitemSettings = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Caseplan = Caseplan;
            this.Stageplan = Stageplan;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.ActivityType = ActivityType;
            this.WorkitemSettings = WorkitemSettings;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the Stepplan.
        /// </summary>
        /// <value>The name of the Stepplan.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The description of the Stepplan.
        /// </summary>
        /// <value>The description of the Stepplan.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The Caseplan of the Stepplan.
        /// </summary>
        /// <value>The Caseplan of the Stepplan.</value>
        [DataMember(Name="caseplan", EmitDefaultValue=false)]
        public CaseplanReference Caseplan { get; set; }



        /// <summary>
        /// The Stageplan of the Stepplan.
        /// </summary>
        /// <value>The Stageplan of the Stepplan.</value>
        [DataMember(Name="stageplan", EmitDefaultValue=false)]
        public StageplanReference Stageplan { get; set; }



        /// <summary>
        /// The Stepplan creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The Stepplan creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The Stepplan modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The Stepplan modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The ID of the User who modified the Stepplan.
        /// </summary>
        /// <value>The ID of the User who modified the Stepplan.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; set; }





        /// <summary>
        /// The workitemSettings of the Stepplan.
        /// </summary>
        /// <value>The workitemSettings of the Stepplan.</value>
        [DataMember(Name="workitemSettings", EmitDefaultValue=false)]
        public WorkitemSettingsResponse WorkitemSettings { get; set; }



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
            sb.Append("class Stepplan {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Caseplan: ").Append(Caseplan).Append("\n");
            sb.Append("  Stageplan: ").Append(Stageplan).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  ActivityType: ").Append(ActivityType).Append("\n");
            sb.Append("  WorkitemSettings: ").Append(WorkitemSettings).Append("\n");
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
            return this.Equals(obj as Stepplan);
        }

        /// <summary>
        /// Returns true if Stepplan instances are equal
        /// </summary>
        /// <param name="other">Instance of Stepplan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stepplan other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Caseplan == other.Caseplan ||
                    this.Caseplan != null &&
                    this.Caseplan.Equals(other.Caseplan)
                ) &&
                (
                    this.Stageplan == other.Stageplan ||
                    this.Stageplan != null &&
                    this.Stageplan.Equals(other.Stageplan)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.ActivityType == other.ActivityType ||
                    this.ActivityType != null &&
                    this.ActivityType.Equals(other.ActivityType)
                ) &&
                (
                    this.WorkitemSettings == other.WorkitemSettings ||
                    this.WorkitemSettings != null &&
                    this.WorkitemSettings.Equals(other.WorkitemSettings)
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

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Caseplan != null)
                    hash = hash * 59 + this.Caseplan.GetHashCode();

                if (this.Stageplan != null)
                    hash = hash * 59 + this.Stageplan.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.ActivityType != null)
                    hash = hash * 59 + this.ActivityType.GetHashCode();

                if (this.WorkitemSettings != null)
                    hash = hash * 59 + this.WorkitemSettings.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
