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
    /// Ticker
    /// </summary>
    [DataContract]
    public partial class Ticker :  IEquatable<Ticker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ticker" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Ticker() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ticker" /> class.
        /// </summary>
        /// <param name="Symbol">The ticker symbol for this organization. Example: ININ, AAPL, MSFT, etc. (required).</param>
        /// <param name="Exchange">The exchange for this ticker symbol. Examples: NYSE, FTSE, NASDAQ, etc. (required).</param>
        public Ticker(string Symbol = null, string Exchange = null)
        {
            // to ensure "Symbol" is required (not null)
            if (Symbol == null)
            {
                throw new InvalidDataException("Symbol is a required property for Ticker and cannot be null");
            }
            else
            {
                this.Symbol = Symbol;
            }
            // to ensure "Exchange" is required (not null)
            if (Exchange == null)
            {
                throw new InvalidDataException("Exchange is a required property for Ticker and cannot be null");
            }
            else
            {
                this.Exchange = Exchange;
            }
        }
        
        /// <summary>
        /// The ticker symbol for this organization. Example: ININ, AAPL, MSFT, etc.
        /// </summary>
        /// <value>The ticker symbol for this organization. Example: ININ, AAPL, MSFT, etc.</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }
        /// <summary>
        /// The exchange for this ticker symbol. Examples: NYSE, FTSE, NASDAQ, etc.
        /// </summary>
        /// <value>The exchange for this ticker symbol. Examples: NYSE, FTSE, NASDAQ, etc.</value>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ticker {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
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
            return this.Equals(obj as Ticker);
        }

        /// <summary>
        /// Returns true if Ticker instances are equal
        /// </summary>
        /// <param name="other">Instance of Ticker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ticker other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Symbol == other.Symbol ||
                    this.Symbol != null &&
                    this.Symbol.Equals(other.Symbol)
                ) &&
                (
                    this.Exchange == other.Exchange ||
                    this.Exchange != null &&
                    this.Exchange.Equals(other.Exchange)
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
                if (this.Symbol != null)
                    hash = hash * 59 + this.Symbol.GetHashCode();
                if (this.Exchange != null)
                    hash = hash * 59 + this.Exchange.GetHashCode();
                return hash;
            }
        }
    }

}
