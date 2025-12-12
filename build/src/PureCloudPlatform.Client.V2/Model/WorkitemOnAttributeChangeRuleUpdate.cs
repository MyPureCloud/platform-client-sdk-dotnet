using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemOnAttributeChangeRuleUpdate
	/// </summary>
	[DataContract]
	public partial class WorkitemOnAttributeChangeRuleUpdate : IEquatable<WorkitemOnAttributeChangeRuleUpdate>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemOnAttributeChangeRuleUpdate" /> class.
		/// </summary>
		/// <param name="Name">The name of the rule..</param>
		/// <param name="Condition">The rules condition. If the condition criteria is met the rules action will be executed..</param>
		public WorkitemOnAttributeChangeRuleUpdate(string Name = null, WorkitemOnAttributeChangeConditionUpdate Condition = null)
		{
			this.Name = Name;
			this.Condition = Condition;

		}



		/// <summary>
		/// The name of the rule.
		/// </summary>
		/// <value>The name of the rule.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The rules condition. If the condition criteria is met the rules action will be executed.
		/// </summary>
		/// <value>The rules condition. If the condition criteria is met the rules action will be executed.</value>
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public WorkitemOnAttributeChangeConditionUpdate Condition { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemOnAttributeChangeRuleUpdate {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Condition: ").Append(Condition).Append("\n");
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
			return this.Equals(obj as WorkitemOnAttributeChangeRuleUpdate);
		}

		/// <summary>
		/// Returns true if WorkitemOnAttributeChangeRuleUpdate instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemOnAttributeChangeRuleUpdate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemOnAttributeChangeRuleUpdate other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Condition == other.Condition ||
					this.Condition != null &&
					this.Condition.Equals(other.Condition)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Condition != null)
					hash = hash * 59 + this.Condition.GetHashCode();

				return hash;
			}
		}
	}

}
