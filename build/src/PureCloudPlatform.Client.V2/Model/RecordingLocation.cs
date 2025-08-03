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
    /// RecordingLocation
    /// </summary>
    [DataContract]
    public partial class RecordingLocation :  IEquatable<RecordingLocation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingLocation" /> class.
        /// </summary>
        /// <param name="Url">URL of the Location..</param>
        /// <param name="Address">Location postal address..</param>
        /// <param name="Text">Location name..</param>
        /// <param name="Latitude">Latitude of the location..</param>
        /// <param name="Longitude">Longitude of the location..</param>
        public RecordingLocation(string Url = null, string Address = null, string Text = null, double? Latitude = null, double? Longitude = null)
        {
            this.Url = Url;
            this.Address = Address;
            this.Text = Text;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            
        }
        


        /// <summary>
        /// URL of the Location.
        /// </summary>
        /// <value>URL of the Location.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Location postal address.
        /// </summary>
        /// <value>Location postal address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }



        /// <summary>
        /// Location name.
        /// </summary>
        /// <value>Location name.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Latitude of the location.
        /// </summary>
        /// <value>Latitude of the location.</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public double? Latitude { get; set; }



        /// <summary>
        /// Longitude of the location.
        /// </summary>
        /// <value>Longitude of the location.</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingLocation {\n");

            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(obj as RecordingLocation);
        }

        /// <summary>
        /// Returns true if RecordingLocation instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingLocation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Latitude == other.Latitude ||
                    this.Latitude != null &&
                    this.Latitude.Equals(other.Latitude)
                ) &&
                (
                    this.Longitude == other.Longitude ||
                    this.Longitude != null &&
                    this.Longitude.Equals(other.Longitude)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.Latitude != null)
                    hash = hash * 59 + this.Latitude.GetHashCode();

                if (this.Longitude != null)
                    hash = hash * 59 + this.Longitude.GetHashCode();

                return hash;
            }
        }
    }

}
