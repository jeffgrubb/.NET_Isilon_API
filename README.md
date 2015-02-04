# Summary
EMC Isilon is a scale-out NAS storage platform designed to be a powerful, simple, and efficient way to consolidate and manage enterprise data and applications. Isilon is a clustered storage system that consists of multiple independent nodes that are all integrated with the OneFS operating system. Nodes effectively pool all storage, compute, and network resources into a single entity capable of providing petabyte scale storage in a single namespace or filesystem. For organizations who wish to automate the administration tasks of OneFS, the platform provides a REST API. This project is a wrapper library written in C# .NET.

# Using .NET Isilon API

To use this code, download the project in its entirety and include a reference to the binary in your project. The entry points into the API are defined in the IsilonAPI.Requests namespace. For example, if your application requires automatically creating or modifying SMB shares, that functionality is located in the IsilonAPI.Requests.SMB class.

# Contributing

Please contribute in any way to the project. Specifically need help filling out the remaining components of the API not yet implemented, and making the wrapper easier to use in other use cases.

# Licensing

Licensed under the Apache License, Version 2.0 (the “License”); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an “AS IS” BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.

# Support

Please file bugs and issues at the Github issues page. For more general discussions you can contact the EMC Code team at [Google Groups](https://groups.google.com/forum/#!forum/emccode-users). The code and documentation are released with no warranties or SLAs and are intended to be supported through a community driven process.
