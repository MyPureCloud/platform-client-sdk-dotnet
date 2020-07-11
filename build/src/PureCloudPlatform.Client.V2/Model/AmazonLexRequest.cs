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
    /// AmazonLexRequest
    /// </summary>
    [DataContract]
    public partial class AmazonLexRequest :  IEquatable<AmazonLexRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonLexRequest" /> class.
        /// </summary>
        /// <param name="RequestAttributes">AttributeName/AttributeValue pairs of User Defined Request Attributes to be sent to the amazon bot See - https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-request-attribs.</param>
        /// <param name="SessionAttributes">AttributeName/AttributeValue pairs of Session Attributes to be sent to the amazon bot. See - https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-session-attribs.</param>
        public AmazonLexRequest(Dictionary<string, string> RequestAttributes = null, Dictionary<string, string> SessionAttributes = null)
        {
            this.RequestAttributes = RequestAttributes;
            this.SessionAttributes = SessionAttributes;
            
        }
        
        
        
        /// <summary>
        /// AttributeName/AttributeValue pairs of User Defined Request Attributes to be sent to the amazon bot See - https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-request-attribs
        /// </summary>
        /// <value>AttributeName/AttributeValue pairs of User Defined Request Attributes to be sent to the amazon bot See - https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-request-attribs</value>
        [DataMember(Name="requestAttributes", EmitDefaultValue=false)]
        public Dictionary<string, string> RequestAttributes { get; set; }
        
        
        
        /// <summary>
        /// AttributeName/AttributeValue pairs of Session Attributes to be sent to the amazon bot. See - https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-session-attribs
        /// </summary>
        /// <value>AttributeName/AttributeValue pairs of Session Attributes to be sent to the amazon bot. See - https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-session-attribs</value>
        [DataMember(Name="sessionAttributes", EmitDefaultValue=false)]
        public Dictionary<string, string> SessionAttributes { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AmazonLexRequest {\n");
            
            sb.Append("  RequestAttributes: ").Append(RequestAttributes).Append("\n");
            sb.Append("  SessionAttributes: ").Append(SessionAttributes).Append("\n");
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
            return this.Equals(obj as AmazonLexRequest);
        }

        /// <summary>
        /// Returns true if AmazonLexRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AmazonLexRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmazonLexRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RequestAttributes == other.RequestAttributes ||
                    this.RequestAttributes != null &&
                    this.RequestAttributes.SequenceEqual(other.RequestAttributes)
                ) &&
                (
                    this.SessionAttributes == other.SessionAttributes ||
                    this.SessionAttributes != null &&
                    this.SessionAttributes.SequenceEqual(other.SessionAttributes)
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
                
                if (this.RequestAttributes != null)
                    hash = hash * 59 + this.RequestAttributes.GetHashCode();
                
                if (this.SessionAttributes != null)
                    hash = hash * 59 + this.SessionAttributes.GetHashCode();
                
                return hash;
            }
        }
    }

}
