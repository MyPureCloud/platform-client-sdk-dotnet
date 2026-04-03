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
    /// ActivityPlanOccurrenceSessionsUsersStructureReference
    /// </summary>
    [DataContract]
    public partial class ActivityPlanOccurrenceSessionsUsersStructureReference :  IEquatable<ActivityPlanOccurrenceSessionsUsersStructureReference>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanOccurrenceSessionsUsersStructureReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanOccurrenceSessionsUsersStructureReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanOccurrenceSessionsUsersStructureReference" /> class.
        /// </summary>
        /// <param name="Sessions">The sessions to delete from this activity plan occurrence (required).</param>
        public ActivityPlanOccurrenceSessionsUsersStructureReference(List<ActivityPlanSessionStructureReference> Sessions = null)
        {
            this.Sessions = Sessions;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The sessions to delete from this activity plan occurrence
        /// </summary>
        /// <value>The sessions to delete from this activity plan occurrence</value>
        [DataMember(Name="sessions", EmitDefaultValue=false)]
        public List<ActivityPlanSessionStructureReference> Sessions { get; set; }



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
            sb.Append("class ActivityPlanOccurrenceSessionsUsersStructureReference {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
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
            return this.Equals(obj as ActivityPlanOccurrenceSessionsUsersStructureReference);
        }

        /// <summary>
        /// Returns true if ActivityPlanOccurrenceSessionsUsersStructureReference instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanOccurrenceSessionsUsersStructureReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanOccurrenceSessionsUsersStructureReference other)
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
                    this.Sessions == other.Sessions ||
                    this.Sessions != null &&
                    this.Sessions.SequenceEqual(other.Sessions)
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

                if (this.Sessions != null)
                    hash = hash * 59 + this.Sessions.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
