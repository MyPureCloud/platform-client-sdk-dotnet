using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A representation of data fields to be gathered for installing the accelerator
	/// </summary>
	[DataContract]
	public partial class MetadataPresentation : IEquatable<MetadataPresentation>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MetadataPresentation" /> class.
		/// </summary>
		public MetadataPresentation()
		{

		}



		/// <summary>
		/// title for a set of data to be gathered
		/// </summary>
		/// <value>title for a set of data to be gathered</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; private set; }



		/// <summary>
		/// description of the contents of the data gathering interface
		/// </summary>
		/// <value>description of the contents of the data gathering interface</value>
		[DataMember(Name = "schema", EmitDefaultValue = false)]
		public MetadataSchema Schema { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MetadataPresentation {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Schema: ").Append(Schema).Append("\n");
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
			return this.Equals(obj as MetadataPresentation);
		}

		/// <summary>
		/// Returns true if MetadataPresentation instances are equal
		/// </summary>
		/// <param name="other">Instance of MetadataPresentation to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MetadataPresentation other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Schema == other.Schema ||
					this.Schema != null &&
					this.Schema.Equals(other.Schema)
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
				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Schema != null)
					hash = hash * 59 + this.Schema.GetHashCode();

				return hash;
			}
		}
	}

}
