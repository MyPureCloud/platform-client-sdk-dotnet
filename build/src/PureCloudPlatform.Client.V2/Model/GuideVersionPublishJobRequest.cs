using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// Request body for publishing a guide version
	/// </summary>
	[DataContract]
	public partial class GuideVersionPublishJobRequest : IEquatable<GuideVersionPublishJobRequest>
	{

		/// <summary>
		/// Initializes a new instance of the <see cref="GuideVersionPublishJobRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected GuideVersionPublishJobRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="GuideVersionPublishJobRequest" /> class.
		/// </summary>
		/// <param name="GuideVersion">The attributes of the guide version to update as part of this publish job. (required).</param>
		public GuideVersionPublishJobRequest(GuideVersionPublish GuideVersion = null)
		{
			this.GuideVersion = GuideVersion;

		}



		/// <summary>
		/// The attributes of the guide version to update as part of this publish job.
		/// </summary>
		/// <value>The attributes of the guide version to update as part of this publish job.</value>
		[DataMember(Name = "guideVersion", EmitDefaultValue = false)]
		public GuideVersionPublish GuideVersion { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class GuideVersionPublishJobRequest {\n");

			sb.Append("  GuideVersion: ").Append(GuideVersion).Append("\n");
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
			return this.Equals(obj as GuideVersionPublishJobRequest);
		}

		/// <summary>
		/// Returns true if GuideVersionPublishJobRequest instances are equal
		/// </summary>
		/// <param name="other">Instance of GuideVersionPublishJobRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(GuideVersionPublishJobRequest other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.GuideVersion == other.GuideVersion ||
					this.GuideVersion != null &&
					this.GuideVersion.Equals(other.GuideVersion)
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
				if (this.GuideVersion != null)
					hash = hash * 59 + this.GuideVersion.GetHashCode();

				return hash;
			}
		}
	}

}
