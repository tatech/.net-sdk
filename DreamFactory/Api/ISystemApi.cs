﻿namespace DreamFactory.Api
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DreamFactory.Model.Database;
    using DreamFactory.Model.System.App;
    using DreamFactory.Model.System.AppGroup;
    using DreamFactory.Model.System.Config;
    using DreamFactory.Model.System.Device;
    using DreamFactory.Model.System.Email;
    using DreamFactory.Model.System.Environment;
    using DreamFactory.Model.System.Event;
    using DreamFactory.Model.System.Role;
    using DreamFactory.Model.System.Script;
    using DreamFactory.Model.System.Service;
    using DreamFactory.Model.System.User;

    /// <summary>
    /// Represents /system API.
    /// </summary>
    public interface ISystemApi
    {
        /// <summary>
        /// Retrieve one or more applications.
        /// </summary>
        /// <param name="query">Query parameters. Pass null to get all records.</param>
        /// <returns>List of applications.</returns>
        Task<IEnumerable<AppResponse>> GetAppsAsync(SqlQuery query = null);

        /// <summary>
        /// Retrieve one or more application groups.
        /// </summary>
        /// <param name="query">Query parameters. Pass null to get all records.</param>
        /// <returns>List of application groups.</returns>
        Task<IEnumerable<AppGroupResponse>> GetAppGroupsAsync(SqlQuery query = null);

        /// <summary>
        /// Retrieve one or more roles.
        /// </summary>
        /// <param name="query">Query parameters. Pass null to get all records.</param>
        /// <returns>List of roles.</returns>
        Task<IEnumerable<RoleResponse>> GetRolesAsync(SqlQuery query = null);

        /// <summary>
        /// Retrieve one or more users.
        /// </summary>
        /// <param name="query">Query parameters. Pass null to get all records.</param>
        /// <returns>List of users.</returns>
        Task<IEnumerable<UserResponse>> GetUsersAsync(SqlQuery query = null);

        /// <summary>
        /// Retrieve one or more services.
        /// </summary>
        /// <param name="query">Query parameters. Pass null to get all records.</param>
        /// <returns>List of services.</returns>
        Task<IEnumerable<ServiceResponse>> GetServicesAsync(SqlQuery query = null);

        /// <summary>
        /// Retrieve one or more email templates.
        /// </summary>
        /// <param name="query">Query parameters. Pass null to get all records.</param>
        /// <returns>List of email templates.</returns>
        Task<IEnumerable<EmailTemplateResponse>> GetEmailTemplatesAsync(SqlQuery query = null);

        /// <summary>
        /// Create one or more applications.
        /// </summary>
        /// <param name="apps">Applications to create.</param>
        /// <returns>List of created applications.</returns>
        Task<IEnumerable<AppResponse>> CreateAppsAsync(params AppRequest[] apps);

        /// <summary>
        /// Create one or more users.
        /// </summary>
        /// <param name="users">Users to create.</param>
        /// <returns>List of created users.</returns>
        Task<IEnumerable<UserResponse>> CreateUsersAsync(params UserRequest[] users);

        /// <summary>
        /// Create one or more roles.
        /// </summary>
        /// <param name="roles">Roles to create.</param>
        /// <returns>List of created roles.</returns>
        Task<IEnumerable<RoleResponse>> CreateRolesAsync(params RoleRequest[] roles);

        /// <summary>
        /// Create one or more services.
        /// </summary>
        /// <param name="services">Services to create.</param>
        /// <returns>List of created services.</returns>
        Task<IEnumerable<ServiceResponse>> CreateServicesAsync(params ServiceRequest[] services);

        /// <summary>
        /// Create one or more email templates.
        /// </summary>
        /// <param name="templates">Email templates to create.</param>
        /// <returns>List of created email templates.</returns>
        Task<IEnumerable<EmailTemplateResponse>> CreateEmailTemplatesAsync(params EmailTemplateRequest[] templates);

        /// <summary>
        /// Update one or more applications.
        /// </summary>
        /// <param name="apps">Applications to update.</param>
        /// <returns>List of updated applications.</returns>
        Task<IEnumerable<AppResponse>> UpdateAppsAsync(params AppRequest[] apps);

        /// <summary>
        /// Update one or more application groups.
        /// </summary>
        /// <param name="appGroups">Application groups to update.</param>
        /// <returns>List of updated application groups.</returns>
        Task<IEnumerable<AppGroupResponse>> UpdateAppGroupsAsync(params AppGroupRequest[] appGroups);

        /// <summary>
        /// Update one or more roles.
        /// </summary>
        /// <param name="roles">Roles to update.</param>
        /// <returns>List of updated roles.</returns>
        Task<IEnumerable<RoleResponse>> UpdateRolesAsync(params RoleRequest[] roles);

        /// <summary>
        /// Update one or more users.
        /// </summary>
        /// <param name="users">Users to update.</param>
        /// <returns>List of updated users.</returns>
        Task<IEnumerable<UserResponse>> UpdateUsersAsync(params UserRequest[] users);

        /// <summary>
        /// Update one or more services.
        /// </summary>
        /// <param name="services">Services to update.</param>
        /// <returns>List of updated services.</returns>
        Task<IEnumerable<ServiceResponse>> UpdateServicesAsync(params ServiceRequest[] services);

        /// <summary>
        /// Update one or more email templates.
        /// </summary>
        /// <param name="templates">Email templates to update.</param>
        /// <returns>List of updated email templates.</returns>
        Task<IEnumerable<EmailTemplateResponse>> UpdateEmailTemplatesAsync(params EmailTemplateRequest[] templates);

        /// <summary>
        /// Delete one or more applications.
        /// </summary>
        /// <param name="deleteStorage">If the app is hosted in a storage service, the storage will be deleted as well.</param>
        /// <param name="ids">Application IDs to delete.</param>
        Task DeleteAppsAsync(bool deleteStorage = false, params int[] ids);

        /// <summary>
        /// Delete one or more application groups.
        /// </summary>
        /// <param name="ids">Application Group IDs to delete.</param>
        Task DeleteAppGroupsAsync(params int[] ids);

        /// <summary>
        /// Delete one or more roles.
        /// </summary>
        /// <param name="ids">Role IDs to delete.</param>
        Task DeleteRolesAsync(params int[] ids);

        /// <summary>
        /// Delete one or more users.
        /// </summary>
        /// <param name="ids">User IDs to delete.</param>
        Task DeleteUsersAsync(params int[] ids);

        /// <summary>
        /// Delete one or more services.
        /// </summary>
        /// <param name="ids">Service IDs to delete.</param>
        Task DeleteServicesAsync(params int[] ids);

        /// <summary>
        /// Delete one or more email templates.
        /// </summary>
        /// <param name="ids">Email template IDs to delete.</param>
        Task DeleteEmailTemplatesAsync(params int[] ids);

        /// <summary>
        /// Delete one or more providers.
        /// </summary>
        /// <param name="ids">Provider IDs to delete.</param>
        Task DeleteProvidersAsync(params int[] ids);

        /// <summary>
        /// Delete one or more provider users.
        /// </summary>
        /// <param name="ids">Provider user IDs to delete.</param>
        Task DeleteProviderUsersAsync(params int[] ids);

        /// <summary>
        /// Download the application as a DreamFactory package file.
        /// </summary>
        /// <param name="applicationId">Application ID.</param>
        /// <param name="includeFiles">Include hosted files in the package.</param>
        /// <param name="includeServices">Include associated services configuration in the package.</param>
        /// <param name="includeSchema">Include associated database schema in the package.</param>
        /// <returns>DreamFactory package contents.</returns>
        Task<byte[]> DownloadApplicationPackageAsync(int applicationId, bool includeFiles = true, bool includeServices = true, bool includeSchema = true);

        /// <summary>
        /// Download the DreamFactory Javascript SDK amended for the app.
        /// </summary>
        /// <param name="applicationId">Application ID.</param>
        /// <returns>SDK contents.</returns>
        Task<byte[]> DownloadApplicationSdkAsync(int applicationId);

        /// <summary>
        /// Retrieve environment information.
        /// </summary>
        /// <returns>See <see cref="EnvironmentResponse"/>.</returns>
        Task<EnvironmentResponse> GetEnvironmentAsync();

        /// <summary>
        /// List all scripts.
        /// </summary>
        /// <param name="includeUserScripts">If true, user scripts will be returned along with the event scripts.</param>
        /// <returns>List of scripts.</returns>
        Task<IEnumerable<ScriptResponse>> GetScriptsAsync(bool includeUserScripts);

        /// <summary>
        /// Write the specified script to the file system.
        /// </summary>
        /// <param name="scriptId">Script ID.</param>
        /// <param name="body">The body of the script to write.</param>
        Task<ScriptResponse> WriteScriptAsync(string scriptId, string body);

        /// <summary>
        /// Run the specified script.
        /// </summary>
        /// <param name="scriptId">Script ID.</param>
        /// <param name="parameters">Script parameters passed in with query.</param>
        /// <param name="logOutput">If true (the default), script output (not the returned result) will be sent to the log as "info".</param>
        /// <returns>Script's result.</returns>
        Task<string> RunScriptAsync(string scriptId, Dictionary<string, object> parameters, bool logOutput = false);

        /// <summary>
        /// Run the specified script.
        /// </summary>
        /// <param name="scriptId">Script ID.</param>
        /// <param name="logOutput">If true (the default), script output (not the returned result) will be sent to the log as "info".</param>
        /// <returns>Script's result.</returns>
        Task<string> RunScriptAsync(string scriptId, bool logOutput = false);

        /// <summary>
        /// Delete script with ID provided.
        /// </summary>
        /// <param name="scriptId">Script ID.</param>
        Task DeleteScriptAsync(string scriptId);

        /// <summary>
        /// Retrieve events and registered listeners.
        /// </summary>
        /// <param name="allEvents">If set to true, all events that are available are returned. Otherwise only events that are have registered listeners are returned.</param>
        /// <param name="asCached">If set to true, the returned structure is identical the stored structure. If false, a simpler form is returned for client consumption.</param>
        /// <returns>List of <see cref="EventCacheResponse"/>.</returns>
        Task<IEnumerable<EventCacheResponse>> GetEventsAsync(bool allEvents, bool asCached);

        /// <summary>
        /// Register one or more event listeners.
        /// </summary>
        /// <param name="requests">Event registration records.</param>
        Task RegisterEventsAsync(params EventRequest[] requests);

        /// <summary>
        /// Delete one or more event listeners.
        /// </summary>
        /// <param name="requests">Event registration records.</param>
        Task UnregisterEventsAsync(params EventRequest[] requests);

        /// <summary>
        /// Retrieve system configuration properties.
        /// </summary>
        /// <returns>See <see cref="ConfigResponse"/>.</returns>
        Task<ConfigResponse> GetConfigAsync();

        /// <summary>
        /// Update one or more system configuration properties.
        /// </summary>
        /// <param name="config">New configuration properties.</param>
        /// <returns>See <see cref="ConfigResponse"/>.</returns>
        Task<ConfigResponse> SetConfigAsync(ConfigRequest config);

        /// <summary>
        /// Get all enumerated types.
        /// </summary>
        /// <returns>List of enumeration types.</returns>
        Task<IEnumerable<string>> GetConstantsAsync();

        /// <summary>
        /// Get enumerated type constant values.
        /// </summary>
        /// <param name="constant">Identifier of the enumeration type to retrieve.</param>
        /// <returns>Key-value pairs.</returns>
        Task<Dictionary<string, string>> GetConstantAsync(string constant);

        /// <summary>
        /// Retrieve one or more devices.
        /// </summary>
        /// <param name="query">Query parameters. Pass null to get all records.</param>
        /// <returns>List of devices.</returns>
        Task<IEnumerable<DeviceResponse>> GetDevicesAsync(SqlQuery query = null);

        /// <summary>
        /// Delete one or more devices.
        /// </summary>
        /// <param name="ids">Device IDs to delete.</param>
        Task DeleteDevicesAsync(params int[] ids);
    }
}
