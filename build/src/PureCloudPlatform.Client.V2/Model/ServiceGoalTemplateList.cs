using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ServiceGoalTemplateList
	/// </summary>
	[DataContract]
	public partial class ServiceGoalTemplateList : IEquatable<ServiceGoalTemplateList>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceGoalTemplateList" /> class.
		/// </summary>
		/// <param name="Entities">Entities.</param>
		/// <param name="Metadata">Version metadata for the service goal templates.</param>
		public ServiceGoalTemplateList(List<ServiceGoalTemplate> Entities = null, WfmVersionedEntityMetadata Metadata = null)
		{
			this.Entities = Entities;
			this.Metadata = Metadata;

		}



		/// <summary>
		/// Gets or Sets Entities
		/// </summary>
		[DataMember(Name = "entities", EmitDefaultValue = false)]
		public List<ServiceGoalTemplate> Entities { get; set; }



		/// <summary>
		/// Version metadata for the service goal templates
		/// </summary>
		/// <value>Version metadata for the service goal templates</value>
		[DataMember(Name = "metadata", EmitDefaultValue = false)]
		public WfmVersionedEntityMetadata Metadata { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ServiceGoalTemplateList {\n");

			sb.Append("  Entities: ").Append(Entities).Append("\n");
			sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
			return this.Equals(obj as ServiceGoalTemplateList);
		}

		/// <summary>
		/// Returns true if ServiceGoalTemplateList instances are equal
		/// </summary>
		/// <param name="other">Instance of ServiceGoalTemplateList to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ServiceGoalTemplateList other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Entities == other.Entities ||
					this.Entities != null &&
					this.Entities.SequenceEqual(other.Entities)
				) &&
				(
					this.Metadata == other.Metadata ||
					this.Metadata != null &&
					this.Metadata.Equals(other.Metadata)
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
				if (this.Entities != null)
					hash = hash * 59 + this.Entities.GetHashCode();

				if (this.Metadata != null)
					hash = hash * 59 + this.Metadata.GetHashCode();

				return hash;
			}
		}
	}

}
