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
    /// DateTimePicker content object.
    /// </summary>
    [DataContract]
    public partial class ConversationContentDatePicker :  IEquatable<ConversationContentDatePicker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentDatePicker" /> class.
        /// </summary>
        /// <param name="Title">Text to show in the title..</param>
        /// <param name="Subtitle">Text to show in the description..</param>
        /// <param name="ImageUrl">URL of an image.</param>
        /// <param name="DateMinimum">The minimum Date Enabled in the datepicker calendar, format: ISO 8601..</param>
        /// <param name="DateMaximum">The maximum Date Enabled in the datepicker calendar, format: ISO 8601..</param>
        /// <param name="Location">Location of the event..</param>
        /// <param name="AvailableTimes">An array of available times objects..</param>
        public ConversationContentDatePicker(string Title = null, string Subtitle = null, string ImageUrl = null, DateTime? DateMinimum = null, DateTime? DateMaximum = null, ConversationContentLocation Location = null, List<ConversationContentDatePickerAvailableTime> AvailableTimes = null)
        {
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.ImageUrl = ImageUrl;
            this.DateMinimum = DateMinimum;
            this.DateMaximum = DateMaximum;
            this.Location = Location;
            this.AvailableTimes = AvailableTimes;
            
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
        /// URL of an image
        /// </summary>
        /// <value>URL of an image</value>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }



        /// <summary>
        /// The minimum Date Enabled in the datepicker calendar, format: ISO 8601.
        /// </summary>
        /// <value>The minimum Date Enabled in the datepicker calendar, format: ISO 8601.</value>
        [DataMember(Name="dateMinimum", EmitDefaultValue=false)]
        public DateTime? DateMinimum { get; set; }



        /// <summary>
        /// The maximum Date Enabled in the datepicker calendar, format: ISO 8601.
        /// </summary>
        /// <value>The maximum Date Enabled in the datepicker calendar, format: ISO 8601.</value>
        [DataMember(Name="dateMaximum", EmitDefaultValue=false)]
        public DateTime? DateMaximum { get; set; }



        /// <summary>
        /// Location of the event.
        /// </summary>
        /// <value>Location of the event.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public ConversationContentLocation Location { get; set; }



        /// <summary>
        /// An array of available times objects.
        /// </summary>
        /// <value>An array of available times objects.</value>
        [DataMember(Name="availableTimes", EmitDefaultValue=false)]
        public List<ConversationContentDatePickerAvailableTime> AvailableTimes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentDatePicker {\n");

            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  DateMinimum: ").Append(DateMinimum).Append("\n");
            sb.Append("  DateMaximum: ").Append(DateMaximum).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  AvailableTimes: ").Append(AvailableTimes).Append("\n");
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
            return this.Equals(obj as ConversationContentDatePicker);
        }

        /// <summary>
        /// Returns true if ConversationContentDatePicker instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentDatePicker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentDatePicker other)
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
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) &&
                (
                    this.DateMinimum == other.DateMinimum ||
                    this.DateMinimum != null &&
                    this.DateMinimum.Equals(other.DateMinimum)
                ) &&
                (
                    this.DateMaximum == other.DateMaximum ||
                    this.DateMaximum != null &&
                    this.DateMaximum.Equals(other.DateMaximum)
                ) &&
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) &&
                (
                    this.AvailableTimes == other.AvailableTimes ||
                    this.AvailableTimes != null &&
                    this.AvailableTimes.SequenceEqual(other.AvailableTimes)
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

                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();

                if (this.DateMinimum != null)
                    hash = hash * 59 + this.DateMinimum.GetHashCode();

                if (this.DateMaximum != null)
                    hash = hash * 59 + this.DateMaximum.GetHashCode();

                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();

                if (this.AvailableTimes != null)
                    hash = hash * 59 + this.AvailableTimes.GetHashCode();

                return hash;
            }
        }
    }

}
