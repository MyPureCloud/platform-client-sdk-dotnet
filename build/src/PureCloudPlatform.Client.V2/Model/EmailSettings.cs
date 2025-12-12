using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EmailSettings
	/// </summary>
	[DataContract]
	public partial class EmailSettings : IEquatable<EmailSettings>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EmailSettings" /> class.
		/// </summary>
		/// <param name="MultipleRouteDestinationsOnInboundEmailEnabled">This setting allows a single inbound email that contains multiple routes configured in Genesys Cloud to create a conversation per route. When this setting is disabled only a single conversation will be created.</param>
		public EmailSettings(bool? MultipleRouteDestinationsOnInboundEmailEnabled = null)
		{
			this.MultipleRouteDestinationsOnInboundEmailEnabled = MultipleRouteDestinationsOnInboundEmailEnabled;

		}



		/// <summary>
		/// This setting allows a single inbound email that contains multiple routes configured in Genesys Cloud to create a conversation per route. When this setting is disabled only a single conversation will be created
		/// </summary>
		/// <value>This setting allows a single inbound email that contains multiple routes configured in Genesys Cloud to create a conversation per route. When this setting is disabled only a single conversation will be created</value>
		[DataMember(Name = "multipleRouteDestinationsOnInboundEmailEnabled", EmitDefaultValue = false)]
		public bool? MultipleRouteDestinationsOnInboundEmailEnabled { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EmailSettings {\n");

			sb.Append("  MultipleRouteDestinationsOnInboundEmailEnabled: ").Append(MultipleRouteDestinationsOnInboundEmailEnabled).Append("\n");
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
			return this.Equals(obj as EmailSettings);
		}

		/// <summary>
		/// Returns true if EmailSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of EmailSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EmailSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.MultipleRouteDestinationsOnInboundEmailEnabled == other.MultipleRouteDestinationsOnInboundEmailEnabled ||
					this.MultipleRouteDestinationsOnInboundEmailEnabled != null &&
					this.MultipleRouteDestinationsOnInboundEmailEnabled.Equals(other.MultipleRouteDestinationsOnInboundEmailEnabled)
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
				if (this.MultipleRouteDestinationsOnInboundEmailEnabled != null)
					hash = hash * 59 + this.MultipleRouteDestinationsOnInboundEmailEnabled.GetHashCode();

				return hash;
			}
		}
	}

}
