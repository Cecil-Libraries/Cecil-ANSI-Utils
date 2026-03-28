#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class RegularModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for RegularMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.RegularMode);
        
        /// <summary>
        /// Gets the Pointer of RegularMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RegularMode")]
        public static IntPtr GetRegularMode() => Pointer;
        
        /// <summary>
        /// Gets the length of RegularMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RegularMode_Length")]
        public static int GetRegularModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of RegularMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RegularMode_Free")]
        public static void RegularModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of RegularMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RegularMode_Restore")]
        public static void RegularModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.RegularMode);
        
        /// <summary>
        /// Checks if the memory of RegularMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RegularMode_IsMemoryValid")]
        public static bool IsRegularModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif