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
    /// AuthorizationSettings
    /// </summary>
    [DataContract]
    public partial class AuthorizationSettings :  IEquatable<AuthorizationSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationSettings" /> class.
        /// </summary>
        public AuthorizationSettings()
        {
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Boolean showing if organization is opted in or not to unused role/perm analysis
        /// </summary>
        /// <value>Boolean showing if organization is opted in or not to unused role/perm analysis</value>
        [DataMember(Name="analysisEnabled", EmitDefaultValue=false)]
        public bool? AnalysisEnabled { get; private set; }



        /// <summary>
        /// Integer number of days to analyze user usage
        /// </summary>
        /// <value>Integer number of days to analyze user usage</value>
        [DataMember(Name="analysisDays", EmitDefaultValue=false)]
        public int? AnalysisDays { get; private set; }



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
            sb.Append("class AuthorizationSettings {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AnalysisEnabled: ").Append(AnalysisEnabled).Append("\n");
            sb.Append("  AnalysisDays: ").Append(AnalysisDays).Append("\n");
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
            return this.Equals(obj as AuthorizationSettings);
        }

        /// <summary>
        /// Returns true if AuthorizationSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthorizationSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizationSettings other)
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
                    this.AnalysisEnabled == other.AnalysisEnabled ||
                    this.AnalysisEnabled != null &&
                    this.AnalysisEnabled.Equals(other.AnalysisEnabled)
                ) &&
                (
                    this.AnalysisDays == other.AnalysisDays ||
                    this.AnalysisDays != null &&
                    this.AnalysisDays.Equals(other.AnalysisDays)
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

                if (this.AnalysisEnabled != null)
                    hash = hash * 59 + this.AnalysisEnabled.GetHashCode();

                if (this.AnalysisDays != null)
                    hash = hash * 59 + this.AnalysisDays.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
