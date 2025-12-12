using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// IgnoreTopicsResponse
	/// </summary>
	[DataContract]
	public partial class IgnoreTopicsResponse : IEquatable<IgnoreTopicsResponse>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="IgnoreTopicsResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected IgnoreTopicsResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="IgnoreTopicsResponse" /> class.
		/// </summary>
		/// <param name="TotalTopics">Total number of topics in current org (required).</param>
		/// <param name="AddedTopics">Number of topics added in current request (required).</param>
		/// <param name="UpdatedTopics">Number of topics updated in current request (required).</param>
		public IgnoreTopicsResponse(int? TotalTopics = null, int? AddedTopics = null, int? UpdatedTopics = null)
		{
			this.TotalTopics = TotalTopics;
			this.AddedTopics = AddedTopics;
			this.UpdatedTopics = UpdatedTopics;

		}



		/// <summary>
		/// Total number of topics in current org
		/// </summary>
		/// <value>Total number of topics in current org</value>
		[DataMember(Name = "totalTopics", EmitDefaultValue = false)]
		public int? TotalTopics { get; set; }



		/// <summary>
		/// Number of topics added in current request
		/// </summary>
		/// <value>Number of topics added in current request</value>
		[DataMember(Name = "addedTopics", EmitDefaultValue = false)]
		public int? AddedTopics { get; set; }



		/// <summary>
		/// Number of topics updated in current request
		/// </summary>
		/// <value>Number of topics updated in current request</value>
		[DataMember(Name = "updatedTopics", EmitDefaultValue = false)]
		public int? UpdatedTopics { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class IgnoreTopicsResponse {\n");

			sb.Append("  TotalTopics: ").Append(TotalTopics).Append("\n");
			sb.Append("  AddedTopics: ").Append(AddedTopics).Append("\n");
			sb.Append("  UpdatedTopics: ").Append(UpdatedTopics).Append("\n");
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
			return this.Equals(obj as IgnoreTopicsResponse);
		}

		/// <summary>
		/// Returns true if IgnoreTopicsResponse instances are equal
		/// </summary>
		/// <param name="other">Instance of IgnoreTopicsResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(IgnoreTopicsResponse other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TotalTopics == other.TotalTopics ||
					this.TotalTopics != null &&
					this.TotalTopics.Equals(other.TotalTopics)
				) &&
				(
					this.AddedTopics == other.AddedTopics ||
					this.AddedTopics != null &&
					this.AddedTopics.Equals(other.AddedTopics)
				) &&
				(
					this.UpdatedTopics == other.UpdatedTopics ||
					this.UpdatedTopics != null &&
					this.UpdatedTopics.Equals(other.UpdatedTopics)
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
				if (this.TotalTopics != null)
					hash = hash * 59 + this.TotalTopics.GetHashCode();

				if (this.AddedTopics != null)
					hash = hash * 59 + this.AddedTopics.GetHashCode();

				if (this.UpdatedTopics != null)
					hash = hash * 59 + this.UpdatedTopics.GetHashCode();

				return hash;
			}
		}
	}

}
