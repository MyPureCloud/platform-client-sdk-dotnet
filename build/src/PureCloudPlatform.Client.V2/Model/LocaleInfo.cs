using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LocaleInfo
	/// </summary>
	[DataContract]
	public partial class LocaleInfo : IEquatable<LocaleInfo>
	{
		/// <summary>
		/// Status of health computation for this flow version.
		/// </summary>
		/// <value>Status of health computation for this flow version.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Inprogress for "InProgress"
			/// </summary>
			[EnumMember(Value = "InProgress")]
			Inprogress,

			/// <summary>
			/// Enum Completed for "Completed"
			/// </summary>
			[EnumMember(Value = "Completed")]
			Completed,

			/// <summary>
			/// Enum Error for "Error"
			/// </summary>
			[EnumMember(Value = "Error")]
			Error
		}
		/// <summary>
		/// Status of health computation for this flow version.
		/// </summary>
		/// <value>Status of health computation for this flow version.</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="LocaleInfo" /> class.
		/// </summary>
		/// <param name="Status">Status of health computation for this flow version..</param>
		/// <param name="ErrorInfo">Error details for the flow version, if any..</param>
		/// <param name="FlowVersionInfo">Info about given flow version..</param>
		public LocaleInfo(StatusEnum? Status = null, FlowHealthErrorInfo ErrorInfo = null, LocaleFlowVersionInfo FlowVersionInfo = null)
		{
			this.Status = Status;
			this.ErrorInfo = ErrorInfo;
			this.FlowVersionInfo = FlowVersionInfo;

		}





		/// <summary>
		/// Error details for the flow version, if any.
		/// </summary>
		/// <value>Error details for the flow version, if any.</value>
		[DataMember(Name = "errorInfo", EmitDefaultValue = false)]
		public FlowHealthErrorInfo ErrorInfo { get; set; }



		/// <summary>
		/// Info about given flow version.
		/// </summary>
		/// <value>Info about given flow version.</value>
		[DataMember(Name = "flowVersionInfo", EmitDefaultValue = false)]
		public LocaleFlowVersionInfo FlowVersionInfo { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LocaleInfo {\n");

			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
			sb.Append("  FlowVersionInfo: ").Append(FlowVersionInfo).Append("\n");
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
			return this.Equals(obj as LocaleInfo);
		}

		/// <summary>
		/// Returns true if LocaleInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of LocaleInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LocaleInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
				) &&
				(
					this.ErrorInfo == other.ErrorInfo ||
					this.ErrorInfo != null &&
					this.ErrorInfo.Equals(other.ErrorInfo)
				) &&
				(
					this.FlowVersionInfo == other.FlowVersionInfo ||
					this.FlowVersionInfo != null &&
					this.FlowVersionInfo.Equals(other.FlowVersionInfo)
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
				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				if (this.ErrorInfo != null)
					hash = hash * 59 + this.ErrorInfo.GetHashCode();

				if (this.FlowVersionInfo != null)
					hash = hash * 59 + this.FlowVersionInfo.GetHashCode();

				return hash;
			}
		}
	}

}
