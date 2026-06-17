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
    /// UpdateAgentScheduleBiddingPreference
    /// </summary>
    [DataContract]
    public partial class UpdateAgentScheduleBiddingPreference :  IEquatable<UpdateAgentScheduleBiddingPreference>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentScheduleBiddingPreference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAgentScheduleBiddingPreference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentScheduleBiddingPreference" /> class.
        /// </summary>
        /// <param name="Submitted">Whether the preference is submitted (required).</param>
        /// <param name="AgentScheduleBidPreferences">The schedule bidding preferences (required).</param>
        public UpdateAgentScheduleBiddingPreference(bool? Submitted = null, List<AgentScheduleBiddingPreferencePriority> AgentScheduleBidPreferences = null)
        {
            this.Submitted = Submitted;
            this.AgentScheduleBidPreferences = AgentScheduleBidPreferences;
            
        }
        


        /// <summary>
        /// Whether the preference is submitted
        /// </summary>
        /// <value>Whether the preference is submitted</value>
        [DataMember(Name="submitted", EmitDefaultValue=false)]
        public bool? Submitted { get; set; }



        /// <summary>
        /// The schedule bidding preferences
        /// </summary>
        /// <value>The schedule bidding preferences</value>
        [DataMember(Name="agentScheduleBidPreferences", EmitDefaultValue=false)]
        public List<AgentScheduleBiddingPreferencePriority> AgentScheduleBidPreferences { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAgentScheduleBiddingPreference {\n");

            sb.Append("  Submitted: ").Append(Submitted).Append("\n");
            sb.Append("  AgentScheduleBidPreferences: ").Append(AgentScheduleBidPreferences).Append("\n");
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
            return this.Equals(obj as UpdateAgentScheduleBiddingPreference);
        }

        /// <summary>
        /// Returns true if UpdateAgentScheduleBiddingPreference instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateAgentScheduleBiddingPreference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAgentScheduleBiddingPreference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Submitted == other.Submitted ||
                    this.Submitted != null &&
                    this.Submitted.Equals(other.Submitted)
                ) &&
                (
                    this.AgentScheduleBidPreferences == other.AgentScheduleBidPreferences ||
                    this.AgentScheduleBidPreferences != null &&
                    this.AgentScheduleBidPreferences.SequenceEqual(other.AgentScheduleBidPreferences)
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
                if (this.Submitted != null)
                    hash = hash * 59 + this.Submitted.GetHashCode();

                if (this.AgentScheduleBidPreferences != null)
                    hash = hash * 59 + this.AgentScheduleBidPreferences.GetHashCode();

                return hash;
            }
        }
    }

}
