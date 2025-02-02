// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.FB
{
    [Extension("XR_FB_hand_tracking_mesh")]
    public unsafe partial class FBHandTrackingMesh : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_hand_tracking_mesh";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetHandMeshFB")]
        public unsafe partial Result GetHandMeshFB([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0)] HandTrackingMeshFB* mesh);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetHandMeshFB")]
        public partial Result GetHandMeshFB([Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0)] ref HandTrackingMeshFB mesh);

        public FBHandTrackingMesh(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

