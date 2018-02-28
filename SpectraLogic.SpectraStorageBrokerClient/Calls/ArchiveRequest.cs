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

using Newtonsoft.Json;
using SpectraLogic.SpectraStorageBrokerClient.Model;
using SpectraLogic.SpectraStorageBrokerClient.Utils;
using System;
using System.Collections.Generic;

namespace SpectraLogic.SpectraStorageBrokerClient.Calls
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="SpectraLogic.SpectraStorageBrokerClient.Calls.RestRequest" />
    public class ArchiveRequest : RestRequest
    {
        #region Public Fields

        /// <summary>
        /// The files to be archive
        /// </summary>
        [JsonProperty(PropertyName = "files")] public IEnumerable<ArchiveFile> Files;

        #endregion Public Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveRequest" /> class.
        /// </summary>
        /// <param name="brokerName">Name of the broker.</param>
        /// <param name="files">The files.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public ArchiveRequest(string brokerName, IEnumerable<ArchiveFile> files)
        {
            Contract.Requires<ArgumentNullException>(brokerName != null, "brokerName");
            Contract.Requires<ArgumentNullException>(files != null, "files");

            BrokerName = brokerName;
            Files = files;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets the name of the broker.
        /// </summary>
        /// <value>
        /// The name of the broker.
        /// </value>
        [JsonIgnore] public string BrokerName { get; private set; }

        #endregion Public Properties

        #region Internal Properties

        internal override string Path => $"/api/brokers/{BrokerName}/archive";
        internal override HttpVerb Verb => HttpVerb.POST;

        #endregion Internal Properties

        #region Internal Methods

        internal override string GetBody()
        {
            return JsonConvert.SerializeObject(this);
        }

        #endregion Internal Methods
    }
}