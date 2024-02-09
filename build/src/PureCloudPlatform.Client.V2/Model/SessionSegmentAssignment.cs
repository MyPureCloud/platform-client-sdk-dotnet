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
    /// SessionSegmentAssignment
    /// </summary>
    [DataContract]
    public partial class SessionSegmentAssignment :  IEquatable<SessionSegmentAssignment>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSegmentAssignment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionSegmentAssignment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSegmentAssignment" /> class.
        /// </summary>
        /// <param name="Segment">The segment that was assigned. (required).</param>
        /// <param name="AssignedDate">Timestamp indicating when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public SessionSegmentAssignment(AssignedSegment Segment = null, DateTime? AssignedDate = null)
        {
            this.Segment = Segment;
            this.AssignedDate = AssignedDate;
            
        }
        


        /// <summary>
        /// The segment that was assigned.
        /// </summary>
        /// <value>The segment that was assigned.</value>
        [DataMember(Name="segment", EmitDefaultValue=false)]
        public AssignedSegment Segment { get; set; }



        /// <summary>
        /// Timestamp indicating when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Timestamp indicating when the segment was assigned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="assignedDate", EmitDefaultValue=false)]
        public DateTime? AssignedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionSegmentAssignment {\n");

            sb.Append("  Segment: ").Append(Segment).Append("\n");
            sb.Append("  AssignedDate: ").Append(AssignedDate).Append("\n");
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
            return this.Equals(obj as SessionSegmentAssignment);
        }

        /// <summary>
        /// Returns true if SessionSegmentAssignment instances are equal
        /// </summary>
        /// <param name="other">Instance of SessionSegmentAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionSegmentAssignment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Segment == other.Segment ||
                    this.Segment != null &&
                    this.Segment.Equals(other.Segment)
                ) &&
                (
                    this.AssignedDate == other.AssignedDate ||
                    this.AssignedDate != null &&
                    this.AssignedDate.Equals(other.AssignedDate)
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
                if (this.Segment != null)
                    hash = hash * 59 + this.Segment.GetHashCode();

                if (this.AssignedDate != null)
                    hash = hash * 59 + this.AssignedDate.GetHashCode();

                return hash;
            }
        }
    }

}
