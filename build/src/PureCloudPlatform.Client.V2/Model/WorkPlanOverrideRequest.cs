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
    /// WorkPlanOverrideRequest
    /// </summary>
    [DataContract]
    public partial class WorkPlanOverrideRequest :  IEquatable<WorkPlanOverrideRequest>
    {
        /// <summary>
        /// The action to perform on work plan override, defaults to add
        /// </summary>
        /// <value>The action to perform on work plan override, defaults to add</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Add for "Add"
            /// </summary>
            [EnumMember(Value = "Add")]
            Add,
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,
            
            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete
        }
        /// <summary>
        /// The action to perform on work plan override, defaults to add
        /// </summary>
        /// <value>The action to perform on work plan override, defaults to add</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanOverrideRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkPlanOverrideRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkPlanOverrideRequest" /> class.
        /// </summary>
        /// <param name="Action">The action to perform on work plan override, defaults to add.</param>
        /// <param name="StartDate">The start date in yyyy-MM-dd format for the updated work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
        /// <param name="WeekCount">The week count of the updated work plan, required if action is Add or Update.</param>
        /// <param name="WorkPlanId">The updated work plan id.</param>
        public WorkPlanOverrideRequest(ActionEnum? Action = null, String StartDate = null, int? WeekCount = null, string WorkPlanId = null)
        {
            this.Action = Action;
            this.StartDate = StartDate;
            this.WeekCount = WeekCount;
            this.WorkPlanId = WorkPlanId;
            
        }
        




        /// <summary>
        /// The start date in yyyy-MM-dd format for the updated work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The start date in yyyy-MM-dd format for the updated work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public String StartDate { get; set; }



        /// <summary>
        /// The week count of the updated work plan, required if action is Add or Update
        /// </summary>
        /// <value>The week count of the updated work plan, required if action is Add or Update</value>
        [DataMember(Name="weekCount", EmitDefaultValue=false)]
        public int? WeekCount { get; set; }



        /// <summary>
        /// The updated work plan id
        /// </summary>
        /// <value>The updated work plan id</value>
        [DataMember(Name="workPlanId", EmitDefaultValue=false)]
        public string WorkPlanId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkPlanOverrideRequest {\n");

            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
            sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
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
            return this.Equals(obj as WorkPlanOverrideRequest);
        }

        /// <summary>
        /// Returns true if WorkPlanOverrideRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkPlanOverrideRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkPlanOverrideRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) &&
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) &&
                (
                    this.WeekCount == other.WeekCount ||
                    this.WeekCount != null &&
                    this.WeekCount.Equals(other.WeekCount)
                ) &&
                (
                    this.WorkPlanId == other.WorkPlanId ||
                    this.WorkPlanId != null &&
                    this.WorkPlanId.Equals(other.WorkPlanId)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();

                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();

                if (this.WeekCount != null)
                    hash = hash * 59 + this.WeekCount.GetHashCode();

                if (this.WorkPlanId != null)
                    hash = hash * 59 + this.WorkPlanId.GetHashCode();

                return hash;
            }
        }
    }

}
