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
    /// Details about the active configuration on a deployment
    /// </summary>
    [DataContract]
    public partial class WebDeploymentActiveConfigurationOnDeployment :  IEquatable<WebDeploymentActiveConfigurationOnDeployment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebDeploymentActiveConfigurationOnDeployment" /> class.
        /// </summary>
        /// <param name="ConfigurationVersion">The active configuration on a deployment.</param>
        /// <param name="Deployment">The web deployment associated with the active configuration.</param>
        public WebDeploymentActiveConfigurationOnDeployment(WebDeploymentConfigurationVersion ConfigurationVersion = null, WebDeployment Deployment = null)
        {
            this.ConfigurationVersion = ConfigurationVersion;
            this.Deployment = Deployment;
            
        }
        


        /// <summary>
        /// The active configuration on a deployment
        /// </summary>
        /// <value>The active configuration on a deployment</value>
        [DataMember(Name="configurationVersion", EmitDefaultValue=false)]
        public WebDeploymentConfigurationVersion ConfigurationVersion { get; set; }



        /// <summary>
        /// The web deployment associated with the active configuration
        /// </summary>
        /// <value>The web deployment associated with the active configuration</value>
        [DataMember(Name="deployment", EmitDefaultValue=false)]
        public WebDeployment Deployment { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebDeploymentActiveConfigurationOnDeployment {\n");

            sb.Append("  ConfigurationVersion: ").Append(ConfigurationVersion).Append("\n");
            sb.Append("  Deployment: ").Append(Deployment).Append("\n");
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
            return this.Equals(obj as WebDeploymentActiveConfigurationOnDeployment);
        }

        /// <summary>
        /// Returns true if WebDeploymentActiveConfigurationOnDeployment instances are equal
        /// </summary>
        /// <param name="other">Instance of WebDeploymentActiveConfigurationOnDeployment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebDeploymentActiveConfigurationOnDeployment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConfigurationVersion == other.ConfigurationVersion ||
                    this.ConfigurationVersion != null &&
                    this.ConfigurationVersion.Equals(other.ConfigurationVersion)
                ) &&
                (
                    this.Deployment == other.Deployment ||
                    this.Deployment != null &&
                    this.Deployment.Equals(other.Deployment)
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
                if (this.ConfigurationVersion != null)
                    hash = hash * 59 + this.ConfigurationVersion.GetHashCode();

                if (this.Deployment != null)
                    hash = hash * 59 + this.Deployment.GetHashCode();

                return hash;
            }
        }
    }

}
