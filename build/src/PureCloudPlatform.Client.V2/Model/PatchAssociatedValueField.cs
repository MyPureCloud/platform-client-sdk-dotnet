using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PatchAssociatedValueField
	/// </summary>
	[DataContract]
	public partial class PatchAssociatedValueField : IEquatable<PatchAssociatedValueField>
	{
		/// <summary>
		/// The data type of the value field.
		/// </summary>
		/// <value>The data type of the value field.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DataTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Number for "Number"
			/// </summary>
			[EnumMember(Value = "Number")]
			Number,

			/// <summary>
			/// Enum Integer for "Integer"
			/// </summary>
			[EnumMember(Value = "Integer")]
			Integer
		}
		/// <summary>
		/// The data type of the value field.
		/// </summary>
		/// <value>The data type of the value field.</value>
		[DataMember(Name = "dataType", EmitDefaultValue = false)]
		public DataTypeEnum? DataType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="PatchAssociatedValueField" /> class.
		/// </summary>
		/// <param name="DataType">The data type of the value field..</param>
		/// <param name="Name">The field name for extracting value from event..</param>
		public PatchAssociatedValueField(DataTypeEnum? DataType = null, string Name = null)
		{
			this.DataType = DataType;
			this.Name = Name;

		}





		/// <summary>
		/// The field name for extracting value from event.
		/// </summary>
		/// <value>The field name for extracting value from event.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PatchAssociatedValueField {\n");

			sb.Append("  DataType: ").Append(DataType).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
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
			return this.Equals(obj as PatchAssociatedValueField);
		}

		/// <summary>
		/// Returns true if PatchAssociatedValueField instances are equal
		/// </summary>
		/// <param name="other">Instance of PatchAssociatedValueField to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PatchAssociatedValueField other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DataType == other.DataType ||
					this.DataType != null &&
					this.DataType.Equals(other.DataType)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
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
				if (this.DataType != null)
					hash = hash * 59 + this.DataType.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				return hash;
			}
		}
	}

}
