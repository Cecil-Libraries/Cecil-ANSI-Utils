#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetUnderlinedModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetUnderlinedMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetUnderlinedMode);
        
        /// <summary>
        /// Gets the Pointer of ResetUnderlinedMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetUnderlinedMode")]
        public static IntPtr GetResetUnderlinedMode() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetUnderlinedMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetUnderlinedMode_Length")]
        public static int GetResetUnderlinedModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetUnderlinedMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetUnderlinedMode_Free")]
        public static void ResetUnderlinedModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetUnderlinedMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetUnderlinedMode_Restore")]
        public static void ResetUnderlinedModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetUnderlinedMode);
        
        /// <summary>
        /// Checks if the memory of ResetUnderlinedMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetUnderlinedMode_IsMemoryValid")]
        public static bool IsResetUnderlinedModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif