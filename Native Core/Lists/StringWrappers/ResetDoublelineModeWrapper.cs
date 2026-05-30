#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetDoublelineModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetDoublelineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetDoublelineMode);
        
        /// <summary>
        /// Gets the Pointer of ResetDoublelineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetDoublelineMode")]
        public static IntPtr GetResetDoublelineMode() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetDoublelineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetDoublelineMode_Length")]
        public static int GetResetDoublelineModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetDoublelineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetDoublelineMode_Free")]
        public static void ResetDoublelineModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetDoublelineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetDoublelineMode_Restore")]
        public static void ResetDoublelineModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetDoublelineMode);
        
        /// <summary>
        /// Checks if the memory of ResetDoublelineMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetDoublelineMode_IsMemoryValid")]
        public static bool IsResetDoublelineModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif