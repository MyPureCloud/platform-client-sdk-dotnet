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
    /// KnowledgeBase
    /// </summary>
    [DataContract]
    public partial class KnowledgeBase :  IEquatable<KnowledgeBase>
    {
        /// <summary>
        /// Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with 'early preview' language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy.
        /// </summary>
        /// <value>Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with 'early preview' language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum CoreLanguageEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Enus for "en-US"
            /// </summary>
            [EnumMember(Value = "en-US")]
            Enus,
            
            /// <summary>
            /// Enum Enuk for "en-UK"
            /// </summary>
            [EnumMember(Value = "en-UK")]
            Enuk,
            
            /// <summary>
            /// Enum Enau for "en-AU"
            /// </summary>
            [EnumMember(Value = "en-AU")]
            Enau,
            
            /// <summary>
            /// Enum Enca for "en-CA"
            /// </summary>
            [EnumMember(Value = "en-CA")]
            Enca,
            
            /// <summary>
            /// Enum Enhk for "en-HK"
            /// </summary>
            [EnumMember(Value = "en-HK")]
            Enhk,
            
            /// <summary>
            /// Enum Enin for "en-IN"
            /// </summary>
            [EnumMember(Value = "en-IN")]
            Enin,
            
            /// <summary>
            /// Enum Enie for "en-IE"
            /// </summary>
            [EnumMember(Value = "en-IE")]
            Enie,
            
            /// <summary>
            /// Enum Ennz for "en-NZ"
            /// </summary>
            [EnumMember(Value = "en-NZ")]
            Ennz,
            
            /// <summary>
            /// Enum Enph for "en-PH"
            /// </summary>
            [EnumMember(Value = "en-PH")]
            Enph,
            
            /// <summary>
            /// Enum Ensg for "en-SG"
            /// </summary>
            [EnumMember(Value = "en-SG")]
            Ensg,
            
            /// <summary>
            /// Enum Enza for "en-ZA"
            /// </summary>
            [EnumMember(Value = "en-ZA")]
            Enza,
            
            /// <summary>
            /// Enum Dede for "de-DE"
            /// </summary>
            [EnumMember(Value = "de-DE")]
            Dede,
            
            /// <summary>
            /// Enum Deat for "de-AT"
            /// </summary>
            [EnumMember(Value = "de-AT")]
            Deat,
            
            /// <summary>
            /// Enum Dech for "de-CH"
            /// </summary>
            [EnumMember(Value = "de-CH")]
            Dech,
            
            /// <summary>
            /// Enum Esar for "es-AR"
            /// </summary>
            [EnumMember(Value = "es-AR")]
            Esar,
            
            /// <summary>
            /// Enum Esco for "es-CO"
            /// </summary>
            [EnumMember(Value = "es-CO")]
            Esco,
            
            /// <summary>
            /// Enum Esmx for "es-MX"
            /// </summary>
            [EnumMember(Value = "es-MX")]
            Esmx,
            
            /// <summary>
            /// Enum Esus for "es-US"
            /// </summary>
            [EnumMember(Value = "es-US")]
            Esus,
            
            /// <summary>
            /// Enum Eses for "es-ES"
            /// </summary>
            [EnumMember(Value = "es-ES")]
            Eses,
            
            /// <summary>
            /// Enum Frfr for "fr-FR"
            /// </summary>
            [EnumMember(Value = "fr-FR")]
            Frfr,
            
            /// <summary>
            /// Enum Frbe for "fr-BE"
            /// </summary>
            [EnumMember(Value = "fr-BE")]
            Frbe,
            
            /// <summary>
            /// Enum Frca for "fr-CA"
            /// </summary>
            [EnumMember(Value = "fr-CA")]
            Frca,
            
            /// <summary>
            /// Enum Frch for "fr-CH"
            /// </summary>
            [EnumMember(Value = "fr-CH")]
            Frch,
            
            /// <summary>
            /// Enum Ptbr for "pt-BR"
            /// </summary>
            [EnumMember(Value = "pt-BR")]
            Ptbr,
            
            /// <summary>
            /// Enum Ptpt for "pt-PT"
            /// </summary>
            [EnumMember(Value = "pt-PT")]
            Ptpt,
            
            /// <summary>
            /// Enum Nlnl for "nl-NL"
            /// </summary>
            [EnumMember(Value = "nl-NL")]
            Nlnl,
            
            /// <summary>
            /// Enum Nlbe for "nl-BE"
            /// </summary>
            [EnumMember(Value = "nl-BE")]
            Nlbe,
            
            /// <summary>
            /// Enum Itit for "it-IT"
            /// </summary>
            [EnumMember(Value = "it-IT")]
            Itit,
            
            /// <summary>
            /// Enum Caes for "ca-ES"
            /// </summary>
            [EnumMember(Value = "ca-ES")]
            Caes,
            
            /// <summary>
            /// Enum Trtr for "tr-TR"
            /// </summary>
            [EnumMember(Value = "tr-TR")]
            Trtr,
            
            /// <summary>
            /// Enum Svse for "sv-SE"
            /// </summary>
            [EnumMember(Value = "sv-SE")]
            Svse,
            
            /// <summary>
            /// Enum Fifi for "fi-FI"
            /// </summary>
            [EnumMember(Value = "fi-FI")]
            Fifi,
            
            /// <summary>
            /// Enum Nbno for "nb-NO"
            /// </summary>
            [EnumMember(Value = "nb-NO")]
            Nbno,
            
            /// <summary>
            /// Enum Dadk for "da-DK"
            /// </summary>
            [EnumMember(Value = "da-DK")]
            Dadk,
            
            /// <summary>
            /// Enum Jajp for "ja-JP"
            /// </summary>
            [EnumMember(Value = "ja-JP")]
            Jajp,
            
            /// <summary>
            /// Enum Arae for "ar-AE"
            /// </summary>
            [EnumMember(Value = "ar-AE")]
            Arae,
            
            /// <summary>
            /// Enum Zhcn for "zh-CN"
            /// </summary>
            [EnumMember(Value = "zh-CN")]
            Zhcn,
            
            /// <summary>
            /// Enum Zhtw for "zh-TW"
            /// </summary>
            [EnumMember(Value = "zh-TW")]
            Zhtw,
            
            /// <summary>
            /// Enum Zhhk for "zh-HK"
            /// </summary>
            [EnumMember(Value = "zh-HK")]
            Zhhk,
            
            /// <summary>
            /// Enum Kokr for "ko-KR"
            /// </summary>
            [EnumMember(Value = "ko-KR")]
            Kokr,
            
            /// <summary>
            /// Enum Plpl for "pl-PL"
            /// </summary>
            [EnumMember(Value = "pl-PL")]
            Plpl,
            
            /// <summary>
            /// Enum Hiin for "hi-IN"
            /// </summary>
            [EnumMember(Value = "hi-IN")]
            Hiin,
            
            /// <summary>
            /// Enum Thth for "th-TH"
            /// </summary>
            [EnumMember(Value = "th-TH")]
            Thth,
            
            /// <summary>
            /// Enum Huhu for "hu-HU"
            /// </summary>
            [EnumMember(Value = "hu-HU")]
            Huhu,
            
            /// <summary>
            /// Enum Vivn for "vi-VN"
            /// </summary>
            [EnumMember(Value = "vi-VN")]
            Vivn,
            
            /// <summary>
            /// Enum Ukua for "uk-UA"
            /// </summary>
            [EnumMember(Value = "uk-UA")]
            Ukua,
            
            /// <summary>
            /// Enum Cscz for "cs-CZ"
            /// </summary>
            [EnumMember(Value = "cs-CZ")]
            Cscz,
            
            /// <summary>
            /// Enum Filph for "fil-PH"
            /// </summary>
            [EnumMember(Value = "fil-PH")]
            Filph,
            
            /// <summary>
            /// Enum Msmy for "ms-MY"
            /// </summary>
            [EnumMember(Value = "ms-MY")]
            Msmy,
            
            /// <summary>
            /// Enum Heil for "he-IL"
            /// </summary>
            [EnumMember(Value = "he-IL")]
            Heil,
            
            /// <summary>
            /// Enum Elgr for "el-GR"
            /// </summary>
            [EnumMember(Value = "el-GR")]
            Elgr
        }
        /// <summary>
        /// Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with 'early preview' language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy.
        /// </summary>
        /// <value>Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with 'early preview' language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy.</value>
        [DataMember(Name="coreLanguage", EmitDefaultValue=false)]
        public CoreLanguageEnum? CoreLanguage { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBase" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Knowledge base description.</param>
        /// <param name="CoreLanguage">Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with &#39;early preview&#39; language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy. (required).</param>
        public KnowledgeBase(string Name = null, string Description = null, CoreLanguageEnum? CoreLanguage = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.CoreLanguage = CoreLanguage;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Knowledge base description
        /// </summary>
        /// <value>Knowledge base description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }





        /// <summary>
        /// Knowledge base creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Knowledge base creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Knowledge base last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Knowledge base last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// The count representing the number of documents of type FAQ in the KnowledgeBase
        /// </summary>
        /// <value>The count representing the number of documents of type FAQ in the KnowledgeBase</value>
        [DataMember(Name="faqCount", EmitDefaultValue=false)]
        public int? FaqCount { get; private set; }



        /// <summary>
        /// The date representing when the last document is modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date representing when the last document is modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateDocumentLastModified", EmitDefaultValue=false)]
        public DateTime? DateDocumentLastModified { get; private set; }



        /// <summary>
        /// The count representing the number of documents of type Article in the KnowledgeBase
        /// </summary>
        /// <value>The count representing the number of documents of type Article in the KnowledgeBase</value>
        [DataMember(Name="articleCount", EmitDefaultValue=false)]
        public int? ArticleCount { get; private set; }



        /// <summary>
        /// Flag that indicates the knowledge base is published
        /// </summary>
        /// <value>Flag that indicates the knowledge base is published</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeBase {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CoreLanguage: ").Append(CoreLanguage).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  FaqCount: ").Append(FaqCount).Append("\n");
            sb.Append("  DateDocumentLastModified: ").Append(DateDocumentLastModified).Append("\n");
            sb.Append("  ArticleCount: ").Append(ArticleCount).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as KnowledgeBase);
        }

        /// <summary>
        /// Returns true if KnowledgeBase instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeBase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.CoreLanguage == other.CoreLanguage ||
                    this.CoreLanguage != null &&
                    this.CoreLanguage.Equals(other.CoreLanguage)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.FaqCount == other.FaqCount ||
                    this.FaqCount != null &&
                    this.FaqCount.Equals(other.FaqCount)
                ) &&
                (
                    this.DateDocumentLastModified == other.DateDocumentLastModified ||
                    this.DateDocumentLastModified != null &&
                    this.DateDocumentLastModified.Equals(other.DateDocumentLastModified)
                ) &&
                (
                    this.ArticleCount == other.ArticleCount ||
                    this.ArticleCount != null &&
                    this.ArticleCount.Equals(other.ArticleCount)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.CoreLanguage != null)
                    hash = hash * 59 + this.CoreLanguage.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.FaqCount != null)
                    hash = hash * 59 + this.FaqCount.GetHashCode();

                if (this.DateDocumentLastModified != null)
                    hash = hash * 59 + this.DateDocumentLastModified.GetHashCode();

                if (this.ArticleCount != null)
                    hash = hash * 59 + this.ArticleCount.GetHashCode();

                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
