using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsilonAPI.Requests
{
    public class StoragePools : Core
    {
        public StoragePools(string Username, string Password, string IsilonUrl, bool IgnoreInvalidCerts)
            : base(Username, Password, IsilonUrl, IgnoreInvalidCerts)
        {

        }

        public void GetStoragePoolSettings()
        {

        }

        public void ModifyStoragePoolSettings()
        {

        }

        public void GetStoragePoolTiers()
        {

        }

        public void GetStoragePoolTier(string tier)
        {

        }

        public void CreateStoragePoolTier()
        { 

        }

        public void DeleteStoragePoolTiers()
        {

        }

        public void DeleteStoragePoolTier(string tier)
        {

        }

        public void GetStoragePoolNodePools()
        {

        }

        public void GetStoragePoolNodePool(string name)
        {

        }

        public void ModifyStoragePoolNodePool()
        {

        }

        public void DeleteStoragePoolNodePool(string name)
        {

        }
    }
}
