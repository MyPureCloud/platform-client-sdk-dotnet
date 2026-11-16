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
    /// ActivityPlanOccurrenceSessionWithAttendees
    /// </summary>
    [DataContract]
    public partial class ActivityPlanOccurrenceSessionWithAttendees :  IEquatable<ActivityPlanOccurrenceSessionWithAttendees>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanOccurrenceSessionWithAttendees" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanOccurrenceSessionWithAttendees() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanOccurrenceSessionWithAttendees" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="Edited">Whether this session is edited.</param>
        /// <param name="Violations">The violations for this session.</param>
        /// <param name="Attendees">The attendees associated with this session.</param>
        public ActivityPlanOccurrenceSessionWithAttendees(string Id = null, bool? Edited = null, List<ActivityPlanSessionViolation> Violations = null, List<UserReference> Attendees = null)
        {
            this.Id = Id;
            this.Edited = Edited;
            this.Violations = Violations;
            this.Attendees = Attendees;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Whether this session is edited
        /// </summary>
        /// <value>Whether this session is edited</value>
        [DataMember(Name="edited", EmitDefaultValue=false)]
        public bool? Edited { get; set; }



        /// <summary>
        /// The violations for this session
        /// </summary>
        /// <value>The violations for this session</value>
        [DataMember(Name="violations", EmitDefaultValue=false)]
        public List<ActivityPlanSessionViolation> Violations { get; set; }



        /// <summary>
        /// The attendees associated with this session
        /// </summary>
        /// <value>The attendees associated with this session</value>
        [DataMember(Name="attendees", EmitDefaultValue=false)]
        public List<UserReference> Attendees { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityPlanOccurrenceSessionWithAttendees {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Edited: ").Append(Edited).Append("\n");
            sb.Append("  Violations: ").Append(Violations).Append("\n");
            sb.Append("  Attendees: ").Append(Attendees).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ActivityPlanOccurrenceSessionWithAttendees);
        }

        /// <summary>
        /// Returns true if ActivityPlanOccurrenceSessionWithAttendees instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanOccurrenceSessionWithAttendees to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanOccurrenceSessionWithAttendees other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Edited == other.Edited ||
                    this.Edited != null &&
                    this.Edited.Equals(other.Edited)
                ) &&
                (
                    this.Violations == other.Violations ||
                    this.Violations != null &&
                    this.Violations.SequenceEqual(other.Violations)
                ) &&
                (
                    this.Attendees == other.Attendees ||
                    this.Attendees != null &&
                    this.Attendees.SequenceEqual(other.Attendees)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Edited != null)
                    hash = hash * 59 + this.Edited.GetHashCode();

                if (this.Violations != null)
                    hash = hash * 59 + this.Violations.GetHashCode();

                if (this.Attendees != null)
                    hash = hash * 59 + this.Attendees.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
