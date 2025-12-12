using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Defines the SCIM metadata.
	/// </summary>
	[DataContract]
	public partial class ScimMetadata : IEquatable<ScimMetadata>
	{
		/// <summary>
		/// The type of SCIM resource.
		/// </summary>
		/// <value>The type of SCIM resource.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ResourceTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum User for "User"
			/// </summary>
			[EnumMember(Value = "User")]
			User,

			/// <summary>
			/// Enum Group for "Group"
			/// </summary>
			[EnumMember(Value = "Group")]
			Group,

			/// <summary>
			/// Enum Serviceproviderconfig for "ServiceProviderConfig"
			/// </summary>
			[EnumMember(Value = "ServiceProviderConfig")]
			Serviceproviderconfig,

			/// <summary>
			/// Enum Resourcetype for "ResourceType"
			/// </summary>
			[EnumMember(Value = "ResourceType")]
			Resourcetype,

			/// <summary>
			/// Enum Schema for "Schema"
			/// </summary>
			[EnumMember(Value = "Schema")]
			Schema
		}
		/// <summary>
		/// The type of SCIM resource.
		/// </summary>
		/// <value>The type of SCIM resource.</value>
		[DataMember(Name = "resourceType", EmitDefaultValue = false)]
		public ResourceTypeEnum? ResourceType { get; private set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ScimMetadata" /> class.
		/// </summary>
		public ScimMetadata()
		{

		}





		/// <summary>
		/// The last time that the resource was modified. Date time is represented as an \&quot;ISO-8601 string\&quot;, for example, yyyy-MM-ddTHH:mm:ss.SSSZ. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.
		/// </summary>
		/// <value>The last time that the resource was modified. Date time is represented as an \&quot;ISO-8601 string\&quot;, for example, yyyy-MM-ddTHH:mm:ss.SSSZ. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.</value>
		[DataMember(Name = "lastModified", EmitDefaultValue = false)]
		public DateTime? LastModified { get; private set; }



		/// <summary>
		/// The URI of the resource.
		/// </summary>
		/// <value>The URI of the resource.</value>
		[DataMember(Name = "location", EmitDefaultValue = false)]
		public string Location { get; private set; }



		/// <summary>
		/// The version of the resource. Matches the ETag HTTP response header. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.
		/// </summary>
		/// <value>The version of the resource. Matches the ETag HTTP response header. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public string Version { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ScimMetadata {\n");

			sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
			sb.Append("  LastModified: ").Append(LastModified).Append("\n");
			sb.Append("  Location: ").Append(Location).Append("\n");
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
			return this.Equals(obj as ScimMetadata);
		}

		/// <summary>
		/// Returns true if ScimMetadata instances are equal
		/// </summary>
		/// <param name="other">Instance of ScimMetadata to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ScimMetadata other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ResourceType == other.ResourceType ||
					this.ResourceType != null &&
					this.ResourceType.Equals(other.ResourceType)
				) &&
				(
					this.LastModified == other.LastModified ||
					this.LastModified != null &&
					this.LastModified.Equals(other.LastModified)
				) &&
				(
					this.Location == other.Location ||
					this.Location != null &&
					this.Location.Equals(other.Location)
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
				if (this.ResourceType != null)
					hash = hash * 59 + this.ResourceType.GetHashCode();

				if (this.LastModified != null)
					hash = hash * 59 + this.LastModified.GetHashCode();

				if (this.Location != null)
					hash = hash * 59 + this.Location.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				return hash;
			}
		}
	}

}
