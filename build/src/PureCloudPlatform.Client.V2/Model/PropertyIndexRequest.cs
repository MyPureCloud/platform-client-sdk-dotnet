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
    /// PropertyIndexRequest
    /// </summary>
    [DataContract]
    public partial class PropertyIndexRequest :  IEquatable<PropertyIndexRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIndexRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyIndexRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyIndexRequest" /> class.
        /// </summary>
        
        
        /// <param name="SessionId">Attach properties to a segment in the indicated session (required).</param>
        
        
        
        /// <param name="TargetDate">Attach properties to a segment covering a specific point in time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        
        
        
        /// <param name="Properties">The list of properties to index (required).</param>
        
        
        public PropertyIndexRequest(string SessionId = null, DateTime? TargetDate = null, List<AnalyticsProperty> Properties = null)
        {
            
            
            
            // to ensure "SessionId" is required (not null)
            if (SessionId == null)
            {
                throw new InvalidDataException("SessionId is a required property for PropertyIndexRequest and cannot be null");
            }
            else
            {
                this.SessionId = SessionId;
            }
            
            
            
            
            
            // to ensure "TargetDate" is required (not null)
            if (TargetDate == null)
            {
                throw new InvalidDataException("TargetDate is a required property for PropertyIndexRequest and cannot be null");
            }
            else
            {
                this.TargetDate = TargetDate;
            }
            
            
            
            
            
            // to ensure "Properties" is required (not null)
            if (Properties == null)
            {
                throw new InvalidDataException("Properties is a required property for PropertyIndexRequest and cannot be null");
            }
            else
            {
                this.Properties = Properties;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Attach properties to a segment in the indicated session
        /// </summary>
        /// <value>Attach properties to a segment in the indicated session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }
        
        
        
        /// <summary>
        /// Attach properties to a segment covering a specific point in time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Attach properties to a segment covering a specific point in time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="targetDate", EmitDefaultValue=false)]
        public DateTime? TargetDate { get; set; }
        
        
        
        /// <summary>
        /// The list of properties to index
        /// </summary>
        /// <value>The list of properties to index</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<AnalyticsProperty> Properties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyIndexRequest {\n");
            
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            
            sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
            
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            
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
            return this.Equals(obj as PropertyIndexRequest);
        }

        /// <summary>
        /// Returns true if PropertyIndexRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PropertyIndexRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyIndexRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.TargetDate == other.TargetDate ||
                    this.TargetDate != null &&
                    this.TargetDate.Equals(other.TargetDate)
                ) &&
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(other.Properties)
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
                
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();
                
                if (this.TargetDate != null)
                    hash = hash * 59 + this.TargetDate.GetHashCode();
                
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                
                return hash;
            }
        }
    }

}
