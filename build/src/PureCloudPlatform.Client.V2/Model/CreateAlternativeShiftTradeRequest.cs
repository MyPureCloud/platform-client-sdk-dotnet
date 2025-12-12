using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreateAlternativeShiftTradeRequest
	/// </summary>
	[DataContract]
	public partial class CreateAlternativeShiftTradeRequest : IEquatable<CreateAlternativeShiftTradeRequest>
	{
		/// <summary>
		/// The granularity of alternative shifts to be traded
		/// </summary>
		/// <value>The granularity of alternative shifts to be traded</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AlternativeShiftTradeGranularityEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Daily for "Daily"
			/// </summary>
			[EnumMember(Value = "Daily")]
			Daily
		}
		/// <summary>
		/// The granularity of alternative shifts to be traded
		/// </summary>
		/// <value>The granularity of alternative shifts to be traded</value>
		[DataMember(Name = "alternativeShiftTradeGranularity", EmitDefaultValue = false)]
		public AlternativeShiftTradeGranularityEnum? AlternativeShiftTradeGranularity { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateAlternativeShiftTradeRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CreateAlternativeShiftTradeRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateAlternativeShiftTradeRequest" /> class.
		/// </summary>
		/// <param name="JobId">The ID of this alternative shift job (required).</param>
		/// <param name="DropShiftReferenceKeys">A list of offered shift reference keys an agent wants to drop.</param>
		/// <param name="PickupShiftReferenceKeys">A list of offered shift reference keys an agent wants to pick up.</param>
		/// <param name="AlternativeShiftTradeGranularity">The granularity of alternative shifts to be traded (required).</param>
		/// <param name="ExpirationDate">The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration.</param>
		public CreateAlternativeShiftTradeRequest(string JobId = null, List<string> DropShiftReferenceKeys = null, List<string> PickupShiftReferenceKeys = null, AlternativeShiftTradeGranularityEnum? AlternativeShiftTradeGranularity = null, DateTime? ExpirationDate = null)
		{
			this.JobId = JobId;
			this.DropShiftReferenceKeys = DropShiftReferenceKeys;
			this.PickupShiftReferenceKeys = PickupShiftReferenceKeys;
			this.AlternativeShiftTradeGranularity = AlternativeShiftTradeGranularity;
			this.ExpirationDate = ExpirationDate;

		}



		/// <summary>
		/// The ID of this alternative shift job
		/// </summary>
		/// <value>The ID of this alternative shift job</value>
		[DataMember(Name = "jobId", EmitDefaultValue = false)]
		public string JobId { get; set; }



		/// <summary>
		/// A list of offered shift reference keys an agent wants to drop
		/// </summary>
		/// <value>A list of offered shift reference keys an agent wants to drop</value>
		[DataMember(Name = "dropShiftReferenceKeys", EmitDefaultValue = false)]
		public List<string> DropShiftReferenceKeys { get; set; }



		/// <summary>
		/// A list of offered shift reference keys an agent wants to pick up
		/// </summary>
		/// <value>A list of offered shift reference keys an agent wants to pick up</value>
		[DataMember(Name = "pickupShiftReferenceKeys", EmitDefaultValue = false)]
		public List<string> PickupShiftReferenceKeys { get; set; }





		/// <summary>
		/// The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration
		/// </summary>
		/// <value>The date when the trade will expire in ISO-8601 format. The trade cannot be approved after expiration</value>
		[DataMember(Name = "expirationDate", EmitDefaultValue = false)]
		public DateTime? ExpirationDate { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateAlternativeShiftTradeRequest {\n");

			sb.Append("  JobId: ").Append(JobId).Append("\n");
			sb.Append("  DropShiftReferenceKeys: ").Append(DropShiftReferenceKeys).Append("\n");
			sb.Append("  PickupShiftReferenceKeys: ").Append(PickupShiftReferenceKeys).Append("\n");
			sb.Append("  AlternativeShiftTradeGranularity: ").Append(AlternativeShiftTradeGranularity).Append("\n");
			sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
			return this.Equals(obj as CreateAlternativeShiftTradeRequest);
		}

		/// <summary>
		/// Returns true if CreateAlternativeShiftTradeRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of CreateAlternativeShiftTradeRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreateAlternativeShiftTradeRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.JobId == other.JobId ||
					this.JobId != null &&
					this.JobId.Equals(other.JobId)
				) &&
				(
					this.DropShiftReferenceKeys == other.DropShiftReferenceKeys ||
					this.DropShiftReferenceKeys != null &&
					this.DropShiftReferenceKeys.SequenceEqual(other.DropShiftReferenceKeys)
				) &&
				(
					this.PickupShiftReferenceKeys == other.PickupShiftReferenceKeys ||
					this.PickupShiftReferenceKeys != null &&
					this.PickupShiftReferenceKeys.SequenceEqual(other.PickupShiftReferenceKeys)
				) &&
				(
					this.AlternativeShiftTradeGranularity == other.AlternativeShiftTradeGranularity ||
					this.AlternativeShiftTradeGranularity != null &&
					this.AlternativeShiftTradeGranularity.Equals(other.AlternativeShiftTradeGranularity)
				) &&
				(
					this.ExpirationDate == other.ExpirationDate ||
					this.ExpirationDate != null &&
					this.ExpirationDate.Equals(other.ExpirationDate)
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
				if (this.JobId != null)
					hash = hash * 59 + this.JobId.GetHashCode();

				if (this.DropShiftReferenceKeys != null)
					hash = hash * 59 + this.DropShiftReferenceKeys.GetHashCode();

				if (this.PickupShiftReferenceKeys != null)
					hash = hash * 59 + this.PickupShiftReferenceKeys.GetHashCode();

				if (this.AlternativeShiftTradeGranularity != null)
					hash = hash * 59 + this.AlternativeShiftTradeGranularity.GetHashCode();

				if (this.ExpirationDate != null)
					hash = hash * 59 + this.ExpirationDate.GetHashCode();

				return hash;
			}
		}
	}

}
