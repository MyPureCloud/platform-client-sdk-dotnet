using System.Runtime.Serialization;
using System.Text;

using Newtonsoft.Json;

using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
	/// <summary>
	/// UpdateUser
	/// </summary>
	[DataContract]
	public partial class UpdateUser : IEquatable<UpdateUser>
	{
		/// <summary>
		/// The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.
		/// </summary>
		/// <value>The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.</value>
		[JsonConverter(typeof(UpgradeSdkEnumConverter))]
		public enum StateEnum
		{
			/// <summary>
			/// Your SDK version is out of date and an unknown enum value was encountered. 
			/// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
			/// in the Package Manager Console
			/// </summary>
			[EnumMember(Value = "OUTDATED_SDK_VERSION")]
			OutdatedSdkVersion,

			/// <summary>
			/// Enum Active for "active"
			/// </summary>
			[EnumMember(Value = "active")]
			Active,

			/// <summary>
			/// Enum Inactive for "inactive"
			/// </summary>
			[EnumMember(Value = "inactive")]
			Inactive,

			/// <summary>
			/// Enum Deleted for "deleted"
			/// </summary>
			[EnumMember(Value = "deleted")]
			Deleted
		}
		/// <summary>
		/// The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.
		/// </summary>
		/// <value>The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public StateEnum? State { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateUser" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected UpdateUser() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="UpdateUser" /> class.
		/// </summary>
		/// <param name="Name">Name.</param>
		/// <param name="Chat">Chat.</param>
		/// <param name="Department">Department.</param>
		/// <param name="Email">Email.</param>
		/// <param name="Addresses">Email address, phone number, and/or extension for this user. One entry is allowed per media type.</param>
		/// <param name="Title">Title.</param>
		/// <param name="Username">Username.</param>
		/// <param name="PreferredName">Preferred full name of agent.</param>
		/// <param name="Manager">Manager.</param>
		/// <param name="Images">Images.</param>
		/// <param name="Version">This value should be the current version of the user. The current version can be obtained with a GET on the user before doing a PATCH. (required).</param>
		/// <param name="ProfileSkills">Profile skills possessed by the user.</param>
		/// <param name="Locations">The user placement at each site location..</param>
		/// <param name="Groups">The groups the user is a member of.</param>
		/// <param name="State">The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field..</param>
		/// <param name="AcdAutoAnswer">The value that denotes if acdAutoAnswer is set on the user.</param>
		/// <param name="Certifications">Certifications.</param>
		/// <param name="Biography">Biography.</param>
		/// <param name="EmployerInfo">EmployerInfo.</param>
		public UpdateUser(string Name = null, Chat Chat = null, string Department = null, string Email = null, List<Contact> Addresses = null, string Title = null, string Username = null, string PreferredName = null, string Manager = null, List<Image> Images = null, int? Version = null, List<string> ProfileSkills = null, List<Location> Locations = null, List<Group> Groups = null, StateEnum? State = null, bool? AcdAutoAnswer = null, List<string> Certifications = null, Biography Biography = null, EmployerInfo EmployerInfo = null)
		{
			this.Name = Name;
			this.Chat = Chat;
			this.Department = Department;
			this.Email = Email;
			this.Addresses = Addresses;
			this.Title = Title;
			this.Username = Username;
			this.PreferredName = PreferredName;
			this.Manager = Manager;
			this.Images = Images;
			this.Version = Version;
			this.ProfileSkills = ProfileSkills;
			this.Locations = Locations;
			this.Groups = Groups;
			this.State = State;
			this.AcdAutoAnswer = AcdAutoAnswer;
			this.Certifications = Certifications;
			this.Biography = Biography;
			this.EmployerInfo = EmployerInfo;

		}



		/// <summary>
		/// The globally unique identifier for the object.
		/// </summary>
		/// <value>The globally unique identifier for the object.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; private set; }



		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }



		/// <summary>
		/// Gets or Sets Chat
		/// </summary>
		[DataMember(Name = "chat", EmitDefaultValue = false)]
		public Chat Chat { get; set; }



		/// <summary>
		/// Gets or Sets Department
		/// </summary>
		[DataMember(Name = "department", EmitDefaultValue = false)]
		public string Department { get; set; }



		/// <summary>
		/// Gets or Sets Email
		/// </summary>
		[DataMember(Name = "email", EmitDefaultValue = false)]
		public string Email { get; set; }



		/// <summary>
		/// The address(s) used for primary contact. Updates to the corresponding address in the addresses list will be reflected here.
		/// </summary>
		/// <value>The address(s) used for primary contact. Updates to the corresponding address in the addresses list will be reflected here.</value>
		[DataMember(Name = "primaryContactInfo", EmitDefaultValue = false)]
		public List<Contact> PrimaryContactInfo { get; private set; }



		/// <summary>
		/// Email address, phone number, and/or extension for this user. One entry is allowed per media type
		/// </summary>
		/// <value>Email address, phone number, and/or extension for this user. One entry is allowed per media type</value>
		[DataMember(Name = "addresses", EmitDefaultValue = false)]
		public List<Contact> Addresses { get; set; }



		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }



		/// <summary>
		/// Gets or Sets Username
		/// </summary>
		[DataMember(Name = "username", EmitDefaultValue = false)]
		public string Username { get; set; }



		/// <summary>
		/// Preferred full name of agent
		/// </summary>
		/// <value>Preferred full name of agent</value>
		[DataMember(Name = "preferredName", EmitDefaultValue = false)]
		public string PreferredName { get; set; }



		/// <summary>
		/// Gets or Sets Manager
		/// </summary>
		[DataMember(Name = "manager", EmitDefaultValue = false)]
		public string Manager { get; set; }



		/// <summary>
		/// Gets or Sets Images
		/// </summary>
		[DataMember(Name = "images", EmitDefaultValue = false)]
		public List<Image> Images { get; set; }



		/// <summary>
		/// This value should be the current version of the user. The current version can be obtained with a GET on the user before doing a PATCH.
		/// </summary>
		/// <value>This value should be the current version of the user. The current version can be obtained with a GET on the user before doing a PATCH.</value>
		[DataMember(Name = "version", EmitDefaultValue = false)]
		public int? Version { get; set; }



		/// <summary>
		/// Profile skills possessed by the user
		/// </summary>
		/// <value>Profile skills possessed by the user</value>
		[DataMember(Name = "profileSkills", EmitDefaultValue = false)]
		public List<string> ProfileSkills { get; set; }



		/// <summary>
		/// The user placement at each site location.
		/// </summary>
		/// <value>The user placement at each site location.</value>
		[DataMember(Name = "locations", EmitDefaultValue = false)]
		public List<Location> Locations { get; set; }



		/// <summary>
		/// The groups the user is a member of
		/// </summary>
		/// <value>The groups the user is a member of</value>
		[DataMember(Name = "groups", EmitDefaultValue = false)]
		public List<Group> Groups { get; set; }





		/// <summary>
		/// The value that denotes if acdAutoAnswer is set on the user
		/// </summary>
		/// <value>The value that denotes if acdAutoAnswer is set on the user</value>
		[DataMember(Name = "acdAutoAnswer", EmitDefaultValue = false)]
		public bool? AcdAutoAnswer { get; set; }



		/// <summary>
		/// Gets or Sets Certifications
		/// </summary>
		[DataMember(Name = "certifications", EmitDefaultValue = false)]
		public List<string> Certifications { get; set; }



		/// <summary>
		/// Gets or Sets Biography
		/// </summary>
		[DataMember(Name = "biography", EmitDefaultValue = false)]
		public Biography Biography { get; set; }



		/// <summary>
		/// Gets or Sets EmployerInfo
		/// </summary>
		[DataMember(Name = "employerInfo", EmitDefaultValue = false)]
		public EmployerInfo EmployerInfo { get; set; }



		/// <summary>
		/// The URI for this object
		/// </summary>
		/// <value>The URI for this object</value>
		[DataMember(Name = "selfUri", EmitDefaultValue = false)]
		public string SelfUri { get; private set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UpdateUser {\n");

			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Chat: ").Append(Chat).Append("\n");
			sb.Append("  Department: ").Append(Department).Append("\n");
			sb.Append("  Email: ").Append(Email).Append("\n");
			sb.Append("  PrimaryContactInfo: ").Append(PrimaryContactInfo).Append("\n");
			sb.Append("  Addresses: ").Append(Addresses).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  PreferredName: ").Append(PreferredName).Append("\n");
			sb.Append("  Manager: ").Append(Manager).Append("\n");
			sb.Append("  Images: ").Append(Images).Append("\n");
			sb.Append("  Version: ").Append(Version).Append("\n");
			sb.Append("  ProfileSkills: ").Append(ProfileSkills).Append("\n");
			sb.Append("  Locations: ").Append(Locations).Append("\n");
			sb.Append("  Groups: ").Append(Groups).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  AcdAutoAnswer: ").Append(AcdAutoAnswer).Append("\n");
			sb.Append("  Certifications: ").Append(Certifications).Append("\n");
			sb.Append("  Biography: ").Append(Biography).Append("\n");
			sb.Append("  EmployerInfo: ").Append(EmployerInfo).Append("\n");
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
			return this.Equals(obj as UpdateUser);
		}

		/// <summary>
		/// Returns true if UpdateUser instances are equal
		/// </summary>
		/// <param name="other">Instance of UpdateUser to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UpdateUser other)
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
					this.Chat == other.Chat ||
					this.Chat != null &&
					this.Chat.Equals(other.Chat)
				) &&
				(
					this.Department == other.Department ||
					this.Department != null &&
					this.Department.Equals(other.Department)
				) &&
				(
					this.Email == other.Email ||
					this.Email != null &&
					this.Email.Equals(other.Email)
				) &&
				(
					this.PrimaryContactInfo == other.PrimaryContactInfo ||
					this.PrimaryContactInfo != null &&
					this.PrimaryContactInfo.SequenceEqual(other.PrimaryContactInfo)
				) &&
				(
					this.Addresses == other.Addresses ||
					this.Addresses != null &&
					this.Addresses.SequenceEqual(other.Addresses)
				) &&
				(
					this.Title == other.Title ||
					this.Title != null &&
					this.Title.Equals(other.Title)
				) &&
				(
					this.Username == other.Username ||
					this.Username != null &&
					this.Username.Equals(other.Username)
				) &&
				(
					this.PreferredName == other.PreferredName ||
					this.PreferredName != null &&
					this.PreferredName.Equals(other.PreferredName)
				) &&
				(
					this.Manager == other.Manager ||
					this.Manager != null &&
					this.Manager.Equals(other.Manager)
				) &&
				(
					this.Images == other.Images ||
					this.Images != null &&
					this.Images.SequenceEqual(other.Images)
				) &&
				(
					this.Version == other.Version ||
					this.Version != null &&
					this.Version.Equals(other.Version)
				) &&
				(
					this.ProfileSkills == other.ProfileSkills ||
					this.ProfileSkills != null &&
					this.ProfileSkills.SequenceEqual(other.ProfileSkills)
				) &&
				(
					this.Locations == other.Locations ||
					this.Locations != null &&
					this.Locations.SequenceEqual(other.Locations)
				) &&
				(
					this.Groups == other.Groups ||
					this.Groups != null &&
					this.Groups.SequenceEqual(other.Groups)
				) &&
				(
					this.State == other.State ||
					this.State != null &&
					this.State.Equals(other.State)
				) &&
				(
					this.AcdAutoAnswer == other.AcdAutoAnswer ||
					this.AcdAutoAnswer != null &&
					this.AcdAutoAnswer.Equals(other.AcdAutoAnswer)
				) &&
				(
					this.Certifications == other.Certifications ||
					this.Certifications != null &&
					this.Certifications.SequenceEqual(other.Certifications)
				) &&
				(
					this.Biography == other.Biography ||
					this.Biography != null &&
					this.Biography.Equals(other.Biography)
				) &&
				(
					this.EmployerInfo == other.EmployerInfo ||
					this.EmployerInfo != null &&
					this.EmployerInfo.Equals(other.EmployerInfo)
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

				if (this.Chat != null)
					hash = hash * 59 + this.Chat.GetHashCode();

				if (this.Department != null)
					hash = hash * 59 + this.Department.GetHashCode();

				if (this.Email != null)
					hash = hash * 59 + this.Email.GetHashCode();

				if (this.PrimaryContactInfo != null)
					hash = hash * 59 + this.PrimaryContactInfo.GetHashCode();

				if (this.Addresses != null)
					hash = hash * 59 + this.Addresses.GetHashCode();

				if (this.Title != null)
					hash = hash * 59 + this.Title.GetHashCode();

				if (this.Username != null)
					hash = hash * 59 + this.Username.GetHashCode();

				if (this.PreferredName != null)
					hash = hash * 59 + this.PreferredName.GetHashCode();

				if (this.Manager != null)
					hash = hash * 59 + this.Manager.GetHashCode();

				if (this.Images != null)
					hash = hash * 59 + this.Images.GetHashCode();

				if (this.Version != null)
					hash = hash * 59 + this.Version.GetHashCode();

				if (this.ProfileSkills != null)
					hash = hash * 59 + this.ProfileSkills.GetHashCode();

				if (this.Locations != null)
					hash = hash * 59 + this.Locations.GetHashCode();

				if (this.Groups != null)
					hash = hash * 59 + this.Groups.GetHashCode();

				if (this.State != null)
					hash = hash * 59 + this.State.GetHashCode();

				if (this.AcdAutoAnswer != null)
					hash = hash * 59 + this.AcdAutoAnswer.GetHashCode();

				if (this.Certifications != null)
					hash = hash * 59 + this.Certifications.GetHashCode();

				if (this.Biography != null)
					hash = hash * 59 + this.Biography.GetHashCode();

				if (this.EmployerInfo != null)
					hash = hash * 59 + this.EmployerInfo.GetHashCode();

				if (this.SelfUri != null)
					hash = hash * 59 + this.SelfUri.GetHashCode();

				return hash;
			}
		}
	}

}
