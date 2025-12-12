using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// TrunkMetricsNetworkTypeIp
	/// </summary>
	[DataContract]
	public partial class TrunkMetricsNetworkTypeIp : IEquatable<TrunkMetricsNetworkTypeIp>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TrunkMetricsNetworkTypeIp" /> class.
		/// </summary>
		/// <param name="Address">Assigned IP Address for the interface.</param>
		/// <param name="ErrorInfo">Information about the error..</param>
		public TrunkMetricsNetworkTypeIp(string Address = null, TrunkErrorInfo ErrorInfo = null)
		{
			this.Address = Address;
			this.ErrorInfo = ErrorInfo;

		}



		/// <summary>
		/// Assigned IP Address for the interface
		/// </summary>
		/// <value>Assigned IP Address for the interface</value>
		[DataMember(Name = "address", EmitDefaultValue = false)]
		public string Address { get; set; }



		/// <summary>
		/// Information about the error.
		/// </summary>
		/// <value>Information about the error.</value>
		[DataMember(Name = "errorInfo", EmitDefaultValue = false)]
		public TrunkErrorInfo ErrorInfo { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TrunkMetricsNetworkTypeIp {\n");

			sb.Append("  Address: ").Append(Address).Append("\n");
			sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
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
			return this.Equals(obj as TrunkMetricsNetworkTypeIp);
		}

		/// <summary>
		/// Returns true if TrunkMetricsNetworkTypeIp instances are equal
		/// </summary>
		/// <param name="other">Instance of TrunkMetricsNetworkTypeIp to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TrunkMetricsNetworkTypeIp other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Address == other.Address ||
					this.Address != null &&
					this.Address.Equals(other.Address)
				) &&
				(
					this.ErrorInfo == other.ErrorInfo ||
					this.ErrorInfo != null &&
					this.ErrorInfo.Equals(other.ErrorInfo)
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
				if (this.Address != null)
					hash = hash * 59 + this.Address.GetHashCode();

				if (this.ErrorInfo != null)
					hash = hash * 59 + this.ErrorInfo.GetHashCode();

				return hash;
			}
		}
	}

}
