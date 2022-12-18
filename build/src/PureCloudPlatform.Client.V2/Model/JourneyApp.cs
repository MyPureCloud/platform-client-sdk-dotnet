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
    /// JourneyApp
    /// </summary>
    [DataContract]
    public partial class JourneyApp :  IEquatable<JourneyApp>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyApp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneyApp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyApp" /> class.
        /// </summary>
        /// <param name="Name">Name of the application (e.g. mybankingapp). (required).</param>
        /// <param name="Namespace">Namespace of the application (e.g. com.genesys.bancodinero). (required).</param>
        /// <param name="Version">Version of the application (e.g. 5.9.27). (required).</param>
        /// <param name="BuildNumber">Build number of the application (e.g. 701). (required).</param>
        public JourneyApp(string Name = null, string Namespace = null, string Version = null, string BuildNumber = null)
        {
            this.Name = Name;
            this.Namespace = Namespace;
            this.Version = Version;
            this.BuildNumber = BuildNumber;
            
        }
        


        /// <summary>
        /// Name of the application (e.g. mybankingapp).
        /// </summary>
        /// <value>Name of the application (e.g. mybankingapp).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Namespace of the application (e.g. com.genesys.bancodinero).
        /// </summary>
        /// <value>Namespace of the application (e.g. com.genesys.bancodinero).</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }



        /// <summary>
        /// Version of the application (e.g. 5.9.27).
        /// </summary>
        /// <value>Version of the application (e.g. 5.9.27).</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }



        /// <summary>
        /// Build number of the application (e.g. 701).
        /// </summary>
        /// <value>Build number of the application (e.g. 701).</value>
        [DataMember(Name="buildNumber", EmitDefaultValue=false)]
        public string BuildNumber { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneyApp {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
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
            return this.Equals(obj as JourneyApp);
        }

        /// <summary>
        /// Returns true if JourneyApp instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneyApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneyApp other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Namespace == other.Namespace ||
                    this.Namespace != null &&
                    this.Namespace.Equals(other.Namespace)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.BuildNumber == other.BuildNumber ||
                    this.BuildNumber != null &&
                    this.BuildNumber.Equals(other.BuildNumber)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Namespace != null)
                    hash = hash * 59 + this.Namespace.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.BuildNumber != null)
                    hash = hash * 59 + this.BuildNumber.GetHashCode();

                return hash;
            }
        }
    }

}
