using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// NluDomainVersionTrainingResponse
	/// </summary>
	[DataContract]
	public partial class NluDomainVersionTrainingResponse : IEquatable<NluDomainVersionTrainingResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NluDomainVersionTrainingResponse" /> class.
		/// </summary>
		/// <param name="Version">Version.</param>
		public NluDomainVersionTrainingResponse(NluDomainVersion Version = null)
		{
			this.Version = Version;

		}



		/// <summary>
		/// A message indicating result of the action.
		/// </summary>
		/// <value>A message indicating result of the action.</value>
		[DataMember(Name = "message", EmitDefaultValue = false)]
		public string Message { get; private set; }



		/// <summary>
		/// Gets or Sets Version
		/// </summary>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public NluDomainVersion Version { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NluDomainVersionTrainingResponse {\n");

			sb.Append("  Message: ").Append(Message).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
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
			return this.Equals(obj as NluDomainVersionTrainingResponse);
		}

		/// <summary>
		/// Returns true if NluDomainVersionTrainingResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of NluDomainVersionTrainingResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NluDomainVersionTrainingResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Message == other.Message ||
					this.Message != null &&
					this.Message.Equals(other.Message)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
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
				if (this.Message != null)
					hash = hash * 59 + this.Message.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				return hash;
			}
		}
	}

}
