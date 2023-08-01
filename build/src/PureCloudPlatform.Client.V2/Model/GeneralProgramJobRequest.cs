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
    /// GeneralProgramJobRequest
    /// </summary>
    [DataContract]
    public partial class GeneralProgramJobRequest :  IEquatable<GeneralProgramJobRequest>
    {
        /// <summary>
        /// The dialect of the topics to link with the general program, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard
        /// </summary>
        /// <value>The dialect of the topics to link with the general program, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DialectEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ar001 for "ar-001"
            /// </summary>
            [EnumMember(Value = "ar-001")]
            Ar001,
            
            /// <summary>
            /// Enum Arae for "ar-AE"
            /// </summary>
            [EnumMember(Value = "ar-AE")]
            Arae,
            
            /// <summary>
            /// Enum Arbh for "ar-BH"
            /// </summary>
            [EnumMember(Value = "ar-BH")]
            Arbh,
            
            /// <summary>
            /// Enum Areg for "ar-EG"
            /// </summary>
            [EnumMember(Value = "ar-EG")]
            Areg,
            
            /// <summary>
            /// Enum Aril for "ar-IL"
            /// </summary>
            [EnumMember(Value = "ar-IL")]
            Aril,
            
            /// <summary>
            /// Enum Arsa for "ar-SA"
            /// </summary>
            [EnumMember(Value = "ar-SA")]
            Arsa,
            
            /// <summary>
            /// Enum Artn for "ar-TN"
            /// </summary>
            [EnumMember(Value = "ar-TN")]
            Artn,
            
            /// <summary>
            /// Enum Dech for "de-CH"
            /// </summary>
            [EnumMember(Value = "de-CH")]
            Dech,
            
            /// <summary>
            /// Enum Dede for "de-DE"
            /// </summary>
            [EnumMember(Value = "de-DE")]
            Dede,
            
            /// <summary>
            /// Enum Enau for "en-AU"
            /// </summary>
            [EnumMember(Value = "en-AU")]
            Enau,
            
            /// <summary>
            /// Enum Engb for "en-GB"
            /// </summary>
            [EnumMember(Value = "en-GB")]
            Engb,
            
            /// <summary>
            /// Enum Enhk for "en-HK"
            /// </summary>
            [EnumMember(Value = "en-HK")]
            Enhk,
            
            /// <summary>
            /// Enum Enie for "en-IE"
            /// </summary>
            [EnumMember(Value = "en-IE")]
            Enie,
            
            /// <summary>
            /// Enum Enin for "en-IN"
            /// </summary>
            [EnumMember(Value = "en-IN")]
            Enin,
            
            /// <summary>
            /// Enum Ennz for "en-NZ"
            /// </summary>
            [EnumMember(Value = "en-NZ")]
            Ennz,
            
            /// <summary>
            /// Enum Ensg for "en-SG"
            /// </summary>
            [EnumMember(Value = "en-SG")]
            Ensg,
            
            /// <summary>
            /// Enum Enus for "en-US"
            /// </summary>
            [EnumMember(Value = "en-US")]
            Enus,
            
            /// <summary>
            /// Enum Enza for "en-ZA"
            /// </summary>
            [EnumMember(Value = "en-ZA")]
            Enza,
            
            /// <summary>
            /// Enum Eses for "es-ES"
            /// </summary>
            [EnumMember(Value = "es-ES")]
            Eses,
            
            /// <summary>
            /// Enum Esus for "es-US"
            /// </summary>
            [EnumMember(Value = "es-US")]
            Esus,
            
            /// <summary>
            /// Enum Frca for "fr-CA"
            /// </summary>
            [EnumMember(Value = "fr-CA")]
            Frca,
            
            /// <summary>
            /// Enum Frfr for "fr-FR"
            /// </summary>
            [EnumMember(Value = "fr-FR")]
            Frfr,
            
            /// <summary>
            /// Enum Itit for "it-IT"
            /// </summary>
            [EnumMember(Value = "it-IT")]
            Itit,
            
            /// <summary>
            /// Enum Jajp for "ja-JP"
            /// </summary>
            [EnumMember(Value = "ja-JP")]
            Jajp,
            
            /// <summary>
            /// Enum Kokr for "ko-KR"
            /// </summary>
            [EnumMember(Value = "ko-KR")]
            Kokr,
            
            /// <summary>
            /// Enum Nlnl for "nl-NL"
            /// </summary>
            [EnumMember(Value = "nl-NL")]
            Nlnl,
            
            /// <summary>
            /// Enum Plpl for "pl-PL"
            /// </summary>
            [EnumMember(Value = "pl-PL")]
            Plpl,
            
            /// <summary>
            /// Enum Ptbr for "pt-BR"
            /// </summary>
            [EnumMember(Value = "pt-BR")]
            Ptbr,
            
            /// <summary>
            /// Enum Ptpt for "pt-PT"
            /// </summary>
            [EnumMember(Value = "pt-PT")]
            Ptpt
        }
        /// <summary>
        /// The mode to use for the general program job, default value is Skip
        /// </summary>
        /// <value>The mode to use for the general program job, default value is Skip</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Skip for "Skip"
            /// </summary>
            [EnumMember(Value = "Skip")]
            Skip,
            
            /// <summary>
            /// Enum Merge for "Merge"
            /// </summary>
            [EnumMember(Value = "Merge")]
            Merge,
            
            /// <summary>
            /// Enum Replacemerge for "ReplaceMerge"
            /// </summary>
            [EnumMember(Value = "ReplaceMerge")]
            Replacemerge
        }
        /// <summary>
        /// The dialect of the topics to link with the general program, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard
        /// </summary>
        /// <value>The dialect of the topics to link with the general program, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard</value>
        [DataMember(Name="dialect", EmitDefaultValue=false)]
        public DialectEnum? Dialect { get; set; }
        /// <summary>
        /// The mode to use for the general program job, default value is Skip
        /// </summary>
        /// <value>The mode to use for the general program job, default value is Skip</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralProgramJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeneralProgramJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralProgramJobRequest" /> class.
        /// </summary>
        /// <param name="Dialect">The dialect of the topics to link with the general program, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (required).</param>
        /// <param name="Mode">The mode to use for the general program job, default value is Skip.</param>
        public GeneralProgramJobRequest(DialectEnum? Dialect = null, ModeEnum? Mode = null)
        {
            this.Dialect = Dialect;
            this.Mode = Mode;
            
        }
        





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneralProgramJobRequest {\n");

            sb.Append("  Dialect: ").Append(Dialect).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
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
            return this.Equals(obj as GeneralProgramJobRequest);
        }

        /// <summary>
        /// Returns true if GeneralProgramJobRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GeneralProgramJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeneralProgramJobRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Dialect == other.Dialect ||
                    this.Dialect != null &&
                    this.Dialect.Equals(other.Dialect)
                ) &&
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
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
                if (this.Dialect != null)
                    hash = hash * 59 + this.Dialect.GetHashCode();

                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();

                return hash;
            }
        }
    }

}
