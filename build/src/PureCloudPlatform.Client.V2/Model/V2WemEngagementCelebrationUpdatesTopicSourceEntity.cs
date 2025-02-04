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
    /// V2WemEngagementCelebrationUpdatesTopicSourceEntity
    /// </summary>
    [DataContract]
    public partial class V2WemEngagementCelebrationUpdatesTopicSourceEntity :  IEquatable<V2WemEngagementCelebrationUpdatesTopicSourceEntity>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum Unknown for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            
            /// <summary>
            /// Enum ThankYou for "THANK_YOU"
            /// </summary>
            [EnumMember(Value = "THANK_YOU")]
            ThankYou,
            
            /// <summary>
            /// Enum Congratulations for "CONGRATULATIONS"
            /// </summary>
            [EnumMember(Value = "CONGRATULATIONS")]
            Congratulations,
            
            /// <summary>
            /// Enum HighPerformance for "HIGH_PERFORMANCE"
            /// </summary>
            [EnumMember(Value = "HIGH_PERFORMANCE")]
            HighPerformance,
            
            /// <summary>
            /// Enum CompanyValues for "COMPANY_VALUES"
            /// </summary>
            [EnumMember(Value = "COMPANY_VALUES")]
            CompanyValues,
            
            /// <summary>
            /// Enum Competition for "COMPETITION"
            /// </summary>
            [EnumMember(Value = "COMPETITION")]
            Competition,
            
            /// <summary>
            /// Enum Race for "RACE"
            /// </summary>
            [EnumMember(Value = "RACE")]
            Race,
            
            /// <summary>
            /// Enum Raffle for "RAFFLE"
            /// </summary>
            [EnumMember(Value = "RAFFLE")]
            Raffle,
            
            /// <summary>
            /// Enum TeamGoal for "TEAM_GOAL"
            /// </summary>
            [EnumMember(Value = "TEAM_GOAL")]
            TeamGoal
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicSourceEntity" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type.</param>
        /// <param name="ContestCompleteData">ContestCompleteData.</param>
        public V2WemEngagementCelebrationUpdatesTopicSourceEntity(Guid? Id = null, TypeEnum? Type = null, V2WemEngagementCelebrationUpdatesTopicContestCompleteData ContestCompleteData = null)
        {
            this.Id = Id;
            this.Type = Type;
            this.ContestCompleteData = ContestCompleteData;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }





        /// <summary>
        /// Gets or Sets ContestCompleteData
        /// </summary>
        [DataMember(Name="contestCompleteData", EmitDefaultValue=false)]
        public V2WemEngagementCelebrationUpdatesTopicContestCompleteData ContestCompleteData { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2WemEngagementCelebrationUpdatesTopicSourceEntity {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContestCompleteData: ").Append(ContestCompleteData).Append("\n");
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
            return this.Equals(obj as V2WemEngagementCelebrationUpdatesTopicSourceEntity);
        }

        /// <summary>
        /// Returns true if V2WemEngagementCelebrationUpdatesTopicSourceEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicSourceEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2WemEngagementCelebrationUpdatesTopicSourceEntity other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.ContestCompleteData == other.ContestCompleteData ||
                    this.ContestCompleteData != null &&
                    this.ContestCompleteData.Equals(other.ContestCompleteData)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.ContestCompleteData != null)
                    hash = hash * 59 + this.ContestCompleteData.GetHashCode();

                return hash;
            }
        }
    }

}
