using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// IgnoreTopicsRequest
	/// </summary>
	[DataContract]
	public partial class IgnoreTopicsRequest : IEquatable<IgnoreTopicsRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="IgnoreTopicsRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected IgnoreTopicsRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="IgnoreTopicsRequest" /> class.
		/// </summary>
		/// <param name="Topics">List of topics to be ignored (required).</param>
		public IgnoreTopicsRequest(List<IgnoreTopic> Topics = null)
		{
			this.Topics = Topics;

		}



		/// <summary>
		/// List of topics to be ignored
		/// </summary>
		/// <value>List of topics to be ignored</value>
		[DataMember(Name = "topics", EmitDefaultValue = false)]
		public List<IgnoreTopic> Topics { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class IgnoreTopicsRequest {\n");

			sb.Append("  Topics: ").Append(Topics).Append("\n");
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
			return this.Equals(obj as IgnoreTopicsRequest);
		}

		/// <summary>
		/// Returns true if IgnoreTopicsRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of IgnoreTopicsRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(IgnoreTopicsRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Topics == other.Topics ||
					this.Topics != null &&
					this.Topics.SequenceEqual(other.Topics)
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
				if (this.Topics != null)
					hash = hash * 59 + this.Topics.GetHashCode();

				return hash;
			}
		}
	}

}
