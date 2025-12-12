using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DomainPhysicalCapabilities
	/// </summary>
	[DataContract]
	public partial class DomainPhysicalCapabilities : IEquatable<DomainPhysicalCapabilities>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DomainPhysicalCapabilities" /> class.
		/// </summary>
		/// <param name="Vlan">Vlan.</param>
		/// <param name="Team">Team.</param>
		public DomainPhysicalCapabilities(bool? Vlan = null, bool? Team = null)
		{
			this.Vlan = Vlan;
			this.Team = Team;

		}



		/// <summary>
		/// Gets or Sets Vlan
		/// </summary>
		[DataMember(Name = "vlan", EmitDefaultValue = false)]
		public bool? Vlan { get; set; }



		/// <summary>
		/// Gets or Sets Team
		/// </summary>
		[DataMember(Name = "team", EmitDefaultValue = false)]
		public bool? Team { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DomainPhysicalCapabilities {\n");

			sb.Append("  Vlan: ").Append(Vlan).Append("\n");
			sb.Append("  Team: ").Append(Team).Append("\n");
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
			return this.Equals(obj as DomainPhysicalCapabilities);
		}

		/// <summary>
		/// Returns true if DomainPhysicalCapabilities instances are equal
		/// </summary>
		/// <param name="other">Instance of DomainPhysicalCapabilities to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DomainPhysicalCapabilities other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Vlan == other.Vlan ||
					this.Vlan != null &&
					this.Vlan.Equals(other.Vlan)
				) &&
				(
					this.Team == other.Team ||
					this.Team != null &&
					this.Team.Equals(other.Team)
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
				if (this.Vlan != null)
					hash = hash * 59 + this.Vlan.GetHashCode();

				if (this.Team != null)
					hash = hash * 59 + this.Team.GetHashCode();

				return hash;
			}
		}
	}

}
