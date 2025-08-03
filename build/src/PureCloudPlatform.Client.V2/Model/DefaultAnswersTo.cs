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
    /// DefaultAnswersTo
    /// </summary>
    [DataContract]
    public partial class DefaultAnswersTo :  IEquatable<DefaultAnswersTo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultAnswersTo" /> class.
        /// </summary>
        /// <param name="HighestScore">True, when answer should default to highest score.</param>
        /// <param name="NotApplicable">True, when answer should default to N/A.</param>
        /// <param name="LowestScore">True, when answer should default to lowest score.</param>
        /// <param name="UserDefined">True, when answer should default to user defined answer.</param>
        public DefaultAnswersTo(bool? HighestScore = null, bool? NotApplicable = null, bool? LowestScore = null, bool? UserDefined = null)
        {
            this.HighestScore = HighestScore;
            this.NotApplicable = NotApplicable;
            this.LowestScore = LowestScore;
            this.UserDefined = UserDefined;
            
        }
        


        /// <summary>
        /// True, when answer should default to highest score
        /// </summary>
        /// <value>True, when answer should default to highest score</value>
        [DataMember(Name="highestScore", EmitDefaultValue=false)]
        public bool? HighestScore { get; set; }



        /// <summary>
        /// True, when answer should default to N/A
        /// </summary>
        /// <value>True, when answer should default to N/A</value>
        [DataMember(Name="notApplicable", EmitDefaultValue=false)]
        public bool? NotApplicable { get; set; }



        /// <summary>
        /// True, when answer should default to lowest score
        /// </summary>
        /// <value>True, when answer should default to lowest score</value>
        [DataMember(Name="lowestScore", EmitDefaultValue=false)]
        public bool? LowestScore { get; set; }



        /// <summary>
        /// True, when answer should default to user defined answer
        /// </summary>
        /// <value>True, when answer should default to user defined answer</value>
        [DataMember(Name="userDefined", EmitDefaultValue=false)]
        public bool? UserDefined { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultAnswersTo {\n");

            sb.Append("  HighestScore: ").Append(HighestScore).Append("\n");
            sb.Append("  NotApplicable: ").Append(NotApplicable).Append("\n");
            sb.Append("  LowestScore: ").Append(LowestScore).Append("\n");
            sb.Append("  UserDefined: ").Append(UserDefined).Append("\n");
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
            return this.Equals(obj as DefaultAnswersTo);
        }

        /// <summary>
        /// Returns true if DefaultAnswersTo instances are equal
        /// </summary>
        /// <param name="other">Instance of DefaultAnswersTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DefaultAnswersTo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.HighestScore == other.HighestScore ||
                    this.HighestScore != null &&
                    this.HighestScore.Equals(other.HighestScore)
                ) &&
                (
                    this.NotApplicable == other.NotApplicable ||
                    this.NotApplicable != null &&
                    this.NotApplicable.Equals(other.NotApplicable)
                ) &&
                (
                    this.LowestScore == other.LowestScore ||
                    this.LowestScore != null &&
                    this.LowestScore.Equals(other.LowestScore)
                ) &&
                (
                    this.UserDefined == other.UserDefined ||
                    this.UserDefined != null &&
                    this.UserDefined.Equals(other.UserDefined)
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
                if (this.HighestScore != null)
                    hash = hash * 59 + this.HighestScore.GetHashCode();

                if (this.NotApplicable != null)
                    hash = hash * 59 + this.NotApplicable.GetHashCode();

                if (this.LowestScore != null)
                    hash = hash * 59 + this.LowestScore.GetHashCode();

                if (this.UserDefined != null)
                    hash = hash * 59 + this.UserDefined.GetHashCode();

                return hash;
            }
        }
    }

}
