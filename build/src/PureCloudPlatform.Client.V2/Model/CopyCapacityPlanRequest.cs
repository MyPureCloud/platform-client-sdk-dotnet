using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CopyCapacityPlanRequest
	/// </summary>
	[DataContract]
	public partial class CopyCapacityPlanRequest : IEquatable<CopyCapacityPlanRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CopyCapacityPlanRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CopyCapacityPlanRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CopyCapacityPlanRequest" /> class.
		/// </summary>
		/// <param name="Name">The name of the new capacity plan (required).</param>
		/// <param name="Description">Description of the new capacity plan.</param>
		/// <param name="StartBusinessUnitDate">The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="EndBusinessUnitDate">The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
		/// <param name="Forecast">The selected forecast for this capacity plan. Uses forecast from original capacity plan if not specified.</param>
		public CopyCapacityPlanRequest(string Name = null, string Description = null, String StartBusinessUnitDate = null, String EndBusinessUnitDate = null, ValueWrapperBuShortTermForecastReference Forecast = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.StartBusinessUnitDate = StartBusinessUnitDate;
			this.EndBusinessUnitDate = EndBusinessUnitDate;
			this.Forecast = Forecast;

		}



		/// <summary>
		/// The name of the new capacity plan
		/// </summary>
		/// <value>The name of the new capacity plan</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Description of the new capacity plan
		/// </summary>
		/// <value>Description of the new capacity plan</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The start date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "startBusinessUnitDate", EmitDefaultValue = false)]
		public String StartBusinessUnitDate { get; set; }



		/// <summary>
		/// The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
		/// </summary>
		/// <value>The end date for the capacity plan relative to the business unit time zone in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
		[DataMember(Name = "endBusinessUnitDate", EmitDefaultValue = false)]
		public String EndBusinessUnitDate { get; set; }



		/// <summary>
		/// The selected forecast for this capacity plan. Uses forecast from original capacity plan if not specified
		/// </summary>
		/// <value>The selected forecast for this capacity plan. Uses forecast from original capacity plan if not specified</value>
		[DataMember(Name = "forecast", EmitDefaultValue = false)]
		public ValueWrapperBuShortTermForecastReference Forecast { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CopyCapacityPlanRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  StartBusinessUnitDate: ").Append(StartBusinessUnitDate).Append("\n");
			sb.Append("  EndBusinessUnitDate: ").Append(EndBusinessUnitDate).Append("\n");
			sb.Append("  Forecast: ").Append(Forecast).Append("\n");
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
			return this.Equals(obj as CopyCapacityPlanRequest);
		}

		/// <summary>
		/// Returns true if CopyCapacityPlanRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of CopyCapacityPlanRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CopyCapacityPlanRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.StartBusinessUnitDate == other.StartBusinessUnitDate ||
					this.StartBusinessUnitDate != null &&
					this.StartBusinessUnitDate.Equals(other.StartBusinessUnitDate)
				) &&
				(
					this.EndBusinessUnitDate == other.EndBusinessUnitDate ||
					this.EndBusinessUnitDate != null &&
					this.EndBusinessUnitDate.Equals(other.EndBusinessUnitDate)
				) &&
				(
					this.Forecast == other.Forecast ||
					this.Forecast != null &&
					this.Forecast.Equals(other.Forecast)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.StartBusinessUnitDate != null)
					hash = hash * 59 + this.StartBusinessUnitDate.GetHashCode();

				if (this.EndBusinessUnitDate != null)
					hash = hash * 59 + this.EndBusinessUnitDate.GetHashCode();

				if (this.Forecast != null)
					hash = hash * 59 + this.Forecast.GetHashCode();

				return hash;
			}
		}
	}

}
