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
    /// FlowHealthIntent
    /// </summary>
    [DataContract]
    public partial class FlowHealthIntent :  IEquatable<FlowHealthIntent>
    {
        /// <summary>
        /// Language provided for this intent's health.
        /// </summary>
        /// <value>Language provided for this intent's health.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LanguageEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Enus for "en-us"
            /// </summary>
            [EnumMember(Value = "en-us")]
            Enus,
            
            /// <summary>
            /// Enum Engb for "en-gb"
            /// </summary>
            [EnumMember(Value = "en-gb")]
            Engb,
            
            /// <summary>
            /// Enum Enau for "en-au"
            /// </summary>
            [EnumMember(Value = "en-au")]
            Enau,
            
            /// <summary>
            /// Enum Enza for "en-za"
            /// </summary>
            [EnumMember(Value = "en-za")]
            Enza,
            
            /// <summary>
            /// Enum Ennz for "en-nz"
            /// </summary>
            [EnumMember(Value = "en-nz")]
            Ennz,
            
            /// <summary>
            /// Enum Enie for "en-ie"
            /// </summary>
            [EnumMember(Value = "en-ie")]
            Enie,
            
            /// <summary>
            /// Enum Frca for "fr-ca"
            /// </summary>
            [EnumMember(Value = "fr-ca")]
            Frca,
            
            /// <summary>
            /// Enum Frfr for "fr-fr"
            /// </summary>
            [EnumMember(Value = "fr-fr")]
            Frfr,
            
            /// <summary>
            /// Enum Esus for "es-us"
            /// </summary>
            [EnumMember(Value = "es-us")]
            Esus,
            
            /// <summary>
            /// Enum Eses for "es-es"
            /// </summary>
            [EnumMember(Value = "es-es")]
            Eses,
            
            /// <summary>
            /// Enum Esmx for "es-mx"
            /// </summary>
            [EnumMember(Value = "es-mx")]
            Esmx,
            
            /// <summary>
            /// Enum Dede for "de-de"
            /// </summary>
            [EnumMember(Value = "de-de")]
            Dede,
            
            /// <summary>
            /// Enum Itit for "it-it"
            /// </summary>
            [EnumMember(Value = "it-it")]
            Itit,
            
            /// <summary>
            /// Enum Ptbr for "pt-br"
            /// </summary>
            [EnumMember(Value = "pt-br")]
            Ptbr,
            
            /// <summary>
            /// Enum Ptpt for "pt-pt"
            /// </summary>
            [EnumMember(Value = "pt-pt")]
            Ptpt,
            
            /// <summary>
            /// Enum Nlnl for "nl-nl"
            /// </summary>
            [EnumMember(Value = "nl-nl")]
            Nlnl
        }
        /// <summary>
        /// Language provided for this intent's health.
        /// </summary>
        /// <value>Language provided for this intent's health.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public LanguageEnum? Language { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowHealthIntent" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="FlowVersionInfo">Info about given flow version..</param>
        /// <param name="Language">Language provided for this intent&#39;s health..</param>
        /// <param name="Health">Health computation details for given language..</param>
        public FlowHealthIntent(string Name = null, FlowHealthIntentVersionInfo FlowVersionInfo = null, LanguageEnum? Language = null, HealthInfo Health = null)
        {
            this.Name = Name;
            this.FlowVersionInfo = FlowVersionInfo;
            this.Language = Language;
            this.Health = Health;
            
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
        /// Info about given flow version.
        /// </summary>
        /// <value>Info about given flow version.</value>
        [DataMember(Name="flowVersionInfo", EmitDefaultValue=false)]
        public FlowHealthIntentVersionInfo FlowVersionInfo { get; set; }





        /// <summary>
        /// Health computation details for given language.
        /// </summary>
        /// <value>Health computation details for given language.</value>
        [DataMember(Name="health", EmitDefaultValue=false)]
        public HealthInfo Health { get; set; }



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
            sb.Append("class FlowHealthIntent {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FlowVersionInfo: ").Append(FlowVersionInfo).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Health: ").Append(Health).Append("\n");
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
            return this.Equals(obj as FlowHealthIntent);
        }

        /// <summary>
        /// Returns true if FlowHealthIntent instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowHealthIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowHealthIntent other)
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
                    this.FlowVersionInfo == other.FlowVersionInfo ||
                    this.FlowVersionInfo != null &&
                    this.FlowVersionInfo.Equals(other.FlowVersionInfo)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.Health == other.Health ||
                    this.Health != null &&
                    this.Health.Equals(other.Health)
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

                if (this.FlowVersionInfo != null)
                    hash = hash * 59 + this.FlowVersionInfo.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.Health != null)
                    hash = hash * 59 + this.Health.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
