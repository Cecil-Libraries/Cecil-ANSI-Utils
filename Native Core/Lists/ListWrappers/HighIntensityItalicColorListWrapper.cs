#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Lists.ListWrappers
{
	public class HighIntensityItalicColorListWrapper
	{
		/// <summary>
		/// The Pointer variant of ANSICodeLists.HighIntensityItalicColorList
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		public static readonly IntPtr[] ColorListPointers = ListUtils.InitializeList(ANSICodeLists.HighIntensityItalicColorList);
		
		/// <summary>
		/// Gets the length from HighIntensityItalicColorList.
		/// </summary>
		/// <returns>The length of the array</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_Count")]
		public static int GetHighIntensityItalicColorListCount() => ListUtils.GetListCount(ColorListPointers);
		
		/// <summary>
		/// Gets the color from HighIntensityItalicColorList at the given Index.
		/// </summary>
		/// <param name="index">The Index in which you want to get the color from.</param>
		/// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_Get")]
		public static IntPtr GetHighIntensityItalicColor(int index) => ListUtils.GetItem(ColorListPointers, index);
		
		/// <summary>
		/// Gets the color from HighIntensityItalicColorList at the given Index.
		/// </summary>
		/// <param name="color">The Enum value to fetch the Index from.</param>
		/// <returns>The Color at the given index, if the index is out of bound we return IntPtr.Zero.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_GetColorByEnum")]
		public static IntPtr GetColorByEnum(ANSICodeListsWrapper.Color color) => ListUtils.GetItem(ColorListPointers, (int)color);
		
		/// <summary>
		/// Finds the Index of the given Color within the HighIntensityItalicColorList.
		/// </summary>
		/// <param name="color">The color in which we need to find the index of.</param>
		/// <returns>The index of the color, if we can't find one we return -1</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_FindColorIndex")]
		public static int FindHighIntensityItalicColorIndex(IntPtr color) => ListUtils.GetItemIndex(ColorListPointers, color);
		
		/// <summary>
		/// Clears the memory of the HighIntensityItalicColorList.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_FreeMemory")]
		public static void ClearColorListPointersMemory() => ListUtils.FreeMemorySingular(ColorListPointers);
		
		/// <summary>
		/// Restores the memory of the HighIntensityItalicColorList.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_RestoreMemory")] 
		public static void RestoreColorListPointersMemory() => ListUtils.RestoreMemorySingular(ColorListPointers, ANSICodeLists.HighIntensityItalicColorList);
		
		/// <summary>
		/// Checks if the memory in the HighIntensityItalicColorList is valid for usage
		/// </summary>
		/// <returns>A true if the memory in the list is valid for use, otherwise false.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_HighIntensityItalicColorList_IsMemoryValid")]
		public static bool IsColorListPointersMemoryValid() => ColorListPointers.All(p => p != IntPtr.Zero);
	}
}
#endif