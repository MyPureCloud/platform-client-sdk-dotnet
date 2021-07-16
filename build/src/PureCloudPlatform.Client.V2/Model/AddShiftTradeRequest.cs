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
    /// AddShiftTradeRequest
    /// </summary>
    [DataContract]
    public partial class AddShiftTradeRequest :  IEquatable<AddShiftTradeRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AddShiftTradeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddShiftTradeRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AddShiftTradeRequest" /> class.
        /// </summary>
        /// <param name="ScheduleId">The ID of the schedule to which the initiating and receiving shifts belong (required).</param>
        /// <param name="InitiatingShiftId">The ID of the shift that the initiating user wants to give up (required).</param>
        /// <param name="ReceivingUserId">The ID of the user to whom to send the request (for use in direct trade requests).</param>
        /// <param name="Expiration">When this shift trade request should expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="AcceptableIntervals">AcceptableIntervals.</param>
        public AddShiftTradeRequest(string ScheduleId = null, string InitiatingShiftId = null, string ReceivingUserId = null, DateTime? Expiration = null, List<string> AcceptableIntervals = null)
        {
            this.ScheduleId = ScheduleId;
            this.InitiatingShiftId = InitiatingShiftId;
            this.ReceivingUserId = ReceivingUserId;
            this.Expiration = Expiration;
            this.AcceptableIntervals = AcceptableIntervals;
            
        }
        
        
        
        /// <summary>
        /// The ID of the schedule to which the initiating and receiving shifts belong
        /// </summary>
        /// <value>The ID of the schedule to which the initiating and receiving shifts belong</value>
        [DataMember(Name="scheduleId", EmitDefaultValue=false)]
        public string ScheduleId { get; set; }
        
        
        
        /// <summary>
        /// The ID of the shift that the initiating user wants to give up
        /// </summary>
        /// <value>The ID of the shift that the initiating user wants to give up</value>
        [DataMember(Name="initiatingShiftId", EmitDefaultValue=false)]
        public string InitiatingShiftId { get; set; }
        
        
        
        /// <summary>
        /// The ID of the user to whom to send the request (for use in direct trade requests)
        /// </summary>
        /// <value>The ID of the user to whom to send the request (for use in direct trade requests)</value>
        [DataMember(Name="receivingUserId", EmitDefaultValue=false)]
        public string ReceivingUserId { get; set; }
        
        
        
        /// <summary>
        /// When this shift trade request should expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>When this shift trade request should expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public DateTime? Expiration { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AcceptableIntervals
        /// </summary>
        [DataMember(Name="acceptableIntervals", EmitDefaultValue=false)]
        public List<string> AcceptableIntervals { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddShiftTradeRequest {\n");
            
            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("  InitiatingShiftId: ").Append(InitiatingShiftId).Append("\n");
            sb.Append("  ReceivingUserId: ").Append(ReceivingUserId).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  AcceptableIntervals: ").Append(AcceptableIntervals).Append("\n");
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
            return this.Equals(obj as AddShiftTradeRequest);
        }

        /// <summary>
        /// Returns true if AddShiftTradeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AddShiftTradeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddShiftTradeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ScheduleId == other.ScheduleId ||
                    this.ScheduleId != null &&
                    this.ScheduleId.Equals(other.ScheduleId)
                ) &&
                (
                    this.InitiatingShiftId == other.InitiatingShiftId ||
                    this.InitiatingShiftId != null &&
                    this.InitiatingShiftId.Equals(other.InitiatingShiftId)
                ) &&
                (
                    this.ReceivingUserId == other.ReceivingUserId ||
                    this.ReceivingUserId != null &&
                    this.ReceivingUserId.Equals(other.ReceivingUserId)
                ) &&
                (
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
                ) &&
                (
                    this.AcceptableIntervals == other.AcceptableIntervals ||
                    this.AcceptableIntervals != null &&
                    this.AcceptableIntervals.SequenceEqual(other.AcceptableIntervals)
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
                
                if (this.ScheduleId != null)
                    hash = hash * 59 + this.ScheduleId.GetHashCode();
                
                if (this.InitiatingShiftId != null)
                    hash = hash * 59 + this.InitiatingShiftId.GetHashCode();
                
                if (this.ReceivingUserId != null)
                    hash = hash * 59 + this.ReceivingUserId.GetHashCode();
                
                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();
                
                if (this.AcceptableIntervals != null)
                    hash = hash * 59 + this.AcceptableIntervals.GetHashCode();
                
                return hash;
            }
        }
    }

}
