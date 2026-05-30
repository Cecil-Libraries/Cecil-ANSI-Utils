#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetUnderlightModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetUnderlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetUnderlightMode);
        
        /// <summary>
        /// Gets the Pointer of ResetUnderlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetUnderlightMode")]
        public static IntPtr GetResetUnderlightMode() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetUnderlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetUnderlightMode_Length")]
        public static int GetResetUnderlightModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetUnderlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetUnderlightMode_Free")]
        public static void ResetUnderlightModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetUnderlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetUnderlightMode_Restore")]
        public static void ResetUnderlightModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetUnderlightMode);
        
        /// <summary>
        /// Checks if the memory of ResetUnderlightMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetUnderlightMode_IsMemoryValid")]
        public static bool IsResetUnderlightModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif