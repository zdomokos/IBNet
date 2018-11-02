﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using IBApi;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Event arguments class for the <see cref="InteractiveBrokersClient.MktDepthExchanges"/> event
    /// </summary>
    public class MktDepthExchangesEventArgs : EventArgs
    {
        /// <summary>
        /// The array of Depth Market Data Descriptions.
        /// </summary>
        public DepthMktDataDescription[] DepthMktDataDescriptions { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MktDepthExchangesEventArgs"/> class
        /// </summary>
        public MktDepthExchangesEventArgs(DepthMktDataDescription[] depthMktDataDescriptions)
        {
            DepthMktDataDescriptions = depthMktDataDescriptions;
        }
    }
}