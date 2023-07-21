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
        /// <param name="Percentile">(Deprecated: use the 'quantile' field instead) Represents the predicted probability's percentile score when compared with all other generated probabilities for a given outcome..</param>
        /// <param name="SessionMaxPercentile">(Deprecated: use the 'quantile' field instead) Represents the maximum likelihood percentile score reached for a given outcome by the current session..</param>
        /// <param name="Quantile">Represents the quantity of sessions that have a maximum probability less than the predicted probability..</param>
        /// <param name="SessionMaxQuantile">Represents the quantity of sessions that have a maximum probability less than the predicted session max probability..</param>
        public OutcomeEventScore(AddressableEntityRef Outcome = null, float? SessionMaxProbability = null, float? Probability = null, int? Percentile = null, int? SessionMaxPercentile = null, float? Quantile = null, float? SessionMaxQuantile = null)
        {
            this.Outcome = Outcome;
            this.SessionMaxProbability = SessionMaxProbability;
            this.Probability = Probability;
            this.Percentile = Percentile;
            this.SessionMaxPercentile = SessionMaxPercentile;
            this.Quantile = Quantile;
            this.SessionMaxQuantile = SessionMaxQuantile;
            
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
        /// (Deprecated: use the 'quantile' field instead) Represents the predicted probability's percentile score when compared with all other generated probabilities for a given outcome.
        /// </summary>
        /// <value>(Deprecated: use the 'quantile' field instead) Represents the predicted probability's percentile score when compared with all other generated probabilities for a given outcome.</value>
        [DataMember(Name="percentile", EmitDefaultValue=false)]
        public int? Percentile { get; set; }



        /// <summary>
        /// (Deprecated: use the 'quantile' field instead) Represents the maximum likelihood percentile score reached for a given outcome by the current session.
        /// </summary>
        /// <value>(Deprecated: use the 'quantile' field instead) Represents the maximum likelihood percentile score reached for a given outcome by the current session.</value>
        [DataMember(Name="sessionMaxPercentile", EmitDefaultValue=false)]
        public int? SessionMaxPercentile { get; set; }



        /// <summary>
        /// Represents the quantity of sessions that have a maximum probability less than the predicted probability.
        /// </summary>
        /// <value>Represents the quantity of sessions that have a maximum probability less than the predicted probability.</value>
        [DataMember(Name="quantile", EmitDefaultValue=false)]
        public float? Quantile { get; set; }



        /// <summary>
        /// Represents the quantity of sessions that have a maximum probability less than the predicted session max probability.
        /// </summary>
        /// <value>Represents the quantity of sessions that have a maximum probability less than the predicted session max probability.</value>
        [DataMember(Name="sessionMaxQuantile", EmitDefaultValue=false)]
        public float? SessionMaxQuantile { get; set; }


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
            sb.Append("  Percentile: ").Append(Percentile).Append("\n");
            sb.Append("  SessionMaxPercentile: ").Append(SessionMaxPercentile).Append("\n");
            sb.Append("  Quantile: ").Append(Quantile).Append("\n");
            sb.Append("  SessionMaxQuantile: ").Append(SessionMaxQuantile).Append("\n");
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
                ) &&
                (
                    this.Percentile == other.Percentile ||
                    this.Percentile != null &&
                    this.Percentile.Equals(other.Percentile)
                ) &&
                (
                    this.SessionMaxPercentile == other.SessionMaxPercentile ||
                    this.SessionMaxPercentile != null &&
                    this.SessionMaxPercentile.Equals(other.SessionMaxPercentile)
                ) &&
                (
                    this.Quantile == other.Quantile ||
                    this.Quantile != null &&
                    this.Quantile.Equals(other.Quantile)
                ) &&
                (
                    this.SessionMaxQuantile == other.SessionMaxQuantile ||
                    this.SessionMaxQuantile != null &&
                    this.SessionMaxQuantile.Equals(other.SessionMaxQuantile)
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

                if (this.Percentile != null)
                    hash = hash * 59 + this.Percentile.GetHashCode();

                if (this.SessionMaxPercentile != null)
                    hash = hash * 59 + this.SessionMaxPercentile.GetHashCode();

                if (this.Quantile != null)
                    hash = hash * 59 + this.Quantile.GetHashCode();

                if (this.SessionMaxQuantile != null)
                    hash = hash * 59 + this.SessionMaxQuantile.GetHashCode();

                return hash;
            }
        }
    }

}
