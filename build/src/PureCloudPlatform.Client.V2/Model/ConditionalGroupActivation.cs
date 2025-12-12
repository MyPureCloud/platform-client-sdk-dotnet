using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConditionalGroupActivation
	/// </summary>
	[DataContract]
	public partial class ConditionalGroupActivation : IEquatable<ConditionalGroupActivation>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConditionalGroupActivation" /> class.
		/// </summary>
		/// <param name="PilotRule">The pilot rule for this queue, which executes periodically to determine queue health.</param>
		/// <param name="Rules">The set of rules to be periodically executed on the queue (if the pilot rule evaluates as true or there is no pilot rule).</param>
		public ConditionalGroupActivation(ConditionalGroupActivationPilotRule PilotRule = null, List<ConditionalGroupActivationRule> Rules = null)
		{
			this.PilotRule = PilotRule;
			this.Rules = Rules;

		}



		/// <summary>
		/// The pilot rule for this queue, which executes periodically to determine queue health
		/// </summary>
		/// <value>The pilot rule for this queue, which executes periodically to determine queue health</value>
		[DataMember(Name = "pilotRule", EmitDefaultValue = false)]
		public ConditionalGroupActivationPilotRule PilotRule { get; set; }



		/// <summary>
		/// The set of rules to be periodically executed on the queue (if the pilot rule evaluates as true or there is no pilot rule)
		/// </summary>
		/// <value>The set of rules to be periodically executed on the queue (if the pilot rule evaluates as true or there is no pilot rule)</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<ConditionalGroupActivationRule> Rules { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConditionalGroupActivation {\n");

			sb.Append("  PilotRule: ").Append(PilotRule).Append("\n");
			sb.Append("  Rules: ").Append(Rules).Append("\n");
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
			return this.Equals(obj as ConditionalGroupActivation);
		}

		/// <summary>
		/// Returns true if ConditionalGroupActivation instances are equal
		/// </summary>
		/// <param name="other">Instance of ConditionalGroupActivation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConditionalGroupActivation other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.PilotRule == other.PilotRule ||
					this.PilotRule != null &&
					this.PilotRule.Equals(other.PilotRule)
				) &&
				(
					this.Rules == other.Rules ||
					this.Rules != null &&
					this.Rules.SequenceEqual(other.Rules)
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
				if (this.PilotRule != null)
					hash = hash * 59 + this.PilotRule.GetHashCode();

				if (this.Rules != null)
					hash = hash * 59 + this.Rules.GetHashCode();

				return hash;
			}
		}
	}

}
