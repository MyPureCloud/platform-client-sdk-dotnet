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
    /// AutoSearchConfig
    /// </summary>
    [DataContract]
    public partial class AutoSearchConfig :  IEquatable<AutoSearchConfig>
    {
        /// <summary>
        /// Auto search configuration type.
        /// </summary>
        /// <value>Auto search configuration type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Articlesonly for "ArticlesOnly"
            /// </summary>
            [EnumMember(Value = "ArticlesOnly")]
            Articlesonly,
            
            /// <summary>
            /// Enum Articleswithanswerhighlights for "ArticlesWithAnswerHighlights"
            /// </summary>
            [EnumMember(Value = "ArticlesWithAnswerHighlights")]
            Articleswithanswerhighlights,
            
            /// <summary>
            /// Enum Answergeneration for "AnswerGeneration"
            /// </summary>
            [EnumMember(Value = "AnswerGeneration")]
            Answergeneration
        }
        /// <summary>
        /// Auto search configuration type.
        /// </summary>
        /// <value>Auto search configuration type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSearchConfig" /> class.
        /// </summary>
        /// <param name="Type">Auto search configuration type..</param>
        public AutoSearchConfig(TypeEnum? Type = null)
        {
            this.Type = Type;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoSearchConfig {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as AutoSearchConfig);
        }

        /// <summary>
        /// Returns true if AutoSearchConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of AutoSearchConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoSearchConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}
