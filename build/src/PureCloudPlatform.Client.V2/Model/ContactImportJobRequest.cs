using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContactImportJobRequest
	/// </summary>
	[DataContract]
	public partial class ContactImportJobRequest : IEquatable<ContactImportJobRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactImportJobRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ContactImportJobRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactImportJobRequest" /> class.
		/// </summary>
		/// <param name="SettingsId">Settings id (required).</param>
		/// <param name="Division">The division to import into.</param>
		public ContactImportJobRequest(string SettingsId = null, WritableStarrableDivision Division = null)
		{
			this.SettingsId = SettingsId;
			this.Division = Division;

		}



		/// <summary>
		/// Settings id
		/// </summary>
		/// <value>Settings id</value>
		[DataMember(Name = "settingsId", EmitDefaultValue = false)]
		public string SettingsId { get; set; }



		/// <summary>
		/// The division to import into
		/// </summary>
		/// <value>The division to import into</value>
		[DataMember(Name = "division", EmitDefaultValue = false)]
		public WritableStarrableDivision Division { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContactImportJobRequest {\n");

			sb.Append("  SettingsId: ").Append(SettingsId).Append("\n");
			sb.Append("  Division: ").Append(Division).Append("\n");
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
			return this.Equals(obj as ContactImportJobRequest);
		}

		/// <summary>
		/// Returns true if ContactImportJobRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ContactImportJobRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContactImportJobRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.SettingsId == other.SettingsId ||
					this.SettingsId != null &&
					this.SettingsId.Equals(other.SettingsId)
				) &&
				(
					this.Division == other.Division ||
					this.Division != null &&
					this.Division.Equals(other.Division)
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
				if (this.SettingsId != null)
					hash = hash * 59 + this.SettingsId.GetHashCode();

				if (this.Division != null)
					hash = hash * 59 + this.Division.GetHashCode();

				return hash;
			}
		}
	}

}
