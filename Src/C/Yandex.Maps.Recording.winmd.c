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

typedef struct ValueType.conflict ValueType.conflict, *PValueType.conflict;

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

struct ValueType.conflict {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0xa
};

typedef struct ValueType ValueType, *PValueType;

struct ValueType {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x8
};

typedef struct Class Class, *PClass;

struct Class {
    enum TypeCode Class; // Class
    byte Type; // TypeDefOrRefOrSpecEncoded
};

typedef struct Blob_Generic_85 Blob_Generic_85, *PBlob_Generic_85;

struct Blob_Generic_85 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_142 Blob_Generic_142, *PBlob_Generic_142;

struct Blob_Generic_142 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_543 Blob_Generic_543, *PBlob_Generic_543;

struct Blob_Generic_543 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_149 Blob_Generic_149, *PBlob_Generic_149;

struct Blob_Generic_149 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_136 Blob_MethodRefSig_136, *PBlob_MethodRefSig_136;

typedef struct MethodRefSig_136 MethodRefSig_136, *PMethodRefSig_136;

typedef struct Type_3479 Type_3479, *PType_3479;

typedef struct Type_3480 Type_3480, *PType_3480;

struct Type_3479 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_3480 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct MethodRefSig_136 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_3479 RetType;
    struct Type_3480 Param0;
};

struct Blob_MethodRefSig_136 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_136 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_96 Blob_Generic_96, *PBlob_Generic_96;

struct Blob_Generic_96 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_CustomAttrib_161 Blob_CustomAttrib_161, *PBlob_CustomAttrib_161;

typedef struct CustomAttrib_161 CustomAttrib_161, *PCustomAttrib_161;

struct CustomAttrib_161 {
    word PROLOG; // Magic (0x0001)
    word NumNamed; // Number of NamedArgs to follow
};

struct Blob_CustomAttrib_161 {
    byte Size; // coded integer - blob size
    struct CustomAttrib_161 CustomAttrib; // A CustomAttrib blob stores values of fixed or named parameters supplied when instantiating a custom attribute
};

typedef struct Blob_PropertySig_75 Blob_PropertySig_75, *PBlob_PropertySig_75;

typedef struct PropertySig_75 PropertySig_75, *PPropertySig_75;

typedef struct Type_3418 Type_3418, *PType_3418;

struct Type_3418 {
    enum TypeCode ELEMENT_TYPE_STRING;
};

struct PropertySig_75 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_3418 RetType; // Return type
};

struct Blob_PropertySig_75 {
    byte Size; // coded integer - blob size
    struct PropertySig_75 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_373 Blob_Generic_373, *PBlob_Generic_373;

struct Blob_Generic_373 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_91 Blob_Generic_91, *PBlob_Generic_91;

struct Blob_Generic_91 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_14 Blob_Generic_14, *PBlob_Generic_14;

struct Blob_Generic_14 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_258 Blob_Generic_258, *PBlob_Generic_258;

struct Blob_Generic_258 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_136 Blob_Generic_136, *PBlob_Generic_136;

struct Blob_Generic_136 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_499 Blob_Generic_499, *PBlob_Generic_499;

struct Blob_Generic_499 {
    byte Size; // coded integer - blob size
    byte Generic[43]; // Undefined blob contents
};

typedef struct Blob_Generic_10 Blob_Generic_10, *PBlob_Generic_10;

struct Blob_Generic_10 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_415 Blob_Generic_415, *PBlob_Generic_415;

struct Blob_Generic_415 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_18 Blob_Generic_18, *PBlob_Generic_18;

struct Blob_Generic_18 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_121 Blob_MethodRefSig_121, *PBlob_MethodRefSig_121;

typedef struct MethodRefSig_121 MethodRefSig_121, *PMethodRefSig_121;

typedef struct Type_3464 Type_3464, *PType_3464;

typedef struct Type_3465 Type_3465, *PType_3465;

typedef struct Type_3466 Type_3466, *PType_3466;

typedef struct Type_3467 Type_3467, *PType_3467;

typedef struct Type_3468 Type_3468, *PType_3468;

typedef struct Type_3469 Type_3469, *PType_3469;

typedef struct Type_3470 Type_3470, *PType_3470;

typedef struct Type_3471 Type_3471, *PType_3471;

typedef struct Type_3472 Type_3472, *PType_3472;

typedef struct Type_3473 Type_3473, *PType_3473;

typedef struct Type_3474 Type_3474, *PType_3474;

typedef struct Type_3475 Type_3475, *PType_3475;

struct Type_3468 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_3469 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_3471 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_3472 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_3473 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_3474 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_3464 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_3475 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct Type_3465 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct Type_3466 {
    enum TypeCode ELEMENT_TYPE_U2;
};

struct Type_3467 {
    enum TypeCode ELEMENT_TYPE_U2;
};

struct Type_3470 {
    enum TypeCode ELEMENT_TYPE_U1;
};

struct MethodRefSig_121 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_3464 RetType;
    struct Type_3465 Param0;
    struct Type_3466 Param1;
    struct Type_3467 Param2;
    struct Type_3468 Param3;
    struct Type_3469 Param4;
    struct Type_3470 Param5;
    struct Type_3471 Param6;
    struct Type_3472 Param7;
    struct Type_3473 Param8;
    struct Type_3474 Param9;
    struct Type_3475 Param10;
};

struct Blob_MethodRefSig_121 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_121 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_121 Blob_Generic_121, *PBlob_Generic_121;

struct Blob_Generic_121 {
    byte Size; // coded integer - blob size
    byte Generic[14]; // Undefined blob contents
};

typedef struct Blob_Generic_64 Blob_Generic_64, *PBlob_Generic_64;

struct Blob_Generic_64 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_116 Blob_MethodRefSig_116, *PBlob_MethodRefSig_116;

typedef struct MethodRefSig_116 MethodRefSig_116, *PMethodRefSig_116;

typedef struct Type_3459 Type_3459, *PType_3459;

typedef struct Type_3460 Type_3460, *PType_3460;

struct Type_3459 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_3460 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct MethodRefSig_116 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_3459 RetType;
    struct Type_3460 Param0;
};

struct Blob_MethodRefSig_116 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_116 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodRefSig_45 Blob_MethodRefSig_45, *PBlob_MethodRefSig_45;

typedef struct MethodRefSig_45 MethodRefSig_45, *PMethodRefSig_45;

typedef struct Type_3388 Type_3388, *PType_3388;

typedef struct Type_3389 Type_3389, *PType_3389;

struct Type_3388 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_3389 {
    enum TypeCode ELEMENT_TYPE_STRING;
};

struct MethodRefSig_45 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_3388 RetType;
    struct Type_3389 Param0;
};

struct Blob_MethodRefSig_45 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_45 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_111 Blob_Generic_111, *PBlob_Generic_111;

struct Blob_Generic_111 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_352 Blob_Generic_352, *PBlob_Generic_352;

struct Blob_Generic_352 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_478 Blob_Generic_478, *PBlob_Generic_478;

struct Blob_Generic_478 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_79 Blob_Generic_79, *PBlob_Generic_79;

struct Blob_Generic_79 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_75 Blob_Generic_75, *PBlob_Generic_75;

struct Blob_Generic_75 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_116 Blob_Generic_116, *PBlob_Generic_116;

struct Blob_Generic_116 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_237 Blob_Generic_237, *PBlob_Generic_237;

struct Blob_Generic_237 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_1 Blob_Generic_1, *PBlob_Generic_1;

struct Blob_Generic_1 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_PropertySig_111 Blob_PropertySig_111, *PBlob_PropertySig_111;

typedef struct PropertySig_111 PropertySig_111, *PPropertySig_111;

typedef struct Type_3454 Type_3454, *PType_3454;

struct Type_3454 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_111 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_3454 RetType; // Return type
};

struct Blob_PropertySig_111 {
    byte Size; // coded integer - blob size
    struct PropertySig_111 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_101 Blob_Generic_101, *PBlob_Generic_101;

struct Blob_Generic_101 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_585 Blob_Generic_585, *PBlob_Generic_585;

struct Blob_Generic_585 {
    byte Size; // coded integer - blob size
    byte Generic[57]; // Undefined blob contents
};

typedef struct Blob_Generic_45 Blob_Generic_45, *PBlob_Generic_45;

struct Blob_Generic_45 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_106 Blob_Generic_106, *PBlob_Generic_106;

struct Blob_Generic_106 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_50 Blob_Generic_50, *PBlob_Generic_50;

struct Blob_Generic_50 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_PropertySig_35 Blob_PropertySig_35, *PBlob_PropertySig_35;

typedef struct PropertySig_35 PropertySig_35, *PPropertySig_35;

typedef struct Type_3378 Type_3378, *PType_3378;

struct Type_3378 {
    enum TypeCode ELEMENT_TYPE_BOOLEAN;
};

struct PropertySig_35 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_3378 RetType; // Return type
};

struct Blob_PropertySig_35 {
    byte Size; // coded integer - blob size
    struct PropertySig_35 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_PropertySig_101 Blob_PropertySig_101, *PBlob_PropertySig_101;

typedef struct PropertySig_101 PropertySig_101, *PPropertySig_101;

typedef struct Type_3444 Type_3444, *PType_3444;

struct Type_3444 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct PropertySig_101 {
    byte PROPERTY; // Magic (0x08) optionalled OR'd with HASTHIS (0x20)
    byte Count; // Number of params to follow RetType
    struct Type_3444 RetType; // Return type
};

struct Blob_PropertySig_101 {
    byte Size; // coded integer - blob size
    struct PropertySig_101 PropertySig; // Contains signature for properties. Gives params for getters/setters.
};

typedef struct Blob_Generic_297 Blob_Generic_297, *PBlob_Generic_297;

struct Blob_Generic_297 {
    byte Size; // coded integer - blob size
    byte Generic[54]; // Undefined blob contents
};

typedef struct Blob_Generic_56 Blob_Generic_56, *PBlob_Generic_56;

struct Blob_Generic_56 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_216 Blob_Generic_216, *PBlob_Generic_216;

struct Blob_Generic_216 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_457 Blob_Generic_457, *PBlob_Generic_457;

struct Blob_Generic_457 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_18 Blob_MethodRefSig_18, *PBlob_MethodRefSig_18;

typedef struct MethodRefSig_18 MethodRefSig_18, *PMethodRefSig_18;

typedef struct Type_3361 Type_3361, *PType_3361;

struct Type_3361 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_18 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_3361 RetType;
};

struct Blob_MethodRefSig_18 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_18 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_161 Blob_Generic_161, *PBlob_Generic_161;

struct Blob_Generic_161 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_166 Blob_Generic_166, *PBlob_Generic_166;

struct Blob_Generic_166 {
    byte Size; // coded integer - blob size
    byte Generic[40]; // Undefined blob contents
};

typedef struct Blob_Generic_564 Blob_Generic_564, *PBlob_Generic_564;

struct Blob_Generic_564 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_288 Blob_Generic_288, *PBlob_Generic_288;

struct Blob_Generic_288 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_207 Blob_Generic_207, *PBlob_Generic_207;

struct Blob_Generic_207 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_22 Blob_Generic_22, *PBlob_Generic_22;

struct Blob_Generic_22 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_155 Blob_MethodRefSig_155, *PBlob_MethodRefSig_155;

typedef struct MethodRefSig_155 MethodRefSig_155, *PMethodRefSig_155;

typedef struct Type_3498 Type_3498, *PType_3498;

typedef struct Type_3499 Type_3499, *PType_3499;

struct Type_3498 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_3499 {
    struct ValueType.conflict ELEMENT_TYPE_VALUETYPE;
};

struct MethodRefSig_155 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_3498 RetType;
    struct Type_3499 Param0;
};

struct Blob_MethodRefSig_155 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_155 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_155 Blob_Generic_155, *PBlob_Generic_155;

struct Blob_Generic_155 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_394 Blob_Generic_394, *PBlob_Generic_394;

struct Blob_Generic_394 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_35 Blob_Generic_35, *PBlob_Generic_35;

struct Blob_Generic_35 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_279 Blob_Generic_279, *PBlob_Generic_279;

struct Blob_Generic_279 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_31 Blob_Generic_31, *PBlob_Generic_31;

struct Blob_Generic_31 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_436 Blob_Generic_436, *PBlob_Generic_436;

struct Blob_Generic_436 {
    byte Size; // coded integer - blob size
    byte Generic[20]; // Undefined blob contents
};

typedef struct Blob_Generic_39 Blob_Generic_39, *PBlob_Generic_39;

struct Blob_Generic_39 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_142 Blob_MethodRefSig_142, *PBlob_MethodRefSig_142;

typedef struct MethodRefSig_142 MethodRefSig_142, *PMethodRefSig_142;

typedef struct Type_3485 Type_3485, *PType_3485;

typedef struct Type_3486 Type_3486, *PType_3486;

typedef struct Type_3488 Type_3488, *PType_3488;

struct Type_3488 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct Type_3485 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_3486 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct MethodRefSig_142 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_3485 RetType;
    struct Type_3486 Param0;
    struct Type_3488 Param1;
};

struct Blob_MethodRefSig_142 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_142 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodRefSig_149 Blob_MethodRefSig_149, *PBlob_MethodRefSig_149;

typedef struct MethodRefSig_149 MethodRefSig_149, *PMethodRefSig_149;

typedef struct Type_3492 Type_3492, *PType_3492;

typedef struct Type_3493 Type_3493, *PType_3493;

struct Type_3493 {
    struct ValueType ELEMENT_TYPE_VALUETYPE;
};

struct Type_3492 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_149 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_3492 RetType;
    struct Type_3493 Param0;
};

struct Blob_MethodRefSig_149 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_149 MethodRefSig; // Type info for imported method return and params
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

typedef struct TypeRef Row TypeRef Row, *PTypeRef Row;

struct TypeRef Row {
    word ResolutionScope;
    word TypeName;
    word TypeNamespace;
};

typedef struct CustomAttribute Row CustomAttribute Row, *PCustomAttribute Row;

struct CustomAttribute Row {
    word Parent;
    word Type;
    word Value;
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

typedef struct InterfaceImpl Row InterfaceImpl Row, *PInterfaceImpl Row;

struct InterfaceImpl Row {
    word Class; // index into TypeDef table
    word Interface; // index into TypeDef/TypeRef/TypeSpec - TypeDefOrRef coded
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
    char [2c][22];
    char [42][24];
    char [5a][14];
    char [68][16];
    char [78][15];
    char [87][14];
    char [95][14];
    char [a3][7];
    char [aa][12];
    char [b6][10];
    char [c0][37];
    char [e5][27];
    char [100][17];
    char [111][9];
    char [11a][8];
    char [122][15];
    char [131][9];
    char [13a][17];
    char [14b][28];
    char [167][14];
    char [175][21];
    char [18a][5];
    char [18f][7];
    char [196][16];
    char [1a6][21];
    char [1bb][19];
    char [1ce][15];
    char [1dd][28];
    char [1f9][15];
    char [208][7];
    char [20f][17];
    char [220][18];
    char [232][23];
    char [249][14];
    char [257][31];
    char [276][18];
    char [288][6];
    char [28e][8];
    char [296][20];
    char [2aa][4];
    char [2ae][14];
    char [2bc][6];
    char [2c2][12];
    char [2ce][13];
    char [2db][12];
    char [2e7][8];
    char [2ef][6];
    char [2f5][10];
    char [2ff][6];
    char [305][9];
    char [30e][9];
    char [317][7];
    char [31e][8];
    char [326][6];
    char [32c][6];
    char [332][15];
    char [341][14];
    char [34f][7];
    char [356][7];
    char [35d][8];
    char [365][16];
    char [375][16];
    char [385][21];
    char [39a][12];
    char [3a6][8];
    char [3ae][17];
    char [3bf][12];
    char [3cb][11];
    char [3d6][5];
    char [3db][9];
    char [3e4][11];
    char [3ef][8];
    char [3f7][12];
    char [403][8];
    char [40b][13];
    char [418][9];
    char [421][28];
    char [43d][1];
    char [43e][1];
    char [43f][1];
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
    dword Rows[13]; // # of rows for each corresponding present table
    struct Module Row Module; // CLI Metadata Table: Module
    struct TypeRef Row TypeRef[18]; // CLI Metadata Table: TypeRef
    struct TypeDef Row TypeDef[14]; // CLI Metadata Table: TypeDef
    struct MethodDef Row MethodDef[27]; // CLI Metadata Table: MethodDef
    struct ParamRow Param[28]; // CLI Metadata Table: Param
    struct InterfaceImpl Row InterfaceImpl[3]; // CLI Metadata Table: InterfaceImpl
    struct MemberRef Row MemberRef[10]; // CLI Metadata Table: MemberRef
    struct CustomAttribute Row CustomAttribute[50]; // CLI Metadata Table: CustomAttribute
    struct PropertyMap Row PropertyMap[5]; // CLI Metadata Table: PropertyMap
    struct Property Row Property[8]; // CLI Metadata Table: Property
    struct MethodSemantics Row MethodSemantics[8]; // CLI Metadata Table: MethodSemantics
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
    struct Blob_Generic_31 [1f];
    struct Blob_PropertySig_35 PropertySig_35; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_39 [27];
    struct Blob_MethodRefSig_45 MethodRefSig_45; // Type info for imported method return and params
    struct Blob_Generic_50 [32];
    struct Blob_Generic_56 [38];
    struct Blob_Generic_64 [40];
    struct Blob_PropertySig_75 PropertySig_75; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_79 [4f];
    struct Blob_Generic_85 [55];
    struct Blob_Generic_91 [5b];
    struct Blob_Generic_96 [60];
    struct Blob_PropertySig_101 PropertySig_101; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_Generic_106 [6a];
    struct Blob_PropertySig_111 PropertySig_111; // Contains signature for properties. Gives params for getters/setters.
    struct Blob_MethodRefSig_116 MethodRefSig_116; // Type info for imported method return and params
    struct Blob_MethodRefSig_121 MethodRefSig_121; // Type info for imported method return and params
    struct Blob_MethodRefSig_136 MethodRefSig_136; // Type info for imported method return and params
    struct Blob_MethodRefSig_142 MethodRefSig_142; // Type info for imported method return and params
    struct Blob_MethodRefSig_149 MethodRefSig_149; // Type info for imported method return and params
    struct Blob_MethodRefSig_155 MethodRefSig_155; // Type info for imported method return and params
    struct Blob_CustomAttrib_161 CustomAttrib_161; // A CustomAttrib blob stores values of fixed or named parameters supplied when instantiating a custom attribute
    struct Blob_Generic_166 [a6];
    struct Blob_Generic_207 [cf];
    struct Blob_Generic_216 [d8];
    struct Blob_Generic_237 [ed];
    struct Blob_Generic_258 [102];
    struct Blob_Generic_279 [117];
    struct Blob_Generic_288 [120];
    struct Blob_Generic_297 [129];
    struct Blob_Generic_352 [160];
    struct Blob_Generic_373 [175];
    struct Blob_Generic_394 [18a];
    struct Blob_Generic_415 [19f];
    struct Blob_Generic_436 [1b4];
    struct Blob_Generic_457 [1c9];
    struct Blob_Generic_478 [1de];
    struct Blob_Generic_499 [1f3];
    struct Blob_Generic_543 [21f];
    struct Blob_Generic_564 [234];
    struct Blob_Generic_585 [249];
};



