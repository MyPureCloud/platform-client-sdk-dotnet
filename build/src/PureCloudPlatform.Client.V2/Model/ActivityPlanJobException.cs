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
    /// ActivityPlanJobException
    /// </summary>
    [DataContract]
    public partial class ActivityPlanJobException :  IEquatable<ActivityPlanJobException>
    {
        /// <summary>
        /// The type of error
        /// </summary>
        /// <value>The type of error</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ExceptionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unscheduledattendees for "UnscheduledAttendees"
            /// </summary>
            [EnumMember(Value = "UnscheduledAttendees")]
            Unscheduledattendees,
            
            /// <summary>
            /// Enum Sessionsnotdeleted for "SessionsNotDeleted"
            /// </summary>
            [EnumMember(Value = "SessionsNotDeleted")]
            Sessionsnotdeleted
        }
        /// <summary>
        /// The type of error
        /// </summary>
        /// <value>The type of error</value>
        [DataMember(Name="exceptionType", EmitDefaultValue=false)]
        public ExceptionTypeEnum? ExceptionType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanJobException" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanJobException() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanJobException" /> class.
        /// </summary>
        /// <param name="ExceptionType">The type of error (required).</param>
        /// <param name="Occurrences">The occurrences in which this error occurred (required).</param>
        public ActivityPlanJobException(ExceptionTypeEnum? ExceptionType = null, List<ActivityPlanOccurrenceReference> Occurrences = null)
        {
            this.ExceptionType = ExceptionType;
            this.Occurrences = Occurrences;
            
        }
        




        /// <summary>
        /// The occurrences in which this error occurred
        /// </summary>
        /// <value>The occurrences in which this error occurred</value>
        [DataMember(Name="occurrences", EmitDefaultValue=false)]
        public List<ActivityPlanOccurrenceReference> Occurrences { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityPlanJobException {\n");

            sb.Append("  ExceptionType: ").Append(ExceptionType).Append("\n");
            sb.Append("  Occurrences: ").Append(Occurrences).Append("\n");
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
            return this.Equals(obj as ActivityPlanJobException);
        }

        /// <summary>
        /// Returns true if ActivityPlanJobException instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanJobException to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanJobException other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ExceptionType == other.ExceptionType ||
                    this.ExceptionType != null &&
                    this.ExceptionType.Equals(other.ExceptionType)
                ) &&
                (
                    this.Occurrences == other.Occurrences ||
                    this.Occurrences != null &&
                    this.Occurrences.SequenceEqual(other.Occurrences)
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
                if (this.ExceptionType != null)
                    hash = hash * 59 + this.ExceptionType.GetHashCode();

                if (this.Occurrences != null)
                    hash = hash * 59 + this.Occurrences.GetHashCode();

                return hash;
            }
        }
    }

}
