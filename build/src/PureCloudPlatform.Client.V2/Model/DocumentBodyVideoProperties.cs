using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DocumentBodyVideoProperties
	/// </summary>
	[DataContract]
	public partial class DocumentBodyVideoProperties : IEquatable<DocumentBodyVideoProperties>
	{
		/// <summary>
		/// The align type for the video.
		/// </summary>
		/// <value>The align type for the video.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AlignEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Center for "Center"
			/// </summary>
			[EnumMember(Value = "Center")]
			Center,

			/// <summary>
			/// Enum Left for "Left"
			/// </summary>
			[EnumMember(Value = "Left")]
			Left,

			/// <summary>
			/// Enum Right for "Right"
			/// </summary>
			[EnumMember(Value = "Right")]
			Right,

			/// <summary>
			/// Enum Justify for "Justify"
			/// </summary>
			[EnumMember(Value = "Justify")]
			Justify
		}
		/// <summary>
		/// The align type for the video.
		/// </summary>
		/// <value>The align type for the video.</value>
		[DataMember(Name = "align", EmitDefaultValue = false)]
		public AlignEnum? Align { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentBodyVideoProperties" /> class.
		/// </summary>
		/// <param name="BackgroundColor">The background color for the video. The valid values in hex color code representation. For example black color - #000000.</param>
		/// <param name="Align">The align type for the video..</param>
		/// <param name="Indentation">The indentation for the video. The valid values in &#39;em&#39;..</param>
		/// <param name="Width">The width of the video in the specified unit..</param>
		/// <param name="Height">The height of the video in the specified unit..</param>
		public DocumentBodyVideoProperties(string BackgroundColor = null, AlignEnum? Align = null, float? Indentation = null, DocumentElementLength Width = null, DocumentElementLength Height = null)
		{
			this.BackgroundColor = BackgroundColor;
			this.Align = Align;
			this.Indentation = Indentation;
			this.Width = Width;
			this.Height = Height;

		}



		/// <summary>
		/// The background color for the video. The valid values in hex color code representation. For example black color - #000000
		/// </summary>
		/// <value>The background color for the video. The valid values in hex color code representation. For example black color - #000000</value>
		[DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
		public string BackgroundColor { get; set; }





		/// <summary>
		/// The indentation for the video. The valid values in &#39;em&#39;.
		/// </summary>
		/// <value>The indentation for the video. The valid values in &#39;em&#39;.</value>
		[DataMember(Name = "indentation", EmitDefaultValue = false)]
		public float? Indentation { get; set; }



		/// <summary>
		/// The width of the video in the specified unit.
		/// </summary>
		/// <value>The width of the video in the specified unit.</value>
		[DataMember(Name = "width", EmitDefaultValue = false)]
		public DocumentElementLength Width { get; set; }



		/// <summary>
		/// The height of the video in the specified unit.
		/// </summary>
		/// <value>The height of the video in the specified unit.</value>
		[DataMember(Name = "height", EmitDefaultValue = false)]
		public DocumentElementLength Height { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentBodyVideoProperties {\n");

			sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
			sb.Append("  Align: ").Append(Align).Append("\n");
			sb.Append("  Indentation: ").Append(Indentation).Append("\n");
			sb.Append("  Width: ").Append(Width).Append("\n");
			sb.Append("  Height: ").Append(Height).Append("\n");
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
			return this.Equals(obj as DocumentBodyVideoProperties);
		}

		/// <summary>
		/// Returns true if DocumentBodyVideoProperties instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentBodyVideoProperties to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentBodyVideoProperties other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.BackgroundColor == other.BackgroundColor ||
					this.BackgroundColor != null &&
					this.BackgroundColor.Equals(other.BackgroundColor)
				) &&
				(
					this.Align == other.Align ||
					this.Align != null &&
					this.Align.Equals(other.Align)
				) &&
				(
					this.Indentation == other.Indentation ||
					this.Indentation != null &&
					this.Indentation.Equals(other.Indentation)
				) &&
				(
					this.Width == other.Width ||
					this.Width != null &&
					this.Width.Equals(other.Width)
				) &&
				(
					this.Height == other.Height ||
					this.Height != null &&
					this.Height.Equals(other.Height)
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
				if (this.BackgroundColor != null)
					hash = hash * 59 + this.BackgroundColor.GetHashCode();

				if (this.Align != null)
					hash = hash * 59 + this.Align.GetHashCode();

				if (this.Indentation != null)
					hash = hash * 59 + this.Indentation.GetHashCode();

				if (this.Width != null)
					hash = hash * 59 + this.Width.GetHashCode();

				if (this.Height != null)
					hash = hash * 59 + this.Height.GetHashCode();

				return hash;
			}
		}
	}

}
