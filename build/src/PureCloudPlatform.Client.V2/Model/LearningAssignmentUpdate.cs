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
    /// LearningAssignmentUpdate
    /// </summary>
    [DataContract]
    public partial class LearningAssignmentUpdate :  IEquatable<LearningAssignmentUpdate>
    {
        /// <summary>
        /// The Learning Assignment state
        /// </summary>
        /// <value>The Learning Assignment state</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Assigned for "Assigned"
            /// </summary>
            [EnumMember(Value = "Assigned")]
            Assigned,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted,
            
            /// <summary>
            /// Enum Notcompleted for "NotCompleted"
            /// </summary>
            [EnumMember(Value = "NotCompleted")]
            Notcompleted,
            
            /// <summary>
            /// Enum Invalidschedule for "InvalidSchedule"
            /// </summary>
            [EnumMember(Value = "InvalidSchedule")]
            Invalidschedule
        }
        /// <summary>
        /// The Learning Assignment state
        /// </summary>
        /// <value>The Learning Assignment state</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentUpdate" /> class.
        /// </summary>
        /// <param name="State">The Learning Assignment state.</param>
        /// <param name="Assessment">An updated Assessment.</param>
        public LearningAssignmentUpdate(StateEnum? State = null, LearningAssessment Assessment = null)
        {
            this.State = State;
            this.Assessment = Assessment;
            
        }
        




        /// <summary>
        /// An updated Assessment
        /// </summary>
        /// <value>An updated Assessment</value>
        [DataMember(Name="assessment", EmitDefaultValue=false)]
        public LearningAssessment Assessment { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignmentUpdate {\n");

            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Assessment: ").Append(Assessment).Append("\n");
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
            return this.Equals(obj as LearningAssignmentUpdate);
        }

        /// <summary>
        /// Returns true if LearningAssignmentUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignmentUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignmentUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Assessment == other.Assessment ||
                    this.Assessment != null &&
                    this.Assessment.Equals(other.Assessment)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Assessment != null)
                    hash = hash * 59 + this.Assessment.GetHashCode();

                return hash;
            }
        }
    }

}
