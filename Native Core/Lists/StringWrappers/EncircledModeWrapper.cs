#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class EncircledModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for EncircledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.EncircledMode);
        
        /// <summary>
        /// Gets the Pointer of EncircledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_EncircledMode")]
        public static IntPtr GetEncircledMode() => Pointer;
        
        /// <summary>
        /// Gets the length of EncircledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_EncircledMode_Length")]
        public static int GetEncircledModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of EncircledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_EncircledMode_Free")]
        public static void EncircledModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of EncircledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_EncircledMode_Restore")]
        public static void EncircledModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.EncircledMode);
        
        /// <summary>
        /// Checks if the memory of EncircledMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_EncircledMode_IsMemoryValid")]
        public static bool IsEncircledModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif