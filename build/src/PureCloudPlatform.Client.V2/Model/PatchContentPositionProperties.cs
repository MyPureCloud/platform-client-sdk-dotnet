using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// PatchContentPositionProperties
	/// </summary>
	[DataContract]
	public partial class PatchContentPositionProperties : IEquatable<PatchContentPositionProperties>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PatchContentPositionProperties" /> class.
		/// </summary>
		/// <param name="Top">Top positioning offset..</param>
		/// <param name="Bottom">Bottom positioning offset..</param>
		/// <param name="Left">Left positioning offset..</param>
		/// <param name="Right">Right positioning offset..</param>
		public PatchContentPositionProperties(string Top = null, string Bottom = null, string Left = null, string Right = null)
		{
			this.Top = Top;
			this.Bottom = Bottom;
			this.Left = Left;
			this.Right = Right;

		}



		/// <summary>
		/// Top positioning offset.
		/// </summary>
		/// <value>Top positioning offset.</value>
		[DataMember(Name = "top", EmitDefaultValue = false)]
		public string Top { get; set; }



		/// <summary>
		/// Bottom positioning offset.
		/// </summary>
		/// <value>Bottom positioning offset.</value>
		[DataMember(Name = "bottom", EmitDefaultValue = false)]
		public string Bottom { get; set; }



		/// <summary>
		/// Left positioning offset.
		/// </summary>
		/// <value>Left positioning offset.</value>
		[DataMember(Name = "left", EmitDefaultValue = false)]
		public string Left { get; set; }



		/// <summary>
		/// Right positioning offset.
		/// </summary>
		/// <value>Right positioning offset.</value>
		[DataMember(Name = "right", EmitDefaultValue = false)]
		public string Right { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PatchContentPositionProperties {\n");

			sb.Append("  Top: ").Append(Top).Append("\n");
			sb.Append("  Bottom: ").Append(Bottom).Append("\n");
			sb.Append("  Left: ").Append(Left).Append("\n");
			sb.Append("  Right: ").Append(Right).Append("\n");
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
			return this.Equals(obj as PatchContentPositionProperties);
		}

		/// <summary>
		/// Returns true if PatchContentPositionProperties instances are equal
		/// </summary>
		/// <param name="other">Instance of PatchContentPositionProperties to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PatchContentPositionProperties other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.Top == other.Top ||
					this.Top != null &&
					this.Top.Equals(other.Top)
				) &&
				(
					this.Bottom == other.Bottom ||
					this.Bottom != null &&
					this.Bottom.Equals(other.Bottom)
				) &&
				(
					this.Left == other.Left ||
					this.Left != null &&
					this.Left.Equals(other.Left)
				) &&
				(
					this.Right == other.Right ||
					this.Right != null &&
					this.Right.Equals(other.Right)
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
				if (this.Top != null)
					hash = hash * 59 + this.Top.GetHashCode();

				if (this.Bottom != null)
					hash = hash * 59 + this.Bottom.GetHashCode();

				if (this.Left != null)
					hash = hash * 59 + this.Left.GetHashCode();

				if (this.Right != null)
					hash = hash * 59 + this.Right.GetHashCode();

				return hash;
			}
		}
	}

}
