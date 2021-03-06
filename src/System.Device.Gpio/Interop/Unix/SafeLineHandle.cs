﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace System.Device.Gpio
{
    /// <summary>
    /// Pointer to a pin.
    /// </summary>
    internal class SafeLineHandle : SafeHandle
    {
        public SafeLineHandle() : base(IntPtr.Zero, false) { }

        protected override bool ReleaseHandle() => true;

        public override bool IsInvalid => handle == IntPtr.Zero || handle == Interop.InvalidHandleValue;
    }
}
