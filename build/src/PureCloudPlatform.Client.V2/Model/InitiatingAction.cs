using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// InitiatingAction
	/// </summary>
	[DataContract]
	public partial class InitiatingAction : IEquatable<InitiatingAction>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InitiatingAction" /> class.
		/// </summary>
		/// <param name="TransactionId">Id of the audit initiating the transaction.</param>
		/// <param name="ActionContext">Action of the audit initiating the transaction.</param>
		public InitiatingAction(string TransactionId = null, string ActionContext = null)
		{
			this.TransactionId = TransactionId;
			this.ActionContext = ActionContext;

		}



		/// <summary>
		/// Id of the audit initiating the transaction
		/// </summary>
		/// <value>Id of the audit initiating the transaction</value>
		[DataMember(Name = "transactionId", EmitDefaultValue = false)]
		public string TransactionId { get; set; }



		/// <summary>
		/// Action of the audit initiating the transaction
		/// </summary>
		/// <value>Action of the audit initiating the transaction</value>
		[DataMember(Name = "actionContext", EmitDefaultValue = false)]
		public string ActionContext { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InitiatingAction {\n");

			sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
			sb.Append("  ActionContext: ").Append(ActionContext).Append("\n");
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
			return this.Equals(obj as InitiatingAction);
		}

		/// <summary>
		/// Returns true if InitiatingAction instances are equal
		/// </summary>
		/// <param name="other">Instance of InitiatingAction to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(InitiatingAction other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.TransactionId == other.TransactionId ||
					this.TransactionId != null &&
					this.TransactionId.Equals(other.TransactionId)
				) &&
				(
					this.ActionContext == other.ActionContext ||
					this.ActionContext != null &&
					this.ActionContext.Equals(other.ActionContext)
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
				if (this.TransactionId != null)
					hash = hash * 59 + this.TransactionId.GetHashCode();

				if (this.ActionContext != null)
					hash = hash * 59 + this.ActionContext.GetHashCode();

				return hash;
			}
		}
	}

}
