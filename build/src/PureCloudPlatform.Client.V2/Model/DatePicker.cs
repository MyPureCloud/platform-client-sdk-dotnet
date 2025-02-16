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
    /// DatePicker
    /// </summary>
    [DataContract]
    public partial class DatePicker :  IEquatable<DatePicker>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DatePicker" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DatePicker() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatePicker" /> class.
        /// </summary>
        /// <param name="Title">Text to show in the title..</param>
        /// <param name="Subtitle">Text to show in the description..</param>
        /// <param name="DatePickerAvailableDateTimes">An array of available times objects. (required).</param>
        public DatePicker(string Title = null, string Subtitle = null, List<DatePickerAvailableDateTime> DatePickerAvailableDateTimes = null)
        {
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.DatePickerAvailableDateTimes = DatePickerAvailableDateTimes;
            
        }
        


        /// <summary>
        /// Text to show in the title.
        /// </summary>
        /// <value>Text to show in the title.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Text to show in the description.
        /// </summary>
        /// <value>Text to show in the description.</value>
        [DataMember(Name="subtitle", EmitDefaultValue=false)]
        public string Subtitle { get; set; }



        /// <summary>
        /// An array of available times objects.
        /// </summary>
        /// <value>An array of available times objects.</value>
        [DataMember(Name="datePickerAvailableDateTimes", EmitDefaultValue=false)]
        public List<DatePickerAvailableDateTime> DatePickerAvailableDateTimes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatePicker {\n");

            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  DatePickerAvailableDateTimes: ").Append(DatePickerAvailableDateTimes).Append("\n");
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
            return this.Equals(obj as DatePicker);
        }

        /// <summary>
        /// Returns true if DatePicker instances are equal
        /// </summary>
        /// <param name="other">Instance of DatePicker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatePicker other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                    this.DatePickerAvailableDateTimes == other.DatePickerAvailableDateTimes ||
                    this.DatePickerAvailableDateTimes != null &&
                    this.DatePickerAvailableDateTimes.SequenceEqual(other.DatePickerAvailableDateTimes)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();

                if (this.Subtitle != null)
                    hash = hash * 59 + this.Subtitle.GetHashCode();

                if (this.DatePickerAvailableDateTimes != null)
                    hash = hash * 59 + this.DatePickerAvailableDateTimes.GetHashCode();

                return hash;
            }
        }
    }

}
