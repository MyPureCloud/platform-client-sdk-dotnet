using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// EventQueryRequest
	/// </summary>
	[DataContract]
	public partial class EventQueryRequest : IEquatable<EventQueryRequest>
	{
		/// <summary>
		/// Order of results. Default order is DESC.
		/// </summary>
		/// <value>Order of results. Default order is DESC.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum SortOrderEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Asc for "ASC"
			/// </summary>
			[EnumMember(Value = "ASC")]
			Asc,

			/// <summary>
			/// Enum Desc for "DESC"
			/// </summary>
			[EnumMember(Value = "DESC")]
			Desc
		}
		/// <summary>
		/// Order of results. Default order is DESC.
		/// </summary>
		/// <value>Order of results. Default order is DESC.</value>
		[DataMember(Name = "sortOrder", EmitDefaultValue = false)]
		public SortOrderEnum? SortOrder { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="EventQueryRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected EventQueryRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="EventQueryRequest" /> class.
		/// </summary>
		/// <param name="Interval">Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
		/// <param name="EventDefinitionIds">Filter events by a list of event definition ids.</param>
		/// <param name="SearchTerm">Only return events that contain the search term.</param>
		/// <param name="SortOrder">Order of results. Default order is DESC..</param>
		public EventQueryRequest(string Interval = null, List<string> EventDefinitionIds = null, string SearchTerm = null, SortOrderEnum? SortOrder = null)
		{
			this.Interval = Interval;
			this.EventDefinitionIds = EventDefinitionIds;
			this.SearchTerm = SearchTerm;
			this.SortOrder = SortOrder;

		}



		/// <summary>
		/// Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
		/// </summary>
		/// <value>Date and time range to query. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
		[DataMember(Name = "interval", EmitDefaultValue = false)]
		public string Interval { get; set; }



		/// <summary>
		/// Filter events by a list of event definition ids
		/// </summary>
		/// <value>Filter events by a list of event definition ids</value>
		[DataMember(Name = "eventDefinitionIds", EmitDefaultValue = false)]
		public List<string> EventDefinitionIds { get; set; }



		/// <summary>
		/// Only return events that contain the search term
		/// </summary>
		/// <value>Only return events that contain the search term</value>
		[DataMember(Name = "searchTerm", EmitDefaultValue = false)]
		public string SearchTerm { get; set; }




		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EventQueryRequest {\n");

			sb.Append("  Interval: ").Append(Interval).Append("\n");
			sb.Append("  EventDefinitionIds: ").Append(EventDefinitionIds).Append("\n");
			sb.Append("  SearchTerm: ").Append(SearchTerm).Append("\n");
			sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
			return this.Equals(obj as EventQueryRequest);
		}

		/// <summary>
		/// Returns true if EventQueryRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of EventQueryRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EventQueryRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Interval == other.Interval ||
					this.Interval != null &&
					this.Interval.Equals(other.Interval)
				) &&
				(
					this.EventDefinitionIds == other.EventDefinitionIds ||
					this.EventDefinitionIds != null &&
					this.EventDefinitionIds.SequenceEqual(other.EventDefinitionIds)
				) &&
				(
					this.SearchTerm == other.SearchTerm ||
					this.SearchTerm != null &&
					this.SearchTerm.Equals(other.SearchTerm)
				) &&
				(
					this.SortOrder == other.SortOrder ||
					this.SortOrder != null &&
					this.SortOrder.Equals(other.SortOrder)
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
				if (this.Interval != null)
					hash = hash * 59 + this.Interval.GetHashCode();

				if (this.EventDefinitionIds != null)
					hash = hash * 59 + this.EventDefinitionIds.GetHashCode();

				if (this.SearchTerm != null)
					hash = hash * 59 + this.SearchTerm.GetHashCode();

				if (this.SortOrder != null)
					hash = hash * 59 + this.SortOrder.GetHashCode();

				return hash;
			}
		}
	}

}
