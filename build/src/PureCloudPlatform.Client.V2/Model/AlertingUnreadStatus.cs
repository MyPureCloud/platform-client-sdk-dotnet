using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// AlertingUnreadStatus
	/// </summary>
	[DataContract]
	public partial class AlertingUnreadStatus : IEquatable<AlertingUnreadStatus>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="AlertingUnreadStatus" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected AlertingUnreadStatus() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="AlertingUnreadStatus" /> class.
		/// </summary>
		/// <param name="Unread">True is alert is unread, false if it has not been. (required).</param>
		public AlertingUnreadStatus(bool? Unread = null)
		{
			this.Unread = Unread;

		}



		/// <summary>
		/// True is alert is unread, false if it has not been.
		/// </summary>
		/// <value>True is alert is unread, false if it has not been.</value>
		[DataMember(Name = "unread", EmitDefaultValue = false)]
		public bool? Unread { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AlertingUnreadStatus {\n");

			sb.Append("  Unread: ").Append(Unread).Append("\n");
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
			return this.Equals(obj as AlertingUnreadStatus);
		}

		/// <summary>
		/// Returns true if AlertingUnreadStatus instances are equal
		/// </summary>
		/// <param name="other">Instance of AlertingUnreadStatus to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AlertingUnreadStatus other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Unread == other.Unread ||
					this.Unread != null &&
					this.Unread.Equals(other.Unread)
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
				if (this.Unread != null)
					hash = hash * 59 + this.Unread.GetHashCode();

				return hash;
			}
		}
	}

}
