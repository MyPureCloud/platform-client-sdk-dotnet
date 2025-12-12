using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkPlanPatternRequest
	/// </summary>
	[DataContract]
	public partial class WorkPlanPatternRequest : IEquatable<WorkPlanPatternRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="WorkPlanPatternRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected WorkPlanPatternRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkPlanPatternRequest" /> class.
		/// </summary>
		/// <param name="WorkPlanIds">List of work plan IDs in order of rotation on a weekly basis. Values in the list cannot be null or empty (required).</param>
		public WorkPlanPatternRequest(List<string> WorkPlanIds = null)
		{
			this.WorkPlanIds = WorkPlanIds;

		}



		/// <summary>
		/// List of work plan IDs in order of rotation on a weekly basis. Values in the list cannot be null or empty
		/// </summary>
		/// <value>List of work plan IDs in order of rotation on a weekly basis. Values in the list cannot be null or empty</value>
		[DataMember(Name = "workPlanIds", EmitDefaultValue = false)]
		public List<string> WorkPlanIds { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkPlanPatternRequest {\n");

			sb.Append("  WorkPlanIds: ").Append(WorkPlanIds).Append("\n");
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
			return this.Equals(obj as WorkPlanPatternRequest);
		}

		/// <summary>
		/// Returns true if WorkPlanPatternRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkPlanPatternRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkPlanPatternRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.WorkPlanIds == other.WorkPlanIds ||
					this.WorkPlanIds != null &&
					this.WorkPlanIds.SequenceEqual(other.WorkPlanIds)
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
				if (this.WorkPlanIds != null)
					hash = hash * 59 + this.WorkPlanIds.GetHashCode();

				return hash;
			}
		}
	}

}
