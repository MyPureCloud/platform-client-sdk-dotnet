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
    /// Date picker component for form input
    /// </summary>
    [DataContract]
    public partial class FormDatePicker :  IEquatable<FormDatePicker>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FormDatePicker" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormDatePicker() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDatePicker" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the date picker.</param>
        /// <param name="Title">Title of the date picker.</param>
        /// <param name="Subtitle">Subtitle of the date picker.</param>
        /// <param name="DateDisplayFormat">Date display format (required).</param>
        public FormDatePicker(string Id = null, string Title = null, string Subtitle = null, string DateDisplayFormat = null)
        {
            this.Id = Id;
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.DateDisplayFormat = DateDisplayFormat;
            
        }
        


        /// <summary>
        /// Unique identifier for the date picker
        /// </summary>
        /// <value>Unique identifier for the date picker</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Title of the date picker
        /// </summary>
        /// <value>Title of the date picker</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }



        /// <summary>
        /// Subtitle of the date picker
        /// </summary>
        /// <value>Subtitle of the date picker</value>
        [DataMember(Name="subtitle", EmitDefaultValue=false)]
        public string Subtitle { get; set; }



        /// <summary>
        /// Date display format
        /// </summary>
        /// <value>Date display format</value>
        [DataMember(Name="dateDisplayFormat", EmitDefaultValue=false)]
        public string DateDisplayFormat { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormDatePicker {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  DateDisplayFormat: ").Append(DateDisplayFormat).Append("\n");
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
            return this.Equals(obj as FormDatePicker);
        }

        /// <summary>
        /// Returns true if FormDatePicker instances are equal
        /// </summary>
        /// <param name="other">Instance of FormDatePicker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormDatePicker other)
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
                    this.DateDisplayFormat == other.DateDisplayFormat ||
                    this.DateDisplayFormat != null &&
                    this.DateDisplayFormat.Equals(other.DateDisplayFormat)
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

                if (this.DateDisplayFormat != null)
                    hash = hash * 59 + this.DateDisplayFormat.GetHashCode();

                return hash;
            }
        }
    }

}
