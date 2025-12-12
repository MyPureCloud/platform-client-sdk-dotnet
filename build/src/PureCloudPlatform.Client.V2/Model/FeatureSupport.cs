using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FeatureSupport
	/// </summary>
	[DataContract]
	public partial class FeatureSupport : IEquatable<FeatureSupport>
	{
		/// <summary>
		/// Level of support for a feature.
		/// </summary>
		/// <value>Level of support for a feature.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SupportLevelEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Supported for "Supported"
			/// </summary>
			[EnumMember(Value = "Supported")]
			Supported,

			/// <summary>
			/// Enum Notsupported for "NotSupported"
			/// </summary>
			[EnumMember(Value = "NotSupported")]
			Notsupported
		}
		/// <summary>
		/// Level of support for a feature.
		/// </summary>
		/// <value>Level of support for a feature.</value>
		[DataMember(Name = "supportLevel", EmitDefaultValue = false)]
		public SupportLevelEnum? SupportLevel { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="FeatureSupport" /> class.
		/// </summary>
		public FeatureSupport()
		{

		}



		/// <summary>
		/// Feature name.
		/// </summary>
		/// <value>Feature name.</value>
		[DataMember(Name = "feature", EmitDefaultValue = false)]
		public string Feature { get; private set; }





		/// <summary>
		/// Additional information for the support of a feature.
		/// </summary>
		/// <value>Additional information for the support of a feature.</value>
		[DataMember(Name = "details", EmitDefaultValue = false)]
		public string Details { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FeatureSupport {\n");

			sb.Append("  Feature: ").Append(Feature).Append("\n");
			sb.Append("  SupportLevel: ").Append(SupportLevel).Append("\n");
			sb.Append("  Details: ").Append(Details).Append("\n");
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
			return this.Equals(obj as FeatureSupport);
		}

		/// <summary>
		/// Returns true if FeatureSupport instances are equal
		/// </summary>
		/// <param name="other">Instance of FeatureSupport to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FeatureSupport other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Feature == other.Feature ||
					this.Feature != null &&
					this.Feature.Equals(other.Feature)
				) &&
				(
					this.SupportLevel == other.SupportLevel ||
					this.SupportLevel != null &&
					this.SupportLevel.Equals(other.SupportLevel)
				) &&
				(
					this.Details == other.Details ||
					this.Details != null &&
					this.Details.Equals(other.Details)
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
				if (this.Feature != null)
					hash = hash * 59 + this.Feature.GetHashCode();

				if (this.SupportLevel != null)
					hash = hash * 59 + this.SupportLevel.GetHashCode();

				if (this.Details != null)
					hash = hash * 59 + this.Details.GetHashCode();

				return hash;
			}
		}
	}

}
