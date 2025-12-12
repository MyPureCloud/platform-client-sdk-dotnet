using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// WorktypeQuerySort
	/// </summary>
	[DataContract]
	public partial class WorktypeQuerySort : IEquatable<WorktypeQuerySort>
	{
		/// <summary>
		/// Specify an attribute for sorting. It's possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can't be present in more than one filter.
		/// </summary>
		/// <value>Specify an attribute for sorting. It's possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can't be present in more than one filter.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum NameEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Datemodified for "dateModified"
			/// </summary>
			[EnumMember(Value = "dateModified")]
			Datemodified,

			/// <summary>
			/// Enum Name for "name"
			/// </summary>
			[EnumMember(Value = "name")]
			Name
		}
		/// <summary>
		/// Specify an attribute for sorting. It's possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can't be present in more than one filter.
		/// </summary>
		/// <value>Specify an attribute for sorting. It's possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can't be present in more than one filter.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public NameEnum? Name { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="WorktypeQuerySort" /> class.
		/// </summary>
		/// <param name="Name">Specify an attribute for sorting. It&#39;s possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can&#39;t be present in more than one filter..</param>
		/// <param name="Ascending">Sort Ascending.</param>
		public WorktypeQuerySort(NameEnum? Name = null, bool? Ascending = null)
		{
			this.Name = Name;
			this.Ascending = Ascending;

		}





		/// <summary>
		/// Sort Ascending
		/// </summary>
		/// <value>Sort Ascending</value>
		[DataMember(Name = "ascending", EmitDefaultValue = false)]
		public bool? Ascending { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class WorktypeQuerySort {\n");

			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Ascending: ").Append(Ascending).Append("\n");
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
			return this.Equals(obj as WorktypeQuerySort);
		}

		/// <summary>
		/// Returns true if WorktypeQuerySort instances are equal
		/// </summary>
		/// <param name="other">Instance of WorktypeQuerySort to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(WorktypeQuerySort other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name)
				) &&
				(
					this.Ascending == other.Ascending ||
					this.Ascending != null &&
					this.Ascending.Equals(other.Ascending)
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
				if (this.Name != null)
					hash = hash * 59 + this.Name.GetHashCode();

				if (this.Ascending != null)
					hash = hash * 59 + this.Ascending.GetHashCode();

				return hash;
			}
		}
	}

}
