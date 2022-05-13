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
    /// AttendanceStatus
    /// </summary>
    [DataContract]
    public partial class AttendanceStatus :  IEquatable<AttendanceStatus>
    {
        /// <summary>
        /// the attendance status
        /// </summary>
        /// <value>the attendance status</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AttendanceStatusTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Hasdata for "HasData"
            /// </summary>
            [EnumMember(Value = "HasData")]
            Hasdata,
            
            /// <summary>
            /// Enum Scheduled for "Scheduled"
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Absent for "Absent"
            /// </summary>
            [EnumMember(Value = "Absent")]
            Absent,
            
            /// <summary>
            /// Enum Present for "Present"
            /// </summary>
            [EnumMember(Value = "Present")]
            Present,
            
            /// <summary>
            /// Enum Noschedule for "NoSchedule"
            /// </summary>
            [EnumMember(Value = "NoSchedule")]
            Noschedule
        }
        /// <summary>
        /// the attendance status
        /// </summary>
        /// <value>the attendance status</value>
        [DataMember(Name="attendanceStatusType", EmitDefaultValue=false)]
        public AttendanceStatusTypeEnum? AttendanceStatusType { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendanceStatus" /> class.
        /// </summary>
        public AttendanceStatus()
        {
            
        }
        


        /// <summary>
        /// the workday date of this attendance status. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>the workday date of this attendance status. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="dateWorkday", EmitDefaultValue=false)]
        public String DateWorkday { get; private set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttendanceStatus {\n");

            sb.Append("  DateWorkday: ").Append(DateWorkday).Append("\n");
            sb.Append("  AttendanceStatusType: ").Append(AttendanceStatusType).Append("\n");
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
            return this.Equals(obj as AttendanceStatus);
        }

        /// <summary>
        /// Returns true if AttendanceStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of AttendanceStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttendanceStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateWorkday == other.DateWorkday ||
                    this.DateWorkday != null &&
                    this.DateWorkday.Equals(other.DateWorkday)
                ) &&
                (
                    this.AttendanceStatusType == other.AttendanceStatusType ||
                    this.AttendanceStatusType != null &&
                    this.AttendanceStatusType.Equals(other.AttendanceStatusType)
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
                if (this.DateWorkday != null)
                    hash = hash * 59 + this.DateWorkday.GetHashCode();

                if (this.AttendanceStatusType != null)
                    hash = hash * 59 + this.AttendanceStatusType.GetHashCode();

                return hash;
            }
        }
    }

}
