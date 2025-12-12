using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ModelMetaDataResult
	/// </summary>
	[DataContract]
	public partial class ModelMetaDataResult : IEquatable<ModelMetaDataResult>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ModelMetaDataResult" /> class.
		/// </summary>
		/// <param name="SessionInfo">Information about the continuous forecast session.</param>
		/// <param name="PlanningGroups">List of planning groups.</param>
		public ModelMetaDataResult(SessionInfo SessionInfo = null, List<PlanningGroupModel> PlanningGroups = null)
		{
			this.SessionInfo = SessionInfo;
			this.PlanningGroups = PlanningGroups;

		}



		/// <summary>
		/// Information about the continuous forecast session
		/// </summary>
		/// <value>Information about the continuous forecast session</value>
		[DataMember(Name = "sessionInfo", EmitDefaultValue = false)]
		public SessionInfo SessionInfo { get; set; }



		/// <summary>
		/// List of planning groups
		/// </summary>
		/// <value>List of planning groups</value>
		[DataMember(Name = "planningGroups", EmitDefaultValue = false)]
		public List<PlanningGroupModel> PlanningGroups { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ModelMetaDataResult {\n");

			sb.Append("  SessionInfo: ").Append(SessionInfo).Append("\n");
			sb.Append("  PlanningGroups: ").Append(PlanningGroups).Append("\n");
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
			return this.Equals(obj as ModelMetaDataResult);
		}

		/// <summary>
		/// Returns true if ModelMetaDataResult instances are equal
		/// </summary>
		/// <param name="other">Instance of ModelMetaDataResult to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ModelMetaDataResult other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SessionInfo == other.SessionInfo ||
					this.SessionInfo != null &&
					this.SessionInfo.Equals(other.SessionInfo)
				) &&
				(
					this.PlanningGroups == other.PlanningGroups ||
					this.PlanningGroups != null &&
					this.PlanningGroups.SequenceEqual(other.PlanningGroups)
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
				if (this.SessionInfo != null)
					hash = hash * 59 + this.SessionInfo.GetHashCode();

				if (this.PlanningGroups != null)
					hash = hash * 59 + this.PlanningGroups.GetHashCode();

				return hash;
			}
		}
	}

}
