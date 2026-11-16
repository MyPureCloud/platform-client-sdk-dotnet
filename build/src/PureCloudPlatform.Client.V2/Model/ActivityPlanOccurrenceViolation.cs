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
    /// ActivityPlanOccurrenceViolation
    /// </summary>
    [DataContract]
    public partial class ActivityPlanOccurrenceViolation :  IEquatable<ActivityPlanOccurrenceViolation>
    {
        /// <summary>
        /// The type of violation for this occurrence
        /// </summary>
        /// <value>The type of violation for this occurrence</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Maxsessions for "MaxSessions"
            /// </summary>
            [EnumMember(Value = "MaxSessions")]
            Maxsessions,
            
            /// <summary>
            /// Enum Maxsimultaneoussessions for "MaxSimultaneousSessions"
            /// </summary>
            [EnumMember(Value = "MaxSimultaneousSessions")]
            Maxsimultaneoussessions,
            
            /// <summary>
            /// Enum Minimumoccurrencetime for "MinimumOccurrenceTime"
            /// </summary>
            [EnumMember(Value = "MinimumOccurrenceTime")]
            Minimumoccurrencetime,
            
            /// <summary>
            /// Enum Recurrenceends for "RecurrenceEnds"
            /// </summary>
            [EnumMember(Value = "RecurrenceEnds")]
            Recurrenceends
        }
        /// <summary>
        /// The type of violation for this occurrence
        /// </summary>
        /// <value>The type of violation for this occurrence</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanOccurrenceViolation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanOccurrenceViolation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanOccurrenceViolation" /> class.
        /// </summary>
        /// <param name="Type">The type of violation for this occurrence (required).</param>
        /// <param name="Details">The detail of the violation.</param>
        public ActivityPlanOccurrenceViolation(TypeEnum? Type = null, ActivityPlanViolationDetails Details = null)
        {
            this.Type = Type;
            this.Details = Details;
            
        }
        




        /// <summary>
        /// The detail of the violation
        /// </summary>
        /// <value>The detail of the violation</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public ActivityPlanViolationDetails Details { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityPlanOccurrenceViolation {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as ActivityPlanOccurrenceViolation);
        }

        /// <summary>
        /// Returns true if ActivityPlanOccurrenceViolation instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanOccurrenceViolation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanOccurrenceViolation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();

                return hash;
            }
        }
    }

}
