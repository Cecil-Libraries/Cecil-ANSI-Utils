#ifndef CECIL_ANSI_H
#define CECIL_ANSI_H

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
