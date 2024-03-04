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
    /// MinerErrorInfo
    /// </summary>
    [DataContract]
    public partial class MinerErrorInfo :  IEquatable<MinerErrorInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinerErrorInfo" /> class.
        /// </summary>
        /// <param name="Message">Message.</param>
        /// <param name="Code">Code.</param>
        /// <param name="MessageWithParams">Error message with params included..</param>
        /// <param name="MessageParams">Map of variables and params for the error message..</param>
        public MinerErrorInfo(string Message = null, string Code = null, string MessageWithParams = null, Dictionary<string, Object> MessageParams = null)
        {
            this.Message = Message;
            this.Code = Code;
            this.MessageWithParams = MessageWithParams;
            this.MessageParams = MessageParams;
            
        }
        


        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// Error message with params included.
        /// </summary>
        /// <value>Error message with params included.</value>
        [DataMember(Name="messageWithParams", EmitDefaultValue=false)]
        public string MessageWithParams { get; set; }



        /// <summary>
        /// Map of variables and params for the error message.
        /// </summary>
        /// <value>Map of variables and params for the error message.</value>
        [DataMember(Name="messageParams", EmitDefaultValue=false)]
        public Dictionary<string, Object> MessageParams { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MinerErrorInfo {\n");

            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
            sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
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
            return this.Equals(obj as MinerErrorInfo);
        }

        /// <summary>
        /// Returns true if MinerErrorInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of MinerErrorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinerErrorInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.MessageWithParams == other.MessageWithParams ||
                    this.MessageWithParams != null &&
                    this.MessageWithParams.Equals(other.MessageWithParams)
                ) &&
                (
                    this.MessageParams == other.MessageParams ||
                    this.MessageParams != null &&
                    this.MessageParams.SequenceEqual(other.MessageParams)
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
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.MessageWithParams != null)
                    hash = hash * 59 + this.MessageWithParams.GetHashCode();

                if (this.MessageParams != null)
                    hash = hash * 59 + this.MessageParams.GetHashCode();

                return hash;
            }
        }
    }

}
