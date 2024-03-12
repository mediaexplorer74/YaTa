typedef unsigned char   undefined;

typedef unsigned long long    GUID;
typedef pointer32 ImageBaseOffset32;

typedef unsigned char    byte;
typedef unsigned int    dword;
typedef unsigned long long    qword;
typedef unsigned short    word;
typedef union IMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryUnion IMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryUnion, *PIMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryUnion;

typedef struct IMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryStruct IMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryStruct, *PIMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryStruct;

struct IMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryStruct {
    dword OffsetToDirectory;
    dword DataIsDirectory;
};

union IMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryUnion {
    dword OffsetToData;
    struct IMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryStruct IMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryStruct;
};

typedef unsigned short    wchar16;
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

typedef struct Var Var, *PVar;

struct Var {
    word wLength;
    word wValueLength;
    word wType;
};

typedef struct IMAGE_RESOURCE_DIRECTORY_ENTRY_NameStruct IMAGE_RESOURCE_DIRECTORY_ENTRY_NameStruct, *PIMAGE_RESOURCE_DIRECTORY_ENTRY_NameStruct;

struct IMAGE_RESOURCE_DIRECTORY_ENTRY_NameStruct {
    dword NameOffset;
    dword NameIsString;
};

typedef struct IMAGE_DEBUG_DIRECTORY IMAGE_DEBUG_DIRECTORY, *PIMAGE_DEBUG_DIRECTORY;

struct IMAGE_DEBUG_DIRECTORY {
    dword Characteristics;
    dword TimeDateStamp;
    word MajorVersion;
    word MinorVersion;
    dword Type;
    dword SizeOfData;
    dword AddressOfRawData;
    dword PointerToRawData;
};

typedef struct IMAGE_FILE_HEADER IMAGE_FILE_HEADER, *PIMAGE_FILE_HEADER;

struct IMAGE_FILE_HEADER {
    word Machine; // 452
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

typedef struct StringFileInfo StringFileInfo, *PStringFileInfo;

struct StringFileInfo {
    word wLength;
    word wValueLength;
    word wType;
};

typedef union IMAGE_RESOURCE_DIRECTORY_ENTRY IMAGE_RESOURCE_DIRECTORY_ENTRY, *PIMAGE_RESOURCE_DIRECTORY_ENTRY;

typedef union IMAGE_RESOURCE_DIRECTORY_ENTRY_NameUnion IMAGE_RESOURCE_DIRECTORY_ENTRY_NameUnion, *PIMAGE_RESOURCE_DIRECTORY_ENTRY_NameUnion;

union IMAGE_RESOURCE_DIRECTORY_ENTRY_NameUnion {
    struct IMAGE_RESOURCE_DIRECTORY_ENTRY_NameStruct IMAGE_RESOURCE_DIRECTORY_ENTRY_NameStruct;
    dword Name;
    word Id;
};

union IMAGE_RESOURCE_DIRECTORY_ENTRY {
    union IMAGE_RESOURCE_DIRECTORY_ENTRY_NameUnion NameUnion;
    union IMAGE_RESOURCE_DIRECTORY_ENTRY_DirectoryUnion DirectoryUnion;
};

typedef struct StringTable StringTable, *PStringTable;

struct StringTable {
    word wLength;
    word wValueLength;
    word wType;
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

typedef struct VS_VERSION_INFO VS_VERSION_INFO, *PVS_VERSION_INFO;

struct VS_VERSION_INFO {
    word StructLength;
    word ValueLength;
    word StructType;
    wchar16 Info[16];
    byte Padding[2];
    dword Signature;
    word StructVersion[2];
    word FileVersion[4];
    word ProductVersion[4];
    dword FileFlagsMask[2];
    dword FileFlags;
    dword FileOS;
    dword FileType;
    dword FileSubtype;
    dword FileTimestamp;
};

typedef struct IMAGE_RESOURCE_DATA_ENTRY IMAGE_RESOURCE_DATA_ENTRY, *PIMAGE_RESOURCE_DATA_ENTRY;

struct IMAGE_RESOURCE_DATA_ENTRY {
    dword OffsetToData;
    dword Size;
    dword CodePage;
    dword Reserved;
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

typedef struct VarFileInfo VarFileInfo, *PVarFileInfo;

struct VarFileInfo {
    word wLength;
    word wValueLength;
    word wType;
};

typedef struct IMAGE_RESOURCE_DIRECTORY IMAGE_RESOURCE_DIRECTORY, *PIMAGE_RESOURCE_DIRECTORY;

struct IMAGE_RESOURCE_DIRECTORY {
    dword Characteristics;
    dword TimeDateStamp;
    word MajorVersion;
    word MinorVersion;
    word NumberOfNamedEntries;
    word NumberOfIdEntries;
};

typedef struct StringInfo StringInfo, *PStringInfo;

struct StringInfo {
    word wLength;
    word wValueLength;
    word wType;
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
    char Version[36];
    word Flags; // should be 0
    word StreamsCount; // number of stream headers to follow
    struct CLI_Stream_Header_#~ #~;
    struct CLI_Stream_Header_#Strings #Strings;
    struct CLI_Stream_Header_#US #US;
    struct CLI_Stream_Header_#GUID #GUID;
    struct CLI_Stream_Header_#Blob #Blob;
};

typedef struct GenericInstType_5354 GenericInstType_5354, *PGenericInstType_5354;

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

typedef struct Class Class, *PClass;

struct Class {
    enum TypeCode Class; // Class
    byte Type; // TypeDefOrRefOrSpecEncoded
};

struct GenericInstType_5354 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct ELEMENT_TYPE_VAR_5404 ELEMENT_TYPE_VAR_5404, *PELEMENT_TYPE_VAR_5404;

struct ELEMENT_TYPE_VAR_5404 {
    enum TypeCode ELEMENT_TYPE_VAR;
    byte number;
};

typedef struct ELEMENT_TYPE_MVAR_5287 ELEMENT_TYPE_MVAR_5287, *PELEMENT_TYPE_MVAR_5287;

struct ELEMENT_TYPE_MVAR_5287 {
    enum TypeCode ELEMENT_TYPE_MVAR;
    byte number;
};

typedef struct ELEMENT_TYPE_VAR_5401 ELEMENT_TYPE_VAR_5401, *PELEMENT_TYPE_VAR_5401;

struct ELEMENT_TYPE_VAR_5401 {
    enum TypeCode ELEMENT_TYPE_VAR;
    byte number;
};

typedef struct GenericInstType_5367 GenericInstType_5367, *PGenericInstType_5367;

struct GenericInstType_5367 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct ELEMENT_TYPE_MVAR_5290 ELEMENT_TYPE_MVAR_5290, *PELEMENT_TYPE_MVAR_5290;

struct ELEMENT_TYPE_MVAR_5290 {
    enum TypeCode ELEMENT_TYPE_MVAR;
    byte number;
};

typedef struct GenericInstType_5532 GenericInstType_5532, *PGenericInstType_5532;

struct GenericInstType_5532 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct GenericInstType_5376 GenericInstType_5376, *PGenericInstType_5376;

struct GenericInstType_5376 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct ELEMENT_TYPE_MVAR_5340 ELEMENT_TYPE_MVAR_5340, *PELEMENT_TYPE_MVAR_5340;

struct ELEMENT_TYPE_MVAR_5340 {
    enum TypeCode ELEMENT_TYPE_MVAR;
    byte number;
};

typedef struct ELEMENT_TYPE_VAR_5389 ELEMENT_TYPE_VAR_5389, *PELEMENT_TYPE_VAR_5389;

struct ELEMENT_TYPE_VAR_5389 {
    enum TypeCode ELEMENT_TYPE_VAR;
    byte number;
};

typedef struct GenericInstType_5732 GenericInstType_5732, *PGenericInstType_5732;

struct GenericInstType_5732 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct ValueType.conflict ValueType.conflict, *PValueType.conflict;

struct ValueType.conflict {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0xe
};

typedef struct ValueType.conflict7 ValueType.conflict7, *PValueType.conflict7;

struct ValueType.conflict7 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeDef: Row 0x4
};

typedef struct ValueType.conflict8 ValueType.conflict8, *PValueType.conflict8;

struct ValueType.conflict8 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeDef: Row 0x5
};

typedef struct ValueType.conflict5 ValueType.conflict5, *PValueType.conflict5;

struct ValueType.conflict5 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeRef: Row 0x30
};

typedef struct ValueType.conflict6 ValueType.conflict6, *PValueType.conflict6;

struct ValueType.conflict6 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeDef: Row 0x3
};

typedef struct ELEMENT_TYPE_MVAR_5337 ELEMENT_TYPE_MVAR_5337, *PELEMENT_TYPE_MVAR_5337;

struct ELEMENT_TYPE_MVAR_5337 {
    enum TypeCode ELEMENT_TYPE_MVAR;
    byte number;
};

typedef struct GenericInstType_5543 GenericInstType_5543, *PGenericInstType_5543;

struct GenericInstType_5543 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct Class Type; // Generic Type
};

typedef struct ValueType.conflict3 ValueType.conflict3, *PValueType.conflict3;

struct ValueType.conflict3 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeRef: Row 0x22
};

typedef struct ValueType ValueType, *PValueType;

struct ValueType {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x8
};

typedef struct GenericInstType_5385 GenericInstType_5385, *PGenericInstType_5385;

struct GenericInstType_5385 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ELEMENT_TYPE_VAR_5389 Type; // Generic Type
};

typedef struct ValueType.conflict4 ValueType.conflict4, *PValueType.conflict4;

struct ValueType.conflict4 {
    enum TypeCode ValueType; // ValueType
    word TypeDefOrRefEncoded; // TypeRef: Row 0x2e
};

typedef struct ValueType.conflict1 ValueType.conflict1, *PValueType.conflict1;

struct ValueType.conflict1 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0xa
};

typedef struct ValueType.conflict2 ValueType.conflict2, *PValueType.conflict2;

struct ValueType.conflict2 {
    enum TypeCode ValueType; // ValueType
    byte TypeDefOrRefEncoded; // TypeRef: Row 0x1b
};

typedef struct ELEMENT_TYPE_VAR_5396 ELEMENT_TYPE_VAR_5396, *PELEMENT_TYPE_VAR_5396;

struct ELEMENT_TYPE_VAR_5396 {
    enum TypeCode ELEMENT_TYPE_VAR;
    byte number;
};

typedef struct GenericInstType_5392 GenericInstType_5392, *PGenericInstType_5392;

struct GenericInstType_5392 {
    enum TypeCode GenericInst; // GenericInst
    enum TypeCode ClassOrValueType; // Class or ValueType
    byte Type; // TypeDefOrRefOrSpecEncoded
    byte GenArgCount; // Number of generics to follow
    struct ELEMENT_TYPE_VAR_5396 Type; // Generic Type
};

typedef struct Blob_MethodRefSig_73 Blob_MethodRefSig_73, *PBlob_MethodRefSig_73;

typedef struct MethodRefSig_73 MethodRefSig_73, *PMethodRefSig_73;

typedef struct Type_5344 Type_5344, *PType_5344;

typedef struct Type_5345 Type_5345, *PType_5345;

struct Type_5344 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_5345 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct MethodRefSig_73 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5344 RetType;
    struct Type_5345 Param0;
};

struct Blob_MethodRefSig_73 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_73 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_300 Blob_Generic_300, *PBlob_Generic_300;

struct Blob_Generic_300 {
    word Size; // coded integer - blob size
    byte Generic[128]; // Undefined blob contents
};

typedef struct Blob_Generic_542 Blob_Generic_542, *PBlob_Generic_542;

struct Blob_Generic_542 {
    byte Size; // coded integer - blob size
    byte Generic[23]; // Undefined blob contents
};

typedef struct Blob_MethodSpecSig_250 Blob_MethodSpecSig_250, *PBlob_MethodSpecSig_250;

typedef struct MethodSpecSig_250 MethodSpecSig_250, *PMethodSpecSig_250;

struct MethodSpecSig_250 {
    byte GENRICINST; // Magic (0x0a)
    byte GenArgCount; // Number of types to follow
    struct ValueType.conflict Type0;
    struct ValueType.conflict7 Type1;
};

struct Blob_MethodSpecSig_250 {
    byte Size; // coded integer - blob size
    struct MethodSpecSig_250 MethodSpecSig; // Specifies a generic method with GenArgCount types
};

typedef struct Blob_Generic_788 Blob_Generic_788, *PBlob_Generic_788;

struct Blob_Generic_788 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_62 Blob_MethodRefSig_62, *PBlob_MethodRefSig_62;

typedef struct MethodRefSig_62 MethodRefSig_62, *PMethodRefSig_62;

typedef struct Type_5334 Type_5334, *PType_5334;

typedef struct Type_5335 Type_5335, *PType_5335;

typedef struct Type_5338 Type_5338, *PType_5338;

struct Type_5338 {
    enum TypeCode ELEMENT_TYPE_BYREF; // By Reference
    struct ELEMENT_TYPE_MVAR_5340 ELEMENT_TYPE_MVAR;
};

struct Type_5335 {
    enum TypeCode ELEMENT_TYPE_BYREF; // By Reference
    struct ELEMENT_TYPE_MVAR_5337 ELEMENT_TYPE_MVAR;
};

struct Type_5334 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_62 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte GenParamCount; // Number of generic paramameters for the method
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5334 RetType;
    struct Type_5335 Param0;
    struct Type_5338 Param1;
};

struct Blob_MethodRefSig_62 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_62 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodSpecSig_243 Blob_MethodSpecSig_243, *PBlob_MethodSpecSig_243;

typedef struct MethodSpecSig_243 MethodSpecSig_243, *PMethodSpecSig_243;

struct MethodSpecSig_243 {
    byte GENRICINST; // Magic (0x0a)
    byte GenArgCount; // Number of types to follow
    struct ValueType.conflict Type0;
    struct ValueType.conflict6 Type1;
};

struct Blob_MethodSpecSig_243 {
    byte Size; // coded integer - blob size
    struct MethodSpecSig_243 MethodSpecSig; // Specifies a generic method with GenArgCount types
};

typedef struct Blob_Generic_536 Blob_Generic_536, *PBlob_Generic_536;

struct Blob_Generic_536 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_12 Blob_Generic_12, *PBlob_Generic_12;

struct Blob_Generic_12 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_656 Blob_Generic_656, *PBlob_Generic_656;

struct Blob_Generic_656 {
    byte Size; // coded integer - blob size
    byte Generic[47]; // Undefined blob contents
};

typedef struct Blob_LocalVarSig_211 Blob_LocalVarSig_211, *PBlob_LocalVarSig_211;

typedef struct LocalVarSig_211 LocalVarSig_211, *PLocalVarSig_211;

typedef struct Type_5482 Type_5482, *PType_5482;

typedef struct Type_5484 Type_5484, *PType_5484;

struct Type_5484 {
    struct ValueType.conflict1 ELEMENT_TYPE_VALUETYPE;
};

struct Type_5482 {
    struct ValueType.conflict7 ELEMENT_TYPE_VALUETYPE;
};

struct LocalVarSig_211 {
    byte LOCAL_SIG; // Magic (0x07)
    byte Count; // Number of types to follow
    struct Type_5482 Type;
    struct Type_5484 Type;
};

struct Blob_LocalVarSig_211 {
    byte Size; // coded integer - blob size
    struct LocalVarSig_211 LocalVarSig; // Contains signature for function locals
};

typedef struct Blob_FieldSig_137 Blob_FieldSig_137, *PBlob_FieldSig_137;

typedef struct FieldSig_137 FieldSig_137, *PFieldSig_137;

typedef struct Type_5407 Type_5407, *PType_5407;

struct Type_5407 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct FieldSig_137 {
    byte FIELD; // Magic (0x06)
    struct Type_5407 ELEMENT_TYPE_CLASS;
};

struct Blob_FieldSig_137 {
    byte Size; // coded integer - blob size
    struct FieldSig_137 FieldSig; // Type information for Field
};

typedef struct Blob_MethodRefSig_58 Blob_MethodRefSig_58, *PBlob_MethodRefSig_58;

typedef struct MethodRefSig_58 MethodRefSig_58, *PMethodRefSig_58;

typedef struct Type_5329 Type_5329, *PType_5329;

struct Type_5329 {
    enum TypeCode ELEMENT_TYPE_BOOLEAN;
};

struct MethodRefSig_58 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5329 RetType;
};

struct Blob_MethodRefSig_58 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_58 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodRefSig_53 Blob_MethodRefSig_53, *PBlob_MethodRefSig_53;

typedef struct MethodRefSig_53 MethodRefSig_53, *PMethodRefSig_53;

typedef struct Type_5324 Type_5324, *PType_5324;

struct Type_5324 {
    struct ValueType.conflict ELEMENT_TYPE_VALUETYPE;
};

struct MethodRefSig_53 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5324 RetType;
};

struct Blob_MethodRefSig_53 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_53 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodRefSig_194 Blob_MethodRefSig_194, *PBlob_MethodRefSig_194;

typedef struct MethodRefSig_194 MethodRefSig_194, *PMethodRefSig_194;

typedef struct Type_5465 Type_5465, *PType_5465;

typedef struct Type_5466 Type_5466, *PType_5466;

struct Type_5466 {
    enum TypeCode ELEMENT_TYPE_U4;
};

struct Type_5465 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_194 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5465 RetType;
    struct Type_5466 Param0;
};

struct Blob_MethodRefSig_194 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_194 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodSpecSig_230 Blob_MethodSpecSig_230, *PBlob_MethodSpecSig_230;

typedef struct MethodSpecSig_230 MethodSpecSig_230, *PMethodSpecSig_230;

struct MethodSpecSig_230 {
    byte GENRICINST; // Magic (0x0a)
    byte GenArgCount; // Number of types to follow
    struct ValueType.conflict8 Type0;
};

struct Blob_MethodSpecSig_230 {
    byte Size; // coded integer - blob size
    struct MethodSpecSig_230 MethodSpecSig; // Specifies a generic method with GenArgCount types
};

typedef struct Blob_MethodRefSig_47 Blob_MethodRefSig_47, *PBlob_MethodRefSig_47;

typedef struct MethodRefSig_47 MethodRefSig_47, *PMethodRefSig_47;

typedef struct Type_5318 Type_5318, *PType_5318;

typedef struct Type_5319 Type_5319, *PType_5319;

struct Type_5319 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct Type_5318 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_47 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5318 RetType;
    struct Type_5319 Param0;
};

struct Blob_MethodRefSig_47 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_47 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_FieldSig_461 Blob_FieldSig_461, *PBlob_FieldSig_461;

typedef struct FieldSig_461 FieldSig_461, *PFieldSig_461;

typedef struct Type_5731 Type_5731, *PType_5731;

struct Type_5731 {
    struct GenericInstType_5732 ELEMENT_TYPE_GENERICINST;
};

struct FieldSig_461 {
    byte FIELD; // Magic (0x06)
    struct Type_5731 ELEMENT_TYPE_GENERICINST;
};

struct Blob_FieldSig_461 {
    byte Size; // coded integer - blob size
    struct FieldSig_461 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_194 Blob_Generic_194, *PBlob_Generic_194;

struct Blob_Generic_194 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_43 Blob_MethodRefSig_43, *PBlob_MethodRefSig_43;

typedef struct MethodRefSig_43 MethodRefSig_43, *PMethodRefSig_43;

typedef struct Type_5314 Type_5314, *PType_5314;

struct Type_5314 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_43 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5314 RetType;
};

struct Blob_MethodRefSig_43 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_43 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_199 Blob_Generic_199, *PBlob_Generic_199;

struct Blob_Generic_199 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_180 Blob_MethodRefSig_180, *PBlob_MethodRefSig_180;

typedef struct MethodRefSig_180 MethodRefSig_180, *PMethodRefSig_180;

typedef struct Type_5451 Type_5451, *PType_5451;

typedef struct Type_5452 Type_5452, *PType_5452;

struct Type_5451 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_5452 {
    struct ValueType.conflict4 ELEMENT_TYPE_VALUETYPE;
};

struct MethodRefSig_180 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5451 RetType;
    struct Type_5452 Param0;
};

struct Blob_MethodRefSig_180 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_180 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_518 Blob_Generic_518, *PBlob_Generic_518;

struct Blob_Generic_518 {
    byte Size; // coded integer - blob size
    byte Generic[17]; // Undefined blob contents
};

typedef struct Blob_TypeSpec_20 Blob_TypeSpec_20, *PBlob_TypeSpec_20;

struct Blob_TypeSpec_20 {
    byte Size; // coded integer - blob size
    struct ELEMENT_TYPE_MVAR_5290 TypeSpec; // Describes a type.
};

typedef struct Blob_MethodRefSig_187 Blob_MethodRefSig_187, *PBlob_MethodRefSig_187;

typedef struct MethodRefSig_187 MethodRefSig_187, *PMethodRefSig_187;

typedef struct Type_5458 Type_5458, *PType_5458;

typedef struct Type_5459 Type_5459, *PType_5459;

struct Type_5459 {
    struct ValueType.conflict5 ELEMENT_TYPE_VALUETYPE;
};

struct Type_5458 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_187 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5458 RetType;
    struct Type_5459 Param0;
};

struct Blob_MethodRefSig_187 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_187 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_7 Blob_Generic_7, *PBlob_Generic_7;

struct Blob_Generic_7 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_37 Blob_MethodRefSig_37, *PBlob_MethodRefSig_37;

typedef struct MethodRefSig_37 MethodRefSig_37, *PMethodRefSig_37;

typedef struct Type_5308 Type_5308, *PType_5308;

typedef struct Type_5309 Type_5309, *PType_5309;

struct Type_5308 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_5309 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct MethodRefSig_37 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5308 RetType;
    struct Type_5309 Param0;
};

struct Blob_MethodRefSig_37 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_37 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_1 Blob_Generic_1, *PBlob_Generic_1;

struct Blob_Generic_1 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_MethodSpecSig_218 Blob_MethodSpecSig_218, *PBlob_MethodSpecSig_218;

typedef struct MethodSpecSig_218 MethodSpecSig_218, *PMethodSpecSig_218;

struct MethodSpecSig_218 {
    byte GENRICINST; // Magic (0x0a)
    byte GenArgCount; // Number of types to follow
    struct ValueType.conflict7 Type0;
};

struct Blob_MethodSpecSig_218 {
    byte Size; // coded integer - blob size
    struct MethodSpecSig_218 MethodSpecSig; // Specifies a generic method with GenArgCount types
};

typedef struct Blob_MethodRefSig_33 Blob_MethodRefSig_33, *PBlob_MethodRefSig_33;

typedef struct MethodRefSig_33 MethodRefSig_33, *PMethodRefSig_33;

typedef struct Type_5304 Type_5304, *PType_5304;

struct Type_5304 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_33 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5304 RetType;
};

struct Blob_MethodRefSig_33 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_33 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_FieldSig_449 Blob_FieldSig_449, *PBlob_FieldSig_449;

typedef struct FieldSig_449 FieldSig_449, *PFieldSig_449;

typedef struct Type_5719 Type_5719, *PType_5719;

struct Type_5719 {
    struct ValueType.conflict ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_449 {
    byte FIELD; // Magic (0x06)
    struct Type_5719 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_449 {
    byte Size; // coded integer - blob size
    struct FieldSig_449 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_461 Blob_Generic_461, *PBlob_Generic_461;

struct Blob_Generic_461 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_47 Blob_Generic_47, *PBlob_Generic_47;

struct Blob_Generic_47 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_223 Blob_Generic_223, *PBlob_Generic_223;

struct Blob_Generic_223 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_170 Blob_MethodRefSig_170, *PBlob_MethodRefSig_170;

typedef struct MethodRefSig_170 MethodRefSig_170, *PMethodRefSig_170;

typedef struct Type_5441 Type_5441, *PType_5441;

typedef struct Type_5442 Type_5442, *PType_5442;

struct Type_5442 {
    enum TypeCode ELEMENT_TYPE_STRING;
};

struct Type_5441 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_170 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5441 RetType;
    struct Type_5442 Param0;
};

struct Blob_MethodRefSig_170 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_170 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_43 Blob_Generic_43, *PBlob_Generic_43;

struct Blob_Generic_43 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_106 Blob_Generic_106, *PBlob_Generic_106;

struct Blob_Generic_106 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_469 Blob_Generic_469, *PBlob_Generic_469;

struct Blob_Generic_469 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_175 Blob_MethodRefSig_175, *PBlob_MethodRefSig_175;

typedef struct MethodRefSig_175 MethodRefSig_175, *PMethodRefSig_175;

typedef struct Type_5446 Type_5446, *PType_5446;

typedef struct Type_5447 Type_5447, *PType_5447;

struct Type_5446 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_5447 {
    enum TypeCode ELEMENT_TYPE_BOOLEAN;
};

struct MethodRefSig_175 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5446 RetType;
    struct Type_5447 Param0;
};

struct Blob_MethodRefSig_175 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_175 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_FieldSig_445 Blob_FieldSig_445, *PBlob_FieldSig_445;

typedef struct FieldSig_445 FieldSig_445, *PFieldSig_445;

typedef struct Type_5715 Type_5715, *PType_5715;

struct Type_5715 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct FieldSig_445 {
    byte FIELD; // Magic (0x06)
    struct Type_5715 ELEMENT_TYPE_CLASS;
};

struct Blob_FieldSig_445 {
    byte Size; // coded integer - blob size
    struct FieldSig_445 FieldSig; // Type information for Field
};

typedef struct Blob_MethodRefSig_28 Blob_MethodRefSig_28, *PBlob_MethodRefSig_28;

typedef struct MethodRefSig_28 MethodRefSig_28, *PMethodRefSig_28;

typedef struct Type_5299 Type_5299, *PType_5299;

struct Type_5299 {
    struct ValueType.conflict1 ELEMENT_TYPE_VALUETYPE;
};

struct MethodRefSig_28 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5299 RetType;
};

struct Blob_MethodRefSig_28 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_28 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodDefSig_152 Blob_MethodDefSig_152, *PBlob_MethodDefSig_152;

typedef struct MethodDefSig_152 MethodDefSig_152, *PMethodDefSig_152;

typedef struct Type_5423 Type_5423, *PType_5423;

typedef struct Type_5424 Type_5424, *PType_5424;

struct Type_5424 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct Type_5423 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodDefSig_152 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte Count; // Number of parameter types to follow RetType
    struct Type_5423 RetType;
    struct Type_5424 Param0;
};

struct Blob_MethodDefSig_152 {
    byte Size; // coded integer - blob size
    struct MethodDefSig_152 MethodDefSig; // Type info for method return and params
};

typedef struct Blob_FieldSig_441 Blob_FieldSig_441, *PBlob_FieldSig_441;

typedef struct FieldSig_441 FieldSig_441, *PFieldSig_441;

typedef struct Type_5711 Type_5711, *PType_5711;

struct Type_5711 {
    struct ValueType ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_441 {
    byte FIELD; // Magic (0x06)
    struct Type_5711 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_441 {
    byte Size; // coded integer - blob size
    struct FieldSig_441 FieldSig; // Type information for Field
};

typedef struct Blob_MethodRefSig_23 Blob_MethodRefSig_23, *PBlob_MethodRefSig_23;

typedef struct MethodRefSig_23 MethodRefSig_23, *PMethodRefSig_23;

typedef struct Type_5294 Type_5294, *PType_5294;

struct Type_5294 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct MethodRefSig_23 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5294 RetType;
};

struct Blob_MethodRefSig_23 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_23 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodSpecSig_206 Blob_MethodSpecSig_206, *PBlob_MethodSpecSig_206;

typedef struct MethodSpecSig_206 MethodSpecSig_206, *PMethodSpecSig_206;

struct MethodSpecSig_206 {
    byte GENRICINST; // Magic (0x0a)
    byte GenArgCount; // Number of types to follow
    struct ValueType.conflict6 Type0;
};

struct Blob_MethodSpecSig_206 {
    byte Size; // coded integer - blob size
    struct MethodSpecSig_206 MethodSpecSig; // Specifies a generic method with GenArgCount types
};

typedef struct Blob_FieldSig_457 Blob_FieldSig_457, *PBlob_FieldSig_457;

typedef struct FieldSig_457 FieldSig_457, *PFieldSig_457;

typedef struct Type_5727 Type_5727, *PType_5727;

struct Type_5727 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct FieldSig_457 {
    byte FIELD; // Magic (0x06)
    struct Type_5727 ELEMENT_TYPE_CLASS;
};

struct Blob_FieldSig_457 {
    byte Size; // coded integer - blob size
    struct FieldSig_457 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_58 Blob_Generic_58, *PBlob_Generic_58;

struct Blob_Generic_58 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_211 Blob_Generic_211, *PBlob_Generic_211;

struct Blob_Generic_211 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_453 Blob_Generic_453, *PBlob_Generic_453;

struct Blob_Generic_453 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_218 Blob_Generic_218, *PBlob_Generic_218;

struct Blob_Generic_218 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_53 Blob_Generic_53, *PBlob_Generic_53;

struct Blob_Generic_53 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_579 Blob_Generic_579, *PBlob_Generic_579;

struct Blob_Generic_579 {
    byte Size; // coded integer - blob size
    byte Generic[76]; // Undefined blob contents
};

typedef struct Blob_Generic_457 Blob_Generic_457, *PBlob_Generic_457;

struct Blob_Generic_457 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_TypeSpec_84 Blob_TypeSpec_84, *PBlob_TypeSpec_84;

struct Blob_TypeSpec_84 {
    byte Size; // coded integer - blob size
    struct GenericInstType_5354 TypeSpec; // Describes a type.
};

typedef struct Blob_MethodRefSig_163 Blob_MethodRefSig_163, *PBlob_MethodRefSig_163;

typedef struct MethodRefSig_163 MethodRefSig_163, *PMethodRefSig_163;

typedef struct Type_5434 Type_5434, *PType_5434;

typedef struct Type_5435 Type_5435, *PType_5435;

struct Type_5435 {
    struct ValueType.conflict3 ELEMENT_TYPE_VALUETYPE;
};

struct Type_5434 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_163 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5434 RetType;
    struct Type_5435 Param0;
};

struct Blob_MethodRefSig_163 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_163 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_LocalVarSig_257 Blob_LocalVarSig_257, *PBlob_LocalVarSig_257;

typedef struct LocalVarSig_257 LocalVarSig_257, *PLocalVarSig_257;

typedef struct Type_5528 Type_5528, *PType_5528;

typedef struct Type_5529 Type_5529, *PType_5529;

typedef struct Type_5531 Type_5531, *PType_5531;

typedef struct Type_5537 Type_5537, *PType_5537;

struct Type_5537 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct Type_5528 {
    enum TypeCode ELEMENT_TYPE_I4;
};

struct Type_5531 {
    struct GenericInstType_5532 ELEMENT_TYPE_GENERICINST;
};

struct Type_5529 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct LocalVarSig_257 {
    byte LOCAL_SIG; // Magic (0x07)
    byte Count; // Number of types to follow
    struct Type_5528 Type;
    struct Type_5529 Type;
    struct Type_5531 Type;
    struct Type_5537 Type;
};

struct Blob_LocalVarSig_257 {
    byte Size; // coded integer - blob size
    struct LocalVarSig_257 LocalVarSig; // Contains signature for function locals
};

typedef struct Blob_FieldSig_453 Blob_FieldSig_453, *PBlob_FieldSig_453;

typedef struct FieldSig_453 FieldSig_453, *PFieldSig_453;

typedef struct Type_5723 Type_5723, *PType_5723;

struct Type_5723 {
    struct ValueType.conflict1 ELEMENT_TYPE_VALUETYPE;
};

struct FieldSig_453 {
    byte FIELD; // Magic (0x06)
    struct Type_5723 ELEMENT_TYPE_VALUETYPE;
};

struct Blob_FieldSig_453 {
    byte Size; // coded integer - blob size
    struct FieldSig_453 FieldSig; // Type information for Field
};

typedef struct Blob_MethodRefSig_12 Blob_MethodRefSig_12, *PBlob_MethodRefSig_12;

typedef struct MethodRefSig_12 MethodRefSig_12, *PMethodRefSig_12;

typedef struct Type_5284 Type_5284, *PType_5284;

typedef struct Type_5285 Type_5285, *PType_5285;

struct Type_5285 {
    enum TypeCode ELEMENT_TYPE_BYREF; // By Reference
    struct ELEMENT_TYPE_MVAR_5287 ELEMENT_TYPE_MVAR;
};

struct Type_5284 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_12 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte GenParamCount; // Number of generic paramameters for the method
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5284 RetType;
    struct Type_5285 Param0;
};

struct Blob_MethodRefSig_12 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_12 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_441 Blob_Generic_441, *PBlob_Generic_441;

struct Blob_Generic_441 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_445 Blob_Generic_445, *PBlob_Generic_445;

struct Blob_Generic_445 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_566 Blob_Generic_566, *PBlob_Generic_566;

struct Blob_Generic_566 {
    byte Size; // coded integer - blob size
    byte Generic[12]; // Undefined blob contents
};

typedef struct Blob_Generic_449 Blob_Generic_449, *PBlob_Generic_449;

struct Blob_Generic_449 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_20 Blob_Generic_20, *PBlob_Generic_20;

struct Blob_Generic_20 {
    byte Size; // coded integer - blob size
    byte Generic[2]; // Undefined blob contents
};

typedef struct Blob_Generic_206 Blob_Generic_206, *PBlob_Generic_206;

struct Blob_Generic_206 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_23 Blob_Generic_23, *PBlob_Generic_23;

struct Blob_Generic_23 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_158 Blob_MethodRefSig_158, *PBlob_MethodRefSig_158;

typedef struct MethodRefSig_158 MethodRefSig_158, *PMethodRefSig_158;

typedef struct Type_5429 Type_5429, *PType_5429;

typedef struct Type_5430 Type_5430, *PType_5430;

struct Type_5429 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_5430 {
    enum TypeCode ELEMENT_TYPE_I4;
};

struct MethodRefSig_158 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5429 RetType;
    struct Type_5430 Param0;
};

struct Blob_MethodRefSig_158 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_158 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_28 Blob_Generic_28, *PBlob_Generic_28;

struct Blob_Generic_28 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_7 Blob_MethodRefSig_7, *PBlob_MethodRefSig_7;

typedef struct MethodRefSig_7 MethodRefSig_7, *PMethodRefSig_7;

typedef struct Type_5278 Type_5278, *PType_5278;

struct Type_5278 {
    struct ValueType ELEMENT_TYPE_VALUETYPE;
};

struct MethodRefSig_7 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5278 RetType;
};

struct Blob_MethodRefSig_7 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_7 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodRefSig_152 Blob_MethodRefSig_152, *PBlob_MethodRefSig_152;

typedef struct MethodRefSig_152 MethodRefSig_152, *PMethodRefSig_152;

struct MethodRefSig_152 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5423 RetType;
    struct Type_5424 Param0;
};

struct Blob_MethodRefSig_152 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_152 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_LocalVarSig_223 Blob_LocalVarSig_223, *PBlob_LocalVarSig_223;

typedef struct LocalVarSig_223 LocalVarSig_223, *PLocalVarSig_223;

typedef struct Type_5494 Type_5494, *PType_5494;

typedef struct Type_5496 Type_5496, *PType_5496;

struct Type_5494 {
    struct ValueType.conflict8 ELEMENT_TYPE_VALUETYPE;
};

struct Type_5496 {
    struct ValueType ELEMENT_TYPE_VALUETYPE;
};

struct LocalVarSig_223 {
    byte LOCAL_SIG; // Magic (0x07)
    byte Count; // Number of types to follow
    struct Type_5494 Type;
    struct Type_5496 Type;
};

struct Blob_LocalVarSig_223 {
    byte Size; // coded integer - blob size
    struct LocalVarSig_223 LocalVarSig; // Contains signature for function locals
};

typedef struct Blob_MethodRefSig_1 Blob_MethodRefSig_1, *PBlob_MethodRefSig_1;

typedef struct MethodRefSig_1 MethodRefSig_1, *PMethodRefSig_1;

typedef struct Type_5272 Type_5272, *PType_5272;

typedef struct Type_5273 Type_5273, *PType_5273;

struct Type_5272 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct Type_5273 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct MethodRefSig_1 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5272 RetType;
    struct Type_5273 Param0;
};

struct Blob_MethodRefSig_1 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_1 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_430 Blob_Generic_430, *PBlob_Generic_430;

struct Blob_Generic_430 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_793 Blob_Generic_793, *PBlob_Generic_793;

struct Blob_Generic_793 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_FieldSig_438 Blob_FieldSig_438, *PBlob_FieldSig_438;

typedef struct FieldSig_438 FieldSig_438, *PFieldSig_438;

typedef struct Type_5708 Type_5708, *PType_5708;

struct Type_5708 {
    enum TypeCode ELEMENT_TYPE_I4;
};

struct FieldSig_438 {
    byte FIELD; // Magic (0x06)
    struct Type_5708 ELEMENT_TYPE_I4;
};

struct Blob_FieldSig_438 {
    byte Size; // coded integer - blob size
    struct FieldSig_438 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_434 Blob_Generic_434, *PBlob_Generic_434;

struct Blob_Generic_434 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_37 Blob_Generic_37, *PBlob_Generic_37;

struct Blob_Generic_37 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_438 Blob_Generic_438, *PBlob_Generic_438;

struct Blob_Generic_438 {
    byte Size; // coded integer - blob size
    byte Generic[2]; // Undefined blob contents
};

typedef struct Blob_Generic_33 Blob_Generic_33, *PBlob_Generic_33;

struct Blob_Generic_33 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_146 Blob_MethodRefSig_146, *PBlob_MethodRefSig_146;

typedef struct MethodRefSig_146 MethodRefSig_146, *PMethodRefSig_146;

typedef struct Type_5417 Type_5417, *PType_5417;

typedef struct Type_5418 Type_5418, *PType_5418;

struct Type_5418 {
    struct ValueType.conflict2 ELEMENT_TYPE_VALUETYPE;
};

struct Type_5417 {
    enum TypeCode ELEMENT_TYPE_VOID;
};

struct MethodRefSig_146 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5417 RetType;
    struct Type_5418 Param0;
};

struct Blob_MethodRefSig_146 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_146 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_AssemblyRefSig_300 Blob_AssemblyRefSig_300, *PBlob_AssemblyRefSig_300;

typedef struct AssemblyRefSig_300 AssemblyRefSig_300, *PAssemblyRefSig_300;

struct AssemblyRefSig_300 {
    byte field0_0x0[128]; // AssemblyRef Content
};

struct Blob_AssemblyRefSig_300 {
    word Size; // coded integer - blob size
    struct AssemblyRefSig_300 AssemblyRefSig; // Data stored in an AssemblyRef blob
};

typedef struct Blob_MethodRefSig_141 Blob_MethodRefSig_141, *PBlob_MethodRefSig_141;

typedef struct MethodRefSig_141 MethodRefSig_141, *PMethodRefSig_141;

typedef struct Type_5412 Type_5412, *PType_5412;

struct Type_5412 {
    struct ValueType.conflict2 ELEMENT_TYPE_VALUETYPE;
};

struct MethodRefSig_141 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5412 RetType;
};

struct Blob_MethodRefSig_141 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_141 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_FieldSig_434 Blob_FieldSig_434, *PBlob_FieldSig_434;

typedef struct FieldSig_434 FieldSig_434, *PFieldSig_434;

typedef struct Type_5704 Type_5704, *PType_5704;

struct Type_5704 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct FieldSig_434 {
    byte FIELD; // Magic (0x06)
    struct Type_5704 ELEMENT_TYPE_CLASS;
};

struct Blob_FieldSig_434 {
    byte Size; // coded integer - blob size
    struct FieldSig_434 FieldSig; // Type information for Field
};

typedef struct Blob_LocalVarSig_235 Blob_LocalVarSig_235, *PBlob_LocalVarSig_235;

typedef struct LocalVarSig_235 LocalVarSig_235, *PLocalVarSig_235;

typedef struct Type_5506 Type_5506, *PType_5506;

typedef struct Type_5507 Type_5507, *PType_5507;

typedef struct Type_5509 Type_5509, *PType_5509;

struct Type_5506 {
    enum TypeCode ELEMENT_TYPE_I4;
};

struct Type_5509 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct Type_5507 {
    struct ValueType.conflict ELEMENT_TYPE_VALUETYPE;
};

struct LocalVarSig_235 {
    byte LOCAL_SIG; // Magic (0x07)
    byte Count; // Number of types to follow
    struct Type_5506 Type;
    struct Type_5507 Type;
    struct Type_5509 Type;
};

struct Blob_LocalVarSig_235 {
    byte Size; // coded integer - blob size
    struct LocalVarSig_235 LocalVarSig; // Contains signature for function locals
};

typedef struct Blob_FieldSig_430 Blob_FieldSig_430, *PBlob_FieldSig_430;

typedef struct FieldSig_430 FieldSig_430, *PFieldSig_430;

typedef struct Type_5700 Type_5700, *PType_5700;

struct Type_5700 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct FieldSig_430 {
    byte FIELD; // Magic (0x06)
    struct Type_5700 ELEMENT_TYPE_CLASS;
};

struct Blob_FieldSig_430 {
    byte Size; // coded integer - blob size
    struct FieldSig_430 FieldSig; // Type information for Field
};

typedef struct Blob_Generic_84 Blob_Generic_84, *PBlob_Generic_84;

struct Blob_Generic_84 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_141 Blob_Generic_141, *PBlob_Generic_141;

struct Blob_Generic_141 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_146 Blob_Generic_146, *PBlob_Generic_146;

struct Blob_Generic_146 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_MethodDefSig_23 Blob_MethodDefSig_23, *PBlob_MethodDefSig_23;

typedef struct MethodDefSig_23 MethodDefSig_23, *PMethodDefSig_23;

struct MethodDefSig_23 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte Count; // Number of parameter types to follow RetType
    struct Type_5294 RetType;
};

struct Blob_MethodDefSig_23 {
    byte Size; // coded integer - blob size
    struct MethodDefSig_23 MethodDefSig; // Type info for method return and params
};

typedef struct Blob_Generic_704 Blob_Generic_704, *PBlob_Generic_704;

struct Blob_Generic_704 {
    byte Size; // coded integer - blob size
    byte Generic[38]; // Undefined blob contents
};

typedef struct Blob_TypeSpec_106 Blob_TypeSpec_106, *PBlob_TypeSpec_106;

struct Blob_TypeSpec_106 {
    byte Size; // coded integer - blob size
    struct GenericInstType_5376 TypeSpec; // Describes a type.
};

typedef struct Blob_Generic_250 Blob_Generic_250, *PBlob_Generic_250;

struct Blob_Generic_250 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_95 Blob_Generic_95, *PBlob_Generic_95;

struct Blob_Generic_95 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_91 Blob_Generic_91, *PBlob_Generic_91;

struct Blob_Generic_91 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_137 Blob_Generic_137, *PBlob_Generic_137;

struct Blob_Generic_137 {
    byte Size; // coded integer - blob size
    byte Generic[3]; // Undefined blob contents
};

typedef struct Blob_Generic_257 Blob_Generic_257, *PBlob_Generic_257;

struct Blob_Generic_257 {
    byte Size; // coded integer - blob size
    byte Generic[13]; // Undefined blob contents
};

typedef struct Blob_Generic_134 Blob_Generic_134, *PBlob_Generic_134;

struct Blob_Generic_134 {
    byte Size; // coded integer - blob size
    byte Generic[2]; // Undefined blob contents
};

typedef struct Blob_MethodDefSig_33 Blob_MethodDefSig_33, *PBlob_MethodDefSig_33;

typedef struct MethodDefSig_33 MethodDefSig_33, *PMethodDefSig_33;

struct MethodDefSig_33 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte Count; // Number of parameter types to follow RetType
    struct Type_5304 RetType;
};

struct Blob_MethodDefSig_33 {
    byte Size; // coded integer - blob size
    struct MethodDefSig_33 MethodDefSig; // Type info for method return and params
};

typedef struct Blob_MethodDefSig_37 Blob_MethodDefSig_37, *PBlob_MethodDefSig_37;

typedef struct MethodDefSig_37 MethodDefSig_37, *PMethodDefSig_37;

struct MethodDefSig_37 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte Count; // Number of parameter types to follow RetType
    struct Type_5308 RetType;
    struct Type_5309 Param0;
};

struct Blob_MethodDefSig_37 {
    byte Size; // coded integer - blob size
    struct MethodDefSig_37 MethodDefSig; // Type info for method return and params
};

typedef struct Blob_MethodRefSig_129 Blob_MethodRefSig_129, *PBlob_MethodRefSig_129;

typedef struct MethodRefSig_129 MethodRefSig_129, *PMethodRefSig_129;

typedef struct Type_5400 Type_5400, *PType_5400;

struct Type_5400 {
    struct ELEMENT_TYPE_VAR_5401 ELEMENT_TYPE_VAR;
};

struct MethodRefSig_129 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5400 RetType;
};

struct Blob_MethodRefSig_129 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_129 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_62 Blob_Generic_62, *PBlob_Generic_62;

struct Blob_Generic_62 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_122 Blob_Generic_122, *PBlob_Generic_122;

struct Blob_Generic_122 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_243 Blob_Generic_243, *PBlob_Generic_243;

struct Blob_Generic_243 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_129 Blob_Generic_129, *PBlob_Generic_129;

struct Blob_Generic_129 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_802 Blob_Generic_802, *PBlob_Generic_802;

struct Blob_Generic_802 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_113 Blob_MethodRefSig_113, *PBlob_MethodRefSig_113;

typedef struct MethodRefSig_113 MethodRefSig_113, *PMethodRefSig_113;

typedef struct Type_5384 Type_5384, *PType_5384;

struct Type_5384 {
    struct GenericInstType_5385 ELEMENT_TYPE_GENERICINST;
};

struct MethodRefSig_113 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5384 RetType;
};

struct Blob_MethodRefSig_113 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_113 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_TypeSpec_122 Blob_TypeSpec_122, *PBlob_TypeSpec_122;

struct Blob_TypeSpec_122 {
    byte Size; // coded integer - blob size
    struct GenericInstType_5392 TypeSpec; // Describes a type.
};

typedef struct Blob_Generic_73 Blob_Generic_73, *PBlob_Generic_73;

struct Blob_Generic_73 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_230 Blob_Generic_230, *PBlob_Generic_230;

struct Blob_Generic_230 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_478 Blob_Generic_478, *PBlob_Generic_478;

struct Blob_Generic_478 {
    byte Size; // coded integer - blob size
    byte Generic[30]; // Undefined blob contents
};

typedef struct Blob_Generic_79 Blob_Generic_79, *PBlob_Generic_79;

struct Blob_Generic_79 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_235 Blob_Generic_235, *PBlob_Generic_235;

struct Blob_Generic_235 {
    byte Size; // coded integer - blob size
    byte Generic[7]; // Undefined blob contents
};

typedef struct Blob_Generic_113 Blob_Generic_113, *PBlob_Generic_113;

struct Blob_Generic_113 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_187 Blob_Generic_187, *PBlob_Generic_187;

struct Blob_Generic_187 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_Generic_743 Blob_Generic_743, *PBlob_Generic_743;

struct Blob_Generic_743 {
    byte Size; // coded integer - blob size
    byte Generic[44]; // Undefined blob contents
};

typedef struct Blob_Generic_509 Blob_Generic_509, *PBlob_Generic_509;

struct Blob_Generic_509 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_170 Blob_Generic_170, *PBlob_Generic_170;

struct Blob_Generic_170 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_291 Blob_Generic_291, *PBlob_Generic_291;

struct Blob_Generic_291 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_Generic_175 Blob_Generic_175, *PBlob_Generic_175;

struct Blob_Generic_175 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_Generic_180 Blob_Generic_180, *PBlob_Generic_180;

struct Blob_Generic_180 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_TypeSpec_134 Blob_TypeSpec_134, *PBlob_TypeSpec_134;

struct Blob_TypeSpec_134 {
    byte Size; // coded integer - blob size
    struct ELEMENT_TYPE_VAR_5404 TypeSpec; // Describes a type.
};

typedef struct Blob_Generic_282 Blob_Generic_282, *PBlob_Generic_282;

struct Blob_Generic_282 {
    byte Size; // coded integer - blob size
    byte Generic[8]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_95 Blob_MethodRefSig_95, *PBlob_MethodRefSig_95;

typedef struct MethodRefSig_95 MethodRefSig_95, *PMethodRefSig_95;

typedef struct Type_5366 Type_5366, *PType_5366;

typedef struct Type_5372 Type_5372, *PType_5372;

typedef struct Type_5373 Type_5373, *PType_5373;

struct Type_5373 {
    enum TypeCode ELEMENT_TYPE_BOOLEAN;
};

struct Type_5372 {
    enum TypeCode ELEMENT_TYPE_STRING;
};

struct Type_5366 {
    struct GenericInstType_5367 ELEMENT_TYPE_GENERICINST;
};

struct MethodRefSig_95 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5366 RetType;
    struct Type_5372 Param0;
    struct Type_5373 Param1;
};

struct Blob_MethodRefSig_95 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_95 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_Generic_163 Blob_Generic_163, *PBlob_Generic_163;

struct Blob_Generic_163 {
    byte Size; // coded integer - blob size
    byte Generic[6]; // Undefined blob contents
};

typedef struct Blob_MethodRefSig_91 Blob_MethodRefSig_91, *PBlob_MethodRefSig_91;

typedef struct MethodRefSig_91 MethodRefSig_91, *PMethodRefSig_91;

typedef struct Type_5362 Type_5362, *PType_5362;

struct Type_5362 {
    enum TypeCode ELEMENT_TYPE_STRING;
};

struct MethodRefSig_91 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5362 RetType;
};

struct Blob_MethodRefSig_91 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_91 MethodRefSig; // Type info for imported method return and params
};

typedef struct Blob_MethodSpecSig_271 Blob_MethodSpecSig_271, *PBlob_MethodSpecSig_271;

typedef struct MethodSpecSig_271 MethodSpecSig_271, *PMethodSpecSig_271;

struct MethodSpecSig_271 {
    byte GENRICINST; // Magic (0x0a)
    byte GenArgCount; // Number of types to follow
    struct GenericInstType_5543 Type0;
    struct ValueType.conflict8 Type1;
};

struct Blob_MethodSpecSig_271 {
    byte Size; // coded integer - blob size
    struct MethodSpecSig_271 MethodSpecSig; // Specifies a generic method with GenArgCount types
};

typedef struct Blob_Generic_271 Blob_Generic_271, *PBlob_Generic_271;

struct Blob_Generic_271 {
    byte Size; // coded integer - blob size
    byte Generic[10]; // Undefined blob contents
};

typedef struct Blob_Generic_152 Blob_Generic_152, *PBlob_Generic_152;

struct Blob_Generic_152 {
    byte Size; // coded integer - blob size
    byte Generic[5]; // Undefined blob contents
};

typedef struct Blob_Generic_158 Blob_Generic_158, *PBlob_Generic_158;

struct Blob_Generic_158 {
    byte Size; // coded integer - blob size
    byte Generic[4]; // Undefined blob contents
};

typedef struct Blob_LocalVarSig_199 Blob_LocalVarSig_199, *PBlob_LocalVarSig_199;

typedef struct LocalVarSig_199 LocalVarSig_199, *PLocalVarSig_199;

typedef struct Type_5470 Type_5470, *PType_5470;

typedef struct Type_5472 Type_5472, *PType_5472;

struct Type_5470 {
    struct ValueType.conflict6 ELEMENT_TYPE_VALUETYPE;
};

struct Type_5472 {
    struct ValueType ELEMENT_TYPE_VALUETYPE;
};

struct LocalVarSig_199 {
    byte LOCAL_SIG; // Magic (0x07)
    byte Count; // Number of types to follow
    struct Type_5470 Type;
    struct Type_5472 Type;
};

struct Blob_LocalVarSig_199 {
    byte Size; // coded integer - blob size
    struct LocalVarSig_199 LocalVarSig; // Contains signature for function locals
};

typedef struct Blob_MethodRefSig_79 Blob_MethodRefSig_79, *PBlob_MethodRefSig_79;

typedef struct MethodRefSig_79 MethodRefSig_79, *PMethodRefSig_79;

typedef struct Type_5350 Type_5350, *PType_5350;

struct Type_5350 {
    struct Class ELEMENT_TYPE_CLASS;
};

struct MethodRefSig_79 {
    byte Flags; // ORed VARARG/GENERIC/HASTHIS/EXPLICITTHIS
    byte ParamCount; // Number of parameter types to follow RetType
    struct Type_5350 RetType;
};

struct Blob_MethodRefSig_79 {
    byte Size; // coded integer - blob size
    struct MethodRefSig_79 MethodRefSig; // Type info for imported method return and params
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

typedef struct MethodSpec Row MethodSpec Row, *PMethodSpec Row;

struct MethodSpec Row {
    word Method; // MethodDefOrRef coded index
    word Instantiation; // index into Blob heap, signature of this instantiation
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

typedef struct TypeSpec Row TypeSpec Row, *PTypeSpec Row;

struct TypeSpec Row {
    word Signature; // index into Blob heap
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

typedef struct CustomAttribute Row CustomAttribute Row, *PCustomAttribute Row;

struct CustomAttribute Row {
    word Parent;
    word Type;
    word Value;
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

typedef struct StandAloneSig Row StandAloneSig Row, *PStandAloneSig Row;

struct StandAloneSig Row {
    word Signature;
};

typedef struct InterfaceImpl Row InterfaceImpl Row, *PInterfaceImpl Row;

struct InterfaceImpl Row {
    word Class; // index into TypeDef table
    word Interface; // index into TypeDef/TypeRef/TypeSpec - TypeDefOrRef coded
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

typedef struct MethodImpl Row MethodImpl Row, *PMethodImpl Row;

struct MethodImpl Row {
    word Class; // index into TypeDef
    word MethodBody; // MethodDefOrRef coded index
    word MethodDeclaration; // MethodDefOrRef coded index
};

typedef struct NestedClass Row NestedClass Row, *PNestedClass Row;

struct NestedClass Row {
    word NestedClass; // TypeDef index
    word EnclosingClass; // TypeDef index
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
    char [1][7];
    char [8][7];
    char [f][14];
    char [1d][6];
    char [23][19];
    char [36][10];
    char [40][16];
    char [50][9];
    char [59][23];
    char [70][28];
    char [8c][9];
    char [95][16];
    char [a5][19];
    char [b8][23];
    char [cf][16];
    char [df][19];
    char [f2][36];
    char [116][17];
    char [127][21];
    char [13c][21];
    char [151][24];
    char [169][13];
    char [176][12];
    char [182][16];
    char [192][15];
    char [1a1][19];
    char [1b4][16];
    char [1c4][13];
    char [1d1][10];
    char [1db][15];
    char [1ea][17];
    char [1fb][13];
    char [208][19];
    char [21b][7];
    char [222][11];
    char [22d][27];
    char [248][20];
    char [25c][21];
    char [271][20];
    char [285][23];
    char [29c][27];
    char [2b7][19];
    char [2ca][27];
    char [2e5][25];
    char [2fe][24];
    char [316][29];
    char [333][31];
    char [352][29];
    char [36f][28];
    char [38b][32];
    char [3ab][25];
    char [3c4][27];
    char [3df][17];
    char [3f0][25];
    char [409][30];
    char [427][6];
    char [42d][26];
    char [447][40];
    char [46f][25];
    char [488][8];
    char [490][9];
    char [499][16];
    char [4a9][13];
    char [4b6][23];
    char [4cd][12];
    char [4d9][15];
    char [4e8][7];
    char [4ef][8];
    char [4f7][19];
    char [50a][18];
    char [51c][13];
    char [529][4];
    char [52d][23];
    char [544][23];
    char [55b][13];
    char [568][12];
    char [574][12];
    char [580][11];
    char [58b][6];
    char [591][6];
    char [597][19];
    char [5aa][26];
    char [5c4][31];
    char [5e3][32];
    char [603][13];
    char [610][15];
    char [61f][31];
    char [63e][10];
    char [648][10];
    char [652][10];
    char [65c][23];
    char [673][25];
    char [68c][39];
    char [6b3][11];
    char [6be][10];
    char [6c8][40];
    char [6f0][38];
    char [716][7];
    char [71d][15];
    char [72c][5];
    char [731][10];
    char [73b][10];
    char [745][6];
    char [74b][9];
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
    struct TypeRef Row TypeRef[52]; // CLI Metadata Table: TypeRef
    struct TypeDef Row TypeDef[6]; // CLI Metadata Table: TypeDef
    struct Field Row Field[15]; // CLI Metadata Table: Field
    struct MethodDef Row MethodDef[13]; // CLI Metadata Table: MethodDef
    struct ParamRow Param[6]; // CLI Metadata Table: Param
    struct InterfaceImpl Row InterfaceImpl[6]; // CLI Metadata Table: InterfaceImpl
    struct MemberRef Row MemberRef[57]; // CLI Metadata Table: MemberRef
    struct CustomAttribute Row CustomAttribute[34]; // CLI Metadata Table: CustomAttribute
    struct StandAloneSig Row StandAloneSig[5]; // CLI Metadata Table: StandAloneSig
    struct MethodImpl Row MethodImpl[8]; // CLI Metadata Table: MethodImpl
    struct TypeSpec Row TypeSpec[5]; // CLI Metadata Table: TypeSpec
    struct Assembly Table Assembly; // CLI Metadata Table: Assembly
    struct AssemblyRef Row AssemblyRef[8]; // CLI Metadata Table: AssemblyRef
    struct NestedClass Row NestedClass[3]; // CLI Metadata Table: NestedClass
    struct MethodSpec Row MethodSpec[6]; // CLI Metadata Table: MethodSpec
};

typedef struct #Blob #Blob, *P#Blob;

struct #Blob {
    byte Reserved; // Always 0
    struct Blob_MethodRefSig_1 MethodRefSig_1; // Type info for imported method return and params
    struct Blob_MethodRefSig_7 MethodRefSig_7; // Type info for imported method return and params
    struct Blob_MethodRefSig_12 MethodRefSig_12; // Type info for imported method return and params
    struct Blob_TypeSpec_20 TypeSpec_20; // Describes a type.
    struct Blob_MethodRefSig_23 MethodRefSig_23; // Type info for imported method return and params
    struct Blob_MethodRefSig_28 MethodRefSig_28; // Type info for imported method return and params
    struct Blob_MethodRefSig_33 MethodRefSig_33; // Type info for imported method return and params
    struct Blob_MethodRefSig_37 MethodRefSig_37; // Type info for imported method return and params
    struct Blob_MethodRefSig_43 MethodRefSig_43; // Type info for imported method return and params
    struct Blob_MethodRefSig_47 MethodRefSig_47; // Type info for imported method return and params
    struct Blob_MethodRefSig_53 MethodRefSig_53; // Type info for imported method return and params
    struct Blob_MethodRefSig_58 MethodRefSig_58; // Type info for imported method return and params
    struct Blob_MethodRefSig_62 MethodRefSig_62; // Type info for imported method return and params
    struct Blob_MethodRefSig_73 MethodRefSig_73; // Type info for imported method return and params
    struct Blob_MethodRefSig_79 MethodRefSig_79; // Type info for imported method return and params
    struct Blob_TypeSpec_84 TypeSpec_84; // Describes a type.
    struct Blob_MethodRefSig_91 MethodRefSig_91; // Type info for imported method return and params
    struct Blob_MethodRefSig_95 MethodRefSig_95; // Type info for imported method return and params
    struct Blob_TypeSpec_106 TypeSpec_106; // Describes a type.
    struct Blob_MethodRefSig_113 MethodRefSig_113; // Type info for imported method return and params
    struct Blob_TypeSpec_122 TypeSpec_122; // Describes a type.
    struct Blob_MethodRefSig_129 MethodRefSig_129; // Type info for imported method return and params
    struct Blob_TypeSpec_134 TypeSpec_134; // Describes a type.
    struct Blob_FieldSig_137 FieldSig_137; // Type information for Field
    struct Blob_MethodRefSig_141 MethodRefSig_141; // Type info for imported method return and params
    struct Blob_MethodRefSig_146 MethodRefSig_146; // Type info for imported method return and params
    struct Blob_MethodRefSig_152 MethodRefSig_152; // Type info for imported method return and params
    struct Blob_MethodRefSig_158 MethodRefSig_158; // Type info for imported method return and params
    struct Blob_MethodRefSig_163 MethodRefSig_163; // Type info for imported method return and params
    struct Blob_MethodRefSig_170 MethodRefSig_170; // Type info for imported method return and params
    struct Blob_MethodRefSig_175 MethodRefSig_175; // Type info for imported method return and params
    struct Blob_MethodRefSig_180 MethodRefSig_180; // Type info for imported method return and params
    struct Blob_MethodRefSig_187 MethodRefSig_187; // Type info for imported method return and params
    struct Blob_MethodRefSig_194 MethodRefSig_194; // Type info for imported method return and params
    struct Blob_LocalVarSig_199 LocalVarSig_199; // Contains signature for function locals
    struct Blob_MethodSpecSig_206 MethodSpecSig_206; // Specifies a generic method with GenArgCount types
    struct Blob_LocalVarSig_211 LocalVarSig_211; // Contains signature for function locals
    struct Blob_MethodSpecSig_218 MethodSpecSig_218; // Specifies a generic method with GenArgCount types
    struct Blob_LocalVarSig_223 LocalVarSig_223; // Contains signature for function locals
    struct Blob_MethodSpecSig_230 MethodSpecSig_230; // Specifies a generic method with GenArgCount types
    struct Blob_LocalVarSig_235 LocalVarSig_235; // Contains signature for function locals
    struct Blob_MethodSpecSig_243 MethodSpecSig_243; // Specifies a generic method with GenArgCount types
    struct Blob_MethodSpecSig_250 MethodSpecSig_250; // Specifies a generic method with GenArgCount types
    struct Blob_LocalVarSig_257 LocalVarSig_257; // Contains signature for function locals
    struct Blob_MethodSpecSig_271 MethodSpecSig_271; // Specifies a generic method with GenArgCount types
    struct Blob_Generic_282 [11a];
    struct Blob_Generic_291 [123];
    struct Blob_AssemblyRefSig_300 AssemblyRefSig_300; // Data stored in an AssemblyRef blob
    struct Blob_FieldSig_430 FieldSig_430; // Type information for Field
    struct Blob_FieldSig_434 FieldSig_434; // Type information for Field
    struct Blob_FieldSig_438 FieldSig_438; // Type information for Field
    struct Blob_FieldSig_441 FieldSig_441; // Type information for Field
    struct Blob_FieldSig_445 FieldSig_445; // Type information for Field
    struct Blob_FieldSig_449 FieldSig_449; // Type information for Field
    struct Blob_FieldSig_453 FieldSig_453; // Type information for Field
    struct Blob_FieldSig_457 FieldSig_457; // Type information for Field
    struct Blob_FieldSig_461 FieldSig_461; // Type information for Field
    struct Blob_Generic_469 [1d5];
    struct Blob_Generic_478 [1de];
    struct Blob_Generic_509 [1fd];
    struct Blob_Generic_518 [206];
    struct Blob_Generic_536 [218];
    struct Blob_Generic_542 [21e];
    struct Blob_Generic_566 [236];
    struct Blob_Generic_579 [243];
    struct Blob_Generic_656 [290];
    struct Blob_Generic_704 [2c0];
    struct Blob_Generic_743 [2e7];
    struct Blob_Generic_788 [314];
    struct Blob_Generic_793 [319];
    struct Blob_Generic_802 [322];
};

typedef struct MethodDefHdr_Fat MethodDefHdr_Fat, *PMethodDefHdr_Fat;

struct MethodDefHdr_Fat {
    word Size+Flags; // L.S. Bits 0:3 Size of hdr in bytes, Bits 4:15 Flags
    word MaxStack; // Maximum number of items on the operand stack
    dword CodeSize; // Size of actual method body in bytes
    dword LocalVarSigTok; // Signature for the local variables of the method. 0 means no locals. References standalone signature in Metadata tables, which references #Blob heap.
};

typedef struct MethodDefHdr_Tiny MethodDefHdr_Tiny, *PMethodDefHdr_Tiny;

struct MethodDefHdr_Tiny {
    byte Size+Flags; // L.S. Bits 0:1 Flags, Bits 2:7 Size of method in Bytes
};

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

typedef struct DotNetPdbInfo DotNetPdbInfo, *PDotNetPdbInfo;

struct DotNetPdbInfo {
    char signature[4];
    GUID guid;
    dword age;
    char pdbpath[101];
};



