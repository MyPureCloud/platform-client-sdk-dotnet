using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SetTimeOffIntegrationStatusRequest
	/// </summary>
	[DataContract]
	public partial class SetTimeOffIntegrationStatusRequest : IEquatable<SetTimeOffIntegrationStatusRequest>
	{
		/// <summary>
		/// The integration status value for the time off request
		/// </summary>
		/// <value>The integration status value for the time off request</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum IntegrationStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Processing for "Processing"
			/// </summary>
			[EnumMember(Value = "Processing")]
			Processing,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error,

			/// <summary>
			/// Enum Automaticallycomplete for "AutomaticallyComplete"
			/// </summary>
			[EnumMember(Value = "AutomaticallyComplete")]
			Automaticallycomplete,

			/// <summary>
			/// Enum Manuallycomplete for "ManuallyComplete"
			/// </summary>
			[EnumMember(Value = "ManuallyComplete")]
			Manuallycomplete
		}
		/// <summary>
		/// The integration status value for the time off request
		/// </summary>
		/// <value>The integration status value for the time off request</value>
		[DataMember(Name = "integrationStatus", EmitDefaultValue = false)]
		public IntegrationStatusEnum? IntegrationStatus { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="SetTimeOffIntegrationStatusRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SetTimeOffIntegrationStatusRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SetTimeOffIntegrationStatusRequest" /> class.
		/// </summary>
		/// <param name="IntegrationStatus">The integration status value for the time off request (required).</param>
		public SetTimeOffIntegrationStatusRequest(IntegrationStatusEnum? IntegrationStatus = null)
		{
			this.IntegrationStatus = IntegrationStatus;

		}




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SetTimeOffIntegrationStatusRequest {\n");

			sb.Append("  IntegrationStatus: ").Append(IntegrationStatus).Append("\n");
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
			return this.Equals(obj as SetTimeOffIntegrationStatusRequest);
		}

		/// <summary>
		/// Returns true if SetTimeOffIntegrationStatusRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of SetTimeOffIntegrationStatusRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SetTimeOffIntegrationStatusRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.IntegrationStatus == other.IntegrationStatus ||
					this.IntegrationStatus != null &&
					this.IntegrationStatus.Equals(other.IntegrationStatus)
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
				if (this.IntegrationStatus != null)
					hash = hash * 59 + this.IntegrationStatus.GetHashCode();

				return hash;
			}
		}
	}

}
