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
    /// OperatorPosition
    /// </summary>
    [DataContract]
    public partial class OperatorPosition :  IEquatable<OperatorPosition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperatorPosition" /> class.
        /// </summary>
        /// <param name="VoiceSecondsPosition">Number of seconds (for voice interactions) from operand match.</param>
        /// <param name="DigitalWordsPosition">Number of words (for digital interactions) from operand match.</param>
        public OperatorPosition(int? VoiceSecondsPosition = null, int? DigitalWordsPosition = null)
        {
            this.VoiceSecondsPosition = VoiceSecondsPosition;
            this.DigitalWordsPosition = DigitalWordsPosition;
            
        }
        


        /// <summary>
        /// Number of seconds (for voice interactions) from operand match
        /// </summary>
        /// <value>Number of seconds (for voice interactions) from operand match</value>
        [DataMember(Name="voiceSecondsPosition", EmitDefaultValue=false)]
        public int? VoiceSecondsPosition { get; set; }



        /// <summary>
        /// Number of words (for digital interactions) from operand match
        /// </summary>
        /// <value>Number of words (for digital interactions) from operand match</value>
        [DataMember(Name="digitalWordsPosition", EmitDefaultValue=false)]
        public int? DigitalWordsPosition { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperatorPosition {\n");

            sb.Append("  VoiceSecondsPosition: ").Append(VoiceSecondsPosition).Append("\n");
            sb.Append("  DigitalWordsPosition: ").Append(DigitalWordsPosition).Append("\n");
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
            return this.Equals(obj as OperatorPosition);
        }

        /// <summary>
        /// Returns true if OperatorPosition instances are equal
        /// </summary>
        /// <param name="other">Instance of OperatorPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperatorPosition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.VoiceSecondsPosition == other.VoiceSecondsPosition ||
                    this.VoiceSecondsPosition != null &&
                    this.VoiceSecondsPosition.Equals(other.VoiceSecondsPosition)
                ) &&
                (
                    this.DigitalWordsPosition == other.DigitalWordsPosition ||
                    this.DigitalWordsPosition != null &&
                    this.DigitalWordsPosition.Equals(other.DigitalWordsPosition)
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
                if (this.VoiceSecondsPosition != null)
                    hash = hash * 59 + this.VoiceSecondsPosition.GetHashCode();

                if (this.DigitalWordsPosition != null)
                    hash = hash * 59 + this.DigitalWordsPosition.GetHashCode();

                return hash;
            }
        }
    }

}
