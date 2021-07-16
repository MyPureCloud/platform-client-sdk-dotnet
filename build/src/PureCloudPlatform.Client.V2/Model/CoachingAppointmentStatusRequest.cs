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
    /// CoachingAppointmentStatusRequest
    /// </summary>
    [DataContract]
    public partial class CoachingAppointmentStatusRequest :  IEquatable<CoachingAppointmentStatusRequest>
    {
        
        
        /// <summary>
        /// The status of the coaching appointment
        /// </summary>
        /// <value>The status of the coaching appointment</value>
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
            /// Enum Scheduled for "Scheduled"
            /// </summary>
            [EnumMember(Value = "Scheduled")]
            Scheduled,
            
            /// <summary>
            /// Enum Inprogress for "InProgress"
            /// </summary>
            [EnumMember(Value = "InProgress")]
            Inprogress,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed
        }
        
        
        
        
        
        /// <summary>
        /// The status of the coaching appointment
        /// </summary>
        /// <value>The status of the coaching appointment</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachingAppointmentStatusRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CoachingAppointmentStatusRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachingAppointmentStatusRequest" /> class.
        /// </summary>
        /// <param name="Status">The status of the coaching appointment (required).</param>
        public CoachingAppointmentStatusRequest(StatusEnum? Status = null)
        {
            this.Status = Status;
            
        }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoachingAppointmentStatusRequest {\n");
            
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as CoachingAppointmentStatusRequest);
        }

        /// <summary>
        /// Returns true if CoachingAppointmentStatusRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CoachingAppointmentStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoachingAppointmentStatusRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }
    }

}
