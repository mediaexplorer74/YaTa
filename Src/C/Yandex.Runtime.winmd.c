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

typedef struct GenericInstType_29151 GenericInstType_29151, *PGenericInstType_29151;

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

typedef struct ValueType.conflict9 ValueType.conflict9, *PValueType.conflict9;

struct ValueType.conflict9 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x17
};

struct GenericInstType_29151 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict9 Type; // Generic Type
};

typedef struct GenericInstType_31079 GenericInstType_31079, *PGenericInstType_31079;

struct GenericInstType_31079 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_29029 GenericInstType_29029, *PGenericInstType_29029;

typedef struct ValueType ValueType, *PValueType;

struct ValueType {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x23
};

struct GenericInstType_29029 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType Type; // Generic Type
};

typedef struct GenericInstType_28339 GenericInstType_28339, *PGenericInstType_28339;

typedef struct ValueType.conflict6 ValueType.conflict6, *PValueType.conflict6;

struct ValueType.conflict6 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x14
};

struct GenericInstType_28339 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict6 Type; // Generic Type
};

typedef struct GenericInstType_28979 GenericInstType_28979, *PGenericInstType_28979;

typedef struct GenericInstType_28984 GenericInstType_28984, *PGenericInstType_28984;

struct GenericInstType_28984 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType Type; // Generic Type
};

struct GenericInstType_28979 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct GenericInstType_28984 Type; // Generic Type
};

typedef struct GenericInstType_29142 GenericInstType_29142, *PGenericInstType_29142;

struct GenericInstType_29142 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict9 Type; // Generic Type
};

typedef struct GenericInstType_28851 GenericInstType_28851, *PGenericInstType_28851;

typedef struct Class Class, *PClass;

struct Class {
    enum TypeCode Class; // Class
    byte Type; // TypeDefOrRefOrSpecEncoded
};

struct GenericInstType_28851 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct GenericInstType_31063 GenericInstType_31063, *PGenericInstType_31063;

struct GenericInstType_31063 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_28348 GenericInstType_28348, *PGenericInstType_28348;

typedef struct ValueType.conflict7 ValueType.conflict7, *PValueType.conflict7;

struct ValueType.conflict7 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x13
};

struct GenericInstType_28348 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict7 Type; // Generic Type
};

typedef struct GenericInstType_28865 GenericInstType_28865, *PGenericInstType_28865;

struct GenericInstType_28865 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct Class Type; // Generic Type
};

typedef struct GenericInstType_29170 GenericInstType_29170, *PGenericInstType_29170;

typedef struct GenericInstType_29175 GenericInstType_29175, *PGenericInstType_29175;

struct GenericInstType_29175 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

struct GenericInstType_29170 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct GenericInstType_29175 Type; // Generic Type
};

typedef struct GenericInstType_29050 GenericInstType_29050, *PGenericInstType_29050;

typedef struct ValueType.conflict8 ValueType.conflict8, *PValueType.conflict8;

struct ValueType.conflict8 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x18
};

struct GenericInstType_29050 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict8 Type; // Generic Type
};

typedef struct GenericInstType_28918 GenericInstType_28918, *PGenericInstType_28918;

typedef struct ValueType.conflict ValueType.conflict, *PValueType.conflict;

struct ValueType.conflict {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x24
};

struct GenericInstType_28918 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict Type; // Generic Type
};

typedef struct GenericInstType_28875 GenericInstType_28875, *PGenericInstType_28875;

struct GenericInstType_28875 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct GenericInstType_28913 GenericInstType_28913, *PGenericInstType_28913;

struct GenericInstType_28913 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct GenericInstType_28918 Type; // Generic Type
};

typedef struct GenericInstType_29045 GenericInstType_29045, *PGenericInstType_29045;

struct GenericInstType_29045 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct GenericInstType_29050 Type; // Generic Type
};

typedef struct GenericInstType_28994 GenericInstType_28994, *PGenericInstType_28994;

struct GenericInstType_28994 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct ValueType Type; // Generic Type
};

typedef struct GenericInstType_28357 GenericInstType_28357, *PGenericInstType_28357;

struct GenericInstType_28357 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_29204 GenericInstType_29204, *PGenericInstType_29204;

struct GenericInstType_29204 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_29183 GenericInstType_29183, *PGenericInstType_29183;

struct GenericInstType_29183 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_28928 GenericInstType_28928, *PGenericInstType_28928;

struct GenericInstType_28928 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct ValueType.conflict Type; // Generic Type
};

typedef struct GenericInstType_28889 GenericInstType_28889, *PGenericInstType_28889;

struct GenericInstType_28889 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct Class Type; // Generic Type
};

typedef struct GenericInstType_29212 GenericInstType_29212, *PGenericInstType_29212;

struct GenericInstType_29212 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_29059 GenericInstType_29059, *PGenericInstType_29059;

struct GenericInstType_29059 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct ValueType.conflict8 Type; // Generic Type
};

typedef struct GenericInstType_29192 GenericInstType_29192, *PGenericInstType_29192;

typedef struct GenericInstType_29196 GenericInstType_29196, *PGenericInstType_29196;

struct GenericInstType_29196 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

struct GenericInstType_29192 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct GenericInstType_29196 Type; // Generic Type
};

typedef struct GenericInstType_29073 GenericInstType_29073, *PGenericInstType_29073;

struct GenericInstType_29073 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict8 Type; // Generic Type
};

typedef struct GenericInstType_28939 GenericInstType_28939, *PGenericInstType_28939;

typedef struct GenericInstType_28943 GenericInstType_28943, *PGenericInstType_28943;

struct GenericInstType_28943 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict Type; // Generic Type
};

struct GenericInstType_28939 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct GenericInstType_28943 Type; // Generic Type
};

typedef struct GenericInstType_28899 GenericInstType_28899, *PGenericInstType_28899;

struct GenericInstType_28899 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct GenericInstType_29069 GenericInstType_29069, *PGenericInstType_29069;

struct GenericInstType_29069 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct GenericInstType_29073 Type; // Generic Type
};

typedef struct GenericInstType_29224 GenericInstType_29224, *PGenericInstType_29224;

struct GenericInstType_29224 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_29105 GenericInstType_29105, *PGenericInstType_29105;

typedef struct GenericInstType_29110 GenericInstType_29110, *PGenericInstType_29110;

struct GenericInstType_29110 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict9 Type; // Generic Type
};

struct GenericInstType_29105 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct GenericInstType_29110 Type; // Generic Type
};

typedef struct GenericInstType_29082 GenericInstType_29082, *PGenericInstType_29082;

struct GenericInstType_29082 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict8 Type; // Generic Type
};

typedef struct GenericInstType_29119 GenericInstType_29119, *PGenericInstType_29119;

struct GenericInstType_29119 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct ValueType.conflict9 Type; // Generic Type
};

typedef struct Class.conflict Class.conflict, *PClass.conflict;

struct Class.conflict {
    enum TypeCode Class; // Class
    word Type; // TypeDefOrRefOrSpecEncoded
};

typedef struct GenericInstType_29236 GenericInstType_29236, *PGenericInstType_29236;

struct GenericInstType_29236 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_29091 GenericInstType_29091, *PGenericInstType_29091;

struct GenericInstType_29091 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict8 Type; // Generic Type
};

typedef struct GenericInstType_28953 GenericInstType_28953, *PGenericInstType_28953;

struct GenericInstType_28953 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict Type; // Generic Type
};

typedef struct GenericInstType_29129 GenericInstType_29129, *PGenericInstType_29129;

typedef struct GenericInstType_29133 GenericInstType_29133, *PGenericInstType_29133;

struct GenericInstType_29133 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict9 Type; // Generic Type
};

struct GenericInstType_29129 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct GenericInstType_29133 Type; // Generic Type
};

typedef struct GenericInstType_29009 GenericInstType_29009, *PGenericInstType_29009;

struct GenericInstType_29009 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType Type; // Generic Type
};

typedef struct ValueType.conflict5 ValueType.conflict5, *PValueType.conflict5;

struct ValueType.conflict5 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0xa
};

typedef struct GenericInstType_29005 GenericInstType_29005, *PGenericInstType_29005;

struct GenericInstType_29005 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct GenericInstType_29009 Type; // Generic Type
};

typedef struct GenericInstType_29248 GenericInstType_29248, *PGenericInstType_29248;

struct GenericInstType_29248 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct SzArray_29165 SzArray_29165, *PSzArray_29165;

struct SzArray_29165 {
    enum TypeCode TypeCode; // SzArray
    enum TypeCode Type; // type or void
};

typedef struct ValueType.conflict3 ValueType.conflict3, *PValueType.conflict3;

struct ValueType.conflict3 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x50
};

typedef struct ValueType.conflict4 ValueType.conflict4, *PValueType.conflict4;

struct ValueType.conflict4 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x8
};

typedef struct GenericInstType_29260 GenericInstType_29260, *PGenericInstType_29260;

struct GenericInstType_29260 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct ValueType.conflict1 ValueType.conflict1, *PValueType.conflict1;

struct ValueType.conflict1 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x34
};

typedef struct ValueType.conflict2 ValueType.conflict2, *PValueType.conflict2;

struct ValueType.conflict2 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeDef: Row 0x35
};

typedef struct GenericInstType_28963 GenericInstType_28963, *PGenericInstType_28963;

struct GenericInstType_28963 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType.conflict Type; // Generic Type
};

typedef struct GenericInstType_29019 GenericInstType_29019, *PGenericInstType_29019;

struct GenericInstType_29019 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ValueType Type; // Generic Type
};

typedef struct GenericInstType_28202 GenericInstType_28202, *PGenericInstType_28202;

struct GenericInstType_28202 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
};

typedef struct GenericInstType_28841 GenericInstType_28841, *PGenericInstType_28841;

struct GenericInstType_28841 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    enum TypeCode Type; // Generic Type
    struct Class Type; // Generic Type
};

typedef struct Blob_PropertySig_277 Blob_PropertySig_277, *PBlob_PropertySig_277;

typedef struct PropertySig_277 PropertySig_277, *PPropertySig_277;

typedef struct Type_28356 Type_28356, *PType_28356;

struct Type_28356 {
    struct GenericInstType_28357 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_277 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28356 RetType; // Return type
};

struct Blob_PropertySig_277 {
    byte Size; // coded integer - blob size
    struct PropertySig_277 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1112 Blob_Generic_1112, *PBlob_Generic_1112;

struct Blob_Generic_1112 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_663 Blob_Generic_663, *PBlob_Generic_663;

struct Blob_Generic_663 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_420 Blob_Generic_420, *PBlob_Generic_420;

struct Blob_Generic_420 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_3777 Blob_Generic_3777, *PBlob_Generic_3777;

struct Blob_Generic_3777 {
    byte Size; // coded integer - blob size
    byte Generic[41]; // Undefined blob contents
};

typedef struct Blob_Generic_4624 Blob_Generic_4624, *PBlob_Generic_4624;

struct Blob_Generic_4624 {
    byte Size; // coded integer - blob size
    byte Generic[72]; // Undefined blob contents
};

typedef struct Blob_Generic_424 Blob_Generic_424, *PBlob_Generic_424;

struct Blob_Generic_424 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_FieldSig_2962 Blob_FieldSig_2962, *PBlob_FieldSig_2962;

typedef struct FieldSig_2962 FieldSig_2962, *PFieldSig_2962;

typedef struct Type_31040 Type_31040, *PType_31040;

struct Type_31040 {
    struct ValueType ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_2962 {
    byte FIELD; // Magic (0x06)
    struct Type_31040 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_2962 {
    byte Size; // coded integer - blob size
    struct FieldSig_2962 FieldSig; // Type information for Field
};

typedef struct Blob_FieldSig_2967 Blob_FieldSig_2967, *PBlob_FieldSig_2967;

typedef struct FieldSig_2967 FieldSig_2967, *PFieldSig_2967;

typedef struct Type_31045 Type_31045, *PType_31045;

struct Type_31045 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct FieldSig_2967 {
    byte FIELD; // Magic (0x06)
    struct Type_31045 ELEMENT_TYPE_U4;
};

struct Blob_FieldSig_2967 {
    byte Size; // coded integer - blob size
    struct FieldSig_2967 FieldSig; // Type information for Field
};

typedef struct Blob_PropertySig_268 Blob_PropertySig_268, *PBlob_PropertySig_268;

typedef struct PropertySig_268 PropertySig_268, *PPropertySig_268;

typedef struct Type_28347 Type_28347, *PType_28347;

struct Type_28347 {
    struct GenericInstType_28348 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_268 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28347 RetType; // Return type
};

struct Blob_PropertySig_268 {
    byte Size; // coded integer - blob size
    struct PropertySig_268 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_14 Blob_Generic_14, *PBlob_Generic_14;

struct Blob_Generic_14 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_412 Blob_Generic_412, *PBlob_Generic_412;

struct Blob_Generic_412 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5964 Blob_Generic_5964, *PBlob_Generic_5964;

struct Blob_Generic_5964 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_FieldSig_2959 Blob_FieldSig_2959, *PBlob_FieldSig_2959;

typedef struct FieldSig_2959 FieldSig_2959, *PFieldSig_2959;

typedef struct Type_31037 Type_31037, *PType_31037;

struct Type_31037 {
    enum TypeCode ELEMENT_TYPE_I4;
};

struct FieldSig_2959 {
    byte FIELD; // Magic (0x06)
    struct Type_31037 ELEMENT_TYPE_I4;
};

struct Blob_FieldSig_2959 {
    byte Size; // coded integer - blob size
    struct FieldSig_2959 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_3300 Blob_Generic_3300, *PBlob_Generic_3300;

struct Blob_Generic_3300 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_893 Blob_Generic_893, *PBlob_Generic_893;

struct Blob_Generic_893 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_10 Blob_Generic_10, *PBlob_Generic_10;

struct Blob_Generic_10 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_3305 Blob_Generic_3305, *PBlob_Generic_3305;

struct Blob_Generic_3305 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_3547 Blob_Generic_3547, *PBlob_Generic_3547;

struct Blob_Generic_3547 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_899 Blob_Generic_899, *PBlob_Generic_899;

struct Blob_Generic_899 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_1124 Blob_Generic_1124, *PBlob_Generic_1124;

struct Blob_Generic_1124 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_4879 Blob_Generic_4879, *PBlob_Generic_4879;

struct Blob_Generic_4879 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18 Blob_Generic_18, *PBlob_Generic_18;

struct Blob_Generic_18 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_400 Blob_Generic_400, *PBlob_Generic_400;

struct Blob_Generic_400 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_883 Blob_Generic_883, *PBlob_Generic_883;

struct Blob_Generic_883 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_1132 Blob_Generic_1132, *PBlob_Generic_1132;

struct Blob_Generic_1132 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5733 Blob_Generic_5733, *PBlob_Generic_5733;

struct Blob_Generic_5733 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_408 Blob_Generic_408, *PBlob_Generic_408;

struct Blob_Generic_408 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_649 Blob_Generic_649, *PBlob_Generic_649;

struct Blob_Generic_649 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_PropertySig_259 Blob_PropertySig_259, *PBlob_PropertySig_259;

typedef struct PropertySig_259 PropertySig_259, *PPropertySig_259;

typedef struct Type_28338 Type_28338, *PType_28338;

struct Type_28338 {
    struct GenericInstType_28339 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_259 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28338 RetType; // Return type
};

struct Blob_PropertySig_259 {
    byte Size; // coded integer - blob size
    struct PropertySig_259 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1140 Blob_Generic_1140, *PBlob_Generic_1140;

struct Blob_Generic_1140 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_1144 Blob_Generic_1144, *PBlob_Generic_1144;

struct Blob_Generic_1144 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_873 Blob_Generic_873, *PBlob_Generic_873;

struct Blob_Generic_873 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3320 Blob_Generic_3320, *PBlob_Generic_3320;

struct Blob_Generic_3320 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3326 Blob_Generic_3326, *PBlob_Generic_3326;

struct Blob_Generic_3326 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_3568 Blob_Generic_3568, *PBlob_Generic_3568;

struct Blob_Generic_3568 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5985 Blob_Generic_5985, *PBlob_Generic_5985;

struct Blob_Generic_5985 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_639 Blob_Generic_639, *PBlob_Generic_639;

struct Blob_Generic_639 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_221 Blob_Generic_221, *PBlob_Generic_221;

struct Blob_Generic_221 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_1152 Blob_Generic_1152, *PBlob_Generic_1152;

struct Blob_Generic_1152 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_460 Blob_Generic_460, *PBlob_Generic_460;

struct Blob_Generic_460 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_5754 Blob_Generic_5754, *PBlob_Generic_5754;

struct Blob_Generic_5754 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1156 Blob_Generic_1156, *PBlob_Generic_1156;

struct Blob_Generic_1156 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3333 Blob_Generic_3333, *PBlob_Generic_3333;

struct Blob_Generic_3333 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_3339 Blob_MethodRefSig_3339, *PBlob_MethodRefSig_3339;

typedef struct MethodRefSig_3339 MethodRefSig_3339, *PMethodRefSig_3339;

typedef struct Type_31418 Type_31418, *PType_31418;

typedef struct Type_31419 Type_31419, *PType_31419;

struct Type_31418 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_31419 {
    struct ValueType.conflict5 ELEMENT_TYPE_VALUETYPE;
};

struct MethodRefSig_3339 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_31418 RetType;
    struct Type_31419 Param0;
};

struct Blob_MethodRefSig_3339 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_3339 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_48 Blob_Generic_48, *PBlob_Generic_48;

struct Blob_Generic_48 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_43 Blob_Generic_43, *PBlob_Generic_43;

struct Blob_Generic_43 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_26 Blob_PropertySig_26, *PBlob_PropertySig_26;

typedef struct PropertySig_26 PropertySig_26, *PPropertySig_26;

typedef struct Type_28105 Type_28105, *PType_28105;

struct Type_28105 {
    enum TypeCode ELEMENT_TYPE_BOOLEAN;
};

struct PropertySig_26 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28105 RetType; // Return type
};

struct Blob_PropertySig_26 {
    byte Size; // coded integer - blob size
    struct PropertySig_26 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2489 Blob_Generic_2489, *PBlob_Generic_2489;

struct Blob_Generic_2489 {
    byte Size; // coded integer - blob size
    byte Generic[106]; // Undefined blob contents
};

typedef struct Blob_Generic_4429 Blob_Generic_4429, *PBlob_Generic_4429;

struct Blob_Generic_4429 {
    byte Size; // coded integer - blob size
    byte Generic[58]; // Undefined blob contents
};

typedef struct Blob_Generic_5518 Blob_Generic_5518, *PBlob_Generic_5518;

struct Blob_Generic_5518 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3339 Blob_Generic_3339, *PBlob_Generic_3339;

struct Blob_Generic_3339 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_34 Blob_PropertySig_34, *PBlob_PropertySig_34;

typedef struct PropertySig_34 PropertySig_34, *PPropertySig_34;

typedef struct Type_28113 Type_28113, *PType_28113;

struct Type_28113 {
    enum TypeCode ELEMENT_TYPE_OBJECT;
};

struct PropertySig_34 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28113 RetType; // Return type
};

struct Blob_PropertySig_34 {
    byte Size; // coded integer - blob size
    struct PropertySig_34 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_694 Blob_Generic_694, *PBlob_Generic_694;

struct Blob_Generic_694 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_451 Blob_Generic_451, *PBlob_Generic_451;

struct Blob_Generic_451 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3345 Blob_Generic_3345, *PBlob_Generic_3345;

struct Blob_Generic_3345 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_212 Blob_Generic_212, *PBlob_Generic_212;

struct Blob_Generic_212 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_1164 Blob_Generic_1164, *PBlob_Generic_1164;

struct Blob_Generic_1164 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_59 Blob_Generic_59, *PBlob_Generic_59;

struct Blob_Generic_59 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3101 Blob_Generic_3101, *PBlob_Generic_3101;

struct Blob_Generic_3101 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_53 Blob_Generic_53, *PBlob_Generic_53;

struct Blob_Generic_53 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3107 Blob_Generic_3107, *PBlob_Generic_3107;

struct Blob_Generic_3107 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_1168 Blob_Generic_1168, *PBlob_Generic_1168;

struct Blob_Generic_1168 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3589 Blob_Generic_3589, *PBlob_Generic_3589;

struct Blob_Generic_3589 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_3326 Blob_MethodRefSig_3326, *PBlob_MethodRefSig_3326;

typedef struct MethodRefSig_3326 MethodRefSig_3326, *PMethodRefSig_3326;

typedef struct Type_31405 Type_31405, *PType_31405;

typedef struct Type_31406 Type_31406, *PType_31406;

typedef struct Type_31408 Type_31408, *PType_31408;

struct Type_31408 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct Type_31406 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct Type_31405 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_3326 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_31405 RetType;
    struct Type_31406 Param0;
    struct Type_31408 Param1;
};

struct Blob_MethodRefSig_3326 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_3326 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodRefSig_3333 Blob_MethodRefSig_3333, *PBlob_MethodRefSig_3333;

typedef struct MethodRefSig_3333 MethodRefSig_3333, *PMethodRefSig_3333;

typedef struct Type_31412 Type_31412, *PType_31412;

typedef struct Type_31413 Type_31413, *PType_31413;

struct Type_31412 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_31413 {
    struct ValueType.conflict4 ELEMENT_TYPE_VALUETYPE;
};

struct MethodRefSig_3333 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_31412 RetType;
    struct Type_31413 Param0;
};

struct Blob_MethodRefSig_3333 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_3333 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_3350 Blob_Generic_3350, *PBlob_Generic_3350;

struct Blob_Generic_3350 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3113 Blob_Generic_3113, *PBlob_Generic_3113;

struct Blob_Generic_3113 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3355 Blob_Generic_3355, *PBlob_Generic_3355;

struct Blob_Generic_3355 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_5775 Blob_Generic_5775, *PBlob_Generic_5775;

struct Blob_Generic_5775 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_26 Blob_Generic_26, *PBlob_Generic_26;

struct Blob_Generic_26 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_442 Blob_Generic_442, *PBlob_Generic_442;

struct Blob_Generic_442 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_1176 Blob_Generic_1176, *PBlob_Generic_1176;

struct Blob_Generic_1176 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_3118 Blob_Generic_3118, *PBlob_Generic_3118;

struct Blob_Generic_3118 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_689 Blob_Generic_689, *PBlob_Generic_689;

struct Blob_Generic_689 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_22 Blob_Generic_22, *PBlob_Generic_22;

struct Blob_Generic_22 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_204 Blob_Generic_204, *PBlob_Generic_204;

struct Blob_Generic_204 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_3320 Blob_MethodRefSig_3320, *PBlob_MethodRefSig_3320;

typedef struct MethodRefSig_3320 MethodRefSig_3320, *PMethodRefSig_3320;

typedef struct Type_31399 Type_31399, *PType_31399;

typedef struct Type_31400 Type_31400, *PType_31400;

struct Type_31399 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_31400 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct MethodRefSig_3320 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_31399 RetType;
    struct Type_31400 Param0;
};

struct Blob_MethodRefSig_3320 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_3320 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_5539 Blob_Generic_5539, *PBlob_Generic_5539;

struct Blob_Generic_5539 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_PropertySig_2983 Blob_PropertySig_2983, *PBlob_PropertySig_2983;

typedef struct PropertySig_2983 PropertySig_2983, *PPropertySig_2983;

typedef struct Type_31062 Type_31062, *PType_31062;

struct Type_31062 {
    struct GenericInstType_31063 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2983 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_31062 RetType; // Return type
};

struct Blob_PropertySig_2983 {
    byte Size; // coded integer - blob size
    struct PropertySig_2983 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1180 Blob_Generic_1180, *PBlob_Generic_1180;

struct Blob_Generic_1180 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_30 Blob_Generic_30, *PBlob_Generic_30;

struct Blob_Generic_30 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_3360 Blob_Generic_3360, *PBlob_Generic_3360;

struct Blob_Generic_3360 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_1188 Blob_Generic_1188, *PBlob_Generic_1188;

struct Blob_Generic_1188 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_4697 Blob_Generic_4697, *PBlob_Generic_4697;

struct Blob_Generic_4697 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_38 Blob_Generic_38, *PBlob_Generic_38;

struct Blob_Generic_38 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_432 Blob_Generic_432, *PBlob_Generic_432;

struct Blob_Generic_432 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_674 Blob_Generic_674, *PBlob_Generic_674;

struct Blob_Generic_674 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_3365 Blob_Generic_3365, *PBlob_Generic_3365;

struct Blob_Generic_3365 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3123 Blob_Generic_3123, *PBlob_Generic_3123;

struct Blob_Generic_3123 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_437 Blob_Generic_437, *PBlob_Generic_437;

struct Blob_Generic_437 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_5306 Blob_Generic_5306, *PBlob_Generic_5306;

struct Blob_Generic_5306 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_34 Blob_Generic_34, *PBlob_Generic_34;

struct Blob_Generic_34 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_3305 Blob_MethodRefSig_3305, *PBlob_MethodRefSig_3305;

typedef struct MethodRefSig_3305 MethodRefSig_3305, *PMethodRefSig_3305;

typedef struct Type_31384 Type_31384, *PType_31384;

typedef struct Type_31385 Type_31385, *PType_31385;

typedef struct Type_31386 Type_31386, *PType_31386;

typedef struct Type_31387 Type_31387, *PType_31387;

typedef struct Type_31388 Type_31388, *PType_31388;

typedef struct Type_31389 Type_31389, *PType_31389;

typedef struct Type_31390 Type_31390, *PType_31390;

typedef struct Type_31391 Type_31391, *PType_31391;

typedef struct Type_31392 Type_31392, *PType_31392;

typedef struct Type_31393 Type_31393, *PType_31393;

typedef struct Type_31394 Type_31394, *PType_31394;

typedef struct Type_31395 Type_31395, *PType_31395;

struct Type_31384 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_31395 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_31385 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct Type_31386 {
    enum TypeCode ELEMENT_TYPE_U2;
};

struct Type_31387 {
    enum TypeCode ELEMENT_TYPE_U2;
};

struct Type_31391 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_31392 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_31389 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_31390 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_31393 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_31388 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_31394 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct MethodRefSig_3305 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_31384 RetType;
    struct Type_31385 Param0;
    struct Type_31386 Param1;
    struct Type_31387 Param2;
    struct Type_31388 Param3;
    struct Type_31389 Param4;
    struct Type_31390 Param5;
    struct Type_31391 Param6;
    struct Type_31392 Param7;
    struct Type_31393 Param8;
    struct Type_31394 Param9;
    struct Type_31395 Param10;
};

struct Blob_MethodRefSig_3305 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_3305 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_PropertySig_2999 Blob_PropertySig_2999, *PBlob_PropertySig_2999;

typedef struct PropertySig_2999 PropertySig_2999, *PPropertySig_2999;

typedef struct Type_31078 Type_31078, *PType_31078;

struct Type_31078 {
    struct GenericInstType_31079 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_2999 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_31078 RetType; // Return type
};

struct Blob_PropertySig_2999 {
    byte Size; // coded integer - blob size
    struct PropertySig_2999 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_MethodRefSig_3300 Blob_MethodRefSig_3300, *PBlob_MethodRefSig_3300;

typedef struct MethodRefSig_3300 MethodRefSig_3300, *PMethodRefSig_3300;

typedef struct Type_31379 Type_31379, *PType_31379;

typedef struct Type_31380 Type_31380, *PType_31380;

struct Type_31379 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_31380 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct MethodRefSig_3300 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_31379 RetType;
    struct Type_31380 Param0;
};

struct Blob_MethodRefSig_3300 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_3300 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_828 Blob_Generic_828, *PBlob_Generic_828;

struct Blob_Generic_828 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3937 Blob_Generic_3937, *PBlob_Generic_3937;

struct Blob_Generic_3937 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_Generic_819 Blob_Generic_819, *PBlob_Generic_819;

struct Blob_Generic_819 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3707 Blob_Generic_3707, *PBlob_Generic_3707;

struct Blob_Generic_3707 {
    byte Size; // coded integer - blob size
    byte Generic[27]; // Undefined blob contents
};

typedef struct Blob_PropertySig_893 Blob_PropertySig_893, *PBlob_PropertySig_893;

typedef struct PropertySig_893 PropertySig_893, *PPropertySig_893;

typedef struct Type_28972 Type_28972, *PType_28972;

struct Type_28972 {
    struct ValueType.conflict ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_893 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28972 RetType; // Return type
};

struct Blob_PropertySig_893 {
    byte Size; // coded integer - blob size
    struct PropertySig_893 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_804 Blob_Generic_804, *PBlob_Generic_804;

struct Blob_Generic_804 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_4802 Blob_Generic_4802, *PBlob_Generic_4802;

struct Blob_Generic_4802 {
    byte Size; // coded integer - blob size
    byte Generic[76]; // Undefined blob contents
};

typedef struct Blob_Generic_809 Blob_Generic_809, *PBlob_Generic_809;

struct Blob_Generic_809 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_899 Blob_PropertySig_899, *PBlob_PropertySig_899;

typedef struct PropertySig_899 PropertySig_899, *PPropertySig_899;

typedef struct Type_28978 Type_28978, *PType_28978;

struct Type_28978 {
    struct GenericInstType_28979 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_899 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28978 RetType; // Return type
};

struct Blob_PropertySig_899 {
    byte Size; // coded integer - blob size
    struct PropertySig_899 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_883 Blob_PropertySig_883, *PBlob_PropertySig_883;

typedef struct PropertySig_883 PropertySig_883, *PPropertySig_883;

typedef struct Type_28962 Type_28962, *PType_28962;

struct Type_28962 {
    struct GenericInstType_28963 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_883 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28962 RetType; // Return type
};

struct Blob_PropertySig_883 {
    byte Size; // coded integer - blob size
    struct PropertySig_883 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2878 Blob_Generic_2878, *PBlob_Generic_2878;

struct Blob_Generic_2878 {
    byte Size; // coded integer - blob size
    byte Generic[80]; // Undefined blob contents
};

typedef struct Blob_PropertySig_873 Blob_PropertySig_873, *PBlob_PropertySig_873;

typedef struct PropertySig_873 PropertySig_873, *PPropertySig_873;

typedef struct Type_28952 Type_28952, *PType_28952;

struct Type_28952 {
    struct GenericInstType_28953 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_873 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28952 RetType; // Return type
};

struct Blob_PropertySig_873 {
    byte Size; // coded integer - blob size
    struct PropertySig_873 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_623 Blob_Generic_623, *PBlob_Generic_623;

struct Blob_Generic_623 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_629 Blob_Generic_629, *PBlob_Generic_629;

struct Blob_Generic_629 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3735 Blob_Generic_3735, *PBlob_Generic_3735;

struct Blob_Generic_3735 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5922 Blob_Generic_5922, *PBlob_Generic_5922;

struct Blob_Generic_5922 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_859 Blob_Generic_859, *PBlob_Generic_859;

struct Blob_Generic_859 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_3756 Blob_Generic_3756, *PBlob_Generic_3756;

struct Blob_Generic_3756 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_848 Blob_Generic_848, *PBlob_Generic_848;

struct Blob_Generic_848 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_608 Blob_Generic_608, *PBlob_Generic_608;

struct Blob_Generic_608 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_PropertySig_859 Blob_PropertySig_859, *PBlob_PropertySig_859;

typedef struct PropertySig_859 PropertySig_859, *PPropertySig_859;

typedef struct Type_28938 Type_28938, *PType_28938;

struct Type_28938 {
    struct GenericInstType_28939 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_859 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28938 RetType; // Return type
};

struct Blob_PropertySig_859 {
    byte Size; // coded integer - blob size
    struct PropertySig_859 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_5943 Blob_Generic_5943, *PBlob_Generic_5943;

struct Blob_Generic_5943 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_833 Blob_Generic_833, *PBlob_Generic_833;

struct Blob_Generic_833 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_1103 Blob_Generic_1103, *PBlob_Generic_1103;

struct Blob_Generic_1103 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_PropertySig_848 Blob_PropertySig_848, *PBlob_PropertySig_848;

typedef struct PropertySig_848 PropertySig_848, *PPropertySig_848;

typedef struct Type_28927 Type_28927, *PType_28927;

struct Type_28927 {
    struct GenericInstType_28928 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_848 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28927 RetType; // Return type
};

struct Blob_PropertySig_848 {
    byte Size; // coded integer - blob size
    struct PropertySig_848 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_3095 Blob_Generic_3095, *PBlob_Generic_3095;

struct Blob_Generic_3095 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_3350.conflict Blob_ConstantSig_3350.conflict, *PBlob_ConstantSig_3350.conflict;

typedef struct ConstantSig_3350.conflict ConstantSig_3350.conflict, *PConstantSig_3350.conflict;

struct ConstantSig_3350.conflict {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_3350.conflict {
    byte Size; // coded integer - blob size
    struct ConstantSig_3350.conflict ConstantSig; // Data stored in a constant
};

typedef struct Blob_PropertySig_959 Blob_PropertySig_959, *PBlob_PropertySig_959;

typedef struct PropertySig_959 PropertySig_959, *PPropertySig_959;

typedef struct Type_29038 Type_29038, *PType_29038;

struct Type_29038 {
    struct ValueType ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_959 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29038 RetType; // Return type
};

struct Blob_PropertySig_959 {
    byte Size; // coded integer - blob size
    struct PropertySig_959 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_949 Blob_PropertySig_949, *PBlob_PropertySig_949;

typedef struct PropertySig_949 PropertySig_949, *PPropertySig_949;

typedef struct Type_29028 Type_29028, *PType_29028;

struct Type_29028 {
    struct GenericInstType_29029 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_949 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29028 RetType; // Return type
};

struct Blob_PropertySig_949 {
    byte Size; // coded integer - blob size
    struct PropertySig_949 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_6380 Blob_Generic_6380, *PBlob_Generic_6380;

struct Blob_Generic_6380 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6140 Blob_Generic_6140, *PBlob_Generic_6140;

struct Blob_Generic_6140 {
    byte Size; // coded integer - blob size
    byte Generic[63]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1180 Blob_PropertySig_1180, *PBlob_PropertySig_1180;

typedef struct PropertySig_1180 PropertySig_1180, *PPropertySig_1180;

typedef struct Type_29259 Type_29259, *PType_29259;

struct Type_29259 {
    struct GenericInstType_29260 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1180 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29259 RetType; // Return type
};

struct Blob_PropertySig_1180 {
    byte Size; // coded integer - blob size
    struct PropertySig_1180 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_FieldSig_3118 Blob_FieldSig_3118, *PBlob_FieldSig_3118;

typedef struct FieldSig_3118 FieldSig_3118, *PFieldSig_3118;

typedef struct Type_31196 Type_31196, *PType_31196;

struct Type_31196 {
    struct ValueType.conflict2 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_3118 {
    byte FIELD; // Magic (0x06)
    struct Type_31196 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_3118 {
    byte Size; // coded integer - blob size
    struct FieldSig_3118 FieldSig; // Type information for Field
};

typedef struct Blob_PropertySig_939 Blob_PropertySig_939, *PBlob_PropertySig_939;

typedef struct PropertySig_939 PropertySig_939, *PPropertySig_939;

typedef struct Type_29018 Type_29018, *PType_29018;

struct Type_29018 {
    struct GenericInstType_29019 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_939 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29018 RetType; // Return type
};

struct Blob_PropertySig_939 {
    byte Size; // coded integer - blob size
    struct PropertySig_939 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1176 Blob_PropertySig_1176, *PBlob_PropertySig_1176;

typedef struct PropertySig_1176 PropertySig_1176, *PPropertySig_1176;

typedef struct Type_29255 Type_29255, *PType_29255;

struct Type_29255 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct PropertySig_1176 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29255 RetType; // Return type
};

struct Blob_PropertySig_1176 {
    byte Size; // coded integer - blob size
    struct PropertySig_1176 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_FieldSig_3113 Blob_FieldSig_3113, *PBlob_FieldSig_3113;

typedef struct FieldSig_3113 FieldSig_3113, *PFieldSig_3113;

typedef struct Type_31191 Type_31191, *PType_31191;

struct Type_31191 {
    struct ValueType.conflict1 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_3113 {
    byte FIELD; // Magic (0x06)
    struct Type_31191 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_3113 {
    byte Size; // coded integer - blob size
    struct FieldSig_3113 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_5067 Blob_Generic_5067, *PBlob_Generic_5067;

struct Blob_Generic_5067 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1188 Blob_PropertySig_1188, *PBlob_PropertySig_1188;

typedef struct PropertySig_1188 PropertySig_1188, *PPropertySig_1188;

typedef struct Type_29267 Type_29267, *PType_29267;

struct Type_29267 {
    enum TypeCode ELEMENT_TYPE_I4;
};

struct PropertySig_1188 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29267 RetType; // Return type
};

struct Blob_PropertySig_1188 {
    byte Size; // coded integer - blob size
    struct PropertySig_1188 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_925 Blob_PropertySig_925, *PBlob_PropertySig_925;

typedef struct PropertySig_925 PropertySig_925, *PPropertySig_925;

typedef struct Type_29004 Type_29004, *PType_29004;

struct Type_29004 {
    struct GenericInstType_29005 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_925 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29004 RetType; // Return type
};

struct Blob_PropertySig_925 {
    byte Size; // coded integer - blob size
    struct PropertySig_925 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_914 Blob_PropertySig_914, *PBlob_PropertySig_914;

typedef struct PropertySig_914 PropertySig_914, *PPropertySig_914;

typedef struct Type_28993 Type_28993, *PType_28993;

struct Type_28993 {
    struct GenericInstType_28994 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_914 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28993 RetType; // Return type
};

struct Blob_PropertySig_914 {
    byte Size; // coded integer - blob size
    struct PropertySig_914 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_5088 Blob_Generic_5088, *PBlob_Generic_5088;

struct Blob_Generic_5088 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3916 Blob_Generic_3916, *PBlob_Generic_3916;

struct Blob_Generic_3916 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1071 Blob_Generic_1071, *PBlob_Generic_1071;

struct Blob_Generic_1071 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3490 Blob_Generic_3490, *PBlob_Generic_3490;

struct Blob_Generic_3490 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3252 Blob_Generic_3252, *PBlob_Generic_3252;

struct Blob_Generic_3252 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_3499 Blob_Generic_3499, *PBlob_Generic_3499;

struct Blob_Generic_3499 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_Generic_268 Blob_Generic_268, *PBlob_Generic_268;

struct Blob_Generic_268 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3013 Blob_Generic_3013, *PBlob_Generic_3013;

struct Blob_Generic_3013 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_5432 Blob_Generic_5432, *PBlob_Generic_5432;

struct Blob_Generic_5432 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3019 Blob_Generic_3019, *PBlob_Generic_3019;

struct Blob_Generic_3019 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6522 Blob_Generic_6522, *PBlob_Generic_6522;

struct Blob_Generic_6522 {
    byte Size; // coded integer - blob size
    byte Generic[32]; // Undefined blob contents
};

typedef struct Blob_Generic_3259 Blob_Generic_3259, *PBlob_Generic_3259;

struct Blob_Generic_3259 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5679 Blob_Generic_5679, *PBlob_Generic_5679;

struct Blob_Generic_5679 {
    byte Size; // coded integer - blob size
    byte Generic[53]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1112 Blob_PropertySig_1112, *PBlob_PropertySig_1112;

typedef struct PropertySig_1112 PropertySig_1112, *PPropertySig_1112;

typedef struct Type_29191 Type_29191, *PType_29191;

struct Type_29191 {
    struct GenericInstType_29192 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1112 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29191 RetType; // Return type
};

struct Blob_PropertySig_1112 {
    byte Size; // coded integer - blob size
    struct PropertySig_1112 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1080 Blob_Generic_1080, *PBlob_Generic_1080;

struct Blob_Generic_1080 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_1085 Blob_Generic_1085, *PBlob_Generic_1085;

struct Blob_Generic_1085 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_4353 Blob_Generic_4353, *PBlob_Generic_4353;

struct Blob_Generic_4353 {
    byte Size; // coded integer - blob size
    byte Generic[75]; // Undefined blob contents
};

typedef struct Blob_Generic_3025 Blob_Generic_3025, *PBlob_Generic_3025;

struct Blob_Generic_3025 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3266 Blob_Generic_3266, *PBlob_Generic_3266;

struct Blob_Generic_3266 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_497 Blob_Generic_497, *PBlob_Generic_497;

struct Blob_Generic_497 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_259 Blob_Generic_259, *PBlob_Generic_259;

struct Blob_Generic_259 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1124 Blob_PropertySig_1124, *PBlob_PropertySig_1124;

typedef struct PropertySig_1124 PropertySig_1124, *PPropertySig_1124;

typedef struct Type_29203 Type_29203, *PType_29203;

struct Type_29203 {
    struct GenericInstType_29204 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1124 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29203 RetType; // Return type
};

struct Blob_PropertySig_1124 {
    byte Size; // coded integer - blob size
    struct PropertySig_1124 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1090 Blob_Generic_1090, *PBlob_Generic_1090;

struct Blob_Generic_1090 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_5453 Blob_Generic_5453, *PBlob_Generic_5453;

struct Blob_Generic_5453 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_483 Blob_Generic_483, *PBlob_Generic_483;

struct Blob_Generic_483 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_240 Blob_Generic_240, *PBlob_Generic_240;

struct Blob_Generic_240 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3031 Blob_Generic_3031, *PBlob_Generic_3031;

struct Blob_Generic_3031 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_3272 Blob_Generic_3272, *PBlob_Generic_3272;

struct Blob_Generic_3272 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3278 Blob_Generic_3278, *PBlob_Generic_3278;

struct Blob_Generic_3278 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_249 Blob_Generic_249, *PBlob_Generic_249;

struct Blob_Generic_249 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3043 Blob_Generic_3043, *PBlob_Generic_3043;

struct Blob_Generic_3043 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_473 Blob_Generic_473, *PBlob_Generic_473;

struct Blob_Generic_473 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_230 Blob_Generic_230, *PBlob_Generic_230;

struct Blob_Generic_230 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3283 Blob_Generic_3283, *PBlob_Generic_3283;

struct Blob_Generic_3283 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3288 Blob_Generic_3288, *PBlob_Generic_3288;

struct Blob_Generic_3288 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4134 Blob_Generic_4134, *PBlob_Generic_4134;

struct Blob_Generic_4134 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6555 Blob_Generic_6555, *PBlob_Generic_6555;

struct Blob_Generic_6555 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1103 Blob_PropertySig_1103, *PBlob_PropertySig_1103;

typedef struct PropertySig_1103 PropertySig_1103, *PPropertySig_1103;

typedef struct Type_29182 Type_29182, *PType_29182;

struct Type_29182 {
    struct GenericInstType_29183 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1103 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29182 RetType; // Return type
};

struct Blob_PropertySig_1103 {
    byte Size; // coded integer - blob size
    struct PropertySig_1103 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_5232 Blob_Generic_5232, *PBlob_Generic_5232;

struct Blob_Generic_5232 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5474 Blob_Generic_5474, *PBlob_Generic_5474;

struct Blob_Generic_5474 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_3053 Blob_Generic_3053, *PBlob_Generic_3053;

struct Blob_Generic_3053 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3294 Blob_Generic_3294, *PBlob_Generic_3294;

struct Blob_Generic_3294 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3058 Blob_Generic_3058, *PBlob_Generic_3058;

struct Blob_Generic_3058 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1152 Blob_PropertySig_1152, *PBlob_PropertySig_1152;

typedef struct PropertySig_1152 PropertySig_1152, *PPropertySig_1152;

typedef struct Type_29231 Type_29231, *PType_29231;

struct Type_29231 {
    enum TypeCode ELEMENT_TYPE_R4;
};

struct PropertySig_1152 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29231 RetType; // Return type
};

struct Blob_PropertySig_1152 {
    byte Size; // coded integer - blob size
    struct PropertySig_1152 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1156 Blob_PropertySig_1156, *PBlob_PropertySig_1156;

typedef struct PropertySig_1156 PropertySig_1156, *PPropertySig_1156;

typedef struct Type_29235 Type_29235, *PType_29235;

struct Type_29235 {
    struct GenericInstType_29236 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1156 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29235 RetType; // Return type
};

struct Blob_PropertySig_1156 {
    byte Size; // coded integer - blob size
    struct PropertySig_1156 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_ConstantSig_3345 Blob_ConstantSig_3345, *PBlob_ConstantSig_3345;

typedef struct ConstantSig_3345 ConstantSig_3345, *PConstantSig_3345;

struct ConstantSig_3345 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_3345 {
    byte Size; // coded integer - blob size
    struct ConstantSig_3345 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_4155 Blob_Generic_4155, *PBlob_Generic_4155;

struct Blob_Generic_4155 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3063 Blob_Generic_3063, *PBlob_Generic_3063;

struct Blob_Generic_3063 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_6338 Blob_Generic_6338, *PBlob_Generic_6338;

struct Blob_Generic_6338 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3068 Blob_Generic_3068, *PBlob_Generic_3068;

struct Blob_Generic_3068 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_6576 Blob_Generic_6576, *PBlob_Generic_6576;

struct Blob_Generic_6576 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1164 Blob_PropertySig_1164, *PBlob_PropertySig_1164;

typedef struct PropertySig_1164 PropertySig_1164, *PPropertySig_1164;

typedef struct Type_29243 Type_29243, *PType_29243;

struct Type_29243 {
    enum TypeCode ELEMENT_TYPE_I8;
};

struct PropertySig_1164 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29243 RetType; // Return type
};

struct Blob_PropertySig_1164 {
    byte Size; // coded integer - blob size
    struct PropertySig_1164 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1168 Blob_PropertySig_1168, *PBlob_PropertySig_1168;

typedef struct PropertySig_1168 PropertySig_1168, *PPropertySig_1168;

typedef struct Type_29247 Type_29247, *PType_29247;

struct Type_29247 {
    struct GenericInstType_29248 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1168 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29247 RetType; // Return type
};

struct Blob_PropertySig_1168 {
    byte Size; // coded integer - blob size
    struct PropertySig_1168 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_ConstantSig_3360 Blob_ConstantSig_3360, *PBlob_ConstantSig_3360;

typedef struct ConstantSig_3360 ConstantSig_3360, *PConstantSig_3360;

struct ConstantSig_3360 {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_3360 {
    byte Size; // coded integer - blob size
    struct ConstantSig_3360 ConstantSig; // Data stored in a constant
};

typedef struct CustomAttrib_3350 CustomAttrib_3350, *PCustomAttrib_3350;

struct CustomAttrib_3350 {
    word PROLOG; // Magic (0x0001)
    word NumNamed; // Number of NamedArgs to follow
};

typedef struct Blob_Generic_285 Blob_Generic_285, *PBlob_Generic_285;

struct Blob_Generic_285 {
    byte Size; // coded integer - blob size
    byte Generic[22]; // Undefined blob contents
};

typedef struct Blob_Generic_3074 Blob_Generic_3074, *PBlob_Generic_3074;

struct Blob_Generic_3074 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5253 Blob_Generic_5253, *PBlob_Generic_5253;

struct Blob_Generic_5253 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1132 Blob_PropertySig_1132, *PBlob_PropertySig_1132;

typedef struct PropertySig_1132 PropertySig_1132, *PPropertySig_1132;

typedef struct Type_29211 Type_29211, *PType_29211;

struct Type_29211 {
    struct GenericInstType_29212 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1132 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29211 RetType; // Return type
};

struct Blob_PropertySig_1132 {
    byte Size; // coded integer - blob size
    struct PropertySig_1132 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_ConstantSig_3365 Blob_ConstantSig_3365, *PBlob_ConstantSig_3365;

typedef struct ConstantSig_3365 ConstantSig_3365, *PConstantSig_3365;

struct ConstantSig_3365 {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_3365 {
    byte Size; // coded integer - blob size
    struct ConstantSig_3365 ConstantSig; // Data stored in a constant
};

typedef struct Blob_ConstantSig_3350 Blob_ConstantSig_3350, *PBlob_ConstantSig_3350;

typedef struct ConstantSig_3350 ConstantSig_3350, *PConstantSig_3350;

struct ConstantSig_3350 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_3350 {
    byte Size; // coded integer - blob size
    struct ConstantSig_3350 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_3081 Blob_Generic_3081, *PBlob_Generic_3081;

struct Blob_Generic_3081 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_6597 Blob_Generic_6597, *PBlob_Generic_6597;

struct Blob_Generic_6597 {
    byte Size; // coded integer - blob size
    byte Generic[35]; // Undefined blob contents
};

typedef struct Blob_Generic_3088 Blob_Generic_3088, *PBlob_Generic_3088;

struct Blob_Generic_3088 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_4176 Blob_Generic_4176, *PBlob_Generic_4176;

struct Blob_Generic_4176 {
    byte Size; // coded integer - blob size
    byte Generic[72]; // Undefined blob contents
};

typedef struct Blob_Generic_6119 Blob_Generic_6119, *PBlob_Generic_6119;

struct Blob_Generic_6119 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_277 Blob_Generic_277, *PBlob_Generic_277;

struct Blob_Generic_277 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_6359 Blob_Generic_6359, *PBlob_Generic_6359;

struct Blob_Generic_6359 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1140 Blob_PropertySig_1140, *PBlob_PropertySig_1140;

typedef struct PropertySig_1140 PropertySig_1140, *PPropertySig_1140;

typedef struct Type_29219 Type_29219, *PType_29219;

struct Type_29219 {
    enum TypeCode ELEMENT_TYPE_R8;
};

struct PropertySig_1140 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29219 RetType; // Return type
};

struct Blob_PropertySig_1140 {
    byte Size; // coded integer - blob size
    struct PropertySig_1140 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1144 Blob_PropertySig_1144, *PBlob_PropertySig_1144;

typedef struct PropertySig_1144 PropertySig_1144, *PPropertySig_1144;

typedef struct Type_29223 Type_29223, *PType_29223;

struct Type_29223 {
    struct GenericInstType_29224 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1144 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29223 RetType; // Return type
};

struct Blob_PropertySig_1144 {
    byte Size; // coded integer - blob size
    struct PropertySig_1144 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_ConstantSig_3355 Blob_ConstantSig_3355, *PBlob_ConstantSig_3355;

typedef struct ConstantSig_3355 ConstantSig_3355, *PConstantSig_3355;

struct ConstantSig_3355 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_3355 {
    byte Size; // coded integer - blob size
    struct ConstantSig_3355 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_780 Blob_Generic_780, *PBlob_Generic_780;

struct Blob_Generic_780 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3895 Blob_Generic_3895, *PBlob_Generic_3895;

struct Blob_Generic_3895 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_543 Blob_Generic_543, *PBlob_Generic_543;

struct Blob_Generic_543 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_785 Blob_Generic_785, *PBlob_Generic_785;

struct Blob_Generic_785 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4987 Blob_Generic_4987, *PBlob_Generic_4987;

struct Blob_Generic_4987 {
    byte Size; // coded integer - blob size
    byte Generic[79]; // Undefined blob contents
};

typedef struct Blob_Generic_5831 Blob_Generic_5831, *PBlob_Generic_5831;

struct Blob_Generic_5831 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3418 Blob_Generic_3418, *PBlob_Generic_3418;

struct Blob_Generic_3418 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_308 Blob_Generic_308, *PBlob_Generic_308;

struct Blob_Generic_308 {
    byte Size; // coded integer - blob size
    byte Generic[21]; // Undefined blob contents
};

typedef struct Blob_Generic_4509 Blob_Generic_4509, *PBlob_Generic_4509;

struct Blob_Generic_4509 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_3370 Blob_ConstantSig_3370, *PBlob_ConstantSig_3370;

typedef struct ConstantSig_3370 ConstantSig_3370, *PConstantSig_3370;

struct ConstantSig_3370 {
    dword ELEMENT_TYPE_I4;
};

struct Blob_ConstantSig_3370 {
    byte Size; // coded integer - blob size
    struct ConstantSig_3370 ConstantSig; // Data stored in a constant
};

typedef struct Blob_Generic_771 Blob_Generic_771, *PBlob_Generic_771;

struct Blob_Generic_771 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_533 Blob_Generic_533, *PBlob_Generic_533;

struct Blob_Generic_533 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_1002 Blob_Generic_1002, *PBlob_Generic_1002;

struct Blob_Generic_1002 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3665 Blob_Generic_3665, *PBlob_Generic_3665;

struct Blob_Generic_3665 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_130 Blob_PropertySig_130, *PBlob_PropertySig_130;

typedef struct PropertySig_130 PropertySig_130, *PPropertySig_130;

typedef struct Type_28209 Type_28209, *PType_28209;

struct Type_28209 {
    enum TypeCode ELEMENT_TYPE_STRING;
};

struct PropertySig_130 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28209 RetType; // Return type
};

struct Blob_PropertySig_130 {
    byte Size; // coded integer - blob size
    struct PropertySig_130 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_520 Blob_Generic_520, *PBlob_Generic_520;

struct Blob_Generic_520 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_761 Blob_Generic_761, *PBlob_Generic_761;

struct Blob_Generic_761 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_1011 Blob_Generic_1011, *PBlob_Generic_1011;

struct Blob_Generic_1011 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5852 Blob_Generic_5852, *PBlob_Generic_5852;

struct Blob_Generic_5852 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3439 Blob_Generic_3439, *PBlob_Generic_3439;

struct Blob_Generic_3439 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1020 Blob_Generic_1020, *PBlob_Generic_1020;

struct Blob_Generic_1020 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_PropertySig_122 Blob_PropertySig_122, *PBlob_PropertySig_122;

typedef struct PropertySig_122 PropertySig_122, *PPropertySig_122;

typedef struct Type_28201 Type_28201, *PType_28201;

struct Type_28201 {
    struct GenericInstType_28202 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_122 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28201 RetType; // Return type
};

struct Blob_PropertySig_122 {
    byte Size; // coded integer - blob size
    struct PropertySig_122 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_511 Blob_Generic_511, *PBlob_Generic_511;

struct Blob_Generic_511 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_2596 Blob_Generic_2596, *PBlob_Generic_2596;

struct Blob_Generic_2596 {
    byte Size; // coded integer - blob size
    byte Generic[105]; // Undefined blob contents
};

typedef struct Blob_Generic_3202 Blob_Generic_3202, *PBlob_Generic_3202;

struct Blob_Generic_3202 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3686 Blob_Generic_3686, *PBlob_Generic_3686;

struct Blob_Generic_3686 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_751 Blob_Generic_751, *PBlob_Generic_751;

struct Blob_Generic_751 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4530 Blob_Generic_4530, *PBlob_Generic_4530;

struct Blob_Generic_4530 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1025 Blob_Generic_1025, *PBlob_Generic_1025;

struct Blob_Generic_1025 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_3208 Blob_Generic_3208, *PBlob_Generic_3208;

struct Blob_Generic_3208 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_112 Blob_PropertySig_112, *PBlob_PropertySig_112;

typedef struct PropertySig_112 PropertySig_112, *PPropertySig_112;

typedef struct Type_28191 Type_28191, *PType_28191;

struct Type_28191 {
    struct ValueType.conflict6 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_112 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28191 RetType; // Return type
};

struct Blob_PropertySig_112 {
    byte Size; // coded integer - blob size
    struct PropertySig_112 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_583 Blob_Generic_583, *PBlob_Generic_583;

struct Blob_Generic_583 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_4781 Blob_Generic_4781, *PBlob_Generic_4781;

struct Blob_Generic_4781 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_102 Blob_Generic_102, *PBlob_Generic_102;

struct Blob_Generic_102 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_5637 Blob_Generic_5637, *PBlob_Generic_5637;

struct Blob_Generic_5637 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_107 Blob_Generic_107, *PBlob_Generic_107;

struct Blob_Generic_107 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_1039 Blob_Generic_1039, *PBlob_Generic_1039;

struct Blob_Generic_1039 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_5873 Blob_Generic_5873, *PBlob_Generic_5873;

struct Blob_Generic_5873 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_3214 Blob_Generic_3214, *PBlob_Generic_3214;

struct Blob_Generic_3214 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_117 Blob_PropertySig_117, *PBlob_PropertySig_117;

typedef struct PropertySig_117 PropertySig_117, *PPropertySig_117;

typedef struct Type_28196 Type_28196, *PType_28196;

struct Type_28196 {
    struct ValueType.conflict7 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_117 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28196 RetType; // Return type
};

struct Blob_PropertySig_117 {
    byte Size; // coded integer - blob size
    struct PropertySig_117 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_573 Blob_Generic_573, *PBlob_Generic_573;

struct Blob_Generic_573 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3220 Blob_Generic_3220, *PBlob_Generic_3220;

struct Blob_Generic_3220 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_4551 Blob_Generic_4551, *PBlob_Generic_4551;

struct Blob_Generic_4551 {
    byte Size; // coded integer - blob size
    byte Generic[72]; // Undefined blob contents
};

typedef struct Blob_Generic_330 Blob_Generic_330, *PBlob_Generic_330;

struct Blob_Generic_330 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3460 Blob_Generic_3460, *PBlob_Generic_3460;

struct Blob_Generic_3460 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1049 Blob_Generic_1049, *PBlob_Generic_1049;

struct Blob_Generic_1049 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_338 Blob_Generic_338, *PBlob_Generic_338;

struct Blob_Generic_338 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_3226 Blob_Generic_3226, *PBlob_Generic_3226;

struct Blob_Generic_3226 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_563 Blob_Generic_563, *PBlob_Generic_563;

struct Blob_Generic_563 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_5658 Blob_Generic_5658, *PBlob_Generic_5658;

struct Blob_Generic_5658 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3240 Blob_Generic_3240, *PBlob_Generic_3240;

struct Blob_Generic_3240 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_1062 Blob_Generic_1062, *PBlob_Generic_1062;

struct Blob_Generic_1062 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3481 Blob_Generic_3481, *PBlob_Generic_3481;

struct Blob_Generic_3481 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_795 Blob_Generic_795, *PBlob_Generic_795;

struct Blob_Generic_795 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_4332 Blob_Generic_4332, *PBlob_Generic_4332;

struct Blob_Generic_4332 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_3007 Blob_Generic_3007, *PBlob_Generic_3007;

struct Blob_Generic_3007 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_557 Blob_Generic_557, *PBlob_Generic_557;

struct Blob_Generic_557 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_795 Blob_PropertySig_795, *PBlob_PropertySig_795;

typedef struct PropertySig_795 PropertySig_795, *PPropertySig_795;

typedef struct Type_28874 Type_28874, *PType_28874;

struct Type_28874 {
    struct GenericInstType_28875 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_795 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28874 RetType; // Return type
};

struct Blob_PropertySig_795 {
    byte Size; // coded integer - blob size
    struct PropertySig_795 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_4900 Blob_Generic_4900, *PBlob_Generic_4900;

struct Blob_Generic_4900 {
    byte Size; // coded integer - blob size
    byte Generic[65]; // Undefined blob contents
};

typedef struct Blob_Generic_2720 Blob_Generic_2720, *PBlob_Generic_2720;

struct Blob_Generic_2720 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_2962 Blob_Generic_2962, *PBlob_Generic_2962;

struct Blob_Generic_2962 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_2967 Blob_Generic_2967, *PBlob_Generic_2967;

struct Blob_Generic_2967 {
    byte Size; // coded integer - blob size
    byte Generic[2]; // Undefined blob contents
};

typedef struct Blob_Generic_703 Blob_Generic_703, *PBlob_Generic_703;

struct Blob_Generic_703 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_2729 Blob_Generic_2729, *PBlob_Generic_2729;

struct Blob_Generic_2729 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3819 Blob_Generic_3819, *PBlob_Generic_3819;

struct Blob_Generic_3819 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_949 Blob_Generic_949, *PBlob_Generic_949;

struct Blob_Generic_949 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_780 Blob_PropertySig_780, *PBlob_PropertySig_780;

typedef struct PropertySig_780 PropertySig_780, *PPropertySig_780;

typedef struct Type_28859 Type_28859, *PType_28859;

struct Type_28859 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_780 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28859 RetType; // Return type
};

struct Blob_PropertySig_780 {
    byte Size; // coded integer - blob size
    struct PropertySig_780 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_785 Blob_PropertySig_785, *PBlob_PropertySig_785;

typedef struct PropertySig_785 PropertySig_785, *PPropertySig_785;

typedef struct Type_28864 Type_28864, *PType_28864;

struct Type_28864 {
    struct GenericInstType_28865 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_785 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28864 RetType; // Return type
};

struct Blob_PropertySig_785 {
    byte Size; // coded integer - blob size
    struct PropertySig_785 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2970 Blob_Generic_2970, *PBlob_Generic_2970;

struct Blob_Generic_2970 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_2975 Blob_Generic_2975, *PBlob_Generic_2975;

struct Blob_Generic_2975 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_939 Blob_Generic_939, *PBlob_Generic_939;

struct Blob_Generic_939 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_2738 Blob_Generic_2738, *PBlob_Generic_2738;

struct Blob_Generic_2738 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_PropertySig_771 Blob_PropertySig_771, *PBlob_PropertySig_771;

typedef struct PropertySig_771 PropertySig_771, *PPropertySig_771;

typedef struct Type_28850 Type_28850, *PType_28850;

struct Type_28850 {
    struct GenericInstType_28851 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_771 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28850 RetType; // Return type
};

struct Blob_PropertySig_771 {
    byte Size; // coded integer - blob size
    struct PropertySig_771 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2983 Blob_Generic_2983, *PBlob_Generic_2983;

struct Blob_Generic_2983 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_2747 Blob_Generic_2747, *PBlob_Generic_2747;

struct Blob_Generic_2747 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_925 Blob_Generic_925, *PBlob_Generic_925;

struct Blob_Generic_925 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_PropertySig_761 Blob_PropertySig_761, *PBlob_PropertySig_761;

typedef struct PropertySig_761 PropertySig_761, *PPropertySig_761;

typedef struct Type_28840 Type_28840, *PType_28840;

struct Type_28840 {
    struct GenericInstType_28841 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_761 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28840 RetType; // Return type
};

struct Blob_PropertySig_761 {
    byte Size; // coded integer - blob size
    struct PropertySig_761 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2991 Blob_Generic_2991, *PBlob_Generic_2991;

struct Blob_Generic_2991 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3095 Blob_PropertySig_3095, *PBlob_PropertySig_3095;

typedef struct PropertySig_3095 PropertySig_3095, *PPropertySig_3095;

typedef struct Type_31174 Type_31174, *PType_31174;

struct Type_31174 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_3095 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_31174 RetType; // Return type
};

struct Blob_PropertySig_3095 {
    byte Size; // coded integer - blob size
    struct PropertySig_3095 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2753 Blob_Generic_2753, *PBlob_Generic_2753;

struct Blob_Generic_2753 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_914 Blob_Generic_914, *PBlob_Generic_914;

struct Blob_Generic_914 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_2999 Blob_Generic_2999, *PBlob_Generic_2999;

struct Blob_Generic_2999 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_742 Blob_Generic_742, *PBlob_Generic_742;

struct Blob_Generic_742 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_502 Blob_Generic_502, *PBlob_Generic_502;

struct Blob_Generic_502 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_2763 Blob_Generic_2763, *PBlob_Generic_2763;

struct Blob_Generic_2763 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_3610 Blob_Generic_3610, *PBlob_Generic_3610;

struct Blob_Generic_3610 {
    byte Size; // coded integer - blob size
    byte Generic[33]; // Undefined blob contents
};

typedef struct Blob_Generic_989 Blob_Generic_989, *PBlob_Generic_989;

struct Blob_Generic_989 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_2773 Blob_Generic_2773, *PBlob_Generic_2773;

struct Blob_Generic_2773 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_737 Blob_Generic_737, *PBlob_Generic_737;

struct Blob_Generic_737 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_979 Blob_Generic_979, *PBlob_Generic_979;

struct Blob_Generic_979 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_4718 Blob_Generic_4718, *PBlob_Generic_4718;

struct Blob_Generic_4718 {
    byte Size; // coded integer - blob size
    byte Generic[62]; // Undefined blob contents
};

typedef struct Blob_PropertySig_989 Blob_PropertySig_989, *PBlob_PropertySig_989;

typedef struct PropertySig_989 PropertySig_989, *PPropertySig_989;

typedef struct Type_29068 Type_29068, *PType_29068;

struct Type_29068 {
    struct GenericInstType_29069 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_989 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29068 RetType; // Return type
};

struct Blob_PropertySig_989 {
    byte Size; // coded integer - blob size
    struct PropertySig_989 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2784 Blob_Generic_2784, *PBlob_Generic_2784;

struct Blob_Generic_2784 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_4966 Blob_Generic_4966, *PBlob_Generic_4966;

struct Blob_Generic_4966 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_965 Blob_Generic_965, *PBlob_Generic_965;

struct Blob_Generic_965 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_3874 Blob_Generic_3874, *PBlob_Generic_3874;

struct Blob_Generic_3874 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_727 Blob_Generic_727, *PBlob_Generic_727;

struct Blob_Generic_727 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_PropertySig_979 Blob_PropertySig_979, *PBlob_PropertySig_979;

typedef struct PropertySig_979 PropertySig_979, *PPropertySig_979;

typedef struct Type_29058 Type_29058, *PType_29058;

struct Type_29058 {
    struct GenericInstType_29059 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_979 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29058 RetType; // Return type
};

struct Blob_PropertySig_979 {
    byte Size; // coded integer - blob size
    struct PropertySig_979 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_FieldSig_3278 Blob_FieldSig_3278, *PBlob_FieldSig_3278;

typedef struct FieldSig_3278 FieldSig_3278, *PFieldSig_3278;

typedef struct Type_31356 Type_31356, *PType_31356;

struct Type_31356 {
    struct ValueType.conflict3 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_3278 {
    byte FIELD; // Magic (0x06)
    struct Type_31356 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_3278 {
    byte Size; // coded integer - blob size
    struct FieldSig_3278 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_2795 Blob_Generic_2795, *PBlob_Generic_2795;

struct Blob_Generic_2795 {
    byte Size; // coded integer - blob size
    byte Generic[82]; // Undefined blob contents
};

typedef struct Blob_Generic_713 Blob_Generic_713, *PBlob_Generic_713;

struct Blob_Generic_713 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_3644 Blob_Generic_3644, *PBlob_Generic_3644;

struct Blob_Generic_3644 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_959 Blob_Generic_959, *PBlob_Generic_959;

struct Blob_Generic_959 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_718 Blob_Generic_718, *PBlob_Generic_718;

struct Blob_Generic_718 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3409 Blob_Generic_3409, *PBlob_Generic_3409;

struct Blob_Generic_3409 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_PropertySig_965 Blob_PropertySig_965, *PBlob_PropertySig_965;

typedef struct PropertySig_965 PropertySig_965, *PPropertySig_965;

typedef struct Type_29044 Type_29044, *PType_29044;

struct Type_29044 {
    struct GenericInstType_29045 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_965 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29044 RetType; // Return type
};

struct Blob_PropertySig_965 {
    byte Size; // coded integer - blob size
    struct PropertySig_965 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_5151 Blob_Generic_5151, *PBlob_Generic_5151;

struct Blob_Generic_5151 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6243 Blob_Generic_6243, *PBlob_Generic_6243;

struct Blob_Generic_6243 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6006 Blob_Generic_6006, *PBlob_Generic_6006;

struct Blob_Generic_6006 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1080 Blob_PropertySig_1080, *PBlob_PropertySig_1080;

typedef struct PropertySig_1080 PropertySig_1080, *PPropertySig_1080;

typedef struct Type_29159 Type_29159, *PType_29159;

struct Type_29159 {
    struct ValueType.conflict9 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_1080 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29159 RetType; // Return type
};

struct Blob_PropertySig_1080 {
    byte Size; // coded integer - blob size
    struct PropertySig_1080 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_3019 Blob_PropertySig_3019, *PBlob_PropertySig_3019;

typedef struct PropertySig_3019 PropertySig_3019, *PPropertySig_3019;

typedef struct Type_31098 Type_31098, *PType_31098;

struct Type_31098 {
    struct ValueType.conflict2 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_3019 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_31098 RetType; // Return type
};

struct Blob_PropertySig_3019 {
    byte Size; // coded integer - blob size
    struct PropertySig_3019 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_833 Blob_PropertySig_833, *PBlob_PropertySig_833;

typedef struct PropertySig_833 PropertySig_833, *PPropertySig_833;

typedef struct Type_28912 Type_28912, *PType_28912;

struct Type_28912 {
    struct GenericInstType_28913 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_833 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28912 RetType; // Return type
};

struct Blob_PropertySig_833 {
    byte Size; // coded integer - blob size
    struct PropertySig_833 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_4075 Blob_Generic_4075, *PBlob_Generic_4075;

struct Blob_Generic_4075 {
    byte Size; // coded integer - blob size
    byte Generic[58]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1090 Blob_PropertySig_1090, *PBlob_PropertySig_1090;

typedef struct PropertySig_1090 PropertySig_1090, *PPropertySig_1090;

typedef struct Type_29169 Type_29169, *PType_29169;

struct Type_29169 {
    struct GenericInstType_29170 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1090 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29169 RetType; // Return type
};

struct Blob_PropertySig_1090 {
    byte Size; // coded integer - blob size
    struct PropertySig_1090 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_828 Blob_PropertySig_828, *PBlob_PropertySig_828;

typedef struct PropertySig_828 PropertySig_828, *PPropertySig_828;

typedef struct Type_28907 Type_28907, *PType_28907;

struct Type_28907 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_828 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28907 RetType; // Return type
};

struct Blob_PropertySig_828 {
    byte Size; // coded integer - blob size
    struct PropertySig_828 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1085 Blob_PropertySig_1085, *PBlob_PropertySig_1085;

typedef struct PropertySig_1085 PropertySig_1085, *PPropertySig_1085;

typedef struct Type_29164 Type_29164, *PType_29164;

struct Type_29164 {
    struct SzArray_29165 ELEMENT_TYPE_SZARRAY;
};

struct PropertySig_1085 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29164 RetType; // Return type
};

struct Blob_PropertySig_1085 {
    byte Size; // coded integer - blob size
    struct PropertySig_1085 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_CustomAttrib_3350 Blob_CustomAttrib_3350, *PBlob_CustomAttrib_3350;

struct Blob_CustomAttrib_3350 {
    byte Size; // coded integer - blob size
    struct CustomAttrib_3350 CustomAttrib; // A CustomAttrib blob stores values of fixed or named parameters supplied when instantiating a custom attribute
};

typedef struct Blob_PropertySig_3025 Blob_PropertySig_3025, *PBlob_PropertySig_3025;

typedef struct PropertySig_3025 PropertySig_3025, *PPropertySig_3025;

typedef struct Type_31104 Type_31104, *PType_31104;

struct Type_31104 {
    struct ValueType.conflict1 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_3025 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_31104 RetType; // Return type
};

struct Blob_PropertySig_3025 {
    byte Size; // coded integer - blob size
    struct PropertySig_3025 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_6264 Blob_Generic_6264, *PBlob_Generic_6264;

struct Blob_Generic_6264 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_5172 Blob_Generic_5172, *PBlob_Generic_5172;

struct Blob_Generic_5172 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6027 Blob_Generic_6027, *PBlob_Generic_6027;

struct Blob_Generic_6027 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_819 Blob_PropertySig_819, *PBlob_PropertySig_819;

typedef struct PropertySig_819 PropertySig_819, *PPropertySig_819;

typedef struct Type_28898 Type_28898, *PType_28898;

struct Type_28898 {
    struct GenericInstType_28899 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_819 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28898 RetType; // Return type
};

struct Blob_PropertySig_819 {
    byte Size; // coded integer - blob size
    struct PropertySig_819 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_193 Blob_Generic_193, *PBlob_Generic_193;

struct Blob_Generic_193 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_43 Blob_MethodRefSig_43, *PBlob_MethodRefSig_43;

typedef struct MethodRefSig_43 MethodRefSig_43, *PMethodRefSig_43;

typedef struct Type_28122 Type_28122, *PType_28122;

typedef struct Type_28123 Type_28123, *PType_28123;

struct Type_28123 {
    enum TypeCode ELEMENT_TYPE_STRING;
};

struct Type_28122 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_43 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_28122 RetType;
    struct Type_28123 Param0;
};

struct Blob_MethodRefSig_43 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_43 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_PropertySig_1071 Blob_PropertySig_1071, *PBlob_PropertySig_1071;

typedef struct PropertySig_1071 PropertySig_1071, *PPropertySig_1071;

typedef struct Type_29150 Type_29150, *PType_29150;

struct Type_29150 {
    struct GenericInstType_29151 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1071 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29150 RetType; // Return type
};

struct Blob_PropertySig_1071 {
    byte Size; // coded integer - blob size
    struct PropertySig_1071 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1062 Blob_PropertySig_1062, *PBlob_PropertySig_1062;

typedef struct PropertySig_1062 PropertySig_1062, *PPropertySig_1062;

typedef struct Type_29141 Type_29141, *PType_29141;

struct Type_29141 {
    struct GenericInstType_29142 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1062 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29141 RetType; // Return type
};

struct Blob_PropertySig_1062 {
    byte Size; // coded integer - blob size
    struct PropertySig_1062 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_809 Blob_PropertySig_809, *PBlob_PropertySig_809;

typedef struct PropertySig_809 PropertySig_809, *PPropertySig_809;

typedef struct Type_28888 Type_28888, *PType_28888;

struct Type_28888 {
    struct GenericInstType_28889 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_809 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28888 RetType; // Return type
};

struct Blob_PropertySig_809 {
    byte Size; // coded integer - blob size
    struct PropertySig_809 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_804 Blob_PropertySig_804, *PBlob_PropertySig_804;

typedef struct PropertySig_804 PropertySig_804, *PPropertySig_804;

typedef struct Type_28883 Type_28883, *PType_28883;

struct Type_28883 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_804 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_28883 RetType; // Return type
};

struct Blob_PropertySig_804 {
    byte Size; // coded integer - blob size
    struct PropertySig_804 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_1 Blob_Generic_1, *PBlob_Generic_1;

struct Blob_Generic_1 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_5193 Blob_Generic_5193, *PBlob_Generic_5193;

struct Blob_Generic_5193 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_Generic_6285 Blob_Generic_6285, *PBlob_Generic_6285;

struct Blob_Generic_6285 {
    byte Size; // coded integer - blob size
    byte Generic[52]; // Undefined blob contents
};

typedef struct Blob_Generic_6048 Blob_Generic_6048, *PBlob_Generic_6048;

struct Blob_Generic_6048 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1834 Blob_Generic_1834, *PBlob_Generic_1834;

struct Blob_Generic_1834 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_1841 Blob_Generic_1841, *PBlob_Generic_1841;

struct Blob_Generic_1841 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_1848 Blob_Generic_1848, *PBlob_Generic_1848;

struct Blob_Generic_1848 {
    word Size; // coded integer - blob size
    byte Generic[639]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_18 Blob_MethodRefSig_18, *PBlob_MethodRefSig_18;

typedef struct MethodRefSig_18 MethodRefSig_18, *PMethodRefSig_18;

typedef struct Type_28097 Type_28097, *PType_28097;

struct Type_28097 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_18 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_28097 RetType;
};

struct Blob_MethodRefSig_18 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_18 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_6069 Blob_Generic_6069, *PBlob_Generic_6069;

struct Blob_Generic_6069 {
    byte Size; // coded integer - blob size
    byte Generic[49]; // Undefined blob contents
};

typedef struct Blob_Generic_2702 Blob_Generic_2702, *PBlob_Generic_2702;

struct Blob_Generic_2702 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_ConstantSig_3355.conflict Blob_ConstantSig_3355.conflict, *PBlob_ConstantSig_3355.conflict;

typedef struct ConstantSig_3355.conflict ConstantSig_3355.conflict, *PConstantSig_3355.conflict;

struct ConstantSig_3355.conflict {
    dword ELEMENT_TYPE_U4;
};

struct Blob_ConstantSig_3355.conflict {
    byte Size; // coded integer - blob size
    struct ConstantSig_3355.conflict ConstantSig; // Data stored in a constant
};

typedef struct Blob_PropertySig_3294 Blob_PropertySig_3294, *PBlob_PropertySig_3294;

typedef struct PropertySig_3294 PropertySig_3294, *PPropertySig_3294;

typedef struct Type_31373 Type_31373, *PType_31373;

struct Type_31373 {
    struct Class.conflict ELEMENT_TYPE_CLASS;
};

struct PropertySig_3294 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_31373 RetType; // Return type
};

struct Blob_PropertySig_3294 {
    byte Size; // coded integer - blob size
    struct PropertySig_3294 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_2711 Blob_Generic_2711, *PBlob_Generic_2711;

struct Blob_Generic_2711 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_2959 Blob_Generic_2959, *PBlob_Generic_2959;

struct Blob_Generic_2959 {
    byte Size; // coded integer - blob size
    byte Generic[2]; // Undefined blob contents
};

typedef struct Blob_Generic_3370 Blob_Generic_3370, *PBlob_Generic_3370;

struct Blob_Generic_3370 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_1192 Blob_Generic_1192, *PBlob_Generic_1192;

struct Blob_Generic_1192 {
    word Size; // coded integer - blob size
    byte Generic[640]; // Undefined blob contents
};

typedef struct Blob_Generic_84 Blob_Generic_84, *PBlob_Generic_84;

struct Blob_Generic_84 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_3131 Blob_Generic_3131, *PBlob_Generic_3131;

struct Blob_Generic_3131 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_384 Blob_Generic_384, *PBlob_Generic_384;

struct Blob_Generic_384 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_388 Blob_Generic_388, *PBlob_Generic_388;

struct Blob_Generic_388 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3375 Blob_Generic_3375, *PBlob_Generic_3375;

struct Blob_Generic_3375 {
    byte Size; // coded integer - blob size
    byte Generic[33]; // Undefined blob contents
};

typedef struct Blob_Generic_5796 Blob_Generic_5796, *PBlob_Generic_5796;

struct Blob_Generic_5796 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_Generic_6401 Blob_Generic_6401, *PBlob_Generic_6401;

struct Blob_Generic_6401 {
    byte Size; // coded integer - blob size
    byte Generic[42]; // Undefined blob contents
};

typedef struct Blob_Generic_94 Blob_Generic_94, *PBlob_Generic_94;

struct Blob_Generic_94 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_90 Blob_Generic_90, *PBlob_Generic_90;

struct Blob_Generic_90 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_3143 Blob_Generic_3143, *PBlob_Generic_3143;

struct Blob_Generic_3143 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_130 Blob_Generic_130, *PBlob_Generic_130;

struct Blob_Generic_130 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_372 Blob_Generic_372, *PBlob_Generic_372;

struct Blob_Generic_372 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_134 Blob_Generic_134, *PBlob_Generic_134;

struct Blob_Generic_134 {
    byte Size; // coded integer - blob size
    byte Generic[16]; // Undefined blob contents
};

typedef struct Blob_Generic_376 Blob_Generic_376, *PBlob_Generic_376;

struct Blob_Generic_376 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_5327 Blob_Generic_5327, *PBlob_Generic_5327;

struct Blob_Generic_5327 {
    byte Size; // coded integer - blob size
    byte Generic[34]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1002 Blob_PropertySig_1002, *PBlob_PropertySig_1002;

typedef struct PropertySig_1002 PropertySig_1002, *PPropertySig_1002;

typedef struct Type_29081 Type_29081, *PType_29081;

struct Type_29081 {
    struct GenericInstType_29082 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1002 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29081 RetType; // Return type
};

struct Blob_PropertySig_1002 {
    byte Size; // coded integer - blob size
    struct PropertySig_1002 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_122 Blob_Generic_122, *PBlob_Generic_122;

struct Blob_Generic_122 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_3151 Blob_Generic_3151, *PBlob_Generic_3151;

struct Blob_Generic_3151 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_4488 Blob_Generic_4488, *PBlob_Generic_4488;

struct Blob_Generic_4488 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_65 Blob_Generic_65, *PBlob_Generic_65;

struct Blob_Generic_65 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_4249 Blob_Generic_4249, *PBlob_Generic_4249;

struct Blob_Generic_4249 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_4006 Blob_Generic_4006, *PBlob_Generic_4006;

struct Blob_Generic_4006 {
    byte Size; // coded integer - blob size
    byte Generic[68]; // Undefined blob contents
};

typedef struct Blob_Generic_3163 Blob_Generic_3163, *PBlob_Generic_3163;

struct Blob_Generic_3163 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_350 Blob_Generic_350, *PBlob_Generic_350;

struct Blob_Generic_350 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_3169 Blob_Generic_3169, *PBlob_Generic_3169;

struct Blob_Generic_3169 {
    byte Size; // coded integer - blob size
    byte Generic[9]; // Undefined blob contents
};

typedef struct Blob_Generic_597 Blob_Generic_597, *PBlob_Generic_597;

struct Blob_Generic_597 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_112 Blob_Generic_112, *PBlob_Generic_112;

struct Blob_Generic_112 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_5109 Blob_Generic_5109, *PBlob_Generic_5109;

struct Blob_Generic_5109 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_78 Blob_Generic_78, *PBlob_Generic_78;

struct Blob_Generic_78 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_117 Blob_Generic_117, *PBlob_Generic_117;

struct Blob_Generic_117 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_359 Blob_Generic_359, *PBlob_Generic_359;

struct Blob_Generic_359 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_181 Blob_Generic_181, *PBlob_Generic_181;

struct Blob_Generic_181 {
    byte Size; // coded integer - blob size
    byte Generic[11]; // Undefined blob contents
};

typedef struct Blob_Generic_3179 Blob_Generic_3179, *PBlob_Generic_3179;

struct Blob_Generic_3179 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_5597 Blob_Generic_5597, *PBlob_Generic_5597;

struct Blob_Generic_5597 {
    byte Size; // coded integer - blob size
    byte Generic[39]; // Undefined blob contents
};

typedef struct Blob_Generic_6444 Blob_Generic_6444, *PBlob_Generic_6444;

struct Blob_Generic_6444 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6204 Blob_Generic_6204, *PBlob_Generic_6204;

struct Blob_Generic_6204 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1039 Blob_PropertySig_1039, *PBlob_PropertySig_1039;

typedef struct PropertySig_1039 PropertySig_1039, *PPropertySig_1039;

typedef struct Type_29118 Type_29118, *PType_29118;

struct Type_29118 {
    struct GenericInstType_29119 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1039 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29118 RetType; // Return type
};

struct Blob_PropertySig_1039 {
    byte Size; // coded integer - blob size
    struct PropertySig_1039 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_4270 Blob_Generic_4270, *PBlob_Generic_4270;

struct Blob_Generic_4270 {
    byte Size; // coded integer - blob size
    byte Generic[61]; // Undefined blob contents
};

typedef struct Blob_Generic_3184 Blob_Generic_3184, *PBlob_Generic_3184;

struct Blob_Generic_3184 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_5362 Blob_Generic_5362, *PBlob_Generic_5362;

struct Blob_Generic_5362 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_PropertySig_3220 Blob_PropertySig_3220, *PBlob_PropertySig_3220;

typedef struct PropertySig_3220 PropertySig_3220, *PPropertySig_3220;

typedef struct Type_31299 Type_31299, *PType_31299;

struct Type_31299 {
    struct ValueType.conflict3 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_3220 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_31299 RetType; // Return type
};

struct Blob_PropertySig_3220 {
    byte Size; // coded integer - blob size
    struct PropertySig_3220 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1049 Blob_PropertySig_1049, *PBlob_PropertySig_1049;

typedef struct PropertySig_1049 PropertySig_1049, *PPropertySig_1049;

typedef struct Type_29128 Type_29128, *PType_29128;

struct Type_29128 {
    struct GenericInstType_29129 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1049 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29128 RetType; // Return type
};

struct Blob_PropertySig_1049 {
    byte Size; // coded integer - blob size
    struct PropertySig_1049 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_5130 Blob_Generic_5130, *PBlob_Generic_5130;

struct Blob_Generic_5130 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_6465 Blob_Generic_6465, *PBlob_Generic_6465;

struct Blob_Generic_6465 {
    byte Size; // coded integer - blob size
    byte Generic[56]; // Undefined blob contents
};

typedef struct Blob_Generic_165 Blob_Generic_165, *PBlob_Generic_165;

struct Blob_Generic_165 {
    byte Size; // coded integer - blob size
    byte Generic[15]; // Undefined blob contents
};

typedef struct Blob_Generic_3195 Blob_Generic_3195, *PBlob_Generic_3195;

struct Blob_Generic_3195 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1011 Blob_PropertySig_1011, *PBlob_PropertySig_1011;

typedef struct PropertySig_1011 PropertySig_1011, *PPropertySig_1011;

typedef struct Type_29090 Type_29090, *PType_29090;

struct Type_29090 {
    struct GenericInstType_29091 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1011 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29090 RetType; // Return type
};

struct Blob_PropertySig_1011 {
    byte Size; // coded integer - blob size
    struct PropertySig_1011 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_151 Blob_Generic_151, *PBlob_Generic_151;

struct Blob_Generic_151 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_5383 Blob_Generic_5383, *PBlob_Generic_5383;

struct Blob_Generic_5383 {
    byte Size; // coded integer - blob size
    byte Generic[48]; // Undefined blob contents
};

typedef struct Blob_Generic_396 Blob_Generic_396, *PBlob_Generic_396;

struct Blob_Generic_396 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_158 Blob_Generic_158, *PBlob_Generic_158;

struct Blob_Generic_158 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_PropertySig_1020 Blob_PropertySig_1020, *PBlob_PropertySig_1020;

typedef struct PropertySig_1020 PropertySig_1020, *PPropertySig_1020;

typedef struct Type_29099 Type_29099, *PType_29099;

struct Type_29099 {
    struct ValueType.conflict8 ELEMENT_TYPE_VALUETYPE;
};

struct PropertySig_1020 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29099 RetType; // Return type
};

struct Blob_PropertySig_1020 {
    byte Size; // coded integer - blob size
    struct PropertySig_1020 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_1025 Blob_PropertySig_1025, *PBlob_PropertySig_1025;

typedef struct PropertySig_1025 PropertySig_1025, *PPropertySig_1025;

typedef struct Type_29104 Type_29104, *PType_29104;

struct Type_29104 {
    struct GenericInstType_29105 ELEMENT_TYPE_GENERICINST;
};

struct PropertySig_1025 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_29104 RetType; // Return type
};

struct Blob_PropertySig_1025 {
    byte Size; // coded integer - blob size
    struct PropertySig_1025 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_FieldSig_2970 Blob_FieldSig_2970, *PBlob_FieldSig_2970;

typedef struct FieldSig_2970 FieldSig_2970, *PFieldSig_2970;

typedef struct Type_31048 Type_31048, *PType_31048;

struct Type_31048 {
    struct ValueType.conflict ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_2970 {
    byte FIELD; // Magic (0x06)
    struct Type_31048 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_2970 {
    byte Size; // coded integer - blob size
    struct FieldSig_2970 FieldSig; // Type information for Field
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

typedef struct MethodImpl Row MethodImpl Row, *PMethodImpl Row;

struct MethodImpl Row {
    word Class; // index into TypeDef
    word MethodBody; // MethodDefOrRef coded index
    word MethodDeclaration; // MethodDefOrRef coded index
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

typedef struct CustomAttribute Row CustomAttribute Row, *PCustomAttribute Row;

struct CustomAttribute Row {
    word Parent;
    word Type;
    word Value;
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

typedef struct TypeRef Row TypeRef Row, *PTypeRef Row;

struct TypeRef Row {
    word ResolutionScope;
    word TypeName;
    word TypeNamespace;
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

typedef struct InterfaceImpl Row InterfaceImpl Row, *PInterfaceImpl Row;

struct InterfaceImpl Row {
    word Class; // index into TypeDef table
    word Interface; // index into TypeDef/TypeRef/TypeSpec - TypeDefOrRef coded
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

typedef struct PropertyMap Row PropertyMap Row, *PPropertyMap Row;

struct PropertyMap Row {
    word Parent;
    word options; // Index into Property table. Points to contiguous run of Properties until next ref from PropertyMap or end of table.
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
    char [2c][15];
    char [3b][24];
    char [53][14];
    char [61][6];
    char [67][22];
    char [7d][20];
    char [91][34];
    char [b3][14];
    char [c1][14];
    char [cf][8];
    char [d7][18];
    char [e9][28];
    char [105][18];
    char [117][8];
    char [11f][34];
    char [141][36];
    char [165][24];
    char [17d][24];
    char [195][14];
    char [1a3][38];
    char [1c9][28];
    char [1e5][18];
    char [1f7][41];
    char [220][31];
    char [23f][21];
    char [254][38];
    char [27a][28];
    char [296][28];
    char [2b2][18];
    char [2c4][42];
    char [2ee][32];
    char [30e][22];
    char [324][45];
    char [351][35];
    char [374][25];
    char [38d][9];
    char [396][17];
    char [3a7][11];
    char [3b2][14];
    char [3c0][17];
    char [3d1][21];
    char [3e6][21];
    char [3fb][22];
    char [411][33];
    char [432][21];
    char [447][23];
    char [45e][13];
    char [46b][30];
    char [489][20];
    char [49d][20];
    char [4b1][10];
    char [4bb][12];
    char [4c7][39];
    char [4ee][29];
    char [50b][19];
    char [51e][20];
    char [532][11];
    char [53d][34];
    char [55f][21];
    char [574][24];
    char [58c][14];
    char [59a][15];
    char [5a9][20];
    char [5bd][12];
    char [5c9][12];
    char [5d5][27];
    char [5f0][23];
    char [607][17];
    char [618][7];
    char [61f][12];
    char [62b][23];
    char [642][14];
    char [650][15];
    char [65f][13];
    char [66c][14];
    char [67a][25];
    char [693][13];
    char [6a0][40];
    char [6c8][30];
    char [6e6][20];
    char [6fa][31];
    char [719][21];
    char [72e][11];
    char [739][12];
    char [745][8];
    char [74d][35];
    char [770][25];
    char [789][15];
    char [798][19];
    char [7ab][33];
    char [7cc][13];
    char [7d9][36];
    char [7fd][16];
    char [80d][9];
    char [816][8];
    char [81e][9];
    char [827][38];
    char [84d][40];
    char [875][17];
    char [886][28];
    char [8a2][14];
    char [8b0][21];
    char [8c5][5];
    char [8ca][7];
    char [8d1][16];
    char [8e1][21];
    char [8f6][19];
    char [909][15];
    char [918][28];
    char [934][15];
    char [943][7];
    char [94a][17];
    char [95b][18];
    char [96d][23];
    char [984][18];
    char [996][14];
    char [9a4][31];
    char [9c3][5];
    char [9c8][15];
    char [9d7][9];
    char [9e0][19];
    char [9f3][9];
    char [9fc][13];
    char [a09][11];
    char [a14][6];
    char [a1a][11];
    char [a25][6];
    char [a2b][16];
    char [a3b][30];
    char [a59][18];
    char [a6b][4];
    char [a6f][15];
    char [a7e][25];
    char [a97][5];
    char [a9c][4];
    char [aa0][14];
    char [aae][6];
    char [ab4][10];
    char [abe][6];
    char [ac4][9];
    char [acd][5];
    char [ad2][8];
    char [ada][11];
    char [ae5][16];
    char [af5][6];
    char [afb][19];
    char [b0e][5];
    char [b13][21];
    char [b28][8];
    char [b30][4];
    char [b34][13];
    char [b41][14];
    char [b4f][16];
    char [b5f][9];
    char [b68][9];
    char [b71][7];
    char [b78][5];
    char [b7d][5];
    char [b82][10];
    char [b8c][6];
    char [b92][8];
    char [b9a][27];
    char [bb5][18];
    char [bc7][13];
    char [bd4][6];
    char [bda][9];
    char [be3][17];
    char [bf4][14];
    char [c02][13];
    char [c0f][14];
    char [c1d][10];
    char [c27][9];
    char [c30][10];
    char [c3a][13];
    char [c47][5];
    char [c4c][2];
    char [c4e][15];
    char [c5d][2];
    char [c5f][5];
    char [c64][13];
    char [c71][10];
    char [c7b][9];
    char [c84][10];
    char [c8e][5];
    char [c93][14];
    char [ca1][6];
    char [ca7][9];
    char [cb0][13];
    char [cbd][14];
    char [ccb][7];
    char [cd2][7];
    char [cd9][8];
    char [ce1][7];
    char [ce8][8];
    char [cf0][6];
    char [cf6][7];
    char [cfd][7];
    char [d04][8];
    char [d0c][7];
    char [d13][8];
    char [d1b][7];
    char [d22][8];
    char [d2a][8];
    char [d32][9];
    char [d3b][8];
    char [d43][9];
    char [d4c][8];
    char [d54][9];
    char [d5d][9];
    char [d66][10];
    char [d70][9];
    char [d79][10];
    char [d83][7];
    char [d8a][8];
    char [d92][8];
    char [d9a][9];
    char [da3][8];
    char [dab][9];
    char [db4][6];
    char [dba][7];
    char [dc1][7];
    char [dc8][8];
    char [dd0][7];
    char [dd7][8];
    char [ddf][6];
    char [de5][7];
    char [dec][7];
    char [df3][8];
    char [dfb][7];
    char [e02][8];
    char [e0a][7];
    char [e11][8];
    char [e19][8];
    char [e21][9];
    char [e2a][8];
    char [e32][9];
    char [e3b][7];
    char [e42][8];
    char [e4a][8];
    char [e52][9];
    char [e5b][8];
    char [e63][9];
    char [e6c][7];
    char [e73][8];
    char [e7b][8];
    char [e83][9];
    char [e8c][8];
    char [e94][9];
    char [e9d][7];
    char [ea4][8];
    char [eac][6];
    char [eb2][7];
    char [eb9][7];
    char [ec0][8];
    char [ec8][7];
    char [ecf][8];
    char [ed7][6];
    char [edd][7];
    char [ee4][7];
    char [eeb][8];
    char [ef3][7];
    char [efa][8];
    char [f02][6];
    char [f08][7];
    char [f0f][7];
    char [f16][8];
    char [f1e][7];
    char [f25][8];
    char [f2d][7];
    char [f34][8];
    char [f3c][8];
    char [f44][9];
    char [f4d][8];
    char [f55][9];
    char [f5e][7];
    char [f65][8];
    char [f6d][8];
    char [f75][9];
    char [f7e][8];
    char [f86][9];
    char [f8f][8];
    char [f97][9];
    char [fa0][9];
    char [fa9][10];
    char [fb3][9];
    char [fbc][10];
    char [fc6][9];
    char [fcf][10];
    char [fd9][10];
    char [fe3][11];
    char [fee][10];
    char [ff8][11];
    char [1003][7];
    char [100a][6];
    char [1010][7];
    char [1017][6];
    char [101d][6];
    char [1023][5];
    char [1028][6];
    char [102e][5];
    char [1033][6];
    char [1039][5];
    char [103e][5];
    char [1043][4];
    char [1047][5];
    char [104c][4];
    char [1050][5];
    char [1055][4];
    char [1059][4];
    char [105d][3];
    char [1060][5];
    char [1065][4];
    char [1069][5];
    char [106e][4];
    char [1072][4];
    char [1076][3];
    char [1079][4];
    char [107d][3];
    char [1080][4];
    char [1084][3];
    char [1087][3];
    char [108a][2];
    char [108c][4];
    char [1090][3];
    char [1093][4];
    char [1097][3];
    char [109a][3];
    char [109d][2];
    char [109f][4];
    char [10a3][3];
    char [10a6][4];
    char [10aa][3];
    char [10ad][3];
    char [10b0][2];
    char [10b2][4];
    char [10b6][3];
    char [10b9][5];
    char [10be][4];
    char [10c2][5];
    char [10c7][4];
    char [10cb][4];
    char [10cf][3];
    char [10d2][5];
    char [10d7][4];
    char [10db][5];
    char [10e0][4];
    char [10e4][4];
    char [10e8][3];
    char [10eb][5];
    char [10f0][4];
    char [10f4][5];
    char [10f9][4];
    char [10fd][4];
    char [1101][3];
    char [1104][4];
    char [1108][3];
    char [110b][4];
    char [110f][3];
    char [1112][3];
    char [1115][2];
    char [1117][4];
    char [111b][3];
    char [111e][4];
    char [1122][3];
    char [1125][3];
    char [1128][2];
    char [112a][5];
    char [112f][4];
    char [1133][5];
    char [1138][4];
    char [113c][4];
    char [1140][3];
    char [1143][6];
    char [1149][5];
    char [114e][6];
    char [1154][5];
    char [1159][5];
    char [115e][4];
    char [1162][5];
    char [1167][4];
    char [116b][5];
    char [1170][4];
    char [1174][4];
    char [1178][3];
    char [117b][4];
    char [117f][3];
    char [1182][4];
    char [1186][3];
    char [1189][3];
    char [118c][2];
    char [118e][4];
    char [1192][3];
    char [1195][4];
    char [1199][3];
    char [119c][3];
    char [119f][3];
    char [11a2][3];
    char [11a5][4];
    char [11a9][3];
    char [11ac][4];
    char [11b0][2];
    char [11b2][3];
    char [11b5][3];
    char [11b8][4];
    char [11bc][3];
    char [11bf][4];
    char [11c3][3];
    char [11c6][4];
    char [11ca][4];
    char [11ce][5];
    char [11d3][4];
    char [11d7][5];
    char [11dc][4];
    char [11e0][5];
    char [11e5][5];
    char [11ea][6];
    char [11f0][5];
    char [11f5][6];
    char [11fb][3];
    char [11fe][4];
    char [1202][4];
    char [1206][5];
    char [120b][4];
    char [120f][5];
    char [1214][2];
    char [1216][3];
    char [1219][3];
    char [121c][4];
    char [1220][3];
    char [1223][4];
    char [1227][2];
    char [1229][3];
    char [122c][3];
    char [122f][4];
    char [1233][3];
    char [1236][4];
    char [123a][3];
    char [123d][4];
    char [1241][4];
    char [1245][5];
    char [124a][4];
    char [124e][5];
    char [1253][3];
    char [1256][4];
    char [125a][4];
    char [125e][5];
    char [1263][4];
    char [1267][5];
    char [126c][3];
    char [126f][4];
    char [1273][4];
    char [1277][5];
    char [127c][4];
    char [1280][5];
    char [1285][3];
    char [1288][4];
    char [128c][2];
    char [128e][3];
    char [1291][3];
    char [1294][4];
    char [1298][3];
    char [129b][4];
    char [129f][2];
    char [12a1][3];
    char [12a4][3];
    char [12a7][4];
    char [12ab][3];
    char [12ae][4];
    char [12b2][2];
    char [12b4][3];
    char [12b7][3];
    char [12ba][4];
    char [12be][3];
    char [12c1][4];
    char [12c5][3];
    char [12c8][4];
    char [12cc][4];
    char [12d0][5];
    char [12d5][4];
    char [12d9][5];
    char [12de][3];
    char [12e1][4];
    char [12e5][4];
    char [12e9][5];
    char [12ee][4];
    char [12f2][5];
    char [12f7][4];
    char [12fb][5];
    char [1300][5];
    char [1305][6];
    char [130b][5];
    char [1310][6];
    char [1316][5];
    char [131b][6];
    char [1321][6];
    char [1327][7];
    char [132e][6];
    char [1334][7];
    char [133b][6];
    char [1341][7];
    char [1348][8];
    char [1350][7];
    char [1357][6];
    char [135d][6];
    char [1363][7];
    char [136a][7];
    char [1371][7];
    char [1378][7];
    char [137f][6];
    char [1385][6];
    char [138b][6];
    char [1391][7];
    char [1398][8];
    char [13a0][6];
    char [13a6][7];
    char [13ad][6];
    char [13b3][4];
    char [13b7][4];
    char [13bb][5];
    char [13c0][6];
    char [13c6][10];
    char [13d0][6];
    char [13d6][8];
    char [13de][15];
    char [13ed][4];
    char [13f1][4];
    char [13f5][11];
    char [1400][17];
    char [1411][9];
    char [141a][17];
    char [142b][9];
    char [1434][14];
    char [1442][6];
    char [1448][17];
    char [1459][9];
    char [1462][10];
    char [146c][10];
    char [1476][6];
    char [147c][8];
    char [1484][15];
    char [1493][6];
    char [1499][23];
    char [14b0][8];
    char [14b8][7];
    char [14bf][9];
    char [14c8][4];
    char [14cc][4];
    char [14d0][20];
    char [14e4][16];
    char [14f4][21];
    char [1509][12];
    char [1515][5];
    char [151a][6];
    char [1520][7];
    char [1527][15];
    char [1536][12];
    char [1542][4];
    char [1546][5];
    char [154b][5];
    char [1550][6];
    char [1556][8];
    char [155e][6];
    char [1564][10];
    char [156e][14];
    char [157c][12];
    char [1588][16];
    char [1598][9];
    char [15a1][10];
    char [15ab][10];
    char [15b5][12];
    char [15c1][16];
    char [15d1][12];
    char [15dd][8];
    char [15e5][6];
    char [15eb][6];
    char [15f1][5];
    char [15f6][5];
    char [15fb][6];
    char [1601][6];
    char [1607][12];
    char [1613][18];
    char [1625][12];
    char [1631][11];
    char [163c][8];
    char [1644][11];
    char [164f][17];
    char [1660][21];
    char [1675][1];
    char [1676][1];
    char [1677][1];
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
    struct TypeRef Row TypeRef[29]; // CLI Metadata Table: TypeRef
    struct TypeDef Row TypeDef[84]; // CLI Metadata Table: TypeDef
    struct Field Row Field[22]; // CLI Metadata Table: Field
    struct MethodDef Row MethodDef[478]; // CLI Metadata Table: MethodDef
    struct ParamRow Param[824]; // CLI Metadata Table: Param
    struct InterfaceImpl Row InterfaceImpl[33]; // CLI Metadata Table: InterfaceImpl
    struct MemberRef Row MemberRef[12]; // CLI Metadata Table: MemberRef
    struct Constant Row Constant[17]; // CLI Metadata Table: Constant
    struct CustomAttribute Row CustomAttribute[364]; // CLI Metadata Table: CustomAttribute
    struct PropertyMap Row PropertyMap[26]; // CLI Metadata Table: PropertyMap
    struct Property Row Property[355]; // CLI Metadata Table: Property
    struct MethodSemantics Row MethodSemantics[396]; // CLI Metadata Table: MethodSemantics
    struct MethodImpl Row MethodImpl[193]; // CLI Metadata Table: MethodImpl
    struct Assembly Table Assembly; // CLI Metadata Table: Assembly
    struct AssemblyRef Row AssemblyRef[5]; // CLI Metadata Table: AssemblyRef
};

typedef struct #Blob #Blob, *P#Blob;

struct #Blob {
    byte Reserved; // Always 0
    struct Blob_Generic_1 [1];
    struct Blob_Generic_10 [a];
    struct Blob_Generic_14 [e];
    struct Blob_MethodRefSig_18 MethodRefSig_18; // Type info for imported method return and params
    struct Blob_Generic_22 [16];
    struct Blob_PropertySig_26 PropertySig_26; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_30 [1e];
    struct Blob_PropertySig_34 PropertySig_34; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_38 [26];
    struct Blob_MethodRefSig_43 MethodRefSig_43; // Type info for imported method return and params
    struct Blob_Generic_48 [30];
    struct Blob_Generic_53 [35];
    struct Blob_Generic_59 [3b];
    struct Blob_Generic_65 [41];
    struct Blob_Generic_78 [4e];
    struct Blob_Generic_84 [54];
    struct Blob_Generic_90 [5a];
    struct Blob_Generic_94 [5e];
    struct Blob_Generic_102 [66];
    struct Blob_Generic_107 [6b];
    struct Blob_PropertySig_112 PropertySig_112; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_117 PropertySig_117; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_122 PropertySig_122; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_130 PropertySig_130; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_134 [86];
    struct Blob_Generic_151 [97];
    struct Blob_Generic_158 [9e];
    struct Blob_Generic_165 [a5];
    struct Blob_Generic_181 [b5];
    struct Blob_Generic_193 [c1];
    struct Blob_Generic_204 [cc];
    struct Blob_Generic_212 [d4];
    struct Blob_Generic_221 [dd];
    struct Blob_Generic_230 [e6];
    struct Blob_Generic_240 [f0];
    struct Blob_Generic_249 [f9];
    struct Blob_PropertySig_259 PropertySig_259; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_268 PropertySig_268; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_277 PropertySig_277; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_285 [11d];
    struct Blob_Generic_308 [134];
    struct Blob_Generic_330 [14a];
    struct Blob_Generic_338 [152];
    struct Blob_Generic_350 [15e];
    struct Blob_Generic_359 [167];
    struct Blob_Generic_372 [174];
    struct Blob_Generic_376 [178];
    struct Blob_Generic_384 [180];
    struct Blob_Generic_388 [184];
    struct Blob_Generic_396 [18c];
    struct Blob_Generic_400 [190];
    struct Blob_Generic_408 [198];
    struct Blob_Generic_412 [19c];
    struct Blob_Generic_420 [1a4];
    struct Blob_Generic_424 [1a8];
    struct Blob_Generic_432 [1b0];
    struct Blob_Generic_437 [1b5];
    struct Blob_Generic_442 [1ba];
    struct Blob_Generic_451 [1c3];
    struct Blob_Generic_460 [1cc];
    struct Blob_Generic_473 [1d9];
    struct Blob_Generic_483 [1e3];
    struct Blob_Generic_497 [1f1];
    struct Blob_Generic_502 [1f6];
    struct Blob_Generic_511 [1ff];
    struct Blob_Generic_520 [208];
    struct Blob_Generic_533 [215];
    struct Blob_Generic_543 [21f];
    struct Blob_Generic_557 [22d];
    struct Blob_Generic_563 [233];
    struct Blob_Generic_573 [23d];
    struct Blob_Generic_583 [247];
    struct Blob_Generic_597 [255];
    struct Blob_Generic_608 [260];
    struct Blob_Generic_623 [26f];
    struct Blob_Generic_629 [275];
    struct Blob_Generic_639 [27f];
    struct Blob_Generic_649 [289];
    struct Blob_Generic_663 [297];
    struct Blob_Generic_674 [2a2];
    struct Blob_Generic_689 [2b1];
    struct Blob_Generic_694 [2b6];
    struct Blob_Generic_703 [2bf];
    struct Blob_Generic_713 [2c9];
    struct Blob_Generic_718 [2ce];
    struct Blob_Generic_727 [2d7];
    struct Blob_Generic_737 [2e1];
    struct Blob_Generic_742 [2e6];
    struct Blob_Generic_751 [2ef];
    struct Blob_PropertySig_761 PropertySig_761; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_771 PropertySig_771; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_780 PropertySig_780; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_785 PropertySig_785; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_795 PropertySig_795; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_804 PropertySig_804; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_809 PropertySig_809; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_819 PropertySig_819; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_828 PropertySig_828; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_833 PropertySig_833; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_848 PropertySig_848; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_859 PropertySig_859; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_873 PropertySig_873; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_883 PropertySig_883; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_893 PropertySig_893; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_899 PropertySig_899; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_914 PropertySig_914; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_925 PropertySig_925; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_939 PropertySig_939; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_949 PropertySig_949; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_959 PropertySig_959; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_965 PropertySig_965; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_979 PropertySig_979; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_989 PropertySig_989; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1002 PropertySig_1002; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1011 PropertySig_1011; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1020 PropertySig_1020; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1025 PropertySig_1025; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1039 PropertySig_1039; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1049 PropertySig_1049; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1062 PropertySig_1062; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1071 PropertySig_1071; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1080 PropertySig_1080; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1085 PropertySig_1085; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1090 PropertySig_1090; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1103 PropertySig_1103; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1112 PropertySig_1112; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1124 PropertySig_1124; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1132 PropertySig_1132; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1140 PropertySig_1140; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1144 PropertySig_1144; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1152 PropertySig_1152; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1156 PropertySig_1156; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1164 PropertySig_1164; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1168 PropertySig_1168; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1176 PropertySig_1176; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1180 PropertySig_1180; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_1188 PropertySig_1188; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_1192 [4a8];
    struct Blob_Generic_1834 [72a];
    struct Blob_Generic_1841 [731];
    struct Blob_Generic_1848 [738];
    struct Blob_Generic_2489 [9b9];
    struct Blob_Generic_2596 [a24];
    struct Blob_Generic_2702 [a8e];
    struct Blob_Generic_2711 [a97];
    struct Blob_Generic_2720 [aa0];
    struct Blob_Generic_2729 [aa9];
    struct Blob_Generic_2738 [ab2];
    struct Blob_Generic_2747 [abb];
    struct Blob_Generic_2753 [ac1];
    struct Blob_Generic_2763 [acb];
    struct Blob_Generic_2773 [ad5];
    struct Blob_Generic_2784 [ae0];
    struct Blob_Generic_2795 [aeb];
    struct Blob_Generic_2878 [b3e];
    struct Blob_FieldSig_2959 FieldSig_2959; // Type information for Field
    struct Blob_FieldSig_2962 FieldSig_2962; // Type information for Field
    struct Blob_FieldSig_2967 FieldSig_2967; // Type information for Field
    struct Blob_FieldSig_2970 FieldSig_2970; // Type information for Field
    struct Blob_Generic_2975 [b9f];
    struct Blob_PropertySig_2983 PropertySig_2983; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_2991 [baf];
    struct Blob_PropertySig_2999 PropertySig_2999; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3007 [bbf];
    struct Blob_Generic_3013 [bc5];
    struct Blob_PropertySig_3019 PropertySig_3019; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_PropertySig_3025 PropertySig_3025; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3031 [bd7];
    struct Blob_Generic_3043 [be3];
    struct Blob_Generic_3053 [bed];
    struct Blob_Generic_3058 [bf2];
    struct Blob_Generic_3063 [bf7];
    struct Blob_Generic_3068 [bfc];
    struct Blob_Generic_3074 [c02];
    struct Blob_Generic_3081 [c09];
    struct Blob_Generic_3088 [c10];
    struct Blob_PropertySig_3095 PropertySig_3095; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3101 [c1d];
    struct Blob_Generic_3107 [c23];
    struct Blob_FieldSig_3113 FieldSig_3113; // Type information for Field
    struct Blob_FieldSig_3118 FieldSig_3118; // Type information for Field
    struct Blob_Generic_3123 [c33];
    struct Blob_Generic_3131 [c3b];
    struct Blob_Generic_3143 [c47];
    struct Blob_Generic_3151 [c4f];
    struct Blob_Generic_3163 [c5b];
    struct Blob_Generic_3169 [c61];
    struct Blob_Generic_3179 [c6b];
    struct Blob_Generic_3184 [c70];
    struct Blob_Generic_3195 [c7b];
    struct Blob_Generic_3202 [c82];
    struct Blob_Generic_3208 [c88];
    struct Blob_Generic_3214 [c8e];
    struct Blob_PropertySig_3220 PropertySig_3220; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_3226 [c9a];
    struct Blob_Generic_3240 [ca8];
    struct Blob_Generic_3252 [cb4];
    struct Blob_Generic_3259 [cbb];
    struct Blob_Generic_3266 [cc2];
    struct Blob_Generic_3272 [cc8];
    struct Blob_FieldSig_3278 FieldSig_3278; // Type information for Field
    struct Blob_Generic_3283 [cd3];
    struct Blob_Generic_3288 [cd8];
    struct Blob_PropertySig_3294 PropertySig_3294; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_MethodRefSig_3300 MethodRefSig_3300; // Type info for imported method return and params
    struct Blob_MethodRefSig_3305 MethodRefSig_3305; // Type info for imported method return and params
    struct Blob_MethodRefSig_3320 MethodRefSig_3320; // Type info for imported method return and params
    struct Blob_MethodRefSig_3326 MethodRefSig_3326; // Type info for imported method return and params
    struct Blob_MethodRefSig_3333 MethodRefSig_3333; // Type info for imported method return and params
    struct Blob_MethodRefSig_3339 MethodRefSig_3339; // Type info for imported method return and params
    struct Blob_ConstantSig_3345 ConstantSig_3345; // Data stored in a constant
    struct Blob_CustomAttrib_3350 CustomAttrib_3350; // A CustomAttrib blob stores values of fixed or named parameters supplied when instantiating a custom attribute
    struct Blob_ConstantSig_3355 ConstantSig_3355; // Data stored in a constant
    struct Blob_ConstantSig_3360 ConstantSig_3360; // Data stored in a constant
    struct Blob_ConstantSig_3365 ConstantSig_3365; // Data stored in a constant
    struct Blob_ConstantSig_3370 ConstantSig_3370; // Data stored in a constant
    struct Blob_Generic_3375 [d2f];
    struct Blob_Generic_3409 [d51];
    struct Blob_Generic_3418 [d5a];
    struct Blob_Generic_3439 [d6f];
    struct Blob_Generic_3460 [d84];
    struct Blob_Generic_3481 [d99];
    struct Blob_Generic_3490 [da2];
    struct Blob_Generic_3499 [dab];
    struct Blob_Generic_3547 [ddb];
    struct Blob_Generic_3568 [df0];
    struct Blob_Generic_3589 [e05];
    struct Blob_Generic_3610 [e1a];
    struct Blob_Generic_3644 [e3c];
    struct Blob_Generic_3665 [e51];
    struct Blob_Generic_3686 [e66];
    struct Blob_Generic_3707 [e7b];
    struct Blob_Generic_3735 [e97];
    struct Blob_Generic_3756 [eac];
    struct Blob_Generic_3777 [ec1];
    struct Blob_Generic_3819 [eeb];
    struct Blob_Generic_3874 [f22];
    struct Blob_Generic_3895 [f37];
    struct Blob_Generic_3916 [f4c];
    struct Blob_Generic_3937 [f61];
    struct Blob_Generic_4006 [fa6];
    struct Blob_Generic_4075 [feb];
    struct Blob_Generic_4134 [1026];
    struct Blob_Generic_4155 [103b];
    struct Blob_Generic_4176 [1050];
    struct Blob_Generic_4249 [1099];
    struct Blob_Generic_4270 [10ae];
    struct Blob_Generic_4332 [10ec];
    struct Blob_Generic_4353 [1101];
    struct Blob_Generic_4429 [114d];
    struct Blob_Generic_4488 [1188];
    struct Blob_Generic_4509 [119d];
    struct Blob_Generic_4530 [11b2];
    struct Blob_Generic_4551 [11c7];
    struct Blob_Generic_4624 [1210];
    struct Blob_Generic_4697 [1259];
    struct Blob_Generic_4718 [126e];
    struct Blob_Generic_4781 [12ad];
    struct Blob_Generic_4802 [12c2];
    struct Blob_Generic_4879 [130f];
    struct Blob_Generic_4900 [1324];
    struct Blob_Generic_4966 [1366];
    struct Blob_Generic_4987 [137b];
    struct Blob_Generic_5067 [13cb];
    struct Blob_Generic_5088 [13e0];
    struct Blob_Generic_5109 [13f5];
    struct Blob_Generic_5130 [140a];
    struct Blob_Generic_5151 [141f];
    struct Blob_Generic_5172 [1434];
    struct Blob_Generic_5193 [1449];
    struct Blob_Generic_5232 [1470];
    struct Blob_Generic_5253 [1485];
    struct Blob_Generic_5306 [14ba];
    struct Blob_Generic_5327 [14cf];
    struct Blob_Generic_5362 [14f2];
    struct Blob_Generic_5383 [1507];
    struct Blob_Generic_5432 [1538];
    struct Blob_Generic_5453 [154d];
    struct Blob_Generic_5474 [1562];
    struct Blob_Generic_5518 [158e];
    struct Blob_Generic_5539 [15a3];
    struct Blob_Generic_5597 [15dd];
    struct Blob_Generic_5637 [1605];
    struct Blob_Generic_5658 [161a];
    struct Blob_Generic_5679 [162f];
    struct Blob_Generic_5733 [1665];
    struct Blob_Generic_5754 [167a];
    struct Blob_Generic_5775 [168f];
    struct Blob_Generic_5796 [16a4];
    struct Blob_Generic_5831 [16c7];
    struct Blob_Generic_5852 [16dc];
    struct Blob_Generic_5873 [16f1];
    struct Blob_Generic_5922 [1722];
    struct Blob_Generic_5943 [1737];
    struct Blob_Generic_5964 [174c];
    struct Blob_Generic_5985 [1761];
    struct Blob_Generic_6006 [1776];
    struct Blob_Generic_6027 [178b];
    struct Blob_Generic_6048 [17a0];
    struct Blob_Generic_6069 [17b5];
    struct Blob_Generic_6119 [17e7];
    struct Blob_Generic_6140 [17fc];
    struct Blob_Generic_6204 [183c];
    struct Blob_Generic_6243 [1863];
    struct Blob_Generic_6264 [1878];
    struct Blob_Generic_6285 [188d];
    struct Blob_Generic_6338 [18c2];
    struct Blob_Generic_6359 [18d7];
    struct Blob_Generic_6380 [18ec];
    struct Blob_Generic_6401 [1901];
    struct Blob_Generic_6444 [192c];
    struct Blob_Generic_6465 [1941];
    struct Blob_Generic_6522 [197a];
    struct Blob_Generic_6555 [199b];
    struct Blob_Generic_6576 [19b0];
    struct Blob_Generic_6597 [19c5];
};



