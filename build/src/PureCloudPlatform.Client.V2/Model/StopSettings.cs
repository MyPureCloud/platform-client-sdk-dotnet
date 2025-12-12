using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// StopSettings
	/// </summary>
	[DataContract]
	public partial class StopSettings : IEquatable<StopSettings>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="StopSettings" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected StopSettings() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="StopSettings" /> class.
		/// </summary>
		/// <param name="Keyword">List of keywords for compliance (required).</param>
		/// <param name="Response">The response configuration for the keywords (required).</param>
		public StopSettings(List<string> Keyword = null, ComplianceResponse Response = null)
		{
			this.Keyword = Keyword;
			this.Response = Response;

		}



		/// <summary>
		/// List of keywords for compliance
		/// </summary>
		/// <value>List of keywords for compliance</value>
		[DataMember(Name = "keyword", EmitDefaultValue = false)]
		public List<string> Keyword { get; set; }



		/// <summary>
		/// The response configuration for the keywords
		/// </summary>
		/// <value>The response configuration for the keywords</value>
		[DataMember(Name = "response", EmitDefaultValue = false)]
		public ComplianceResponse Response { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class StopSettings {\n");

			sb.Append("  Keyword: ").Append(Keyword).Append("\n");
			sb.Append("  Response: ").Append(Response).Append("\n");
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
			return this.Equals(obj as StopSettings);
		}

		/// <summary>
		/// Returns true if StopSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of StopSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(StopSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Keyword == other.Keyword ||
					this.Keyword != null &&
					this.Keyword.SequenceEqual(other.Keyword)
				) &&
				(
					this.Response == other.Response ||
					this.Response != null &&
					this.Response.Equals(other.Response)
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
				if (this.Keyword != null)
					hash = hash * 59 + this.Keyword.GetHashCode();

				if (this.Response != null)
					hash = hash * 59 + this.Response.GetHashCode();

				return hash;
			}
		}
	}

}
