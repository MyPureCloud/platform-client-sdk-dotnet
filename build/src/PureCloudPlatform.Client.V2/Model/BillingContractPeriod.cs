using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BillingContractPeriod
	/// </summary>
	[DataContract]
	public partial class BillingContractPeriod : IEquatable<BillingContractPeriod>
	{
		/// <summary>
		/// The type of address.
		/// </summary>
		/// <value>The type of address.</value>
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
			/// Enum Open for "Open"
			/// </summary>
			[EnumMember(Value = "Open")]
			Open,

			/// <summary>
			/// Enum Closed for "Closed"
			/// </summary>
			[EnumMember(Value = "Closed")]
			Closed
		}
		/// <summary>
		/// The type of address.
		/// </summary>
		/// <value>The type of address.</value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public StatusEnum? Status { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="BillingContractPeriod" /> class.
		/// </summary>
		/// <param name="DateStart">The date when the Billing Period starts. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="DateEnd">The date when the Billing Period starts. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
		/// <param name="Status">The type of address..</param>
		public BillingContractPeriod(String DateStart = null, String DateEnd = null, StatusEnum? Status = null)
		{
			this.DateStart = DateStart;
			this.DateEnd = DateEnd;
			this.Status = Status;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The date when the Billing Period starts. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The date when the Billing Period starts. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateStart", EmitDefaultValue = false)]
		public String DateStart { get; set; }



		/// <summary>
		/// The date when the Billing Period starts. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The date when the Billing Period starts. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "dateEnd", EmitDefaultValue = false)]
		public String DateEnd { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BillingContractPeriod {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  DateStart: ").Append(DateStart).Append("\n");
			sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
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
			return this.Equals(obj as BillingContractPeriod);
		}

		/// <summary>
		/// Returns true if BillingContractPeriod instances are equal
		/// </summary>
		/// <param name="other">Instance of BillingContractPeriod to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BillingContractPeriod other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.DateStart == other.DateStart ||
					this.DateStart != null &&
					this.DateStart.Equals(other.DateStart)
				) &&
				(
					this.DateEnd == other.DateEnd ||
					this.DateEnd != null &&
					this.DateEnd.Equals(other.DateEnd)
				) &&
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.DateStart != null)
					hash = hash * 59 + this.DateStart.GetHashCode();

				if (this.DateEnd != null)
					hash = hash * 59 + this.DateEnd.GetHashCode();

				if (this.Status != null)
					hash = hash * 59 + this.Status.GetHashCode();

				return hash;
			}
		}
	}

}
