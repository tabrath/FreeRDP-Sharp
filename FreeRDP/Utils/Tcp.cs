﻿/**
 * FreeRDP: A Remote Desktop Protocol Implementation
 * Tcp Utils
 *
 * Copyright 2012 Marc-Andre Moreau <marcandre.moreau@gmail.com>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Runtime.InteropServices;

namespace FreeRDP
{
	public unsafe static class Tcp
	{
		[DllImport("libfreerdp-utils", CallingConvention = CallingConvention.Cdecl)]
		public static extern int freerdp_wsa_startup();

		[DllImport("libfreerdp-utils", CallingConvention = CallingConvention.Cdecl)]
		public static extern int freerdp_wsa_cleanup();

		public static int WSAStartup()
		{
			return freerdp_wsa_startup();
		}

		public static int WSACleanup()
		{
			return freerdp_wsa_cleanup();
		}
	}
}

