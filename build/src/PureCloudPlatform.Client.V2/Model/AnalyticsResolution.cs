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
    /// AnalyticsResolution
    /// </summary>
    [DataContract]
    public partial class AnalyticsResolution :  IEquatable<AnalyticsResolution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsResolution" /> class.
        /// </summary>
        /// <param name="EventTime">Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="QueueId">The ID of the last queue on which the conversation was handled..</param>
        /// <param name="UserId">The ID of the last user who handled the conversation..</param>
        /// <param name="NNextContactAvoided">NNextContactAvoided.</param>
        public AnalyticsResolution(DateTime? EventTime = null, string QueueId = null, string UserId = null, long? NNextContactAvoided = null)
        {
            this.EventTime = EventTime;
            this.QueueId = QueueId;
            this.UserId = UserId;
            this.NNextContactAvoided = NNextContactAvoided;
            
        }
        


        /// <summary>
        /// Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }



        /// <summary>
        /// The ID of the last queue on which the conversation was handled.
        /// </summary>
        /// <value>The ID of the last queue on which the conversation was handled.</value>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }



        /// <summary>
        /// The ID of the last user who handled the conversation.
        /// </summary>
        /// <value>The ID of the last user who handled the conversation.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Gets or Sets NNextContactAvoided
        /// </summary>
        [DataMember(Name="nNextContactAvoided", EmitDefaultValue=false)]
        public long? NNextContactAvoided { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsResolution {\n");

            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  NNextContactAvoided: ").Append(NNextContactAvoided).Append("\n");
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
            return this.Equals(obj as AnalyticsResolution);
        }

        /// <summary>
        /// Returns true if AnalyticsResolution instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsResolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsResolution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.NNextContactAvoided == other.NNextContactAvoided ||
                    this.NNextContactAvoided != null &&
                    this.NNextContactAvoided.Equals(other.NNextContactAvoided)
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
                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();

                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.NNextContactAvoided != null)
                    hash = hash * 59 + this.NNextContactAvoided.GetHashCode();

                return hash;
            }
        }
    }

}
