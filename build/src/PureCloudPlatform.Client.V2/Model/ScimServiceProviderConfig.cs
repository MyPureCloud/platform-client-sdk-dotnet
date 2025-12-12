using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Defines a SCIM service provider&#39;s configuration.
	/// </summary>
	[DataContract]
	public partial class ScimServiceProviderConfig : IEquatable<ScimServiceProviderConfig>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ScimServiceProviderConfig" /> class.
		/// </summary>
		public ScimServiceProviderConfig()
		{

		}



		/// <summary>
		/// The list of supported schemas.
		/// </summary>
		/// <value>The list of supported schemas.</value>
		[DataMember(Name = "schemas", EmitDefaultValue = false)]
		public List<string> Schemas { get; private set; }



		/// <summary>
		/// The HTTP-addressable URL that points to the service provider&#39;s documentation.
		/// </summary>
		/// <value>The HTTP-addressable URL that points to the service provider&#39;s documentation.</value>
		[DataMember(Name = "documentationUri", EmitDefaultValue = false)]
		public string DocumentationUri { get; private set; }



		/// <summary>
		/// The \&quot;patch\&quot; configuration options.
		/// </summary>
		/// <value>The \&quot;patch\&quot; configuration options.</value>
		[DataMember(Name = "patch", EmitDefaultValue = false)]
		public ScimServiceProviderConfigSimpleFeature Patch { get; private set; }



		/// <summary>
		/// The \&quot;filter\&quot; configuration options.
		/// </summary>
		/// <value>The \&quot;filter\&quot; configuration options.</value>
		[DataMember(Name = "filter", EmitDefaultValue = false)]
		public ScimServiceProviderConfigFilterFeature Filter { get; private set; }



		/// <summary>
		/// The \&quot;etag\&quot; configuration options.
		/// </summary>
		/// <value>The \&quot;etag\&quot; configuration options.</value>
		[DataMember(Name = "etag", EmitDefaultValue = false)]
		public ScimServiceProviderConfigSimpleFeature Etag { get; private set; }



		/// <summary>
		/// The \&quot;sort\&quot; configuration options.
		/// </summary>
		/// <value>The \&quot;sort\&quot; configuration options.</value>
		[DataMember(Name = "sort", EmitDefaultValue = false)]
		public ScimServiceProviderConfigSimpleFeature Sort { get; private set; }



		/// <summary>
		/// The \&quot;bulk\&quot; configuration options.
		/// </summary>
		/// <value>The \&quot;bulk\&quot; configuration options.</value>
		[DataMember(Name = "bulk", EmitDefaultValue = false)]
		public ScimServiceProviderConfigBulkFeature Bulk { get; private set; }



		/// <summary>
		/// The \&quot;changePassword\&quot; configuration options.
		/// </summary>
		/// <value>The \&quot;changePassword\&quot; configuration options.</value>
		[DataMember(Name = "changePassword", EmitDefaultValue = false)]
		public ScimServiceProviderConfigSimpleFeature ChangePassword { get; private set; }



		/// <summary>
		/// The list of supported authentication schemes.
		/// </summary>
		/// <value>The list of supported authentication schemes.</value>
		[DataMember(Name = "authenticationSchemes", EmitDefaultValue = false)]
		public List<ScimServiceProviderConfigAuthenticationScheme> AuthenticationSchemes { get; private set; }



		/// <summary>
		/// The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.
		/// </summary>
		/// <value>The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.</value>
		[DataMember(Name = "meta", EmitDefaultValue = false)]
		public ScimMetadata Meta { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ScimServiceProviderConfig {\n");

			sb.Append("  Schemas: ").Append(Schemas).Append("\n");
			sb.Append("  DocumentationUri: ").Append(DocumentationUri).Append("\n");
			sb.Append("  Patch: ").Append(Patch).Append("\n");
			sb.Append("  Filter: ").Append(Filter).Append("\n");
			sb.Append("  Etag: ").Append(Etag).Append("\n");
			sb.Append("  Sort: ").Append(Sort).Append("\n");
			sb.Append("  Bulk: ").Append(Bulk).Append("\n");
			sb.Append("  ChangePassword: ").Append(ChangePassword).Append("\n");
			sb.Append("  AuthenticationSchemes: ").Append(AuthenticationSchemes).Append("\n");
			sb.Append("  Meta: ").Append(Meta).Append("\n");
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
			return this.Equals(obj as ScimServiceProviderConfig);
		}

		/// <summary>
		/// Returns true if ScimServiceProviderConfig instances are equal
		/// </summary>
		/// <param name="other">Instance of ScimServiceProviderConfig to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ScimServiceProviderConfig other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Schemas == other.Schemas ||
					this.Schemas != null &&
					this.Schemas.SequenceEqual(other.Schemas)
				) &&
				(
					this.DocumentationUri == other.DocumentationUri ||
					this.DocumentationUri != null &&
					this.DocumentationUri.Equals(other.DocumentationUri)
				) &&
				(
					this.Patch == other.Patch ||
					this.Patch != null &&
					this.Patch.Equals(other.Patch)
				) &&
				(
					this.Filter == other.Filter ||
					this.Filter != null &&
					this.Filter.Equals(other.Filter)
				) &&
				(
					this.Etag == other.Etag ||
					this.Etag != null &&
					this.Etag.Equals(other.Etag)
				) &&
				(
					this.Sort == other.Sort ||
					this.Sort != null &&
					this.Sort.Equals(other.Sort)
				) &&
				(
					this.Bulk == other.Bulk ||
					this.Bulk != null &&
					this.Bulk.Equals(other.Bulk)
				) &&
				(
					this.ChangePassword == other.ChangePassword ||
					this.ChangePassword != null &&
					this.ChangePassword.Equals(other.ChangePassword)
				) &&
				(
					this.AuthenticationSchemes == other.AuthenticationSchemes ||
					this.AuthenticationSchemes != null &&
					this.AuthenticationSchemes.SequenceEqual(other.AuthenticationSchemes)
				) &&
				(
					this.Meta == other.Meta ||
					this.Meta != null &&
					this.Meta.Equals(other.Meta)
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
				if (this.Schemas != null)
					hash = hash * 59 + this.Schemas.GetHashCode();

				if (this.DocumentationUri != null)
					hash = hash * 59 + this.DocumentationUri.GetHashCode();

				if (this.Patch != null)
					hash = hash * 59 + this.Patch.GetHashCode();

				if (this.Filter != null)
					hash = hash * 59 + this.Filter.GetHashCode();

				if (this.Etag != null)
					hash = hash * 59 + this.Etag.GetHashCode();

				if (this.Sort != null)
					hash = hash * 59 + this.Sort.GetHashCode();

				if (this.Bulk != null)
					hash = hash * 59 + this.Bulk.GetHashCode();

				if (this.ChangePassword != null)
					hash = hash * 59 + this.ChangePassword.GetHashCode();

				if (this.AuthenticationSchemes != null)
					hash = hash * 59 + this.AuthenticationSchemes.GetHashCode();

				if (this.Meta != null)
					hash = hash * 59 + this.Meta.GetHashCode();

				return hash;
			}
		}
	}

}
