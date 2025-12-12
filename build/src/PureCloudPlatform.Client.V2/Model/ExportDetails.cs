using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ExportDetails
	/// </summary>
	[DataContract]
	public partial class ExportDetails : IEquatable<ExportDetails>
	{
		/// <summary>
		/// The export type for the flow. Default: 'Yaml'.
		/// </summary>
		/// <value>The export type for the flow. Default: 'Yaml'.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ExportTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Architect for "Architect"
			/// </summary>
			[EnumMember(Value = "Architect")]
			Architect,

			/// <summary>
			/// Enum Yaml for "Yaml"
			/// </summary>
			[EnumMember(Value = "Yaml")]
			Yaml
		}
		/// <summary>
		/// The export type for the flow. Default: 'Yaml'.
		/// </summary>
		/// <value>The export type for the flow. Default: 'Yaml'.</value>
		[DataMember(Name = "exportType", EmitDefaultValue = false)]
		public ExportTypeEnum? ExportType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ExportDetails" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ExportDetails() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ExportDetails" /> class.
		/// </summary>
		/// <param name="Flow">The flow to export. If you do not provide the flow ID, you must provide both the name and type. (required).</param>
		/// <param name="FileName">Name to assign to the file after download. The extension will be automatically appended based on desired export type. Must contain only alphanumeric characters, underscores, or hyphens..</param>
		/// <param name="ExportType">The export type for the flow. Default: &#39;Yaml&#39;..</param>
		public ExportDetails(ArchitectFlowReference Flow = null, string FileName = null, ExportTypeEnum? ExportType = null)
		{
			this.Flow = Flow;
			this.FileName = FileName;
			this.ExportType = ExportType;

		}



		/// <summary>
		/// The flow to export. If you do not provide the flow ID, you must provide both the name and type.
		/// </summary>
		/// <value>The flow to export. If you do not provide the flow ID, you must provide both the name and type.</value>
		[DataMember(Name = "flow", EmitDefaultValue = false)]
		public ArchitectFlowReference Flow { get; set; }



		/// <summary>
		/// Name to assign to the file after download. The extension will be automatically appended based on desired export type. Must contain only alphanumeric characters, underscores, or hyphens.
		/// </summary>
		/// <value>Name to assign to the file after download. The extension will be automatically appended based on desired export type. Must contain only alphanumeric characters, underscores, or hyphens.</value>
		[DataMember(Name = "fileName", EmitDefaultValue = false)]
		public string FileName { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ExportDetails {\n");

			sb.Append("  Flow: ").Append(Flow).Append("\n");
			sb.Append("  FileName: ").Append(FileName).Append("\n");
			sb.Append("  ExportType: ").Append(ExportType).Append("\n");
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
			return this.Equals(obj as ExportDetails);
		}

		/// <summary>
		/// Returns true if ExportDetails instances are equal
		/// </summary>
		/// <param name="other">Instance of ExportDetails to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ExportDetails other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Flow == other.Flow ||
					this.Flow != null &&
					this.Flow.Equals(other.Flow)
				) &&
				(
					this.FileName == other.FileName ||
					this.FileName != null &&
					this.FileName.Equals(other.FileName)
				) &&
				(
					this.ExportType == other.ExportType ||
					this.ExportType != null &&
					this.ExportType.Equals(other.ExportType)
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
				if (this.Flow != null)
					hash = hash * 59 + this.Flow.GetHashCode();

				if (this.FileName != null)
					hash = hash * 59 + this.FileName.GetHashCode();

				if (this.ExportType != null)
					hash = hash * 59 + this.ExportType.GetHashCode();

				return hash;
			}
		}
	}

}
