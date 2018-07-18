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
    /// AsgInfoResponse
    /// </summary>
    [DataContract]
    public partial class AsgInfoResponse :  IEquatable<AsgInfoResponse>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AsgInfoResponse" /> class.
        /// </summary>
        /// <param name="Id">The full id of the asg &lt;orgId&gt;-&lt;siteId&gt;-ASG-&lt;asgVersion&gt;.</param>
        /// <param name="Site">The site that the asg belongs to..</param>
        /// <param name="Ami">The version of the asg, ex &#39;003&#39;.</param>
        /// <param name="EdgeVersion">The software ami of the edges in the asg..</param>
        /// <param name="InstanceInfo">List of instances and their information that live in the ASG..</param>
        public AsgInfoResponse(string Id = null, Site Site = null, string Ami = null, string EdgeVersion = null, List<InstanceInfo> InstanceInfo = null)
        {
            this.Id = Id;
            this.Site = Site;
            this.Ami = Ami;
            this.EdgeVersion = EdgeVersion;
            this.InstanceInfo = InstanceInfo;
            
        }
        
        
        
        /// <summary>
        /// The full id of the asg &lt;orgId&gt;-&lt;siteId&gt;-ASG-&lt;asgVersion&gt;
        /// </summary>
        /// <value>The full id of the asg &lt;orgId&gt;-&lt;siteId&gt;-ASG-&lt;asgVersion&gt;</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The site that the asg belongs to.
        /// </summary>
        /// <value>The site that the asg belongs to.</value>
        [DataMember(Name="site", EmitDefaultValue=false)]
        public Site Site { get; set; }
        
        
        
        /// <summary>
        /// The version of the asg, ex &#39;003&#39;
        /// </summary>
        /// <value>The version of the asg, ex &#39;003&#39;</value>
        [DataMember(Name="ami", EmitDefaultValue=false)]
        public string Ami { get; set; }
        
        
        
        /// <summary>
        /// The software ami of the edges in the asg.
        /// </summary>
        /// <value>The software ami of the edges in the asg.</value>
        [DataMember(Name="edgeVersion", EmitDefaultValue=false)]
        public string EdgeVersion { get; set; }
        
        
        
        /// <summary>
        /// List of instances and their information that live in the ASG.
        /// </summary>
        /// <value>List of instances and their information that live in the ASG.</value>
        [DataMember(Name="instanceInfo", EmitDefaultValue=false)]
        public List<InstanceInfo> InstanceInfo { get; set; }
        
        
        
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
            sb.Append("class AsgInfoResponse {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  Ami: ").Append(Ami).Append("\n");
            sb.Append("  EdgeVersion: ").Append(EdgeVersion).Append("\n");
            sb.Append("  InstanceInfo: ").Append(InstanceInfo).Append("\n");
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
            return this.Equals(obj as AsgInfoResponse);
        }

        /// <summary>
        /// Returns true if AsgInfoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AsgInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsgInfoResponse other)
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
                    this.Site == other.Site ||
                    this.Site != null &&
                    this.Site.Equals(other.Site)
                ) &&
                (
                    this.Ami == other.Ami ||
                    this.Ami != null &&
                    this.Ami.Equals(other.Ami)
                ) &&
                (
                    this.EdgeVersion == other.EdgeVersion ||
                    this.EdgeVersion != null &&
                    this.EdgeVersion.Equals(other.EdgeVersion)
                ) &&
                (
                    this.InstanceInfo == other.InstanceInfo ||
                    this.InstanceInfo != null &&
                    this.InstanceInfo.SequenceEqual(other.InstanceInfo)
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
                
                if (this.Site != null)
                    hash = hash * 59 + this.Site.GetHashCode();
                
                if (this.Ami != null)
                    hash = hash * 59 + this.Ami.GetHashCode();
                
                if (this.EdgeVersion != null)
                    hash = hash * 59 + this.EdgeVersion.GetHashCode();
                
                if (this.InstanceInfo != null)
                    hash = hash * 59 + this.InstanceInfo.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
