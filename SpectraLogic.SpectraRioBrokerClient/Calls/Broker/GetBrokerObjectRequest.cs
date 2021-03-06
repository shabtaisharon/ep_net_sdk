﻿/*
 * ******************************************************************************
 *   Copyright 2014-2020 Spectra Logic Corporation. All Rights Reserved.
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

using SpectraLogic.SpectraRioBrokerClient.Utils;
using System;

namespace SpectraLogic.SpectraRioBrokerClient.Calls.Broker
{
    /// <summary>
    /// </summary>
    /// <seealso cref="SpectraLogic.SpectraRioBrokerClient.Calls.RestRequest"/>
    public class GetBrokerObjectRequest : RestRequest
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBrokerObjectRequest"/> class.
        /// </summary>
        /// <param name="brokerName">Name of the broker.</param>
        /// <param name="objectName">Name of the object.</param>
        /// <param name="includeLocation">
        /// If enabled, will include object location information in the response. Defaults to false.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public GetBrokerObjectRequest(string brokerName, string objectName, bool? includeLocation = null)
        {
            Contract.Requires<ArgumentNullException>(brokerName != null, "brokerName");
            Contract.Requires<ArgumentNullException>(objectName != null, "objectName");

            BrokerName = brokerName;
            ObjectName = objectName;

            if (includeLocation != null)
            {
                AddQueryParam("includeLocation", includeLocation.ToString());
            }
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets the name of the broker.
        /// </summary>
        /// <value>The name of the broker.</value>
        public string BrokerName { get; private set; }

        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        /// <value>The name of the object.</value>
        public string ObjectName { get; private set; }

        internal override string Path => $"/api/brokers/{BrokerName}/objects/{Uri.EscapeDataString(ObjectName)}";
        internal override HttpVerb Verb => HttpVerb.GET;

        #endregion Properties
    }
}