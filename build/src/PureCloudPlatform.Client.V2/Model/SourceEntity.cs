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
    /// SourceEntity
    /// </summary>
    [DataContract]
    public partial class SourceEntity :  IEquatable<SourceEntity>
    {
        /// <summary>
        /// The type of the source entity
        /// </summary>
        /// <value>The type of the source entity</value>
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
            /// Enum Thankyou for "ThankYou"
            /// </summary>
            [EnumMember(Value = "ThankYou")]
            Thankyou,
            
            /// <summary>
            /// Enum Congratulations for "Congratulations"
            /// </summary>
            [EnumMember(Value = "Congratulations")]
            Congratulations,
            
            /// <summary>
            /// Enum Highperformance for "HighPerformance"
            /// </summary>
            [EnumMember(Value = "HighPerformance")]
            Highperformance,
            
            /// <summary>
            /// Enum Companyvalues for "CompanyValues"
            /// </summary>
            [EnumMember(Value = "CompanyValues")]
            Companyvalues,
            
            /// <summary>
            /// Enum Competition for "Competition"
            /// </summary>
            [EnumMember(Value = "Competition")]
            Competition,
            
            /// <summary>
            /// Enum Race for "Race"
            /// </summary>
            [EnumMember(Value = "Race")]
            Race,
            
            /// <summary>
            /// Enum Raffle for "Raffle"
            /// </summary>
            [EnumMember(Value = "Raffle")]
            Raffle,
            
            /// <summary>
            /// Enum Teamgoal for "TeamGoal"
            /// </summary>
            [EnumMember(Value = "TeamGoal")]
            Teamgoal
        }
        /// <summary>
        /// The type of the source entity
        /// </summary>
        /// <value>The type of the source entity</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceEntity" /> class.
        /// </summary>
        /// <param name="Type">The type of the source entity.</param>
        /// <param name="ContestCompleteData">The contest data - Only supplied when celebration is of type ContestComplete.</param>
        public SourceEntity(TypeEnum? Type = null, ContestCompleteData ContestCompleteData = null)
        {
            this.Type = Type;
            this.ContestCompleteData = ContestCompleteData;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// The contest data - Only supplied when celebration is of type ContestComplete
        /// </summary>
        /// <value>The contest data - Only supplied when celebration is of type ContestComplete</value>
        [DataMember(Name="contestCompleteData", EmitDefaultValue=false)]
        public ContestCompleteData ContestCompleteData { get; set; }



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
            sb.Append("class SourceEntity {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContestCompleteData: ").Append(ContestCompleteData).Append("\n");
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
            return this.Equals(obj as SourceEntity);
        }

        /// <summary>
        /// Returns true if SourceEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of SourceEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceEntity other)
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

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.ContestCompleteData != null)
                    hash = hash * 59 + this.ContestCompleteData.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
