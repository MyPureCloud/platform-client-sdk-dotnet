using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// GuideVersionResources
	/// </summary>
	[DataContract]
	public partial class GuideVersionResources : IEquatable<GuideVersionResources>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GuideVersionResources" /> class.
		/// </summary>
		/// <param name="DataActions">The data actions associated with this version of the guide..</param>
		public GuideVersionResources(List<DataAction> DataActions = null)
		{
			this.DataActions = DataActions;

		}



		/// <summary>
		/// The data actions associated with this version of the guide.
		/// </summary>
		/// <value>The data actions associated with this version of the guide.</value>
		[DataMember(Name = "dataActions", EmitDefaultValue = false)]
		public List<DataAction> DataActions { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GuideVersionResources {\n");

			sb.Append("  DataActions: ").Append(DataActions).Append("\n");
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
			return this.Equals(obj as GuideVersionResources);
		}

		/// <summary>
		/// Returns true if GuideVersionResources instances are equal
		/// </summary>
		/// <param name="other">Instance of GuideVersionResources to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GuideVersionResources other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.DataActions == other.DataActions ||
					this.DataActions != null &&
					this.DataActions.SequenceEqual(other.DataActions)
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
				if (this.DataActions != null)
					hash = hash * 59 + this.DataActions.GetHashCode();

				return hash;
			}
		}
	}

}
