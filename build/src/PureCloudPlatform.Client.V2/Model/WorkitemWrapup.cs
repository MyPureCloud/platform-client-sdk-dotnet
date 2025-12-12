using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemWrapup
	/// </summary>
	[DataContract]
	public partial class WorkitemWrapup : IEquatable<WorkitemWrapup>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemWrapup" /> class.
		/// </summary>
		/// <param name="Workitem">Workitem that the wrapup code has been added to..</param>
		/// <param name="WrapupCode">The wrapup code used in the workitem..</param>
		/// <param name="ModifiedBy">The user who added the wrapup code to the workitem..</param>
		/// <param name="User">The user for whom wrapup code was added. This may be the same as modifiedBy..</param>
		/// <param name="DateModified">The modified date of the Workitem when the wrapup code was added. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public WorkitemWrapup(WorkitemReference Workitem = null, WrapupIdReference WrapupCode = null, UserReference ModifiedBy = null, UserReference User = null, DateTime? DateModified = null)
		{
			this.Workitem = Workitem;
			this.WrapupCode = WrapupCode;
			this.ModifiedBy = ModifiedBy;
			this.User = User;
			this.DateModified = DateModified;

		}



		/// <summary>
		/// Workitem that the wrapup code has been added to.
		/// </summary>
		/// <value>Workitem that the wrapup code has been added to.</value>
		[DataMember(Name = "workitem", EmitDefaultValue = false)]
		public WorkitemReference Workitem { get; set; }



		/// <summary>
		/// The wrapup code used in the workitem.
		/// </summary>
		/// <value>The wrapup code used in the workitem.</value>
		[DataMember(Name = "wrapupCode", EmitDefaultValue = false)]
		public WrapupIdReference WrapupCode { get; set; }



		/// <summary>
		/// The user who added the wrapup code to the workitem.
		/// </summary>
		/// <value>The user who added the wrapup code to the workitem.</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public UserReference ModifiedBy { get; set; }



		/// <summary>
		/// The user for whom wrapup code was added. This may be the same as modifiedBy.
		/// </summary>
		/// <value>The user for whom wrapup code was added. This may be the same as modifiedBy.</value>
		[DataMember(Name = "user", EmitDefaultValue = false)]
		public UserReference User { get; set; }



		/// <summary>
		/// The modified date of the Workitem when the wrapup code was added. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The modified date of the Workitem when the wrapup code was added. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemWrapup {\n");

			sb.Append("  Workitem: ").Append(Workitem).Append("\n");
			sb.Append("  WrapupCode: ").Append(WrapupCode).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  User: ").Append(User).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
			return this.Equals(obj as WorkitemWrapup);
		}

		/// <summary>
		/// Returns true if WorkitemWrapup instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemWrapup to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemWrapup other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Workitem == other.Workitem ||
					this.Workitem != null &&
					this.Workitem.Equals(other.Workitem)
				) &&
				(
					this.WrapupCode == other.WrapupCode ||
					this.WrapupCode != null &&
					this.WrapupCode.Equals(other.WrapupCode)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.User == other.User ||
					this.User != null &&
					this.User.Equals(other.User)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
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
				if (this.Workitem != null)
					hash = hash * 59 + this.Workitem.GetHashCode();

				if (this.WrapupCode != null)
					hash = hash * 59 + this.WrapupCode.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.User != null)
					hash = hash * 59 + this.User.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				return hash;
			}
		}
	}

}
