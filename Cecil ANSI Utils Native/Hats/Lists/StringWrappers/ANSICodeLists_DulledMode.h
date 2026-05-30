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
    
    // Summary; Gets the Pointer of DulledMode
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    const char* ANSICodeLists_DulledMode();
    
    // Summary; Gets the length of DulledMode
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_DulledMode_Length();
    
    // Summary; Frees the memory of DulledMode
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_DulledMode_Free();
    
    // Summary; Restores the memory of DulledMode
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_DulledMode_Restore();
    
    // Summary; Checks if the memory of DulledMode is valid for usage
    // Returns; A true if the memory in the string is valid for use, otherwise false.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    bool ANSICodeLists_DulledMode_IsMemoryValid();
    
#ifdef __cplusplus
}
#endif

#endif
