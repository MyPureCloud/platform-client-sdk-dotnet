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
    /// CampaignSchedule
    /// </summary>
    [DataContract]
    public partial class CampaignSchedule :  IEquatable<CampaignSchedule>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSchedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignSchedule() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSchedule" /> class.
        /// </summary>
        
        
        
        
        /// <param name="Name">Name.</param>
        
        
        
        
        
        
        
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        
        
        
        /// <param name="Intervals">a list of start and end times (required).</param>
        
        
        
        /// <param name="TimeZone">time zone identifier to be applied to the intervals; for example Africa/Abidjan (required).</param>
        
        
        
        /// <param name="Campaign">identifier of the campaign to be scheduled (required).</param>
        
        
        
        
        public CampaignSchedule(string Name = null, int? Version = null, List<ScheduleInterval> Intervals = null, string TimeZone = null, UriReference Campaign = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // to ensure "Intervals" is required (not null)
            if (Intervals == null)
            {
                throw new InvalidDataException("Intervals is a required property for CampaignSchedule and cannot be null");
            }
            else
            {
                this.Intervals = Intervals;
            }
            
            
            
            
            
            // to ensure "TimeZone" is required (not null)
            if (TimeZone == null)
            {
                throw new InvalidDataException("TimeZone is a required property for CampaignSchedule and cannot be null");
            }
            else
            {
                this.TimeZone = TimeZone;
            }
            
            
            
            
            
            // to ensure "Campaign" is required (not null)
            if (Campaign == null)
            {
                throw new InvalidDataException("Campaign is a required property for CampaignSchedule and cannot be null");
            }
            else
            {
                this.Campaign = Campaign;
            }
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
            
            
            
            
this.Version = Version;
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
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
        /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }
        
        
        
        /// <summary>
        /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }
        
        
        
        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// a list of start and end times
        /// </summary>
        /// <value>a list of start and end times</value>
        [DataMember(Name="intervals", EmitDefaultValue=false)]
        public List<ScheduleInterval> Intervals { get; set; }
        
        
        
        /// <summary>
        /// time zone identifier to be applied to the intervals; for example Africa/Abidjan
        /// </summary>
        /// <value>time zone identifier to be applied to the intervals; for example Africa/Abidjan</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }
        
        
        
        /// <summary>
        /// identifier of the campaign to be scheduled
        /// </summary>
        /// <value>identifier of the campaign to be scheduled</value>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public UriReference Campaign { get; set; }
        
        
        
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
            sb.Append("class CampaignSchedule {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            
            sb.Append("  Version: ").Append(Version).Append("\n");
            
            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
            
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            
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
            return this.Equals(obj as CampaignSchedule);
        }

        /// <summary>
        /// Returns true if CampaignSchedule instances are equal
        /// </summary>
        /// <param name="other">Instance of CampaignSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignSchedule other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Intervals == other.Intervals ||
                    this.Intervals != null &&
                    this.Intervals.SequenceEqual(other.Intervals)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.Campaign == other.Campaign ||
                    this.Campaign != null &&
                    this.Campaign.Equals(other.Campaign)
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
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Intervals != null)
                    hash = hash * 59 + this.Intervals.GetHashCode();
                
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                
                if (this.Campaign != null)
                    hash = hash * 59 + this.Campaign.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
