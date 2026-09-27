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
    /// ActivityPlanDeletionOccurrenceIds
    /// </summary>
    [DataContract]
    public partial class ActivityPlanDeletionOccurrenceIds :  IEquatable<ActivityPlanDeletionOccurrenceIds>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanDeletionOccurrenceIds" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanDeletionOccurrenceIds() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanDeletionOccurrenceIds" /> class.
        /// </summary>
        /// <param name="Ids">The occurrence Ids to delete from this activity plan (required).</param>
        public ActivityPlanDeletionOccurrenceIds(List<string> Ids = null)
        {
            this.Ids = Ids;
            
        }
        


        /// <summary>
        /// The occurrence Ids to delete from this activity plan
        /// </summary>
        /// <value>The occurrence Ids to delete from this activity plan</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityPlanDeletionOccurrenceIds {\n");

            sb.Append("  Ids: ").Append(Ids).Append("\n");
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
            return this.Equals(obj as ActivityPlanDeletionOccurrenceIds);
        }

        /// <summary>
        /// Returns true if ActivityPlanDeletionOccurrenceIds instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanDeletionOccurrenceIds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanDeletionOccurrenceIds other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Ids == other.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(other.Ids)
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
                if (this.Ids != null)
                    hash = hash * 59 + this.Ids.GetHashCode();

                return hash;
            }
        }
    }

}
