using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// DocumentBodyTableRowBlockProperties
	/// </summary>
	[DataContract]
	public partial class DocumentBodyTableRowBlockProperties : IEquatable<DocumentBodyTableRowBlockProperties>
	{
		/// <summary>
		/// The type of the table row.
		/// </summary>
		/// <value>The type of the table row.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum RowTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Header for "Header"
			/// </summary>
			[EnumMember(Value = "Header")]
			Header,

			/// <summary>
			/// Enum Footer for "Footer"
			/// </summary>
			[EnumMember(Value = "Footer")]
			Footer,

			/// <summary>
			/// Enum Body for "Body"
			/// </summary>
			[EnumMember(Value = "Body")]
			Body
		}
		/// <summary>
		/// The alignment for the table row.
		/// </summary>
		/// <value>The alignment for the table row.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum AlignmentEnum
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
			Right
		}
		/// <summary>
		/// The border style for the table row.
		/// </summary>
		/// <value>The border style for the table row.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum BorderStyleEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Solid for "Solid"
			/// </summary>
			[EnumMember(Value = "Solid")]
			Solid,

			/// <summary>
			/// Enum Dotted for "Dotted"
			/// </summary>
			[EnumMember(Value = "Dotted")]
			Dotted,

			/// <summary>
			/// Enum Dashed for "Dashed"
			/// </summary>
			[EnumMember(Value = "Dashed")]
			Dashed,

			/// <summary>
			/// Enum Double for "Double"
			/// </summary>
			[EnumMember(Value = "Double")]
			Double,

			/// <summary>
			/// Enum Groove for "Groove"
			/// </summary>
			[EnumMember(Value = "Groove")]
			Groove,

			/// <summary>
			/// Enum Ridge for "Ridge"
			/// </summary>
			[EnumMember(Value = "Ridge")]
			Ridge,

			/// <summary>
			/// Enum Inset for "Inset"
			/// </summary>
			[EnumMember(Value = "Inset")]
			Inset,

			/// <summary>
			/// Enum Outset for "Outset"
			/// </summary>
			[EnumMember(Value = "Outset")]
			Outset,

			/// <summary>
			/// Enum Hidden for "Hidden"
			/// </summary>
			[EnumMember(Value = "Hidden")]
			Hidden,

			/// <summary>
			/// Enum None for "None"
			/// </summary>
			[EnumMember(Value = "None")]
			None
		}
		/// <summary>
		/// The type of the table row.
		/// </summary>
		/// <value>The type of the table row.</value>
		[DataMember(Name = "rowType", EmitDefaultValue = false)]
		public RowTypeEnum? RowType { get; set; }
		/// <summary>
		/// The alignment for the table row.
		/// </summary>
		/// <value>The alignment for the table row.</value>
		[DataMember(Name = "alignment", EmitDefaultValue = false)]
		public AlignmentEnum? Alignment { get; set; }
		/// <summary>
		/// The border style for the table row.
		/// </summary>
		/// <value>The border style for the table row.</value>
		[DataMember(Name = "borderStyle", EmitDefaultValue = false)]
		public BorderStyleEnum? BorderStyle { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="DocumentBodyTableRowBlockProperties" /> class.
		/// </summary>
		/// <param name="RowType">The type of the table row..</param>
		/// <param name="Alignment">The alignment for the table row..</param>
		/// <param name="Height">The height for the table row..</param>
		/// <param name="BorderStyle">The border style for the table row..</param>
		/// <param name="BorderColor">The border color for the table row. For example black color - #000000.</param>
		/// <param name="BackgroundColor">The background color for the table row. For example black color - #000000.</param>
		public DocumentBodyTableRowBlockProperties(RowTypeEnum? RowType = null, AlignmentEnum? Alignment = null, float? Height = null, BorderStyleEnum? BorderStyle = null, string BorderColor = null, string BackgroundColor = null)
		{
			this.RowType = RowType;
			this.Alignment = Alignment;
			this.Height = Height;
			this.BorderStyle = BorderStyle;
			this.BorderColor = BorderColor;
			this.BackgroundColor = BackgroundColor;

		}







		/// <summary>
		/// The height for the table row.
		/// </summary>
		/// <value>The height for the table row.</value>
		[DataMember(Name = "height", EmitDefaultValue = false)]
		public float? Height { get; set; }





		/// <summary>
		/// The border color for the table row. For example black color - #000000
		/// </summary>
		/// <value>The border color for the table row. For example black color - #000000</value>
		[DataMember(Name = "borderColor", EmitDefaultValue = false)]
		public string BorderColor { get; set; }



		/// <summary>
		/// The background color for the table row. For example black color - #000000
		/// </summary>
		/// <value>The background color for the table row. For example black color - #000000</value>
		[DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
		public string BackgroundColor { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DocumentBodyTableRowBlockProperties {\n");

			sb.Append("  RowType: ").Append(RowType).Append("\n");
			sb.Append("  Alignment: ").Append(Alignment).Append("\n");
			sb.Append("  Height: ").Append(Height).Append("\n");
			sb.Append("  BorderStyle: ").Append(BorderStyle).Append("\n");
			sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
			sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
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
			return this.Equals(obj as DocumentBodyTableRowBlockProperties);
		}

		/// <summary>
		/// Returns true if DocumentBodyTableRowBlockProperties instances are equal
		/// </summary>
		/// <param name="other">Instance of DocumentBodyTableRowBlockProperties to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DocumentBodyTableRowBlockProperties other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.RowType == other.RowType ||
					this.RowType != null &&
					this.RowType.Equals(other.RowType)
				) &&
				(
					this.Alignment == other.Alignment ||
					this.Alignment != null &&
					this.Alignment.Equals(other.Alignment)
				) &&
				(
					this.Height == other.Height ||
					this.Height != null &&
					this.Height.Equals(other.Height)
				) &&
				(
					this.BorderStyle == other.BorderStyle ||
					this.BorderStyle != null &&
					this.BorderStyle.Equals(other.BorderStyle)
				) &&
				(
					this.BorderColor == other.BorderColor ||
					this.BorderColor != null &&
					this.BorderColor.Equals(other.BorderColor)
				) &&
				(
					this.BackgroundColor == other.BackgroundColor ||
					this.BackgroundColor != null &&
					this.BackgroundColor.Equals(other.BackgroundColor)
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
				if (this.RowType != null)
					hash = hash * 59 + this.RowType.GetHashCode();

				if (this.Alignment != null)
					hash = hash * 59 + this.Alignment.GetHashCode();

				if (this.Height != null)
					hash = hash * 59 + this.Height.GetHashCode();

				if (this.BorderStyle != null)
					hash = hash * 59 + this.BorderStyle.GetHashCode();

				if (this.BorderColor != null)
					hash = hash * 59 + this.BorderColor.GetHashCode();

				if (this.BackgroundColor != null)
					hash = hash * 59 + this.BackgroundColor.GetHashCode();

				return hash;
			}
		}
	}

}
