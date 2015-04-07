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

using NUnit.Framework;
using QuantConnect.Indicators;

namespace QuantConnect.Tests.Indicators
{
    [TestFixture]
    public class MovingAverageTypeExtensionsTests
    {
        [Test]
        public void CreatesCorrectAveragingIndicator()
        {
            var indicator = MovingAverageType.Simple.AsIndicator(1);
            Assert.IsInstanceOf(typeof(SimpleMovingAverage), indicator);

            indicator = MovingAverageType.Exponential.AsIndicator(1);
            Assert.IsInstanceOf(typeof(ExponentialMovingAverage), indicator);

            indicator = MovingAverageType.Wilders.AsIndicator(1);
            Assert.IsInstanceOf(typeof(ExponentialMovingAverage), indicator);

            string name = string.Empty;
            indicator = MovingAverageType.Simple.AsIndicator(name, 1);
            Assert.IsInstanceOf(typeof(SimpleMovingAverage), indicator);

            indicator = MovingAverageType.Exponential.AsIndicator(name, 1);
            Assert.IsInstanceOf(typeof(ExponentialMovingAverage), indicator);

            indicator = MovingAverageType.Wilders.AsIndicator(name, 1);
            Assert.IsInstanceOf(typeof(ExponentialMovingAverage), indicator);
        }
    }
}