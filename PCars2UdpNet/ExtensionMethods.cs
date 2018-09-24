// <copyright file="ExtensionMethods.cs" company="Racing Sim Tools">
// Original work Copyright (c) MWL. All rights reserved.
//
// Modified work Copyright 2015 - 2018, Jim Britton and Contributors. [Crew Chief]
// Copyright (c) Racing Sim Tools. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace PCars2UdpNet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reactive.Linq;
    using System.Text;
    using Structs;

    public static class ExtensionMethods
    {
        public static IObservable<TSource> Sort<TSource>(
             this IObservable<TSource> source,
             Func<TSource, uint> keySelector,
             int bufferMax = 10)
        {
            return Observable.Create<TSource>(o =>
            {
                uint nextKey = 0;
                var buffer = new Dictionary<uint, TSource>();
                return source.Subscribe(i =>
                {
                    // First packet recieved.
                    if (nextKey == 0)
                    {
                        nextKey = keySelector(i);
                    }

                    // Check if we are in sequence
                    if (keySelector(i).Equals(nextKey))
                    {
                        nextKey++;
                        o.OnNext(i);
                    }
                    else
                    {
                        // Only add later packets. (Drop older ones)
                        if (keySelector(i) > nextKey)
                        {
                            buffer.Add(keySelector(i), i);
                        }

                        // If the max buffer reached, assume packet was lost.
                        if (buffer.Count > bufferMax)
                        {
                            nextKey = buffer.Keys.Min();
                        }
                    }

                    while (buffer.TryGetValue(nextKey, out TSource nextValue))
                    {
                        buffer.Remove(nextKey);
                        o.OnNext(nextValue);
                        nextKey++;
                    }
                });
            });
        }
    }
}
