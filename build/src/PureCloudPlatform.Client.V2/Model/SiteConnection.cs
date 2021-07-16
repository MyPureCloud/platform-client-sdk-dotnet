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
    /// SiteConnection
    /// </summary>
    [DataContract]
    public partial class SiteConnection :  IEquatable<SiteConnection>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Connection method from site to site (Direct, Indirect, CloudProxy
        /// </summary>
        /// <value>Connection method from site to site (Direct, Indirect, CloudProxy</value>
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
            /// Enum Direct for "Direct"
            /// </summary>
            [EnumMember(Value = "Direct")]
            Direct,
            
            /// <summary>
            /// Enum Indirect for "Indirect"
            /// </summary>
            [EnumMember(Value = "Indirect")]
            Indirect,
            
            /// <summary>
            /// Enum Cloudproxy for "CloudProxy"
            /// </summary>
            [EnumMember(Value = "CloudProxy")]
            Cloudproxy
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Media model for the current site.
        /// </summary>
        /// <value>Media model for the current site.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediaModelEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Premises for "Premises"
            /// </summary>
            [EnumMember(Value = "Premises")]
            Premises,
            
            /// <summary>
            /// Enum Cloud for "Cloud"
            /// </summary>
            [EnumMember(Value = "Cloud")]
            Cloud
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Connection method from site to site (Direct, Indirect, CloudProxy
        /// </summary>
        /// <value>Connection method from site to site (Direct, Indirect, CloudProxy</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        /// <summary>
        /// Media model for the current site.
        /// </summary>
        /// <value>Media model for the current site.</value>
        [DataMember(Name="mediaModel", EmitDefaultValue=false)]
        public MediaModelEnum? MediaModel { get; set; }
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteConnection" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="SelfUri">SelfUri.</param>
        /// <param name="Managed">Managed.</param>
        /// <param name="Type">Connection method from site to site (Direct, Indirect, CloudProxy.</param>
        /// <param name="Enabled">Indicates if the current site is linked.</param>
        /// <param name="EdgeList">All of the edges to which the site connects.</param>
        /// <param name="PrimaryCoreSites">List of site ids names and selfUris for the primary core sites.</param>
        /// <param name="SecondaryCoreSites">List of site ids names and selfUris for the secondary core sites.</param>
        public SiteConnection(string Id = null, string Name = null, string SelfUri = null, bool? Managed = null, TypeEnum? Type = null, bool? Enabled = null, List<ConnectedEdge> EdgeList = null, List<DomainEntityRef> PrimaryCoreSites = null, List<DomainEntityRef> SecondaryCoreSites = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.SelfUri = SelfUri;
            this.Managed = Managed;
            this.Type = Type;
            this.Enabled = Enabled;
            this.EdgeList = EdgeList;
            this.PrimaryCoreSites = PrimaryCoreSites;
            this.SecondaryCoreSites = SecondaryCoreSites;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Managed
        /// </summary>
        [DataMember(Name="managed", EmitDefaultValue=false)]
        public bool? Managed { get; set; }
        
        
        
        
        
        /// <summary>
        /// Indicates if the current site is linked
        /// </summary>
        /// <value>Indicates if the current site is linked</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        
        
        /// <summary>
        /// All of the edges to which the site connects
        /// </summary>
        /// <value>All of the edges to which the site connects</value>
        [DataMember(Name="edgeList", EmitDefaultValue=false)]
        public List<ConnectedEdge> EdgeList { get; set; }
        
        
        
        /// <summary>
        /// The core site
        /// </summary>
        /// <value>The core site</value>
        [DataMember(Name="coreSite", EmitDefaultValue=false)]
        public bool? CoreSite { get; private set; }
        
        
        
        /// <summary>
        /// List of site ids names and selfUris for the primary core sites
        /// </summary>
        /// <value>List of site ids names and selfUris for the primary core sites</value>
        [DataMember(Name="primaryCoreSites", EmitDefaultValue=false)]
        public List<DomainEntityRef> PrimaryCoreSites { get; set; }
        
        
        
        /// <summary>
        /// List of site ids names and selfUris for the secondary core sites
        /// </summary>
        /// <value>List of site ids names and selfUris for the secondary core sites</value>
        [DataMember(Name="secondaryCoreSites", EmitDefaultValue=false)]
        public List<DomainEntityRef> SecondaryCoreSites { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteConnection {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  Managed: ").Append(Managed).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MediaModel: ").Append(MediaModel).Append("\n");
            sb.Append("  EdgeList: ").Append(EdgeList).Append("\n");
            sb.Append("  CoreSite: ").Append(CoreSite).Append("\n");
            sb.Append("  PrimaryCoreSites: ").Append(PrimaryCoreSites).Append("\n");
            sb.Append("  SecondaryCoreSites: ").Append(SecondaryCoreSites).Append("\n");
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
            return this.Equals(obj as SiteConnection);
        }

        /// <summary>
        /// Returns true if SiteConnection instances are equal
        /// </summary>
        /// <param name="other">Instance of SiteConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SiteConnection other)
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
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.Managed == other.Managed ||
                    this.Managed != null &&
                    this.Managed.Equals(other.Managed)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.MediaModel == other.MediaModel ||
                    this.MediaModel != null &&
                    this.MediaModel.Equals(other.MediaModel)
                ) &&
                (
                    this.EdgeList == other.EdgeList ||
                    this.EdgeList != null &&
                    this.EdgeList.SequenceEqual(other.EdgeList)
                ) &&
                (
                    this.CoreSite == other.CoreSite ||
                    this.CoreSite != null &&
                    this.CoreSite.Equals(other.CoreSite)
                ) &&
                (
                    this.PrimaryCoreSites == other.PrimaryCoreSites ||
                    this.PrimaryCoreSites != null &&
                    this.PrimaryCoreSites.SequenceEqual(other.PrimaryCoreSites)
                ) &&
                (
                    this.SecondaryCoreSites == other.SecondaryCoreSites ||
                    this.SecondaryCoreSites != null &&
                    this.SecondaryCoreSites.SequenceEqual(other.SecondaryCoreSites)
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
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                if (this.Managed != null)
                    hash = hash * 59 + this.Managed.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.MediaModel != null)
                    hash = hash * 59 + this.MediaModel.GetHashCode();
                
                if (this.EdgeList != null)
                    hash = hash * 59 + this.EdgeList.GetHashCode();
                
                if (this.CoreSite != null)
                    hash = hash * 59 + this.CoreSite.GetHashCode();
                
                if (this.PrimaryCoreSites != null)
                    hash = hash * 59 + this.PrimaryCoreSites.GetHashCode();
                
                if (this.SecondaryCoreSites != null)
                    hash = hash * 59 + this.SecondaryCoreSites.GetHashCode();
                
                return hash;
            }
        }
    }

}
