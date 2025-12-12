using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// LimitDocs
	/// </summary>
	[DataContract]
	public partial class LimitDocs : IEquatable<LimitDocs>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LimitDocs" /> class.
		/// </summary>
		/// <param name="Key">Key.</param>
		/// <param name="DefaultValue">DefaultValue.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Resource">Resource.</param>
		/// <param name="Configurable">Configurable.</param>
		/// <param name="Trackable">Trackable.</param>
		public LimitDocs(string Key = null, long? DefaultValue = null, string Description = null, string Resource = null, bool? Configurable = null, bool? Trackable = null)
		{
			this.Key = Key;
			this.DefaultValue = DefaultValue;
			this.Description = Description;
			this.Resource = Resource;
			this.Configurable = Configurable;
			this.Trackable = Trackable;

		}



		/// <summary>
		/// Gets or Sets Key
		/// </summary>
		[DataMember(Name = "key", EmitDefaultValue = false)]
		public string Key { get; set; }



		/// <summary>
		/// Gets or Sets DefaultValue
		/// </summary>
		[DataMember(Name = "defaultValue", EmitDefaultValue = false)]
		public long? DefaultValue { get; set; }



		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// Gets or Sets Resource
		/// </summary>
		[DataMember(Name = "resource", EmitDefaultValue = false)]
		public string Resource { get; set; }



		/// <summary>
		/// Gets or Sets Configurable
		/// </summary>
		[DataMember(Name = "configurable", EmitDefaultValue = false)]
		public bool? Configurable { get; set; }



		/// <summary>
		/// Gets or Sets Trackable
		/// </summary>
		[DataMember(Name = "trackable", EmitDefaultValue = false)]
		public bool? Trackable { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LimitDocs {\n");

			sb.Append("  Key: ").Append(Key).Append("\n");
			sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Resource: ").Append(Resource).Append("\n");
			sb.Append("  Configurable: ").Append(Configurable).Append("\n");
			sb.Append("  Trackable: ").Append(Trackable).Append("\n");
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
			return this.Equals(obj as LimitDocs);
		}

		/// <summary>
		/// Returns true if LimitDocs instances are equal
		/// </summary>
		/// <param name="other">Instance of LimitDocs to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LimitDocs other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Key == other.Key ||
					this.Key != null &&
					this.Key.Equals(other.Key)
				) &&
				(
					this.DefaultValue == other.DefaultValue ||
					this.DefaultValue != null &&
					this.DefaultValue.Equals(other.DefaultValue)
				) &&
				(
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Resource == other.Resource ||
					this.Resource != null &&
					this.Resource.Equals(other.Resource)
				) &&
				(
					this.Configurable == other.Configurable ||
					this.Configurable != null &&
					this.Configurable.Equals(other.Configurable)
				) &&
				(
					this.Trackable == other.Trackable ||
					this.Trackable != null &&
					this.Trackable.Equals(other.Trackable)
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
				if (this.Key != null)
					hash = hash * 59 + this.Key.GetHashCode();

				if (this.DefaultValue != null)
					hash = hash * 59 + this.DefaultValue.GetHashCode();

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Resource != null)
					hash = hash * 59 + this.Resource.GetHashCode();

				if (this.Configurable != null)
					hash = hash * 59 + this.Configurable.GetHashCode();

				if (this.Trackable != null)
					hash = hash * 59 + this.Trackable.GetHashCode();

				return hash;
			}
		}
	}

}
