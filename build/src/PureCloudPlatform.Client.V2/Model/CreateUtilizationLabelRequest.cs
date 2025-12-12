using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// CreateUtilizationLabelRequest
	/// </summary>
	[DataContract]
	public partial class CreateUtilizationLabelRequest : IEquatable<CreateUtilizationLabelRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateUtilizationLabelRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CreateUtilizationLabelRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CreateUtilizationLabelRequest" /> class.
		/// </summary>
		/// <param name="Name">The utilization label name. (required).</param>
		/// <param name="Utilization">Org level utilization settings for the new label. If not specified, default utilization settings will be applied..</param>
		public CreateUtilizationLabelRequest(string Name = null, LabelUtilizationRequest Utilization = null)
		{
			this.Name = Name;
			this.Utilization = Utilization;

		}



		/// <summary>
		/// The utilization label name.
		/// </summary>
		/// <value>The utilization label name.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Org level utilization settings for the new label. If not specified, default utilization settings will be applied.
		/// </summary>
		/// <value>Org level utilization settings for the new label. If not specified, default utilization settings will be applied.</value>
		[DataMember(Name = "utilization", EmitDefaultValue = false)]
		public LabelUtilizationRequest Utilization { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CreateUtilizationLabelRequest {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Utilization: ").Append(Utilization).Append("\n");
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
			return this.Equals(obj as CreateUtilizationLabelRequest);
		}

		/// <summary>
		/// Returns true if CreateUtilizationLabelRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of CreateUtilizationLabelRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CreateUtilizationLabelRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Utilization == other.Utilization ||
					this.Utilization != null &&
					this.Utilization.Equals(other.Utilization)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Utilization != null)
					hash = hash * 59 + this.Utilization.GetHashCode();

				return hash;
			}
		}
	}

}
