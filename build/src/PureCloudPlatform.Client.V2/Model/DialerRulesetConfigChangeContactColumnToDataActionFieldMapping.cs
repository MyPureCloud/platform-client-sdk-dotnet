using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DialerRulesetConfigChangeContactColumnToDataActionFieldMapping
	/// </summary>
	[DataContract]
	public partial class DialerRulesetConfigChangeContactColumnToDataActionFieldMapping : IEquatable<DialerRulesetConfigChangeContactColumnToDataActionFieldMapping>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DialerRulesetConfigChangeContactColumnToDataActionFieldMapping" /> class.
		/// </summary>
		/// <param name="ContactColumnName">The name of a contact column whose data will be passed to the data action.</param>
		/// <param name="DataActionField">The name of an output field from the data action that the contact column data will be passed to.</param>
		/// <param name="AdditionalProperties">AdditionalProperties.</param>
		/// <param name="GetAdditionalProperties">GetAdditionalProperties.</param>
		public DialerRulesetConfigChangeContactColumnToDataActionFieldMapping(string ContactColumnName = null, string DataActionField = null, Dictionary<string, Object> AdditionalProperties = null, Dictionary<string, Object> GetAdditionalProperties = null)
		{
			this.ContactColumnName = ContactColumnName;
			this.DataActionField = DataActionField;
			this.AdditionalProperties = AdditionalProperties;
			this.GetAdditionalProperties = GetAdditionalProperties;

		}



		/// <summary>
		/// The name of a contact column whose data will be passed to the data action
		/// </summary>
		/// <value>The name of a contact column whose data will be passed to the data action</value>
		[DataMember(Name = "contactColumnName", EmitDefaultValue = false)]
		public string ContactColumnName { get; set; }



		/// <summary>
		/// The name of an output field from the data action that the contact column data will be passed to
		/// </summary>
		/// <value>The name of an output field from the data action that the contact column data will be passed to</value>
		[DataMember(Name = "dataActionField", EmitDefaultValue = false)]
		public string DataActionField { get; set; }



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
			sb.Append("class DialerRulesetConfigChangeContactColumnToDataActionFieldMapping {\n");

			sb.Append("  ContactColumnName: ").Append(ContactColumnName).Append("\n");
			sb.Append("  DataActionField: ").Append(DataActionField).Append("\n");
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
			return this.Equals(obj as DialerRulesetConfigChangeContactColumnToDataActionFieldMapping);
		}

		/// <summary>
		/// Returns true if DialerRulesetConfigChangeContactColumnToDataActionFieldMapping instances are equal
		/// </summary>
		/// <param name="other">Instance of DialerRulesetConfigChangeContactColumnToDataActionFieldMapping to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DialerRulesetConfigChangeContactColumnToDataActionFieldMapping other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.ContactColumnName == other.ContactColumnName ||
					this.ContactColumnName != null &&
					this.ContactColumnName.Equals(other.ContactColumnName)
				) &&
				(
					this.DataActionField == other.DataActionField ||
					this.DataActionField != null &&
					this.DataActionField.Equals(other.DataActionField)
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
				if (this.ContactColumnName != null)
					hash = hash * 59 + this.ContactColumnName.GetHashCode();

				if (this.DataActionField != null)
					hash = hash * 59 + this.DataActionField.GetHashCode();

				if (this.AdditionalProperties != null)
					hash = hash * 59 + this.AdditionalProperties.GetHashCode();

				if (this.GetAdditionalProperties != null)
					hash = hash * 59 + this.GetAdditionalProperties.GetHashCode();

				return hash;
			}
		}
	}

}
