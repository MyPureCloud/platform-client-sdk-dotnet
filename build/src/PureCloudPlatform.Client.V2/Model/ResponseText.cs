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
    /// Contains information about the text associated with a response.
    /// </summary>
    [DataContract]
    public partial class ResponseText :  IEquatable<ResponseText>
    {
        
        
        
        
        
        /// <summary>
        /// Response text content type.
        /// </summary>
        /// <value>Response text content type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ContentTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Textplain for "text/plain"
            /// </summary>
            [EnumMember(Value = "text/plain")]
            Textplain,
            
            /// <summary>
            /// Enum Texthtml for "text/html"
            /// </summary>
            [EnumMember(Value = "text/html")]
            Texthtml
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Response text content type.
        /// </summary>
        /// <value>Response text content type.</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseText" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseText() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseText" /> class.
        /// </summary>
        
        
        /// <param name="Content">Response text content. (required).</param>
        
        
        
        /// <param name="ContentType">Response text content type..</param>
        
        
        public ResponseText(string Content = null, ContentTypeEnum? ContentType = null)
        {
            
            
            
            // to ensure "Content" is required (not null)
            if (Content == null)
            {
                throw new InvalidDataException("Content is a required property for ResponseText and cannot be null");
            }
            else
            {
                this.Content = Content;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.ContentType = ContentType;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Response text content.
        /// </summary>
        /// <value>Response text content.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseText {\n");
            
            sb.Append("  Content: ").Append(Content).Append("\n");
            
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            
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
            return this.Equals(obj as ResponseText);
        }

        /// <summary>
        /// Returns true if ResponseText instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseText to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseText other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
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
                
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                
                return hash;
            }
        }
    }

}
