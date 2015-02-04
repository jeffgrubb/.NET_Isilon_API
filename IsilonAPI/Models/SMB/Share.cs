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
        [DataMember(Name = "access_based_enumeration", EmitDefaultValue = false)]
        public bool AccessBasedEnumeration;

        [DataMember(Name = "access_based_enumeration_root_only", EmitDefaultValue = false)]
        public bool AccessBasedEnumerationRootOnly;

        [DataMember(Name = "allow_variable_expansion", EmitDefaultValue = false)]
        public bool AllowVariableExpansion;

        [DataMember(Name = "allow_delete_readonly", EmitDefaultValue = false)]
        public bool AllowDeleteReadonly;

        [DataMember(Name = "allow_execute_always", EmitDefaultValue = false)]
        public bool AllowExecuteAlways;

        [DataMember(Name = "auto_create_directory", EmitDefaultValue = false)]
        public bool AutoCreateDirectory;

        [DataMember(Name = "browsable", EmitDefaultValue = false)]
        public bool Browsable;

        [DataMember(Name = "change_notify", EmitDefaultValue = false)]
        public string ChangeNotify;

        [DataMember(Name = "create_permissions", EmitDefaultValue = false)]
        public string CreatePermissions;

        [DataMember(Name = "csc_policy", EmitDefaultValue = false)]
        public string CscPolicy;

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description;

        [DataMember(Name = "directory_create_mask", EmitDefaultValue = false)]
        public int DirectoryCreateMask;

        [DataMember(Name = "directory_create_mode", EmitDefaultValue = false)]
        public int DirectoryCreateMode;

        [DataMember(Name = "file_create_mask", EmitDefaultValue = false)]
        public int FileCreateMask;

        [DataMember(Name = "file_create_mode", EmitDefaultValue = false)]
        public int FileCreateMode;

        [DataMember(Name = "hide_dot_files", EmitDefaultValue = false)]
        public bool HideDotFiles;

        [DataMember(Name = "host_acl", EmitDefaultValue = false)]
        public object[] HostAcl;

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        [DataMember(Name = "impersonate_guest", EmitDefaultValue = false)]
        public string ImpersonateGuest;

        [DataMember(Name = "impersonate_user", EmitDefaultValue = false)]
        public string ImpersonateUser;

        [DataMember(Name = "inheritable_path_acl", EmitDefaultValue = false)]
        public bool InheritablePathAcl;

        [DataMember(Name = "mangle_byte_start", EmitDefaultValue = false)]
        public int MangleByteStart;

        [DataMember(Name = "mangle_map", EmitDefaultValue = false)]
        public object[] MangleMap;

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;

        [DataMember(Name = "ntfs_acl_support", EmitDefaultValue = false)]
        public bool NtfsAclSupport;

        [DataMember(Name = "opslock", EmitDefaultValue = false)]
        public bool OpsLock;

        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path;

        [DataMember(Name = "permissions", EmitDefaultValue=false)]
        public Permission[] Permissions;
    }
}
