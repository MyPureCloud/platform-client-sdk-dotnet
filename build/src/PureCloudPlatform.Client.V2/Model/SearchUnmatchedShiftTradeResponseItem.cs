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
    /// SearchUnmatchedShiftTradeResponseItem
    /// </summary>
    [DataContract]
    public partial class SearchUnmatchedShiftTradeResponseItem :  IEquatable<SearchUnmatchedShiftTradeResponseItem>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchUnmatchedShiftTradeResponseItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchUnmatchedShiftTradeResponseItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchUnmatchedShiftTradeResponseItem" /> class.
        /// </summary>
        /// <param name="Trade">A trade which matches search criteria (required).</param>
        /// <param name="ReceivingShiftMatches">The shifts that match the search criteria (required).</param>
        public SearchUnmatchedShiftTradeResponseItem(ShiftTradeResponseItem Trade = null, List<ShiftTradeMatchResponseItem> ReceivingShiftMatches = null)
        {
            this.Trade = Trade;
            this.ReceivingShiftMatches = ReceivingShiftMatches;
            
        }
        


        /// <summary>
        /// A trade which matches search criteria
        /// </summary>
        /// <value>A trade which matches search criteria</value>
        [DataMember(Name="trade", EmitDefaultValue=false)]
        public ShiftTradeResponseItem Trade { get; set; }



        /// <summary>
        /// The shifts that match the search criteria
        /// </summary>
        /// <value>The shifts that match the search criteria</value>
        [DataMember(Name="receivingShiftMatches", EmitDefaultValue=false)]
        public List<ShiftTradeMatchResponseItem> ReceivingShiftMatches { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchUnmatchedShiftTradeResponseItem {\n");

            sb.Append("  Trade: ").Append(Trade).Append("\n");
            sb.Append("  ReceivingShiftMatches: ").Append(ReceivingShiftMatches).Append("\n");
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
            return this.Equals(obj as SearchUnmatchedShiftTradeResponseItem);
        }

        /// <summary>
        /// Returns true if SearchUnmatchedShiftTradeResponseItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchUnmatchedShiftTradeResponseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchUnmatchedShiftTradeResponseItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Trade == other.Trade ||
                    this.Trade != null &&
                    this.Trade.Equals(other.Trade)
                ) &&
                (
                    this.ReceivingShiftMatches == other.ReceivingShiftMatches ||
                    this.ReceivingShiftMatches != null &&
                    this.ReceivingShiftMatches.SequenceEqual(other.ReceivingShiftMatches)
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
                if (this.Trade != null)
                    hash = hash * 59 + this.Trade.GetHashCode();

                if (this.ReceivingShiftMatches != null)
                    hash = hash * 59 + this.ReceivingShiftMatches.GetHashCode();

                return hash;
            }
        }
    }

}
