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
    /// Message content element.
    /// </summary>
    [DataContract]
    public partial class OpenInboundStructuredResponseNormalizedMessageContent :  IEquatable<OpenInboundStructuredResponseNormalizedMessageContent>
    {
        /// <summary>
        /// Type of this content element
        /// </summary>
        /// <value>Type of this content element</value>
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
            /// Enum Buttonresponse for "ButtonResponse"
            /// </summary>
            [EnumMember(Value = "ButtonResponse")]
            Buttonresponse
        }
        /// <summary>
        /// Type of this content element
        /// </summary>
        /// <value>Type of this content element</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public ContentTypeEnum? ContentType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenInboundStructuredResponseNormalizedMessageContent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpenInboundStructuredResponseNormalizedMessageContent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenInboundStructuredResponseNormalizedMessageContent" /> class.
        /// </summary>
        /// <param name="ContentType">Type of this content element (required).</param>
        /// <param name="ButtonResponse">Button response content..</param>
        public OpenInboundStructuredResponseNormalizedMessageContent(ContentTypeEnum? ContentType = null, ContentButtonResponse ButtonResponse = null)
        {
            this.ContentType = ContentType;
            this.ButtonResponse = ButtonResponse;
            
        }
        




        /// <summary>
        /// Button response content.
        /// </summary>
        /// <value>Button response content.</value>
        [DataMember(Name="buttonResponse", EmitDefaultValue=false)]
        public ContentButtonResponse ButtonResponse { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenInboundStructuredResponseNormalizedMessageContent {\n");

            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ButtonResponse: ").Append(ButtonResponse).Append("\n");
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
            return this.Equals(obj as OpenInboundStructuredResponseNormalizedMessageContent);
        }

        /// <summary>
        /// Returns true if OpenInboundStructuredResponseNormalizedMessageContent instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenInboundStructuredResponseNormalizedMessageContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenInboundStructuredResponseNormalizedMessageContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) &&
                (
                    this.ButtonResponse == other.ButtonResponse ||
                    this.ButtonResponse != null &&
                    this.ButtonResponse.Equals(other.ButtonResponse)
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
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();

                if (this.ButtonResponse != null)
                    hash = hash * 59 + this.ButtonResponse.GetHashCode();

                return hash;
            }
        }
    }

}
