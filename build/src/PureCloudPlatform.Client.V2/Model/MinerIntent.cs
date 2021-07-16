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
    /// MinerIntent
    /// </summary>
    [DataContract]
    public partial class MinerIntent :  IEquatable<MinerIntent>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MinerIntent" /> class.
        /// </summary>
        /// <param name="Name">Intent name..</param>
        /// <param name="Miner">The miner to which the intent belongs..</param>
        /// <param name="Utterances">The utterances that are extracted for an Intent..</param>
        /// <param name="AnalyticVolumePercent">Percentage of conversations belonging to the intent..</param>
        public MinerIntent(string Name = null, Miner Miner = null, List<Utterance> Utterances = null, double? AnalyticVolumePercent = null)
        {
            this.Name = Name;
            this.Miner = Miner;
            this.Utterances = Utterances;
            this.AnalyticVolumePercent = AnalyticVolumePercent;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Intent name.
        /// </summary>
        /// <value>Intent name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The miner to which the intent belongs.
        /// </summary>
        /// <value>The miner to which the intent belongs.</value>
        [DataMember(Name="miner", EmitDefaultValue=false)]
        public Miner Miner { get; set; }
        
        
        
        /// <summary>
        /// The utterances that are extracted for an Intent.
        /// </summary>
        /// <value>The utterances that are extracted for an Intent.</value>
        [DataMember(Name="utterances", EmitDefaultValue=false)]
        public List<Utterance> Utterances { get; set; }
        
        
        
        /// <summary>
        /// Percentage of conversations belonging to the intent.
        /// </summary>
        /// <value>Percentage of conversations belonging to the intent.</value>
        [DataMember(Name="analyticVolumePercent", EmitDefaultValue=false)]
        public double? AnalyticVolumePercent { get; set; }
        
        
        
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
            sb.Append("class MinerIntent {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Miner: ").Append(Miner).Append("\n");
            sb.Append("  Utterances: ").Append(Utterances).Append("\n");
            sb.Append("  AnalyticVolumePercent: ").Append(AnalyticVolumePercent).Append("\n");
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
            return this.Equals(obj as MinerIntent);
        }

        /// <summary>
        /// Returns true if MinerIntent instances are equal
        /// </summary>
        /// <param name="other">Instance of MinerIntent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinerIntent other)
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
                    this.Miner == other.Miner ||
                    this.Miner != null &&
                    this.Miner.Equals(other.Miner)
                ) &&
                (
                    this.Utterances == other.Utterances ||
                    this.Utterances != null &&
                    this.Utterances.SequenceEqual(other.Utterances)
                ) &&
                (
                    this.AnalyticVolumePercent == other.AnalyticVolumePercent ||
                    this.AnalyticVolumePercent != null &&
                    this.AnalyticVolumePercent.Equals(other.AnalyticVolumePercent)
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
                
                if (this.Miner != null)
                    hash = hash * 59 + this.Miner.GetHashCode();
                
                if (this.Utterances != null)
                    hash = hash * 59 + this.Utterances.GetHashCode();
                
                if (this.AnalyticVolumePercent != null)
                    hash = hash * 59 + this.AnalyticVolumePercent.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
