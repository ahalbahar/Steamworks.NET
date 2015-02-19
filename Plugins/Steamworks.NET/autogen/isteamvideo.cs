// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2014 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamVideo {
		/// <summary>
		/// <para> Get a URL suitable for streaming the given Video app ID's video</para>
		/// </summary>
		public static void GetVideoURL(AppId_t unVideoAppID) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamVideo_GetVideoURL(unVideoAppID);
		}
	}
}