using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SyncStatusRequest
	/// </summary>
	[DataContract]
	public partial class SyncStatusRequest : IEquatable<SyncStatusRequest>
	{
		/// <summary>
		/// New status for an existing sync operation
		/// </summary>
		/// <value>New status for an existing sync operation</value>
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
			/// Enum Created for "Created"
			/// </summary>
			[EnumMember(Value = "Created")]
			Created,

			/// <summary>
			/// Enum Validationinprogress for "ValidationInProgress"
			/// </summary>
			[EnumMember(Value = "ValidationInProgress")]
			Validationinprogress,

			/// <summary>
			/// Enum Validationcompleted for "ValidationCompleted"
			/// </summary>
			[EnumMember(Value = "ValidationCompleted")]
			Validationcompleted,

			/// <summary>
			/// Enum Validationfailed for "ValidationFailed"
			/// </summary>
			[EnumMember(Value = "ValidationFailed")]
			Validationfailed,

			/// <summary>
			/// Enum Started for "Started"
			/// </summary>
			[EnumMember(Value = "Started")]
			Started,

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
			/// Enum Partialcompleted for "PartialCompleted"
			/// </summary>
			[EnumMember(Value = "PartialCompleted")]
			Partialcompleted,

			/// <summary>
			/// Enum Failed for "Failed"
			/// </summary>
			[EnumMember(Value = "Failed")]
			Failed,

			/// <summary>
			/// Enum Abortrequested for "AbortRequested"
			/// </summary>
			[EnumMember(Value = "AbortRequested")]
			Abortrequested,

			/// <summary>
			/// Enum Aborted for "Aborted"
			/// </summary>
			[EnumMember(Value = "Aborted")]
			Aborted
		}
		/// <summary>
		/// New status for an existing sync operation
		/// </summary>
		/// <value>New status for an existing sync operation</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="SyncStatusRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SyncStatusRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SyncStatusRequest" /> class.
		/// </summary>
		/// <param name="Status">New status for an existing sync operation (required).</param>
		public SyncStatusRequest(StatusEnum? Status = null)
		{
			this.Status = Status;

		}




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SyncStatusRequest {\n");

			sb.Append("  Status: ").Append(Status).Append("\n");
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
			return this.Equals(obj as SyncStatusRequest);
		}

		/// <summary>
		/// Returns true if SyncStatusRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of SyncStatusRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SyncStatusRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Status == other.Status ||
					this.Status != null &&
					this.Status.Equals(other.Status)
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

				return hash;
			}
		}
	}

}
