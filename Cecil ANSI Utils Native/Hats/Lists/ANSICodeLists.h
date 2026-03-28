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
    
    // Summary; Clears the memory of all IntPtr arrays.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_FreeMemoryLists();
    
    // Summary; Restores the memory of all IntPtr arrays.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    void ANSICodeLists_RestoreMemoryLists();
    
    // Summary; Passes the ColorCount variable through AOT.
    // Returns; The ColorCount Variable.
    // Remarks; This code is provided by Creator/Chaosyr/SaxbyMod/The Stoat Lord.
    int ANSICodeLists_ColorCount();
    
#ifdef __cplusplus
}
#endif

#endif
