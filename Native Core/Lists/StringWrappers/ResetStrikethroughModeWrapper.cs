#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetStrikethroughModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetStrikethroughMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetStrikethroughMode);
        
        /// <summary>
        /// Gets the Pointer of ResetStrikethroughMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetStrikethroughMode")]
        public static IntPtr GetResetStrikethroughMode() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetStrikethroughMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetStrikethroughMode_Length")]
        public static int GetResetStrikethroughModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetStrikethroughMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetStrikethroughMode_Free")]
        public static void ResetStrikethroughModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetStrikethroughMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetStrikethroughMode_Restore")]
        public static void ResetStrikethroughModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetStrikethroughMode);
        
        /// <summary>
        /// Checks if the memory of ResetStrikethroughMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetStrikethroughMode_IsMemoryValid")]
        public static bool IsResetStrikethroughModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif