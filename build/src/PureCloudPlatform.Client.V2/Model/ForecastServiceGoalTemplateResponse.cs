using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ForecastServiceGoalTemplateResponse
	/// </summary>
	[DataContract]
	public partial class ForecastServiceGoalTemplateResponse : IEquatable<ForecastServiceGoalTemplateResponse>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ForecastServiceGoalTemplateResponse" /> class.
		/// </summary>
		/// <param name="ServiceLevel">The service level goal for this forecast.</param>
		/// <param name="AverageSpeedOfAnswer">The average speed of answer goal for this forecast.</param>
		/// <param name="AbandonRate">The abandon rate goal for this forecast.</param>
		/// <param name="ImpactOverride">The service goal impact overrides for this forecast.</param>
		public ForecastServiceGoalTemplateResponse(ForecastServiceLevelResponse ServiceLevel = null, ForecastAverageSpeedOfAnswerResponse AverageSpeedOfAnswer = null, ForecastAbandonRateResponse AbandonRate = null, ForecastServiceGoalTemplateImpactOverrideResponse ImpactOverride = null)
		{
			this.ServiceLevel = ServiceLevel;
			this.AverageSpeedOfAnswer = AverageSpeedOfAnswer;
			this.AbandonRate = AbandonRate;
			this.ImpactOverride = ImpactOverride;

		}



		/// <summary>
		/// The service level goal for this forecast
		/// </summary>
		/// <value>The service level goal for this forecast</value>
		[DataMember(Name = "serviceLevel", EmitDefaultValue = false)]
		public ForecastServiceLevelResponse ServiceLevel { get; set; }



		/// <summary>
		/// The average speed of answer goal for this forecast
		/// </summary>
		/// <value>The average speed of answer goal for this forecast</value>
		[DataMember(Name = "averageSpeedOfAnswer", EmitDefaultValue = false)]
		public ForecastAverageSpeedOfAnswerResponse AverageSpeedOfAnswer { get; set; }



		/// <summary>
		/// The abandon rate goal for this forecast
		/// </summary>
		/// <value>The abandon rate goal for this forecast</value>
		[DataMember(Name = "abandonRate", EmitDefaultValue = false)]
		public ForecastAbandonRateResponse AbandonRate { get; set; }



		/// <summary>
		/// The service goal impact overrides for this forecast
		/// </summary>
		/// <value>The service goal impact overrides for this forecast</value>
		[DataMember(Name = "impactOverride", EmitDefaultValue = false)]
		public ForecastServiceGoalTemplateImpactOverrideResponse ImpactOverride { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ForecastServiceGoalTemplateResponse {\n");

			sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
			sb.Append("  AverageSpeedOfAnswer: ").Append(AverageSpeedOfAnswer).Append("\n");
			sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
			sb.Append("  ImpactOverride: ").Append(ImpactOverride).Append("\n");
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
			return this.Equals(obj as ForecastServiceGoalTemplateResponse);
		}

		/// <summary>
		/// Returns true if ForecastServiceGoalTemplateResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of ForecastServiceGoalTemplateResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ForecastServiceGoalTemplateResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ServiceLevel == other.ServiceLevel ||
					this.ServiceLevel != null &&
					this.ServiceLevel.Equals(other.ServiceLevel)
				) &&
				(
					this.AverageSpeedOfAnswer == other.AverageSpeedOfAnswer ||
					this.AverageSpeedOfAnswer != null &&
					this.AverageSpeedOfAnswer.Equals(other.AverageSpeedOfAnswer)
				) &&
				(
					this.AbandonRate == other.AbandonRate ||
					this.AbandonRate != null &&
					this.AbandonRate.Equals(other.AbandonRate)
				) &&
				(
					this.ImpactOverride == other.ImpactOverride ||
					this.ImpactOverride != null &&
					this.ImpactOverride.Equals(other.ImpactOverride)
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
				if (this.ServiceLevel != null)
					hash = hash * 59 + this.ServiceLevel.GetHashCode();

				if (this.AverageSpeedOfAnswer != null)
					hash = hash * 59 + this.AverageSpeedOfAnswer.GetHashCode();

				if (this.AbandonRate != null)
					hash = hash * 59 + this.AbandonRate.GetHashCode();

				if (this.ImpactOverride != null)
					hash = hash * 59 + this.ImpactOverride.GetHashCode();

				return hash;
			}
		}
	}

}
