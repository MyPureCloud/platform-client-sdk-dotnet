using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AuditQueryService
	/// </summary>
	[DataContract]
	public partial class AuditQueryService : IEquatable<AuditQueryService>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AuditQueryService" /> class.
		/// </summary>
		/// <param name="Name">Name of the Service.</param>
		/// <param name="Entities">List of Entities.</param>
		public AuditQueryService(string Name = null, List<AuditQueryEntity> Entities = null)
		{
			this.Name = Name;
			this.Entities = Entities;

		}



		/// <summary>
		/// Name of the Service
		/// </summary>
		/// <value>Name of the Service</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// List of Entities
		/// </summary>
		/// <value>List of Entities</value>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<AuditQueryEntity> Entities { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AuditQueryService {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Entities: ").Append(Entities).Append("\n");
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
			return this.Equals(obj as AuditQueryService);
		}

		/// <summary>
		/// Returns true if AuditQueryService instances are equal
		/// </summary>
		/// <param name="other">Instance of AuditQueryService to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AuditQueryService other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				return hash;
			}
		}
	}

}
