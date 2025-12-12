using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConditionalGroupActivationPilotRule
	/// </summary>
	[DataContract]
	public partial class ConditionalGroupActivationPilotRule : IEquatable<ConditionalGroupActivationPilotRule>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConditionalGroupActivationPilotRule" /> class.
		/// </summary>
		/// <param name="Conditions">The list of conditions used in this rule.</param>
		/// <param name="ConditionExpression">A string expression that defines the relationships of conditions in this rule.</param>
		public ConditionalGroupActivationPilotRule(List<ConditionalGroupActivationCondition> Conditions = null, string ConditionExpression = null)
		{
			this.Conditions = Conditions;
			this.ConditionExpression = ConditionExpression;

		}



		/// <summary>
		/// The list of conditions used in this rule
		/// </summary>
		/// <value>The list of conditions used in this rule</value>
		[DataMember(Name = "conditions", EmitDefaultValue = false)]
		public List<ConditionalGroupActivationCondition> Conditions { get; set; }



		/// <summary>
		/// A string expression that defines the relationships of conditions in this rule
		/// </summary>
		/// <value>A string expression that defines the relationships of conditions in this rule</value>
		[DataMember(Name = "conditionExpression", EmitDefaultValue = false)]
		public string ConditionExpression { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConditionalGroupActivationPilotRule {\n");

			sb.Append("  Conditions: ").Append(Conditions).Append("\n");
			sb.Append("  ConditionExpression: ").Append(ConditionExpression).Append("\n");
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
			return this.Equals(obj as ConditionalGroupActivationPilotRule);
		}

		/// <summary>
		/// Returns true if ConditionalGroupActivationPilotRule instances are equal
		/// </summary>
		/// <param name="other">Instance of ConditionalGroupActivationPilotRule to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConditionalGroupActivationPilotRule other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Conditions == other.Conditions ||
					this.Conditions != null &&
					this.Conditions.SequenceEqual(other.Conditions)
				) &&
				(
					this.ConditionExpression == other.ConditionExpression ||
					this.ConditionExpression != null &&
					this.ConditionExpression.Equals(other.ConditionExpression)
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
				if (this.Conditions != null)
					hash = hash * 59 + this.Conditions.GetHashCode();

				if (this.ConditionExpression != null)
					hash = hash * 59 + this.ConditionExpression.GetHashCode();

				return hash;
			}
		}
	}

}
