using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SessionMetricData
	/// </summary>
	[DataContract]
	public partial class SessionMetricData : IEquatable<SessionMetricData>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SessionMetricData" /> class.
		/// </summary>
		/// <param name="Model">Model to be used for internal evaluation purposes.</param>
		/// <param name="Computed">Forecasted data for the requested session.</param>
		/// <param name="Historical">Historical data for the requested session.</param>
		/// <param name="ModelMetaData">Contains forecast meta data.</param>
		public SessionMetricData(ModelData Model = null, ComputedData Computed = null, HistoricalData Historical = null, ModelMetaData ModelMetaData = null)
		{
			this.Model = Model;
			this.Computed = Computed;
			this.Historical = Historical;
			this.ModelMetaData = ModelMetaData;

		}



		/// <summary>
		/// Model to be used for internal evaluation purposes
		/// </summary>
		/// <value>Model to be used for internal evaluation purposes</value>
		[DataMember(Name = "model", EmitDefaultValue = false)]
		public ModelData Model { get; set; }



		/// <summary>
		/// Forecasted data for the requested session
		/// </summary>
		/// <value>Forecasted data for the requested session</value>
		[DataMember(Name = "computed", EmitDefaultValue = false)]
		public ComputedData Computed { get; set; }



		/// <summary>
		/// Historical data for the requested session
		/// </summary>
		/// <value>Historical data for the requested session</value>
		[DataMember(Name = "historical", EmitDefaultValue = false)]
		public HistoricalData Historical { get; set; }



		/// <summary>
		/// Contains forecast meta data
		/// </summary>
		/// <value>Contains forecast meta data</value>
		[DataMember(Name = "modelMetaData", EmitDefaultValue = false)]
		public ModelMetaData ModelMetaData { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SessionMetricData {\n");

			sb.Append("  Model: ").Append(Model).Append("\n");
			sb.Append("  Computed: ").Append(Computed).Append("\n");
			sb.Append("  Historical: ").Append(Historical).Append("\n");
			sb.Append("  ModelMetaData: ").Append(ModelMetaData).Append("\n");
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
			return this.Equals(obj as SessionMetricData);
		}

		/// <summary>
		/// Returns true if SessionMetricData instances are equal
		/// </summary>
		/// <param name="other">Instance of SessionMetricData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SessionMetricData other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Model == other.Model ||
					this.Model != null &&
					this.Model.Equals(other.Model)
				) &&
				(
					this.Computed == other.Computed ||
					this.Computed != null &&
					this.Computed.Equals(other.Computed)
				) &&
				(
					this.Historical == other.Historical ||
					this.Historical != null &&
					this.Historical.Equals(other.Historical)
				) &&
				(
					this.ModelMetaData == other.ModelMetaData ||
					this.ModelMetaData != null &&
					this.ModelMetaData.Equals(other.ModelMetaData)
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
				if (this.Model != null)
					hash = hash * 59 + this.Model.GetHashCode();

				if (this.Computed != null)
					hash = hash * 59 + this.Computed.GetHashCode();

				if (this.Historical != null)
					hash = hash * 59 + this.Historical.GetHashCode();

				if (this.ModelMetaData != null)
					hash = hash * 59 + this.ModelMetaData.GetHashCode();

				return hash;
			}
		}
	}

}
