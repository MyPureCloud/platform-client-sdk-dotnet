using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Used to retrieve executionData based upon certain criteria
	/// </summary>
	[DataContract]
	public partial class CriteriaQuery : IEquatable<CriteriaQuery>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="CriteriaQuery" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CriteriaQuery() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CriteriaQuery" /> class.
		/// </summary>
		/// <param name="Query">A list of CriteriaGroups which will be AND&#39;d together to generate a result set. (required).</param>
		public CriteriaQuery(List<CriteriaGroup> Query = null)
		{
			this.Query = Query;

		}



		/// <summary>
		/// A list of CriteriaGroups which will be AND&#39;d together to generate a result set.
		/// </summary>
		/// <value>A list of CriteriaGroups which will be AND&#39;d together to generate a result set.</value>
		[DataMember(Name = "query", EmitDefaultValue = false)]
		public List<CriteriaGroup> Query { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CriteriaQuery {\n");

			sb.Append("  Query: ").Append(Query).Append("\n");
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
			return this.Equals(obj as CriteriaQuery);
		}

		/// <summary>
		/// Returns true if CriteriaQuery instances are equal
		/// </summary>
		/// <param name="other">Instance of CriteriaQuery to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CriteriaQuery other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Query == other.Query ||
					this.Query != null &&
					this.Query.SequenceEqual(other.Query)
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
				if (this.Query != null)
					hash = hash * 59 + this.Query.GetHashCode();

				return hash;
			}
		}
	}

}
