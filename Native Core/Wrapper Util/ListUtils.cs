#if NATIVE_AOT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util
{
    /// <summary>
    /// ListUtils for NativeAOT List based Systems.
    /// </summary>
    public class ListUtils
    {
        /// <summary>
        /// Initializes a IntPtr array from a List of Strings.
        /// </summary>
        /// <param name="list">The list your wishing to initalize</param>
        /// <returns>The initialized list.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr[] InitializeList(IReadOnlyList<string> list)
        {
            return list.Select(s => Marshal.StringToHGlobalAnsi(s)).ToArray();
        }
        
        /// <summary>
        /// Gets the length of the passed in List.
        /// </summary>
        /// <param name="list">The IntPtr array you wish to get the length from.</param>
        /// <returns>The Length as an Int.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static int GetListCount(IntPtr[] list)
        {
            return list.Length;
        }

        /// <summary>
        /// Gets the item at the given index from the list.
        /// </summary>
        /// <param name="list">The IntPtr array you wish to get the item from.</param>
        /// <param name="index">The exact Index position to get.</param>
        /// <returns>An IntPtr found at the given Index, if the index is out of bounds it returns IntPtr.Zero.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static IntPtr GetItem(IntPtr[] list, int index)
        {
            if (index < 0 || index >= GetListCount(list))
            {
                return IntPtr.Zero;
            }

            return list[index];
        }

        /// <summary>
        /// Gets the index of the given item from the list.
        /// </summary>
        /// <param name="list">The IntPtr array you wish to check for the Items index within.</param>
        /// <param name="item">The item to check for within the list.</param>
        /// <returns>The items index if found within the list, otherwise -1.</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static int GetItemIndex(IntPtr[] list, IntPtr item)
        {
            for (int i = 0; i < GetListCount(list); i++)
            {
                if (GetItem(list, i) == item)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Frees memory of all the IntPtr arrays passed in.
        /// </summary>
        /// <param name="lists">The lists in which should be cleared.</param>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static void FreeMemory(params IntPtr[][] lists)
        {
            foreach (IntPtr[] listToClear in lists)
            {
                if (listToClear == null) continue;

                for (int i = 0; i < listToClear.Length; i++)
                {
                    if (listToClear[i] != IntPtr.Zero)
                    {
                        Marshal.FreeHGlobal(listToClear[i]);
                        listToClear[i] = IntPtr.Zero;
                    }
                }
            }
        }

        /// <summary>
        /// Frees memory of the IntPtr array passed in.
        /// </summary>
        /// <param name="listToClear">The list in which should be cleared.</param>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static void FreeMemorySingular(IntPtr[] listToClear)
        {
            if (listToClear == null) return;

            for (int i = 0; i < listToClear.Length; i++)
            {
                if (listToClear[i] != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(listToClear[i]);
                    listToClear[i] = IntPtr.Zero;
                }
            }
        }

        /// <summary>
        /// A record utilized for RestoreMemory.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal record restoreParts
        {
            public IntPtr[] listToRestore { get; set; }
            public IReadOnlyList<String> listToRestoreTo { get; init; }
        }

        /// <summary>
        /// Restores memory of all IntPtr arrays passed in.
        /// </summary>
        /// <param name="ListsToRestore">Records of type restoreParts, these contain the ListToRestore and ListToRestoreTo.</param>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static void RestoreMemory(params restoreParts[] ListsToRestore)
        {
            foreach (restoreParts parts in ListsToRestore)
            {
                if (parts.listToRestore.All(Pointer => Pointer != IntPtr.Zero))
                {
                    continue;
                }
                
                for (int i = 0; i < Math.Min(parts.listToRestore.Length, parts.listToRestoreTo.Count); i++)
                {
                    if (parts.listToRestore[i] == IntPtr.Zero)
                    {
                        parts.listToRestore[i] = Marshal.StringToHGlobalAnsi(parts.listToRestoreTo[i]);
                    }
                }
            }
        }

        /// <summary>
        /// Restores memory of a single IntPtr array.
        /// </summary>
        /// <param name="listToRestore">The IntPtr array you wish to restore the memory of.</param>
        /// <param name="listToRestoreTo">The List in which you wish to reference for restoring the IntPtr array.</param>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        internal static void RestoreMemorySingular(IntPtr[] listToRestore, IReadOnlyList<String> listToRestoreTo)
        {
            if (listToRestore.All(Pointer => Pointer != IntPtr.Zero))
            {
                return;
            }
                
            for (int i = 0; i < Math.Min(listToRestore.Length, listToRestoreTo.Count); i++)
            {
                if (listToRestore[i] == IntPtr.Zero)
                {
                    listToRestore[i] = Marshal.StringToHGlobalAnsi(listToRestoreTo[i]);
                }
            }
        }
    }
}
#endif