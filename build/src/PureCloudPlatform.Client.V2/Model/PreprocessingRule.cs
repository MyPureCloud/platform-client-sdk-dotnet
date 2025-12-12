using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PreprocessingRule
	/// </summary>
	[DataContract]
	public partial class PreprocessingRule : IEquatable<PreprocessingRule>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PreprocessingRule" /> class.
		/// </summary>
		/// <param name="Find">The regular expression to which file lines are to be matched..</param>
		/// <param name="ReplaceWith">The string to be substituted for each match..</param>
		/// <param name="Global">Replaces all matching substrings in every line..</param>
		/// <param name="IgnoreCase">Enables case-insensitive matching.</param>
		public PreprocessingRule(string Find = null, string ReplaceWith = null, bool? Global = null, bool? IgnoreCase = null)
		{
			this.Find = Find;
			this.ReplaceWith = ReplaceWith;
			this.Global = Global;
			this.IgnoreCase = IgnoreCase;

		}



		/// <summary>
		/// The regular expression to which file lines are to be matched.
		/// </summary>
		/// <value>The regular expression to which file lines are to be matched.</value>
		[DataMember(Name = "find", EmitDefaultValue = false)]
		public string Find { get; set; }



		/// <summary>
		/// The string to be substituted for each match.
		/// </summary>
		/// <value>The string to be substituted for each match.</value>
		[DataMember(Name = "replaceWith", EmitDefaultValue = false)]
		public string ReplaceWith { get; set; }



		/// <summary>
		/// Replaces all matching substrings in every line.
		/// </summary>
		/// <value>Replaces all matching substrings in every line.</value>
		[DataMember(Name = "global", EmitDefaultValue = false)]
		public bool? Global { get; set; }



		/// <summary>
		/// Enables case-insensitive matching
		/// </summary>
		/// <value>Enables case-insensitive matching</value>
		[DataMember(Name = "ignoreCase", EmitDefaultValue = false)]
		public bool? IgnoreCase { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PreprocessingRule {\n");

			sb.Append("  Find: ").Append(Find).Append("\n");
			sb.Append("  ReplaceWith: ").Append(ReplaceWith).Append("\n");
			sb.Append("  Global: ").Append(Global).Append("\n");
			sb.Append("  IgnoreCase: ").Append(IgnoreCase).Append("\n");
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
			return this.Equals(obj as PreprocessingRule);
		}

		/// <summary>
		/// Returns true if PreprocessingRule instances are equal
		/// </summary>
		/// <param name="other">Instance of PreprocessingRule to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PreprocessingRule other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Find == other.Find ||
					this.Find != null &&
					this.Find.Equals(other.Find)
				) &&
				(
					this.ReplaceWith == other.ReplaceWith ||
					this.ReplaceWith != null &&
					this.ReplaceWith.Equals(other.ReplaceWith)
				) &&
				(
					this.Global == other.Global ||
					this.Global != null &&
					this.Global.Equals(other.Global)
				) &&
				(
					this.IgnoreCase == other.IgnoreCase ||
					this.IgnoreCase != null &&
					this.IgnoreCase.Equals(other.IgnoreCase)
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
				if (this.Find != null)
					hash = hash * 59 + this.Find.GetHashCode();

				if (this.ReplaceWith != null)
					hash = hash * 59 + this.ReplaceWith.GetHashCode();

				if (this.Global != null)
					hash = hash * 59 + this.Global.GetHashCode();

				if (this.IgnoreCase != null)
					hash = hash * 59 + this.IgnoreCase.GetHashCode();

				return hash;
			}
		}
	}

}
