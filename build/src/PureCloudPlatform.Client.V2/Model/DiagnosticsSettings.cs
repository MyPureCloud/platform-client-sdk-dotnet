using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DiagnosticsSettings
	/// </summary>
	[DataContract]
	public partial class DiagnosticsSettings : IEquatable<DiagnosticsSettings>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DiagnosticsSettings" /> class.
		/// </summary>
		/// <param name="ReportLowMaxCallsPerAgentAlert">Whether to report on low max calls per agent alerts..</param>
		public DiagnosticsSettings(bool? ReportLowMaxCallsPerAgentAlert = null)
		{
			this.ReportLowMaxCallsPerAgentAlert = ReportLowMaxCallsPerAgentAlert;

		}



		/// <summary>
		/// Whether to report on low max calls per agent alerts.
		/// </summary>
		/// <value>Whether to report on low max calls per agent alerts.</value>
		[DataMember(Name = "reportLowMaxCallsPerAgentAlert", EmitDefaultValue = false)]
		public bool? ReportLowMaxCallsPerAgentAlert { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DiagnosticsSettings {\n");

			sb.Append("  ReportLowMaxCallsPerAgentAlert: ").Append(ReportLowMaxCallsPerAgentAlert).Append("\n");
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
			return this.Equals(obj as DiagnosticsSettings);
		}

		/// <summary>
		/// Returns true if DiagnosticsSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of DiagnosticsSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DiagnosticsSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ReportLowMaxCallsPerAgentAlert == other.ReportLowMaxCallsPerAgentAlert ||
					this.ReportLowMaxCallsPerAgentAlert != null &&
					this.ReportLowMaxCallsPerAgentAlert.Equals(other.ReportLowMaxCallsPerAgentAlert)
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
				if (this.ReportLowMaxCallsPerAgentAlert != null)
					hash = hash * 59 + this.ReportLowMaxCallsPerAgentAlert.GetHashCode();

				return hash;
			}
		}
	}

}
