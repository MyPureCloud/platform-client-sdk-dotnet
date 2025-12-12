using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OpenActionProperties
	/// </summary>
	[DataContract]
	public partial class OpenActionProperties : IEquatable<OpenActionProperties>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OpenActionProperties" /> class.
		/// </summary>
		/// <param name="OpenActionName">The specific type of the open action..</param>
		/// <param name="ConfigurationFields">Custom fields defined in the schema referenced by the open action type selected..</param>
		public OpenActionProperties(string OpenActionName = null, Dictionary<string, Object> ConfigurationFields = null)
		{
			this.OpenActionName = OpenActionName;
			this.ConfigurationFields = ConfigurationFields;

		}



		/// <summary>
		/// The specific type of the open action.
		/// </summary>
		/// <value>The specific type of the open action.</value>
		[DataMember(Name = "openActionName", EmitDefaultValue = false)]
		public string OpenActionName { get; set; }



		/// <summary>
		/// Custom fields defined in the schema referenced by the open action type selected.
		/// </summary>
		/// <value>Custom fields defined in the schema referenced by the open action type selected.</value>
		[DataMember(Name = "configurationFields", EmitDefaultValue = false)]
		public Dictionary<string, Object> ConfigurationFields { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OpenActionProperties {\n");

			sb.Append("  OpenActionName: ").Append(OpenActionName).Append("\n");
			sb.Append("  ConfigurationFields: ").Append(ConfigurationFields).Append("\n");
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
			return this.Equals(obj as OpenActionProperties);
		}

		/// <summary>
		/// Returns true if OpenActionProperties instances are equal
		/// </summary>
		/// <param name="other">Instance of OpenActionProperties to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OpenActionProperties other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.OpenActionName == other.OpenActionName ||
					this.OpenActionName != null &&
					this.OpenActionName.Equals(other.OpenActionName)
				) &&
				(
					this.ConfigurationFields == other.ConfigurationFields ||
					this.ConfigurationFields != null &&
					this.ConfigurationFields.SequenceEqual(other.ConfigurationFields)
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
				if (this.OpenActionName != null)
					hash = hash * 59 + this.OpenActionName.GetHashCode();

				if (this.ConfigurationFields != null)
					hash = hash * 59 + this.ConfigurationFields.GetHashCode();

				return hash;
			}
		}
	}

}
