using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DataActionConditionSettings
	/// </summary>
	[DataContract]
	public partial class DataActionConditionSettings : IEquatable<DataActionConditionSettings>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DataActionConditionSettings" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DataActionConditionSettings() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DataActionConditionSettings" /> class.
		/// </summary>
		/// <param name="DataActionId">The Data Action Id to use for this condition. (required).</param>
		/// <param name="ContactIdField">The input field from the data action that the contactId will be passed into..</param>
		/// <param name="DataNotFoundResolution">The result of this condition if the data action returns a result indicating there was no data. (required).</param>
		/// <param name="Predicates">A list of predicates defining the comparisons to use for this condition..</param>
		/// <param name="ContactColumnToDataActionFieldMappings">A list of mappings defining which contact data fields will be passed to which data action input fields..</param>
		public DataActionConditionSettings(string DataActionId = null, string ContactIdField = null, bool? DataNotFoundResolution = null, List<DigitalDataActionConditionPredicate> Predicates = null, List<DataActionContactColumnFieldMapping> ContactColumnToDataActionFieldMappings = null)
		{
			this.DataActionId = DataActionId;
			this.ContactIdField = ContactIdField;
			this.DataNotFoundResolution = DataNotFoundResolution;
			this.Predicates = Predicates;
			this.ContactColumnToDataActionFieldMappings = ContactColumnToDataActionFieldMappings;

		}



		/// <summary>
		/// The Data Action Id to use for this condition.
		/// </summary>
		/// <value>The Data Action Id to use for this condition.</value>
		[DataMember(Name = "dataActionId", EmitDefaultValue = false)]
		public string DataActionId { get; set; }



		/// <summary>
		/// The input field from the data action that the contactId will be passed into.
		/// </summary>
		/// <value>The input field from the data action that the contactId will be passed into.</value>
		[DataMember(Name = "contactIdField", EmitDefaultValue = false)]
		public string ContactIdField { get; set; }



		/// <summary>
		/// The result of this condition if the data action returns a result indicating there was no data.
		/// </summary>
		/// <value>The result of this condition if the data action returns a result indicating there was no data.</value>
		[DataMember(Name = "dataNotFoundResolution", EmitDefaultValue = false)]
		public bool? DataNotFoundResolution { get; set; }



		/// <summary>
		/// A list of predicates defining the comparisons to use for this condition.
		/// </summary>
		/// <value>A list of predicates defining the comparisons to use for this condition.</value>
		[DataMember(Name = "predicates", EmitDefaultValue = false)]
		public List<DigitalDataActionConditionPredicate> Predicates { get; set; }



		/// <summary>
		/// A list of mappings defining which contact data fields will be passed to which data action input fields.
		/// </summary>
		/// <value>A list of mappings defining which contact data fields will be passed to which data action input fields.</value>
		[DataMember(Name = "contactColumnToDataActionFieldMappings", EmitDefaultValue = false)]
		public List<DataActionContactColumnFieldMapping> ContactColumnToDataActionFieldMappings { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DataActionConditionSettings {\n");

			sb.Append("  DataActionId: ").Append(DataActionId).Append("\n");
			sb.Append("  ContactIdField: ").Append(ContactIdField).Append("\n");
			sb.Append("  DataNotFoundResolution: ").Append(DataNotFoundResolution).Append("\n");
			sb.Append("  Predicates: ").Append(Predicates).Append("\n");
			sb.Append("  ContactColumnToDataActionFieldMappings: ").Append(ContactColumnToDataActionFieldMappings).Append("\n");
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
			return this.Equals(obj as DataActionConditionSettings);
		}

		/// <summary>
		/// Returns true if DataActionConditionSettings instances are equal
		/// </summary>
		/// <param name="other">Instance of DataActionConditionSettings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DataActionConditionSettings other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DataActionId == other.DataActionId ||
					this.DataActionId != null &&
					this.DataActionId.Equals(other.DataActionId)
				) &&
				(
					this.ContactIdField == other.ContactIdField ||
					this.ContactIdField != null &&
					this.ContactIdField.Equals(other.ContactIdField)
				) &&
				(
					this.DataNotFoundResolution == other.DataNotFoundResolution ||
					this.DataNotFoundResolution != null &&
					this.DataNotFoundResolution.Equals(other.DataNotFoundResolution)
				) &&
				(
					this.Predicates == other.Predicates ||
					this.Predicates != null &&
					this.Predicates.SequenceEqual(other.Predicates)
				) &&
				(
					this.ContactColumnToDataActionFieldMappings == other.ContactColumnToDataActionFieldMappings ||
					this.ContactColumnToDataActionFieldMappings != null &&
					this.ContactColumnToDataActionFieldMappings.SequenceEqual(other.ContactColumnToDataActionFieldMappings)
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
				if (this.DataActionId != null)
					hash = hash * 59 + this.DataActionId.GetHashCode();

				if (this.ContactIdField != null)
					hash = hash * 59 + this.ContactIdField.GetHashCode();

				if (this.DataNotFoundResolution != null)
					hash = hash * 59 + this.DataNotFoundResolution.GetHashCode();

				if (this.Predicates != null)
					hash = hash * 59 + this.Predicates.GetHashCode();

				if (this.ContactColumnToDataActionFieldMappings != null)
					hash = hash * 59 + this.ContactColumnToDataActionFieldMappings.GetHashCode();

				return hash;
			}
		}
	}

}
