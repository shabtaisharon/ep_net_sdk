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

using System;

namespace SpectraLogic.SpectraRioBrokerClient.Exceptions
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class InvalidDeviceCredentialsException : Exception
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidDeviceCredentialsException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public InvalidDeviceCredentialsException(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}