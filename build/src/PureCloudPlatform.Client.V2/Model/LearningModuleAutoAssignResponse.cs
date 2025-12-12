using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Auto assign response
	/// </summary>
	[DataContract]
	public partial class LearningModuleAutoAssignResponse : IEquatable<LearningModuleAutoAssignResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="LearningModuleAutoAssignResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected LearningModuleAutoAssignResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="LearningModuleAutoAssignResponse" /> class.
		/// </summary>
		/// <param name="Rule">The rule reference (required).</param>
		/// <param name="Enabled">Whether the rule is enabled for the module (required).</param>
		public LearningModuleAutoAssignResponse(UsersRulesRuleReference Rule = null, bool? Enabled = null)
		{
			this.Rule = Rule;
			this.Enabled = Enabled;

		}



		/// <summary>
		/// The rule reference
		/// </summary>
		/// <value>The rule reference</value>
		[DataMember(Name = "rule", EmitDefaultValue = false)]
		public UsersRulesRuleReference Rule { get; set; }



		/// <summary>
		/// Whether the rule is enabled for the module
		/// </summary>
		/// <value>Whether the rule is enabled for the module</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LearningModuleAutoAssignResponse {\n");

			sb.Append("  Rule: ").Append(Rule).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
			return this.Equals(obj as LearningModuleAutoAssignResponse);
		}

		/// <summary>
		/// Returns true if LearningModuleAutoAssignResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of LearningModuleAutoAssignResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LearningModuleAutoAssignResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Rule == other.Rule ||
					this.Rule != null &&
					this.Rule.Equals(other.Rule)
				) &&
				(
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
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
				if (this.Rule != null)
					hash = hash * 59 + this.Rule.GetHashCode();

				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				return hash;
			}
		}
	}

}
