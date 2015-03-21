﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;
using System.Threading;

internal partial class Interop
{
    internal partial class mincore
    {
        [DllImport(Libraries.CoreFile_L1, SetLastError = true)]
        unsafe internal static extern int ReadFile(
            SafeHandle handle,
            byte* bytes,
            int numBytesToRead,
            IntPtr numBytesRead_mustBeZero,
            NativeOverlapped* overlapped);
    }
}
