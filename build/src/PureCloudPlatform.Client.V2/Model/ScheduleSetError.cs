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
    /// ScheduleSetError
    /// </summary>
    [DataContract]
    public partial class ScheduleSetError :  IEquatable<ScheduleSetError>
    {
        /// <summary>
        /// Error code that indicates why schedule set optimization failed. At least one of workPlans or workPlanRotations is set if there is an error during optimization
        /// </summary>
        /// <value>Error code that indicates why schedule set optimization failed. At least one of workPlans or workPlanRotations is set if there is an error during optimization</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ErrorCodeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Invalidworkplans for "InvalidWorkPlans"
            /// </summary>
            [EnumMember(Value = "InvalidWorkPlans")]
            Invalidworkplans,
            
            /// <summary>
            /// Enum Invalidworkplanrotations for "InvalidWorkPlanRotations"
            /// </summary>
            [EnumMember(Value = "InvalidWorkPlanRotations")]
            Invalidworkplanrotations
        }
        /// <summary>
        /// Error code that indicates why schedule set optimization failed. At least one of workPlans or workPlanRotations is set if there is an error during optimization
        /// </summary>
        /// <value>Error code that indicates why schedule set optimization failed. At least one of workPlans or workPlanRotations is set if there is an error during optimization</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleSetError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleSetError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleSetError" /> class.
        /// </summary>
        /// <param name="ErrorCode">Error code that indicates why schedule set optimization failed. At least one of workPlans or workPlanRotations is set if there is an error during optimization (required).</param>
        /// <param name="WorkPlans">Work plans involved in the optimization failure.</param>
        /// <param name="WorkPlanRotations">Work plan rotations involved in the optimization failure.</param>
        public ScheduleSetError(ErrorCodeEnum? ErrorCode = null, List<WorkPlanReference> WorkPlans = null, List<WorkPlanRotationReference> WorkPlanRotations = null)
        {
            this.ErrorCode = ErrorCode;
            this.WorkPlans = WorkPlans;
            this.WorkPlanRotations = WorkPlanRotations;
            
        }
        




        /// <summary>
        /// Work plans involved in the optimization failure
        /// </summary>
        /// <value>Work plans involved in the optimization failure</value>
        [DataMember(Name="workPlans", EmitDefaultValue=false)]
        public List<WorkPlanReference> WorkPlans { get; set; }



        /// <summary>
        /// Work plan rotations involved in the optimization failure
        /// </summary>
        /// <value>Work plan rotations involved in the optimization failure</value>
        [DataMember(Name="workPlanRotations", EmitDefaultValue=false)]
        public List<WorkPlanRotationReference> WorkPlanRotations { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleSetError {\n");

            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  WorkPlans: ").Append(WorkPlans).Append("\n");
            sb.Append("  WorkPlanRotations: ").Append(WorkPlanRotations).Append("\n");
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
            return this.Equals(obj as ScheduleSetError);
        }

        /// <summary>
        /// Returns true if ScheduleSetError instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleSetError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleSetError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.WorkPlans == other.WorkPlans ||
                    this.WorkPlans != null &&
                    this.WorkPlans.SequenceEqual(other.WorkPlans)
                ) &&
                (
                    this.WorkPlanRotations == other.WorkPlanRotations ||
                    this.WorkPlanRotations != null &&
                    this.WorkPlanRotations.SequenceEqual(other.WorkPlanRotations)
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
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();

                if (this.WorkPlans != null)
                    hash = hash * 59 + this.WorkPlans.GetHashCode();

                if (this.WorkPlanRotations != null)
                    hash = hash * 59 + this.WorkPlanRotations.GetHashCode();

                return hash;
            }
        }
    }

}
