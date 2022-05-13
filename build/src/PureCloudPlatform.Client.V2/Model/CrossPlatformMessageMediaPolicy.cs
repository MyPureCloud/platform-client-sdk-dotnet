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
    /// CrossPlatformMessageMediaPolicy
    /// </summary>
    [DataContract]
    public partial class CrossPlatformMessageMediaPolicy :  IEquatable<CrossPlatformMessageMediaPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossPlatformMessageMediaPolicy" /> class.
        /// </summary>
        /// <param name="Actions">Actions applied when specified conditions are met.</param>
        /// <param name="Conditions">Conditions for when actions should be applied.</param>
        public CrossPlatformMessageMediaPolicy(CrossPlatformPolicyActions Actions = null, MessageMediaPolicyConditions Conditions = null)
        {
            this.Actions = Actions;
            this.Conditions = Conditions;
            
        }
        


        /// <summary>
        /// Actions applied when specified conditions are met
        /// </summary>
        /// <value>Actions applied when specified conditions are met</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public CrossPlatformPolicyActions Actions { get; set; }



        /// <summary>
        /// Conditions for when actions should be applied
        /// </summary>
        /// <value>Conditions for when actions should be applied</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public MessageMediaPolicyConditions Conditions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrossPlatformMessageMediaPolicy {\n");

            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
            return this.Equals(obj as CrossPlatformMessageMediaPolicy);
        }

        /// <summary>
        /// Returns true if CrossPlatformMessageMediaPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of CrossPlatformMessageMediaPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrossPlatformMessageMediaPolicy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.Equals(other.Actions)
                ) &&
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.Equals(other.Conditions)
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
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();

                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();

                return hash;
            }
        }
    }

}
