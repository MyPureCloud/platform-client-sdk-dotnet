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
    /// ShiftTradeMatchResponseItem
    /// </summary>
    [DataContract]
    public partial class ShiftTradeMatchResponseItem :  IEquatable<ShiftTradeMatchResponseItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeMatchResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShiftTradeMatchResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftTradeMatchResponseItem" /> class.
        /// </summary>
        /// <param name="ShiftIds">The IDs of the receiving shift trades which match the initiating shift trade (required).</param>
        /// <param name="Preview">A preview of what the shift trade would look like if matched (required).</param>
        public ShiftTradeMatchResponseItem(List<string> ShiftIds = null, ShiftTradePreviewResponse Preview = null)
        {
            this.ShiftIds = ShiftIds;
            this.Preview = Preview;
            
        }
        


        /// <summary>
        /// The IDs of the receiving shift trades which match the initiating shift trade
        /// </summary>
        /// <value>The IDs of the receiving shift trades which match the initiating shift trade</value>
        [DataMember(Name="shiftIds", EmitDefaultValue=false)]
        public List<string> ShiftIds { get; set; }



        /// <summary>
        /// A preview of what the shift trade would look like if matched
        /// </summary>
        /// <value>A preview of what the shift trade would look like if matched</value>
        [DataMember(Name="preview", EmitDefaultValue=false)]
        public ShiftTradePreviewResponse Preview { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShiftTradeMatchResponseItem {\n");

            sb.Append("  ShiftIds: ").Append(ShiftIds).Append("\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
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
            return this.Equals(obj as ShiftTradeMatchResponseItem);
        }

        /// <summary>
        /// Returns true if ShiftTradeMatchResponseItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ShiftTradeMatchResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShiftTradeMatchResponseItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ShiftIds == other.ShiftIds ||
                    this.ShiftIds != null &&
                    this.ShiftIds.SequenceEqual(other.ShiftIds)
                ) &&
                (
                    this.Preview == other.Preview ||
                    this.Preview != null &&
                    this.Preview.Equals(other.Preview)
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
                if (this.ShiftIds != null)
                    hash = hash * 59 + this.ShiftIds.GetHashCode();

                if (this.Preview != null)
                    hash = hash * 59 + this.Preview.GetHashCode();

                return hash;
            }
        }
    }

}
