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
    /// Request to upload partial set of user schedules
    /// </summary>
    [DataContract]
    public partial class UserSchedulesPartialUploadRequest :  IEquatable<UserSchedulesPartialUploadRequest>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSchedulesPartialUploadRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSchedulesPartialUploadRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSchedulesPartialUploadRequest" /> class.
        /// </summary>
        /// <param name="UserSchedules">User schedules that are part of partial request (required).</param>
        public UserSchedulesPartialUploadRequest(Dictionary<string, UserSchedule> UserSchedules = null)
        {
            this.UserSchedules = UserSchedules;
            
        }
        
        
        
        /// <summary>
        /// User schedules that are part of partial request
        /// </summary>
        /// <value>User schedules that are part of partial request</value>
        [DataMember(Name="userSchedules", EmitDefaultValue=false)]
        public Dictionary<string, UserSchedule> UserSchedules { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSchedulesPartialUploadRequest {\n");
            
            sb.Append("  UserSchedules: ").Append(UserSchedules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserSchedulesPartialUploadRequest);
        }

        /// <summary>
        /// Returns true if UserSchedulesPartialUploadRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSchedulesPartialUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSchedulesPartialUploadRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserSchedules == other.UserSchedules ||
                    this.UserSchedules != null &&
                    this.UserSchedules.SequenceEqual(other.UserSchedules)
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
                
                if (this.UserSchedules != null)
                    hash = hash * 59 + this.UserSchedules.GetHashCode();
                
                return hash;
            }
        }
    }

}
