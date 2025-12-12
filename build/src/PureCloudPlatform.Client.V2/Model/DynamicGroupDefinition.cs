using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DynamicGroupDefinition
	/// </summary>
	[DataContract]
	public partial class DynamicGroupDefinition : IEquatable<DynamicGroupDefinition>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="DynamicGroupDefinition" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected DynamicGroupDefinition() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="DynamicGroupDefinition" /> class.
		/// </summary>
		/// <param name="Group">The group the dynamic group definition belongs to (required).</param>
		/// <param name="DateModified">Last modified date/time of the dynamic group definition. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
		/// <param name="Query">Properties used for building a dynamic groups query (required).</param>
		public DynamicGroupDefinition(AddressableEntityRef Group = null, DateTime? DateModified = null, DynamicGroupQuery Query = null)
		{
			this.Group = Group;
			this.DateModified = DateModified;
			this.Query = Query;

		}



		/// <summary>
		/// The group the dynamic group definition belongs to
		/// </summary>
		/// <value>The group the dynamic group definition belongs to</value>
		[DataMember(Name = "group", EmitDefaultValue = false)]
		public AddressableEntityRef Group { get; set; }



		/// <summary>
		/// Last modified date/time of the dynamic group definition. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>Last modified date/time of the dynamic group definition. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; set; }



		/// <summary>
		/// Properties used for building a dynamic groups query
		/// </summary>
		/// <value>Properties used for building a dynamic groups query</value>
		[DataMember(Name = "query", EmitDefaultValue = false)]
		public DynamicGroupQuery Query { get; set; }



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
			sb.Append("class DynamicGroupDefinition {\n");

			sb.Append("  Group: ").Append(Group).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
			sb.Append("  Query: ").Append(Query).Append("\n");
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
			return this.Equals(obj as DynamicGroupDefinition);
		}

		/// <summary>
		/// Returns true if DynamicGroupDefinition instances are equal
		/// </summary>
		/// <param name="other">Instance of DynamicGroupDefinition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DynamicGroupDefinition other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Group == other.Group ||
					this.Group != null &&
					this.Group.Equals(other.Group)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
				) &&
				(
					this.Query == other.Query ||
					this.Query != null &&
					this.Query.Equals(other.Query)
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
				if (this.Group != null)
					hash = hash * 59 + this.Group.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.Query != null)
					hash = hash * 59 + this.Query.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
