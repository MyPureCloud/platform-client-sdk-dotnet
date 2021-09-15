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
    /// OutcomeEventScore
    /// </summary>
    [DataContract]
    public partial class OutcomeEventScore :  IEquatable<OutcomeEventScore>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeEventScore" /> class.
        /// </summary>
        /// <param name="Outcome">The outcome that the score was calculated for..</param>
        /// <param name="SessionMaxProbability">Represents the max probability reached in the session..</param>
        /// <param name="Probability">Represents the likelihood of a customer reaching or achieving a given outcome..</param>
        public OutcomeEventScore(AddressableEntityRef Outcome = null, float? SessionMaxProbability = null, float? Probability = null)
        {
            this.Outcome = Outcome;
            this.SessionMaxProbability = SessionMaxProbability;
            this.Probability = Probability;
            
        }
        
        
        
        /// <summary>
        /// The outcome that the score was calculated for.
        /// </summary>
        /// <value>The outcome that the score was calculated for.</value>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public AddressableEntityRef Outcome { get; set; }
        
        
        
        /// <summary>
        /// Represents the max probability reached in the session.
        /// </summary>
        /// <value>Represents the max probability reached in the session.</value>
        [DataMember(Name="sessionMaxProbability", EmitDefaultValue=false)]
        public float? SessionMaxProbability { get; set; }
        
        
        
        /// <summary>
        /// Represents the likelihood of a customer reaching or achieving a given outcome.
        /// </summary>
        /// <value>Represents the likelihood of a customer reaching or achieving a given outcome.</value>
        [DataMember(Name="probability", EmitDefaultValue=false)]
        public float? Probability { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutcomeEventScore {\n");
            
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  SessionMaxProbability: ").Append(SessionMaxProbability).Append("\n");
            sb.Append("  Probability: ").Append(Probability).Append("\n");
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
            return this.Equals(obj as OutcomeEventScore);
        }

        /// <summary>
        /// Returns true if OutcomeEventScore instances are equal
        /// </summary>
        /// <param name="other">Instance of OutcomeEventScore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutcomeEventScore other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Outcome == other.Outcome ||
                    this.Outcome != null &&
                    this.Outcome.Equals(other.Outcome)
                ) &&
                (
                    this.SessionMaxProbability == other.SessionMaxProbability ||
                    this.SessionMaxProbability != null &&
                    this.SessionMaxProbability.Equals(other.SessionMaxProbability)
                ) &&
                (
                    this.Probability == other.Probability ||
                    this.Probability != null &&
                    this.Probability.Equals(other.Probability)
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
                
                if (this.Outcome != null)
                    hash = hash * 59 + this.Outcome.GetHashCode();
                
                if (this.SessionMaxProbability != null)
                    hash = hash * 59 + this.SessionMaxProbability.GetHashCode();
                
                if (this.Probability != null)
                    hash = hash * 59 + this.Probability.GetHashCode();
                
                return hash;
            }
        }
    }

}
