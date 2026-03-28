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

    // Summary; Gets the length from StrikethroughColorList.
    // Returns; The length of the array
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_StrikethroughColorList_Count();
    
    // Summary; Gets the color from StrikethroughColorList at the given Index.
    // Param (Index); The Index in which you want to get the color from.
    // Returns; The Color at the given index, if the index is out of bounds or if the memory has been cleared we return NULL.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_StrikethroughColorList_Get(int index);
    
    // Summary; Gets the color from StrikethroughColorList at the given Index.
    // Param (color); The Enum value to fetch the Index from.
    // Returns; The Color at the given index, if the index is out of bound we return IntPtr.Zero.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_StrikethroughColorList_GetColorByEnum(Color color);
    
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
    
    // Summary; Checks if the memory in the StrikethroughColorList is valid for usage.
    // Returns; A true if the memory in the list is valid for use, otherwise false.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    bool ANSICodeLists_StrikethroughColorList_IsMemoryValid();
    
#ifdef __cplusplus
}
#endif

#endif