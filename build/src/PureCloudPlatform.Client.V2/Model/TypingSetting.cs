using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TypingSetting
	/// </summary>
	[DataContract]
	public partial class TypingSetting : IEquatable<TypingSetting>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TypingSetting" /> class.
		/// </summary>
		/// <param name="On">Should typing indication Events be sent.</param>
		public TypingSetting(SettingDirection On = null)
		{
			this.On = On;

		}



		/// <summary>
		/// Should typing indication Events be sent
		/// </summary>
		/// <value>Should typing indication Events be sent</value>
		[DataMember(Name = "on", EmitDefaultValue = false)]
		public SettingDirection On { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TypingSetting {\n");

			sb.Append("  On: ").Append(On).Append("\n");
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
			return this.Equals(obj as TypingSetting);
		}

		/// <summary>
		/// Returns true if TypingSetting instances are equal
		/// </summary>
		/// <param name="other">Instance of TypingSetting to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TypingSetting other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.On == other.On ||
					this.On != null &&
					this.On.Equals(other.On)
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
				if (this.On != null)
					hash = hash * 59 + this.On.GetHashCode();

				return hash;
			}
		}
	}

}
