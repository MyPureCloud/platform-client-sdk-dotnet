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
    /// Settings concerning journey events
    /// </summary>
    [DataContract]
    public partial class JourneyEventsSettings :  IEquatable<JourneyEventsSettings>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Controls how the pageview events are tracked.
        /// </summary>
        /// <value>Controls how the pageview events are tracked.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PageviewConfigEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>
            [EnumMember(Value = "Auto")]
            Auto,
            
            /// <summary>
            /// Enum Once for "Once"
            /// </summary>
            [EnumMember(Value = "Once")]
            Once,
            
            /// <summary>
            /// Enum Off for "Off"
            /// </summary>
            [EnumMember(Value = "Off")]
            Off
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Controls how the pageview events are tracked.
        /// </summary>
        /// <value>Controls how the pageview events are tracked.</value>
        [DataMember(Name="pageviewConfig", EmitDefaultValue=false)]
        public PageviewConfigEnum? PageviewConfig { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyEventsSettings" /> class.
        /// </summary>
        /// <param name="Enabled">Whether or not journey event collection is enabled..</param>
        /// <param name="ExcludedQueryParameters">List of parameters to be excluded from the query string..</param>
        /// <param name="ShouldKeepUrlFragment">Whether or not to keep the URL fragment..</param>
        /// <param name="SearchQueryParameters">List of query parameters used for search (e.g. &#39;q&#39;)..</param>
        /// <param name="PageviewConfig">Controls how the pageview events are tracked..</param>
        /// <param name="ClickEvents">Tracks when and where a visitor clicks on a webpage..</param>
        /// <param name="FormsTrackEvents">Controls how the form submitted and form abandoned events are tracked after a visitor interacts with a form element..</param>
        /// <param name="IdleEvents">Tracks when and where a visitor becomes inactive on a webpage..</param>
        /// <param name="InViewportEvents">Tracks when elements become visible or hidden on screen..</param>
        /// <param name="ScrollDepthEvents">Tracks when a visitor scrolls to a specific percentage of a webpage..</param>
        public JourneyEventsSettings(bool? Enabled = null, List<string> ExcludedQueryParameters = null, bool? ShouldKeepUrlFragment = null, List<string> SearchQueryParameters = null, PageviewConfigEnum? PageviewConfig = null, List<SelectorEventTrigger> ClickEvents = null, List<FormsTrackTrigger> FormsTrackEvents = null, List<IdleEventTrigger> IdleEvents = null, List<SelectorEventTrigger> InViewportEvents = null, List<ScrollPercentageEventTrigger> ScrollDepthEvents = null)
        {
            this.Enabled = Enabled;
            this.ExcludedQueryParameters = ExcludedQueryParameters;
            this.ShouldKeepUrlFragment = ShouldKeepUrlFragment;
            this.SearchQueryParameters = SearchQueryParameters;
            this.PageviewConfig = PageviewConfig;
            this.ClickEvents = ClickEvents;
            this.FormsTrackEvents = FormsTrackEvents;
            this.IdleEvents = IdleEvents;
            this.InViewportEvents = InViewportEvents;
            this.ScrollDepthEvents = ScrollDepthEvents;
            
        }
        
        
        
        /// <summary>
        /// Whether or not journey event collection is enabled.
        /// </summary>
        /// <value>Whether or not journey event collection is enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        
        
        
        /// <summary>
        /// List of parameters to be excluded from the query string.
        /// </summary>
        /// <value>List of parameters to be excluded from the query string.</value>
        [DataMember(Name="excludedQueryParameters", EmitDefaultValue=false)]
        public List<string> ExcludedQueryParameters { get; set; }
        
        
        
        /// <summary>
        /// Whether or not to keep the URL fragment.
        /// </summary>
        /// <value>Whether or not to keep the URL fragment.</value>
        [DataMember(Name="shouldKeepUrlFragment", EmitDefaultValue=false)]
        public bool? ShouldKeepUrlFragment { get; set; }
        
        
        
        /// <summary>
        /// List of query parameters used for search (e.g. &#39;q&#39;).
        /// </summary>
        /// <value>List of query parameters used for search (e.g. &#39;q&#39;).</value>
        [DataMember(Name="searchQueryParameters", EmitDefaultValue=false)]
        public List<string> SearchQueryParameters { get; set; }
        
        
        
        
        
        /// <summary>
        /// Tracks when and where a visitor clicks on a webpage.
        /// </summary>
        /// <value>Tracks when and where a visitor clicks on a webpage.</value>
        [DataMember(Name="clickEvents", EmitDefaultValue=false)]
        public List<SelectorEventTrigger> ClickEvents { get; set; }
        
        
        
        /// <summary>
        /// Controls how the form submitted and form abandoned events are tracked after a visitor interacts with a form element.
        /// </summary>
        /// <value>Controls how the form submitted and form abandoned events are tracked after a visitor interacts with a form element.</value>
        [DataMember(Name="formsTrackEvents", EmitDefaultValue=false)]
        public List<FormsTrackTrigger> FormsTrackEvents { get; set; }
        
        
        
        /// <summary>
        /// Tracks when and where a visitor becomes inactive on a webpage.
        /// </summary>
        /// <value>Tracks when and where a visitor becomes inactive on a webpage.</value>
        [DataMember(Name="idleEvents", EmitDefaultValue=false)]
        public List<IdleEventTrigger> IdleEvents { get; set; }
        
        
        
        /// <summary>
        /// Tracks when elements become visible or hidden on screen.
        /// </summary>
        /// <value>Tracks when elements become visible or hidden on screen.</value>
        [DataMember(Name="inViewportEvents", EmitDefaultValue=false)]
        public List<SelectorEventTrigger> InViewportEvents { get; set; }
        
        
        
        /// <summary>
        /// Tracks when a visitor scrolls to a specific percentage of a webpage.
        /// </summary>
        /// <value>Tracks when a visitor scrolls to a specific percentage of a webpage.</value>
        [DataMember(Name="scrollDepthEvents", EmitDefaultValue=false)]
        public List<ScrollPercentageEventTrigger> ScrollDepthEvents { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyEventsSettings {\n");
            
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ExcludedQueryParameters: ").Append(ExcludedQueryParameters).Append("\n");
            sb.Append("  ShouldKeepUrlFragment: ").Append(ShouldKeepUrlFragment).Append("\n");
            sb.Append("  SearchQueryParameters: ").Append(SearchQueryParameters).Append("\n");
            sb.Append("  PageviewConfig: ").Append(PageviewConfig).Append("\n");
            sb.Append("  ClickEvents: ").Append(ClickEvents).Append("\n");
            sb.Append("  FormsTrackEvents: ").Append(FormsTrackEvents).Append("\n");
            sb.Append("  IdleEvents: ").Append(IdleEvents).Append("\n");
            sb.Append("  InViewportEvents: ").Append(InViewportEvents).Append("\n");
            sb.Append("  ScrollDepthEvents: ").Append(ScrollDepthEvents).Append("\n");
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
            return this.Equals(obj as JourneyEventsSettings);
        }

        /// <summary>
        /// Returns true if JourneyEventsSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyEventsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyEventsSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.ExcludedQueryParameters == other.ExcludedQueryParameters ||
                    this.ExcludedQueryParameters != null &&
                    this.ExcludedQueryParameters.SequenceEqual(other.ExcludedQueryParameters)
                ) &&
                (
                    this.ShouldKeepUrlFragment == other.ShouldKeepUrlFragment ||
                    this.ShouldKeepUrlFragment != null &&
                    this.ShouldKeepUrlFragment.Equals(other.ShouldKeepUrlFragment)
                ) &&
                (
                    this.SearchQueryParameters == other.SearchQueryParameters ||
                    this.SearchQueryParameters != null &&
                    this.SearchQueryParameters.SequenceEqual(other.SearchQueryParameters)
                ) &&
                (
                    this.PageviewConfig == other.PageviewConfig ||
                    this.PageviewConfig != null &&
                    this.PageviewConfig.Equals(other.PageviewConfig)
                ) &&
                (
                    this.ClickEvents == other.ClickEvents ||
                    this.ClickEvents != null &&
                    this.ClickEvents.SequenceEqual(other.ClickEvents)
                ) &&
                (
                    this.FormsTrackEvents == other.FormsTrackEvents ||
                    this.FormsTrackEvents != null &&
                    this.FormsTrackEvents.SequenceEqual(other.FormsTrackEvents)
                ) &&
                (
                    this.IdleEvents == other.IdleEvents ||
                    this.IdleEvents != null &&
                    this.IdleEvents.SequenceEqual(other.IdleEvents)
                ) &&
                (
                    this.InViewportEvents == other.InViewportEvents ||
                    this.InViewportEvents != null &&
                    this.InViewportEvents.SequenceEqual(other.InViewportEvents)
                ) &&
                (
                    this.ScrollDepthEvents == other.ScrollDepthEvents ||
                    this.ScrollDepthEvents != null &&
                    this.ScrollDepthEvents.SequenceEqual(other.ScrollDepthEvents)
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
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.ExcludedQueryParameters != null)
                    hash = hash * 59 + this.ExcludedQueryParameters.GetHashCode();
                
                if (this.ShouldKeepUrlFragment != null)
                    hash = hash * 59 + this.ShouldKeepUrlFragment.GetHashCode();
                
                if (this.SearchQueryParameters != null)
                    hash = hash * 59 + this.SearchQueryParameters.GetHashCode();
                
                if (this.PageviewConfig != null)
                    hash = hash * 59 + this.PageviewConfig.GetHashCode();
                
                if (this.ClickEvents != null)
                    hash = hash * 59 + this.ClickEvents.GetHashCode();
                
                if (this.FormsTrackEvents != null)
                    hash = hash * 59 + this.FormsTrackEvents.GetHashCode();
                
                if (this.IdleEvents != null)
                    hash = hash * 59 + this.IdleEvents.GetHashCode();
                
                if (this.InViewportEvents != null)
                    hash = hash * 59 + this.InViewportEvents.GetHashCode();
                
                if (this.ScrollDepthEvents != null)
                    hash = hash * 59 + this.ScrollDepthEvents.GetHashCode();
                
                return hash;
            }
        }
    }

}
