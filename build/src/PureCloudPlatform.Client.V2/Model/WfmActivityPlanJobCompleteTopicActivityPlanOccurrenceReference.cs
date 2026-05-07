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
    /// WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference
    /// </summary>
    [DataContract]
    public partial class WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference :  IEquatable<WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Sessions">Sessions.</param>
        public WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference(string Id = null, List<WfmActivityPlanJobCompleteTopicActivityPlanSessionReference> Sessions = null)
        {
            this.Id = Id;
            this.Sessions = Sessions;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Sessions
        /// </summary>
        [DataMember(Name="sessions", EmitDefaultValue=false)]
        public List<WfmActivityPlanJobCompleteTopicActivityPlanSessionReference> Sessions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
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
            return this.Equals(obj as WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference);
        }

        /// <summary>
        /// Returns true if WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference instances are equal
        /// </summary>
        /// <param name="other">Instance of WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference other)
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

                return hash;
            }
        }
    }

}
