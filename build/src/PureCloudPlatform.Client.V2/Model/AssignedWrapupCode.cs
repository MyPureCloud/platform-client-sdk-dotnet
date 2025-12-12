using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AssignedWrapupCode
	/// </summary>
	[DataContract]
	public partial class AssignedWrapupCode : IEquatable<AssignedWrapupCode>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssignedWrapupCode" /> class.
		/// </summary>
		/// <param name="Code">The user configured wrap up code id..</param>
		/// <param name="Notes">Text entered by the agent to describe the call or disposition..</param>
		/// <param name="Tags">List of tags selected by the agent to describe the call or disposition..</param>
		/// <param name="DurationSeconds">The duration in seconds of the wrap-up segment..</param>
		/// <param name="EndTime">The timestamp when the wrap-up segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public AssignedWrapupCode(string Code = null, string Notes = null, List<string> Tags = null, int? DurationSeconds = null, DateTime? EndTime = null)
		{
			this.Code = Code;
			this.Notes = Notes;
			this.Tags = Tags;
			this.DurationSeconds = DurationSeconds;
			this.EndTime = EndTime;

		}



		/// <summary>
		/// The user configured wrap up code id.
		/// </summary>
		/// <value>The user configured wrap up code id.</value>
		[DataMember(Name = "code", EmitDefaultValue = false)]
		public string Code { get; set; }



		/// <summary>
		/// Text entered by the agent to describe the call or disposition.
		/// </summary>
		/// <value>Text entered by the agent to describe the call or disposition.</value>
		[DataMember(Name = "notes", EmitDefaultValue = false)]
		public string Notes { get; set; }



		/// <summary>
		/// List of tags selected by the agent to describe the call or disposition.
		/// </summary>
		/// <value>List of tags selected by the agent to describe the call or disposition.</value>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public List<string> Tags { get; set; }



		/// <summary>
		/// The duration in seconds of the wrap-up segment.
		/// </summary>
		/// <value>The duration in seconds of the wrap-up segment.</value>
		[DataMember(Name = "durationSeconds", EmitDefaultValue = false)]
		public int? DurationSeconds { get; set; }



		/// <summary>
		/// The timestamp when the wrap-up segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The timestamp when the wrap-up segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "endTime", EmitDefaultValue = false)]
		public DateTime? EndTime { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AssignedWrapupCode {\n");

			sb.Append("  Code: ").Append(Code).Append("\n");
			sb.Append("  Notes: ").Append(Notes).Append("\n");
			sb.Append("  Tags: ").Append(Tags).Append("\n");
			sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
			sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
			return this.Equals(obj as AssignedWrapupCode);
		}

		/// <summary>
		/// Returns true if AssignedWrapupCode instances are equal
		/// </summary>
		/// <param name="other">Instance of AssignedWrapupCode to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AssignedWrapupCode other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Code == other.Code ||
					this.Code != null &&
					this.Code.Equals(other.Code)
				) &&
				(
					this.Notes == other.Notes ||
					this.Notes != null &&
					this.Notes.Equals(other.Notes)
				) &&
				(
					this.Tags == other.Tags ||
					this.Tags != null &&
					this.Tags.SequenceEqual(other.Tags)
				) &&
				(
					this.DurationSeconds == other.DurationSeconds ||
					this.DurationSeconds != null &&
					this.DurationSeconds.Equals(other.DurationSeconds)
				) &&
				(
					this.EndTime == other.EndTime ||
					this.EndTime != null &&
					this.EndTime.Equals(other.EndTime)
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
				if (this.Code != null)
					hash = hash * 59 + this.Code.GetHashCode();

				if (this.Notes != null)
					hash = hash * 59 + this.Notes.GetHashCode();

				if (this.Tags != null)
					hash = hash * 59 + this.Tags.GetHashCode();

				if (this.DurationSeconds != null)
					hash = hash * 59 + this.DurationSeconds.GetHashCode();

				if (this.EndTime != null)
					hash = hash * 59 + this.EndTime.GetHashCode();

				return hash;
			}
		}
	}

}
