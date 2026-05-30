#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetColorWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetColor
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetColor);
        
        /// <summary>
        /// Gets the Pointer of ResetColor
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetColor")]
        public static IntPtr GetResetColor() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetColor
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetColor_Length")]
        public static int GetResetColorLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetColor
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetColor_Free")]
        public static void ResetColorFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetColor
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetColor_Restore")]
        public static void ResetColorRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetColor);
        
        /// <summary>
        /// Checks if the memory of ResetColor is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetColor_IsMemoryValid")]
        public static bool IsResetColorMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif