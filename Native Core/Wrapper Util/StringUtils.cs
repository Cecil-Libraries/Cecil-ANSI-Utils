#if NATIVE_AOT
using System;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util
{
	public class StringUtils
	{
		internal static IntPtr InitializeString(string item)
		{
			return Marshal.StringToHGlobalAnsi(item);
		}
		
		internal static int GetStringLength(IntPtr item)
		{
			return Marshal.PtrToStringAnsi(item)?.Length ?? 0;
		}
		
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
			public IntPtr itemToRestore { get; set; }
			public string itemToRestoreTo { get; init; }
		}
		
		internal static void RestoreMemory(params restoreParts[] ListsToRestore)
		{
			foreach (restoreParts parts in ListsToRestore)
			{
				if (parts.itemToRestore != IntPtr.Zero)
				{
					continue;
				}
				
				parts.itemToRestore = Marshal.StringToHGlobalAnsi(parts.itemToRestoreTo);
			}
		}
		
		internal static void RestoreMemory(ref restoreParts ListToRestore)
		{
			if (ListToRestore.itemToRestore != IntPtr.Zero)
			{
				return;
			}
			
			ListToRestore.itemToRestore = Marshal.StringToHGlobalAnsi(ListToRestore.itemToRestoreTo);
		}
	}
}
#endif