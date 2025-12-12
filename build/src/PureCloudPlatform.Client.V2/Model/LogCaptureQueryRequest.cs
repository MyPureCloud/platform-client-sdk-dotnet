using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LogCaptureQueryRequest
	/// </summary>
	[DataContract]
	public partial class LogCaptureQueryRequest : IEquatable<LogCaptureQueryRequest>
	{
		/// <summary>
		/// Order of results. Default order is ASC.
		/// </summary>
		/// <value>Order of results. Default order is ASC.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SortOrderEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Asc for "ASC"
			/// </summary>
			[EnumMember(Value = "ASC")]
			Asc,

			/// <summary>
			/// Enum Desc for "DESC"
			/// </summary>
			[EnumMember(Value = "DESC")]
			Desc
		}
		/// <summary>
		/// Order of results. Default order is ASC.
		/// </summary>
		/// <value>Order of results. Default order is ASC.</value>
		[DataMember(Name = "sortOrder", EmitDefaultValue = false)]
		public SortOrderEnum? SortOrder { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="LogCaptureQueryRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected LogCaptureQueryRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="LogCaptureQueryRequest" /> class.
		/// </summary>
		/// <param name="Interval">Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
		/// <param name="UserId">Id of the user to query. (required).</param>
		/// <param name="SortOrder">Order of results. Default order is ASC..</param>
		public LogCaptureQueryRequest(string Interval = null, string UserId = null, SortOrderEnum? SortOrder = null)
		{
			this.Interval = Interval;
			this.UserId = UserId;
			this.SortOrder = SortOrder;

		}



		/// <summary>
		/// Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
		/// </summary>
		/// <value>Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }



		/// <summary>
		/// Id of the user to query.
		/// </summary>
		/// <value>Id of the user to query.</value>
		[DataMember(Name = "userId", EmitDefaultValue = false)]
		public string UserId { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LogCaptureQueryRequest {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
			return this.Equals(obj as LogCaptureQueryRequest);
		}

		/// <summary>
		/// Returns true if LogCaptureQueryRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of LogCaptureQueryRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LogCaptureQueryRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Interval == other.Interval ||
					this.Interval != null &&
					this.Interval.Equals(other.Interval)
				) &&
				(
					this.UserId == other.UserId ||
					this.UserId != null &&
					this.UserId.Equals(other.UserId)
				) &&
				(
					this.SortOrder == other.SortOrder ||
					this.SortOrder != null &&
					this.SortOrder.Equals(other.SortOrder)
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
				if (this.Interval != null)
					hash = hash * 59 + this.Interval.GetHashCode();

				if (this.UserId != null)
					hash = hash * 59 + this.UserId.GetHashCode();

				if (this.SortOrder != null)
					hash = hash * 59 + this.SortOrder.GetHashCode();

				return hash;
			}
		}
	}

}
