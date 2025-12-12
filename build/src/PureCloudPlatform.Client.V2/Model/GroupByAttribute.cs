using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// GroupByAttribute
	/// </summary>
	[DataContract]
	public partial class GroupByAttribute : IEquatable<GroupByAttribute>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GroupByAttribute" /> class.
		/// </summary>
		public GroupByAttribute()
		{

		}



		/// <summary>
		/// Group by attribute
		/// </summary>
		/// <value>Group by attribute</value>
		[DataMember(Name = "attribute", EmitDefaultValue = false)]
		public string Attribute { get; private set; }



		/// <summary>
		/// Value of this group by attribute
		/// </summary>
		/// <value>Value of this group by attribute</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GroupByAttribute {\n");

			sb.Append("  Attribute: ").Append(Attribute).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return this.Equals(obj as GroupByAttribute);
		}

		/// <summary>
		/// Returns true if GroupByAttribute instances are equal
		/// </summary>
		/// <param name="other">Instance of GroupByAttribute to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GroupByAttribute other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Attribute == other.Attribute ||
					this.Attribute != null &&
					this.Attribute.Equals(other.Attribute)
				) &&
				(
					this.Value == other.Value ||
					this.Value != null &&
					this.Value.Equals(other.Value)
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
				if (this.Attribute != null)
					hash = hash * 59 + this.Attribute.GetHashCode();

				if (this.Value != null)
					hash = hash * 59 + this.Value.GetHashCode();

				return hash;
			}
		}
	}

}
