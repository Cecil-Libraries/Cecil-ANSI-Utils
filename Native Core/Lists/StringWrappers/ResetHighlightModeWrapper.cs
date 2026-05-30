#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetHighlightModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetHighlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetHighlightMode);
        
        /// <summary>
        /// Gets the Pointer of ResetHighlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetHighlightMode")]
        public static IntPtr GetResetHighlightMode() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetHighlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetHighlightMode_Length")]
        public static int GetResetHighlightModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetHighlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetHighlightMode_Free")]
        public static void ResetHighlightModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetHighlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetHighlightMode_Restore")]
        public static void ResetHighlightModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetHighlightMode);
        
        /// <summary>
        /// Checks if the memory of ResetHighlightMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetHighlightMode_IsMemoryValid")]
        public static bool IsResetHighlightModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif