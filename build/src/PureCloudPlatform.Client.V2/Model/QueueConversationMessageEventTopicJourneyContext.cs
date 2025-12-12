using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// QueueConversationMessageEventTopicJourneyContext
	/// </summary>
	[DataContract]
	public partial class QueueConversationMessageEventTopicJourneyContext : IEquatable<QueueConversationMessageEventTopicJourneyContext>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QueueConversationMessageEventTopicJourneyContext" /> class.
		/// </summary>
		/// <param name="Customer">Customer.</param>
		/// <param name="CustomerSession">CustomerSession.</param>
		/// <param name="TriggeringAction">TriggeringAction.</param>
		public QueueConversationMessageEventTopicJourneyContext(QueueConversationMessageEventTopicJourneyCustomer Customer = null, QueueConversationMessageEventTopicJourneyCustomerSession CustomerSession = null, QueueConversationMessageEventTopicJourneyAction TriggeringAction = null)
		{
			this.Customer = Customer;
			this.CustomerSession = CustomerSession;
			this.TriggeringAction = TriggeringAction;

		}



		/// <summary>
		/// Gets or Sets Customer
		/// </summary>
		[DataMember(Name = "customer", EmitDefaultValue = false)]
		public QueueConversationMessageEventTopicJourneyCustomer Customer { get; set; }



		/// <summary>
		/// Gets or Sets CustomerSession
		/// </summary>
		[DataMember(Name = "customerSession", EmitDefaultValue = false)]
		public QueueConversationMessageEventTopicJourneyCustomerSession CustomerSession { get; set; }



		/// <summary>
		/// Gets or Sets TriggeringAction
		/// </summary>
		[DataMember(Name = "triggeringAction", EmitDefaultValue = false)]
		public QueueConversationMessageEventTopicJourneyAction TriggeringAction { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QueueConversationMessageEventTopicJourneyContext {\n");

			sb.Append("  Customer: ").Append(Customer).Append("\n");
			sb.Append("  CustomerSession: ").Append(CustomerSession).Append("\n");
			sb.Append("  TriggeringAction: ").Append(TriggeringAction).Append("\n");
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
			return this.Equals(obj as QueueConversationMessageEventTopicJourneyContext);
		}

		/// <summary>
		/// Returns true if QueueConversationMessageEventTopicJourneyContext instances are equal
		/// </summary>
		/// <param name="other">Instance of QueueConversationMessageEventTopicJourneyContext to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(QueueConversationMessageEventTopicJourneyContext other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Customer == other.Customer ||
					this.Customer != null &&
					this.Customer.Equals(other.Customer)
				) &&
				(
					this.CustomerSession == other.CustomerSession ||
					this.CustomerSession != null &&
					this.CustomerSession.Equals(other.CustomerSession)
				) &&
				(
					this.TriggeringAction == other.TriggeringAction ||
					this.TriggeringAction != null &&
					this.TriggeringAction.Equals(other.TriggeringAction)
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
				if (this.Customer != null)
					hash = hash * 59 + this.Customer.GetHashCode();

				if (this.CustomerSession != null)
					hash = hash * 59 + this.CustomerSession.GetHashCode();

				if (this.TriggeringAction != null)
					hash = hash * 59 + this.TriggeringAction.GetHashCode();

				return hash;
			}
		}
	}

}
