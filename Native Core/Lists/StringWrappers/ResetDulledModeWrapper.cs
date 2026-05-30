#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers
{
	public class ResetDulledModeWrapper
	{
		/// <summary>
        /// Defines the Pointer for ResetDulledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr Pointer = StringUtils.InitializeString(ANSICodeLists.ResetDulledMode);
        
        /// <summary>
        /// Gets the Pointer of ResetDulledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetDulledMode")]
        public static IntPtr GetResetDulledMode() => Pointer;
        
        /// <summary>
        /// Gets the length of ResetDulledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetDulledMode_Length")]
        public static int GetResetDulledModeLength() => StringUtils.GetStringLength(Pointer);
        
        /// <summary>
        /// Frees the memory of ResetDulledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetDulledMode_Free")]
        public static void ResetDulledModeFree() => StringUtils.FreeMemorySingular(ref Pointer);
        
        /// <summary>
        /// Restores the memory of ResetDulledMode
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetDulledMode_Restore")]
        public static void ResetDulledModeRestore() => StringUtils.RestoreMemorySingular(ref Pointer, ANSICodeLists.ResetDulledMode);
        
        /// <summary>
        /// Checks if the memory of ResetDulledMode is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the string is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ResetDulledMode_IsMemoryValid")]
        public static bool IsResetDulledModeMemoryValid() => Pointer != IntPtr.Zero;
	}
}
#endif