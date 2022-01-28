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
            /// Enum Enus for "en-US"
            /// </summary>
            [EnumMember(Value = "en-US")]
            Enus,
            
            /// <summary>
            /// Enum Esus for "es-US"
            /// </summary>
            [EnumMember(Value = "es-US")]
            Esus,
            
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
            /// Enum Enin for "en-IN"
            /// </summary>
            [EnumMember(Value = "en-IN")]
            Enin,
            
            /// <summary>
            /// Enum Frfr for "fr-FR"
            /// </summary>
            [EnumMember(Value = "fr-FR")]
            Frfr,
            
            /// <summary>
            /// Enum Frca for "fr-CA"
            /// </summary>
            [EnumMember(Value = "fr-CA")]
            Frca,
            
            /// <summary>
            /// Enum Itit for "it-IT"
            /// </summary>
            [EnumMember(Value = "it-IT")]
            Itit,
            
            /// <summary>
            /// Enum Dede for "de-DE"
            /// </summary>
            [EnumMember(Value = "de-DE")]
            Dede,
            
            /// <summary>
            /// Enum Ptbr for "pt-BR"
            /// </summary>
            [EnumMember(Value = "pt-BR")]
            Ptbr,
            
            /// <summary>
            /// Enum Plpl for "pl-PL"
            /// </summary>
            [EnumMember(Value = "pl-PL")]
            Plpl
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
            Merge
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
