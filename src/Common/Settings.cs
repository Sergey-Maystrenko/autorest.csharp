﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using AutoRest.Core.Utilities;
using static AutoRest.Core.Utilities.DependencyInjection;

namespace AutoRest.Core
{
    public interface IHost {
    }

    public class Settings : IsSingleton<Settings>
    {
        public const int DefaultMaximumCommentColumns = 80;

        /// <summary>
        /// Returns the version of this instance of AutoRest.
        /// </summary>
        public static string Version => typeof(Settings).GetAssembly().GetName().Version.ToString();

        public const string DefaultCodeGenerationHeader = @"Code generated by Microsoft (R) AutoRest Code Generator {0}
Changes may cause incorrect behavior and will be lost if the code is regenerated.";

        public const string DefaultCodeGenerationHeaderWithoutVersion = @"Code generated by Microsoft (R) AutoRest Code Generator.
Changes may cause incorrect behavior and will be lost if the code is regenerated.";

        public const string MicrosoftApacheLicenseHeader = @"Copyright (c) Microsoft and contributors.  All rights reserved.

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

See the License for the specific language governing permissions and
limitations under the License.
";

        public const string MicrosoftMitLicenseHeader = @"Copyright (c) Microsoft Corporation. All rights reserved.
Licensed under the MIT License. See License.txt in the project root for license information.
";

        public const string MicrosoftMitSmallLicenseHeader = @"Copyright (c) Microsoft Corporation. All rights reserved.
Licensed under the MIT License.
";

        private string _header;
        
        public Settings()
        {
            // this instance of the settings object should be used for subsequent 
            // requests for settings.
            Singleton<Settings>.Instance = this;

            FileSystemInput = new MemoryFileSystem();
            FileSystemOutput = new MemoryFileSystem();
            CustomSettings = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            Header = string.Format(CultureInfo.InvariantCulture, DefaultCodeGenerationHeaderWithoutVersion, Version);
            CodeGenerator = "CSharp";
            ModelsName = "Models";
            CodeGenerationMode = "rest-client";
            MaximumCommentColumns = DefaultMaximumCommentColumns;
        }

        /// <summary>
        /// Gets or sets the IFileSystem used by code generation.
        /// </summary>
        public MemoryFileSystem FileSystemInput { get; set; }

        /// <summary>
        /// Gets the Uri for the path to the folder that contains the input specification file.
        /// </summary>
        public MemoryFileSystem FileSystemOutput { get; set; }

        /// <summary>
        /// Custom provider specific settings.
        /// </summary>
        public IDictionary<string, object> CustomSettings { get; }

        // The CommandLineInfo attribute is reflected to display help.
        // Prefer to show required properties before optional.
        // Although not guaranteed by the Framework, the iteration order matches the
        // order of definition.

        #region ordered_properties

        public int MaximumCommentColumns { get; set; }

        /// <summary>
        /// Gets or sets a name for the generated client models Namespace and Models output folder
        /// </summary>
        public string ModelsName { get; set; }

        /// <summary>
        /// Gets or sets the code generation language.
        /// </summary>
        public string CodeGenerator { get; set; }

        #endregion

        /// <summary>
        /// Gets or sets the code generation mode (Server or Client)
        /// If the CodeGenerationMode is Server, AutoRest generates the server code for given spec
        /// else generates (by default) the client code for spec
        /// </summary>
        public string CodeGenerationMode { get; set; }

        /// <summary>
        /// Gets or sets a comment header to include in each generated file.
        /// </summary>
        public string Header
        {
            get { return _header; }
            set
            {
                if (value == "MICROSOFT_MIT")
                {
                    _header = MicrosoftMitLicenseHeader + Environment.NewLine + string.Format(CultureInfo.InvariantCulture, DefaultCodeGenerationHeader, Version);
                }
                else if (value == "MICROSOFT_APACHE")
                {
                    _header = MicrosoftApacheLicenseHeader + Environment.NewLine + string.Format(CultureInfo.InvariantCulture, DefaultCodeGenerationHeader, Version);
                }
                else if (value == "MICROSOFT_MIT_NO_VERSION")
                {
                    _header = MicrosoftMitLicenseHeader + Environment.NewLine + DefaultCodeGenerationHeaderWithoutVersion;
                }
                else if (value == "MICROSOFT_APACHE_NO_VERSION")
                {
                    _header = MicrosoftApacheLicenseHeader + Environment.NewLine + DefaultCodeGenerationHeaderWithoutVersion;
                }
                else if (value == "MICROSOFT_MIT_NO_CODEGEN")
                {
                    _header = MicrosoftMitLicenseHeader + Environment.NewLine + "Code generated by Microsoft (R) AutoRest Code Generator.";
                }
                else if (value == "NONE")
                {
                    _header = String.Empty;
                } else if (value == "MICROSOFT_MIT_SMALL") {
                    _header = MicrosoftMitSmallLicenseHeader + "Code generated by Microsoft (R) AutoRest Code Generator.";
                } else if (value == "MICROSOFT_MIT_SMALL_NO_CODEGEN") {
                    _header = MicrosoftMitSmallLicenseHeader;
                }
                else
                {
                    _header = value;
                }
            }
        }

        /// <summary>
        /// If set to true, collect and print out more detailed messages.
        /// </summary>
        public bool Verbose { get; set; }
    }
}
