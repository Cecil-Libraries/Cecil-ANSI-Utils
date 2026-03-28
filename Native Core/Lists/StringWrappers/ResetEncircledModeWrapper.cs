#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetEncircledModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetEncircledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetEncircledMode);
        
        /// <summary>
        /// Gets the Pointer of ResetEncircledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetEncircledMode")]
        public static IntPtr GetResetEncircledMode() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetEncircledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetEncircledMode_Length")]
        public static int GetResetEncircledModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetEncircledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetEncircledMode_Free")]
        public static void ResetEncircledModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetEncircledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetEncircledMode_Restore")]
        public static void ResetEncircledModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetEncircledMode);
        
        /// <summary>
        /// Checks if the memory of ResetEncircledMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetEncircledMode_IsMemoryValid")]
        public static bool IsResetEncircledModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif