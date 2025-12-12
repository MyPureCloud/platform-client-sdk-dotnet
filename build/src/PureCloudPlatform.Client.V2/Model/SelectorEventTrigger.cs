using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Details about a selector event trigger
	/// </summary>
	[DataContract]
	public partial class SelectorEventTrigger : IEquatable<SelectorEventTrigger>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="SelectorEventTrigger" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SelectorEventTrigger() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SelectorEventTrigger" /> class.
		/// </summary>
		/// <param name="Selector">Element that triggers event. (required).</param>
		/// <param name="EventName">Name of event triggered when element matching selector is interacted with. (required).</param>
		public SelectorEventTrigger(string Selector = null, string EventName = null)
		{
			this.Selector = Selector;
			this.EventName = EventName;

		}



		/// <summary>
		/// Element that triggers event.
		/// </summary>
		/// <value>Element that triggers event.</value>
		[DataMember(Name = "selector", EmitDefaultValue = false)]
		public string Selector { get; set; }



		/// <summary>
		/// Name of event triggered when element matching selector is interacted with.
		/// </summary>
		/// <value>Name of event triggered when element matching selector is interacted with.</value>
		[DataMember(Name = "eventName", EmitDefaultValue = false)]
		public string EventName { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SelectorEventTrigger {\n");

			sb.Append("  Selector: ").Append(Selector).Append("\n");
			sb.Append("  EventName: ").Append(EventName).Append("\n");
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
			return this.Equals(obj as SelectorEventTrigger);
		}

		/// <summary>
		/// Returns true if SelectorEventTrigger instances are equal
		/// </summary>
		/// <param name="other">Instance of SelectorEventTrigger to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SelectorEventTrigger other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Selector == other.Selector ||
					this.Selector != null &&
					this.Selector.Equals(other.Selector)
				) &&
				(
					this.EventName == other.EventName ||
					this.EventName != null &&
					this.EventName.Equals(other.EventName)
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
				if (this.Selector != null)
					hash = hash * 59 + this.Selector.GetHashCode();

				if (this.EventName != null)
					hash = hash * 59 + this.EventName.GetHashCode();

				return hash;
			}
		}
	}

}
