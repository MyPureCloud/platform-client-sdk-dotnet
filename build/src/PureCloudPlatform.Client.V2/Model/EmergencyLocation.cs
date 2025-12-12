using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EmergencyLocation
	/// </summary>
	[DataContract]
	public partial class EmergencyLocation : IEquatable<EmergencyLocation>
	{
		/// <summary>
		/// source
		/// </summary>
		/// <value>source</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SourceEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Admin for "Admin"
			/// </summary>
			[EnumMember(Value = "Admin")]
			Admin,

			/// <summary>
			/// Enum User for "User"
			/// </summary>
			[EnumMember(Value = "User")]
			User
		}
		/// <summary>
		/// source
		/// </summary>
		/// <value>source</value>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public SourceEnum? Source { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="EmergencyLocation" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected EmergencyLocation() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="EmergencyLocation" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Address">Emergency address (required).</param>
		/// <param name="Did">Phone number in E164 format (required).</param>
		/// <param name="Source">source (required).</param>
		public EmergencyLocation(string Name = null, LocationAddress Address = null, string Did = null, SourceEnum? Source = null)
		{
			this.Name = Name;
			this.Address = Address;
			this.Did = Did;
			this.Source = Source;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Emergency address
		/// </summary>
		/// <value>Emergency address</value>
		[DataMember(Name = "address", EmitDefaultValue = false)]
		public LocationAddress Address { get; set; }



		/// <summary>
		/// Phone number in E164 format
		/// </summary>
		/// <value>Phone number in E164 format</value>
		[DataMember(Name = "did", EmitDefaultValue = false)]
		public string Did { get; set; }





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
			sb.Append("class EmergencyLocation {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Address: ").Append(Address).Append("\n");
			sb.Append("  Did: ").Append(Did).Append("\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
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
			return this.Equals(obj as EmergencyLocation);
		}

		/// <summary>
		/// Returns true if EmergencyLocation instances are equal
		/// </summary>
		/// <param name="other">Instance of EmergencyLocation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EmergencyLocation other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Address == other.Address ||
					this.Address != null &&
					this.Address.Equals(other.Address)
				) &&
				(
					this.Did == other.Did ||
					this.Did != null &&
					this.Did.Equals(other.Did)
				) &&
				(
					this.Source == other.Source ||
					this.Source != null &&
					this.Source.Equals(other.Source)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Address != null)
					hash = hash * 59 + this.Address.GetHashCode();

				if (this.Did != null)
					hash = hash * 59 + this.Did.GetHashCode();

				if (this.Source != null)
					hash = hash * 59 + this.Source.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
