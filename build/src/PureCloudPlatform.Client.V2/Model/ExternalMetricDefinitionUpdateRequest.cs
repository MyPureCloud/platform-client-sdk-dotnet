using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ExternalMetricDefinitionUpdateRequest
	/// </summary>
	[DataContract]
	public partial class ExternalMetricDefinitionUpdateRequest : IEquatable<ExternalMetricDefinitionUpdateRequest>
	{
		/// <summary>
		/// The default objective type of the External Metric Definition
		/// </summary>
		/// <value>The default objective type of the External Metric Definition</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum DefaultObjectiveTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Higherisbetter for "HigherIsBetter"
			/// </summary>
			[EnumMember(Value = "HigherIsBetter")]
			Higherisbetter,

			/// <summary>
			/// Enum Lowerisbetter for "LowerIsBetter"
			/// </summary>
			[EnumMember(Value = "LowerIsBetter")]
			Lowerisbetter,

			/// <summary>
			/// Enum Targetarea for "TargetArea"
			/// </summary>
			[EnumMember(Value = "TargetArea")]
			Targetarea
		}
		/// <summary>
		/// The default objective type of the External Metric Definition
		/// </summary>
		/// <value>The default objective type of the External Metric Definition</value>
		[DataMember(Name = "defaultObjectiveType", EmitDefaultValue = false)]
		public DefaultObjectiveTypeEnum? DefaultObjectiveType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ExternalMetricDefinitionUpdateRequest" /> class.
		/// </summary>
		/// <param name="Name">The name of the External Metric Definition.</param>
		/// <param name="Precision">The decimal precision of the External Metric Definition. Must be at least 0 and at most 5.</param>
		/// <param name="DefaultObjectiveType">The default objective type of the External Metric Definition.</param>
		/// <param name="Enabled">True if the External Metric Definition is enabled.</param>
		public ExternalMetricDefinitionUpdateRequest(string Name = null, int? Precision = null, DefaultObjectiveTypeEnum? DefaultObjectiveType = null, bool? Enabled = null)
		{
			this.Name = Name;
			this.Precision = Precision;
			this.DefaultObjectiveType = DefaultObjectiveType;
			this.Enabled = Enabled;

		}



		/// <summary>
		/// The name of the External Metric Definition
		/// </summary>
		/// <value>The name of the External Metric Definition</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The decimal precision of the External Metric Definition. Must be at least 0 and at most 5
		/// </summary>
		/// <value>The decimal precision of the External Metric Definition. Must be at least 0 and at most 5</value>
		[DataMember(Name = "precision", EmitDefaultValue = false)]
		public int? Precision { get; set; }





		/// <summary>
		/// True if the External Metric Definition is enabled
		/// </summary>
		/// <value>True if the External Metric Definition is enabled</value>
		[DataMember(Name = "enabled", EmitDefaultValue = false)]
		public bool? Enabled { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ExternalMetricDefinitionUpdateRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Precision: ").Append(Precision).Append("\n");
			sb.Append("  DefaultObjectiveType: ").Append(DefaultObjectiveType).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
			return this.Equals(obj as ExternalMetricDefinitionUpdateRequest);
		}

		/// <summary>
		/// Returns true if ExternalMetricDefinitionUpdateRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ExternalMetricDefinitionUpdateRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ExternalMetricDefinitionUpdateRequest other)
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
					this.Precision == other.Precision ||
					this.Precision != null &&
					this.Precision.Equals(other.Precision)
				) &&
				(
					this.DefaultObjectiveType == other.DefaultObjectiveType ||
					this.DefaultObjectiveType != null &&
					this.DefaultObjectiveType.Equals(other.DefaultObjectiveType)
				) &&
				(
					this.Enabled == other.Enabled ||
					this.Enabled != null &&
					this.Enabled.Equals(other.Enabled)
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

				if (this.Precision != null)
					hash = hash * 59 + this.Precision.GetHashCode();

				if (this.DefaultObjectiveType != null)
					hash = hash * 59 + this.DefaultObjectiveType.GetHashCode();

				if (this.Enabled != null)
					hash = hash * 59 + this.Enabled.GetHashCode();

				return hash;
			}
		}
	}

}
