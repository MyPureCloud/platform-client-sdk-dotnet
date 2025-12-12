using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkflowTargetSettings
	/// </summary>
	[DataContract]
	public partial class WorkflowTargetSettings : IEquatable<WorkflowTargetSettings>
	{
		/// <summary>
		/// The data format to use when invoking target.
		/// </summary>
		/// <value>The data format to use when invoking target.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DataFormatEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Json for "Json"
			/// </summary>
			[EnumMember(Value = "Json")]
			Json,

			/// <summary>
			/// Enum Toplevelprimitives for "TopLevelPrimitives"
			/// </summary>
			[EnumMember(Value = "TopLevelPrimitives")]
			Toplevelprimitives
		}
		/// <summary>
		/// The data format to use when invoking target.
		/// </summary>
		/// <value>The data format to use when invoking target.</value>
		[DataMember(Name = "dataFormat", EmitDefaultValue = false)]
		public DataFormatEnum? DataFormat { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkflowTargetSettings" /> class.
		/// </summary>
		/// <param name="DataFormat">The data format to use when invoking target..</param>
		public WorkflowTargetSettings(DataFormatEnum? DataFormat = null)
		{
			this.DataFormat = DataFormat;

		}




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkflowTargetSettings {\n");

			sb.Append("  DataFormat: ").Append(DataFormat).Append("\n");
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
			return this.Equals(obj as WorkflowTargetSettings);
		}

		/// <summary>
		/// Returns true if WorkflowTargetSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkflowTargetSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkflowTargetSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DataFormat == other.DataFormat ||
					this.DataFormat != null &&
					this.DataFormat.Equals(other.DataFormat)
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
				if (this.DataFormat != null)
					hash = hash * 59 + this.DataFormat.GetHashCode();

				return hash;
			}
		}
	}

}
