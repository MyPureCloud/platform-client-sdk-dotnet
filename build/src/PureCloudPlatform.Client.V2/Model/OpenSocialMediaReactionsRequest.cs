using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// OpenSocialMediaReactionsRequest
	/// </summary>
	[DataContract]
	public partial class OpenSocialMediaReactionsRequest : IEquatable<OpenSocialMediaReactionsRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="OpenSocialMediaReactionsRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected OpenSocialMediaReactionsRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="OpenSocialMediaReactionsRequest" /> class.
		/// </summary>
		/// <param name="Events">List of open social media reaction events (required).</param>
		public OpenSocialMediaReactionsRequest(List<OpenSocialMediaReactionsNormalizedEvent> Events = null)
		{
			this.Events = Events;

		}



		/// <summary>
		/// List of open social media reaction events
		/// </summary>
		/// <value>List of open social media reaction events</value>
		[DataMember(Name = "events", EmitDefaultValue = false)]
		public List<OpenSocialMediaReactionsNormalizedEvent> Events { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OpenSocialMediaReactionsRequest {\n");

			sb.Append("  Events: ").Append(Events).Append("\n");
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
			return this.Equals(obj as OpenSocialMediaReactionsRequest);
		}

		/// <summary>
		/// Returns true if OpenSocialMediaReactionsRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of OpenSocialMediaReactionsRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OpenSocialMediaReactionsRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Events == other.Events ||
					this.Events != null &&
					this.Events.SequenceEqual(other.Events)
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
				if (this.Events != null)
					hash = hash * 59 + this.Events.GetHashCode();

				return hash;
			}
		}
	}

}
