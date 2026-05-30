#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class DoublelineModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for DoublelineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.DoublelineMode);
        
        /// <summary>
        /// Gets the Pointer of DoublelineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_DoublelineMode")]
        public static IntPtr GetDoublelineMode() => Pointer;
        
        /// <summary>
        /// Gets the length of DoublelineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_DoublelineMode_Length")]
        public static int GetDoublelineModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of DoublelineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_DoublelineMode_Free")]
        public static void DoublelineModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of DoublelineMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_DoublelineMode_Restore")]
        public static void DoublelineModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.DoublelineMode);
        
        /// <summary>
        /// Checks if the memory of DoublelineMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_DoublelineMode_IsMemoryValid")]
        public static bool IsDoublelineModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif