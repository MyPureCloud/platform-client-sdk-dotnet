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
    /// GenesysBotConnector
    /// </summary>
    [DataContract]
    public partial class GenesysBotConnector :  IEquatable<GenesysBotConnector>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GenesysBotConnector" /> class.
        /// </summary>
        /// <param name="QueryParameters">User defined name/value parameters passed to the BotConnector bot..</param>
        public GenesysBotConnector(Dictionary<string, string> QueryParameters = null)
        {
            this.QueryParameters = QueryParameters;
            
        }
        
        
        
        /// <summary>
        /// User defined name/value parameters passed to the BotConnector bot.
        /// </summary>
        /// <value>User defined name/value parameters passed to the BotConnector bot.</value>
        [DataMember(Name="queryParameters", EmitDefaultValue=false)]
        public Dictionary<string, string> QueryParameters { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GenesysBotConnector {\n");
            
            sb.Append("  QueryParameters: ").Append(QueryParameters).Append("\n");
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
            return this.Equals(obj as GenesysBotConnector);
        }

        /// <summary>
        /// Returns true if GenesysBotConnector instances are equal
        /// </summary>
        /// <param name="other">Instance of GenesysBotConnector to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenesysBotConnector other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.QueryParameters == other.QueryParameters ||
                    this.QueryParameters != null &&
                    this.QueryParameters.SequenceEqual(other.QueryParameters)
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
                
                if (this.QueryParameters != null)
                    hash = hash * 59 + this.QueryParameters.GetHashCode();
                
                return hash;
            }
        }
    }

}
