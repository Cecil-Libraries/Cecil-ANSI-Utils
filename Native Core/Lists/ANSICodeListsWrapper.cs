#if NATIVE_AOT
using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.Native_ANSI_Utils.Wrapper_Util;
using System.Runtime.InteropServices;
using Cecil_Libraries.Native_ANSI_Utils.Lists.ListWrappers;
using Cecil_Libraries.Native_ANSI_Utils.Lists.StringWrappers;

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

        /// <summary>
        /// Passes the ColorCount variable through AOT.
        /// </summary>
        /// <returns>ColorCount = 8</returns>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_ColorCount")]
        public static int GetColorCount() => ColorCount;

        /// <summary>
        /// Clears the memory of all IntPtr arrays.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FreeMemoryLists")]
        public static void ClearMemoryLists() => ListUtils.FreeMemory(
            ColorListWrapper.ColorListPointers, 
            BoldColorListWrapper.ColorListPointers, 
            DarkenedColorListWrapper.ColorListPointers, 
            ItalicColorListWrapper.ColorListPointers,
            UnderlineColorListWrapper.ColorListPointers,
            FlashyColorListWrapper.ColorListPointers,
            HighlighterColorListWrapper.ColorListPointers,
            InvisibleColorListWrapper.ColorListPointers,
            StrikethroughColorListWrapper.ColorListPointers,
            BackgroundColorListWrapper.ColorListPointers,
            HighIntensityBackgroundColorListWrapper.ColorListPointers,
            HighIntensityColorListWrapper.ColorListPointers,
            HighIntensityBoldColorListWrapper.ColorListPointers,
            HighIntensityDarkenedColorListWrapper.ColorListPointers,
            HighIntensityItalicColorListWrapper.ColorListPointers,
            HighIntensityUnderlineColorListWrapper.ColorListPointers,
            HighIntensityFlashyColorListWrapper.ColorListPointers,
            HighIntensityHighlighterColorListWrapper.ColorListPointers,
            HighIntensityInvisibleColorListWrapper.ColorListPointers,
            HighIntensityStrikethroughColorListWrapper.ColorListPointers
        );
        
        /// <summary>
        /// Restores the memory of all IntPtr arrays.
        /// </summary>
        /// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
        [UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RestoreMemoryLists")]
        public static void RestoreMemoryLists() => ListUtils.RestoreMemory(new ListUtils.restoreParts
        	{
        	    listToRestore = ColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.ColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = BoldColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.BoldColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = DarkenedColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.DarkenedColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = ItalicColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.ItalicColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = UnderlineColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.UnderlineColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = FlashyColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.FlashyColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = HighlighterColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.HighlighterColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = InvisibleColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.InvisibleColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = StrikethroughColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.StrikethroughColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = BackgroundColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.BackgroundColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = HighIntensityBackgroundColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.HighIntensityBackgroundColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = HighIntensityColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.HighIntensityColorList
        	}, new ListUtils.restoreParts
        	{
        	    listToRestore = HighIntensityBoldColorListWrapper.ColorListPointers,
        	    listToRestoreTo = ANSICodeLists.HighIntensityBoldColorList
        	}, new ListUtils.restoreParts
        	{
	    	    listToRestore = HighIntensityDarkenedColorListWrapper.ColorListPointers,
	    	    listToRestoreTo = ANSICodeLists.HighIntensityDarkenedColorList
        	}, new ListUtils.restoreParts
        	{
	    	    listToRestore = HighIntensityItalicColorListWrapper.ColorListPointers,
	    	    listToRestoreTo = ANSICodeLists.HighIntensityItalicColorList
        	}, new ListUtils.restoreParts
	        {
		        listToRestore = HighIntensityUnderlineColorListWrapper.ColorListPointers,
		        listToRestoreTo = ANSICodeLists.HighIntensityUnderlineColorList
	        }, new ListUtils.restoreParts
	        {
		        listToRestore = HighIntensityFlashyColorListWrapper.ColorListPointers,
		        listToRestoreTo = ANSICodeLists.HighIntensityFlashyColorList
	        }
	        , new ListUtils.restoreParts
	        {
		        listToRestore = HighIntensityHighlighterColorListWrapper.ColorListPointers,
		        listToRestoreTo = ANSICodeLists.HighIntensityHighlighterColorList
	        }, new ListUtils.restoreParts
	        {
		        listToRestore = HighIntensityInvisibleColorListWrapper.ColorListPointers,
		        listToRestoreTo = ANSICodeLists.HighIntensityInvisibleColorList
	        }, new ListUtils.restoreParts
	        {
		        listToRestore = HighIntensityStrikethroughColorListWrapper.ColorListPointers,
		        listToRestoreTo = ANSICodeLists.HighIntensityStrikethroughColorList
	        }
	    );
        
        /// <summary>
		/// Clears the memory of all IntPtr's.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_FreeMemoryStrings")]
			public static void ClearMemoryStrings() => StringUtils.FreeMemory(
	        	ResetColorWrapper.Pointer, 
	        	ResetForegroundWrapper.Pointer, 
				ResetBackgroundWrapper.Pointer, 
				RegularModeWrapper.Pointer,
				BoldModeWrapper.Pointer,
				DulledModeWrapper.Pointer,
				ItalicModeWrapper.Pointer,
				UnderlinedModeWrapper.Pointer,
				BlinkModeWrapper.Pointer,
				RapidModeWrapper.Pointer,
				HighlightModeWrapper.Pointer,
				UnderlightModeWrapper.Pointer,
				StrikethroughModeWrapper.Pointer,
				DoublelineModeWrapper.Pointer,
				OverlineModeWrapper.Pointer,
				FramedModeWrapper.Pointer,
				EncircledModeWrapper.Pointer,
				ResetBoldModeWrapper.Pointer,
				ResetDulledModeWrapper.Pointer,
				ResetItalicModeWrapper.Pointer,
				ResetUnderlinedModeWrapper.Pointer,
				ResetBlinkModeWrapper.Pointer,
				ResetRapidModeWrapper.Pointer,
				ResetHighlightModeWrapper.Pointer,
				ResetUnderlightModeWrapper.Pointer,
				ResetStrikethroughModeWrapper.Pointer,
				ResetDoublelineModeWrapper.Pointer,
				ResetOverlineModeWrapper.Pointer,
				ResetFramedModeWrapper.Pointer,
				ResetEncircledModeWrapper.Pointer
			);
		
		/// <summary>
		/// Restores the memory of all IntPtr's.
		/// </summary>
		/// <remarks>This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.</remarks>
		[UnmanagedCallersOnly(EntryPoint = "ANSICodeLists_RestoreMemoryStrings")] 
		public static void RestoreMemoryStrings() => StringUtils.RestoreMemory(new StringUtils.restoreParts
			{
				itemToRestore = ResetColorWrapper.Pointer,
					itemToRestoreTo = ANSICodeLists.ResetColor
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetForegroundWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetForeground
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetBackgroundWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetBackground
			}, new StringUtils.restoreParts
			{
				itemToRestore = RegularModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.RegularMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = BoldModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.BoldMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = DulledModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.DulledMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ItalicModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ItalicMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = UnderlinedModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.UnderlinedMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = BlinkModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.BlinkMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = RapidModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.RapidMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = HighlightModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.HighlightMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = UnderlightModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.UnderlightMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = StrikethroughModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.StrikethroughMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = DoublelineModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.DoublelineMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = OverlineModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.OverlineMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = FramedModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.FramedMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = EncircledModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.EncircledMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetBoldModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetBoldMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetDulledModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetDulledMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetItalicModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetItalicMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetUnderlinedModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetUnderlinedMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetBlinkModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetBlinkMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetRapidModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetRapidMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetHighlightModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetHighlightMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetUnderlightModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetUnderlightMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetStrikethroughModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetStrikethroughMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetDoublelineModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetDoublelineMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetOverlineModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetOverlineMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetFramedModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetFramedMode
			}, new StringUtils.restoreParts
			{
				itemToRestore = ResetEncircledModeWrapper.Pointer, itemToRestoreTo = ANSICodeLists.ResetEncircledMode
			} 
		);
    }
}
#endif