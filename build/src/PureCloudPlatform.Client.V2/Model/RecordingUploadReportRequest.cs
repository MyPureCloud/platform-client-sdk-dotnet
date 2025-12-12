using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RecordingUploadReportRequest
	/// </summary>
	[DataContract]
	public partial class RecordingUploadReportRequest : IEquatable<RecordingUploadReportRequest>
	{
		/// <summary>
		/// Report will include uploads with this status
		/// </summary>
		/// <value>Report will include uploads with this status</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum UploadStatusEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Pending for "Pending"
			/// </summary>
			[EnumMember(Value = "Pending")]
			Pending,

			/// <summary>
			/// Enum Success for "Success"
			/// </summary>
			[EnumMember(Value = "Success")]
			Success,

			/// <summary>
			/// Enum Failure for "Failure"
			/// </summary>
			[EnumMember(Value = "Failure")]
			Failure,

			/// <summary>
			/// Enum Waitforconversation for "WaitForConversation"
			/// </summary>
			[EnumMember(Value = "WaitForConversation")]
			Waitforconversation
		}
		/// <summary>
		/// Report will include uploads with this status
		/// </summary>
		/// <value>Report will include uploads with this status</value>
		[DataMember(Name = "uploadStatus", EmitDefaultValue = false)]
		public UploadStatusEnum? UploadStatus { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingUploadReportRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected RecordingUploadReportRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingUploadReportRequest" /> class.
		/// </summary>
		/// <param name="DateSince">Report will include uploads since this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="UploadStatus">Report will include uploads with this status.</param>
		public RecordingUploadReportRequest(DateTime? DateSince = null, UploadStatusEnum? UploadStatus = null)
		{
			this.DateSince = DateSince;
			this.UploadStatus = UploadStatus;

		}



		/// <summary>
		/// Report will include uploads since this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Report will include uploads since this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateSince", EmitDefaultValue = false)]
		public DateTime? DateSince { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecordingUploadReportRequest {\n");

			sb.Append("  DateSince: ").Append(DateSince).Append("\n");
			sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
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
			return this.Equals(obj as RecordingUploadReportRequest);
		}

		/// <summary>
		/// Returns true if RecordingUploadReportRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of RecordingUploadReportRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecordingUploadReportRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DateSince == other.DateSince ||
					this.DateSince != null &&
					this.DateSince.Equals(other.DateSince)
				) &&
				(
					this.UploadStatus == other.UploadStatus ||
					this.UploadStatus != null &&
					this.UploadStatus.Equals(other.UploadStatus)
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
				if (this.DateSince != null)
					hash = hash * 59 + this.DateSince.GetHashCode();

				if (this.UploadStatus != null)
					hash = hash * 59 + this.UploadStatus.GetHashCode();

				return hash;
			}
		}
	}

}
