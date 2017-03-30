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
    /// Section
    /// </summary>
    [DataContract]
    public partial class Section :  IEquatable<Section>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        /// <param name="FieldList">FieldList.</param>
        /// <param name="InstructionText">InstructionText.</param>
        /// <param name="Key">Key.</param>
        /// <param name="State">State.</param>
        public Section(List<FieldList> FieldList = null, string InstructionText = null, string Key = null, string State = null)
        {
            this.FieldList = FieldList;
            this.InstructionText = InstructionText;
            this.Key = Key;
            this.State = State;
        }
        
        /// <summary>
        /// Gets or Sets FieldList
        /// </summary>
        [DataMember(Name="fieldList", EmitDefaultValue=false)]
        public List<FieldList> FieldList { get; set; }
        /// <summary>
        /// Gets or Sets InstructionText
        /// </summary>
        [DataMember(Name="instructionText", EmitDefaultValue=false)]
        public string InstructionText { get; set; }
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Section {\n");
            sb.Append("  FieldList: ").Append(FieldList).Append("\n");
            sb.Append("  InstructionText: ").Append(InstructionText).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Section);
        }

        /// <summary>
        /// Returns true if Section instances are equal
        /// </summary>
        /// <param name="other">Instance of Section to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Section other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FieldList == other.FieldList ||
                    this.FieldList != null &&
                    this.FieldList.SequenceEqual(other.FieldList)
                ) &&
                (
                    this.InstructionText == other.InstructionText ||
                    this.InstructionText != null &&
                    this.InstructionText.Equals(other.InstructionText)
                ) &&
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.FieldList != null)
                    hash = hash * 59 + this.FieldList.GetHashCode();
                if (this.InstructionText != null)
                    hash = hash * 59 + this.InstructionText.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                return hash;
            }
        }
    }

}
