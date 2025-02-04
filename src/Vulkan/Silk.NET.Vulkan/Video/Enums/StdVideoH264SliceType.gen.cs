// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH264SliceType")]
    public enum StdVideoH264SliceType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"P\"")]
        [NativeName("Name", "STD_VIDEO_H264_SLICE_TYPE_P")]
        StdVideoH264SliceTypeP = 0x0,
        [Obsolete("Deprecated in favour of \"B\"")]
        [NativeName("Name", "STD_VIDEO_H264_SLICE_TYPE_B")]
        StdVideoH264SliceTypeB = 0x1,
        [Obsolete("Deprecated in favour of \"I\"")]
        [NativeName("Name", "STD_VIDEO_H264_SLICE_TYPE_I")]
        StdVideoH264SliceTypeI = 0x2,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_H264_SLICE_TYPE_INVALID")]
        StdVideoH264SliceTypeInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_H264_SLICE_TYPE_MAX_ENUM")]
        StdVideoH264SliceTypeMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_SLICE_TYPE_P")]
        P = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_SLICE_TYPE_B")]
        B = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_SLICE_TYPE_I")]
        I = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_SLICE_TYPE_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_SLICE_TYPE_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
