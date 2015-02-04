using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace IsilonAPI.Models.SMB
{
    [DataContract]
    public class Share
    {
        [DataMember(Name = "access_based_enumeration", EmitDefaultValue = true)]
        public bool AccessBasedEnumeration;

        [DataMember(Name = "access_based_enumeration_root_only", EmitDefaultValue = true)]
        public bool AccessBasedEnumerationRootOnly;

        [DataMember(Name = "allow_variable_expansion", EmitDefaultValue = true)]
        public bool AllowVariableExpansion;

        [DataMember(Name = "allow_delete_readonly", EmitDefaultValue = true)]
        public bool AllowDeleteReadonly;

        [DataMember(Name = "allow_execute_always", EmitDefaultValue = true)]
        public bool AllowExecuteAlways;

        [DataMember(Name = "auto_create_directory", EmitDefaultValue = true)]
        public bool AutoCreateDirectory;

        [DataMember(Name = "browsable", EmitDefaultValue = true)]
        public bool Browsable;

        [DataMember(Name = "change_notify", EmitDefaultValue = true)]
        public string ChangeNotify;

        [DataMember(Name = "create_permissions", EmitDefaultValue = true)]
        public string CreatePermissions;

        [DataMember(Name = "csc_policy", EmitDefaultValue = true)]
        public string CscPolicy;

        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description;

        [DataMember(Name = "directory_create_mask", EmitDefaultValue = true)]
        public int DirectoryCreateMask;

        [DataMember(Name = "directory_create_mode", EmitDefaultValue = true)]
        public int DirectoryCreateMode;

        [DataMember(Name = "file_create_mask", EmitDefaultValue = true)]
        public int FileCreateMask;

        [DataMember(Name = "file_create_mode", EmitDefaultValue = true)]
        public int FileCreateMode;

        [DataMember(Name = "hide_dot_files", EmitDefaultValue = true)]
        public bool HideDotFiles;

        [DataMember(Name = "host_acl", EmitDefaultValue = true)]
        public object[] HostAcl;

        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id;

        [DataMember(Name = "impersonate_guest", EmitDefaultValue = true)]
        public string ImpersonateGuest;

        [DataMember(Name = "impersonate_user", EmitDefaultValue = true)]
        public string ImpersonateUser;

        [DataMember(Name = "inheritable_path_acl", EmitDefaultValue = true)]
        public bool InheritablePathAcl;

        [DataMember(Name = "mangle_byte_start", EmitDefaultValue = true)]
        public int MangleByteStart;

        [DataMember(Name = "mangle_map", EmitDefaultValue = true)]
        public object[] MangleMap;

        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name;

        [DataMember(Name = "ntfs_acl_support", EmitDefaultValue = true)]
        public bool NtfsAclSupport;

        [DataMember(Name = "opslock", EmitDefaultValue = true)]
        public bool OpsLock;

        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path;

        [DataMember(Name = "permissions", EmitDefaultValue=true)]
        public Permission[] Permissions;
    }
}
