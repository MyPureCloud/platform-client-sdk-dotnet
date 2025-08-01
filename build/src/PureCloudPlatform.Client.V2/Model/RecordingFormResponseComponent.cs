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
    /// RecordingFormResponseComponent
    /// </summary>
    [DataContract]
    public partial class RecordingFormResponseComponent :  IEquatable<RecordingFormResponseComponent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingFormResponseComponent" /> class.
        /// </summary>
        /// <param name="Id">The id of the component in the original message..</param>
        /// <param name="Component">The content object capturing component response from the original message..</param>
        public RecordingFormResponseComponent(string Id = null, RecordingFormResponseContent Component = null)
        {
            this.Id = Id;
            this.Component = Component;
            
        }
        


        /// <summary>
        /// The id of the component in the original message.
        /// </summary>
        /// <value>The id of the component in the original message.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The content object capturing component response from the original message.
        /// </summary>
        /// <value>The content object capturing component response from the original message.</value>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public RecordingFormResponseContent Component { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingFormResponseComponent {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Component: ").Append(Component).Append("\n");
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
            return this.Equals(obj as RecordingFormResponseComponent);
        }

        /// <summary>
        /// Returns true if RecordingFormResponseComponent instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingFormResponseComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingFormResponseComponent other)
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
                    this.Component == other.Component ||
                    this.Component != null &&
                    this.Component.Equals(other.Component)
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

                if (this.Component != null)
                    hash = hash * 59 + this.Component.GetHashCode();

                return hash;
            }
        }
    }

}
