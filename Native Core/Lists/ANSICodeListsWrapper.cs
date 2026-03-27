#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS0618 // Type or member is obsolete

namespace Cecil_Libraries.Native_ANSI_Utils.Lists
{
    /// <summary>
    /// ANSICodeList's NativeAOT Wrapper.
    /// </summary>
    public static class ANSICodeListsWrapper
    {
        /// <summary>
        /// A list of all the colors.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public enum Color
        {
            /// <summary>
            /// The Color Black
            /// </summary>
            Black = 0,
            /// <summary>
            /// The Color Red
            /// </summary>
            Red = 1,
            /// <summary>
            /// The Color Green
            /// </summary>
            Green = 2,
            /// <summary>
            /// The Color Yellow
            /// </summary>
            Yellow = 3,
            /// <summary>
            /// The Color Blue
            /// </summary>
            Blue = 4,
            /// <summary>
            /// The Color Magenta
            /// </summary>
            Magenta = 5,
            /// <summary>
            /// The Color Cyan
            /// </summary>
            Cyan = 6,
            /// <summary>
            /// The Color White
            /// </summary>
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
        
        // Start BoldColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.BoldColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] BoldColorListPointers = ListUtils.InitializeList(ANSICodeLists.BoldColorList);
        
        /// <summary>
        /// Gets the length from BoldColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BoldColorList_Count")]
        public static int GetBoldColorListCount() => ListUtils.GetListCount(BoldColorListPointers);
        
        /// <summary>
        /// Gets the color from BoldColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BoldColorList_Get")]
        public static IntPtr GetBoldColor(int index) => ListUtils.GetItem(BoldColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the BoldColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BoldColorList_FindColorIndex")]
        public static int FindBoldColorIndex(IntPtr color) => ListUtils.GetItemIndex(BoldColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the BoldColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BoldColorList_FreeMemory")]
        public static void ClearBoldColorListPointersMemory() => ListUtils.FreeMemorySingular(BoldColorListPointers);
        
        /// <summary>
        /// Restores the memory of the BoldColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BoldColorList_RestoreMemory")]
        public static void RestoreBoldColorListPointersMemory() => ListUtils.RestoreMemorySingular(BoldColorListPointers, ANSICodeLists.BoldColorList);
        
        // End BoldColorList
        
        // Start DarkenedColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.DarkenedColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] DarkenedColorListPointers = ListUtils.InitializeList(ANSICodeLists.DarkenedColorList);
        
        /// <summary>
        /// Gets the length from DarkenedColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_DarkenedColorList_Count")]
        public static int GetDarkenedColorListCount() => ListUtils.GetListCount(DarkenedColorListPointers);
        
        /// <summary>
        /// Gets the color from DarkenedColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_DarkenedColorList_Get")]
        public static IntPtr GetDarkenedColor(int index) => ListUtils.GetItem(DarkenedColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the DarkenedColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_DarkenedColorList_FindColorIndex")]
        public static int FindDarkenedColorIndex(IntPtr color) => ListUtils.GetItemIndex(DarkenedColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the DarkenedColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_DarkenedColorList_FreeMemory")]
        public static void ClearDarkenedColorListPointersMemory() => ListUtils.FreeMemorySingular(DarkenedColorListPointers);
        
        /// <summary>
        /// Restores the memory of the DarkenedColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_DarkenedColorList_RestoreMemory")]
        public static void RestoreDarkenedColorListPointersMemory() => ListUtils.RestoreMemorySingular(DarkenedColorListPointers, ANSICodeLists.DarkenedColorList);
        
        // End DarkenedColorList
        
        // Start ItalicColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.ItalicColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] ItalicColorListPointers = ListUtils.InitializeList(ANSICodeLists.ItalicColorList);
        
        /// <summary>
        /// Gets the length from ItalicColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ItalicColorList_Count")]
        public static int GetItalicColorListCount() => ListUtils.GetListCount(ItalicColorListPointers);
        
        /// <summary>
        /// Gets the color from ItalicColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ItalicColorList_Get")]
        public static IntPtr GetItalicColor(int index) => ListUtils.GetItem(ItalicColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the ItalicColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ItalicColorList_FindColorIndex")]
        public static int FindItalicColorIndex(IntPtr color) => ListUtils.GetItemIndex(ItalicColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the ItalicColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ItalicColorList_FreeMemory")]
        public static void ClearItalicColorListPointersMemory() => ListUtils.FreeMemorySingular(ItalicColorListPointers);
        
        /// <summary>
        /// Restores the memory of the ItalicColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ItalicColorList_RestoreMemory")]
        public static void RestoreItalicColorListPointersMemory() => ListUtils.RestoreMemorySingular(ItalicColorListPointers, ANSICodeLists.ItalicColorList);
        
        // End ItalicColorList
        
        // Start UnderlineColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.UnderlineColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] UnderlineColorListPointers = ListUtils.InitializeList(ANSICodeLists.UnderlineColorList);
        
        /// <summary>
        /// Gets the length from UnderlineColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlineColorList_Count")]
        public static int GetUnderlineColorListCount() => ListUtils.GetListCount(UnderlineColorListPointers);
        
        /// <summary>
        /// Gets the color from UnderlineColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlineColorList_Get")]
        public static IntPtr GetUnderlineColor(int index) => ListUtils.GetItem(UnderlineColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the UnderlineColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlineColorList_FindColorIndex")]
        public static int FindUnderlineColorIndex(IntPtr color) => ListUtils.GetItemIndex(UnderlineColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the UnderlineColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlineColorList_FreeMemory")]
        public static void ClearUnderlineColorListPointersMemory() => ListUtils.FreeMemorySingular(UnderlineColorListPointers);
        
        /// <summary>
        /// Restores the memory of the UnderlineColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_UnderlineColorList_RestoreMemory")]
        public static void RestoreUnderlineColorListPointersMemory() => ListUtils.RestoreMemorySingular(UnderlineColorListPointers, ANSICodeLists.UnderlineColorList);
        
        // End UnderlineColorList
        
        // Start FlashyColorList
                        
        /// <summary>
        /// The Pointer variant of ANSICodeLists.FlashyColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] FlashyColorListPointers = ListUtils.InitializeList(ANSICodeLists.FlashyColorList);
        
        /// <summary>
        /// Gets the length from FlashyColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_Count")]
        public static int GetFlashyColorListCount() => ListUtils.GetListCount(FlashyColorListPointers);
        
        /// <summary>
        /// Gets the color from FlashyColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_Get")]
        public static IntPtr GetFlashyColor(int index) => ListUtils.GetItem(FlashyColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the FlashyColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_FindColorIndex")]
        public static int FindFlashyColorIndex(IntPtr color) => ListUtils.GetItemIndex(FlashyColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the FlashyColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_FreeMemory")]
        public static void ClearFlashyColorListPointersMemory() => ListUtils.FreeMemorySingular(FlashyColorListPointers);
        
        /// <summary>
        /// Restores the memory of the FlashyColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FlashyColorList_RestoreMemory")]
        public static void RestoreFlashyColorListPointersMemory() => ListUtils.RestoreMemorySingular(FlashyColorListPointers, ANSICodeLists.FlashyColorList);
        
        // End FlashyColorList
        
        // Start HighlighterColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.HighlighterColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] HighlighterColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighlighterColorList);
        
        /// <summary>
        /// Gets the length from HighlighterColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighlighterColorList_Count")]
        public static int GetHighlighterColorListCount() => ListUtils.GetListCount(HighlighterColorListPointers);
        
        /// <summary>
        /// Gets the color from HighlighterColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighlighterColorList_Get")]
        public static IntPtr GetHighlighterColor(int index) => ListUtils.GetItem(HighlighterColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the HighlighterColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighlighterColorList_FindColorIndex")]
        public static int FindHighlighterColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighlighterColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the HighlighterColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighlighterColorList_FreeMemory")]
        public static void ClearHighlighterColorListPointersMemory() => ListUtils.FreeMemorySingular(HighlighterColorListPointers);
        
        /// <summary>
        /// Restores the memory of the HighlighterColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighlighterColorList_RestoreMemory")]
        public static void RestoreHighlighterColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighlighterColorListPointers, ANSICodeLists.HighlighterColorList);
        
        // End HighlighterColorList
        
        // Start InvisibleColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.InvisibleColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] InvisibleColorListPointers = ListUtils.InitializeList(ANSICodeLists.InvisibleColorList);
        
        /// <summary>
        /// Gets the length from InvisibleColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_InvisibleColorList_Count")]
        public static int GetInvisibleColorListCount() => ListUtils.GetListCount(InvisibleColorListPointers);
        
        /// <summary>
        /// Gets the color from InvisibleColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_InvisibleColorList_Get")]
        public static IntPtr GetInvisibleColor(int index) => ListUtils.GetItem(InvisibleColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the InvisibleColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_InvisibleColorList_FindColorIndex")]
        public static int FindInvisibleColorIndex(IntPtr color) => ListUtils.GetItemIndex(InvisibleColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the InvisibleColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_InvisibleColorList_FreeMemory")]
        public static void ClearInvisibleColorListPointersMemory() => ListUtils.FreeMemorySingular(InvisibleColorListPointers);
        
        /// <summary>
        /// Restores the memory of the InvisibleColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_InvisibleColorList_RestoreMemory")]
        public static void RestoreInvisibleColorListPointersMemory() => ListUtils.RestoreMemorySingular(InvisibleColorListPointers, ANSICodeLists.InvisibleColorList);
        
        // End InvisibleColorList
        
        // Start StrikethroughColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.StrikethroughColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] StrikethroughColorListPointers = ListUtils.InitializeList(ANSICodeLists.StrikethroughColorList);
        
        /// <summary>
        /// Gets the length from StrikethroughColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_StrikethroughColorList_Count")]
        public static int GetStrikethroughColorListCount() => ListUtils.GetListCount(StrikethroughColorListPointers);
        
        /// <summary>
        /// Gets the color from StrikethroughColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_StrikethroughColorList_Get")]
        public static IntPtr GetStrikethroughColor(int index) => ListUtils.GetItem(StrikethroughColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the StrikethroughColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_StrikethroughColorList_FindColorIndex")]
        public static int FindStrikethroughColorIndex(IntPtr color) => ListUtils.GetItemIndex(StrikethroughColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the StrikethroughColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_StrikethroughColorList_FreeMemory")]
        public static void ClearStrikethroughColorListPointersMemory() => ListUtils.FreeMemorySingular(StrikethroughColorListPointers);
        
        /// <summary>
        /// Restores the memory of the StrikethroughColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_StrikethroughColorList_RestoreMemory")]
        public static void RestoreStrikethroughColorListPointersMemory() => ListUtils.RestoreMemorySingular(StrikethroughColorListPointers, ANSICodeLists.StrikethroughColorList);
        
        // End StrikethroughColorList
        
        // Start BackgroundColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.BackgroundColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] BackgroundColorListPointers = ListUtils.InitializeList(ANSICodeLists.BackgroundColorList);
        
        /// <summary>
        /// Gets the length from BackgroundColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BackgroundColorList_Count")]
        public static int GetBackgroundColorListCount() => ListUtils.GetListCount(BackgroundColorListPointers);
        
        /// <summary>
        /// Gets the color from BackgroundColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BackgroundColorList_Get")]
        public static IntPtr GetBackgroundColor(int index) => ListUtils.GetItem(BackgroundColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the BackgroundColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BackgroundColorList_FindColorIndex")]
        public static int FindBackgroundColorIndex(IntPtr color) => ListUtils.GetItemIndex(BackgroundColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the BackgroundColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BackgroundColorList_FreeMemory")]
        public static void ClearBackgroundColorListPointersMemory() => ListUtils.FreeMemorySingular(BackgroundColorListPointers);
        
        /// <summary>
        /// Restores the memory of the BackgroundColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_BackgroundColorList_RestoreMemory")]
        public static void RestoreBackgroundColorListPointersMemory() => ListUtils.RestoreMemorySingular(BackgroundColorListPointers, ANSICodeLists.BackgroundColorList);
        
        // End BackgroundColorList
        
        // Start HighIntensityBackgroundColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.HighIntensityBackgroundColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] HighIntensityBackgroundColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityBackgroundColorList);
        
        /// <summary>
        /// Gets the length from HighIntensityBackgroundColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityBackgroundColorList_Count")]
        public static int GetHighIntensityBackgroundColorListCount() => ListUtils.GetListCount(HighIntensityBackgroundColorListPointers);
        
        /// <summary>
        /// Gets the color from HighIntensityBackgroundColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityBackgroundColorList_Get")]
        public static IntPtr GetHighIntensityBackgroundColor(int index) => ListUtils.GetItem(HighIntensityBackgroundColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the HighIntensityBackgroundColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityBackgroundColorList_FindColorIndex")]
        public static int FindHighIntensityBackgroundColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighIntensityBackgroundColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the HighIntensityBackgroundColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityBackgroundColorList_FreeMemory")]
        public static void ClearHighIntensityBackgroundColorListPointersMemory() => ListUtils.FreeMemorySingular(HighIntensityBackgroundColorListPointers);
        
        /// <summary>
        /// Restores the memory of the HighIntensityBackgroundColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityBackgroundColorList_RestoreMemory")]
        public static void RestoreHighIntensityBackgroundColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighIntensityBackgroundColorListPointers, ANSICodeLists.HighIntensityBackgroundColorList);
        
        // End HighIntensityBackgroundColorList
        
        // Start HighIntensityColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.HighIntensityColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] HighIntensityColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityColorList);
        
        /// <summary>
        /// Gets the length from HighIntensityColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityColorList_Count")]
        public static int GetHighIntensityColorListCount() => ListUtils.GetListCount(HighIntensityColorListPointers);
        
        /// <summary>
        /// Gets the color from HighIntensityColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityColorList_Get")]
        public static IntPtr GetHighIntensityColor(int index) => ListUtils.GetItem(HighIntensityColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the HighIntensityColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityColorList_FindColorIndex")]
        public static int FindHighIntensityColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighIntensityColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the HighIntensityColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityColorList_FreeMemory")]
        public static void ClearHighIntensityColorListPointersMemory() => ListUtils.FreeMemorySingular(HighIntensityColorListPointers);
        
        /// <summary>
        /// Restores the memory of the HighIntensityColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityColorList_RestoreMemory")]
        public static void RestoreHighIntensityColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighIntensityColorListPointers, ANSICodeLists.HighIntensityColorList);
        
        // End HighIntensityColorList

        // Start HighIntensityBoldColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.HighIntensityBoldColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] HighIntensityBoldColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityBoldColorList);
        
        /// <summary>
        /// Gets the length from HighIntensityBoldColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityBoldColorList_Count")]
        public static int GetHighIntensityBoldColorListCount() => ListUtils.GetListCount(HighIntensityBoldColorListPointers);
        
        /// <summary>
        /// Gets the color from HighIntensityBoldColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityBoldColorList_Get")]
        public static IntPtr GetHighIntensityBoldColor(int index) => ListUtils.GetItem(HighIntensityBoldColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the HighIntensityBoldColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityBoldColorList_FindColorIndex")]
        public static int FindHighIntensityBoldColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighIntensityBoldColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the HighIntensityBoldColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityBoldColorList_FreeMemory")]
        public static void ClearHighIntensityBoldColorListPointersMemory() => ListUtils.FreeMemorySingular(HighIntensityBoldColorListPointers);
        
        /// <summary>
        /// Restores the memory of the HighIntensityBoldColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityBoldColorList_RestoreMemory")]
        public static void RestoreHighIntensityBoldColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighIntensityBoldColorListPointers, ANSICodeLists.HighIntensityBoldColorList);
        
        // End HighIntensityBoldColorList

        // Start HighIntensityDarkenedColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.HighIntensityDarkenedColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] HighIntensityDarkenedColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityDarkenedColorList);
        
        /// <summary>
        /// Gets the length from HighIntensityDarkenedColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityDarkenedColorList_Count")]
        public static int GetHighIntensityDarkenedColorListCount() => ListUtils.GetListCount(HighIntensityDarkenedColorListPointers);
        
        /// <summary>
        /// Gets the color from HighIntensityDarkenedColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityDarkenedColorList_Get")]
        public static IntPtr GetHighIntensityDarkenedColor(int index) => ListUtils.GetItem(HighIntensityDarkenedColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the HighIntensityDarkenedColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityDarkenedColorList_FindColorIndex")]
        public static int FindHighIntensityDarkenedColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighIntensityDarkenedColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the HighIntensityDarkenedColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityDarkenedColorList_FreeMemory")]
        public static void ClearHighIntensityDarkenedColorListPointersMemory() => ListUtils.FreeMemorySingular(HighIntensityDarkenedColorListPointers);
        
        /// <summary>
        /// Restores the memory of the HighIntensityDarkenedColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityDarkenedColorList_RestoreMemory")]
        public static void RestoreHighIntensityDarkenedColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighIntensityDarkenedColorListPointers, ANSICodeLists.HighIntensityDarkenedColorList);
        
        // End HighIntensityDarkenedColorList

        // Start HighIntensityItalicColorList
		
		/// <summary>
		/// The Pointer variant of ANSICodeLists.HighIntensityItalicColorList
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static readonly IntPtr[] HighIntensityItalicColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityItalicColorList);
		
		/// <summary>
		/// Gets the length from HighIntensityItalicColorList.
		/// </summary>
		/// <returns>The length of the array</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_Count")]
		public static int GetHighIntensityItalicColorListCount() => ListUtils.GetListCount(HighIntensityItalicColorListPointers);
		
		/// <summary>
		/// Gets the color from HighIntensityItalicColorList at the given Index.
		/// </summary>
		/// <param name="index">The Index in which you want to get the color from.</param>
		/// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_Get")]
		public static IntPtr GetHighIntensityItalicColor(int index) => ListUtils.GetItem(HighIntensityItalicColorListPointers, index);
		
		/// <summary>
		/// Finds the Index of the given Color within the HighIntensityItalicColorList.
		/// </summary>
		/// <param name="color">The color in which we need to find the index of.</param>
		/// <returns>The index of the color, if we can't find one we return -1</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_FindColorIndex")]
		public static int FindHighIntensityItalicColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighIntensityItalicColorListPointers, color);
		
		/// <summary>
		/// Clears the memory of the HighIntensityItalicColorList.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_FreeMemory")]
		public static void ClearHighIntensityItalicColorListPointersMemory() => ListUtils.FreeMemorySingular(HighIntensityItalicColorListPointers);
		
		/// <summary>
		/// Restores the memory of the HighIntensityItalicColorList.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_RestoreMemory")] 
		public static void RestoreHighIntensityItalicColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighIntensityItalicColorListPointers, ANSICodeLists.HighIntensityItalicColorList);
		
		// End HighIntensityItalicColorList
        
        // Start HighIntensityUnderlineColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.HighIntensityUnderlineColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] HighIntensityUnderlineColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityUnderlineColorList);
        
        /// <summary>
        /// Gets the length from HighIntensityUnderlineColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityUnderlineColorList_Count")]
        public static int GetHighIntensityUnderlineColorListCount() => ListUtils.GetListCount(HighIntensityUnderlineColorListPointers);
        
        /// <summary>
        /// Gets the color from HighIntensityUnderlineColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityUnderlineColorList_Get")]
        public static IntPtr GetHighIntensityUnderlineColor(int index) => ListUtils.GetItem(HighIntensityUnderlineColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the HighIntensityUnderlineColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityUnderlineColorList_FindColorIndex")]
        public static int FindHighIntensityUnderlineColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighIntensityUnderlineColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the HighIntensityUnderlineColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityUnderlineColorList_FreeMemory")]
        public static void ClearHighIntensityUnderlineColorListPointersMemory() => ListUtils.FreeMemorySingular(HighIntensityUnderlineColorListPointers);
        
        /// <summary>
        /// Restores the memory of the HighIntensityUnderlineColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityUnderlineColorList_RestoreMemory")]
        public static void RestoreHighIntensityUnderlineColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighIntensityUnderlineColorListPointers, ANSICodeLists.HighIntensityUnderlineColorList);
        
        // End HighIntensityUnderlineColorList

        // Start HighIntensityFlashyColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.HighIntensityFlashyColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] HighIntensityFlashyColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityFlashyColorList);
        
        /// <summary>
        /// Gets the length from HighIntensityFlashyColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityFlashyColorList_Count")]
        public static int GetHighIntensityFlashyColorListCount() => ListUtils.GetListCount(HighIntensityFlashyColorListPointers);
        
        /// <summary>
        /// Gets the color from HighIntensityFlashyColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityFlashyColorList_Get")]
        public static IntPtr GetHighIntensityFlashyColor(int index) => ListUtils.GetItem(HighIntensityFlashyColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the HighIntensityFlashyColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityFlashyColorList_FindColorIndex")]
        public static int FindHighIntensityFlashyColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighIntensityFlashyColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the HighIntensityFlashyColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityFlashyColorList_FreeMemory")]
        public static void ClearHighIntensityFlashyColorListPointersMemory() => ListUtils.FreeMemorySingular(HighIntensityFlashyColorListPointers);
        
        /// <summary>
        /// Restores the memory of the HighIntensityFlashyColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityFlashyColorList_RestoreMemory")]
        public static void RestoreHighIntensityFlashyColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighIntensityFlashyColorListPointers, ANSICodeLists.HighIntensityFlashyColorList);
        
        // End HighIntensityFlashyColorList

        // Start HighIntensityHighlighterColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.HighIntensityHighlighterColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] HighIntensityHighlighterColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityHighlighterColorList);
        
        /// <summary>
        /// Gets the length from HighIntensityHighlighterColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityHighlighterColorList_Count")]
        public static int GetHighIntensityHighlighterColorListCount() => ListUtils.GetListCount(HighIntensityHighlighterColorListPointers);
        
        /// <summary>
        /// Gets the color from HighIntensityHighlighterColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityHighlighterColorList_Get")]
        public static IntPtr GetHighIntensityHighlighterColor(int index) => ListUtils.GetItem(HighIntensityHighlighterColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the HighIntensityHighlighterColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityHighlighterColorList_FindColorIndex")]
        public static int FindHighIntensityHighlighterColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighIntensityHighlighterColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the HighIntensityHighlighterColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityHighlighterColorList_FreeMemory")]
        public static void ClearHighIntensityHighlighterColorListPointersMemory() => ListUtils.FreeMemorySingular(HighIntensityHighlighterColorListPointers);
        
        /// <summary>
        /// Restores the memory of the HighIntensityHighlighterColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityHighlighterColorList_RestoreMemory")]
        public static void RestoreHighIntensityHighlighterColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighIntensityHighlighterColorListPointers, ANSICodeLists.HighIntensityHighlighterColorList);
        
        // End HighIntensityHighlighterColorList

        // Start HighIntensityInvisibleColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.HighIntensityInvisibleColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] HighIntensityInvisibleColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityInvisibleColorList);
        
        /// <summary>
        /// Gets the length from HighIntensityInvisibleColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityInvisibleColorList_Count")]
        public static int GetHighIntensityInvisibleColorListCount() => ListUtils.GetListCount(HighIntensityInvisibleColorListPointers);
        
        /// <summary>
        /// Gets the color from HighIntensityInvisibleColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityInvisibleColorList_Get")]
        public static IntPtr GetHighIntensityInvisibleColor(int index) => ListUtils.GetItem(HighIntensityInvisibleColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the HighIntensityInvisibleColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityInvisibleColorList_FindColorIndex")]
        public static int FindHighIntensityInvisibleColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighIntensityInvisibleColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the HighIntensityInvisibleColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityInvisibleColorList_FreeMemory")]
        public static void ClearHighIntensityInvisibleColorListPointersMemory() => ListUtils.FreeMemorySingular(HighIntensityInvisibleColorListPointers);
        
        /// <summary>
        /// Restores the memory of the HighIntensityInvisibleColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityInvisibleColorList_RestoreMemory")]
        public static void RestoreHighIntensityInvisibleColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighIntensityInvisibleColorListPointers, ANSICodeLists.HighIntensityInvisibleColorList);
        
        // End HighIntensityInvisibleColorList

        // Start HighIntensityStrikethroughColorList
                
        /// <summary>
        /// The Pointer variant of ANSICodeLists.HighIntensityStrikethroughColorList
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        public static readonly IntPtr[] HighIntensityStrikethroughColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityStrikethroughColorList);
        
        /// <summary>
        /// Gets the length from HighIntensityStrikethroughColorList.
        /// </summary>
        /// <returns>The length of the array</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityStrikethroughColorList_Count")]
        public static int GetHighIntensityStrikethroughColorListCount() => ListUtils.GetListCount(HighIntensityStrikethroughColorListPointers);
        
        /// <summary>
        /// Gets the color from HighIntensityStrikethroughColorList at the given Index.
        /// </summary>
        /// <param name="index">The Index in which you want to get the color from.</param>
        /// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityStrikethroughColorList_Get")]
        public static IntPtr GetHighIntensityStrikethroughColor(int index) => ListUtils.GetItem(HighIntensityStrikethroughColorListPointers, index);
        
        /// <summary>
        /// Finds the Index of the given Color within the HighIntensityStrikethroughColorList.
        /// </summary>
        /// <param name="color">The color in which we need to find the index of.</param>
        /// <returns>The index of the color, if we can't find one we return -1</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityStrikethroughColorList_FindColorIndex")]
        public static int FindHighIntensityStrikethroughColorIndex(IntPtr color) => ListUtils.GetItemIndex(HighIntensityStrikethroughColorListPointers, color);
        
        /// <summary>
        /// Clears the memory of the HighIntensityStrikethroughColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityStrikethroughColorList_FreeMemory")]
        public static void ClearHighIntensityStrikethroughColorListPointersMemory() => ListUtils.FreeMemorySingular(HighIntensityStrikethroughColorListPointers);
        
        /// <summary>
        /// Restores the memory of the HighIntensityStrikethroughColorList.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityStrikethroughColorList_RestoreMemory")]
        public static void RestoreHighIntensityStrikethroughColorListPointersMemory() => ListUtils.RestoreMemorySingular(HighIntensityStrikethroughColorListPointers, ANSICodeLists.HighIntensityStrikethroughColorList);
        
        // End HighIntensityStrikethroughColorList

        /// <summary>
        /// Clears the memory of all IntPtr arrays.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FreeMemory")]
        public static void ClearMemory() => ListUtils.FreeMemory(
            ColorListPointers, 
            BoldColorListPointers, 
            DarkenedColorListPointers, 
            ItalicColorListPointers,
            UnderlineColorListPointers,
            FlashyColorListPointers,
            HighlighterColorListPointers,
            InvisibleColorListPointers,
            StrikethroughColorListPointers,
            BackgroundColorListPointers,
            HighIntensityBackgroundColorListPointers,
            HighIntensityColorListPointers,
            HighIntensityBoldColorListPointers,
            HighIntensityDarkenedColorListPointers,
            HighIntensityItalicColorListPointers,
            HighIntensityUnderlineColorListPointers,
            HighIntensityFlashyColorListPointers,
            HighIntensityHighlighterColorListPointers,
            HighIntensityInvisibleColorListPointers,
            HighIntensityStrikethroughColorListPointers
        );
        
        /// <summary>
        /// Restores the memory of all IntPtr arrays.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RestoreMemory")]
        public static void RestoreMemory() => ListUtils.RestoreMemory(new ListUtils.restoreParts
        	{
        	    listToRestore = ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.ColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = BoldColorListPointers,
        	    listToRestoreTo = ANSICodeLists.BoldColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = DarkenedColorListPointers,
        	    listToRestoreTo = ANSICodeLists.DarkenedColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = ItalicColorListPointers,
        	    listToRestoreTo = ANSICodeLists.ItalicColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = UnderlineColorListPointers,
        	    listToRestoreTo = ANSICodeLists.UnderlineColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = FlashyColorListPointers,
        	    listToRestoreTo = ANSICodeLists.FlashyColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = HighlighterColorListPointers,
        	    listToRestoreTo = ANSICodeLists.HighlighterColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = InvisibleColorListPointers,
        	    listToRestoreTo = ANSICodeLists.InvisibleColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = StrikethroughColorListPointers,
        	    listToRestoreTo = ANSICodeLists.StrikethroughColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = BackgroundColorListPointers,
        	    listToRestoreTo = ANSICodeLists.BackgroundColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = HighIntensityBackgroundColorListPointers,
        	    listToRestoreTo = ANSICodeLists.HighIntensityBackgroundColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = HighIntensityColorListPointers,
        	    listToRestoreTo = ANSICodeLists.HighIntensityColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = HighIntensityBoldColorListPointers,
        	    listToRestoreTo = ANSICodeLists.HighIntensityBoldColorList
        	}, new ListUtils.restoreParts
        	{
	    	    listToRestore = HighIntensityDarkenedColorListPointers,
	    	    listToRestoreTo = ANSICodeLists.HighIntensityDarkenedColorList
        	}, new ListUtils.restoreParts
        	{
	    	    listToRestore = HighIntensityItalicColorListPointers,
	    	    listToRestoreTo = ANSICodeLists.HighIntensityItalicColorList
        	}, new ListUtils.restoreParts
	        {
		        listToRestore = HighIntensityUnderlineColorListPointers,
		        listToRestoreTo = ANSICodeLists.HighIntensityUnderlineColorList
	        }, new ListUtils.restoreParts
	        {
		        listToRestore = HighIntensityFlashyColorListPointers,
		        listToRestoreTo = ANSICodeLists.HighIntensityFlashyColorList
	        }
	        , new ListUtils.restoreParts
	        {
		        listToRestore = HighIntensityHighlighterColorListPointers,
		        listToRestoreTo = ANSICodeLists.HighIntensityHighlighterColorList
	        }, new ListUtils.restoreParts
	        {
		        listToRestore = HighIntensityInvisibleColorListPointers,
		        listToRestoreTo = ANSICodeLists.HighIntensityInvisibleColorList
	        }, new ListUtils.restoreParts
	        {
		        listToRestore = HighIntensityStrikethroughColorListPointers,
		        listToRestoreTo = ANSICodeLists.HighIntensityStrikethroughColorList
	        }
	    );
    }
}
#endif