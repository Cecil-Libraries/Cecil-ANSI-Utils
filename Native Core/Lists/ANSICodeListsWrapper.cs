#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists
{
    public static unsafe class ANSICodeListsWrapper
    {
        /// <summary>
        /// A list of all the colors.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public enum Color
        {
            Black = 0,
            Red = 1,
            Green = 2,
            Yellow = 3,
            Blue = 4,
            Magenta = 5,
            Cyan = 6,
            White = 7
        };

        /// <summary>
        /// The amount of colors provided in the lists.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public const int ColorCount = 8;

        // Start ColorList
        
        /// <summary>
        /// The Pointer variant of ANSICodeLists.ColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] ColorListPointers = ListUtils.InitializeList(ANSICodeLists.ColorList);

        /// <summary>
        /// Gets the length from ColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ColorList_Count")]
        public static int GetColorListCount() => ListUtils.GetListCount(ColorListPointers);

        /// <summary>
        /// Gets the color from ColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ColorList_Get")]
        public static IntPtr GetColor(int index) => ListUtils.GetItem(ColorListPointers, index);

        /// <summary>
        /// Finds the Index of the given Color within the ColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ColorList_FindColorIndex")]
        public static int FindColorIndex(IntPtr color) => ListUtils.GetItemIndex(ColorListPointers, color);

        /// <summary>
        /// Clears the memory of the ColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ColorList_FreeMemory")]
        public static void ClearColorListPointersMemory() => ListUtils.FreeMemorySingular(ColorListPointers);

        /// <summary>
        /// Restores the memory of the ColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ColorList_RestoreMemory")]
        public static void RestoreColorListPointersMemory() => ListUtils.RestoreMemorySingular(ColorListPointers, ANSICodeLists.ColorList);
        
        // End ColorList

        /// <summary>
        /// Clears the memory of all IntPtr arrays.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FreeMemory")]
        public static void ClearMemory() => ListUtils.FreeMemory(ColorListPointers);
        
        /// <summary>
        /// Restores the memory of all IntPtr arrays.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RestoreMemory")]
        public static void RestoreMemory() => ListUtils.RestoreMemory(new ListUtils.restoreParts
        {
            listToRestore = ColorListPointers,
            listToRestoreTo = ANSICodeLists.ColorList
        });
    }
}
#endif