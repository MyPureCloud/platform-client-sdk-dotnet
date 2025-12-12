using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ExportScriptResponse
	/// </summary>
	[DataContract]
	public partial class ExportScriptResponse : IEquatable<ExportScriptResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExportScriptResponse" /> class.
		/// </summary>
		/// <param name="Url">Url.</param>
		public ExportScriptResponse(string Url = null)
		{
			this.Url = Url;

		}



		/// <summary>
		/// Gets or Sets Url
		/// </summary>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ExportScriptResponse {\n");

			sb.Append("  Url: ").Append(Url).Append("\n");
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
			return this.Equals(obj as ExportScriptResponse);
		}

		/// <summary>
		/// Returns true if ExportScriptResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ExportScriptResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ExportScriptResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url)
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
				if (this.Url != null)
					hash = hash * 59 + this.Url.GetHashCode();

				return hash;
			}
		}
	}

}
