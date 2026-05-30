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
    
    // Summary; Gets the Pointer of BoldMode
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_BoldMode();
    
    // Summary; Gets the length of BoldMode
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_BoldMode_Length();
    
    // Summary; Frees the memory of BoldMode
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_BoldMode_Free();
    
    // Summary; Restores the memory of BoldMode
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_BoldMode_Restore();
    
    // Summary; Checks if the memory of BoldMode is valid for usage
    // Returns; A true if the memory in the string is valid for use, otherwise false.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    bool ANSICodeLists_BoldMode_IsMemoryValid();
    
#ifdef __cplusplus
}
#endif

#endif
