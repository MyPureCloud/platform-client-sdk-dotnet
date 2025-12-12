using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ContentSetting
	/// </summary>
	[DataContract]
	public partial class ContentSetting : IEquatable<ContentSetting>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContentSetting" /> class.
		/// </summary>
		/// <param name="Story">Settings relating to facebook and instagram stories feature.</param>
		public ContentSetting(StorySetting Story = null)
		{
			this.Story = Story;

		}



		/// <summary>
		/// Settings relating to facebook and instagram stories feature
		/// </summary>
		/// <value>Settings relating to facebook and instagram stories feature</value>
		[DataMember(Name = "story", EmitDefaultValue = false)]
		public StorySetting Story { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ContentSetting {\n");

			sb.Append("  Story: ").Append(Story).Append("\n");
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
			return this.Equals(obj as ContentSetting);
		}

		/// <summary>
		/// Returns true if ContentSetting instances are equal
		/// </summary>
		/// <param name="other">Instance of ContentSetting to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ContentSetting other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Story == other.Story ||
					this.Story != null &&
					this.Story.Equals(other.Story)
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
				if (this.Story != null)
					hash = hash * 59 + this.Story.GetHashCode();

				return hash;
			}
		}
	}

}
