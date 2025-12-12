using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// FlowHealthVersionInfo
	/// </summary>
	[DataContract]
	public partial class FlowHealthVersionInfo : IEquatable<FlowHealthVersionInfo>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FlowHealthVersionInfo" /> class.
		/// </summary>
		public FlowHealthVersionInfo()
		{

		}



		/// <summary>
		/// Given flow&#39;s Version Info.
		/// </summary>
		/// <value>Given flow&#39;s Version Info.</value>
		[DataMember(Name = "flowVersion", EmitDefaultValue = false)]
		public AddressableEntityRef FlowVersion { get; private set; }



		/// <summary>
		/// NLU Domain Info for this flow version.
		/// </summary>
		/// <value>NLU Domain Info for this flow version.</value>
		[DataMember(Name = "nluDomain", EmitDefaultValue = false)]
		public AddressableEntityRef NluDomain { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FlowHealthVersionInfo {\n");

			sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
			sb.Append("  NluDomain: ").Append(NluDomain).Append("\n");
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
			return this.Equals(obj as FlowHealthVersionInfo);
		}

		/// <summary>
		/// Returns true if FlowHealthVersionInfo instances are equal
		/// </summary>
		/// <param name="other">Instance of FlowHealthVersionInfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FlowHealthVersionInfo other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FlowVersion == other.FlowVersion ||
					this.FlowVersion != null &&
					this.FlowVersion.Equals(other.FlowVersion)
				) &&
				(
					this.NluDomain == other.NluDomain ||
					this.NluDomain != null &&
					this.NluDomain.Equals(other.NluDomain)
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
				if (this.FlowVersion != null)
					hash = hash * 59 + this.FlowVersion.GetHashCode();

				if (this.NluDomain != null)
					hash = hash * 59 + this.NluDomain.GetHashCode();

				return hash;
			}
		}
	}

}
