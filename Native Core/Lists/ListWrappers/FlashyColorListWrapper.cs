#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.ListWrappers
{
	public class FlashyColorListWrapper
	{
		/// <summary>
        /// The Pointer variant of ANSICodeLists.FlashyColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static readonly IntPtr[] ColorListPointers = ListUtils.InitializeList(ANSICodeLists.FlashyColorList);
        
        /// <summary>
        /// Gets the length from FlashyColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_Count")]
        public static int GetFlashyColorListCount() => ListUtils.GetListCount(ColorListPointers);
        
        /// <summary>
        /// Gets the color from FlashyColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_Get")]
        public static IntPtr GetFlashyColor(int index) => ListUtils.GetItem(ColorListPointers, index);
        
        /// <summary>
        /// Gets the color from FlashyColorList at the given Index.
        /// </summary>
        /// <param name="color">The Enum value to fetch the Index from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_GetColorByEnum")]
        public static IntPtr GetColorByEnum(ANSICodeListsWrapper.Color color) => ListUtils.GetItem(ColorListPointers, (int)color);
        
        /// <summary>
        /// Finds the Index of the given Color within the FlashyColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_FindColorIndex")]
        public static int FindFlashyColorIndex(IntPtr color) => ListUtils.GetItemIndex(ColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the FlashyColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_FreeMemory")]
        public static void ClearColorListPointersMemory() => ListUtils.FreeMemorySingular(ColorListPointers);
        
        /// <summary>
        /// Restores the memory of the FlashyColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_RestoreMemory")]
        public static void RestoreColorListPointersMemory() => ListUtils.RestoreMemorySingular(ColorListPointers, ANSICodeLists.FlashyColorList);
        
        /// <summary>
        /// Checks if the memory in the FlashyColorList is valid for usage
        /// </summary>
        /// <returns>A true if the memory in the list is valid for use, otherwise false.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_IsMemoryValid")]
        public static bool IsFlashyColorListPointersMemoryValid() => ColorListPointers.All(p => p != IntPtr.Zero);
	}
}
#endif