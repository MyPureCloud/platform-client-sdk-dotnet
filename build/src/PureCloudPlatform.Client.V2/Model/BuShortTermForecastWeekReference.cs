using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// BuShortTermForecastWeekReference
	/// </summary>
	[DataContract]
	public partial class BuShortTermForecastWeekReference : IEquatable<BuShortTermForecastWeekReference>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="BuShortTermForecastWeekReference" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected BuShortTermForecastWeekReference() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="BuShortTermForecastWeekReference" /> class.
		/// </summary>
		/// <param name="Id">The ID of the forecast (required).</param>
		/// <param name="WeekDate">The weekDate of the short term forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="WeekNumber">The week number to be used from the selected forecast. First week starts with number 1 (required).</param>
		public BuShortTermForecastWeekReference(string Id = null, String WeekDate = null, int? WeekNumber = null)
		{
			this.Id = Id;
			this.WeekDate = WeekDate;
			this.WeekNumber = WeekNumber;

		}



		/// <summary>
		/// The ID of the forecast
		/// </summary>
		/// <value>The ID of the forecast</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The weekDate of the short term forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The weekDate of the short term forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "weekDate", EmitDefaultValue = false)]
		public String WeekDate { get; set; }



		/// <summary>
		/// The description of the short term forecast
		/// </summary>
		/// <value>The description of the short term forecast</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; private set; }



		/// <summary>
		/// The week number to be used from the selected forecast. First week starts with number 1
		/// </summary>
		/// <value>The week number to be used from the selected forecast. First week starts with number 1</value>
		[DataMember(Name = "weekNumber", EmitDefaultValue = false)]
		public int? WeekNumber { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class BuShortTermForecastWeekReference {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  WeekNumber: ").Append(WeekNumber).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as BuShortTermForecastWeekReference);
		}

		/// <summary>
		/// Returns true if BuShortTermForecastWeekReference instances are equal
		/// </summary>
		/// <param name="other">Instance of BuShortTermForecastWeekReference to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BuShortTermForecastWeekReference other)
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
					this.WeekDate == other.WeekDate ||
					this.WeekDate != null &&
					this.WeekDate.Equals(other.WeekDate)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.WeekNumber == other.WeekNumber ||
					this.WeekNumber != null &&
					this.WeekNumber.Equals(other.WeekNumber)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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

				if (this.WeekDate != null)
					hash = hash * 59 + this.WeekDate.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.WeekNumber != null)
					hash = hash * 59 + this.WeekNumber.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
