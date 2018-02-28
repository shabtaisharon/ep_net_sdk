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
using SpectraLogic.SpectraStorageBrokerClient.Utils;
using System;

namespace SpectraLogic.SpectraStorageBrokerClient.Calls
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="SpectraLogic.SpectraStorageBrokerClient.Calls.RestRequest" />
    public class CreateDeviceRequest : RestRequest
    {
        #region Public Fields

        /// <summary>
        /// The device name
        /// </summary>
        [JsonProperty(Order = 1, PropertyName = "name")] public string DeviceName;

        /// <summary>
        /// The MGMT interface
        /// </summary>
        [JsonProperty(Order = 2, PropertyName = "mgmtInterface")] public string MgmtInterface;

        /// <summary>
        /// The password
        /// </summary>
        [JsonProperty(Order = 4, PropertyName = "password")] public string Password;

        /// <summary>
        /// The username
        /// </summary>
        [JsonProperty(Order = 3, PropertyName = "username")] public string Username;

        #endregion Public Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeviceRequest" /> class.
        /// </summary>
        /// <param name="deviceName">The device name.</param>
        /// <param name="mgmtInterface">The MGMT interface.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public CreateDeviceRequest(string deviceName, string mgmtInterface, string username, string password)
        {
            Contract.Requires<ArgumentNullException>(deviceName != null, "deviceName");
            Contract.Requires<ArgumentNullException>(mgmtInterface != null, "mgmtInterface");
            Contract.Requires<ArgumentNullException>(username != null, "username");
            Contract.Requires<ArgumentNullException>(password != null, "password");

            DeviceName = deviceName;
            MgmtInterface = mgmtInterface;
            Username = username;
            Password = password;
        }

        #endregion Public Constructors

        #region Internal Properties

        internal override string Path => $"/api/devices/spectra";
        internal override HttpVerb Verb => HttpVerb.POST;

        #endregion Internal Properties

        #region Public Methods

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Path}\n{Verb}\n{GetBody()}";
        }

        #endregion Public Methods

        #region Internal Methods

        internal override string GetBody()
        {
            return JsonConvert.SerializeObject(this);
        }

        #endregion Internal Methods
    }
}