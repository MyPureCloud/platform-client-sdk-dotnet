using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DocumentBodyImageProperties
	/// </summary>
	[DataContract]
	public partial class DocumentBodyImageProperties : IEquatable<DocumentBodyImageProperties>
	{
		/// <summary>
		/// The align property for the image.
		/// </summary>
		/// <value>The align property for the image.</value>
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
		/// The align property for the image.
		/// </summary>
		/// <value>The align property for the image.</value>
		[DataMember(Name = "align", EmitDefaultValue = false)]
		public AlignEnum? Align { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentBodyImageProperties" /> class.
		/// </summary>
		/// <param name="BackgroundColor">The background color property for the image. The valid values in hex color code representation. For example black color - #000000.</param>
		/// <param name="Align">The align property for the image..</param>
		/// <param name="Indentation">The indentation property for the image. The valid values in &#39;em&#39;..</param>
		/// <param name="Width">The width of the image converted to em unit..</param>
		/// <param name="WidthWithUnit">The width of the image in the specified unit..</param>
		/// <param name="AltText">Alternate text for the image for accessibility and when the image can&#39;t be loaded..</param>
		public DocumentBodyImageProperties(string BackgroundColor = null, AlignEnum? Align = null, float? Indentation = null, float? Width = null, DocumentElementLength WidthWithUnit = null, string AltText = null)
		{
			this.BackgroundColor = BackgroundColor;
			this.Align = Align;
			this.Indentation = Indentation;
			this.Width = Width;
			this.WidthWithUnit = WidthWithUnit;
			this.AltText = AltText;

		}



		/// <summary>
		/// The background color property for the image. The valid values in hex color code representation. For example black color - #000000
		/// </summary>
		/// <value>The background color property for the image. The valid values in hex color code representation. For example black color - #000000</value>
		[DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
		public string BackgroundColor { get; set; }





		/// <summary>
		/// The indentation property for the image. The valid values in &#39;em&#39;.
		/// </summary>
		/// <value>The indentation property for the image. The valid values in &#39;em&#39;.</value>
		[DataMember(Name = "indentation", EmitDefaultValue = false)]
		public float? Indentation { get; set; }



		/// <summary>
		/// The width of the image converted to em unit.
		/// </summary>
		/// <value>The width of the image converted to em unit.</value>
		[DataMember(Name = "width", EmitDefaultValue = false)]
		public float? Width { get; set; }



		/// <summary>
		/// The width of the image in the specified unit.
		/// </summary>
		/// <value>The width of the image in the specified unit.</value>
		[DataMember(Name = "widthWithUnit", EmitDefaultValue = false)]
		public DocumentElementLength WidthWithUnit { get; set; }



		/// <summary>
		/// Alternate text for the image for accessibility and when the image can&#39;t be loaded.
		/// </summary>
		/// <value>Alternate text for the image for accessibility and when the image can&#39;t be loaded.</value>
		[DataMember(Name = "altText", EmitDefaultValue = false)]
		public string AltText { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentBodyImageProperties {\n");

			sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
			sb.Append("  Align: ").Append(Align).Append("\n");
			sb.Append("  Indentation: ").Append(Indentation).Append("\n");
			sb.Append("  Width: ").Append(Width).Append("\n");
			sb.Append("  WidthWithUnit: ").Append(WidthWithUnit).Append("\n");
			sb.Append("  AltText: ").Append(AltText).Append("\n");
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
			return this.Equals(obj as DocumentBodyImageProperties);
		}

		/// <summary>
		/// Returns true if DocumentBodyImageProperties instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentBodyImageProperties to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentBodyImageProperties other)
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
					this.WidthWithUnit == other.WidthWithUnit ||
					this.WidthWithUnit != null &&
					this.WidthWithUnit.Equals(other.WidthWithUnit)
				) &&
				(
					this.AltText == other.AltText ||
					this.AltText != null &&
					this.AltText.Equals(other.AltText)
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

				if (this.WidthWithUnit != null)
					hash = hash * 59 + this.WidthWithUnit.GetHashCode();

				if (this.AltText != null)
					hash = hash * 59 + this.AltText.GetHashCode();

				return hash;
			}
		}
	}

}
