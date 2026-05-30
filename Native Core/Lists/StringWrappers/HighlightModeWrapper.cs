#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class HighlightModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for HighlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.HighlightMode);
        
        /// <summary>
        /// Gets the Pointer of HighlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighlightMode")]
        public static IntPtr GetHighlightMode() => Pointer;
        
        /// <summary>
        /// Gets the length of HighlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighlightMode_Length")]
        public static int GetHighlightModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of HighlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighlightMode_Free")]
        public static void HighlightModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of HighlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighlightMode_Restore")]
        public static void HighlightModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.HighlightMode);
        
        /// <summary>
        /// Checks if the memory of HighlightMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighlightMode_IsMemoryValid")]
        public static bool IsHighlightModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif