using Newtonsoft.Json;

namespace GitLabApiClient.Models.Groups.Requests
{
    /// <summary>
    /// Updates the project group. Only available to group owners and administrators.
    /// </summary>
    public sealed class UpdateGroupRequest
    {
        /// <summary>
        /// The name of the group
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The path of the group
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// The group's description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Prevent adding new members to project membership within this group
        /// </summary>
        [JsonProperty("membership_lock")]
        public bool? MembershipLock { get; set; }

        /// <summary>
        /// Prevent sharing a project with another group within this group
        /// </summary>
        [JsonProperty("share_with_group_lock")]
        public bool? ShareWithGroupLock { get; set; }

        /// <summary>
        /// The group's visibility. Can be private, internal, or public.
        /// </summary>
        [JsonProperty("visibility")]
        public GroupsVisibility? Visibility { get; set; }

        /// <summary>
        /// Require all users in this group to setup Two-factor authentication.
        /// </summary>
        [JsonProperty("require_two_factor_authentication")]
        public bool? RequireTwoFactorAuthentication { get; set; }

        /// <summary>
        /// Time before Two-factor authentication is enforced (in hours).
        /// </summary>
        [JsonProperty("two_factor_grace_period")]
        public int? TwoFactorGracePeriod { get; set; }

        /// <summary>
        /// Determine if developers can create projects in the group. Can be noone (No one), maintainer (Maintainers), or developer (Developers + Maintainers).
        /// </summary>
        [JsonProperty("project_creation_level")]
        public ProjectCreationLevel? ProjectCreationLevel { get; set; }

        /// <summary>
        /// Default to Auto DevOps pipeline for all projects within this group.
        /// </summary>
        [JsonProperty("auto_devops_enabled")]
        public bool? AutoDevOpsEnabled { get; set; }

        /// <summary>
        /// Allowed to create subgroups. Can be owner (Owners), or maintainer (Maintainers).
        /// </summary>
        [JsonProperty("subgroup_creation_level")]
        public SubgroupCreationLevel? SubgroupCreationLevel { get; set; }

        /// <summary>
        /// Disable email notifications
        /// </summary>
        [JsonProperty("emails_disabled")]
        public bool? EmailsDisabled { get; set; }

        /// <summary>
        /// Disable the capability of a group from getting mentioned
        /// </summary>
        [JsonProperty("mentions_disabled")]
        public bool? MentionsDisabled { get; set; }

        /// <summary>
        /// Enable/disable Large File Storage (LFS) for the projects in this group
        /// </summary>
        [JsonProperty("lfs_enabled")]
        public bool? LfsEnabled { get; set; }

        /// <summary>
        /// Allow users to request member access.
        /// </summary>
        [JsonProperty("request_access_enabled")]
        public bool? RequestAccessEnabled { get; set; }

        /// <summary>
        /// See Options for default_branch_protection (https://docs.gitlab.com/ee/api/groups.html#options-for-default_branch_protection). Default to the global level default branch protection setting.
        /// </summary>
        [JsonProperty("default_branch_protection")]
        public int? DefaultBranchProtection { get; set; }

        /// <summary>
        /// The parent group id for creating nested group.
        /// </summary>
        [JsonProperty("file_template_project_id")]
        public int? FileTemplateProjectId { get; set; }

        /// <summary>
        /// Pipeline minutes quota for this group
        /// </summary>
        [JsonProperty("shared_runners_minutes_limit")]
        public int? SharedRunnersMinutesLimit { get; set; }

        /// <summary>
        /// xtra pipeline minutes quota for this group (purchased in addition to the minutes included in the plan).
        /// </summary>
        [JsonProperty("extra_shared_runners_minutes_limit")]
        public int? ExtraSharedRunnersMinutesLimit { get; set; }

        /// <summary>
        /// When enabled, users can not fork projects from this group to external namespaces
        /// </summary>
        [JsonProperty("prevent_forking_outside_group")]
        public bool? PreventForkingOutsideGroup { get; set; }
    }
}
