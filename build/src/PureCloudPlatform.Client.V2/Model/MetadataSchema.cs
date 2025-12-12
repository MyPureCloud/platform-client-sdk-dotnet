using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A description of the contents of a data gathering interface for an accelerator
	/// </summary>
	[DataContract]
	public partial class MetadataSchema : IEquatable<MetadataSchema>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MetadataSchema" /> class.
		/// </summary>
		public MetadataSchema()
		{

		}



		/// <summary>
		/// title for the data gathering page
		/// </summary>
		/// <value>title for the data gathering page</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; private set; }



		/// <summary>
		/// description of the data being gathered on this page
		/// </summary>
		/// <value>description of the data being gathered on this page</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; private set; }



		/// <summary>
		/// type of data being gathered
		/// </summary>
		/// <value>type of data being gathered</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; private set; }



		/// <summary>
		/// list of properties for which input is to be gathered, bother required and optional
		/// </summary>
		/// <value>list of properties for which input is to be gathered, bother required and optional</value>
		[DataMember(Name = "properties", EmitDefaultValue = false)]
		public List<Dictionary<string, MetadataProperty>> Properties { get; private set; }



		/// <summary>
		/// list of required properties
		/// </summary>
		/// <value>list of required properties</value>
		[DataMember(Name = "required", EmitDefaultValue = false)]
		public List<string> Required { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MetadataSchema {\n");

			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Properties: ").Append(Properties).Append("\n");
			sb.Append("  Required: ").Append(Required).Append("\n");
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
			return this.Equals(obj as MetadataSchema);
		}

		/// <summary>
		/// Returns true if MetadataSchema instances are equal
		/// </summary>
		/// <param name="other">Instance of MetadataSchema to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MetadataSchema other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Type == other.Type ||
					this.Type != null &&
					this.Type.Equals(other.Type)
				) &&
				(
					this.Properties == other.Properties ||
					this.Properties != null &&
					this.Properties.SequenceEqual(other.Properties)
				) &&
				(
					this.Required == other.Required ||
					this.Required != null &&
					this.Required.SequenceEqual(other.Required)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Type != null)
					hash = hash * 59 + this.Type.GetHashCode();

				if (this.Properties != null)
					hash = hash * 59 + this.Properties.GetHashCode();

				if (this.Required != null)
					hash = hash * 59 + this.Required.GetHashCode();

				return hash;
			}
		}
	}

}
