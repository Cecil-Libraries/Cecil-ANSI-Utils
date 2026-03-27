#ifndef CECIL_ANSI_H
#define CECIL_ANSI_H  // NOLINT(clang-diagnostic-unused-macros)

#ifdef __cplusplus
extern "C" {
#endif
    
    // |--------------------------------------------------------------|
    // |                       ANSICodeLists                          |
    // |                                                              |
    // |          Memory Management: Get -> Free -> Restore           |
    // |--------------------------------------------------------------|
    
    // Ownership; Returned const char* values belong to this library. Do NOT free them directly.
    // Calling FreeMemory() invalidates all previously returned pointers. After calling RestoreMemory(), new valid pointers can be obtained via Get().
    
    // Summary; Gets the length from ColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_ColorList_Count();
    
    // Summary; Gets the color from ColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_ColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the ColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_ColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the ColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_ColorList_FreeMemory();
    
    // Summary; Restores the memory of the ColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_ColorList_RestoreMemory();
    
    // Summary; Gets the length from BoldColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_BoldColorList_Count();
    
    // Summary; Gets the color from BoldColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_BoldColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the BoldColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_BoldColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the BoldColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_BoldColorList_FreeMemory();
    
    // Summary; Restores the memory of the BoldColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_BoldColorList_RestoreMemory();
    
    // Summary; Gets the length from DarkenedColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_DarkenedColorList_Count();
    
    // Summary; Gets the color from DarkenedColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_DarkenedColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the DarkenedColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_DarkenedColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the DarkenedColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_DarkenedColorList_FreeMemory();
    
    // Summary; Restores the memory of the DarkenedColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_DarkenedColorList_RestoreMemory();
    
    // Summary; Gets the length from ItalicColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_ItalicColorList_Count();
    
    // Summary; Gets the color from ItalicColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_ItalicColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the ItalicColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_ItalicColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the ItalicColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_ItalicColorList_FreeMemory();
    
    // Summary; Restores the memory of the ItalicColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_ItalicColorList_RestoreMemory();
    
    // Summary; Gets the length from UnderlineColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_UnderlineColorList_Count();
    
    // Summary; Gets the color from UnderlineColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_UnderlineColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the UnderlineColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_UnderlineColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the UnderlineColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_UnderlineColorList_FreeMemory();
    
    // Summary; Restores the memory of the UnderlineColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_UnderlineColorList_RestoreMemory();
    
    // Summary; Gets the length from FlashyColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_FlashyColorList_Count();
    
    // Summary; Gets the color from FlashyColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_FlashyColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the FlashyColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_FlashyColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the FlashyColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_FlashyColorList_FreeMemory();
    
    // Summary; Restores the memory of the FlashyColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_FlashyColorList_RestoreMemory();
    
    // Summary; Gets the length from HighlighterColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighlighterColorList_Count();
    
    // Summary; Gets the color from HighlighterColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighlighterColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighlighterColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighlighterColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the HighlighterColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighlighterColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighlighterColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighlighterColorList_RestoreMemory();
    
    // Summary; Gets the length from InvisibleColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_InvisibleColorList_Count();
    
    // Summary; Gets the color from InvisibleColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_InvisibleColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the InvisibleColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_InvisibleColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the InvisibleColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_InvisibleColorList_FreeMemory();
    
    // Summary; Restores the memory of the InvisibleColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_InvisibleColorList_RestoreMemory();
    
    // Summary; Gets the length from StrikethroughColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_StrikethroughColorList_Count();
    
    // Summary; Gets the color from StrikethroughColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_StrikethroughColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the StrikethroughColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_StrikethroughColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the StrikethroughColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_StrikethroughColorList_FreeMemory();
    
    // Summary; Restores the memory of the StrikethroughColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_StrikethroughColorList_RestoreMemory();
    
    // Summary; Gets the length from BackgroundColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_BackgroundColorList_Count();
    
    // Summary; Gets the color from BackgroundColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_BackgroundColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the BackgroundColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_BackgroundColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the BackgroundColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_BackgroundColorList_FreeMemory();
    
    // Summary; Restores the memory of the BackgroundColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_BackgroundColorList_RestoreMemory();
    
    // Summary; Gets the length from HighIntensityBackgroundColorList.
    // Returns; The length of the array</returns>
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityBackgroundColorList_Count();
    
    // Summary; Gets the color from HighIntensityBackgroundColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighIntensityBackgroundColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighIntensityBackgroundColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityBackgroundColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the HighIntensityBackgroundColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityBackgroundColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighIntensityBackgroundColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityBackgroundColorList_RestoreMemory();
    
    // Summary; Gets the length from HighIntensityColorList.
    // Returns; The length of the array</returns>
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityColorList_Count();
    
    // Summary; Gets the color from HighIntensityColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighIntensityColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighIntensityColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityColorList_FindColorIndex(const char* color);
    
    // Summary; Gets the length from HighIntensityBoldColorList.
    // Returns; The length of the array</returns>
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityBoldColorList_Count();
    
    // Summary; Gets the color from HighIntensityBoldColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighIntensityBoldColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighIntensityBoldColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityBoldColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the HighIntensityBoldColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityBoldColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighIntensityBoldColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityBoldColorList_RestoreMemory();
    
    // Summary; Clears the memory of the HighIntensityColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighIntensityColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityColorList_RestoreMemory();
    
    // Summary; Gets the length from HighIntensityDarkenedColorList.
    // Returns; The length of the array</returns>
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityDarkenedColorList_Count();
    
    // Summary; Gets the color from HighIntensityDarkenedColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighIntensityDarkenedColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighIntensityDarkenedColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityDarkenedColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the HighIntensityDarkenedColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityDarkenedColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighIntensityDarkenedColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityDarkenedColorList_RestoreMemory();
    
    // Summary; Gets the length from HighIntensityItalicColorList.
    // Returns; The length of the array</returns>
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityItalicColorList_Count();
    
    // Summary; Gets the color from HighIntensityItalicColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighIntensityItalicColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighIntensityItalicColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityItalicColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the HighIntensityItalicColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityItalicColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighIntensityItalicColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityItalicColorList_RestoreMemory();
    
    // Summary; Gets the length from HighIntensityUnderlineColorList.
    // Returns; The length of the array</returns>
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityUnderlineColorList_Count();
    
    // Summary; Gets the color from HighIntensityUnderlineColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighIntensityUnderlineColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighIntensityUnderlineColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityUnderlineColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the HighIntensityUnderlineColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityUnderlineColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighIntensityUnderlineColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityUnderlineColorList_RestoreMemory();
    
    // Summary; Gets the length from HighIntensityFlashyColorList.
    // Returns; The length of the array</returns>
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityFlashyColorList_Count();
    
    // Summary; Gets the color from HighIntensityFlashyColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighIntensityFlashyColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighIntensityFlashyColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityFlashyColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the HighIntensityFlashyColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityFlashyColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighIntensityFlashyColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityFlashyColorList_RestoreMemory();
    
    // Summary; Gets the length from HighIntensityHighlighterColorList.
    // Returns; The length of the array</returns>
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityHighlighterColorList_Count();
    
    // Summary; Gets the color from HighIntensityHighlighterColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighIntensityHighlighterColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighIntensityHighlighterColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityHighlighterColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the HighIntensityHighlighterColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityHighlighterColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighIntensityHighlighterColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityHighlighterColorList_RestoreMemory();
    
    // Summary; Gets the length from HighIntensityInvisibleColorList.
    // Returns; The length of the array</returns>
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityInvisibleColorList_Count();
    
    // Summary; Gets the color from HighIntensityInvisibleColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighIntensityInvisibleColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighIntensityInvisibleColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityInvisibleColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the HighIntensityInvisibleColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityInvisibleColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighIntensityInvisibleColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityInvisibleColorList_RestoreMemory();
    
    // Summary; Gets the length from HighIntensityStrikethroughColorList.
    // Returns; The length of the array</returns>
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityStrikethroughColorList_Count();
    
    // Summary; Gets the color from HighIntensityStrikethroughColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_HighIntensityStrikethroughColorList_Get(int index);
    
    // Summary; Finds the Index of the given Color within the HighIntensityStrikethroughColorList.
    // Params (Color); The color in which we need to find the index of.
    // Returns; The index of the color, if we can't find one we return -1
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_HighIntensityStrikethroughColorList_FindColorIndex(const char* color);
    
    // Summary; Clears the memory of the HighIntensityStrikethroughColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityStrikethroughColorList_FreeMemory();
    
    // Summary; Restores the memory of the HighIntensityStrikethroughColorList.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_HighIntensityStrikethroughColorList_RestoreMemory();
    
    // Summary; Clears the memory of all IntPtr arrays.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_FreeMemory();
    
    // Summary; Restores the memory of all IntPtr arrays.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_RestoreMemory();
#ifdef __cplusplus
}
#endif

#endif
