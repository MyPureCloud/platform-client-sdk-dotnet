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
    /// JourneyCampaign
    /// </summary>
    [DataContract]
    public partial class JourneyCampaign :  IEquatable<JourneyCampaign>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyCampaign" /> class.
        /// </summary>
        /// <param name="Content">Differentiate ads or links that point to the same URL (e.g. textlink)..</param>
        /// <param name="Medium">Identify a medium such as email or cost-per-click (e.g. CPC)..</param>
        /// <param name="Name">Identify a specific product promotion or strategic campaign (e.g. 320banner)..</param>
        /// <param name="Source">Identify a search engine, newsletter name, or other source (e.g. Google)..</param>
        /// <param name="Term">Note the keywords for this ad (e.g. running+shoes)..</param>
        /// <param name="ClickId">The click ID (unique number that is generated when a potential customer clicks on an affiliate link)..</param>
        /// <param name="Network">The ad network to which the click ID belongs..</param>
        public JourneyCampaign(string Content = null, string Medium = null, string Name = null, string Source = null, string Term = null, string ClickId = null, string Network = null)
        {
            this.Content = Content;
            this.Medium = Medium;
            this.Name = Name;
            this.Source = Source;
            this.Term = Term;
            this.ClickId = ClickId;
            this.Network = Network;
            
        }
        


        /// <summary>
        /// Differentiate ads or links that point to the same URL (e.g. textlink).
        /// </summary>
        /// <value>Differentiate ads or links that point to the same URL (e.g. textlink).</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }



        /// <summary>
        /// Identify a medium such as email or cost-per-click (e.g. CPC).
        /// </summary>
        /// <value>Identify a medium such as email or cost-per-click (e.g. CPC).</value>
        [DataMember(Name="medium", EmitDefaultValue=false)]
        public string Medium { get; set; }



        /// <summary>
        /// Identify a specific product promotion or strategic campaign (e.g. 320banner).
        /// </summary>
        /// <value>Identify a specific product promotion or strategic campaign (e.g. 320banner).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Identify a search engine, newsletter name, or other source (e.g. Google).
        /// </summary>
        /// <value>Identify a search engine, newsletter name, or other source (e.g. Google).</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }



        /// <summary>
        /// Note the keywords for this ad (e.g. running+shoes).
        /// </summary>
        /// <value>Note the keywords for this ad (e.g. running+shoes).</value>
        [DataMember(Name="term", EmitDefaultValue=false)]
        public string Term { get; set; }



        /// <summary>
        /// The click ID (unique number that is generated when a potential customer clicks on an affiliate link).
        /// </summary>
        /// <value>The click ID (unique number that is generated when a potential customer clicks on an affiliate link).</value>
        [DataMember(Name="clickId", EmitDefaultValue=false)]
        public string ClickId { get; set; }



        /// <summary>
        /// The ad network to which the click ID belongs.
        /// </summary>
        /// <value>The ad network to which the click ID belongs.</value>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public string Network { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyCampaign {\n");

            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Term: ").Append(Term).Append("\n");
            sb.Append("  ClickId: ").Append(ClickId).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
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
            return this.Equals(obj as JourneyCampaign);
        }

        /// <summary>
        /// Returns true if JourneyCampaign instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyCampaign other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) &&
                (
                    this.Medium == other.Medium ||
                    this.Medium != null &&
                    this.Medium.Equals(other.Medium)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) &&
                (
                    this.Term == other.Term ||
                    this.Term != null &&
                    this.Term.Equals(other.Term)
                ) &&
                (
                    this.ClickId == other.ClickId ||
                    this.ClickId != null &&
                    this.ClickId.Equals(other.ClickId)
                ) &&
                (
                    this.Network == other.Network ||
                    this.Network != null &&
                    this.Network.Equals(other.Network)
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
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();

                if (this.Medium != null)
                    hash = hash * 59 + this.Medium.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();

                if (this.Term != null)
                    hash = hash * 59 + this.Term.GetHashCode();

                if (this.ClickId != null)
                    hash = hash * 59 + this.ClickId.GetHashCode();

                if (this.Network != null)
                    hash = hash * 59 + this.Network.GetHashCode();

                return hash;
            }
        }
    }

}
