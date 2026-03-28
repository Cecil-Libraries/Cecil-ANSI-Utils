#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class StrikethroughModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for StrikethroughMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.StrikethroughMode);
        
        /// <summary>
        /// Gets the Pointer of StrikethroughMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_StrikethroughMode")]
        public static IntPtr GetStrikethroughMode() => Pointer;
        
        /// <summary>
        /// Gets the length of StrikethroughMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_StrikethroughMode_Length")]
        public static int GetStrikethroughModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of StrikethroughMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_StrikethroughMode_Free")]
        public static void StrikethroughModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of StrikethroughMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_StrikethroughMode_Restore")]
        public static void StrikethroughModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.StrikethroughMode);
        
        /// <summary>
        /// Checks if the memory of StrikethroughMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_StrikethroughMode_IsMemoryValid")]
        public static bool IsStrikethroughModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif