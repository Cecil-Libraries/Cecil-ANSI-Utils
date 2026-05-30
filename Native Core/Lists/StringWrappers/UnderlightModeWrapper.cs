#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class UnderlightModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for UnderlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.UnderlightMode);
        
        /// <summary>
        /// Gets the Pointer of UnderlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlightMode")]
        public static IntPtr GetUnderlightMode() => Pointer;
        
        /// <summary>
        /// Gets the length of UnderlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlightMode_Length")]
        public static int GetUnderlightModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of UnderlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlightMode_Free")]
        public static void UnderlightModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of UnderlightMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlightMode_Restore")]
        public static void UnderlightModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.UnderlightMode);
        
        /// <summary>
        /// Checks if the memory of UnderlightMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlightMode_IsMemoryValid")]
        public static bool IsUnderlightModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif