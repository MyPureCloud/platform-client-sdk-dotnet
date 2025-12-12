using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A journey view
	/// </summary>
	[DataContract]
	public partial class JourneyView : IEquatable<JourneyView>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyView" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected JourneyView() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="JourneyView" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Description">A description of the journey view.</param>
		/// <param name="Interval">An absolute timeframe for the journey view, expressed as an ISO 8601 interval. Only one of interval or duration must be specified. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
		/// <param name="Duration">A relative timeframe for the journey view, expressed as an ISO 8601 duration. Only one of interval or duration must be specified. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
		/// <param name="Elements">The elements within the journey view (required).</param>
		/// <param name="Charts">A list of charts to measure within context of the elements of the the journey view.</param>
		public JourneyView(string Name = null, string Description = null, string Interval = null, string Duration = null, List<JourneyViewElement> Elements = null, List<JourneyViewChart> Charts = null)
		{
			this.Name = Name;
			this.Description = Description;
			this.Interval = Interval;
			this.Duration = Duration;
			this.Elements = Elements;
			this.Charts = Charts;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// A description of the journey view
		/// </summary>
		/// <value>A description of the journey view</value>
		[DataMember(Name = "description", EmitDefaultValue = false)]
		public string Description { get; set; }



		/// <summary>
		/// The version of the journey view
		/// </summary>
		/// <value>The version of the journey view</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? Version { get; private set; }



		/// <summary>
		/// User that has created the view.
		/// </summary>
		/// <value>User that has created the view.</value>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public JourneyViewUser CreatedBy { get; private set; }



		/// <summary>
		/// User that has modified the view.
		/// </summary>
		/// <value>User that has modified the view.</value>
		[DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
		public JourneyViewUser ModifiedBy { get; private set; }



		/// <summary>
		/// An absolute timeframe for the journey view, expressed as an ISO 8601 interval. Only one of interval or duration must be specified. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
		/// </summary>
		/// <value>An absolute timeframe for the journey view, expressed as an ISO 8601 interval. Only one of interval or duration must be specified. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }



		/// <summary>
		/// A relative timeframe for the journey view, expressed as an ISO 8601 duration. Only one of interval or duration must be specified. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
		/// </summary>
		/// <value>A relative timeframe for the journey view, expressed as an ISO 8601 duration. Only one of interval or duration must be specified. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
		[DataMember(Name = "duration", EmitDefaultValue = false)]
		public string Duration { get; set; }



		/// <summary>
		/// The elements within the journey view
		/// </summary>
		/// <value>The elements within the journey view</value>
		[DataMember(Name = "elements", EmitDefaultValue = false)]
		public List<JourneyViewElement> Elements { get; set; }



		/// <summary>
		/// A list of charts to measure within context of the elements of the the journey view
		/// </summary>
		/// <value>A list of charts to measure within context of the elements of the the journey view</value>
		[DataMember(Name = "charts", EmitDefaultValue = false)]
		public List<JourneyViewChart> Charts { get; set; }



		/// <summary>
		/// The date when the journey view was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date when the journey view was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateCreated", EmitDefaultValue = false)]
		public DateTime? DateCreated { get; private set; }



		/// <summary>
		/// The date when this version of the journey view was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
		/// </summary>
		/// <value>The date when this version of the journey view was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
		[DataMember(Name = "dateModified", EmitDefaultValue = false)]
		public DateTime? DateModified { get; private set; }



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
			sb.Append("class JourneyView {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
			sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  Duration: ").Append(Duration).Append("\n");
			sb.Append("  Elements: ").Append(Elements).Append("\n");
			sb.Append("  Charts: ").Append(Charts).Append("\n");
			sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
			sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
			return this.Equals(obj as JourneyView);
		}

		/// <summary>
		/// Returns true if JourneyView instances are equal
		/// </summary>
		/// <param name="other">Instance of JourneyView to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JourneyView other)
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
					this.Description == other.Description ||
					this.Description != null &&
					this.Description.Equals(other.Description)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.CreatedBy == other.CreatedBy ||
					this.CreatedBy != null &&
					this.CreatedBy.Equals(other.CreatedBy)
				) &&
				(
					this.ModifiedBy == other.ModifiedBy ||
					this.ModifiedBy != null &&
					this.ModifiedBy.Equals(other.ModifiedBy)
				) &&
				(
					this.Interval == other.Interval ||
					this.Interval != null &&
					this.Interval.Equals(other.Interval)
				) &&
				(
					this.Duration == other.Duration ||
					this.Duration != null &&
					this.Duration.Equals(other.Duration)
				) &&
				(
					this.Elements == other.Elements ||
					this.Elements != null &&
					this.Elements.SequenceEqual(other.Elements)
				) &&
				(
					this.Charts == other.Charts ||
					this.Charts != null &&
					this.Charts.SequenceEqual(other.Charts)
				) &&
				(
					this.DateCreated == other.DateCreated ||
					this.DateCreated != null &&
					this.DateCreated.Equals(other.DateCreated)
				) &&
				(
					this.DateModified == other.DateModified ||
					this.DateModified != null &&
					this.DateModified.Equals(other.DateModified)
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

				if (this.Description != null)
					hash = hash * 59 + this.Description.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.CreatedBy != null)
					hash = hash * 59 + this.CreatedBy.GetHashCode();

				if (this.ModifiedBy != null)
					hash = hash * 59 + this.ModifiedBy.GetHashCode();

				if (this.Interval != null)
					hash = hash * 59 + this.Interval.GetHashCode();

				if (this.Duration != null)
					hash = hash * 59 + this.Duration.GetHashCode();

				if (this.Elements != null)
					hash = hash * 59 + this.Elements.GetHashCode();

				if (this.Charts != null)
					hash = hash * 59 + this.Charts.GetHashCode();

				if (this.DateCreated != null)
					hash = hash * 59 + this.DateCreated.GetHashCode();

				if (this.DateModified != null)
					hash = hash * 59 + this.DateModified.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
