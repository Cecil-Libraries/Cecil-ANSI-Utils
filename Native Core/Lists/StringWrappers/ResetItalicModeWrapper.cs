#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetItalicModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetItalicMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetItalicMode);
        
        /// <summary>
        /// Gets the Pointer of ResetItalicMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetItalicMode")]
        public static IntPtr GetResetItalicMode() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetItalicMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetItalicMode_Length")]
        public static int GetResetItalicModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetItalicMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetItalicMode_Free")]
        public static void ResetItalicModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetItalicMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetItalicMode_Restore")]
        public static void ResetItalicModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetItalicMode);
        
        /// <summary>
        /// Checks if the memory of ResetItalicMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetItalicMode_IsMemoryValid")]
        public static bool IsResetItalicModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif