using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TransfersFullTimeEquivalent
	/// </summary>
	[DataContract]
	public partial class TransfersFullTimeEquivalent : IEquatable<TransfersFullTimeEquivalent>
	{
		/// <summary>
		/// The duration of the transfer full time equivalent from one staffing group to another
		/// </summary>
		/// <value>The duration of the transfer full time equivalent from one staffing group to another</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum TransferTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Permanent for "Permanent"
			/// </summary>
			[EnumMember(Value = "Permanent")]
			Permanent,

			/// <summary>
			/// Enum Temporary for "Temporary"
			/// </summary>
			[EnumMember(Value = "Temporary")]
			Temporary
		}
		/// <summary>
		/// The duration of the transfer full time equivalent from one staffing group to another
		/// </summary>
		/// <value>The duration of the transfer full time equivalent from one staffing group to another</value>
		[DataMember(Name = "transferType", EmitDefaultValue = false)]
		public TransferTypeEnum? TransferType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="TransfersFullTimeEquivalent" /> class.
		/// </summary>
		/// <param name="DestinationStaffingGroupId">The target staffing group that will receive the full time equivalent when agents are transferred from one staffing group to another.</param>
		/// <param name="TransferType">The duration of the transfer full time equivalent from one staffing group to another.</param>
		public TransfersFullTimeEquivalent(string DestinationStaffingGroupId = null, TransferTypeEnum? TransferType = null)
		{
			this.DestinationStaffingGroupId = DestinationStaffingGroupId;
			this.TransferType = TransferType;

		}



		/// <summary>
		/// The target staffing group that will receive the full time equivalent when agents are transferred from one staffing group to another
		/// </summary>
		/// <value>The target staffing group that will receive the full time equivalent when agents are transferred from one staffing group to another</value>
		[DataMember(Name = "destinationStaffingGroupId", EmitDefaultValue = false)]
		public string DestinationStaffingGroupId { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TransfersFullTimeEquivalent {\n");

			sb.Append("  DestinationStaffingGroupId: ").Append(DestinationStaffingGroupId).Append("\n");
			sb.Append("  TransferType: ").Append(TransferType).Append("\n");
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
			return this.Equals(obj as TransfersFullTimeEquivalent);
		}

		/// <summary>
		/// Returns true if TransfersFullTimeEquivalent instances are equal
		/// </summary>
		/// <param name="other">Instance of TransfersFullTimeEquivalent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TransfersFullTimeEquivalent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DestinationStaffingGroupId == other.DestinationStaffingGroupId ||
					this.DestinationStaffingGroupId != null &&
					this.DestinationStaffingGroupId.Equals(other.DestinationStaffingGroupId)
				) &&
				(
					this.TransferType == other.TransferType ||
					this.TransferType != null &&
					this.TransferType.Equals(other.TransferType)
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
				if (this.DestinationStaffingGroupId != null)
					hash = hash * 59 + this.DestinationStaffingGroupId.GetHashCode();

				if (this.TransferType != null)
					hash = hash * 59 + this.TransferType.GetHashCode();

				return hash;
			}
		}
	}

}
