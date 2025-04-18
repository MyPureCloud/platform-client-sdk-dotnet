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
    /// ExternalContactsOrganizationChangedTopicTicker
    /// </summary>
    [DataContract]
    public partial class ExternalContactsOrganizationChangedTopicTicker :  IEquatable<ExternalContactsOrganizationChangedTopicTicker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsOrganizationChangedTopicTicker" /> class.
        /// </summary>
        /// <param name="Symbol">Symbol.</param>
        /// <param name="Exchange">Exchange.</param>
        public ExternalContactsOrganizationChangedTopicTicker(string Symbol = null, string Exchange = null)
        {
            this.Symbol = Symbol;
            this.Exchange = Exchange;
            
        }
        


        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }



        /// <summary>
        /// Gets or Sets Exchange
        /// </summary>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsOrganizationChangedTopicTicker {\n");

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
            return this.Equals(obj as ExternalContactsOrganizationChangedTopicTicker);
        }

        /// <summary>
        /// Returns true if ExternalContactsOrganizationChangedTopicTicker instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsOrganizationChangedTopicTicker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsOrganizationChangedTopicTicker other)
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
