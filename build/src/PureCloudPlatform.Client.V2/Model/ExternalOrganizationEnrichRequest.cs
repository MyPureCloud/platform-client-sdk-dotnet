using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ExternalOrganizationEnrichRequest
	/// </summary>
	[DataContract]
	public partial class ExternalOrganizationEnrichRequest : IEquatable<ExternalOrganizationEnrichRequest>
	{
		/// <summary>
		/// The action that should be taken based on any External Organization found by `matchingIdentifiers`.
		/// </summary>
		/// <value>The action that should be taken based on any External Organization found by `matchingIdentifiers`.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum ActionEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Upsert for "Upsert"
			/// </summary>
			[EnumMember(Value = "Upsert")]
			Upsert,

			/// <summary>
			/// Enum Update for "Update"
			/// </summary>
			[EnumMember(Value = "Update")]
			Update,

			/// <summary>
			/// Enum Insert for "Insert"
			/// </summary>
			[EnumMember(Value = "Insert")]
			Insert
		}
		/// <summary>
		/// The action that should be taken based on any External Organization found by `matchingIdentifiers`.
		/// </summary>
		/// <value>The action that should be taken based on any External Organization found by `matchingIdentifiers`.</value>
		[DataMember(Name = "action", EmitDefaultValue = false)]
		public ActionEnum? Action { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="ExternalOrganizationEnrichRequest" /> class.
		/// </summary>
		/// <param name="Id">A user-specified tracker string, only useful in the Bulk-Enrich API. If one Bulk-Enrich operation in a request fails, the requested operation will be repeated in the Bulk API response, including this id field, allowing associating request and response operations..</param>
		/// <param name="Division">The division to which this entity belongs..</param>
		/// <param name="MatchingIdentifiers">An ordered list of one or more Identifiers which might each be claimed by an External Organization. &#x60;action&#x60; describes what to do with any possibly matching External Organization. Identifier lookups will occur in the order specified here..</param>
		/// <param name="Action">The action that should be taken based on any External Organization found by &#x60;matchingIdentifiers&#x60;..</param>
		/// <param name="ExternalOrganization">Data to be added, either as an update to an existing External Organization or the body of a new External Organization. Omitting a field in this contract means that it will be treated as null in the &#x60;fieldRules&#x60; logic..</param>
		/// <param name="FieldRules">Logic describing how to combine data from the submitted request with data found in the database..</param>
		public ExternalOrganizationEnrichRequest(string Id = null, WritableStarrableDivision Division = null, List<ExternalOrganizationIdentifier> MatchingIdentifiers = null, ActionEnum? Action = null, ExternalOrganization ExternalOrganization = null, EnrichFieldRules FieldRules = null)
		{
			this.Id = Id;
			this.Division = Division;
			this.MatchingIdentifiers = MatchingIdentifiers;
			this.Action = Action;
			this.ExternalOrganization = ExternalOrganization;
			this.FieldRules = FieldRules;

		}



		/// <summary>
		/// A user-specified tracker string, only useful in the Bulk-Enrich API. If one Bulk-Enrich operation in a request fails, the requested operation will be repeated in the Bulk API response, including this id field, allowing associating request and response operations.
		/// </summary>
		/// <value>A user-specified tracker string, only useful in the Bulk-Enrich API. If one Bulk-Enrich operation in a request fails, the requested operation will be repeated in the Bulk API response, including this id field, allowing associating request and response operations.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// The division to which this entity belongs.
		/// </summary>
		/// <value>The division to which this entity belongs.</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public WritableStarrableDivision Division { get; set; }



		/// <summary>
		/// An ordered list of one or more Identifiers which might each be claimed by an External Organization. &#x60;action&#x60; describes what to do with any possibly matching External Organization. Identifier lookups will occur in the order specified here.
		/// </summary>
		/// <value>An ordered list of one or more Identifiers which might each be claimed by an External Organization. &#x60;action&#x60; describes what to do with any possibly matching External Organization. Identifier lookups will occur in the order specified here.</value>
		[DataMember(Name = "matchingIdentifiers", EmitDefaultValue = false)]
		public List<ExternalOrganizationIdentifier> MatchingIdentifiers { get; set; }





		/// <summary>
		/// Data to be added, either as an update to an existing External Organization or the body of a new External Organization. Omitting a field in this contract means that it will be treated as null in the &#x60;fieldRules&#x60; logic.
		/// </summary>
		/// <value>Data to be added, either as an update to an existing External Organization or the body of a new External Organization. Omitting a field in this contract means that it will be treated as null in the &#x60;fieldRules&#x60; logic.</value>
		[DataMember(Name = "externalOrganization", EmitDefaultValue = false)]
		public ExternalOrganization ExternalOrganization { get; set; }



		/// <summary>
		/// Logic describing how to combine data from the submitted request with data found in the database.
		/// </summary>
		/// <value>Logic describing how to combine data from the submitted request with data found in the database.</value>
		[DataMember(Name = "fieldRules", EmitDefaultValue = false)]
		public EnrichFieldRules FieldRules { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ExternalOrganizationEnrichRequest {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
			sb.Append("  MatchingIdentifiers: ").Append(MatchingIdentifiers).Append("\n");
			sb.Append("  Action: ").Append(Action).Append("\n");
			sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
			sb.Append("  FieldRules: ").Append(FieldRules).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as ExternalOrganizationEnrichRequest);
		}

		/// <summary>
		/// Returns true if ExternalOrganizationEnrichRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ExternalOrganizationEnrichRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ExternalOrganizationEnrichRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
				) &&
				(
					this.MatchingIdentifiers == other.MatchingIdentifiers ||
					this.MatchingIdentifiers != null &&
					this.MatchingIdentifiers.SequenceEqual(other.MatchingIdentifiers)
				) &&
				(
					this.Action == other.Action ||
					this.Action != null &&
					this.Action.Equals(other.Action)
				) &&
				(
					this.ExternalOrganization == other.ExternalOrganization ||
					this.ExternalOrganization != null &&
					this.ExternalOrganization.Equals(other.ExternalOrganization)
				) &&
				(
					this.FieldRules == other.FieldRules ||
					this.FieldRules != null &&
					this.FieldRules.Equals(other.FieldRules)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				if (this.MatchingIdentifiers != null)
					hash = hash * 59 + this.MatchingIdentifiers.GetHashCode();

				if (this.Action != null)
					hash = hash * 59 + this.Action.GetHashCode();

				if (this.ExternalOrganization != null)
					hash = hash * 59 + this.ExternalOrganization.GetHashCode();

				if (this.FieldRules != null)
					hash = hash * 59 + this.FieldRules.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
