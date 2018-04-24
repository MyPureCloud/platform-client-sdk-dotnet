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
    /// Represents a listing in the AppFoundry
    /// </summary>
    [DataContract]
    public partial class AppFoundryListing :  IEquatable<AppFoundryListing>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AppFoundryListing" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Localized name.</param>
        
        
        
        /// <param name="RegistryInfo">Provides information about the integration implementation.</param>
        
        
        
        /// <param name="MarketingInfo">Marketing data.</param>
        
        
        
        /// <param name="Tagline">Localized tagline.</param>
        
        
        
        /// <param name="BriefDescription">Localized short description.</param>
        
        
        
        /// <param name="FullDescription">Localized full description.</param>
        
        
        
        /// <param name="Platform">The supported platform.</param>
        
        
        
        /// <param name="CompanyLogo">URL to the company logo to be displayed.</param>
        
        
        
        /// <param name="AppLogo">URL to the app logo to be displayed.</param>
        
        
        
        /// <param name="CompanyName">Localized company name for the listing publisher.</param>
        
        
        
        /// <param name="Website">Localized URL to the website associated with the listing.</param>
        
        
        
        /// <param name="Screenshots">Screenshot URLS.</param>
        
        
        
        /// <param name="VideoLinks">Usage video URLS.</param>
        
        
        
        /// <param name="Languages">Indicates the languages that the application supports. Supported application languages may differ from the listing localization languages.</param>
        
        
        
        /// <param name="VendorEmail">Contact email for the listing publisher.</param>
        
        
        
        /// <param name="TermsOfService">URL to the terms of service.</param>
        
        
        
        /// <param name="HelpDocumentationURL">URL to help documentation.</param>
        
        
        
        /// <param name="MarketingURL">URL to external marketing page.</param>
        
        
        
        /// <param name="Industries">Industries targeted.</param>
        
        
        
        /// <param name="Categories">Indicated the categories the listing belongs to.</param>
        
        
        
        /// <param name="SmartCases">Use cases the listing is meant to address.</param>
        
        
        
        /// <param name="Pricing">Pricing options for the listing.</param>
        
        
        
        
        public AppFoundryListing(LocalizedField Name = null, AppFoundryListingRegistryInfo RegistryInfo = null, MarketingInfo MarketingInfo = null, LocalizedField Tagline = null, LocalizedField BriefDescription = null, LocalizedField FullDescription = null, Platform Platform = null, string CompanyLogo = null, string AppLogo = null, LocalizedField CompanyName = null, LocalizedField Website = null, List<string> Screenshots = null, List<string> VideoLinks = null, List<string> Languages = null, string VendorEmail = null, string TermsOfService = null, LocalizedField HelpDocumentationURL = null, LocalizedField MarketingURL = null, List<string> Industries = null, List<string> Categories = null, List<SmartCase> SmartCases = null, List<PricingOption> Pricing = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.RegistryInfo = RegistryInfo;
            
            
            
            
            
            
            
            
this.MarketingInfo = MarketingInfo;
            
            
            
            
            
            
            
            
this.Tagline = Tagline;
            
            
            
            
            
            
            
            
this.BriefDescription = BriefDescription;
            
            
            
            
            
            
            
            
this.FullDescription = FullDescription;
            
            
            
            
            
            
            
            
this.Platform = Platform;
            
            
            
            
            
            
            
            
this.CompanyLogo = CompanyLogo;
            
            
            
            
            
            
            
            
this.AppLogo = AppLogo;
            
            
            
            
            
            
            
            
this.CompanyName = CompanyName;
            
            
            
            
            
            
            
            
this.Website = Website;
            
            
            
            
            
            
            
            
this.Screenshots = Screenshots;
            
            
            
            
            
            
            
            
this.VideoLinks = VideoLinks;
            
            
            
            
            
            
            
            
this.Languages = Languages;
            
            
            
            
            
            
            
            
this.VendorEmail = VendorEmail;
            
            
            
            
            
            
            
            
this.TermsOfService = TermsOfService;
            
            
            
            
            
            
            
            
this.HelpDocumentationURL = HelpDocumentationURL;
            
            
            
            
            
            
            
            
this.MarketingURL = MarketingURL;
            
            
            
            
            
            
            
            
this.Industries = Industries;
            
            
            
            
            
            
            
            
this.Categories = Categories;
            
            
            
            
            
            
            
            
this.SmartCases = SmartCases;
            
            
            
            
            
            
            
            
this.Pricing = Pricing;
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Localized name
        /// </summary>
        /// <value>Localized name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public LocalizedField Name { get; set; }
        
        
        
        /// <summary>
        /// Provides information about the integration implementation
        /// </summary>
        /// <value>Provides information about the integration implementation</value>
        [DataMember(Name="registryInfo", EmitDefaultValue=false)]
        public AppFoundryListingRegistryInfo RegistryInfo { get; set; }
        
        
        
        /// <summary>
        /// Marketing data
        /// </summary>
        /// <value>Marketing data</value>
        [DataMember(Name="marketingInfo", EmitDefaultValue=false)]
        public MarketingInfo MarketingInfo { get; set; }
        
        
        
        /// <summary>
        /// Localized tagline
        /// </summary>
        /// <value>Localized tagline</value>
        [DataMember(Name="tagline", EmitDefaultValue=false)]
        public LocalizedField Tagline { get; set; }
        
        
        
        /// <summary>
        /// Localized short description
        /// </summary>
        /// <value>Localized short description</value>
        [DataMember(Name="briefDescription", EmitDefaultValue=false)]
        public LocalizedField BriefDescription { get; set; }
        
        
        
        /// <summary>
        /// Localized full description
        /// </summary>
        /// <value>Localized full description</value>
        [DataMember(Name="fullDescription", EmitDefaultValue=false)]
        public LocalizedField FullDescription { get; set; }
        
        
        
        /// <summary>
        /// The supported platform
        /// </summary>
        /// <value>The supported platform</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public Platform Platform { get; set; }
        
        
        
        /// <summary>
        /// URL to the company logo to be displayed
        /// </summary>
        /// <value>URL to the company logo to be displayed</value>
        [DataMember(Name="companyLogo", EmitDefaultValue=false)]
        public string CompanyLogo { get; set; }
        
        
        
        /// <summary>
        /// URL to the app logo to be displayed
        /// </summary>
        /// <value>URL to the app logo to be displayed</value>
        [DataMember(Name="appLogo", EmitDefaultValue=false)]
        public string AppLogo { get; set; }
        
        
        
        /// <summary>
        /// Localized company name for the listing publisher
        /// </summary>
        /// <value>Localized company name for the listing publisher</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public LocalizedField CompanyName { get; set; }
        
        
        
        /// <summary>
        /// Localized URL to the website associated with the listing
        /// </summary>
        /// <value>Localized URL to the website associated with the listing</value>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public LocalizedField Website { get; set; }
        
        
        
        /// <summary>
        /// Screenshot URLS
        /// </summary>
        /// <value>Screenshot URLS</value>
        [DataMember(Name="screenshots", EmitDefaultValue=false)]
        public List<string> Screenshots { get; set; }
        
        
        
        /// <summary>
        /// Usage video URLS
        /// </summary>
        /// <value>Usage video URLS</value>
        [DataMember(Name="videoLinks", EmitDefaultValue=false)]
        public List<string> VideoLinks { get; set; }
        
        
        
        /// <summary>
        /// Indicates the languages that the application supports. Supported application languages may differ from the listing localization languages
        /// </summary>
        /// <value>Indicates the languages that the application supports. Supported application languages may differ from the listing localization languages</value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<string> Languages { get; set; }
        
        
        
        /// <summary>
        /// Contact email for the listing publisher
        /// </summary>
        /// <value>Contact email for the listing publisher</value>
        [DataMember(Name="vendorEmail", EmitDefaultValue=false)]
        public string VendorEmail { get; set; }
        
        
        
        /// <summary>
        /// URL to the terms of service
        /// </summary>
        /// <value>URL to the terms of service</value>
        [DataMember(Name="termsOfService", EmitDefaultValue=false)]
        public string TermsOfService { get; set; }
        
        
        
        /// <summary>
        /// URL to help documentation
        /// </summary>
        /// <value>URL to help documentation</value>
        [DataMember(Name="helpDocumentationURL", EmitDefaultValue=false)]
        public LocalizedField HelpDocumentationURL { get; set; }
        
        
        
        /// <summary>
        /// URL to external marketing page
        /// </summary>
        /// <value>URL to external marketing page</value>
        [DataMember(Name="marketingURL", EmitDefaultValue=false)]
        public LocalizedField MarketingURL { get; set; }
        
        
        
        /// <summary>
        /// Industries targeted
        /// </summary>
        /// <value>Industries targeted</value>
        [DataMember(Name="industries", EmitDefaultValue=false)]
        public List<string> Industries { get; set; }
        
        
        
        /// <summary>
        /// Indicated the categories the listing belongs to
        /// </summary>
        /// <value>Indicated the categories the listing belongs to</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<string> Categories { get; set; }
        
        
        
        /// <summary>
        /// Use cases the listing is meant to address
        /// </summary>
        /// <value>Use cases the listing is meant to address</value>
        [DataMember(Name="smartCases", EmitDefaultValue=false)]
        public List<SmartCase> SmartCases { get; set; }
        
        
        
        /// <summary>
        /// Pricing options for the listing
        /// </summary>
        /// <value>Pricing options for the listing</value>
        [DataMember(Name="pricing", EmitDefaultValue=false)]
        public List<PricingOption> Pricing { get; set; }
        
        
        
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
            sb.Append("class AppFoundryListing {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  RegistryInfo: ").Append(RegistryInfo).Append("\n");
            
            sb.Append("  MarketingInfo: ").Append(MarketingInfo).Append("\n");
            
            sb.Append("  Tagline: ").Append(Tagline).Append("\n");
            
            sb.Append("  BriefDescription: ").Append(BriefDescription).Append("\n");
            
            sb.Append("  FullDescription: ").Append(FullDescription).Append("\n");
            
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            
            sb.Append("  CompanyLogo: ").Append(CompanyLogo).Append("\n");
            
            sb.Append("  AppLogo: ").Append(AppLogo).Append("\n");
            
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            
            sb.Append("  Website: ").Append(Website).Append("\n");
            
            sb.Append("  Screenshots: ").Append(Screenshots).Append("\n");
            
            sb.Append("  VideoLinks: ").Append(VideoLinks).Append("\n");
            
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            
            sb.Append("  VendorEmail: ").Append(VendorEmail).Append("\n");
            
            sb.Append("  TermsOfService: ").Append(TermsOfService).Append("\n");
            
            sb.Append("  HelpDocumentationURL: ").Append(HelpDocumentationURL).Append("\n");
            
            sb.Append("  MarketingURL: ").Append(MarketingURL).Append("\n");
            
            sb.Append("  Industries: ").Append(Industries).Append("\n");
            
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            
            sb.Append("  SmartCases: ").Append(SmartCases).Append("\n");
            
            sb.Append("  Pricing: ").Append(Pricing).Append("\n");
            
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AppFoundryListing);
        }

        /// <summary>
        /// Returns true if AppFoundryListing instances are equal
        /// </summary>
        /// <param name="other">Instance of AppFoundryListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppFoundryListing other)
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
                    this.RegistryInfo == other.RegistryInfo ||
                    this.RegistryInfo != null &&
                    this.RegistryInfo.Equals(other.RegistryInfo)
                ) &&
                (
                    this.MarketingInfo == other.MarketingInfo ||
                    this.MarketingInfo != null &&
                    this.MarketingInfo.Equals(other.MarketingInfo)
                ) &&
                (
                    this.Tagline == other.Tagline ||
                    this.Tagline != null &&
                    this.Tagline.Equals(other.Tagline)
                ) &&
                (
                    this.BriefDescription == other.BriefDescription ||
                    this.BriefDescription != null &&
                    this.BriefDescription.Equals(other.BriefDescription)
                ) &&
                (
                    this.FullDescription == other.FullDescription ||
                    this.FullDescription != null &&
                    this.FullDescription.Equals(other.FullDescription)
                ) &&
                (
                    this.Platform == other.Platform ||
                    this.Platform != null &&
                    this.Platform.Equals(other.Platform)
                ) &&
                (
                    this.CompanyLogo == other.CompanyLogo ||
                    this.CompanyLogo != null &&
                    this.CompanyLogo.Equals(other.CompanyLogo)
                ) &&
                (
                    this.AppLogo == other.AppLogo ||
                    this.AppLogo != null &&
                    this.AppLogo.Equals(other.AppLogo)
                ) &&
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) &&
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) &&
                (
                    this.Screenshots == other.Screenshots ||
                    this.Screenshots != null &&
                    this.Screenshots.SequenceEqual(other.Screenshots)
                ) &&
                (
                    this.VideoLinks == other.VideoLinks ||
                    this.VideoLinks != null &&
                    this.VideoLinks.SequenceEqual(other.VideoLinks)
                ) &&
                (
                    this.Languages == other.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(other.Languages)
                ) &&
                (
                    this.VendorEmail == other.VendorEmail ||
                    this.VendorEmail != null &&
                    this.VendorEmail.Equals(other.VendorEmail)
                ) &&
                (
                    this.TermsOfService == other.TermsOfService ||
                    this.TermsOfService != null &&
                    this.TermsOfService.Equals(other.TermsOfService)
                ) &&
                (
                    this.HelpDocumentationURL == other.HelpDocumentationURL ||
                    this.HelpDocumentationURL != null &&
                    this.HelpDocumentationURL.Equals(other.HelpDocumentationURL)
                ) &&
                (
                    this.MarketingURL == other.MarketingURL ||
                    this.MarketingURL != null &&
                    this.MarketingURL.Equals(other.MarketingURL)
                ) &&
                (
                    this.Industries == other.Industries ||
                    this.Industries != null &&
                    this.Industries.SequenceEqual(other.Industries)
                ) &&
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
                ) &&
                (
                    this.SmartCases == other.SmartCases ||
                    this.SmartCases != null &&
                    this.SmartCases.SequenceEqual(other.SmartCases)
                ) &&
                (
                    this.Pricing == other.Pricing ||
                    this.Pricing != null &&
                    this.Pricing.SequenceEqual(other.Pricing)
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
                
                if (this.RegistryInfo != null)
                    hash = hash * 59 + this.RegistryInfo.GetHashCode();
                
                if (this.MarketingInfo != null)
                    hash = hash * 59 + this.MarketingInfo.GetHashCode();
                
                if (this.Tagline != null)
                    hash = hash * 59 + this.Tagline.GetHashCode();
                
                if (this.BriefDescription != null)
                    hash = hash * 59 + this.BriefDescription.GetHashCode();
                
                if (this.FullDescription != null)
                    hash = hash * 59 + this.FullDescription.GetHashCode();
                
                if (this.Platform != null)
                    hash = hash * 59 + this.Platform.GetHashCode();
                
                if (this.CompanyLogo != null)
                    hash = hash * 59 + this.CompanyLogo.GetHashCode();
                
                if (this.AppLogo != null)
                    hash = hash * 59 + this.AppLogo.GetHashCode();
                
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                
                if (this.Screenshots != null)
                    hash = hash * 59 + this.Screenshots.GetHashCode();
                
                if (this.VideoLinks != null)
                    hash = hash * 59 + this.VideoLinks.GetHashCode();
                
                if (this.Languages != null)
                    hash = hash * 59 + this.Languages.GetHashCode();
                
                if (this.VendorEmail != null)
                    hash = hash * 59 + this.VendorEmail.GetHashCode();
                
                if (this.TermsOfService != null)
                    hash = hash * 59 + this.TermsOfService.GetHashCode();
                
                if (this.HelpDocumentationURL != null)
                    hash = hash * 59 + this.HelpDocumentationURL.GetHashCode();
                
                if (this.MarketingURL != null)
                    hash = hash * 59 + this.MarketingURL.GetHashCode();
                
                if (this.Industries != null)
                    hash = hash * 59 + this.Industries.GetHashCode();
                
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
                
                if (this.SmartCases != null)
                    hash = hash * 59 + this.SmartCases.GetHashCode();
                
                if (this.Pricing != null)
                    hash = hash * 59 + this.Pricing.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
