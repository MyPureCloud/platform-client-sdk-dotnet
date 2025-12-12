using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DefaultAnswer
	/// </summary>
	[DataContract]
	public partial class DefaultAnswer : IEquatable<DefaultAnswer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DefaultAnswer" /> class.
		/// </summary>
		/// <param name="Id">Selected default answer id for the question..</param>
		public DefaultAnswer(string Id = null)
		{
			this.Id = Id;

		}



		/// <summary>
		/// Selected default answer id for the question.
		/// </summary>
		/// <value>Selected default answer id for the question.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }



		/// <summary>
		/// Is true if the selected default answer for the question is N/A
		/// </summary>
		/// <value>Is true if the selected default answer for the question is N/A</value>
		[DataMember(Name = "notApplicable", EmitDefaultValue = false)]
		public bool? NotApplicable { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DefaultAnswer {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  NotApplicable: ").Append(NotApplicable).Append("\n");
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
			return this.Equals(obj as DefaultAnswer);
		}

		/// <summary>
		/// Returns true if DefaultAnswer instances are equal
		/// </summary>
		/// <param name="other">Instance of DefaultAnswer to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DefaultAnswer other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.NotApplicable == other.NotApplicable ||
					this.NotApplicable != null &&
					this.NotApplicable.Equals(other.NotApplicable)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.NotApplicable != null)
					hash = hash * 59 + this.NotApplicable.GetHashCode();

				return hash;
			}
		}
	}

}
