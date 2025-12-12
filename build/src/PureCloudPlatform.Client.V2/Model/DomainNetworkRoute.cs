using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DomainNetworkRoute
	/// </summary>
	[DataContract]
	public partial class DomainNetworkRoute : IEquatable<DomainNetworkRoute>
	{
		/// <summary>
		/// The address family for this route.
		/// </summary>
		/// <value>The address family for this route.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum FamilyEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum NUMBER_2 for 2
			/// </summary>
			[EnumMember(Value = "2")]
			NUMBER_2 = 2,

			/// <summary>
			/// Enum NUMBER_23 for 23
			/// </summary>
			[EnumMember(Value = "23")]
			NUMBER_23 = 23
		}
		/// <summary>
		/// The address family for this route.
		/// </summary>
		/// <value>The address family for this route.</value>
		[DataMember(Name = "family", EmitDefaultValue = false)]
		public FamilyEnum? Family { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DomainNetworkRoute" /> class.
		/// </summary>
		/// <param name="Prefix">The IPv4 or IPv6 route prefix in CIDR notation..</param>
		/// <param name="Nexthop">The IPv4 or IPv6 nexthop IP address..</param>
		/// <param name="Persistent">True if this route will persist on Edge restart.  Routes assigned by DHCP will be returned as false..</param>
		/// <param name="Metric">The metric being used for route. Lower values will have a higher priority..</param>
		/// <param name="Family">The address family for this route..</param>
		public DomainNetworkRoute(string Prefix = null, string Nexthop = null, bool? Persistent = null, int? Metric = null, FamilyEnum? Family = null)
		{
			this.Prefix = Prefix;
			this.Nexthop = Nexthop;
			this.Persistent = Persistent;
			this.Metric = Metric;
			this.Family = Family;

		}



		/// <summary>
		/// The IPv4 or IPv6 route prefix in CIDR notation.
		/// </summary>
		/// <value>The IPv4 or IPv6 route prefix in CIDR notation.</value>
		[DataMember(Name = "prefix", EmitDefaultValue = false)]
		public string Prefix { get; set; }



		/// <summary>
		/// The IPv4 or IPv6 nexthop IP address.
		/// </summary>
		/// <value>The IPv4 or IPv6 nexthop IP address.</value>
		[DataMember(Name = "nexthop", EmitDefaultValue = false)]
		public string Nexthop { get; set; }



		/// <summary>
		/// True if this route will persist on Edge restart.  Routes assigned by DHCP will be returned as false.
		/// </summary>
		/// <value>True if this route will persist on Edge restart.  Routes assigned by DHCP will be returned as false.</value>
		[DataMember(Name = "persistent", EmitDefaultValue = false)]
		public bool? Persistent { get; set; }



		/// <summary>
		/// The metric being used for route. Lower values will have a higher priority.
		/// </summary>
		/// <value>The metric being used for route. Lower values will have a higher priority.</value>
		[DataMember(Name = "metric", EmitDefaultValue = false)]
		public int? Metric { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DomainNetworkRoute {\n");

			sb.Append("  Prefix: ").Append(Prefix).Append("\n");
			sb.Append("  Nexthop: ").Append(Nexthop).Append("\n");
			sb.Append("  Persistent: ").Append(Persistent).Append("\n");
			sb.Append("  Metric: ").Append(Metric).Append("\n");
			sb.Append("  Family: ").Append(Family).Append("\n");
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
			return this.Equals(obj as DomainNetworkRoute);
		}

		/// <summary>
		/// Returns true if DomainNetworkRoute instances are equal
		/// </summary>
		/// <param name="other">Instance of DomainNetworkRoute to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DomainNetworkRoute other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Prefix == other.Prefix ||
					this.Prefix != null &&
					this.Prefix.Equals(other.Prefix)
				) &&
				(
					this.Nexthop == other.Nexthop ||
					this.Nexthop != null &&
					this.Nexthop.Equals(other.Nexthop)
				) &&
				(
					this.Persistent == other.Persistent ||
					this.Persistent != null &&
					this.Persistent.Equals(other.Persistent)
				) &&
				(
					this.Metric == other.Metric ||
					this.Metric != null &&
					this.Metric.Equals(other.Metric)
				) &&
				(
					this.Family == other.Family ||
					this.Family != null &&
					this.Family.Equals(other.Family)
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
				if (this.Prefix != null)
					hash = hash * 59 + this.Prefix.GetHashCode();

				if (this.Nexthop != null)
					hash = hash * 59 + this.Nexthop.GetHashCode();

				if (this.Persistent != null)
					hash = hash * 59 + this.Persistent.GetHashCode();

				if (this.Metric != null)
					hash = hash * 59 + this.Metric.GetHashCode();

				if (this.Family != null)
					hash = hash * 59 + this.Family.GetHashCode();

				return hash;
			}
		}
	}

}
