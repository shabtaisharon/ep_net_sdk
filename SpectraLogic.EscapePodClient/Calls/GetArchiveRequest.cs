﻿/*
 * ******************************************************************************
 *   Copyright 2014-2018 Spectra Logic Corporation. All Rights Reserved.
 *   Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *   this file except in compliance with the License. A copy of the License is located at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 *   or in the "license" file accompanying this file.
 *   This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *   CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *   specific language governing permissions and limitations under the License.
 * ****************************************************************************
 */

using System.Linq;

namespace SpectraLogic.EscapePodClient.Calls
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SpectraLogic.EscapePodClient.Calls.RestRequest" />
    public class GetArchiveRequest : RestRequest
    {
        /// <summary>
        /// Gets the name of the archive.
        /// </summary>
        /// <value>
        /// The name of the archive.
        /// </value>
        public string ArchiveName { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetArchiveRequest"/> class.
        /// </summary>
        /// <param name="archiveName">Name of the archive.</param>
        public GetArchiveRequest(string archiveName)
        {
            ArchiveName = archiveName;
        }

        internal override HttpVerb Verb => HttpVerb.GET;
        internal override string Path => $"/api/archives/{ArchiveName}";
        
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Path}\n{Verb}";
        }
    }
}
