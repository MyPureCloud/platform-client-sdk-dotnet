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
    /// ContestsFinalizeRequest
    /// </summary>
    [DataContract]
    public partial class ContestsFinalizeRequest :  IEquatable<ContestsFinalizeRequest>
    {
        /// <summary>
        /// The Contest finalization status
        /// </summary>
        /// <value>The Contest finalization status</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Cancelled for "Cancelled"
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled
        }
        /// <summary>
        /// The Contest finalization status
        /// </summary>
        /// <value>The Contest finalization status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContestsFinalizeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContestsFinalizeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContestsFinalizeRequest" /> class.
        /// </summary>
        /// <param name="Status">The Contest finalization status (required).</param>
        /// <param name="Winners">The Contest finalization winners.</param>
        /// <param name="DisqualifiedAgents">The Contest finalization disqualified agents.</param>
        public ContestsFinalizeRequest(StatusEnum? Status = null, List<ContestWinnersRequest> Winners = null, List<ContestDisqualifiedAgents> DisqualifiedAgents = null)
        {
            this.Status = Status;
            this.Winners = Winners;
            this.DisqualifiedAgents = DisqualifiedAgents;
            
        }
        




        /// <summary>
        /// The Contest finalization winners
        /// </summary>
        /// <value>The Contest finalization winners</value>
        [DataMember(Name="winners", EmitDefaultValue=false)]
        public List<ContestWinnersRequest> Winners { get; set; }



        /// <summary>
        /// The Contest finalization disqualified agents
        /// </summary>
        /// <value>The Contest finalization disqualified agents</value>
        [DataMember(Name="disqualifiedAgents", EmitDefaultValue=false)]
        public List<ContestDisqualifiedAgents> DisqualifiedAgents { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContestsFinalizeRequest {\n");

            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Winners: ").Append(Winners).Append("\n");
            sb.Append("  DisqualifiedAgents: ").Append(DisqualifiedAgents).Append("\n");
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
            return this.Equals(obj as ContestsFinalizeRequest);
        }

        /// <summary>
        /// Returns true if ContestsFinalizeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContestsFinalizeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContestsFinalizeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Winners == other.Winners ||
                    this.Winners != null &&
                    this.Winners.SequenceEqual(other.Winners)
                ) &&
                (
                    this.DisqualifiedAgents == other.DisqualifiedAgents ||
                    this.DisqualifiedAgents != null &&
                    this.DisqualifiedAgents.SequenceEqual(other.DisqualifiedAgents)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Winners != null)
                    hash = hash * 59 + this.Winners.GetHashCode();

                if (this.DisqualifiedAgents != null)
                    hash = hash * 59 + this.DisqualifiedAgents.GetHashCode();

                return hash;
            }
        }
    }

}
