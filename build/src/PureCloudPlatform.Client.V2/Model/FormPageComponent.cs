using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// A component within a form page
	/// </summary>
	[DataContract]
	public partial class FormPageComponent : IEquatable<FormPageComponent>
	{
		/// <summary>
		/// Type of the component
		/// </summary>
		/// <value>Type of the component</value>
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
			/// Enum Input for "Input"
			/// </summary>
			[EnumMember(Value = "Input")]
			Input,

			/// <summary>
			/// Enum Wheelpicker for "WheelPicker"
			/// </summary>
			[EnumMember(Value = "WheelPicker")]
			Wheelpicker
		}
		/// <summary>
		/// Type of the component
		/// </summary>
		/// <value>Type of the component</value>
		[DataMember(Name = "formComponentType", EmitDefaultValue = false)]
		public FormComponentTypeEnum? FormComponentType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="FormPageComponent" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected FormPageComponent() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="FormPageComponent" /> class.
		/// </summary>
		/// <param name="FormComponentType">Type of the component (required).</param>
		/// <param name="ListPicker">List picker configuration.</param>
		/// <param name="DatePicker">Date picker configuration.</param>
		/// <param name="Input">Input field configuration.</param>
		/// <param name="WheelPicker">Wheel picker configuration.</param>
		public FormPageComponent(FormComponentTypeEnum? FormComponentType = null, FormListPicker ListPicker = null, FormDatePicker DatePicker = null, Input Input = null, WheelPicker WheelPicker = null)
		{
			this.FormComponentType = FormComponentType;
			this.ListPicker = ListPicker;
			this.DatePicker = DatePicker;
			this.Input = Input;
			this.WheelPicker = WheelPicker;

		}





		/// <summary>
		/// List picker configuration
		/// </summary>
		/// <value>List picker configuration</value>
		[DataMember(Name = "listPicker", EmitDefaultValue = false)]
		public FormListPicker ListPicker { get; set; }



		/// <summary>
		/// Date picker configuration
		/// </summary>
		/// <value>Date picker configuration</value>
		[DataMember(Name = "datePicker", EmitDefaultValue = false)]
		public FormDatePicker DatePicker { get; set; }



		/// <summary>
		/// Input field configuration
		/// </summary>
		/// <value>Input field configuration</value>
		[DataMember(Name = "input", EmitDefaultValue = false)]
		public Input Input { get; set; }



		/// <summary>
		/// Wheel picker configuration
		/// </summary>
		/// <value>Wheel picker configuration</value>
		[DataMember(Name = "wheelPicker", EmitDefaultValue = false)]
		public WheelPicker WheelPicker { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FormPageComponent {\n");

			sb.Append("  FormComponentType: ").Append(FormComponentType).Append("\n");
			sb.Append("  ListPicker: ").Append(ListPicker).Append("\n");
			sb.Append("  DatePicker: ").Append(DatePicker).Append("\n");
			sb.Append("  Input: ").Append(Input).Append("\n");
			sb.Append("  WheelPicker: ").Append(WheelPicker).Append("\n");
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
			return this.Equals(obj as FormPageComponent);
		}

		/// <summary>
		/// Returns true if FormPageComponent instances are equal
		/// </summary>
		/// <param name="other">Instance of FormPageComponent to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FormPageComponent other)
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
					this.ListPicker == other.ListPicker ||
					this.ListPicker != null &&
					this.ListPicker.Equals(other.ListPicker)
				) &&
				(
					this.DatePicker == other.DatePicker ||
					this.DatePicker != null &&
					this.DatePicker.Equals(other.DatePicker)
				) &&
				(
					this.Input == other.Input ||
					this.Input != null &&
					this.Input.Equals(other.Input)
				) &&
				(
					this.WheelPicker == other.WheelPicker ||
					this.WheelPicker != null &&
					this.WheelPicker.Equals(other.WheelPicker)
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

				if (this.ListPicker != null)
					hash = hash * 59 + this.ListPicker.GetHashCode();

				if (this.DatePicker != null)
					hash = hash * 59 + this.DatePicker.GetHashCode();

				if (this.Input != null)
					hash = hash * 59 + this.Input.GetHashCode();

				if (this.WheelPicker != null)
					hash = hash * 59 + this.WheelPicker.GetHashCode();

				return hash;
			}
		}
	}

}
