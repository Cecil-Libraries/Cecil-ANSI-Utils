#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class BoldModeWrapper
	{
		/// <summary>
		/// Defines the Pointer for BoldMode
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.BoldMode);
		
		/// <summary>
		/// Gets the Pointer of BoldMode
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BoldMode")]
		public static IntPtr GetBoldMode() => Pointer;
		
		/// <summary>
		/// Gets the length of BoldMode
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BoldMode_Length")]
		public static int GetBoldModeLength() => StringUtils.GetStringLength(Pointer);
		
		/// <summary>
		/// Frees the memory of BoldMode
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BoldMode_Free")]
		public static void BoldModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
		
		/// <summary>
		/// Restores the memory of BoldMode
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BoldMode_Restore")]
		public static void BoldModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.BoldMode);
		
		/// <summary>
		/// Checks if the memory of BoldMode is valid for usage
		/// </summary>
		/// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BoldMode_IsMemoryValid")]
		public static bool IsBoldModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif