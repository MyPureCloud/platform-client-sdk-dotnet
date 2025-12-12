using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// ServiceNowSourceRequest
	/// </summary>
	[DataContract]
	public partial class ServiceNowSourceRequest : IEquatable<ServiceNowSourceRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceNowSourceRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ServiceNowSourceRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceNowSourceRequest" /> class.
		/// </summary>
		/// <param name="Name">The name of the integration source. (required).</param>
		/// <param name="IntegrationId">The integration associated with the source..</param>
		/// <param name="SchedulePeriod">The schedule period of the source in hours. Must be at least 6 and at most 48 hours..</param>
		/// <param name="Settings">The settings of the source..</param>
		public ServiceNowSourceRequest(string Name = null, string IntegrationId = null, int? SchedulePeriod = null, ServiceNowSettings Settings = null)
		{
			this.Name = Name;
			this.IntegrationId = IntegrationId;
			this.SchedulePeriod = SchedulePeriod;
			this.Settings = Settings;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// The name of the integration source.
		/// </summary>
		/// <value>The name of the integration source.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// The integration associated with the source.
		/// </summary>
		/// <value>The integration associated with the source.</value>
		[DataMember(Name = "integrationId", EmitDefaultValue = false)]
		public string IntegrationId { get; set; }



		/// <summary>
		/// The schedule period of the source in hours. Must be at least 6 and at most 48 hours.
		/// </summary>
		/// <value>The schedule period of the source in hours. Must be at least 6 and at most 48 hours.</value>
		[DataMember(Name = "schedulePeriod", EmitDefaultValue = false)]
		public int? SchedulePeriod { get; set; }



		/// <summary>
		/// The settings of the source.
		/// </summary>
		/// <value>The settings of the source.</value>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public ServiceNowSettings Settings { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ServiceNowSourceRequest {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
			sb.Append("  SchedulePeriod: ").Append(SchedulePeriod).Append("\n");
			sb.Append("  Settings: ").Append(Settings).Append("\n");
			sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
			return this.Equals(obj as ServiceNowSourceRequest);
		}

		/// <summary>
		/// Returns true if ServiceNowSourceRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of ServiceNowSourceRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ServiceNowSourceRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Id == other.Id ||
					this.Id != null &&
					this.Id.Equals(other.Id)
				) &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.IntegrationId == other.IntegrationId ||
					this.IntegrationId != null &&
					this.IntegrationId.Equals(other.IntegrationId)
				) &&
				(
					this.SchedulePeriod == other.SchedulePeriod ||
					this.SchedulePeriod != null &&
					this.SchedulePeriod.Equals(other.SchedulePeriod)
				) &&
				(
					this.Settings == other.Settings ||
					this.Settings != null &&
					this.Settings.Equals(other.Settings)
				) &&
				(
					this.SelfUri == other.SelfUri ||
					this.SelfUri != null &&
					this.SelfUri.Equals(other.SelfUri)
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
				if (this.Id != null)
					hash = hash * 59 + this.Id.GetHashCode();

				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.IntegrationId != null)
					hash = hash * 59 + this.IntegrationId.GetHashCode();

				if (this.SchedulePeriod != null)
					hash = hash * 59 + this.SchedulePeriod.GetHashCode();

				if (this.Settings != null)
					hash = hash * 59 + this.Settings.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
