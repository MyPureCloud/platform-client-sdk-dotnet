using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// RecordingFormPageComponent
	/// </summary>
	[DataContract]
	public partial class RecordingFormPageComponent : IEquatable<RecordingFormPageComponent>
	{
		/// <summary>
		/// Type of this form component element.
		/// </summary>
		/// <value>Type of this form component element.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum FormComponentTypeEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Listpicker for "ListPicker"
			/// </summary>
			[EnumMember(Value = "ListPicker")]
			Listpicker,

			/// <summary>
			/// Enum Datepicker for "DatePicker"
			/// </summary>
			[EnumMember(Value = "DatePicker")]
			Datepicker,

			/// <summary>
			/// Enum Wheelpicker for "WheelPicker"
			/// </summary>
			[EnumMember(Value = "WheelPicker")]
			Wheelpicker,

			/// <summary>
			/// Enum Input for "Input"
			/// </summary>
			[EnumMember(Value = "Input")]
			Input
		}
		/// <summary>
		/// Type of this form component element.
		/// </summary>
		/// <value>Type of this form component element.</value>
		[DataMember(Name = "formComponentType", EmitDefaultValue = false)]
		public FormComponentTypeEnum? FormComponentType { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="RecordingFormPageComponent" /> class.
		/// </summary>
		/// <param name="FormComponentType">Type of this form component element..</param>
		/// <param name="DatePicker">Date Picker content..</param>
		/// <param name="WheelPicker">Wheel Picker content..</param>
		/// <param name="ListPicker">List Picker content..</param>
		/// <param name="Input">Input content..</param>
		public RecordingFormPageComponent(FormComponentTypeEnum? FormComponentType = null, DatePicker DatePicker = null, RecordingWheelPicker WheelPicker = null, ListPicker ListPicker = null, RecordingInput Input = null)
		{
			this.FormComponentType = FormComponentType;
			this.DatePicker = DatePicker;
			this.WheelPicker = WheelPicker;
			this.ListPicker = ListPicker;
			this.Input = Input;

		}





		/// <summary>
		/// Date Picker content.
		/// </summary>
		/// <value>Date Picker content.</value>
		[DataMember(Name = "datePicker", EmitDefaultValue = false)]
		public DatePicker DatePicker { get; set; }



		/// <summary>
		/// Wheel Picker content.
		/// </summary>
		/// <value>Wheel Picker content.</value>
		[DataMember(Name = "wheelPicker", EmitDefaultValue = false)]
		public RecordingWheelPicker WheelPicker { get; set; }



		/// <summary>
		/// List Picker content.
		/// </summary>
		/// <value>List Picker content.</value>
		[DataMember(Name = "listPicker", EmitDefaultValue = false)]
		public ListPicker ListPicker { get; set; }



		/// <summary>
		/// Input content.
		/// </summary>
		/// <value>Input content.</value>
		[DataMember(Name = "input", EmitDefaultValue = false)]
		public RecordingInput Input { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class RecordingFormPageComponent {\n");

			sb.Append("  FormComponentType: ").Append(FormComponentType).Append("\n");
			sb.Append("  DatePicker: ").Append(DatePicker).Append("\n");
			sb.Append("  WheelPicker: ").Append(WheelPicker).Append("\n");
			sb.Append("  ListPicker: ").Append(ListPicker).Append("\n");
			sb.Append("  Input: ").Append(Input).Append("\n");
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
			return this.Equals(obj as RecordingFormPageComponent);
		}

		/// <summary>
		/// Returns true if RecordingFormPageComponent instances are equal
		/// </summary>
		/// <param name="other">Instance of RecordingFormPageComponent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RecordingFormPageComponent other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return true &&
				(
					this.FormComponentType == other.FormComponentType ||
					this.FormComponentType != null &&
					this.FormComponentType.Equals(other.FormComponentType)
				) &&
				(
					this.DatePicker == other.DatePicker ||
					this.DatePicker != null &&
					this.DatePicker.Equals(other.DatePicker)
				) &&
				(
					this.WheelPicker == other.WheelPicker ||
					this.WheelPicker != null &&
					this.WheelPicker.Equals(other.WheelPicker)
				) &&
				(
					this.ListPicker == other.ListPicker ||
					this.ListPicker != null &&
					this.ListPicker.Equals(other.ListPicker)
				) &&
				(
					this.Input == other.Input ||
					this.Input != null &&
					this.Input.Equals(other.Input)
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
				if (this.FormComponentType != null)
					hash = hash * 59 + this.FormComponentType.GetHashCode();

				if (this.DatePicker != null)
					hash = hash * 59 + this.DatePicker.GetHashCode();

				if (this.WheelPicker != null)
					hash = hash * 59 + this.WheelPicker.GetHashCode();

				if (this.ListPicker != null)
					hash = hash * 59 + this.ListPicker.GetHashCode();

				if (this.Input != null)
					hash = hash * 59 + this.Input.GetHashCode();

				return hash;
			}
		}
	}

}
