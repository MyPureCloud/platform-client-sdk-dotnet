using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FlowHealth
	/// </summary>
	[DataContract]
	public partial class FlowHealth : IEquatable<FlowHealth>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FlowHealth" /> class.
		/// </summary>
		/// <param name="FlowVersionInfo">Info about given flow version..</param>
		/// <param name="LanguageInfo">Each language&#39;s status about its health computation..</param>
		/// <param name="Intents">Health metrics information for the intents..</param>
		public FlowHealth(FlowHealthVersionInfo FlowVersionInfo = null, Dictionary<string, LocaleInfo> LanguageInfo = null, List<FlowHealthIntentInfo> Intents = null)
		{
			this.FlowVersionInfo = FlowVersionInfo;
			this.LanguageInfo = LanguageInfo;
			this.Intents = Intents;

		}



		/// <summary>
		/// Info about given flow version.
		/// </summary>
		/// <value>Info about given flow version.</value>
		[DataMember(Name = "flowVersionInfo", EmitDefaultValue = false)]
		public FlowHealthVersionInfo FlowVersionInfo { get; set; }



		/// <summary>
		/// Each language&#39;s status about its health computation.
		/// </summary>
		/// <value>Each language&#39;s status about its health computation.</value>
		[DataMember(Name = "languageInfo", EmitDefaultValue = false)]
		public Dictionary<string, LocaleInfo> LanguageInfo { get; set; }



		/// <summary>
		/// Health metrics information for the intents.
		/// </summary>
		/// <value>Health metrics information for the intents.</value>
		[DataMember(Name = "intents", EmitDefaultValue = false)]
		public List<FlowHealthIntentInfo> Intents { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FlowHealth {\n");

			sb.Append("  FlowVersionInfo: ").Append(FlowVersionInfo).Append("\n");
			sb.Append("  LanguageInfo: ").Append(LanguageInfo).Append("\n");
			sb.Append("  Intents: ").Append(Intents).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as FlowHealth);
		}

		/// <summary>
		/// Returns true if FlowHealth instances are equal
		/// </summary>
		/// <param name="other">Instance of FlowHealth to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FlowHealth other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FlowVersionInfo == other.FlowVersionInfo ||
					this.FlowVersionInfo != null &&
					this.FlowVersionInfo.Equals(other.FlowVersionInfo)
				) &&
				(
					this.LanguageInfo == other.LanguageInfo ||
					this.LanguageInfo != null &&
					this.LanguageInfo.SequenceEqual(other.LanguageInfo)
				) &&
				(
					this.Intents == other.Intents ||
					this.Intents != null &&
					this.Intents.SequenceEqual(other.Intents)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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
				if (this.FlowVersionInfo != null)
					hash = hash * 59 + this.FlowVersionInfo.GetHashCode();

				if (this.LanguageInfo != null)
					hash = hash * 59 + this.LanguageInfo.GetHashCode();

				if (this.Intents != null)
					hash = hash * 59 + this.Intents.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
