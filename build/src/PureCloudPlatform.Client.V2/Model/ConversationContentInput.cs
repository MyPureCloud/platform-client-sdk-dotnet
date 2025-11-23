using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Single or multiline text input component.
    /// </summary>
    [DataContract]
    public partial class ConversationContentInput :  IEquatable<ConversationContentInput>
    {
        /// <summary>
        /// Type of keyboard to be shown.
        /// </summary>
        /// <value>Type of keyboard to be shown.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum KeyboardTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>
            [EnumMember(Value = "Default")]
            Default,
            
            /// <summary>
            /// Enum Numberpunctuation for "NumberPunctuation"
            /// </summary>
            [EnumMember(Value = "NumberPunctuation")]
            Numberpunctuation,
            
            /// <summary>
            /// Enum Number for "Number"
            /// </summary>
            [EnumMember(Value = "Number")]
            Number,
            
            /// <summary>
            /// Enum Phone for "Phone"
            /// </summary>
            [EnumMember(Value = "Phone")]
            Phone,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Decimal for "Decimal"
            /// </summary>
            [EnumMember(Value = "Decimal")]
            Decimal,
            
            /// <summary>
            /// Enum Websearch for "Websearch"
            /// </summary>
            [EnumMember(Value = "Websearch")]
            Websearch,
            
            /// <summary>
            /// Enum Url for "URL"
            /// </summary>
            [EnumMember(Value = "URL")]
            Url
        }
        /// <summary>
        /// A string value representing the keyboard and system information about the expected semantic meaning for the content that users enter.
        /// </summary>
        /// <value>A string value representing the keyboard and system information about the expected semantic meaning for the content that users enter.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AutoCompleteTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Prefix for "Prefix"
            /// </summary>
            [EnumMember(Value = "Prefix")]
            Prefix,
            
            /// <summary>
            /// Enum Name for "Name"
            /// </summary>
            [EnumMember(Value = "Name")]
            Name,
            
            /// <summary>
            /// Enum Givenname for "GivenName"
            /// </summary>
            [EnumMember(Value = "GivenName")]
            Givenname,
            
            /// <summary>
            /// Enum Middlename for "MiddleName"
            /// </summary>
            [EnumMember(Value = "MiddleName")]
            Middlename,
            
            /// <summary>
            /// Enum Familyname for "FamilyName"
            /// </summary>
            [EnumMember(Value = "FamilyName")]
            Familyname,
            
            /// <summary>
            /// Enum Suffix for "Suffix"
            /// </summary>
            [EnumMember(Value = "Suffix")]
            Suffix,
            
            /// <summary>
            /// Enum Nickname for "Nickname"
            /// </summary>
            [EnumMember(Value = "Nickname")]
            Nickname,
            
            /// <summary>
            /// Enum Title for "Title"
            /// </summary>
            [EnumMember(Value = "Title")]
            Title,
            
            /// <summary>
            /// Enum Organization for "Organization"
            /// </summary>
            [EnumMember(Value = "Organization")]
            Organization,
            
            /// <summary>
            /// Enum Location for "Location"
            /// </summary>
            [EnumMember(Value = "Location")]
            Location,
            
            /// <summary>
            /// Enum Streetaddress for "StreetAddress"
            /// </summary>
            [EnumMember(Value = "StreetAddress")]
            Streetaddress,
            
            /// <summary>
            /// Enum Addressline1 for "Addressline1"
            /// </summary>
            [EnumMember(Value = "Addressline1")]
            Addressline1,
            
            /// <summary>
            /// Enum Addressline2 for "Addressline2"
            /// </summary>
            [EnumMember(Value = "Addressline2")]
            Addressline2,
            
            /// <summary>
            /// Enum City for "City"
            /// </summary>
            [EnumMember(Value = "City")]
            City,
            
            /// <summary>
            /// Enum State for "State"
            /// </summary>
            [EnumMember(Value = "State")]
            State,
            
            /// <summary>
            /// Enum Country for "Country"
            /// </summary>
            [EnumMember(Value = "Country")]
            Country,
            
            /// <summary>
            /// Enum Postalcode for "PostalCode"
            /// </summary>
            [EnumMember(Value = "PostalCode")]
            Postalcode,
            
            /// <summary>
            /// Enum Username for "Username"
            /// </summary>
            [EnumMember(Value = "Username")]
            Username,
            
            /// <summary>
            /// Enum Onetimecode for "OneTimeCode"
            /// </summary>
            [EnumMember(Value = "OneTimeCode")]
            Onetimecode,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Phone for "Phone"
            /// </summary>
            [EnumMember(Value = "Phone")]
            Phone,
            
            /// <summary>
            /// Enum Paymentcardnumber for "PaymentCardNumber"
            /// </summary>
            [EnumMember(Value = "PaymentCardNumber")]
            Paymentcardnumber,
            
            /// <summary>
            /// Enum Paymentcardexpiration for "PaymentCardExpiration"
            /// </summary>
            [EnumMember(Value = "PaymentCardExpiration")]
            Paymentcardexpiration,
            
            /// <summary>
            /// Enum Paymentcardexpirationmonth for "PaymentCardExpirationMonth"
            /// </summary>
            [EnumMember(Value = "PaymentCardExpirationMonth")]
            Paymentcardexpirationmonth,
            
            /// <summary>
            /// Enum Paymentcardexpirationyear for "PaymentCardExpirationYear"
            /// </summary>
            [EnumMember(Value = "PaymentCardExpirationYear")]
            Paymentcardexpirationyear,
            
            /// <summary>
            /// Enum Paymentcardsecuritycode for "PaymentCardSecurityCode"
            /// </summary>
            [EnumMember(Value = "PaymentCardSecurityCode")]
            Paymentcardsecuritycode,
            
            /// <summary>
            /// Enum Paymentcardtype for "PaymentCardType"
            /// </summary>
            [EnumMember(Value = "PaymentCardType")]
            Paymentcardtype,
            
            /// <summary>
            /// Enum Paymentcardname for "PaymentCardName"
            /// </summary>
            [EnumMember(Value = "PaymentCardName")]
            Paymentcardname,
            
            /// <summary>
            /// Enum Paymentcardgivenname for "PaymentCardGivenName"
            /// </summary>
            [EnumMember(Value = "PaymentCardGivenName")]
            Paymentcardgivenname,
            
            /// <summary>
            /// Enum Paymentcardmiddlename for "PaymentCardMiddleName"
            /// </summary>
            [EnumMember(Value = "PaymentCardMiddleName")]
            Paymentcardmiddlename,
            
            /// <summary>
            /// Enum Paymentcardfamilyname for "PaymentCardFamilyName"
            /// </summary>
            [EnumMember(Value = "PaymentCardFamilyName")]
            Paymentcardfamilyname,
            
            /// <summary>
            /// Enum Birthdate for "Birthdate"
            /// </summary>
            [EnumMember(Value = "Birthdate")]
            Birthdate,
            
            /// <summary>
            /// Enum Birthdateday for "BirthdateDay"
            /// </summary>
            [EnumMember(Value = "BirthdateDay")]
            Birthdateday,
            
            /// <summary>
            /// Enum Birthdatemonth for "BirthdateMonth"
            /// </summary>
            [EnumMember(Value = "BirthdateMonth")]
            Birthdatemonth,
            
            /// <summary>
            /// Enum Birthdateyear for "BirthdateYear"
            /// </summary>
            [EnumMember(Value = "BirthdateYear")]
            Birthdateyear,
            
            /// <summary>
            /// Enum Datetime for "DateTime"
            /// </summary>
            [EnumMember(Value = "DateTime")]
            Datetime,
            
            /// <summary>
            /// Enum Flightnumber for "FlightNumber"
            /// </summary>
            [EnumMember(Value = "FlightNumber")]
            Flightnumber,
            
            /// <summary>
            /// Enum Url for "Url"
            /// </summary>
            [EnumMember(Value = "Url")]
            Url
        }
        /// <summary>
        /// Type of keyboard to be shown.
        /// </summary>
        /// <value>Type of keyboard to be shown.</value>
        [DataMember(Name="keyboardType", EmitDefaultValue=false)]
        public KeyboardTypeEnum? KeyboardType { get; set; }
        /// <summary>
        /// A string value representing the keyboard and system information about the expected semantic meaning for the content that users enter.
        /// </summary>
        /// <value>A string value representing the keyboard and system information about the expected semantic meaning for the content that users enter.</value>
        [DataMember(Name="autoCompleteType", EmitDefaultValue=false)]
        public AutoCompleteTypeEnum? AutoCompleteType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentInput" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the input.</param>
        /// <param name="Title">The main text displayed for the input field(s)..</param>
        /// <param name="Subtitle">Additional text providing more details about the input field(s)..</param>
        /// <param name="PlaceholderText">Placeholder text for input field(s)..</param>
        /// <param name="IsRequired">Whether the input field(s) are required to be filled in. (required).</param>
        /// <param name="IsMultipleLine">Whether the input should allow multiple lines of text. (required).</param>
        /// <param name="KeyboardType">Type of keyboard to be shown..</param>
        /// <param name="AutoCompleteType">A string value representing the keyboard and system information about the expected semantic meaning for the content that users enter..</param>
        public ConversationContentInput(string Id = null, string Title = null, string Subtitle = null, string PlaceholderText = null, bool? IsRequired = null, bool? IsMultipleLine = null, KeyboardTypeEnum? KeyboardType = null, AutoCompleteTypeEnum? AutoCompleteType = null)
        {
            this.Id = Id;
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.PlaceholderText = PlaceholderText;
            this.IsRequired = IsRequired;
            this.IsMultipleLine = IsMultipleLine;
            this.KeyboardType = KeyboardType;
            this.AutoCompleteType = AutoCompleteType;
            
        }
        


        /// <summary>
        /// Unique identifier for the input
        /// </summary>
        /// <value>Unique identifier for the input</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The main text displayed for the input field(s).
        /// </summary>
        /// <value>The main text displayed for the input field(s).</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Additional text providing more details about the input field(s).
        /// </summary>
        /// <value>Additional text providing more details about the input field(s).</value>
        [DataMember(Name="subtitle", EmitDefaultValue=false)]
        public string Subtitle { get; set; }



        /// <summary>
        /// Placeholder text for input field(s).
        /// </summary>
        /// <value>Placeholder text for input field(s).</value>
        [DataMember(Name="placeholderText", EmitDefaultValue=false)]
        public string PlaceholderText { get; set; }



        /// <summary>
        /// Whether the input field(s) are required to be filled in.
        /// </summary>
        /// <value>Whether the input field(s) are required to be filled in.</value>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }



        /// <summary>
        /// Whether the input should allow multiple lines of text.
        /// </summary>
        /// <value>Whether the input should allow multiple lines of text.</value>
        [DataMember(Name="isMultipleLine", EmitDefaultValue=false)]
        public bool? IsMultipleLine { get; set; }






        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentInput {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  PlaceholderText: ").Append(PlaceholderText).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  IsMultipleLine: ").Append(IsMultipleLine).Append("\n");
            sb.Append("  KeyboardType: ").Append(KeyboardType).Append("\n");
            sb.Append("  AutoCompleteType: ").Append(AutoCompleteType).Append("\n");
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
            return this.Equals(obj as ConversationContentInput);
        }

        /// <summary>
        /// Returns true if ConversationContentInput instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Subtitle == other.Subtitle ||
                    this.Subtitle != null &&
                    this.Subtitle.Equals(other.Subtitle)
                ) &&
                (
                    this.PlaceholderText == other.PlaceholderText ||
                    this.PlaceholderText != null &&
                    this.PlaceholderText.Equals(other.PlaceholderText)
                ) &&
                (
                    this.IsRequired == other.IsRequired ||
                    this.IsRequired != null &&
                    this.IsRequired.Equals(other.IsRequired)
                ) &&
                (
                    this.IsMultipleLine == other.IsMultipleLine ||
                    this.IsMultipleLine != null &&
                    this.IsMultipleLine.Equals(other.IsMultipleLine)
                ) &&
                (
                    this.KeyboardType == other.KeyboardType ||
                    this.KeyboardType != null &&
                    this.KeyboardType.Equals(other.KeyboardType)
                ) &&
                (
                    this.AutoCompleteType == other.AutoCompleteType ||
                    this.AutoCompleteType != null &&
                    this.AutoCompleteType.Equals(other.AutoCompleteType)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Subtitle != null)
                    hash = hash * 59 + this.Subtitle.GetHashCode();

                if (this.PlaceholderText != null)
                    hash = hash * 59 + this.PlaceholderText.GetHashCode();

                if (this.IsRequired != null)
                    hash = hash * 59 + this.IsRequired.GetHashCode();

                if (this.IsMultipleLine != null)
                    hash = hash * 59 + this.IsMultipleLine.GetHashCode();

                if (this.KeyboardType != null)
                    hash = hash * 59 + this.KeyboardType.GetHashCode();

                if (this.AutoCompleteType != null)
                    hash = hash * 59 + this.AutoCompleteType.GetHashCode();

                return hash;
            }
        }
    }

}
