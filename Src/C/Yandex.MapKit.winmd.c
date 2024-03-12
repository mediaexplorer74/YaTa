typedef unsigned char   undefined;

typedef unsigned long long    GUID;
typedef pointer32 ImageBaseOffset32;

typedef unsigned char    byte;
typedef unsigned int    dword;
typedef unsigned long long    qword;
typedef unsigned short    word;
typedef unsigned short    wchar16;
typedef struct IMAGE_DOS_HEADER IMAGE_DOS_HEADER, *PIMAGE_DOS_HEADER;

struct IMAGE_DOS_HEADER {
    char e_magic[2]; // Magic number
    word e_cblp; // Bytes of last page
    word e_cp; // Pages in file
    word e_crlc; // Relocations
    word e_cparhdr; // Size of header in paragraphs
    word e_minalloc; // Minimum extra paragraphs needed
    word e_maxalloc; // Maximum extra paragraphs needed
    word e_ss; // Initial (relative) SS value
    word e_sp; // Initial SP value
    word e_csum; // Checksum
    word e_ip; // Initial IP value
    word e_cs; // Initial (relative) CS value
    word e_lfarlc; // File address of relocation table
    word e_ovno; // Overlay number
    word e_res[4][4]; // Reserved words
    word e_oemid; // OEM identifier (for e_oeminfo)
    word e_oeminfo; // OEM information; e_oemid specific
    word e_res2[10][10]; // Reserved words
    dword e_lfanew; // File address of new exe header
    byte e_program[64]; // Actual DOS program
};

typedef struct IMAGE_OPTIONAL_HEADER32 IMAGE_OPTIONAL_HEADER32, *PIMAGE_OPTIONAL_HEADER32;

typedef struct IMAGE_DATA_DIRECTORY IMAGE_DATA_DIRECTORY, *PIMAGE_DATA_DIRECTORY;

struct IMAGE_DATA_DIRECTORY {
    ImageBaseOffset32 VirtualAddress;
    dword Size;
};

struct IMAGE_OPTIONAL_HEADER32 {
    word Magic;
    byte MajorLinkerVersion;
    byte MinorLinkerVersion;
    dword SizeOfCode;
    dword SizeOfInitializedData;
    dword SizeOfUninitializedData;
    ImageBaseOffset32 AddressOfEntryPoint;
    ImageBaseOffset32 BaseOfCode;
    ImageBaseOffset32 BaseOfData;
    pointer32 ImageBase;
    dword SectionAlignment;
    dword FileAlignment;
    word MajorOperatingSystemVersion;
    word MinorOperatingSystemVersion;
    word MajorImageVersion;
    word MinorImageVersion;
    word MajorSubsystemVersion;
    word MinorSubsystemVersion;
    dword Win32VersionValue;
    dword SizeOfImage;
    dword SizeOfHeaders;
    dword CheckSum;
    word Subsystem;
    word DllCharacteristics;
    dword SizeOfStackReserve;
    dword SizeOfStackCommit;
    dword SizeOfHeapReserve;
    dword SizeOfHeapCommit;
    dword LoaderFlags;
    dword NumberOfRvaAndSizes;
    struct IMAGE_DATA_DIRECTORY DataDirectory[16];
};

typedef struct IMAGE_SECTION_HEADER IMAGE_SECTION_HEADER, *PIMAGE_SECTION_HEADER;

typedef union Misc Misc, *PMisc;

typedef enum SectionFlags {
    IMAGE_SCN_TYPE_NO_PAD=8,
    IMAGE_SCN_RESERVED_0001=16,
    IMAGE_SCN_CNT_CODE=32,
    IMAGE_SCN_CNT_INITIALIZED_DATA=64,
    IMAGE_SCN_CNT_UNINITIALIZED_DATA=128,
    IMAGE_SCN_LNK_OTHER=256,
    IMAGE_SCN_LNK_INFO=512,
    IMAGE_SCN_RESERVED_0040=1024,
    IMAGE_SCN_LNK_REMOVE=2048,
    IMAGE_SCN_LNK_COMDAT=4096,
    IMAGE_SCN_GPREL=32768,
    IMAGE_SCN_MEM_16BIT=131072,
    IMAGE_SCN_MEM_PURGEABLE=131072,
    IMAGE_SCN_MEM_LOCKED=262144,
    IMAGE_SCN_MEM_PRELOAD=524288,
    IMAGE_SCN_ALIGN_1BYTES=1048576,
    IMAGE_SCN_ALIGN_2BYTES=2097152,
    IMAGE_SCN_ALIGN_4BYTES=3145728,
    IMAGE_SCN_ALIGN_8BYTES=4194304,
    IMAGE_SCN_ALIGN_16BYTES=5242880,
    IMAGE_SCN_ALIGN_32BYTES=6291456,
    IMAGE_SCN_ALIGN_64BYTES=7340032,
    IMAGE_SCN_ALIGN_128BYTES=8388608,
    IMAGE_SCN_ALIGN_256BYTES=9437184,
    IMAGE_SCN_ALIGN_512BYTES=10485760,
    IMAGE_SCN_ALIGN_1024BYTES=11534336,
    IMAGE_SCN_ALIGN_2048BYTES=12582912,
    IMAGE_SCN_ALIGN_4096BYTES=13631488,
    IMAGE_SCN_ALIGN_8192BYTES=14680064,
    IMAGE_SCN_LNK_NRELOC_OVFL=16777216,
    IMAGE_SCN_MEM_DISCARDABLE=33554432,
    IMAGE_SCN_MEM_NOT_CACHED=67108864,
    IMAGE_SCN_MEM_NOT_PAGED=134217728,
    IMAGE_SCN_MEM_SHARED=268435456,
    IMAGE_SCN_MEM_EXECUTE=536870912,
    IMAGE_SCN_MEM_READ=1073741824,
    IMAGE_SCN_MEM_WRITE=2147483648
} SectionFlags;

union Misc {
    dword PhysicalAddress;
    dword VirtualSize;
};

struct IMAGE_SECTION_HEADER {
    char Name[8];
    union Misc Misc;
    ImageBaseOffset32 VirtualAddress;
    dword SizeOfRawData;
    dword PointerToRawData;
    dword PointerToRelocations;
    dword PointerToLinenumbers;
    word NumberOfRelocations;
    word NumberOfLinenumbers;
    enum SectionFlags Characteristics;
};

typedef struct IMAGE_COR20_HEADER IMAGE_COR20_HEADER, *PIMAGE_COR20_HEADER;

typedef struct CLI_METADATA_DIRECTORY CLI_METADATA_DIRECTORY, *PCLI_METADATA_DIRECTORY;

typedef enum COR20_Flags {
    COMIMAGE_FLAGS_ILONLY=1,
    COMIMAGE_FLAGS_32BITREQUIRED=2,
    COMIMAGE_FLAGS_IL_LIBRARY=4,
    COMIMAGE_FLAGS_STRONGNAMESIGNED=8,
    COMIMAGE_FLAGS_NATIVE_ENTRYPOINT=16,
    COMIMAGE_FLAGS_TRACKDEBUGDATA=65536
} COR20_Flags;

typedef struct IMAGE_DATA_DIRECTORY.conflict IMAGE_DATA_DIRECTORY.conflict, *PIMAGE_DATA_DIRECTORY.conflict;

struct CLI_METADATA_DIRECTORY {
    dword VirtualAddress;
    dword Size;
};

struct IMAGE_DATA_DIRECTORY.conflict {
    dword VirtualAddress;
    dword Size;
};

struct IMAGE_COR20_HEADER {
    dword cb; // Size of the structure
    word MajorRuntimeVersion; // Version of CLR Runtime
    word MinorRuntimeVersion;
    struct CLI_METADATA_DIRECTORY MetaData; // RVA and size of MetaData
    enum COR20_Flags Flags;
    dword EntryPointToken; // This is a metadata token if not a valid RVA
    struct IMAGE_DATA_DIRECTORY.conflict Resources;
    struct IMAGE_DATA_DIRECTORY.conflict StrongNameSignature;
    struct IMAGE_DATA_DIRECTORY.conflict CodeManagerTable; // Should be 0
    struct IMAGE_DATA_DIRECTORY.conflict VTableFixups;
    struct IMAGE_DATA_DIRECTORY.conflict ExportAddressTableJumps; // Should be 0
    struct IMAGE_DATA_DIRECTORY.conflict ManagedNativeHeader; // 0 unless this is a native image
};

typedef struct IMAGE_FILE_HEADER IMAGE_FILE_HEADER, *PIMAGE_FILE_HEADER;

struct IMAGE_FILE_HEADER {
    word Machine; // 332
    word NumberOfSections;
    dword TimeDateStamp;
    dword PointerToSymbolTable;
    dword NumberOfSymbols;
    word SizeOfOptionalHeader;
    word Characteristics;
};

typedef struct IMAGE_NT_HEADERS32 IMAGE_NT_HEADERS32, *PIMAGE_NT_HEADERS32;

struct IMAGE_NT_HEADERS32 {
    char Signature[4];
    struct IMAGE_FILE_HEADER FileHeader;
    struct IMAGE_OPTIONAL_HEADER32 OptionalHeader;
};

typedef struct CLI_METADATA_HEADER CLI_METADATA_HEADER, *PCLI_METADATA_HEADER;

typedef struct CLI_Stream_Header_#~ CLI_Stream_Header_#~, *PCLI_Stream_Header_#~;

typedef struct CLI_Stream_Header_#Strings CLI_Stream_Header_#Strings, *PCLI_Stream_Header_#Strings;

typedef struct CLI_Stream_Header_#US CLI_Stream_Header_#US, *PCLI_Stream_Header_#US;

typedef struct CLI_Stream_Header_#GUID CLI_Stream_Header_#GUID, *PCLI_Stream_Header_#GUID;

typedef struct CLI_Stream_Header_#Blob CLI_Stream_Header_#Blob, *PCLI_Stream_Header_#Blob;

struct CLI_Stream_Header_#Blob {
    dword offset;
    dword size;
    char name[8];
};

struct CLI_Stream_Header_#GUID {
    dword offset;
    dword size;
    char name[8];
};

struct CLI_Stream_Header_#~ {
    dword offset;
    dword size;
    char name[4];
};

struct CLI_Stream_Header_#US {
    dword offset;
    dword size;
    char name[4];
};

struct CLI_Stream_Header_#Strings {
    dword offset;
    dword size;
    char name[12];
};

struct CLI_METADATA_HEADER {
    dword Signature; // must be 0x424a5342
    word MajorVersion;
    word MinorVersion;
    dword Reserved; // should be 0
    dword VersionLength;
    char Version[20];
    word Flags; // should be 0
    word StreamsCount; // number of stream headers to follow
    struct CLI_Stream_Header_#~ #~;
    struct CLI_Stream_Header_#Strings #Strings;
    struct CLI_Stream_Header_#US #US;
    struct CLI_Stream_Header_#GUID #GUID;
    struct CLI_Stream_Header_#Blob #Blob;
};

typedef struct GenericInstType_179879 GenericInstType_179879, *PGenericInstType_179879;

typedef enum TypeCode {
    ELEMENT_TYPE_END=0,
    ELEMENT_TYPE_VOID=1,
    ELEMENT_TYPE_BOOLEAN=2,
    ELEMENT_TYPE_CHAR=3,
    ELEMENT_TYPE_I1=4,
    ELEMENT_TYPE_U1=5,
    ELEMENT_TYPE_I2=6,
    ELEMENT_TYPE_U2=7,
    ELEMENT_TYPE_I4=8,
    ELEMENT_TYPE_U4=9,
    ELEMENT_TYPE_I8=10,
    ELEMENT_TYPE_U8=11,
    ELEMENT_TYPE_R4=12,
    ELEMENT_TYPE_R8=13,
    ELEMENT_TYPE_STRING=14,
    ELEMENT_TYPE_PTR=15,
    ELEMENT_TYPE_BYREF=16,
    ELEMENT_TYPE_VALUETYPE=17,
    ELEMENT_TYPE_CLASS=18,
    ELEMENT_TYPE_VAR=19,
    ELEMENT_TYPE_ARRAY=20,
    ELEMENT_TYPE_GENERICINST=21,
    ELEMENT_TYPE_TYPEDBYREF=22,
    ELEMENT_TYPE_I=24,
    ELEMENT_TYPE_U=25,
    ELEMENT_TYPE_FNPTR=27,
    ELEMENT_TYPE_OBJECT=28,
    ELEMENT_TYPE_SZARRAY=29,
    ELEMENT_TYPE_MVAR=30,
    ELEMENT_TYPE_CMOD_REQD=31,
    ELEMENT_TYPE_CMOD_OPT=32,
    ELEMENT_TYPE_INTERNAL=33,
    ELEMENT_TYPE_MAX=34,
    ELEMENT_TYPE_MODIFIER=64,
    ELEMENT_TYPE_SENTINEL=65,
    ELEMENT_TYPE_PINNED=69
} TypeCode;

typedef struct ValueType.conflict23 ValueType.conflict23, *PValueType.conflict23;

struct ValueType.conflict23 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1e7
};

struct GenericInstType_179879 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict23 Type; // Generic Type
};

typedef struct GenericInstType_176245 GenericInstType_176245, *PGenericInstType_176245;

typedef struct Class.conflict Class.conflict, *PClass.conflict;

struct Class.conflict {
    enum TypeCode Class; // Class
    word Type; // TypeDefOrRefOrSpecEncoded
};

struct GenericInstType_176245 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_177575 GenericInstType_177575, *PGenericInstType_177575;

typedef struct ValueType.conflict9 ValueType.conflict9, *PValueType.conflict9;

struct ValueType.conflict9 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x13c
};

struct GenericInstType_177575 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict9 Type; // Generic Type
};

typedef struct GenericInstType_182366 GenericInstType_182366, *PGenericInstType_182366;

typedef struct ValueType.conflict30 ValueType.conflict30, *PValueType.conflict30;

struct ValueType.conflict30 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2ca
};

struct GenericInstType_182366 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict30 Type; // Generic Type
};

typedef struct GenericInstType_176361 GenericInstType_176361, *PGenericInstType_176361;

struct GenericInstType_176361 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_177451 GenericInstType_177451, *PGenericInstType_177451;

typedef struct ValueType.conflict1 ValueType.conflict1, *PValueType.conflict1;

struct ValueType.conflict1 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0xdf
};

struct GenericInstType_177451 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict1 Type; // Generic Type
};

typedef struct GenericInstType_181711 GenericInstType_181711, *PGenericInstType_181711;

struct GenericInstType_181711 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_185994 GenericInstType_185994, *PGenericInstType_185994;

struct GenericInstType_185994 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_173656 GenericInstType_173656, *PGenericInstType_173656;

typedef struct Class Class, *PClass;

struct Class {
    enum TypeCode Class; // Class
    byte Type; // TypeDefOrRefOrSpecEncoded
};

struct GenericInstType_173656 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct GenericInstType_175834 GenericInstType_175834, *PGenericInstType_175834;

typedef struct ValueType.conflict2 ValueType.conflict2, *PValueType.conflict2;

struct ValueType.conflict2 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0xe0
};

struct GenericInstType_175834 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict2 Type; // Generic Type
};

typedef struct GenericInstType_186160 GenericInstType_186160, *PGenericInstType_186160;

struct GenericInstType_186160 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_176237 GenericInstType_176237, *PGenericInstType_176237;

struct GenericInstType_176237 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_178893 GenericInstType_178893, *PGenericInstType_178893;

struct GenericInstType_178893 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_176233 GenericInstType_176233, *PGenericInstType_176233;

struct GenericInstType_176233 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct GenericInstType_176237 Type; // Generic Type
};

typedef struct GenericInstType_184658 GenericInstType_184658, *PGenericInstType_184658;

struct GenericInstType_184658 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct SzArray_175919 SzArray_175919, *PSzArray_175919;

struct SzArray_175919 {
    enum TypeCode TypeCode; // SzArray
    enum TypeCode Type; // type or void
};

typedef struct GenericInstType_175826 GenericInstType_175826, *PGenericInstType_175826;

struct GenericInstType_175826 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_185061 GenericInstType_185061, *PGenericInstType_185061;

struct GenericInstType_185061 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_181978 GenericInstType_181978, *PGenericInstType_181978;

struct GenericInstType_181978 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_175059 GenericInstType_175059, *PGenericInstType_175059;

typedef struct ValueType.conflict ValueType.conflict, *PValueType.conflict;

struct ValueType.conflict {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0xde
};

struct GenericInstType_175059 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict Type; // Generic Type
};

typedef struct GenericInstType_176265 GenericInstType_176265, *PGenericInstType_176265;

struct GenericInstType_176265 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_180641 GenericInstType_180641, *PGenericInstType_180641;

struct GenericInstType_180641 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_185659 GenericInstType_185659, *PGenericInstType_185659;

struct GenericInstType_185659 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_180767 GenericInstType_180767, *PGenericInstType_180767;

struct GenericInstType_180767 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_184201 GenericInstType_184201, *PGenericInstType_184201;

struct GenericInstType_184201 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_182142 GenericInstType_182142, *PGenericInstType_182142;

struct GenericInstType_182142 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_184562 GenericInstType_184562, *PGenericInstType_184562;

struct GenericInstType_184562 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_182386 GenericInstType_182386, *PGenericInstType_182386;

typedef struct ValueType.conflict29 ValueType.conflict29, *PValueType.conflict29;

struct ValueType.conflict29 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2c9
};

struct GenericInstType_182386 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict29 Type; // Generic Type
};

typedef struct GenericInstType_179889 GenericInstType_179889, *PGenericInstType_179889;

typedef struct ValueType.conflict48 ValueType.conflict48, *PValueType.conflict48;

struct ValueType.conflict48 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x18
};

struct GenericInstType_179889 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict48 Type; // Generic Type
};

typedef struct GenericInstType_181607 GenericInstType_181607, *PGenericInstType_181607;

struct GenericInstType_181607 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_175043 GenericInstType_175043, *PGenericInstType_175043;

struct GenericInstType_175043 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict1 Type; // Generic Type
};

typedef struct GenericInstType_176255 GenericInstType_176255, *PGenericInstType_176255;

struct GenericInstType_176255 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_181047 GenericInstType_181047, *PGenericInstType_181047;

typedef struct ValueType.conflict26 ValueType.conflict26, *PValueType.conflict26;

struct ValueType.conflict26 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2c6
};

struct GenericInstType_181047 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict26 Type; // Generic Type
};

typedef struct GenericInstType_177461 GenericInstType_177461, *PGenericInstType_177461;

struct GenericInstType_177461 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_184439 GenericInstType_184439, *PGenericInstType_184439;

struct GenericInstType_184439 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_182376 GenericInstType_182376, *PGenericInstType_182376;

struct GenericInstType_182376 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_176814 GenericInstType_176814, *PGenericInstType_176814;

struct GenericInstType_176814 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_175752 GenericInstType_175752, *PGenericInstType_175752;

struct GenericInstType_175752 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_179311 GenericInstType_179311, *PGenericInstType_179311;

typedef struct ValueType.conflict19 ValueType.conflict19, *PValueType.conflict19;

struct ValueType.conflict19 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1e3
};

struct GenericInstType_179311 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict19 Type; // Generic Type
};

typedef struct GenericInstType_177377 GenericInstType_177377, *PGenericInstType_177377;

struct GenericInstType_177377 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_176040 GenericInstType_176040, *PGenericInstType_176040;

struct GenericInstType_176040 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_185319 GenericInstType_185319, *PGenericInstType_185319;

struct GenericInstType_185319 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_185550 GenericInstType_185550, *PGenericInstType_185550;

struct GenericInstType_185550 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct ValueType.conflict37 ValueType.conflict37, *PValueType.conflict37;

struct ValueType.conflict37 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x318
};

typedef struct ValueType.conflict36 ValueType.conflict36, *PValueType.conflict36;

struct ValueType.conflict36 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2d0
};

typedef struct ValueType.conflict39 ValueType.conflict39, *PValueType.conflict39;

struct ValueType.conflict39 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x34e
};

typedef struct ValueType.conflict38 ValueType.conflict38, *PValueType.conflict38;

struct ValueType.conflict38 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x329
};

typedef struct ValueType.conflict33 ValueType.conflict33, *PValueType.conflict33;

struct ValueType.conflict33 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2cd
};

typedef struct GenericInstType_176606 GenericInstType_176606, *PGenericInstType_176606;

struct GenericInstType_176606 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct ValueType.conflict32 ValueType.conflict32, *PValueType.conflict32;

struct ValueType.conflict32 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2cc
};

typedef struct ValueType.conflict35 ValueType.conflict35, *PValueType.conflict35;

struct ValueType.conflict35 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2cf
};

typedef struct ValueType.conflict34 ValueType.conflict34, *PValueType.conflict34;

struct ValueType.conflict34 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2ce
};

typedef struct ValueType.conflict31 ValueType.conflict31, *PValueType.conflict31;

struct ValueType.conflict31 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2cb
};

typedef struct GenericInstType_175637 GenericInstType_175637, *PGenericInstType_175637;

struct GenericInstType_175637 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_178903 GenericInstType_178903, *PGenericInstType_178903;

struct GenericInstType_178903 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_185303 GenericInstType_185303, *PGenericInstType_185303;

struct GenericInstType_185303 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict31 Type; // Generic Type
};

typedef struct ValueType.conflict47 ValueType.conflict47, *PValueType.conflict47;

struct ValueType.conflict47 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x17
};

typedef struct ValueType.conflict44 ValueType.conflict44, *PValueType.conflict44;

struct ValueType.conflict44 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x389
};

typedef struct ValueType.conflict43 ValueType.conflict43, *PValueType.conflict43;

struct ValueType.conflict43 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x352
};

typedef struct ValueType.conflict46 ValueType.conflict46, *PValueType.conflict46;

struct ValueType.conflict46 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0xa
};

typedef struct ValueType.conflict45 ValueType.conflict45, *PValueType.conflict45;

struct ValueType.conflict45 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x8
};

typedef struct ValueType.conflict40 ValueType.conflict40, *PValueType.conflict40;

struct ValueType.conflict40 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x34f
};

typedef struct GenericInstType_176712 GenericInstType_176712, *PGenericInstType_176712;

struct GenericInstType_176712 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct ValueType.conflict42 ValueType.conflict42, *PValueType.conflict42;

struct ValueType.conflict42 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x351
};

typedef struct ValueType.conflict41 ValueType.conflict41, *PValueType.conflict41;

struct ValueType.conflict41 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x350
};

typedef struct GenericInstType_174683 GenericInstType_174683, *PGenericInstType_174683;

struct GenericInstType_174683 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_184803 GenericInstType_184803, *PGenericInstType_184803;

struct GenericInstType_184803 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict39 Type; // Generic Type
};

typedef struct ValueType.conflict18 ValueType.conflict18, *PValueType.conflict18;

struct ValueType.conflict18 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1e2
};

typedef struct GenericInstType_183271 GenericInstType_183271, *PGenericInstType_183271;

struct GenericInstType_183271 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct ValueType.conflict15 ValueType.conflict15, *PValueType.conflict15;

struct ValueType.conflict15 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1df
};

typedef struct ValueType.conflict14 ValueType.conflict14, *PValueType.conflict14;

struct ValueType.conflict14 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1de
};

typedef struct ValueType.conflict17 ValueType.conflict17, *PValueType.conflict17;

struct ValueType.conflict17 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1e1
};

typedef struct ValueType.conflict16 ValueType.conflict16, *PValueType.conflict16;

struct ValueType.conflict16 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1e0
};

typedef struct ValueType.conflict11 ValueType.conflict11, *PValueType.conflict11;

struct ValueType.conflict11 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x15f
};

typedef struct ValueType.conflict10 ValueType.conflict10, *PValueType.conflict10;

struct ValueType.conflict10 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x15e
};

typedef struct ValueType.conflict13 ValueType.conflict13, *PValueType.conflict13;

struct ValueType.conflict13 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x16a
};

typedef struct GenericInstType_174326 GenericInstType_174326, *PGenericInstType_174326;

struct GenericInstType_174326 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct Class Type; // Generic Type
};

typedef struct ValueType.conflict12 ValueType.conflict12, *PValueType.conflict12;

struct ValueType.conflict12 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x160
};

typedef struct GenericInstType_174313 GenericInstType_174313, *PGenericInstType_174313;

struct GenericInstType_174313 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_178112 GenericInstType_178112, *PGenericInstType_178112;

struct GenericInstType_178112 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_180551 GenericInstType_180551, *PGenericInstType_180551;

struct GenericInstType_180551 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict16 Type; // Generic Type
};

typedef struct ValueType.conflict25 ValueType.conflict25, *PValueType.conflict25;

struct ValueType.conflict25 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1e9
};

typedef struct ValueType.conflict28 ValueType.conflict28, *PValueType.conflict28;

struct ValueType.conflict28 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2c8
};

typedef struct ValueType.conflict27 ValueType.conflict27, *PValueType.conflict27;

struct ValueType.conflict27 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x2c7
};

typedef struct ValueType.conflict22 ValueType.conflict22, *PValueType.conflict22;

struct ValueType.conflict22 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1e6
};

typedef struct ValueType.conflict21 ValueType.conflict21, *PValueType.conflict21;

struct ValueType.conflict21 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1e5
};

typedef struct ValueType.conflict24 ValueType.conflict24, *PValueType.conflict24;

struct ValueType.conflict24 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1e8
};

typedef struct ValueType.conflict20 ValueType.conflict20, *PValueType.conflict20;

struct ValueType.conflict20 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x1e4
};

typedef struct GenericInstType_179479 GenericInstType_179479, *PGenericInstType_179479;

struct GenericInstType_179479 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_183733 GenericInstType_183733, *PGenericInstType_183733;

struct GenericInstType_183733 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_179231 GenericInstType_179231, *PGenericInstType_179231;

struct GenericInstType_179231 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_177049 GenericInstType_177049, *PGenericInstType_177049;

struct GenericInstType_177049 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_179221 GenericInstType_179221, *PGenericInstType_179221;

struct GenericInstType_179221 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_184373 GenericInstType_184373, *PGenericInstType_184373;

struct GenericInstType_184373 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_175309 GenericInstType_175309, *PGenericInstType_175309;

struct GenericInstType_175309 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_174336 GenericInstType_174336, *PGenericInstType_174336;

struct GenericInstType_174336 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_175213 GenericInstType_175213, *PGenericInstType_175213;

typedef struct ValueType.conflict4 ValueType.conflict4, *PValueType.conflict4;

struct ValueType.conflict4 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0xe2
};

struct GenericInstType_175213 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict4 Type; // Generic Type
};

typedef struct GenericInstType_179131 GenericInstType_179131, *PGenericInstType_179131;

struct GenericInstType_179131 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_185813 GenericInstType_185813, *PGenericInstType_185813;

struct GenericInstType_185813 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_185934 GenericInstType_185934, *PGenericInstType_185934;

struct GenericInstType_185934 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_186100 GenericInstType_186100, *PGenericInstType_186100;

struct GenericInstType_186100 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict44 Type; // Generic Type
};

typedef struct GenericInstType_185133 GenericInstType_185133, *PGenericInstType_185133;

struct GenericInstType_185133 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_179121 GenericInstType_179121, *PGenericInstType_179121;

struct GenericInstType_179121 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_175477 GenericInstType_175477, *PGenericInstType_175477;

typedef struct ValueType.conflict6 ValueType.conflict6, *PValueType.conflict6;

struct ValueType.conflict6 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0xe4
};

struct GenericInstType_175477 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict6 Type; // Generic Type
};

typedef struct GenericInstType_180705 GenericInstType_180705, *PGenericInstType_180705;

struct GenericInstType_180705 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict27 Type; // Generic Type
};

typedef struct GenericInstType_185719 GenericInstType_185719, *PGenericInstType_185719;

struct GenericInstType_185719 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_173851 GenericInstType_173851, *PGenericInstType_173851;

struct GenericInstType_173851 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct GenericInstType_185273 GenericInstType_185273, *PGenericInstType_185273;

struct GenericInstType_185273 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_175223 GenericInstType_175223, *PGenericInstType_175223;

struct GenericInstType_175223 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict4 Type; // Generic Type
};

typedef struct GenericInstType_175463 GenericInstType_175463, *PGenericInstType_175463;

struct GenericInstType_175463 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_174492 GenericInstType_174492, *PGenericInstType_174492;

struct GenericInstType_174492 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_182558 GenericInstType_182558, *PGenericInstType_182558;

struct GenericInstType_182558 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_184737 GenericInstType_184737, *PGenericInstType_184737;

struct GenericInstType_184737 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_184055 GenericInstType_184055, *PGenericInstType_184055;

struct GenericInstType_184055 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_185263 GenericInstType_185263, *PGenericInstType_185263;

struct GenericInstType_185263 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict43 Type; // Generic Type
};

typedef struct GenericInstType_176223 GenericInstType_176223, *PGenericInstType_176223;

struct GenericInstType_176223 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict2 Type; // Generic Type
};

typedef struct GenericInstType_181497 GenericInstType_181497, *PGenericInstType_181497;

struct GenericInstType_181497 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct ValueType.conflict7 ValueType.conflict7, *PValueType.conflict7;

struct ValueType.conflict7 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0xe5
};

typedef struct GenericInstType_173998 GenericInstType_173998, *PGenericInstType_173998;

struct GenericInstType_173998 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct ValueType.conflict8 ValueType.conflict8, *PValueType.conflict8;

struct ValueType.conflict8 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x13b
};

typedef struct ValueType.conflict5 ValueType.conflict5, *PValueType.conflict5;

struct ValueType.conflict5 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0xe3
};

typedef struct GenericInstType_185293 GenericInstType_185293, *PGenericInstType_185293;

struct GenericInstType_185293 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_176213 GenericInstType_176213, *PGenericInstType_176213;

struct GenericInstType_176213 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_180956 GenericInstType_180956, *PGenericInstType_180956;

struct GenericInstType_180956 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct ValueType.conflict3 ValueType.conflict3, *PValueType.conflict3;

struct ValueType.conflict3 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0xe1
};

typedef struct ValueType ValueType, *PValueType;

struct ValueType {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x6e
};

typedef struct GenericInstType_181487 GenericInstType_181487, *PGenericInstType_181487;

struct GenericInstType_181487 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_180833 GenericInstType_180833, *PGenericInstType_180833;

struct GenericInstType_180833 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_181241 GenericInstType_181241, *PGenericInstType_181241;

struct GenericInstType_181241 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_182210 GenericInstType_182210, *PGenericInstType_182210;

struct GenericInstType_182210 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct GenericInstType_185283 GenericInstType_185283, *PGenericInstType_185283;

struct GenericInstType_185283 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class.conflict Type; // Generic Type
};

typedef struct Blob_Generic_42003 Blob_Generic_42003, *PBlob_Generic_42003;

struct Blob_Generic_42003 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_43335 Blob_Generic_43335, *PBlob_Generic_43335;

struct Blob_Generic_43335 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2681 Blob_Generic_2681, *PBlob_Generic_2681;

struct Blob_Generic_2681 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10410 Blob_Generic_10410, *PBlob_Generic_10410;

struct Blob_Generic_10410 {
    byte Size; // coded integer - blob size
    byte Generic[22]; // Undefined blob contents
};

typedef struct Blob_Generic_11741 Blob_Generic_11741, *PBlob_Generic_11741;

struct Blob_Generic_11741 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_30015 Blob_Generic_30015, *PBlob_Generic_30015;

struct Blob_Generic_30015 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2691 Blob_Generic_2691, *PBlob_Generic_2691;

struct Blob_Generic_2691 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_45982 Blob_Generic_45982, *PBlob_Generic_45982;

struct Blob_Generic_45982 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1364 Blob_Generic_1364, *PBlob_Generic_1364;

struct Blob_Generic_1364 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11751 Blob_Generic_11751, *PBlob_Generic_11751;

struct Blob_Generic_11751 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_29040 Blob_Generic_29040, *PBlob_Generic_29040;

struct Blob_Generic_29040 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_35716 Blob_Generic_35716, *PBlob_Generic_35716;

struct Blob_Generic_35716 {
    byte Size; // coded integer - blob size
    byte Generic[26]; // Undefined blob contents
};

typedef struct Blob_Generic_5729 Blob_Generic_5729, *PBlob_Generic_5729;

struct Blob_Generic_5729 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_31354 Blob_Generic_31354, *PBlob_Generic_31354;

struct Blob_Generic_31354 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_44659 Blob_Generic_44659, *PBlob_Generic_44659;

struct Blob_Generic_44659 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17024 Blob_Generic_17024, *PBlob_Generic_17024;

struct Blob_Generic_17024 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_43314 Blob_Generic_43314, *PBlob_Generic_43314;

struct Blob_Generic_43314 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18353 Blob_Generic_18353, *PBlob_Generic_18353;

struct Blob_Generic_18353 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_1372 Blob_Generic_1372, *PBlob_Generic_1372;

struct Blob_Generic_1372 {
    byte Size; // coded integer - blob size
    byte Generic[16]; // Undefined blob contents
};

typedef struct Blob_Generic_11721 Blob_Generic_11721, *PBlob_Generic_11721;

struct Blob_Generic_11721 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6071 Blob_PropertySig_6071, *PBlob_PropertySig_6071;

typedef struct PropertySig_6071 PropertySig_6071, *PPropertySig_6071;

typedef struct Type_179602 Type_179602, *PType_179602;

struct Type_179602 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6071 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179602 RetType; // Return type
};

struct Blob_PropertySig_6071 {
    byte Size; // coded integer - blob size
    struct PropertySig_6071 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_40281 Blob_Generic_40281, *PBlob_Generic_40281;

struct Blob_Generic_40281 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_32657 Blob_Generic_32657, *PBlob_Generic_32657;

struct Blob_Generic_32657 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_5737 Blob_Generic_5737, *PBlob_Generic_5737;

struct Blob_Generic_5737 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_39287 Blob_Generic_39287, *PBlob_Generic_39287;

struct Blob_Generic_39287 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_Generic_4412 Blob_Generic_4412, *PBlob_Generic_4412;

struct Blob_Generic_4412 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11731 Blob_Generic_11731, *PBlob_Generic_11731;

struct Blob_Generic_11731 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10402 Blob_Generic_10402, *PBlob_Generic_10402;

struct Blob_Generic_10402 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5745 Blob_Generic_5745, *PBlob_Generic_5745;

struct Blob_Generic_5745 {
    byte Size; // coded integer - blob size
    byte Generic[17]; // Undefined blob contents
};

typedef struct Blob_Generic_1389 Blob_Generic_1389, *PBlob_Generic_1389;

struct Blob_Generic_1389 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4418 Blob_Generic_4418, *PBlob_Generic_4418;

struct Blob_Generic_4418 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_44638 Blob_Generic_44638, *PBlob_Generic_44638;

struct Blob_Generic_44638 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_21105 Blob_Generic_21105, *PBlob_Generic_21105;

struct Blob_Generic_21105 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11781 Blob_Generic_11781, *PBlob_Generic_11781;

struct Blob_Generic_11781 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_22432 Blob_Generic_22432, *PBlob_Generic_22432;

struct Blob_Generic_22432 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_PropertySig_476 Blob_PropertySig_476, *PBlob_PropertySig_476;

typedef struct PropertySig_476 PropertySig_476, *PPropertySig_476;

typedef struct Type_174007 Type_174007, *PType_174007;

struct Type_174007 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_476 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174007 RetType; // Return type
};

struct Blob_PropertySig_476 {
    byte Size; // coded integer - blob size
    struct PropertySig_476 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1397 Blob_Generic_1397, *PBlob_Generic_1397;

struct Blob_Generic_1397 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11787 Blob_Generic_11787, *PBlob_Generic_11787;

struct Blob_Generic_11787 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10457 Blob_Generic_10457, *PBlob_Generic_10457;

struct Blob_Generic_10457 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_227 Blob_Generic_227, *PBlob_Generic_227;

struct Blob_Generic_227 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_4424 Blob_Generic_4424, *PBlob_Generic_4424;

struct Blob_Generic_4424 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_35743 Blob_Generic_35743, *PBlob_Generic_35743;

struct Blob_Generic_35743 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_30057 Blob_Generic_30057, *PBlob_Generic_30057;

struct Blob_Generic_30057 {
    byte Size; // coded integer - blob size
    byte Generic[36]; // Undefined blob contents
};

typedef struct Blob_Generic_17094 Blob_Generic_17094, *PBlob_Generic_17094;

struct Blob_Generic_17094 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_4430 Blob_Generic_4430, *PBlob_Generic_4430;

struct Blob_Generic_4430 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_47723 Blob_Generic_47723, *PBlob_Generic_47723;

struct Blob_Generic_47723 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_PropertySig_466 Blob_PropertySig_466, *PBlob_PropertySig_466;

typedef struct PropertySig_466 PropertySig_466, *PPropertySig_466;

typedef struct Type_173997 Type_173997, *PType_173997;

struct Type_173997 {
    struct GenericInstType_173998 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_466 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173997 RetType; // Return type
};

struct Blob_PropertySig_466 {
    byte Size; // coded integer - blob size
    struct PropertySig_466 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_5763 Blob_Generic_5763, *PBlob_Generic_5763;

struct Blob_Generic_5763 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10465 Blob_Generic_10465, *PBlob_Generic_10465;

struct Blob_Generic_10465 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_11797 Blob_Generic_11797, *PBlob_Generic_11797;

struct Blob_Generic_11797 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_29082 Blob_Generic_29082, *PBlob_Generic_29082;

struct Blob_Generic_29082 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5769 Blob_Generic_5769, *PBlob_Generic_5769;

struct Blob_Generic_5769 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_216 Blob_Generic_216, *PBlob_Generic_216;

struct Blob_Generic_216 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_4436 Blob_Generic_4436, *PBlob_Generic_4436;

struct Blob_Generic_4436 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3105 Blob_Generic_3105, *PBlob_Generic_3105;

struct Blob_Generic_3105 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_42024 Blob_Generic_42024, *PBlob_Generic_42024;

struct Blob_Generic_42024 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2508 Blob_PropertySig_2508, *PBlob_PropertySig_2508;

typedef struct PropertySig_2508 PropertySig_2508, *PPropertySig_2508;

typedef struct Type_176039 Type_176039, *PType_176039;

struct Type_176039 {
    struct GenericInstType_176040 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2508 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176039 RetType; // Return type
};

struct Blob_PropertySig_2508 {
    byte Size; // coded integer - blob size
    struct PropertySig_2508 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_22411 Blob_Generic_22411, *PBlob_Generic_22411;

struct Blob_Generic_22411 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_23740 Blob_Generic_23740, *PBlob_Generic_23740;

struct Blob_Generic_23740 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_43356 Blob_Generic_43356, *PBlob_Generic_43356;

struct Blob_Generic_43356 {
    byte Size; // coded integer - blob size
    byte Generic[70]; // Undefined blob contents
};

typedef struct Blob_Generic_3113 Blob_Generic_3113, *PBlob_Generic_3113;

struct Blob_Generic_3113 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_11761 Blob_Generic_11761, *PBlob_Generic_11761;

struct Blob_Generic_11761 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_44680 Blob_Generic_44680, *PBlob_Generic_44680;

struct Blob_Generic_44680 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_202 Blob_Generic_202, *PBlob_Generic_202;

struct Blob_Generic_202 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_4442 Blob_Generic_4442, *PBlob_Generic_4442;

struct Blob_Generic_4442 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_8804 Blob_Generic_8804, *PBlob_Generic_8804;

struct Blob_Generic_8804 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10433 Blob_Generic_10433, *PBlob_Generic_10433;

struct Blob_Generic_10433 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4448 Blob_Generic_4448, *PBlob_Generic_4448;

struct Blob_Generic_4448 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_5779 Blob_Generic_5779, *PBlob_Generic_5779;

struct Blob_Generic_5779 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_30036 Blob_Generic_30036, *PBlob_Generic_30036;

struct Blob_Generic_30036 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_209 Blob_Generic_209, *PBlob_Generic_209;

struct Blob_Generic_209 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_17073 Blob_Generic_17073, *PBlob_Generic_17073;

struct Blob_Generic_17073 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11771 Blob_Generic_11771, *PBlob_Generic_11771;

struct Blob_Generic_11771 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3124 Blob_Generic_3124, *PBlob_Generic_3124;

struct Blob_Generic_3124 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_8814 Blob_Generic_8814, *PBlob_Generic_8814;

struct Blob_Generic_8814 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10441 Blob_Generic_10441, *PBlob_Generic_10441;

struct Blob_Generic_10441 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_29061 Blob_Generic_29061, *PBlob_Generic_29061;

struct Blob_Generic_29061 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5789 Blob_Generic_5789, *PBlob_Generic_5789;

struct Blob_Generic_5789 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10449 Blob_Generic_10449, *PBlob_Generic_10449;

struct Blob_Generic_10449 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_31375 Blob_Generic_31375, *PBlob_Generic_31375;

struct Blob_Generic_31375 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_34401 Blob_Generic_34401, *PBlob_Generic_34401;

struct Blob_Generic_34401 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3845 Blob_PropertySig_3845, *PBlob_PropertySig_3845;

typedef struct PropertySig_3845 PropertySig_3845, *PPropertySig_3845;

typedef struct Type_177376 Type_177376, *PType_177376;

struct Type_177376 {
    struct GenericInstType_177377 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_3845 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177376 RetType; // Return type
};

struct Blob_PropertySig_3845 {
    byte Size; // coded integer - blob size
    struct PropertySig_3845 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_40220 Blob_Generic_40220, *PBlob_Generic_40220;

struct Blob_Generic_40220 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_9236 Blob_Generic_9236, *PBlob_Generic_9236;

struct Blob_Generic_9236 {
    byte Size; // coded integer - blob size
    byte Generic[17]; // Undefined blob contents
};

typedef struct Blob_Generic_2600 Blob_Generic_2600, *PBlob_Generic_2600;

struct Blob_Generic_2600 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_19628 Blob_Generic_19628, *PBlob_Generic_19628;

struct Blob_Generic_19628 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9998 Blob_PropertySig_9998, *PBlob_PropertySig_9998;

typedef struct PropertySig_9998 PropertySig_9998, *PPropertySig_9998;

typedef struct Type_183529 Type_183529, *PType_183529;

struct Type_183529 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_9998 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183529 RetType; // Return type
};

struct Blob_PropertySig_9998 {
    byte Size; // coded integer - blob size
    struct PropertySig_9998 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_30897 Blob_Generic_30897, *PBlob_Generic_30897;

struct Blob_Generic_30897 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_48190 Blob_Generic_48190, *PBlob_Generic_48190;

struct Blob_Generic_48190 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_Generic_52204 Blob_Generic_52204, *PBlob_Generic_52204;

struct Blob_Generic_52204 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3937 Blob_Generic_3937, *PBlob_Generic_3937;

struct Blob_Generic_3937 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_20616 Blob_Generic_20616, *PBlob_Generic_20616;

struct Blob_Generic_20616 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_21946 Blob_Generic_21946, *PBlob_Generic_21946;

struct Blob_Generic_21946 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_39224 Blob_Generic_39224, *PBlob_Generic_39224;

struct Blob_Generic_39224 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41544 Blob_Generic_41544, *PBlob_Generic_41544;

struct Blob_Generic_41544 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3943 Blob_Generic_3943, *PBlob_Generic_3943;

struct Blob_Generic_3943 {
    byte Size; // coded integer - blob size
    byte Generic[37]; // Undefined blob contents
};

typedef struct Blob_Generic_33937 Blob_Generic_33937, *PBlob_Generic_33937;

struct Blob_Generic_33937 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2610 Blob_Generic_2610, *PBlob_Generic_2610;

struct Blob_Generic_2610 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_27253 Blob_Generic_27253, *PBlob_Generic_27253;

struct Blob_Generic_27253 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8678 Blob_PropertySig_8678, *PBlob_PropertySig_8678;

typedef struct PropertySig_8678 PropertySig_8678, *PPropertySig_8678;

typedef struct Type_182209 Type_182209, *PType_182209;

struct Type_182209 {
    struct GenericInstType_182210 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_8678 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182209 RetType; // Return type
};

struct Blob_PropertySig_8678 {
    byte Size; // coded integer - blob size
    struct PropertySig_8678 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_9254 Blob_Generic_9254, *PBlob_Generic_9254;

struct Blob_Generic_9254 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_48169 Blob_Generic_48169, *PBlob_Generic_48169;

struct Blob_Generic_48169 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9980 Blob_PropertySig_9980, *PBlob_PropertySig_9980;

typedef struct PropertySig_9980 PropertySig_9980, *PPropertySig_9980;

typedef struct Type_183511 Type_183511, *PType_183511;

struct Type_183511 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_9980 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183511 RetType; // Return type
};

struct Blob_PropertySig_9980 {
    byte Size; // coded integer - blob size
    struct PropertySig_9980 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_30876 Blob_Generic_30876, *PBlob_Generic_30876;

struct Blob_Generic_30876 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_49497 Blob_Generic_49497, *PBlob_Generic_49497;

struct Blob_Generic_49497 {
    byte Size; // coded integer - blob size
    byte Generic[72]; // Undefined blob contents
};

typedef struct Blob_Generic_2620 Blob_Generic_2620, *PBlob_Generic_2620;

struct Blob_Generic_2620 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_19607 Blob_Generic_19607, *PBlob_Generic_19607;

struct Blob_Generic_19607 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_29883 Blob_Generic_29883, *PBlob_Generic_29883;

struct Blob_Generic_29883 {
    byte Size; // coded integer - blob size
    byte Generic[37]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7311 Blob_PropertySig_7311, *PBlob_PropertySig_7311;

typedef struct PropertySig_7311 PropertySig_7311, *PPropertySig_7311;

typedef struct Type_180842 Type_180842, *PType_180842;

struct Type_180842 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_7311 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180842 RetType; // Return type
};

struct Blob_PropertySig_7311 {
    byte Size; // coded integer - blob size
    struct PropertySig_7311 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_9267 Blob_Generic_9267, *PBlob_Generic_9267;

struct Blob_Generic_9267 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10669 Blob_PropertySig_10669, *PBlob_PropertySig_10669;

typedef struct PropertySig_10669 PropertySig_10669, *PPropertySig_10669;

typedef struct Type_184200 Type_184200, *PType_184200;

struct Type_184200 {
    struct GenericInstType_184201 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_10669 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184200 RetType; // Return type
};

struct Blob_PropertySig_10669 {
    byte Size; // coded integer - blob size
    struct PropertySig_10669 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_41523 Blob_Generic_41523, *PBlob_Generic_41523;

struct Blob_Generic_41523 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_39203 Blob_Generic_39203, *PBlob_Generic_39203;

struct Blob_Generic_39203 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9992 Blob_PropertySig_9992, *PBlob_PropertySig_9992;

typedef struct PropertySig_9992 PropertySig_9992, *PPropertySig_9992;

typedef struct Type_183523 Type_183523, *PType_183523;

struct Type_183523 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_9992 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183523 RetType; // Return type
};

struct Blob_PropertySig_9992 {
    byte Size; // coded integer - blob size
    struct PropertySig_9992 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2630 Blob_Generic_2630, *PBlob_Generic_2630;

struct Blob_Generic_2630 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_33916 Blob_Generic_33916, *PBlob_Generic_33916;

struct Blob_Generic_33916 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_27232 Blob_Generic_27232, *PBlob_Generic_27232;

struct Blob_Generic_27232 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_28568 Blob_Generic_28568, *PBlob_Generic_28568;

struct Blob_Generic_28568 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9986 Blob_PropertySig_9986, *PBlob_PropertySig_9986;

typedef struct PropertySig_9986 PropertySig_9986, *PPropertySig_9986;

typedef struct Type_183517 Type_183517, *PType_183517;

struct Type_183517 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_9986 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183517 RetType; // Return type
};

struct Blob_PropertySig_9986 {
    byte Size; // coded integer - blob size
    struct PropertySig_9986 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1308 Blob_Generic_1308, *PBlob_Generic_1308;

struct Blob_Generic_1308 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_18332 Blob_Generic_18332, *PBlob_Generic_18332;

struct Blob_Generic_18332 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_32636 Blob_Generic_32636, *PBlob_Generic_32636;

struct Blob_Generic_32636 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2642 Blob_Generic_2642, *PBlob_Generic_2642;

struct Blob_Generic_2642 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_11701 Blob_Generic_11701, *PBlob_Generic_11701;

struct Blob_Generic_11701 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_1318 Blob_Generic_1318, *PBlob_Generic_1318;

struct Blob_Generic_1318 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_52246 Blob_Generic_52246, *PBlob_Generic_52246;

struct Blob_Generic_52246 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_9280 Blob_Generic_9280, *PBlob_Generic_9280;

struct Blob_Generic_9280 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_20658 Blob_Generic_20658, *PBlob_Generic_20658;

struct Blob_Generic_20658 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_21988 Blob_Generic_21988, *PBlob_Generic_21988;

struct Blob_Generic_21988 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19678 Blob_Generic_19678, *PBlob_Generic_19678;

struct Blob_Generic_19678 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_39266 Blob_Generic_39266, *PBlob_Generic_39266;

struct Blob_Generic_39266 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9287 Blob_Generic_9287, *PBlob_Generic_9287;

struct Blob_Generic_9287 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_2652 Blob_Generic_2652, *PBlob_Generic_2652;

struct Blob_Generic_2652 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3981 Blob_Generic_3981, *PBlob_Generic_3981;

struct Blob_Generic_3981 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11711 Blob_Generic_11711, *PBlob_Generic_11711;

struct Blob_Generic_11711 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_33979 Blob_Generic_33979, *PBlob_Generic_33979;

struct Blob_Generic_33979 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3989 Blob_Generic_3989, *PBlob_Generic_3989;

struct Blob_Generic_3989 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_15285 Blob_Generic_15285, *PBlob_Generic_15285;

struct Blob_Generic_15285 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_18311 Blob_Generic_18311, *PBlob_Generic_18311;

struct Blob_Generic_18311 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2662 Blob_Generic_2662, *PBlob_Generic_2662;

struct Blob_Generic_2662 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_32615 Blob_Generic_32615, *PBlob_Generic_32615;

struct Blob_Generic_32615 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3997 Blob_Generic_3997, *PBlob_Generic_3997;

struct Blob_Generic_3997 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_1334 Blob_Generic_1334, *PBlob_Generic_1334;

struct Blob_Generic_1334 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_2669 Blob_Generic_2669, *PBlob_Generic_2669;

struct Blob_Generic_2669 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_52225 Blob_Generic_52225, *PBlob_Generic_52225;

struct Blob_Generic_52225 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_20637 Blob_Generic_20637, *PBlob_Generic_20637;

struct Blob_Generic_20637 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_21967 Blob_Generic_21967, *PBlob_Generic_21967;

struct Blob_Generic_21967 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_45938 Blob_Generic_45938, *PBlob_Generic_45938;

struct Blob_Generic_45938 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_39245 Blob_Generic_39245, *PBlob_Generic_39245;

struct Blob_Generic_39245 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41565 Blob_Generic_41565, *PBlob_Generic_41565;

struct Blob_Generic_41565 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_33958 Blob_Generic_33958, *PBlob_Generic_33958;

struct Blob_Generic_33958 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2676 Blob_Generic_2676, *PBlob_Generic_2676;

struct Blob_Generic_2676 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_27274 Blob_Generic_27274, *PBlob_Generic_27274;

struct Blob_Generic_27274 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7369 Blob_PropertySig_7369, *PBlob_PropertySig_7369;

typedef struct PropertySig_7369 PropertySig_7369, *PPropertySig_7369;

typedef struct Type_180900 Type_180900, *PType_180900;

struct Type_180900 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_7369 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180900 RetType; // Return type
};

struct Blob_PropertySig_7369 {
    byte Size; // coded integer - blob size
    struct PropertySig_7369 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1349 Blob_Generic_1349, *PBlob_Generic_1349;

struct Blob_Generic_1349 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_5709 Blob_Generic_5709, *PBlob_Generic_5709;

struct Blob_Generic_5709 {
    byte Size; // coded integer - blob size
    byte Generic[19]; // Undefined blob contents
};

typedef struct Blob_Generic_12271 Blob_Generic_12271, *PBlob_Generic_12271;

struct Blob_Generic_12271 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_6124 Blob_Generic_6124, *PBlob_Generic_6124;

struct Blob_Generic_6124 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7455 Blob_Generic_7455, *PBlob_Generic_7455;

struct Blob_Generic_7455 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3097 Blob_Generic_3097, *PBlob_Generic_3097;

struct Blob_Generic_3097 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_8788 Blob_Generic_8788, *PBlob_Generic_8788;

struct Blob_Generic_8788 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_29942 Blob_Generic_29942, *PBlob_Generic_29942;

struct Blob_Generic_29942 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_25586 Blob_Generic_25586, *PBlob_Generic_25586;

struct Blob_Generic_25586 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_28614 Blob_Generic_28614, *PBlob_Generic_28614;

struct Blob_Generic_28614 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_12351 Blob_PropertySig_12351, *PBlob_PropertySig_12351;

typedef struct PropertySig_12351 PropertySig_12351, *PPropertySig_12351;

typedef struct Type_185882 Type_185882, *PType_185882;

struct Type_185882 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_12351 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185882 RetType; // Return type
};

struct Blob_PropertySig_12351 {
    byte Size; // coded integer - blob size
    struct PropertySig_12351 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_7463 Blob_Generic_7463, *PBlob_Generic_7463;

struct Blob_Generic_7463 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_12281 Blob_Generic_12281, *PBlob_Generic_12281;

struct Blob_Generic_12281 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_8797 Blob_Generic_8797, *PBlob_Generic_8797;

struct Blob_Generic_8797 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_6130 Blob_Generic_6130, *PBlob_Generic_6130;

struct Blob_Generic_6130 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_17973 Blob_Generic_17973, *PBlob_Generic_17973;

struct Blob_Generic_17973 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_45187 Blob_Generic_45187, *PBlob_Generic_45187;

struct Blob_Generic_45187 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16645 Blob_Generic_16645, *PBlob_Generic_16645;

struct Blob_Generic_16645 {
    byte Size; // coded integer - blob size
    byte Generic[25]; // Undefined blob contents
};

typedef struct Blob_Generic_50536 Blob_Generic_50536, *PBlob_Generic_50536;

struct Blob_Generic_50536 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6136 Blob_Generic_6136, *PBlob_Generic_6136;

struct Blob_Generic_6136 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12897 Blob_ConstantSig_12897, *PBlob_ConstantSig_12897;

typedef struct ConstantSig_12897 ConstantSig_12897, *PConstantSig_12897;

struct ConstantSig_12897 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12897 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12897 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_37578 Blob_Generic_37578, *PBlob_Generic_37578;

struct Blob_Generic_37578 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_12291 Blob_Generic_12291, *PBlob_Generic_12291;

struct Blob_Generic_12291 {
    byte Size; // coded integer - blob size
    byte Generic[19]; // Undefined blob contents
};

typedef struct Blob_Generic_7474 Blob_Generic_7474, *PBlob_Generic_7474;

struct Blob_Generic_7474 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_30918 Blob_Generic_30918, *PBlob_Generic_30918;

struct Blob_Generic_30918 {
    byte Size; // coded integer - blob size
    byte Generic[59]; // Undefined blob contents
};

typedef struct Blob_Generic_6142 Blob_Generic_6142, *PBlob_Generic_6142;

struct Blob_Generic_6142 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_38888 Blob_Generic_38888, *PBlob_Generic_38888;

struct Blob_Generic_38888 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12892 Blob_ConstantSig_12892, *PBlob_ConstantSig_12892;

typedef struct ConstantSig_12892 ConstantSig_12892, *PConstantSig_12892;

struct ConstantSig_12892 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12892 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12892 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_12259 Blob_Generic_12259, *PBlob_Generic_12259;

struct Blob_Generic_12259 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_6148 Blob_Generic_6148, *PBlob_Generic_6148;

struct Blob_Generic_6148 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_42908 Blob_Generic_42908, *PBlob_Generic_42908;

struct Blob_Generic_42908 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_Generic_29921 Blob_Generic_29921, *PBlob_Generic_29921;

struct Blob_Generic_29921 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12887 Blob_ConstantSig_12887, *PBlob_ConstantSig_12887;

typedef struct ConstantSig_12887 ConstantSig_12887, *PConstantSig_12887;

struct ConstantSig_12887 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12887 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12887 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_7487 Blob_Generic_7487, *PBlob_Generic_7487;

struct Blob_Generic_7487 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_13593 Blob_Generic_13593, *PBlob_Generic_13593;

struct Blob_Generic_13593 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17952 Blob_Generic_17952, *PBlob_Generic_17952;

struct Blob_Generic_17952 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12882 Blob_ConstantSig_12882, *PBlob_ConstantSig_12882;

typedef struct ConstantSig_12882 ConstantSig_12882, *PConstantSig_12882;

struct ConstantSig_12882 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12882 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12882 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_45166 Blob_Generic_45166, *PBlob_Generic_45166;

struct Blob_Generic_45166 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25570 Blob_Generic_25570, *PBlob_Generic_25570;

struct Blob_Generic_25570 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6876 Blob_PropertySig_6876, *PBlob_PropertySig_6876;

typedef struct PropertySig_6876 PropertySig_6876, *PPropertySig_6876;

typedef struct Type_180407 Type_180407, *PType_180407;

struct Type_180407 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6876 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180407 RetType; // Return type
};

struct Blob_PropertySig_6876 {
    byte Size; // coded integer - blob size
    struct PropertySig_6876 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_36229 Blob_Generic_36229, *PBlob_Generic_36229;

struct Blob_Generic_36229 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6870 Blob_PropertySig_6870, *PBlob_PropertySig_6870;

typedef struct PropertySig_6870 PropertySig_6870, *PPropertySig_6870;

typedef struct Type_180401 Type_180401, *PType_180401;

struct Type_180401 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6870 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180401 RetType; // Return type
};

struct Blob_PropertySig_6870 {
    byte Size; // coded integer - blob size
    struct PropertySig_6870 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_37557 Blob_Generic_37557, *PBlob_Generic_37557;

struct Blob_Generic_37557 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12877 Blob_ConstantSig_12877, *PBlob_ConstantSig_12877;

typedef struct ConstantSig_12877 ConstantSig_12877, *PConstantSig_12877;

struct ConstantSig_12877 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12877 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12877 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_33195 Blob_Generic_33195, *PBlob_Generic_33195;

struct Blob_Generic_33195 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7498 Blob_Generic_7498, *PBlob_Generic_7498;

struct Blob_Generic_7498 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_16671 Blob_Generic_16671, *PBlob_Generic_16671;

struct Blob_Generic_16671 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6163 Blob_Generic_6163, *PBlob_Generic_6163;

struct Blob_Generic_6163 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_50588 Blob_Generic_50588, *PBlob_Generic_50588;

struct Blob_Generic_50588 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_39319 Blob_Generic_39319, *PBlob_Generic_39319;

struct Blob_Generic_39319 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_48262 Blob_Generic_48262, *PBlob_Generic_48262;

struct Blob_Generic_48262 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_Generic_30978 Blob_Generic_30978, *PBlob_Generic_30978;

struct Blob_Generic_30978 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5599 Blob_PropertySig_5599, *PBlob_PropertySig_5599;

typedef struct PropertySig_5599 PropertySig_5599, *PPropertySig_5599;

typedef struct Type_179130 Type_179130, *PType_179130;

struct Type_179130 {
    struct GenericInstType_179131 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_5599 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179130 RetType; // Return type
};

struct Blob_PropertySig_5599 {
    byte Size; // coded integer - blob size
    struct PropertySig_5599 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_24296 Blob_Generic_24296, *PBlob_Generic_24296;

struct Blob_Generic_24296 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_36279 Blob_Generic_36279, *PBlob_Generic_36279;

struct Blob_Generic_36279 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6171 Blob_Generic_6171, *PBlob_Generic_6171;

struct Blob_Generic_6171 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_27328 Blob_Generic_27328, *PBlob_Generic_27328;

struct Blob_Generic_27328 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6179 Blob_Generic_6179, *PBlob_Generic_6179;

struct Blob_Generic_6179 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_14025 Blob_Generic_14025, *PBlob_Generic_14025;

struct Blob_Generic_14025 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_15359 Blob_Generic_15359, *PBlob_Generic_15359;

struct Blob_Generic_15359 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_9206 Blob_Generic_9206, *PBlob_Generic_9206;

struct Blob_Generic_9206 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3903 Blob_Generic_3903, *PBlob_Generic_3903;

struct Blob_Generic_3903 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_49591 Blob_Generic_49591, *PBlob_Generic_49591;

struct Blob_Generic_49591 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_29994 Blob_Generic_29994, *PBlob_Generic_29994;

struct Blob_Generic_29994 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7301 Blob_PropertySig_7301, *PBlob_PropertySig_7301;

typedef struct PropertySig_7301 PropertySig_7301, *PPropertySig_7301;

typedef struct Type_180832 Type_180832, *PType_180832;

struct Type_180832 {
    struct GenericInstType_180833 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_7301 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180832 RetType; // Return type
};

struct Blob_PropertySig_7301 {
    byte Size; // coded integer - blob size
    struct PropertySig_7301 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_20707 Blob_Generic_20707, *PBlob_Generic_20707;

struct Blob_Generic_20707 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_3909 Blob_Generic_3909, *PBlob_Generic_3909;

struct Blob_Generic_3909 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_9216 Blob_Generic_9216, *PBlob_Generic_9216;

struct Blob_Generic_9216 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_48241 Blob_Generic_48241, *PBlob_Generic_48241;

struct Blob_Generic_48241 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6192 Blob_Generic_6192, *PBlob_Generic_6192;

struct Blob_Generic_6192 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_28635 Blob_Generic_28635, *PBlob_Generic_28635;

struct Blob_Generic_28635 {
    byte Size; // coded integer - blob size
    byte Generic[59]; // Undefined blob contents
};

typedef struct Blob_Generic_3919 Blob_Generic_3919, *PBlob_Generic_3919;

struct Blob_Generic_3919 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_41617 Blob_Generic_41617, *PBlob_Generic_41617;

struct Blob_Generic_41617 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10591 Blob_PropertySig_10591, *PBlob_PropertySig_10591;

typedef struct PropertySig_10591 PropertySig_10591, *PPropertySig_10591;

typedef struct Type_184122 Type_184122, *PType_184122;

struct Type_184122 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10591 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184122 RetType; // Return type
};

struct Blob_PropertySig_10591 {
    byte Size; // coded integer - blob size
    struct PropertySig_10591 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_9226 Blob_Generic_9226, *PBlob_Generic_9226;

struct Blob_Generic_9226 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_14004 Blob_Generic_14004, *PBlob_Generic_14004;

struct Blob_Generic_14004 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17994 Blob_Generic_17994, *PBlob_Generic_17994;

struct Blob_Generic_17994 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_15338 Blob_Generic_15338, *PBlob_Generic_15338;

struct Blob_Generic_15338 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_50557 Blob_Generic_50557, *PBlob_Generic_50557;

struct Blob_Generic_50557 {
    byte Size; // coded integer - blob size
    byte Generic[30]; // Undefined blob contents
};

typedef struct Blob_Generic_49570 Blob_Generic_49570, *PBlob_Generic_49570;

struct Blob_Generic_49570 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5589 Blob_PropertySig_5589, *PBlob_PropertySig_5589;

typedef struct PropertySig_5589 PropertySig_5589, *PPropertySig_5589;

typedef struct Type_179120 Type_179120, *PType_179120;

struct Type_179120 {
    struct GenericInstType_179121 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_5589 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179120 RetType; // Return type
};

struct Blob_PropertySig_5589 {
    byte Size; // coded integer - blob size
    struct PropertySig_5589 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_3929 Blob_Generic_3929, *PBlob_Generic_3929;

struct Blob_Generic_3929 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_51882 Blob_Generic_51882, *PBlob_Generic_51882;

struct Blob_Generic_51882 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8610 Blob_PropertySig_8610, *PBlob_PropertySig_8610;

typedef struct PropertySig_8610 PropertySig_8610, *PPropertySig_8610;

typedef struct Type_182141 Type_182141, *PType_182141;

struct Type_182141 {
    struct GenericInstType_182142 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_8610 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182141 RetType; // Return type
};

struct Blob_PropertySig_8610 {
    byte Size; // coded integer - blob size
    struct PropertySig_8610 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_10585 Blob_PropertySig_10585, *PBlob_PropertySig_10585;

typedef struct PropertySig_10585 PropertySig_10585, *PPropertySig_10585;

typedef struct Type_184116 Type_184116, *PType_184116;

struct Type_184116 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10585 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184116 RetType; // Return type
};

struct Blob_PropertySig_10585 {
    byte Size; // coded integer - blob size
    struct PropertySig_10585 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_10491 Blob_Generic_10491, *PBlob_Generic_10491;

struct Blob_Generic_10491 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_22479 Blob_Generic_22479, *PBlob_Generic_22479;

struct Blob_Generic_22479 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3011 Blob_Generic_3011, *PBlob_Generic_3011;

struct Blob_Generic_3011 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_4340 Blob_Generic_4340, *PBlob_Generic_4340;

struct Blob_Generic_4340 {
    byte Size; // coded integer - blob size
    byte Generic[36]; // Undefined blob contents
};

typedef struct Blob_Generic_268 Blob_Generic_268, *PBlob_Generic_268;

struct Blob_Generic_268 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_8703 Blob_Generic_8703, *PBlob_Generic_8703;

struct Blob_Generic_8703 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_46443 Blob_Generic_46443, *PBlob_Generic_46443;

struct Blob_Generic_46443 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10499 Blob_Generic_10499, *PBlob_Generic_10499;

struct Blob_Generic_10499 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_42080 Blob_Generic_42080, *PBlob_Generic_42080;

struct Blob_Generic_42080 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_38825 Blob_Generic_38825, *PBlob_Generic_38825;

struct Blob_Generic_38825 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3016 Blob_Generic_3016, *PBlob_Generic_3016;

struct Blob_Generic_3016 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_5679 Blob_Generic_5679, *PBlob_Generic_5679;

struct Blob_Generic_5679 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_33127 Blob_Generic_33127, *PBlob_Generic_33127;

struct Blob_Generic_33127 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_30094 Blob_Generic_30094, *PBlob_Generic_30094;

struct Blob_Generic_30094 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34451 Blob_Generic_34451, *PBlob_Generic_34451;

struct Blob_Generic_34451 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_45108 Blob_Generic_45108, *PBlob_Generic_45108;

struct Blob_Generic_45108 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_3021 Blob_Generic_3021, *PBlob_Generic_3021;

struct Blob_Generic_3021 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_253 Blob_Generic_253, *PBlob_Generic_253;

struct Blob_Generic_253 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_258 Blob_Generic_258, *PBlob_Generic_258;

struct Blob_Generic_258 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3026 Blob_Generic_3026, *PBlob_Generic_3026;

struct Blob_Generic_3026 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_8711 Blob_Generic_8711, *PBlob_Generic_8711;

struct Blob_Generic_8711 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_14869 Blob_Generic_14869, *PBlob_Generic_14869;

struct Blob_Generic_14869 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_5689 Blob_Generic_5689, *PBlob_Generic_5689;

struct Blob_Generic_5689 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2450 Blob_PropertySig_2450, *PBlob_PropertySig_2450;

typedef struct PropertySig_2450 PropertySig_2450, *PPropertySig_2450;

typedef struct Type_175981 Type_175981, *PType_175981;

struct Type_175981 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_2450 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175981 RetType; // Return type
};

struct Blob_PropertySig_2450 {
    byte Size; // coded integer - blob size
    struct PropertySig_2450 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8719 Blob_Generic_8719, *PBlob_Generic_8719;

struct Blob_Generic_8719 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2456 Blob_PropertySig_2456, *PBlob_PropertySig_2456;

typedef struct PropertySig_2456 PropertySig_2456, *PPropertySig_2456;

typedef struct Type_175987 Type_175987, *PType_175987;

struct Type_175987 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_2456 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175987 RetType; // Return type
};

struct Blob_PropertySig_2456 {
    byte Size; // coded integer - blob size
    struct PropertySig_2456 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_26847 Blob_Generic_26847, *PBlob_Generic_26847;

struct Blob_Generic_26847 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_21126 Blob_Generic_21126, *PBlob_Generic_21126;

struct Blob_Generic_21126 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_242 Blob_Generic_242, *PBlob_Generic_242;

struct Blob_Generic_242 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5699 Blob_Generic_5699, *PBlob_Generic_5699;

struct Blob_Generic_5699 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10474 Blob_Generic_10474, *PBlob_Generic_10474;

struct Blob_Generic_10474 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_38804 Blob_Generic_38804, *PBlob_Generic_38804;

struct Blob_Generic_38804 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3038 Blob_Generic_3038, *PBlob_Generic_3038;

struct Blob_Generic_3038 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_248 Blob_Generic_248, *PBlob_Generic_248;

struct Blob_Generic_248 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_35764 Blob_Generic_35764, *PBlob_Generic_35764;

struct Blob_Generic_35764 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_7400 Blob_Generic_7400, *PBlob_Generic_7400;

struct Blob_Generic_7400 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_231 Blob_Generic_231, *PBlob_Generic_231;

struct Blob_Generic_231 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_10483 Blob_Generic_10483, *PBlob_Generic_10483;

struct Blob_Generic_10483 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_42059 Blob_Generic_42059, *PBlob_Generic_42059;

struct Blob_Generic_42059 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_235 Blob_Generic_235, *PBlob_Generic_235;

struct Blob_Generic_235 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_4377 Blob_Generic_4377, *PBlob_Generic_4377;

struct Blob_Generic_4377 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_7407 Blob_Generic_7407, *PBlob_Generic_7407;

struct Blob_Generic_7407 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_8739 Blob_Generic_8739, *PBlob_Generic_8739;

struct Blob_Generic_8739 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3046 Blob_Generic_3046, *PBlob_Generic_3046;

struct Blob_Generic_3046 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_8732 Blob_Generic_8732, *PBlob_Generic_8732;

struct Blob_Generic_8732 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_14848 Blob_Generic_14848, *PBlob_Generic_14848;

struct Blob_Generic_14848 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct CustomAttrib_12882 CustomAttrib_12882, *PCustomAttrib_12882;

struct CustomAttrib_12882 {
    word PROLOG; // Magic (0x0001)
    word NumNamed; // Number of NamedArgs to follow
};

typedef struct Blob_PropertySig_1109 Blob_PropertySig_1109, *PBlob_PropertySig_1109;

typedef struct PropertySig_1109 PropertySig_1109, *PPropertySig_1109;

typedef struct Type_174640 Type_174640, *PType_174640;

struct Type_174640 {
    struct ValueType ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_1109 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174640 RetType; // Return type
};

struct Blob_PropertySig_1109 {
    byte Size; // coded integer - blob size
    struct PropertySig_1109 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_26826 Blob_Generic_26826, *PBlob_Generic_26826;

struct Blob_Generic_26826 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3054 Blob_Generic_3054, *PBlob_Generic_3054;

struct Blob_Generic_3054 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_13562 Blob_Generic_13562, *PBlob_Generic_13562;

struct Blob_Generic_13562 {
    byte Size; // coded integer - blob size
    byte Generic[30]; // Undefined blob contents
};

typedef struct Blob_Generic_12230 Blob_Generic_12230, *PBlob_Generic_12230;

struct Blob_Generic_12230 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_46485 Blob_Generic_46485, *PBlob_Generic_46485;

struct Blob_Generic_46485 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_38867 Blob_Generic_38867, *PBlob_Generic_38867;

struct Blob_Generic_38867 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_51835 Blob_Generic_51835, *PBlob_Generic_51835;

struct Blob_Generic_51835 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_7414 Blob_Generic_7414, *PBlob_Generic_7414;

struct Blob_Generic_7414 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_8745 Blob_Generic_8745, *PBlob_Generic_8745;

struct Blob_Generic_8745 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_21190 Blob_Generic_21190, *PBlob_Generic_21190;

struct Blob_Generic_21190 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1151 Blob_PropertySig_1151, *PBlob_PropertySig_1151;

typedef struct PropertySig_1151 PropertySig_1151, *PPropertySig_1151;

typedef struct Type_174682 Type_174682, *PType_174682;

struct Type_174682 {
    struct GenericInstType_174683 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1151 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174682 RetType; // Return type
};

struct Blob_PropertySig_1151 {
    byte Size; // coded integer - blob size
    struct PropertySig_1151 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_34492 Blob_Generic_34492, *PBlob_Generic_34492;

struct Blob_Generic_34492 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_293 Blob_Generic_293, *PBlob_Generic_293;

struct Blob_Generic_293 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_3064 Blob_Generic_3064, *PBlob_Generic_3064;

struct Blob_Generic_3064 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_12245 Blob_Generic_12245, *PBlob_Generic_12245;

struct Blob_Generic_12245 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_16601 Blob_Generic_16601, *PBlob_Generic_16601;

struct Blob_Generic_16601 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_8755 Blob_Generic_8755, *PBlob_Generic_8755;

struct Blob_Generic_8755 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_7424 Blob_Generic_7424, *PBlob_Generic_7424;

struct Blob_Generic_7424 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_36208 Blob_Generic_36208, *PBlob_Generic_36208;

struct Blob_Generic_36208 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25554 Blob_Generic_25554, *PBlob_Generic_25554;

struct Blob_Generic_25554 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_33174 Blob_Generic_33174, *PBlob_Generic_33174;

struct Blob_Generic_33174 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_24227 Blob_Generic_24227, *PBlob_Generic_24227;

struct Blob_Generic_24227 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5527 Blob_PropertySig_5527, *PBlob_PropertySig_5527;

typedef struct PropertySig_5527 PropertySig_5527, *PPropertySig_5527;

typedef struct Type_179058 Type_179058, *PType_179058;

struct Type_179058 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_5527 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179058 RetType; // Return type
};

struct Blob_PropertySig_5527 {
    byte Size; // coded integer - blob size
    struct PropertySig_5527 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_280 Blob_Generic_280, *PBlob_Generic_280;

struct Blob_Generic_280 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_21169 Blob_Generic_21169, *PBlob_Generic_21169;

struct Blob_Generic_21169 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3074 Blob_Generic_3074, *PBlob_Generic_3074;

struct Blob_Generic_3074 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_284 Blob_Generic_284, *PBlob_Generic_284;

struct Blob_Generic_284 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_13541 Blob_Generic_13541, *PBlob_Generic_13541;

struct Blob_Generic_13541 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12214 Blob_Generic_12214, *PBlob_Generic_12214;

struct Blob_Generic_12214 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_38846 Blob_Generic_38846, *PBlob_Generic_38846;

struct Blob_Generic_38846 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_46464 Blob_Generic_46464, *PBlob_Generic_46464;

struct Blob_Generic_46464 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7434 Blob_Generic_7434, *PBlob_Generic_7434;

struct Blob_Generic_7434 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_8765 Blob_Generic_8765, *PBlob_Generic_8765;

struct Blob_Generic_8765 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_6106 Blob_Generic_6106, *PBlob_Generic_6106;

struct Blob_Generic_6106 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3797 Blob_PropertySig_3797, *PBlob_PropertySig_3797;

typedef struct PropertySig_3797 PropertySig_3797, *PPropertySig_3797;

typedef struct Type_177328 Type_177328, *PType_177328;

struct Type_177328 {
    struct ValueType.conflict8 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_3797 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177328 RetType; // Return type
};

struct Blob_PropertySig_3797 {
    byte Size; // coded integer - blob size
    struct PropertySig_3797 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_3084 Blob_Generic_3084, *PBlob_Generic_3084;

struct Blob_Generic_3084 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_8772 Blob_Generic_8772, *PBlob_Generic_8772;

struct Blob_Generic_8772 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_276 Blob_Generic_276, *PBlob_Generic_276;

struct Blob_Generic_276 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_12222 Blob_Generic_12222, *PBlob_Generic_12222;

struct Blob_Generic_12222 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_7447 Blob_Generic_7447, *PBlob_Generic_7447;

struct Blob_Generic_7447 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6117 Blob_Generic_6117, *PBlob_Generic_6117;

struct Blob_Generic_6117 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_47780 Blob_Generic_47780, *PBlob_Generic_47780;

struct Blob_Generic_47780 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11030 Blob_PropertySig_11030, *PBlob_PropertySig_11030;

typedef struct PropertySig_11030 PropertySig_11030, *PPropertySig_11030;

typedef struct Type_184561 Type_184561, *PType_184561;

struct Type_184561 {
    struct GenericInstType_184562 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11030 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184561 RetType; // Return type
};

struct Blob_PropertySig_11030 {
    byte Size; // coded integer - blob size
    struct PropertySig_11030 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_394 Blob_PropertySig_394, *PBlob_PropertySig_394;

typedef struct PropertySig_394 PropertySig_394, *PPropertySig_394;

typedef struct Type_173925 Type_173925, *PType_173925;

struct Type_173925 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_394 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173925 RetType; // Return type
};

struct Blob_PropertySig_394 {
    byte Size; // coded integer - blob size
    struct PropertySig_394 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_3895 Blob_Generic_3895, *PBlob_Generic_3895;

struct Blob_Generic_3895 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2564 Blob_Generic_2564, *PBlob_Generic_2564;

struct Blob_Generic_2564 {
    byte Size; // coded integer - blob size
    byte Generic[29]; // Undefined blob contents
};

typedef struct Blob_Generic_6922 Blob_Generic_6922, *PBlob_Generic_6922;

struct Blob_Generic_6922 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_44781 Blob_Generic_44781, *PBlob_Generic_44781;

struct Blob_Generic_44781 {
    byte Size; // coded integer - blob size
    byte Generic[79]; // Undefined blob contents
};

typedef struct Blob_Generic_10533 Blob_Generic_10533, *PBlob_Generic_10533;

struct Blob_Generic_10533 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_1235 Blob_Generic_1235, *PBlob_Generic_1235;

struct Blob_Generic_1235 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_42129 Blob_Generic_42129, *PBlob_Generic_42129;

struct Blob_Generic_42129 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_1244 Blob_Generic_1244, *PBlob_Generic_1244;

struct Blob_Generic_1244 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10546 Blob_Generic_10546, *PBlob_Generic_10546;

struct Blob_Generic_10546 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_29162 Blob_Generic_29162, *PBlob_Generic_29162;

struct Blob_Generic_29162 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6931 Blob_Generic_6931, *PBlob_Generic_6931;

struct Blob_Generic_6931 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_5609 Blob_Generic_5609, *PBlob_Generic_5609;

struct Blob_Generic_5609 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_23823 Blob_Generic_23823, *PBlob_Generic_23823;

struct Blob_Generic_23823 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_6945 Blob_Generic_6945, *PBlob_Generic_6945;

struct Blob_Generic_6945 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_1253 Blob_Generic_1253, *PBlob_Generic_1253;

struct Blob_Generic_1253 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10513 Blob_Generic_10513, *PBlob_Generic_10513;

struct Blob_Generic_10513 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_370 Blob_PropertySig_370, *PBlob_PropertySig_370;

typedef struct PropertySig_370 PropertySig_370, *PPropertySig_370;

typedef struct Type_173901 Type_173901, *PType_173901;

struct Type_173901 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct PropertySig_370 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173901 RetType; // Return type
};

struct Blob_PropertySig_370 {
    byte Size; // coded integer - blob size
    struct PropertySig_370 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_35805 Blob_Generic_35805, *PBlob_Generic_35805;

struct Blob_Generic_35805 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_29124 Blob_Generic_29124, *PBlob_Generic_29124;

struct Blob_Generic_29124 {
    byte Size; // coded integer - blob size
    byte Generic[37]; // Undefined blob contents
};

typedef struct Blob_Generic_30115 Blob_Generic_30115, *PBlob_Generic_30115;

struct Blob_Generic_30115 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_Generic_31446 Blob_Generic_31446, *PBlob_Generic_31446;

struct Blob_Generic_31446 {
    byte Size; // coded integer - blob size
    byte Generic[63]; // Undefined blob contents
};

typedef struct Blob_Generic_51050 Blob_Generic_51050, *PBlob_Generic_51050;

struct Blob_Generic_51050 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_40396 Blob_Generic_40396, *PBlob_Generic_40396;

struct Blob_Generic_40396 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17154 Blob_Generic_17154, *PBlob_Generic_17154;

struct Blob_Generic_17154 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_22500 Blob_Generic_22500, *PBlob_Generic_22500;

struct Blob_Generic_22500 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_1262 Blob_Generic_1262, *PBlob_Generic_1262;

struct Blob_Generic_1262 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5622 Blob_Generic_5622, *PBlob_Generic_5622;

struct Blob_Generic_5622 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_2594 Blob_Generic_2594, *PBlob_Generic_2594;

struct Blob_Generic_2594 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6956 Blob_Generic_6956, *PBlob_Generic_6956;

struct Blob_Generic_6956 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_992 Blob_Generic_992, *PBlob_Generic_992;

struct Blob_Generic_992 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10523 Blob_Generic_10523, *PBlob_Generic_10523;

struct Blob_Generic_10523 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_32788 Blob_Generic_32788, *PBlob_Generic_32788;

struct Blob_Generic_32788 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_43427 Blob_Generic_43427, *PBlob_Generic_43427;

struct Blob_Generic_43427 {
    byte Size; // coded integer - blob size
    byte Generic[70]; // Undefined blob contents
};

typedef struct Blob_Generic_52370 Blob_Generic_52370, *PBlob_Generic_52370;

struct Blob_Generic_52370 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_38085 Blob_Generic_38085, *PBlob_Generic_38085;

struct Blob_Generic_38085 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_43498 Blob_Generic_43498, *PBlob_Generic_43498;

struct Blob_Generic_43498 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1271 Blob_Generic_1271, *PBlob_Generic_1271;

struct Blob_Generic_1271 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10573 Blob_Generic_10573, *PBlob_Generic_10573;

struct Blob_Generic_10573 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6966 Blob_Generic_6966, *PBlob_Generic_6966;

struct Blob_Generic_6966 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_14935 Blob_Generic_14935, *PBlob_Generic_14935;

struct Blob_Generic_14935 {
    byte Size; // coded integer - blob size
    byte Generic[58]; // Undefined blob contents
};

typedef struct Blob_Generic_5635 Blob_Generic_5635, *PBlob_Generic_5635;

struct Blob_Generic_5635 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_10579 Blob_Generic_10579, *PBlob_Generic_10579;

struct Blob_Generic_10579 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_42162 Blob_Generic_42162, *PBlob_Generic_42162;

struct Blob_Generic_42162 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_105 Blob_Generic_105, *PBlob_Generic_105;

struct Blob_Generic_105 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_4309 Blob_Generic_4309, *PBlob_Generic_4309;

struct Blob_Generic_4309 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_35867 Blob_Generic_35867, *PBlob_Generic_35867;

struct Blob_Generic_35867 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_38909 Blob_Generic_38909, *PBlob_Generic_38909;

struct Blob_Generic_38909 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34534 Blob_Generic_34534, *PBlob_Generic_34534;

struct Blob_Generic_34534 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_26929 Blob_Generic_26929, *PBlob_Generic_26929;

struct Blob_Generic_26929 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_47841 Blob_Generic_47841, *PBlob_Generic_47841;

struct Blob_Generic_47841 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1281 Blob_Generic_1281, *PBlob_Generic_1281;

struct Blob_Generic_1281 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_23893 Blob_Generic_23893, *PBlob_Generic_23893;

struct Blob_Generic_23893 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10585 Blob_Generic_10585, *PBlob_Generic_10585;

struct Blob_Generic_10585 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_22561 Blob_Generic_22561, *PBlob_Generic_22561;

struct Blob_Generic_22561 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5648 Blob_Generic_5648, *PBlob_Generic_5648;

struct Blob_Generic_5648 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_13614 Blob_Generic_13614, *PBlob_Generic_13614;

struct Blob_Generic_13614 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_6973 Blob_Generic_6973, *PBlob_Generic_6973;

struct Blob_Generic_6973 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4314 Blob_Generic_4314, *PBlob_Generic_4314;

struct Blob_Generic_4314 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_33216 Blob_Generic_33216, *PBlob_Generic_33216;

struct Blob_Generic_33216 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_30187 Blob_Generic_30187, *PBlob_Generic_30187;

struct Blob_Generic_30187 {
    byte Size; // coded integer - blob size
    byte Generic[41]; // Undefined blob contents
};

typedef struct Blob_Generic_1290 Blob_Generic_1290, *PBlob_Generic_1290;

struct Blob_Generic_1290 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_6981 Blob_Generic_6981, *PBlob_Generic_6981;

struct Blob_Generic_6981 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4322 Blob_Generic_4322, *PBlob_Generic_4322;

struct Blob_Generic_4322 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_6989 Blob_Generic_6989, *PBlob_Generic_6989;

struct Blob_Generic_6989 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_1297 Blob_Generic_1297, *PBlob_Generic_1297;

struct Blob_Generic_1297 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_10554 Blob_Generic_10554, *PBlob_Generic_10554;

struct Blob_Generic_10554 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_14914 Blob_Generic_14914, *PBlob_Generic_14914;

struct Blob_Generic_14914 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11889 Blob_Generic_11889, *PBlob_Generic_11889;

struct Blob_Generic_11889 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_35846 Blob_Generic_35846, *PBlob_Generic_35846;

struct Blob_Generic_35846 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34513 Blob_Generic_34513, *PBlob_Generic_34513;

struct Blob_Generic_34513 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_26908 Blob_Generic_26908, *PBlob_Generic_26908;

struct Blob_Generic_26908 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4331 Blob_Generic_4331, *PBlob_Generic_4331;

struct Blob_Generic_4331 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_47820 Blob_Generic_47820, *PBlob_Generic_47820;

struct Blob_Generic_47820 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5661 Blob_Generic_5661, *PBlob_Generic_5661;

struct Blob_Generic_5661 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_21211 Blob_Generic_21211, *PBlob_Generic_21211;

struct Blob_Generic_21211 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_23872 Blob_Generic_23872, *PBlob_Generic_23872;

struct Blob_Generic_23872 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10562 Blob_Generic_10562, *PBlob_Generic_10562;

struct Blob_Generic_10562 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_29183 Blob_Generic_29183, *PBlob_Generic_29183;

struct Blob_Generic_29183 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3001 Blob_Generic_3001, *PBlob_Generic_3001;

struct Blob_Generic_3001 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_11897 Blob_Generic_11897, *PBlob_Generic_11897;

struct Blob_Generic_11897 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5669 Blob_Generic_5669, *PBlob_Generic_5669;

struct Blob_Generic_5669 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3006 Blob_Generic_3006, *PBlob_Generic_3006;

struct Blob_Generic_3006 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_6997 Blob_Generic_6997, *PBlob_Generic_6997;

struct Blob_Generic_6997 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9026 Blob_PropertySig_9026, *PBlob_PropertySig_9026;

typedef struct PropertySig_9026 PropertySig_9026, *PPropertySig_9026;

typedef struct Type_182557 Type_182557, *PType_182557;

struct Type_182557 {
    struct GenericInstType_182558 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_9026 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182557 RetType; // Return type
};

struct Blob_PropertySig_9026 {
    byte Size; // coded integer - blob size
    struct PropertySig_9026 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_30166 Blob_Generic_30166, *PBlob_Generic_30166;

struct Blob_Generic_30166 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9114 Blob_Generic_9114, *PBlob_Generic_9114;

struct Blob_Generic_9114 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_38021 Blob_Generic_38021, *PBlob_Generic_38021;

struct Blob_Generic_38021 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_40342 Blob_Generic_40342, *PBlob_Generic_40342;

struct Blob_Generic_40342 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_44701 Blob_Generic_44701, *PBlob_Generic_44701;

struct Blob_Generic_44701 {
    byte Size; // coded integer - blob size
    byte Generic[79]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4191 Blob_PropertySig_4191, *PBlob_PropertySig_4191;

typedef struct PropertySig_4191 PropertySig_4191, *PPropertySig_4191;

typedef struct Type_177722 Type_177722, *PType_177722;

struct Type_177722 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4191 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177722 RetType; // Return type
};

struct Blob_PropertySig_4191 {
    byte Size; // coded integer - blob size
    struct PropertySig_4191 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_944 Blob_Generic_944, *PBlob_Generic_944;

struct Blob_Generic_944 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_27370 Blob_Generic_27370, *PBlob_Generic_27370;

struct Blob_Generic_27370 {
    byte Size; // coded integer - blob size
    byte Generic[67]; // Undefined blob contents
};

typedef struct Blob_Generic_26032 Blob_Generic_26032, *PBlob_Generic_26032;

struct Blob_Generic_26032 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_28695 Blob_Generic_28695, *PBlob_Generic_28695;

struct Blob_Generic_28695 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_32712 Blob_Generic_32712, *PBlob_Generic_32712;

struct Blob_Generic_32712 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_3812 Blob_Generic_3812, *PBlob_Generic_3812;

struct Blob_Generic_3812 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_39361 Blob_Generic_39361, *PBlob_Generic_39361;

struct Blob_Generic_39361 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6090 Blob_Generic_6090, *PBlob_Generic_6090;

struct Blob_Generic_6090 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_319 Blob_PropertySig_319, *PBlob_PropertySig_319;

typedef struct PropertySig_319 PropertySig_319, *PPropertySig_319;

typedef struct Type_173850 Type_173850, *PType_173850;

struct Type_173850 {
    struct GenericInstType_173851 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_319 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173850 RetType; // Return type
};

struct Blob_PropertySig_319 {
    byte Size; // coded integer - blob size
    struct PropertySig_319 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_9124 Blob_Generic_9124, *PBlob_Generic_9124;

struct Blob_Generic_9124 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_15395 Blob_Generic_15395, *PBlob_Generic_15395;

struct Blob_Generic_15395 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6098 Blob_Generic_6098, *PBlob_Generic_6098;

struct Blob_Generic_6098 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3820 Blob_Generic_3820, *PBlob_Generic_3820;

struct Blob_Generic_3820 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_936 Blob_Generic_936, *PBlob_Generic_936;

struct Blob_Generic_936 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4197 Blob_PropertySig_4197, *PBlob_PropertySig_4197;

typedef struct PropertySig_4197 PropertySig_4197, *PPropertySig_4197;

typedef struct Type_177728 Type_177728, *PType_177728;

struct Type_177728 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4197 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177728 RetType; // Return type
};

struct Blob_PropertySig_4197 {
    byte Size; // coded integer - blob size
    struct PropertySig_4197 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_3828 Blob_Generic_3828, *PBlob_Generic_3828;

struct Blob_Generic_3828 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8556 Blob_PropertySig_8556, *PBlob_PropertySig_8556;

typedef struct PropertySig_8556 PropertySig_8556, *PPropertySig_8556;

typedef struct Type_182087 Type_182087, *PType_182087;

struct Type_182087 {
    struct ValueType.conflict28 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_8556 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182087 RetType; // Return type
};

struct Blob_PropertySig_8556 {
    byte Size; // coded integer - blob size
    struct PropertySig_8556 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_41669 Blob_Generic_41669, *PBlob_Generic_41669;

struct Blob_Generic_41669 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_42998 Blob_Generic_42998, *PBlob_Generic_42998;

struct Blob_Generic_42998 {
    byte Size; // coded integer - blob size
    byte Generic[55]; // Undefined blob contents
};

typedef struct Blob_Generic_38000 Blob_Generic_38000, *PBlob_Generic_38000;

struct Blob_Generic_38000 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16692 Blob_Generic_16692, *PBlob_Generic_16692;

struct Blob_Generic_16692 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9131 Blob_Generic_9131, *PBlob_Generic_9131;

struct Blob_Generic_9131 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_52308 Blob_Generic_52308, *PBlob_Generic_52308;

struct Blob_Generic_52308 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_920 Blob_Generic_920, *PBlob_Generic_920;

struct Blob_Generic_920 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_2500 Blob_Generic_2500, *PBlob_Generic_2500;

struct Blob_Generic_2500 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_19728 Blob_Generic_19728, *PBlob_Generic_19728;

struct Blob_Generic_19728 {
    byte Size; // coded integer - blob size
    byte Generic[33]; // Undefined blob contents
};

typedef struct Blob_Generic_48294 Blob_Generic_48294, *PBlob_Generic_48294;

struct Blob_Generic_48294 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3835 Blob_Generic_3835, *PBlob_Generic_3835;

struct Blob_Generic_3835 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_929 Blob_Generic_929, *PBlob_Generic_929;

struct Blob_Generic_929 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_2508 Blob_Generic_2508, *PBlob_Generic_2508;

struct Blob_Generic_2508 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_27349 Blob_Generic_27349, *PBlob_Generic_27349;

struct Blob_Generic_27349 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_39340 Blob_Generic_39340, *PBlob_Generic_39340;

struct Blob_Generic_39340 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9144 Blob_Generic_9144, *PBlob_Generic_9144;

struct Blob_Generic_9144 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_14046 Blob_Generic_14046, *PBlob_Generic_14046;

struct Blob_Generic_14046 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_18400 Blob_Generic_18400, *PBlob_Generic_18400;

struct Blob_Generic_18400 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_915 Blob_Generic_915, *PBlob_Generic_915;

struct Blob_Generic_915 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_2516 Blob_Generic_2516, *PBlob_Generic_2516;

struct Blob_Generic_2516 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_Generic_3845 Blob_Generic_3845, *PBlob_Generic_3845;

struct Blob_Generic_3845 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10783 Blob_PropertySig_10783, *PBlob_PropertySig_10783;

typedef struct PropertySig_10783 PropertySig_10783, *PPropertySig_10783;

typedef struct Type_184314 Type_184314, *PType_184314;

struct Type_184314 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10783 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184314 RetType; // Return type
};

struct Blob_PropertySig_10783 {
    byte Size; // coded integer - blob size
    struct PropertySig_10783 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_42977 Blob_Generic_42977, *PBlob_Generic_42977;

struct Blob_Generic_42977 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_23802 Blob_Generic_23802, *PBlob_Generic_23802;

struct Blob_Generic_23802 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_20777 Blob_Generic_20777, *PBlob_Generic_20777;

struct Blob_Generic_20777 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_9159 Blob_Generic_9159, *PBlob_Generic_9159;

struct Blob_Generic_9159 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_19783 Blob_Generic_19783, *PBlob_Generic_19783;

struct Blob_Generic_19783 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_984 Blob_Generic_984, *PBlob_Generic_984;

struct Blob_Generic_984 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3855 Blob_Generic_3855, *PBlob_Generic_3855;

struct Blob_Generic_3855 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_29103 Blob_Generic_29103, *PBlob_Generic_29103;

struct Blob_Generic_29103 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_31425 Blob_Generic_31425, *PBlob_Generic_31425;

struct Blob_Generic_31425 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18468 Blob_Generic_18468, *PBlob_Generic_18468;

struct Blob_Generic_18468 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_17133 Blob_Generic_17133, *PBlob_Generic_17133;

struct Blob_Generic_17133 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_51029 Blob_Generic_51029, *PBlob_Generic_51029;

struct Blob_Generic_51029 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_970 Blob_Generic_970, *PBlob_Generic_970;

struct Blob_Generic_970 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_26096 Blob_Generic_26096, *PBlob_Generic_26096;

struct Blob_Generic_26096 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3868 Blob_Generic_3868, *PBlob_Generic_3868;

struct Blob_Generic_3868 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_32767 Blob_Generic_32767, *PBlob_Generic_32767;

struct Blob_Generic_32767 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10507 Blob_Generic_10507, *PBlob_Generic_10507;

struct Blob_Generic_10507 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9172 Blob_Generic_9172, *PBlob_Generic_9172;

struct Blob_Generic_9172 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_38064 Blob_Generic_38064, *PBlob_Generic_38064;

struct Blob_Generic_38064 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_40363 Blob_Generic_40363, *PBlob_Generic_40363;

struct Blob_Generic_40363 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_9179 Blob_Generic_9179, *PBlob_Generic_9179;

struct Blob_Generic_9179 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1939 Blob_PropertySig_1939, *PBlob_PropertySig_1939;

typedef struct PropertySig_1939 PropertySig_1939, *PPropertySig_1939;

typedef struct Type_175470 Type_175470, *PType_175470;

struct Type_175470 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_1939 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175470 RetType; // Return type
};

struct Blob_PropertySig_1939 {
    byte Size; // coded integer - blob size
    struct PropertySig_1939 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_19762 Blob_Generic_19762, *PBlob_Generic_19762;

struct Blob_Generic_19762 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1211 Blob_Generic_1211, *PBlob_Generic_1211;

struct Blob_Generic_1211 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6900 Blob_Generic_6900, *PBlob_Generic_6900;

struct Blob_Generic_6900 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_960 Blob_Generic_960, *PBlob_Generic_960;

struct Blob_Generic_960 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3876 Blob_Generic_3876, *PBlob_Generic_3876;

struct Blob_Generic_3876 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_41690 Blob_Generic_41690, *PBlob_Generic_41690;

struct Blob_Generic_41690 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6907 Blob_Generic_6907, *PBlob_Generic_6907;

struct Blob_Generic_6907 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11803 Blob_Generic_11803, *PBlob_Generic_11803;

struct Blob_Generic_11803 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_26053 Blob_Generic_26053, *PBlob_Generic_26053;

struct Blob_Generic_26053 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_1217 Blob_Generic_1217, *PBlob_Generic_1217;

struct Blob_Generic_1217 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2548 Blob_Generic_2548, *PBlob_Generic_2548;

struct Blob_Generic_2548 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11809 Blob_Generic_11809, *PBlob_Generic_11809;

struct Blob_Generic_11809 {
    byte Size; // coded integer - blob size
    byte Generic[79]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7235 Blob_PropertySig_7235, *PBlob_PropertySig_7235;

typedef struct PropertySig_7235 PropertySig_7235, *PPropertySig_7235;

typedef struct Type_180766 Type_180766, *PType_180766;

struct Type_180766 {
    struct GenericInstType_180767 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_7235 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180766 RetType; // Return type
};

struct Blob_PropertySig_7235 {
    byte Size; // coded integer - blob size
    struct PropertySig_7235 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1931 Blob_PropertySig_1931, *PBlob_PropertySig_1931;

typedef struct PropertySig_1931 PropertySig_1931, *PPropertySig_1931;

typedef struct Type_175462 Type_175462, *PType_175462;

struct Type_175462 {
    struct GenericInstType_175463 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1931 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175462 RetType; // Return type
};

struct Blob_PropertySig_1931 {
    byte Size; // coded integer - blob size
    struct PropertySig_1931 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_39382 Blob_Generic_39382, *PBlob_Generic_39382;

struct Blob_Generic_39382 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_20756 Blob_Generic_20756, *PBlob_Generic_20756;

struct Blob_Generic_20756 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18447 Blob_Generic_18447, *PBlob_Generic_18447;

struct Blob_Generic_18447 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10743 Blob_PropertySig_10743, *PBlob_PropertySig_10743;

typedef struct PropertySig_10743 PropertySig_10743, *PPropertySig_10743;

typedef struct Type_184274 Type_184274, *PType_184274;

struct Type_184274 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10743 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184274 RetType; // Return type
};

struct Blob_PropertySig_10743 {
    byte Size; // coded integer - blob size
    struct PropertySig_10743 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_9186 Blob_Generic_9186, *PBlob_Generic_9186;

struct Blob_Generic_9186 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_14089 Blob_Generic_14089, *PBlob_Generic_14089;

struct Blob_Generic_14089 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_3884 Blob_Generic_3884, *PBlob_Generic_3884;

struct Blob_Generic_3884 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_950 Blob_Generic_950, *PBlob_Generic_950;

struct Blob_Generic_950 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_2556 Blob_Generic_2556, *PBlob_Generic_2556;

struct Blob_Generic_2556 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_1223 Blob_Generic_1223, *PBlob_Generic_1223;

struct Blob_Generic_1223 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_1229 Blob_Generic_1229, *PBlob_Generic_1229;

struct Blob_Generic_1229 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6915 Blob_Generic_6915, *PBlob_Generic_6915;

struct Blob_Generic_6915 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_9196 Blob_Generic_9196, *PBlob_Generic_9196;

struct Blob_Generic_9196 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_FieldSig_3021 Blob_FieldSig_3021, *PBlob_FieldSig_3021;

typedef struct FieldSig_3021 FieldSig_3021, *PFieldSig_3021;

typedef struct Type_176551 Type_176551, *PType_176551;

struct Type_176551 {
    struct ValueType.conflict7 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_3021 {
    byte FIELD; // Magic (0x06)
    struct Type_176551 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_3021 {
    byte Size; // coded integer - blob size
    struct FieldSig_3021 FieldSig; // Type information for Field
};

typedef struct Blob_PropertySig_1945 Blob_PropertySig_1945, *PBlob_PropertySig_1945;

typedef struct PropertySig_1945 PropertySig_1945, *PPropertySig_1945;

typedef struct Type_175476 Type_175476, *PType_175476;

struct Type_175476 {
    struct GenericInstType_175477 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1945 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175476 RetType; // Return type
};

struct Blob_PropertySig_1945 {
    byte Size; // coded integer - blob size
    struct PropertySig_1945 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_12392 Blob_Generic_12392, *PBlob_Generic_12392;

struct Blob_Generic_12392 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_7333 Blob_Generic_7333, *PBlob_Generic_7333;

struct Blob_Generic_7333 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_16753 Blob_Generic_16753, *PBlob_Generic_16753;

struct Blob_Generic_16753 {
    byte Size; // coded integer - blob size
    byte Generic[33]; // Undefined blob contents
};

typedef struct Blob_Generic_9992 Blob_Generic_9992, *PBlob_Generic_9992;

struct Blob_Generic_9992 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_23046 Blob_Generic_23046, *PBlob_Generic_23046;

struct Blob_Generic_23046 {
    byte Size; // coded integer - blob size
    byte Generic[55]; // Undefined blob contents
};

typedef struct Blob_Generic_9998 Blob_Generic_9998, *PBlob_Generic_9998;

struct Blob_Generic_9998 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1083 Blob_PropertySig_1083, *PBlob_PropertySig_1083;

typedef struct PropertySig_1083 PropertySig_1083, *PPropertySig_1083;

typedef struct Type_174614 Type_174614, *PType_174614;

struct Type_174614 {
    enum TypeCode ELEMENT_TYPE_I8;
};

struct PropertySig_1083 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174614 RetType; // Return type
};

struct Blob_PropertySig_1083 {
    byte Size; // coded integer - blob size
    struct PropertySig_1083 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8668 Blob_Generic_8668, *PBlob_Generic_8668;

struct Blob_Generic_8668 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_FieldSig_3016 Blob_FieldSig_3016, *PBlob_FieldSig_3016;

typedef struct FieldSig_3016 FieldSig_3016, *PFieldSig_3016;

typedef struct Type_176546 Type_176546, *PType_176546;

struct Type_176546 {
    struct ValueType.conflict6 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_3016 {
    byte FIELD; // Magic (0x06)
    struct Type_176546 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_3016 {
    byte Size; // coded integer - blob size
    struct FieldSig_3016 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_51992 Blob_Generic_51992, *PBlob_Generic_51992;

struct Blob_Generic_51992 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_36357 Blob_Generic_36357, *PBlob_Generic_36357;

struct Blob_Generic_36357 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6763 Blob_PropertySig_6763, *PBlob_PropertySig_6763;

typedef struct PropertySig_6763 PropertySig_6763, *PPropertySig_6763;

typedef struct Type_180294 Type_180294, *PType_180294;

struct Type_180294 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6763 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180294 RetType; // Return type
};

struct Blob_PropertySig_6763 {
    byte Size; // coded integer - blob size
    struct PropertySig_6763 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_28737 Blob_Generic_28737, *PBlob_Generic_28737;

struct Blob_Generic_28737 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_3011 Blob_FieldSig_3011, *PBlob_FieldSig_3011;

typedef struct FieldSig_3011 FieldSig_3011, *PFieldSig_3011;

typedef struct Type_176541 Type_176541, *PType_176541;

struct Type_176541 {
    struct ValueType.conflict5 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_3011 {
    byte FIELD; // Magic (0x06)
    struct Type_176541 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_3011 {
    byte Size; // coded integer - blob size
    struct FieldSig_3011 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_41711 Blob_Generic_41711, *PBlob_Generic_41711;

struct Blob_Generic_41711 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6769 Blob_PropertySig_6769, *PBlob_PropertySig_6769;

typedef struct PropertySig_6769 PropertySig_6769, *PPropertySig_6769;

typedef struct Type_180300 Type_180300, *PType_180300;

struct Type_180300 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6769 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180300 RetType; // Return type
};

struct Blob_PropertySig_6769 {
    byte Size; // coded integer - blob size
    struct PropertySig_6769 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_11071 Blob_Generic_11071, *PBlob_Generic_11071;

struct Blob_Generic_11071 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_47005 Blob_Generic_47005, *PBlob_Generic_47005;

struct Blob_Generic_47005 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7341 Blob_Generic_7341, *PBlob_Generic_7341;

struct Blob_Generic_7341 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11079 Blob_Generic_11079, *PBlob_Generic_11079;

struct Blob_Generic_11079 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_15437 Blob_Generic_15437, *PBlob_Generic_15437;

struct Blob_Generic_15437 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_50654 Blob_Generic_50654, *PBlob_Generic_50654;

struct Blob_Generic_50654 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_8678 Blob_Generic_8678, *PBlob_Generic_8678;

struct Blob_Generic_8678 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_6016 Blob_Generic_6016, *PBlob_Generic_6016;

struct Blob_Generic_6016 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_7349 Blob_Generic_7349, *PBlob_Generic_7349;

struct Blob_Generic_7349 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_FieldSig_3006 Blob_FieldSig_3006, *PBlob_FieldSig_3006;

typedef struct FieldSig_3006 FieldSig_3006, *PFieldSig_3006;

typedef struct Type_176536 Type_176536, *PType_176536;

struct Type_176536 {
    struct ValueType.conflict4 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_3006 {
    byte FIELD; // Magic (0x06)
    struct Type_176536 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_3006 {
    byte Size; // coded integer - blob size
    struct FieldSig_3006 FieldSig; // Type information for Field
};

typedef struct Blob_ConstantSig_12887.conflict Blob_ConstantSig_12887.conflict, *PBlob_ConstantSig_12887.conflict;

typedef struct ConstantSig_12887.conflict ConstantSig_12887.conflict, *PConstantSig_12887.conflict;

struct ConstantSig_12887.conflict {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12887.conflict {
    byte Size; // coded integer - blob size
    struct ConstantSig_12887.conflict ConstantSig; // Data stored in a constant
};

typedef struct Blob_PropertySig_5447 Blob_PropertySig_5447, *PBlob_PropertySig_5447;

typedef struct PropertySig_5447 PropertySig_5447, *PPropertySig_5447;

typedef struct Type_178978 Type_178978, *PType_178978;

struct Type_178978 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_5447 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178978 RetType; // Return type
};

struct Blob_PropertySig_5447 {
    byte Size; // coded integer - blob size
    struct PropertySig_5447 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_24385 Blob_Generic_24385, *PBlob_Generic_24385;

struct Blob_Generic_24385 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_35039 Blob_Generic_35039, *PBlob_Generic_35039;

struct Blob_Generic_35039 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_3001 Blob_FieldSig_3001, *PBlob_FieldSig_3001;

typedef struct FieldSig_3001 FieldSig_3001, *PFieldSig_3001;

typedef struct Type_176531 Type_176531, *PType_176531;

struct Type_176531 {
    struct ValueType.conflict3 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_3001 {
    byte FIELD; // Magic (0x06)
    struct Type_176531 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_3001 {
    byte Size; // coded integer - blob size
    struct FieldSig_3001 FieldSig; // Type information for Field
};

typedef struct Blob_PropertySig_12462 Blob_PropertySig_12462, *PBlob_PropertySig_12462;

typedef struct PropertySig_12462 PropertySig_12462, *PPropertySig_12462;

typedef struct Type_185993 Type_185993, *PType_185993;

struct Type_185993 {
    struct GenericInstType_185994 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_12462 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185993 RetType; // Return type
};

struct Blob_PropertySig_12462 {
    byte Size; // coded integer - blob size
    struct PropertySig_12462 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_6024 Blob_Generic_6024, *PBlob_Generic_6024;

struct Blob_Generic_6024 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11040 Blob_Generic_11040, *PBlob_Generic_11040;

struct Blob_Generic_11040 {
    byte Size; // coded integer - blob size
    byte Generic[30]; // Undefined blob contents
};

typedef struct Blob_Generic_12372 Blob_Generic_12372, *PBlob_Generic_12372;

struct Blob_Generic_12372 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11126 Blob_PropertySig_11126, *PBlob_PropertySig_11126;

typedef struct PropertySig_11126 PropertySig_11126, *PPropertySig_11126;

typedef struct Type_184657 Type_184657, *PType_184657;

struct Type_184657 {
    struct GenericInstType_184658 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11126 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184657 RetType; // Return type
};

struct Blob_PropertySig_11126 {
    byte Size; // coded integer - blob size
    struct PropertySig_11126 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8688 Blob_Generic_8688, *PBlob_Generic_8688;

struct Blob_Generic_8688 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6745 Blob_PropertySig_6745, *PBlob_PropertySig_6745;

typedef struct PropertySig_6745 PropertySig_6745, *PPropertySig_6745;

typedef struct Type_180276 Type_180276, *PType_180276;

struct Type_180276 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6745 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180276 RetType; // Return type
};

struct Blob_PropertySig_6745 {
    byte Size; // coded integer - blob size
    struct PropertySig_6745 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_51971 Blob_Generic_51971, *PBlob_Generic_51971;

struct Blob_Generic_51971 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_36336 Blob_Generic_36336, *PBlob_Generic_36336;

struct Blob_Generic_36336 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2387 Blob_PropertySig_2387, *PBlob_PropertySig_2387;

typedef struct PropertySig_2387 PropertySig_2387, *PPropertySig_2387;

typedef struct Type_175918 Type_175918, *PType_175918;

struct Type_175918 {
    struct SzArray_175919 ELEMENT_TYPE_SZARRAY;
};

struct PropertySig_2387 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175918 RetType; // Return type
};

struct Blob_PropertySig_2387 {
    byte Size; // coded integer - blob size
    struct PropertySig_2387 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_37661 Blob_Generic_37661, *PBlob_Generic_37661;

struct Blob_Generic_37661 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_28716 Blob_Generic_28716, *PBlob_Generic_28716;

struct Blob_Generic_28716 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12385 Blob_Generic_12385, *PBlob_Generic_12385;

struct Blob_Generic_12385 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_38993 Blob_Generic_38993, *PBlob_Generic_38993;

struct Blob_Generic_38993 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_49647 Blob_Generic_49647, *PBlob_Generic_49647;

struct Blob_Generic_49647 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_6032 Blob_Generic_6032, *PBlob_Generic_6032;

struct Blob_Generic_6032 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_7363 Blob_Generic_7363, *PBlob_Generic_7363;

struct Blob_Generic_7363 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_48315 Blob_Generic_48315, *PBlob_Generic_48315;

struct Blob_Generic_48315 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_15416 Blob_Generic_15416, *PBlob_Generic_15416;

struct Blob_Generic_15416 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7369 Blob_Generic_7369, *PBlob_Generic_7369;

struct Blob_Generic_7369 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_25694 Blob_Generic_25694, *PBlob_Generic_25694;

struct Blob_Generic_25694 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_24364 Blob_Generic_24364, *PBlob_Generic_24364;

struct Blob_Generic_24364 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6751 Blob_PropertySig_6751, *PBlob_PropertySig_6751;

typedef struct PropertySig_6751 PropertySig_6751, *PPropertySig_6751;

typedef struct Type_180282 Type_180282, *PType_180282;

struct Type_180282 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6751 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180282 RetType; // Return type
};

struct Blob_PropertySig_6751 {
    byte Size; // coded integer - blob size
    struct PropertySig_6751 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_6757 Blob_PropertySig_6757, *PBlob_PropertySig_6757;

typedef struct PropertySig_6757 PropertySig_6757, *PPropertySig_6757;

typedef struct Type_180288 Type_180288, *PType_180288;

struct Type_180288 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6757 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180288 RetType; // Return type
};

struct Blob_PropertySig_6757 {
    byte Size; // coded integer - blob size
    struct PropertySig_6757 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_7375 Blob_Generic_7375, *PBlob_Generic_7375;

struct Blob_Generic_7375 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_14132 Blob_Generic_14132, *PBlob_Generic_14132;

struct Blob_Generic_14132 {
    byte Size; // coded integer - blob size
    byte Generic[33]; // Undefined blob contents
};

typedef struct Blob_Generic_41753 Blob_Generic_41753, *PBlob_Generic_41753;

struct Blob_Generic_41753 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_38106 Blob_Generic_38106, *PBlob_Generic_38106;

struct Blob_Generic_38106 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_26117 Blob_Generic_26117, *PBlob_Generic_26117;

struct Blob_Generic_26117 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_20812 Blob_Generic_20812, *PBlob_Generic_20812;

struct Blob_Generic_20812 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_35081 Blob_Generic_35081, *PBlob_Generic_35081;

struct Blob_Generic_35081 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7384 Blob_Generic_7384, *PBlob_Generic_7384;

struct Blob_Generic_7384 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_18509 Blob_Generic_18509, *PBlob_Generic_18509;

struct Blob_Generic_18509 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_39428 Blob_Generic_39428, *PBlob_Generic_39428;

struct Blob_Generic_39428 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_50690 Blob_Generic_50690, *PBlob_Generic_50690;

struct Blob_Generic_50690 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_27459 Blob_Generic_27459, *PBlob_Generic_27459;

struct Blob_Generic_27459 {
    byte Size; // coded integer - blob size
    byte Generic[36]; // Undefined blob contents
};

typedef struct Blob_Generic_7392 Blob_Generic_7392, *PBlob_Generic_7392;

struct Blob_Generic_7392 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_40417 Blob_Generic_40417, *PBlob_Generic_40417;

struct Blob_Generic_40417 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41732 Blob_Generic_41732, *PBlob_Generic_41732;

struct Blob_Generic_41732 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11087 Blob_Generic_11087, *PBlob_Generic_11087;

struct Blob_Generic_11087 {
    byte Size; // coded integer - blob size
    byte Generic[28]; // Undefined blob contents
};

typedef struct Blob_Generic_6065 Blob_Generic_6065, *PBlob_Generic_6065;

struct Blob_Generic_6065 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_49696 Blob_Generic_49696, *PBlob_Generic_49696;

struct Blob_Generic_49696 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19804 Blob_Generic_19804, *PBlob_Generic_19804;

struct Blob_Generic_19804 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_48361 Blob_Generic_48361, *PBlob_Generic_48361;

struct Blob_Generic_48361 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_28758 Blob_Generic_28758, *PBlob_Generic_28758;

struct Blob_Generic_28758 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_36378 Blob_Generic_36378, *PBlob_Generic_36378;

struct Blob_Generic_36378 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_6071 Blob_Generic_6071, *PBlob_Generic_6071;

struct Blob_Generic_6071 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6077 Blob_Generic_6077, *PBlob_Generic_6077;

struct Blob_Generic_6077 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_35060 Blob_Generic_35060, *PBlob_Generic_35060;

struct Blob_Generic_35060 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9104 Blob_Generic_9104, *PBlob_Generic_9104;

struct Blob_Generic_9104 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_16787 Blob_Generic_16787, *PBlob_Generic_16787;

struct Blob_Generic_16787 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_12402 Blob_PropertySig_12402, *PBlob_PropertySig_12402;

typedef struct PropertySig_12402 PropertySig_12402, *PPropertySig_12402;

typedef struct Type_185933 Type_185933, *PType_185933;

struct Type_185933 {
    struct GenericInstType_185934 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_12402 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185933 RetType; // Return type
};

struct Blob_PropertySig_12402 {
    byte Size; // coded integer - blob size
    struct PropertySig_12402 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_47026 Blob_Generic_47026, *PBlob_Generic_47026;

struct Blob_Generic_47026 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_3803 Blob_Generic_3803, *PBlob_Generic_3803;

struct Blob_Generic_3803 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4131 Blob_PropertySig_4131, *PBlob_PropertySig_4131;

typedef struct PropertySig_4131 PropertySig_4131, *PPropertySig_4131;

typedef struct Type_177662 Type_177662, *PType_177662;

struct Type_177662 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4131 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177662 RetType; // Return type
};

struct Blob_PropertySig_4131 {
    byte Size; // coded integer - blob size
    struct PropertySig_4131 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_4137 Blob_PropertySig_4137, *PBlob_PropertySig_4137;

typedef struct PropertySig_4137 PropertySig_4137, *PPropertySig_4137;

typedef struct Type_177668 Type_177668, *PType_177668;

struct Type_177668 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4137 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177668 RetType; // Return type
};

struct Blob_PropertySig_4137 {
    byte Size; // coded integer - blob size
    struct PropertySig_4137 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_27438 Blob_Generic_27438, *PBlob_Generic_27438;

struct Blob_Generic_27438 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6882 Blob_Generic_6882, *PBlob_Generic_6882;

struct Blob_Generic_6882 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_1195 Blob_Generic_1195, *PBlob_Generic_1195;

struct Blob_Generic_1195 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_4221 Blob_Generic_4221, *PBlob_Generic_4221;

struct Blob_Generic_4221 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5552 Blob_Generic_5552, *PBlob_Generic_5552;

struct Blob_Generic_5552 {
    byte Size; // coded integer - blob size
    byte Generic[16]; // Undefined blob contents
};

typedef struct Blob_Generic_143 Blob_Generic_143, *PBlob_Generic_143;

struct Blob_Generic_143 {
    byte Size; // coded integer - blob size
    byte Generic[16]; // Undefined blob contents
};

typedef struct Blob_Generic_21268 Blob_Generic_21268, *PBlob_Generic_21268;

struct Blob_Generic_21268 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_9914 Blob_Generic_9914, *PBlob_Generic_9914;

struct Blob_Generic_9914 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12311 Blob_Generic_12311, *PBlob_Generic_12311;

struct Blob_Generic_12311 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12319 Blob_Generic_12319, *PBlob_Generic_12319;

struct Blob_Generic_12319 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6892 Blob_Generic_6892, *PBlob_Generic_6892;

struct Blob_Generic_6892 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_133 Blob_Generic_133, *PBlob_Generic_133;

struct Blob_Generic_133 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_4230 Blob_Generic_4230, *PBlob_Generic_4230;

struct Blob_Generic_4230 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_38930 Blob_Generic_38930, *PBlob_Generic_38930;

struct Blob_Generic_38930 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_47883 Blob_Generic_47883, *PBlob_Generic_47883;

struct Blob_Generic_47883 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_12327 Blob_Generic_12327, *PBlob_Generic_12327;

struct Blob_Generic_12327 {
    byte Size; // coded integer - blob size
    byte Generic[17]; // Undefined blob contents
};

typedef struct Blob_Generic_4239 Blob_Generic_4239, *PBlob_Generic_4239;

struct Blob_Generic_4239 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5569 Blob_Generic_5569, *PBlob_Generic_5569;

struct Blob_Generic_5569 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_138 Blob_Generic_138, *PBlob_Generic_138;

struct Blob_Generic_138 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_9922 Blob_Generic_9922, *PBlob_Generic_9922;

struct Blob_Generic_9922 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_13659 Blob_Generic_13659, *PBlob_Generic_13659;

struct Blob_Generic_13659 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_37619 Blob_Generic_37619, *PBlob_Generic_37619;

struct Blob_Generic_37619 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_33256 Blob_Generic_33256, *PBlob_Generic_33256;

struct Blob_Generic_33256 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9928 Blob_Generic_9928, *PBlob_Generic_9928;

struct Blob_Generic_9928 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_34589 Blob_Generic_34589, *PBlob_Generic_34589;

struct Blob_Generic_34589 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_26964 Blob_Generic_26964, *PBlob_Generic_26964;

struct Blob_Generic_26964 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25634 Blob_Generic_25634, *PBlob_Generic_25634;

struct Blob_Generic_25634 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_10591 Blob_Generic_10591, *PBlob_Generic_10591;

struct Blob_Generic_10591 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_46543 Blob_Generic_46543, *PBlob_Generic_46543;

struct Blob_Generic_46543 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_4246 Blob_Generic_4246, *PBlob_Generic_4246;

struct Blob_Generic_4246 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_124 Blob_Generic_124, *PBlob_Generic_124;

struct Blob_Generic_124 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10597 Blob_Generic_10597, *PBlob_Generic_10597;

struct Blob_Generic_10597 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_8600 Blob_Generic_8600, *PBlob_Generic_8600;

struct Blob_Generic_8600 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_9934 Blob_Generic_9934, *PBlob_Generic_9934;

struct Blob_Generic_9934 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5579 Blob_Generic_5579, *PBlob_Generic_5579;

struct Blob_Generic_5579 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_42183 Blob_Generic_42183, *PBlob_Generic_42183;

struct Blob_Generic_42183 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_35888 Blob_Generic_35888, *PBlob_Generic_35888;

struct Blob_Generic_35888 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2302 Blob_PropertySig_2302, *PBlob_PropertySig_2302;

typedef struct PropertySig_2302 PropertySig_2302, *PPropertySig_2302;

typedef struct Type_175833 Type_175833, *PType_175833;

struct Type_175833 {
    struct GenericInstType_175834 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2302 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175833 RetType; // Return type
};

struct Blob_PropertySig_2302 {
    byte Size; // coded integer - blob size
    struct PropertySig_2302 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_25602 Blob_Generic_25602, *PBlob_Generic_25602;

struct Blob_Generic_25602 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_25618 Blob_Generic_25618, *PBlob_Generic_25618;

struct Blob_Generic_25618 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_8610 Blob_Generic_8610, *PBlob_Generic_8610;

struct Blob_Generic_8610 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_9940 Blob_Generic_9940, *PBlob_Generic_9940;

struct Blob_Generic_9940 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_45208 Blob_Generic_45208, *PBlob_Generic_45208;

struct Blob_Generic_45208 {
    byte Size; // coded integer - blob size
    byte Generic[71]; // Undefined blob contents
};

typedef struct Blob_Generic_110 Blob_Generic_110, *PBlob_Generic_110;

struct Blob_Generic_110 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_4253 Blob_Generic_4253, *PBlob_Generic_4253;

struct Blob_Generic_4253 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_115 Blob_Generic_115, *PBlob_Generic_115;

struct Blob_Generic_115 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5589 Blob_Generic_5589, *PBlob_Generic_5589;

struct Blob_Generic_5589 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_9946 Blob_Generic_9946, *PBlob_Generic_9946;

struct Blob_Generic_9946 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_22582 Blob_Generic_22582, *PBlob_Generic_22582;

struct Blob_Generic_22582 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_47862 Blob_Generic_47862, *PBlob_Generic_47862;

struct Blob_Generic_47862 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2312 Blob_PropertySig_2312, *PBlob_PropertySig_2312;

typedef struct PropertySig_2312 PropertySig_2312, *PPropertySig_2312;

typedef struct Type_175843 Type_175843, *PType_175843;

struct Type_175843 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_2312 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175843 RetType; // Return type
};

struct Blob_PropertySig_2312 {
    byte Size; // coded integer - blob size
    struct PropertySig_2312 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_4260 Blob_Generic_4260, *PBlob_Generic_4260;

struct Blob_Generic_4260 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_9952 Blob_Generic_9952, *PBlob_Generic_9952;

struct Blob_Generic_9952 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_8620 Blob_Generic_8620, *PBlob_Generic_8620;

struct Blob_Generic_8620 {
    byte Size; // coded integer - blob size
    byte Generic[16]; // Undefined blob contents
};

typedef struct Blob_Generic_13680 Blob_Generic_13680, *PBlob_Generic_13680;

struct Blob_Generic_13680 {
    byte Size; // coded integer - blob size
    byte Generic[28]; // Undefined blob contents
};

typedef struct Blob_Generic_11020 Blob_Generic_11020, *PBlob_Generic_11020;

struct Blob_Generic_11020 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_12351 Blob_Generic_12351, *PBlob_Generic_12351;

struct Blob_Generic_12351 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9958 Blob_Generic_9958, *PBlob_Generic_9958;

struct Blob_Generic_9958 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5599 Blob_Generic_5599, *PBlob_Generic_5599;

struct Blob_Generic_5599 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_16713 Blob_Generic_16713, *PBlob_Generic_16713;

struct Blob_Generic_16713 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_4267 Blob_Generic_4267, *PBlob_Generic_4267;

struct Blob_Generic_4267 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_12357 Blob_Generic_12357, *PBlob_Generic_12357;

struct Blob_Generic_12357 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_45280 Blob_Generic_45280, *PBlob_Generic_45280;

struct Blob_Generic_45280 {
    byte Size; // coded integer - blob size
    byte Generic[71]; // Undefined blob contents
};

typedef struct Blob_Generic_51950 Blob_Generic_51950, *PBlob_Generic_51950;

struct Blob_Generic_51950 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_12003 Blob_FieldSig_12003, *PBlob_FieldSig_12003;

typedef struct FieldSig_12003 FieldSig_12003, *PFieldSig_12003;

typedef struct Type_185533 Type_185533, *PType_185533;

struct Type_185533 {
    struct ValueType.conflict43 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_12003 {
    byte FIELD; // Magic (0x06)
    struct Type_185533 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_12003 {
    byte Size; // coded integer - blob size
    struct FieldSig_12003 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_37640 Blob_Generic_37640, *PBlob_Generic_37640;

struct Blob_Generic_37640 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_190 Blob_Generic_190, *PBlob_Generic_190;

struct Blob_Generic_190 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6727 Blob_PropertySig_6727, *PBlob_PropertySig_6727;

typedef struct PropertySig_6727 PropertySig_6727, *PPropertySig_6727;

typedef struct Type_180258 Type_180258, *PType_180258;

struct Type_180258 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6727 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180258 RetType; // Return type
};

struct Blob_PropertySig_6727 {
    byte Size; // coded integer - blob size
    struct PropertySig_6727 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_11184 Blob_PropertySig_11184, *PBlob_PropertySig_11184;

typedef struct PropertySig_11184 PropertySig_11184, *PPropertySig_11184;

typedef struct Type_184715 Type_184715, *PType_184715;

struct Type_184715 {
    struct ValueType.conflict38 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_11184 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184715 RetType; // Return type
};

struct Blob_PropertySig_11184 {
    byte Size; // coded integer - blob size
    struct PropertySig_11184 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_4272 Blob_Generic_4272, *PBlob_Generic_4272;

struct Blob_Generic_4272 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_7301 Blob_Generic_7301, *PBlob_Generic_7301;

struct Blob_Generic_7301 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_11030 Blob_Generic_11030, *PBlob_Generic_11030;

struct Blob_Generic_11030 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_38972 Blob_Generic_38972, *PBlob_Generic_38972;

struct Blob_Generic_38972 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_49626 Blob_Generic_49626, *PBlob_Generic_49626;

struct Blob_Generic_49626 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_174 Blob_Generic_174, *PBlob_Generic_174;

struct Blob_Generic_174 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_8637 Blob_Generic_8637, *PBlob_Generic_8637;

struct Blob_Generic_8637 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4277 Blob_Generic_4277, *PBlob_Generic_4277;

struct Blob_Generic_4277 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_9967 Blob_Generic_9967, *PBlob_Generic_9967;

struct Blob_Generic_9967 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6733 Blob_PropertySig_6733, *PBlob_PropertySig_6733;

typedef struct PropertySig_6733 PropertySig_6733, *PPropertySig_6733;

typedef struct Type_180264 Type_180264, *PType_180264;

struct Type_180264 {
    struct ValueType.conflict15 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_6733 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180264 RetType; // Return type
};

struct Blob_PropertySig_6733 {
    byte Size; // coded integer - blob size
    struct PropertySig_6733 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_25673 Blob_Generic_25673, *PBlob_Generic_25673;

struct Blob_Generic_25673 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6739 Blob_PropertySig_6739, *PBlob_PropertySig_6739;

typedef struct PropertySig_6739 PropertySig_6739, *PPropertySig_6739;

typedef struct Type_180270 Type_180270, *PType_180270;

struct Type_180270 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6739 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180270 RetType; // Return type
};

struct Blob_PropertySig_6739 {
    byte Size; // coded integer - blob size
    struct PropertySig_6739 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_33298 Blob_Generic_33298, *PBlob_Generic_33298;

struct Blob_Generic_33298 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4282 Blob_Generic_4282, *PBlob_Generic_4282;

struct Blob_Generic_4282 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_160 Blob_Generic_160, *PBlob_Generic_160;

struct Blob_Generic_160 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_7311 Blob_Generic_7311, *PBlob_Generic_7311;

struct Blob_Generic_7311 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9974 Blob_Generic_9974, *PBlob_Generic_9974;

struct Blob_Generic_9974 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_50609 Blob_Generic_50609, *PBlob_Generic_50609;

struct Blob_Generic_50609 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_14994 Blob_Generic_14994, *PBlob_Generic_14994;

struct Blob_Generic_14994 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7317 Blob_Generic_7317, *PBlob_Generic_7317;

struct Blob_Generic_7317 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_167 Blob_Generic_167, *PBlob_Generic_167;

struct Blob_Generic_167 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_8645 Blob_Generic_8645, *PBlob_Generic_8645;

struct Blob_Generic_8645 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11009 Blob_Generic_11009, *PBlob_Generic_11009;

struct Blob_Generic_11009 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1016 Blob_PropertySig_1016, *PBlob_PropertySig_1016;

typedef struct PropertySig_1016 PropertySig_1016, *PPropertySig_1016;

typedef struct Type_174547 Type_174547, *PType_174547;

struct Type_174547 {
    enum TypeCode ELEMENT_TYPE_I4;
};

struct PropertySig_1016 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174547 RetType; // Return type
};

struct Blob_PropertySig_1016 {
    byte Size; // coded integer - blob size
    struct PropertySig_1016 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_24317 Blob_Generic_24317, *PBlob_Generic_24317;

struct Blob_Generic_24317 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_4291 Blob_Generic_4291, *PBlob_Generic_4291;

struct Blob_Generic_4291 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_8653 Blob_Generic_8653, *PBlob_Generic_8653;

struct Blob_Generic_8653 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_51929 Blob_Generic_51929, *PBlob_Generic_51929;

struct Blob_Generic_51929 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4298 Blob_Generic_4298, *PBlob_Generic_4298;

struct Blob_Generic_4298 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_38951 Blob_Generic_38951, *PBlob_Generic_38951;

struct Blob_Generic_38951 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9980 Blob_Generic_9980, *PBlob_Generic_9980;

struct Blob_Generic_9980 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12345 Blob_Generic_12345, *PBlob_Generic_12345;

struct Blob_Generic_12345 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9986 Blob_Generic_9986, *PBlob_Generic_9986;

struct Blob_Generic_9986 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_33277 Blob_Generic_33277, *PBlob_Generic_33277;

struct Blob_Generic_33277 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_26985 Blob_Generic_26985, *PBlob_Generic_26985;

struct Blob_Generic_26985 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_36300 Blob_Generic_36300, *PBlob_Generic_36300;

struct Blob_Generic_36300 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_22632 Blob_Generic_22632, *PBlob_Generic_22632;

struct Blob_Generic_22632 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_46601 Blob_Generic_46601, *PBlob_Generic_46601;

struct Blob_Generic_46601 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6800 Blob_Generic_6800, *PBlob_Generic_6800;

struct Blob_Generic_6800 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_FieldSig_11998 Blob_FieldSig_11998, *PBlob_FieldSig_11998;

typedef struct FieldSig_11998 FieldSig_11998, *PFieldSig_11998;

typedef struct Type_185528 Type_185528, *PType_185528;

struct Type_185528 {
    struct ValueType.conflict42 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_11998 {
    byte FIELD; // Magic (0x06)
    struct Type_185528 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_11998 {
    byte Size; // coded integer - blob size
    struct FieldSig_11998 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_11983 Blob_Generic_11983, *PBlob_Generic_11983;

struct Blob_Generic_11983 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_1115 Blob_Generic_1115, *PBlob_Generic_1115;

struct Blob_Generic_1115 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3777 Blob_Generic_3777, *PBlob_Generic_3777;

struct Blob_Generic_3777 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2444 Blob_Generic_2444, *PBlob_Generic_2444;

struct Blob_Generic_2444 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11988 Blob_Generic_11988, *PBlob_Generic_11988;

struct Blob_Generic_11988 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_10659 Blob_Generic_10659, *PBlob_Generic_10659;

struct Blob_Generic_10659 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_34610 Blob_Generic_34610, *PBlob_Generic_34610;

struct Blob_Generic_34610 {
    byte Size; // coded integer - blob size
    byte Generic[37]; // Undefined blob contents
};

typedef struct Blob_Generic_6805 Blob_Generic_6805, *PBlob_Generic_6805;

struct Blob_Generic_6805 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_FieldSig_11993 Blob_FieldSig_11993, *PBlob_FieldSig_11993;

typedef struct FieldSig_11993 FieldSig_11993, *PFieldSig_11993;

typedef struct Type_185523 Type_185523, *PType_185523;

struct Type_185523 {
    struct ValueType.conflict41 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_11993 {
    byte FIELD; // Magic (0x06)
    struct Type_185523 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_11993 {
    byte Size; // coded integer - blob size
    struct FieldSig_11993 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_30250 Blob_Generic_30250, *PBlob_Generic_30250;

struct Blob_Generic_30250 {
    byte Size; // coded integer - blob size
    byte Generic[55]; // Undefined blob contents
};

typedef struct Blob_Generic_9080 Blob_Generic_9080, *PBlob_Generic_9080;

struct Blob_Generic_9080 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1879 Blob_PropertySig_1879, *PBlob_PropertySig_1879;

typedef struct PropertySig_1879 PropertySig_1879, *PPropertySig_1879;

typedef struct Type_175410 Type_175410, *PType_175410;

struct Type_175410 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_1879 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175410 RetType; // Return type
};

struct Blob_PropertySig_1879 {
    byte Size; // coded integer - blob size
    struct PropertySig_1879 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_47937 Blob_Generic_47937, *PBlob_Generic_47937;

struct Blob_Generic_47937 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_23977 Blob_Generic_23977, *PBlob_Generic_23977;

struct Blob_Generic_23977 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_Generic_43567 Blob_Generic_43567, *PBlob_Generic_43567;

struct Blob_Generic_43567 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_892 Blob_Generic_892, *PBlob_Generic_892;

struct Blob_Generic_892 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_2450 Blob_Generic_2450, *PBlob_Generic_2450;

struct Blob_Generic_2450 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9087 Blob_Generic_9087, *PBlob_Generic_9087;

struct Blob_Generic_9087 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_11993 Blob_Generic_11993, *PBlob_Generic_11993;

struct Blob_Generic_11993 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3783 Blob_Generic_3783, *PBlob_Generic_3783;

struct Blob_Generic_3783 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_899 Blob_Generic_899, *PBlob_Generic_899;

struct Blob_Generic_899 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11998 Blob_Generic_11998, *PBlob_Generic_11998;

struct Blob_Generic_11998 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_1125 Blob_Generic_1125, *PBlob_Generic_1125;

struct Blob_Generic_1125 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2456 Blob_Generic_2456, *PBlob_Generic_2456;

struct Blob_Generic_2456 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6810 Blob_Generic_6810, *PBlob_Generic_6810;

struct Blob_Generic_6810 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_10669 Blob_Generic_10669, *PBlob_Generic_10669;

struct Blob_Generic_10669 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_31599 Blob_Generic_31599, *PBlob_Generic_31599;

struct Blob_Generic_31599 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_29277 Blob_Generic_29277, *PBlob_Generic_29277;

struct Blob_Generic_29277 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_6815 Blob_Generic_6815, *PBlob_Generic_6815;

struct Blob_Generic_6815 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_9094 Blob_Generic_9094, *PBlob_Generic_9094;

struct Blob_Generic_9094 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_253 Blob_PropertySig_253, *PBlob_PropertySig_253;

typedef struct PropertySig_253 PropertySig_253, *PPropertySig_253;

typedef struct Type_173784 Type_173784, *PType_173784;

struct Type_173784 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_253 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173784 RetType; // Return type
};

struct Blob_PropertySig_253 {
    byte Size; // coded integer - blob size
    struct PropertySig_253 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_3791 Blob_Generic_3791, *PBlob_Generic_3791;

struct Blob_Generic_3791 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_42225 Blob_Generic_42225, *PBlob_Generic_42225;

struct Blob_Generic_42225 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_1133 Blob_Generic_1133, *PBlob_Generic_1133;

struct Blob_Generic_1133 {
    byte Size; // coded integer - blob size
    byte Generic[2]; // Undefined blob contents
};

typedef struct Blob_Generic_2462 Blob_Generic_2462, *PBlob_Generic_2462;

struct Blob_Generic_2462 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_6825 Blob_Generic_6825, *PBlob_Generic_6825;

struct Blob_Generic_6825 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_6820 Blob_Generic_6820, *PBlob_Generic_6820;

struct Blob_Generic_6820 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_1136 Blob_Generic_1136, *PBlob_Generic_1136;

struct Blob_Generic_1136 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3797 Blob_Generic_3797, *PBlob_Generic_3797;

struct Blob_Generic_3797 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10635 Blob_Generic_10635, *PBlob_Generic_10635;

struct Blob_Generic_10635 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_17274 Blob_Generic_17274, *PBlob_Generic_17274;

struct Blob_Generic_17274 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_1141 Blob_Generic_1141, *PBlob_Generic_1141;

struct Blob_Generic_1141 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_6835 Blob_Generic_6835, *PBlob_Generic_6835;

struct Blob_Generic_6835 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2474 Blob_Generic_2474, *PBlob_Generic_2474;

struct Blob_Generic_2474 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6830 Blob_Generic_6830, *PBlob_Generic_6830;

struct Blob_Generic_6830 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7173 Blob_PropertySig_7173, *PBlob_PropertySig_7173;

typedef struct PropertySig_7173 PropertySig_7173, *PPropertySig_7173;

typedef struct Type_180704 Type_180704, *PType_180704;

struct Type_180704 {
    struct GenericInstType_180705 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_7173 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180704 RetType; // Return type
};

struct Blob_PropertySig_7173 {
    byte Size; // coded integer - blob size
    struct PropertySig_7173 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_10648 Blob_Generic_10648, *PBlob_Generic_10648;

struct Blob_Generic_10648 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_31578 Blob_Generic_31578, *PBlob_Generic_31578;

struct Blob_Generic_31578 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_231 Blob_PropertySig_231, *PBlob_PropertySig_231;

typedef struct PropertySig_231 PropertySig_231, *PPropertySig_231;

typedef struct Type_173762 Type_173762, *PType_173762;

struct Type_173762 {
    enum TypeCode ELEMENT_TYPE_R8;
};

struct PropertySig_231 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173762 RetType; // Return type
};

struct Blob_PropertySig_231 {
    byte Size; // coded integer - blob size
    struct PropertySig_231 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1151 Blob_Generic_1151, *PBlob_Generic_1151;

struct Blob_Generic_1151 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_2482 Blob_Generic_2482, *PBlob_Generic_2482;

struct Blob_Generic_2482 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_46643 Blob_Generic_46643, *PBlob_Generic_46643;

struct Blob_Generic_46643 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_22674 Blob_Generic_22674, *PBlob_Generic_22674;

struct Blob_Generic_22674 {
    byte Size; // coded integer - blob size
    byte Generic[63]; // Undefined blob contents
};

typedef struct Blob_Generic_5511 Blob_Generic_5511, *PBlob_Generic_5511;

struct Blob_Generic_5511 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_6841 Blob_Generic_6841, *PBlob_Generic_6841;

struct Blob_Generic_6841 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6849 Blob_Generic_6849, *PBlob_Generic_6849;

struct Blob_Generic_6849 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2490 Blob_Generic_2490, *PBlob_Generic_2490;

struct Blob_Generic_2490 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_19036 Blob_Generic_19036, *PBlob_Generic_19036;

struct Blob_Generic_19036 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_1161 Blob_Generic_1161, *PBlob_Generic_1161;

struct Blob_Generic_1161 {
    byte Size; // coded integer - blob size
    byte Generic[17]; // Undefined blob contents
};

typedef struct Blob_Generic_13730 Blob_Generic_13730, *PBlob_Generic_13730;

struct Blob_Generic_13730 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_5521 Blob_Generic_5521, *PBlob_Generic_5521;

struct Blob_Generic_5521 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6857 Blob_Generic_6857, *PBlob_Generic_6857;

struct Blob_Generic_6857 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12402 Blob_Generic_12402, *PBlob_Generic_12402;

struct Blob_Generic_12402 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_5527 Blob_Generic_5527, *PBlob_Generic_5527;

struct Blob_Generic_5527 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_42272 Blob_Generic_42272, *PBlob_Generic_42272;

struct Blob_Generic_42272 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_34669 Blob_Generic_34669, *PBlob_Generic_34669;

struct Blob_Generic_34669 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25715 Blob_Generic_25715, *PBlob_Generic_25715;

struct Blob_Generic_25715 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_21325 Blob_Generic_21325, *PBlob_Generic_21325;

struct Blob_Generic_21325 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_22653 Blob_Generic_22653, *PBlob_Generic_22653;

struct Blob_Generic_22653 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_46622 Blob_Generic_46622, *PBlob_Generic_46622;

struct Blob_Generic_46622 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4203 Blob_Generic_4203, *PBlob_Generic_4203;

struct Blob_Generic_4203 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5533 Blob_Generic_5533, *PBlob_Generic_5533;

struct Blob_Generic_5533 {
    byte Size; // coded integer - blob size
    byte Generic[18]; // Undefined blob contents
};

typedef struct Blob_Generic_6863 Blob_Generic_6863, *PBlob_Generic_6863;

struct Blob_Generic_6863 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_1179 Blob_Generic_1179, *PBlob_Generic_1179;

struct Blob_Generic_1179 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10679 Blob_Generic_10679, *PBlob_Generic_10679;

struct Blob_Generic_10679 {
    byte Size; // coded integer - blob size
    byte Generic[21]; // Undefined blob contents
};

typedef struct Blob_Generic_13709 Blob_Generic_13709, *PBlob_Generic_13709;

struct Blob_Generic_13709 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_35964 Blob_Generic_35964, *PBlob_Generic_35964;

struct Blob_Generic_35964 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_43588 Blob_Generic_43588, *PBlob_Generic_43588;

struct Blob_Generic_43588 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6870 Blob_Generic_6870, *PBlob_Generic_6870;

struct Blob_Generic_6870 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9902 Blob_Generic_9902, *PBlob_Generic_9902;

struct Blob_Generic_9902 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4212 Blob_Generic_4212, *PBlob_Generic_4212;

struct Blob_Generic_4212 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_1187 Blob_Generic_1187, *PBlob_Generic_1187;

struct Blob_Generic_1187 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_33319 Blob_Generic_33319, *PBlob_Generic_33319;

struct Blob_Generic_33319 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_6876 Blob_Generic_6876, *PBlob_Generic_6876;

struct Blob_Generic_6876 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_34648 Blob_Generic_34648, *PBlob_Generic_34648;

struct Blob_Generic_34648 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9908 Blob_Generic_9908, *PBlob_Generic_9908;

struct Blob_Generic_9908 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_39474 Blob_Generic_39474, *PBlob_Generic_39474;

struct Blob_Generic_39474 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41792 Blob_Generic_41792, *PBlob_Generic_41792;

struct Blob_Generic_41792 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18530 Blob_Generic_18530, *PBlob_Generic_18530;

struct Blob_Generic_18530 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11787 Blob_PropertySig_11787, *PBlob_PropertySig_11787;

typedef struct PropertySig_11787 PropertySig_11787, *PPropertySig_11787;

typedef struct Type_185318 Type_185318, *PType_185318;

struct Type_185318 {
    struct GenericInstType_185319 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11787 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185318 RetType; // Return type
};

struct Blob_PropertySig_11787 {
    byte Size; // coded integer - blob size
    struct PropertySig_11787 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1991 Blob_Generic_1991, *PBlob_Generic_1991;

struct Blob_Generic_1991 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_17207 Blob_Generic_17207, *PBlob_Generic_17207;

struct Blob_Generic_17207 {
    byte Size; // coded integer - blob size
    byte Generic[24]; // Undefined blob contents
};

typedef struct Blob_Generic_1999 Blob_Generic_1999, *PBlob_Generic_1999;

struct Blob_Generic_1999 {
    byte Size; // coded integer - blob size
    byte Generic[25]; // Undefined blob contents
};

typedef struct Blob_Generic_11905 Blob_Generic_11905, *PBlob_Generic_11905;

struct Blob_Generic_11905 {
    byte Size; // coded integer - blob size
    byte Generic[77]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11781 Blob_PropertySig_11781, *PBlob_PropertySig_11781;

typedef struct PropertySig_11781 PropertySig_11781, *PPropertySig_11781;

typedef struct Type_185312 Type_185312, *PType_185312;

struct Type_185312 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_11781 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185312 RetType; // Return type
};

struct Blob_PropertySig_11781 {
    byte Size; // coded integer - blob size
    struct PropertySig_11781 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_14187 Blob_Generic_14187, *PBlob_Generic_14187;

struct Blob_Generic_14187 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_52439 Blob_Generic_52439, *PBlob_Generic_52439;

struct Blob_Generic_52439 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3701 Blob_Generic_3701, *PBlob_Generic_3701;

struct Blob_Generic_3701 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_9007 Blob_Generic_9007, *PBlob_Generic_9007;

struct Blob_Generic_9007 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_31510 Blob_Generic_31510, *PBlob_Generic_31510;

struct Blob_Generic_31510 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_814 Blob_Generic_814, *PBlob_Generic_814;

struct Blob_Generic_814 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_Generic_32844 Blob_Generic_32844, *PBlob_Generic_32844;

struct Blob_Generic_32844 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_27496 Blob_Generic_27496, *PBlob_Generic_27496;

struct Blob_Generic_27496 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_47090 Blob_Generic_47090, *PBlob_Generic_47090;

struct Blob_Generic_47090 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_51103 Blob_Generic_51103, *PBlob_Generic_51103;

struct Blob_Generic_51103 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11771 Blob_PropertySig_11771, *PBlob_PropertySig_11771;

typedef struct PropertySig_11771 PropertySig_11771, *PPropertySig_11771;

typedef struct Type_185302 Type_185302, *PType_185302;

struct Type_185302 {
    struct GenericInstType_185303 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11771 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185302 RetType; // Return type
};

struct Blob_PropertySig_11771 {
    byte Size; // coded integer - blob size
    struct PropertySig_11771 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_7109 Blob_PropertySig_7109, *PBlob_PropertySig_7109;

typedef struct PropertySig_7109 PropertySig_7109, *PPropertySig_7109;

typedef struct Type_180640 Type_180640, *PType_180640;

struct Type_180640 {
    struct GenericInstType_180641 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_7109 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180640 RetType; // Return type
};

struct Blob_PropertySig_7109 {
    byte Size; // coded integer - blob size
    struct PropertySig_7109 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct CustomAttrib_13030 CustomAttrib_13030, *PCustomAttrib_13030;

struct CustomAttrib_13030 {
    word PROLOG; // Magic (0x0001)
    dword FixedArg_0; // Elem (ELEMENT_TYPE_U4)
    word NumNamed; // Number of NamedArgs to follow
};

typedef struct Blob_Generic_9016 Blob_Generic_9016, *PBlob_Generic_9016;

struct Blob_Generic_9016 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_15487 Blob_Generic_15487, *PBlob_Generic_15487;

struct Blob_Generic_15487 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_3710 Blob_Generic_3710, *PBlob_Generic_3710;

struct Blob_Generic_3710 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_804 Blob_Generic_804, *PBlob_Generic_804;

struct Blob_Generic_804 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4043 Blob_PropertySig_4043, *PBlob_PropertySig_4043;

typedef struct PropertySig_4043 PropertySig_4043, *PPropertySig_4043;

typedef struct Type_177574 Type_177574, *PType_177574;

struct Type_177574 {
    struct GenericInstType_177575 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_4043 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177574 RetType; // Return type
};

struct Blob_PropertySig_4043 {
    byte Size; // coded integer - blob size
    struct PropertySig_4043 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_28798 Blob_Generic_28798, *PBlob_Generic_28798;

struct Blob_Generic_28798 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_26138 Blob_Generic_26138, *PBlob_Generic_26138;

struct Blob_Generic_26138 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_915 Blob_MethodRefSig_915, *PBlob_MethodRefSig_915;

typedef struct MethodRefSig_915 MethodRefSig_915, *PMethodRefSig_915;

typedef struct Type_174446 Type_174446, *PType_174446;

typedef struct Type_174447 Type_174447, *PType_174447;

struct Type_174447 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct Type_174446 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_915 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_174446 RetType;
    struct Type_174447 Param0;
};

struct Blob_MethodRefSig_915 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_915 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_PropertySig_11761 Blob_PropertySig_11761, *PBlob_PropertySig_11761;

typedef struct PropertySig_11761 PropertySig_11761, *PPropertySig_11761;

typedef struct Type_185292 Type_185292, *PType_185292;

struct Type_185292 {
    struct GenericInstType_185293 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11761 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185292 RetType; // Return type
};

struct Blob_PropertySig_11761 {
    byte Size; // coded integer - blob size
    struct PropertySig_11761 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_20833 Blob_Generic_20833, *PBlob_Generic_20833;

struct Blob_Generic_20833 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9739 Blob_PropertySig_9739, *PBlob_PropertySig_9739;

typedef struct PropertySig_9739 PropertySig_9739, *PPropertySig_9739;

typedef struct Type_183270 Type_183270, *PType_183270;

struct Type_183270 {
    struct GenericInstType_183271 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_9739 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183270 RetType; // Return type
};

struct Blob_PropertySig_9739 {
    byte Size; // coded integer - blob size
    struct PropertySig_9739 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_9026 Blob_Generic_9026, *PBlob_Generic_9026;

struct Blob_Generic_9026 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_14166 Blob_Generic_14166, *PBlob_Generic_14166;

struct Blob_Generic_14166 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19852 Blob_Generic_19852, *PBlob_Generic_19852;

struct Blob_Generic_19852 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_47069 Blob_Generic_47069, *PBlob_Generic_47069;

struct Blob_Generic_47069 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3722 Blob_Generic_3722, *PBlob_Generic_3722;

struct Blob_Generic_3722 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_32823 Blob_Generic_32823, *PBlob_Generic_32823;

struct Blob_Generic_32823 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_48397 Blob_Generic_48397, *PBlob_Generic_48397;

struct Blob_Generic_48397 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_52418 Blob_Generic_52418, *PBlob_Generic_52418;

struct Blob_Generic_52418 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_40438 Blob_Generic_40438, *PBlob_Generic_40438;

struct Blob_Generic_40438 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11751 Blob_PropertySig_11751, *PBlob_PropertySig_11751;

typedef struct PropertySig_11751 PropertySig_11751, *PPropertySig_11751;

typedef struct Type_185282 Type_185282, *PType_185282;

struct Type_185282 {
    struct GenericInstType_185283 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11751 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185282 RetType; // Return type
};

struct Blob_PropertySig_11751 {
    byte Size; // coded integer - blob size
    struct PropertySig_11751 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1839 Blob_PropertySig_1839, *PBlob_PropertySig_1839;

typedef struct PropertySig_1839 PropertySig_1839, *PPropertySig_1839;

typedef struct Type_175370 Type_175370, *PType_175370;

struct Type_175370 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_1839 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175370 RetType; // Return type
};

struct Blob_PropertySig_1839 {
    byte Size; // coded integer - blob size
    struct PropertySig_1839 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_9036 Blob_Generic_9036, *PBlob_Generic_9036;

struct Blob_Generic_9036 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_42204 Blob_Generic_42204, *PBlob_Generic_42204;

struct Blob_Generic_42204 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_44861 Blob_Generic_44861, *PBlob_Generic_44861;

struct Blob_Generic_44861 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_35909 Blob_Generic_35909, *PBlob_Generic_35909;

struct Blob_Generic_35909 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_862 Blob_Generic_862, *PBlob_Generic_862;

struct Blob_Generic_862 {
    byte Size; // coded integer - blob size
    byte Generic[29]; // Undefined blob contents
};

typedef struct Blob_Generic_3734 Blob_Generic_3734, *PBlob_Generic_3734;

struct Blob_Generic_3734 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10617 Blob_Generic_10617, *PBlob_Generic_10617;

struct Blob_Generic_10617 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2408 Blob_Generic_2408, *PBlob_Generic_2408;

struct Blob_Generic_2408 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_29225 Blob_Generic_29225, *PBlob_Generic_29225;

struct Blob_Generic_29225 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11741 Blob_PropertySig_11741, *PBlob_PropertySig_11741;

typedef struct PropertySig_11741 PropertySig_11741, *PPropertySig_11741;

typedef struct Type_185272 Type_185272, *PType_185272;

struct Type_185272 {
    struct GenericInstType_185273 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11741 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185272 RetType; // Return type
};

struct Blob_PropertySig_11741 {
    byte Size; // coded integer - blob size
    struct PropertySig_11741 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_52481 Blob_Generic_52481, *PBlob_Generic_52481;

struct Blob_Generic_52481 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_17253 Blob_Generic_17253, *PBlob_Generic_17253;

struct Blob_Generic_17253 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18585 Blob_Generic_18585, *PBlob_Generic_18585;

struct Blob_Generic_18585 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11731 Blob_PropertySig_11731, *PBlob_PropertySig_11731;

typedef struct PropertySig_11731 PropertySig_11731, *PPropertySig_11731;

typedef struct Type_185262 Type_185262, *PType_185262;

struct Type_185262 {
    struct GenericInstType_185263 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11731 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185262 RetType; // Return type
};

struct Blob_PropertySig_11731 {
    byte Size; // coded integer - blob size
    struct PropertySig_11731 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_854 Blob_Generic_854, *PBlob_Generic_854;

struct Blob_Generic_854 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3743 Blob_Generic_3743, *PBlob_Generic_3743;

struct Blob_Generic_3743 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_30229 Blob_Generic_30229, *PBlob_Generic_30229;

struct Blob_Generic_30229 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10625 Blob_Generic_10625, *PBlob_Generic_10625;

struct Blob_Generic_10625 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_2416 Blob_Generic_2416, *PBlob_Generic_2416;

struct Blob_Generic_2416 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_51145 Blob_Generic_51145, *PBlob_Generic_51145;

struct Blob_Generic_51145 {
    byte Size; // coded integer - blob size
    byte Generic[66]; // Undefined blob contents
};

typedef struct Blob_Generic_9051 Blob_Generic_9051, *PBlob_Generic_9051;

struct Blob_Generic_9051 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_9059 Blob_Generic_9059, *PBlob_Generic_9059;

struct Blob_Generic_9059 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_39495 Blob_Generic_39495, *PBlob_Generic_39495;

struct Blob_Generic_39495 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_Generic_40485 Blob_Generic_40485, *PBlob_Generic_40485;

struct Blob_Generic_40485 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_3752 Blob_Generic_3752, *PBlob_Generic_3752;

struct Blob_Generic_3752 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_2424 Blob_Generic_2424, *PBlob_Generic_2424;

struct Blob_Generic_2424 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_846 Blob_Generic_846, *PBlob_Generic_846;

struct Blob_Generic_846 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8446 Blob_PropertySig_8446, *PBlob_PropertySig_8446;

typedef struct PropertySig_8446 PropertySig_8446, *PPropertySig_8446;

typedef struct Type_181977 Type_181977, *PType_181977;

struct Type_181977 {
    struct GenericInstType_181978 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_8446 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181977 RetType; // Return type
};

struct Blob_PropertySig_8446 {
    byte Size; // coded integer - blob size
    struct PropertySig_8446 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_29204 Blob_Generic_29204, *PBlob_Generic_29204;

struct Blob_Generic_29204 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_43519 Blob_Generic_43519, *PBlob_Generic_43519;

struct Blob_Generic_43519 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_52460 Blob_Generic_52460, *PBlob_Generic_52460;

struct Blob_Generic_52460 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17232 Blob_Generic_17232, *PBlob_Generic_17232;

struct Blob_Generic_17232 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19893 Blob_Generic_19893, *PBlob_Generic_19893;

struct Blob_Generic_19893 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_20882 Blob_Generic_20882, *PBlob_Generic_20882;

struct Blob_Generic_20882 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9067 Blob_Generic_9067, *PBlob_Generic_9067;

struct Blob_Generic_9067 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_FieldSig_11988 Blob_FieldSig_11988, *PBlob_FieldSig_11988;

typedef struct FieldSig_11988 FieldSig_11988, *PFieldSig_11988;

typedef struct Type_185518 Type_185518, *PType_185518;

struct Type_185518 {
    struct ValueType.conflict40 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_11988 {
    byte FIELD; // Magic (0x06)
    struct Type_185518 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_11988 {
    byte Size; // coded integer - blob size
    struct FieldSig_11988 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_3761 Blob_Generic_3761, *PBlob_Generic_3761;

struct Blob_Generic_3761 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_26195 Blob_Generic_26195, *PBlob_Generic_26195;

struct Blob_Generic_26195 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_1103 Blob_Generic_1103, *PBlob_Generic_1103;

struct Blob_Generic_1103 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_1109 Blob_Generic_1109, *PBlob_Generic_1109;

struct Blob_Generic_1109 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3769 Blob_Generic_3769, *PBlob_Generic_3769;

struct Blob_Generic_3769 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2438 Blob_Generic_2438, *PBlob_Generic_2438;

struct Blob_Generic_2438 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_32865 Blob_Generic_32865, *PBlob_Generic_32865;

struct Blob_Generic_32865 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_51124 Blob_Generic_51124, *PBlob_Generic_51124;

struct Blob_Generic_51124 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_11983 Blob_FieldSig_11983, *PBlob_FieldSig_11983;

typedef struct FieldSig_11983 FieldSig_11983, *PFieldSig_11983;

typedef struct Type_185513 Type_185513, *PType_185513;

struct Type_185513 {
    struct ValueType.conflict39 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_11983 {
    byte FIELD; // Magic (0x06)
    struct Type_185513 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_11983 {
    byte Size; // coded integer - blob size
    struct FieldSig_11983 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_10609 Blob_Generic_10609, *PBlob_Generic_10609;

struct Blob_Generic_10609 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_31531 Blob_Generic_31531, *PBlob_Generic_31531;

struct Blob_Generic_31531 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_23914 Blob_Generic_23914, *PBlob_Generic_23914;

struct Blob_Generic_23914 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_Generic_38163 Blob_Generic_38163, *PBlob_Generic_38163;

struct Blob_Generic_38163 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_9873 Blob_Generic_9873, *PBlob_Generic_9873;

struct Blob_Generic_9873 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_7213 Blob_Generic_7213, *PBlob_Generic_7213;

struct Blob_Generic_7213 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_11184 Blob_Generic_11184, *PBlob_Generic_11184;

struct Blob_Generic_11184 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_8540 Blob_Generic_8540, *PBlob_Generic_8540;

struct Blob_Generic_8540 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4185 Blob_Generic_4185, *PBlob_Generic_4185;

struct Blob_Generic_4185 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_16877 Blob_Generic_16877, *PBlob_Generic_16877;

struct Blob_Generic_16877 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_23165 Blob_Generic_23165, *PBlob_Generic_23165;

struct Blob_Generic_23165 {
    byte Size; // coded integer - blob size
    byte Generic[69]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7975 Blob_PropertySig_7975, *PBlob_PropertySig_7975;

typedef struct PropertySig_7975 PropertySig_7975, *PPropertySig_7975;

typedef struct Type_181506 Type_181506, *PType_181506;

struct Type_181506 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_7975 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181506 RetType; // Return type
};

struct Blob_PropertySig_7975 {
    byte Size; // coded integer - blob size
    struct PropertySig_7975 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_50782 Blob_Generic_50782, *PBlob_Generic_50782;

struct Blob_Generic_50782 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_36478 Blob_Generic_36478, *PBlob_Generic_36478;

struct Blob_Generic_36478 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41834 Blob_Generic_41834, *PBlob_Generic_41834;

struct Blob_Generic_41834 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_1917 Blob_Generic_1917, *PBlob_Generic_1917;

struct Blob_Generic_1917 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4191 Blob_Generic_4191, *PBlob_Generic_4191;

struct Blob_Generic_4191 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11190 Blob_Generic_11190, *PBlob_Generic_11190;

struct Blob_Generic_11190 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_11195 Blob_Generic_11195, *PBlob_Generic_11195;

struct Blob_Generic_11195 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4197 Blob_Generic_4197, *PBlob_Generic_4197;

struct Blob_Generic_4197 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9882 Blob_Generic_9882, *PBlob_Generic_9882;

struct Blob_Generic_9882 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_49788 Blob_Generic_49788, *PBlob_Generic_49788;

struct Blob_Generic_49788 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8550 Blob_Generic_8550, *PBlob_Generic_8550;

struct Blob_Generic_8550 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_15558 Blob_Generic_15558, *PBlob_Generic_15558;

struct Blob_Generic_15558 {
    byte Size; // coded integer - blob size
    byte Generic[36]; // Undefined blob contents
};

typedef struct Blob_Generic_7225 Blob_Generic_7225, *PBlob_Generic_7225;

struct Blob_Generic_7225 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_9888 Blob_Generic_9888, *PBlob_Generic_9888;

struct Blob_Generic_9888 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_8556 Blob_Generic_8556, *PBlob_Generic_8556;

struct Blob_Generic_8556 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_19914 Blob_Generic_19914, *PBlob_Generic_19914;

struct Blob_Generic_19914 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1923 Blob_Generic_1923, *PBlob_Generic_1923;

struct Blob_Generic_1923 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2294 Blob_PropertySig_2294, *PBlob_PropertySig_2294;

typedef struct PropertySig_2294 PropertySig_2294, *PPropertySig_2294;

typedef struct Type_175825 Type_175825, *PType_175825;

struct Type_175825 {
    struct GenericInstType_175826 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2294 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175825 RetType; // Return type
};

struct Blob_PropertySig_2294 {
    byte Size; // coded integer - blob size
    struct PropertySig_2294 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_20903 Blob_Generic_20903, *PBlob_Generic_20903;

struct Blob_Generic_20903 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_9894 Blob_Generic_9894, *PBlob_Generic_9894;

struct Blob_Generic_9894 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12493 Blob_Generic_12493, *PBlob_Generic_12493;

struct Blob_Generic_12493 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_7235 Blob_Generic_7235, *PBlob_Generic_7235;

struct Blob_Generic_7235 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_8562 Blob_Generic_8562, *PBlob_Generic_8562;

struct Blob_Generic_8562 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_11166 Blob_Generic_11166, *PBlob_Generic_11166;

struct Blob_Generic_11166 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_23144 Blob_Generic_23144, *PBlob_Generic_23144;

struct Blob_Generic_23144 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_47111 Blob_Generic_47111, *PBlob_Generic_47111;

struct Blob_Generic_47111 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_1931 Blob_Generic_1931, *PBlob_Generic_1931;

struct Blob_Generic_1931 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7955 Blob_PropertySig_7955, *PBlob_PropertySig_7955;

typedef struct PropertySig_7955 PropertySig_7955, *PPropertySig_7955;

typedef struct Type_181486 Type_181486, *PType_181486;

struct Type_181486 {
    struct GenericInstType_181487 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_7955 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181486 RetType; // Return type
};

struct Blob_PropertySig_7955 {
    byte Size; // coded integer - blob size
    struct PropertySig_7955 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_32097 Blob_Generic_32097, *PBlob_Generic_32097;

struct Blob_Generic_32097 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_41813 Blob_Generic_41813, *PBlob_Generic_41813;

struct Blob_Generic_41813 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1939 Blob_Generic_1939, *PBlob_Generic_1939;

struct Blob_Generic_1939 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_8574 Blob_Generic_8574, *PBlob_Generic_8574;

struct Blob_Generic_8574 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_7245 Blob_Generic_7245, *PBlob_Generic_7245;

struct Blob_Generic_7245 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_48439 Blob_Generic_48439, *PBlob_Generic_48439;

struct Blob_Generic_48439 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_49767 Blob_Generic_49767, *PBlob_Generic_49767;

struct Blob_Generic_49767 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11178 Blob_Generic_11178, *PBlob_Generic_11178;

struct Blob_Generic_11178 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_15537 Blob_Generic_15537, *PBlob_Generic_15537;

struct Blob_Generic_15537 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_14208 Blob_Generic_14208, *PBlob_Generic_14208;

struct Blob_Generic_14208 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_1945 Blob_Generic_1945, *PBlob_Generic_1945;

struct Blob_Generic_1945 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_44081 Blob_Generic_44081, *PBlob_Generic_44081;

struct Blob_Generic_44081 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7965 Blob_PropertySig_7965, *PBlob_PropertySig_7965;

typedef struct PropertySig_7965 PropertySig_7965, *PPropertySig_7965;

typedef struct Type_181496 Type_181496, *PType_181496;

struct Type_181496 {
    struct GenericInstType_181497 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_7965 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181496 RetType; // Return type
};

struct Blob_PropertySig_7965 {
    byte Size; // coded integer - blob size
    struct PropertySig_7965 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_28840 Blob_Generic_28840, *PBlob_Generic_28840;

struct Blob_Generic_28840 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_27517 Blob_Generic_27517, *PBlob_Generic_27517;

struct Blob_Generic_27517 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_Generic_37792 Blob_Generic_37792, *PBlob_Generic_37792;

struct Blob_Generic_37792 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_38220 Blob_Generic_38220, *PBlob_Generic_38220;

struct Blob_Generic_38220 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_8582 Blob_Generic_8582, *PBlob_Generic_8582;

struct Blob_Generic_8582 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_14256 Blob_Generic_14256, *PBlob_Generic_14256;

struct Blob_Generic_14256 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5361 Blob_PropertySig_5361, *PBlob_PropertySig_5361;

typedef struct PropertySig_5361 PropertySig_5361, *PPropertySig_5361;

typedef struct Type_178892 Type_178892, *PType_178892;

struct Type_178892 {
    struct GenericInstType_178893 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_5361 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178892 RetType; // Return type
};

struct Blob_PropertySig_5361 {
    byte Size; // coded integer - blob size
    struct PropertySig_5361 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_7258 Blob_Generic_7258, *PBlob_Generic_7258;

struct Blob_Generic_7258 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_32914 Blob_Generic_32914, *PBlob_Generic_32914;

struct Blob_Generic_32914 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_1955 Blob_Generic_1955, *PBlob_Generic_1955;

struct Blob_Generic_1955 {
    byte Size; // coded integer - blob size
    byte Generic[27]; // Undefined blob contents
};

typedef struct Blob_Generic_28894 Blob_Generic_28894, *PBlob_Generic_28894;

struct Blob_Generic_28894 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_907 Blob_Generic_907, *PBlob_Generic_907;

struct Blob_Generic_907 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_27568 Blob_Generic_27568, *PBlob_Generic_27568;

struct Blob_Generic_27568 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_44906 Blob_Generic_44906, *PBlob_Generic_44906;

struct Blob_Generic_44906 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8590 Blob_Generic_8590, *PBlob_Generic_8590;

struct Blob_Generic_8590 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_7266 Blob_Generic_7266, *PBlob_Generic_7266;

struct Blob_Generic_7266 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_15595 Blob_Generic_15595, *PBlob_Generic_15595;

struct Blob_Generic_15595 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_40532 Blob_Generic_40532, *PBlob_Generic_40532;

struct Blob_Generic_40532 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_Generic_39548 Blob_Generic_39548, *PBlob_Generic_39548;

struct Blob_Generic_39548 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5371 Blob_PropertySig_5371, *PBlob_PropertySig_5371;

typedef struct PropertySig_5371 PropertySig_5371, *PPropertySig_5371;

typedef struct Type_178902 Type_178902, *PType_178902;

struct Type_178902 {
    struct GenericInstType_178903 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_5371 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178902 RetType; // Return type
};

struct Blob_PropertySig_5371 {
    byte Size; // coded integer - blob size
    struct PropertySig_5371 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_47168 Blob_Generic_47168, *PBlob_Generic_47168;

struct Blob_Generic_47168 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_20947 Blob_Generic_20947, *PBlob_Generic_20947;

struct Blob_Generic_20947 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10363 Blob_PropertySig_10363, *PBlob_PropertySig_10363;

typedef struct PropertySig_10363 PropertySig_10363, *PPropertySig_10363;

typedef struct Type_183894 Type_183894, *PType_183894;

struct Type_183894 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10363 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183894 RetType; // Return type
};

struct Blob_PropertySig_10363 {
    byte Size; // coded integer - blob size
    struct PropertySig_10363 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_7274 Blob_Generic_7274, *PBlob_Generic_7274;

struct Blob_Generic_7274 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10357 Blob_PropertySig_10357, *PBlob_PropertySig_10357;

typedef struct PropertySig_10357 PropertySig_10357, *PPropertySig_10357;

typedef struct Type_183888 Type_183888, *PType_183888;

struct Type_183888 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10357 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183888 RetType; // Return type
};

struct Blob_PropertySig_10357 {
    byte Size; // coded integer - blob size
    struct PropertySig_10357 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_48489 Blob_Generic_48489, *PBlob_Generic_48489;

struct Blob_Generic_48489 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_16898 Blob_Generic_16898, *PBlob_Generic_16898;

struct Blob_Generic_16898 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_36499 Blob_Generic_36499, *PBlob_Generic_36499;

struct Blob_Generic_36499 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_35162 Blob_Generic_35162, *PBlob_Generic_35162;

struct Blob_Generic_35162 {
    byte Size; // coded integer - blob size
    byte Generic[59]; // Undefined blob contents
};

typedef struct Blob_Generic_7285 Blob_Generic_7285, *PBlob_Generic_7285;

struct Blob_Generic_7285 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_39527 Blob_Generic_39527, *PBlob_Generic_39527;

struct Blob_Generic_39527 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19935 Blob_Generic_19935, *PBlob_Generic_19935;

struct Blob_Generic_19935 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_1983 Blob_Generic_1983, *PBlob_Generic_1983;

struct Blob_Generic_1983 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9701 Blob_PropertySig_9701, *PBlob_PropertySig_9701;

typedef struct PropertySig_9701 PropertySig_9701, *PPropertySig_9701;

typedef struct Type_183232 Type_183232, *PType_183232;

struct Type_183232 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_9701 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183232 RetType; // Return type
};

struct Blob_PropertySig_9701 {
    byte Size; // coded integer - blob size
    struct PropertySig_9701 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_7291 Blob_Generic_7291, *PBlob_Generic_7291;

struct Blob_Generic_7291 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_49717 Blob_Generic_49717, *PBlob_Generic_49717;

struct Blob_Generic_49717 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_20059 Blob_Generic_20059, *PBlob_Generic_20059;

struct Blob_Generic_20059 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_21387 Blob_Generic_21387, *PBlob_Generic_21387;

struct Blob_Generic_21387 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12433 Blob_Generic_12433, *PBlob_Generic_12433;

struct Blob_Generic_12433 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_1079 Blob_Generic_1079, *PBlob_Generic_1079;

struct Blob_Generic_1079 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_45352 Blob_Generic_45352, *PBlob_Generic_45352;

struct Blob_Generic_45352 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_6769 Blob_Generic_6769, *PBlob_Generic_6769;

struct Blob_Generic_6769 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6763 Blob_Generic_6763, *PBlob_Generic_6763;

struct Blob_Generic_6763 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_34690 Blob_Generic_34690, *PBlob_Generic_34690;

struct Blob_Generic_34690 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_5441 Blob_Generic_5441, *PBlob_Generic_5441;

struct Blob_Generic_5441 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_1083 Blob_Generic_1083, *PBlob_Generic_1083;

struct Blob_Generic_1083 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_13773 Blob_Generic_13773, *PBlob_Generic_13773;

struct Blob_Generic_13773 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12441 Blob_Generic_12441, *PBlob_Generic_12441;

struct Blob_Generic_12441 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_1087 Blob_Generic_1087, *PBlob_Generic_1087;

struct Blob_Generic_1087 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_9806 Blob_Generic_9806, *PBlob_Generic_9806;

struct Blob_Generic_9806 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_4119 Blob_Generic_4119, *PBlob_Generic_4119;

struct Blob_Generic_4119 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11116 Blob_Generic_11116, *PBlob_Generic_11116;

struct Blob_Generic_11116 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_6775 Blob_Generic_6775, *PBlob_Generic_6775;

struct Blob_Generic_6775 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_5447 Blob_Generic_5447, *PBlob_Generic_5447;

struct Blob_Generic_5447 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4870 Blob_PropertySig_4870, *PBlob_PropertySig_4870;

typedef struct PropertySig_4870 PropertySig_4870, *PPropertySig_4870;

typedef struct Type_178401 Type_178401, *PType_178401;

struct Type_178401 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4870 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178401 RetType; // Return type
};

struct Blob_PropertySig_4870 {
    byte Size; // coded integer - blob size
    struct PropertySig_4870 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_16808 Blob_Generic_16808, *PBlob_Generic_16808;

struct Blob_Generic_16808 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_33373 Blob_Generic_33373, *PBlob_Generic_33373;

struct Blob_Generic_33373 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_19088 Blob_Generic_19088, *PBlob_Generic_19088;

struct Blob_Generic_19088 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4876 Blob_PropertySig_4876, *PBlob_PropertySig_4876;

typedef struct PropertySig_4876 PropertySig_4876, *PPropertySig_4876;

typedef struct Type_178407 Type_178407, *PType_178407;

struct Type_178407 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4876 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178407 RetType; // Return type
};

struct Blob_PropertySig_4876 {
    byte Size; // coded integer - blob size
    struct PropertySig_4876 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_12187 Blob_PropertySig_12187, *PBlob_PropertySig_12187;

typedef struct PropertySig_12187 PropertySig_12187, *PPropertySig_12187;

typedef struct Type_185718 Type_185718, *PType_185718;

struct Type_185718 {
    struct GenericInstType_185719 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_12187 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185718 RetType; // Return type
};

struct Blob_PropertySig_12187 {
    byte Size; // coded integer - blob size
    struct PropertySig_12187 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_20038 Blob_Generic_20038, *PBlob_Generic_20038;

struct Blob_Generic_20038 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1096 Blob_Generic_1096, *PBlob_Generic_1096;

struct Blob_Generic_1096 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5453 Blob_Generic_5453, *PBlob_Generic_5453;

struct Blob_Generic_5453 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_21366 Blob_Generic_21366, *PBlob_Generic_21366;

struct Blob_Generic_21366 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_46664 Blob_Generic_46664, *PBlob_Generic_46664;

struct Blob_Generic_46664 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_6780 Blob_Generic_6780, *PBlob_Generic_6780;

struct Blob_Generic_6780 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_4125 Blob_Generic_4125, *PBlob_Generic_4125;

struct Blob_Generic_4125 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_47991 Blob_Generic_47991, *PBlob_Generic_47991;

struct Blob_Generic_47991 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_Generic_12412 Blob_Generic_12412, *PBlob_Generic_12412;

struct Blob_Generic_12412 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_6785 Blob_Generic_6785, *PBlob_Generic_6785;

struct Blob_Generic_6785 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3517 Blob_PropertySig_3517, *PBlob_PropertySig_3517;

typedef struct PropertySig_3517 PropertySig_3517, *PPropertySig_3517;

typedef struct Type_177048 Type_177048, *PType_177048;

struct Type_177048 {
    struct GenericInstType_177049 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_3517 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177048 RetType; // Return type
};

struct Blob_PropertySig_3517 {
    byte Size; // coded integer - blob size
    struct PropertySig_3517 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_6795 Blob_Generic_6795, *PBlob_Generic_6795;

struct Blob_Generic_6795 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_4131 Blob_Generic_4131, *PBlob_Generic_4131;

struct Blob_Generic_4131 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6790 Blob_Generic_6790, *PBlob_Generic_6790;

struct Blob_Generic_6790 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_4137 Blob_Generic_4137, *PBlob_Generic_4137;

struct Blob_Generic_4137 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9828 Blob_Generic_9828, *PBlob_Generic_9828;

struct Blob_Generic_9828 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_9822 Blob_Generic_9822, *PBlob_Generic_9822;

struct Blob_Generic_9822 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12425 Blob_Generic_12425, *PBlob_Generic_12425;

struct Blob_Generic_12425 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5469 Blob_Generic_5469, *PBlob_Generic_5469;

struct Blob_Generic_5469 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_37716 Blob_Generic_37716, *PBlob_Generic_37716;

struct Blob_Generic_37716 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_32024 Blob_Generic_32024, *PBlob_Generic_32024;

struct Blob_Generic_32024 {
    byte Size; // coded integer - blob size
    byte Generic[30]; // Undefined blob contents
};

typedef struct Blob_Generic_24406 Blob_Generic_24406, *PBlob_Generic_24406;

struct Blob_Generic_24406 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_28819 Blob_Generic_28819, *PBlob_Generic_28819;

struct Blob_Generic_28819 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4143 Blob_Generic_4143, *PBlob_Generic_4143;

struct Blob_Generic_4143 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_12472 Blob_Generic_12472, *PBlob_Generic_12472;

struct Blob_Generic_12472 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_23123 Blob_Generic_23123, *PBlob_Generic_23123;

struct Blob_Generic_23123 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8505 Blob_Generic_8505, *PBlob_Generic_8505;

struct Blob_Generic_8505 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5477 Blob_Generic_5477, *PBlob_Generic_5477;

struct Blob_Generic_5477 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_9839 Blob_Generic_9839, *PBlob_Generic_9839;

struct Blob_Generic_9839 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_9833 Blob_Generic_9833, *PBlob_Generic_9833;

struct Blob_Generic_9833 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_44060 Blob_Generic_44060, *PBlob_Generic_44060;

struct Blob_Generic_44060 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_35102 Blob_Generic_35102, *PBlob_Generic_35102;

struct Blob_Generic_35102 {
    byte Size; // coded integer - blob size
    byte Generic[59]; // Undefined blob contents
};

typedef struct Blob_Generic_25789 Blob_Generic_25789, *PBlob_Generic_25789;

struct Blob_Generic_25789 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_32076 Blob_Generic_32076, *PBlob_Generic_32076;

struct Blob_Generic_32076 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11150 Blob_Generic_11150, *PBlob_Generic_11150;

struct Blob_Generic_11150 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_48418 Blob_Generic_48418, *PBlob_Generic_48418;

struct Blob_Generic_48418 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5485 Blob_Generic_5485, *PBlob_Generic_5485;

struct Blob_Generic_5485 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_4152 Blob_Generic_4152, *PBlob_Generic_4152;

struct Blob_Generic_4152 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_12485 Blob_Generic_12485, *PBlob_Generic_12485;

struct Blob_Generic_12485 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_50732 Blob_Generic_50732, *PBlob_Generic_50732;

struct Blob_Generic_50732 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_8519 Blob_Generic_8519, *PBlob_Generic_8519;

struct Blob_Generic_8519 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_11158 Blob_Generic_11158, *PBlob_Generic_11158;

struct Blob_Generic_11158 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_8512 Blob_Generic_8512, *PBlob_Generic_8512;

struct Blob_Generic_8512 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_9846 Blob_Generic_9846, *PBlob_Generic_9846;

struct Blob_Generic_9846 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_24467 Blob_Generic_24467, *PBlob_Generic_24467;

struct Blob_Generic_24467 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_37771 Blob_Generic_37771, *PBlob_Generic_37771;

struct Blob_Generic_37771 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4161 Blob_Generic_4161, *PBlob_Generic_4161;

struct Blob_Generic_4161 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_9852 Blob_Generic_9852, *PBlob_Generic_9852;

struct Blob_Generic_9852 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12452 Blob_Generic_12452, *PBlob_Generic_12452;

struct Blob_Generic_12452 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_23102 Blob_Generic_23102, *PBlob_Generic_23102;

struct Blob_Generic_23102 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9858 Blob_Generic_9858, *PBlob_Generic_9858;

struct Blob_Generic_9858 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5499 Blob_Generic_5499, *PBlob_Generic_5499;

struct Blob_Generic_5499 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_11126 Blob_Generic_11126, *PBlob_Generic_11126;

struct Blob_Generic_11126 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_8526 Blob_Generic_8526, *PBlob_Generic_8526;

struct Blob_Generic_8526 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2220 Blob_PropertySig_2220, *PBlob_PropertySig_2220;

typedef struct PropertySig_2220 PropertySig_2220, *PPropertySig_2220;

typedef struct Type_175751 Type_175751, *PType_175751;

struct Type_175751 {
    struct GenericInstType_175752 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2220 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175751 RetType; // Return type
};

struct Blob_PropertySig_2220 {
    byte Size; // coded integer - blob size
    struct PropertySig_2220 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_32055 Blob_Generic_32055, *PBlob_Generic_32055;

struct Blob_Generic_32055 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25768 Blob_Generic_25768, *PBlob_Generic_25768;

struct Blob_Generic_25768 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_44039 Blob_Generic_44039, *PBlob_Generic_44039;

struct Blob_Generic_44039 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4170 Blob_Generic_4170, *PBlob_Generic_4170;

struct Blob_Generic_4170 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_12462 Blob_Generic_12462, *PBlob_Generic_12462;

struct Blob_Generic_12462 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_13794 Blob_Generic_13794, *PBlob_Generic_13794;

struct Blob_Generic_13794 {
    byte Size; // coded integer - blob size
    byte Generic[29]; // Undefined blob contents
};

typedef struct Blob_PropertySig_12127 Blob_PropertySig_12127, *PBlob_PropertySig_12127;

typedef struct PropertySig_12127 PropertySig_12127, *PPropertySig_12127;

typedef struct Type_185658 Type_185658, *PType_185658;

struct Type_185658 {
    struct GenericInstType_185659 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_12127 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185658 RetType; // Return type
};

struct Blob_PropertySig_12127 {
    byte Size; // coded integer - blob size
    struct PropertySig_12127 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_4179 Blob_Generic_4179, *PBlob_Generic_4179;

struct Blob_Generic_4179 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11136 Blob_Generic_11136, *PBlob_Generic_11136;

struct Blob_Generic_11136 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_50711 Blob_Generic_50711, *PBlob_Generic_50711;

struct Blob_Generic_50711 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_280 Blob_PropertySig_280, *PBlob_PropertySig_280;

typedef struct PropertySig_280 PropertySig_280, *PPropertySig_280;

typedef struct Type_173811 Type_173811, *PType_173811;

struct Type_173811 {
    enum TypeCode ELEMENT_TYPE_R4;
};

struct PropertySig_280 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173811 RetType; // Return type
};

struct Blob_PropertySig_280 {
    byte Size; // coded integer - blob size
    struct PropertySig_280 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_7205 Blob_Generic_7205, *PBlob_Generic_7205;

struct Blob_Generic_7205 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_20080 Blob_Generic_20080, *PBlob_Generic_20080;

struct Blob_Generic_20080 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9867 Blob_Generic_9867, *PBlob_Generic_9867;

struct Blob_Generic_9867 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_36428 Blob_Generic_36428, *PBlob_Generic_36428;

struct Blob_Generic_36428 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_16829 Blob_Generic_16829, *PBlob_Generic_16829;

struct Blob_Generic_16829 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_1907 Blob_Generic_1907, *PBlob_Generic_1907;

struct Blob_Generic_1907 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_41034 Blob_Generic_41034, *PBlob_Generic_41034;

struct Blob_Generic_41034 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_781 Blob_Generic_781, *PBlob_Generic_781;

struct Blob_Generic_781 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_19109 Blob_Generic_19109, *PBlob_Generic_19109;

struct Blob_Generic_19109 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_789 Blob_Generic_789, *PBlob_Generic_789;

struct Blob_Generic_789 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3656 Blob_Generic_3656, *PBlob_Generic_3656;

struct Blob_Generic_3656 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_42361 Blob_Generic_42361, *PBlob_Generic_42361;

struct Blob_Generic_42361 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10777 Blob_Generic_10777, *PBlob_Generic_10777;

struct Blob_Generic_10777 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4985 Blob_Generic_4985, *PBlob_Generic_4985;

struct Blob_Generic_4985 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_29389 Blob_Generic_29389, *PBlob_Generic_29389;

struct Blob_Generic_29389 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_21429 Blob_Generic_21429, *PBlob_Generic_21429;

struct Blob_Generic_21429 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_46728 Blob_Generic_46728, *PBlob_Generic_46728;

struct Blob_Generic_46728 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_20101 Blob_Generic_20101, *PBlob_Generic_20101;

struct Blob_Generic_20101 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_4994 Blob_Generic_4994, *PBlob_Generic_4994;

struct Blob_Generic_4994 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_10783 Blob_Generic_10783, *PBlob_Generic_10783;

struct Blob_Generic_10783 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_773 Blob_Generic_773, *PBlob_Generic_773;

struct Blob_Generic_773 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_1000 Blob_Generic_1000, *PBlob_Generic_1000;

struct Blob_Generic_1000 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_3666 Blob_Generic_3666, *PBlob_Generic_3666;

struct Blob_Generic_3666 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10789 Blob_Generic_10789, *PBlob_Generic_10789;

struct Blob_Generic_10789 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_34742 Blob_Generic_34742, *PBlob_Generic_34742;

struct Blob_Generic_34742 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_41013 Blob_Generic_41013, *PBlob_Generic_41013;

struct Blob_Generic_41013 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11803 Blob_PropertySig_11803, *PBlob_PropertySig_11803;

typedef struct PropertySig_11803 PropertySig_11803, *PPropertySig_11803;

typedef struct Type_185334 Type_185334, *PType_185334;

struct Type_185334 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_11803 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185334 RetType; // Return type
};

struct Blob_PropertySig_11803 {
    byte Size; // coded integer - blob size
    struct PropertySig_11803 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_133 Blob_PropertySig_133, *PBlob_PropertySig_133;

typedef struct PropertySig_133 PropertySig_133, *PPropertySig_133;

typedef struct Type_173664 Type_173664, *PType_173664;

struct Type_173664 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_133 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173664 RetType; // Return type
};

struct Blob_PropertySig_133 {
    byte Size; // coded integer - blob size
    struct PropertySig_133 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1012 Blob_Generic_1012, *PBlob_Generic_1012;

struct Blob_Generic_1012 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_2343 Blob_Generic_2343, *PBlob_Generic_2343;

struct Blob_Generic_2343 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3675 Blob_Generic_3675, *PBlob_Generic_3675;

struct Blob_Generic_3675 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_43671 Blob_Generic_43671, *PBlob_Generic_43671;

struct Blob_Generic_43671 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_768 Blob_Generic_768, *PBlob_Generic_768;

struct Blob_Generic_768 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_1016 Blob_Generic_1016, *PBlob_Generic_1016;

struct Blob_Generic_1016 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_42340 Blob_Generic_42340, *PBlob_Generic_42340;

struct Blob_Generic_42340 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6700 Blob_Generic_6700, *PBlob_Generic_6700;

struct Blob_Generic_6700 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_6707 Blob_Generic_6707, *PBlob_Generic_6707;

struct Blob_Generic_6707 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_PropertySig_138 Blob_PropertySig_138, *PBlob_PropertySig_138;

typedef struct PropertySig_138 PropertySig_138, *PPropertySig_138;

typedef struct Type_173669 Type_173669, *PType_173669;

struct Type_173669 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_138 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173669 RetType; // Return type
};

struct Blob_PropertySig_138 {
    byte Size; // coded integer - blob size
    struct PropertySig_138 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_21408 Blob_Generic_21408, *PBlob_Generic_21408;

struct Blob_Generic_21408 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_22738 Blob_Generic_22738, *PBlob_Generic_22738;

struct Blob_Generic_22738 {
    byte Size; // coded integer - blob size
    byte Generic[63]; // Undefined blob contents
};

typedef struct Blob_Generic_46707 Blob_Generic_46707, *PBlob_Generic_46707;

struct Blob_Generic_46707 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1020 Blob_Generic_1020, *PBlob_Generic_1020;

struct Blob_Generic_1020 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2351 Blob_Generic_2351, *PBlob_Generic_2351;

struct Blob_Generic_2351 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_124 Blob_PropertySig_124, *PBlob_PropertySig_124;

typedef struct PropertySig_124 PropertySig_124, *PPropertySig_124;

typedef struct Type_173655 Type_173655, *PType_173655;

struct Type_173655 {
    struct GenericInstType_173656 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_124 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173655 RetType; // Return type
};

struct Blob_PropertySig_124 {
    byte Size; // coded integer - blob size
    struct PropertySig_124 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_6714 Blob_Generic_6714, *PBlob_Generic_6714;

struct Blob_Generic_6714 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_3683 Blob_Generic_3683, *PBlob_Generic_3683;

struct Blob_Generic_3683 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10764 Blob_Generic_10764, *PBlob_Generic_10764;

struct Blob_Generic_10764 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_1028 Blob_Generic_1028, *PBlob_Generic_1028;

struct Blob_Generic_1028 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2359 Blob_Generic_2359, *PBlob_Generic_2359;

struct Blob_Generic_2359 {
    byte Size; // coded integer - blob size
    byte Generic[22]; // Undefined blob contents
};

typedef struct Blob_Generic_758 Blob_Generic_758, *PBlob_Generic_758;

struct Blob_Generic_758 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_30369 Blob_Generic_30369, *PBlob_Generic_30369;

struct Blob_Generic_30369 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_28049 Blob_Generic_28049, *PBlob_Generic_28049;

struct Blob_Generic_28049 {
    byte Size; // coded integer - blob size
    byte Generic[64]; // Undefined blob contents
};

typedef struct Blob_Generic_31695 Blob_Generic_31695, *PBlob_Generic_31695;

struct Blob_Generic_31695 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16073 Blob_Generic_16073, *PBlob_Generic_16073;

struct Blob_Generic_16073 {
    byte Size; // coded integer - blob size
    byte Generic[30]; // Undefined blob contents
};

typedef struct Blob_Generic_41076 Blob_Generic_41076, *PBlob_Generic_41076;

struct Blob_Generic_41076 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3692 Blob_Generic_3692, *PBlob_Generic_3692;

struct Blob_Generic_3692 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_44102 Blob_Generic_44102, *PBlob_Generic_44102;

struct Blob_Generic_44102 {
    byte Size; // coded integer - blob size
    byte Generic[72]; // Undefined blob contents
};

typedef struct Blob_Generic_1034 Blob_Generic_1034, *PBlob_Generic_1034;

struct Blob_Generic_1034 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_12512 Blob_Generic_12512, *PBlob_Generic_12512;

struct Blob_Generic_12512 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_13845 Blob_Generic_13845, *PBlob_Generic_13845;

struct Blob_Generic_13845 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6721 Blob_Generic_6721, *PBlob_Generic_6721;

struct Blob_Generic_6721 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_33448 Blob_Generic_33448, *PBlob_Generic_33448;

struct Blob_Generic_33448 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6727 Blob_Generic_6727, *PBlob_Generic_6727;

struct Blob_Generic_6727 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_25821 Blob_Generic_25821, *PBlob_Generic_25821;

struct Blob_Generic_25821 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_45428 Blob_Generic_45428, *PBlob_Generic_45428;

struct Blob_Generic_45428 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12520 Blob_Generic_12520, *PBlob_Generic_12520;

struct Blob_Generic_12520 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_1043 Blob_Generic_1043, *PBlob_Generic_1043;

struct Blob_Generic_1043 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_6733 Blob_Generic_6733, *PBlob_Generic_6733;

struct Blob_Generic_6733 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6739 Blob_Generic_6739, *PBlob_Generic_6739;

struct Blob_Generic_6739 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_19163 Blob_Generic_19163, *PBlob_Generic_19163;

struct Blob_Generic_19163 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_25805 Blob_Generic_25805, *PBlob_Generic_25805;

struct Blob_Generic_25805 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_41055 Blob_Generic_41055, *PBlob_Generic_41055;

struct Blob_Generic_41055 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1050 Blob_Generic_1050, *PBlob_Generic_1050;

struct Blob_Generic_1050 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2382 Blob_Generic_2382, *PBlob_Generic_2382;

struct Blob_Generic_2382 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_1056 Blob_Generic_1056, *PBlob_Generic_1056;

struct Blob_Generic_1056 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_2387 Blob_Generic_2387, *PBlob_Generic_2387;

struct Blob_Generic_2387 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_6745 Blob_Generic_6745, *PBlob_Generic_6745;

struct Blob_Generic_6745 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5410 Blob_Generic_5410, *PBlob_Generic_5410;

struct Blob_Generic_5410 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5417 Blob_Generic_5417, *PBlob_Generic_5417;

struct Blob_Generic_5417 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_42382 Blob_Generic_42382, *PBlob_Generic_42382;

struct Blob_Generic_42382 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_13824 Blob_Generic_13824, *PBlob_Generic_13824;

struct Blob_Generic_13824 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_33427 Blob_Generic_33427, *PBlob_Generic_33427;

struct Blob_Generic_33427 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1777 Blob_PropertySig_1777, *PBlob_PropertySig_1777;

typedef struct PropertySig_1777 PropertySig_1777, *PPropertySig_1777;

typedef struct Type_175308 Type_175308, *PType_175308;

struct Type_175308 {
    struct GenericInstType_175309 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1777 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175308 RetType; // Return type
};

struct Blob_PropertySig_1777 {
    byte Size; // coded integer - blob size
    struct PropertySig_1777 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_30390 Blob_Generic_30390, *PBlob_Generic_30390;

struct Blob_Generic_30390 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4819 Blob_PropertySig_4819, *PBlob_PropertySig_4819;

typedef struct PropertySig_4819 PropertySig_4819, *PPropertySig_4819;

typedef struct Type_178350 Type_178350, *PType_178350;

struct Type_178350 {
    struct ValueType.conflict13 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_4819 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178350 RetType; // Return type
};

struct Blob_PropertySig_4819 {
    byte Size; // coded integer - blob size
    struct PropertySig_4819 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_6751 Blob_Generic_6751, *PBlob_Generic_6751;

struct Blob_Generic_6751 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_1063 Blob_Generic_1063, *PBlob_Generic_1063;

struct Blob_Generic_1063 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2392 Blob_Generic_2392, *PBlob_Generic_2392;

struct Blob_Generic_2392 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_6757 Blob_Generic_6757, *PBlob_Generic_6757;

struct Blob_Generic_6757 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12501 Blob_Generic_12501, *PBlob_Generic_12501;

struct Blob_Generic_12501 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_794 Blob_Generic_794, *PBlob_Generic_794;

struct Blob_Generic_794 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_5428 Blob_Generic_5428, *PBlob_Generic_5428;

struct Blob_Generic_5428 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_1069 Blob_Generic_1069, *PBlob_Generic_1069;

struct Blob_Generic_1069 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_19142 Blob_Generic_19142, *PBlob_Generic_19142;

struct Blob_Generic_19142 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_45407 Blob_Generic_45407, *PBlob_Generic_45407;

struct Blob_Generic_45407 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18657 Blob_Generic_18657, *PBlob_Generic_18657;

struct Blob_Generic_18657 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7173 Blob_Generic_7173, *PBlob_Generic_7173;

struct Blob_Generic_7173 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_40585 Blob_Generic_40585, *PBlob_Generic_40585;

struct Blob_Generic_40585 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5285 Blob_PropertySig_5285, *PBlob_PropertySig_5285;

typedef struct PropertySig_5285 PropertySig_5285, *PPropertySig_5285;

typedef struct Type_178816 Type_178816, *PType_178816;

struct Type_178816 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_5285 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178816 RetType; // Return type
};

struct Blob_PropertySig_5285 {
    byte Size; // coded integer - blob size
    struct PropertySig_5285 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_700 Blob_Generic_700, *PBlob_Generic_700;

struct Blob_Generic_700 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_1873 Blob_Generic_1873, *PBlob_Generic_1873;

struct Blob_Generic_1873 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_1879 Blob_Generic_1879, *PBlob_Generic_1879;

struct Blob_Generic_1879 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_26273 Blob_Generic_26273, *PBlob_Generic_26273;

struct Blob_Generic_26273 {
    byte Size; // coded integer - blob size
    byte Generic[55]; // Undefined blob contents
};

typedef struct Blob_Generic_708 Blob_Generic_708, *PBlob_Generic_708;

struct Blob_Generic_708 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4906 Blob_Generic_4906, *PBlob_Generic_4906;

struct Blob_Generic_4906 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_19990 Blob_Generic_19990, *PBlob_Generic_19990;

struct Blob_Generic_19990 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_7183 Blob_Generic_7183, *PBlob_Generic_7183;

struct Blob_Generic_7183 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_38273 Blob_Generic_38273, *PBlob_Generic_38273;

struct Blob_Generic_38273 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_44948 Blob_Generic_44948, *PBlob_Generic_44948;

struct Blob_Generic_44948 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17334 Blob_Generic_17334, *PBlob_Generic_17334;

struct Blob_Generic_17334 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1885 Blob_Generic_1885, *PBlob_Generic_1885;

struct Blob_Generic_1885 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_30306 Blob_Generic_30306, *PBlob_Generic_30306;

struct Blob_Generic_30306 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10701 Blob_Generic_10701, *PBlob_Generic_10701;

struct Blob_Generic_10701 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_32963 Blob_Generic_32963, *PBlob_Generic_32963;

struct Blob_Generic_32963 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4914 Blob_Generic_4914, *PBlob_Generic_4914;

struct Blob_Generic_4914 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10709 Blob_Generic_10709, *PBlob_Generic_10709;

struct Blob_Generic_10709 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_43609 Blob_Generic_43609, *PBlob_Generic_43609;

struct Blob_Generic_43609 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_20989 Blob_Generic_20989, *PBlob_Generic_20989;

struct Blob_Generic_20989 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_7197 Blob_Generic_7197, *PBlob_Generic_7197;

struct Blob_Generic_7197 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_14277 Blob_Generic_14277, *PBlob_Generic_14277;

struct Blob_Generic_14277 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_40564 Blob_Generic_40564, *PBlob_Generic_40564;

struct Blob_Generic_40564 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4922 Blob_Generic_4922, *PBlob_Generic_4922;

struct Blob_Generic_4922 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_18636 Blob_Generic_18636, *PBlob_Generic_18636;

struct Blob_Generic_18636 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1897 Blob_Generic_1897, *PBlob_Generic_1897;

struct Blob_Generic_1897 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_26252 Blob_Generic_26252, *PBlob_Generic_26252;

struct Blob_Generic_26252 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_51212 Blob_Generic_51212, *PBlob_Generic_51212;

struct Blob_Generic_51212 {
    byte Size; // coded integer - blob size
    byte Generic[66]; // Undefined blob contents
};

typedef struct Blob_Generic_52543 Blob_Generic_52543, *PBlob_Generic_52543;

struct Blob_Generic_52543 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_44927 Blob_Generic_44927, *PBlob_Generic_44927;

struct Blob_Generic_44927 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17313 Blob_Generic_17313, *PBlob_Generic_17313;

struct Blob_Generic_17313 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_39569 Blob_Generic_39569, *PBlob_Generic_39569;

struct Blob_Generic_39569 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_4932 Blob_Generic_4932, *PBlob_Generic_4932;

struct Blob_Generic_4932 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3608 Blob_Generic_3608, *PBlob_Generic_3608;

struct Blob_Generic_3608 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_41887 Blob_Generic_41887, *PBlob_Generic_41887;

struct Blob_Generic_41887 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_20968 Blob_Generic_20968, *PBlob_Generic_20968;

struct Blob_Generic_20968 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4941 Blob_Generic_4941, *PBlob_Generic_4941;

struct Blob_Generic_4941 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_29350 Blob_Generic_29350, *PBlob_Generic_29350;

struct Blob_Generic_29350 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_748 Blob_Generic_748, *PBlob_Generic_748;

struct Blob_Generic_748 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3615 Blob_Generic_3615, *PBlob_Generic_3615;

struct Blob_Generic_3615 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10737 Blob_Generic_10737, *PBlob_Generic_10737;

struct Blob_Generic_10737 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7019 Blob_PropertySig_7019, *PBlob_PropertySig_7019;

typedef struct PropertySig_7019 PropertySig_7019, *PPropertySig_7019;

typedef struct Type_180550 Type_180550, *PType_180550;

struct Type_180550 {
    struct GenericInstType_180551 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_7019 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180550 RetType; // Return type
};

struct Blob_PropertySig_7019 {
    byte Size; // coded integer - blob size
    struct PropertySig_7019 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_31660 Blob_Generic_31660, *PBlob_Generic_31660;

struct Blob_Generic_31660 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7013 Blob_PropertySig_7013, *PBlob_PropertySig_7013;

typedef struct PropertySig_7013 PropertySig_7013, *PPropertySig_7013;

typedef struct Type_180544 Type_180544, *PType_180544;

struct Type_180544 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_7013 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180544 RetType; // Return type
};

struct Blob_PropertySig_7013 {
    byte Size; // coded integer - blob size
    struct PropertySig_7013 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_51279 Blob_Generic_51279, *PBlob_Generic_51279;

struct Blob_Generic_51279 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17376 Blob_Generic_17376, *PBlob_Generic_17376;

struct Blob_Generic_17376 {
    byte Size; // coded integer - blob size
    byte Generic[27]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10523 Blob_PropertySig_10523, *PBlob_PropertySig_10523;

typedef struct PropertySig_10523 PropertySig_10523, *PPropertySig_10523;

typedef struct Type_184054 Type_184054, *PType_184054;

struct Type_184054 {
    struct GenericInstType_184055 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_10523 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184054 RetType; // Return type
};

struct Blob_PropertySig_10523 {
    byte Size; // coded integer - blob size
    struct PropertySig_10523 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_30348 Blob_Generic_30348, *PBlob_Generic_30348;

struct Blob_Generic_30348 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10743 Blob_Generic_10743, *PBlob_Generic_10743;

struct Blob_Generic_10743 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3621 Blob_Generic_3621, *PBlob_Generic_3621;

struct Blob_Generic_3621 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4952 Blob_Generic_4952, *PBlob_Generic_4952;

struct Blob_Generic_4952 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_738 Blob_Generic_738, *PBlob_Generic_738;

struct Blob_Generic_738 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10749 Blob_Generic_10749, *PBlob_Generic_10749;

struct Blob_Generic_10749 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_28028 Blob_Generic_28028, *PBlob_Generic_28028;

struct Blob_Generic_28028 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3629 Blob_Generic_3629, *PBlob_Generic_3629;

struct Blob_Generic_3629 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_42319 Blob_Generic_42319, *PBlob_Generic_42319;

struct Blob_Generic_42319 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16052 Blob_Generic_16052, *PBlob_Generic_16052;

struct Blob_Generic_16052 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16011 Blob_Generic_16011, *PBlob_Generic_16011;

struct Blob_Generic_16011 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_18678 Blob_Generic_18678, *PBlob_Generic_18678;

struct Blob_Generic_18678 {
    byte Size; // coded integer - blob size
    byte Generic[64]; // Undefined blob contents
};

typedef struct Blob_Generic_720 Blob_Generic_720, *PBlob_Generic_720;

struct Blob_Generic_720 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4961 Blob_Generic_4961, *PBlob_Generic_4961;

struct Blob_Generic_4961 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2302 Blob_Generic_2302, *PBlob_Generic_2302;

struct Blob_Generic_2302 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3639 Blob_Generic_3639, *PBlob_Generic_3639;

struct Blob_Generic_3639 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_4969 Blob_Generic_4969, *PBlob_Generic_4969;

struct Blob_Generic_4969 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_726 Blob_Generic_726, *PBlob_Generic_726;

struct Blob_Generic_726 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_10717 Blob_Generic_10717, *PBlob_Generic_10717;

struct Blob_Generic_10717 {
    byte Size; // coded integer - blob size
    byte Generic[19]; // Undefined blob contents
};

typedef struct Blob_Generic_29329 Blob_Generic_29329, *PBlob_Generic_29329;

struct Blob_Generic_29329 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_38294 Blob_Generic_38294, *PBlob_Generic_38294;

struct Blob_Generic_38294 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_44969 Blob_Generic_44969, *PBlob_Generic_44969;

struct Blob_Generic_44969 {
    byte Size; // coded integer - blob size
    byte Generic[58]; // Undefined blob contents
};

typedef struct Blob_Generic_17355 Blob_Generic_17355, *PBlob_Generic_17355;

struct Blob_Generic_17355 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_960 Blob_PropertySig_960, *PBlob_PropertySig_960;

typedef struct PropertySig_960 PropertySig_960, *PPropertySig_960;

typedef struct Type_174491 Type_174491, *PType_174491;

struct Type_174491 {
    struct GenericInstType_174492 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_960 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174491 RetType; // Return type
};

struct Blob_PropertySig_960 {
    byte Size; // coded integer - blob size
    struct PropertySig_960 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_4976 Blob_Generic_4976, *PBlob_Generic_4976;

struct Blob_Generic_4976 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_30327 Blob_Generic_30327, *PBlob_Generic_30327;

struct Blob_Generic_30327 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2312 Blob_Generic_2312, *PBlob_Generic_2312;

struct Blob_Generic_2312 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2318 Blob_Generic_2318, *PBlob_Generic_2318;

struct Blob_Generic_2318 {
    byte Size; // coded integer - blob size
    byte Generic[24]; // Undefined blob contents
};

typedef struct Blob_Generic_32984 Blob_Generic_32984, *PBlob_Generic_32984;

struct Blob_Generic_32984 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3648 Blob_Generic_3648, *PBlob_Generic_3648;

struct Blob_Generic_3648 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_714 Blob_Generic_714, *PBlob_Generic_714;

struct Blob_Generic_714 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_28007 Blob_Generic_28007, *PBlob_Generic_28007;

struct Blob_Generic_28007 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1701 Blob_PropertySig_1701, *PBlob_PropertySig_1701;

typedef struct PropertySig_1701 PropertySig_1701, *PPropertySig_1701;

typedef struct Type_175232 Type_175232, *PType_175232;

struct Type_175232 {
    struct ValueType.conflict5 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_1701 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175232 RetType; // Return type
};

struct Blob_PropertySig_1701 {
    byte Size; // coded integer - blob size
    struct PropertySig_1701 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8421 Blob_Generic_8421, *PBlob_Generic_8421;

struct Blob_Generic_8421 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5397 Blob_Generic_5397, *PBlob_Generic_5397;

struct Blob_Generic_5397 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_8428 Blob_Generic_8428, *PBlob_Generic_8428;

struct Blob_Generic_8428 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_14338 Blob_Generic_14338, *PBlob_Generic_14338;

struct Blob_Generic_14338 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_15667 Blob_Generic_15667, *PBlob_Generic_15667;

struct Blob_Generic_15667 {
    byte Size; // coded integer - blob size
    byte Generic[37]; // Undefined blob contents
};

typedef struct Blob_Generic_52605 Blob_Generic_52605, *PBlob_Generic_52605;

struct Blob_Generic_52605 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_Generic_48591 Blob_Generic_48591, *PBlob_Generic_48591;

struct Blob_Generic_48591 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_35263 Blob_Generic_35263, *PBlob_Generic_35263;

struct Blob_Generic_35263 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_40627 Blob_Generic_40627, *PBlob_Generic_40627;

struct Blob_Generic_40627 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_9762 Blob_Generic_9762, *PBlob_Generic_9762;

struct Blob_Generic_9762 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_41940 Blob_Generic_41940, *PBlob_Generic_41940;

struct Blob_Generic_41940 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7109 Blob_Generic_7109, *PBlob_Generic_7109;

struct Blob_Generic_7109 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_50897 Blob_Generic_50897, *PBlob_Generic_50897;

struct Blob_Generic_50897 {
    byte Size; // coded integer - blob size
    byte Generic[65]; // Undefined blob contents
};

typedef struct Blob_Generic_47246 Blob_Generic_47246, *PBlob_Generic_47246;

struct Blob_Generic_47246 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4079 Blob_Generic_4079, *PBlob_Generic_4079;

struct Blob_Generic_4079 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2182 Blob_PropertySig_2182, *PBlob_PropertySig_2182;

typedef struct PropertySig_2182 PropertySig_2182, *PPropertySig_2182;

typedef struct Type_175713 Type_175713, *PType_175713;

struct Type_175713 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_2182 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175713 RetType; // Return type
};

struct Blob_PropertySig_2182 {
    byte Size; // coded integer - blob size
    struct PropertySig_2182 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8438 Blob_Generic_8438, *PBlob_Generic_8438;

struct Blob_Generic_8438 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_48570 Blob_Generic_48570, *PBlob_Generic_48570;

struct Blob_Generic_48570 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_28981 Blob_Generic_28981, *PBlob_Generic_28981;

struct Blob_Generic_28981 {
    byte Size; // coded integer - blob size
    byte Generic[58]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2176 Blob_PropertySig_2176, *PBlob_PropertySig_2176;

typedef struct PropertySig_2176 PropertySig_2176, *PPropertySig_2176;

typedef struct Type_175707 Type_175707, *PType_175707;

struct Type_175707 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_2176 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175707 RetType; // Return type
};

struct Blob_PropertySig_2176 {
    byte Size; // coded integer - blob size
    struct PropertySig_2176 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1803 Blob_Generic_1803, *PBlob_Generic_1803;

struct Blob_Generic_1803 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_27657 Blob_Generic_27657, *PBlob_Generic_27657;

struct Blob_Generic_27657 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_26329 Blob_Generic_26329, *PBlob_Generic_26329;

struct Blob_Generic_26329 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11281 Blob_Generic_11281, *PBlob_Generic_11281;

struct Blob_Generic_11281 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_9770 Blob_Generic_9770, *PBlob_Generic_9770;

struct Blob_Generic_9770 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4087 Blob_Generic_4087, *PBlob_Generic_4087;

struct Blob_Generic_4087 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_7119 Blob_Generic_7119, *PBlob_Generic_7119;

struct Blob_Generic_7119 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_39615 Blob_Generic_39615, *PBlob_Generic_39615;

struct Blob_Generic_39615 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_16975 Blob_Generic_16975, *PBlob_Generic_16975;

struct Blob_Generic_16975 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_9778 Blob_Generic_9778, *PBlob_Generic_9778;

struct Blob_Generic_9778 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_8446 Blob_Generic_8446, *PBlob_Generic_8446;

struct Blob_Generic_8446 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_14317 Blob_Generic_14317, *PBlob_Generic_14317;

struct Blob_Generic_14317 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6502 Blob_PropertySig_6502, *PBlob_PropertySig_6502;

typedef struct PropertySig_6502 PropertySig_6502, *PPropertySig_6502;

typedef struct Type_180033 Type_180033, *PType_180033;

struct Type_180033 {
    struct ValueType.conflict25 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_6502 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180033 RetType; // Return type
};

struct Blob_PropertySig_6502 {
    byte Size; // coded integer - blob size
    struct PropertySig_6502 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1811 Blob_Generic_1811, *PBlob_Generic_1811;

struct Blob_Generic_1811 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_1819 Blob_Generic_1819, *PBlob_Generic_1819;

struct Blob_Generic_1819 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_40606 Blob_Generic_40606, *PBlob_Generic_40606;

struct Blob_Generic_40606 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4095 Blob_Generic_4095, *PBlob_Generic_4095;

struct Blob_Generic_4095 {
    byte Size; // coded integer - blob size
    byte Generic[23]; // Undefined blob contents
};

typedef struct Blob_Generic_8456 Blob_Generic_8456, *PBlob_Generic_8456;

struct Blob_Generic_8456 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_11295 Blob_Generic_11295, *PBlob_Generic_11295;

struct Blob_Generic_11295 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_47225 Blob_Generic_47225, *PBlob_Generic_47225;

struct Blob_Generic_47225 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_50876 Blob_Generic_50876, *PBlob_Generic_50876;

struct Blob_Generic_50876 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9789 Blob_Generic_9789, *PBlob_Generic_9789;

struct Blob_Generic_9789 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_28960 Blob_Generic_28960, *PBlob_Generic_28960;

struct Blob_Generic_28960 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_27636 Blob_Generic_27636, *PBlob_Generic_27636;

struct Blob_Generic_27636 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_36581 Blob_Generic_36581, *PBlob_Generic_36581;

struct Blob_Generic_36581 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_1 Blob_Generic_1, *PBlob_Generic_1;

struct Blob_Generic_1 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_9796 Blob_Generic_9796, *PBlob_Generic_9796;

struct Blob_Generic_9796 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_7134 Blob_Generic_7134, *PBlob_Generic_7134;

struct Blob_Generic_7134 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_8463 Blob_Generic_8463, *PBlob_Generic_8463;

struct Blob_Generic_8463 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_17404 Blob_Generic_17404, *PBlob_Generic_17404;

struct Blob_Generic_17404 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_26350 Blob_Generic_26350, *PBlob_Generic_26350;

struct Blob_Generic_26350 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1833 Blob_Generic_1833, *PBlob_Generic_1833;

struct Blob_Generic_1833 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_1839 Blob_Generic_1839, *PBlob_Generic_1839;

struct Blob_Generic_1839 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_37000 Blob_Generic_37000, *PBlob_Generic_37000;

struct Blob_Generic_37000 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18743 Blob_Generic_18743, *PBlob_Generic_18743;

struct Blob_Generic_18743 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_39661 Blob_Generic_39661, *PBlob_Generic_39661;

struct Blob_Generic_39661 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8478 Blob_Generic_8478, *PBlob_Generic_8478;

struct Blob_Generic_8478 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_8472 Blob_Generic_8472, *PBlob_Generic_8472;

struct Blob_Generic_8472 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7142 Blob_Generic_7142, *PBlob_Generic_7142;

struct Blob_Generic_7142 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_38336 Blob_Generic_38336, *PBlob_Generic_38336;

struct Blob_Generic_38336 {
    byte Size; // coded integer - blob size
    byte Generic[66]; // Undefined blob contents
};

typedef struct Blob_Generic_41982 Blob_Generic_41982, *PBlob_Generic_41982;

struct Blob_Generic_41982 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_47288 Blob_Generic_47288, *PBlob_Generic_47288;

struct Blob_Generic_47288 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_31716 Blob_Generic_31716, *PBlob_Generic_31716;

struct Blob_Generic_31716 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_52637 Blob_Generic_52637, *PBlob_Generic_52637;

struct Blob_Generic_52637 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_26371 Blob_Generic_26371, *PBlob_Generic_26371;

struct Blob_Generic_26371 {
    byte Size; // coded integer - blob size
    byte Generic[69]; // Undefined blob contents
};

typedef struct Blob_Generic_1845 Blob_Generic_1845, *PBlob_Generic_1845;

struct Blob_Generic_1845 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_51300 Blob_Generic_51300, *PBlob_Generic_51300;

struct Blob_Generic_51300 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_25035 Blob_Generic_25035, *PBlob_Generic_25035;

struct Blob_Generic_25035 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_18 Blob_MethodRefSig_18, *PBlob_MethodRefSig_18;

typedef struct MethodRefSig_18 MethodRefSig_18, *PMethodRefSig_18;

typedef struct Type_173549 Type_173549, *PType_173549;

struct Type_173549 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_18 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_173549 RetType;
};

struct Blob_MethodRefSig_18 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_18 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_7150 Blob_Generic_7150, *PBlob_Generic_7150;

struct Blob_Generic_7150 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_14392 Blob_Generic_14392, *PBlob_Generic_14392;

struct Blob_Generic_14392 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_13060 Blob_Generic_13060, *PBlob_Generic_13060;

struct Blob_Generic_13060 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8485 Blob_Generic_8485, *PBlob_Generic_8485;

struct Blob_Generic_8485 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_8491 Blob_Generic_8491, *PBlob_Generic_8491;

struct Blob_Generic_8491 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_35284 Blob_Generic_35284, *PBlob_Generic_35284;

struct Blob_Generic_35284 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8498 Blob_Generic_8498, *PBlob_Generic_8498;

struct Blob_Generic_8498 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_13030 Blob_Generic_13030, *PBlob_Generic_13030;

struct Blob_Generic_13030 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_7163 Blob_Generic_7163, *PBlob_Generic_7163;

struct Blob_Generic_7163 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_41961 Blob_Generic_41961, *PBlob_Generic_41961;

struct Blob_Generic_41961 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11797 Blob_PropertySig_11797, *PBlob_PropertySig_11797;

typedef struct PropertySig_11797 PropertySig_11797, *PPropertySig_11797;

typedef struct Type_185328 Type_185328, *PType_185328;

struct Type_185328 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_11797 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185328 RetType; // Return type
};

struct Blob_PropertySig_11797 {
    byte Size; // coded integer - blob size
    struct PropertySig_11797 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_38315 Blob_Generic_38315, *PBlob_Generic_38315;

struct Blob_Generic_38315 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1860 Blob_Generic_1860, *PBlob_Generic_1860;

struct Blob_Generic_1860 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_13039 Blob_Generic_13039, *PBlob_Generic_13039;

struct Blob_Generic_13039 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_47267 Blob_Generic_47267, *PBlob_Generic_47267;

struct Blob_Generic_47267 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2286 Blob_Generic_2286, *PBlob_Generic_2286;

struct Blob_Generic_2286 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5311 Blob_Generic_5311, *PBlob_Generic_5311;

struct Blob_Generic_5311 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12558 Blob_Generic_12558, *PBlob_Generic_12558;

struct Blob_Generic_12558 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_6643 Blob_Generic_6643, *PBlob_Generic_6643;

struct Blob_Generic_6643 {
    byte Size; // coded integer - blob size
    byte Generic[19]; // Undefined blob contents
};

typedef struct Blob_Generic_7975 Blob_Generic_7975, *PBlob_Generic_7975;

struct Blob_Generic_7975 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5319 Blob_Generic_5319, *PBlob_Generic_5319;

struct Blob_Generic_5319 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_25861 Blob_Generic_25861, *PBlob_Generic_25861;

struct Blob_Generic_25861 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4740 Blob_PropertySig_4740, *PBlob_PropertySig_4740;

typedef struct PropertySig_4740 PropertySig_4740, *PPropertySig_4740;

typedef struct Type_178271 Type_178271, *PType_178271;

struct Type_178271 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4740 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178271 RetType; // Return type
};

struct Blob_PropertySig_4740 {
    byte Size; // coded integer - blob size
    struct PropertySig_4740 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_4746 Blob_PropertySig_4746, *PBlob_PropertySig_4746;

typedef struct PropertySig_4746 PropertySig_4746, *PPropertySig_4746;

typedef struct Type_178277 Type_178277, *PType_178277;

struct Type_178277 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4746 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178277 RetType; // Return type
};

struct Blob_PropertySig_4746 {
    byte Size; // coded integer - blob size
    struct PropertySig_4746 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_7981 Blob_Generic_7981, *PBlob_Generic_7981;

struct Blob_Generic_7981 {
    byte Size; // coded integer - blob size
    byte Generic[25]; // Undefined blob contents
};

typedef struct Blob_Generic_11231 Blob_Generic_11231, *PBlob_Generic_11231;

struct Blob_Generic_11231 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2294 Blob_Generic_2294, *PBlob_Generic_2294;

struct Blob_Generic_2294 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_CustomAttrib_13030 Blob_CustomAttrib_13030, *PBlob_CustomAttrib_13030;

struct Blob_CustomAttrib_13030 {
    byte Size; // coded integer - blob size
    struct CustomAttrib_13030 CustomAttrib; // A CustomAttrib blob stores values of fixed or named parameters supplied when instantiating a custom attribute
};

typedef struct Blob_Generic_5329 Blob_Generic_5329, *PBlob_Generic_5329;

struct Blob_Generic_5329 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12568 Blob_Generic_12568, *PBlob_Generic_12568;

struct Blob_Generic_12568 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_11239 Blob_Generic_11239, *PBlob_Generic_11239;

struct Blob_Generic_11239 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4752 Blob_PropertySig_4752, *PBlob_PropertySig_4752;

typedef struct PropertySig_4752 PropertySig_4752, *PPropertySig_4752;

typedef struct Type_178283 Type_178283, *PType_178283;

struct Type_178283 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4752 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178283 RetType; // Return type
};

struct Blob_PropertySig_4752 {
    byte Size; // coded integer - blob size
    struct PropertySig_4752 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_32163 Blob_Generic_32163, *PBlob_Generic_32163;

struct Blob_Generic_32163 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_37852 Blob_Generic_37852, *PBlob_Generic_37852;

struct Blob_Generic_37852 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4758 Blob_PropertySig_4758, *PBlob_PropertySig_4758;

typedef struct PropertySig_4758 PropertySig_4758, *PPropertySig_4758;

typedef struct Type_178289 Type_178289, *PType_178289;

struct Type_178289 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4758 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178289 RetType; // Return type
};

struct Blob_PropertySig_4758 {
    byte Size; // coded integer - blob size
    struct PropertySig_4758 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_33490 Blob_Generic_33490, *PBlob_Generic_33490;

struct Blob_Generic_33490 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_6663 Blob_Generic_6663, *PBlob_Generic_6663;

struct Blob_Generic_6663 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_46785 Blob_Generic_46785, *PBlob_Generic_46785;

struct Blob_Generic_46785 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12532 Blob_Generic_12532, *PBlob_Generic_12532;

struct Blob_Generic_12532 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6669 Blob_Generic_6669, *PBlob_Generic_6669;

struct Blob_Generic_6669 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_21484 Blob_Generic_21484, *PBlob_Generic_21484;

struct Blob_Generic_21484 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_41097 Blob_Generic_41097, *PBlob_Generic_41097;

struct Blob_Generic_41097 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11205 Blob_Generic_11205, *PBlob_Generic_11205;

struct Blob_Generic_11205 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_13866 Blob_Generic_13866, *PBlob_Generic_13866;

struct Blob_Generic_13866 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_5337 Blob_Generic_5337, *PBlob_Generic_5337;

struct Blob_Generic_5337 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_33469 Blob_Generic_33469, *PBlob_Generic_33469;

struct Blob_Generic_33469 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1691 Blob_PropertySig_1691, *PBlob_PropertySig_1691;

typedef struct PropertySig_1691 PropertySig_1691, *PPropertySig_1691;

typedef struct Type_175222 Type_175222, *PType_175222;

struct Type_175222 {
    struct GenericInstType_175223 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1691 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175222 RetType; // Return type
};

struct Blob_PropertySig_1691 {
    byte Size; // coded integer - blob size
    struct PropertySig_1691 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_34794 Blob_Generic_34794, *PBlob_Generic_34794;

struct Blob_Generic_34794 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_45449 Blob_Generic_45449, *PBlob_Generic_45449;

struct Blob_Generic_45449 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_Generic_5343 Blob_Generic_5343, *PBlob_Generic_5343;

struct Blob_Generic_5343 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12540 Blob_Generic_12540, *PBlob_Generic_12540;

struct Blob_Generic_12540 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_20163 Blob_Generic_20163, *PBlob_Generic_20163;

struct Blob_Generic_20163 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_9707 Blob_Generic_9707, *PBlob_Generic_9707;

struct Blob_Generic_9707 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_6675 Blob_Generic_6675, *PBlob_Generic_6675;

struct Blob_Generic_6675 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9701 Blob_Generic_9701, *PBlob_Generic_9701;

struct Blob_Generic_9701 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11215 Blob_Generic_11215, *PBlob_Generic_11215;

struct Blob_Generic_11215 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_12548 Blob_Generic_12548, *PBlob_Generic_12548;

struct Blob_Generic_12548 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_12281 Blob_PropertySig_12281, *PBlob_PropertySig_12281;

typedef struct PropertySig_12281 PropertySig_12281, *PPropertySig_12281;

typedef struct Type_185812 Type_185812, *PType_185812;

struct Type_185812 {
    struct GenericInstType_185813 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_12281 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185812 RetType; // Return type
};

struct Blob_PropertySig_12281 {
    byte Size; // coded integer - blob size
    struct PropertySig_12281 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_37831 Blob_Generic_37831, *PBlob_Generic_37831;

struct Blob_Generic_37831 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4734 Blob_PropertySig_4734, *PBlob_PropertySig_4734;

typedef struct PropertySig_4734 PropertySig_4734, *PPropertySig_4734;

typedef struct Type_178265 Type_178265, *PType_178265;

struct Type_178265 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4734 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178265 RetType; // Return type
};

struct Blob_PropertySig_4734 {
    byte Size; // coded integer - blob size
    struct PropertySig_4734 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_32142 Blob_Generic_32142, *PBlob_Generic_32142;

struct Blob_Generic_32142 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_49809 Blob_Generic_49809, *PBlob_Generic_49809;

struct Blob_Generic_49809 {
    byte Size; // coded integer - blob size
    byte Generic[63]; // Undefined blob contents
};

typedef struct Blob_Generic_24528 Blob_Generic_24528, *PBlob_Generic_24528;

struct Blob_Generic_24528 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_48549 Blob_Generic_48549, *PBlob_Generic_48549;

struct Blob_Generic_48549 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11261 Blob_Generic_11261, *PBlob_Generic_11261;

struct Blob_Generic_11261 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_12591 Blob_Generic_12591, *PBlob_Generic_12591;

struct Blob_Generic_12591 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5351 Blob_Generic_5351, *PBlob_Generic_5351;

struct Blob_Generic_5351 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_6681 Blob_Generic_6681, *PBlob_Generic_6681;

struct Blob_Generic_6681 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_16954 Blob_Generic_16954, *PBlob_Generic_16954;

struct Blob_Generic_16954 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12599 Blob_Generic_12599, *PBlob_Generic_12599;

struct Blob_Generic_12599 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_49873 Blob_Generic_49873, *PBlob_Generic_49873;

struct Blob_Generic_49873 {
    byte Size; // coded integer - blob size
    byte Generic[63]; // Undefined blob contents
};

typedef struct Blob_Generic_6687 Blob_Generic_6687, *PBlob_Generic_6687;

struct Blob_Generic_6687 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9719 Blob_Generic_9719, *PBlob_Generic_9719;

struct Blob_Generic_9719 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_35222 Blob_Generic_35222, *PBlob_Generic_35222;

struct Blob_Generic_35222 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_5361 Blob_Generic_5361, *PBlob_Generic_5361;

struct Blob_Generic_5361 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_6693 Blob_Generic_6693, *PBlob_Generic_6693;

struct Blob_Generic_6693 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_11271 Blob_Generic_11271, *PBlob_Generic_11271;

struct Blob_Generic_11271 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4033 Blob_Generic_4033, *PBlob_Generic_4033;

struct Blob_Generic_4033 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_44175 Blob_Generic_44175, *PBlob_Generic_44175;

struct Blob_Generic_44175 {
    byte Size; // coded integer - blob size
    byte Generic[72]; // Undefined blob contents
};

typedef struct Blob_Generic_9729 Blob_Generic_9729, *PBlob_Generic_9729;

struct Blob_Generic_9729 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_50855 Blob_Generic_50855, *PBlob_Generic_50855;

struct Blob_Generic_50855 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7823 Blob_PropertySig_7823, *PBlob_PropertySig_7823;

typedef struct PropertySig_7823 PropertySig_7823, *PPropertySig_7823;

typedef struct Type_181354 Type_181354, *PType_181354;

struct Type_181354 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_7823 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181354 RetType; // Return type
};

struct Blob_PropertySig_7823 {
    byte Size; // coded integer - blob size
    struct PropertySig_7823 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_24582 Blob_Generic_24582, *PBlob_Generic_24582;

struct Blob_Generic_24582 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_27615 Blob_Generic_27615, *PBlob_Generic_27615;

struct Blob_Generic_27615 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_36560 Blob_Generic_36560, *PBlob_Generic_36560;

struct Blob_Generic_36560 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5371 Blob_Generic_5371, *PBlob_Generic_5371;

struct Blob_Generic_5371 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_48528 Blob_Generic_48528, *PBlob_Generic_48528;

struct Blob_Generic_48528 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4043 Blob_Generic_4043, *PBlob_Generic_4043;

struct Blob_Generic_4043 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_5379 Blob_Generic_5379, *PBlob_Generic_5379;

struct Blob_Generic_5379 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_16933 Blob_Generic_16933, *PBlob_Generic_16933;

struct Blob_Generic_16933 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12578 Blob_Generic_12578, *PBlob_Generic_12578;

struct Blob_Generic_12578 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_9739 Blob_Generic_9739, *PBlob_Generic_9739;

struct Blob_Generic_9739 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_11247 Blob_Generic_11247, *PBlob_Generic_11247;

struct Blob_Generic_11247 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12897.conflict Blob_ConstantSig_12897.conflict, *PBlob_ConstantSig_12897.conflict;

typedef struct ConstantSig_12897.conflict ConstantSig_12897.conflict, *PConstantSig_12897.conflict;

struct ConstantSig_12897.conflict {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12897.conflict {
    byte Size; // coded integer - blob size
    struct ConstantSig_12897.conflict ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_8404 Blob_Generic_8404, *PBlob_Generic_8404;

struct Blob_Generic_8404 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_36539 Blob_Generic_36539, *PBlob_Generic_36539;

struct Blob_Generic_36539 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25882 Blob_Generic_25882, *PBlob_Generic_25882;

struct Blob_Generic_25882 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4764 Blob_PropertySig_4764, *PBlob_PropertySig_4764;

typedef struct PropertySig_4764 PropertySig_4764, *PPropertySig_4764;

typedef struct Type_178295 Type_178295, *PType_178295;

struct Type_178295 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4764 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178295 RetType; // Return type
};

struct Blob_PropertySig_4764 {
    byte Size; // coded integer - blob size
    struct PropertySig_4764 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_2105 Blob_PropertySig_2105, *PBlob_PropertySig_2105;

typedef struct PropertySig_2105 PropertySig_2105, *PPropertySig_2105;

typedef struct Type_175636 Type_175636, *PType_175636;

struct Type_175636 {
    struct GenericInstType_175637 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2105 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175636 RetType; // Return type
};

struct Blob_PropertySig_2105 {
    byte Size; // coded integer - blob size
    struct PropertySig_2105 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_28915 Blob_Generic_28915, *PBlob_Generic_28915;

struct Blob_Generic_28915 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_5386 Blob_Generic_5386, *PBlob_Generic_5386;

struct Blob_Generic_5386 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_84 Blob_MethodRefSig_84, *PBlob_MethodRefSig_84;

typedef struct MethodRefSig_84 MethodRefSig_84, *PMethodRefSig_84;

typedef struct Type_173615 Type_173615, *PType_173615;

typedef struct Type_173616 Type_173616, *PType_173616;

struct Type_173615 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_173616 {
    enum TypeCode ELEMENT_TYPE_STRING;
};

struct MethodRefSig_84 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_173615 RetType;
    struct Type_173616 Param0;
};

struct Blob_MethodRefSig_84 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_84 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_23235 Blob_Generic_23235, *PBlob_Generic_23235;

struct Blob_Generic_23235 {
    byte Size; // coded integer - blob size
    byte Generic[69]; // Undefined blob contents
};

typedef struct Blob_Generic_4053 Blob_Generic_4053, *PBlob_Generic_4053;

struct Blob_Generic_4053 {
    byte Size; // coded integer - blob size
    byte Generic[25]; // Undefined blob contents
};

typedef struct Blob_Generic_9749 Blob_Generic_9749, *PBlob_Generic_9749;

struct Blob_Generic_9749 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_8414 Blob_Generic_8414, *PBlob_Generic_8414;

struct Blob_Generic_8414 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_50834 Blob_Generic_50834, *PBlob_Generic_50834;

struct Blob_Generic_50834 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_15616 Blob_Generic_15616, *PBlob_Generic_15616;

struct Blob_Generic_15616 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_Generic_37873 Blob_Generic_37873, *PBlob_Generic_37873;

struct Blob_Generic_37873 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2115 Blob_PropertySig_2115, *PBlob_PropertySig_2115;

typedef struct PropertySig_2115 PropertySig_2115, *PPropertySig_2115;

typedef struct Type_175646 Type_175646, *PType_175646;

struct Type_175646 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_2115 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175646 RetType; // Return type
};

struct Blob_PropertySig_2115 {
    byte Size; // coded integer - blob size
    struct PropertySig_2115 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_22874 Blob_Generic_22874, *PBlob_Generic_22874;

struct Blob_Generic_22874 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2200 Blob_Generic_2200, *PBlob_Generic_2200;

struct Blob_Generic_2200 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_664 Blob_Generic_664, *PBlob_Generic_664;

struct Blob_Generic_664 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10897 Blob_Generic_10897, *PBlob_Generic_10897;

struct Blob_Generic_10897 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3534 Blob_Generic_3534, *PBlob_Generic_3534;

struct Blob_Generic_3534 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_4864 Blob_Generic_4864, *PBlob_Generic_4864;

struct Blob_Generic_4864 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_28179 Blob_Generic_28179, *PBlob_Generic_28179;

struct Blob_Generic_28179 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_33523 Blob_Generic_33523, *PBlob_Generic_33523;

struct Blob_Generic_33523 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_30495 Blob_Generic_30495, *PBlob_Generic_30495;

struct Blob_Generic_30495 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34851 Blob_Generic_34851, *PBlob_Generic_34851;

struct Blob_Generic_34851 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1631 Blob_PropertySig_1631, *PBlob_PropertySig_1631;

typedef struct PropertySig_1631 PropertySig_1631, *PPropertySig_1631;

typedef struct Type_175162 Type_175162, *PType_175162;

struct Type_175162 {
    struct ValueType.conflict3 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_1631 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175162 RetType; // Return type
};

struct Blob_PropertySig_1631 {
    byte Size; // coded integer - blob size
    struct PropertySig_1631 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_46849 Blob_Generic_46849, *PBlob_Generic_46849;

struct Blob_Generic_46849 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_45518 Blob_Generic_45518, *PBlob_Generic_45518;

struct Blob_Generic_45518 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25903 Blob_Generic_25903, *PBlob_Generic_25903;

struct Blob_Generic_25903 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_20225 Blob_Generic_20225, *PBlob_Generic_20225;

struct Blob_Generic_20225 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_4870 Blob_Generic_4870, *PBlob_Generic_4870;

struct Blob_Generic_4870 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3543 Blob_Generic_3543, *PBlob_Generic_3543;

struct Blob_Generic_3543 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_2210 Blob_Generic_2210, *PBlob_Generic_2210;

struct Blob_Generic_2210 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4876 Blob_Generic_4876, *PBlob_Generic_4876;

struct Blob_Generic_4876 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_655 Blob_Generic_655, *PBlob_Generic_655;

struct Blob_Generic_655 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_12607 Blob_Generic_12607, *PBlob_Generic_12607;

struct Blob_Generic_12607 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_7904 Blob_Generic_7904, *PBlob_Generic_7904;

struct Blob_Generic_7904 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_42466 Blob_Generic_42466, *PBlob_Generic_42466;

struct Blob_Generic_42466 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_7912 Blob_Generic_7912, *PBlob_Generic_7912;

struct Blob_Generic_7912 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2220 Blob_Generic_2220, *PBlob_Generic_2220;

struct Blob_Generic_2220 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3552 Blob_Generic_3552, *PBlob_Generic_3552;

struct Blob_Generic_3552 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4882 Blob_Generic_4882, *PBlob_Generic_4882;

struct Blob_Generic_4882 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3558 Blob_Generic_3558, *PBlob_Generic_3558;

struct Blob_Generic_3558 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_646 Blob_Generic_646, *PBlob_Generic_646;

struct Blob_Generic_646 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10875 Blob_Generic_10875, *PBlob_Generic_10875;

struct Blob_Generic_10875 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4887 Blob_Generic_4887, *PBlob_Generic_4887;

struct Blob_Generic_4887 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_34830 Blob_Generic_34830, *PBlob_Generic_34830;

struct Blob_Generic_34830 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_30474 Blob_Generic_30474, *PBlob_Generic_30474;

struct Blob_Generic_30474 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19210 Blob_Generic_19210, *PBlob_Generic_19210;

struct Blob_Generic_19210 {
    byte Size; // coded integer - blob size
    byte Generic[37]; // Undefined blob contents
};

typedef struct Blob_Generic_41139 Blob_Generic_41139, *PBlob_Generic_41139;

struct Blob_Generic_41139 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2230 Blob_Generic_2230, *PBlob_Generic_2230;

struct Blob_Generic_2230 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_3564 Blob_Generic_3564, *PBlob_Generic_3564;

struct Blob_Generic_3564 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_4894 Blob_Generic_4894, *PBlob_Generic_4894;

struct Blob_Generic_4894 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_10883 Blob_Generic_10883, *PBlob_Generic_10883;

struct Blob_Generic_10883 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_13910 Blob_Generic_13910, *PBlob_Generic_13910;

struct Blob_Generic_13910 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_7920 Blob_Generic_7920, *PBlob_Generic_7920;

struct Blob_Generic_7920 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_637 Blob_Generic_637, *PBlob_Generic_637;

struct Blob_Generic_637 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_7929 Blob_Generic_7929, *PBlob_Generic_7929;

struct Blob_Generic_7929 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_21539 Blob_Generic_21539, *PBlob_Generic_21539;

struct Blob_Generic_21539 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19269 Blob_Generic_19269, *PBlob_Generic_19269;

struct Blob_Generic_19269 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3576 Blob_Generic_3576, *PBlob_Generic_3576;

struct Blob_Generic_3576 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_7935 Blob_Generic_7935, *PBlob_Generic_7935;

struct Blob_Generic_7935 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_2243 Blob_Generic_2243, *PBlob_Generic_2243;

struct Blob_Generic_2243 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11303 Blob_Generic_11303, *PBlob_Generic_11303;

struct Blob_Generic_11303 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_37926 Blob_Generic_37926, *PBlob_Generic_37926;

struct Blob_Generic_37926 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_12638 Blob_Generic_12638, *PBlob_Generic_12638;

struct Blob_Generic_12638 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_32232 Blob_Generic_32232, *PBlob_Generic_32232;

struct Blob_Generic_32232 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_33565 Blob_Generic_33565, *PBlob_Generic_33565;

struct Blob_Generic_33565 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_34893 Blob_Generic_34893, *PBlob_Generic_34893;

struct Blob_Generic_34893 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_2251 Blob_Generic_2251, *PBlob_Generic_2251;

struct Blob_Generic_2251 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_693 Blob_Generic_693, *PBlob_Generic_693;

struct Blob_Generic_693 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_21595 Blob_Generic_21595, *PBlob_Generic_21595;

struct Blob_Generic_21595 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_20265 Blob_Generic_20265, *PBlob_Generic_20265;

struct Blob_Generic_20265 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41181 Blob_Generic_41181, *PBlob_Generic_41181;

struct Blob_Generic_41181 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_46870 Blob_Generic_46870, *PBlob_Generic_46870;

struct Blob_Generic_46870 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3586 Blob_Generic_3586, *PBlob_Generic_3586;

struct Blob_Generic_3586 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_7945 Blob_Generic_7945, *PBlob_Generic_7945;

struct Blob_Generic_7945 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_11311 Blob_Generic_11311, *PBlob_Generic_11311;

struct Blob_Generic_11311 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_2259 Blob_Generic_2259, *PBlob_Generic_2259;

struct Blob_Generic_2259 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1681 Blob_PropertySig_1681, *PBlob_PropertySig_1681;

typedef struct PropertySig_1681 PropertySig_1681, *PPropertySig_1681;

typedef struct Type_175212 Type_175212, *PType_175212;

struct Type_175212 {
    struct GenericInstType_175213 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1681 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175212 RetType; // Return type
};

struct Blob_PropertySig_1681 {
    byte Size; // coded integer - blob size
    struct PropertySig_1681 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_24624 Blob_Generic_24624, *PBlob_Generic_24624;

struct Blob_Generic_24624 {
    byte Size; // coded integer - blob size
    byte Generic[67]; // Undefined blob contents
};

typedef struct Blob_Generic_19248 Blob_Generic_19248, *PBlob_Generic_19248;

struct Blob_Generic_19248 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_22895 Blob_Generic_22895, *PBlob_Generic_22895;

struct Blob_Generic_22895 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_680 Blob_Generic_680, *PBlob_Generic_680;

struct Blob_Generic_680 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_3598 Blob_Generic_3598, *PBlob_Generic_3598;

struct Blob_Generic_3598 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_7955 Blob_Generic_7955, *PBlob_Generic_7955;

struct Blob_Generic_7955 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_21560 Blob_Generic_21560, *PBlob_Generic_21560;

struct Blob_Generic_21560 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_684 Blob_Generic_684, *PBlob_Generic_684;

struct Blob_Generic_684 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_689 Blob_Generic_689, *PBlob_Generic_689;

struct Blob_Generic_689 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_6623 Blob_Generic_6623, *PBlob_Generic_6623;

struct Blob_Generic_6623 {
    byte Size; // coded integer - blob size
    byte Generic[19]; // Undefined blob contents
};

typedef struct Blob_Generic_12618 Blob_Generic_12618, *PBlob_Generic_12618;

struct Blob_Generic_12618 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_32211 Blob_Generic_32211, *PBlob_Generic_32211;

struct Blob_Generic_32211 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_33544 Blob_Generic_33544, *PBlob_Generic_33544;

struct Blob_Generic_33544 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34872 Blob_Generic_34872, *PBlob_Generic_34872;

struct Blob_Generic_34872 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_45539 Blob_Generic_45539, *PBlob_Generic_45539;

struct Blob_Generic_45539 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_25924 Blob_Generic_25924, *PBlob_Generic_25924;

struct Blob_Generic_25924 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_2270 Blob_Generic_2270, *PBlob_Generic_2270;

struct Blob_Generic_2270 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_672 Blob_Generic_672, *PBlob_Generic_672;

struct Blob_Generic_672 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_42499 Blob_Generic_42499, *PBlob_Generic_42499;

struct Blob_Generic_42499 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5303 Blob_Generic_5303, *PBlob_Generic_5303;

struct Blob_Generic_5303 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2276 Blob_Generic_2276, *PBlob_Generic_2276;

struct Blob_Generic_2276 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_FieldSig_12678 Blob_FieldSig_12678, *PBlob_FieldSig_12678;

typedef struct FieldSig_12678 FieldSig_12678, *PFieldSig_12678;

typedef struct Type_186208 Type_186208, *PType_186208;

struct Type_186208 {
    struct ValueType.conflict44 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_12678 {
    byte FIELD; // Magic (0x06)
    struct Type_186208 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_12678 {
    byte Size; // coded integer - blob size
    struct FieldSig_12678 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_13954 Blob_Generic_13954, *PBlob_Generic_13954;

struct Blob_Generic_13954 {
    byte Size; // coded integer - blob size
    byte Generic[28]; // Undefined blob contents
};

typedef struct Blob_Generic_7965 Blob_Generic_7965, *PBlob_Generic_7965;

struct Blob_Generic_7965 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_41160 Blob_Generic_41160, *PBlob_Generic_41160;

struct Blob_Generic_41160 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12628 Blob_Generic_12628, *PBlob_Generic_12628;

struct Blob_Generic_12628 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_24603 Blob_Generic_24603, *PBlob_Generic_24603;

struct Blob_Generic_24603 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_43733 Blob_Generic_43733, *PBlob_Generic_43733;

struct Blob_Generic_43733 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_42403 Blob_Generic_42403, *PBlob_Generic_42403;

struct Blob_Generic_42403 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17446 Blob_Generic_17446, *PBlob_Generic_17446;

struct Blob_Generic_17446 {
    byte Size; // coded integer - blob size
    byte Generic[41]; // Undefined blob contents
};

typedef struct Blob_Generic_7055 Blob_Generic_7055, *PBlob_Generic_7055;

struct Blob_Generic_7055 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_8385 Blob_Generic_8385, *PBlob_Generic_8385;

struct Blob_Generic_8385 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6490 Blob_PropertySig_6490, *PBlob_PropertySig_6490;

typedef struct PropertySig_6490 PropertySig_6490, *PPropertySig_6490;

typedef struct Type_180021 Type_180021, *PType_180021;

struct Type_180021 {
    struct ValueType.conflict24 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_6490 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180021 RetType; // Return type
};

struct Blob_PropertySig_6490 {
    byte Size; // coded integer - blob size
    struct PropertySig_6490 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_10811 Blob_Generic_10811, *PBlob_Generic_10811;

struct Blob_Generic_10811 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_30411 Blob_Generic_30411, *PBlob_Generic_30411;

struct Blob_Generic_30411 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_50023 Blob_Generic_50023, *PBlob_Generic_50023;

struct Blob_Generic_50023 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10819 Blob_Generic_10819, *PBlob_Generic_10819;

struct Blob_Generic_10819 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_8390 Blob_Generic_8390, *PBlob_Generic_8390;

struct Blob_Generic_8390 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11539 Blob_PropertySig_11539, *PBlob_PropertySig_11539;

typedef struct PropertySig_11539 PropertySig_11539, *PPropertySig_11539;

typedef struct Type_185070 Type_185070, *PType_185070;

struct Type_185070 {
    struct ValueType.conflict42 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_11539 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185070 RetType; // Return type
};

struct Blob_PropertySig_11539 {
    byte Size; // coded integer - blob size
    struct PropertySig_11539 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_7063 Blob_Generic_7063, *PBlob_Generic_7063;

struct Blob_Generic_7063 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_8397 Blob_Generic_8397, *PBlob_Generic_8397;

struct Blob_Generic_8397 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_16125 Blob_Generic_16125, *PBlob_Generic_16125;

struct Blob_Generic_16125 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_52679 Blob_Generic_52679, *PBlob_Generic_52679;

struct Blob_Generic_52679 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_1767 Blob_Generic_1767, *PBlob_Generic_1767;

struct Blob_Generic_1767 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_29431 Blob_Generic_29431, *PBlob_Generic_29431;

struct Blob_Generic_29431 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10201 Blob_PropertySig_10201, *PBlob_PropertySig_10201;

typedef struct PropertySig_10201 PropertySig_10201, *PPropertySig_10201;

typedef struct Type_183732 Type_183732, *PType_183732;

struct Type_183732 {
    struct GenericInstType_183733 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_10201 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183732 RetType; // Return type
};

struct Blob_PropertySig_10201 {
    byte Size; // coded integer - blob size
    struct PropertySig_10201 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_22802 Blob_Generic_22802, *PBlob_Generic_22802;

struct Blob_Generic_22802 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11529 Blob_PropertySig_11529, *PBlob_PropertySig_11529;

typedef struct PropertySig_11529 PropertySig_11529, *PPropertySig_11529;

typedef struct Type_185060 Type_185060, *PType_185060;

struct Type_185060 {
    struct GenericInstType_185061 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11529 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185060 RetType; // Return type
};

struct Blob_PropertySig_11529 {
    byte Size; // coded integer - blob size
    struct PropertySig_11529 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_7079 Blob_Generic_7079, *PBlob_Generic_7079;

struct Blob_Generic_7079 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_17425 Blob_Generic_17425, *PBlob_Generic_17425;

struct Blob_Generic_17425 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_49017 Blob_Generic_49017, *PBlob_Generic_49017;

struct Blob_Generic_49017 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5141 Blob_PropertySig_5141, *PBlob_PropertySig_5141;

typedef struct PropertySig_5141 PropertySig_5141, *PPropertySig_5141;

typedef struct Type_178672 Type_178672, *PType_178672;

struct Type_178672 {
    enum TypeCode ELEMENT_TYPE_OBJECT;
};

struct PropertySig_5141 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178672 RetType; // Return type
};

struct Blob_PropertySig_5141 {
    byte Size; // coded integer - blob size
    struct PropertySig_5141 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_6472 Blob_PropertySig_6472, *PBlob_PropertySig_6472;

typedef struct PropertySig_6472 PropertySig_6472, *PPropertySig_6472;

typedef struct Type_180003 Type_180003, *PType_180003;

struct Type_180003 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6472 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180003 RetType; // Return type
};

struct Blob_PropertySig_6472 {
    byte Size; // coded integer - blob size
    struct PropertySig_6472 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1777 Blob_Generic_1777, *PBlob_Generic_1777;

struct Blob_Generic_1777 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_50002 Blob_Generic_50002, *PBlob_Generic_50002;

struct Blob_Generic_50002 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_37021 Blob_Generic_37021, *PBlob_Generic_37021;

struct Blob_Generic_37021 {
    byte Size; // coded integer - blob size
    byte Generic[71]; // Undefined blob contents
};

typedef struct Blob_Generic_18764 Blob_Generic_18764, *PBlob_Generic_18764;

struct Blob_Generic_18764 {
    byte Size; // coded integer - blob size
    byte Generic[41]; // Undefined blob contents
};

typedef struct Blob_Generic_39682 Blob_Generic_39682, *PBlob_Generic_39682;

struct Blob_Generic_39682 {
    byte Size; // coded integer - blob size
    byte Generic[30]; // Undefined blob contents
};

typedef struct Blob_Generic_16104 Blob_Generic_16104, *PBlob_Generic_16104;

struct Blob_Generic_16104 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_40673 Blob_Generic_40673, *PBlob_Generic_40673;

struct Blob_Generic_40673 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_52658 Blob_Generic_52658, *PBlob_Generic_52658;

struct Blob_Generic_52658 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1787 Blob_Generic_1787, *PBlob_Generic_1787;

struct Blob_Generic_1787 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_31737 Blob_Generic_31737, *PBlob_Generic_31737;

struct Blob_Generic_31737 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_29410 Blob_Generic_29410, *PBlob_Generic_29410;

struct Blob_Generic_29410 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6478 Blob_PropertySig_6478, *PBlob_PropertySig_6478;

typedef struct PropertySig_6478 PropertySig_6478, *PPropertySig_6478;

typedef struct Type_180009 Type_180009, *PType_180009;

struct Type_180009 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6478 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180009 RetType; // Return type
};

struct Blob_PropertySig_6478 {
    byte Size; // coded integer - blob size
    struct PropertySig_6478 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_10803 Blob_Generic_10803, *PBlob_Generic_10803;

struct Blob_Generic_10803 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4813 Blob_Generic_4813, *PBlob_Generic_4813;

struct Blob_Generic_4813 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_25056 Blob_Generic_25056, *PBlob_Generic_25056;

struct Blob_Generic_25056 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_4819 Blob_Generic_4819, *PBlob_Generic_4819;

struct Blob_Generic_4819 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5145 Blob_PropertySig_5145, *PBlob_PropertySig_5145;

typedef struct PropertySig_5145 PropertySig_5145, *PPropertySig_5145;

typedef struct Type_178676 Type_178676, *PType_178676;

struct Type_178676 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_5145 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178676 RetType; // Return type
};

struct Blob_PropertySig_5145 {
    byte Size; // coded integer - blob size
    struct PropertySig_5145 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_13081 Blob_Generic_13081, *PBlob_Generic_13081;

struct Blob_Generic_13081 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7090 Blob_Generic_7090, *PBlob_Generic_7090;

struct Blob_Generic_7090 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_37093 Blob_Generic_37093, *PBlob_Generic_37093;

struct Blob_Generic_37093 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_42445 Blob_Generic_42445, *PBlob_Generic_42445;

struct Blob_Generic_42445 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7099 Blob_Generic_7099, *PBlob_Generic_7099;

struct Blob_Generic_7099 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_17488 Blob_Generic_17488, *PBlob_Generic_17488;

struct Blob_Generic_17488 {
    byte Size; // coded integer - blob size
    byte Generic[28]; // Undefined blob contents
};

typedef struct Blob_Generic_620 Blob_Generic_620, *PBlob_Generic_620;

struct Blob_Generic_620 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10851 Blob_Generic_10851, *PBlob_Generic_10851;

struct Blob_Generic_10851 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_31786 Blob_Generic_31786, *PBlob_Generic_31786;

struct Blob_Generic_31786 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_628 Blob_Generic_628, *PBlob_Generic_628;

struct Blob_Generic_628 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_12852 Blob_MethodRefSig_12852, *PBlob_MethodRefSig_12852;

typedef struct MethodRefSig_12852 MethodRefSig_12852, *PMethodRefSig_12852;

typedef struct Type_186383 Type_186383, *PType_186383;

typedef struct Type_186384 Type_186384, *PType_186384;

struct Type_186383 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_186384 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct MethodRefSig_12852 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_186383 RetType;
    struct Type_186384 Param0;
};

struct Blob_MethodRefSig_12852 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_12852 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_4825 Blob_Generic_4825, *PBlob_Generic_4825;

struct Blob_Generic_4825 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_30453 Blob_Generic_30453, *PBlob_Generic_30453;

struct Blob_Generic_30453 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_49080 Blob_Generic_49080, *PBlob_Generic_49080;

struct Blob_Generic_49080 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_Generic_41118 Blob_Generic_41118, *PBlob_Generic_41118;

struct Blob_Generic_41118 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_12858 Blob_MethodRefSig_12858, *PBlob_MethodRefSig_12858;

typedef struct MethodRefSig_12858 MethodRefSig_12858, *PMethodRefSig_12858;

typedef struct Type_186389 Type_186389, *PType_186389;

typedef struct Type_186390 Type_186390, *PType_186390;

typedef struct Type_186392 Type_186392, *PType_186392;

struct Type_186390 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct Type_186392 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct Type_186389 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_12858 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_186389 RetType;
    struct Type_186390 Param0;
    struct Type_186392 Param1;
};

struct Blob_MethodRefSig_12858 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_12858 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_46806 Blob_Generic_46806, *PBlob_Generic_46806;

struct Blob_Generic_46806 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_29484 Blob_Generic_29484, *PBlob_Generic_29484;

struct Blob_Generic_29484 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_611 Blob_Generic_611, *PBlob_Generic_611;

struct Blob_Generic_611 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10867 Blob_Generic_10867, *PBlob_Generic_10867;

struct Blob_Generic_10867 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3505 Blob_Generic_3505, *PBlob_Generic_3505;

struct Blob_Generic_3505 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_16170 Blob_Generic_16170, *PBlob_Generic_16170;

struct Blob_Generic_16170 {
    byte Size; // coded integer - blob size
    byte Generic[29]; // Undefined blob contents
};

typedef struct Blob_Generic_51382 Blob_Generic_51382, *PBlob_Generic_51382;

struct Blob_Generic_51382 {
    byte Size; // coded integer - blob size
    byte Generic[74]; // Undefined blob contents
};

typedef struct Blob_Generic_43754 Blob_Generic_43754, *PBlob_Generic_43754;

struct Blob_Generic_43754 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_42424 Blob_Generic_42424, *PBlob_Generic_42424;

struct Blob_Generic_42424 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3510 Blob_Generic_3510, *PBlob_Generic_3510;

struct Blob_Generic_3510 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_4840 Blob_Generic_4840, *PBlob_Generic_4840;

struct Blob_Generic_4840 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_602 Blob_Generic_602, *PBlob_Generic_602;

struct Blob_Generic_602 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10831 Blob_Generic_10831, *PBlob_Generic_10831;

struct Blob_Generic_10831 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_30432 Blob_Generic_30432, *PBlob_Generic_30432;

struct Blob_Generic_30432 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3517 Blob_Generic_3517, *PBlob_Generic_3517;

struct Blob_Generic_3517 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_50044 Blob_Generic_50044, *PBlob_Generic_50044;

struct Blob_Generic_50044 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_12871 Blob_MethodRefSig_12871, *PBlob_MethodRefSig_12871;

typedef struct MethodRefSig_12871 MethodRefSig_12871, *PMethodRefSig_12871;

typedef struct Type_186402 Type_186402, *PType_186402;

typedef struct Type_186403 Type_186403, *PType_186403;

struct Type_186403 {
    struct ValueType.conflict46 ELEMENT_TYPE_VALUETYPE;
};

struct Type_186402 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_12871 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_186402 RetType;
    struct Type_186403 Param0;
};

struct Blob_MethodRefSig_12871 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_12871 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_28114 Blob_Generic_28114, *PBlob_Generic_28114;

struct Blob_Generic_28114 {
    byte Size; // coded integer - blob size
    byte Generic[64]; // Undefined blob contents
};

typedef struct Blob_Generic_22823 Blob_Generic_22823, *PBlob_Generic_22823;

struct Blob_Generic_22823 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_Generic_10841 Blob_Generic_10841, *PBlob_Generic_10841;

struct Blob_Generic_10841 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4853 Blob_Generic_4853, *PBlob_Generic_4853;

struct Blob_Generic_4853 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_51361 Blob_Generic_51361, *PBlob_Generic_51361;

struct Blob_Generic_51361 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4858 Blob_Generic_4858, *PBlob_Generic_4858;

struct Blob_Generic_4858 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3526 Blob_Generic_3526, *PBlob_Generic_3526;

struct Blob_Generic_3526 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_12865 Blob_MethodRefSig_12865, *PBlob_MethodRefSig_12865;

typedef struct MethodRefSig_12865 MethodRefSig_12865, *PMethodRefSig_12865;

typedef struct Type_186396 Type_186396, *PType_186396;

typedef struct Type_186397 Type_186397, *PType_186397;

struct Type_186396 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_186397 {
    struct ValueType.conflict45 ELEMENT_TYPE_VALUETYPE;
};

struct MethodRefSig_12865 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_186396 RetType;
    struct Type_186397 Param0;
};

struct Blob_MethodRefSig_12865 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_12865 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_5272 Blob_Generic_5272, *PBlob_Generic_5272;

struct Blob_Generic_5272 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_8302 Blob_Generic_8302, *PBlob_Generic_8302;

struct Blob_Generic_8302 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_13120 Blob_Generic_13120, *PBlob_Generic_13120;

struct Blob_Generic_13120 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_10097 Blob_Generic_10097, *PBlob_Generic_10097;

struct Blob_Generic_10097 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_39755 Blob_Generic_39755, *PBlob_Generic_39755;

struct Blob_Generic_39755 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_40740 Blob_Generic_40740, *PBlob_Generic_40740;

struct Blob_Generic_40740 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_46045 Blob_Generic_46045, *PBlob_Generic_46045;

struct Blob_Generic_46045 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_9638 Blob_Generic_9638, *PBlob_Generic_9638;

struct Blob_Generic_9638 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5279 Blob_Generic_5279, *PBlob_Generic_5279;

struct Blob_Generic_5279 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_52725 Blob_Generic_52725, *PBlob_Generic_52725;

struct Blob_Generic_52725 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_22072 Blob_Generic_22072, *PBlob_Generic_22072;

struct Blob_Generic_22072 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2043 Blob_PropertySig_2043, *PBlob_PropertySig_2043;

typedef struct PropertySig_2043 PropertySig_2043, *PPropertySig_2043;

typedef struct Type_175574 Type_175574, *PType_175574;

struct Type_175574 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_2043 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175574 RetType; // Return type
};

struct Blob_PropertySig_2043 {
    byte Size; // coded integer - blob size
    struct PropertySig_2043 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_27760 Blob_Generic_27760, *PBlob_Generic_27760;

struct Blob_Generic_27760 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25102 Blob_Generic_25102, *PBlob_Generic_25102;

struct Blob_Generic_25102 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7731 Blob_PropertySig_7731, *PBlob_PropertySig_7731;

typedef struct PropertySig_7731 PropertySig_7731, *PPropertySig_7731;

typedef struct Type_181262 Type_181262, *PType_181262;

struct Type_181262 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_7731 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181262 RetType; // Return type
};

struct Blob_PropertySig_7731 {
    byte Size; // coded integer - blob size
    struct PropertySig_7731 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_2049 Blob_PropertySig_2049, *PBlob_PropertySig_2049;

typedef struct PropertySig_2049 PropertySig_2049, *PPropertySig_2049;

typedef struct Type_175580 Type_175580, *PType_175580;

struct Type_175580 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_2049 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175580 RetType; // Return type
};

struct Blob_PropertySig_2049 {
    byte Size; // coded integer - blob size
    struct PropertySig_2049 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_34053 Blob_Generic_34053, *PBlob_Generic_34053;

struct Blob_Generic_34053 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_35381 Blob_Generic_35381, *PBlob_Generic_35381;

struct Blob_Generic_35381 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_5285 Blob_Generic_5285, *PBlob_Generic_5285;

struct Blob_Generic_5285 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_14469 Blob_Generic_14469, *PBlob_Generic_14469;

struct Blob_Generic_14469 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_18827 Blob_Generic_18827, *PBlob_Generic_18827;

struct Blob_Generic_18827 {
    byte Size; // coded integer - blob size
    byte Generic[55]; // Undefined blob contents
};

typedef struct Blob_Generic_48697 Blob_Generic_48697, *PBlob_Generic_48697;

struct Blob_Generic_48697 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_47367 Blob_Generic_47367, *PBlob_Generic_47367;

struct Blob_Generic_47367 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_15799 Blob_Generic_15799, *PBlob_Generic_15799;

struct Blob_Generic_15799 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_8315 Blob_Generic_8315, *PBlob_Generic_8315;

struct Blob_Generic_8315 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_9646 Blob_Generic_9646, *PBlob_Generic_9646;

struct Blob_Generic_9646 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_26441 Blob_Generic_26441, *PBlob_Generic_26441;

struct Blob_Generic_26441 {
    byte Size; // coded integer - blob size
    byte Generic[69]; // Undefined blob contents
};

typedef struct Blob_Generic_5291 Blob_Generic_5291, *PBlob_Generic_5291;

struct Blob_Generic_5291 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12882.conflict Blob_ConstantSig_12882.conflict, *PBlob_ConstantSig_12882.conflict;

typedef struct ConstantSig_12882.conflict ConstantSig_12882.conflict, *PConstantSig_12882.conflict;

struct ConstantSig_12882.conflict {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12882.conflict {
    byte Size; // coded integer - blob size
    struct ConstantSig_12882.conflict ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_10070 Blob_Generic_10070, *PBlob_Generic_10070;

struct Blob_Generic_10070 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_9654 Blob_Generic_9654, *PBlob_Generic_9654;

struct Blob_Generic_9654 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_10075 Blob_Generic_10075, *PBlob_Generic_10075;

struct Blob_Generic_10075 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_13102 Blob_Generic_13102, *PBlob_Generic_13102;

struct Blob_Generic_13102 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_38403 Blob_Generic_38403, *PBlob_Generic_38403;

struct Blob_Generic_38403 {
    byte Size; // coded integer - blob size
    byte Generic[66]; // Undefined blob contents
};

typedef struct Blob_Generic_39734 Blob_Generic_39734, *PBlob_Generic_39734;

struct Blob_Generic_39734 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_46024 Blob_Generic_46024, *PBlob_Generic_46024;

struct Blob_Generic_46024 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_23383 Blob_Generic_23383, *PBlob_Generic_23383;

struct Blob_Generic_23383 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_22051 Blob_Generic_22051, *PBlob_Generic_22051;

struct Blob_Generic_22051 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8328 Blob_Generic_8328, *PBlob_Generic_8328;

struct Blob_Generic_8328 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3350 Blob_PropertySig_3350, *PBlob_PropertySig_3350;

typedef struct PropertySig_3350 PropertySig_3350, *PPropertySig_3350;

typedef struct Type_176881 Type_176881, *PType_176881;

struct Type_176881 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_3350 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176881 RetType; // Return type
};

struct Blob_PropertySig_3350 {
    byte Size; // coded integer - blob size
    struct PropertySig_3350 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_3356 Blob_PropertySig_3356, *PBlob_PropertySig_3356;

typedef struct PropertySig_3356 PropertySig_3356, *PPropertySig_3356;

typedef struct Type_176887 Type_176887, *PType_176887;

struct Type_176887 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_3356 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176887 RetType; // Return type
};

struct Blob_PropertySig_3356 {
    byte Size; // coded integer - blob size
    struct PropertySig_3356 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_34037 Blob_Generic_34037, *PBlob_Generic_34037;

struct Blob_Generic_34037 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7719 Blob_PropertySig_7719, *PBlob_PropertySig_7719;

typedef struct PropertySig_7719 PropertySig_7719, *PPropertySig_7719;

typedef struct Type_181250 Type_181250, *PType_181250;

struct Type_181250 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_7719 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181250 RetType; // Return type
};

struct Blob_PropertySig_7719 {
    byte Size; // coded integer - blob size
    struct PropertySig_7719 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_MethodRefSig_12837 Blob_MethodRefSig_12837, *PBlob_MethodRefSig_12837;

typedef struct MethodRefSig_12837 MethodRefSig_12837, *PMethodRefSig_12837;

typedef struct Type_186368 Type_186368, *PType_186368;

typedef struct Type_186369 Type_186369, *PType_186369;

typedef struct Type_186370 Type_186370, *PType_186370;

typedef struct Type_186371 Type_186371, *PType_186371;

typedef struct Type_186372 Type_186372, *PType_186372;

typedef struct Type_186373 Type_186373, *PType_186373;

typedef struct Type_186374 Type_186374, *PType_186374;

typedef struct Type_186375 Type_186375, *PType_186375;

typedef struct Type_186376 Type_186376, *PType_186376;

typedef struct Type_186377 Type_186377, *PType_186377;

typedef struct Type_186378 Type_186378, *PType_186378;

typedef struct Type_186379 Type_186379, *PType_186379;

struct Type_186372 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_186373 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_186374 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_186375 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_186370 {
    enum TypeCode ELEMENT_TYPE_U2;
};

struct Type_186371 {
    enum TypeCode ELEMENT_TYPE_U2;
};

struct Type_186369 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct Type_186379 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_186378 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_186376 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_186368 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_186377 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct MethodRefSig_12837 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_186368 RetType;
    struct Type_186369 Param0;
    struct Type_186370 Param1;
    struct Type_186371 Param2;
    struct Type_186372 Param3;
    struct Type_186373 Param4;
    struct Type_186374 Param5;
    struct Type_186375 Param6;
    struct Type_186376 Param7;
    struct Type_186377 Param8;
    struct Type_186378 Param9;
    struct Type_186379 Param10;
};

struct Blob_MethodRefSig_12837 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_12837 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_10080 Blob_Generic_10080, *PBlob_Generic_10080;

struct Blob_Generic_10080 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10151 Blob_PropertySig_10151, *PBlob_PropertySig_10151;

typedef struct PropertySig_10151 PropertySig_10151, *PPropertySig_10151;

typedef struct Type_183682 Type_183682, *PType_183682;

struct Type_183682 {
    struct ValueType.conflict26 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_10151 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183682 RetType; // Return type
};

struct Blob_PropertySig_10151 {
    byte Size; // coded integer - blob size
    struct PropertySig_10151 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_10085 Blob_Generic_10085, *PBlob_Generic_10085;

struct Blob_Generic_10085 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_13111 Blob_Generic_13111, *PBlob_Generic_13111;

struct Blob_Generic_13111 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_47346 Blob_Generic_47346, *PBlob_Generic_47346;

struct Blob_Generic_47346 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9661 Blob_Generic_9661, *PBlob_Generic_9661;

struct Blob_Generic_9661 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_14448 Blob_Generic_14448, *PBlob_Generic_14448;

struct Blob_Generic_14448 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18806 Blob_Generic_18806, *PBlob_Generic_18806;

struct Blob_Generic_18806 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7007 Blob_Generic_7007, *PBlob_Generic_7007;

struct Blob_Generic_7007 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3362 Blob_PropertySig_3362, *PBlob_PropertySig_3362;

typedef struct PropertySig_3362 PropertySig_3362, *PPropertySig_3362;

typedef struct Type_176893 Type_176893, *PType_176893;

struct Type_176893 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_3362 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176893 RetType; // Return type
};

struct Blob_PropertySig_3362 {
    byte Size; // coded integer - blob size
    struct PropertySig_3362 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1701 Blob_Generic_1701, *PBlob_Generic_1701;

struct Blob_Generic_1701 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_40719 Blob_Generic_40719, *PBlob_Generic_40719;

struct Blob_Generic_40719 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1707 Blob_Generic_1707, *PBlob_Generic_1707;

struct Blob_Generic_1707 {
    byte Size; // coded integer - blob size
    byte Generic[22]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7725 Blob_PropertySig_7725, *PBlob_PropertySig_7725;

typedef struct PropertySig_7725 PropertySig_7725, *PPropertySig_7725;

typedef struct Type_181256 Type_181256, *PType_181256;

struct Type_181256 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_7725 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181256 RetType; // Return type
};

struct Blob_PropertySig_7725 {
    byte Size; // coded integer - blob size
    struct PropertySig_7725 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_10091 Blob_Generic_10091, *PBlob_Generic_10091;

struct Blob_Generic_10091 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_8344 Blob_Generic_8344, *PBlob_Generic_8344;

struct Blob_Generic_8344 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_7013 Blob_Generic_7013, *PBlob_Generic_7013;

struct Blob_Generic_7013 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_40782 Blob_Generic_40782, *PBlob_Generic_40782;

struct Blob_Generic_40782 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9672 Blob_Generic_9672, *PBlob_Generic_9672;

struct Blob_Generic_9672 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_13167 Blob_Generic_13167, *PBlob_Generic_13167;

struct Blob_Generic_13167 {
    byte Size; // coded integer - blob size
    byte Generic[30]; // Undefined blob contents
};

typedef struct Blob_Generic_7019 Blob_Generic_7019, *PBlob_Generic_7019;

struct Blob_Generic_7019 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_50102 Blob_Generic_50102, *PBlob_Generic_50102;

struct Blob_Generic_50102 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_PropertySig_12795 Blob_PropertySig_12795, *PBlob_PropertySig_12795;

typedef struct PropertySig_12795 PropertySig_12795, *PPropertySig_12795;

typedef struct Type_186326 Type_186326, *PType_186326;

struct Type_186326 {
    struct ValueType.conflict6 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_12795 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_186326 RetType; // Return type
};

struct Blob_PropertySig_12795 {
    byte Size; // coded integer - blob size
    struct PropertySig_12795 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_29505 Blob_Generic_29505, *PBlob_Generic_29505;

struct Blob_Generic_29505 {
    byte Size; // coded integer - blob size
    byte Generic[36]; // Undefined blob contents
};

typedef struct Blob_Generic_38470 Blob_Generic_38470, *PBlob_Generic_38470;

struct Blob_Generic_38470 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16200 Blob_Generic_16200, *PBlob_Generic_16200;

struct Blob_Generic_16200 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9683 Blob_Generic_9683, *PBlob_Generic_9683;

struct Blob_Generic_9683 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_17538 Blob_Generic_17538, *PBlob_Generic_17538;

struct Blob_Generic_17538 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7029 Blob_Generic_7029, *PBlob_Generic_7029;

struct Blob_Generic_7029 {
    byte Size; // coded integer - blob size
    byte Generic[17]; // Undefined blob contents
};

typedef struct Blob_Generic_10907 Blob_Generic_10907, *PBlob_Generic_10907;

struct Blob_Generic_10907 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_43806 Blob_Generic_43806, *PBlob_Generic_43806;

struct Blob_Generic_43806 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8360 Blob_Generic_8360, *PBlob_Generic_8360;

struct Blob_Generic_8360 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_9695 Blob_Generic_9695, *PBlob_Generic_9695;

struct Blob_Generic_9695 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_40761 Blob_Generic_40761, *PBlob_Generic_40761;

struct Blob_Generic_40761 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_31807 Blob_Generic_31807, *PBlob_Generic_31807;

struct Blob_Generic_31807 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_52746 Blob_Generic_52746, *PBlob_Generic_52746;

struct Blob_Generic_52746 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_1730 Blob_Generic_1730, *PBlob_Generic_1730;

struct Blob_Generic_1730 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_22093 Blob_Generic_22093, *PBlob_Generic_22093;

struct Blob_Generic_22093 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_27781 Blob_Generic_27781, *PBlob_Generic_27781;

struct Blob_Generic_27781 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25123 Blob_Generic_25123, *PBlob_Generic_25123;

struct Blob_Generic_25123 {
    byte Size; // coded integer - blob size
    byte Generic[59]; // Undefined blob contents
};

typedef struct Blob_Generic_1738 Blob_Generic_1738, *PBlob_Generic_1738;

struct Blob_Generic_1738 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_FieldSig_4882 Blob_FieldSig_4882, *PBlob_FieldSig_4882;

typedef struct FieldSig_4882 FieldSig_4882, *PFieldSig_4882;

typedef struct Type_178412 Type_178412, *PType_178412;

struct Type_178412 {
    struct ValueType.conflict13 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_4882 {
    byte FIELD; // Magic (0x06)
    struct Type_178412 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_4882 {
    byte Size; // coded integer - blob size
    struct FieldSig_4882 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_7047 Blob_Generic_7047, *PBlob_Generic_7047;

struct Blob_Generic_7047 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_8378 Blob_Generic_8378, *PBlob_Generic_8378;

struct Blob_Generic_8378 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_8373 Blob_Generic_8373, *PBlob_Generic_8373;

struct Blob_Generic_8373 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10103 Blob_PropertySig_10103, *PBlob_PropertySig_10103;

typedef struct PropertySig_10103 PropertySig_10103, *PPropertySig_10103;

typedef struct Type_183634 Type_183634, *PType_183634;

struct Type_183634 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10103 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183634 RetType; // Return type
};

struct Blob_PropertySig_10103 {
    byte Size; // coded integer - blob size
    struct PropertySig_10103 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_17517 Blob_Generic_17517, *PBlob_Generic_17517;

struct Blob_Generic_17517 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_47388 Blob_Generic_47388, *PBlob_Generic_47388;

struct Blob_Generic_47388 {
    byte Size; // coded integer - blob size
    byte Generic[33]; // Undefined blob contents
};

typedef struct Blob_Generic_1746 Blob_Generic_1746, *PBlob_Generic_1746;

struct Blob_Generic_1746 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34089 Blob_Generic_34089, *PBlob_Generic_34089;

struct Blob_Generic_34089 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2164 Blob_Generic_2164, *PBlob_Generic_2164;

struct Blob_Generic_2164 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6525 Blob_Generic_6525, *PBlob_Generic_6525;

struct Blob_Generic_6525 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_45594 Blob_Generic_45594, *PBlob_Generic_45594;

struct Blob_Generic_45594 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3496 Blob_Generic_3496, *PBlob_Generic_3496;

struct Blob_Generic_3496 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10015 Blob_Generic_10015, *PBlob_Generic_10015;

struct Blob_Generic_10015 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11346 Blob_Generic_11346, *PBlob_Generic_11346;

struct Blob_Generic_11346 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_15705 Blob_Generic_15705, *PBlob_Generic_15705;

struct Blob_Generic_15705 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12678 Blob_Generic_12678, *PBlob_Generic_12678;

struct Blob_Generic_12678 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_7854 Blob_Generic_7854, *PBlob_Generic_7854;

struct Blob_Generic_7854 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_35305 Blob_Generic_35305, *PBlob_Generic_35305;

struct Blob_Generic_35305 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_36635 Blob_Generic_36635, *PBlob_Generic_36635;

struct Blob_Generic_36635 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5957 Blob_PropertySig_5957, *PBlob_PropertySig_5957;

typedef struct PropertySig_5957 PropertySig_5957, *PPropertySig_5957;

typedef struct Type_179488 Type_179488, *PType_179488;

struct Type_179488 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_5957 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179488 RetType; // Return type
};

struct Blob_PropertySig_5957 {
    byte Size; // coded integer - blob size
    struct PropertySig_5957 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2170 Blob_Generic_2170, *PBlob_Generic_2170;

struct Blob_Generic_2170 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_22009 Blob_Generic_22009, *PBlob_Generic_22009;

struct Blob_Generic_22009 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7861 Blob_Generic_7861, *PBlob_Generic_7861;

struct Blob_Generic_7861 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5200 Blob_Generic_5200, *PBlob_Generic_5200;

struct Blob_Generic_5200 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10021 Blob_Generic_10021, *PBlob_Generic_10021;

struct Blob_Generic_10021 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12683 Blob_Generic_12683, *PBlob_Generic_12683;

struct Blob_Generic_12683 {
    byte Size; // coded integer - blob size
    byte Generic[18]; // Undefined blob contents
};

typedef struct Blob_Generic_11354 Blob_Generic_11354, *PBlob_Generic_11354;

struct Blob_Generic_11354 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_2176 Blob_Generic_2176, *PBlob_Generic_2176;

struct Blob_Generic_2176 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6539 Blob_Generic_6539, *PBlob_Generic_6539;

struct Blob_Generic_6539 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5208 Blob_Generic_5208, *PBlob_Generic_5208;

struct Blob_Generic_5208 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10027 Blob_Generic_10027, *PBlob_Generic_10027;

struct Blob_Generic_10027 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_6533 Blob_Generic_6533, *PBlob_Generic_6533;

struct Blob_Generic_6533 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_37979 Blob_Generic_37979, *PBlob_Generic_37979;

struct Blob_Generic_37979 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5963 Blob_PropertySig_5963, *PBlob_PropertySig_5963;

typedef struct PropertySig_5963 PropertySig_5963, *PPropertySig_5963;

typedef struct Type_179494 Type_179494, *PType_179494;

struct Type_179494 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_5963 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179494 RetType; // Return type
};

struct Blob_PropertySig_5963 {
    byte Size; // coded integer - blob size
    struct PropertySig_5963 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_5969 Blob_PropertySig_5969, *PBlob_PropertySig_5969;

typedef struct PropertySig_5969 PropertySig_5969, *PPropertySig_5969;

typedef struct Type_179500 Type_179500, *PType_179500;

struct Type_179500 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_5969 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179500 RetType; // Return type
};

struct Blob_PropertySig_5969 {
    byte Size; // coded integer - blob size
    struct PropertySig_5969 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_7870 Blob_Generic_7870, *PBlob_Generic_7870;

struct Blob_Generic_7870 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_44248 Blob_Generic_44248, *PBlob_Generic_44248;

struct Blob_Generic_44248 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_49937 Blob_Generic_49937, *PBlob_Generic_49937;

struct Blob_Generic_49937 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_2182 Blob_Generic_2182, *PBlob_Generic_2182;

struct Blob_Generic_2182 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_23305 Blob_Generic_23305, *PBlob_Generic_23305;

struct Blob_Generic_23305 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_12651 Blob_Generic_12651, *PBlob_Generic_12651;

struct Blob_Generic_12651 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_7878 Blob_Generic_7878, *PBlob_Generic_7878;

struct Blob_Generic_7878 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_13983 Blob_Generic_13983, *PBlob_Generic_13983;

struct Blob_Generic_13983 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11323 Blob_Generic_11323, *PBlob_Generic_11323;

struct Blob_Generic_11323 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_2188 Blob_Generic_2188, *PBlob_Generic_2188;

struct Blob_Generic_2188 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_5217 Blob_Generic_5217, *PBlob_Generic_5217;

struct Blob_Generic_5217 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_12659 Blob_Generic_12659, *PBlob_Generic_12659;

struct Blob_Generic_12659 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6546 Blob_Generic_6546, *PBlob_Generic_6546;

struct Blob_Generic_6546 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_19290 Blob_Generic_19290, *PBlob_Generic_19290;

struct Blob_Generic_19290 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_32253 Blob_Generic_32253, *PBlob_Generic_32253;

struct Blob_Generic_32253 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_6553 Blob_Generic_6553, *PBlob_Generic_6553;

struct Blob_Generic_6553 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_20286 Blob_Generic_20286, *PBlob_Generic_20286;

struct Blob_Generic_20286 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5226 Blob_Generic_5226, *PBlob_Generic_5226;

struct Blob_Generic_5226 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_46891 Blob_Generic_46891, *PBlob_Generic_46891;

struct Blob_Generic_46891 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_10003 Blob_Generic_10003, *PBlob_Generic_10003;

struct Blob_Generic_10003 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7886 Blob_Generic_7886, *PBlob_Generic_7886;

struct Blob_Generic_7886 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_12667 Blob_Generic_12667, *PBlob_Generic_12667;

struct Blob_Generic_12667 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_11338 Blob_Generic_11338, *PBlob_Generic_11338;

struct Blob_Generic_11338 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10009 Blob_Generic_10009, *PBlob_Generic_10009;

struct Blob_Generic_10009 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5947 Blob_PropertySig_5947, *PBlob_PropertySig_5947;

typedef struct PropertySig_5947 PropertySig_5947, *PPropertySig_5947;

typedef struct Type_179478 Type_179478, *PType_179478;

struct Type_179478 {
    struct GenericInstType_179479 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_5947 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179478 RetType; // Return type
};

struct Blob_PropertySig_5947 {
    byte Size; // coded integer - blob size
    struct PropertySig_5947 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_25978 Blob_Generic_25978, *PBlob_Generic_25978;

struct Blob_Generic_25978 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_7893 Blob_Generic_7893, *PBlob_Generic_7893;

struct Blob_Generic_7893 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_11381 Blob_Generic_11381, *PBlob_Generic_11381;

struct Blob_Generic_11381 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10052 Blob_Generic_10052, *PBlob_Generic_10052;

struct Blob_Generic_10052 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_6560 Blob_Generic_6560, *PBlob_Generic_6560;

struct Blob_Generic_6560 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_6569 Blob_Generic_6569, *PBlob_Generic_6569;

struct Blob_Generic_6569 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11387 Blob_Generic_11387, *PBlob_Generic_11387;

struct Blob_Generic_11387 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_10057 Blob_Generic_10057, *PBlob_Generic_10057;

struct Blob_Generic_10057 {
    byte Size; // coded integer - blob size
    byte Generic[2]; // Undefined blob contents
};

typedef struct Blob_Generic_39713 Blob_Generic_39713, *PBlob_Generic_39713;

struct Blob_Generic_39713 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5235 Blob_Generic_5235, *PBlob_Generic_5235;

struct Blob_Generic_5235 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_46003 Blob_Generic_46003, *PBlob_Generic_46003;

struct Blob_Generic_46003 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_23362 Blob_Generic_23362, *PBlob_Generic_23362;

struct Blob_Generic_23362 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_22030 Blob_Generic_22030, *PBlob_Generic_22030;

struct Blob_Generic_22030 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_15747 Blob_Generic_15747, *PBlob_Generic_15747;

struct Blob_Generic_15747 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_24692 Blob_Generic_24692, *PBlob_Generic_24692;

struct Blob_Generic_24692 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10060 Blob_Generic_10060, *PBlob_Generic_10060;

struct Blob_Generic_10060 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_6575 Blob_Generic_6575, *PBlob_Generic_6575;

struct Blob_Generic_6575 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5244 Blob_Generic_5244, *PBlob_Generic_5244;

struct Blob_Generic_5244 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_10065 Blob_Generic_10065, *PBlob_Generic_10065;

struct Blob_Generic_10065 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_11399 Blob_Generic_11399, *PBlob_Generic_11399;

struct Blob_Generic_11399 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_49981 Blob_Generic_49981, *PBlob_Generic_49981;

struct Blob_Generic_49981 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_14427 Blob_Generic_14427, *PBlob_Generic_14427;

struct Blob_Generic_14427 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_36689 Blob_Generic_36689, *PBlob_Generic_36689;

struct Blob_Generic_36689 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34021 Blob_Generic_34021, *PBlob_Generic_34021;

struct Blob_Generic_34021 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7709 Blob_PropertySig_7709, *PBlob_PropertySig_7709;

typedef struct PropertySig_7709 PropertySig_7709, *PPropertySig_7709;

typedef struct Type_181240 Type_181240, *PType_181240;

struct Type_181240 {
    struct GenericInstType_181241 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_7709 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181240 RetType; // Return type
};

struct Blob_PropertySig_7709 {
    byte Size; // coded integer - blob size
    struct PropertySig_7709 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_27739 Blob_Generic_27739, *PBlob_Generic_27739;

struct Blob_Generic_27739 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5251 Blob_Generic_5251, *PBlob_Generic_5251;

struct Blob_Generic_5251 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_6584 Blob_Generic_6584, *PBlob_Generic_6584;

struct Blob_Generic_6584 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_10032 Blob_Generic_10032, *PBlob_Generic_10032;

struct Blob_Generic_10032 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_48644 Blob_Generic_48644, *PBlob_Generic_48644;

struct Blob_Generic_48644 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_5258 Blob_Generic_5258, *PBlob_Generic_5258;

struct Blob_Generic_5258 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_50963 Blob_Generic_50963, *PBlob_Generic_50963;

struct Blob_Generic_50963 {
    byte Size; // coded integer - blob size
    byte Generic[65]; // Undefined blob contents
};

typedef struct Blob_Generic_11367 Blob_Generic_11367, *PBlob_Generic_11367;

struct Blob_Generic_11367 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10037 Blob_Generic_10037, *PBlob_Generic_10037;

struct Blob_Generic_10037 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_9612 Blob_Generic_9612, *PBlob_Generic_9612;

struct Blob_Generic_9612 {
    byte Size; // coded integer - blob size
    byte Generic[16]; // Undefined blob contents
};

typedef struct Blob_Generic_15726 Blob_Generic_15726, *PBlob_Generic_15726;

struct Blob_Generic_15726 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5975 Blob_PropertySig_5975, *PBlob_PropertySig_5975;

typedef struct PropertySig_5975 PropertySig_5975, *PPropertySig_5975;

typedef struct Type_179506 Type_179506, *PType_179506;

struct Type_179506 {
    struct ValueType.conflict17 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_5975 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179506 RetType; // Return type
};

struct Blob_PropertySig_5975 {
    byte Size; // coded integer - blob size
    struct PropertySig_5975 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_35326 Blob_Generic_35326, *PBlob_Generic_35326;

struct Blob_Generic_35326 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_6597 Blob_Generic_6597, *PBlob_Generic_6597;

struct Blob_Generic_6597 {
    byte Size; // coded integer - blob size
    byte Generic[25]; // Undefined blob contents
};

typedef struct Blob_Generic_5265 Blob_Generic_5265, *PBlob_Generic_5265;

struct Blob_Generic_5265 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_10042 Blob_Generic_10042, *PBlob_Generic_10042;

struct Blob_Generic_10042 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_11375 Blob_Generic_11375, *PBlob_Generic_11375;

struct Blob_Generic_11375 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10047 Blob_Generic_10047, *PBlob_Generic_10047;

struct Blob_Generic_10047 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_9629 Blob_Generic_9629, *PBlob_Generic_9629;

struct Blob_Generic_9629 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_34000 Blob_Generic_34000, *PBlob_Generic_34000;

struct Blob_Generic_34000 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_27718 Blob_Generic_27718, *PBlob_Generic_27718;

struct Blob_Generic_27718 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18015 Blob_Generic_18015, *PBlob_Generic_18015;

struct Blob_Generic_18015 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_45636 Blob_Generic_45636, *PBlob_Generic_45636;

struct Blob_Generic_45636 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_Generic_44306 Blob_Generic_44306, *PBlob_Generic_44306;

struct Blob_Generic_44306 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_540 Blob_Generic_540, *PBlob_Generic_540;

struct Blob_Generic_540 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3411 Blob_Generic_3411, *PBlob_Generic_3411;

struct Blob_Generic_3411 {
    byte Size; // coded integer - blob size
    byte Generic[24]; // Undefined blob contents
};

typedef struct Blob_Generic_4740 Blob_Generic_4740, *PBlob_Generic_4740;

struct Blob_Generic_4740 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12710 Blob_Generic_12710, *PBlob_Generic_12710;

struct Blob_Generic_12710 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4746 Blob_Generic_4746, *PBlob_Generic_4746;

struct Blob_Generic_4746 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_546 Blob_Generic_546, *PBlob_Generic_546;

struct Blob_Generic_546 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12718 Blob_Generic_12718, *PBlob_Generic_12718;

struct Blob_Generic_12718 {
    byte Size; // coded integer - blob size
    byte Generic[16]; // Undefined blob contents
};

typedef struct Blob_Generic_32315 Blob_Generic_32315, *PBlob_Generic_32315;

struct Blob_Generic_32315 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1511 Blob_PropertySig_1511, *PBlob_PropertySig_1511;

typedef struct PropertySig_1511 PropertySig_1511, *PPropertySig_1511;

typedef struct Type_175042 Type_175042, *PType_175042;

struct Type_175042 {
    struct GenericInstType_175043 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1511 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175042 RetType; // Return type
};

struct Blob_PropertySig_1511 {
    byte Size; // coded integer - blob size
    struct PropertySig_1511 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_41265 Blob_Generic_41265, *PBlob_Generic_41265;

struct Blob_Generic_41265 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_4752 Blob_Generic_4752, *PBlob_Generic_4752;

struct Blob_Generic_4752 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_42593 Blob_Generic_42593, *PBlob_Generic_42593;

struct Blob_Generic_42593 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_534 Blob_Generic_534, *PBlob_Generic_534;

struct Blob_Generic_534 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4758 Blob_Generic_4758, *PBlob_Generic_4758;

struct Blob_Generic_4758 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_33654 Blob_Generic_33654, *PBlob_Generic_33654;

struct Blob_Generic_33654 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19363 Blob_Generic_19363, *PBlob_Generic_19363;

struct Blob_Generic_19363 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1521 Blob_PropertySig_1521, *PBlob_PropertySig_1521;

typedef struct PropertySig_1521 PropertySig_1521, *PPropertySig_1521;

typedef struct Type_175052 Type_175052, *PType_175052;

struct Type_175052 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_1521 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175052 RetType; // Return type
};

struct Blob_PropertySig_1521 {
    byte Size; // coded integer - blob size
    struct PropertySig_1521 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1527 Blob_PropertySig_1527, *PBlob_PropertySig_1527;

typedef struct PropertySig_1527 PropertySig_1527, *PPropertySig_1527;

typedef struct Type_175058 Type_175058, *PType_175058;

struct Type_175058 {
    struct GenericInstType_175059 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1527 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_175058 RetType; // Return type
};

struct Blob_PropertySig_1527 {
    byte Size; // coded integer - blob size
    struct PropertySig_1527 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_2829 Blob_PropertySig_2829, *PBlob_PropertySig_2829;

typedef struct PropertySig_2829 PropertySig_2829, *PPropertySig_2829;

typedef struct Type_176360 Type_176360, *PType_176360;

struct Type_176360 {
    struct GenericInstType_176361 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2829 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176360 RetType; // Return type
};

struct Blob_PropertySig_2829 {
    byte Size; // coded integer - blob size
    struct PropertySig_2829 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_45615 Blob_Generic_45615, *PBlob_Generic_45615;

struct Blob_Generic_45615 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4764 Blob_Generic_4764, *PBlob_Generic_4764;

struct Blob_Generic_4764 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10991 Blob_Generic_10991, *PBlob_Generic_10991;

struct Blob_Generic_10991 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9462 Blob_PropertySig_9462, *PBlob_PropertySig_9462;

typedef struct PropertySig_9462 PropertySig_9462, *PPropertySig_9462;

typedef struct Type_182993 Type_182993, *PType_182993;

struct Type_182993 {
    struct ValueType.conflict34 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_9462 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182993 RetType; // Return type
};

struct Blob_PropertySig_9462 {
    byte Size; // coded integer - blob size
    struct PropertySig_9462 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2105 Blob_Generic_2105, *PBlob_Generic_2105;

struct Blob_Generic_2105 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3436 Blob_Generic_3436, *PBlob_Generic_3436;

struct Blob_Generic_3436 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10996 Blob_Generic_10996, *PBlob_Generic_10996;

struct Blob_Generic_10996 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_42580 Blob_Generic_42580, *PBlob_Generic_42580;

struct Blob_Generic_42580 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_528 Blob_Generic_528, *PBlob_Generic_528;

struct Blob_Generic_528 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9456 Blob_PropertySig_9456, *PBlob_PropertySig_9456;

typedef struct PropertySig_9456 PropertySig_9456, *PPropertySig_9456;

typedef struct Type_182987 Type_182987, *PType_182987;

struct Type_182987 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_9456 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182987 RetType; // Return type
};

struct Blob_PropertySig_9456 {
    byte Size; // coded integer - blob size
    struct PropertySig_9456 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_30592 Blob_Generic_30592, *PBlob_Generic_30592;

struct Blob_Generic_30592 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_46948 Blob_Generic_46948, *PBlob_Generic_46948;

struct Blob_Generic_46948 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_41244 Blob_Generic_41244, *PBlob_Generic_41244;

struct Blob_Generic_41244 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4770 Blob_Generic_4770, *PBlob_Generic_4770;

struct Blob_Generic_4770 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_22981 Blob_Generic_22981, *PBlob_Generic_22981;

struct Blob_Generic_22981 {
    byte Size; // coded integer - blob size
    byte Generic[64]; // Undefined blob contents
};

typedef struct Blob_Generic_4775 Blob_Generic_4775, *PBlob_Generic_4775;

struct Blob_Generic_4775 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_28291 Blob_Generic_28291, *PBlob_Generic_28291;

struct Blob_Generic_28291 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_Generic_7804 Blob_Generic_7804, *PBlob_Generic_7804;

struct Blob_Generic_7804 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_514 Blob_Generic_514, *PBlob_Generic_514;

struct Blob_Generic_514 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_3446 Blob_Generic_3446, *PBlob_Generic_3446;

struct Blob_Generic_3446 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2115 Blob_Generic_2115, *PBlob_Generic_2115;

struct Blob_Generic_2115 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_12702 Blob_Generic_12702, *PBlob_Generic_12702;

struct Blob_Generic_12702 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_33633 Blob_Generic_33633, *PBlob_Generic_33633;

struct Blob_Generic_33633 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19342 Blob_Generic_19342, *PBlob_Generic_19342;

struct Blob_Generic_19342 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_50192 Blob_Generic_50192, *PBlob_Generic_50192;

struct Blob_Generic_50192 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_44348 Blob_Generic_44348, *PBlob_Generic_44348;

struct Blob_Generic_44348 {
    byte Size; // coded integer - blob size
    byte Generic[71]; // Undefined blob contents
};

typedef struct Blob_Generic_23404 Blob_Generic_23404, *PBlob_Generic_23404;

struct Blob_Generic_23404 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_584 Blob_Generic_584, *PBlob_Generic_584;

struct Blob_Generic_584 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_2120 Blob_Generic_2120, *PBlob_Generic_2120;

struct Blob_Generic_2120 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_4780 Blob_Generic_4780, *PBlob_Generic_4780;

struct Blob_Generic_4780 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3454 Blob_Generic_3454, *PBlob_Generic_3454;

struct Blob_Generic_3454 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4785 Blob_Generic_4785, *PBlob_Generic_4785;

struct Blob_Generic_4785 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11421 Blob_Generic_11421, *PBlob_Generic_11421;

struct Blob_Generic_11421 {
    byte Size; // coded integer - blob size
    byte Generic[26]; // Undefined blob contents
};

typedef struct Blob_Generic_12755 Blob_Generic_12755, *PBlob_Generic_12755;

struct Blob_Generic_12755 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_7817 Blob_Generic_7817, *PBlob_Generic_7817;

struct Blob_Generic_7817 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_36710 Blob_Generic_36710, *PBlob_Generic_36710;

struct Blob_Generic_36710 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_19395 Blob_Generic_19395, *PBlob_Generic_19395;

struct Blob_Generic_19395 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_24734 Blob_Generic_24734, *PBlob_Generic_24734;

struct Blob_Generic_24734 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3462 Blob_Generic_3462, *PBlob_Generic_3462;

struct Blob_Generic_3462 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4791 Blob_Generic_4791, *PBlob_Generic_4791;

struct Blob_Generic_4791 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_570 Blob_Generic_570, *PBlob_Generic_570;

struct Blob_Generic_570 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7823 Blob_Generic_7823, *PBlob_Generic_7823;

struct Blob_Generic_7823 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12763 Blob_Generic_12763, *PBlob_Generic_12763;

struct Blob_Generic_12763 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_576 Blob_Generic_576, *PBlob_Generic_576;

struct Blob_Generic_576 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2135 Blob_Generic_2135, *PBlob_Generic_2135;

struct Blob_Generic_2135 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10103 Blob_Generic_10103, *PBlob_Generic_10103;

struct Blob_Generic_10103 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_20382 Blob_Generic_20382, *PBlob_Generic_20382;

struct Blob_Generic_20382 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_4798 Blob_Generic_4798, *PBlob_Generic_4798;

struct Blob_Generic_4798 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_10109 Blob_Generic_10109, *PBlob_Generic_10109;

struct Blob_Generic_10109 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_33696 Blob_Generic_33696, *PBlob_Generic_33696;

struct Blob_Generic_33696 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7829 Blob_Generic_7829, *PBlob_Generic_7829;

struct Blob_Generic_7829 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_18071 Blob_Generic_18071, *PBlob_Generic_18071;

struct Blob_Generic_18071 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_44327 Blob_Generic_44327, *PBlob_Generic_44327;

struct Blob_Generic_44327 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_21686 Blob_Generic_21686, *PBlob_Generic_21686;

struct Blob_Generic_21686 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_3470 Blob_Generic_3470, *PBlob_Generic_3470;

struct Blob_Generic_3470 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_564 Blob_Generic_564, *PBlob_Generic_564;

struct Blob_Generic_564 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2143 Blob_Generic_2143, *PBlob_Generic_2143;

struct Blob_Generic_2143 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6502 Blob_Generic_6502, *PBlob_Generic_6502;

struct Blob_Generic_6502 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12735 Blob_Generic_12735, *PBlob_Generic_12735;

struct Blob_Generic_12735 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_11409 Blob_Generic_11409, *PBlob_Generic_11409;

struct Blob_Generic_11409 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7838 Blob_Generic_7838, *PBlob_Generic_7838;

struct Blob_Generic_7838 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6508 Blob_Generic_6508, *PBlob_Generic_6508;

struct Blob_Generic_6508 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_34993 Blob_Generic_34993, *PBlob_Generic_34993;

struct Blob_Generic_34993 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_24713 Blob_Generic_24713, *PBlob_Generic_24713;

struct Blob_Generic_24713 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3483 Blob_Generic_3483, *PBlob_Generic_3483;

struct Blob_Generic_3483 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_2151 Blob_Generic_2151, *PBlob_Generic_2151;

struct Blob_Generic_2151 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_20361 Blob_Generic_20361, *PBlob_Generic_20361;

struct Blob_Generic_20361 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6515 Blob_Generic_6515, *PBlob_Generic_6515;

struct Blob_Generic_6515 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_7846 Blob_Generic_7846, *PBlob_Generic_7846;

struct Blob_Generic_7846 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_552 Blob_Generic_552, *PBlob_Generic_552;

struct Blob_Generic_552 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_31019 Blob_Generic_31019, *PBlob_Generic_31019;

struct Blob_Generic_31019 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_558 Blob_Generic_558, *PBlob_Generic_558;

struct Blob_Generic_558 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11415 Blob_Generic_11415, *PBlob_Generic_11415;

struct Blob_Generic_11415 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12747 Blob_Generic_12747, *PBlob_Generic_12747;

struct Blob_Generic_12747 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_12083 Blob_PropertySig_12083, *PBlob_PropertySig_12083;

typedef struct PropertySig_12083 PropertySig_12083, *PPropertySig_12083;

typedef struct Type_185614 Type_185614, *PType_185614;

struct Type_185614 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_12083 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185614 RetType; // Return type
};

struct Blob_PropertySig_12083 {
    byte Size; // coded integer - blob size
    struct PropertySig_12083 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_8179 Blob_PropertySig_8179, *PBlob_PropertySig_8179;

typedef struct PropertySig_8179 PropertySig_8179, *PPropertySig_8179;

typedef struct Type_181710 Type_181710, *PType_181710;

struct Type_181710 {
    struct GenericInstType_181711 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_8179 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181710 RetType; // Return type
};

struct Blob_PropertySig_8179 {
    byte Size; // coded integer - blob size
    struct PropertySig_8179 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_33675 Blob_Generic_33675, *PBlob_Generic_33675;

struct Blob_Generic_33675 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18050 Blob_Generic_18050, *PBlob_Generic_18050;

struct Blob_Generic_18050 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_42520 Blob_Generic_42520, *PBlob_Generic_42520;

struct Blob_Generic_42520 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_PropertySig_794 Blob_PropertySig_794, *PBlob_PropertySig_794;

typedef struct PropertySig_794 PropertySig_794, *PPropertySig_794;

typedef struct Type_174325 Type_174325, *PType_174325;

struct Type_174325 {
    struct GenericInstType_174326 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_794 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174325 RetType; // Return type
};

struct Blob_PropertySig_794 {
    byte Size; // coded integer - blob size
    struct PropertySig_794 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8265 Blob_Generic_8265, *PBlob_Generic_8265;

struct Blob_Generic_8265 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_9596 Blob_Generic_9596, *PBlob_Generic_9596;

struct Blob_Generic_9596 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_1631 Blob_Generic_1631, *PBlob_Generic_1631;

struct Blob_Generic_1631 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10933 Blob_Generic_10933, *PBlob_Generic_10933;

struct Blob_Generic_10933 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_29542 Blob_Generic_29542, *PBlob_Generic_29542;

struct Blob_Generic_29542 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1637 Blob_Generic_1637, *PBlob_Generic_1637;

struct Blob_Generic_1637 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_8272 Blob_Generic_8272, *PBlob_Generic_8272;

struct Blob_Generic_8272 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_22916 Blob_Generic_22916, *PBlob_Generic_22916;

struct Blob_Generic_22916 {
    byte Size; // coded integer - blob size
    byte Generic[64]; // Undefined blob contents
};

typedef struct Blob_Generic_37163 Blob_Generic_37163, *PBlob_Generic_37163;

struct Blob_Generic_37163 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_37184 Blob_Generic_37184, *PBlob_Generic_37184;

struct Blob_Generic_37184 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16242 Blob_Generic_16242, *PBlob_Generic_16242;

struct Blob_Generic_16242 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_PropertySig_781 Blob_PropertySig_781, *PBlob_PropertySig_781;

typedef struct PropertySig_781 PropertySig_781, *PPropertySig_781;

typedef struct Type_174312 Type_174312, *PType_174312;

struct Type_174312 {
    struct GenericInstType_174313 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_781 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174312 RetType; // Return type
};

struct Blob_PropertySig_781 {
    byte Size; // coded integer - blob size
    struct PropertySig_781 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2970 Blob_Generic_2970, *PBlob_Generic_2970;

struct Blob_Generic_2970 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_10941 Blob_Generic_10941, *PBlob_Generic_10941;

struct Blob_Generic_10941 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_31877 Blob_Generic_31877, *PBlob_Generic_31877;

struct Blob_Generic_31877 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_49143 Blob_Generic_49143, *PBlob_Generic_49143;

struct Blob_Generic_49143 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1647 Blob_Generic_1647, *PBlob_Generic_1647;

struct Blob_Generic_1647 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10949 Blob_Generic_10949, *PBlob_Generic_10949;

struct Blob_Generic_10949 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_28228 Blob_Generic_28228, *PBlob_Generic_28228;

struct Blob_Generic_28228 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_789 Blob_PropertySig_789, *PBlob_PropertySig_789;

typedef struct PropertySig_789 PropertySig_789, *PPropertySig_789;

typedef struct Type_174320 Type_174320, *PType_174320;

struct Type_174320 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_789 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174320 RetType; // Return type
};

struct Blob_PropertySig_789 {
    byte Size; // coded integer - blob size
    struct PropertySig_789 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8282 Blob_Generic_8282, *PBlob_Generic_8282;

struct Blob_Generic_8282 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_52790 Blob_Generic_52790, *PBlob_Generic_52790;

struct Blob_Generic_52790 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_43848 Blob_Generic_43848, *PBlob_Generic_43848;

struct Blob_Generic_43848 {
    byte Size; // coded integer - blob size
    byte Generic[65]; // Undefined blob contents
};

typedef struct Blob_Generic_51457 Blob_Generic_51457, *PBlob_Generic_51457;

struct Blob_Generic_51457 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_1655 Blob_Generic_1655, *PBlob_Generic_1655;

struct Blob_Generic_1655 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2986 Blob_Generic_2986, *PBlob_Generic_2986;

struct Blob_Generic_2986 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_30516 Blob_Generic_30516, *PBlob_Generic_30516;

struct Blob_Generic_30516 {
    byte Size; // coded integer - blob size
    byte Generic[33]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6347 Blob_PropertySig_6347, *PBlob_PropertySig_6347;

typedef struct PropertySig_6347 PropertySig_6347, *PPropertySig_6347;

typedef struct Type_179878 Type_179878, *PType_179878;

struct Type_179878 {
    struct GenericInstType_179879 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_6347 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179878 RetType; // Return type
};

struct Blob_PropertySig_6347 {
    byte Size; // coded integer - blob size
    struct PropertySig_6347 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_10917 Blob_Generic_10917, *PBlob_Generic_10917;

struct Blob_Generic_10917 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_8292 Blob_Generic_8292, *PBlob_Generic_8292;

struct Blob_Generic_8292 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_38491 Blob_Generic_38491, *PBlob_Generic_38491;

struct Blob_Generic_38491 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_37142 Blob_Generic_37142, *PBlob_Generic_37142;

struct Blob_Generic_37142 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16221 Blob_Generic_16221, *PBlob_Generic_16221;

struct Blob_Generic_16221 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_13198 Blob_Generic_13198, *PBlob_Generic_13198;

struct Blob_Generic_13198 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18883 Blob_Generic_18883, *PBlob_Generic_18883;

struct Blob_Generic_18883 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1661 Blob_Generic_1661, *PBlob_Generic_1661;

struct Blob_Generic_1661 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_17559 Blob_Generic_17559, *PBlob_Generic_17559;

struct Blob_Generic_17559 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_2991 Blob_Generic_2991, *PBlob_Generic_2991;

struct Blob_Generic_2991 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_2996 Blob_Generic_2996, *PBlob_Generic_2996;

struct Blob_Generic_2996 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_31856 Blob_Generic_31856, *PBlob_Generic_31856;

struct Blob_Generic_31856 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25183 Blob_Generic_25183, *PBlob_Generic_25183;

struct Blob_Generic_25183 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6357 Blob_PropertySig_6357, *PBlob_PropertySig_6357;

typedef struct PropertySig_6357 PropertySig_6357, *PPropertySig_6357;

typedef struct Type_179888 Type_179888, *PType_179888;

struct Type_179888 {
    struct GenericInstType_179889 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_6357 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179888 RetType; // Return type
};

struct Blob_PropertySig_6357 {
    byte Size; // coded integer - blob size
    struct PropertySig_6357 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_43827 Blob_Generic_43827, *PBlob_Generic_43827;

struct Blob_Generic_43827 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_42567 Blob_Generic_42567, *PBlob_Generic_42567;

struct Blob_Generic_42567 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_1671 Blob_Generic_1671, *PBlob_Generic_1671;

struct Blob_Generic_1671 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10972 Blob_Generic_10972, *PBlob_Generic_10972;

struct Blob_Generic_10972 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_506 Blob_Generic_506, *PBlob_Generic_506;

struct Blob_Generic_506 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4704 Blob_Generic_4704, *PBlob_Generic_4704;

struct Blob_Generic_4704 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10979 Blob_Generic_10979, *PBlob_Generic_10979;

struct Blob_Generic_10979 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_29584 Blob_Generic_29584, *PBlob_Generic_29584;

struct Blob_Generic_29584 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_Generic_30571 Blob_Generic_30571, *PBlob_Generic_30571;

struct Blob_Generic_30571 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16286 Blob_Generic_16286, *PBlob_Generic_16286;

struct Blob_Generic_16286 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41223 Blob_Generic_41223, *PBlob_Generic_41223;

struct Blob_Generic_41223 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_28270 Blob_Generic_28270, *PBlob_Generic_28270;

struct Blob_Generic_28270 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1681 Blob_Generic_1681, *PBlob_Generic_1681;

struct Blob_Generic_1681 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10985 Blob_Generic_10985, *PBlob_Generic_10985;

struct Blob_Generic_10985 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9450 Blob_PropertySig_9450, *PBlob_PropertySig_9450;

typedef struct PropertySig_9450 PropertySig_9450, *PPropertySig_9450;

typedef struct Type_182981 Type_182981, *PType_182981;

struct Type_182981 {
    struct ValueType.conflict35 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_9450 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182981 RetType; // Return type
};

struct Blob_PropertySig_9450 {
    byte Size; // coded integer - blob size
    struct PropertySig_9450 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_4710 Blob_Generic_4710, *PBlob_Generic_4710;

struct Blob_Generic_4710 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_33612 Blob_Generic_33612, *PBlob_Generic_33612;

struct Blob_Generic_33612 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4716 Blob_Generic_4716, *PBlob_Generic_4716;

struct Blob_Generic_4716 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_34943 Blob_Generic_34943, *PBlob_Generic_34943;

struct Blob_Generic_34943 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_20307 Blob_Generic_20307, *PBlob_Generic_20307;

struct Blob_Generic_20307 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_21637 Blob_Generic_21637, *PBlob_Generic_21637;

struct Blob_Generic_21637 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_1691 Blob_Generic_1691, *PBlob_Generic_1691;

struct Blob_Generic_1691 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11601 Blob_PropertySig_11601, *PBlob_PropertySig_11601;

typedef struct PropertySig_11601 PropertySig_11601, *PPropertySig_11601;

typedef struct Type_185132 Type_185132, *PType_185132;

struct Type_185132 {
    struct GenericInstType_185133 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11601 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185132 RetType; // Return type
};

struct Blob_PropertySig_11601 {
    byte Size; // coded integer - blob size
    struct PropertySig_11601 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_4722 Blob_Generic_4722, *PBlob_Generic_4722;

struct Blob_Generic_4722 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4728 Blob_Generic_4728, *PBlob_Generic_4728;

struct Blob_Generic_4728 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_29563 Blob_Generic_29563, *PBlob_Generic_29563;

struct Blob_Generic_29563 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_30550 Blob_Generic_30550, *PBlob_Generic_30550;

struct Blob_Generic_30550 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_50160 Blob_Generic_50160, *PBlob_Generic_50160;

struct Blob_Generic_50160 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_CustomAttrib_12882 Blob_CustomAttrib_12882, *PBlob_CustomAttrib_12882;

struct Blob_CustomAttrib_12882 {
    byte Size; // coded integer - blob size
    struct CustomAttrib_12882 CustomAttrib; // A CustomAttrib blob stores values of fixed or named parameters supplied when instantiating a custom attribute
};

typedef struct Blob_Generic_41202 Blob_Generic_41202, *PBlob_Generic_41202;

struct Blob_Generic_41202 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3403 Blob_Generic_3403, *PBlob_Generic_3403;

struct Blob_Generic_3403 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4734 Blob_Generic_4734, *PBlob_Generic_4734;

struct Blob_Generic_4734 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10963 Blob_Generic_10963, *PBlob_Generic_10963;

struct Blob_Generic_10963 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_49164 Blob_Generic_49164, *PBlob_Generic_49164;

struct Blob_Generic_49164 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_31898 Blob_Generic_31898, *PBlob_Generic_31898;

struct Blob_Generic_31898 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_Generic_28249 Blob_Generic_28249, *PBlob_Generic_28249;

struct Blob_Generic_28249 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_720 Blob_PropertySig_720, *PBlob_PropertySig_720;

typedef struct PropertySig_720 PropertySig_720, *PPropertySig_720;

typedef struct Type_174251 Type_174251, *PType_174251;

struct Type_174251 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_720 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174251 RetType; // Return type
};

struct Blob_PropertySig_720 {
    byte Size; // coded integer - blob size
    struct PropertySig_720 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_21616 Blob_Generic_21616, *PBlob_Generic_21616;

struct Blob_Generic_21616 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6484 Blob_Generic_6484, *PBlob_Generic_6484;

struct Blob_Generic_6484 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5151 Blob_Generic_5151, *PBlob_Generic_5151;

struct Blob_Generic_5151 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_13240 Blob_Generic_13240, *PBlob_Generic_13240;

struct Blob_Generic_13240 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_14575 Blob_Generic_14575, *PBlob_Generic_14575;

struct Blob_Generic_14575 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5158 Blob_Generic_5158, *PBlob_Generic_5158;

struct Blob_Generic_5158 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_17602 Blob_Generic_17602, *PBlob_Generic_17602;

struct Blob_Generic_17602 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_46161 Blob_Generic_46161, *PBlob_Generic_46161;

struct Blob_Generic_46161 {
    byte Size; // coded integer - blob size
    byte Generic[41]; // Undefined blob contents
};

typedef struct Blob_Generic_9515 Blob_Generic_9515, *PBlob_Generic_9515;

struct Blob_Generic_9515 {
    byte Size; // coded integer - blob size
    byte Generic[28]; // Undefined blob contents
};

typedef struct Blob_Generic_37205 Blob_Generic_37205, *PBlob_Generic_37205;

struct Blob_Generic_37205 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_Generic_40866 Blob_Generic_40866, *PBlob_Generic_40866;

struct Blob_Generic_40866 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_11190 Blob_FieldSig_11190, *PBlob_FieldSig_11190;

typedef struct FieldSig_11190 FieldSig_11190, *PFieldSig_11190;

typedef struct Type_184720 Type_184720, *PType_184720;

struct Type_184720 {
    struct ValueType.conflict38 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_11190 {
    byte FIELD; // Magic (0x06)
    struct Type_184720 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_11190 {
    byte Size; // coded integer - blob size
    struct FieldSig_11190 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_6490 Blob_Generic_6490, *PBlob_Generic_6490;

struct Blob_Generic_6490 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6496 Blob_Generic_6496, *PBlob_Generic_6496;

struct Blob_Generic_6496 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_18942 Blob_Generic_18942, *PBlob_Generic_18942;

struct Blob_Generic_18942 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_38530 Blob_Generic_38530, *PBlob_Generic_38530;

struct Blob_Generic_38530 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5165 Blob_Generic_5165, *PBlob_Generic_5165;

struct Blob_Generic_5165 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_39866 Blob_Generic_39866, *PBlob_Generic_39866;

struct Blob_Generic_39866 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_51505 Blob_Generic_51505, *PBlob_Generic_51505;

struct Blob_Generic_51505 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_26563 Blob_Generic_26563, *PBlob_Generic_26563;

struct Blob_Generic_26563 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10191 Blob_Generic_10191, *PBlob_Generic_10191;

struct Blob_Generic_10191 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_5172 Blob_Generic_5172, *PBlob_Generic_5172;

struct Blob_Generic_5172 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_14554 Blob_Generic_14554, *PBlob_Generic_14554;

struct Blob_Generic_14554 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8209 Blob_Generic_8209, *PBlob_Generic_8209;

struct Blob_Generic_8209 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_22175 Blob_Generic_22175, *PBlob_Generic_22175;

struct Blob_Generic_22175 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_5179 Blob_Generic_5179, *PBlob_Generic_5179;

struct Blob_Generic_5179 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_25204 Blob_Generic_25204, *PBlob_Generic_25204;

struct Blob_Generic_25204 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_40845 Blob_Generic_40845, *PBlob_Generic_40845;

struct Blob_Generic_40845 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2908 Blob_Generic_2908, *PBlob_Generic_2908;

struct Blob_Generic_2908 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34152 Blob_Generic_34152, *PBlob_Generic_34152;

struct Blob_Generic_34152 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_9544 Blob_Generic_9544, *PBlob_Generic_9544;

struct Blob_Generic_9544 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_5186 Blob_Generic_5186, *PBlob_Generic_5186;

struct Blob_Generic_5186 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_48799 Blob_Generic_48799, *PBlob_Generic_48799;

struct Blob_Generic_48799 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10269 Blob_PropertySig_10269, *PBlob_PropertySig_10269;

typedef struct PropertySig_10269 PropertySig_10269, *PPropertySig_10269;

typedef struct Type_183800 Type_183800, *PType_183800;

struct Type_183800 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10269 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183800 RetType; // Return type
};

struct Blob_PropertySig_10269 {
    byte Size; // coded integer - blob size
    struct PropertySig_10269 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_47464 Blob_Generic_47464, *PBlob_Generic_47464;

struct Blob_Generic_47464 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_52811 Blob_Generic_52811, *PBlob_Generic_52811;

struct Blob_Generic_52811 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_39845 Blob_Generic_39845, *PBlob_Generic_39845;

struct Blob_Generic_39845 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4580 Blob_PropertySig_4580, *PBlob_PropertySig_4580;

typedef struct PropertySig_4580 PropertySig_4580, *PPropertySig_4580;

typedef struct Type_178111 Type_178111, *PType_178111;

struct Type_178111 {
    struct GenericInstType_178112 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_4580 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178111 RetType; // Return type
};

struct Blob_PropertySig_4580 {
    byte Size; // coded integer - blob size
    struct PropertySig_4580 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8217 Blob_Generic_8217, *PBlob_Generic_8217;

struct Blob_Generic_8217 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4574 Blob_PropertySig_4574, *PBlob_PropertySig_4574;

typedef struct PropertySig_4574 PropertySig_4574, *PPropertySig_4574;

typedef struct Type_178105 Type_178105, *PType_178105;

struct Type_178105 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4574 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178105 RetType; // Return type
};

struct Blob_PropertySig_4574 {
    byte Size; // coded integer - blob size
    struct PropertySig_4574 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_27872 Blob_Generic_27872, *PBlob_Generic_27872;

struct Blob_Generic_27872 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10263 Blob_PropertySig_10263, *PBlob_PropertySig_10263;

typedef struct PropertySig_10263 PropertySig_10263, *PPropertySig_10263;

typedef struct Type_183794 Type_183794, *PType_183794;

struct Type_183794 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10263 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183794 RetType; // Return type
};

struct Blob_PropertySig_10263 {
    byte Size; // coded integer - blob size
    struct PropertySig_10263 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_804 Blob_PropertySig_804, *PBlob_PropertySig_804;

typedef struct PropertySig_804 PropertySig_804, *PPropertySig_804;

typedef struct Type_174335 Type_174335, *PType_174335;

struct Type_174335 {
    struct GenericInstType_174336 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_804 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174335 RetType; // Return type
};

struct Blob_PropertySig_804 {
    byte Size; // coded integer - blob size
    struct PropertySig_804 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_17641 Blob_Generic_17641, *PBlob_Generic_17641;

struct Blob_Generic_17641 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8225 Blob_Generic_8225, *PBlob_Generic_8225;

struct Blob_Generic_8225 {
    byte Size; // coded integer - blob size
    byte Generic[17]; // Undefined blob contents
};

typedef struct Blob_Generic_13285 Blob_Generic_13285, *PBlob_Generic_13285;

struct Blob_Generic_13285 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5193 Blob_Generic_5193, *PBlob_Generic_5193;

struct Blob_Generic_5193 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_9555 Blob_Generic_9555, *PBlob_Generic_9555;

struct Blob_Generic_9555 {
    byte Size; // coded integer - blob size
    byte Generic[21]; // Undefined blob contents
};

typedef struct Blob_Generic_49239 Blob_Generic_49239, *PBlob_Generic_49239;

struct Blob_Generic_49239 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25261 Blob_Generic_25261, *PBlob_Generic_25261;

struct Blob_Generic_25261 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_2929 Blob_Generic_2929, *PBlob_Generic_2929;

struct Blob_Generic_2929 {
    byte Size; // coded integer - blob size
    byte Generic[18]; // Undefined blob contents
};

typedef struct Blob_FieldSig_4780 Blob_FieldSig_4780, *PBlob_FieldSig_4780;

typedef struct FieldSig_4780 FieldSig_4780, *PFieldSig_4780;

typedef struct Type_178310 Type_178310, *PType_178310;

struct Type_178310 {
    struct ValueType.conflict12 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_4780 {
    byte FIELD; // Magic (0x06)
    struct Type_178310 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_4780 {
    byte Size; // coded integer - blob size
    struct FieldSig_4780 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_18984 Blob_Generic_18984, *PBlob_Generic_18984;

struct Blob_Generic_18984 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_38572 Blob_Generic_38572, *PBlob_Generic_38572;

struct Blob_Generic_38572 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_52876 Blob_Generic_52876, *PBlob_Generic_52876;

struct Blob_Generic_52876 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_51547 Blob_Generic_51547, *PBlob_Generic_51547;

struct Blob_Generic_51547 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1601 Blob_Generic_1601, *PBlob_Generic_1601;

struct Blob_Generic_1601 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_25274 Blob_Generic_25274, *PBlob_Generic_25274;

struct Blob_Generic_25274 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_29635 Blob_Generic_29635, *PBlob_Generic_29635;

struct Blob_Generic_29635 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_50213 Blob_Generic_50213, *PBlob_Generic_50213;

struct Blob_Generic_50213 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_4770 Blob_FieldSig_4770, *PBlob_FieldSig_4770;

typedef struct FieldSig_4770 FieldSig_4770, *PFieldSig_4770;

typedef struct Type_178300 Type_178300, *PType_178300;

struct Type_178300 {
    struct ValueType.conflict10 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_4770 {
    byte FIELD; // Magic (0x06)
    struct Type_178300 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_4770 {
    byte Size; // coded integer - blob size
    struct FieldSig_4770 FieldSig; // Type information for Field
};

typedef struct Blob_FieldSig_4775 Blob_FieldSig_4775, *PBlob_FieldSig_4775;

typedef struct FieldSig_4775 FieldSig_4775, *PFieldSig_4775;

typedef struct Type_178305 Type_178305, *PType_178305;

struct Type_178305 {
    struct ValueType.conflict11 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_4775 {
    byte FIELD; // Magic (0x06)
    struct Type_178305 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_4775 {
    byte Size; // coded integer - blob size
    struct FieldSig_4775 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_9577 Blob_Generic_9577, *PBlob_Generic_9577;

struct Blob_Generic_9577 {
    byte Size; // coded integer - blob size
    byte Generic[18]; // Undefined blob contents
};

typedef struct Blob_Generic_49218 Blob_Generic_49218, *PBlob_Generic_49218;

struct Blob_Generic_49218 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8243 Blob_Generic_8243, *PBlob_Generic_8243;

struct Blob_Generic_8243 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_14596 Blob_Generic_14596, *PBlob_Generic_14596;

struct Blob_Generic_14596 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3282 Blob_PropertySig_3282, *PBlob_PropertySig_3282;

typedef struct PropertySig_3282 PropertySig_3282, *PPropertySig_3282;

typedef struct Type_176813 Type_176813, *PType_176813;

struct Type_176813 {
    struct GenericInstType_176814 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_3282 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176813 RetType; // Return type
};

struct Blob_PropertySig_3282 {
    byte Size; // coded integer - blob size
    struct PropertySig_3282 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1614 Blob_Generic_1614, *PBlob_Generic_1614;

struct Blob_Generic_1614 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_2948 Blob_Generic_2948, *PBlob_Generic_2948;

struct Blob_Generic_2948 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7631 Blob_PropertySig_7631, *PBlob_PropertySig_7631;

typedef struct PropertySig_7631 PropertySig_7631, *PPropertySig_7631;

typedef struct Type_181162 Type_181162, *PType_181162;

struct Type_181162 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_7631 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181162 RetType; // Return type
};

struct Blob_PropertySig_7631 {
    byte Size; // coded integer - blob size
    struct PropertySig_7631 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_25248 Blob_Generic_25248, *PBlob_Generic_25248;

struct Blob_Generic_25248 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_40887 Blob_Generic_40887, *PBlob_Generic_40887;

struct Blob_Generic_40887 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_7637 Blob_PropertySig_7637, *PBlob_PropertySig_7637;

typedef struct PropertySig_7637 PropertySig_7637, *PPropertySig_7637;

typedef struct Type_181168 Type_181168, *PType_181168;

struct Type_181168 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_7637 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181168 RetType; // Return type
};

struct Blob_PropertySig_7637 {
    byte Size; // coded integer - blob size
    struct PropertySig_7637 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_43914 Blob_Generic_43914, *PBlob_Generic_43914;

struct Blob_Generic_43914 {
    byte Size; // coded integer - blob size
    byte Generic[65]; // Undefined blob contents
};

typedef struct Blob_Generic_18963 Blob_Generic_18963, *PBlob_Generic_18963;

struct Blob_Generic_18963 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_38551 Blob_Generic_38551, *PBlob_Generic_38551;

struct Blob_Generic_38551 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8254 Blob_Generic_8254, *PBlob_Generic_8254;

struct Blob_Generic_8254 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_39887 Blob_Generic_39887, *PBlob_Generic_39887;

struct Blob_Generic_39887 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16307 Blob_Generic_16307, *PBlob_Generic_16307;

struct Blob_Generic_16307 {
    byte Size; // coded integer - blob size
    byte Generic[28]; // Undefined blob contents
};

typedef struct Blob_Generic_52855 Blob_Generic_52855, *PBlob_Generic_52855;

struct Blob_Generic_52855 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_51526 Blob_Generic_51526, *PBlob_Generic_51526;

struct Blob_Generic_51526 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1625 Blob_Generic_1625, *PBlob_Generic_1625;

struct Blob_Generic_1625 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2954 Blob_Generic_2954, *PBlob_Generic_2954;

struct Blob_Generic_2954 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_26584 Blob_Generic_26584, *PBlob_Generic_26584;

struct Blob_Generic_26584 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8974 Blob_PropertySig_8974, *PBlob_PropertySig_8974;

typedef struct PropertySig_8974 PropertySig_8974, *PPropertySig_8974;

typedef struct Type_182505 Type_182505, *PType_182505;

struct Type_182505 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_8974 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182505 RetType; // Return type
};

struct Blob_PropertySig_8974 {
    byte Size; // coded integer - blob size
    struct PropertySig_8974 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2043 Blob_Generic_2043, *PBlob_Generic_2043;

struct Blob_Generic_2043 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_22114 Blob_Generic_22114, *PBlob_Generic_22114;

struct Blob_Generic_22114 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_12795 Blob_Generic_12795, *PBlob_Generic_12795;

struct Blob_Generic_12795 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7737 Blob_Generic_7737, *PBlob_Generic_7737;

struct Blob_Generic_7737 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10136 Blob_Generic_10136, *PBlob_Generic_10136;

struct Blob_Generic_10136 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_6400 Blob_Generic_6400, *PBlob_Generic_6400;

struct Blob_Generic_6400 {
    byte Size; // coded integer - blob size
    byte Generic[31]; // Undefined blob contents
};

typedef struct Blob_Generic_7731 Blob_Generic_7731, *PBlob_Generic_7731;

struct Blob_Generic_7731 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_43054 Blob_Generic_43054, *PBlob_Generic_43054;

struct Blob_Generic_43054 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2049 Blob_Generic_2049, *PBlob_Generic_2049;

struct Blob_Generic_2049 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5831 Blob_PropertySig_5831, *PBlob_PropertySig_5831;

typedef struct PropertySig_5831 PropertySig_5831, *PPropertySig_5831;

typedef struct Type_179362 Type_179362, *PType_179362;

struct Type_179362 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_5831 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179362 RetType; // Return type
};

struct Blob_PropertySig_5831 {
    byte Size; // coded integer - blob size
    struct PropertySig_5831 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_36757 Blob_Generic_36757, *PBlob_Generic_36757;

struct Blob_Generic_36757 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_32398 Blob_Generic_32398, *PBlob_Generic_32398;

struct Blob_Generic_32398 {
    byte Size; // coded integer - blob size
    byte Generic[59]; // Undefined blob contents
};

typedef struct Blob_Generic_27802 Blob_Generic_27802, *PBlob_Generic_27802;

struct Blob_Generic_27802 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_PropertySig_12077 Blob_PropertySig_12077, *PBlob_PropertySig_12077;

typedef struct PropertySig_12077 PropertySig_12077, *PPropertySig_12077;

typedef struct Type_185608 Type_185608, *PType_185608;

struct Type_185608 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_12077 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185608 RetType; // Return type
};

struct Blob_PropertySig_12077 {
    byte Size; // coded integer - blob size
    struct PropertySig_12077 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_31061 Blob_Generic_31061, *PBlob_Generic_31061;

struct Blob_Generic_31061 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_48736 Blob_Generic_48736, *PBlob_Generic_48736;

struct Blob_Generic_48736 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2054 Blob_Generic_2054, *PBlob_Generic_2054;

struct Blob_Generic_2054 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_11473 Blob_Generic_11473, *PBlob_Generic_11473;

struct Blob_Generic_11473 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7746 Blob_Generic_7746, *PBlob_Generic_7746;

struct Blob_Generic_7746 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10145 Blob_Generic_10145, *PBlob_Generic_10145;

struct Blob_Generic_10145 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_15832 Blob_Generic_15832, *PBlob_Generic_15832;

struct Blob_Generic_15832 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_35436 Blob_Generic_35436, *PBlob_Generic_35436;

struct Blob_Generic_35436 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4514 Blob_PropertySig_4514, *PBlob_PropertySig_4514;

typedef struct PropertySig_4514 PropertySig_4514, *PPropertySig_4514;

typedef struct Type_178045 Type_178045, *PType_178045;

struct Type_178045 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4514 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_178045 RetType; // Return type
};

struct Blob_PropertySig_4514 {
    byte Size; // coded integer - blob size
    struct PropertySig_4514 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_23425 Blob_Generic_23425, *PBlob_Generic_23425;

struct Blob_Generic_23425 {
    byte Size; // coded integer - blob size
    byte Generic[70]; // Undefined blob contents
};

typedef struct Blob_Generic_2065 Blob_Generic_2065, *PBlob_Generic_2065;

struct Blob_Generic_2065 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3395 Blob_Generic_3395, *PBlob_Generic_3395;

struct Blob_Generic_3395 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12773 Blob_Generic_12773, *PBlob_Generic_12773;

struct Blob_Generic_12773 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_7755 Blob_Generic_7755, *PBlob_Generic_7755;

struct Blob_Generic_7755 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_11448 Blob_Generic_11448, *PBlob_Generic_11448;

struct Blob_Generic_11448 {
    byte Size; // coded integer - blob size
    byte Generic[24]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8097 Blob_PropertySig_8097, *PBlob_PropertySig_8097;

typedef struct PropertySig_8097 PropertySig_8097, *PPropertySig_8097;

typedef struct Type_181628 Type_181628, *PType_181628;

struct Type_181628 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_8097 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181628 RetType; // Return type
};

struct Blob_PropertySig_8097 {
    byte Size; // coded integer - blob size
    struct PropertySig_8097 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1451 Blob_PropertySig_1451, *PBlob_PropertySig_1451;

typedef struct PropertySig_1451 PropertySig_1451, *PPropertySig_1451;

typedef struct Type_174982 Type_174982, *PType_174982;

struct Type_174982 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_1451 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174982 RetType; // Return type
};

struct Blob_PropertySig_1451 {
    byte Size; // coded integer - blob size
    struct PropertySig_1451 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_32377 Blob_Generic_32377, *PBlob_Generic_32377;

struct Blob_Generic_32377 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_31040 Blob_Generic_31040, *PBlob_Generic_31040;

struct Blob_Generic_31040 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1457 Blob_PropertySig_1457, *PBlob_PropertySig_1457;

typedef struct PropertySig_1457 PropertySig_1457, *PPropertySig_1457;

typedef struct Type_174988 Type_174988, *PType_174988;

struct Type_174988 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_1457 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174988 RetType; // Return type
};

struct Blob_PropertySig_1457 {
    byte Size; // coded integer - blob size
    struct PropertySig_1457 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_2786 Blob_PropertySig_2786, *PBlob_PropertySig_2786;

typedef struct PropertySig_2786 PropertySig_2786, *PPropertySig_2786;

typedef struct Type_176317 Type_176317, *PType_176317;

struct Type_176317 {
    struct ValueType.conflict7 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_2786 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176317 RetType; // Return type
};

struct Blob_PropertySig_2786 {
    byte Size; // coded integer - blob size
    struct PropertySig_2786 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_24755 Blob_Generic_24755, *PBlob_Generic_24755;

struct Blob_Generic_24755 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_6432 Blob_Generic_6432, *PBlob_Generic_6432;

struct Blob_Generic_6432 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_593 Blob_Generic_593, *PBlob_Generic_593;

struct Blob_Generic_593 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_2073 Blob_Generic_2073, *PBlob_Generic_2073;

struct Blob_Generic_2073 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10120 Blob_Generic_10120, *PBlob_Generic_10120;

struct Blob_Generic_10120 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12782 Blob_Generic_12782, *PBlob_Generic_12782;

struct Blob_Generic_12782 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_7764 Blob_Generic_7764, *PBlob_Generic_7764;

struct Blob_Generic_7764 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_12789 Blob_Generic_12789, *PBlob_Generic_12789;

struct Blob_Generic_12789 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10128 Blob_Generic_10128, *PBlob_Generic_10128;

struct Blob_Generic_10128 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5106 Blob_Generic_5106, *PBlob_Generic_5106;

struct Blob_Generic_5106 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_18092 Blob_Generic_18092, *PBlob_Generic_18092;

struct Blob_Generic_18092 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_6441 Blob_Generic_6441, *PBlob_Generic_6441;

struct Blob_Generic_6441 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2081 Blob_Generic_2081, *PBlob_Generic_2081;

struct Blob_Generic_2081 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5112 Blob_Generic_5112, *PBlob_Generic_5112;

struct Blob_Generic_5112 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10175 Blob_Generic_10175, *PBlob_Generic_10175;

struct Blob_Generic_10175 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_22154 Blob_Generic_22154, *PBlob_Generic_22154;

struct Blob_Generic_22154 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5118 Blob_Generic_5118, *PBlob_Generic_5118;

struct Blob_Generic_5118 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_7777 Blob_Generic_7777, *PBlob_Generic_7777;

struct Blob_Generic_7777 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_6447 Blob_Generic_6447, *PBlob_Generic_6447;

struct Blob_Generic_6447 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_43096 Blob_Generic_43096, *PBlob_Generic_43096;

struct Blob_Generic_43096 {
    byte Size; // coded integer - blob size
    byte Generic[69]; // Undefined blob contents
};

typedef struct Blob_Generic_36799 Blob_Generic_36799, *PBlob_Generic_36799;

struct Blob_Generic_36799 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_26511 Blob_Generic_26511, *PBlob_Generic_26511;

struct Blob_Generic_26511 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_34131 Blob_Generic_34131, *PBlob_Generic_34131;

struct Blob_Generic_34131 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2090 Blob_Generic_2090, *PBlob_Generic_2090;

struct Blob_Generic_2090 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_40824 Blob_Generic_40824, *PBlob_Generic_40824;

struct Blob_Generic_40824 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6453 Blob_Generic_6453, *PBlob_Generic_6453;

struct Blob_Generic_6453 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10183 Blob_Generic_10183, *PBlob_Generic_10183;

struct Blob_Generic_10183 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_48778 Blob_Generic_48778, *PBlob_Generic_48778;

struct Blob_Generic_48778 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5122 Blob_Generic_5122, *PBlob_Generic_5122;

struct Blob_Generic_5122 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_15874 Blob_Generic_15874, *PBlob_Generic_15874;

struct Blob_Generic_15874 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_2095 Blob_Generic_2095, *PBlob_Generic_2095;

struct Blob_Generic_2095 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_5127 Blob_Generic_5127, *PBlob_Generic_5127;

struct Blob_Generic_5127 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_6459 Blob_Generic_6459, *PBlob_Generic_6459;

struct Blob_Generic_6459 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_18904 Blob_Generic_18904, *PBlob_Generic_18904;

struct Blob_Generic_18904 {
    byte Size; // coded integer - blob size
    byte Generic[37]; // Undefined blob contents
};

typedef struct Blob_Generic_23496 Blob_Generic_23496, *PBlob_Generic_23496;

struct Blob_Generic_23496 {
    byte Size; // coded integer - blob size
    byte Generic[70]; // Undefined blob contents
};

typedef struct Blob_Generic_47443 Blob_Generic_47443, *PBlob_Generic_47443;

struct Blob_Generic_47443 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7786 Blob_Generic_7786, *PBlob_Generic_7786;

struct Blob_Generic_7786 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_13219 Blob_Generic_13219, *PBlob_Generic_13219;

struct Blob_Generic_13219 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_2996 Blob_FieldSig_2996, *PBlob_FieldSig_2996;

typedef struct FieldSig_2996 FieldSig_2996, *PFieldSig_2996;

typedef struct Type_176526 Type_176526, *PType_176526;

struct Type_176526 {
    struct ValueType.conflict2 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_2996 {
    byte FIELD; // Magic (0x06)
    struct Type_176526 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_2996 {
    byte Size; // coded integer - blob size
    struct FieldSig_2996 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_27851 Blob_Generic_27851, *PBlob_Generic_27851;

struct Blob_Generic_27851 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5881 Blob_PropertySig_5881, *PBlob_PropertySig_5881;

typedef struct PropertySig_5881 PropertySig_5881, *PPropertySig_5881;

typedef struct Type_179412 Type_179412, *PType_179412;

struct Type_179412 {
    struct ValueType.conflict20 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_5881 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179412 RetType; // Return type
};

struct Blob_PropertySig_5881 {
    byte Size; // coded integer - blob size
    struct PropertySig_5881 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_FieldSig_2991 Blob_FieldSig_2991, *PBlob_FieldSig_2991;

typedef struct FieldSig_2991 FieldSig_2991, *PFieldSig_2991;

typedef struct Type_176521 Type_176521, *PType_176521;

struct Type_176521 {
    struct ValueType.conflict1 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_2991 {
    byte FIELD; // Magic (0x06)
    struct Type_176521 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_2991 {
    byte Size; // coded integer - blob size
    struct FieldSig_2991 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_7795 Blob_Generic_7795, *PBlob_Generic_7795;

struct Blob_Generic_7795 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_6465 Blob_Generic_6465, *PBlob_Generic_6465;

struct Blob_Generic_6465 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5134 Blob_Generic_5134, *PBlob_Generic_5134;

struct Blob_Generic_5134 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_10151 Blob_Generic_10151, *PBlob_Generic_10151;

struct Blob_Generic_10151 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_46103 Blob_Generic_46103, *PBlob_Generic_46103;

struct Blob_Generic_46103 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_PropertySig_12018 Blob_PropertySig_12018, *PBlob_PropertySig_12018;

typedef struct PropertySig_12018 PropertySig_12018, *PPropertySig_12018;

typedef struct Type_185549 Type_185549, *PType_185549;

struct Type_185549 {
    struct GenericInstType_185550 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_12018 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_185549 RetType; // Return type
};

struct Blob_PropertySig_12018 {
    byte Size; // coded integer - blob size
    struct PropertySig_12018 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_10157 Blob_Generic_10157, *PBlob_Generic_10157;

struct Blob_Generic_10157 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_14518 Blob_Generic_14518, *PBlob_Generic_14518;

struct Blob_Generic_14518 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_43075 Blob_Generic_43075, *PBlob_Generic_43075;

struct Blob_Generic_43075 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_2986 Blob_FieldSig_2986, *PBlob_FieldSig_2986;

typedef struct FieldSig_2986 FieldSig_2986, *PFieldSig_2986;

typedef struct Type_176516 Type_176516, *PType_176516;

struct Type_176516 {
    struct ValueType.conflict ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_2986 {
    byte FIELD; // Magic (0x06)
    struct Type_176516 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_2986 {
    byte Size; // coded integer - blob size
    struct FieldSig_2986 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_36778 Blob_Generic_36778, *PBlob_Generic_36778;

struct Blob_Generic_36778 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_24795 Blob_Generic_24795, *PBlob_Generic_24795;

struct Blob_Generic_24795 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34110 Blob_Generic_34110, *PBlob_Generic_34110;

struct Blob_Generic_34110 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_31082 Blob_Generic_31082, *PBlob_Generic_31082;

struct Blob_Generic_31082 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_40803 Blob_Generic_40803, *PBlob_Generic_40803;

struct Blob_Generic_40803 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5141 Blob_Generic_5141, *PBlob_Generic_5141;

struct Blob_Generic_5141 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_5145 Blob_Generic_5145, *PBlob_Generic_5145;

struct Blob_Generic_5145 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11494 Blob_Generic_11494, *PBlob_Generic_11494;

struct Blob_Generic_11494 {
    byte Size; // coded integer - blob size
    byte Generic[18]; // Undefined blob contents
};

typedef struct Blob_Generic_48757 Blob_Generic_48757, *PBlob_Generic_48757;

struct Blob_Generic_48757 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6472 Blob_Generic_6472, *PBlob_Generic_6472;

struct Blob_Generic_6472 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9507 Blob_Generic_9507, *PBlob_Generic_9507;

struct Blob_Generic_9507 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_39800 Blob_Generic_39800, *PBlob_Generic_39800;

struct Blob_Generic_39800 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_10167 Blob_Generic_10167, *PBlob_Generic_10167;

struct Blob_Generic_10167 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_15853 Blob_Generic_15853, *PBlob_Generic_15853;

struct Blob_Generic_15853 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_47422 Blob_Generic_47422, *PBlob_Generic_47422;

struct Blob_Generic_47422 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6478 Blob_Generic_6478, *PBlob_Generic_6478;

struct Blob_Generic_6478 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_35457 Blob_Generic_35457, *PBlob_Generic_35457;

struct Blob_Generic_35457 {
    byte Size; // coded integer - blob size
    byte Generic[55]; // Undefined blob contents
};

typedef struct Blob_Generic_39077 Blob_Generic_39077, *PBlob_Generic_39077;

struct Blob_Generic_39077 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_24816 Blob_Generic_24816, *PBlob_Generic_24816;

struct Blob_Generic_24816 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_40065 Blob_Generic_40065, *PBlob_Generic_40065;

struct Blob_Generic_40065 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_44420 Blob_Generic_44420, *PBlob_Generic_44420;

struct Blob_Generic_44420 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_422 Blob_Generic_422, *PBlob_Generic_422;

struct Blob_Generic_422 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_4623 Blob_Generic_4623, *PBlob_Generic_4623;

struct Blob_Generic_4623 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_12837 Blob_Generic_12837, *PBlob_Generic_12837;

struct Blob_Generic_12837 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_5957 Blob_Generic_5957, *PBlob_Generic_5957;

struct Blob_Generic_5957 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2723 Blob_PropertySig_2723, *PBlob_PropertySig_2723;

typedef struct PropertySig_2723 PropertySig_2723, *PPropertySig_2723;

typedef struct Type_176254 Type_176254, *PType_176254;

struct Type_176254 {
    struct GenericInstType_176255 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2723 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176254 RetType; // Return type
};

struct Blob_PropertySig_2723 {
    byte Size; // coded integer - blob size
    struct PropertySig_2723 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_18141 Blob_Generic_18141, *PBlob_Generic_18141;

struct Blob_Generic_18141 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10841 Blob_PropertySig_10841, *PBlob_PropertySig_10841;

typedef struct PropertySig_10841 PropertySig_10841, *PPropertySig_10841;

typedef struct Type_184372 Type_184372, *PType_184372;

struct Type_184372 {
    struct GenericInstType_184373 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_10841 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184372 RetType; // Return type
};

struct Blob_PropertySig_10841 {
    byte Size; // coded integer - blob size
    struct PropertySig_10841 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_14 Blob_Generic_14, *PBlob_Generic_14;

struct Blob_Generic_14 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_412 Blob_Generic_412, *PBlob_Generic_412;

struct Blob_Generic_412 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_20460 Blob_Generic_20460, *PBlob_Generic_20460;

struct Blob_Generic_20460 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_10 Blob_Generic_10, *PBlob_Generic_10;

struct Blob_Generic_10 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_3305 Blob_Generic_3305, *PBlob_Generic_3305;

struct Blob_Generic_3305 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11513 Blob_Generic_11513, *PBlob_Generic_11513;

struct Blob_Generic_11513 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5963 Blob_Generic_5963, *PBlob_Generic_5963;

struct Blob_Generic_5963 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4638 Blob_Generic_4638, *PBlob_Generic_4638;

struct Blob_Generic_4638 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11519 Blob_Generic_11519, *PBlob_Generic_11519;

struct Blob_Generic_11519 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_18 Blob_Generic_18, *PBlob_Generic_18;

struct Blob_Generic_18 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_5969 Blob_Generic_5969, *PBlob_Generic_5969;

struct Blob_Generic_5969 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2733 Blob_PropertySig_2733, *PBlob_PropertySig_2733;

typedef struct PropertySig_2733 PropertySig_2733, *PPropertySig_2733;

typedef struct Type_176264 Type_176264, *PType_176264;

struct Type_176264 {
    struct GenericInstType_176265 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2733 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176264 RetType; // Return type
};

struct Blob_PropertySig_2733 {
    byte Size; // coded integer - blob size
    struct PropertySig_2733 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_19483 Blob_Generic_19483, *PBlob_Generic_19483;

struct Blob_Generic_19483 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_40044 Blob_Generic_40044, *PBlob_Generic_40044;

struct Blob_Generic_40044 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_39056 Blob_Generic_39056, *PBlob_Generic_39056;

struct Blob_Generic_39056 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5975 Blob_Generic_5975, *PBlob_Generic_5975;

struct Blob_Generic_5975 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_400 Blob_Generic_400, *PBlob_Generic_400;

struct Blob_Generic_400 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_4646 Blob_Generic_4646, *PBlob_Generic_4646;

struct Blob_Generic_4646 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3313 Blob_Generic_3313, *PBlob_Generic_3313;

struct Blob_Generic_3313 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12812 Blob_Generic_12812, *PBlob_Generic_12812;

struct Blob_Generic_12812 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2701 Blob_PropertySig_2701, *PBlob_PropertySig_2701;

typedef struct PropertySig_2701 PropertySig_2701, *PPropertySig_2701;

typedef struct Type_176232 Type_176232, *PType_176232;

struct Type_176232 {
    struct GenericInstType_176233 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2701 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176232 RetType; // Return type
};

struct Blob_PropertySig_2701 {
    byte Size; // coded integer - blob size
    struct PropertySig_2701 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_20439 Blob_Generic_20439, *PBlob_Generic_20439;

struct Blob_Generic_20439 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_21777 Blob_Generic_21777, *PBlob_Generic_21777;

struct Blob_Generic_21777 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_5981 Blob_Generic_5981, *PBlob_Generic_5981;

struct Blob_Generic_5981 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_3321 Blob_Generic_3321, *PBlob_Generic_3321;

struct Blob_Generic_3321 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_12820 Blob_Generic_12820, *PBlob_Generic_12820;

struct Blob_Generic_12820 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_33759 Blob_Generic_33759, *PBlob_Generic_33759;

struct Blob_Generic_33759 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4655 Blob_Generic_4655, *PBlob_Generic_4655;

struct Blob_Generic_4655 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_12828 Blob_Generic_12828, *PBlob_Generic_12828;

struct Blob_Generic_12828 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2713 Blob_PropertySig_2713, *PBlob_PropertySig_2713;

typedef struct PropertySig_2713 PropertySig_2713, *PPropertySig_2713;

typedef struct Type_176244 Type_176244, *PType_176244;

struct Type_176244 {
    struct GenericInstType_176245 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2713 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176244 RetType; // Return type
};

struct Blob_PropertySig_2713 {
    byte Size; // coded integer - blob size
    struct PropertySig_2713 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_44468 Blob_Generic_44468, *PBlob_Generic_44468;

struct Blob_Generic_44468 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12871 Blob_Generic_12871, *PBlob_Generic_12871;

struct Blob_Generic_12871 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_466 Blob_Generic_466, *PBlob_Generic_466;

struct Blob_Generic_466 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10211 Blob_Generic_10211, *PBlob_Generic_10211;

struct Blob_Generic_10211 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_3332 Blob_Generic_3332, *PBlob_Generic_3332;

struct Blob_Generic_3332 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4662 Blob_Generic_4662, *PBlob_Generic_4662;

struct Blob_Generic_4662 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_3338 Blob_Generic_3338, *PBlob_Generic_3338;

struct Blob_Generic_3338 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4669 Blob_Generic_4669, *PBlob_Generic_4669;

struct Blob_Generic_4669 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_11545 Blob_Generic_11545, *PBlob_Generic_11545;

struct Blob_Generic_11545 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_12877 Blob_Generic_12877, *PBlob_Generic_12877;

struct Blob_Generic_12877 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_42 Blob_Generic_42, *PBlob_Generic_42;

struct Blob_Generic_42 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8075 Blob_PropertySig_8075, *PBlob_PropertySig_8075;

typedef struct PropertySig_8075 PropertySig_8075, *PPropertySig_8075;

typedef struct Type_181606 Type_181606, *PType_181606;

struct Type_181606 {
    struct GenericInstType_181607 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_8075 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181606 RetType; // Return type
};

struct Blob_PropertySig_8075 {
    byte Size; // coded integer - blob size
    struct PropertySig_8075 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_32479 Blob_Generic_32479, *PBlob_Generic_32479;

struct Blob_Generic_32479 {
    byte Size; // coded integer - blob size
    byte Generic[73]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8069 Blob_PropertySig_8069, *PBlob_PropertySig_8069;

typedef struct PropertySig_8069 PropertySig_8069, *PPropertySig_8069;

typedef struct Type_181600 Type_181600, *PType_181600;

struct Type_181600 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_8069 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181600 RetType; // Return type
};

struct Blob_PropertySig_8069 {
    byte Size; // coded integer - blob size
    struct PropertySig_8069 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_18183 Blob_Generic_18183, *PBlob_Generic_18183;

struct Blob_Generic_18183 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_51 Blob_Generic_51, *PBlob_Generic_51;

struct Blob_Generic_51 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_32 Blob_PropertySig_32, *PBlob_PropertySig_32;

typedef struct PropertySig_32 PropertySig_32, *PPropertySig_32;

typedef struct Type_173563 Type_173563, *PType_173563;

struct Type_173563 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_32 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173563 RetType; // Return type
};

struct Blob_PropertySig_32 {
    byte Size; // coded integer - blob size
    struct PropertySig_32 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_450 Blob_Generic_450, *PBlob_Generic_450;

struct Blob_Generic_450 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12882 Blob_Generic_12882, *PBlob_Generic_12882;

struct Blob_Generic_12882 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_456 Blob_Generic_456, *PBlob_Generic_456;

struct Blob_Generic_456 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4676 Blob_Generic_4676, *PBlob_Generic_4676;

struct Blob_Generic_4676 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_3344 Blob_Generic_3344, *PBlob_Generic_3344;

struct Blob_Generic_3344 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_59 Blob_Generic_59, *PBlob_Generic_59;

struct Blob_Generic_59 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_10224 Blob_Generic_10224, *PBlob_Generic_10224;

struct Blob_Generic_10224 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12887 Blob_Generic_12887, *PBlob_Generic_12887;

struct Blob_Generic_12887 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_37 Blob_PropertySig_37, *PBlob_PropertySig_37;

typedef struct PropertySig_37 PropertySig_37, *PPropertySig_37;

typedef struct Type_173568 Type_173568, *PType_173568;

struct Type_173568 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_37 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173568 RetType; // Return type
};

struct Blob_PropertySig_37 {
    byte Size; // coded integer - blob size
    struct PropertySig_37 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_8085 Blob_PropertySig_8085, *PBlob_PropertySig_8085;

typedef struct PropertySig_8085 PropertySig_8085, *PPropertySig_8085;

typedef struct Type_181616 Type_181616, *PType_181616;

struct Type_181616 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_8085 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181616 RetType; // Return type
};

struct Blob_PropertySig_8085 {
    byte Size; // coded integer - blob size
    struct PropertySig_8085 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_35513 Blob_Generic_35513, *PBlob_Generic_35513;

struct Blob_Generic_35513 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7709 Blob_Generic_7709, *PBlob_Generic_7709;

struct Blob_Generic_7709 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4683 Blob_Generic_4683, *PBlob_Generic_4683;

struct Blob_Generic_4683 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_45774 Blob_Generic_45774, *PBlob_Generic_45774;

struct Blob_Generic_45774 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_3350 Blob_Generic_3350, *PBlob_Generic_3350;

struct Blob_Generic_3350 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3356 Blob_Generic_3356, *PBlob_Generic_3356;

struct Blob_Generic_3356 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2025 Blob_Generic_2025, *PBlob_Generic_2025;

struct Blob_Generic_2025 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_27 Blob_Generic_27, *PBlob_Generic_27;

struct Blob_Generic_27 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_442 Blob_Generic_442, *PBlob_Generic_442;

struct Blob_Generic_442 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12852 Blob_Generic_12852, *PBlob_Generic_12852;

struct Blob_Generic_12852 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_22 Blob_Generic_22, *PBlob_Generic_22;

struct Blob_Generic_22 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_12858 Blob_Generic_12858, *PBlob_Generic_12858;

struct Blob_Generic_12858 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_11529 Blob_Generic_11529, *PBlob_Generic_11529;

struct Blob_Generic_11529 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_32458 Blob_Generic_32458, *PBlob_Generic_32458;

struct Blob_Generic_32458 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7719 Blob_Generic_7719, *PBlob_Generic_7719;

struct Blob_Generic_7719 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_33780 Blob_Generic_33780, *PBlob_Generic_33780;

struct Blob_Generic_33780 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2743 Blob_PropertySig_2743, *PBlob_PropertySig_2743;

typedef struct PropertySig_2743 PropertySig_2743, *PPropertySig_2743;

typedef struct Type_176274 Type_176274, *PType_176274;

struct Type_176274 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_2743 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176274 RetType; // Return type
};

struct Blob_PropertySig_2743 {
    byte Size; // coded integer - blob size
    struct PropertySig_2743 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_18162 Blob_Generic_18162, *PBlob_Generic_18162;

struct Blob_Generic_18162 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4690 Blob_Generic_4690, *PBlob_Generic_4690;

struct Blob_Generic_4690 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2032 Blob_Generic_2032, *PBlob_Generic_2032;

struct Blob_Generic_2032 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3362 Blob_Generic_3362, *PBlob_Generic_3362;

struct Blob_Generic_3362 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_434 Blob_Generic_434, *PBlob_Generic_434;

struct Blob_Generic_434 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4698 Blob_Generic_4698, *PBlob_Generic_4698;

struct Blob_Generic_4698 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7725 Blob_Generic_7725, *PBlob_Generic_7725;

struct Blob_Generic_7725 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10201 Blob_Generic_10201, *PBlob_Generic_10201;

struct Blob_Generic_10201 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_37 Blob_Generic_37, *PBlob_Generic_37;

struct Blob_Generic_37 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_32 Blob_Generic_32, *PBlob_Generic_32;

struct Blob_Generic_32 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_12865 Blob_Generic_12865, *PBlob_Generic_12865;

struct Blob_Generic_12865 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_2037 Blob_Generic_2037, *PBlob_Generic_2037;

struct Blob_Generic_2037 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_59 Blob_PropertySig_59, *PBlob_PropertySig_59;

typedef struct PropertySig_59 PropertySig_59, *PPropertySig_59;

typedef struct Type_173590 Type_173590, *PType_173590;

struct Type_173590 {
    enum TypeCode ELEMENT_TYPE_STRING;
};

struct PropertySig_59 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_173590 RetType; // Return type
};

struct Blob_PropertySig_59 {
    byte Size; // coded integer - blob size
    struct PropertySig_59 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_3368 Blob_Generic_3368, *PBlob_Generic_3368;

struct Blob_Generic_3368 {
    byte Size; // coded integer - blob size
    byte Generic[26]; // Undefined blob contents
};

typedef struct Blob_Generic_11539 Blob_Generic_11539, *PBlob_Generic_11539;

struct Blob_Generic_11539 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_31137 Blob_Generic_31137, *PBlob_Generic_31137;

struct Blob_Generic_31137 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_PropertySig_689 Blob_PropertySig_689, *PBlob_PropertySig_689;

typedef struct PropertySig_689 PropertySig_689, *PPropertySig_689;

typedef struct Type_174220 Type_174220, *PType_174220;

struct Type_174220 {
    enum TypeCode ELEMENT_TYPE_BOOLEAN;
};

struct PropertySig_689 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174220 RetType; // Return type
};

struct Blob_PropertySig_689 {
    byte Size; // coded integer - blob size
    struct PropertySig_689 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_52053 Blob_Generic_52053, *PBlob_Generic_52053;

struct Blob_Generic_52053 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_39098 Blob_Generic_39098, *PBlob_Generic_39098;

struct Blob_Generic_39098 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17683 Blob_Generic_17683, *PBlob_Generic_17683;

struct Blob_Generic_17683 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8141 Blob_Generic_8141, *PBlob_Generic_8141;

struct Blob_Generic_8141 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_16357 Blob_Generic_16357, *PBlob_Generic_16357;

struct Blob_Generic_16357 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1511 Blob_Generic_1511, *PBlob_Generic_1511;

struct Blob_Generic_1511 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_2848 Blob_Generic_2848, *PBlob_Generic_2848;

struct Blob_Generic_2848 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_42649 Blob_Generic_42649, *PBlob_Generic_42649;

struct Blob_Generic_42649 {
    byte Size; // coded integer - blob size
    byte Generic[29]; // Undefined blob contents
};

typedef struct Blob_PropertySig_12628 Blob_PropertySig_12628, *PBlob_PropertySig_12628;

typedef struct PropertySig_12628 PropertySig_12628, *PPropertySig_12628;

typedef struct Type_186159 Type_186159, *PType_186159;

struct Type_186159 {
    struct GenericInstType_186160 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_12628 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_186159 RetType; // Return type
};

struct Blob_PropertySig_12628 {
    byte Size; // coded integer - blob size
    struct PropertySig_12628 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8153 Blob_Generic_8153, *PBlob_Generic_8153;

struct Blob_Generic_8153 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_1521 Blob_Generic_1521, *PBlob_Generic_1521;

struct Blob_Generic_1521 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_1527 Blob_Generic_1527, *PBlob_Generic_1527;

struct Blob_Generic_1527 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_2856 Blob_Generic_2856, *PBlob_Generic_2856;

struct Blob_Generic_2856 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_29677 Blob_Generic_29677, *PBlob_Generic_29677;

struct Blob_Generic_29677 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41305 Blob_Generic_41305, *PBlob_Generic_41305;

struct Blob_Generic_41305 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8161 Blob_Generic_8161, *PBlob_Generic_8161;

struct Blob_Generic_8161 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_9499 Blob_Generic_9499, *PBlob_Generic_9499;

struct Blob_Generic_9499 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_17662 Blob_Generic_17662, *PBlob_Generic_17662;

struct Blob_Generic_17662 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8169 Blob_Generic_8169, *PBlob_Generic_8169;

struct Blob_Generic_8169 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_16336 Blob_Generic_16336, *PBlob_Generic_16336;

struct Blob_Generic_16336 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2864 Blob_Generic_2864, *PBlob_Generic_2864;

struct Blob_Generic_2864 {
    byte Size; // coded integer - blob size
    byte Generic[21]; // Undefined blob contents
};

typedef struct Blob_Generic_1537 Blob_Generic_1537, *PBlob_Generic_1537;

struct Blob_Generic_1537 {
    byte Size; // coded integer - blob size
    byte Generic[24]; // Undefined blob contents
};

typedef struct Blob_Generic_31961 Blob_Generic_31961, *PBlob_Generic_31961;

struct Blob_Generic_31961 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_Generic_49260 Blob_Generic_49260, *PBlob_Generic_49260;

struct Blob_Generic_49260 {
    byte Size; // coded integer - blob size
    byte Generic[67]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6221 Blob_PropertySig_6221, *PBlob_PropertySig_6221;

typedef struct PropertySig_6221 PropertySig_6221, *PPropertySig_6221;

typedef struct Type_179752 Type_179752, *PType_179752;

struct Type_179752 {
    struct ValueType.conflict22 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_6221 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179752 RetType; // Return type
};

struct Blob_PropertySig_6221 {
    byte Size; // coded integer - blob size
    struct PropertySig_6221 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_37268 Blob_Generic_37268, *PBlob_Generic_37268;

struct Blob_Generic_37268 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_Generic_42628 Blob_Generic_42628, *PBlob_Generic_42628;

struct Blob_Generic_42628 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8179 Blob_Generic_8179, *PBlob_Generic_8179;

struct Blob_Generic_8179 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_15015 Blob_Generic_15015, *PBlob_Generic_15015;

struct Blob_Generic_15015 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_51568 Blob_Generic_51568, *PBlob_Generic_51568;

struct Blob_Generic_51568 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_5901 Blob_Generic_5901, *PBlob_Generic_5901;

struct Blob_Generic_5901 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_25295 Blob_Generic_25295, *PBlob_Generic_25295;

struct Blob_Generic_25295 {
    byte Size; // coded integer - blob size
    byte Generic[37]; // Undefined blob contents
};

typedef struct Blob_Generic_29656 Blob_Generic_29656, *PBlob_Generic_29656;

struct Blob_Generic_29656 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_50234 Blob_Generic_50234, *PBlob_Generic_50234;

struct Blob_Generic_50234 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_52897 Blob_Generic_52897, *PBlob_Generic_52897;

struct Blob_Generic_52897 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_30640 Blob_Generic_30640, *PBlob_Generic_30640;

struct Blob_Generic_30640 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_8189 Blob_Generic_8189, *PBlob_Generic_8189;

struct Blob_Generic_8189 {
    byte Size; // coded integer - blob size
    byte Generic[19]; // Undefined blob contents
};

typedef struct Blob_Generic_39035 Blob_Generic_39035, *PBlob_Generic_39035;

struct Blob_Generic_39035 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_4272 Blob_FieldSig_4272, *PBlob_FieldSig_4272;

typedef struct FieldSig_4272 FieldSig_4272, *PFieldSig_4272;

typedef struct Type_177802 Type_177802, *PType_177802;

struct Type_177802 {
    struct ValueType.conflict9 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_4272 {
    byte FIELD; // Magic (0x06)
    struct Type_177802 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_4272 {
    byte Size; // coded integer - blob size
    struct FieldSig_4272 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_2886 Blob_Generic_2886, *PBlob_Generic_2886;

struct Blob_Generic_2886 {
    byte Size; // coded integer - blob size
    byte Generic[21]; // Undefined blob contents
};

typedef struct Blob_Generic_5919 Blob_Generic_5919, *PBlob_Generic_5919;

struct Blob_Generic_5919 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5913 Blob_Generic_5913, *PBlob_Generic_5913;

struct Blob_Generic_5913 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_FieldSig_4267 Blob_FieldSig_4267, *PBlob_FieldSig_4267;

typedef struct FieldSig_4267 FieldSig_4267, *PFieldSig_4267;

typedef struct Type_177797 Type_177797, *PType_177797;

struct Type_177797 {
    struct ValueType.conflict8 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_4267 {
    byte FIELD; // Magic (0x06)
    struct Type_177797 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_4267 {
    byte Size; // coded integer - blob size
    struct FieldSig_4267 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_20418 Blob_Generic_20418, *PBlob_Generic_20418;

struct Blob_Generic_20418 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_21756 Blob_Generic_21756, *PBlob_Generic_21756;

struct Blob_Generic_21756 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19437 Blob_Generic_19437, *PBlob_Generic_19437;

struct Blob_Generic_19437 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_15076 Blob_Generic_15076, *PBlob_Generic_15076;

struct Blob_Generic_15076 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_41347 Blob_Generic_41347, *PBlob_Generic_41347;

struct Blob_Generic_41347 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_40013 Blob_Generic_40013, *PBlob_Generic_40013;

struct Blob_Generic_40013 {
    byte Size; // coded integer - blob size
    byte Generic[30]; // Undefined blob contents
};

typedef struct Blob_Generic_1562 Blob_Generic_1562, *PBlob_Generic_1562;

struct Blob_Generic_1562 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9333 Blob_PropertySig_9333, *PBlob_PropertySig_9333;

typedef struct PropertySig_9333 PropertySig_9333, *PPropertySig_9333;

typedef struct Type_182864 Type_182864, *PType_182864;

struct Type_182864 {
    struct ValueType.conflict32 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_9333 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182864 RetType; // Return type
};

struct Blob_PropertySig_9333 {
    byte Size; // coded integer - blob size
    struct PropertySig_9333 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_12801 Blob_Generic_12801, *PBlob_Generic_12801;

struct Blob_Generic_12801 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_33738 Blob_Generic_33738, *PBlob_Generic_33738;

struct Blob_Generic_33738 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_27055 Blob_Generic_27055, *PBlob_Generic_27055;

struct Blob_Generic_27055 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_PropertySig_9327 Blob_PropertySig_9327, *PBlob_PropertySig_9327;

typedef struct PropertySig_9327 PropertySig_9327, *PPropertySig_9327;

typedef struct Type_182858 Type_182858, *PType_182858;

struct Type_182858 {
    struct ValueType.conflict33 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_9327 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182858 RetType; // Return type
};

struct Blob_PropertySig_9327 {
    byte Size; // coded integer - blob size
    struct PropertySig_9327 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_5925 Blob_Generic_5925, *PBlob_Generic_5925;

struct Blob_Generic_5925 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_42679 Blob_Generic_42679, *PBlob_Generic_42679;

struct Blob_Generic_42679 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_45705 Blob_Generic_45705, *PBlob_Generic_45705;

struct Blob_Generic_45705 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_Generic_39014 Blob_Generic_39014, *PBlob_Generic_39014;

struct Blob_Generic_39014 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1570 Blob_Generic_1570, *PBlob_Generic_1570;

struct Blob_Generic_1570 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_16378 Blob_Generic_16378, *PBlob_Generic_16378;

struct Blob_Generic_16378 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_5931 Blob_Generic_5931, *PBlob_Generic_5931;

struct Blob_Generic_5931 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_1578 Blob_Generic_1578, *PBlob_Generic_1578;

struct Blob_Generic_1578 {
    byte Size; // coded integer - blob size
    byte Generic[22]; // Undefined blob contents
};

typedef struct Blob_Generic_4607 Blob_Generic_4607, *PBlob_Generic_4607;

struct Blob_Generic_4607 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_28354 Blob_Generic_28354, *PBlob_Generic_28354;

struct Blob_Generic_28354 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_Generic_5937 Blob_Generic_5937, *PBlob_Generic_5937;

struct Blob_Generic_5937 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_50280 Blob_Generic_50280, *PBlob_Generic_50280;

struct Blob_Generic_50280 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_15055 Blob_Generic_15055, *PBlob_Generic_15055;

struct Blob_Generic_15055 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19416 Blob_Generic_19416, *PBlob_Generic_19416;

struct Blob_Generic_19416 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_43980 Blob_Generic_43980, *PBlob_Generic_43980;

struct Blob_Generic_43980 {
    byte Size; // coded integer - blob size
    byte Generic[58]; // Undefined blob contents
};

typedef struct Blob_Generic_33717 Blob_Generic_33717, *PBlob_Generic_33717;

struct Blob_Generic_33717 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4615 Blob_Generic_4615, *PBlob_Generic_4615;

struct Blob_Generic_4615 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_27034 Blob_Generic_27034, *PBlob_Generic_27034;

struct Blob_Generic_27034 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_30688 Blob_Generic_30688, *PBlob_Generic_30688;

struct Blob_Generic_30688 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5947 Blob_Generic_5947, *PBlob_Generic_5947;

struct Blob_Generic_5947 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_29698 Blob_Generic_29698, *PBlob_Generic_29698;

struct Blob_Generic_29698 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41326 Blob_Generic_41326, *PBlob_Generic_41326;

struct Blob_Generic_41326 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_21735 Blob_Generic_21735, *PBlob_Generic_21735;

struct Blob_Generic_21735 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_39992 Blob_Generic_39992, *PBlob_Generic_39992;

struct Blob_Generic_39992 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6366 Blob_Generic_6366, *PBlob_Generic_6366;

struct Blob_Generic_6366 {
    byte Size; // coded integer - blob size
    byte Generic[33]; // Undefined blob contents
};

typedef struct Blob_Generic_13364 Blob_Generic_13364, *PBlob_Generic_13364;

struct Blob_Generic_13364 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_Generic_7693 Blob_Generic_7693, *PBlob_Generic_7693;

struct Blob_Generic_7693 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5037 Blob_Generic_5037, *PBlob_Generic_5037;

struct Blob_Generic_5037 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_7699 Blob_Generic_7699, *PBlob_Generic_7699;

struct Blob_Generic_7699 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3130 Blob_PropertySig_3130, *PBlob_PropertySig_3130;

typedef struct PropertySig_3130 PropertySig_3130, *PPropertySig_3130;

typedef struct Type_176661 Type_176661, *PType_176661;

struct Type_176661 {
    struct ValueType.conflict2 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_3130 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176661 RetType; // Return type
};

struct Blob_PropertySig_3130 {
    byte Size; // coded integer - blob size
    struct PropertySig_3130 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_51630 Blob_Generic_51630, *PBlob_Generic_51630;

struct Blob_Generic_51630 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_12042 Blob_Generic_12042, *PBlob_Generic_12042;

struct Blob_Generic_12042 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_30709 Blob_Generic_30709, *PBlob_Generic_30709;

struct Blob_Generic_30709 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_40971 Blob_Generic_40971, *PBlob_Generic_40971;

struct Blob_Generic_40971 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9407 Blob_Generic_9407, *PBlob_Generic_9407;

struct Blob_Generic_9407 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_52955 Blob_Generic_52955, *PBlob_Generic_52955;

struct Blob_Generic_52955 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8834 Blob_PropertySig_8834, *PBlob_PropertySig_8834;

typedef struct PropertySig_8834 PropertySig_8834, *PPropertySig_8834;

typedef struct Type_182365 Type_182365, *PType_182365;

struct Type_182365 {
    struct GenericInstType_182366 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_8834 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182365 RetType; // Return type
};

struct Blob_PropertySig_8834 {
    byte Size; // coded integer - blob size
    struct PropertySig_8834 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_25354 Blob_Generic_25354, *PBlob_Generic_25354;

struct Blob_Generic_25354 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_29719 Blob_Generic_29719, *PBlob_Generic_29719;

struct Blob_Generic_29719 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_Generic_37331 Blob_Generic_37331, *PBlob_Generic_37331;

struct Blob_Generic_37331 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5051 Blob_Generic_5051, *PBlob_Generic_5051;

struct Blob_Generic_5051 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_39971 Blob_Generic_39971, *PBlob_Generic_39971;

struct Blob_Generic_39971 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_13343 Blob_Generic_13343, *PBlob_Generic_13343;

struct Blob_Generic_13343 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17704 Blob_Generic_17704, *PBlob_Generic_17704;

struct Blob_Generic_17704 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_9418 Blob_Generic_9418, *PBlob_Generic_9418;

struct Blob_Generic_9418 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_46266 Blob_Generic_46266, *PBlob_Generic_46266;

struct Blob_Generic_46266 {
    byte Size; // coded integer - blob size
    byte Generic[55]; // Undefined blob contents
};

typedef struct Blob_Generic_12018 Blob_Generic_12018, *PBlob_Generic_12018;

struct Blob_Generic_12018 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_22292 Blob_Generic_22292, *PBlob_Generic_22292;

struct Blob_Generic_22292 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4442 Blob_PropertySig_4442, *PBlob_PropertySig_4442;

typedef struct PropertySig_4442 PropertySig_4442, *PPropertySig_4442;

typedef struct Type_177973 Type_177973, *PType_177973;

struct Type_177973 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_4442 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177973 RetType; // Return type
};

struct Blob_PropertySig_4442 {
    byte Size; // coded integer - blob size
    struct PropertySig_4442 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_34273 Blob_Generic_34273, *PBlob_Generic_34273;

struct Blob_Generic_34273 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5779 Blob_PropertySig_5779, *PBlob_PropertySig_5779;

typedef struct PropertySig_5779 PropertySig_5779, *PPropertySig_5779;

typedef struct Type_179310 Type_179310, *PType_179310;

struct Type_179310 {
    struct GenericInstType_179311 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_5779 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179310 RetType; // Return type
};

struct Blob_PropertySig_5779 {
    byte Size; // coded integer - blob size
    struct PropertySig_5779 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_5063 Blob_Generic_5063, *PBlob_Generic_5063;

struct Blob_Generic_5063 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_40950 Blob_Generic_40950, *PBlob_Generic_40950;

struct Blob_Generic_40950 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_12568 Blob_PropertySig_12568, *PBlob_PropertySig_12568;

typedef struct PropertySig_12568 PropertySig_12568, *PPropertySig_12568;

typedef struct Type_186099 Type_186099, *PType_186099;

struct Type_186099 {
    struct GenericInstType_186100 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_12568 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_186099 RetType; // Return type
};

struct Blob_PropertySig_12568 {
    byte Size; // coded integer - blob size
    struct PropertySig_12568 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_12028 Blob_Generic_12028, *PBlob_Generic_12028;

struct Blob_Generic_12028 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_47581 Blob_Generic_47581, *PBlob_Generic_47581;

struct Blob_Generic_47581 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_9425 Blob_Generic_9425, *PBlob_Generic_9425;

struct Blob_Generic_9425 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_25333 Blob_Generic_25333, *PBlob_Generic_25333;

struct Blob_Generic_25333 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5789 Blob_PropertySig_5789, *PBlob_PropertySig_5789;

typedef struct PropertySig_5789 PropertySig_5789, *PPropertySig_5789;

typedef struct Type_179320 Type_179320, *PType_179320;

struct Type_179320 {
    struct ValueType.conflict18 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_5789 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179320 RetType; // Return type
};

struct Blob_PropertySig_5789 {
    byte Size; // coded integer - blob size
    struct PropertySig_5789 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_9432 Blob_Generic_9432, *PBlob_Generic_9432;

struct Blob_Generic_9432 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5072 Blob_Generic_5072, *PBlob_Generic_5072;

struct Blob_Generic_5072 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_8103 Blob_Generic_8103, *PBlob_Generic_8103;

struct Blob_Generic_8103 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_12077 Blob_Generic_12077, *PBlob_Generic_12077;

struct Blob_Generic_12077 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_42721 Blob_Generic_42721, *PBlob_Generic_42721;

struct Blob_Generic_42721 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3180 Blob_PropertySig_3180, *PBlob_PropertySig_3180;

typedef struct PropertySig_3180 PropertySig_3180, *PPropertySig_3180;

typedef struct Type_176711 Type_176711, *PType_176711;

struct Type_176711 {
    struct GenericInstType_176712 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_3180 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176711 RetType; // Return type
};

struct Blob_PropertySig_3180 {
    byte Size; // coded integer - blob size
    struct PropertySig_3180 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_48023 Blob_Generic_48023, *PBlob_Generic_48023;

struct Blob_Generic_48023 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9438 Blob_Generic_9438, *PBlob_Generic_9438;

struct Blob_Generic_9438 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_24061 Blob_Generic_24061, *PBlob_Generic_24061;

struct Blob_Generic_24061 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_2803 Blob_Generic_2803, *PBlob_Generic_2803;

struct Blob_Generic_2803 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_28417 Blob_Generic_28417, *PBlob_Generic_28417;

struct Blob_Generic_28417 {
    byte Size; // coded integer - blob size
    byte Generic[36]; // Undefined blob contents
};

typedef struct Blob_Generic_5081 Blob_Generic_5081, *PBlob_Generic_5081;

struct Blob_Generic_5081 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_9444 Blob_Generic_9444, *PBlob_Generic_9444;

struct Blob_Generic_9444 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12083 Blob_Generic_12083, *PBlob_Generic_12083;

struct Blob_Generic_12083 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_8115 Blob_Generic_8115, *PBlob_Generic_8115;

struct Blob_Generic_8115 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5088 Blob_Generic_5088, *PBlob_Generic_5088;

struct Blob_Generic_5088 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_12089 Blob_Generic_12089, *PBlob_Generic_12089;

struct Blob_Generic_12089 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_38699 Blob_Generic_38699, *PBlob_Generic_38699;

struct Blob_Generic_38699 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_50335 Blob_Generic_50335, *PBlob_Generic_50335;

struct Blob_Generic_50335 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2812 Blob_Generic_2812, *PBlob_Generic_2812;

struct Blob_Generic_2812 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_FieldSig_6830 Blob_FieldSig_6830, *PBlob_FieldSig_6830;

typedef struct FieldSig_6830 FieldSig_6830, *PFieldSig_6830;

typedef struct Type_180360 Type_180360, *PType_180360;

struct Type_180360 {
    struct ValueType.conflict25 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6830 {
    byte FIELD; // Magic (0x06)
    struct Type_180360 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6830 {
    byte Size; // coded integer - blob size
    struct FieldSig_6830 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_5097 Blob_Generic_5097, *PBlob_Generic_5097;

struct Blob_Generic_5097 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_8123 Blob_Generic_8123, *PBlob_Generic_8123;

struct Blob_Generic_8123 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12050 Blob_Generic_12050, *PBlob_Generic_12050;

struct Blob_Generic_12050 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_9456 Blob_Generic_9456, *PBlob_Generic_9456;

struct Blob_Generic_9456 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_42700 Blob_Generic_42700, *PBlob_Generic_42700;

struct Blob_Generic_42700 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9450 Blob_Generic_9450, *PBlob_Generic_9450;

struct Blob_Generic_9450 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11205 Blob_PropertySig_11205, *PBlob_PropertySig_11205;

typedef struct PropertySig_11205 PropertySig_11205, *PPropertySig_11205;

typedef struct Type_184736 Type_184736, *PType_184736;

struct Type_184736 {
    struct GenericInstType_184737 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11205 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184736 RetType; // Return type
};

struct Blob_PropertySig_11205 {
    byte Size; // coded integer - blob size
    struct PropertySig_11205 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_12058 Blob_Generic_12058, *PBlob_Generic_12058;

struct Blob_Generic_12058 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_2820 Blob_Generic_2820, *PBlob_Generic_2820;

struct Blob_Generic_2820 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_26692 Blob_Generic_26692, *PBlob_Generic_26692;

struct Blob_Generic_26692 {
    byte Size; // coded integer - blob size
    byte Generic[65]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8844 Blob_PropertySig_8844, *PBlob_PropertySig_8844;

typedef struct PropertySig_8844 PropertySig_8844, *PPropertySig_8844;

typedef struct Type_182375 Type_182375, *PType_182375;

struct Type_182375 {
    struct GenericInstType_182376 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_8844 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182375 RetType; // Return type
};

struct Blob_PropertySig_8844 {
    byte Size; // coded integer - blob size
    struct PropertySig_8844 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_FieldSig_1136 Blob_FieldSig_1136, *PBlob_FieldSig_1136;

typedef struct FieldSig_1136 FieldSig_1136, *PFieldSig_1136;

typedef struct Type_174666 Type_174666, *PType_174666;

struct Type_174666 {
    struct ValueType ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_1136 {
    byte FIELD; // Magic (0x06)
    struct Type_174666 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_1136 {
    byte Size; // coded integer - blob size
    struct FieldSig_1136 FieldSig; // Type information for Field
};

typedef struct Blob_FieldSig_6825 Blob_FieldSig_6825, *PBlob_FieldSig_6825;

typedef struct FieldSig_6825 FieldSig_6825, *PFieldSig_6825;

typedef struct Type_180355 Type_180355, *PType_180355;

struct Type_180355 {
    struct ValueType.conflict24 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6825 {
    byte FIELD; // Magic (0x06)
    struct Type_180355 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6825 {
    byte Size; // coded integer - blob size
    struct FieldSig_6825 FieldSig; // Type information for Field
};

typedef struct Blob_PropertySig_7515 Blob_PropertySig_7515, *PBlob_PropertySig_7515;

typedef struct PropertySig_7515 PropertySig_7515, *PPropertySig_7515;

typedef struct Type_181046 Type_181046, *PType_181046;

struct Type_181046 {
    struct GenericInstType_181047 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_7515 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_181046 RetType; // Return type
};

struct Blob_PropertySig_7515 {
    byte Size; // coded integer - blob size
    struct PropertySig_7515 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_36019 Blob_Generic_36019, *PBlob_Generic_36019;

struct Blob_Generic_36019 {
    byte Size; // coded integer - blob size
    byte Generic[37]; // Undefined blob contents
};

typedef struct Blob_Generic_2829 Blob_Generic_2829, *PBlob_Generic_2829;

struct Blob_Generic_2829 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_FieldSig_6820 Blob_FieldSig_6820, *PBlob_FieldSig_6820;

typedef struct FieldSig_6820 FieldSig_6820, *PFieldSig_6820;

typedef struct Type_180350 Type_180350, *PType_180350;

struct Type_180350 {
    struct ValueType.conflict23 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6820 {
    byte FIELD; // Magic (0x06)
    struct Type_180350 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6820 {
    byte Size; // coded integer - blob size
    struct FieldSig_6820 FieldSig; // Type information for Field
};

typedef struct Blob_FieldSig_1133 Blob_FieldSig_1133, *PBlob_FieldSig_1133;

typedef struct FieldSig_1133 FieldSig_1133, *PFieldSig_1133;

typedef struct Type_174663 Type_174663, *PType_174663;

struct Type_174663 {
    enum TypeCode ELEMENT_TYPE_I4;
};

struct FieldSig_1133 {
    byte FIELD; // Magic (0x06)
    struct Type_174663 ELEMENT_TYPE_I4;
};

struct Blob_FieldSig_1133 {
    byte Size; // coded integer - blob size
    struct FieldSig_1133 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_9468 Blob_Generic_9468, *PBlob_Generic_9468;

struct Blob_Generic_9468 {
    byte Size; // coded integer - blob size
    byte Generic[30]; // Undefined blob contents
};

typedef struct Blob_Generic_8131 Blob_Generic_8131, *PBlob_Generic_8131;

struct Blob_Generic_8131 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_9462 Blob_Generic_9462, *PBlob_Generic_9462;

struct Blob_Generic_9462 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_49328 Blob_Generic_49328, *PBlob_Generic_49328;

struct Blob_Generic_49328 {
    byte Size; // coded integer - blob size
    byte Generic[67]; // Undefined blob contents
};

typedef struct Blob_Generic_40992 Blob_Generic_40992, *PBlob_Generic_40992;

struct Blob_Generic_40992 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16421 Blob_Generic_16421, *PBlob_Generic_16421;

struct Blob_Generic_16421 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_38678 Blob_Generic_38678, *PBlob_Generic_38678;

struct Blob_Generic_38678 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17757 Blob_Generic_17757, *PBlob_Generic_17757;

struct Blob_Generic_17757 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_1501 Blob_Generic_1501, *PBlob_Generic_1501;

struct Blob_Generic_1501 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_24040 Blob_Generic_24040, *PBlob_Generic_24040;

struct Blob_Generic_24040 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_8854 Blob_PropertySig_8854, *PBlob_PropertySig_8854;

typedef struct PropertySig_8854 PropertySig_8854, *PPropertySig_8854;

typedef struct Type_182385 Type_182385, *PType_182385;

struct Type_182385 {
    struct GenericInstType_182386 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_8854 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_182385 RetType; // Return type
};

struct Blob_PropertySig_8854 {
    byte Size; // coded integer - blob size
    struct PropertySig_8854 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2837 Blob_Generic_2837, *PBlob_Generic_2837;

struct Blob_Generic_2837 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_FieldSig_6815 Blob_FieldSig_6815, *PBlob_FieldSig_6815;

typedef struct FieldSig_6815 FieldSig_6815, *PFieldSig_6815;

typedef struct Type_180345 Type_180345, *PType_180345;

struct Type_180345 {
    struct ValueType.conflict22 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6815 {
    byte FIELD; // Magic (0x06)
    struct Type_180345 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6815 {
    byte Size; // coded integer - blob size
    struct FieldSig_6815 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_37352 Blob_Generic_37352, *PBlob_Generic_37352;

struct Blob_Generic_37352 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_FieldSig_6810 Blob_FieldSig_6810, *PBlob_FieldSig_6810;

typedef struct FieldSig_6810 FieldSig_6810, *PFieldSig_6810;

typedef struct Type_180340 Type_180340, *PType_180340;

struct Type_180340 {
    struct ValueType.conflict21 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6810 {
    byte FIELD; // Magic (0x06)
    struct Type_180340 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6810 {
    byte Size; // coded integer - blob size
    struct FieldSig_6810 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_12070 Blob_Generic_12070, *PBlob_Generic_12070;

struct Blob_Generic_12070 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_4580 Blob_Generic_4580, *PBlob_Generic_4580;

struct Blob_Generic_4580 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_23567 Blob_Generic_23567, *PBlob_Generic_23567;

struct Blob_Generic_23567 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_46203 Blob_Generic_46203, *PBlob_Generic_46203;

struct Blob_Generic_46203 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3252 Blob_Generic_3252, *PBlob_Generic_3252;

struct Blob_Generic_3252 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10251 Blob_Generic_10251, *PBlob_Generic_10251;

struct Blob_Generic_10251 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10257 Blob_Generic_10257, *PBlob_Generic_10257;

struct Blob_Generic_10257 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_15942 Blob_Generic_15942, *PBlob_Generic_15942;

struct Blob_Generic_15942 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2681 Blob_PropertySig_2681, *PBlob_PropertySig_2681;

typedef struct PropertySig_2681 PropertySig_2681, *PPropertySig_2681;

typedef struct Type_176212 Type_176212, *PType_176212;

struct Type_176212 {
    struct GenericInstType_176213 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2681 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176212 RetType; // Return type
};

struct Blob_PropertySig_2681 {
    byte Size; // coded integer - blob size
    struct PropertySig_2681 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_40908 Blob_Generic_40908, *PBlob_Generic_40908;

struct Blob_Generic_40908 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_6800 Blob_FieldSig_6800, *PBlob_FieldSig_6800;

typedef struct FieldSig_6800 FieldSig_6800, *PFieldSig_6800;

typedef struct Type_180330 Type_180330, *PType_180330;

struct Type_180330 {
    struct ValueType.conflict19 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6800 {
    byte FIELD; // Magic (0x06)
    struct Type_180330 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6800 {
    byte Size; // coded integer - blob size
    struct FieldSig_6800 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_24891 Blob_Generic_24891, *PBlob_Generic_24891;

struct Blob_Generic_24891 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7619 Blob_Generic_7619, *PBlob_Generic_7619;

struct Blob_Generic_7619 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_FieldSig_6805 Blob_FieldSig_6805, *PBlob_FieldSig_6805;

typedef struct FieldSig_6805 FieldSig_6805, *PFieldSig_6805;

typedef struct Type_180335 Type_180335, *PType_180335;

struct Type_180335 {
    struct ValueType.conflict20 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6805 {
    byte FIELD; // Magic (0x06)
    struct Type_180335 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6805 {
    byte Size; // coded integer - blob size
    struct FieldSig_6805 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_3260 Blob_Generic_3260, *PBlob_Generic_3260;

struct Blob_Generic_3260 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_4590 Blob_Generic_4590, *PBlob_Generic_4590;

struct Blob_Generic_4590 {
    byte Size; // coded integer - blob size
    byte Generic[16]; // Undefined blob contents
};

typedef struct Blob_Generic_11591 Blob_Generic_11591, *PBlob_Generic_11591;

struct Blob_Generic_11591 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_43166 Blob_Generic_43166, *PBlob_Generic_43166;

struct Blob_Generic_43166 {
    byte Size; // coded integer - blob size
    byte Generic[69]; // Undefined blob contents
};

typedef struct Blob_Generic_10263 Blob_Generic_10263, *PBlob_Generic_10263;

struct Blob_Generic_10263 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7625 Blob_Generic_7625, *PBlob_Generic_7625;

struct Blob_Generic_7625 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_48852 Blob_Generic_48852, *PBlob_Generic_48852;

struct Blob_Generic_48852 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_498 Blob_Generic_498, *PBlob_Generic_498;

struct Blob_Generic_498 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10269 Blob_Generic_10269, *PBlob_Generic_10269;

struct Blob_Generic_10269 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_39908 Blob_Generic_39908, *PBlob_Generic_39908;

struct Blob_Generic_39908 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2691 Blob_PropertySig_2691, *PBlob_PropertySig_2691;

typedef struct PropertySig_2691 PropertySig_2691, *PPropertySig_2691;

typedef struct Type_176222 Type_176222, *PType_176222;

struct Type_176222 {
    struct GenericInstType_176223 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2691 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176222 RetType; // Return type
};

struct Blob_PropertySig_2691 {
    byte Size; // coded integer - blob size
    struct PropertySig_2691 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_35555 Blob_Generic_35555, *PBlob_Generic_35555;

struct Blob_Generic_35555 {
    byte Size; // coded integer - blob size
    byte Generic[69]; // Undefined blob contents
};

typedef struct Blob_Generic_26605 Blob_Generic_26605, *PBlob_Generic_26605;

struct Blob_Generic_26605 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_27935 Blob_Generic_27935, *PBlob_Generic_27935;

struct Blob_Generic_27935 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_31192 Blob_Generic_31192, *PBlob_Generic_31192;

struct Blob_Generic_31192 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_7631 Blob_Generic_7631, *PBlob_Generic_7631;

struct Blob_Generic_7631 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_47512 Blob_Generic_47512, *PBlob_Generic_47512;

struct Blob_Generic_47512 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_11561 Blob_Generic_11561, *PBlob_Generic_11561;

struct Blob_Generic_11561 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_482 Blob_Generic_482, *PBlob_Generic_482;

struct Blob_Generic_482 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_3272 Blob_Generic_3272, *PBlob_Generic_3272;

struct Blob_Generic_3272 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_12892 Blob_Generic_12892, *PBlob_Generic_12892;

struct Blob_Generic_12892 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_44489 Blob_Generic_44489, *PBlob_Generic_44489;

struct Blob_Generic_44489 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8968 Blob_Generic_8968, *PBlob_Generic_8968;

struct Blob_Generic_8968 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10232 Blob_Generic_10232, *PBlob_Generic_10232;

struct Blob_Generic_10232 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_15921 Blob_Generic_15921, *PBlob_Generic_15921;

struct Blob_Generic_15921 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7637 Blob_Generic_7637, *PBlob_Generic_7637;

struct Blob_Generic_7637 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12897 Blob_Generic_12897, *PBlob_Generic_12897;

struct Blob_Generic_12897 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_6308 Blob_Generic_6308, *PBlob_Generic_6308;

struct Blob_Generic_6308 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_11569 Blob_Generic_11569, *PBlob_Generic_11569;

struct Blob_Generic_11569 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_24870 Blob_Generic_24870, *PBlob_Generic_24870;

struct Blob_Generic_24870 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3282 Blob_Generic_3282, *PBlob_Generic_3282;

struct Blob_Generic_3282 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_22229 Blob_Generic_22229, *PBlob_Generic_22229;

struct Blob_Generic_22229 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10240 Blob_Generic_10240, *PBlob_Generic_10240;

struct Blob_Generic_10240 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_476 Blob_Generic_476, *PBlob_Generic_476;

struct Blob_Generic_476 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6318 Blob_Generic_6318, *PBlob_Generic_6318;

struct Blob_Generic_6318 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_11577 Blob_Generic_11577, *PBlob_Generic_11577;

struct Blob_Generic_11577 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_7643 Blob_Generic_7643, *PBlob_Generic_7643;

struct Blob_Generic_7643 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_8974 Blob_Generic_8974, *PBlob_Generic_8974;

struct Blob_Generic_8974 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_35534 Blob_Generic_35534, *PBlob_Generic_35534;

struct Blob_Generic_35534 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34202 Blob_Generic_34202, *PBlob_Generic_34202;

struct Blob_Generic_34202 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_36860 Blob_Generic_36860, *PBlob_Generic_36860;

struct Blob_Generic_36860 {
    byte Size; // coded integer - blob size
    byte Generic[60]; // Undefined blob contents
};

typedef struct Blob_Generic_3292 Blob_Generic_3292, *PBlob_Generic_3292;

struct Blob_Generic_3292 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_39950 Blob_Generic_39950, *PBlob_Generic_39950;

struct Blob_Generic_39950 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_10295 Blob_Generic_10295, *PBlob_Generic_10295;

struct Blob_Generic_10295 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_8980 Blob_Generic_8980, *PBlob_Generic_8980;

struct Blob_Generic_8980 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_6329 Blob_Generic_6329, *PBlob_Generic_6329;

struct Blob_Generic_6329 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_38625 Blob_Generic_38625, *PBlob_Generic_38625;

struct Blob_Generic_38625 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_46245 Blob_Generic_46245, *PBlob_Generic_46245;

struct Blob_Generic_46245 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7655 Blob_Generic_7655, *PBlob_Generic_7655;

struct Blob_Generic_7655 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_34252 Blob_Generic_34252, *PBlob_Generic_34252;

struct Blob_Generic_34252 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_15990 Blob_Generic_15990, *PBlob_Generic_15990;

struct Blob_Generic_15990 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7663 Blob_Generic_7663, *PBlob_Generic_7663;

struct Blob_Generic_7663 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_8991 Blob_Generic_8991, *PBlob_Generic_8991;

struct Blob_Generic_8991 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6338 Blob_Generic_6338, *PBlob_Generic_6338;

struct Blob_Generic_6338 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_14667 Blob_Generic_14667, *PBlob_Generic_14667;

struct Blob_Generic_14667 {
    byte Size; // coded integer - blob size
    byte Generic[36]; // Undefined blob contents
};

typedef struct Blob_Generic_5005 Blob_Generic_5005, *PBlob_Generic_5005;

struct Blob_Generic_5005 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_12003 Blob_Generic_12003, *PBlob_Generic_12003;

struct Blob_Generic_12003 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_12008 Blob_Generic_12008, *PBlob_Generic_12008;

struct Blob_Generic_12008 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_8999 Blob_Generic_8999, *PBlob_Generic_8999;

struct Blob_Generic_8999 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_47560 Blob_Generic_47560, *PBlob_Generic_47560;

struct Blob_Generic_47560 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4430 Blob_PropertySig_4430, *PBlob_PropertySig_4430;

typedef struct PropertySig_4430 PropertySig_4430, *PPropertySig_4430;

typedef struct Type_177961 Type_177961, *PType_177961;

struct Type_177961 {
    struct ValueType.conflict11 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_4430 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177961 RetType; // Return type
};

struct Blob_PropertySig_4430 {
    byte Size; // coded integer - blob size
    struct PropertySig_4430 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_4436 Blob_PropertySig_4436, *PBlob_PropertySig_4436;

typedef struct PropertySig_4436 PropertySig_4436, *PPropertySig_4436;

typedef struct Type_177967 Type_177967, *PType_177967;

struct Type_177967 {
    struct ValueType.conflict10 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_4436 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177967 RetType; // Return type
};

struct Blob_PropertySig_4436 {
    byte Size; // coded integer - blob size
    struct PropertySig_4436 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_46224 Blob_Generic_46224, *PBlob_Generic_46224;

struct Blob_Generic_46224 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7671 Blob_Generic_7671, *PBlob_Generic_7671;

struct Blob_Generic_7671 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10275 Blob_Generic_10275, *PBlob_Generic_10275;

struct Blob_Generic_10275 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_15963 Blob_Generic_15963, *PBlob_Generic_15963;

struct Blob_Generic_15963 {
    byte Size; // coded integer - blob size
    byte Generic[26]; // Undefined blob contents
};

typedef struct Blob_Generic_5014 Blob_Generic_5014, *PBlob_Generic_5014;

struct Blob_Generic_5014 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_13306 Blob_Generic_13306, *PBlob_Generic_13306;

struct Blob_Generic_13306 {
    byte Size; // coded integer - blob size
    byte Generic[36]; // Undefined blob contents
};

typedef struct Blob_Generic_22250 Blob_Generic_22250, *PBlob_Generic_22250;

struct Blob_Generic_22250 {
    byte Size; // coded integer - blob size
    byte Generic[41]; // Undefined blob contents
};

typedef struct Blob_Generic_6347 Blob_Generic_6347, *PBlob_Generic_6347;

struct Blob_Generic_6347 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_40929 Blob_Generic_40929, *PBlob_Generic_40929;

struct Blob_Generic_40929 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7681 Blob_Generic_7681, *PBlob_Generic_7681;

struct Blob_Generic_7681 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5028 Blob_Generic_5028, *PBlob_Generic_5028;

struct Blob_Generic_5028 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_10287 Blob_Generic_10287, *PBlob_Generic_10287;

struct Blob_Generic_10287 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_14646 Blob_Generic_14646, *PBlob_Generic_14646;

struct Blob_Generic_14646 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7687 Blob_Generic_7687, *PBlob_Generic_7687;

struct Blob_Generic_7687 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6357 Blob_Generic_6357, *PBlob_Generic_6357;

struct Blob_Generic_6357 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_39929 Blob_Generic_39929, *PBlob_Generic_39929;

struct Blob_Generic_39929 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11271 Blob_PropertySig_11271, *PBlob_PropertySig_11271;

typedef struct PropertySig_11271 PropertySig_11271, *PPropertySig_11271;

typedef struct Type_184802 Type_184802, *PType_184802;

struct Type_184802 {
    struct GenericInstType_184803 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_11271 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184802 RetType; // Return type
};

struct Blob_PropertySig_11271 {
    byte Size; // coded integer - blob size
    struct PropertySig_11271 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_27956 Blob_Generic_27956, *PBlob_Generic_27956;

struct Blob_Generic_27956 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_Generic_26626 Blob_Generic_26626, *PBlob_Generic_26626;

struct Blob_Generic_26626 {
    byte Size; // coded integer - blob size
    byte Generic[65]; // Undefined blob contents
};

typedef struct Blob_Generic_18257 Blob_Generic_18257, *PBlob_Generic_18257;

struct Blob_Generic_18257 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_19586 Blob_Generic_19586, *PBlob_Generic_19586;

struct Blob_Generic_19586 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1475 Blob_Generic_1475, *PBlob_Generic_1475;

struct Blob_Generic_1475 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_300 Blob_Generic_300, *PBlob_Generic_300;

struct Blob_Generic_300 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_12952 Blob_Generic_12952, *PBlob_Generic_12952;

struct Blob_Generic_12952 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_45870 Blob_Generic_45870, *PBlob_Generic_45870;

struct Blob_Generic_45870 {
    byte Size; // coded integer - blob size
    byte Generic[67]; // Undefined blob contents
};

typedef struct Blob_Generic_4501 Blob_Generic_4501, *PBlob_Generic_4501;

struct Blob_Generic_4501 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5831 Blob_Generic_5831, *PBlob_Generic_5831;

struct Blob_Generic_5831 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_11625 Blob_Generic_11625, *PBlob_Generic_11625;

struct Blob_Generic_11625 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4508 Blob_Generic_4508, *PBlob_Generic_4508;

struct Blob_Generic_4508 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12957 Blob_Generic_12957, *PBlob_Generic_12957;

struct Blob_Generic_12957 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_5837 Blob_Generic_5837, *PBlob_Generic_5837;

struct Blob_Generic_5837 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_32553 Blob_Generic_32553, *PBlob_Generic_32553;

struct Blob_Generic_32553 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12877.conflict Blob_ConstantSig_12877.conflict, *PBlob_ConstantSig_12877.conflict;

typedef struct ConstantSig_12877.conflict ConstantSig_12877.conflict, *PConstantSig_12877.conflict;

struct ConstantSig_12877.conflict {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12877.conflict {
    byte Size; // coded integer - blob size
    struct ConstantSig_12877.conflict ConstantSig; // Data stored in a constant
};

typedef struct Blob_PropertySig_3937 Blob_PropertySig_3937, *PBlob_PropertySig_3937;

typedef struct PropertySig_3937 PropertySig_3937, *PPropertySig_3937;

typedef struct Type_177468 Type_177468, *PType_177468;

struct Type_177468 {
    struct ValueType.conflict ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_3937 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177468 RetType; // Return type
};

struct Blob_PropertySig_3937 {
    byte Size; // coded integer - blob size
    struct PropertySig_3937 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_48905 Blob_Generic_48905, *PBlob_Generic_48905;

struct Blob_Generic_48905 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_23615 Blob_Generic_23615, *PBlob_Generic_23615;

struct Blob_Generic_23615 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_40178 Blob_Generic_40178, *PBlob_Generic_40178;

struct Blob_Generic_40178 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1485 Blob_Generic_1485, *PBlob_Generic_1485;

struct Blob_Generic_1485 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_20581 Blob_Generic_20581, *PBlob_Generic_20581;

struct Blob_Generic_20581 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_12962 Blob_Generic_12962, *PBlob_Generic_12962;

struct Blob_Generic_12962 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_11633 Blob_Generic_11633, *PBlob_Generic_11633;

struct Blob_Generic_11633 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4514 Blob_Generic_4514, *PBlob_Generic_4514;

struct Blob_Generic_4514 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10303 Blob_Generic_10303, *PBlob_Generic_10303;

struct Blob_Generic_10303 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_12967 Blob_Generic_12967, *PBlob_Generic_12967;

struct Blob_Generic_12967 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_52156 Blob_Generic_52156, *PBlob_Generic_52156;

struct Blob_Generic_52156 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_36921 Blob_Generic_36921, *PBlob_Generic_36921;

struct Blob_Generic_36921 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5849 Blob_Generic_5849, *PBlob_Generic_5849;

struct Blob_Generic_5849 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_33895 Blob_Generic_33895, *PBlob_Generic_33895;

struct Blob_Generic_33895 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3919 Blob_PropertySig_3919, *PBlob_PropertySig_3919;

typedef struct PropertySig_3919 PropertySig_3919, *PPropertySig_3919;

typedef struct Type_177450 Type_177450, *PType_177450;

struct Type_177450 {
    struct GenericInstType_177451 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_3919 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177450 RetType; // Return type
};

struct Blob_PropertySig_3919 {
    byte Size; // coded integer - blob size
    struct PropertySig_3919 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_4520 Blob_Generic_4520, *PBlob_Generic_4520;

struct Blob_Generic_4520 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_1495 Blob_Generic_1495, *PBlob_Generic_1495;

struct Blob_Generic_1495 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5857 Blob_Generic_5857, *PBlob_Generic_5857;

struct Blob_Generic_5857 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12932 Blob_Generic_12932, *PBlob_Generic_12932;

struct Blob_Generic_12932 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_11601 Blob_Generic_11601, *PBlob_Generic_11601;

struct Blob_Generic_11601 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_12937 Blob_Generic_12937, *PBlob_Generic_12937;

struct Blob_Generic_12937 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_39182 Blob_Generic_39182, *PBlob_Generic_39182;

struct Blob_Generic_39182 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18241 Blob_Generic_18241, *PBlob_Generic_18241;

struct Blob_Generic_18241 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_24912 Blob_Generic_24912, *PBlob_Generic_24912;

struct Blob_Generic_24912 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_21899 Blob_Generic_21899, *PBlob_Generic_21899;

struct Blob_Generic_21899 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3929 Blob_PropertySig_3929, *PBlob_PropertySig_3929;

typedef struct PropertySig_3929 PropertySig_3929, *PPropertySig_3929;

typedef struct Type_177460 Type_177460, *PType_177460;

struct Type_177460 {
    struct GenericInstType_177461 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_3929 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177460 RetType; // Return type
};

struct Blob_PropertySig_3929 {
    byte Size; // coded integer - blob size
    struct PropertySig_3929 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_44510 Blob_Generic_44510, *PBlob_Generic_44510;

struct Blob_Generic_44510 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_5865 Blob_Generic_5865, *PBlob_Generic_5865;

struct Blob_Generic_5865 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4532 Blob_Generic_4532, *PBlob_Generic_4532;

struct Blob_Generic_4532 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_20560 Blob_Generic_20560, *PBlob_Generic_20560;

struct Blob_Generic_20560 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_11611 Blob_Generic_11611, *PBlob_Generic_11611;

struct Blob_Generic_11611 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_12942 Blob_Generic_12942, *PBlob_Generic_12942;

struct Blob_Generic_12942 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3203 Blob_Generic_3203, *PBlob_Generic_3203;

struct Blob_Generic_3203 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12947 Blob_Generic_12947, *PBlob_Generic_12947;

struct Blob_Generic_12947 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_52135 Blob_Generic_52135, *PBlob_Generic_52135;

struct Blob_Generic_52135 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_33874 Blob_Generic_33874, *PBlob_Generic_33874;

struct Blob_Generic_33874 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_45849 Blob_Generic_45849, *PBlob_Generic_45849;

struct Blob_Generic_45849 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4540 Blob_Generic_4540, *PBlob_Generic_4540;

struct Blob_Generic_4540 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_22313 Blob_Generic_22313, *PBlob_Generic_22313;

struct Blob_Generic_22313 {
    byte Size; // coded integer - blob size
    byte Generic[55]; // Undefined blob contents
};

typedef struct Blob_Generic_340 Blob_Generic_340, *PBlob_Generic_340;

struct Blob_Generic_340 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12992 Blob_Generic_12992, *PBlob_Generic_12992;

struct Blob_Generic_12992 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_10330 Blob_Generic_10330, *PBlob_Generic_10330;

struct Blob_Generic_10330 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3211 Blob_Generic_3211, *PBlob_Generic_3211;

struct Blob_Generic_3211 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11665 Blob_Generic_11665, *PBlob_Generic_11665;

struct Blob_Generic_11665 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4548 Blob_Generic_4548, *PBlob_Generic_4548;

struct Blob_Generic_4548 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_12997 Blob_Generic_12997, *PBlob_Generic_12997;

struct Blob_Generic_12997 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_348 Blob_Generic_348, *PBlob_Generic_348;

struct Blob_Generic_348 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5875 Blob_Generic_5875, *PBlob_Generic_5875;

struct Blob_Generic_5875 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10338 Blob_Generic_10338, *PBlob_Generic_10338;

struct Blob_Generic_10338 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_8909 Blob_Generic_8909, *PBlob_Generic_8909;

struct Blob_Generic_8909 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3219 Blob_Generic_3219, *PBlob_Generic_3219;

struct Blob_Generic_3219 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_35625 Blob_Generic_35625, *PBlob_Generic_35625;

struct Blob_Generic_35625 {
    byte Size; // coded integer - blob size
    byte Generic[69]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12902 Blob_ConstantSig_12902, *PBlob_ConstantSig_12902;

typedef struct ConstantSig_12902 ConstantSig_12902, *PConstantSig_12902;

struct ConstantSig_12902 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12902 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12902 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_31266 Blob_Generic_31266, *PBlob_Generic_31266;

struct Blob_Generic_31266 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_24977 Blob_Generic_24977, *PBlob_Generic_24977;

struct Blob_Generic_24977 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12907 Blob_ConstantSig_12907, *PBlob_ConstantSig_12907;

typedef struct ConstantSig_12907 ConstantSig_12907, *PConstantSig_12907;

struct ConstantSig_12907 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12907 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12907 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_5881 Blob_Generic_5881, *PBlob_Generic_5881;

struct Blob_Generic_5881 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_23657 Blob_Generic_23657, *PBlob_Generic_23657;

struct Blob_Generic_23657 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5887 Blob_Generic_5887, *PBlob_Generic_5887;

struct Blob_Generic_5887 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_11675 Blob_Generic_11675, *PBlob_Generic_11675;

struct Blob_Generic_11675 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_44572 Blob_Generic_44572, *PBlob_Generic_44572;

struct Blob_Generic_44572 {
    byte Size; // coded integer - blob size
    byte Generic[65]; // Undefined blob contents
};

typedef struct Blob_Generic_10345 Blob_Generic_10345, *PBlob_Generic_10345;

struct Blob_Generic_10345 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_14704 Blob_Generic_14704, *PBlob_Generic_14704;

struct Blob_Generic_14704 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4558 Blob_Generic_4558, *PBlob_Generic_4558;

struct Blob_Generic_4558 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_34309 Blob_Generic_34309, *PBlob_Generic_34309;

struct Blob_Generic_34309 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8917 Blob_Generic_8917, *PBlob_Generic_8917;

struct Blob_Generic_8917 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_570 Blob_PropertySig_570, *PBlob_PropertySig_570;

typedef struct PropertySig_570 PropertySig_570, *PPropertySig_570;

typedef struct Type_174101 Type_174101, *PType_174101;

struct Type_174101 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_570 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174101 RetType; // Return type
};

struct Blob_PropertySig_570 {
    byte Size; // coded integer - blob size
    struct PropertySig_570 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_48926 Blob_Generic_48926, *PBlob_Generic_48926;

struct Blob_Generic_48926 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_3230 Blob_Generic_3230, *PBlob_Generic_3230;

struct Blob_Generic_3230 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_43236 Blob_Generic_43236, *PBlob_Generic_43236;

struct Blob_Generic_43236 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_12972 Blob_Generic_12972, *PBlob_Generic_12972;

struct Blob_Generic_12972 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_11641 Blob_Generic_11641, *PBlob_Generic_11641;

struct Blob_Generic_11641 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_8925 Blob_Generic_8925, *PBlob_Generic_8925;

struct Blob_Generic_8925 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_328 Blob_Generic_328, *PBlob_Generic_328;

struct Blob_Generic_328 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_10313 Blob_Generic_10313, *PBlob_Generic_10313;

struct Blob_Generic_10313 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_4568 Blob_Generic_4568, *PBlob_Generic_4568;

struct Blob_Generic_4568 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12977 Blob_Generic_12977, *PBlob_Generic_12977;

struct Blob_Generic_12977 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_32574 Blob_Generic_32574, *PBlob_Generic_32574;

struct Blob_Generic_32574 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_31245 Blob_Generic_31245, *PBlob_Generic_31245;

struct Blob_Generic_31245 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_24956 Blob_Generic_24956, *PBlob_Generic_24956;

struct Blob_Generic_24956 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_23636 Blob_Generic_23636, *PBlob_Generic_23636;

struct Blob_Generic_23636 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_40199 Blob_Generic_40199, *PBlob_Generic_40199;

struct Blob_Generic_40199 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_564 Blob_PropertySig_564, *PBlob_PropertySig_564;

typedef struct PropertySig_564 PropertySig_564, *PPropertySig_564;

typedef struct Type_174095 Type_174095, *PType_174095;

struct Type_174095 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_564 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174095 RetType; // Return type
};

struct Blob_PropertySig_564 {
    byte Size; // coded integer - blob size
    struct PropertySig_564 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_12982 Blob_Generic_12982, *PBlob_Generic_12982;

struct Blob_Generic_12982 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3244 Blob_Generic_3244, *PBlob_Generic_3244;

struct Blob_Generic_3244 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10322 Blob_Generic_10322, *PBlob_Generic_10322;

struct Blob_Generic_10322 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11653 Blob_Generic_11653, *PBlob_Generic_11653;

struct Blob_Generic_11653 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10907 Blob_PropertySig_10907, *PBlob_PropertySig_10907;

typedef struct PropertySig_10907 PropertySig_10907, *PPropertySig_10907;

typedef struct Type_184438 Type_184438, *PType_184438;

struct Type_184438 {
    struct GenericInstType_184439 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_10907 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184438 RetType; // Return type
};

struct Blob_PropertySig_10907 {
    byte Size; // coded integer - blob size
    struct PropertySig_10907 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_310 Blob_Generic_310, *PBlob_Generic_310;

struct Blob_Generic_310 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_4574 Blob_Generic_4574, *PBlob_Generic_4574;

struct Blob_Generic_4574 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12987 Blob_Generic_12987, *PBlob_Generic_12987;

struct Blob_Generic_12987 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_7600 Blob_Generic_7600, *PBlob_Generic_7600;

struct Blob_Generic_7600 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11659 Blob_Generic_11659, *PBlob_Generic_11659;

struct Blob_Generic_11659 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_319 Blob_Generic_319, *PBlob_Generic_319;

struct Blob_Generic_319 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_7608 Blob_Generic_7608, *PBlob_Generic_7608;

struct Blob_Generic_7608 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_36942 Blob_Generic_36942, *PBlob_Generic_36942;

struct Blob_Generic_36942 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_18290 Blob_Generic_18290, *PBlob_Generic_18290;

struct Blob_Generic_18290 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_552 Blob_PropertySig_552, *PBlob_PropertySig_552;

typedef struct PropertySig_552 PropertySig_552, *PPropertySig_552;

typedef struct Type_174083 Type_174083, *PType_174083;

struct Type_174083 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_552 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174083 RetType; // Return type
};

struct Blob_PropertySig_552 {
    byte Size; // coded integer - blob size
    struct PropertySig_552 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8023 Blob_Generic_8023, *PBlob_Generic_8023;

struct Blob_Generic_8023 {
    byte Size; // coded integer - blob size
    byte Generic[23]; // Undefined blob contents
};

typedef struct Blob_Generic_39119 Blob_Generic_39119, *PBlob_Generic_39119;

struct Blob_Generic_39119 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_48065 Blob_Generic_48065, *PBlob_Generic_48065;

struct Blob_Generic_48065 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_49396 Blob_Generic_49396, *PBlob_Generic_49396;

struct Blob_Generic_49396 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_30773 Blob_Generic_30773, *PBlob_Generic_30773;

struct Blob_Generic_30773 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_28454 Blob_Generic_28454, *PBlob_Generic_28454;

struct Blob_Generic_28454 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2723 Blob_Generic_2723, *PBlob_Generic_2723;

struct Blob_Generic_2723 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_33801 Blob_Generic_33801, *PBlob_Generic_33801;

struct Blob_Generic_33801 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_27126 Blob_Generic_27126, *PBlob_Generic_27126;

struct Blob_Generic_27126 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_558 Blob_PropertySig_558, *PBlob_PropertySig_558;

typedef struct PropertySig_558 PropertySig_558, *PPropertySig_558;

typedef struct Type_174089 Type_174089, *PType_174089;

struct Type_174089 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_558 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174089 RetType; // Return type
};

struct Blob_PropertySig_558 {
    byte Size; // coded integer - blob size
    struct PropertySig_558 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_36078 Blob_Generic_36078, *PBlob_Generic_36078;

struct Blob_Generic_36078 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_15151 Blob_Generic_15151, *PBlob_Generic_15151;

struct Blob_Generic_15151 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_9369 Blob_Generic_9369, *PBlob_Generic_9369;

struct Blob_Generic_9369 {
    byte Size; // coded integer - blob size
    byte Generic[27]; // Undefined blob contents
};

typedef struct Blob_Generic_21831 Blob_Generic_21831, *PBlob_Generic_21831;

struct Blob_Generic_21831 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11415 Blob_PropertySig_11415, *PBlob_PropertySig_11415;

typedef struct PropertySig_11415 PropertySig_11415, *PPropertySig_11415;

typedef struct Type_184946 Type_184946, *PType_184946;

struct Type_184946 {
    struct ValueType.conflict41 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_11415 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184946 RetType; // Return type
};

struct Blob_PropertySig_11415 {
    byte Size; // coded integer - blob size
    struct PropertySig_11415 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_41422 Blob_Generic_41422, *PBlob_Generic_41422;

struct Blob_Generic_41422 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6142 Blob_PropertySig_6142, *PBlob_PropertySig_6142;

typedef struct PropertySig_6142 PropertySig_6142, *PPropertySig_6142;

typedef struct Type_179673 Type_179673, *PType_179673;

struct Type_179673 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_6142 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179673 RetType; // Return type
};

struct Blob_PropertySig_6142 {
    byte Size; // coded integer - blob size
    struct PropertySig_6142 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2733 Blob_Generic_2733, *PBlob_Generic_2733;

struct Blob_Generic_2733 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_33815 Blob_Generic_33815, *PBlob_Generic_33815;

struct Blob_Generic_33815 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_1405 Blob_Generic_1405, *PBlob_Generic_1405;

struct Blob_Generic_1405 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_29794 Blob_Generic_29794, *PBlob_Generic_29794;

struct Blob_Generic_29794 {
    byte Size; // coded integer - blob size
    byte Generic[67]; // Undefined blob contents
};

typedef struct Blob_Generic_50377 Blob_Generic_50377, *PBlob_Generic_50377;

struct Blob_Generic_50377 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_6136 Blob_PropertySig_6136, *PBlob_PropertySig_6136;

typedef struct PropertySig_6136 PropertySig_6136, *PPropertySig_6136;

typedef struct Type_179667 Type_179667, *PType_179667;

struct Type_179667 {
    struct ValueType.conflict21 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_6136 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179667 RetType; // Return type
};

struct Blob_PropertySig_6136 {
    byte Size; // coded integer - blob size
    struct PropertySig_6136 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8047 Blob_Generic_8047, *PBlob_Generic_8047;

struct Blob_Generic_8047 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_42742 Blob_Generic_42742, *PBlob_Generic_42742;

struct Blob_Generic_42742 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_2743 Blob_Generic_2743, *PBlob_Generic_2743;

struct Blob_Generic_2743 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_48044 Blob_Generic_48044, *PBlob_Generic_48044;

struct Blob_Generic_48044 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_51692 Blob_Generic_51692, *PBlob_Generic_51692;

struct Blob_Generic_51692 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_30752 Blob_Generic_30752, *PBlob_Generic_30752;

struct Blob_Generic_30752 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2749 Blob_Generic_2749, *PBlob_Generic_2749;

struct Blob_Generic_2749 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_27105 Blob_Generic_27105, *PBlob_Generic_27105;

struct Blob_Generic_27105 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_36057 Blob_Generic_36057, *PBlob_Generic_36057;

struct Blob_Generic_36057 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16464 Blob_Generic_16464, *PBlob_Generic_16464;

struct Blob_Generic_16464 {
    byte Size; // coded integer - blob size
    byte Generic[29]; // Undefined blob contents
};

typedef struct Blob_Generic_21810 Blob_Generic_21810, *PBlob_Generic_21810;

struct Blob_Generic_21810 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_15130 Blob_Generic_15130, *PBlob_Generic_15130;

struct Blob_Generic_15130 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8053 Blob_Generic_8053, *PBlob_Generic_8053;

struct Blob_Generic_8053 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_41401 Blob_Generic_41401, *PBlob_Generic_41401;

struct Blob_Generic_41401 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1420 Blob_Generic_1420, *PBlob_Generic_1420;

struct Blob_Generic_1420 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_1427 Blob_Generic_1427, *PBlob_Generic_1427;

struct Blob_Generic_1427 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_29773 Blob_Generic_29773, *PBlob_Generic_29773;

struct Blob_Generic_29773 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_50356 Blob_Generic_50356, *PBlob_Generic_50356;

struct Blob_Generic_50356 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8063 Blob_Generic_8063, *PBlob_Generic_8063;

struct Blob_Generic_8063 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_37397 Blob_Generic_37397, *PBlob_Generic_37397;

struct Blob_Generic_37397 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8069 Blob_Generic_8069, *PBlob_Generic_8069;

struct Blob_Generic_8069 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_9397 Blob_Generic_9397, *PBlob_Generic_9397;

struct Blob_Generic_9397 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_2760 Blob_Generic_2760, *PBlob_Generic_2760;

struct Blob_Generic_2760 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_1432 Blob_Generic_1432, *PBlob_Generic_1432;

struct Blob_Generic_1432 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_12912 Blob_Generic_12912, *PBlob_Generic_12912;

struct Blob_Generic_12912 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_1439 Blob_Generic_1439, *PBlob_Generic_1439;

struct Blob_Generic_1439 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_28496 Blob_Generic_28496, *PBlob_Generic_28496;

struct Blob_Generic_28496 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_Generic_33844 Blob_Generic_33844, *PBlob_Generic_33844;

struct Blob_Generic_33844 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_12917 Blob_Generic_12917, *PBlob_Generic_12917;

struct Blob_Generic_12917 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_15190 Blob_Generic_15190, *PBlob_Generic_15190;

struct Blob_Generic_15190 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_19550 Blob_Generic_19550, *PBlob_Generic_19550;

struct Blob_Generic_19550 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_39161 Blob_Generic_39161, *PBlob_Generic_39161;

struct Blob_Generic_39161 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41464 Blob_Generic_41464, *PBlob_Generic_41464;

struct Blob_Generic_41464 {
    byte Size; // coded integer - blob size
    byte Generic[37]; // Undefined blob contents
};

typedef struct Blob_Generic_40131 Blob_Generic_40131, *PBlob_Generic_40131;

struct Blob_Generic_40131 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_8075 Blob_Generic_8075, *PBlob_Generic_8075;

struct Blob_Generic_8075 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_42797 Blob_Generic_42797, *PBlob_Generic_42797;

struct Blob_Generic_42797 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18225 Blob_Generic_18225, *PBlob_Generic_18225;

struct Blob_Generic_18225 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_2770 Blob_Generic_2770, *PBlob_Generic_2770;

struct Blob_Generic_2770 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_1445 Blob_Generic_1445, *PBlob_Generic_1445;

struct Blob_Generic_1445 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12922 Blob_Generic_12922, *PBlob_Generic_12922;

struct Blob_Generic_12922 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_33859 Blob_Generic_33859, *PBlob_Generic_33859;

struct Blob_Generic_33859 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_12927 Blob_Generic_12927, *PBlob_Generic_12927;

struct Blob_Generic_12927 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_52114 Blob_Generic_52114, *PBlob_Generic_52114;

struct Blob_Generic_52114 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_10991 Blob_FieldSig_10991, *PBlob_FieldSig_10991;

typedef struct FieldSig_10991 FieldSig_10991, *PFieldSig_10991;

typedef struct Type_184521 Type_184521, *PType_184521;

struct Type_184521 {
    struct ValueType.conflict37 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10991 {
    byte FIELD; // Magic (0x06)
    struct Type_184521 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10991 {
    byte Size; // coded integer - blob size
    struct FieldSig_10991 FieldSig; // Type information for Field
};

typedef struct Blob_FieldSig_6795 Blob_FieldSig_6795, *PBlob_FieldSig_6795;

typedef struct FieldSig_6795 FieldSig_6795, *PFieldSig_6795;

typedef struct Type_180325 Type_180325, *PType_180325;

struct Type_180325 {
    struct ValueType.conflict18 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6795 {
    byte FIELD; // Magic (0x06)
    struct Type_180325 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6795 {
    byte Size; // coded integer - blob size
    struct FieldSig_6795 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_8085 Blob_Generic_8085, *PBlob_Generic_8085;

struct Blob_Generic_8085 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_45828 Blob_Generic_45828, *PBlob_Generic_45828;

struct Blob_Generic_45828 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_20510 Blob_Generic_20510, *PBlob_Generic_20510;

struct Blob_Generic_20510 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_16494 Blob_Generic_16494, *PBlob_Generic_16494;

struct Blob_Generic_16494 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_6790 Blob_FieldSig_6790, *PBlob_FieldSig_6790;

typedef struct FieldSig_6790 FieldSig_6790, *PFieldSig_6790;

typedef struct Type_180320 Type_180320, *PType_180320;

struct Type_180320 {
    struct ValueType.conflict17 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6790 {
    byte FIELD; // Magic (0x06)
    struct Type_180320 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6790 {
    byte Size; // coded integer - blob size
    struct FieldSig_6790 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_2780 Blob_Generic_2780, *PBlob_Generic_2780;

struct Blob_Generic_2780 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_33829 Blob_Generic_33829, *PBlob_Generic_33829;

struct Blob_Generic_33829 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_5811 Blob_Generic_5811, *PBlob_Generic_5811;

struct Blob_Generic_5811 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_1451 Blob_Generic_1451, *PBlob_Generic_1451;

struct Blob_Generic_1451 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_1457 Blob_Generic_1457, *PBlob_Generic_1457;

struct Blob_Generic_1457 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_19529 Blob_Generic_19529, *PBlob_Generic_19529;

struct Blob_Generic_19529 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_2786 Blob_Generic_2786, *PBlob_Generic_2786;

struct Blob_Generic_2786 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_28475 Blob_Generic_28475, *PBlob_Generic_28475;

struct Blob_Generic_28475 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_27147 Blob_Generic_27147, *PBlob_Generic_27147;

struct Blob_Generic_27147 {
    byte Size; // coded integer - blob size
    byte Generic[63]; // Undefined blob contents
};

typedef struct Blob_Generic_36099 Blob_Generic_36099, *PBlob_Generic_36099;

struct Blob_Generic_36099 {
    byte Size; // coded integer - blob size
    byte Generic[51]; // Undefined blob contents
};

typedef struct Blob_Generic_39140 Blob_Generic_39140, *PBlob_Generic_39140;

struct Blob_Generic_39140 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_6785 Blob_FieldSig_6785, *PBlob_FieldSig_6785;

typedef struct FieldSig_6785 FieldSig_6785, *PFieldSig_6785;

typedef struct Type_180315 Type_180315, *PType_180315;

struct Type_180315 {
    struct ValueType.conflict16 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6785 {
    byte FIELD; // Magic (0x06)
    struct Type_180315 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6785 {
    byte Size; // coded integer - blob size
    struct FieldSig_6785 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_8091 Blob_Generic_8091, *PBlob_Generic_8091;

struct Blob_Generic_8091 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_40110 Blob_Generic_40110, *PBlob_Generic_40110;

struct Blob_Generic_40110 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_21852 Blob_Generic_21852, *PBlob_Generic_21852;

struct Blob_Generic_21852 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10985 Blob_PropertySig_10985, *PBlob_PropertySig_10985;

typedef struct PropertySig_10985 PropertySig_10985, *PPropertySig_10985;

typedef struct Type_184516 Type_184516, *PType_184516;

struct Type_184516 {
    struct ValueType.conflict37 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_10985 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184516 RetType; // Return type
};

struct Blob_PropertySig_10985 {
    byte Size; // coded integer - blob size
    struct PropertySig_10985 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_8097 Blob_Generic_8097, *PBlob_Generic_8097;

struct Blob_Generic_8097 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_FieldSig_6780 Blob_FieldSig_6780, *PBlob_FieldSig_6780;

typedef struct FieldSig_6780 FieldSig_6780, *PFieldSig_6780;

typedef struct Type_180310 Type_180310, *PType_180310;

struct Type_180310 {
    struct ValueType.conflict15 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6780 {
    byte FIELD; // Magic (0x06)
    struct Type_180310 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6780 {
    byte Size; // coded integer - blob size
    struct FieldSig_6780 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_18204 Blob_Generic_18204, *PBlob_Generic_18204;

struct Blob_Generic_18204 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_41443 Blob_Generic_41443, *PBlob_Generic_41443;

struct Blob_Generic_41443 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1463 Blob_Generic_1463, *PBlob_Generic_1463;

struct Blob_Generic_1463 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_2792 Blob_Generic_2792, *PBlob_Generic_2792;

struct Blob_Generic_2792 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_12902 Blob_Generic_12902, *PBlob_Generic_12902;

struct Blob_Generic_12902 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_5825 Blob_Generic_5825, *PBlob_Generic_5825;

struct Blob_Generic_5825 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12907 Blob_Generic_12907, *PBlob_Generic_12907;

struct Blob_Generic_12907 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_50398 Blob_Generic_50398, *PBlob_Generic_50398;

struct Blob_Generic_50398 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_FieldSig_6775 Blob_FieldSig_6775, *PBlob_FieldSig_6775;

typedef struct FieldSig_6775 FieldSig_6775, *PFieldSig_6775;

typedef struct Type_180305 Type_180305, *PType_180305;

struct Type_180305 {
    struct ValueType.conflict14 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_6775 {
    byte FIELD; // Magic (0x06)
    struct Type_180305 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_6775 {
    byte Size; // coded integer - blob size
    struct FieldSig_6775 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_12150 Blob_Generic_12150, *PBlob_Generic_12150;

struct Blob_Generic_12150 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6245 Blob_Generic_6245, *PBlob_Generic_6245;

struct Blob_Generic_6245 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_38783 Blob_Generic_38783, *PBlob_Generic_38783;

struct Blob_Generic_38783 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_12158 Blob_Generic_12158, *PBlob_Generic_12158;

struct Blob_Generic_12158 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12957.conflict Blob_ConstantSig_12957.conflict, *PBlob_ConstantSig_12957.conflict;

typedef struct ConstantSig_12957.conflict ConstantSig_12957.conflict, *PConstantSig_12957.conflict;

struct ConstantSig_12957.conflict {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12957.conflict {
    byte Size; // coded integer - blob size
    struct ConstantSig_12957.conflict ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_16515 Blob_Generic_16515, *PBlob_Generic_16515;

struct Blob_Generic_16515 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_7579 Blob_Generic_7579, *PBlob_Generic_7579;

struct Blob_Generic_7579 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_PropertySig_11381 Blob_PropertySig_11381, *PBlob_PropertySig_11381;

typedef struct PropertySig_11381 PropertySig_11381, *PPropertySig_11381;

typedef struct Type_184912 Type_184912, *PType_184912;

struct Type_184912 {
    struct ValueType.conflict40 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_11381 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_184912 RetType; // Return type
};

struct Blob_PropertySig_11381 {
    byte Size; // coded integer - blob size
    struct PropertySig_11381 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_24137 Blob_Generic_24137, *PBlob_Generic_24137;

struct Blob_Generic_24137 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6253 Blob_Generic_6253, *PBlob_Generic_6253;

struct Blob_Generic_6253 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_13492 Blob_Generic_13492, *PBlob_Generic_13492;

struct Blob_Generic_13492 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_12166 Blob_Generic_12166, *PBlob_Generic_12166;

struct Blob_Generic_12166 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_46399 Blob_Generic_46399, *PBlob_Generic_46399;

struct Blob_Generic_46399 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_51746 Blob_Generic_51746, *PBlob_Generic_51746;

struct Blob_Generic_51746 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_25473 Blob_Generic_25473, *PBlob_Generic_25473;

struct Blob_Generic_25473 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5689 Blob_PropertySig_5689, *PBlob_PropertySig_5689;

typedef struct PropertySig_5689 PropertySig_5689, *PPropertySig_5689;

typedef struct Type_179220 Type_179220, *PType_179220;

struct Type_179220 {
    struct GenericInstType_179221 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_5689 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179220 RetType; // Return type
};

struct Blob_PropertySig_5689 {
    byte Size; // coded integer - blob size
    struct PropertySig_5689 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_38762 Blob_Generic_38762, *PBlob_Generic_38762;

struct Blob_Generic_38762 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6261 Blob_Generic_6261, *PBlob_Generic_6261;

struct Blob_Generic_6261 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_7592 Blob_Generic_7592, *PBlob_Generic_7592;

struct Blob_Generic_7592 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_49417 Blob_Generic_49417, *PBlob_Generic_49417;

struct Blob_Generic_49417 {
    byte Size; // coded integer - blob size
    byte Generic[58]; // Undefined blob contents
};

typedef struct Blob_Generic_14797 Blob_Generic_14797, *PBlob_Generic_14797;

struct Blob_Generic_14797 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_Generic_12137 Blob_Generic_12137, *PBlob_Generic_12137;

struct Blob_Generic_12137 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_6268 Blob_Generic_6268, *PBlob_Generic_6268;

struct Blob_Generic_6268 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_24116 Blob_Generic_24116, *PBlob_Generic_24116;

struct Blob_Generic_24116 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_26779 Blob_Generic_26779, *PBlob_Generic_26779;

struct Blob_Generic_26779 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_6275 Blob_Generic_6275, *PBlob_Generic_6275;

struct Blob_Generic_6275 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_9301 Blob_Generic_9301, *PBlob_Generic_9301;

struct Blob_Generic_9301 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_13471 Blob_Generic_13471, *PBlob_Generic_13471;

struct Blob_Generic_13471 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_33080 Blob_Generic_33080, *PBlob_Generic_33080;

struct Blob_Generic_33080 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_17831 Blob_Generic_17831, *PBlob_Generic_17831;

struct Blob_Generic_17831 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_46378 Blob_Generic_46378, *PBlob_Generic_46378;

struct Blob_Generic_46378 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_9307 Blob_Generic_9307, *PBlob_Generic_9307;

struct Blob_Generic_9307 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_37439 Blob_Generic_37439, *PBlob_Generic_37439;

struct Blob_Generic_37439 {
    byte Size; // coded integer - blob size
    byte Generic[58]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10021 Blob_PropertySig_10021, *PBlob_PropertySig_10021;

typedef struct PropertySig_10021 PropertySig_10021, *PPropertySig_10021;

typedef struct Type_183552 Type_183552, *PType_183552;

struct Type_183552 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10021 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183552 RetType; // Return type
};

struct Blob_PropertySig_10021 {
    byte Size; // coded integer - blob size
    struct PropertySig_10021 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_9314 Blob_Generic_9314, *PBlob_Generic_9314;

struct Blob_Generic_9314 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6289 Blob_Generic_6289, *PBlob_Generic_6289;

struct Blob_Generic_6289 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_6282 Blob_Generic_6282, *PBlob_Generic_6282;

struct Blob_Generic_6282 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_12197 Blob_Generic_12197, *PBlob_Generic_12197;

struct Blob_Generic_12197 {
    byte Size; // coded integer - blob size
    byte Generic[16]; // Undefined blob contents
};

typedef struct Blob_Generic_50467 Blob_Generic_50467, *PBlob_Generic_50467;

struct Blob_Generic_50467 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_Generic_48148 Blob_Generic_48148, *PBlob_Generic_48148;

struct Blob_Generic_48148 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_49476 Blob_Generic_49476, *PBlob_Generic_49476;

struct Blob_Generic_49476 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_16557 Blob_Generic_16557, *PBlob_Generic_16557;

struct Blob_Generic_16557 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_29862 Blob_Generic_29862, *PBlob_Generic_29862;

struct Blob_Generic_29862 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_36151 Blob_Generic_36151, *PBlob_Generic_36151;

struct Blob_Generic_36151 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_36172 Blob_Generic_36172, *PBlob_Generic_36172;

struct Blob_Generic_36172 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_6298 Blob_Generic_6298, *PBlob_Generic_6298;

struct Blob_Generic_6298 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_15232 Blob_Generic_15232, *PBlob_Generic_15232;

struct Blob_Generic_15232 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_PropertySig_10009 Blob_PropertySig_10009, *PBlob_PropertySig_10009;

typedef struct PropertySig_10009 PropertySig_10009, *PPropertySig_10009;

typedef struct Type_183540 Type_183540, *PType_183540;

struct Type_183540 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10009 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183540 RetType; // Return type
};

struct Blob_PropertySig_10009 {
    byte Size; // coded integer - blob size
    struct PropertySig_10009 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_9320 Blob_Generic_9320, *PBlob_Generic_9320;

struct Blob_Generic_9320 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_17895 Blob_Generic_17895, *PBlob_Generic_17895;

struct Blob_Generic_17895 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_51788 Blob_Generic_51788, *PBlob_Generic_51788;

struct Blob_Generic_51788 {
    byte Size; // coded integer - blob size
    byte Generic[46]; // Undefined blob contents
};

typedef struct Blob_Generic_9327 Blob_Generic_9327, *PBlob_Generic_9327;

struct Blob_Generic_9327 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3074 Blob_PropertySig_3074, *PBlob_PropertySig_3074;

typedef struct PropertySig_3074 PropertySig_3074, *PPropertySig_3074;

typedef struct Type_176605 Type_176605, *PType_176605;

struct Type_176605 {
    struct GenericInstType_176606 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_3074 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_176605 RetType; // Return type
};

struct Blob_PropertySig_3074 {
    byte Size; // coded integer - blob size
    struct PropertySig_3074 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_7424 Blob_PropertySig_7424, *PBlob_PropertySig_7424;

typedef struct PropertySig_7424 PropertySig_7424, *PPropertySig_7424;

typedef struct Type_180955 Type_180955, *PType_180955;

struct Type_180955 {
    struct GenericInstType_180956 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_7424 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_180955 RetType; // Return type
};

struct Blob_PropertySig_7424 {
    byte Size; // coded integer - blob size
    struct PropertySig_7424 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_27211 Blob_Generic_27211, *PBlob_Generic_27211;

struct Blob_Generic_27211 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_28547 Blob_Generic_28547, *PBlob_Generic_28547;

struct Blob_Generic_28547 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_37498 Blob_Generic_37498, *PBlob_Generic_37498;

struct Blob_Generic_37498 {
    byte Size; // coded integer - blob size
    byte Generic[58]; // Undefined blob contents
};

typedef struct Blob_Generic_41502 Blob_Generic_41502, *PBlob_Generic_41502;

struct Blob_Generic_41502 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_42839 Blob_Generic_42839, *PBlob_Generic_42839;

struct Blob_Generic_42839 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_Generic_9333 Blob_Generic_9333, *PBlob_Generic_9333;

struct Blob_Generic_9333 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12177 Blob_Generic_12177, *PBlob_Generic_12177;

struct Blob_Generic_12177 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_16536 Blob_Generic_16536, *PBlob_Generic_16536;

struct Blob_Generic_16536 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8007 Blob_Generic_8007, *PBlob_Generic_8007;

struct Blob_Generic_8007 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_9339 Blob_Generic_9339, *PBlob_Generic_9339;

struct Blob_Generic_9339 {
    byte Size; // coded integer - blob size
    byte Generic[29]; // Undefined blob contents
};

typedef struct Blob_Generic_2701 Blob_Generic_2701, *PBlob_Generic_2701;

struct Blob_Generic_2701 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_30830 Blob_Generic_30830, *PBlob_Generic_30830;

struct Blob_Generic_30830 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_PropertySig_5699 Blob_PropertySig_5699, *PBlob_PropertySig_5699;

typedef struct PropertySig_5699 PropertySig_5699, *PPropertySig_5699;

typedef struct Type_179230 Type_179230, *PType_179230;

struct Type_179230 {
    struct GenericInstType_179231 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_5699 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_179230 RetType; // Return type
};

struct Blob_PropertySig_5699 {
    byte Size; // coded integer - blob size
    struct PropertySig_5699 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_24158 Blob_Generic_24158, *PBlob_Generic_24158;

struct Blob_Generic_24158 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_Generic_8015 Blob_Generic_8015, *PBlob_Generic_8015;

struct Blob_Generic_8015 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_12187 Blob_Generic_12187, *PBlob_Generic_12187;

struct Blob_Generic_12187 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_15211 Blob_Generic_15211, *PBlob_Generic_15211;

struct Blob_Generic_15211 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_17874 Blob_Generic_17874, *PBlob_Generic_17874;

struct Blob_Generic_17874 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_45087 Blob_Generic_45087, *PBlob_Generic_45087;

struct Blob_Generic_45087 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_51767 Blob_Generic_51767, *PBlob_Generic_51767;

struct Blob_Generic_51767 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_48111 Blob_Generic_48111, *PBlob_Generic_48111;

struct Blob_Generic_48111 {
    byte Size; // coded integer - blob size
    byte Generic[36]; // Undefined blob contents
};

typedef struct Blob_Generic_25494 Blob_Generic_25494, *PBlob_Generic_25494;

struct Blob_Generic_25494 {
    byte Size; // coded integer - blob size
    byte Generic[59]; // Undefined blob contents
};

typedef struct Blob_Generic_2713 Blob_Generic_2713, *PBlob_Generic_2713;

struct Blob_Generic_2713 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_42818 Blob_Generic_42818, *PBlob_Generic_42818;

struct Blob_Generic_42818 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_382 Blob_Generic_382, *PBlob_Generic_382;

struct Blob_Generic_382 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_84 Blob_Generic_84, *PBlob_Generic_84;

struct Blob_Generic_84 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_4463 Blob_Generic_4463, *PBlob_Generic_4463;

struct Blob_Generic_4463 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_3130 Blob_Generic_3130, *PBlob_Generic_3130;

struct Blob_Generic_3130 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3136 Blob_Generic_3136, *PBlob_Generic_3136;

struct Blob_Generic_3136 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_43293 Blob_Generic_43293, *PBlob_Generic_43293;

struct Blob_Generic_43293 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8824 Blob_Generic_8824, *PBlob_Generic_8824;

struct Blob_Generic_8824 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_388 Blob_Generic_388, *PBlob_Generic_388;

struct Blob_Generic_388 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_46322 Blob_Generic_46322, *PBlob_Generic_46322;

struct Blob_Generic_46322 {
    byte Size; // coded integer - blob size
    byte Generic[55]; // Undefined blob contents
};

typedef struct Blob_FieldSig_10027 Blob_FieldSig_10027, *PBlob_FieldSig_10027;

typedef struct FieldSig_10027 FieldSig_10027, *PFieldSig_10027;

typedef struct Type_183557 Type_183557, *PType_183557;

struct Type_183557 {
    struct ValueType.conflict26 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10027 {
    byte FIELD; // Magic (0x06)
    struct Type_183557 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10027 {
    byte Size; // coded integer - blob size
    struct FieldSig_10027 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_5795 Blob_Generic_5795, *PBlob_Generic_5795;

struct Blob_Generic_5795 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_89 Blob_Generic_89, *PBlob_Generic_89;

struct Blob_Generic_89 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12947 Blob_ConstantSig_12947, *PBlob_ConstantSig_12947;

typedef struct ConstantSig_12947 ConstantSig_12947, *PConstantSig_12947;

struct ConstantSig_12947 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12947 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12947 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_33005 Blob_Generic_33005, *PBlob_Generic_33005;

struct Blob_Generic_33005 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12942 Blob_ConstantSig_12942, *PBlob_ConstantSig_12942;

typedef struct ConstantSig_12942 ConstantSig_12942, *PConstantSig_12942;

struct ConstantSig_12942 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12942 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12942 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_34330 Blob_Generic_34330, *PBlob_Generic_34330;

struct Blob_Generic_34330 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_370 Blob_Generic_370, *PBlob_Generic_370;

struct Blob_Generic_370 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_22369 Blob_Generic_22369, *PBlob_Generic_22369;

struct Blob_Generic_22369 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_374 Blob_Generic_374, *PBlob_Generic_374;

struct Blob_Generic_374 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_47645 Blob_Generic_47645, *PBlob_Generic_47645;

struct Blob_Generic_47645 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_48975 Blob_Generic_48975, *PBlob_Generic_48975;

struct Blob_Generic_48975 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3146 Blob_Generic_3146, *PBlob_Generic_3146;

struct Blob_Generic_3146 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_7505 Blob_Generic_7505, *PBlob_Generic_7505;

struct Blob_Generic_7505 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4476 Blob_Generic_4476, *PBlob_Generic_4476;

struct Blob_Generic_4476 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_97 Blob_Generic_97, *PBlob_Generic_97;

struct Blob_Generic_97 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_13415 Blob_Generic_13415, *PBlob_Generic_13415;

struct Blob_Generic_13415 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_8834 Blob_Generic_8834, *PBlob_Generic_8834;

struct Blob_Generic_8834 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_14746 Blob_Generic_14746, *PBlob_Generic_14746;

struct Blob_Generic_14746 {
    byte Size; // coded integer - blob size
    byte Generic[50]; // Undefined blob contents
};

typedef struct Blob_FieldSig_10032 Blob_FieldSig_10032, *PBlob_FieldSig_10032;

typedef struct FieldSig_10032 FieldSig_10032, *PFieldSig_10032;

typedef struct Type_183562 Type_183562, *PType_183562;

struct Type_183562 {
    struct ValueType.conflict27 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10032 {
    byte FIELD; // Magic (0x06)
    struct Type_183562 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10032 {
    byte Size; // coded integer - blob size
    struct FieldSig_10032 FieldSig; // Type information for Field
};

typedef struct Blob_FieldSig_10037 Blob_FieldSig_10037, *PBlob_FieldSig_10037;

typedef struct FieldSig_10037 FieldSig_10037, *PFieldSig_10037;

typedef struct Type_183567 Type_183567, *PType_183567;

struct Type_183567 {
    struct ValueType.conflict28 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10037 {
    byte FIELD; // Magic (0x06)
    struct Type_183567 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10037 {
    byte Size; // coded integer - blob size
    struct FieldSig_10037 FieldSig; // Type information for Field
};

typedef struct Blob_ConstantSig_12932 Blob_ConstantSig_12932, *PBlob_ConstantSig_12932;

typedef struct ConstantSig_12932 ConstantSig_12932, *PConstantSig_12932;

struct ConstantSig_12932 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12932 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12932 ConstantSig; // Data stored in a constant
};

typedef struct Blob_ConstantSig_12937 Blob_ConstantSig_12937, *PBlob_ConstantSig_12937;

typedef struct ConstantSig_12937 ConstantSig_12937, *PConstantSig_12937;

struct ConstantSig_12937 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12937 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12937 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_63 Blob_Generic_63, *PBlob_Generic_63;

struct Blob_Generic_63 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3154 Blob_Generic_3154, *PBlob_Generic_3154;

struct Blob_Generic_3154 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_11681 Blob_Generic_11681, *PBlob_Generic_11681;

struct Blob_Generic_11681 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4483 Blob_Generic_4483, *PBlob_Generic_4483;

struct Blob_Generic_4483 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_10351 Blob_Generic_10351, *PBlob_Generic_10351;

struct Blob_Generic_10351 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7515 Blob_Generic_7515, *PBlob_Generic_7515;

struct Blob_Generic_7515 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_366 Blob_Generic_366, *PBlob_Generic_366;

struct Blob_Generic_366 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_10357 Blob_Generic_10357, *PBlob_Generic_10357;

struct Blob_Generic_10357 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_8844 Blob_Generic_8844, *PBlob_Generic_8844;

struct Blob_Generic_8844 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12922 Blob_ConstantSig_12922, *PBlob_ConstantSig_12922;

typedef struct ConstantSig_12922 ConstantSig_12922, *PConstantSig_12922;

struct ConstantSig_12922 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12922 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12922 ConstantSig; // Data stored in a constant
};

typedef struct Blob_FieldSig_10042 Blob_FieldSig_10042, *PBlob_FieldSig_10042;

typedef struct FieldSig_10042 FieldSig_10042, *PFieldSig_10042;

typedef struct Type_183572 Type_183572, *PType_183572;

struct Type_183572 {
    struct ValueType.conflict29 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10042 {
    byte FIELD; // Magic (0x06)
    struct Type_183572 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10042 {
    byte Size; // coded integer - blob size
    struct FieldSig_10042 FieldSig; // Type information for Field
};

typedef struct Blob_FieldSig_10047 Blob_FieldSig_10047, *PBlob_FieldSig_10047;

typedef struct FieldSig_10047 FieldSig_10047, *PFieldSig_10047;

typedef struct Type_183577 Type_183577, *PType_183577;

struct Type_183577 {
    struct ValueType.conflict30 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10047 {
    byte FIELD; // Magic (0x06)
    struct Type_183577 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10047 {
    byte Size; // coded integer - blob size
    struct FieldSig_10047 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_31287 Blob_Generic_31287, *PBlob_Generic_31287;

struct Blob_Generic_31287 {
    byte Size; // coded integer - blob size
    byte Generic[66]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12927 Blob_ConstantSig_12927, *PBlob_ConstantSig_12927;

typedef struct ConstantSig_12927 ConstantSig_12927, *PConstantSig_12927;

struct ConstantSig_12927 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12927 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12927 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_71 Blob_Generic_71, *PBlob_Generic_71;

struct Blob_Generic_71 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_4490 Blob_Generic_4490, *PBlob_Generic_4490;

struct Blob_Generic_4490 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_23678 Blob_Generic_23678, *PBlob_Generic_23678;

struct Blob_Generic_23678 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_11691 Blob_Generic_11691, *PBlob_Generic_11691;

struct Blob_Generic_11691 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_47624 Blob_Generic_47624, *PBlob_Generic_47624;

struct Blob_Generic_47624 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3162 Blob_Generic_3162, *PBlob_Generic_3162;

struct Blob_Generic_3162 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_10363 Blob_Generic_10363, *PBlob_Generic_10363;

struct Blob_Generic_10363 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_356 Blob_Generic_356, *PBlob_Generic_356;

struct Blob_Generic_356 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_8854 Blob_Generic_8854, *PBlob_Generic_8854;

struct Blob_Generic_8854 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_10369 Blob_Generic_10369, *PBlob_Generic_10369;

struct Blob_Generic_10369 {
    byte Size; // coded integer - blob size
    byte Generic[24]; // Undefined blob contents
};

typedef struct Blob_Generic_78 Blob_Generic_78, *PBlob_Generic_78;

struct Blob_Generic_78 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7525 Blob_Generic_7525, *PBlob_Generic_7525;

struct Blob_Generic_7525 {
    byte Size; // coded integer - blob size
    byte Generic[19]; // Undefined blob contents
};

typedef struct Blob_Generic_14725 Blob_Generic_14725, *PBlob_Generic_14725;

struct Blob_Generic_14725 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12912 Blob_ConstantSig_12912, *PBlob_ConstantSig_12912;

typedef struct ConstantSig_12912 ConstantSig_12912, *PConstantSig_12912;

struct ConstantSig_12912 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12912 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12912 ConstantSig; // Data stored in a constant
};

typedef struct Blob_FieldSig_10052 Blob_FieldSig_10052, *PBlob_FieldSig_10052;

typedef struct FieldSig_10052 FieldSig_10052, *PFieldSig_10052;

typedef struct Type_183582 Type_183582, *PType_183582;

struct Type_183582 {
    struct ValueType.conflict31 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10052 {
    byte FIELD; // Magic (0x06)
    struct Type_183582 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10052 {
    byte Size; // coded integer - blob size
    struct FieldSig_10052 FieldSig; // Type information for Field
};

typedef struct Blob_PropertySig_1223 Blob_PropertySig_1223, *PBlob_PropertySig_1223;

typedef struct PropertySig_1223 PropertySig_1223, *PPropertySig_1223;

typedef struct Type_174754 Type_174754, *PType_174754;

struct Type_174754 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_1223 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174754 RetType; // Return type
};

struct Blob_PropertySig_1223 {
    byte Size; // coded integer - blob size
    struct PropertySig_1223 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_FieldSig_10057 Blob_FieldSig_10057, *PBlob_FieldSig_10057;

typedef struct FieldSig_10057 FieldSig_10057, *PFieldSig_10057;

typedef struct Type_183587 Type_183587, *PType_183587;

struct Type_183587 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct FieldSig_10057 {
    byte FIELD; // Magic (0x06)
    struct Type_183587 ELEMENT_TYPE_U4;
};

struct Blob_FieldSig_10057 {
    byte Size; // coded integer - blob size
    struct FieldSig_10057 FieldSig; // Type information for Field
};

typedef struct Blob_ConstantSig_12917 Blob_ConstantSig_12917, *PBlob_ConstantSig_12917;

typedef struct ConstantSig_12917 ConstantSig_12917, *PConstantSig_12917;

struct ConstantSig_12917 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12917 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12917 ConstantSig; // Data stored in a constant
};

typedef struct Blob_PropertySig_1229 Blob_PropertySig_1229, *PBlob_PropertySig_1229;

typedef struct PropertySig_1229 PropertySig_1229, *PPropertySig_1229;

typedef struct Type_174760 Type_174760, *PType_174760;

struct Type_174760 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_1229 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_174760 RetType; // Return type
};

struct Blob_PropertySig_1229 {
    byte Size; // coded integer - blob size
    struct PropertySig_1229 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_3170 Blob_Generic_3170, *PBlob_Generic_3170;

struct Blob_Generic_3170 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_38741 Blob_Generic_38741, *PBlob_Generic_38741;

struct Blob_Generic_38741 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12992 Blob_ConstantSig_12992, *PBlob_ConstantSig_12992;

typedef struct ConstantSig_12992 ConstantSig_12992, *PConstantSig_12992;

struct ConstantSig_12992 {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12992 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12992 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_51713 Blob_Generic_51713, *PBlob_Generic_51713;

struct Blob_Generic_51713 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_8864 Blob_Generic_8864, *PBlob_Generic_8864;

struct Blob_Generic_8864 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_12117 Blob_Generic_12117, *PBlob_Generic_12117;

struct Blob_Generic_12117 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_6205 Blob_Generic_6205, *PBlob_Generic_6205;

struct Blob_Generic_6205 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_22390 Blob_Generic_22390, *PBlob_Generic_22390;

struct Blob_Generic_22390 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_10065 Blob_FieldSig_10065, *PBlob_FieldSig_10065;

typedef struct FieldSig_10065 FieldSig_10065, *PFieldSig_10065;

typedef struct Type_183595 Type_183595, *PType_183595;

struct Type_183595 {
    struct ValueType.conflict33 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10065 {
    byte FIELD; // Magic (0x06)
    struct Type_183595 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10065 {
    byte Size; // coded integer - blob size
    struct FieldSig_10065 FieldSig; // Type information for Field
};

typedef struct Blob_PropertySig_10091 Blob_PropertySig_10091, *PBlob_PropertySig_10091;

typedef struct PropertySig_10091 PropertySig_10091, *PPropertySig_10091;

typedef struct Type_183622 Type_183622, *PType_183622;

struct Type_183622 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_10091 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_183622 RetType; // Return type
};

struct Blob_PropertySig_10091 {
    byte Size; // coded integer - blob size
    struct PropertySig_10091 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_ConstantSig_12987 Blob_ConstantSig_12987, *PBlob_ConstantSig_12987;

typedef struct ConstantSig_12987 ConstantSig_12987, *PConstantSig_12987;

struct ConstantSig_12987 {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12987 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12987 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_25427 Blob_Generic_25427, *PBlob_Generic_25427;

struct Blob_Generic_25427 {
    byte Size; // coded integer - blob size
    byte Generic[45]; // Undefined blob contents
};

typedef struct Blob_Generic_26758 Blob_Generic_26758, *PBlob_Generic_26758;

struct Blob_Generic_26758 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_4309 Blob_PropertySig_4309, *PBlob_PropertySig_4309;

typedef struct PropertySig_4309 PropertySig_4309, *PPropertySig_4309;

typedef struct Type_177840 Type_177840, *PType_177840;

struct Type_177840 {
    struct ValueType.conflict47 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_4309 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_177840 RetType; // Return type
};

struct Blob_PropertySig_4309 {
    byte Size; // coded integer - blob size
    struct PropertySig_4309 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_FieldSig_10060 Blob_FieldSig_10060, *PBlob_FieldSig_10060;

typedef struct FieldSig_10060 FieldSig_10060, *PFieldSig_10060;

typedef struct Type_183590 Type_183590, *PType_183590;

struct Type_183590 {
    struct ValueType.conflict32 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10060 {
    byte FIELD; // Magic (0x06)
    struct Type_183590 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10060 {
    byte Size; // coded integer - blob size
    struct FieldSig_10060 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_3180 Blob_Generic_3180, *PBlob_Generic_3180;

struct Blob_Generic_3180 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_17810 Blob_Generic_17810, *PBlob_Generic_17810;

struct Blob_Generic_17810 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_45028 Blob_Generic_45028, *PBlob_Generic_45028;

struct Blob_Generic_45028 {
    byte Size; // coded integer - blob size
    byte Generic[58]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12917.conflict Blob_ConstantSig_12917.conflict, *PBlob_ConstantSig_12917.conflict;

typedef struct ConstantSig_12917.conflict ConstantSig_12917.conflict, *PConstantSig_12917.conflict;

struct ConstantSig_12917.conflict {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12917.conflict {
    byte Size; // coded integer - blob size
    struct ConstantSig_12917.conflict ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_12127 Blob_Generic_12127, *PBlob_Generic_12127;

struct Blob_Generic_12127 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12982 Blob_ConstantSig_12982, *PBlob_ConstantSig_12982;

typedef struct ConstantSig_12982 ConstantSig_12982, *PConstantSig_12982;

struct ConstantSig_12982 {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12982 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12982 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_7545 Blob_Generic_7545, *PBlob_Generic_7545;

struct Blob_Generic_7545 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6215 Blob_Generic_6215, *PBlob_Generic_6215;

struct Blob_Generic_6215 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12977 Blob_ConstantSig_12977, *PBlob_ConstantSig_12977;

typedef struct ConstantSig_12977 ConstantSig_12977, *PConstantSig_12977;

struct ConstantSig_12977 {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12977 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12977 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_37418 Blob_Generic_37418, *PBlob_Generic_37418;

struct Blob_Generic_37418 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_10075 Blob_FieldSig_10075, *PBlob_FieldSig_10075;

typedef struct FieldSig_10075 FieldSig_10075, *PFieldSig_10075;

typedef struct Type_183605 Type_183605, *PType_183605;

struct Type_183605 {
    struct ValueType.conflict35 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10075 {
    byte FIELD; // Magic (0x06)
    struct Type_183605 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10075 {
    byte Size; // coded integer - blob size
    struct FieldSig_10075 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_33059 Blob_Generic_33059, *PBlob_Generic_33059;

struct Blob_Generic_33059 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3190 Blob_Generic_3190, *PBlob_Generic_3190;

struct Blob_Generic_3190 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_FieldSig_10070 Blob_FieldSig_10070, *PBlob_FieldSig_10070;

typedef struct FieldSig_10070 FieldSig_10070, *PFieldSig_10070;

typedef struct Type_183600 Type_183600, *PType_183600;

struct Type_183600 {
    struct ValueType.conflict34 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10070 {
    byte FIELD; // Magic (0x06)
    struct Type_183600 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10070 {
    byte Size; // coded integer - blob size
    struct FieldSig_10070 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_6221 Blob_Generic_6221, *PBlob_Generic_6221;

struct Blob_Generic_6221 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7553 Blob_Generic_7553, *PBlob_Generic_7553;

struct Blob_Generic_7553 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_21047 Blob_Generic_21047, *PBlob_Generic_21047;

struct Blob_Generic_21047 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_10394 Blob_Generic_10394, *PBlob_Generic_10394;

struct Blob_Generic_10394 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_38720 Blob_Generic_38720, *PBlob_Generic_38720;

struct Blob_Generic_38720 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12972 Blob_ConstantSig_12972, *PBlob_ConstantSig_12972;

typedef struct ConstantSig_12972 ConstantSig_12972, *PConstantSig_12972;

struct ConstantSig_12972 {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_12972 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12972 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_6227 Blob_Generic_6227, *PBlob_Generic_6227;

struct Blob_Generic_6227 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12967 Blob_ConstantSig_12967, *PBlob_ConstantSig_12967;

typedef struct ConstantSig_12967 ConstantSig_12967, *PConstantSig_12967;

struct ConstantSig_12967 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12967 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12967 ConstantSig; // Data stored in a constant
};

typedef struct Blob_ConstantSig_12962 Blob_ConstantSig_12962, *PBlob_ConstantSig_12962;

typedef struct ConstantSig_12962 ConstantSig_12962, *PConstantSig_12962;

struct ConstantSig_12962 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12962 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12962 ConstantSig; // Data stored in a constant
};

typedef struct Blob_FieldSig_10080 Blob_FieldSig_10080, *PBlob_FieldSig_10080;

typedef struct FieldSig_10080 FieldSig_10080, *PFieldSig_10080;

typedef struct Type_183610 Type_183610, *PType_183610;

struct Type_183610 {
    struct ValueType.conflict36 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_10080 {
    byte FIELD; // Magic (0x06)
    struct Type_183610 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_10080 {
    byte Size; // coded integer - blob size
    struct FieldSig_10080 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_34351 Blob_Generic_34351, *PBlob_Generic_34351;

struct Blob_Generic_34351 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_25406 Blob_Generic_25406, *PBlob_Generic_25406;

struct Blob_Generic_25406 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_47666 Blob_Generic_47666, *PBlob_Generic_47666;

struct Blob_Generic_47666 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_48996 Blob_Generic_48996, *PBlob_Generic_48996;

struct Blob_Generic_48996 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_394 Blob_Generic_394, *PBlob_Generic_394;

struct Blob_Generic_394 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_7561 Blob_Generic_7561, *PBlob_Generic_7561;

struct Blob_Generic_7561 {
    byte Size; // coded integer - blob size
    byte Generic[17]; // Undefined blob contents
};

typedef struct Blob_Generic_13436 Blob_Generic_13436, *PBlob_Generic_13436;

struct Blob_Generic_13436 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_12104 Blob_Generic_12104, *PBlob_Generic_12104;

struct Blob_Generic_12104 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_6237 Blob_Generic_6237, *PBlob_Generic_6237;

struct Blob_Generic_6237 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_12957 Blob_ConstantSig_12957, *PBlob_ConstantSig_12957;

typedef struct ConstantSig_12957 ConstantSig_12957, *PConstantSig_12957;

struct ConstantSig_12957 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12957 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12957 ConstantSig; // Data stored in a constant
};

typedef struct Blob_ConstantSig_12952 Blob_ConstantSig_12952, *PBlob_ConstantSig_12952;

typedef struct ConstantSig_12952 ConstantSig_12952, *PConstantSig_12952;

struct ConstantSig_12952 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_12952 {
    byte Size; // coded integer - blob size
    struct ConstantSig_12952 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_33038 Blob_Generic_33038, *PBlob_Generic_33038;

struct Blob_Generic_33038 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_35695 Blob_Generic_35695, *PBlob_Generic_35695;

struct Blob_Generic_35695 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct ParamRow ParamRow, *PParamRow;

typedef enum ParamAttributes {
    In=1,
    Out=2,
    Optional=16,
    HasDefault=4096,
    HasFieldMarshal=8192,
    Unused=53216
} ParamAttributes;

struct ParamRow {
    enum ParamAttributes Flags; // bitmask of type ParamAttributes
    word Sequence; // constant
    word Name; // index into String heap
};

typedef struct Field Row Field Row, *PField Row;

typedef enum FieldAttributes {
    Access_CompilerControlled=0,
    Access_Private=1,
    Access_FamANDAssem=2,
    Access_Assembly=3,
    Access_Family=4,
    Access_FamORAssem=5,
    Access_Public=6,
    Static=16,
    InitOnly=32,
    Literal=64,
    NotSerialized=128,
    HasFieldRVA=256,
    SpecialName=512,
    RTSpecialName=1024,
    HasFieldMarshal=4096,
    PInvokeImpl=8192,
    HasDefault=32768
} FieldAttributes;

struct Field Row {
    enum FieldAttributes Flags; // see CorFieldAttr
    word Name; // index into String heap
    word Signature; // index into Blob heap
};

typedef struct CustomAttribute Row CustomAttribute Row, *PCustomAttribute Row;

struct CustomAttribute Row {
    dword Parent;
    word Type;
    word Value;
};

typedef struct InterfaceImpl Row InterfaceImpl Row, *PInterfaceImpl Row;

struct InterfaceImpl Row {
    word Class; // index into TypeDef table
    word Interface; // index into TypeDef/TypeRef/TypeSpec - TypeDefOrRef coded
};

typedef struct MethodDef Row MethodDef Row, *PMethodDef Row;

typedef enum MethodImplAttributes {
    CodeType_IL=0,
    CodeType_Native=1,
    CodeType_OPTIL=2,
    CodeType_Runtime=3,
    Unmanaged=4,
    NoInlining=8,
    ForwardRef=16,
    Synchronized=32,
    NoOptimization=64,
    PreserveSig=128,
    InternalCall=4096,
    MaxMethodImplVal=65535
} MethodImplAttributes;

typedef enum MethodAttributes {
    MAccess_CompilerControlled=0,
    MAccess_Private=1,
    MAccess_FamANDAssem=2,
    MAccess_Assem=3,
    MAccess_Family=4,
    MAccess_FamORAssem=5,
    MAccess_Public=6,
    UnmanagedExport=8,
    Static=16,
    Final=32,
    Virtual=64,
    HideBySig=128,
    VtableLayout_NewSlot=256,
    Strict=512,
    Abstract=1024,
    SpecialName=2048,
    RTSpecialName=4096,
    PInvokeImpl=8192,
    HasSecurity=16384,
    RequireSecObject=32768
} MethodAttributes;

struct MethodDef Row {
    dword RVA;
    enum MethodImplAttributes ImplFlags; // Bitmask of type MethodImplAttributes
    enum MethodAttributes Flags; // Bitmask of type MethodAttribute
    word Name; // index into String heap
    word Signature; // index into Blob heap
    word ParamList; // index into Param table
};

typedef struct MemberRef Row MemberRef Row, *PMemberRef Row;

struct MemberRef Row {
    word Class; // index-MemberRefParent coded
    word Name; // index into String heap
    word Signature; // index into Blob heap
};

typedef struct AssemblyRef Row AssemblyRef Row, *PAssemblyRef Row;

typedef enum AssemblyFlags {
    PublicKey=1,
    Retargetable=256,
    DisableJITcompileOptimizer=16384,
    EnableJITcompileTracking=32768
} AssemblyFlags;

struct AssemblyRef Row {
    word MajorVersion;
    word MinorVersion;
    word BuildNumber;
    word RevisionNumber;
    enum AssemblyFlags Flags; // Bitmask of type AssemblyFlags
    word PublicKeyOrToken; // Public Key or token identifying the author of the assembly.
    word Name; // index into String heap
    word Culture; // index into String heap
    word HashValue; // index into Blob heap
};

typedef struct Property Row Property Row, *PProperty Row;

typedef enum PropertyAttributes {
    SpecialName=512,
    RTSpecialName=1024,
    HasDefault=4096,
    Unused=59903
} PropertyAttributes;

struct Property Row {
    enum PropertyAttributes Flags; // Bitmask of type PropertyAttributes
    word Name;
    word Type; // Blob index to the signature, not a TypeDef/TypeRef
};

typedef struct MethodSemantics Row MethodSemantics Row, *PMethodSemantics Row;

typedef enum MethodSemanticsAttributes {
    Setter=1,
    Getter=2,
    Other=4,
    AddOn=8,
    RemoveOn=16,
    Fire=32
} MethodSemanticsAttributes;

struct MethodSemantics Row {
    enum MethodSemanticsAttributes Semantics; // Bitmask of type MethodSemanticsAttributes
    word Method; // index into MethodDef table
    word Association; // HasSemantics coded index into Event or Property
};

typedef struct MethodImpl Row MethodImpl Row, *PMethodImpl Row;

struct MethodImpl Row {
    word Class; // index into TypeDef
    word MethodBody; // MethodDefOrRef coded index
    word MethodDeclaration; // MethodDefOrRef coded index
};

typedef struct TypeRef Row TypeRef Row, *PTypeRef Row;

struct TypeRef Row {
    word ResolutionScope;
    word TypeName;
    word TypeNamespace;
};

typedef struct PropertyMap Row PropertyMap Row, *PPropertyMap Row;

struct PropertyMap Row {
    word Parent;
    word options; // Index into Property table. Points to contiguous run of Properties until next ref from PropertyMap or end of table.
};

typedef struct Constant Row Constant Row, *PConstant Row;

struct Constant Row {
    enum TypeCode Type; // if Class, indicates nullref
    byte Reserved; // should be 0
    word Parent; // index - coded HasConstant
    word Value; // index into Blob heap
};

typedef struct TypeDef Row TypeDef Row, *PTypeDef Row;

typedef enum TypeAttributes {
    Visibility_NotPublic=0,
    Visibility_Public=1,
    Visibility_NestedPublic=2,
    Visibility_NestedPrivate=3,
    Visibility_NestedFamily=4,
    Visibility_NestedAssembly=5,
    Visibility_NestedFamANDAssem=6,
    Visibility_NestedFamORAssem=7,
    SequentialLayout=8,
    ExplicitLayout=16,
    Interface=32,
    Abstract=128,
    Sealed=256,
    SpecialName=1024,
    RTSpecialName=2048,
    Import=4096,
    Serializable=8192,
    UnicodeClass=65536,
    AutoClass=131072,
    CustomFormatClass=196608,
    HasSecurity=262144,
    BeforeFieldInit=1048576,
    IsTypeForwarder=2097152,
    CustomStringFormatMask=12582912
} TypeAttributes;

struct TypeDef Row {
    enum TypeAttributes Flags; // see CorTypeAttr
    word TypeName; // index into String heap
    word TypeNamespace; // index into String heap
    word Extends; // index: coded TypeDefOrRef
    word FieldList; // index into Field table
    word MethodList; // index into MethodDef table
};

typedef struct Assembly Table Assembly Table, *PAssembly Table;

typedef enum AssemblyHash {
    None=0,
    Reserved (MD5)=32771,
    SHA1=32772
} AssemblyHash;

struct Assembly Table {
    enum AssemblyHash HashAlg; // Type of hash present
    word MajorVersion;
    word MinorVersion;
    word BuildNumber;
    word RevisionNumber;
    enum AssemblyFlags Flags; // Bitmask of type AssemblyFlags
    word PublicKey; // index into Blob heap
    word Name; // index into String heap
    word Culture; // index into String heap
};

typedef struct Module Row Module Row, *PModule Row;

struct Module Row {
    word Generation; // reserved, shall be 0
    word Name; // index into String heap
    word MvId; // used to distinguish between versions of same module
    word EncId; // reserved, shall be 0
    word EncBaseId; // reserved, shall be 0
};

typedef struct #US #US, *P#US;

struct #US {
    byte Reserved; // Always 0
    byte Next string size;
    wchar16 [1][1];
    byte Extra byte; // 0x01 if string contains non-ASCII
};

typedef struct #GUID #GUID, *P#GUID;

struct #GUID {
    GUID [0];
};

typedef struct #Strings #Strings, *P#Strings;

struct #Strings {
    char [0][1];
    char [1][9];
    char [a][34];
    char [2c][14];
    char [3a][24];
    char [52][14];
    char [60][32];
    char [80][22];
    char [96][12];
    char [a2][38];
    char [c8][28];
    char [e4][18];
    char [f6][36];
    char [11a][26];
    char [134][16];
    char [144][27];
    char [15f][19];
    char [172][17];
    char [183][7];
    char [18a][25];
    char [1a3][15];
    char [1b2][5];
    char [1b7][26];
    char [1d1][16];
    char [1e1][16];
    char [1f1][6];
    char [1f7][25];
    char [210][15];
    char [21f][15];
    char [22e][5];
    char [233][26];
    char [24d][23];
    char [264][16];
    char [274][6];
    char [27a][32];
    char [29a][22];
    char [2b0][12];
    char [2bc][27];
    char [2d7][17];
    char [2e8][7];
    char [2ef][28];
    char [30b][18];
    char [31d][8];
    char [325][29];
    char [342][19];
    char [355][19];
    char [368][9];
    char [371][37];
    char [396][27];
    char [3b1][17];
    char [3c2][32];
    char [3e2][22];
    char [3f8][12];
    char [404][31];
    char [423][21];
    char [438][21];
    char [44d][11];
    char [458][28];
    char [474][18];
    char [486][18];
    char [498][8];
    char [4a0][29];
    char [4bd][19];
    char [4d0][9];
    char [4d9][30];
    char [4f7][20];
    char [50b][10];
    char [515][25];
    char [52e][15];
    char [53d][5];
    char [542][14];
    char [550][23];
    char [567][28];
    char [583][18];
    char [595][8];
    char [59d][32];
    char [5bd][22];
    char [5d3][12];
    char [5df][31];
    char [5fe][21];
    char [613][11];
    char [61e][30];
    char [63c][20];
    char [650][20];
    char [664][10];
    char [66e][31];
    char [68d][21];
    char [6a2][21];
    char [6b7][11];
    char [6c2][27];
    char [6dd][17];
    char [6ee][7];
    char [6f5][35];
    char [718][25];
    char [731][15];
    char [740][36];
    char [764][26];
    char [77e][26];
    char [798][16];
    char [7a8][40];
    char [7d0][30];
    char [7ee][20];
    char [802][26];
    char [81c][16];
    char [82c][6];
    char [832][18];
    char [844][17];
    char [855][17];
    char [866][29];
    char [883][19];
    char [896][9];
    char [89f][30];
    char [8bd][20];
    char [8d1][10];
    char [8db][14];
    char [8e9][40];
    char [911][30];
    char [92f][30];
    char [94d][20];
    char [961][44];
    char [98d][34];
    char [9af][24];
    char [9c7][18];
    char [9d9][23];
    char [9f0][15];
    char [9ff][17];
    char [a10][27];
    char [a2b][17];
    char [a3c][7];
    char [a43][18];
    char [a55][15];
    char [a64][15];
    char [a73][9];
    char [a7c][27];
    char [a97][21];
    char [aac][17];
    char [abd][17];
    char [ace][7];
    char [ad5][34];
    char [af7][22];
    char [b0d][24];
    char [b25][14];
    char [b33][44];
    char [b5f][34];
    char [b81][24];
    char [b99][35];
    char [bbc][25];
    char [bd5][15];
    char [be4][31];
    char [c03][21];
    char [c18][21];
    char [c2d][11];
    char [c38][26];
    char [c52][16];
    char [c62][6];
    char [c68][31];
    char [c87][21];
    char [c9c][11];
    char [ca7][25];
    char [cc0][15];
    char [ccf][15];
    char [cde][5];
    char [ce3][29];
    char [d00][19];
    char [d13][19];
    char [d26][9];
    char [d2f][27];
    char [d4a][17];
    char [d5b][7];
    char [d62][31];
    char [d81][25];
    char [d9a][21];
    char [daf][11];
    char [dba][38];
    char [de0][28];
    char [dfc][28];
    char [e18][18];
    char [e2a][30];
    char [e48][20];
    char [e5c][10];
    char [e66][28];
    char [e82][18];
    char [e94][8];
    char [e9c][37];
    char [ec1][27];
    char [edc][27];
    char [ef7][17];
    char [f08][36];
    char [f2c][26];
    char [f46][26];
    char [f60][16];
    char [f70][34];
    char [f92][24];
    char [faa][24];
    char [fc2][14];
    char [fd0][28];
    char [fec][18];
    char [ffe][18];
    char [1010][8];
    char [1018][19];
    char [102b][26];
    char [1045][16];
    char [1055][16];
    char [1065][6];
    char [106b][6];
    char [1071][16];
    char [1081][21];
    char [1096][19];
    char [10a9][24];
    char [10c1][8];
    char [10c9][15];
    char [10d8][33];
    char [10f9][23];
    char [1110][13];
    char [111d][35];
    char [1140][25];
    char [1159][15];
    char [1168][16];
    char [1178][14];
    char [1186][31];
    char [11a5][31];
    char [11c4][21];
    char [11d9][11];
    char [11e4][7];
    char [11eb][9];
    char [11f4][19];
    char [1207][8];
    char [120f][14];
    char [121d][9];
    char [1226][10];
    char [1230][17];
    char [1241][34];
    char [1263][24];
    char [127b][24];
    char [1293][14];
    char [12a1][35];
    char [12c4][25];
    char [12dd][25];
    char [12f6][15];
    char [1305][40];
    char [132d][30];
    char [134b][30];
    char [1369][20];
    char [137d][41];
    char [13a6][31];
    char [13c5][31];
    char [13e4][21];
    char [13f9][32];
    char [1419][22];
    char [142f][22];
    char [1445][12];
    char [1451][33];
    char [1472][23];
    char [1489][23];
    char [14a0][13];
    char [14ad][39];
    char [14d4][29];
    char [14f1][29];
    char [150e][19];
    char [1521][31];
    char [1540][21];
    char [1555][21];
    char [156a][11];
    char [1575][38];
    char [159b][28];
    char [15b7][18];
    char [15c9][22];
    char [15df][26];
    char [15f9][21];
    char [160e][28];
    char [162a][27];
    char [1645][18];
    char [1657][8];
    char [165f][11];
    char [166a][32];
    char [168a][22];
    char [16a0][12];
    char [16ac][38];
    char [16d2][28];
    char [16ee][18];
    char [1700][36];
    char [1724][16];
    char [1734][30];
    char [1752][20];
    char [1766][10];
    char [1770][38];
    char [1796][28];
    char [17b2][18];
    char [17c4][33];
    char [17e5][21];
    char [17fa][23];
    char [1811][13];
    char [181e][17];
    char [182f][32];
    char [184f][23];
    char [1866][22];
    char [187c][22];
    char [1892][12];
    char [189e][35];
    char [18c1][25];
    char [18da][25];
    char [18f3][15];
    char [1902][48];
    char [1932][38];
    char [1958][38];
    char [197e][28];
    char [199a][44];
    char [19c6][34];
    char [19e8][34];
    char [1a0a][24];
    char [1a22][39];
    char [1a49][29];
    char [1a66][19];
    char [1a79][27];
    char [1a94][17];
    char [1aa5][7];
    char [1aac][8];
    char [1ab4][33];
    char [1ad5][32];
    char [1af5][23];
    char [1b0c][13];
    char [1b19][16];
    char [1b29][14];
    char [1b37][7];
    char [1b3e][14];
    char [1b4c][19];
    char [1b5f][23];
    char [1b76][46];
    char [1ba4][36];
    char [1bc8][26];
    char [1be2][29];
    char [1bff][19];
    char [1c12][9];
    char [1c1b][39];
    char [1c42][29];
    char [1c5f][19];
    char [1c72][17];
    char [1c83][17];
    char [1c94][16];
    char [1ca4][41];
    char [1ccd][31];
    char [1cec][21];
    char [1d01][43];
    char [1d2c][33];
    char [1d4d][33];
    char [1d6e][23];
    char [1d85][41];
    char [1dae][31];
    char [1dcd][31];
    char [1dec][21];
    char [1e01][29];
    char [1e1e][19];
    char [1e31][9];
    char [1e3a][38];
    char [1e60][28];
    char [1e7c][18];
    char [1e8e][6];
    char [1e94][14];
    char [1ea2][15];
    char [1eb1][15];
    char [1ec0][26];
    char [1eda][18];
    char [1eec][32];
    char [1f0c][22];
    char [1f22][12];
    char [1f2e][37];
    char [1f53][27];
    char [1f6e][17];
    char [1f7f][15];
    char [1f8e][21];
    char [1fa3][18];
    char [1fb5][21];
    char [1fca][21];
    char [1fdf][6];
    char [1fe5][32];
    char [2005][22];
    char [201b][22];
    char [2031][12];
    char [203d][12];
    char [2049][33];
    char [206a][23];
    char [2081][13];
    char [208e][12];
    char [209a][25];
    char [20b3][26];
    char [20cd][18];
    char [20df][35];
    char [2102][18];
    char [2114][25];
    char [212d][15];
    char [213c][15];
    char [214b][14];
    char [2159][34];
    char [217b][24];
    char [2193][14];
    char [21a1][39];
    char [21c8][29];
    char [21e5][19];
    char [21f8][22];
    char [220e][21];
    char [2223][10];
    char [222d][28];
    char [2249][17];
    char [225a][20];
    char [226e][30];
    char [228c][26];
    char [22a6][17];
    char [22b7][20];
    char [22cb][34];
    char [22ed][28];
    char [2309][21];
    char [231e][18];
    char [2330][18];
    char [2342][8];
    char [234a][37];
    char [236f][27];
    char [238a][17];
    char [239b][40];
    char [23c3][30];
    char [23e1][20];
    char [23f5][35];
    char [2418][25];
    char [2431][25];
    char [244a][15];
    char [2459][47];
    char [2488][37];
    char [24ad][27];
    char [24c8][44];
    char [24f4][34];
    char [2516][24];
    char [252e][41];
    char [2557][31];
    char [2576][21];
    char [258b][29];
    char [25a8][19];
    char [25bb][9];
    char [25c4][43];
    char [25ef][33];
    char [2610][33];
    char [2631][23];
    char [2648][25];
    char [2661][15];
    char [2670][5];
    char [2675][42];
    char [269f][32];
    char [26bf][32];
    char [26df][22];
    char [26f5][54];
    char [272b][44];
    char [2757][34];
    char [2779][35];
    char [279c][25];
    char [27b5][25];
    char [27ce][15];
    char [27dd][29];
    char [27fa][19];
    char [280d][19];
    char [2820][9];
    char [2829][12];
    char [2835][26];
    char [284f][28];
    char [286b][20];
    char [287f][18];
    char [2891][18];
    char [28a3][8];
    char [28ab][13];
    char [28b8][12];
    char [28c4][33];
    char [28e5][22];
    char [28fb][23];
    char [2912][23];
    char [2929][13];
    char [2936][16];
    char [2946][13];
    char [2953][16];
    char [2963][30];
    char [2981][20];
    char [2995][10];
    char [299f][19];
    char [29b2][17];
    char [29c3][27];
    char [29de][24];
    char [29f6][26];
    char [2a10][27];
    char [2a2b][24];
    char [2a43][18];
    char [2a55][15];
    char [2a64][4];
    char [2a68][19];
    char [2a7b][8];
    char [2a83][5];
    char [2a88][12];
    char [2a94][9];
    char [2a9d][11];
    char [2aa8][32];
    char [2ac8][13];
    char [2ad5][13];
    char [2ae2][13];
    char [2aef][21];
    char [2b04][23];
    char [2b1b][10];
    char [2b25][14];
    char [2b33][17];
    char [2b44][6];
    char [2b4a][18];
    char [2b5c][17];
    char [2b6d][25];
    char [2b86][25];
    char [2b9f][15];
    char [2bae][15];
    char [2bbd][5];
    char [2bc2][25];
    char [2bdb][15];
    char [2bea][15];
    char [2bf9][5];
    char [2bfe][30];
    char [2c1c][20];
    char [2c30][10];
    char [2c3a][27];
    char [2c55][17];
    char [2c66][17];
    char [2c77][7];
    char [2c7e][25];
    char [2c97][15];
    char [2ca6][15];
    char [2cb5][5];
    char [2cba][35];
    char [2cdd][25];
    char [2cf6][25];
    char [2d0f][15];
    char [2d1e][30];
    char [2d3c][20];
    char [2d50][20];
    char [2d64][10];
    char [2d6e][45];
    char [2d9b][35];
    char [2dbe][35];
    char [2de1][25];
    char [2dfa][24];
    char [2e12][18];
    char [2e24][14];
    char [2e32][4];
    char [2e36][38];
    char [2e5c][28];
    char [2e78][28];
    char [2e94][18];
    char [2ea6][25];
    char [2ebf][15];
    char [2ece][5];
    char [2ed3][25];
    char [2eec][15];
    char [2efb][15];
    char [2f0a][5];
    char [2f0f][29];
    char [2f2c][19];
    char [2f3f][19];
    char [2f52][9];
    char [2f5b][47];
    char [2f8a][37];
    char [2faf][27];
    char [2fca][38];
    char [2ff0][28];
    char [300c][28];
    char [3028][18];
    char [303a][30];
    char [3058][20];
    char [306c][20];
    char [3080][10];
    char [308a][32];
    char [30aa][22];
    char [30c0][22];
    char [30d6][12];
    char [30e2][42];
    char [310c][32];
    char [312c][32];
    char [314c][22];
    char [3162][28];
    char [317e][18];
    char [3190][18];
    char [31a2][8];
    char [31aa][20];
    char [31be][25];
    char [31d7][23];
    char [31ee][28];
    char [320a][11];
    char [3215][8];
    char [321d][15];
    char [322c][23];
    char [3243][18];
    char [3255][17];
    char [3266][17];
    char [3277][27];
    char [3292][28];
    char [32ae][21];
    char [32c3][17];
    char [32d4][17];
    char [32e5][15];
    char [32f4][19];
    char [3307][20];
    char [331b][23];
    char [3332][23];
    char [3349][24];
    char [3361][19];
    char [3374][14];
    char [3382][7];
    char [3389][23];
    char [33a0][22];
    char [33b6][16];
    char [33c6][29];
    char [33e3][26];
    char [33fd][21];
    char [3412][16];
    char [3422][16];
    char [3432][6];
    char [3438][21];
    char [344d][18];
    char [345f][16];
    char [346f][13];
    char [347c][13];
    char [3489][13];
    char [3496][14];
    char [34a4][24];
    char [34bc][22];
    char [34d2][14];
    char [34e0][4];
    char [34e4][40];
    char [350c][30];
    char [352a][30];
    char [3548][20];
    char [355c][22];
    char [3572][19];
    char [3585][23];
    char [359c][20];
    char [35b0][24];
    char [35c8][20];
    char [35dc][14];
    char [35ea][13];
    char [35f7][13];
    char [3604][15];
    char [3613][20];
    char [3627][17];
    char [3638][20];
    char [364c][17];
    char [365d][16];
    char [366d][13];
    char [367a][15];
    char [3689][12];
    char [3695][16];
    char [36a5][12];
    char [36b1][17];
    char [36c2][17];
    char [36d3][12];
    char [36df][12];
    char [36eb][18];
    char [36fd][34];
    char [371f][24];
    char [3737][14];
    char [3745][17];
    char [3756][14];
    char [3764][32];
    char [3784][22];
    char [379a][22];
    char [37b0][12];
    char [37bc][18];
    char [37ce][15];
    char [37dd][14];
    char [37eb][32];
    char [380b][22];
    char [3821][22];
    char [3837][22];
    char [384d][12];
    char [3859][18];
    char [386b][15];
    char [387a][15];
    char [3889][31];
    char [38a8][19];
    char [38bb][21];
    char [38d0][11];
    char [38db][29];
    char [38f8][19];
    char [390b][19];
    char [391e][9];
    char [3927][19];
    char [393a][16];
    char [394a][16];
    char [395a][12];
    char [3966][14];
    char [3974][19];
    char [3987][7];
    char [398e][34];
    char [39b0][24];
    char [39c8][14];
    char [39d6][25];
    char [39ef][19];
    char [3a02][10];
    char [3a0c][5];
    char [3a11][7];
    char [3a18][10];
    char [3a22][11];
    char [3a2d][8];
    char [3a35][16];
    char [3a45][18];
    char [3a57][18];
    char [3a69][36];
    char [3a8d][16];
    char [3a9d][31];
    char [3abc][11];
    char [3ac7][12];
    char [3ad3][35];
    char [3af6][35];
    char [3b19][25];
    char [3b32][25];
    char [3b4b][15];
    char [3b5a][36];
    char [3b7e][26];
    char [3b98][26];
    char [3bb2][16];
    char [3bc2][37];
    char [3be7][27];
    char [3c02][27];
    char [3c1d][17];
    char [3c2e][28];
    char [3c4a][18];
    char [3c5c][18];
    char [3c6e][8];
    char [3c76][32];
    char [3c96][22];
    char [3cac][22];
    char [3cc2][12];
    char [3cce][47];
    char [3cfd][37];
    char [3d22][27];
    char [3d3d][37];
    char [3d62][27];
    char [3d7d][17];
    char [3d8e][46];
    char [3dbc][36];
    char [3de0][36];
    char [3e04][26];
    char [3e1e][34];
    char [3e40][24];
    char [3e58][24];
    char [3e70][14];
    char [3e7e][47];
    char [3ead][37];
    char [3ed2][37];
    char [3ef7][27];
    char [3f12][44];
    char [3f3e][34];
    char [3f60][24];
    char [3f78][44];
    char [3fa4][34];
    char [3fc6][34];
    char [3fe8][24];
    char [4000][43];
    char [402b][33];
    char [404c][23];
    char [4063][33];
    char [4084][23];
    char [409b][23];
    char [40b2][13];
    char [40bf][31];
    char [40de][21];
    char [40f3][21];
    char [4108][11];
    char [4113][33];
    char [4134][23];
    char [414b][23];
    char [4162][13];
    char [416f][15];
    char [417e][12];
    char [418a][31];
    char [41a9][21];
    char [41be][11];
    char [41c9][31];
    char [41e8][21];
    char [41fd][21];
    char [4212][11];
    char [421d][31];
    char [423c][21];
    char [4251][21];
    char [4266][11];
    char [4271][20];
    char [4285][14];
    char [4293][39];
    char [42ba][19];
    char [42cd][21];
    char [42e2][25];
    char [42fb][28];
    char [4317][18];
    char [4329][18];
    char [433b][8];
    char [4343][37];
    char [4368][27];
    char [4383][27];
    char [439e][17];
    char [43af][34];
    char [43d1][24];
    char [43e9][24];
    char [4401][14];
    char [440f][26];
    char [4429][16];
    char [4439][6];
    char [443f][31];
    char [445e][21];
    char [4473][11];
    char [447e][26];
    char [4498][16];
    char [44a8][6];
    char [44ae][30];
    char [44cc][20];
    char [44e0][10];
    char [44ea][33];
    char [450b][23];
    char [4522][23];
    char [4539][13];
    char [4546][33];
    char [4567][23];
    char [457e][23];
    char [4595][13];
    char [45a2][43];
    char [45cd][33];
    char [45ee][33];
    char [460f][23];
    char [4626][14];
    char [4634][9];
    char [463d][10];
    char [4647][9];
    char [4650][7];
    char [4657][48];
    char [4687][38];
    char [46ad][38];
    char [46d3][28];
    char [46ef][53];
    char [4724][43];
    char [474f][33];
    char [4770][29];
    char [478d][19];
    char [47a0][9];
    char [47a9][44];
    char [47d5][34];
    char [47f7][34];
    char [4819][24];
    char [4831][38];
    char [4857][28];
    char [4873][28];
    char [488f][18];
    char [48a1][26];
    char [48bb][16];
    char [48cb][6];
    char [48d1][49];
    char [4902][39];
    char [4929][39];
    char [4950][29];
    char [496d][30];
    char [498b][20];
    char [499f][10];
    char [49a9][46];
    char [49d7][36];
    char [49fb][36];
    char [4a1f][26];
    char [4a39][47];
    char [4a68][37];
    char [4a8d][37];
    char [4ab2][27];
    char [4acd][55];
    char [4b04][45];
    char [4b31][35];
    char [4b54][42];
    char [4b7e][32];
    char [4b9e][32];
    char [4bbe][22];
    char [4bd4][27];
    char [4bef][17];
    char [4c00][17];
    char [4c11][7];
    char [4c18][41];
    char [4c41][31];
    char [4c60][31];
    char [4c7f][21];
    char [4c94][11];
    char [4c9f][22];
    char [4cb5][42];
    char [4cdf][32];
    char [4cff][32];
    char [4d1f][22];
    char [4d35][42];
    char [4d5f][32];
    char [4d7f][32];
    char [4d9f][22];
    char [4db5][26];
    char [4dcf][16];
    char [4ddf][6];
    char [4de5][37];
    char [4e0a][27];
    char [4e25][27];
    char [4e40][17];
    char [4e51][9];
    char [4e5a][8];
    char [4e62][15];
    char [4e71][9];
    char [4e7a][17];
    char [4e8b][28];
    char [4ea7][14];
    char [4eb5][21];
    char [4eca][7];
    char [4ed1][16];
    char [4ee1][21];
    char [4ef6][19];
    char [4f09][15];
    char [4f18][28];
    char [4f34][15];
    char [4f43][7];
    char [4f4a][17];
    char [4f5b][18];
    char [4f6d][23];
    char [4f84][14];
    char [4f92][31];
    char [4fb1][14];
    char [4fbf][11];
    char [4fca][18];
    char [4fdc][6];
    char [4fe2][5];
    char [4fe7][25];
    char [5000][13];
    char [500d][19];
    char [5020][9];
    char [5029][14];
    char [5037][21];
    char [504c][12];
    char [5058][30];
    char [5076][15];
    char [5085][8];
    char [508d][20];
    char [50a1][12];
    char [50ad][20];
    char [50c1][13];
    char [50ce][5];
    char [50d3][25];
    char [50ec][4];
    char [50f0][14];
    char [50fe][6];
    char [5104][11];
    char [510f][9];
    char [5118][15];
    char [5127][7];
    char [512e][5];
    char [5133][9];
    char [513c][8];
    char [5144][10];
    char [514e][6];
    char [5154][5];
    char [5159][5];
    char [515e][4];
    char [5162][6];
    char [5168][9];
    char [5171][5];
    char [5176][5];
    char [517b][8];
    char [5183][9];
    char [518c][4];
    char [5190][4];
    char [5194][5];
    char [5199][7];
    char [51a0][15];
    char [51af][16];
    char [51bf][10];
    char [51c9][6];
    char [51cf][11];
    char [51da][3];
    char [51dd][3];
    char [51e0][11];
    char [51eb][12];
    char [51f7][6];
    char [51fd][5];
    char [5202][14];
    char [5210][13];
    char [521d][9];
    char [5226][9];
    char [522f][13];
    char [523c][14];
    char [524a][10];
    char [5254][9];
    char [525d][9];
    char [5266][10];
    char [5270][14];
    char [527e][14];
    char [528c][10];
    char [5296][10];
    char [52a0][10];
    char [52aa][10];
    char [52b4][11];
    char [52bf][11];
    char [52ca][7];
    char [52d1][7];
    char [52d8][7];
    char [52df][7];
    char [52e6][15];
    char [52f5][13];
    char [5302][9];
    char [530b][11];
    char [5316][11];
    char [5321][9];
    char [532a][11];
    char [5335][7];
    char [533c][7];
    char [5343][17];
    char [5354][20];
    char [5368][16];
    char [5378][13];
    char [5385][13];
    char [5392][16];
    char [53a2][10];
    char [53ac][8];
    char [53b4][4];
    char [53b8][6];
    char [53be][6];
    char [53c4][4];
    char [53c8][14];
    char [53d6][15];
    char [53e5][11];
    char [53f0][10];
    char [53fa][10];
    char [5404][11];
    char [540f][10];
    char [5419][13];
    char [5426][12];
    char [5432][16];
    char [5442][11];
    char [544d][10];
    char [5457][6];
    char [545d][13];
    char [546a][9];
    char [5473][12];
    char [547f][8];
    char [5487][16];
    char [5497][12];
    char [54a3][11];
    char [54ae][7];
    char [54b5][12];
    char [54c1][9];
    char [54ca][5];
    char [54cf][8];
    char [54d7][8];
    char [54df][5];
    char [54e4][20];
    char [54f8][18];
    char [550a][14];
    char [5518][16];
    char [5528][16];
    char [5538][14];
    char [5546][10];
    char [5550][11];
    char [555b][3];
    char [555e][10];
    char [5568][6];
    char [556e][8];
    char [5576][4];
    char [557a][4];
    char [557e][6];
    char [5584][6];
    char [558a][2];
    char [558c][2];
    char [558e][2];
    char [5590][2];
    char [5592][12];
    char [559e][16];
    char [55ae][12];
    char [55ba][8];
    char [55c2][8];
    char [55ca][12];
    char [55d6][20];
    char [55ea][13];
    char [55f7][19];
    char [560a][22];
    char [5620][9];
    char [5629][5];
    char [562e][18];
    char [5640][15];
    char [564f][16];
    char [565f][16];
    char [566f][9];
    char [5678][15];
    char [5687][18];
    char [5699][5];
    char [569e][10];
    char [56a8][6];
    char [56ae][6];
    char [56b4][6];
    char [56ba][2];
    char [56bc][2];
    char [56be][9];
    char [56c7][5];
    char [56cc][5];
    char [56d1][10];
    char [56db][6];
    char [56e1][6];
    char [56e7][13];
    char [56f4][9];
    char [56fd][9];
    char [5706][9];
    char [570f][9];
    char [5718][7];
    char [571f][4];
    char [5723][6];
    char [5729][7];
    char [5730][6];
    char [5736][18];
    char [5748][17];
    char [5759][13];
    char [5766][9];
    char [576f][9];
    char [5778][13];
    char [5785][9];
    char [578e][9];
    char [5797][8];
    char [579f][5];
    char [57a4][7];
    char [57ab][7];
    char [57b2][13];
    char [57bf][9];
    char [57c8][9];
    char [57d1][8];
    char [57d9][15];
    char [57e8][11];
    char [57f3][4];
    char [57f7][8];
    char [57ff][15];
    char [580e][11];
    char [5819][10];
    char [5823][18];
    char [5835][15];
    char [5844][12];
    char [5850][12];
    char [585c][8];
    char [5864][8];
    char [586c][8];
    char [5874][8];
    char [587c][8];
    char [5884][18];
    char [5896][15];
    char [58a5][10];
    char [58af][5];
    char [58b4][5];
    char [58b9][8];
    char [58c1][14];
    char [58cf][10];
    char [58d9][10];
    char [58e3][16];
    char [58f3][11];
    char [58fe][8];
    char [5906][12];
    char [5912][8];
    char [591a][4];
    char [591e][7];
    char [5925][12];
    char [5931][6];
    char [5937][6];
    char [593d][6];
    char [5943][6];
    char [5949][12];
    char [5955][7];
    char [595c][4];
    char [5960][8];
    char [5968][11];
    char [5973][7];
    char [597a][7];
    char [5981][15];
    char [5990][11];
    char [599b][11];
    char [59a6][18];
    char [59b8][28];
    char [59d4][24];
    char [59ec][14];
    char [59fa][24];
    char [5a12][11];
    char [5a1d][12];
    char [5a29][19];
    char [5a3c][14];
    char [5a4a][10];
    char [5a54][8];
    char [5a5c][7];
    char [5a63][8];
    char [5a6b][15];
    char [5a7a][10];
    char [5a84][12];
    char [5a90][15];
    char [5a9f][13];
    char [5aac][22];
    char [5ac2][19];
    char [5ad5][23];
    char [5aec][15];
    char [5afb][11];
    char [5b06][19];
    char [5b19][15];
    char [5b28][18];
    char [5b3a][9];
    char [5b43][11];
    char [5b4e][8];
    char [5b56][8];
    char [5b5e][11];
    char [5b69][9];
    char [5b72][18];
    char [5b84][15];
    char [5b93][19];
    char [5ba6][11];
    char [5bb1][12];
    char [5bbd][10];
    char [5bc7][6];
    char [5bcd][8];
    char [5bd5][6];
    char [5bdb][13];
    char [5be8][15];
    char [5bf7][25];
    char [5c10][21];
    char [5c25][11];
    char [5c30][9];
    char [5c39][11];
    char [5c44][21];
    char [5c59][13];
    char [5c66][10];
    char [5c70][6];
    char [5c76][9];
    char [5c7f][9];
    char [5c88][6];
    char [5c8e][9];
    char [5c97][20];
    char [5cab][13];
    char [5cb8][9];
    char [5cc1][16];
    char [5cd1][5];
    char [5cd6][5];
    char [5cdb][16];
    char [5ceb][9];
    char [5cf4][12];
    char [5d00][16];
    char [5d10][10];
    char [5d1a][15];
    char [5d29][21];
    char [5d3e][18];
    char [5d50][14];
    char [5d5e][17];
    char [5d6f][6];
    char [5d75][12];
    char [5d81][8];
    char [5d89][8];
    char [5d91][12];
    char [5d9d][6];
    char [5da3][11];
    char [5dae][17];
    char [5dbf][14];
    char [5dcd][14];
    char [5ddb][12];
    char [5de7][8];
    char [5def][10];
    char [5df9][10];
    char [5e03][8];
    char [5e0b][13];
    char [5e18][12];
    char [5e24][8];
    char [5e2c][9];
    char [5e35][9];
    char [5e3e][8];
    char [5e46][11];
    char [5e51][10];
    char [5e5b][7];
    char [5e62][6];
    char [5e68][14];
    char [5e76][10];
    char [5e80][10];
    char [5e8a][13];
    char [5e97][15];
    char [5ea6][13];
    char [5eb3][22];
    char [5ec9][18];
    char [5edb][9];
    char [5ee4][9];
    char [5eed][9];
    char [5ef6][11];
    char [5f01][9];
    char [5f0a][18];
    char [5f1c][15];
    char [5f2b][11];
    char [5f36][7];
    char [5f3d][11];
    char [5f48][11];
    char [5f53][7];
    char [5f5a][13];
    char [5f67][9];
    char [5f70][9];
    char [5f79][20];
    char [5f8d][21];
    char [5fa2][21];
    char [5fb7][13];
    char [5fc4][15];
    char [5fd3][23];
    char [5fea][19];
    char [5ffd][11];
    char [6008][17];
    char [6019][9];
    char [6022][11];
    char [602d][19];
    char [6040][12];
    char [604c][13];
    char [6059][16];
    char [6069][11];
    char [6074][16];
    char [6084][22];
    char [609a][14];
    char [60a8][13];
    char [60b5][26];
    char [60cf][22];
    char [60e5][19];
    char [60f8][25];
    char [6111][13];
    char [611e][22];
    char [6134][10];
    char [613e][18];
    char [6150][7];
    char [6157][12];
    char [6163][9];
    char [616c][8];
    char [6174][7];
    char [617b][16];
    char [618b][21];
    char [61a0][19];
    char [61b3][24];
    char [61cb][19];
    char [61de][19];
    char [61f1][15];
    char [6200][15];
    char [620f][5];
    char [6214][6];
    char [621a][5];
    char [621f][5];
    char [6224][14];
    char [6232][15];
    char [6241][21];
    char [6256][28];
    char [6272][14];
    char [6280][21];
    char [6295][7];
    char [629c][8];
    char [62a4][7];
    char [62ab][30];
    char [62c9][4];
    char [62cd][8];
    char [62d5][9];
    char [62de][11];
    char [62e9][12];
    char [62f5][5];
    char [62fa][6];
    char [6300][9];
    char [6309][10];
    char [6313][9];
    char [631c][10];
    char [6326][10];
    char [6330][11];
    char [633b][16];
    char [634b][16];
    char [635b][11];
    char [6366][11];
    char [6371][9];
    char [637a][10];
    char [6384][7];
    char [638b][16];
    char [639b][20];
    char [63af][13];
    char [63bc][13];
    char [63c9][12];
    char [63d5][12];
    char [63e1][9];
    char [63ea][11];
    char [63f5][14];
    char [6403][15];
    char [6412][6];
    char [6418][7];
    char [641f][6];
    char [6425][8];
    char [642d][5];
    char [6432][6];
    char [6438][5];
    char [643d][9];
    char [6446][17];
    char [6457][8];
    char [645f][8];
    char [6467][7];
    char [646e][7];
    char [6475][14];
    char [6483][8];
    char [648b][8];
    char [6493][9];
    char [649c][9];
    char [64a5][14];
    char [64b3][14];
    char [64c1][10];
    char [64cb][11];
    char [64d6][12];
    char [64e2][10];
    char [64ec][8];
    char [64f4][9];
    char [64fd][9];
    char [6506][9];
    char [650f][6];
    char [6515][15];
    char [6524][9];
    char [652d][11];
    char [6538][7];
    char [653f][5];
    char [6544][12];
    char [6550][11];
    char [655b][11];
    char [6566][9];
    char [656f][9];
    char [6578][9];
    char [6581][10];
    char [658b][6];
    char [6591][6];
    char [6597][12];
    char [65a3][12];
    char [65af][8];
    char [65b7][8];
    char [65bf][10];
    char [65c9][18];
    char [65db][10];
    char [65e5][11];
    char [65f0][9];
    char [65f9][5];
    char [65fe][7];
    char [6605][6];
    char [660b][6];
    char [6611][7];
    char [6618][17];
    char [6629][20];
    char [663d][15];
    char [664c][9];
    char [6655][4];
    char [6659][10];
    char [6663][20];
    char [6677][12];
    char [6683][11];
    char [668e][10];
    char [6698][9];
    char [66a1][10];
    char [66ab][8];
    char [66b3][20];
    char [66c7][15];
    char [66d6][12];
    char [66e2][21];
    char [66f7][7];
    char [66fe][6];
    char [6704][12];
    char [6710][11];
    char [671b][12];
    char [6727][16];
    char [6737][8];
    char [673f][26];
    char [6759][7];
    char [6760][10];
    char [676a][10];
    char [6774][6];
    char [677a][7];
    char [6781][17];
    char [6792][16];
    char [67a2][12];
    char [67ae][13];
    char [67bb][13];
    char [67c8][12];
    char [67d4][10];
    char [67de][7];
    char [67e5][6];
    char [67eb][9];
    char [67f4][5];
    char [67f9][5];
    char [67fe][10];
    char [6808][6];
    char [680e][6];
    char [6814][19];
    char [6827][24];
    char [683f][20];
    char [6853][15];
    char [6862][15];
    char [6871][20];
    char [6885][10];
    char [688f][11];
    char [689a][10];
    char [68a4][6];
    char [68aa][10];
    char [68b4][13];
    char [68c1][9];
    char [68ca][6];
    char [68d0][10];
    char [68da][6];
    char [68e0][13];
    char [68ed][9];
    char [68f6][4];
    char [68fa][7];
    char [6901][6];
    char [6907][7];
    char [690e][13];
    char [691b][13];
    char [6928][16];
    char [6938][19];
    char [694b][15];
    char [695a][21];
    char [696f][7];
    char [6976][14];
    char [6984][12];
    char [6990][13];
    char [699d][13];
    char [69aa][10];
    char [69b4][17];
    char [69c5][8];
    char [69cd][10];
    char [69d7][13];
    char [69e4][25];
    char [69fd][6];
    char [6a03][13];
    char [6a10][13];
    char [6a1d][21];
    char [6a32][12];
    char [6a3e][22];
    char [6a54][22];
    char [6a6a][18];
    char [6a7c][18];
    char [6a8e][8];
    char [6a96][17];
    char [6aa7][9];
    char [6ab0][9];
    char [6ab9][9];
    char [6ac2][9];
    char [6acb][17];
    char [6adc][8];
    char [6ae4][18];
    char [6af6][18];
    char [6b08][18];
    char [6b1a][19];
    char [6b2d][14];
    char [6b3b][15];
    char [6b4a][18];
    char [6b5c][23];
    char [6b73][21];
    char [6b88][18];
    char [6b9a][16];
    char [6baa][12];
    char [6bb6][18];
    char [6bc8][15];
    char [6bd7][20];
    char [6beb][28];
    char [6c07][21];
    char [6c1c][18];
    char [6c2e][27];
    char [6c49][31];
    char [6c68][20];
    char [6c7c][24];
    char [6c94][7];
    char [6c9b][28];
    char [6cb7][16];
    char [6cc7][8];
    char [6ccf][12];
    char [6cdb][21];
    char [6cf0][17];
    char [6d01][20];
    char [6d15][22];
    char [6d2b][18];
    char [6d3d][16];
    char [6d4d][17];
    char [6d5e][13];
    char [6d6b][13];
    char [6d78][12];
    char [6d84][12];
    char [6d90][13];
    char [6d9d][9];
    char [6da6][15];
    char [6db5][15];
    char [6dc4][11];
    char [6dcf][11];
    char [6dda][11];
    char [6de5][11];
    char [6df0][19];
    char [6e03][15];
    char [6e12][15];
    char [6e21][17];
    char [6e32][19];
    char [6e45][16];
    char [6e55][11];
    char [6e60][8];
    char [6e68][5];
    char [6e6d][7];
    char [6e74][9];
    char [6e7d][11];
    char [6e88][18];
    char [6e9a][11];
    char [6ea5][20];
    char [6eb9][28];
    char [6ed5][24];
    char [6eed][25];
    char [6f06][23];
    char [6f1d][26];
    char [6f37][31];
    char [6f56][25];
    char [6f6f][10];
    char [6f79][18];
    char [6f8b][25];
    char [6fa4][19];
    char [6fb7][23];
    char [6fce][13];
    char [6fdb][13];
    char [6fe8][22];
    char [6ffe][23];
    char [7015][23];
    char [702c][19];
    char [703f][26];
    char [7059][15];
    char [7068][11];
    char [7073][22];
    char [7089][19];
    char [709c][9];
    char [70a5][14];
    char [70b3][5];
    char [70b8][13];
    char [70c5][7];
    char [70cc][4];
    char [70d0][3];
    char [70d3][13];
    char [70e0][10];
    char [70ea][14];
    char [70f8][9];
    char [7101][14];
    char [710f][14];
    char [711d][11];
    char [7128][28];
    char [7144][18];
    char [7156][31];
    char [7175][7];
    char [717c][10];
    char [7186][10];
    char [7190][10];
    char [719a][15];
    char [71a9][11];
    char [71b4][6];
    char [71ba][6];
    char [71c0][6];
    char [71c6][6];
    char [71cc][11];
    char [71d7][21];
    char [71ec][6];
    char [71f2][21];
    char [7207][22];
    char [721d][21];
    char [7232][18];
    char [7244][14];
    char [7252][18];
    char [7264][17];
    char [7275][9];
    char [727e][9];
    char [7287][14];
    char [7295][13];
    char [72a2][13];
    char [72af][9];
    char [72b8][9];
    char [72c1][12];
    char [72cd][11];
    char [72d8][9];
    char [72e1][11];
    char [72ec][8];
    char [72f4][6];
    char [72fa][7];
    char [7301][11];
    char [730c][7];
    char [7313][7];
    char [731a][11];
    char [7325][6];
    char [732b][11];
    char [7336][7];
    char [733d][23];
    char [7354][23];
    char [736b][19];
    char [737e][14];
    char [738c][14];
    char [739a][10];
    char [73a4][13];
    char [73b1][13];
    char [73be][9];
    char [73c7][24];
    char [73df][24];
    char [73f7][20];
    char [740b][20];
    char [741f][9];
    char [7428][10];
    char [7432][19];
    char [7445][21];
    char [745a][13];
    char [7467][10];
    char [7471][11];
    char [747c][9];
    char [7485][5];
    char [748a][7];
    char [7491][7];
    char [7498][24];
    char [74b0][4];
    char [74b4][15];
    char [74c3][19];
    char [74d6][9];
    char [74df][9];
    char [74e8][13];
    char [74f5][13];
    char [7502][15];
    char [7511][11];
    char [751c][9];
    char [7525][9];
    char [752e][11];
    char [7539][10];
    char [7543][14];
    char [7551][21];
    char [7566][10];
    char [7570][16];
    char [7580][19];
    char [7593][15];
    char [75a2][11];
    char [75ad][12];
    char [75b9][12];
    char [75c5][8];
    char [75cd][8];
    char [75d5][11];
    char [75e0][11];
    char [75eb][7];
    char [75f2][14];
    char [7600][14];
    char [760e][10];
    char [7618][13];
    char [7625][13];
    char [7632][9];
    char [763b][15];
    char [764a][12];
    char [7656][18];
    char [7668][16];
    char [7678][13];
    char [7685][9];
    char [768e][10];
    char [7698][7];
    char [769f][8];
    char [76a7][7];
    char [76ae][17];
    char [76bf][19];
    char [76d2][19];
    char [76e5][19];
    char [76f8][10];
    char [7702][18];
    char [7714][25];
    char [772d][17];
    char [773e][16];
    char [774e][23];
    char [7765][21];
    char [777a][13];
    char [7787][12];
    char [7793][19];
    char [77a6][11];
    char [77b1][10];
    char [77bb][14];
    char [77c9][9];
    char [77d2][17];
    char [77e3][12];
    char [77ef][19];
    char [7802][13];
    char [780f][8];
    char [7817][19];
    char [782a][18];
    char [783c][14];
    char [784a][7];
    char [7851][16];
    char [7861][14];
    char [786f][16];
    char [787f][22];
    char [7895][19];
    char [78a8][15];
    char [78b7][11];
    char [78c2][17];
    char [78d3][14];
    char [78e1][14];
    char [78ef][10];
    char [78f9][10];
    char [7903][13];
    char [7910][17];
    char [7921][13];
    char [792e][14];
    char [793c][10];
    char [7946][14];
    char [7954][10];
    char [795e][13];
    char [796b][11];
    char [7976][7];
    char [797d][9];
    char [7986][9];
    char [798f][7];
    char [7996][13];
    char [79a3][10];
    char [79ad][6];
    char [79b3][9];
    char [79bc][13];
    char [79c9][9];
    char [79d2][10];
    char [79dc][6];
    char [79e2][18];
    char [79f4][14];
    char [7a02][14];
    char [7a10][15];
    char [7a1f][20];
    char [7a33][16];
    char [7a43][11];
    char [7a4e][11];
    char [7a59][16];
    char [7a69][11];
    char [7a74][7];
    char [7a7b][7];
    char [7a82][10];
    char [7a8c][17];
    char [7a9d][17];
    char [7aae][13];
    char [7abb][13];
    char [7ac8][6];
    char [7ace][6];
    char [7ad4][13];
    char [7ae1][13];
    char [7aee][9];
    char [7af7][5];
    char [7afc][5];
    char [7b01][16];
    char [7b11][9];
    char [7b1a][26];
    char [7b34][27];
    char [7b4f][10];
    char [7b59][12];
    char [7b65][12];
    char [7b71][16];
    char [7b81][12];
    char [7b8d][8];
    char [7b95][8];
    char [7b9d][6];
    char [7ba3][12];
    char [7baf][5];
    char [7bb4][22];
    char [7bca][23];
    char [7be1][6];
    char [7be7][8];
    char [7bef][8];
    char [7bf7][12];
    char [7c03][14];
    char [7c11][10];
    char [7c1b][10];
    char [7c25][7];
    char [7c2c][9];
    char [7c35][12];
    char [7c41][9];
    char [7c4a][10];
    char [7c54][12];
    char [7c60][8];
    char [7c68][6];
    char [7c6e][5];
    char [7c73][5];
    char [7c78][6];
    char [7c7e][8];
    char [7c86][7];
    char [7c8d][10];
    char [7c97][10];
    char [7ca1][6];
    char [7ca7][6];
    char [7cad][6];
    char [7cb3][6];
    char [7cb9][17];
    char [7cca][13];
    char [7cd7][17];
    char [7ce8][17];
    char [7cf9][17];
    char [7d0a][18];
    char [7d1c][19];
    char [7d2f][20];
    char [7d43][19];
    char [7d56][16];
    char [7d66][22];
    char [7d7c][16];
    char [7d8c][16];
    char [7d9c][12];
    char [7da8][16];
    char [7db8][16];
    char [7dc8][12];
    char [7dd4][14];
    char [7de2][14];
    char [7df0][10];
    char [7dfa][13];
    char [7e07][13];
    char [7e14][9];
    char [7e1d][9];
    char [7e26][10];
    char [7e30][12];
    char [7e3c][12];
    char [7e48][11];
    char [7e53][11];
    char [7e5e][7];
    char [7e65][17];
    char [7e76][17];
    char [7e87][13];
    char [7e94][9];
    char [7e9d][9];
    char [7ea6][5];
    char [7eab][5];
    char [7eb0][7];
    char [7eb7][14];
    char [7ec5][14];
    char [7ed3][10];
    char [7edd][8];
    char [7ee5][6];
    char [7eeb][6];
    char [7ef1][17];
    char [7f02][10];
    char [7f0c][16];
    char [7f1c][8];
    char [7f24][14];
    char [7f32][19];
    char [7f45][17];
    char [7f56][17];
    char [7f67][13];
    char [7f74][13];
    char [7f81][15];
    char [7f90][10];
    char [7f9a][4];
    char [7f9e][12];
    char [7faa][13];
    char [7fb7][9];
    char [7fc0][15];
    char [7fcf][11];
    char [7fda][14];
    char [7fe8][5];
    char [7fed][16];
    char [7ffd][16];
    char [800d][24];
    char [8025][12];
    char [8031][12];
    char [803d][8];
    char [8045][19];
    char [8058][19];
    char [806b][15];
    char [807a][10];
    char [8084][13];
    char [8091][13];
    char [809e][12];
    char [80aa][18];
    char [80bc][20];
    char [80d0][20];
    char [80e4][16];
    char [80f4][18];
    char [8106][10];
    char [8110][7];
    char [8117][15];
    char [8126][18];
    char [8138][15];
    char [8147][16];
    char [8157][14];
    char [8165][15];
    char [8174][8];
    char [817c][10];
    char [8186][19];
    char [8199][18];
    char [81ab][17];
    char [81bc][5];
    char [81c1][14];
    char [81cf][15];
    char [81de][11];
    char [81e9][11];
    char [81f4][9];
    char [81fd][8];
    char [8205][12];
    char [8211][13];
    char [821e][17];
    char [822f][17];
    char [8240][17];
    char [8251][17];
    char [8262][11];
    char [826d][12];
    char [8279][13];
    char [8286][21];
    char [829b][17];
    char [82ac][18];
    char [82be][24];
    char [82d6][16];
    char [82e6][21];
    char [82fb][21];
    char [8310][17];
    char [8321][24];
    char [8339][24];
    char [8351][20];
    char [8365][26];
    char [837f][26];
    char [8399][22];
    char [83af][24];
    char [83c7][24];
    char [83df][20];
    char [83f3][26];
    char [840d][26];
    char [8427][22];
    char [843d][12];
    char [8449][12];
    char [8455][8];
    char [845d][17];
    char [846e][14];
    char [847c][20];
    char [8490][18];
    char [84a2][15];
    char [84b1][21];
    char [84c6][15];
    char [84d5][12];
    char [84e1][22];
    char [84f7][11];
    char [8502][22];
    char [8518][20];
    char [852c][22];
    char [8542][20];
    char [8556][17];
    char [8567][20];
    char [857b][9];
    char [8584][12];
    char [8590][5];
    char [8595][10];
    char [859f][7];
    char [85a6][10];
    char [85b0][4];
    char [85b4][8];
    char [85bc][11];
    char [85c7][8];
    char [85cf][12];
    char [85db][8];
    char [85e3][6];
    char [85e9][10];
    char [85f3][6];
    char [85f9][5];
    char [85fe][9];
    char [8607][7];
    char [860e][13];
    char [861b][10];
    char [8625][9];
    char [862e][12];
    char [863a][6];
    char [8640][7];
    char [8647][9];
    char [8650][5];
    char [8655][5];
    char [865a][6];
    char [8660][8];
    char [8668][8];
    char [8670][8];
    char [8678][3];
    char [867b][12];
    char [8687][4];
    char [868b][7];
    char [8692][6];
    char [8698][11];
    char [86a3][7];
    char [86aa][7];
    char [86b1][7];
    char [86b8][8];
    char [86c0][14];
    char [86ce][11];
    char [86d9][14];
    char [86e7][12];
    char [86f3][14];
    char [8701][14];
    char [870f][10];
    char [8719][16];
    char [8729][12];
    char [8735][10];
    char [873f][13];
    char [874c][11];
    char [8757][10];
    char [8761][11];
    char [876c][19];
    char [877f][19];
    char [8792][15];
    char [87a1][15];
    char [87b0][15];
    char [87bf][15];
    char [87ce][11];
    char [87d9][14];
    char [87e7][14];
    char [87f5][10];
    char [87ff][10];
    char [8809][11];
    char [8814][11];
    char [881f][6];
    char [8825][19];
    char [8838][19];
    char [884b][15];
    char [885a][17];
    char [886b][17];
    char [887c][13];
    char [8889][17];
    char [889a][17];
    char [88ab][13];
    char [88b8][7];
    char [88bf][5];
    char [88c4][10];
    char [88ce][7];
    char [88d5][8];
    char [88dd][9];
    char [88e6][7];
    char [88ed][20];
    char [8901][23];
    char [8918][13];
    char [8925][13];
    char [8932][15];
    char [8941][17];
    char [8952][10];
    char [895c][6];
    char [8962][13];
    char [896f][13];
    char [897c][19];
    char [898f][15];
    char [899e][15];
    char [89ad][10];
    char [89b7][6];
    char [89bd][6];
    char [89c3][9];
    char [89cc][12];
    char [89d8][8];
    char [89e0][5];
    char [89e5][8];
    char [89ed][11];
    char [89f8][7];
    char [89ff][9];
    char [8a08][5];
    char [8a0d][5];
    char [8a12][20];
    char [8a26][19];
    char [8a39][15];
    char [8a48][16];
    char [8a58][16];
    char [8a68][15];
    char [8a77][10];
    char [8a81][6];
    char [8a87][6];
    char [8a8d][18];
    char [8a9f][14];
    char [8aad][14];
    char [8abb][9];
    char [8ac4][9];
    char [8acd][13];
    char [8ada][15];
    char [8ae9][11];
    char [8af4][9];
    char [8afd][5];
    char [8b02][9];
    char [8b0b][5];
    char [8b10][13];
    char [8b1d][9];
    char [8b26][15];
    char [8b35][11];
    char [8b40][9];
    char [8b49][5];
    char [8b4e][10];
    char [8b58][13];
    char [8b65][9];
    char [8b6e][6];
    char [8b74][6];
    char [8b7a][9];
    char [8b83][16];
    char [8b93][12];
    char [8b9f][15];
    char [8bae][11];
    char [8bb9][11];
    char [8bc4][16];
    char [8bd4][18];
    char [8be6][14];
    char [8bf4][12];
    char [8c00][12];
    char [8c0c][14];
    char [8c1a][13];
    char [8c27][9];
    char [8c30][9];
    char [8c39][20];
    char [8c4d][25];
    char [8c66][23];
    char [8c7d][28];
    char [8c99][11];
    char [8ca4][8];
    char [8cac][11];
    char [8cb7][12];
    char [8cc3][13];
    char [8cd0][19];
    char [8ce3][8];
    char [8ceb][20];
    char [8cff][16];
    char [8d0f][14];
    char [8d1d][21];
    char [8d32][7];
    char [8d39][19];
    char [8d4c][14];
    char [8d5a][22];
    char [8d70][5];
    char [8d75][5];
    char [8d7a][16];
    char [8d8a][15];
    char [8d99][24];
    char [8db1][14];
    char [8dbf][27];
    char [8dda][12];
    char [8de6][24];
    char [8dfe][12];
    char [8e0a][17];
    char [8e1b][9];
    char [8e24][17];
    char [8e35][12];
    char [8e41][15];
    char [8e50][19];
    char [8e63][9];
    char [8e6c][8];
    char [8e74][17];
    char [8e85][17];
    char [8e96][7];
    char [8e9d][18];
    char [8eaf][7];
    char [8eb6][27];
    char [8ed1][22];
    char [8ee7][20];
    char [8efb][13];
    char [8f08][11];
    char [8f13][11];
    char [8f1e][7];
    char [8f25][13];
    char [8f32][8];
    char [8f3a][5];
    char [8f3f][12];
    char [8f4b][12];
    char [8f57][11];
    char [8f62][12];
    char [8f6e][12];
    char [8f7a][15];
    char [8f89][16];
    char [8f99][16];
    char [8fa9][14];
    char [8fb7][15];
    char [8fc6][15];
    char [8fd5][26];
    char [8fef][23];
    char [9006][29];
    char [9023][27];
    char [903e][24];
    char [9056][30];
    char [9074][22];
    char [908a][19];
    char [909d][25];
    char [90b6][17];
    char [90c7][20];
    char [90db][19];
    char [90ee][20];
    char [9102][20];
    char [9116][12];
    char [9122][23];
    char [9139][22];
    char [914f][9];
    char [9158][12];
    char [9164][8];
    char [916c][5];
    char [9171][8];
    char [9179][11];
    char [9184][7];
    char [918b][7];
    char [9192][5];
    char [9197][7];
    char [919e][12];
    char [91aa][14];
    char [91b8][21];
    char [91cd][18];
    char [91df][16];
    char [91ef][13];
    char [91fc][7];
    char [9203][11];
    char [920e][12];
    char [921a][8];
    char [9222][8];
    char [922a][15];
    char [9239][12];
    char [9245][11];
    char [9250][13];
    char [925d][13];
    char [926a][13];
    char [9277][8];
    char [927f][11];
    char [928a][9];
    char [9293][9];
    char [929c][9];
    char [92a5][7];
    char [92ac][11];
    char [92b7][8];
    char [92bf][7];
    char [92c6][9];
    char [92cf][9];
    char [92d8][9];
    char [92e1][4];
    char [92e5][6];
    char [92eb][22];
    char [9301][19];
    char [9314][23];
    char [932b][20];
    char [933f][24];
    char [9357][20];
    char [936b][8];
    char [9373][15];
    char [9382][15];
    char [9391][6];
    char [9397][20];
    char [93ab][17];
    char [93bc][20];
    char [93d0][17];
    char [93e1][16];
    char [93f1][13];
    char [93fe][15];
    char [940d][12];
    char [9419][16];
    char [9429][12];
    char [9435][9];
    char [943e][10];
    char [9448][14];
    char [9456][17];
    char [9467][7];
    char [946e][9];
    char [9477][9];
    char [9480][11];
    char [948b][16];
    char [949b][16];
    char [94ab][12];
    char [94b7][19];
    char [94ca][19];
    char [94dd][15];
    char [94ec][13];
    char [94f9][13];
    char [9506][9];
    char [950f][17];
    char [9520][17];
    char [9531][13];
    char [953e][11];
    char [9549][17];
    char [955a][17];
    char [956b][13];
    char [9578][17];
    char [9589][17];
    char [959a][13];
    char [95a7][13];
    char [95b4][13];
    char [95c1][9];
    char [95ca][17];
    char [95db][17];
    char [95ec][13];
    char [95f9][15];
    char [9608][15];
    char [9617][11];
    char [9622][11];
    char [962d][13];
    char [963a][9];
    char [9643][13];
    char [9650][13];
    char [965d][13];
    char [966a][9];
    char [9673][15];
    char [9682][12];
    char [968e][17];
    char [969f][14];
    char [96ad][11];
    char [96b8][8];
    char [96c0][14];
    char [96ce][18];
    char [96e0][14];
    char [96ee][17];
    char [96ff][14];
    char [970d][9];
    char [9716][13];
    char [9723][9];
    char [972c][15];
    char [973b][15];
    char [974a][10];
    char [9754][6];
    char [975a][11];
    char [9765][11];
    char [9770][5];
    char [9775][9];
    char [977e][9];
    char [9787][5];
    char [978c][11];
    char [9797][11];
    char [97a2][6];
    char [97a8][8];
    char [97b0][7];
    char [97b7][11];
    char [97c2][12];
    char [97ce][4];
    char [97d2][8];
    char [97da][7];
    char [97e1][18];
    char [97f3][15];
    char [9802][14];
    char [9810][20];
    char [9824][16];
    char [9834][7];
    char [983b][4];
    char [983f][5];
    char [9844][13];
    char [9851][11];
    char [985c][18];
    char [986e][15];
    char [987d][14];
    char [988b][8];
    char [9893][16];
    char [98a3][9];
    char [98ac][5];
    char [98b1][12];
    char [98bd][12];
    char [98c9][5];
    char [98ce][16];
    char [98de][12];
    char [98ea][12];
    char [98f6][9];
    char [98ff][19];
    char [9912][16];
    char [9922][16];
    char [9932][4];
    char [9936][11];
    char [9941][5];
    char [9946][9];
    char [994f][11];
    char [995a][8];
    char [9962][9];
    char [996b][8];
    char [9973][16];
    char [9983][18];
    char [9995][15];
    char [99a4][11];
    char [99af][25];
    char [99c8][22];
    char [99de][24];
    char [99f6][12];
    char [9a02][24];
    char [9a1a][7];
    char [9a21][20];
    char [9a35][29];
    char [9a52][16];
    char [9a62][13];
    char [9a6f][24];
    char [9a87][22];
    char [9a9d][21];
    char [9ab2][20];
    char [9ac6][21];
    char [9adb][24];
    char [9af3][20];
    char [9b07][24];
    char [9b1f][23];
    char [9b36][20];
    char [9b4a][18];
    char [9b5c][21];
    char [9b71][14];
    char [9b7f][18];
    char [9b91][13];
    char [9b9e][9];
    char [9ba7][9];
    char [9bb0][11];
    char [9bbb][14];
    char [9bc9][10];
    char [9bd3][9];
    char [9bdc][10];
    char [9be6][8];
    char [9bee][11];
    char [9bf9][6];
    char [9bff][5];
    char [9c04][5];
    char [9c09][4];
    char [9c0d][3];
    char [9c10][2];
    char [9c12][2];
    char [9c14][2];
    char [9c16][3];
    char [9c19][4];
    char [9c1d][5];
    char [9c22][4];
    char [9c26][11];
    char [9c31][9];
    char [9c3a][9];
    char [9c43][6];
    char [9c49][7];
    char [9c50][6];
    char [9c56][7];
    char [9c5d][4];
    char [9c61][4];
    char [9c65][8];
    char [9c6d][4];
    char [9c71][8];
    char [9c79][15];
    char [9c88][13];
    char [9c95][10];
    char [9c9f][12];
    char [9cab][9];
    char [9cb4][7];
    char [9cbb][11];
    char [9cc6][8];
    char [9cce][7];
    char [9cd5][8];
    char [9cdd][11];
    char [9ce8][14];
    char [9cf6][19];
    char [9d09][15];
    char [9d18][20];
    char [9d2c][16];
    char [9d3c][16];
    char [9d4c][11];
    char [9d57][20];
    char [9d6b][16];
    char [9d7b][16];
    char [9d8b][15];
    char [9d9a][14];
    char [9da8][10];
    char [9db2][11];
    char [9dbd][11];
    char [9dc8][10];
    char [9dd2][14];
    char [9de0][10];
    char [9dea][10];
    char [9df4][14];
    char [9e02][16];
    char [9e12][12];
    char [9e1e][10];
    char [9e28][10];
    char [9e32][12];
    char [9e3e][15];
    char [9e4d][14];
    char [9e5b][18];
    char [9e6d][10];
    char [9e77][11];
    char [9e82][11];
    char [9e8d][10];
    char [9e97][14];
    char [9ea5][18];
    char [9eb7][14];
    char [9ec5][14];
    char [9ed3][16];
    char [9ee3][12];
    char [9eef][12];
    char [9efb][21];
    char [9f10][17];
    char [9f21][14];
    char [9f2f][15];
    char [9f3e][6];
    char [9f44][6];
    char [9f4a][12];
    char [9f56][11];
    char [9f61][13];
    char [9f6e][13];
    char [9f7b][13];
    char [9f88][17];
    char [9f99][16];
    char [9fa9][25];
    char [9fc2][12];
    char [9fce][13];
    char [9fdb][9];
    char [9fe4][9];
    char [9fed][9];
    char [9ff6][7];
    char [9ffd][8];
    char [a005][12];
    char [a011][7];
    char [a018][10];
    char [a022][10];
    char [a02c][14];
    char [a03a][16];
    char [a04a][15];
    char [a059][12];
    char [a065][15];
    char [a074][11];
    char [a07f][8];
    char [a087][11];
    char [a092][12];
    char [a09e][10];
    char [a0a8][10];
    char [a0b2][12];
    char [a0be][13];
    char [a0cb][11];
    char [a0d6][8];
    char [a0de][11];
    char [a0e9][10];
    char [a0f3][6];
    char [a0f9][8];
    char [a101][7];
    char [a108][6];
    char [a10e][12];
    char [a11a][9];
    char [a123][11];
    char [a12e][8];
    char [a136][9];
    char [a13f][5];
    char [a144][7];
    char [a14b][7];
    char [a152][9];
    char [a15b][21];
    char [a170][15];
    char [a17f][16];
    char [a18f][15];
    char [a19e][11];
    char [a1a9][12];
    char [a1b5][11];
    char [a1c0][17];
    char [a1d1][17];
    char [a1e2][11];
    char [a1ed][12];
    char [a1f9][11];
    char [a204][10];
    char [a20e][6];
    char [a214][6];
    char [a21a][20];
    char [a22e][9];
    char [a237][11];
    char [a242][8];
    char [a24a][11];
    char [a255][4];
    char [a259][7];
    char [a260][5];
    char [a265][16];
    char [a275][16];
    char [a285][5];
    char [a28a][7];
    char [a291][4];
    char [a295][7];
    char [a29c][22];
    char [a2b2][9];
    char [a2bb][7];
    char [a2c2][3];
    char [a2c5][18];
    char [a2d7][18];
    char [a2e9][5];
    char [a2ee][3];
    char [a2f1][9];
    char [a2fa][15];
    char [a309][11];
    char [a314][5];
    char [a319][5];
    char [a31e][11];
    char [a329][19];
    char [a33c][15];
    char [a34b][15];
    char [a35a][8];
    char [a362][12];
    char [a36e][18];
    char [a380][11];
    char [a38b][17];
    char [a39c][14];
    char [a3aa][13];
    char [a3b7][11];
    char [a3c2][11];
    char [a3cd][15];
    char [a3dc][12];
    char [a3e8][8];
    char [a3f0][11];
    char [a3fb][7];
    char [a402][9];
    char [a40b][7];
    char [a412][4];
    char [a416][8];
    char [a41e][14];
    char [a42c][7];
    char [a433][13];
    char [a440][10];
    char [a44a][9];
    char [a453][7];
    char [a45a][7];
    char [a461][11];
    char [a46c][8];
    char [a474][9];
    char [a47d][5];
    char [a482][9];
    char [a48b][9];
    char [a494][7];
    char [a49b][8];
    char [a4a3][13];
    char [a4b0][15];
    char [a4bf][11];
    char [a4ca][6];
    char [a4d0][8];
    char [a4d8][5];
    char [a4dd][7];
    char [a4e4][10];
    char [a4ee][8];
    char [a4f6][4];
    char [a4fa][9];
    char [a503][7];
    char [a50a][7];
    char [a511][8];
    char [a519][10];
    char [a523][9];
    char [a52c][7];
    char [a533][9];
    char [a53c][9];
    char [a545][8];
    char [a54d][9];
    char [a556][10];
    char [a560][10];
    char [a56a][11];
    char [a575][7];
    char [a57c][9];
    char [a585][14];
    char [a593][10];
    char [a59d][21];
    char [a5b2][24];
    char [a5ca][20];
    char [a5de][17];
    char [a5ef][17];
    char [a600][20];
    char [a614][15];
    char [a623][12];
    char [a62f][10];
    char [a639][6];
    char [a63f][8];
    char [a647][11];
    char [a652][11];
    char [a65d][8];
    char [a665][6];
    char [a66b][12];
    char [a677][11];
    char [a682][7];
    char [a689][8];
    char [a691][7];
    char [a698][17];
    char [a6a9][13];
    char [a6b6][8];
    char [a6be][12];
    char [a6ca][8];
    char [a6d2][8];
    char [a6da][5];
    char [a6df][15];
    char [a6ee][17];
    char [a6ff][13];
    char [a70c][11];
    char [a717][11];
    char [a722][13];
    char [a72f][13];
    char [a73c][9];
    char [a745][14];
    char [a753][11];
    char [a75e][20];
    char [a772][1];
    char [a773][1];
};

typedef struct #~ #~, *P#~;

struct #~ {
    dword Reserved; // Always 0
    byte MajorVersion;
    byte MinorVersion;
    byte HeapSizes; // Bit vector for heap sizes
    byte Reserved; // Always 1
    qword Valid; // Bit vector of present tables
    qword Sorted; // Bit vector of sorted tables
    dword Rows[16]; // # of rows for each corresponding present table
    struct Module Row Module; // CLI Metadata Table: Module
    struct TypeRef Row TypeRef[31]; // CLI Metadata Table: TypeRef
    struct TypeDef Row TypeDef[923]; // CLI Metadata Table: TypeDef
    struct Field Row Field[288]; // CLI Metadata Table: Field
    struct MethodDef Row MethodDef[2472]; // CLI Metadata Table: MethodDef
    struct ParamRow Param[3812]; // CLI Metadata Table: Param
    struct InterfaceImpl Row InterfaceImpl[222]; // CLI Metadata Table: InterfaceImpl
    struct MemberRef Row MemberRef[13]; // CLI Metadata Table: MemberRef
    struct Constant Row Constant[242]; // CLI Metadata Table: Constant
    struct CustomAttribute Row CustomAttribute[4327]; // CLI Metadata Table: CustomAttribute
    struct PropertyMap Row PropertyMap[414]; // CLI Metadata Table: PropertyMap
    struct Property Row Property[1231]; // CLI Metadata Table: Property
    struct MethodSemantics Row MethodSemantics[1324]; // CLI Metadata Table: MethodSemantics
    struct MethodImpl Row MethodImpl[566]; // CLI Metadata Table: MethodImpl
    struct Assembly Table Assembly; // CLI Metadata Table: Assembly
    struct AssemblyRef Row AssemblyRef[4]; // CLI Metadata Table: AssemblyRef
};

typedef struct #Blob #Blob, *P#Blob;

struct #Blob {
    byte Reserved; // Always 0
    struct Blob_Generic_1 [1];
    struct Blob_Generic_10 [a];
    struct Blob_Generic_14 [e];
    struct Blob_MethodRefSig_18 MethodRefSig_18; // Type info for imported method return and params
    struct Blob_Generic_22 [16];
    struct Blob_Generic_27 [1b];
    struct Blob_PropertySig_32 PropertySig_32; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_37 PropertySig_37; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_42 [2a];
    struct Blob_Generic_51 [33];
    struct Blob_PropertySig_59 PropertySig_59; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_63 [3f];
    struct Blob_Generic_71 [47];
    struct Blob_Generic_78 [4e];
    struct Blob_MethodRefSig_84 MethodRefSig_84; // Type info for imported method return and params
    struct Blob_Generic_89 [59];
    struct Blob_Generic_97 [61];
    struct Blob_Generic_105 [69];
    struct Blob_Generic_110 [6e];
    struct Blob_Generic_115 [73];
    struct Blob_PropertySig_124 PropertySig_124; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_133 PropertySig_133; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_138 PropertySig_138; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_143 [8f];
    struct Blob_Generic_160 [a0];
    struct Blob_Generic_167 [a7];
    struct Blob_Generic_174 [ae];
    struct Blob_Generic_190 [be];
    struct Blob_Generic_202 [ca];
    struct Blob_Generic_209 [d1];
    struct Blob_Generic_216 [d8];
    struct Blob_Generic_227 [e3];
    struct Blob_PropertySig_231 PropertySig_231; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_235 [eb];
    struct Blob_Generic_242 [f2];
    struct Blob_Generic_248 [f8];
    struct Blob_PropertySig_253 PropertySig_253; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_258 [102];
    struct Blob_Generic_268 [10c];
    struct Blob_Generic_276 [114];
    struct Blob_PropertySig_280 PropertySig_280; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_284 [11c];
    struct Blob_Generic_293 [125];
    struct Blob_Generic_300 [12c];
    struct Blob_Generic_310 [136];
    struct Blob_PropertySig_319 PropertySig_319; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_328 [148];
    struct Blob_Generic_340 [154];
    struct Blob_Generic_348 [15c];
    struct Blob_Generic_356 [164];
    struct Blob_Generic_366 [16e];
    struct Blob_PropertySig_370 PropertySig_370; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_374 [176];
    struct Blob_Generic_382 [17e];
    struct Blob_Generic_388 [184];
    struct Blob_PropertySig_394 PropertySig_394; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_400 [190];
    struct Blob_Generic_412 [19c];
    struct Blob_Generic_422 [1a6];
    struct Blob_Generic_434 [1b2];
    struct Blob_Generic_442 [1ba];
    struct Blob_Generic_450 [1c2];
    struct Blob_Generic_456 [1c8];
    struct Blob_PropertySig_466 PropertySig_466; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_476 PropertySig_476; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_482 [1e2];
    struct Blob_Generic_498 [1f2];
    struct Blob_Generic_506 [1fa];
    struct Blob_Generic_514 [202];
    struct Blob_Generic_528 [210];
    struct Blob_Generic_534 [216];
    struct Blob_Generic_540 [21c];
    struct Blob_Generic_546 [222];
    struct Blob_PropertySig_552 PropertySig_552; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_558 PropertySig_558; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_564 PropertySig_564; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_570 PropertySig_570; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_576 [240];
    struct Blob_Generic_584 [248];
    struct Blob_Generic_593 [251];
    struct Blob_Generic_602 [25a];
    struct Blob_Generic_611 [263];
    struct Blob_Generic_620 [26c];
    struct Blob_Generic_628 [274];
    struct Blob_Generic_637 [27d];
    struct Blob_Generic_646 [286];
    struct Blob_Generic_655 [28f];
    struct Blob_Generic_664 [298];
    struct Blob_Generic_672 [2a0];
    struct Blob_Generic_680 [2a8];
    struct Blob_Generic_684 [2ac];
    struct Blob_PropertySig_689 PropertySig_689; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_693 [2b5];
    struct Blob_Generic_700 [2bc];
    struct Blob_Generic_708 [2c4];
    struct Blob_Generic_714 [2ca];
    struct Blob_PropertySig_720 PropertySig_720; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_726 [2d6];
    struct Blob_Generic_738 [2e2];
    struct Blob_Generic_748 [2ec];
    struct Blob_Generic_758 [2f6];
    struct Blob_Generic_768 [300];
    struct Blob_Generic_773 [305];
    struct Blob_PropertySig_781 PropertySig_781; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_789 PropertySig_789; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_794 PropertySig_794; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_804 PropertySig_804; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_814 [32e];
    struct Blob_Generic_846 [34e];
    struct Blob_Generic_854 [356];
    struct Blob_Generic_862 [35e];
    struct Blob_Generic_892 [37c];
    struct Blob_Generic_899 [383];
    struct Blob_Generic_907 [38b];
    struct Blob_MethodRefSig_915 MethodRefSig_915; // Type info for imported method return and params
    struct Blob_Generic_920 [398];
    struct Blob_Generic_929 [3a1];
    struct Blob_Generic_936 [3a8];
    struct Blob_Generic_944 [3b0];
    struct Blob_Generic_950 [3b6];
    struct Blob_PropertySig_960 PropertySig_960; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_970 [3ca];
    struct Blob_Generic_984 [3d8];
    struct Blob_Generic_992 [3e0];
    struct Blob_Generic_1000 [3e8];
    struct Blob_Generic_1012 [3f4];
    struct Blob_PropertySig_1016 PropertySig_1016; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1020 [3fc];
    struct Blob_Generic_1028 [404];
    struct Blob_Generic_1034 [40a];
    struct Blob_Generic_1043 [413];
    struct Blob_Generic_1050 [41a];
    struct Blob_Generic_1056 [420];
    struct Blob_Generic_1063 [427];
    struct Blob_Generic_1069 [42d];
    struct Blob_Generic_1079 [437];
    struct Blob_PropertySig_1083 PropertySig_1083; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1087 [43f];
    struct Blob_Generic_1096 [448];
    struct Blob_Generic_1103 [44f];
    struct Blob_PropertySig_1109 PropertySig_1109; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1115 [45b];
    struct Blob_Generic_1125 [465];
    struct Blob_FieldSig_1133 FieldSig_1133; // Type information for Field
    struct Blob_FieldSig_1136 FieldSig_1136; // Type information for Field
    struct Blob_Generic_1141 [475];
    struct Blob_PropertySig_1151 PropertySig_1151; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1161 [489];
    struct Blob_Generic_1179 [49b];
    struct Blob_Generic_1187 [4a3];
    struct Blob_Generic_1195 [4ab];
    struct Blob_Generic_1211 [4bb];
    struct Blob_Generic_1217 [4c1];
    struct Blob_PropertySig_1223 PropertySig_1223; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1229 PropertySig_1229; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1235 [4d3];
    struct Blob_Generic_1244 [4dc];
    struct Blob_Generic_1253 [4e5];
    struct Blob_Generic_1262 [4ee];
    struct Blob_Generic_1271 [4f7];
    struct Blob_Generic_1281 [501];
    struct Blob_Generic_1290 [50a];
    struct Blob_Generic_1297 [511];
    struct Blob_Generic_1308 [51c];
    struct Blob_Generic_1318 [526];
    struct Blob_Generic_1334 [536];
    struct Blob_Generic_1349 [545];
    struct Blob_Generic_1364 [554];
    struct Blob_Generic_1372 [55c];
    struct Blob_Generic_1389 [56d];
    struct Blob_Generic_1397 [575];
    struct Blob_Generic_1405 [57d];
    struct Blob_Generic_1420 [58c];
    struct Blob_Generic_1427 [593];
    struct Blob_Generic_1432 [598];
    struct Blob_Generic_1439 [59f];
    struct Blob_Generic_1445 [5a5];
    struct Blob_PropertySig_1451 PropertySig_1451; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1457 PropertySig_1457; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1463 [5b7];
    struct Blob_Generic_1475 [5c3];
    struct Blob_Generic_1485 [5cd];
    struct Blob_Generic_1495 [5d7];
    struct Blob_Generic_1501 [5dd];
    struct Blob_PropertySig_1511 PropertySig_1511; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1521 PropertySig_1521; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1527 PropertySig_1527; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1537 [601];
    struct Blob_Generic_1562 [61a];
    struct Blob_Generic_1570 [622];
    struct Blob_Generic_1578 [62a];
    struct Blob_Generic_1601 [641];
    struct Blob_Generic_1614 [64e];
    struct Blob_Generic_1625 [659];
    struct Blob_PropertySig_1631 PropertySig_1631; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1637 [665];
    struct Blob_Generic_1647 [66f];
    struct Blob_Generic_1655 [677];
    struct Blob_Generic_1661 [67d];
    struct Blob_Generic_1671 [687];
    struct Blob_PropertySig_1681 PropertySig_1681; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1691 PropertySig_1691; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1701 PropertySig_1701; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1707 [6ab];
    struct Blob_Generic_1730 [6c2];
    struct Blob_Generic_1738 [6ca];
    struct Blob_Generic_1746 [6d2];
    struct Blob_Generic_1767 [6e7];
    struct Blob_PropertySig_1777 PropertySig_1777; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1787 [6fb];
    struct Blob_Generic_1803 [70b];
    struct Blob_Generic_1811 [713];
    struct Blob_Generic_1819 [71b];
    struct Blob_Generic_1833 [729];
    struct Blob_PropertySig_1839 PropertySig_1839; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1845 [735];
    struct Blob_Generic_1860 [744];
    struct Blob_Generic_1873 [751];
    struct Blob_PropertySig_1879 PropertySig_1879; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1885 [75d];
    struct Blob_Generic_1897 [769];
    struct Blob_Generic_1907 [773];
    struct Blob_Generic_1917 [77d];
    struct Blob_Generic_1923 [783];
    struct Blob_PropertySig_1931 PropertySig_1931; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1939 PropertySig_1939; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1945 PropertySig_1945; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1955 [7a3];
    struct Blob_Generic_1983 [7bf];
    struct Blob_Generic_1991 [7c7];
    struct Blob_Generic_1999 [7cf];
    struct Blob_Generic_2025 [7e9];
    struct Blob_Generic_2032 [7f0];
    struct Blob_Generic_2037 [7f5];
    struct Blob_PropertySig_2043 PropertySig_2043; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2049 PropertySig_2049; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2054 [806];
    struct Blob_Generic_2065 [811];
    struct Blob_Generic_2073 [819];
    struct Blob_Generic_2081 [821];
    struct Blob_Generic_2090 [82a];
    struct Blob_Generic_2095 [82f];
    struct Blob_PropertySig_2105 PropertySig_2105; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2115 PropertySig_2115; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2120 [848];
    struct Blob_Generic_2135 [857];
    struct Blob_Generic_2143 [85f];
    struct Blob_Generic_2151 [867];
    struct Blob_Generic_2164 [874];
    struct Blob_Generic_2170 [87a];
    struct Blob_PropertySig_2176 PropertySig_2176; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2182 PropertySig_2182; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2188 [88c];
    struct Blob_Generic_2200 [898];
    struct Blob_Generic_2210 [8a2];
    struct Blob_PropertySig_2220 PropertySig_2220; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2230 [8b6];
    struct Blob_Generic_2243 [8c3];
    struct Blob_Generic_2251 [8cb];
    struct Blob_Generic_2259 [8d3];
    struct Blob_Generic_2270 [8de];
    struct Blob_Generic_2276 [8e4];
    struct Blob_Generic_2286 [8ee];
    struct Blob_PropertySig_2294 PropertySig_2294; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2302 PropertySig_2302; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2312 PropertySig_2312; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2318 [90e];
    struct Blob_Generic_2343 [927];
    struct Blob_Generic_2351 [92f];
    struct Blob_Generic_2359 [937];
    struct Blob_Generic_2382 [94e];
    struct Blob_PropertySig_2387 PropertySig_2387; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2392 [958];
    struct Blob_Generic_2408 [968];
    struct Blob_Generic_2416 [970];
    struct Blob_Generic_2424 [978];
    struct Blob_Generic_2438 [986];
    struct Blob_Generic_2444 [98c];
    struct Blob_PropertySig_2450 PropertySig_2450; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2456 PropertySig_2456; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2462 [99e];
    struct Blob_Generic_2474 [9aa];
    struct Blob_Generic_2482 [9b2];
    struct Blob_Generic_2490 [9ba];
    struct Blob_Generic_2500 [9c4];
    struct Blob_PropertySig_2508 PropertySig_2508; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2516 [9d4];
    struct Blob_Generic_2548 [9f4];
    struct Blob_Generic_2556 [9fc];
    struct Blob_Generic_2564 [a04];
    struct Blob_Generic_2594 [a22];
    struct Blob_Generic_2600 [a28];
    struct Blob_Generic_2610 [a32];
    struct Blob_Generic_2620 [a3c];
    struct Blob_Generic_2630 [a46];
    struct Blob_Generic_2642 [a52];
    struct Blob_Generic_2652 [a5c];
    struct Blob_Generic_2662 [a66];
    struct Blob_Generic_2669 [a6d];
    struct Blob_Generic_2676 [a74];
    struct Blob_PropertySig_2681 PropertySig_2681; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2691 PropertySig_2691; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2701 PropertySig_2701; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2713 PropertySig_2713; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2723 PropertySig_2723; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2733 PropertySig_2733; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_2743 PropertySig_2743; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2749 [abd];
    struct Blob_Generic_2760 [ac8];
    struct Blob_Generic_2770 [ad2];
    struct Blob_Generic_2780 [adc];
    struct Blob_PropertySig_2786 PropertySig_2786; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2792 [ae8];
    struct Blob_Generic_2803 [af3];
    struct Blob_Generic_2812 [afc];
    struct Blob_Generic_2820 [b04];
    struct Blob_PropertySig_2829 PropertySig_2829; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2837 [b15];
    struct Blob_Generic_2848 [b20];
    struct Blob_Generic_2856 [b28];
    struct Blob_Generic_2864 [b30];
    struct Blob_Generic_2886 [b46];
    struct Blob_Generic_2908 [b5c];
    struct Blob_Generic_2929 [b71];
    struct Blob_Generic_2948 [b84];
    struct Blob_Generic_2954 [b8a];
    struct Blob_Generic_2970 [b9a];
    struct Blob_FieldSig_2986 FieldSig_2986; // Type information for Field
    struct Blob_FieldSig_2991 FieldSig_2991; // Type information for Field
    struct Blob_FieldSig_2996 FieldSig_2996; // Type information for Field
    struct Blob_FieldSig_3001 FieldSig_3001; // Type information for Field
    struct Blob_FieldSig_3006 FieldSig_3006; // Type information for Field
    struct Blob_FieldSig_3011 FieldSig_3011; // Type information for Field
    struct Blob_FieldSig_3016 FieldSig_3016; // Type information for Field
    struct Blob_FieldSig_3021 FieldSig_3021; // Type information for Field
    struct Blob_Generic_3026 [bd2];
    struct Blob_Generic_3038 [bde];
    struct Blob_Generic_3046 [be6];
    struct Blob_Generic_3054 [bee];
    struct Blob_Generic_3064 [bf8];
    struct Blob_PropertySig_3074 PropertySig_3074; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3084 [c0c];
    struct Blob_Generic_3097 [c19];
    struct Blob_Generic_3105 [c21];
    struct Blob_Generic_3113 [c29];
    struct Blob_Generic_3124 [c34];
    struct Blob_PropertySig_3130 PropertySig_3130; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3136 [c40];
    struct Blob_Generic_3146 [c4a];
    struct Blob_Generic_3154 [c52];
    struct Blob_Generic_3162 [c5a];
    struct Blob_Generic_3170 [c62];
    struct Blob_PropertySig_3180 PropertySig_3180; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3190 [c76];
    struct Blob_Generic_3203 [c83];
    struct Blob_Generic_3211 [c8b];
    struct Blob_Generic_3219 [c93];
    struct Blob_Generic_3230 [c9e];
    struct Blob_Generic_3244 [cac];
    struct Blob_Generic_3252 [cb4];
    struct Blob_Generic_3260 [cbc];
    struct Blob_Generic_3272 [cc8];
    struct Blob_PropertySig_3282 PropertySig_3282; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3292 [cdc];
    struct Blob_Generic_3305 [ce9];
    struct Blob_Generic_3313 [cf1];
    struct Blob_Generic_3321 [cf9];
    struct Blob_Generic_3332 [d04];
    struct Blob_Generic_3338 [d0a];
    struct Blob_Generic_3344 [d10];
    struct Blob_PropertySig_3350 PropertySig_3350; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_3356 PropertySig_3356; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_3362 PropertySig_3362; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3368 [d28];
    struct Blob_Generic_3395 [d43];
    struct Blob_Generic_3403 [d4b];
    struct Blob_Generic_3411 [d53];
    struct Blob_Generic_3436 [d6c];
    struct Blob_Generic_3446 [d76];
    struct Blob_Generic_3454 [d7e];
    struct Blob_Generic_3462 [d86];
    struct Blob_Generic_3470 [d8e];
    struct Blob_Generic_3483 [d9b];
    struct Blob_Generic_3496 [da8];
    struct Blob_Generic_3505 [db1];
    struct Blob_Generic_3510 [db6];
    struct Blob_PropertySig_3517 PropertySig_3517; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3526 [dc6];
    struct Blob_Generic_3534 [dce];
    struct Blob_Generic_3543 [dd7];
    struct Blob_Generic_3552 [de0];
    struct Blob_Generic_3558 [de6];
    struct Blob_Generic_3564 [dec];
    struct Blob_Generic_3576 [df8];
    struct Blob_Generic_3586 [e02];
    struct Blob_Generic_3598 [e0e];
    struct Blob_Generic_3608 [e18];
    struct Blob_Generic_3615 [e1f];
    struct Blob_Generic_3621 [e25];
    struct Blob_Generic_3629 [e2d];
    struct Blob_Generic_3639 [e37];
    struct Blob_Generic_3648 [e40];
    struct Blob_Generic_3656 [e48];
    struct Blob_Generic_3666 [e52];
    struct Blob_Generic_3675 [e5b];
    struct Blob_Generic_3683 [e63];
    struct Blob_Generic_3692 [e6c];
    struct Blob_Generic_3701 [e75];
    struct Blob_Generic_3710 [e7e];
    struct Blob_Generic_3722 [e8a];
    struct Blob_Generic_3734 [e96];
    struct Blob_Generic_3743 [e9f];
    struct Blob_Generic_3752 [ea8];
    struct Blob_Generic_3761 [eb1];
    struct Blob_Generic_3769 [eb9];
    struct Blob_Generic_3777 [ec1];
    struct Blob_Generic_3783 [ec7];
    struct Blob_Generic_3791 [ecf];
    struct Blob_PropertySig_3797 PropertySig_3797; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3803 [edb];
    struct Blob_Generic_3812 [ee4];
    struct Blob_Generic_3820 [eec];
    struct Blob_Generic_3828 [ef4];
    struct Blob_Generic_3835 [efb];
    struct Blob_PropertySig_3845 PropertySig_3845; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3855 [f0f];
    struct Blob_Generic_3868 [f1c];
    struct Blob_Generic_3876 [f24];
    struct Blob_Generic_3884 [f2c];
    struct Blob_Generic_3895 [f37];
    struct Blob_Generic_3903 [f3f];
    struct Blob_Generic_3909 [f45];
    struct Blob_PropertySig_3919 PropertySig_3919; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_3929 PropertySig_3929; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_3937 PropertySig_3937; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3943 [f67];
    struct Blob_Generic_3981 [f8d];
    struct Blob_Generic_3989 [f95];
    struct Blob_Generic_3997 [f9d];
    struct Blob_Generic_4033 [fc1];
    struct Blob_PropertySig_4043 PropertySig_4043; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_4053 [fd5];
    struct Blob_Generic_4079 [fef];
    struct Blob_Generic_4087 [ff7];
    struct Blob_Generic_4095 [fff];
    struct Blob_Generic_4119 [1017];
    struct Blob_Generic_4125 [101d];
    struct Blob_PropertySig_4131 PropertySig_4131; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4137 PropertySig_4137; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_4143 [102f];
    struct Blob_Generic_4152 [1038];
    struct Blob_Generic_4161 [1041];
    struct Blob_Generic_4170 [104a];
    struct Blob_Generic_4179 [1053];
    struct Blob_Generic_4185 [1059];
    struct Blob_PropertySig_4191 PropertySig_4191; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4197 PropertySig_4197; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_4203 [106b];
    struct Blob_Generic_4212 [1074];
    struct Blob_Generic_4221 [107d];
    struct Blob_Generic_4230 [1086];
    struct Blob_Generic_4239 [108f];
    struct Blob_Generic_4246 [1096];
    struct Blob_Generic_4253 [109d];
    struct Blob_Generic_4260 [10a4];
    struct Blob_FieldSig_4267 FieldSig_4267; // Type information for Field
    struct Blob_FieldSig_4272 FieldSig_4272; // Type information for Field
    struct Blob_Generic_4277 [10b5];
    struct Blob_Generic_4282 [10ba];
    struct Blob_Generic_4291 [10c3];
    struct Blob_Generic_4298 [10ca];
    struct Blob_PropertySig_4309 PropertySig_4309; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_4314 [10da];
    struct Blob_Generic_4322 [10e2];
    struct Blob_Generic_4331 [10eb];
    struct Blob_Generic_4340 [10f4];
    struct Blob_Generic_4377 [1119];
    struct Blob_Generic_4412 [113c];
    struct Blob_Generic_4418 [1142];
    struct Blob_Generic_4424 [1148];
    struct Blob_PropertySig_4430 PropertySig_4430; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4436 PropertySig_4436; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4442 PropertySig_4442; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_4448 [1160];
    struct Blob_Generic_4463 [116f];
    struct Blob_Generic_4476 [117c];
    struct Blob_Generic_4483 [1183];
    struct Blob_Generic_4490 [118a];
    struct Blob_Generic_4501 [1195];
    struct Blob_Generic_4508 [119c];
    struct Blob_PropertySig_4514 PropertySig_4514; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_4520 [11a8];
    struct Blob_Generic_4532 [11b4];
    struct Blob_Generic_4540 [11bc];
    struct Blob_Generic_4548 [11c4];
    struct Blob_Generic_4558 [11ce];
    struct Blob_Generic_4568 [11d8];
    struct Blob_PropertySig_4574 PropertySig_4574; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4580 PropertySig_4580; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_4590 [11ee];
    struct Blob_Generic_4607 [11ff];
    struct Blob_Generic_4615 [1207];
    struct Blob_Generic_4623 [120f];
    struct Blob_Generic_4638 [121e];
    struct Blob_Generic_4646 [1226];
    struct Blob_Generic_4655 [122f];
    struct Blob_Generic_4662 [1236];
    struct Blob_Generic_4669 [123d];
    struct Blob_Generic_4676 [1244];
    struct Blob_Generic_4683 [124b];
    struct Blob_Generic_4690 [1252];
    struct Blob_Generic_4698 [125a];
    struct Blob_Generic_4704 [1260];
    struct Blob_Generic_4710 [1266];
    struct Blob_Generic_4716 [126c];
    struct Blob_Generic_4722 [1272];
    struct Blob_Generic_4728 [1278];
    struct Blob_PropertySig_4734 PropertySig_4734; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4740 PropertySig_4740; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4746 PropertySig_4746; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4752 PropertySig_4752; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4758 PropertySig_4758; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4764 PropertySig_4764; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_FieldSig_4770 FieldSig_4770; // Type information for Field
    struct Blob_FieldSig_4775 FieldSig_4775; // Type information for Field
    struct Blob_FieldSig_4780 FieldSig_4780; // Type information for Field
    struct Blob_Generic_4785 [12b1];
    struct Blob_Generic_4791 [12b7];
    struct Blob_Generic_4798 [12be];
    struct Blob_Generic_4813 [12cd];
    struct Blob_PropertySig_4819 PropertySig_4819; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_4825 [12d9];
    struct Blob_Generic_4840 [12e8];
    struct Blob_Generic_4853 [12f5];
    struct Blob_Generic_4858 [12fa];
    struct Blob_Generic_4864 [1300];
    struct Blob_PropertySig_4870 PropertySig_4870; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_4876 PropertySig_4876; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_FieldSig_4882 FieldSig_4882; // Type information for Field
    struct Blob_Generic_4887 [1317];
    struct Blob_Generic_4894 [131e];
    struct Blob_Generic_4906 [132a];
    struct Blob_Generic_4914 [1332];
    struct Blob_Generic_4922 [133a];
    struct Blob_Generic_4932 [1344];
    struct Blob_Generic_4941 [134d];
    struct Blob_Generic_4952 [1358];
    struct Blob_Generic_4961 [1361];
    struct Blob_Generic_4969 [1369];
    struct Blob_Generic_4976 [1370];
    struct Blob_Generic_4985 [1379];
    struct Blob_Generic_4994 [1382];
    struct Blob_Generic_5005 [138d];
    struct Blob_Generic_5014 [1396];
    struct Blob_Generic_5028 [13a4];
    struct Blob_Generic_5037 [13ad];
    struct Blob_Generic_5051 [13bb];
    struct Blob_Generic_5063 [13c7];
    struct Blob_Generic_5072 [13d0];
    struct Blob_Generic_5081 [13d9];
    struct Blob_Generic_5088 [13e0];
    struct Blob_Generic_5097 [13e9];
    struct Blob_Generic_5106 [13f2];
    struct Blob_Generic_5112 [13f8];
    struct Blob_Generic_5118 [13fe];
    struct Blob_Generic_5122 [1402];
    struct Blob_Generic_5127 [1407];
    struct Blob_Generic_5134 [140e];
    struct Blob_PropertySig_5141 PropertySig_5141; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_5145 PropertySig_5145; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5151 [141f];
    struct Blob_Generic_5158 [1426];
    struct Blob_Generic_5165 [142d];
    struct Blob_Generic_5172 [1434];
    struct Blob_Generic_5179 [143b];
    struct Blob_Generic_5186 [1442];
    struct Blob_Generic_5193 [1449];
    struct Blob_Generic_5200 [1450];
    struct Blob_Generic_5208 [1458];
    struct Blob_Generic_5217 [1461];
    struct Blob_Generic_5226 [146a];
    struct Blob_Generic_5235 [1473];
    struct Blob_Generic_5244 [147c];
    struct Blob_Generic_5251 [1483];
    struct Blob_Generic_5258 [148a];
    struct Blob_Generic_5265 [1491];
    struct Blob_Generic_5272 [1498];
    struct Blob_Generic_5279 [149f];
    struct Blob_PropertySig_5285 PropertySig_5285; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5291 [14ab];
    struct Blob_Generic_5303 [14b7];
    struct Blob_Generic_5311 [14bf];
    struct Blob_Generic_5319 [14c7];
    struct Blob_Generic_5329 [14d1];
    struct Blob_Generic_5337 [14d9];
    struct Blob_Generic_5343 [14df];
    struct Blob_Generic_5351 [14e7];
    struct Blob_PropertySig_5361 PropertySig_5361; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_5371 PropertySig_5371; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5379 [1503];
    struct Blob_Generic_5386 [150a];
    struct Blob_Generic_5397 [1515];
    struct Blob_Generic_5410 [1522];
    struct Blob_Generic_5417 [1529];
    struct Blob_Generic_5428 [1534];
    struct Blob_Generic_5441 [1541];
    struct Blob_PropertySig_5447 PropertySig_5447; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5453 [154d];
    struct Blob_Generic_5469 [155d];
    struct Blob_Generic_5477 [1565];
    struct Blob_Generic_5485 [156d];
    struct Blob_Generic_5499 [157b];
    struct Blob_Generic_5511 [1587];
    struct Blob_Generic_5521 [1591];
    struct Blob_PropertySig_5527 PropertySig_5527; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5533 [159d];
    struct Blob_Generic_5552 [15b0];
    struct Blob_Generic_5569 [15c1];
    struct Blob_Generic_5579 [15cb];
    struct Blob_PropertySig_5589 PropertySig_5589; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_5599 PropertySig_5599; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5609 [15e9];
    struct Blob_Generic_5622 [15f6];
    struct Blob_Generic_5635 [1603];
    struct Blob_Generic_5648 [1610];
    struct Blob_Generic_5661 [161d];
    struct Blob_Generic_5669 [1625];
    struct Blob_Generic_5679 [162f];
    struct Blob_PropertySig_5689 PropertySig_5689; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_5699 PropertySig_5699; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5709 [164d];
    struct Blob_Generic_5729 [1661];
    struct Blob_Generic_5737 [1669];
    struct Blob_Generic_5745 [1671];
    struct Blob_Generic_5763 [1683];
    struct Blob_Generic_5769 [1689];
    struct Blob_PropertySig_5779 PropertySig_5779; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_5789 PropertySig_5789; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5795 [16a3];
    struct Blob_Generic_5811 [16b3];
    struct Blob_Generic_5825 [16c1];
    struct Blob_PropertySig_5831 PropertySig_5831; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5837 [16cd];
    struct Blob_Generic_5849 [16d9];
    struct Blob_Generic_5857 [16e1];
    struct Blob_Generic_5865 [16e9];
    struct Blob_Generic_5875 [16f3];
    struct Blob_PropertySig_5881 PropertySig_5881; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5887 [16ff];
    struct Blob_Generic_5901 [170d];
    struct Blob_Generic_5913 [1719];
    struct Blob_Generic_5919 [171f];
    struct Blob_Generic_5925 [1725];
    struct Blob_Generic_5931 [172b];
    struct Blob_Generic_5937 [1731];
    struct Blob_PropertySig_5947 PropertySig_5947; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_5957 PropertySig_5957; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_5963 PropertySig_5963; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_5969 PropertySig_5969; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_5975 PropertySig_5975; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_5981 [175d];
    struct Blob_Generic_6016 [1780];
    struct Blob_Generic_6024 [1788];
    struct Blob_Generic_6032 [1790];
    struct Blob_Generic_6065 [17b1];
    struct Blob_PropertySig_6071 PropertySig_6071; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_6077 [17bd];
    struct Blob_Generic_6090 [17ca];
    struct Blob_Generic_6098 [17d2];
    struct Blob_Generic_6106 [17da];
    struct Blob_Generic_6117 [17e5];
    struct Blob_Generic_6124 [17ec];
    struct Blob_Generic_6130 [17f2];
    struct Blob_PropertySig_6136 PropertySig_6136; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6142 PropertySig_6142; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_6148 [1804];
    struct Blob_Generic_6163 [1813];
    struct Blob_Generic_6171 [181b];
    struct Blob_Generic_6179 [1823];
    struct Blob_Generic_6192 [1830];
    struct Blob_Generic_6205 [183d];
    struct Blob_Generic_6215 [1847];
    struct Blob_PropertySig_6221 PropertySig_6221; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_6227 [1853];
    struct Blob_Generic_6237 [185d];
    struct Blob_Generic_6245 [1865];
    struct Blob_Generic_6253 [186d];
    struct Blob_Generic_6261 [1875];
    struct Blob_Generic_6268 [187c];
    struct Blob_Generic_6275 [1883];
    struct Blob_Generic_6282 [188a];
    struct Blob_Generic_6289 [1891];
    struct Blob_Generic_6298 [189a];
    struct Blob_Generic_6308 [18a4];
    struct Blob_Generic_6318 [18ae];
    struct Blob_Generic_6329 [18b9];
    struct Blob_Generic_6338 [18c2];
    struct Blob_PropertySig_6347 PropertySig_6347; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6357 PropertySig_6357; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_6366 [18de];
    struct Blob_Generic_6400 [1900];
    struct Blob_Generic_6432 [1920];
    struct Blob_Generic_6441 [1929];
    struct Blob_Generic_6447 [192f];
    struct Blob_Generic_6453 [1935];
    struct Blob_Generic_6459 [193b];
    struct Blob_Generic_6465 [1941];
    struct Blob_PropertySig_6472 PropertySig_6472; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6478 PropertySig_6478; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_6484 [1954];
    struct Blob_PropertySig_6490 PropertySig_6490; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_6496 [1960];
    struct Blob_PropertySig_6502 PropertySig_6502; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_6508 [196c];
    struct Blob_Generic_6515 [1973];
    struct Blob_Generic_6525 [197d];
    struct Blob_Generic_6533 [1985];
    struct Blob_Generic_6539 [198b];
    struct Blob_Generic_6546 [1992];
    struct Blob_Generic_6553 [1999];
    struct Blob_Generic_6560 [19a0];
    struct Blob_Generic_6569 [19a9];
    struct Blob_Generic_6575 [19af];
    struct Blob_Generic_6584 [19b8];
    struct Blob_Generic_6597 [19c5];
    struct Blob_Generic_6623 [19df];
    struct Blob_Generic_6643 [19f3];
    struct Blob_Generic_6663 [1a07];
    struct Blob_Generic_6669 [1a0d];
    struct Blob_Generic_6675 [1a13];
    struct Blob_Generic_6681 [1a19];
    struct Blob_Generic_6687 [1a1f];
    struct Blob_Generic_6693 [1a25];
    struct Blob_Generic_6700 [1a2c];
    struct Blob_Generic_6707 [1a33];
    struct Blob_Generic_6714 [1a3a];
    struct Blob_Generic_6721 [1a41];
    struct Blob_PropertySig_6727 PropertySig_6727; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6733 PropertySig_6733; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6739 PropertySig_6739; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6745 PropertySig_6745; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6751 PropertySig_6751; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6757 PropertySig_6757; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6763 PropertySig_6763; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6769 PropertySig_6769; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_FieldSig_6775 FieldSig_6775; // Type information for Field
    struct Blob_FieldSig_6780 FieldSig_6780; // Type information for Field
    struct Blob_FieldSig_6785 FieldSig_6785; // Type information for Field
    struct Blob_FieldSig_6790 FieldSig_6790; // Type information for Field
    struct Blob_FieldSig_6795 FieldSig_6795; // Type information for Field
    struct Blob_FieldSig_6800 FieldSig_6800; // Type information for Field
    struct Blob_FieldSig_6805 FieldSig_6805; // Type information for Field
    struct Blob_FieldSig_6810 FieldSig_6810; // Type information for Field
    struct Blob_FieldSig_6815 FieldSig_6815; // Type information for Field
    struct Blob_FieldSig_6820 FieldSig_6820; // Type information for Field
    struct Blob_FieldSig_6825 FieldSig_6825; // Type information for Field
    struct Blob_FieldSig_6830 FieldSig_6830; // Type information for Field
    struct Blob_Generic_6835 [1ab3];
    struct Blob_Generic_6841 [1ab9];
    struct Blob_Generic_6849 [1ac1];
    struct Blob_Generic_6857 [1ac9];
    struct Blob_Generic_6863 [1acf];
    struct Blob_PropertySig_6870 PropertySig_6870; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_6876 PropertySig_6876; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_6882 [1ae2];
    struct Blob_Generic_6892 [1aec];
    struct Blob_Generic_6900 [1af4];
    struct Blob_Generic_6907 [1afb];
    struct Blob_Generic_6915 [1b03];
    struct Blob_Generic_6922 [1b0a];
    struct Blob_Generic_6931 [1b13];
    struct Blob_Generic_6945 [1b21];
    struct Blob_Generic_6956 [1b2c];
    struct Blob_Generic_6966 [1b36];
    struct Blob_Generic_6973 [1b3d];
    struct Blob_Generic_6981 [1b45];
    struct Blob_Generic_6989 [1b4d];
    struct Blob_Generic_6997 [1b55];
    struct Blob_Generic_7007 [1b5f];
    struct Blob_PropertySig_7013 PropertySig_7013; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_7019 PropertySig_7019; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7029 [1b75];
    struct Blob_Generic_7047 [1b87];
    struct Blob_Generic_7055 [1b8f];
    struct Blob_Generic_7063 [1b97];
    struct Blob_Generic_7079 [1ba7];
    struct Blob_Generic_7090 [1bb2];
    struct Blob_Generic_7099 [1bbb];
    struct Blob_PropertySig_7109 PropertySig_7109; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7119 [1bcf];
    struct Blob_Generic_7134 [1bde];
    struct Blob_Generic_7142 [1be6];
    struct Blob_Generic_7150 [1bee];
    struct Blob_Generic_7163 [1bfb];
    struct Blob_PropertySig_7173 PropertySig_7173; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7183 [1c0f];
    struct Blob_Generic_7197 [1c1d];
    struct Blob_Generic_7205 [1c25];
    struct Blob_Generic_7213 [1c2d];
    struct Blob_Generic_7225 [1c39];
    struct Blob_PropertySig_7235 PropertySig_7235; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7245 [1c4d];
    struct Blob_Generic_7258 [1c5a];
    struct Blob_Generic_7266 [1c62];
    struct Blob_Generic_7274 [1c6a];
    struct Blob_Generic_7285 [1c75];
    struct Blob_Generic_7291 [1c7b];
    struct Blob_PropertySig_7301 PropertySig_7301; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_7311 PropertySig_7311; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7317 [1c95];
    struct Blob_Generic_7333 [1ca5];
    struct Blob_Generic_7341 [1cad];
    struct Blob_Generic_7349 [1cb5];
    struct Blob_Generic_7363 [1cc3];
    struct Blob_PropertySig_7369 PropertySig_7369; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7375 [1ccf];
    struct Blob_Generic_7384 [1cd8];
    struct Blob_Generic_7392 [1ce0];
    struct Blob_Generic_7400 [1ce8];
    struct Blob_Generic_7407 [1cef];
    struct Blob_Generic_7414 [1cf6];
    struct Blob_PropertySig_7424 PropertySig_7424; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7434 [1d0a];
    struct Blob_Generic_7447 [1d17];
    struct Blob_Generic_7455 [1d1f];
    struct Blob_Generic_7463 [1d27];
    struct Blob_Generic_7474 [1d32];
    struct Blob_Generic_7487 [1d3f];
    struct Blob_Generic_7498 [1d4a];
    struct Blob_Generic_7505 [1d51];
    struct Blob_PropertySig_7515 PropertySig_7515; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7525 [1d65];
    struct Blob_Generic_7545 [1d79];
    struct Blob_Generic_7553 [1d81];
    struct Blob_Generic_7561 [1d89];
    struct Blob_Generic_7579 [1d9b];
    struct Blob_Generic_7592 [1da8];
    struct Blob_Generic_7600 [1db0];
    struct Blob_Generic_7608 [1db8];
    struct Blob_Generic_7619 [1dc3];
    struct Blob_Generic_7625 [1dc9];
    struct Blob_PropertySig_7631 PropertySig_7631; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_7637 PropertySig_7637; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7643 [1ddb];
    struct Blob_Generic_7655 [1de7];
    struct Blob_Generic_7663 [1def];
    struct Blob_Generic_7671 [1df7];
    struct Blob_Generic_7681 [1e01];
    struct Blob_Generic_7687 [1e07];
    struct Blob_Generic_7693 [1e0d];
    struct Blob_Generic_7699 [1e13];
    struct Blob_PropertySig_7709 PropertySig_7709; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_7719 PropertySig_7719; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_7725 PropertySig_7725; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_7731 PropertySig_7731; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7737 [1e39];
    struct Blob_Generic_7746 [1e42];
    struct Blob_Generic_7755 [1e4b];
    struct Blob_Generic_7764 [1e54];
    struct Blob_Generic_7777 [1e61];
    struct Blob_Generic_7786 [1e6a];
    struct Blob_Generic_7795 [1e73];
    struct Blob_Generic_7804 [1e7c];
    struct Blob_Generic_7817 [1e89];
    struct Blob_PropertySig_7823 PropertySig_7823; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7829 [1e95];
    struct Blob_Generic_7838 [1e9e];
    struct Blob_Generic_7846 [1ea6];
    struct Blob_Generic_7854 [1eae];
    struct Blob_Generic_7861 [1eb5];
    struct Blob_Generic_7870 [1ebe];
    struct Blob_Generic_7878 [1ec6];
    struct Blob_Generic_7886 [1ece];
    struct Blob_Generic_7893 [1ed5];
    struct Blob_Generic_7904 [1ee0];
    struct Blob_Generic_7912 [1ee8];
    struct Blob_Generic_7920 [1ef0];
    struct Blob_Generic_7929 [1ef9];
    struct Blob_Generic_7935 [1eff];
    struct Blob_Generic_7945 [1f09];
    struct Blob_PropertySig_7955 PropertySig_7955; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_7965 PropertySig_7965; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_7975 PropertySig_7975; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_7981 [1f2d];
    struct Blob_Generic_8007 [1f47];
    struct Blob_Generic_8015 [1f4f];
    struct Blob_Generic_8023 [1f57];
    struct Blob_Generic_8047 [1f6f];
    struct Blob_Generic_8053 [1f75];
    struct Blob_Generic_8063 [1f7f];
    struct Blob_PropertySig_8069 PropertySig_8069; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_8075 PropertySig_8075; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_8085 PropertySig_8085; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_8091 [1f9b];
    struct Blob_PropertySig_8097 PropertySig_8097; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_8103 [1fa7];
    struct Blob_Generic_8115 [1fb3];
    struct Blob_Generic_8123 [1fbb];
    struct Blob_Generic_8131 [1fc3];
    struct Blob_Generic_8141 [1fcd];
    struct Blob_Generic_8153 [1fd9];
    struct Blob_Generic_8161 [1fe1];
    struct Blob_Generic_8169 [1fe9];
    struct Blob_PropertySig_8179 PropertySig_8179; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_8189 [1ffd];
    struct Blob_Generic_8209 [2011];
    struct Blob_Generic_8217 [2019];
    struct Blob_Generic_8225 [2021];
    struct Blob_Generic_8243 [2033];
    struct Blob_Generic_8254 [203e];
    struct Blob_Generic_8265 [2049];
    struct Blob_Generic_8272 [2050];
    struct Blob_Generic_8282 [205a];
    struct Blob_Generic_8292 [2064];
    struct Blob_Generic_8302 [206e];
    struct Blob_Generic_8315 [207b];
    struct Blob_Generic_8328 [2088];
    struct Blob_Generic_8344 [2098];
    struct Blob_Generic_8360 [20a8];
    struct Blob_Generic_8373 [20b5];
    struct Blob_Generic_8378 [20ba];
    struct Blob_Generic_8385 [20c1];
    struct Blob_Generic_8390 [20c6];
    struct Blob_Generic_8397 [20cd];
    struct Blob_Generic_8404 [20d4];
    struct Blob_Generic_8414 [20de];
    struct Blob_Generic_8421 [20e5];
    struct Blob_Generic_8428 [20ec];
    struct Blob_Generic_8438 [20f6];
    struct Blob_PropertySig_8446 PropertySig_8446; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_8456 [2108];
    struct Blob_Generic_8463 [210f];
    struct Blob_Generic_8472 [2118];
    struct Blob_Generic_8478 [211e];
    struct Blob_Generic_8485 [2125];
    struct Blob_Generic_8491 [212b];
    struct Blob_Generic_8498 [2132];
    struct Blob_Generic_8505 [2139];
    struct Blob_Generic_8512 [2140];
    struct Blob_Generic_8519 [2147];
    struct Blob_Generic_8526 [214e];
    struct Blob_Generic_8540 [215c];
    struct Blob_Generic_8550 [2166];
    struct Blob_PropertySig_8556 PropertySig_8556; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_8562 [2172];
    struct Blob_Generic_8574 [217e];
    struct Blob_Generic_8582 [2186];
    struct Blob_Generic_8590 [218e];
    struct Blob_Generic_8600 [2198];
    struct Blob_PropertySig_8610 PropertySig_8610; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_8620 [21ac];
    struct Blob_Generic_8637 [21bd];
    struct Blob_Generic_8645 [21c5];
    struct Blob_Generic_8653 [21cd];
    struct Blob_Generic_8668 [21dc];
    struct Blob_PropertySig_8678 PropertySig_8678; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_8688 [21f0];
    struct Blob_Generic_8703 [21ff];
    struct Blob_Generic_8711 [2207];
    struct Blob_Generic_8719 [220f];
    struct Blob_Generic_8732 [221c];
    struct Blob_Generic_8739 [2223];
    struct Blob_Generic_8745 [2229];
    struct Blob_Generic_8755 [2233];
    struct Blob_Generic_8765 [223d];
    struct Blob_Generic_8772 [2244];
    struct Blob_Generic_8788 [2254];
    struct Blob_Generic_8797 [225d];
    struct Blob_Generic_8804 [2264];
    struct Blob_Generic_8814 [226e];
    struct Blob_Generic_8824 [2278];
    struct Blob_PropertySig_8834 PropertySig_8834; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_8844 PropertySig_8844; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_8854 PropertySig_8854; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_8864 [22a0];
    struct Blob_Generic_8909 [22cd];
    struct Blob_Generic_8917 [22d5];
    struct Blob_Generic_8925 [22dd];
    struct Blob_Generic_8968 [2308];
    struct Blob_PropertySig_8974 PropertySig_8974; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_8980 [2314];
    struct Blob_Generic_8991 [231f];
    struct Blob_Generic_8999 [2327];
    struct Blob_Generic_9007 [232f];
    struct Blob_Generic_9016 [2338];
    struct Blob_PropertySig_9026 PropertySig_9026; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_9036 [234c];
    struct Blob_Generic_9051 [235b];
    struct Blob_Generic_9059 [2363];
    struct Blob_Generic_9067 [236b];
    struct Blob_Generic_9080 [2378];
    struct Blob_Generic_9087 [237f];
    struct Blob_Generic_9094 [2386];
    struct Blob_Generic_9104 [2390];
    struct Blob_Generic_9114 [239a];
    struct Blob_Generic_9124 [23a4];
    struct Blob_Generic_9131 [23ab];
    struct Blob_Generic_9144 [23b8];
    struct Blob_Generic_9159 [23c7];
    struct Blob_Generic_9172 [23d4];
    struct Blob_Generic_9179 [23db];
    struct Blob_Generic_9186 [23e2];
    struct Blob_Generic_9196 [23ec];
    struct Blob_Generic_9206 [23f6];
    struct Blob_Generic_9216 [2400];
    struct Blob_Generic_9226 [240a];
    struct Blob_Generic_9236 [2414];
    struct Blob_Generic_9254 [2426];
    struct Blob_Generic_9267 [2433];
    struct Blob_Generic_9280 [2440];
    struct Blob_Generic_9287 [2447];
    struct Blob_Generic_9301 [2455];
    struct Blob_Generic_9307 [245b];
    struct Blob_Generic_9314 [2462];
    struct Blob_Generic_9320 [2468];
    struct Blob_PropertySig_9327 PropertySig_9327; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_9333 PropertySig_9333; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_9339 [247b];
    struct Blob_Generic_9369 [2499];
    struct Blob_Generic_9397 [24b5];
    struct Blob_Generic_9407 [24bf];
    struct Blob_Generic_9418 [24ca];
    struct Blob_Generic_9425 [24d1];
    struct Blob_Generic_9432 [24d8];
    struct Blob_Generic_9438 [24de];
    struct Blob_Generic_9444 [24e4];
    struct Blob_PropertySig_9450 PropertySig_9450; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_9456 PropertySig_9456; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_9462 PropertySig_9462; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_9468 [24fc];
    struct Blob_Generic_9499 [251b];
    struct Blob_Generic_9507 [2523];
    struct Blob_Generic_9515 [252b];
    struct Blob_Generic_9544 [2548];
    struct Blob_Generic_9555 [2553];
    struct Blob_Generic_9577 [2569];
    struct Blob_Generic_9596 [257c];
    struct Blob_Generic_9612 [258c];
    struct Blob_Generic_9629 [259d];
    struct Blob_Generic_9638 [25a6];
    struct Blob_Generic_9646 [25ae];
    struct Blob_Generic_9654 [25b6];
    struct Blob_Generic_9661 [25bd];
    struct Blob_Generic_9672 [25c8];
    struct Blob_Generic_9683 [25d3];
    struct Blob_Generic_9695 [25df];
    struct Blob_PropertySig_9701 PropertySig_9701; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_9707 [25eb];
    struct Blob_Generic_9719 [25f7];
    struct Blob_Generic_9729 [2601];
    struct Blob_PropertySig_9739 PropertySig_9739; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_9749 [2615];
    struct Blob_Generic_9762 [2622];
    struct Blob_Generic_9770 [262a];
    struct Blob_Generic_9778 [2632];
    struct Blob_Generic_9789 [263d];
    struct Blob_Generic_9796 [2644];
    struct Blob_Generic_9806 [264e];
    struct Blob_Generic_9822 [265e];
    struct Blob_Generic_9828 [2664];
    struct Blob_Generic_9833 [2669];
    struct Blob_Generic_9839 [266f];
    struct Blob_Generic_9846 [2676];
    struct Blob_Generic_9852 [267c];
    struct Blob_Generic_9858 [2682];
    struct Blob_Generic_9867 [268b];
    struct Blob_Generic_9873 [2691];
    struct Blob_Generic_9882 [269a];
    struct Blob_Generic_9888 [26a0];
    struct Blob_Generic_9894 [26a6];
    struct Blob_Generic_9902 [26ae];
    struct Blob_Generic_9908 [26b4];
    struct Blob_Generic_9914 [26ba];
    struct Blob_Generic_9922 [26c2];
    struct Blob_Generic_9928 [26c8];
    struct Blob_Generic_9934 [26ce];
    struct Blob_Generic_9940 [26d4];
    struct Blob_Generic_9946 [26da];
    struct Blob_Generic_9952 [26e0];
    struct Blob_Generic_9958 [26e6];
    struct Blob_Generic_9967 [26ef];
    struct Blob_Generic_9974 [26f6];
    struct Blob_PropertySig_9980 PropertySig_9980; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_9986 PropertySig_9986; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_9992 PropertySig_9992; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_9998 PropertySig_9998; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10003 [2713];
    struct Blob_PropertySig_10009 PropertySig_10009; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10015 [271f];
    struct Blob_PropertySig_10021 PropertySig_10021; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_FieldSig_10027 FieldSig_10027; // Type information for Field
    struct Blob_FieldSig_10032 FieldSig_10032; // Type information for Field
    struct Blob_FieldSig_10037 FieldSig_10037; // Type information for Field
    struct Blob_FieldSig_10042 FieldSig_10042; // Type information for Field
    struct Blob_FieldSig_10047 FieldSig_10047; // Type information for Field
    struct Blob_FieldSig_10052 FieldSig_10052; // Type information for Field
    struct Blob_FieldSig_10057 FieldSig_10057; // Type information for Field
    struct Blob_FieldSig_10060 FieldSig_10060; // Type information for Field
    struct Blob_FieldSig_10065 FieldSig_10065; // Type information for Field
    struct Blob_FieldSig_10070 FieldSig_10070; // Type information for Field
    struct Blob_FieldSig_10075 FieldSig_10075; // Type information for Field
    struct Blob_FieldSig_10080 FieldSig_10080; // Type information for Field
    struct Blob_Generic_10085 [2765];
    struct Blob_PropertySig_10091 PropertySig_10091; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10097 [2771];
    struct Blob_PropertySig_10103 PropertySig_10103; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10109 [277d];
    struct Blob_Generic_10120 [2788];
    struct Blob_Generic_10128 [2790];
    struct Blob_Generic_10136 [2798];
    struct Blob_Generic_10145 [27a1];
    struct Blob_PropertySig_10151 PropertySig_10151; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10157 [27ad];
    struct Blob_Generic_10167 [27b7];
    struct Blob_Generic_10175 [27bf];
    struct Blob_Generic_10183 [27c7];
    struct Blob_Generic_10191 [27cf];
    struct Blob_PropertySig_10201 PropertySig_10201; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10211 [27e3];
    struct Blob_Generic_10224 [27f0];
    struct Blob_Generic_10232 [27f8];
    struct Blob_Generic_10240 [2800];
    struct Blob_Generic_10251 [280b];
    struct Blob_Generic_10257 [2811];
    struct Blob_PropertySig_10263 PropertySig_10263; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_10269 PropertySig_10269; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10275 [2823];
    struct Blob_Generic_10287 [282f];
    struct Blob_Generic_10295 [2837];
    struct Blob_Generic_10303 [283f];
    struct Blob_Generic_10313 [2849];
    struct Blob_Generic_10322 [2852];
    struct Blob_Generic_10330 [285a];
    struct Blob_Generic_10338 [2862];
    struct Blob_Generic_10345 [2869];
    struct Blob_Generic_10351 [286f];
    struct Blob_PropertySig_10357 PropertySig_10357; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_10363 PropertySig_10363; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10369 [2881];
    struct Blob_Generic_10394 [289a];
    struct Blob_Generic_10402 [28a2];
    struct Blob_Generic_10410 [28aa];
    struct Blob_Generic_10433 [28c1];
    struct Blob_Generic_10441 [28c9];
    struct Blob_Generic_10449 [28d1];
    struct Blob_Generic_10457 [28d9];
    struct Blob_Generic_10465 [28e1];
    struct Blob_Generic_10474 [28ea];
    struct Blob_Generic_10483 [28f3];
    struct Blob_Generic_10491 [28fb];
    struct Blob_Generic_10499 [2903];
    struct Blob_Generic_10507 [290b];
    struct Blob_Generic_10513 [2911];
    struct Blob_PropertySig_10523 PropertySig_10523; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10533 [2925];
    struct Blob_Generic_10546 [2932];
    struct Blob_Generic_10554 [293a];
    struct Blob_Generic_10562 [2942];
    struct Blob_Generic_10573 [294d];
    struct Blob_Generic_10579 [2953];
    struct Blob_PropertySig_10585 PropertySig_10585; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_10591 PropertySig_10591; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10597 [2965];
    struct Blob_Generic_10609 [2971];
    struct Blob_Generic_10617 [2979];
    struct Blob_Generic_10625 [2981];
    struct Blob_Generic_10635 [298b];
    struct Blob_Generic_10648 [2998];
    struct Blob_Generic_10659 [29a3];
    struct Blob_PropertySig_10669 PropertySig_10669; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10679 [29b7];
    struct Blob_Generic_10701 [29cd];
    struct Blob_Generic_10709 [29d5];
    struct Blob_Generic_10717 [29dd];
    struct Blob_Generic_10737 [29f1];
    struct Blob_PropertySig_10743 PropertySig_10743; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10749 [29fd];
    struct Blob_Generic_10764 [2a0c];
    struct Blob_Generic_10777 [2a19];
    struct Blob_PropertySig_10783 PropertySig_10783; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10789 [2a25];
    struct Blob_Generic_10803 [2a33];
    struct Blob_Generic_10811 [2a3b];
    struct Blob_Generic_10819 [2a43];
    struct Blob_Generic_10831 [2a4f];
    struct Blob_PropertySig_10841 PropertySig_10841; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10851 [2a63];
    struct Blob_Generic_10867 [2a73];
    struct Blob_Generic_10875 [2a7b];
    struct Blob_Generic_10883 [2a83];
    struct Blob_Generic_10897 [2a91];
    struct Blob_PropertySig_10907 PropertySig_10907; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_10917 [2aa5];
    struct Blob_Generic_10933 [2ab5];
    struct Blob_Generic_10941 [2abd];
    struct Blob_Generic_10949 [2ac5];
    struct Blob_Generic_10963 [2ad3];
    struct Blob_Generic_10972 [2adc];
    struct Blob_Generic_10979 [2ae3];
    struct Blob_PropertySig_10985 PropertySig_10985; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_FieldSig_10991 FieldSig_10991; // Type information for Field
    struct Blob_Generic_10996 [2af4];
    struct Blob_Generic_11009 [2b01];
    struct Blob_Generic_11020 [2b0c];
    struct Blob_PropertySig_11030 PropertySig_11030; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_11040 [2b20];
    struct Blob_Generic_11071 [2b3f];
    struct Blob_Generic_11079 [2b47];
    struct Blob_Generic_11087 [2b4f];
    struct Blob_Generic_11116 [2b6c];
    struct Blob_PropertySig_11126 PropertySig_11126; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_11136 [2b80];
    struct Blob_Generic_11150 [2b8e];
    struct Blob_Generic_11158 [2b96];
    struct Blob_Generic_11166 [2b9e];
    struct Blob_Generic_11178 [2baa];
    struct Blob_PropertySig_11184 PropertySig_11184; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_FieldSig_11190 FieldSig_11190; // Type information for Field
    struct Blob_Generic_11195 [2bbb];
    struct Blob_PropertySig_11205 PropertySig_11205; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_11215 [2bcf];
    struct Blob_Generic_11231 [2bdf];
    struct Blob_Generic_11239 [2be7];
    struct Blob_Generic_11247 [2bef];
    struct Blob_Generic_11261 [2bfd];
    struct Blob_PropertySig_11271 PropertySig_11271; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_11281 [2c11];
    struct Blob_Generic_11295 [2c1f];
    struct Blob_Generic_11303 [2c27];
    struct Blob_Generic_11311 [2c2f];
    struct Blob_Generic_11323 [2c3b];
    struct Blob_Generic_11338 [2c4a];
    struct Blob_Generic_11346 [2c52];
    struct Blob_Generic_11354 [2c5a];
    struct Blob_Generic_11367 [2c67];
    struct Blob_Generic_11375 [2c6f];
    struct Blob_PropertySig_11381 PropertySig_11381; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_11387 [2c7b];
    struct Blob_Generic_11399 [2c87];
    struct Blob_Generic_11409 [2c91];
    struct Blob_PropertySig_11415 PropertySig_11415; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_11421 [2c9d];
    struct Blob_Generic_11448 [2cb8];
    struct Blob_Generic_11473 [2cd1];
    struct Blob_Generic_11494 [2ce6];
    struct Blob_Generic_11513 [2cf9];
    struct Blob_Generic_11519 [2cff];
    struct Blob_PropertySig_11529 PropertySig_11529; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_11539 PropertySig_11539; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_11545 [2d19];
    struct Blob_Generic_11561 [2d29];
    struct Blob_Generic_11569 [2d31];
    struct Blob_Generic_11577 [2d39];
    struct Blob_Generic_11591 [2d47];
    struct Blob_PropertySig_11601 PropertySig_11601; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_11611 [2d5b];
    struct Blob_Generic_11625 [2d69];
    struct Blob_Generic_11633 [2d71];
    struct Blob_Generic_11641 [2d79];
    struct Blob_Generic_11653 [2d85];
    struct Blob_Generic_11659 [2d8b];
    struct Blob_Generic_11665 [2d91];
    struct Blob_Generic_11675 [2d9b];
    struct Blob_Generic_11681 [2da1];
    struct Blob_Generic_11691 [2dab];
    struct Blob_Generic_11701 [2db5];
    struct Blob_Generic_11711 [2dbf];
    struct Blob_Generic_11721 [2dc9];
    struct Blob_PropertySig_11731 PropertySig_11731; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_11741 PropertySig_11741; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_11751 PropertySig_11751; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_11761 PropertySig_11761; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_11771 PropertySig_11771; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_11781 PropertySig_11781; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_11787 PropertySig_11787; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_11797 PropertySig_11797; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_11803 PropertySig_11803; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_11809 [2e21];
    struct Blob_Generic_11889 [2e71];
    struct Blob_Generic_11897 [2e79];
    struct Blob_Generic_11905 [2e81];
    struct Blob_FieldSig_11983 FieldSig_11983; // Type information for Field
    struct Blob_FieldSig_11988 FieldSig_11988; // Type information for Field
    struct Blob_FieldSig_11993 FieldSig_11993; // Type information for Field
    struct Blob_FieldSig_11998 FieldSig_11998; // Type information for Field
    struct Blob_FieldSig_12003 FieldSig_12003; // Type information for Field
    struct Blob_Generic_12008 [2ee8];
    struct Blob_PropertySig_12018 PropertySig_12018; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12028 [2efc];
    struct Blob_Generic_12042 [2f0a];
    struct Blob_Generic_12050 [2f12];
    struct Blob_Generic_12058 [2f1a];
    struct Blob_Generic_12070 [2f26];
    struct Blob_PropertySig_12077 PropertySig_12077; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_12083 PropertySig_12083; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12089 [2f39];
    struct Blob_Generic_12104 [2f48];
    struct Blob_Generic_12117 [2f55];
    struct Blob_PropertySig_12127 PropertySig_12127; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12137 [2f69];
    struct Blob_Generic_12150 [2f76];
    struct Blob_Generic_12158 [2f7e];
    struct Blob_Generic_12166 [2f86];
    struct Blob_Generic_12177 [2f91];
    struct Blob_PropertySig_12187 PropertySig_12187; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12197 [2fa5];
    struct Blob_Generic_12214 [2fb6];
    struct Blob_Generic_12222 [2fbe];
    struct Blob_Generic_12230 [2fc6];
    struct Blob_Generic_12245 [2fd5];
    struct Blob_Generic_12259 [2fe3];
    struct Blob_Generic_12271 [2fef];
    struct Blob_PropertySig_12281 PropertySig_12281; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12291 [3003];
    struct Blob_Generic_12311 [3017];
    struct Blob_Generic_12319 [301f];
    struct Blob_Generic_12327 [3027];
    struct Blob_Generic_12345 [3039];
    struct Blob_PropertySig_12351 PropertySig_12351; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12357 [3045];
    struct Blob_Generic_12372 [3054];
    struct Blob_Generic_12385 [3061];
    struct Blob_Generic_12392 [3068];
    struct Blob_PropertySig_12402 PropertySig_12402; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12412 [307c];
    struct Blob_Generic_12425 [3089];
    struct Blob_Generic_12433 [3091];
    struct Blob_Generic_12441 [3099];
    struct Blob_Generic_12452 [30a4];
    struct Blob_PropertySig_12462 PropertySig_12462; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12472 [30b8];
    struct Blob_Generic_12485 [30c5];
    struct Blob_Generic_12493 [30cd];
    struct Blob_Generic_12501 [30d5];
    struct Blob_Generic_12512 [30e0];
    struct Blob_Generic_12520 [30e8];
    struct Blob_Generic_12532 [30f4];
    struct Blob_Generic_12540 [30fc];
    struct Blob_Generic_12548 [3104];
    struct Blob_Generic_12558 [310e];
    struct Blob_PropertySig_12568 PropertySig_12568; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12578 [3122];
    struct Blob_Generic_12591 [312f];
    struct Blob_Generic_12599 [3137];
    struct Blob_Generic_12607 [313f];
    struct Blob_Generic_12618 [314a];
    struct Blob_PropertySig_12628 PropertySig_12628; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12638 [315e];
    struct Blob_Generic_12651 [316b];
    struct Blob_Generic_12659 [3173];
    struct Blob_Generic_12667 [317b];
    struct Blob_FieldSig_12678 FieldSig_12678; // Type information for Field
    struct Blob_Generic_12683 [318b];
    struct Blob_Generic_12702 [319e];
    struct Blob_Generic_12710 [31a6];
    struct Blob_Generic_12718 [31ae];
    struct Blob_Generic_12735 [31bf];
    struct Blob_Generic_12747 [31cb];
    struct Blob_Generic_12755 [31d3];
    struct Blob_Generic_12763 [31db];
    struct Blob_Generic_12773 [31e5];
    struct Blob_Generic_12782 [31ee];
    struct Blob_Generic_12789 [31f5];
    struct Blob_PropertySig_12795 PropertySig_12795; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_12801 [3201];
    struct Blob_Generic_12812 [320c];
    struct Blob_Generic_12820 [3214];
    struct Blob_Generic_12828 [321c];
    struct Blob_MethodRefSig_12837 MethodRefSig_12837; // Type info for imported method return and params
    struct Blob_MethodRefSig_12852 MethodRefSig_12852; // Type info for imported method return and params
    struct Blob_MethodRefSig_12858 MethodRefSig_12858; // Type info for imported method return and params
    struct Blob_MethodRefSig_12865 MethodRefSig_12865; // Type info for imported method return and params
    struct Blob_MethodRefSig_12871 MethodRefSig_12871; // Type info for imported method return and params
    struct Blob_ConstantSig_12877 ConstantSig_12877; // Data stored in a constant
    struct Blob_CustomAttrib_12882 CustomAttrib_12882; // A CustomAttrib blob stores values of fixed or named parameters supplied when instantiating a custom attribute
    struct Blob_ConstantSig_12887 ConstantSig_12887; // Data stored in a constant
    struct Blob_ConstantSig_12892 ConstantSig_12892; // Data stored in a constant
    struct Blob_ConstantSig_12897.conflict ConstantSig_12897; // Data stored in a constant
    struct Blob_ConstantSig_12902 ConstantSig_12902; // Data stored in a constant
    struct Blob_ConstantSig_12907 ConstantSig_12907; // Data stored in a constant
    struct Blob_ConstantSig_12912 ConstantSig_12912; // Data stored in a constant
    struct Blob_ConstantSig_12917.conflict ConstantSig_12917; // Data stored in a constant
    struct Blob_ConstantSig_12922 ConstantSig_12922; // Data stored in a constant
    struct Blob_ConstantSig_12927 ConstantSig_12927; // Data stored in a constant
    struct Blob_ConstantSig_12932 ConstantSig_12932; // Data stored in a constant
    struct Blob_ConstantSig_12937 ConstantSig_12937; // Data stored in a constant
    struct Blob_ConstantSig_12942 ConstantSig_12942; // Data stored in a constant
    struct Blob_ConstantSig_12947 ConstantSig_12947; // Data stored in a constant
    struct Blob_ConstantSig_12952 ConstantSig_12952; // Data stored in a constant
    struct Blob_ConstantSig_12957.conflict ConstantSig_12957; // Data stored in a constant
    struct Blob_ConstantSig_12962 ConstantSig_12962; // Data stored in a constant
    struct Blob_ConstantSig_12967 ConstantSig_12967; // Data stored in a constant
    struct Blob_ConstantSig_12972 ConstantSig_12972; // Data stored in a constant
    struct Blob_ConstantSig_12977 ConstantSig_12977; // Data stored in a constant
    struct Blob_ConstantSig_12982 ConstantSig_12982; // Data stored in a constant
    struct Blob_ConstantSig_12987 ConstantSig_12987; // Data stored in a constant
    struct Blob_ConstantSig_12992 ConstantSig_12992; // Data stored in a constant
    struct Blob_Generic_12997 [32c5];
    struct Blob_CustomAttrib_13030 CustomAttrib_13030; // A CustomAttrib blob stores values of fixed or named parameters supplied when instantiating a custom attribute
    struct Blob_Generic_13039 [32ef];
    struct Blob_Generic_13060 [3304];
    struct Blob_Generic_13081 [3319];
    struct Blob_Generic_13102 [332e];
    struct Blob_Generic_13111 [3337];
    struct Blob_Generic_13120 [3340];
    struct Blob_Generic_13167 [336f];
    struct Blob_Generic_13198 [338e];
    struct Blob_Generic_13219 [33a3];
    struct Blob_Generic_13240 [33b8];
    struct Blob_Generic_13285 [33e5];
    struct Blob_Generic_13306 [33fa];
    struct Blob_Generic_13343 [341f];
    struct Blob_Generic_13364 [3434];
    struct Blob_Generic_13415 [3467];
    struct Blob_Generic_13436 [347c];
    struct Blob_Generic_13471 [349f];
    struct Blob_Generic_13492 [34b4];
    struct Blob_Generic_13541 [34e5];
    struct Blob_Generic_13562 [34fa];
    struct Blob_Generic_13593 [3519];
    struct Blob_Generic_13614 [352e];
    struct Blob_Generic_13659 [355b];
    struct Blob_Generic_13680 [3570];
    struct Blob_Generic_13709 [358d];
    struct Blob_Generic_13730 [35a2];
    struct Blob_Generic_13773 [35cd];
    struct Blob_Generic_13794 [35e2];
    struct Blob_Generic_13824 [3600];
    struct Blob_Generic_13845 [3615];
    struct Blob_Generic_13866 [362a];
    struct Blob_Generic_13910 [3656];
    struct Blob_Generic_13954 [3682];
    struct Blob_Generic_13983 [369f];
    struct Blob_Generic_14004 [36b4];
    struct Blob_Generic_14025 [36c9];
    struct Blob_Generic_14046 [36de];
    struct Blob_Generic_14089 [3709];
    struct Blob_Generic_14132 [3734];
    struct Blob_Generic_14166 [3756];
    struct Blob_Generic_14187 [376b];
    struct Blob_Generic_14208 [3780];
    struct Blob_Generic_14256 [37b0];
    struct Blob_Generic_14277 [37c5];
    struct Blob_Generic_14317 [37ed];
    struct Blob_Generic_14338 [3802];
    struct Blob_Generic_14392 [3838];
    struct Blob_Generic_14427 [385b];
    struct Blob_Generic_14448 [3870];
    struct Blob_Generic_14469 [3885];
    struct Blob_Generic_14518 [38b6];
    struct Blob_Generic_14554 [38da];
    struct Blob_Generic_14575 [38ef];
    struct Blob_Generic_14596 [3904];
    struct Blob_Generic_14646 [3936];
    struct Blob_Generic_14667 [394b];
    struct Blob_Generic_14704 [3970];
    struct Blob_Generic_14725 [3985];
    struct Blob_Generic_14746 [399a];
    struct Blob_Generic_14797 [39cd];
    struct Blob_Generic_14848 [3a00];
    struct Blob_Generic_14869 [3a15];
    struct Blob_Generic_14914 [3a42];
    struct Blob_Generic_14935 [3a57];
    struct Blob_Generic_14994 [3a92];
    struct Blob_Generic_15015 [3aa7];
    struct Blob_Generic_15055 [3acf];
    struct Blob_Generic_15076 [3ae4];
    struct Blob_Generic_15130 [3b1a];
    struct Blob_Generic_15151 [3b2f];
    struct Blob_Generic_15190 [3b56];
    struct Blob_Generic_15211 [3b6b];
    struct Blob_Generic_15232 [3b80];
    struct Blob_Generic_15285 [3bb5];
    struct Blob_Generic_15338 [3bea];
    struct Blob_Generic_15359 [3bff];
    struct Blob_Generic_15395 [3c23];
    struct Blob_Generic_15416 [3c38];
    struct Blob_Generic_15437 [3c4d];
    struct Blob_Generic_15487 [3c7f];
    struct Blob_Generic_15537 [3cb1];
    struct Blob_Generic_15558 [3cc6];
    struct Blob_Generic_15595 [3ceb];
    struct Blob_Generic_15616 [3d00];
    struct Blob_Generic_15667 [3d33];
    struct Blob_Generic_15705 [3d59];
    struct Blob_Generic_15726 [3d6e];
    struct Blob_Generic_15747 [3d83];
    struct Blob_Generic_15799 [3db7];
    struct Blob_Generic_15832 [3dd8];
    struct Blob_Generic_15853 [3ded];
    struct Blob_Generic_15874 [3e02];
    struct Blob_Generic_15921 [3e31];
    struct Blob_Generic_15942 [3e46];
    struct Blob_Generic_15963 [3e5b];
    struct Blob_Generic_15990 [3e76];
    struct Blob_Generic_16011 [3e8b];
    struct Blob_Generic_16052 [3eb4];
    struct Blob_Generic_16073 [3ec9];
    struct Blob_Generic_16104 [3ee8];
    struct Blob_Generic_16125 [3efd];
    struct Blob_Generic_16170 [3f2a];
    struct Blob_Generic_16200 [3f48];
    struct Blob_Generic_16221 [3f5d];
    struct Blob_Generic_16242 [3f72];
    struct Blob_Generic_16286 [3f9e];
    struct Blob_Generic_16307 [3fb3];
    struct Blob_Generic_16336 [3fd0];
    struct Blob_Generic_16357 [3fe5];
    struct Blob_Generic_16378 [3ffa];
    struct Blob_Generic_16421 [4025];
    struct Blob_Generic_16464 [4050];
    struct Blob_Generic_16494 [406e];
    struct Blob_Generic_16515 [4083];
    struct Blob_Generic_16536 [4098];
    struct Blob_Generic_16557 [40ad];
    struct Blob_Generic_16601 [40d9];
    struct Blob_Generic_16645 [4105];
    struct Blob_Generic_16671 [411f];
    struct Blob_Generic_16692 [4134];
    struct Blob_Generic_16713 [4149];
    struct Blob_Generic_16753 [4171];
    struct Blob_Generic_16787 [4193];
    struct Blob_Generic_16808 [41a8];
    struct Blob_Generic_16829 [41bd];
    struct Blob_Generic_16877 [41ed];
    struct Blob_Generic_16898 [4202];
    struct Blob_Generic_16933 [4225];
    struct Blob_Generic_16954 [423a];
    struct Blob_Generic_16975 [424f];
    struct Blob_Generic_17024 [4280];
    struct Blob_Generic_17073 [42b1];
    struct Blob_Generic_17094 [42c6];
    struct Blob_Generic_17133 [42ed];
    struct Blob_Generic_17154 [4302];
    struct Blob_Generic_17207 [4337];
    struct Blob_Generic_17232 [4350];
    struct Blob_Generic_17253 [4365];
    struct Blob_Generic_17274 [437a];
    struct Blob_Generic_17313 [43a1];
    struct Blob_Generic_17334 [43b6];
    struct Blob_Generic_17355 [43cb];
    struct Blob_Generic_17376 [43e0];
    struct Blob_Generic_17404 [43fc];
    struct Blob_Generic_17425 [4411];
    struct Blob_Generic_17446 [4426];
    struct Blob_Generic_17488 [4450];
    struct Blob_Generic_17517 [446d];
    struct Blob_Generic_17538 [4482];
    struct Blob_Generic_17559 [4497];
    struct Blob_Generic_17602 [44c2];
    struct Blob_Generic_17641 [44e9];
    struct Blob_Generic_17662 [44fe];
    struct Blob_Generic_17683 [4513];
    struct Blob_Generic_17704 [4528];
    struct Blob_Generic_17757 [455d];
    struct Blob_Generic_17810 [4592];
    struct Blob_Generic_17831 [45a7];
    struct Blob_Generic_17874 [45d2];
    struct Blob_Generic_17895 [45e7];
    struct Blob_Generic_17952 [4620];
    struct Blob_Generic_17973 [4635];
    struct Blob_Generic_17994 [464a];
    struct Blob_Generic_18015 [465f];
    struct Blob_Generic_18050 [4682];
    struct Blob_Generic_18071 [4697];
    struct Blob_Generic_18092 [46ac];
    struct Blob_Generic_18141 [46dd];
    struct Blob_Generic_18162 [46f2];
    struct Blob_Generic_18183 [4707];
    struct Blob_Generic_18204 [471c];
    struct Blob_Generic_18225 [4731];
    struct Blob_Generic_18241 [4741];
    struct Blob_Generic_18257 [4751];
    struct Blob_Generic_18290 [4772];
    struct Blob_Generic_18311 [4787];
    struct Blob_Generic_18332 [479c];
    struct Blob_Generic_18353 [47b1];
    struct Blob_Generic_18400 [47e0];
    struct Blob_Generic_18447 [480f];
    struct Blob_Generic_18468 [4824];
    struct Blob_Generic_18509 [484d];
    struct Blob_Generic_18530 [4862];
    struct Blob_Generic_18585 [4899];
    struct Blob_Generic_18636 [48cc];
    struct Blob_Generic_18657 [48e1];
    struct Blob_Generic_18678 [48f6];
    struct Blob_Generic_18743 [4937];
    struct Blob_Generic_18764 [494c];
    struct Blob_Generic_18806 [4976];
    struct Blob_Generic_18827 [498b];
    struct Blob_Generic_18883 [49c3];
    struct Blob_Generic_18904 [49d8];
    struct Blob_Generic_18942 [49fe];
    struct Blob_Generic_18963 [4a13];
    struct Blob_Generic_18984 [4a28];
    struct Blob_Generic_19036 [4a5c];
    struct Blob_Generic_19088 [4a90];
    struct Blob_Generic_19109 [4aa5];
    struct Blob_Generic_19142 [4ac6];
    struct Blob_Generic_19163 [4adb];
    struct Blob_Generic_19210 [4b0a];
    struct Blob_Generic_19248 [4b30];
    struct Blob_Generic_19269 [4b45];
    struct Blob_Generic_19290 [4b5a];
    struct Blob_Generic_19342 [4b8e];
    struct Blob_Generic_19363 [4ba3];
    struct Blob_Generic_19395 [4bc3];
    struct Blob_Generic_19416 [4bd8];
    struct Blob_Generic_19437 [4bed];
    struct Blob_Generic_19483 [4c1b];
    struct Blob_Generic_19529 [4c49];
    struct Blob_Generic_19550 [4c5e];
    struct Blob_Generic_19586 [4c82];
    struct Blob_Generic_19607 [4c97];
    struct Blob_Generic_19628 [4cac];
    struct Blob_Generic_19678 [4cde];
    struct Blob_Generic_19728 [4d10];
    struct Blob_Generic_19762 [4d32];
    struct Blob_Generic_19783 [4d47];
    struct Blob_Generic_19804 [4d5c];
    struct Blob_Generic_19852 [4d8c];
    struct Blob_Generic_19893 [4db5];
    struct Blob_Generic_19914 [4dca];
    struct Blob_Generic_19935 [4ddf];
    struct Blob_Generic_19990 [4e16];
    struct Blob_Generic_20038 [4e46];
    struct Blob_Generic_20059 [4e5b];
    struct Blob_Generic_20080 [4e70];
    struct Blob_Generic_20101 [4e85];
    struct Blob_Generic_20163 [4ec3];
    struct Blob_Generic_20225 [4f01];
    struct Blob_Generic_20265 [4f29];
    struct Blob_Generic_20286 [4f3e];
    struct Blob_Generic_20307 [4f53];
    struct Blob_Generic_20361 [4f89];
    struct Blob_Generic_20382 [4f9e];
    struct Blob_Generic_20418 [4fc2];
    struct Blob_Generic_20439 [4fd7];
    struct Blob_Generic_20460 [4fec];
    struct Blob_Generic_20510 [501e];
    struct Blob_Generic_20560 [5050];
    struct Blob_Generic_20581 [5065];
    struct Blob_Generic_20616 [5088];
    struct Blob_Generic_20637 [509d];
    struct Blob_Generic_20658 [50b2];
    struct Blob_Generic_20707 [50e3];
    struct Blob_Generic_20756 [5114];
    struct Blob_Generic_20777 [5129];
    struct Blob_Generic_20812 [514c];
    struct Blob_Generic_20833 [5161];
    struct Blob_Generic_20882 [5192];
    struct Blob_Generic_20903 [51a7];
    struct Blob_Generic_20947 [51d3];
    struct Blob_Generic_20968 [51e8];
    struct Blob_Generic_20989 [51fd];
    struct Blob_Generic_21047 [5237];
    struct Blob_Generic_21105 [5271];
    struct Blob_Generic_21126 [5286];
    struct Blob_Generic_21169 [52b1];
    struct Blob_Generic_21190 [52c6];
    struct Blob_Generic_21211 [52db];
    struct Blob_Generic_21268 [5314];
    struct Blob_Generic_21325 [534d];
    struct Blob_Generic_21366 [5376];
    struct Blob_Generic_21387 [538b];
    struct Blob_Generic_21408 [53a0];
    struct Blob_Generic_21429 [53b5];
    struct Blob_Generic_21484 [53ec];
    struct Blob_Generic_21539 [5423];
    struct Blob_Generic_21560 [5438];
    struct Blob_Generic_21595 [545b];
    struct Blob_Generic_21616 [5470];
    struct Blob_Generic_21637 [5485];
    struct Blob_Generic_21686 [54b6];
    struct Blob_Generic_21735 [54e7];
    struct Blob_Generic_21756 [54fc];
    struct Blob_Generic_21777 [5511];
    struct Blob_Generic_21810 [5532];
    struct Blob_Generic_21831 [5547];
    struct Blob_Generic_21852 [555c];
    struct Blob_Generic_21899 [558b];
    struct Blob_Generic_21946 [55ba];
    struct Blob_Generic_21967 [55cf];
    struct Blob_Generic_21988 [55e4];
    struct Blob_Generic_22009 [55f9];
    struct Blob_Generic_22030 [560e];
    struct Blob_Generic_22051 [5623];
    struct Blob_Generic_22072 [5638];
    struct Blob_Generic_22093 [564d];
    struct Blob_Generic_22114 [5662];
    struct Blob_Generic_22154 [568a];
    struct Blob_Generic_22175 [569f];
    struct Blob_Generic_22229 [56d5];
    struct Blob_Generic_22250 [56ea];
    struct Blob_Generic_22292 [5714];
    struct Blob_Generic_22313 [5729];
    struct Blob_Generic_22369 [5761];
    struct Blob_Generic_22390 [5776];
    struct Blob_Generic_22411 [578b];
    struct Blob_Generic_22432 [57a0];
    struct Blob_Generic_22479 [57cf];
    struct Blob_Generic_22500 [57e4];
    struct Blob_Generic_22561 [5821];
    struct Blob_Generic_22582 [5836];
    struct Blob_Generic_22632 [5868];
    struct Blob_Generic_22653 [587d];
    struct Blob_Generic_22674 [5892];
    struct Blob_Generic_22738 [58d2];
    struct Blob_Generic_22802 [5912];
    struct Blob_Generic_22823 [5927];
    struct Blob_Generic_22874 [595a];
    struct Blob_Generic_22895 [596f];
    struct Blob_Generic_22916 [5984];
    struct Blob_Generic_22981 [59c5];
    struct Blob_Generic_23046 [5a06];
    struct Blob_Generic_23102 [5a3e];
    struct Blob_Generic_23123 [5a53];
    struct Blob_Generic_23144 [5a68];
    struct Blob_Generic_23165 [5a7d];
    struct Blob_Generic_23235 [5ac3];
    struct Blob_Generic_23305 [5b09];
    struct Blob_Generic_23362 [5b42];
    struct Blob_Generic_23383 [5b57];
    struct Blob_Generic_23404 [5b6c];
    struct Blob_Generic_23425 [5b81];
    struct Blob_Generic_23496 [5bc8];
    struct Blob_Generic_23567 [5c0f];
    struct Blob_Generic_23615 [5c3f];
    struct Blob_Generic_23636 [5c54];
    struct Blob_Generic_23657 [5c69];
    struct Blob_Generic_23678 [5c7e];
    struct Blob_Generic_23740 [5cbc];
    struct Blob_Generic_23802 [5cfa];
    struct Blob_Generic_23823 [5d0f];
    struct Blob_Generic_23872 [5d40];
    struct Blob_Generic_23893 [5d55];
    struct Blob_Generic_23914 [5d6a];
    struct Blob_Generic_23977 [5da9];
    struct Blob_Generic_24040 [5de8];
    struct Blob_Generic_24061 [5dfd];
    struct Blob_Generic_24116 [5e34];
    struct Blob_Generic_24137 [5e49];
    struct Blob_Generic_24158 [5e5e];
    struct Blob_Generic_24227 [5ea3];
    struct Blob_Generic_24296 [5ee8];
    struct Blob_Generic_24317 [5efd];
    struct Blob_Generic_24364 [5f2c];
    struct Blob_Generic_24385 [5f41];
    struct Blob_Generic_24406 [5f56];
    struct Blob_Generic_24467 [5f93];
    struct Blob_Generic_24528 [5fd0];
    struct Blob_Generic_24582 [6006];
    struct Blob_Generic_24603 [601b];
    struct Blob_Generic_24624 [6030];
    struct Blob_Generic_24692 [6074];
    struct Blob_Generic_24713 [6089];
    struct Blob_Generic_24734 [609e];
    struct Blob_Generic_24755 [60b3];
    struct Blob_Generic_24795 [60db];
    struct Blob_Generic_24816 [60f0];
    struct Blob_Generic_24870 [6126];
    struct Blob_Generic_24891 [613b];
    struct Blob_Generic_24912 [6150];
    struct Blob_Generic_24956 [617c];
    struct Blob_Generic_24977 [6191];
    struct Blob_Generic_25035 [61cb];
    struct Blob_Generic_25056 [61e0];
    struct Blob_Generic_25102 [620e];
    struct Blob_Generic_25123 [6223];
    struct Blob_Generic_25183 [625f];
    struct Blob_Generic_25204 [6274];
    struct Blob_Generic_25248 [62a0];
    struct Blob_Generic_25261 [62ad];
    struct Blob_Generic_25274 [62ba];
    struct Blob_Generic_25295 [62cf];
    struct Blob_Generic_25333 [62f5];
    struct Blob_Generic_25354 [630a];
    struct Blob_Generic_25406 [633e];
    struct Blob_Generic_25427 [6353];
    struct Blob_Generic_25473 [6381];
    struct Blob_Generic_25494 [6396];
    struct Blob_Generic_25554 [63d2];
    struct Blob_Generic_25570 [63e2];
    struct Blob_Generic_25586 [63f2];
    struct Blob_Generic_25602 [6402];
    struct Blob_Generic_25618 [6412];
    struct Blob_Generic_25634 [6422];
    struct Blob_Generic_25673 [6449];
    struct Blob_Generic_25694 [645e];
    struct Blob_Generic_25715 [6473];
    struct Blob_Generic_25768 [64a8];
    struct Blob_Generic_25789 [64bd];
    struct Blob_Generic_25805 [64cd];
    struct Blob_Generic_25821 [64dd];
    struct Blob_Generic_25861 [6505];
    struct Blob_Generic_25882 [651a];
    struct Blob_Generic_25903 [652f];
    struct Blob_Generic_25924 [6544];
    struct Blob_Generic_25978 [657a];
    struct Blob_Generic_26032 [65b0];
    struct Blob_Generic_26053 [65c5];
    struct Blob_Generic_26096 [65f0];
    struct Blob_Generic_26117 [6605];
    struct Blob_Generic_26138 [661a];
    struct Blob_Generic_26195 [6653];
    struct Blob_Generic_26252 [668c];
    struct Blob_Generic_26273 [66a1];
    struct Blob_Generic_26329 [66d9];
    struct Blob_Generic_26350 [66ee];
    struct Blob_Generic_26371 [6703];
    struct Blob_Generic_26441 [6749];
    struct Blob_Generic_26511 [678f];
    struct Blob_Generic_26563 [67c3];
    struct Blob_Generic_26584 [67d8];
    struct Blob_Generic_26605 [67ed];
    struct Blob_Generic_26626 [6802];
    struct Blob_Generic_26692 [6844];
    struct Blob_Generic_26758 [6886];
    struct Blob_Generic_26779 [689b];
    struct Blob_Generic_26826 [68ca];
    struct Blob_Generic_26847 [68df];
    struct Blob_Generic_26908 [691c];
    struct Blob_Generic_26929 [6931];
    struct Blob_Generic_26964 [6954];
    struct Blob_Generic_26985 [6969];
    struct Blob_Generic_27034 [699a];
    struct Blob_Generic_27055 [69af];
    struct Blob_Generic_27105 [69e1];
    struct Blob_Generic_27126 [69f6];
    struct Blob_Generic_27147 [6a0b];
    struct Blob_Generic_27211 [6a4b];
    struct Blob_Generic_27232 [6a60];
    struct Blob_Generic_27253 [6a75];
    struct Blob_Generic_27274 [6a8a];
    struct Blob_Generic_27328 [6ac0];
    struct Blob_Generic_27349 [6ad5];
    struct Blob_Generic_27370 [6aea];
    struct Blob_Generic_27438 [6b2e];
    struct Blob_Generic_27459 [6b43];
    struct Blob_Generic_27496 [6b68];
    struct Blob_Generic_27517 [6b7d];
    struct Blob_Generic_27568 [6bb0];
    struct Blob_Generic_27615 [6bdf];
    struct Blob_Generic_27636 [6bf4];
    struct Blob_Generic_27657 [6c09];
    struct Blob_Generic_27718 [6c46];
    struct Blob_Generic_27739 [6c5b];
    struct Blob_Generic_27760 [6c70];
    struct Blob_Generic_27781 [6c85];
    struct Blob_Generic_27802 [6c9a];
    struct Blob_Generic_27851 [6ccb];
    struct Blob_Generic_27872 [6ce0];
    struct Blob_Generic_27935 [6d1f];
    struct Blob_Generic_27956 [6d34];
    struct Blob_Generic_28007 [6d67];
    struct Blob_Generic_28028 [6d7c];
    struct Blob_Generic_28049 [6d91];
    struct Blob_Generic_28114 [6dd2];
    struct Blob_Generic_28179 [6e13];
    struct Blob_Generic_28228 [6e44];
    struct Blob_Generic_28249 [6e59];
    struct Blob_Generic_28270 [6e6e];
    struct Blob_Generic_28291 [6e83];
    struct Blob_Generic_28354 [6ec2];
    struct Blob_Generic_28417 [6f01];
    struct Blob_Generic_28454 [6f26];
    struct Blob_Generic_28475 [6f3b];
    struct Blob_Generic_28496 [6f50];
    struct Blob_Generic_28547 [6f83];
    struct Blob_Generic_28568 [6f98];
    struct Blob_Generic_28614 [6fc6];
    struct Blob_Generic_28635 [6fdb];
    struct Blob_Generic_28695 [7017];
    struct Blob_Generic_28716 [702c];
    struct Blob_Generic_28737 [7041];
    struct Blob_Generic_28758 [7056];
    struct Blob_Generic_28798 [707e];
    struct Blob_Generic_28819 [7093];
    struct Blob_Generic_28840 [70a8];
    struct Blob_Generic_28894 [70de];
    struct Blob_Generic_28915 [70f3];
    struct Blob_Generic_28960 [7120];
    struct Blob_Generic_28981 [7135];
    struct Blob_Generic_29040 [7170];
    struct Blob_Generic_29061 [7185];
    struct Blob_Generic_29082 [719a];
    struct Blob_Generic_29103 [71af];
    struct Blob_Generic_29124 [71c4];
    struct Blob_Generic_29162 [71ea];
    struct Blob_Generic_29183 [71ff];
    struct Blob_Generic_29204 [7214];
    struct Blob_Generic_29225 [7229];
    struct Blob_Generic_29277 [725d];
    struct Blob_Generic_29329 [7291];
    struct Blob_Generic_29350 [72a6];
    struct Blob_Generic_29389 [72cd];
    struct Blob_Generic_29410 [72e2];
    struct Blob_Generic_29431 [72f7];
    struct Blob_Generic_29484 [732c];
    struct Blob_Generic_29505 [7341];
    struct Blob_Generic_29542 [7366];
    struct Blob_Generic_29563 [737b];
    struct Blob_Generic_29584 [7390];
    struct Blob_Generic_29635 [73c3];
    struct Blob_Generic_29656 [73d8];
    struct Blob_Generic_29677 [73ed];
    struct Blob_Generic_29698 [7402];
    struct Blob_Generic_29719 [7417];
    struct Blob_Generic_29773 [744d];
    struct Blob_Generic_29794 [7462];
    struct Blob_Generic_29862 [74a6];
    struct Blob_Generic_29883 [74bb];
    struct Blob_Generic_29921 [74e1];
    struct Blob_Generic_29942 [74f6];
    struct Blob_Generic_29994 [752a];
    struct Blob_Generic_30015 [753f];
    struct Blob_Generic_30036 [7554];
    struct Blob_Generic_30057 [7569];
    struct Blob_Generic_30094 [758e];
    struct Blob_Generic_30115 [75a3];
    struct Blob_Generic_30166 [75d6];
    struct Blob_Generic_30187 [75eb];
    struct Blob_Generic_30229 [7615];
    struct Blob_Generic_30250 [762a];
    struct Blob_Generic_30306 [7662];
    struct Blob_Generic_30327 [7677];
    struct Blob_Generic_30348 [768c];
    struct Blob_Generic_30369 [76a1];
    struct Blob_Generic_30390 [76b6];
    struct Blob_Generic_30411 [76cb];
    struct Blob_Generic_30432 [76e0];
    struct Blob_Generic_30453 [76f5];
    struct Blob_Generic_30474 [770a];
    struct Blob_Generic_30495 [771f];
    struct Blob_Generic_30516 [7734];
    struct Blob_Generic_30550 [7756];
    struct Blob_Generic_30571 [776b];
    struct Blob_Generic_30592 [7780];
    struct Blob_Generic_30640 [77b0];
    struct Blob_Generic_30688 [77e0];
    struct Blob_Generic_30709 [77f5];
    struct Blob_Generic_30752 [7820];
    struct Blob_Generic_30773 [7835];
    struct Blob_Generic_30830 [786e];
    struct Blob_Generic_30876 [789c];
    struct Blob_Generic_30897 [78b1];
    struct Blob_Generic_30918 [78c6];
    struct Blob_Generic_30978 [7902];
    struct Blob_Generic_31019 [792b];
    struct Blob_Generic_31040 [7940];
    struct Blob_Generic_31061 [7955];
    struct Blob_Generic_31082 [796a];
    struct Blob_Generic_31137 [79a1];
    struct Blob_Generic_31192 [79d8];
    struct Blob_Generic_31245 [7a0d];
    struct Blob_Generic_31266 [7a22];
    struct Blob_Generic_31287 [7a37];
    struct Blob_Generic_31354 [7a7a];
    struct Blob_Generic_31375 [7a8f];
    struct Blob_Generic_31425 [7ac1];
    struct Blob_Generic_31446 [7ad6];
    struct Blob_Generic_31510 [7b16];
    struct Blob_Generic_31531 [7b2b];
    struct Blob_Generic_31578 [7b5a];
    struct Blob_Generic_31599 [7b6f];
    struct Blob_Generic_31660 [7bac];
    struct Blob_Generic_31695 [7bcf];
    struct Blob_Generic_31716 [7be4];
    struct Blob_Generic_31737 [7bf9];
    struct Blob_Generic_31786 [7c2a];
    struct Blob_Generic_31807 [7c3f];
    struct Blob_Generic_31856 [7c70];
    struct Blob_Generic_31877 [7c85];
    struct Blob_Generic_31898 [7c9a];
    struct Blob_Generic_31961 [7cd9];
    struct Blob_Generic_32024 [7d18];
    struct Blob_Generic_32055 [7d37];
    struct Blob_Generic_32076 [7d4c];
    struct Blob_Generic_32097 [7d61];
    struct Blob_Generic_32142 [7d8e];
    struct Blob_Generic_32163 [7da3];
    struct Blob_Generic_32211 [7dd3];
    struct Blob_Generic_32232 [7de8];
    struct Blob_Generic_32253 [7dfd];
    struct Blob_Generic_32315 [7e3b];
    struct Blob_Generic_32377 [7e79];
    struct Blob_Generic_32398 [7e8e];
    struct Blob_Generic_32458 [7eca];
    struct Blob_Generic_32479 [7edf];
    struct Blob_Generic_32553 [7f29];
    struct Blob_Generic_32574 [7f3e];
    struct Blob_Generic_32615 [7f67];
    struct Blob_Generic_32636 [7f7c];
    struct Blob_Generic_32657 [7f91];
    struct Blob_Generic_32712 [7fc8];
    struct Blob_Generic_32767 [7fff];
    struct Blob_Generic_32788 [8014];
    struct Blob_Generic_32823 [8037];
    struct Blob_Generic_32844 [804c];
    struct Blob_Generic_32865 [8061];
    struct Blob_Generic_32914 [8092];
    struct Blob_Generic_32963 [80c3];
    struct Blob_Generic_32984 [80d8];
    struct Blob_Generic_33005 [80ed];
    struct Blob_Generic_33038 [810e];
    struct Blob_Generic_33059 [8123];
    struct Blob_Generic_33080 [8138];
    struct Blob_Generic_33127 [8167];
    struct Blob_Generic_33174 [8196];
    struct Blob_Generic_33195 [81ab];
    struct Blob_Generic_33216 [81c0];
    struct Blob_Generic_33256 [81e8];
    struct Blob_Generic_33277 [81fd];
    struct Blob_Generic_33298 [8212];
    struct Blob_Generic_33319 [8227];
    struct Blob_Generic_33373 [825d];
    struct Blob_Generic_33427 [8293];
    struct Blob_Generic_33448 [82a8];
    struct Blob_Generic_33469 [82bd];
    struct Blob_Generic_33490 [82d2];
    struct Blob_Generic_33523 [82f3];
    struct Blob_Generic_33544 [8308];
    struct Blob_Generic_33565 [831d];
    struct Blob_Generic_33612 [834c];
    struct Blob_Generic_33633 [8361];
    struct Blob_Generic_33654 [8376];
    struct Blob_Generic_33675 [838b];
    struct Blob_Generic_33696 [83a0];
    struct Blob_Generic_33717 [83b5];
    struct Blob_Generic_33738 [83ca];
    struct Blob_Generic_33759 [83df];
    struct Blob_Generic_33780 [83f4];
    struct Blob_Generic_33801 [8409];
    struct Blob_Generic_33815 [8417];
    struct Blob_Generic_33829 [8425];
    struct Blob_Generic_33844 [8434];
    struct Blob_Generic_33859 [8443];
    struct Blob_Generic_33874 [8452];
    struct Blob_Generic_33895 [8467];
    struct Blob_Generic_33916 [847c];
    struct Blob_Generic_33937 [8491];
    struct Blob_Generic_33958 [84a6];
    struct Blob_Generic_33979 [84bb];
    struct Blob_Generic_34000 [84d0];
    struct Blob_Generic_34021 [84e5];
    struct Blob_Generic_34037 [84f5];
    struct Blob_Generic_34053 [8505];
    struct Blob_Generic_34089 [8529];
    struct Blob_Generic_34110 [853e];
    struct Blob_Generic_34131 [8553];
    struct Blob_Generic_34152 [8568];
    struct Blob_Generic_34202 [859a];
    struct Blob_Generic_34252 [85cc];
    struct Blob_Generic_34273 [85e1];
    struct Blob_Generic_34309 [8605];
    struct Blob_Generic_34330 [861a];
    struct Blob_Generic_34351 [862f];
    struct Blob_Generic_34401 [8661];
    struct Blob_Generic_34451 [8693];
    struct Blob_Generic_34492 [86bc];
    struct Blob_Generic_34513 [86d1];
    struct Blob_Generic_34534 [86e6];
    struct Blob_Generic_34589 [871d];
    struct Blob_Generic_34610 [8732];
    struct Blob_Generic_34648 [8758];
    struct Blob_Generic_34669 [876d];
    struct Blob_Generic_34690 [8782];
    struct Blob_Generic_34742 [87b6];
    struct Blob_Generic_34794 [87ea];
    struct Blob_Generic_34830 [880e];
    struct Blob_Generic_34851 [8823];
    struct Blob_Generic_34872 [8838];
    struct Blob_Generic_34893 [884d];
    struct Blob_Generic_34943 [887f];
    struct Blob_Generic_34993 [88b1];
    struct Blob_Generic_35039 [88df];
    struct Blob_Generic_35060 [88f4];
    struct Blob_Generic_35081 [8909];
    struct Blob_Generic_35102 [891e];
    struct Blob_Generic_35162 [895a];
    struct Blob_Generic_35222 [8996];
    struct Blob_Generic_35263 [89bf];
    struct Blob_Generic_35284 [89d4];
    struct Blob_Generic_35305 [89e9];
    struct Blob_Generic_35326 [89fe];
    struct Blob_Generic_35381 [8a35];
    struct Blob_Generic_35436 [8a6c];
    struct Blob_Generic_35457 [8a81];
    struct Blob_Generic_35513 [8ab9];
    struct Blob_Generic_35534 [8ace];
    struct Blob_Generic_35555 [8ae3];
    struct Blob_Generic_35625 [8b29];
    struct Blob_Generic_35695 [8b6f];
    struct Blob_Generic_35716 [8b84];
    struct Blob_Generic_35743 [8b9f];
    struct Blob_Generic_35764 [8bb4];
    struct Blob_Generic_35805 [8bdd];
    struct Blob_Generic_35846 [8c06];
    struct Blob_Generic_35867 [8c1b];
    struct Blob_Generic_35888 [8c30];
    struct Blob_Generic_35909 [8c45];
    struct Blob_Generic_35964 [8c7c];
    struct Blob_Generic_36019 [8cb3];
    struct Blob_Generic_36057 [8cd9];
    struct Blob_Generic_36078 [8cee];
    struct Blob_Generic_36099 [8d03];
    struct Blob_Generic_36151 [8d37];
    struct Blob_Generic_36172 [8d4c];
    struct Blob_Generic_36208 [8d70];
    struct Blob_Generic_36229 [8d85];
    struct Blob_Generic_36279 [8db7];
    struct Blob_Generic_36300 [8dcc];
    struct Blob_Generic_36336 [8df0];
    struct Blob_Generic_36357 [8e05];
    struct Blob_Generic_36378 [8e1a];
    struct Blob_Generic_36428 [8e4c];
    struct Blob_Generic_36478 [8e7e];
    struct Blob_Generic_36499 [8e93];
    struct Blob_Generic_36539 [8ebb];
    struct Blob_Generic_36560 [8ed0];
    struct Blob_Generic_36581 [8ee5];
    struct Blob_Generic_36635 [8f1b];
    struct Blob_Generic_36689 [8f51];
    struct Blob_Generic_36710 [8f66];
    struct Blob_Generic_36757 [8f95];
    struct Blob_Generic_36778 [8faa];
    struct Blob_Generic_36799 [8fbf];
    struct Blob_Generic_36860 [8ffc];
    struct Blob_Generic_36921 [9039];
    struct Blob_Generic_36942 [904e];
    struct Blob_Generic_37000 [9088];
    struct Blob_Generic_37021 [909d];
    struct Blob_Generic_37093 [90e5];
    struct Blob_Generic_37142 [9116];
    struct Blob_Generic_37163 [912b];
    struct Blob_Generic_37184 [9140];
    struct Blob_Generic_37205 [9155];
    struct Blob_Generic_37268 [9194];
    struct Blob_Generic_37331 [91d3];
    struct Blob_Generic_37352 [91e8];
    struct Blob_Generic_37397 [9215];
    struct Blob_Generic_37418 [922a];
    struct Blob_Generic_37439 [923f];
    struct Blob_Generic_37498 [927a];
    struct Blob_Generic_37557 [92b5];
    struct Blob_Generic_37578 [92ca];
    struct Blob_Generic_37619 [92f3];
    struct Blob_Generic_37640 [9308];
    struct Blob_Generic_37661 [931d];
    struct Blob_Generic_37716 [9354];
    struct Blob_Generic_37771 [938b];
    struct Blob_Generic_37792 [93a0];
    struct Blob_Generic_37831 [93c7];
    struct Blob_Generic_37852 [93dc];
    struct Blob_Generic_37873 [93f1];
    struct Blob_Generic_37926 [9426];
    struct Blob_Generic_37979 [945b];
    struct Blob_Generic_38000 [9470];
    struct Blob_Generic_38021 [9485];
    struct Blob_Generic_38064 [94b0];
    struct Blob_Generic_38085 [94c5];
    struct Blob_Generic_38106 [94da];
    struct Blob_Generic_38163 [9513];
    struct Blob_Generic_38220 [954c];
    struct Blob_Generic_38273 [9581];
    struct Blob_Generic_38294 [9596];
    struct Blob_Generic_38315 [95ab];
    struct Blob_Generic_38336 [95c0];
    struct Blob_Generic_38403 [9603];
    struct Blob_Generic_38470 [9646];
    struct Blob_Generic_38491 [965b];
    struct Blob_Generic_38530 [9682];
    struct Blob_Generic_38551 [9697];
    struct Blob_Generic_38572 [96ac];
    struct Blob_Generic_38625 [96e1];
    struct Blob_Generic_38678 [9716];
    struct Blob_Generic_38699 [972b];
    struct Blob_Generic_38720 [9740];
    struct Blob_Generic_38741 [9755];
    struct Blob_Generic_38762 [976a];
    struct Blob_Generic_38783 [977f];
    struct Blob_Generic_38804 [9794];
    struct Blob_Generic_38825 [97a9];
    struct Blob_Generic_38846 [97be];
    struct Blob_Generic_38867 [97d3];
    struct Blob_Generic_38888 [97e8];
    struct Blob_Generic_38909 [97fd];
    struct Blob_Generic_38930 [9812];
    struct Blob_Generic_38951 [9827];
    struct Blob_Generic_38972 [983c];
    struct Blob_Generic_38993 [9851];
    struct Blob_Generic_39014 [9866];
    struct Blob_Generic_39035 [987b];
    struct Blob_Generic_39056 [9890];
    struct Blob_Generic_39077 [98a5];
    struct Blob_Generic_39098 [98ba];
    struct Blob_Generic_39119 [98cf];
    struct Blob_Generic_39140 [98e4];
    struct Blob_Generic_39161 [98f9];
    struct Blob_Generic_39182 [990e];
    struct Blob_Generic_39203 [9923];
    struct Blob_Generic_39224 [9938];
    struct Blob_Generic_39245 [994d];
    struct Blob_Generic_39266 [9962];
    struct Blob_Generic_39287 [9977];
    struct Blob_Generic_39319 [9997];
    struct Blob_Generic_39340 [99ac];
    struct Blob_Generic_39361 [99c1];
    struct Blob_Generic_39382 [99d6];
    struct Blob_Generic_39428 [9a04];
    struct Blob_Generic_39474 [9a32];
    struct Blob_Generic_39495 [9a47];
    struct Blob_Generic_39527 [9a67];
    struct Blob_Generic_39548 [9a7c];
    struct Blob_Generic_39569 [9a91];
    struct Blob_Generic_39615 [9abf];
    struct Blob_Generic_39661 [9aed];
    struct Blob_Generic_39682 [9b02];
    struct Blob_Generic_39713 [9b21];
    struct Blob_Generic_39734 [9b36];
    struct Blob_Generic_39755 [9b4b];
    struct Blob_Generic_39800 [9b78];
    struct Blob_Generic_39845 [9ba5];
    struct Blob_Generic_39866 [9bba];
    struct Blob_Generic_39887 [9bcf];
    struct Blob_Generic_39908 [9be4];
    struct Blob_Generic_39929 [9bf9];
    struct Blob_Generic_39950 [9c0e];
    struct Blob_Generic_39971 [9c23];
    struct Blob_Generic_39992 [9c38];
    struct Blob_Generic_40013 [9c4d];
    struct Blob_Generic_40044 [9c6c];
    struct Blob_Generic_40065 [9c81];
    struct Blob_Generic_40110 [9cae];
    struct Blob_Generic_40131 [9cc3];
    struct Blob_Generic_40178 [9cf2];
    struct Blob_Generic_40199 [9d07];
    struct Blob_Generic_40220 [9d1c];
    struct Blob_Generic_40281 [9d59];
    struct Blob_Generic_40342 [9d96];
    struct Blob_Generic_40363 [9dab];
    struct Blob_Generic_40396 [9dcc];
    struct Blob_Generic_40417 [9de1];
    struct Blob_Generic_40438 [9df6];
    struct Blob_Generic_40485 [9e25];
    struct Blob_Generic_40532 [9e54];
    struct Blob_Generic_40564 [9e74];
    struct Blob_Generic_40585 [9e89];
    struct Blob_Generic_40606 [9e9e];
    struct Blob_Generic_40627 [9eb3];
    struct Blob_Generic_40673 [9ee1];
    struct Blob_Generic_40719 [9f0f];
    struct Blob_Generic_40740 [9f24];
    struct Blob_Generic_40761 [9f39];
    struct Blob_Generic_40782 [9f4e];
    struct Blob_Generic_40803 [9f63];
    struct Blob_Generic_40824 [9f78];
    struct Blob_Generic_40845 [9f8d];
    struct Blob_Generic_40866 [9fa2];
    struct Blob_Generic_40887 [9fb7];
    struct Blob_Generic_40908 [9fcc];
    struct Blob_Generic_40929 [9fe1];
    struct Blob_Generic_40950 [9ff6];
    struct Blob_Generic_40971 [a00b];
    struct Blob_Generic_40992 [a020];
    struct Blob_Generic_41013 [a035];
    struct Blob_Generic_41034 [a04a];
    struct Blob_Generic_41055 [a05f];
    struct Blob_Generic_41076 [a074];
    struct Blob_Generic_41097 [a089];
    struct Blob_Generic_41118 [a09e];
    struct Blob_Generic_41139 [a0b3];
    struct Blob_Generic_41160 [a0c8];
    struct Blob_Generic_41181 [a0dd];
    struct Blob_Generic_41202 [a0f2];
    struct Blob_Generic_41223 [a107];
    struct Blob_Generic_41244 [a11c];
    struct Blob_Generic_41265 [a131];
    struct Blob_Generic_41305 [a159];
    struct Blob_Generic_41326 [a16e];
    struct Blob_Generic_41347 [a183];
    struct Blob_Generic_41401 [a1b9];
    struct Blob_Generic_41422 [a1ce];
    struct Blob_Generic_41443 [a1e3];
    struct Blob_Generic_41464 [a1f8];
    struct Blob_Generic_41502 [a21e];
    struct Blob_Generic_41523 [a233];
    struct Blob_Generic_41544 [a248];
    struct Blob_Generic_41565 [a25d];
    struct Blob_Generic_41617 [a291];
    struct Blob_Generic_41669 [a2c5];
    struct Blob_Generic_41690 [a2da];
    struct Blob_Generic_41711 [a2ef];
    struct Blob_Generic_41732 [a304];
    struct Blob_Generic_41753 [a319];
    struct Blob_Generic_41792 [a340];
    struct Blob_Generic_41813 [a355];
    struct Blob_Generic_41834 [a36a];
    struct Blob_Generic_41887 [a39f];
    struct Blob_Generic_41940 [a3d4];
    struct Blob_Generic_41961 [a3e9];
    struct Blob_Generic_41982 [a3fe];
    struct Blob_Generic_42003 [a413];
    struct Blob_Generic_42024 [a428];
    struct Blob_Generic_42059 [a44b];
    struct Blob_Generic_42080 [a460];
    struct Blob_Generic_42129 [a491];
    struct Blob_Generic_42162 [a4b2];
    struct Blob_Generic_42183 [a4c7];
    struct Blob_Generic_42204 [a4dc];
    struct Blob_Generic_42225 [a4f1];
    struct Blob_Generic_42272 [a520];
    struct Blob_Generic_42319 [a54f];
    struct Blob_Generic_42340 [a564];
    struct Blob_Generic_42361 [a579];
    struct Blob_Generic_42382 [a58e];
    struct Blob_Generic_42403 [a5a3];
    struct Blob_Generic_42424 [a5b8];
    struct Blob_Generic_42445 [a5cd];
    struct Blob_Generic_42466 [a5e2];
    struct Blob_Generic_42499 [a603];
    struct Blob_Generic_42520 [a618];
    struct Blob_Generic_42567 [a647];
    struct Blob_Generic_42580 [a654];
    struct Blob_Generic_42593 [a661];
    struct Blob_Generic_42628 [a684];
    struct Blob_Generic_42649 [a699];
    struct Blob_Generic_42679 [a6b7];
    struct Blob_Generic_42700 [a6cc];
    struct Blob_Generic_42721 [a6e1];
    struct Blob_Generic_42742 [a6f6];
    struct Blob_Generic_42797 [a72d];
    struct Blob_Generic_42818 [a742];
    struct Blob_Generic_42839 [a757];
    struct Blob_Generic_42908 [a79c];
    struct Blob_Generic_42977 [a7e1];
    struct Blob_Generic_42998 [a7f6];
    struct Blob_Generic_43054 [a82e];
    struct Blob_Generic_43075 [a843];
    struct Blob_Generic_43096 [a858];
    struct Blob_Generic_43166 [a89e];
    struct Blob_Generic_43236 [a8e4];
    struct Blob_Generic_43293 [a91d];
    struct Blob_Generic_43314 [a932];
    struct Blob_Generic_43335 [a947];
    struct Blob_Generic_43356 [a95c];
    struct Blob_Generic_43427 [a9a3];
    struct Blob_Generic_43498 [a9ea];
    struct Blob_Generic_43519 [a9ff];
    struct Blob_Generic_43567 [aa2f];
    struct Blob_Generic_43588 [aa44];
    struct Blob_Generic_43609 [aa59];
    struct Blob_Generic_43671 [aa97];
    struct Blob_Generic_43733 [aad5];
    struct Blob_Generic_43754 [aaea];
    struct Blob_Generic_43806 [ab1e];
    struct Blob_Generic_43827 [ab33];
    struct Blob_Generic_43848 [ab48];
    struct Blob_Generic_43914 [ab8a];
    struct Blob_Generic_43980 [abcc];
    struct Blob_Generic_44039 [ac07];
    struct Blob_Generic_44060 [ac1c];
    struct Blob_Generic_44081 [ac31];
    struct Blob_Generic_44102 [ac46];
    struct Blob_Generic_44175 [ac8f];
    struct Blob_Generic_44248 [acd8];
    struct Blob_Generic_44306 [ad12];
    struct Blob_Generic_44327 [ad27];
    struct Blob_Generic_44348 [ad3c];
    struct Blob_Generic_44420 [ad84];
    struct Blob_Generic_44468 [adb4];
    struct Blob_Generic_44489 [adc9];
    struct Blob_Generic_44510 [adde];
    struct Blob_Generic_44572 [ae1c];
    struct Blob_Generic_44638 [ae5e];
    struct Blob_Generic_44659 [ae73];
    struct Blob_Generic_44680 [ae88];
    struct Blob_Generic_44701 [ae9d];
    struct Blob_Generic_44781 [aeed];
    struct Blob_Generic_44861 [af3d];
    struct Blob_Generic_44906 [af6a];
    struct Blob_Generic_44927 [af7f];
    struct Blob_Generic_44948 [af94];
    struct Blob_Generic_44969 [afa9];
    struct Blob_Generic_45028 [afe4];
    struct Blob_Generic_45087 [b01f];
    struct Blob_Generic_45108 [b034];
    struct Blob_Generic_45166 [b06e];
    struct Blob_Generic_45187 [b083];
    struct Blob_Generic_45208 [b098];
    struct Blob_Generic_45280 [b0e0];
    struct Blob_Generic_45352 [b128];
    struct Blob_Generic_45407 [b15f];
    struct Blob_Generic_45428 [b174];
    struct Blob_Generic_45449 [b189];
    struct Blob_Generic_45518 [b1ce];
    struct Blob_Generic_45539 [b1e3];
    struct Blob_Generic_45594 [b21a];
    struct Blob_Generic_45615 [b22f];
    struct Blob_Generic_45636 [b244];
    struct Blob_Generic_45705 [b289];
    struct Blob_Generic_45774 [b2ce];
    struct Blob_Generic_45828 [b304];
    struct Blob_Generic_45849 [b319];
    struct Blob_Generic_45870 [b32e];
    struct Blob_Generic_45938 [b372];
    struct Blob_Generic_45982 [b39e];
    struct Blob_Generic_46003 [b3b3];
    struct Blob_Generic_46024 [b3c8];
    struct Blob_Generic_46045 [b3dd];
    struct Blob_Generic_46103 [b417];
    struct Blob_Generic_46161 [b451];
    struct Blob_Generic_46203 [b47b];
    struct Blob_Generic_46224 [b490];
    struct Blob_Generic_46245 [b4a5];
    struct Blob_Generic_46266 [b4ba];
    struct Blob_Generic_46322 [b4f2];
    struct Blob_Generic_46378 [b52a];
    struct Blob_Generic_46399 [b53f];
    struct Blob_Generic_46443 [b56b];
    struct Blob_Generic_46464 [b580];
    struct Blob_Generic_46485 [b595];
    struct Blob_Generic_46543 [b5cf];
    struct Blob_Generic_46601 [b609];
    struct Blob_Generic_46622 [b61e];
    struct Blob_Generic_46643 [b633];
    struct Blob_Generic_46664 [b648];
    struct Blob_Generic_46707 [b673];
    struct Blob_Generic_46728 [b688];
    struct Blob_Generic_46785 [b6c1];
    struct Blob_Generic_46806 [b6d6];
    struct Blob_Generic_46849 [b701];
    struct Blob_Generic_46870 [b716];
    struct Blob_Generic_46891 [b72b];
    struct Blob_Generic_46948 [b764];
    struct Blob_Generic_47005 [b79d];
    struct Blob_Generic_47026 [b7b2];
    struct Blob_Generic_47069 [b7dd];
    struct Blob_Generic_47090 [b7f2];
    struct Blob_Generic_47111 [b807];
    struct Blob_Generic_47168 [b840];
    struct Blob_Generic_47225 [b879];
    struct Blob_Generic_47246 [b88e];
    struct Blob_Generic_47267 [b8a3];
    struct Blob_Generic_47288 [b8b8];
    struct Blob_Generic_47346 [b8f2];
    struct Blob_Generic_47367 [b907];
    struct Blob_Generic_47388 [b91c];
    struct Blob_Generic_47422 [b93e];
    struct Blob_Generic_47443 [b953];
    struct Blob_Generic_47464 [b968];
    struct Blob_Generic_47512 [b998];
    struct Blob_Generic_47560 [b9c8];
    struct Blob_Generic_47581 [b9dd];
    struct Blob_Generic_47624 [ba08];
    struct Blob_Generic_47645 [ba1d];
    struct Blob_Generic_47666 [ba32];
    struct Blob_Generic_47723 [ba6b];
    struct Blob_Generic_47780 [baa4];
    struct Blob_Generic_47820 [bacc];
    struct Blob_Generic_47841 [bae1];
    struct Blob_Generic_47862 [baf6];
    struct Blob_Generic_47883 [bb0b];
    struct Blob_Generic_47937 [bb41];
    struct Blob_Generic_47991 [bb77];
    struct Blob_Generic_48023 [bb97];
    struct Blob_Generic_48044 [bbac];
    struct Blob_Generic_48065 [bbc1];
    struct Blob_Generic_48111 [bbef];
    struct Blob_Generic_48148 [bc14];
    struct Blob_Generic_48169 [bc29];
    struct Blob_Generic_48190 [bc3e];
    struct Blob_Generic_48241 [bc71];
    struct Blob_Generic_48262 [bc86];
    struct Blob_Generic_48294 [bca6];
    struct Blob_Generic_48315 [bcbb];
    struct Blob_Generic_48361 [bce9];
    struct Blob_Generic_48397 [bd0d];
    struct Blob_Generic_48418 [bd22];
    struct Blob_Generic_48439 [bd37];
    struct Blob_Generic_48489 [bd69];
    struct Blob_Generic_48528 [bd90];
    struct Blob_Generic_48549 [bda5];
    struct Blob_Generic_48570 [bdba];
    struct Blob_Generic_48591 [bdcf];
    struct Blob_Generic_48644 [be04];
    struct Blob_Generic_48697 [be39];
    struct Blob_Generic_48736 [be60];
    struct Blob_Generic_48757 [be75];
    struct Blob_Generic_48778 [be8a];
    struct Blob_Generic_48799 [be9f];
    struct Blob_Generic_48852 [bed4];
    struct Blob_Generic_48905 [bf09];
    struct Blob_Generic_48926 [bf1e];
    struct Blob_Generic_48975 [bf4f];
    struct Blob_Generic_48996 [bf64];
    struct Blob_Generic_49017 [bf79];
    struct Blob_Generic_49080 [bfb8];
    struct Blob_Generic_49143 [bff7];
    struct Blob_Generic_49164 [c00c];
    struct Blob_Generic_49218 [c042];
    struct Blob_Generic_49239 [c057];
    struct Blob_Generic_49260 [c06c];
    struct Blob_Generic_49328 [c0b0];
    struct Blob_Generic_49396 [c0f4];
    struct Blob_Generic_49417 [c109];
    struct Blob_Generic_49476 [c144];
    struct Blob_Generic_49497 [c159];
    struct Blob_Generic_49570 [c1a2];
    struct Blob_Generic_49591 [c1b7];
    struct Blob_Generic_49626 [c1da];
    struct Blob_Generic_49647 [c1ef];
    struct Blob_Generic_49696 [c220];
    struct Blob_Generic_49717 [c235];
    struct Blob_Generic_49767 [c267];
    struct Blob_Generic_49788 [c27c];
    struct Blob_Generic_49809 [c291];
    struct Blob_Generic_49873 [c2d1];
    struct Blob_Generic_49937 [c311];
    struct Blob_Generic_49981 [c33d];
    struct Blob_Generic_50002 [c352];
    struct Blob_Generic_50023 [c367];
    struct Blob_Generic_50044 [c37c];
    struct Blob_Generic_50102 [c3b6];
    struct Blob_Generic_50160 [c3f0];
    struct Blob_Generic_50192 [c410];
    struct Blob_Generic_50213 [c425];
    struct Blob_Generic_50234 [c43a];
    struct Blob_Generic_50280 [c468];
    struct Blob_Generic_50335 [c49f];
    struct Blob_Generic_50356 [c4b4];
    struct Blob_Generic_50377 [c4c9];
    struct Blob_Generic_50398 [c4de];
    struct Blob_Generic_50467 [c523];
    struct Blob_Generic_50536 [c568];
    struct Blob_Generic_50557 [c57d];
    struct Blob_Generic_50588 [c59c];
    struct Blob_Generic_50609 [c5b1];
    struct Blob_Generic_50654 [c5de];
    struct Blob_Generic_50690 [c602];
    struct Blob_Generic_50711 [c617];
    struct Blob_Generic_50732 [c62c];
    struct Blob_Generic_50782 [c65e];
    struct Blob_Generic_50834 [c692];
    struct Blob_Generic_50855 [c6a7];
    struct Blob_Generic_50876 [c6bc];
    struct Blob_Generic_50897 [c6d1];
    struct Blob_Generic_50963 [c713];
    struct Blob_Generic_51029 [c755];
    struct Blob_Generic_51050 [c76a];
    struct Blob_Generic_51103 [c79f];
    struct Blob_Generic_51124 [c7b4];
    struct Blob_Generic_51145 [c7c9];
    struct Blob_Generic_51212 [c80c];
    struct Blob_Generic_51279 [c84f];
    struct Blob_Generic_51300 [c864];
    struct Blob_Generic_51361 [c8a1];
    struct Blob_Generic_51382 [c8b6];
    struct Blob_Generic_51457 [c901];
    struct Blob_Generic_51505 [c931];
    struct Blob_Generic_51526 [c946];
    struct Blob_Generic_51547 [c95b];
    struct Blob_Generic_51568 [c970];
    struct Blob_Generic_51630 [c9ae];
    struct Blob_Generic_51692 [c9ec];
    struct Blob_Generic_51713 [ca01];
    struct Blob_Generic_51746 [ca22];
    struct Blob_Generic_51767 [ca37];
    struct Blob_Generic_51788 [ca4c];
    struct Blob_Generic_51835 [ca7b];
    struct Blob_Generic_51882 [caaa];
    struct Blob_Generic_51929 [cad9];
    struct Blob_Generic_51950 [caee];
    struct Blob_Generic_51971 [cb03];
    struct Blob_Generic_51992 [cb18];
    struct Blob_Generic_52053 [cb55];
    struct Blob_Generic_52114 [cb92];
    struct Blob_Generic_52135 [cba7];
    struct Blob_Generic_52156 [cbbc];
    struct Blob_Generic_52204 [cbec];
    struct Blob_Generic_52225 [cc01];
    struct Blob_Generic_52246 [cc16];
    struct Blob_Generic_52308 [cc54];
    struct Blob_Generic_52370 [cc92];
    struct Blob_Generic_52418 [ccc2];
    struct Blob_Generic_52439 [ccd7];
    struct Blob_Generic_52460 [ccec];
    struct Blob_Generic_52481 [cd01];
    struct Blob_Generic_52543 [cd3f];
    struct Blob_Generic_52605 [cd7d];
    struct Blob_Generic_52637 [cd9d];
    struct Blob_Generic_52658 [cdb2];
    struct Blob_Generic_52679 [cdc7];
    struct Blob_Generic_52725 [cdf5];
    struct Blob_Generic_52746 [ce0a];
    struct Blob_Generic_52790 [ce36];
    struct Blob_Generic_52811 [ce4b];
    struct Blob_Generic_52855 [ce77];
    struct Blob_Generic_52876 [ce8c];
    struct Blob_Generic_52897 [cea1];
    struct Blob_Generic_52955 [cedb];
};



