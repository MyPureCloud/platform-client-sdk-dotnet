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
    /// EdgeMetricsTopicEdgeMetrics
    /// </summary>
    [DataContract]
    public partial class EdgeMetricsTopicEdgeMetrics :  IEquatable<EdgeMetricsTopicEdgeMetrics>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeMetricsTopicEdgeMetrics" /> class.
        /// </summary>
        /// <param name="Edge">Edge.</param>
        /// <param name="EventTime">EventTime.</param>
        /// <param name="UpTimeMsec">UpTimeMsec.</param>
        /// <param name="Processors">Processors.</param>
        /// <param name="Memory">Memory.</param>
        /// <param name="Disks">Disks.</param>
        /// <param name="Subsystems">Subsystems.</param>
        /// <param name="Networks">Networks.</param>
        public EdgeMetricsTopicEdgeMetrics(EdgeMetricsTopicUriReference Edge = null, DateTime? EventTime = null, int? UpTimeMsec = null, List<EdgeMetricsTopicEdgeMetricProcessor> Processors = null, List<EdgeMetricsTopicEdgeMetricMemory> Memory = null, List<EdgeMetricsTopicEdgeMetricDisk> Disks = null, List<EdgeMetricsTopicEdgeMetricSubsystem> Subsystems = null, List<EdgeMetricsTopicEdgeMetricNetworks> Networks = null)
        {
            this.Edge = Edge;
            this.EventTime = EventTime;
            this.UpTimeMsec = UpTimeMsec;
            this.Processors = Processors;
            this.Memory = Memory;
            this.Disks = Disks;
            this.Subsystems = Subsystems;
            this.Networks = Networks;
            
        }
        


        /// <summary>
        /// Gets or Sets Edge
        /// </summary>
        [DataMember(Name="edge", EmitDefaultValue=false)]
        public EdgeMetricsTopicUriReference Edge { get; set; }



        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public DateTime? EventTime { get; set; }



        /// <summary>
        /// Gets or Sets UpTimeMsec
        /// </summary>
        [DataMember(Name="upTimeMsec", EmitDefaultValue=false)]
        public int? UpTimeMsec { get; set; }



        /// <summary>
        /// Gets or Sets Processors
        /// </summary>
        [DataMember(Name="processors", EmitDefaultValue=false)]
        public List<EdgeMetricsTopicEdgeMetricProcessor> Processors { get; set; }



        /// <summary>
        /// Gets or Sets Memory
        /// </summary>
        [DataMember(Name="memory", EmitDefaultValue=false)]
        public List<EdgeMetricsTopicEdgeMetricMemory> Memory { get; set; }



        /// <summary>
        /// Gets or Sets Disks
        /// </summary>
        [DataMember(Name="disks", EmitDefaultValue=false)]
        public List<EdgeMetricsTopicEdgeMetricDisk> Disks { get; set; }



        /// <summary>
        /// Gets or Sets Subsystems
        /// </summary>
        [DataMember(Name="subsystems", EmitDefaultValue=false)]
        public List<EdgeMetricsTopicEdgeMetricSubsystem> Subsystems { get; set; }



        /// <summary>
        /// Gets or Sets Networks
        /// </summary>
        [DataMember(Name="networks", EmitDefaultValue=false)]
        public List<EdgeMetricsTopicEdgeMetricNetworks> Networks { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeMetricsTopicEdgeMetrics {\n");

            sb.Append("  Edge: ").Append(Edge).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  UpTimeMsec: ").Append(UpTimeMsec).Append("\n");
            sb.Append("  Processors: ").Append(Processors).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  Disks: ").Append(Disks).Append("\n");
            sb.Append("  Subsystems: ").Append(Subsystems).Append("\n");
            sb.Append("  Networks: ").Append(Networks).Append("\n");
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
            return this.Equals(obj as EdgeMetricsTopicEdgeMetrics);
        }

        /// <summary>
        /// Returns true if EdgeMetricsTopicEdgeMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeMetricsTopicEdgeMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeMetricsTopicEdgeMetrics other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Edge == other.Edge ||
                    this.Edge != null &&
                    this.Edge.Equals(other.Edge)
                ) &&
                (
                    this.EventTime == other.EventTime ||
                    this.EventTime != null &&
                    this.EventTime.Equals(other.EventTime)
                ) &&
                (
                    this.UpTimeMsec == other.UpTimeMsec ||
                    this.UpTimeMsec != null &&
                    this.UpTimeMsec.Equals(other.UpTimeMsec)
                ) &&
                (
                    this.Processors == other.Processors ||
                    this.Processors != null &&
                    this.Processors.SequenceEqual(other.Processors)
                ) &&
                (
                    this.Memory == other.Memory ||
                    this.Memory != null &&
                    this.Memory.SequenceEqual(other.Memory)
                ) &&
                (
                    this.Disks == other.Disks ||
                    this.Disks != null &&
                    this.Disks.SequenceEqual(other.Disks)
                ) &&
                (
                    this.Subsystems == other.Subsystems ||
                    this.Subsystems != null &&
                    this.Subsystems.SequenceEqual(other.Subsystems)
                ) &&
                (
                    this.Networks == other.Networks ||
                    this.Networks != null &&
                    this.Networks.SequenceEqual(other.Networks)
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
                if (this.Edge != null)
                    hash = hash * 59 + this.Edge.GetHashCode();

                if (this.EventTime != null)
                    hash = hash * 59 + this.EventTime.GetHashCode();

                if (this.UpTimeMsec != null)
                    hash = hash * 59 + this.UpTimeMsec.GetHashCode();

                if (this.Processors != null)
                    hash = hash * 59 + this.Processors.GetHashCode();

                if (this.Memory != null)
                    hash = hash * 59 + this.Memory.GetHashCode();

                if (this.Disks != null)
                    hash = hash * 59 + this.Disks.GetHashCode();

                if (this.Subsystems != null)
                    hash = hash * 59 + this.Subsystems.GetHashCode();

                if (this.Networks != null)
                    hash = hash * 59 + this.Networks.GetHashCode();

                return hash;
            }
        }
    }

}
