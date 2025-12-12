using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerContactlistConfigChangeEmailColumn
	/// </summary>
	[DataContract]
	public partial class DialerContactlistConfigChangeEmailColumn : IEquatable<DialerContactlistConfigChangeEmailColumn>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerContactlistConfigChangeEmailColumn" /> class.
		/// </summary>
		/// <param name="ColumnName">The name of the email address column.</param>
		/// <param name="Type">The type of the email address column, for example, &#39;work&#39; or &#39;home&#39;.</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DialerContactlistConfigChangeEmailColumn(string ColumnName = null, string Type = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.ColumnName = ColumnName;
			this.Type = Type;
			this.AdditionalProperties = AdditionalProperties;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}



		/// <summary>
		/// The name of the email address column
		/// </summary>
		/// <value>The name of the email address column</value>
		[DataMember(Name = "columnName", EmitDefaultValue = false)]
		public string ColumnName { get; set; }



		/// <summary>
		/// The type of the email address column, for example, &#39;work&#39; or &#39;home&#39;
		/// </summary>
		/// <value>The type of the email address column, for example, &#39;work&#39; or &#39;home&#39;</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }



		/// <summary>
		/// Gets or Sets AdditionalProperties
		/// </summary>
		[DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> AdditionalProperties { get; set; }



		/// <summary>
		/// Gets or Sets GetAdditionalProperties
		/// </summary>
		[DataMember(Name = "getAdditionalProperties", EmitDefaultValue = false)]
		public Dictionary<string, Object> GetAdditionalProperties { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DialerContactlistConfigChangeEmailColumn {\n");

			sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
			sb.Append("  GetAdditionalProperties: ").Append(GetAdditionalProperties).Append("\n");
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
			return this.Equals(obj as DialerContactlistConfigChangeEmailColumn);
		}

		/// <summary>
		/// Returns true if DialerContactlistConfigChangeEmailColumn instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerContactlistConfigChangeEmailColumn to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerContactlistConfigChangeEmailColumn other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ColumnName == other.ColumnName ||
					this.ColumnName != null &&
					this.ColumnName.Equals(other.ColumnName)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.AdditionalProperties == other.AdditionalProperties ||
					this.AdditionalProperties != null &&
					this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
				) &&
				(
					this.GetAdditionalProperties == other.GetAdditionalProperties ||
					this.GetAdditionalProperties != null &&
					this.GetAdditionalProperties.SequenceEqual(other.GetAdditionalProperties)
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
				if (this.ColumnName != null)
					hash = hash * 59 + this.ColumnName.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
