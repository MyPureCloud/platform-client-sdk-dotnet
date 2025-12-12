using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ConditionalGroupActivationRule
	/// </summary>
	[DataContract]
	public partial class ConditionalGroupActivationRule : IEquatable<ConditionalGroupActivationRule>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConditionalGroupActivationRule" /> class.
		/// </summary>
		/// <param name="Conditions">The list of conditions used in this rule.</param>
		/// <param name="ConditionExpression">A string expression that defines the relationships of conditions in this rule.</param>
		/// <param name="Groups">The group(s) that this rule activates (if rule evaluates as true) or deactivates (if rule evaluates as false).</param>
		public ConditionalGroupActivationRule(List<ConditionalGroupActivationCondition> Conditions = null, string ConditionExpression = null, List<MemberGroup> Groups = null)
		{
			this.Conditions = Conditions;
			this.ConditionExpression = ConditionExpression;
			this.Groups = Groups;

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
		/// The group(s) that this rule activates (if rule evaluates as true) or deactivates (if rule evaluates as false)
		/// </summary>
		/// <value>The group(s) that this rule activates (if rule evaluates as true) or deactivates (if rule evaluates as false)</value>
		[DataMember(Name = "groups", EmitDefaultValue = false)]
		public List<MemberGroup> Groups { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ConditionalGroupActivationRule {\n");

			sb.Append("  Conditions: ").Append(Conditions).Append("\n");
			sb.Append("  ConditionExpression: ").Append(ConditionExpression).Append("\n");
			sb.Append("  Groups: ").Append(Groups).Append("\n");
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
			return this.Equals(obj as ConditionalGroupActivationRule);
		}

		/// <summary>
		/// Returns true if ConditionalGroupActivationRule instances are equal
		/// </summary>
		/// <param name="other">Instance of ConditionalGroupActivationRule to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ConditionalGroupActivationRule other)
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
				) &&
				(
					this.Groups == other.Groups ||
					this.Groups != null &&
					this.Groups.SequenceEqual(other.Groups)
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

				if (this.Groups != null)
					hash = hash * 59 + this.Groups.GetHashCode();

				return hash;
			}
		}
	}

}
