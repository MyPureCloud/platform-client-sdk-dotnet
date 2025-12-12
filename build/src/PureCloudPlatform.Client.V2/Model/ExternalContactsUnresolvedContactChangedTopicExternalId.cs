using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ExternalContactsUnresolvedContactChangedTopicExternalId
	/// </summary>
	[DataContract]
	public partial class ExternalContactsUnresolvedContactChangedTopicExternalId : IEquatable<ExternalContactsUnresolvedContactChangedTopicExternalId>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExternalContactsUnresolvedContactChangedTopicExternalId" /> class.
		/// </summary>
		/// <param name="ExternalSource">ExternalSource.</param>
		/// <param name="Value">Value.</param>
		public ExternalContactsUnresolvedContactChangedTopicExternalId(ExternalContactsUnresolvedContactChangedTopicExternalSource ExternalSource = null, string Value = null)
		{
			this.ExternalSource = ExternalSource;
			this.Value = Value;

		}



		/// <summary>
		/// Gets or Sets ExternalSource
		/// </summary>
		[DataMember(Name = "externalSource", EmitDefaultValue = false)]
		public ExternalContactsUnresolvedContactChangedTopicExternalSource ExternalSource { get; set; }



		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ExternalContactsUnresolvedContactChangedTopicExternalId {\n");

			sb.Append("  ExternalSource: ").Append(ExternalSource).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as ExternalContactsUnresolvedContactChangedTopicExternalId);
		}

		/// <summary>
		/// Returns true if ExternalContactsUnresolvedContactChangedTopicExternalId instances are equal
		/// </summary>
		/// <param name="other">Instance of ExternalContactsUnresolvedContactChangedTopicExternalId to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ExternalContactsUnresolvedContactChangedTopicExternalId other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ExternalSource == other.ExternalSource ||
					this.ExternalSource != null &&
					this.ExternalSource.Equals(other.ExternalSource)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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
				if (this.ExternalSource != null)
					hash = hash * 59 + this.ExternalSource.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
