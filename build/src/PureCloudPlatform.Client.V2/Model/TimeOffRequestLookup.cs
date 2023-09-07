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
    /// TimeOffRequestLookup
    /// </summary>
    [DataContract]
    public partial class TimeOffRequestLookup :  IEquatable<TimeOffRequestLookup>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequestLookup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimeOffRequestLookup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeOffRequestLookup" /> class.
        /// </summary>
        /// <param name="TimeOffRequestId">The ID of the time off request (required).</param>
        /// <param name="UserId">The ID of the user to whom the time off request belongs (required).</param>
        public TimeOffRequestLookup(string TimeOffRequestId = null, string UserId = null)
        {
            this.TimeOffRequestId = TimeOffRequestId;
            this.UserId = UserId;
            
        }
        


        /// <summary>
        /// The ID of the time off request
        /// </summary>
        /// <value>The ID of the time off request</value>
        [DataMember(Name="timeOffRequestId", EmitDefaultValue=false)]
        public string TimeOffRequestId { get; set; }



        /// <summary>
        /// The ID of the user to whom the time off request belongs
        /// </summary>
        /// <value>The ID of the user to whom the time off request belongs</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeOffRequestLookup {\n");

            sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as TimeOffRequestLookup);
        }

        /// <summary>
        /// Returns true if TimeOffRequestLookup instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeOffRequestLookup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeOffRequestLookup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TimeOffRequestId == other.TimeOffRequestId ||
                    this.TimeOffRequestId != null &&
                    this.TimeOffRequestId.Equals(other.TimeOffRequestId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.TimeOffRequestId != null)
                    hash = hash * 59 + this.TimeOffRequestId.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                return hash;
            }
        }
    }

}
