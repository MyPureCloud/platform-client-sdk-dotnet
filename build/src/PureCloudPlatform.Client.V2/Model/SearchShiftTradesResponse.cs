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
    /// SearchShiftTradesResponse
    /// </summary>
    [DataContract]
    public partial class SearchShiftTradesResponse :  IEquatable<SearchShiftTradesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchShiftTradesResponse" /> class.
        /// </summary>
        /// <param name="Trades">The shift trades that match the search criteria.</param>
        public SearchShiftTradesResponse(List<SearchShiftTradeResponse> Trades = null)
        {
            this.Trades = Trades;
            
        }
        


        /// <summary>
        /// The shift trades that match the search criteria
        /// </summary>
        /// <value>The shift trades that match the search criteria</value>
        [DataMember(Name="trades", EmitDefaultValue=false)]
        public List<SearchShiftTradeResponse> Trades { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchShiftTradesResponse {\n");

            sb.Append("  Trades: ").Append(Trades).Append("\n");
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
            return this.Equals(obj as SearchShiftTradesResponse);
        }

        /// <summary>
        /// Returns true if SearchShiftTradesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchShiftTradesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchShiftTradesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Trades == other.Trades ||
                    this.Trades != null &&
                    this.Trades.SequenceEqual(other.Trades)
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
                if (this.Trades != null)
                    hash = hash * 59 + this.Trades.GetHashCode();

                return hash;
            }
        }
    }

}
