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
    /// KnowledgeExtendedCategory
    /// </summary>
    [DataContract]
    public partial class KnowledgeExtendedCategory :  IEquatable<KnowledgeExtendedCategory>
    {
        /// <summary>
        /// Actual language of the category
        /// </summary>
        /// <value>Actual language of the category</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LanguageCodeEnum
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
            Ukua
        }
        /// <summary>
        /// Actual language of the category
        /// </summary>
        /// <value>Actual language of the category</value>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public LanguageCodeEnum? LanguageCode { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeExtendedCategory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnowledgeExtendedCategory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeExtendedCategory" /> class.
        /// </summary>
        /// <param name="Name">Category name (required).</param>
        /// <param name="Description">Category description.</param>
        public KnowledgeExtendedCategory(string Name = null, string Description = null)
        {
            this.Name = Name;
            this.Description = Description;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Category name
        /// </summary>
        /// <value>Category name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Category description
        /// </summary>
        /// <value>Category description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// Knowledge base which category does belong to
        /// </summary>
        /// <value>Knowledge base which category does belong to</value>
        [DataMember(Name="knowledgeBase", EmitDefaultValue=false)]
        public KnowledgeBase KnowledgeBase { get; private set; }





        /// <summary>
        /// Category creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Category creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Category last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Category last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// Category parent
        /// </summary>
        /// <value>Category parent</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public KnowledgeCategory Parent { get; private set; }



        /// <summary>
        /// Category children
        /// </summary>
        /// <value>Category children</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<KnowledgeCategory> Children { get; private set; }



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
            sb.Append("class KnowledgeExtendedCategory {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
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
            return this.Equals(obj as KnowledgeExtendedCategory);
        }

        /// <summary>
        /// Returns true if KnowledgeExtendedCategory instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeExtendedCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeExtendedCategory other)
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
                    this.KnowledgeBase == other.KnowledgeBase ||
                    this.KnowledgeBase != null &&
                    this.KnowledgeBase.Equals(other.KnowledgeBase)
                ) &&
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
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
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) &&
                (
                    this.Children == other.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(other.Children)
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

                if (this.KnowledgeBase != null)
                    hash = hash * 59 + this.KnowledgeBase.GetHashCode();

                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();

                if (this.Children != null)
                    hash = hash * 59 + this.Children.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
