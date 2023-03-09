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
    /// LearningAssignmentReschedule
    /// </summary>
    [DataContract]
    public partial class LearningAssignmentReschedule :  IEquatable<LearningAssignmentReschedule>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentReschedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LearningAssignmentReschedule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LearningAssignmentReschedule" /> class.
        /// </summary>
        /// <param name="DateRecommendedForCompletion">The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        /// <param name="LengthInMinutes">The length in minutes of the assignment.</param>
        public LearningAssignmentReschedule(DateTime? DateRecommendedForCompletion = null, int? LengthInMinutes = null)
        {
            this.DateRecommendedForCompletion = DateRecommendedForCompletion;
            this.LengthInMinutes = LengthInMinutes;
            
        }
        


        /// <summary>
        /// The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The recommended completion date of the assignment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateRecommendedForCompletion", EmitDefaultValue=false)]
        public DateTime? DateRecommendedForCompletion { get; set; }



        /// <summary>
        /// The length in minutes of the assignment
        /// </summary>
        /// <value>The length in minutes of the assignment</value>
        [DataMember(Name="lengthInMinutes", EmitDefaultValue=false)]
        public int? LengthInMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LearningAssignmentReschedule {\n");

            sb.Append("  DateRecommendedForCompletion: ").Append(DateRecommendedForCompletion).Append("\n");
            sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
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
            return this.Equals(obj as LearningAssignmentReschedule);
        }

        /// <summary>
        /// Returns true if LearningAssignmentReschedule instances are equal
        /// </summary>
        /// <param name="other">Instance of LearningAssignmentReschedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LearningAssignmentReschedule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DateRecommendedForCompletion == other.DateRecommendedForCompletion ||
                    this.DateRecommendedForCompletion != null &&
                    this.DateRecommendedForCompletion.Equals(other.DateRecommendedForCompletion)
                ) &&
                (
                    this.LengthInMinutes == other.LengthInMinutes ||
                    this.LengthInMinutes != null &&
                    this.LengthInMinutes.Equals(other.LengthInMinutes)
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
                if (this.DateRecommendedForCompletion != null)
                    hash = hash * 59 + this.DateRecommendedForCompletion.GetHashCode();

                if (this.LengthInMinutes != null)
                    hash = hash * 59 + this.LengthInMinutes.GetHashCode();

                return hash;
            }
        }
    }

}
