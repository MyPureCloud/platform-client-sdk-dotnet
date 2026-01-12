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
    /// RecordingTemplateCard
    /// </summary>
    [DataContract]
    public partial class RecordingTemplateCard :  IEquatable<RecordingTemplateCard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingTemplateCard" /> class.
        /// </summary>
        /// <param name="Header">The template header..</param>
        /// <param name="Body">The template body..</param>
        /// <param name="Buttons">Template buttons..</param>
        public RecordingTemplateCard(RecordingTemplateHeader Header = null, RecordingTemplateBody Body = null, List<RecordingTemplateButton> Buttons = null)
        {
            this.Header = Header;
            this.Body = Body;
            this.Buttons = Buttons;
            
        }
        


        /// <summary>
        /// The template header.
        /// </summary>
        /// <value>The template header.</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public RecordingTemplateHeader Header { get; set; }



        /// <summary>
        /// The template body.
        /// </summary>
        /// <value>The template body.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public RecordingTemplateBody Body { get; set; }



        /// <summary>
        /// Template buttons.
        /// </summary>
        /// <value>Template buttons.</value>
        [DataMember(Name="buttons", EmitDefaultValue=false)]
        public List<RecordingTemplateButton> Buttons { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingTemplateCard {\n");

            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Buttons: ").Append(Buttons).Append("\n");
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
            return this.Equals(obj as RecordingTemplateCard);
        }

        /// <summary>
        /// Returns true if RecordingTemplateCard instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingTemplateCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingTemplateCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Header == other.Header ||
                    this.Header != null &&
                    this.Header.Equals(other.Header)
                ) &&
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) &&
                (
                    this.Buttons == other.Buttons ||
                    this.Buttons != null &&
                    this.Buttons.SequenceEqual(other.Buttons)
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
                if (this.Header != null)
                    hash = hash * 59 + this.Header.GetHashCode();

                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();

                if (this.Buttons != null)
                    hash = hash * 59 + this.Buttons.GetHashCode();

                return hash;
            }
        }
    }

}
