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
    /// UpdateAgentSchedulingPreferencesRequest
    /// </summary>
    [DataContract]
    public partial class UpdateAgentSchedulingPreferencesRequest :  IEquatable<UpdateAgentSchedulingPreferencesRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentSchedulingPreferencesRequest" /> class.
        /// </summary>
        /// <param name="PreferencesToAdd">Scheduling preferences to add.</param>
        /// <param name="PreferenceIdsToRemove">IDs of scheduling preferences to remove.</param>
        public UpdateAgentSchedulingPreferencesRequest(List<AgentSchedulingPreference> PreferencesToAdd = null, List<string> PreferenceIdsToRemove = null)
        {
            this.PreferencesToAdd = PreferencesToAdd;
            this.PreferenceIdsToRemove = PreferenceIdsToRemove;
            
        }
        


        /// <summary>
        /// Scheduling preferences to add
        /// </summary>
        /// <value>Scheduling preferences to add</value>
        [DataMember(Name="preferencesToAdd", EmitDefaultValue=false)]
        public List<AgentSchedulingPreference> PreferencesToAdd { get; set; }



        /// <summary>
        /// IDs of scheduling preferences to remove
        /// </summary>
        /// <value>IDs of scheduling preferences to remove</value>
        [DataMember(Name="preferenceIdsToRemove", EmitDefaultValue=false)]
        public List<string> PreferenceIdsToRemove { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAgentSchedulingPreferencesRequest {\n");

            sb.Append("  PreferencesToAdd: ").Append(PreferencesToAdd).Append("\n");
            sb.Append("  PreferenceIdsToRemove: ").Append(PreferenceIdsToRemove).Append("\n");
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
            return this.Equals(obj as UpdateAgentSchedulingPreferencesRequest);
        }

        /// <summary>
        /// Returns true if UpdateAgentSchedulingPreferencesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateAgentSchedulingPreferencesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAgentSchedulingPreferencesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PreferencesToAdd == other.PreferencesToAdd ||
                    this.PreferencesToAdd != null &&
                    this.PreferencesToAdd.SequenceEqual(other.PreferencesToAdd)
                ) &&
                (
                    this.PreferenceIdsToRemove == other.PreferenceIdsToRemove ||
                    this.PreferenceIdsToRemove != null &&
                    this.PreferenceIdsToRemove.SequenceEqual(other.PreferenceIdsToRemove)
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
                if (this.PreferencesToAdd != null)
                    hash = hash * 59 + this.PreferencesToAdd.GetHashCode();

                if (this.PreferenceIdsToRemove != null)
                    hash = hash * 59 + this.PreferenceIdsToRemove.GetHashCode();

                return hash;
            }
        }
    }

}
