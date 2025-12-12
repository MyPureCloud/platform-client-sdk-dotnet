using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DnclistImportStatusImportStatus
	/// </summary>
	[DataContract]
	public partial class DnclistImportStatusImportStatus : IEquatable<DnclistImportStatusImportStatus>
	{
		/// <summary>
		/// current status of the import
		/// </summary>
		/// <value>current status of the import</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ImportStateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum InProgress for "IN_PROGRESS"
			/// </summary>
			[EnumMember(Value = "IN_PROGRESS")]
			InProgress,

			/// <summary>
			/// Enum Failed for "FAILED"
			/// </summary>
			[EnumMember(Value = "FAILED")]
			Failed
		}
		/// <summary>
		/// current status of the import
		/// </summary>
		/// <value>current status of the import</value>
		[DataMember(Name = "importState", EmitDefaultValue = false)]
		public ImportStateEnum? ImportState { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DnclistImportStatusImportStatus" /> class.
		/// </summary>
		/// <param name="ImportState">current status of the import.</param>
		/// <param name="TotalRecords">total number of records to be imported.</param>
		/// <param name="CompletedRecords">number of records finished importing.</param>
		/// <param name="PercentageComplete">percentage of records finished importing.</param>
		/// <param name="FailureReason">if the import has failed, the reason for the failure.</param>
		/// <param name="TargetContactListIds">The ids for target contact lists.</param>
		/// <param name="ListNamePrefix">The prefix used for target contact list names.</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DnclistImportStatusImportStatus(ImportStateEnum? ImportState = null, long? TotalRecords = null, long? CompletedRecords = null, long? PercentageComplete = null, string FailureReason = null, List<string> TargetContactListIds = null, string ListNamePrefix = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.ImportState = ImportState;
			this.TotalRecords = TotalRecords;
			this.CompletedRecords = CompletedRecords;
			this.PercentageComplete = PercentageComplete;
			this.FailureReason = FailureReason;
			this.TargetContactListIds = TargetContactListIds;
			this.ListNamePrefix = ListNamePrefix;
			this.AdditionalProperties = AdditionalProperties;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}





		/// <summary>
		/// total number of records to be imported
		/// </summary>
		/// <value>total number of records to be imported</value>
		[DataMember(Name = "totalRecords", EmitDefaultValue = false)]
		public long? TotalRecords { get; set; }



		/// <summary>
		/// number of records finished importing
		/// </summary>
		/// <value>number of records finished importing</value>
		[DataMember(Name = "completedRecords", EmitDefaultValue = false)]
		public long? CompletedRecords { get; set; }



		/// <summary>
		/// percentage of records finished importing
		/// </summary>
		/// <value>percentage of records finished importing</value>
		[DataMember(Name = "percentageComplete", EmitDefaultValue = false)]
		public long? PercentageComplete { get; set; }



		/// <summary>
		/// if the import has failed, the reason for the failure
		/// </summary>
		/// <value>if the import has failed, the reason for the failure</value>
		[DataMember(Name = "failureReason", EmitDefaultValue = false)]
		public string FailureReason { get; set; }



		/// <summary>
		/// The ids for target contact lists
		/// </summary>
		/// <value>The ids for target contact lists</value>
		[DataMember(Name = "targetContactListIds", EmitDefaultValue = false)]
		public List<string> TargetContactListIds { get; set; }



		/// <summary>
		/// The prefix used for target contact list names
		/// </summary>
		/// <value>The prefix used for target contact list names</value>
		[DataMember(Name = "listNamePrefix", EmitDefaultValue = false)]
		public string ListNamePrefix { get; set; }



		/// <summary>
		/// Gets or Sets AdditionalProperties
		/// </summary>
		[DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> AdditionalProperties { get; set; }



		/// <summary>
		/// Gets or Sets GetAdditionalProperties
		/// </summary>
		[DataMember(Name = "getAdditionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> GetAdditionalProperties { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DnclistImportStatusImportStatus {\n");

			sb.Append("  ImportState: ").Append(ImportState).Append("\n");
			sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
			sb.Append("  CompletedRecords: ").Append(CompletedRecords).Append("\n");
			sb.Append("  PercentageComplete: ").Append(PercentageComplete).Append("\n");
			sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
			sb.Append("  TargetContactListIds: ").Append(TargetContactListIds).Append("\n");
			sb.Append("  ListNamePrefix: ").Append(ListNamePrefix).Append("\n");
			sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
			sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
			return this.Equals(obj as DnclistImportStatusImportStatus);
		}

		/// <summary>
		/// Returns true if DnclistImportStatusImportStatus instances are equal
		/// </summary>
		/// <param name="other">Instance of DnclistImportStatusImportStatus to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DnclistImportStatusImportStatus other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ImportState == other.ImportState ||
					this.ImportState != null &&
					this.ImportState.Equals(other.ImportState)
				) &&
				(
					this.TotalRecords == other.TotalRecords ||
					this.TotalRecords != null &&
					this.TotalRecords.Equals(other.TotalRecords)
				) &&
				(
					this.CompletedRecords == other.CompletedRecords ||
					this.CompletedRecords != null &&
					this.CompletedRecords.Equals(other.CompletedRecords)
				) &&
				(
					this.PercentageComplete == other.PercentageComplete ||
					this.PercentageComplete != null &&
					this.PercentageComplete.Equals(other.PercentageComplete)
				) &&
				(
					this.FailureReason == other.FailureReason ||
					this.FailureReason != null &&
					this.FailureReason.Equals(other.FailureReason)
				) &&
				(
					this.TargetContactListIds == other.TargetContactListIds ||
					this.TargetContactListIds != null &&
					this.TargetContactListIds.SequenceEqual(other.TargetContactListIds)
				) &&
				(
					this.ListNamePrefix == other.ListNamePrefix ||
					this.ListNamePrefix != null &&
					this.ListNamePrefix.Equals(other.ListNamePrefix)
				) &&
				(
					this.AdditionalProperties == other.AdditionalProperties ||
					this.AdditionalProperties != null &&
					this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
				) &&
				(
					this.GetAdditionalProperties == other.GetAdditionalProperties ||
					this.GetAdditionalProperties != null &&
					this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
				if (this.ImportState != null)
					hash = hash * 59 + this.ImportState.GetHashCode();

				if (this.TotalRecords != null)
					hash = hash * 59 + this.TotalRecords.GetHashCode();

				if (this.CompletedRecords != null)
					hash = hash * 59 + this.CompletedRecords.GetHashCode();

				if (this.PercentageComplete != null)
					hash = hash * 59 + this.PercentageComplete.GetHashCode();

				if (this.FailureReason != null)
					hash = hash * 59 + this.FailureReason.GetHashCode();

				if (this.TargetContactListIds != null)
					hash = hash * 59 + this.TargetContactListIds.GetHashCode();

				if (this.ListNamePrefix != null)
					hash = hash * 59 + this.ListNamePrefix.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
