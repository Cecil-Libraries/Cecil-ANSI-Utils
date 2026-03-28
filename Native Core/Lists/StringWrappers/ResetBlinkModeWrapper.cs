#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetBlinkModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetBlinkMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetBlinkMode);
        
        /// <summary>
        /// Gets the Pointer of ResetBlinkMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetBlinkMode")]
        public static IntPtr GetResetBlinkMode() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetBlinkMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetBlinkMode_Length")]
        public static int GetResetBlinkModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetBlinkMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetBlinkMode_Free")]
        public static void ResetBlinkModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetBlinkMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetBlinkMode_Restore")]
        public static void ResetBlinkModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetBlinkMode);
        
        /// <summary>
        /// Checks if the memory of ResetBlinkMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetBlinkMode_IsMemoryValid")]
        public static bool IsResetBlinkModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif