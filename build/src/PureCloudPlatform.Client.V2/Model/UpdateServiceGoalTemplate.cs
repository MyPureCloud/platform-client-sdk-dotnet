using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateServiceGoalTemplate
	/// </summary>
	[DataContract]
	public partial class UpdateServiceGoalTemplate : IEquatable<UpdateServiceGoalTemplate>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateServiceGoalTemplate" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UpdateServiceGoalTemplate() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateServiceGoalTemplate" /> class.
		/// </summary>
		/// <param name="Name">The name of the service goal template..</param>
		/// <param name="ServiceLevel">Service level targets for this service goal template.</param>
		/// <param name="AverageSpeedOfAnswer">Average speed of answer targets for this service goal template.</param>
		/// <param name="AbandonRate">Abandon rate targets for this service goal template.</param>
		/// <param name="Metadata">Version metadata for the service goal template (required).</param>
		/// <param name="ImpactOverride">Settings controlling max percent increase and decrease of service goals for this service goal template.</param>
		public UpdateServiceGoalTemplate(string Name = null, BuServiceLevel ServiceLevel = null, BuAverageSpeedOfAnswer AverageSpeedOfAnswer = null, BuAbandonRate AbandonRate = null, WfmVersionedEntityMetadata Metadata = null, ServiceGoalTemplateImpactOverride ImpactOverride = null)
		{
			this.Name = Name;
			this.ServiceLevel = ServiceLevel;
			this.AverageSpeedOfAnswer = AverageSpeedOfAnswer;
			this.AbandonRate = AbandonRate;
			this.Metadata = Metadata;
			this.ImpactOverride = ImpactOverride;

		}



		/// <summary>
		/// The name of the service goal template.
		/// </summary>
		/// <value>The name of the service goal template.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Service level targets for this service goal template
		/// </summary>
		/// <value>Service level targets for this service goal template</value>
		[DataMember(Name = "serviceLevel", EmitDefaultValue = false)]
		public BuServiceLevel ServiceLevel { get; set; }



		/// <summary>
		/// Average speed of answer targets for this service goal template
		/// </summary>
		/// <value>Average speed of answer targets for this service goal template</value>
		[DataMember(Name = "averageSpeedOfAnswer", EmitDefaultValue = false)]
		public BuAverageSpeedOfAnswer AverageSpeedOfAnswer { get; set; }



		/// <summary>
		/// Abandon rate targets for this service goal template
		/// </summary>
		/// <value>Abandon rate targets for this service goal template</value>
		[DataMember(Name = "abandonRate", EmitDefaultValue = false)]
		public BuAbandonRate AbandonRate { get; set; }



		/// <summary>
		/// Version metadata for the service goal template
		/// </summary>
		/// <value>Version metadata for the service goal template</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public WfmVersionedEntityMetadata Metadata { get; set; }



		/// <summary>
		/// Settings controlling max percent increase and decrease of service goals for this service goal template
		/// </summary>
		/// <value>Settings controlling max percent increase and decrease of service goals for this service goal template</value>
		[DataMember(Name = "impactOverride", EmitDefaultValue = false)]
		public ServiceGoalTemplateImpactOverride ImpactOverride { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateServiceGoalTemplate {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
			sb.Append("  AverageSpeedOfAnswer: ").Append(AverageSpeedOfAnswer).Append("\n");
			sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
			return this.Equals(obj as UpdateServiceGoalTemplate);
		}

		/// <summary>
		/// Returns true if UpdateServiceGoalTemplate instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateServiceGoalTemplate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateServiceGoalTemplate other)
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
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.Equals(other.Metadata)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.ServiceLevel != null)
					hash = hash * 59 + this.ServiceLevel.GetHashCode();

				if (this.AverageSpeedOfAnswer != null)
					hash = hash * 59 + this.AverageSpeedOfAnswer.GetHashCode();

				if (this.AbandonRate != null)
					hash = hash * 59 + this.AbandonRate.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				if (this.ImpactOverride != null)
					hash = hash * 59 + this.ImpactOverride.GetHashCode();

				return hash;
			}
		}
	}

}
