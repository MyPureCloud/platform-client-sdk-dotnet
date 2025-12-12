using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FieldConfigs
	/// </summary>
	[DataContract]
	public partial class FieldConfigs : IEquatable<FieldConfigs>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FieldConfigs" /> class.
		/// </summary>
		/// <param name="Org">Org.</param>
		/// <param name="Person">Person.</param>
		/// <param name="Group">Group.</param>
		public FieldConfigs(FieldConfig Org = null, FieldConfig Person = null, FieldConfig Group = null)
		{
			this.Org = Org;
			this.Person = Person;
			this.Group = Group;

		}



		/// <summary>
		/// Gets or Sets Org
		/// </summary>
		[DataMember(Name = "org", EmitDefaultValue = false)]
		public FieldConfig Org { get; set; }



		/// <summary>
		/// Gets or Sets Person
		/// </summary>
		[DataMember(Name = "person", EmitDefaultValue = false)]
		public FieldConfig Person { get; set; }



		/// <summary>
		/// Gets or Sets Group
		/// </summary>
		[DataMember(Name = "group", EmitDefaultValue = false)]
		public FieldConfig Group { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FieldConfigs {\n");

			sb.Append("  Org: ").Append(Org).Append("\n");
			sb.Append("  Person: ").Append(Person).Append("\n");
			sb.Append("  Group: ").Append(Group).Append("\n");
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
			return this.Equals(obj as FieldConfigs);
		}

		/// <summary>
		/// Returns true if FieldConfigs instances are equal
		/// </summary>
		/// <param name="other">Instance of FieldConfigs to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FieldConfigs other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Org == other.Org ||
					this.Org != null &&
					this.Org.Equals(other.Org)
				) &&
				(
					this.Person == other.Person ||
					this.Person != null &&
					this.Person.Equals(other.Person)
				) &&
				(
					this.Group == other.Group ||
					this.Group != null &&
					this.Group.Equals(other.Group)
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
				if (this.Org != null)
					hash = hash * 59 + this.Org.GetHashCode();

				if (this.Person != null)
					hash = hash * 59 + this.Person.GetHashCode();

				if (this.Group != null)
					hash = hash * 59 + this.Group.GetHashCode();

				return hash;
			}
		}
	}

}
