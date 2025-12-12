using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// SummarySettingPII
	/// </summary>
	[DataContract]
	public partial class SummarySettingPII : IEquatable<SummarySettingPII>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SummarySettingPII" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SummarySettingPII() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SummarySettingPII" /> class.
		/// </summary>
		/// <param name="All">Toggle PII visibility in summary. (required).</param>
		public SummarySettingPII(bool? All = null)
		{
			this.All = All;

		}



		/// <summary>
		/// Toggle PII visibility in summary.
		/// </summary>
		/// <value>Toggle PII visibility in summary.</value>
		[DataMember(Name = "all", EmitDefaultValue = false)]
		public bool? All { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SummarySettingPII {\n");

			sb.Append("  All: ").Append(All).Append("\n");
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
			return this.Equals(obj as SummarySettingPII);
		}

		/// <summary>
		/// Returns true if SummarySettingPII instances are equal
		/// </summary>
		/// <param name="other">Instance of SummarySettingPII to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SummarySettingPII other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.All == other.All ||
					this.All != null &&
					this.All.Equals(other.All)
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
				if (this.All != null)
					hash = hash * 59 + this.All.GetHashCode();

				return hash;
			}
		}
	}

}
