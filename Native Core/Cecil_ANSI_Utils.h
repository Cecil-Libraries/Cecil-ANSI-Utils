#ifndef CECIL_ANSI_H
#define CECIL_ANSI_H

#ifdef __cplusplus
extern "C" {
#endif
    
    // Summary; Gets the color from ColorList at the given Index.
    // Param (index); The Index in which you want to get the color from.
    // Returns; The Color at the given index.
    const char* ANSICodeLists_ColorList_Get(int index);
    
    // Summary; Gets the length from ColorList.
    // Returns; The length of the array
    int ANSICodeLists_ColorList_Count(void);
    
#ifdef __cplusplus
}
#endif

#endif // CECIL_ANSI_H
