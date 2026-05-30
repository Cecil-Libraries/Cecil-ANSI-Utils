#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class UnderlinedModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for UnderlinedMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.UnderlinedMode);
        
        /// <summary>
        /// Gets the Pointer of UnderlinedMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlinedMode")]
        public static IntPtr GetUnderlinedMode() => Pointer;
        
        /// <summary>
        /// Gets the length of UnderlinedMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlinedMode_Length")]
        public static int GetUnderlinedModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of UnderlinedMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlinedMode_Free")]
        public static void UnderlinedModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of UnderlinedMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlinedMode_Restore")]
        public static void UnderlinedModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.UnderlinedMode);
        
        /// <summary>
        /// Checks if the memory of UnderlinedMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlinedMode_IsMemoryValid")]
        public static bool IsUnderlinedModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif