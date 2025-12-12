using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemsAttributeChangeInstant
	/// </summary>
	[DataContract]
	public partial class WorkitemsAttributeChangeInstant : IEquatable<WorkitemsAttributeChangeInstant>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemsAttributeChangeInstant" /> class.
		/// </summary>
		/// <param name="NewValue">New property value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		/// <param name="OldValue">Old property value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
		public WorkitemsAttributeChangeInstant(DateTime? NewValue = null, DateTime? OldValue = null)
		{
			this.NewValue = NewValue;
			this.OldValue = OldValue;

		}



		/// <summary>
		/// New property value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>New property value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "newValue", EmitDefaultValue = false)]
		public DateTime? NewValue { get; set; }



		/// <summary>
		/// Old property value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Old property value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "oldValue", EmitDefaultValue = false)]
		public DateTime? OldValue { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemsAttributeChangeInstant {\n");

			sb.Append("  NewValue: ").Append(NewValue).Append("\n");
			sb.Append("  OldValue: ").Append(OldValue).Append("\n");
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
			return this.Equals(obj as WorkitemsAttributeChangeInstant);
		}

		/// <summary>
		/// Returns true if WorkitemsAttributeChangeInstant instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemsAttributeChangeInstant to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemsAttributeChangeInstant other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.NewValue == other.NewValue ||
					this.NewValue != null &&
					this.NewValue.Equals(other.NewValue)
				) &&
				(
					this.OldValue == other.OldValue ||
					this.OldValue != null &&
					this.OldValue.Equals(other.OldValue)
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
				if (this.NewValue != null)
					hash = hash * 59 + this.NewValue.GetHashCode();

				if (this.OldValue != null)
					hash = hash * 59 + this.OldValue.GetHashCode();

				return hash;
			}
		}
	}

}
