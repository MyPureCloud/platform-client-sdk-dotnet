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
    /// ResourcePermissionPolicy
    /// </summary>
    [DataContract]
    public partial class ResourcePermissionPolicy :  IEquatable<ResourcePermissionPolicy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcePermissionPolicy" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Domain">Domain.</param>
        /// <param name="EntityName">EntityName.</param>
        /// <param name="PolicyName">PolicyName.</param>
        /// <param name="PolicyDescription">PolicyDescription.</param>
        /// <param name="ActionSetKey">ActionSetKey.</param>
        /// <param name="AllowConditions">AllowConditions.</param>
        /// <param name="ResourceConditionNode">ResourceConditionNode.</param>
        /// <param name="NamedResources">NamedResources.</param>
        /// <param name="ResourceCondition">ResourceCondition.</param>
        /// <param name="ActionSet">ActionSet.</param>
        public ResourcePermissionPolicy(string Id = null, string Domain = null, string EntityName = null, string PolicyName = null, string PolicyDescription = null, string ActionSetKey = null, bool? AllowConditions = null, ResourceConditionNode ResourceConditionNode = null, List<string> NamedResources = null, string ResourceCondition = null, List<string> ActionSet = null)
        {
            this.Id = Id;
            this.Domain = Domain;
            this.EntityName = EntityName;
            this.PolicyName = PolicyName;
            this.PolicyDescription = PolicyDescription;
            this.ActionSetKey = ActionSetKey;
            this.AllowConditions = AllowConditions;
            this.ResourceConditionNode = ResourceConditionNode;
            this.NamedResources = NamedResources;
            this.ResourceCondition = ResourceCondition;
            this.ActionSet = ActionSet;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }



        /// <summary>
        /// Gets or Sets EntityName
        /// </summary>
        [DataMember(Name="entityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }



        /// <summary>
        /// Gets or Sets PolicyName
        /// </summary>
        [DataMember(Name="policyName", EmitDefaultValue=false)]
        public string PolicyName { get; set; }



        /// <summary>
        /// Gets or Sets PolicyDescription
        /// </summary>
        [DataMember(Name="policyDescription", EmitDefaultValue=false)]
        public string PolicyDescription { get; set; }



        /// <summary>
        /// Gets or Sets ActionSetKey
        /// </summary>
        [DataMember(Name="actionSetKey", EmitDefaultValue=false)]
        public string ActionSetKey { get; set; }



        /// <summary>
        /// Gets or Sets AllowConditions
        /// </summary>
        [DataMember(Name="allowConditions", EmitDefaultValue=false)]
        public bool? AllowConditions { get; set; }



        /// <summary>
        /// Gets or Sets ResourceConditionNode
        /// </summary>
        [DataMember(Name="resourceConditionNode", EmitDefaultValue=false)]
        public ResourceConditionNode ResourceConditionNode { get; set; }



        /// <summary>
        /// Gets or Sets NamedResources
        /// </summary>
        [DataMember(Name="namedResources", EmitDefaultValue=false)]
        public List<string> NamedResources { get; set; }



        /// <summary>
        /// Gets or Sets ResourceCondition
        /// </summary>
        [DataMember(Name="resourceCondition", EmitDefaultValue=false)]
        public string ResourceCondition { get; set; }



        /// <summary>
        /// Gets or Sets ActionSet
        /// </summary>
        [DataMember(Name="actionSet", EmitDefaultValue=false)]
        public List<string> ActionSet { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcePermissionPolicy {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
            sb.Append("  PolicyDescription: ").Append(PolicyDescription).Append("\n");
            sb.Append("  ActionSetKey: ").Append(ActionSetKey).Append("\n");
            sb.Append("  AllowConditions: ").Append(AllowConditions).Append("\n");
            sb.Append("  ResourceConditionNode: ").Append(ResourceConditionNode).Append("\n");
            sb.Append("  NamedResources: ").Append(NamedResources).Append("\n");
            sb.Append("  ResourceCondition: ").Append(ResourceCondition).Append("\n");
            sb.Append("  ActionSet: ").Append(ActionSet).Append("\n");
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
            return this.Equals(obj as ResourcePermissionPolicy);
        }

        /// <summary>
        /// Returns true if ResourcePermissionPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of ResourcePermissionPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourcePermissionPolicy other)
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
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.EntityName == other.EntityName ||
                    this.EntityName != null &&
                    this.EntityName.Equals(other.EntityName)
                ) &&
                (
                    this.PolicyName == other.PolicyName ||
                    this.PolicyName != null &&
                    this.PolicyName.Equals(other.PolicyName)
                ) &&
                (
                    this.PolicyDescription == other.PolicyDescription ||
                    this.PolicyDescription != null &&
                    this.PolicyDescription.Equals(other.PolicyDescription)
                ) &&
                (
                    this.ActionSetKey == other.ActionSetKey ||
                    this.ActionSetKey != null &&
                    this.ActionSetKey.Equals(other.ActionSetKey)
                ) &&
                (
                    this.AllowConditions == other.AllowConditions ||
                    this.AllowConditions != null &&
                    this.AllowConditions.Equals(other.AllowConditions)
                ) &&
                (
                    this.ResourceConditionNode == other.ResourceConditionNode ||
                    this.ResourceConditionNode != null &&
                    this.ResourceConditionNode.Equals(other.ResourceConditionNode)
                ) &&
                (
                    this.NamedResources == other.NamedResources ||
                    this.NamedResources != null &&
                    this.NamedResources.SequenceEqual(other.NamedResources)
                ) &&
                (
                    this.ResourceCondition == other.ResourceCondition ||
                    this.ResourceCondition != null &&
                    this.ResourceCondition.Equals(other.ResourceCondition)
                ) &&
                (
                    this.ActionSet == other.ActionSet ||
                    this.ActionSet != null &&
                    this.ActionSet.SequenceEqual(other.ActionSet)
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

                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();

                if (this.EntityName != null)
                    hash = hash * 59 + this.EntityName.GetHashCode();

                if (this.PolicyName != null)
                    hash = hash * 59 + this.PolicyName.GetHashCode();

                if (this.PolicyDescription != null)
                    hash = hash * 59 + this.PolicyDescription.GetHashCode();

                if (this.ActionSetKey != null)
                    hash = hash * 59 + this.ActionSetKey.GetHashCode();

                if (this.AllowConditions != null)
                    hash = hash * 59 + this.AllowConditions.GetHashCode();

                if (this.ResourceConditionNode != null)
                    hash = hash * 59 + this.ResourceConditionNode.GetHashCode();

                if (this.NamedResources != null)
                    hash = hash * 59 + this.NamedResources.GetHashCode();

                if (this.ResourceCondition != null)
                    hash = hash * 59 + this.ResourceCondition.GetHashCode();

                if (this.ActionSet != null)
                    hash = hash * 59 + this.ActionSet.GetHashCode();

                return hash;
            }
        }
    }

}
