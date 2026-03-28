#if NATIVE_AOT
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util
{
	/// <summary>
	/// StringUtils for NativeAOT String based Systems.
	/// </summary>
	public class StringUtils
	{
		/// <summary>
		/// Initializes a IntPtr from the String
		/// </summary>
		/// <param name="item">The string in which will become a IntPtr.</param>
		/// <returns>The Initialized String</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		internal static IntPtr InitializeString(string item)
		{
			return Marshal.StringToHGlobalAnsi(item);
		}
		
		/// <summary>
		/// Gets the String length from a IntPtr.
		/// </summary>
		/// <param name="item">The IntPtr to get the length of.</param>
		/// <returns>The length of the given String (IntPtr).</returns>
		internal static int GetStringLength(IntPtr item)
		{
			return Marshal.PtrToStringAnsi(item)?.Length ?? 0;
		}
		
		/// <summary>
		/// Frees memory of all the IntPtr's passed in.
		/// </summary>
		/// <param name="items">The IntPtr's in which to free the memory of.</param>
		/// <returns>The passed in items as IntPtr.Zero</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		internal static void FreeMemory(params IntPtr[] items)
		{
			if (items == null) return;
			
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(items[i]);
					items[i] = IntPtr.Zero;
				}
			}
		}
		
		/// <summary>
		/// Frees the Memory of the IntPtr passed in.
		/// </summary>
		/// <param name="item">The IntPtr in which to free the memory of.</param>
		/// <returns>The passed in item as IntPtr.Zero</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		internal static void FreeMemorySingular(ref IntPtr item)
		{
			if (item != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(item);
				item = IntPtr.Zero;
			}
		}
		
		/// <summary>
		/// A record utilized for RestoreMemory.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		internal record restoreParts
		{
			/// <summary>
			/// The IntPtr in which to restore.
			/// </summary>
			public IntPtr itemToRestore { get; set; }
			/// <summary>
			/// The String in which will be referenced to restore the IntPtr.
			/// </summary>
			public string itemToRestoreTo { get; init; }
		}
		
		/// <summary>
		/// Restore the memory of all restoreParts passed in.
		/// </summary>
		/// <param name="ItemsToRestore">The IntPtr and String to restore to.</param>
		/// <returns>The original state of the IntPtr's in ItemsToRestore</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		internal static void RestoreMemory(params restoreParts[] ItemsToRestore)
		{
			foreach (restoreParts parts in ItemsToRestore)
			{
				if (parts.itemToRestore != IntPtr.Zero)
				{
					continue;
				}
				
				parts.itemToRestore = Marshal.StringToHGlobalAnsi(parts.itemToRestoreTo);
			}
		}
		
		/// <summary>
		/// Restores the memory of the restorePart passed in.
		/// </summary>
		/// <param name="ItemToRestore">The IntPtr and String to restore to.</param>
		/// <returns>The original state of the IntPtr apart of ItemToRestore.</returns>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		internal static void RestoreMemorySingular(ref IntPtr itemToRestore, string itemToRestoreTo)
		{
			if (itemToRestore != IntPtr.Zero)
			{
				return;
			}
			
			itemToRestore = Marshal.StringToHGlobalAnsi(itemToRestoreTo);
		}
	}
}
#endif