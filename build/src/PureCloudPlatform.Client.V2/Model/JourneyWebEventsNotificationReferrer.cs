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
    /// JourneyWebEventsNotificationReferrer
    /// </summary>
    [DataContract]
    public partial class JourneyWebEventsNotificationReferrer :  IEquatable<JourneyWebEventsNotificationReferrer>
    {
        /// <summary>
        /// Gets or Sets Medium
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MediumEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Internal for "internal"
            /// </summary>
            [EnumMember(Value = "internal")]
            Internal,
            
            /// <summary>
            /// Enum Search for "search"
            /// </summary>
            [EnumMember(Value = "search")]
            Search,
            
            /// <summary>
            /// Enum Social for "social"
            /// </summary>
            [EnumMember(Value = "social")]
            Social,
            
            /// <summary>
            /// Enum Email for "email"
            /// </summary>
            [EnumMember(Value = "email")]
            Email,
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Paid for "paid"
            /// </summary>
            [EnumMember(Value = "paid")]
            Paid
        }
        /// <summary>
        /// Gets or Sets Medium
        /// </summary>
        [DataMember(Name="medium", EmitDefaultValue=false)]
        public MediumEnum? Medium { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationReferrer" /> class.
        /// </summary>
        /// <param name="Url">Url.</param>
        /// <param name="Domain">Domain.</param>
        /// <param name="Hostname">Hostname.</param>
        /// <param name="Keywords">Keywords.</param>
        /// <param name="Pathname">Pathname.</param>
        /// <param name="QueryString">QueryString.</param>
        /// <param name="Fragment">Fragment.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Medium">Medium.</param>
        public JourneyWebEventsNotificationReferrer(string Url = null, string Domain = null, string Hostname = null, string Keywords = null, string Pathname = null, string QueryString = null, string Fragment = null, string Name = null, MediumEnum? Medium = null)
        {
            this.Url = Url;
            this.Domain = Domain;
            this.Hostname = Hostname;
            this.Keywords = Keywords;
            this.Pathname = Pathname;
            this.QueryString = QueryString;
            this.Fragment = Fragment;
            this.Name = Name;
            this.Medium = Medium;
            
        }
        


        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }



        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }



        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public string Keywords { get; set; }



        /// <summary>
        /// Gets or Sets Pathname
        /// </summary>
        [DataMember(Name="pathname", EmitDefaultValue=false)]
        public string Pathname { get; set; }



        /// <summary>
        /// Gets or Sets QueryString
        /// </summary>
        [DataMember(Name="queryString", EmitDefaultValue=false)]
        public string QueryString { get; set; }



        /// <summary>
        /// Gets or Sets Fragment
        /// </summary>
        [DataMember(Name="fragment", EmitDefaultValue=false)]
        public string Fragment { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyWebEventsNotificationReferrer {\n");

            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Pathname: ").Append(Pathname).Append("\n");
            sb.Append("  QueryString: ").Append(QueryString).Append("\n");
            sb.Append("  Fragment: ").Append(Fragment).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
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
            return this.Equals(obj as JourneyWebEventsNotificationReferrer);
        }

        /// <summary>
        /// Returns true if JourneyWebEventsNotificationReferrer instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyWebEventsNotificationReferrer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyWebEventsNotificationReferrer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.Hostname == other.Hostname ||
                    this.Hostname != null &&
                    this.Hostname.Equals(other.Hostname)
                ) &&
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.Equals(other.Keywords)
                ) &&
                (
                    this.Pathname == other.Pathname ||
                    this.Pathname != null &&
                    this.Pathname.Equals(other.Pathname)
                ) &&
                (
                    this.QueryString == other.QueryString ||
                    this.QueryString != null &&
                    this.QueryString.Equals(other.QueryString)
                ) &&
                (
                    this.Fragment == other.Fragment ||
                    this.Fragment != null &&
                    this.Fragment.Equals(other.Fragment)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Medium == other.Medium ||
                    this.Medium != null &&
                    this.Medium.Equals(other.Medium)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();

                if (this.Hostname != null)
                    hash = hash * 59 + this.Hostname.GetHashCode();

                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();

                if (this.Pathname != null)
                    hash = hash * 59 + this.Pathname.GetHashCode();

                if (this.QueryString != null)
                    hash = hash * 59 + this.QueryString.GetHashCode();

                if (this.Fragment != null)
                    hash = hash * 59 + this.Fragment.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Medium != null)
                    hash = hash * 59 + this.Medium.GetHashCode();

                return hash;
            }
        }
    }

}
