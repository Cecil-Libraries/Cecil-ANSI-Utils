#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetOverlineModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetOverlineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetOverlineMode);
        
        /// <summary>
        /// Gets the Pointer of ResetOverlineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetOverlineMode")]
        public static IntPtr GetResetOverlineMode() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetOverlineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetOverlineMode_Length")]
        public static int GetResetOverlineModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetOverlineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetOverlineMode_Free")]
        public static void ResetOverlineModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetOverlineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetOverlineMode_Restore")]
        public static void ResetOverlineModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetOverlineMode);
        
        /// <summary>
        /// Checks if the memory of ResetOverlineMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetOverlineMode_IsMemoryValid")]
        public static bool IsResetOverlineModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif