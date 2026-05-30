#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class RapidModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for RapidMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.RapidMode);
        
        /// <summary>
        /// Gets the Pointer of RapidMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RapidMode")]
        public static IntPtr GetRapidMode() => Pointer;
        
        /// <summary>
        /// Gets the length of RapidMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RapidMode_Length")]
        public static int GetRapidModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of RapidMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RapidMode_Free")]
        public static void RapidModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of RapidMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RapidMode_Restore")]
        public static void RapidModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.RapidMode);
        
        /// <summary>
        /// Checks if the memory of RapidMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RapidMode_IsMemoryValid")]
        public static bool IsRapidModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif