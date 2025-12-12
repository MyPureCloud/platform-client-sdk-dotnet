using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Defines a request in the SCIM service provider&#39;s configuration.
	/// </summary>
	[DataContract]
	public partial class ScimServiceProviderConfigSimpleFeature : IEquatable<ScimServiceProviderConfigSimpleFeature>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ScimServiceProviderConfigSimpleFeature" /> class.
		/// </summary>
		public ScimServiceProviderConfigSimpleFeature()
		{

		}



		/// <summary>
		/// Indicates whether configuration options are supported.
		/// </summary>
		/// <value>Indicates whether configuration options are supported.</value>
		[DataMember(Name = "supported", EmitDefaultValue = false)]
		public bool? Supported { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ScimServiceProviderConfigSimpleFeature {\n");

			sb.Append("  Supported: ").Append(Supported).Append("\n");
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
			return this.Equals(obj as ScimServiceProviderConfigSimpleFeature);
		}

		/// <summary>
		/// Returns true if ScimServiceProviderConfigSimpleFeature instances are equal
		/// </summary>
		/// <param name="other">Instance of ScimServiceProviderConfigSimpleFeature to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ScimServiceProviderConfigSimpleFeature other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Supported == other.Supported ||
					this.Supported != null &&
					this.Supported.Equals(other.Supported)
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
				if (this.Supported != null)
					hash = hash * 59 + this.Supported.GetHashCode();

				return hash;
			}
		}
	}

}
