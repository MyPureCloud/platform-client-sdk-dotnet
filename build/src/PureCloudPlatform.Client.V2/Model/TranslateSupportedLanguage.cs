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
    /// TranslateSupportedLanguage
    /// </summary>
    [DataContract]
    public partial class TranslateSupportedLanguage :  IEquatable<TranslateSupportedLanguage>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateSupportedLanguage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TranslateSupportedLanguage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateSupportedLanguage" /> class.
        /// </summary>
        /// <param name="LanguageName">Supported translation language name, natively spelled (ex. Español) (required).</param>
        /// <param name="LanguageCode">Supported translation language code. See - https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html#what-is-languages-supported (required).</param>
        public TranslateSupportedLanguage(string LanguageName = null, string LanguageCode = null)
        {
            this.LanguageName = LanguageName;
            this.LanguageCode = LanguageCode;
            
        }
        


        /// <summary>
        /// Supported translation language name, natively spelled (ex. Español)
        /// </summary>
        /// <value>Supported translation language name, natively spelled (ex. Español)</value>
        [DataMember(Name="languageName", EmitDefaultValue=false)]
        public string LanguageName { get; set; }



        /// <summary>
        /// Supported translation language code. See - https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html#what-is-languages-supported
        /// </summary>
        /// <value>Supported translation language code. See - https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html#what-is-languages-supported</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TranslateSupportedLanguage {\n");

            sb.Append("  LanguageName: ").Append(LanguageName).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
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
            return this.Equals(obj as TranslateSupportedLanguage);
        }

        /// <summary>
        /// Returns true if TranslateSupportedLanguage instances are equal
        /// </summary>
        /// <param name="other">Instance of TranslateSupportedLanguage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TranslateSupportedLanguage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LanguageName == other.LanguageName ||
                    this.LanguageName != null &&
                    this.LanguageName.Equals(other.LanguageName)
                ) &&
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
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
                if (this.LanguageName != null)
                    hash = hash * 59 + this.LanguageName.GetHashCode();

                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();

                return hash;
            }
        }
    }

}
