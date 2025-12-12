using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorkitemsAttributeChangeBoolean
	/// </summary>
	[DataContract]
	public partial class WorkitemsAttributeChangeBoolean : IEquatable<WorkitemsAttributeChangeBoolean>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WorkitemsAttributeChangeBoolean" /> class.
		/// </summary>
		/// <param name="NewValue">New property value.</param>
		/// <param name="OldValue">Old property value.</param>
		public WorkitemsAttributeChangeBoolean(bool? NewValue = null, bool? OldValue = null)
		{
			this.NewValue = NewValue;
			this.OldValue = OldValue;

		}



		/// <summary>
		/// New property value
		/// </summary>
		/// <value>New property value</value>
		[DataMember(Name = "newValue", EmitDefaultValue = false)]
		public bool? NewValue { get; set; }



		/// <summary>
		/// Old property value
		/// </summary>
		/// <value>Old property value</value>
		[DataMember(Name = "oldValue", EmitDefaultValue = false)]
		public bool? OldValue { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorkitemsAttributeChangeBoolean {\n");

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
			return this.Equals(obj as WorkitemsAttributeChangeBoolean);
		}

		/// <summary>
		/// Returns true if WorkitemsAttributeChangeBoolean instances are equal
		/// </summary>
		/// <param name="other">Instance of WorkitemsAttributeChangeBoolean to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorkitemsAttributeChangeBoolean other)
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
