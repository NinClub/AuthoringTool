// Decompiled with JetBrains decompiler
// Type: <Module>
// Assembly: FileSystemMetaLibrary, Version=1.0.6136.25604, Culture=neutral, PublicKeyToken=null
// MVID: 4C5582A3-19FF-49E7-85B4-2E885794566F
// Assembly location: E:\AuthoringTool\FileSystemMetaLibrary.dll

using \u003CCppImplementationDetails\u003E;
using \u003CCrtImplementationDetails\u003E;
using msclr.interop.details;
using Nintendo.Authoring.FileSystemMetaLibrary;
using Nintendo.Authoring.FileSystemMetaLibrary.\u003FGetFileFragmentList\u0040PartitionFileSystemArchiveReaderImpl\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0024\u0024FQAMP\u0024AAV\u003F\u0024List\u0040P\u0024AAV\u003F\u0024Tuple\u0040_J_J\u0040System\u0040\u0040\u0040Generic\u0040Collections\u0040System\u0040\u0040P\u0024AAVString\u00408\u0040\u0040Z.__l2;
using Nintendo.Authoring.FileSystemMetaLibrary.\u003FGetFileFragmentList\u0040RomFsFileSystemArchiveReaderImpl\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0024\u0024FQAMP\u0024AAV\u003F\u0024List\u0040P\u0024AAV\u003F\u0024Tuple\u0040_J_J\u0040System\u0040\u0040\u0040Generic\u0040Collections\u0040System\u0040\u0040P\u0024AAVString\u00408\u0040\u0040Z.__l2;
using Nintendo.Authoring.FileSystemMetaLibrary.\u003FGetFileFragmentList\u0040Sha256PartitionFileSystemArchiveReaderImpl\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0024\u0024FQAMP\u0024AAV\u003F\u0024List\u0040P\u0024AAV\u003F\u0024Tuple\u0040_J_J\u0040System\u0040\u0040\u0040Generic\u0040Collections\u0040System\u0040\u0040P\u0024AAVString\u00408\u0040\u0040Z.__l2;
using Nintendo.Authoring.FileSystemMetaLibrary.\u003FGetFileSize\u0040FileSystemArchiveReaderImplBase\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0024\u0024FQAM_JP\u0024AAVString\u0040System\u0040\u0040\u0040Z.__l2;
using Nintendo.Authoring.FileSystemMetaLibrary.\u003FListFileInfo\u0040FileSystemArchiveReaderImplBase\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0024\u0024FQAMP\u0024AAV\u003F\u0024List\u0040P\u0024AAV\u003F\u0024Tuple\u0040P\u0024AAVString\u0040System\u0040\u0040_J\u0040System\u0040\u0040\u0040Generic\u0040Collections\u0040System\u0040\u0040P\u0024AAVString\u00408\u0040\u0040Z.__l2;
using Nintendo.Authoring.FileSystemMetaLibrary.\u003FOpenFileStorage\u0040PartitionFileSystemArchiveReaderImpl\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0024\u0024FQAMXPAV\u003F\u0024shared_ptr\u0040VIStorage\u0040fs\u0040nn\u0040\u0040\u0040std\u0040\u0040P\u0024AAVString\u0040System\u0040\u0040\u0040Z.__l2;
using Nintendo.Authoring.FileSystemMetaLibrary.\u003FOpenFileStorage\u0040Sha256PartitionFileSystemArchiveReaderImpl\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0024\u0024FQAMXPAV\u003F\u0024shared_ptr\u0040VIStorage\u0040fs\u0040nn\u0040\u0040\u0040std\u0040\u0040P\u0024AAVString\u0040System\u0040\u0040\u0040Z.__l2;
using Nintendo.Authoring.FileSystemMetaLibrary.\u003FReadFile\u0040FileSystemArchiveReaderImplBase\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0024\u0024FQAMP\u002401AEP\u0024AAVString\u0040System\u0040\u0040_J1\u0040Z.__l2;
using nn;
using nn.fs;
using nn.fssystem;
using nn.fssystem.detail;
using nn.fssystem.RomPathTool;
using nn.fssystem.save;
using nn.ncm;
using nn.os;
using nn.result.detail;
using nn.sf.detail;
using nn.util;
using nn.util.detail;
using std;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;

internal class \u003CModule\u003E
{
  internal static \u0024ArrayType\u0024\u0024\u0024BY0BC\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_0BC\u0040EOODALEL\u0040Unknown\u003F5exception\u003F\u0024AA\u0040;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4exception\u0040std\u0040\u00406B\u0040;
  internal static bool Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x66b321eb\u002Eg_IsBufferPoolInitialized;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0IAAAAA\u0040D Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x66b321eb\u002Eg_DeviceBuffer;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040exception\u0040std\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_4 \u003F\u003F_R2exception\u0040std\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY02Q6AXXZ \u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3exception\u0040std\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_20 \u003F\u003F_R0\u003FAVexception\u0040std\u0040\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0BA\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_0BA\u0040JFNIOLAK\u0040string\u003F5too\u003F5long\u003F\u0024AA\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0BI\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_0BI\u0040CFPLBAOH\u0040invalid\u003F5string\u003F5position\u003F\u0024AA\u0040;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_27 \u003F\u003F_R0\u003FAVfailure\u0040ios_base\u0040std\u0040\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_24 \u003F\u003F_R0\u003FAVruntime_error\u0040std\u0040\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_16 \u003F\u003F_R2system_error\u0040std\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040system_error\u0040std\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY07Q6AXXZ \u003F\u003F_7FileSystemBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_4 \u003F\u003F_R2Newable\u0040detail\u0040fs\u0040nn\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_27 \u003F\u003F_R0\u003FAVNewable\u0040detail\u0040fs\u0040nn\u0040\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_12 \u003F\u003F_R2SubStorage\u0040fs\u0040nn\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4SubStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3DummyStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_4 \u003F\u003F_R2IBufferManager\u0040fssystem\u0040nn\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R13\u003F0A\u0040EA\u0040Newable\u0040detail\u0040fs\u0040nn\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4runtime_error\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4_System_error\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040bad_cast\u0040std\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040runtime_error\u0040std\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_12 \u003F\u003F_R2_System_error\u0040std\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_23 \u003F\u003F_R0\u003FAVsystem_error\u0040std\u0040\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3SubStorage\u0040fs\u0040nn\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4system_error\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4DummyStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4IBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040DummyStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3FileSystemBufferManager\u0040fssystem\u0040nn\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_33 \u003F\u003F_R0\u003FAVIBufferManager\u0040fssystem\u0040nn\u0040\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3_System_error\u0040std\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_4 \u003F\u003F_R2IStorage\u0040fs\u0040nn\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY07Q6AXXZ \u003F\u003F_7IBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2FileSystemBufferManager\u0040fssystem\u0040nn\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_42 \u003F\u003F_R0\u003FAVFileSystemBufferManager\u0040fssystem\u0040nn\u0040\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2bad_cast\u0040std\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4failure\u0040ios_base\u0040std\u0040\u00406B\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY02Q6AXXZ \u003F\u003F_7bad_cast\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3IStorage\u0040fs\u0040nn\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4RomFsStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2RomFsStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040IStorage\u0040fs\u0040nn\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_19 \u003F\u003F_R0\u003FAVbad_cast\u0040std\u0040\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_60 \u003F\u003F_R0\u003FAVRomFsStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_20 \u003F\u003F_R2failure\u0040ios_base\u0040std\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY07Q6AXXZ \u003F\u003F_7RomFsStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3failure\u0040ios_base\u0040std\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_60 \u003F\u003F_R0\u003FAVDummyStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY07Q6AXXZ \u003F\u003F_7SubStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040IBufferManager\u0040fssystem\u0040nn\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY02Q6AXXZ \u003F\u003F_7runtime_error\u0040std\u0040\u00406B\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY02Q6AXXZ \u003F\u003F_7_System_error\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040Newable\u0040detail\u0040fs\u0040nn\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040failure\u0040ios_base\u0040std\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_21 \u003F\u003F_R0\u003FAVIStorage\u0040fs\u0040nn\u0040\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040FileSystemBufferManager\u0040fssystem\u0040nn\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY07Q6AXXZ \u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2DummyStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3RomFsStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040SubStorage\u0040fs\u0040nn\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040_System_error\u0040std\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3bad_cast\u0040std\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4FileSystemBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3IBufferManager\u0040fssystem\u0040nn\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4bad_cast\u0040std\u0040\u00406B\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2runtime_error\u0040std\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3Newable\u0040detail\u0040fs\u0040nn\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_24 \u003F\u003F_R0\u003FAV_System_error\u0040std\u0040\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY07Q6AXXZ \u003F\u003F_7DummyStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3system_error\u0040std\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_23 \u003F\u003F_R0\u003FAVSubStorage\u0040fs\u0040nn\u0040\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY02Q6AXXZ \u003F\u003F_7system_error\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3runtime_error\u0040std\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY02Q6AXXZ \u003F\u003F_7failure\u0040ios_base\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040RomFsStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  public static unsafe int** __unep\u0040\u003FGenerateRandomForAuthoringTool\u0040\u003FA0x9604d1c5\u0040\u0040\u0024\u0024FYAXPAXI\u0040Z;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040ManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4MemoryResource\u0040nn\u0040\u00406B\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_4 \u003F\u003F_R2MemoryResource\u0040nn\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_69 \u003F\u003F_R0\u003FAVDefaultMemoryResource\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040_Ref_count_base\u0040std\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3\u003F\u0024_Ref_count_obj\u0040VNcaReader\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040\u003F\u0024_Ref_count_obj\u0040VNcaReader\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040\u003F\u0024_Ref_count\u0040VManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY04Q6AXXZ \u003F\u003F_7\u003F\u0024_Ref_count_obj\u0040VNcaReader\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_88 \u003F\u003F_R0\u003FAV\u003F\u0024_Ref_count\u0040VManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0040std\u0040\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4_Ref_count_base\u0040std\u0040\u00406B\u0040;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_68 \u003F\u003F_R0\u003FAVManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4ManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3DefaultMemoryResource\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY04Q6AXXZ \u003F\u003F_7MemoryResource\u0040nn\u0040\u00406B\u0040;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4DefaultMemoryResource\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_52 \u003F\u003F_R0\u003FAV\u003F\u0024_Ref_count_obj\u0040VNcaReader\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3MemoryResource\u0040nn\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY04Q6AXXZ \u003F\u003F_7DefaultMemoryResource\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4\u003F\u0024_Ref_count_obj\u0040VNcaReader\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY04Q6AXXZ \u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY07Q6AXXZ \u003F\u003F_7ManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2\u003F\u0024_Ref_count_obj\u0040VNcaReader\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2\u003F\u0024_Ref_count\u0040VManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY04Q6AXXZ \u003F\u003F_7\u003F\u0024_Ref_count\u0040VManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2ManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040DefaultMemoryResource\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040MemoryResource\u0040nn\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_24 \u003F\u003F_R0\u003FAVMemoryResource\u0040nn\u0040\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_26 \u003F\u003F_R0\u003FAV_Ref_count_base\u0040std\u0040\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3_Ref_count_base\u0040std\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3\u003F\u0024_Ref_count\u0040VManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2DefaultMemoryResource\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_4 \u003F\u003F_R2_Ref_count_base\u0040std\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4\u003F\u0024_Ref_count\u0040VManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3ManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00408;
  static unsafe int** __unep\u0040\u003FGenerateKeyWin\u0040detail\u0040fs\u0040nn\u0040\u0040\u0024\u0024FYAXPAXIPBXIW4NcaKeyIndex\u0040fssystem\u00403\u0040ABUNcaCryptoConfiguration\u004053\u0040\u0040Z;
  internal static \u0024ArrayType\u0024\u0024\u0024BY01\u0024\u0024CBD \u003F\u003F_C\u0040_01KMDKNFGN\u0040\u003F1\u003F\u0024AA\u0040;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040\u003F\u0024_Ref_count_obj\u0040VFileStorageBasedFileSystem\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040V\u003F\u0024PartitionFileSystemMetaCore\u0040VPartitionFileSystemFormat\u0040detail\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040V\u003F\u0024PartitionFileSystemMetaCore\u0040VPartitionFileSystemFormat\u0040detail\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2\u003F\u0024_Ref_count_obj\u0040VFileStorageBasedFileSystem\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_69 \u003F\u003F_R0\u003FAV\u003F\u0024_Ref_count_obj\u0040VFileStorageBasedFileSystem\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4\u003F\u0024_Ref_count_obj\u0040VFileStorageBasedFileSystem\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3\u003F\u0024_Ref_count_obj\u0040VFileStorageBasedFileSystem\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_161 \u003F\u003F_R0\u003FAV\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040V\u003F\u0024PartitionFileSystemMetaCore\u0040VPartitionFileSystemFormat\u0040detail\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040V\u003F\u0024PartitionFileSystemMetaCore\u0040VPartitionFileSystemFormat\u0040detail\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY04Q6AXXZ \u003F\u003F_7\u003F\u0024_Ref_count_obj\u0040VFileStorageBasedFileSystem\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY04Q6AXXZ \u003F\u003F_7\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040V\u003F\u0024PartitionFileSystemMetaCore\u0040VPartitionFileSystemFormat\u0040detail\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040V\u003F\u0024PartitionFileSystemMetaCore\u0040VPartitionFileSystemFormat\u0040detail\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0BD\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_0BD\u0040OLBABOEK\u0040vector\u003F\u0024DMT\u003F\u0024DO\u003F5too\u003F5long\u003F\u0024AA\u0040;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4\u003F\u0024_Ref_count_obj\u0040VRomFsFileSystem\u0040fs\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY04Q6AXXZ \u003F\u003F_7\u003F\u0024_Ref_count_obj\u0040VRomFsFileSystem\u0040fs\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040\u003F\u0024_Ref_count_obj\u0040VRomFsFileSystem\u0040fs\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2\u003F\u0024_Ref_count_obj\u0040VRomFsFileSystem\u0040fs\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3\u003F\u0024_Ref_count_obj\u0040VRomFsFileSystem\u0040fs\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_52 \u003F\u003F_R0\u003FAV\u003F\u0024_Ref_count_obj\u0040VRomFsFileSystem\u0040fs\u0040nn\u0040\u0040\u0040std\u0040\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_32 \u003F\u003F_R0\u003FAVMemoryStorage\u0040fssystem\u0040nn\u0040\u0040\u00408;
  internal static \u0024ArrayType\u0024\u0024\u0024BY07Q6AXXZ \u003F\u003F_7MemoryStorage\u0040fssystem\u0040nn\u0040\u00406B\u0040;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040MemoryStorage\u0040fssystem\u0040nn\u0040\u00408;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2MemoryStorage\u0040fssystem\u0040nn\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3MemoryStorage\u0040fssystem\u0040nn\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4MemoryStorage\u0040fssystem\u0040nn\u0040\u00406B\u0040;
  internal static \u0024ArrayType\u0024\u0024\u0024BY04Q6AXXZ \u003F\u003F_7\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040VSha256PartitionFileSystemMeta\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_8 \u003F\u003F_R2\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040VSha256PartitionFileSystemMeta\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040VSha256PartitionFileSystemMeta\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static \u0024_TypeDescriptor\u0024_extraBytes_113 \u003F\u003F_R0\u003FAV\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040VSha256PartitionFileSystemMeta\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u0040\u00408;
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040VSha256PartitionFileSystemMeta\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040VSha256PartitionFileSystemMeta\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00408;
  internal static __s_GUID _GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e;
  [FixedAddressValueType]
  internal static Progress \u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A;
  internal static __FnPtr<void ()> \u003FA0x13efd873\u002E\u003FInitializedPerProcess\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static __s_GUID _GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e;
  internal static __s_GUID _GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02;
  internal static __s_GUID _GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02;
  [FixedAddressValueType]
  internal static int \u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA;
  [FixedAddressValueType]
  internal static Progress \u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A;
  internal static bool \u003FEntered\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static TriBool \u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A;
  internal static bool \u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static int \u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA;
  [FixedAddressValueType]
  internal static int \u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA;
  [FixedAddressValueType]
  internal static Progress \u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A;
  internal static bool \u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  [FixedAddressValueType]
  internal static bool \u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA;
  [FixedAddressValueType]
  internal static Progress \u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A;
  internal static bool \u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  internal static TriBool \u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ __xc_mp_z;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ __xi_vt_z;
  internal static __FnPtr<void ()> \u003FA0x13efd873\u002E\u003FIsDefaultDomain\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ __xc_ma_a;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ __xc_ma_z;
  internal static __FnPtr<void ()> \u003FA0x13efd873\u002E\u003FInitialized\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static __FnPtr<void ()> \u003FA0x13efd873\u002E\u003FInitializedPerAppDomain\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ __xi_vt_a;
  internal static __FnPtr<void ()> \u003FA0x13efd873\u002E\u003FInitializedNative\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ __xc_mp_a;
  internal static __FnPtr<void ()> \u003FA0x13efd873\u002E\u003FInitializedVtables\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static __FnPtr<void ()> \u003FA0x13efd873\u002E\u003FUninitialized\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  public static unsafe int** __unep\u0040\u003FDoNothing\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z;
  public static unsafe int** __unep\u0040\u003F_UninitializeDefaultDomain\u0040LanguageSupport\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z;
  internal static unsafe __FnPtr<void ()>* \u003FA0x27925454\u002E__onexitbegin_m;
  internal static uint \u003FA0x27925454\u002E__exit_list_size;
  [FixedAddressValueType]
  internal static unsafe __FnPtr<void ()>* __onexitend_app_domain;
  [FixedAddressValueType]
  internal static unsafe void* \u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA;
  [FixedAddressValueType]
  internal static int \u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA;
  internal static unsafe __FnPtr<void ()>* \u003FA0x27925454\u002E__onexitend_m;
  [FixedAddressValueType]
  internal static uint __exit_list_size_app_domain;
  [FixedAddressValueType]
  internal static unsafe __FnPtr<void ()>* __onexitbegin_app_domain;
  internal static \u0024ArrayType\u0024\u0024\u0024BY01Q6AXXZ \u003F\u003F_7type_info\u0040\u00406B\u0040;
  internal static int \u003FMasterHashOffset\u0040HierarchicalSha256Data\u0040HashData\u0040NcaFsHeader\u0040fssystem\u0040nn\u0040\u00402HB;
  internal static int \u003FMasterHashOffset\u0040IntegrityMetaInfo\u0040HashData\u0040NcaFsHeader\u0040fssystem\u0040nn\u0040\u00402HB;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AHXZ __xi_z;
  internal static __scrt_native_startup_state __scrt_current_native_startup_state;
  internal static unsafe void* __scrt_native_startup_lock;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AXXZ __xc_a;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AHXZ __xi_a;
  internal static uint __scrt_native_dllmain_reason;
  internal static \u0024ArrayType\u0024\u0024\u0024BY0A\u0040P6AXXZ __xc_z;

  internal static unsafe Result* nn\u002EResult\u002E\u007Bctor\u007D([In] Result* obj0, uint innerValue)
  {
    *(int*) obj0 = (int) innerValue;
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultInternalAccessor\u002EConstructResult([In] Result* obj0, uint innerValue)
  {
    *(int*) obj0 = (int) innerValue;
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EConstructResult([In] Result* obj0, uint innerValue)
  {
    *(int*) obj0 = (int) innerValue;
    return obj0;
  }

  internal static unsafe Result* nn\u002EResultSuccess\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ResultSuccess* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 0;
    return obj1;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool nn\u002Efssystem\u002ERomPathTool\u002EIsSeparator(sbyte ch)
  {
    return ch == (sbyte) 47;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002Efssystem\u002ERomPathTool\u002EIsCurrentDirectory(sbyte* pDirName)
  {
    return *pDirName == (sbyte) 46 && pDirName[1] == (sbyte) 0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002Efssystem\u002ERomPathTool\u002EIsCurrentDirectory(sbyte* pDirName, uint length)
  {
    return length == 1U && *pDirName == (sbyte) 46;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002Efssystem\u002ERomPathTool\u002EIsParentDirectory(RomEntryName* dirName)
  {
    int num1;
    if (*(int*) dirName == 2)
    {
      int num2 = *(int*) ((IntPtr) dirName + 4);
      if (*(sbyte*) num2 == (sbyte) 46 && *(sbyte*) (num2 + 1) == (sbyte) 46)
      {
        num1 = 1;
        goto label_4;
      }
    }
    num1 = 0;
label_4:
    return num1 != 0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002Efssystem\u002ERomPathTool\u002EIsParentDirectory(sbyte* pDirName)
  {
    return *pDirName == (sbyte) 46 && pDirName[1] == (sbyte) 46 && pDirName[2] == (sbyte) 0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002Efssystem\u002ERomPathTool\u002EIsParentDirectory(sbyte* pDirName, uint length)
  {
    return length == 2U && *pDirName == (sbyte) 46 && pDirName[1] == (sbyte) 46;
  }

  internal static unsafe PathParser* nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002E\u007Bctor\u007D([In] PathParser* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    *(sbyte*) ((IntPtr) obj0 + 12) = (sbyte) 0;
    return obj0;
  }

  internal static unsafe Result* nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EInitialize([In] PathParser* obj0, [In] Result* obj1, sbyte* pFullPath)
  {
    if (*pFullPath != (sbyte) 47)
    {
      *(int*) obj1 = 4052482;
      return obj1;
    }
    while (true)
    {
      sbyte* numPtr = pFullPath + 1;
      if (*numPtr == (sbyte) 47)
        pFullPath = numPtr;
      else
        break;
    }
    *(int*) obj0 = (int) pFullPath;
    *(int*) ((IntPtr) obj0 + 4) = (int) pFullPath;
    *(int*) ((IntPtr) obj0 + 8) = (int) (pFullPath + 1);
    while (true)
    {
      int num = *(int*) ((IntPtr) obj0 + 8);
      if (*(sbyte*) num == (sbyte) 47)
        *(int*) ((IntPtr) obj0 + 8) = num + 1;
      else
        break;
    }
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe void nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EFinalize([In] PathParser* obj0)
  {
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EIsParseFinished([In] PathParser* obj0)
  {
    return (bool) *(byte*) ((IntPtr) obj0 + 12);
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EIsDirectoryPath([In] PathParser* obj0)
  {
    int num = *(int*) ((IntPtr) obj0 + 8);
    if (*(sbyte*) num == (sbyte) 0 && *(sbyte*) (num - 1) == (sbyte) 47)
      return true;
    sbyte* numPtr = (sbyte*) num;
    return (*numPtr != (sbyte) 46 || numPtr[1] != (sbyte) 0 ? 0 : 1) != 0 || \u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EIsParentDirectory((sbyte*) num);
  }

  internal static unsafe Result* nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EGetNextDirectoryName([In] PathParser* obj0, [In] Result* obj1, RomEntryName* pDirName)
  {
    *(int*) pDirName = *(int*) ((IntPtr) obj0 + 4) - *(int*) obj0;
    *(int*) ((IntPtr) pDirName + 4) = *(int*) obj0;
    int num1 = *(int*) ((IntPtr) obj0 + 8);
    *(int*) obj0 = num1;
    sbyte* numPtr = (sbyte*) num1;
    uint num2 = 0;
    while (true)
    {
      switch (*(sbyte*) ((int) num2 + (IntPtr) numPtr))
      {
        case 0:
          goto label_10;
        case 47:
          goto label_3;
        default:
          ++num2;
          continue;
      }
    }
label_3:
    if (num2 >= 768U)
    {
      *(int*) obj1 = 4052994;
      return obj1;
    }
    int num3 = (int) (numPtr + (int) num2);
    *(int*) ((IntPtr) obj0 + 4) = num3;
    *(int*) ((IntPtr) obj0 + 8) = num3 + 1;
    while (true)
    {
      int num4 = *(int*) ((IntPtr) obj0 + 8);
      if (*(sbyte*) num4 == (sbyte) 47)
        *(int*) ((IntPtr) obj0 + 8) = num4 + 1;
      else
        break;
    }
    if (*(sbyte*) *(int*) ((IntPtr) obj0 + 8) == (sbyte) 0)
    {
      *(sbyte*) ((IntPtr) obj0 + 12) = (sbyte) 1;
      goto label_11;
    }
    else
      goto label_11;
label_10:
    *(sbyte*) ((IntPtr) obj0 + 12) = (sbyte) 1;
    int num5 = (int) (numPtr + (int) num2);
    *(int*) ((IntPtr) obj0 + 8) = num5;
    *(int*) ((IntPtr) obj0 + 4) = num5;
label_11:
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EGetAsDirectoryName([In] PathParser* obj0, [In] Result* obj1, RomEntryName* pName)
  {
    uint num = (uint) (*(int*) ((IntPtr) obj0 + 4) - *(int*) obj0);
    if (num > 768U)
    {
      *(int*) obj1 = 4052994;
      return obj1;
    }
    *(int*) pName = (int) num;
    *(int*) ((IntPtr) pName + 4) = *(int*) obj0;
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EGetAsFileName([In] PathParser* obj0, [In] Result* obj1, RomEntryName* pName)
  {
    uint num = (uint) (*(int*) ((IntPtr) obj0 + 4) - *(int*) obj0);
    if (num > 768U)
    {
      *(int*) obj1 = 4053506;
      return obj1;
    }
    *(int*) pName = (int) num;
    *(int*) ((IntPtr) pName + 4) = *(int*) obj0;
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002ERomPathTool\u002EGetParentDirectoryName([In] Result* obj0, RomEntryName* pOut, RomEntryName* @base, sbyte* pHead)
  {
    int num1 = *(int*) ((IntPtr) @base + 4);
    sbyte* numPtr1 = (sbyte*) num1;
    sbyte* numPtr2 = (sbyte*) (*(int*) @base + num1 - 1);
    int num2 = 1;
    int num3 = \u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EIsParentDirectory(@base) ? 2 : num2;
    uint num4 = (uint) *(int*) ((IntPtr) @base + 4);
    if ((UIntPtr) (int) num4 > (UIntPtr) pHead)
    {
      uint num5 = 0;
      sbyte* numPtr3 = (sbyte*) ((int) num4 - 1);
      if (numPtr3 >= pHead)
      {
        do
        {
          if (*numPtr3 == (sbyte) 47)
          {
            if ((num5 != 1U || numPtr3[1] != (sbyte) 46 ? 0 : 1) != 0)
              ++num3;
            if ((num5 != 2U || numPtr3[1] != (sbyte) 46 || (numPtr3 + 1)[1] != (sbyte) 46 ? 0 : 1) != 0)
              num3 += 2;
            if (num3 != 0)
            {
              while (*numPtr3 == (sbyte) 47)
                --numPtr3;
              numPtr2 = numPtr3;
              num5 = 0U;
              --num3;
            }
            else
              goto label_12;
          }
          ++num5;
          --numPtr3;
        }
        while (numPtr3 >= pHead);
        goto label_13;
label_12:
        numPtr1 = numPtr3 + 1;
        goto label_15;
      }
label_13:
      if (num3 != 0)
      {
        *(int*) obj0 = 4052482;
        return obj0;
      }
label_15:
      if (numPtr3 == pHead)
        numPtr1 = pHead + 1;
    }
    if (numPtr2 <= pHead)
    {
      *(int*) ((IntPtr) pOut + 4) = (int) pHead;
      *(int*) pOut = 0;
    }
    else
    {
      *(int*) ((IntPtr) pOut + 4) = (int) numPtr1;
      *(int*) pOut = (int) ((IntPtr) numPtr2 - (IntPtr) numPtr1 + 1);
    }
    *(int*) obj0 = 0;
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C7917\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C7917\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 4053506;
    return obj1;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C7916\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C7916\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 4052994;
    return obj1;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C7915\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C7915\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 4052482;
    return obj1;
  }

  [SpecialName]
  internal static unsafe exception* std\u002Eexception\u002E\u007Bctor\u007D([In] exception* obj0, exception* _Other)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    exception* exceptionPtr = (exception*) ((IntPtr) obj0 + 4);
    // ISSUE: initblk instruction
    __memset((IntPtr) exceptionPtr, 0, 8);
    \u003CModule\u003E.__std_exception_copy((__std_exception_data*) ((IntPtr) _Other + 4), (__std_exception_data*) exceptionPtr);
    return obj0;
  }

  internal static unsafe void std\u002Eexception\u002E\u007Bdtor\u007D([In] exception* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
  }

  internal static unsafe sbyte* std\u002Eexception\u002Ewhat([In] exception* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_0BC\u0040EOODALEL\u0040Unknown\u003F5exception\u003F\u0024AA\u0040;
    return (sbyte*) num;
  }

  internal static unsafe void* std\u002Eexception\u002E__vecDelDtor([In] exception* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      exception* exceptionPtr1 = (exception*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 12U, (uint) *(int*) exceptionPtr1, (__FnPtr<void (void*)>) __methodptr(std\u002Eexception\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        exception* exceptionPtr2 = exceptionPtr1;
        int num = *(int*) exceptionPtr2 * 12 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) exceptionPtr2, (uint) num);
      }
      return (void*) exceptionPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0);
    return (void*) obj0;
  }

  internal static unsafe void std\u002Eexception_ptr\u002E\u007Bdtor\u007D([In] exception_ptr* obj0)
  {
    \u003CModule\u003E.__ExceptionPtrDestroy((void*) obj0);
  }

  [SpecialName]
  internal static unsafe exception_ptr* std\u002Eexception_ptr\u002E\u007Bctor\u007D([In] exception_ptr* obj0, exception_ptr* _Rhs)
  {
    \u003CModule\u003E.__ExceptionPtrCopy((void*) obj0, (void*) _Rhs);
    return obj0;
  }

  [SpecialName]
  internal static unsafe _Container_base12* std\u002E_Container_base12\u002E\u007Bctor\u007D([In] _Container_base12* obj0, _Container_base12* A_0)
  {
    *(int*) obj0 = 0;
    return obj0;
  }

  [SpecialName]
  internal static unsafe _Iterator_base12* std\u002E_Iterator_base12\u002E\u007Bctor\u007D([In] _Iterator_base12* obj0, _Iterator_base12* _Right)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    uint num = (uint) *(int*) _Right;
    if (0U != num)
    {
      _Container_base12* containerBase12Ptr = (_Container_base12*) *(int*) num;
      if ((IntPtr) containerBase12Ptr != IntPtr.Zero)
        *(int*) obj0 = *(int*) containerBase12Ptr;
    }
    return obj0;
  }

  internal static unsafe _Iterator_base12* std\u002E_Iterator_base12\u002E\u003D([In] _Iterator_base12* obj0, _Iterator_base12* _Right)
  {
    uint num = (uint) *(int*) _Right;
    if (*(int*) obj0 != (int) num && num != 0U)
    {
      _Container_base12* containerBase12Ptr = (_Container_base12*) *(int*) num;
      if ((IntPtr) containerBase12Ptr != IntPtr.Zero)
        *(int*) obj0 = *(int*) containerBase12Ptr;
    }
    return obj0;
  }

  internal static unsafe void std\u002E_Iterator_base12\u002E_Adopt([In] _Iterator_base12* obj0, _Container_base12* _Parent)
  {
    if ((IntPtr) _Parent == IntPtr.Zero)
      return;
    *(int*) obj0 = *(int*) _Parent;
  }

  [SpecialName]
  internal static unsafe allocator\u003Cvoid\u003E* std\u002Eallocator\u003Cvoid\u003E\u002E\u007Bctor\u007D([In] allocator\u003Cvoid\u003E* obj0, allocator\u003Cvoid\u003E* A_0)
  {
    return obj0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002EResult\u002EIsSuccess([In] Result* obj0)
  {
    return *(int*) obj0 == 0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EEnsureBufferPool()
  {
    if (\u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x66b321eb\u002Eg_IsBufferPoolInitialized)
      return;
    Result result;
    if (*(int*) \u003CModule\u003E.nn\u002Efssystem\u002EInitializeBufferPool(&result, (sbyte*) &\u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x66b321eb\u002Eg_DeviceBuffer, 8388608U) != 0)
      \u003CModule\u003E.abort();
    \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x66b321eb\u002Eg_IsBufferPoolInitialized = true;
  }

  internal static unsafe void* @new(uint _Size, void* _Where)
  {
    return _Where;
  }

  internal static unsafe sbyte* std\u002Echar_traits\u003Cchar\u003E\u002Ecopy(sbyte* _First1, sbyte* _First2, uint _Count)
  {
    if (_Count == 0U)
      return _First1;
    sbyte* numPtr = _First1;
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) numPtr, (IntPtr) _First2, (int) _Count);
    return numPtr;
  }

  internal static unsafe sbyte* std\u002Echar_traits\u003Cchar\u003E\u002Emove(sbyte* _First1, sbyte* _First2, uint _Count)
  {
    if (_Count == 0U)
      return _First1;
    return (sbyte*) \u003CModule\u003E.memmove((void*) _First1, (void*) _First2, _Count);
  }

  internal static unsafe void std\u002Echar_traits\u003Cchar\u003E\u002Eassign(sbyte* _Left, sbyte* _Right)
  {
    *_Left = *_Right;
  }

  internal static unsafe void* std\u002E_Allocate(uint _Count, uint _Sz, [MarshalAs(UnmanagedType.U1)] bool _Try_aligned_allocation)
  {
    if (_Count == 0U)
      return (void*) 0;
    if (uint.MaxValue / _Sz < _Count)
      \u003CModule\u003E.std\u002E_Xbad_alloc();
    uint num1 = _Count * _Sz;
    void* voidPtr;
    if (_Try_aligned_allocation && 4096U <= num1)
    {
      uint num2 = num1 + 35U;
      if (num2 <= num1)
        \u003CModule\u003E.std\u002E_Xbad_alloc();
      uint num3 = (uint) \u003CModule\u003E.@new(num2);
      if (num3 == 0U)
        \u003CModule\u003E._invalid_parameter_noinfo_noreturn();
      voidPtr = (void*) ((int) num3 + 35 & -32);
      *(int*) ((IntPtr) voidPtr - 4) = (int) num3;
    }
    else
    {
      voidPtr = \u003CModule\u003E.@new(num1);
      if ((IntPtr) voidPtr == IntPtr.Zero)
        \u003CModule\u003E._invalid_parameter_noinfo_noreturn();
    }
    return voidPtr;
  }

  internal static unsafe void std\u002E_Deallocate(void* _Ptr, uint _Count, uint _Sz)
  {
    if (_Count > uint.MaxValue / _Sz)
      \u003CModule\u003E._invalid_parameter_noinfo_noreturn();
    if (4096U <= _Count * _Sz)
    {
      if (((IntPtr) _Ptr & 31) != IntPtr.Zero)
        \u003CModule\u003E._invalid_parameter_noinfo_noreturn();
      uint num1 = (uint) *(int*) ((IntPtr) _Ptr - 4);
      if ((UIntPtr) (int) num1 >= (UIntPtr) _Ptr)
        \u003CModule\u003E._invalid_parameter_noinfo_noreturn();
      uint num2 = (uint) ((IntPtr) _Ptr - (int) num1);
      if (4U > num2)
        \u003CModule\u003E._invalid_parameter_noinfo_noreturn();
      if (num2 > 35U)
        \u003CModule\u003E._invalid_parameter_noinfo_noreturn();
      _Ptr = (void*) num1;
    }
    \u003CModule\u003E.delete(_Ptr);
  }

  internal static unsafe void* std\u002Eruntime_error\u002E__vecDelDtor([In] runtime_error* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      runtime_error* runtimeErrorPtr1 = (runtime_error*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 12U, (uint) *(int*) runtimeErrorPtr1, (__FnPtr<void (void*)>) __methodptr(std\u002Eruntime_error\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        runtime_error* runtimeErrorPtr2 = runtimeErrorPtr1;
        int num = *(int*) runtimeErrorPtr2 * 12 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) runtimeErrorPtr2, (uint) num);
      }
      return (void*) runtimeErrorPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 12U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002Eruntime_error\u002E\u007Bdtor\u007D([In] runtime_error* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
  }

  internal static unsafe void nn\u002Efs\u002EInt64\u002ESet([In] nn.fs.Int64* obj0, long s)
  {
    *(int*) obj0 = (int) s;
    *(int*) ((IntPtr) obj0 + 4) = (int) (uint) ((ulong) s >> 32);
  }

  internal static unsafe long nn\u002Efs\u002EInt64\u002EGet([In] nn.fs.Int64* obj0)
  {
    return (long) (uint) *(int*) ((IntPtr) obj0 + 4) << 32 | (long) (uint) *(int*) obj0;
  }

  internal static unsafe nn.fs.Int64* nn\u002Efs\u002EInt64\u002E\u003D([In] nn.fs.Int64* obj0, long rhs)
  {
    *(int*) obj0 = (int) rhs;
    *(int*) ((IntPtr) obj0 + 4) = (int) (uint) ((ulong) rhs >> 32);
    return obj0;
  }

  internal static unsafe long nn\u002Efs\u002EInt64\u002E\u002E_J([In] nn.fs.Int64* obj0)
  {
    return (long) (uint) *(int*) ((IntPtr) obj0 + 4) << 32 | (long) (uint) *(int*) obj0;
  }

  internal static unsafe nn.os.Mutex* nn\u002Eos\u002EMutex\u002E\u007Bctor\u007D([In] nn.os.Mutex* obj0, [MarshalAs(UnmanagedType.U1)] bool recursive)
  {
    \u003CModule\u003E.nn\u002Eos\u002EInitializeMutex((MutexType*) obj0, recursive, 0);
    return obj0;
  }

  internal static unsafe void nn\u002Eos\u002EMutex\u002E\u007Bdtor\u007D([In] nn.os.Mutex* obj0)
  {
    \u003CModule\u003E.nn\u002Eos\u002EFinalizeMutex((MutexType*) obj0);
  }

  internal static unsafe void nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D([In] IStorage* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  }

  internal static unsafe Result* nn\u002Efs\u002EIStorage\u002EWrite([In] IStorage* obj0, [In] Result* obj1, long offset, void* buffer, uint size)
  {
    \u003CModule\u003E.abort();
    return (Result*) 0;
  }

  internal static unsafe Result* nn\u002Efs\u002EIStorage\u002EFlush([In] IStorage* obj0, [In] Result* obj1)
  {
    \u003CModule\u003E.abort();
    return (Result*) 0;
  }

  internal static unsafe Result* nn\u002Efs\u002EIStorage\u002ESetSize([In] IStorage* obj0, [In] Result* obj1, long size)
  {
    \u003CModule\u003E.abort();
    return (Result*) 0;
  }

  internal static unsafe Result* nn\u002Efs\u002EIStorage\u002EOperateRange([In] IStorage* obj0, [In] Result* obj1, IStorage.OperationId operationId, long offset, long size)
  {
    *(int*) obj1 = 3225602;
    return obj1;
  }

  internal static unsafe void* nn\u002Efs\u002EIStorage\u002E__vecDelDtor([In] IStorage* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      IStorage* istoragePtr1 = (IStorage*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 4U, (uint) *(int*) istoragePtr1, (__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        IStorage* istoragePtr2 = istoragePtr1;
        int num = *(int*) istoragePtr2 * 4 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) istoragePtr2, (uint) num);
      }
      return (void*) istoragePtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 4U);
    return (void*) obj0;
  }

  internal static unsafe void* std\u002Ebad_cast\u002E__vecDelDtor([In] bad_cast* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      bad_cast* badCastPtr1 = (bad_cast*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 12U, (uint) *(int*) badCastPtr1, (__FnPtr<void (void*)>) __methodptr(std\u002Ebad_cast\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        bad_cast* badCastPtr2 = badCastPtr1;
        int num = *(int*) badCastPtr2 * 12 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) badCastPtr2, (uint) num);
      }
      return (void*) badCastPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 12U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002Ebad_cast\u002E\u007Bdtor\u007D([In] bad_cast* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
  }

  internal static unsafe void std\u002E_Ref_count_base\u002E_Incref([In] _Ref_count_base* obj0)
  {
    // ISSUE: cast to a reference type
    Interlocked.Increment((int&) ((IntPtr) obj0 + 4));
  }

  internal static unsafe void std\u002E_Ref_count_base\u002E_Decref([In] _Ref_count_base* obj0)
  {
    // ISSUE: cast to a reference type
    if (Interlocked.Decrement((int&) ((IntPtr) obj0 + 4)) != 0)
      return;
    _Ref_count_base* refCountBasePtr1 = obj0;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    __calli((__FnPtr<void (IntPtr)>) *(int*) *(int*) refCountBasePtr1)((IntPtr) refCountBasePtr1);
    // ISSUE: cast to a reference type
    if (Interlocked.Decrement((int&) ((IntPtr) obj0 + 8)) != 0)
      return;
    _Ref_count_base* refCountBasePtr2 = obj0;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    __calli((__FnPtr<void (IntPtr)>) *(int*) (*(int*) refCountBasePtr2 + 4))((IntPtr) refCountBasePtr2);
  }

  internal static unsafe void std\u002E_Ref_count_base\u002E_Decwref([In] _Ref_count_base* obj0)
  {
    // ISSUE: cast to a reference type
    if (Interlocked.Decrement((int&) ((IntPtr) obj0 + 8)) != 0)
      return;
    _Ref_count_base* refCountBasePtr = obj0;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    __calli((__FnPtr<void (IntPtr)>) *(int*) (*(int*) refCountBasePtr + 4))((IntPtr) refCountBasePtr);
  }

  internal static unsafe void* nn\u002Efs\u002Edetail\u002ENewable\u002Enew(uint size)
  {
    return \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EAllocate(size);
  }

  internal static unsafe void nn\u002Efs\u002Edetail\u002ENewable\u002Edelete(void* p, uint size)
  {
    \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EDeallocate(p, size);
  }

  internal static unsafe void nn\u002Efs\u002Edetail\u002ENewable\u002Edelete\u005B\u005D(void* p, uint size)
  {
    \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EDeallocate(p, size);
  }

  internal static unsafe SubStorage* nn\u002Efs\u002ESubStorage\u002E\u007Bctor\u007D([In] SubStorage* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7SubStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
      *(int*) ((IntPtr) obj0 + 4) = 0;
      *(long*) ((IntPtr) obj0 + 8) = 0L;
      *(long*) ((IntPtr) obj0 + 16) = 0L;
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) obj0 + 24);
      *(int*) sharedPtrNnFsIstoragePtr = 0;
      *(int*) ((IntPtr) sharedPtrNnFsIstoragePtr + 4) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  [SpecialName]
  internal static unsafe SubStorage* nn\u002Efs\u002ESubStorage\u002E\u007Bctor\u007D([In] SubStorage* obj0, SubStorage* subStorage)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7SubStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
      *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) subStorage + 4);
      *(long*) ((IntPtr) obj0 + 8) = *(long*) ((IntPtr) subStorage + 8);
      *(long*) ((IntPtr) obj0 + 16) = *(long*) ((IntPtr) subStorage + 16);
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) obj0 + 24);
      *(int*) sharedPtrNnFsIstoragePtr = 0;
      *(int*) ((IntPtr) sharedPtrNnFsIstoragePtr + 4) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe SubStorage* nn\u002Efs\u002ESubStorage\u002E\u007Bctor\u007D([In] SubStorage* obj0, IStorage* pBaseStorage, long offset, long size)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7SubStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
      *(int*) ((IntPtr) obj0 + 4) = (int) pBaseStorage;
      *(long*) ((IntPtr) obj0 + 8) = offset;
      *(long*) ((IntPtr) obj0 + 16) = size;
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) obj0 + 24);
      *(int*) sharedPtrNnFsIstoragePtr = 0;
      *(int*) ((IntPtr) sharedPtrNnFsIstoragePtr + 4) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe Result* nn\u002Efs\u002ESubStorage\u002ERead([In] SubStorage* obj0, [In] Result* obj1, long offset, void* buffer, uint size)
  {
    if (size == 0U)
    {
      *(int*) obj1 = 0;
      return obj1;
    }
    if ((IntPtr) buffer == IntPtr.Zero)
    {
      *(int*) obj1 = 3104258;
      return obj1;
    }
    if (offset >= 0L && *(long*) ((IntPtr) obj0 + 16) >= (long) size + offset)
    {
      int num1 = *(int*) ((IntPtr) obj0 + 4);
      int num2 = num1;
      Result result;
      ref Result local = ref result;
      long num3 = *(long*) ((IntPtr) obj0 + 8) + offset;
      void* voidPtr = buffer;
      int num4 = (int) size;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num5 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num1 + 4))((uint) num2, (void*) ref local, num3, (Result*) voidPtr, (IntPtr) num4);
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, num5, 4);
      return obj1;
    }
    *(int*) obj1 = 1538562;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efs\u002ESubStorage\u002EWrite([In] SubStorage* obj0, [In] Result* obj1, long offset, void* buffer, uint size)
  {
    if (size == 0U)
    {
      *(int*) obj1 = 0;
      return obj1;
    }
    if ((IntPtr) buffer == IntPtr.Zero)
    {
      *(int*) obj1 = 3104258;
      return obj1;
    }
    if (offset >= 0L && *(long*) ((IntPtr) obj0 + 16) >= (long) size + offset)
    {
      int num1 = *(int*) ((IntPtr) obj0 + 4);
      int num2 = num1;
      Result result;
      ref Result local = ref result;
      long num3 = *(long*) ((IntPtr) obj0 + 8) + offset;
      void* voidPtr = buffer;
      int num4 = (int) size;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num5 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num1 + 8))((uint) num2, (void*) ref local, num3, (Result*) voidPtr, (IntPtr) num4);
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, num5, 4);
      return obj1;
    }
    *(int*) obj1 = 1538562;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efs\u002ESubStorage\u002EFlush([In] SubStorage* obj0, [In] Result* obj1)
  {
    int num1 = *(int*) ((IntPtr) obj0 + 4);
    int num2 = num1;
    Result result;
    ref Result local = ref result;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num3 = (int) __calli((__FnPtr<Result* (IntPtr, Result*)>) *(int*) (*(int*) num1 + 12))((Result*) num2, (IntPtr) ref local);
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, num3, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efs\u002ESubStorage\u002EGetSize([In] SubStorage* obj0, [In] Result* obj1, long* outValue)
  {
    *outValue = *(long*) ((IntPtr) obj0 + 16);
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efs\u002ESubStorage\u002EOperateRange([In] SubStorage* obj0, [In] Result* obj1, IStorage.OperationId operationId, long offset, long size)
  {
    if (offset >= 0L && *(long*) ((IntPtr) obj0 + 16) >= offset + size)
    {
      int num1 = *(int*) ((IntPtr) obj0 + 4);
      int num2 = num1;
      Result result;
      ref Result local = ref result;
      long num3 = (long) operationId;
      long num4 = *(long*) ((IntPtr) obj0 + 8) + offset;
      long num5 = size;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num6 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, IStorage.OperationId, long, long)>) *(int*) (*(int*) num1 + 24))((long) num2, (long) ref local, (IStorage.OperationId) num3, (Result*) num4, (IntPtr) num5);
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, num6, 4);
      return obj1;
    }
    *(int*) obj1 = 1538562;
    return obj1;
  }

  internal static unsafe void* nn\u002Efs\u002ESubStorage\u002E__vecDelDtor([In] SubStorage* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      SubStorage* subStoragePtr1 = (SubStorage*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 32U, (uint) *(int*) subStoragePtr1, (__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002ESubStorage\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        if (((int) A_0 & 4) == 0)
        {
          SubStorage* subStoragePtr2 = subStoragePtr1;
          int num = *(int*) subStoragePtr2 * 32 + 4;
          \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EDeallocate((void*) subStoragePtr2, (uint) num);
        }
        else
        {
          SubStorage* subStoragePtr2 = subStoragePtr1;
          int num = *(int*) subStoragePtr2 * 32 + 4;
          \u003CModule\u003E.delete\u005B\u005D((void*) subStoragePtr2, (uint) num);
        }
      }
      return (void*) subStoragePtr1;
    }
    // ISSUE: fault handler
    try
    {
      uint num = (uint) *(int*) ((IntPtr) obj0 + 24 + 4);
      if (num != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
    {
      if (((int) A_0 & 4) == 0)
        \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EDeallocate((void*) obj0, 32U);
      else
        \u003CModule\u003E.delete((void*) obj0, 32U);
    }
    return (void*) obj0;
  }

  internal static unsafe void nn\u002Efs\u002ESubStorage\u002E\u007Bdtor\u007D([In] SubStorage* obj0)
  {
    // ISSUE: fault handler
    try
    {
      uint num = (uint) *(int*) ((IntPtr) obj0 + 24 + 4);
      if (num != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  }

  internal static unsafe IStorage* nn\u002Efs\u002EIStorage\u002E\u007Bctor\u007D([In] IStorage* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    return obj0;
  }

  internal static int nn\u002Efssystem\u002Edbm\u002E\u003FA0x9604d1c5\u002ECountLeadingZeros(uint bits)
  {
    return \u003CModule\u003E.nn\u002Eutil\u002Ecntl0\u003Cunsigned\u0020int\u003E(bits);
  }

  [SpecialName]
  internal static unsafe runtime_error* std\u002Eruntime_error\u002E\u007Bctor\u007D([In] runtime_error* obj0, runtime_error* A_0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    runtime_error* runtimeErrorPtr = (runtime_error*) ((IntPtr) obj0 + 4);
    // ISSUE: initblk instruction
    __memset((IntPtr) runtimeErrorPtr, 0, 8);
    \u003CModule\u003E.__std_exception_copy((__std_exception_data*) ((IntPtr) A_0 + 4), (__std_exception_data*) runtimeErrorPtr);
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7runtime_error\u0040std\u0040\u00406B\u0040;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eexception\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  [SpecialName]
  internal static unsafe locale* std\u002Elocale\u002E\u007Bctor\u007D([In] locale* obj0, locale* _Right)
  {
    int num1 = *(int*) ((IntPtr) _Right + 4);
    *(int*) ((IntPtr) obj0 + 4) = num1;
    int num2 = num1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    __calli((__FnPtr<void (IntPtr)>) *(int*) (*(int*) num2 + 4))((IntPtr) num2);
    return obj0;
  }

  internal static unsafe void* std\u002E_System_error\u002E__vecDelDtor([In] _System_error* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      _System_error* systemErrorPtr1 = (_System_error*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 20U, (uint) *(int*) systemErrorPtr1, (__FnPtr<void (void*)>) __methodptr(std\u002E_System_error\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        _System_error* systemErrorPtr2 = systemErrorPtr1;
        int num = *(int*) systemErrorPtr2 * 20 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) systemErrorPtr2, (uint) num);
      }
      return (void*) systemErrorPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 20U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002E_System_error\u002E\u007Bdtor\u007D([In] _System_error* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
  }

  internal static unsafe void* std\u002Esystem_error\u002E__vecDelDtor([In] system_error* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      system_error* systemErrorPtr1 = (system_error*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 20U, (uint) *(int*) systemErrorPtr1, (__FnPtr<void (void*)>) __methodptr(std\u002Esystem_error\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        system_error* systemErrorPtr2 = systemErrorPtr1;
        int num = *(int*) systemErrorPtr2 * 20 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) systemErrorPtr2, (uint) num);
      }
      return (void*) systemErrorPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 20U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002Esystem_error\u002E\u007Bdtor\u007D([In] system_error* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
  }

  internal static unsafe void* std\u002Eios_base\u002Efailure\u002E__vecDelDtor([In] ios_base.failure* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      ios_base.failure* failurePtr1 = (ios_base.failure*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 20U, (uint) *(int*) failurePtr1, (__FnPtr<void (void*)>) __methodptr(std\u002Eios_base\u002Efailure\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        ios_base.failure* failurePtr2 = failurePtr1;
        int num = *(int*) failurePtr2 * 20 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) failurePtr2, (uint) num);
      }
      return (void*) failurePtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 20U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002Eios_base\u002Efailure\u002E\u007Bdtor\u007D([In] ios_base.failure* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    \u003CModule\u003E.__std_exception_destroy((__std_exception_data*) ((IntPtr) obj0 + 4));
  }

  [SpecialName]
  internal static unsafe ios_base.failure* std\u002Eios_base\u002Efailure\u002E\u007Bctor\u007D([In] ios_base.failure* obj0, ios_base.failure* A_0)
  {
    \u003CModule\u003E.std\u002E_System_error\u002E\u007Bctor\u007D((_System_error*) obj0, (_System_error*) A_0);
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7system_error\u0040std\u0040\u00406B\u0040;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_System_error\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7failure\u0040ios_base\u0040std\u0040\u00406B\u0040;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Esystem_error\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  [SpecialName]
  internal static unsafe system_error* std\u002Esystem_error\u002E\u007Bctor\u007D([In] system_error* obj0, system_error* A_0)
  {
    \u003CModule\u003E.std\u002E_System_error\u002E\u007Bctor\u007D((_System_error*) obj0, (_System_error*) A_0);
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7system_error\u0040std\u0040\u00406B\u0040;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_System_error\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  [SpecialName]
  internal static unsafe _System_error* std\u002E_System_error\u002E\u007Bctor\u007D([In] _System_error* obj0, _System_error* A_0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    _System_error* systemErrorPtr = (_System_error*) ((IntPtr) obj0 + 4);
    // ISSUE: initblk instruction
    __memset((IntPtr) systemErrorPtr, 0, 8);
    \u003CModule\u003E.__std_exception_copy((__std_exception_data*) ((IntPtr) A_0 + 4), (__std_exception_data*) systemErrorPtr);
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7runtime_error\u0040std\u0040\u00406B\u0040;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eexception\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_System_error\u0040std\u0040\u00406B\u0040;
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj0 + 12, (IntPtr) A_0 + 12, 8);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eruntime_error\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static uint nn\u002Efssystem\u002Esave\u002EILog2(uint x)
  {
    return (uint) (31 - \u003CModule\u003E.nn\u002Eutil\u002Ecntl0\u003Cunsigned\u0020int\u003E(x));
  }

  [SpecialName]
  internal static unsafe nn.fssystem.save.Path* nn\u002Efssystem\u002Esave\u002EPath\u002E\u007Bctor\u007D([In] nn.fssystem.save.Path* obj0, nn.fssystem.save.Path* rhs)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) rhs, 769);
    return obj0;
  }

  internal static unsafe void nn\u002Efssystem\u002EIBufferManager\u002E\u007Bdtor\u007D([In] IBufferManager* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
  }

  internal static unsafe void* nn\u002Efssystem\u002EIBufferManager\u002E__vecDelDtor([In] IBufferManager* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      IBufferManager* ibufferManagerPtr1 = (IBufferManager*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 4U, (uint) *(int*) ibufferManagerPtr1, (__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EIBufferManager\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        IBufferManager* ibufferManagerPtr2 = ibufferManagerPtr1;
        int num = *(int*) ibufferManagerPtr2 * 4 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) ibufferManagerPtr2, (uint) num);
      }
      return (void*) ibufferManagerPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 4U);
    return (void*) obj0;
  }

  internal static unsafe FileSystemBuddyHeap* nn\u002Efssystem\u002EFileSystemBuddyHeap\u002E\u007Bctor\u007D([In] FileSystemBuddyHeap* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    *(int*) ((IntPtr) obj0 + 12) = 0;
    *(int*) ((IntPtr) obj0 + 16) = 0;
    *(int*) ((IntPtr) obj0 + 20) = 0;
    *(int*) ((IntPtr) obj0 + 24) = 0;
    return obj0;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EFileSystemBuddyHeap\u002EInitialize([In] FileSystemBuddyHeap* obj0, [In] Result* obj1, uint addr, uint size, uint blockSize)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBuddyHeap\u002EInitialize(obj0, obj1, addr, size, blockSize, \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBuddyHeap\u002EQueryOrderMax(size, blockSize));
    return obj1;
  }

  internal static unsafe FileSystemBufferManager* nn\u002Efssystem\u002EFileSystemBufferManager\u002E\u007Bctor\u007D([In] FileSystemBufferManager* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7FileSystemBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
      \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBuddyHeap\u002E\u007Bctor\u007D((FileSystemBuddyHeap*) ((IntPtr) obj0 + 4));
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBufferManager\u002ECacheHandleTable\u002E\u007Bctor\u007D((FileSystemBufferManager.CacheHandleTable*) ((IntPtr) obj0 + 32));
        // ISSUE: fault handler
        try
        {
          *(int*) ((IntPtr) obj0 + 96) = 0;
          \u003CModule\u003E.nn\u002Eos\u002EInitializeMutex((MutexType*) ((IntPtr) obj0 + 100), true, 0);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EFileSystemBufferManager\u002ECacheHandleTable\u002E\u007Bdtor\u007D), (void*) ((IntPtr) obj0 + 32));
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EFileSystemBuddyHeap\u002E\u007Bdtor\u007D), (void*) ((IntPtr) obj0 + 4));
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EIBufferManager\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void nn\u002Efssystem\u002EFileSystemBufferManager\u002E\u007Bdtor\u007D([In] FileSystemBufferManager* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7FileSystemBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      // ISSUE: fault handler
      try
      {
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.nn\u002Eos\u002EFinalizeMutex((MutexType*) ((IntPtr) obj0 + 100));
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EFileSystemBufferManager\u002ECacheHandleTable\u002E\u007Bdtor\u007D), (void*) ((IntPtr) obj0 + 32));
        }
        \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBufferManager\u002ECacheHandleTable\u002E\u007Bdtor\u007D((FileSystemBufferManager.CacheHandleTable*) ((IntPtr) obj0 + 32));
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EFileSystemBuddyHeap\u002E\u007Bdtor\u007D), (void*) ((IntPtr) obj0 + 4));
      }
      int num = *(int*) ((IntPtr) obj0 + 4 + 24);
      if (num != 0)
        \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EDeallocate((void*) num, 12U);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EIBufferManager\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EFileSystemBufferManager\u002EInitialize([In] FileSystemBufferManager* obj0, [In] Result* obj1, int cacheCountMax, uint address, uint bufferSize, uint blockSize)
  {
    Result result1;
    \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBufferManager\u002ECacheHandleTable\u002EInitialize((FileSystemBufferManager.CacheHandleTable*) ((IntPtr) obj0 + 32), &result1, cacheCountMax);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      Result result2;
      \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBuddyHeap\u002EInitialize((FileSystemBuddyHeap*) ((IntPtr) obj0 + 4), &result2, address, bufferSize, blockSize, \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBuddyHeap\u002EQueryOrderMax(bufferSize, blockSize));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 == 0)
      {
        *(int*) ((IntPtr) obj0 + 96) = (int) \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBuddyHeap\u002EGetTotalFreeSize((FileSystemBuddyHeap*) ((IntPtr) obj0 + 4));
        *(int*) obj1 = 0;
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result2, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe void* nn\u002Efssystem\u002EFileSystemBufferManager\u002E__vecDelDtor([In] FileSystemBufferManager* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      FileSystemBufferManager* systemBufferManagerPtr1 = (FileSystemBufferManager*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 144U, (uint) *(int*) systemBufferManagerPtr1, (__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EFileSystemBufferManager\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        FileSystemBufferManager* systemBufferManagerPtr2 = systemBufferManagerPtr1;
        int num = *(int*) systemBufferManagerPtr2 * 144 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) systemBufferManagerPtr2, (uint) num);
      }
      return (void*) systemBufferManagerPtr1;
    }
    \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBufferManager\u002E\u007Bdtor\u007D(obj0);
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 144U);
    return (void*) obj0;
  }

  internal static unsafe IBufferManager* nn\u002Efssystem\u002EIBufferManager\u002E\u007Bctor\u007D([In] IBufferManager* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IBufferManager\u0040fssystem\u0040nn\u0040\u00406B\u0040;
    return obj0;
  }

  internal static unsafe void nn\u002Efssystem\u002EFileSystemBuddyHeap\u002E\u007Bdtor\u007D([In] FileSystemBuddyHeap* obj0)
  {
    int num = *(int*) ((IntPtr) obj0 + 24);
    if (num == 0)
      return;
    \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EDeallocate((void*) num, 12U);
  }

  internal static unsafe long nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationInformation\u002EGetDataOffset([In] HierarchicalIntegrityVerificationInformation* obj0)
  {
    HierarchicalIntegrityVerificationInformation* verificationInformationPtr = obj0;
    int num = *(int*) verificationInformationPtr * 24;
    nn.fs.Int64* int64Ptr = (nn.fs.Int64*) ((IntPtr) verificationInformationPtr + num - 44);
    return (long) (uint) *(int*) ((IntPtr) int64Ptr + 4) << 32 | (long) (uint) *(int*) int64Ptr;
  }

  internal static unsafe long nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationInformation\u002EGetDataSize([In] HierarchicalIntegrityVerificationInformation* obj0)
  {
    HierarchicalIntegrityVerificationInformation* verificationInformationPtr = obj0;
    int num = *(int*) verificationInformationPtr * 24;
    nn.fs.Int64* int64Ptr = (nn.fs.Int64*) ((IntPtr) verificationInformationPtr + num - 36);
    return (long) (uint) *(int*) ((IntPtr) int64Ptr + 4) << 32 | (long) (uint) *(int*) int64Ptr;
  }

  internal static unsafe HierarchicalIntegrityVerificationStorageControlArea* nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorageControlArea\u002E\u007Bctor\u007D([In] HierarchicalIntegrityVerificationStorageControlArea* obj0)
  {
    \u003CModule\u003E.nn\u002Efs\u002ESubStorage\u002E\u007Bctor\u007D((SubStorage*) obj0);
    return obj0;
  }

  internal static unsafe void nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorageControlArea\u002EGetLevelHashInfo([In] HierarchicalIntegrityVerificationStorageControlArea* obj0, HierarchicalIntegrityVerificationInformation* outInfo)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) outInfo, (IntPtr) obj0 + 44, 180);
  }

  internal static unsafe Result* nn\u002Efssystem\u002EIntegrityRomFsStorage\u002ECommit([In] IntegrityRomFsStorage* obj0, [In] Result* obj1)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorage\u002ECommit((nn.fssystem.save.HierarchicalIntegrityVerificationStorage*) ((IntPtr) obj0 + 8), obj1);
    return obj1;
  }

  internal static unsafe void \u003FA0x9604d1c5\u002EGenerateRandomForAuthoringTool(void* pData, uint size)
  {
    // ISSUE: initblk instruction
    __memset((IntPtr) pData, 0, (int) size);
  }

  internal static unsafe RomFsStorage* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsStorage\u002E\u007Bctor\u007D([In] RomFsStorage* obj0, long bufferSize)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7RomFsStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
      *(long*) ((IntPtr) obj0 + 8) = bufferSize;
      byte* numPtr1 = (byte*) \u003CModule\u003E.new\u005B\u005D((uint) (int) bufferSize);
      *(int*) ((IntPtr) obj0 + 16) = (int) numPtr1;
      byte* numPtr2 = (byte*) ((int) bufferSize + (IntPtr) numPtr1);
      if (numPtr1 != numPtr2)
      {
        // ISSUE: initblk instruction
        __memset((IntPtr) numPtr1, 0, (IntPtr) numPtr2 - (IntPtr) numPtr1);
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsStorage\u002E\u007Bdtor\u007D([In] RomFsStorage* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7RomFsStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.delete((void*) *(int*) ((IntPtr) obj0 + 16), 1U);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  }

  internal static unsafe Result* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsStorage\u002ERead([In] RomFsStorage* obj0, [In] Result* obj1, long offset, void* buffer, uint size)
  {
    if (offset >= 0L && *(long*) ((IntPtr) obj0 + 8) >= (long) size + offset)
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) buffer, (int) offset + *(int*) ((IntPtr) obj0 + 16), (int) size);
      *(int*) obj1 = 0;
      return obj1;
    }
    *(int*) obj1 = 1538562;
    return obj1;
  }

  internal static unsafe Result* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsStorage\u002EWrite([In] RomFsStorage* obj0, [In] Result* obj1, long offset, void* buffer, uint size)
  {
    if (offset >= 0L && *(long*) ((IntPtr) obj0 + 8) >= (long) size + offset)
    {
      // ISSUE: cpblk instruction
      __memcpy((int) offset + *(int*) ((IntPtr) obj0 + 16), (IntPtr) buffer, (int) size);
      *(int*) obj1 = 0;
      return obj1;
    }
    *(int*) obj1 = 1538562;
    return obj1;
  }

  internal static unsafe Result* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsStorage\u002EFlush([In] RomFsStorage* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsStorage\u002EGetSize([In] RomFsStorage* obj0, [In] Result* obj1, long* outValue)
  {
    *outValue = *(long*) ((IntPtr) obj0 + 8);
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe void* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsStorage\u002E__vecDelDtor([In] RomFsStorage* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      RomFsStorage* romFsStoragePtr1 = (RomFsStorage*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 24U, (uint) *(int*) romFsStoragePtr1, (__FnPtr<void (void*)>) __methodptr(Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsStorage\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        RomFsStorage* romFsStoragePtr2 = romFsStoragePtr1;
        int num = *(int*) romFsStoragePtr2 * 24 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) romFsStoragePtr2, (uint) num);
      }
      return (void*) romFsStoragePtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7RomFsStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.delete((void*) *(int*) ((IntPtr) obj0 + 16), 1U);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 24U);
    return (void*) obj0;
  }

  internal static unsafe DummyStorage* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDummyStorage\u002E\u007Bctor\u007D([In] DummyStorage* obj0, byte* buffer, long bufferSize)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7DummyStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
      *(int*) ((IntPtr) obj0 + 4) = (int) buffer;
      *(long*) ((IntPtr) obj0 + 8) = bufferSize;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDummyStorage\u002E\u007Bdtor\u007D([In] DummyStorage* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7DummyStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  }

  internal static unsafe Result* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDummyStorage\u002ERead([In] DummyStorage* obj0, [In] Result* obj1, long offset, void* buffer, uint size)
  {
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDummyStorage\u002EWrite([In] DummyStorage* obj0, [In] Result* obj1, long offset, void* buffer, uint size)
  {
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDummyStorage\u002EFlush([In] DummyStorage* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDummyStorage\u002EGetSize([In] DummyStorage* obj0, [In] Result* obj1, long* outValue)
  {
    *outValue = *(long*) ((IntPtr) obj0 + 8);
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe void* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDummyStorage\u002E__vecDelDtor([In] DummyStorage* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      DummyStorage* dummyStoragePtr1 = (DummyStorage*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 16U, (uint) *(int*) dummyStoragePtr1, (__FnPtr<void (void*)>) __methodptr(Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDummyStorage\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        DummyStorage* dummyStoragePtr2 = dummyStoragePtr1;
        int num = *(int*) dummyStoragePtr2 * 16 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) dummyStoragePtr2, (uint) num);
      }
      return (void*) dummyStoragePtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7DummyStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 16U);
    return (void*) obj0;
  }

  internal static unsafe void nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorageControlArea\u002E\u007Bdtor\u007D([In] HierarchicalIntegrityVerificationStorageControlArea* obj0)
  {
    // ISSUE: fault handler
    try
    {
      uint num = (uint) *(int*) ((IntPtr) obj0 + 24 + 4);
      if (num != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  }

  internal static unsafe void std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E* obj0)
  {
    int num = *(int*) obj0;
    if (num == 0)
      return;
    \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EDeallocate((void*) num, 12U);
  }

  internal static unsafe unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E* std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E* obj0, void* A_0)
  {
    *(int*) obj0 = 0;
    return obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  [SpecialName]
  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* _Other)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AIStorage\u003E((_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) obj0, (_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) _Other);
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C6300\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C6300\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 3225602;
    return obj1;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C6063\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C6063\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 3104258;
    return obj1;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C3005\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C3005\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 1538562;
    return obj1;
  }

  internal static unsafe void std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0)
  {
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(obj0, true, 0U);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
    }
  }

  [SpecialName]
  internal static unsafe basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Right)
  {
    // ISSUE: fault handler
    try
    {
      *(int*) ((IntPtr) obj0 + 16) = 0;
      *(int*) ((IntPtr) obj0 + 20) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(obj0, false, 0U);
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eassign(obj0, _Right, 0U, uint.MaxValue);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
  }

  internal static unsafe void std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E\u002E\u007Bdtor\u007D([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
  }

  internal static unsafe void std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E* obj0)
  {
  }

  internal static unsafe void std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E\u002E_Delete([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E* obj0)
  {
    int num = *(int*) obj0;
    if (num == 0)
      return;
    \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EDeallocate((void*) num, 12U);
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Decref([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe void std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D([In] _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E._Bxty* obj0)
  {
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eselect_on_container_copy_construction([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, [In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj1, _Nil A_0)
  {
    return obj1;
  }

  internal static unsafe uint* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E_Mysize([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (uint*) ((IntPtr) obj0 + 16);
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E_Getal([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E_Getal([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe sbyte* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E_Myptr([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    if (16U <= (uint) *(int*) ((IntPtr) obj0 + 20))
      return (sbyte*) *(int*) obj0;
    return (sbyte*) obj0;
  }

  internal static unsafe sbyte* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E_Myptr([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    if (16U <= (uint) *(int*) ((IntPtr) obj0 + 20))
      return (sbyte*) *(int*) obj0;
    return (sbyte*) obj0;
  }

  internal static unsafe void std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, [MarshalAs(UnmanagedType.U1)] bool _Built, uint _Newsize)
  {
    if (_Built && 16U <= (uint) *(int*) ((IntPtr) obj0 + 20))
    {
      sbyte* numPtr = (sbyte*) *(int*) obj0;
      if (0U < _Newsize)
      {
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) obj0, (IntPtr) numPtr, (int) _Newsize);
      }
      \u003CModule\u003E.std\u002E_Deallocate((void*) numPtr, (uint) (*(int*) ((IntPtr) obj0 + 20) + 1), 1U);
    }
    *(int*) ((IntPtr) obj0 + 20) = 15;
    *(int*) ((IntPtr) obj0 + 16) = (int) _Newsize;
    *(sbyte*) ((int) _Newsize + (IntPtr) obj0) = (sbyte) 0;
  }

  internal static basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eassign([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Right, uint _Roff, uint _Count)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static unsafe default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E* std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E\u002Eget_deleter([In] _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E* obj0)
  {
    return (default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E*) obj0;
  }

  internal static unsafe FileSystemBuddyHeap.PageList* std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E\u002Eget([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E* obj0)
  {
    return (FileSystemBuddyHeap.PageList*) *(int*) obj0;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe sbyte* std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Myptr([In] _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E* obj0)
  {
    if (16U <= (uint) *(int*) ((IntPtr) obj0 + 20))
      return (sbyte*) *(int*) obj0;
    return (sbyte*) obj0;
  }

  internal static unsafe sbyte* std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Myptr([In] _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E* obj0)
  {
    if (16U <= (uint) *(int*) ((IntPtr) obj0 + 20))
      return (sbyte*) *(int*) obj0;
    return (sbyte*) obj0;
  }

  internal static unsafe allocator\u003Cchar\u003E* std\u002Eallocator_traits\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eselect_on_container_copy_construction([In] allocator\u003Cchar\u003E* obj0, allocator\u003Cchar\u003E* _Al)
  {
    return obj0;
  }

  internal static unsafe void std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Edeallocate([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, sbyte* _Ptr, uint _Count)
  {
    \u003CModule\u003E.std\u002E_Deallocate((void*) _Ptr, _Count, 1U);
  }

  internal static unsafe uint* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E_Myres([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (uint*) ((IntPtr) obj0 + 20);
  }

  internal static unsafe uint* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E_Mysize([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (uint*) ((IntPtr) obj0 + 16);
  }

  internal static unsafe _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E._Bxty* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E_Bx([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E._Bxty*) obj0;
  }

  internal static unsafe _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E_Get_data([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E_Get_data([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe void std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Check_offset([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, uint _Off)
  {
    if ((uint) *(int*) ((IntPtr) obj0 + 16) >= _Off)
      return;
    \u003CModule\u003E.std\u002E_Xout_of_range((sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_0BI\u0040CFPLBAOH\u0040invalid\u003F5string\u003F5position\u003F\u0024AA\u0040);
  }

  internal static unsafe void std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Xlen([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0)
  {
    \u003CModule\u003E.std\u002E_Xlength_error((sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_0BA\u0040JFNIOLAK\u0040string\u003F5too\u003F5long\u003F\u0024AA\u0040);
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Grow([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, uint _Newsize, [MarshalAs(UnmanagedType.U1)] bool _Trim)
  {
    if (4294967294U < _Newsize)
      \u003CModule\u003E.std\u002E_Xlength_error((sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_0BA\u0040JFNIOLAK\u0040string\u003F5too\u003F5long\u003F\u0024AA\u0040);
    uint num1 = (uint) *(int*) ((IntPtr) obj0 + 20);
    if (num1 < _Newsize)
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Copy(obj0, _Newsize, (uint) *(int*) ((IntPtr) obj0 + 16));
    else if (_Trim && _Newsize < 16U)
    {
      uint num2 = (uint) *(int*) ((IntPtr) obj0 + 16);
      uint _Newsize1 = _Newsize < num2 ? _Newsize : num2;
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(obj0, true, _Newsize1);
    }
    else if (_Newsize == 0U)
    {
      *(int*) ((IntPtr) obj0 + 16) = 0;
      *(16U > num1 ? (sbyte*) (ValueType) (IntPtr) obj0 : (sbyte*) (ValueType) *(int*) obj0) = (sbyte) 0;
      goto label_10;
    }
    int num3;
    if (0U < _Newsize)
    {
      num3 = 1;
      goto label_11;
    }
label_10:
    num3 = 0;
label_11:
    return num3 != 0;
  }

  internal static void std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Eos([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, uint _Newsize)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static unsafe uint std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Clamp_suffix_size([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, uint _Off, uint _Size)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 16) - _Off;
    if (_Size > num)
      return num;
    return _Size;
  }

  internal static basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eerase([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, uint _Off, uint _Count)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eerase([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, uint _Off)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static unsafe default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u002A\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u002A\u002C1\u003E* obj0)
  {
    return (default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E*) obj0;
  }

  internal static unsafe FileSystemBuddyHeap.PageList** std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E\u002E_Myptr([In] _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E* obj0)
  {
    return (FileSystemBuddyHeap.PageList**) obj0;
  }

  internal static unsafe _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe void std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Xran([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0)
  {
    \u003CModule\u003E.std\u002E_Xout_of_range((sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_0BI\u0040CFPLBAOH\u0040invalid\u003F5string\u003F5position\u003F\u0024AA\u0040);
  }

  internal static void std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Copy([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, uint _Newsize, uint _Oldlen)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static unsafe uint std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Emax_size([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0)
  {
    return 4294967294;
  }

  [SpecialName]
  internal static unsafe allocator\u003Cwchar_t\u003E* std\u002Eallocator\u003Cwchar_t\u003E\u002E\u007Bctor\u007D([In] allocator\u003Cwchar_t\u003E* obj0, allocator\u003Cwchar_t\u003E* A_0)
  {
    return obj0;
  }

  internal static unsafe void std\u002Eallocator\u003Cchar\u003E\u002Edeallocate([In] allocator\u003Cchar\u003E* obj0, sbyte* _Ptr, uint _Count)
  {
    \u003CModule\u003E.std\u002E_Deallocate((void*) _Ptr, _Count, 1U);
  }

  [SpecialName]
  internal static unsafe allocator\u003Cchar\u003E* std\u002Eallocator\u003Cchar\u003E\u002E\u007Bctor\u007D([In] allocator\u003Cchar\u003E* obj0, allocator\u003Cchar\u003E* A_0)
  {
    return obj0;
  }

  internal static unsafe FileSystemBuddyHeap.PageList** std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u002A\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u002A\u002C1\u003E* obj0)
  {
    return (FileSystemBuddyHeap.PageList**) obj0;
  }

  internal static unsafe uint std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Emax_size([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, _Nil A_0)
  {
    return uint.MaxValue;
  }

  internal static unsafe sbyte* std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eallocate([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, uint _Count)
  {
    return (sbyte*) \u003CModule\u003E.std\u002E_Allocate(_Count, 1U, true);
  }

  internal static unsafe uint std\u002Eallocator_traits\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Emax_size(allocator\u003Cchar\u003E* _Al)
  {
    return uint.MaxValue;
  }

  internal static unsafe sbyte* std\u002Eallocator\u003Cchar\u003E\u002Eallocate([In] allocator\u003Cchar\u003E* obj0, uint _Count)
  {
    return (sbyte*) \u003CModule\u003E.std\u002E_Allocate(_Count, 1U, true);
  }

  internal static unsafe uint std\u002Eallocator\u003Cchar\u003E\u002Emax_size([In] allocator\u003Cchar\u003E* obj0)
  {
    return uint.MaxValue;
  }

  internal static int nn\u002Eutil\u002Ecntl0\u003Cunsigned\u0020int\u003E(uint x)
  {
    int num1 = (int) x;
    x = (uint) num1 | (uint) num1 >> 1;
    int num2 = (int) x;
    x = (uint) num2 | (uint) num2 >> 2;
    int num3 = (int) x;
    x = (uint) num3 | (uint) num3 >> 4;
    int num4 = (int) x;
    x = (uint) num4 | (uint) num4 >> 8;
    int num5 = (int) x;
    x = (uint) num5 | (uint) num5 >> 16;
    return \u003CModule\u003E.nn\u002Eutil\u002Epopcount\u003Cunsigned\u0020int\u003E(~x);
  }

  internal static unsafe ResultAutoConverter\u003Cnn\u003A\u003AResult\u003E* nn\u002Eresult\u002Edetail\u002EMakeResultAutoConverter\u003Cclass\u0020nn\u003A\u003AResult\u003E([In] ResultAutoConverter\u003Cnn\u003A\u003AResult\u003E* obj0, Result* result, void* __unnamed001)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 4);
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultAutoConverter\u003Cnn\u003A\u003AResult\u003E\u002Eoperator\u003Cclass\u0020nn\u003A\u003AResult\u003E([In] ResultAutoConverter\u003Cnn\u003A\u003AResult\u003E* obj0, [In] Result* obj1)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, (IntPtr) obj0, 4);
    return obj1;
  }

  internal static unsafe void std\u002Efill\u003Cunsigned\u0020char\u0020\u002A\u002Cint\u003E(byte* _First, byte* _Last, int* _Val)
  {
    byte* numPtr = _First;
    if (_First == _Last)
      return;
    do
    {
      *numPtr = (byte) *_Val;
      ++numPtr;
    }
    while (numPtr != _Last);
  }

  internal static unsafe _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E* std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u002A\u003E([In] _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u0020\u003E* obj0, FileSystemBuddyHeap.PageList* _Ptr)
  {
    *(int*) obj0 = (int) _Ptr;
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AIStorage\u003E([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* _Other)
  {
    _Ref_count_base* refCountBasePtr = (_Ref_count_base*) *(int*) ((IntPtr) _Other + 4);
    IStorage* istoragePtr = (IStorage*) *(int*) _Other;
    if ((IntPtr) refCountBasePtr != IntPtr.Zero)
    {
      // ISSUE: cast to a reference type
      Interlocked.Increment((int&) ((IntPtr) refCountBasePtr + 4));
    }
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) refCountBasePtr;
    *(int*) obj0 = (int) istoragePtr;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Emove\u003Cstruct\u0020std\u003A\u003A_Wrap_alloc\u003Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u0026\u003E(_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003Cstruct\u0020std\u003A\u003A_Wrap_alloc\u003Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cvoid\u003E([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Al)
  {
    // ISSUE: fault handler
    try
    {
      *(int*) ((IntPtr) obj0 + 16) = 0;
      *(int*) ((IntPtr) obj0 + 20) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void std\u002Edefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u002Eoperator\u0028\u0029\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u002Cvoid\u003E([In] default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E* obj0, FileSystemBuddyHeap.PageList* _Ptr)
  {
    \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EDeallocate((void*) _Ptr, 12U);
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, allocator\u003Cchar\u003E* _Right)
  {
    return obj0;
  }

  internal static unsafe sbyte** std\u002Eaddressof\u003Cchar\u0020\u002A\u003E(sbyte** _Val)
  {
    return _Val;
  }

  internal static unsafe void std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Edestroy\u003Cchar\u0020\u002A\u003E([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, sbyte** _Ptr)
  {
  }

  internal static unsafe sbyte* std\u002E_Unfancy\u003Cchar\u003E(sbyte* _Ptr)
  {
    return _Ptr;
  }

  internal static unsafe void std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Econstruct\u003Cchar\u0020\u002A\u002Cchar\u0020\u002A\u0020\u0026\u003E([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, sbyte** _Ptr, sbyte** _param2)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    *(int*) _Ptr = *(int*) _param2;
  }

  [SpecialName]
  internal static unsafe bad_cast* std\u002Ebad_cast\u002E\u007Bctor\u007D([In] bad_cast* obj0, bad_cast* A_0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7exception\u0040std\u0040\u00406B\u0040;
    bad_cast* badCastPtr = (bad_cast*) ((IntPtr) obj0 + 4);
    // ISSUE: initblk instruction
    __memset((IntPtr) badCastPtr, 0, 8);
    \u003CModule\u003E.__std_exception_copy((__std_exception_data*) ((IntPtr) A_0 + 4), (__std_exception_data*) badCastPtr);
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7bad_cast\u0040std\u0040\u00406B\u0040;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eexception\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultToReturnTypeConverter\u003Cnn\u003A\u003AResult\u002Cnn\u003A\u003AResult\u002Cvoid\u003E\u002EConvert([In] Result* obj0, Result* result)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 4);
    return obj0;
  }

  internal static unsafe ResultAutoConverter\u003Cnn\u003A\u003AResult\u003E* nn\u002Eresult\u002Edetail\u002EResultAutoConverter\u003Cnn\u003A\u003AResult\u003E\u002E\u007Bctor\u007D([In] ResultAutoConverter\u003Cnn\u003A\u003AResult\u003E* obj0, Result* result)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 4);
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Reset([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, IStorage* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    if ((IntPtr) _Other_rep != IntPtr.Zero)
    {
      // ISSUE: cast to a reference type
      Interlocked.Increment((int&) ((IntPtr) _Other_rep + 4));
    }
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E* std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E* obj0)
  {
    // ISSUE: fault handler
    try
    {
      *(int*) ((IntPtr) obj0 + 16) = 0;
      *(int*) ((IntPtr) obj0 + 20) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Reset0([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, IStorage* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E._Bxty* std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bctor\u007D([In] _String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E._Bxty* obj0)
  {
    return obj0;
  }

  internal static int nn\u002Eutil\u002Epopcount\u003Cunsigned\u0020int\u003E(uint x)
  {
    uint num1;
    // ISSUE: cpblk instruction
    __memcpy(ref num1, ref x, 4);
    int num2 = (int) num1;
    uint num3 = (uint) (num2 - ((int) ((uint) num2 >> 1) & 1431655765));
    uint num4 = (uint) (((int) (num3 >> 2) & 858993459) + ((int) num3 & 858993459));
    uint num5 = (uint) ((int) (num4 >> 4) + (int) num4 & 252645135);
    uint num6 = (num5 >> 8) + num5;
    return (int) ((num6 >> 16) + num6) & (int) sbyte.MaxValue;
  }

  internal static unsafe byte* std\u002E_Unchecked\u003Cunsigned\u0020char\u0020\u002A\u003E(byte* _Src)
  {
    return _Src;
  }

  internal static unsafe void std\u002E_Fill_unchecked\u003Cunsigned\u0020char\u0020\u002A\u002Cint\u003E(byte* _First, byte* _Last, int* _Val)
  {
    byte* numPtr = _First;
    if (_First == _Last)
      return;
    do
    {
      *numPtr = (byte) *_Val;
      ++numPtr;
    }
    while (numPtr != _Last);
  }

  internal static unsafe _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u002A\u002C1\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u002A\u002C1\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u002A\u0020\u0026\u003E([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u005B0\u005D\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u002A\u002C1\u003E* obj0, _Zero_then_variadic_args_t __unnamed000, FileSystemBuddyHeap.PageList** _param2)
  {
    *(int*) obj0 = *(int*) _param2;
    return obj0;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Eforward\u003Cstruct\u0020std\u003A\u003A_Wrap_alloc\u003Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E(_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E\u002E\u007Bctor\u007D\u003Cstruct\u0020std\u003A\u003A_Wrap_alloc\u003Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E* obj0, _One_then_variadic_args_t __unnamed000, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Val1)
  {
    // ISSUE: fault handler
    try
    {
      *(int*) ((IntPtr) obj0 + 16) = 0;
      *(int*) ((IntPtr) obj0 + 20) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe allocator\u003Cchar\u003E* std\u002Eforward\u003Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E(allocator\u003Cchar\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe void std\u002Eallocator_traits\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Edestroy\u003Cchar\u0020\u002A\u003E(allocator\u003Cchar\u003E* _Al, sbyte** _Ptr)
  {
  }

  internal static unsafe sbyte** std\u002Eforward\u003Cchar\u0020\u002A\u0020\u0026\u003E(sbyte** _Arg)
  {
    return _Arg;
  }

  internal static unsafe void std\u002Eallocator_traits\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Econstruct\u003Cchar\u0020\u002A\u002Cchar\u0020\u002A\u0020\u0026\u003E(allocator\u003Cchar\u003E* _Al, sbyte** _Ptr, sbyte** _param2)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    *(int*) _Ptr = *(int*) _param2;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Right)
  {
    return obj0;
  }

  internal static unsafe integral_constant\u003Cbool\u002C0\u003E std\u002E_Fill_memset_is_safe\u003Cunsigned\u0020char\u0020\u002A\u002Cint\u003E(byte** A_0, int* A_1)
  {
    integral_constant\u003Cbool\u002C0\u003E integralConstantBool0_1;
    // ISSUE: initblk instruction
    __memset(ref integralConstantBool0_1, 0, 1);
    integral_constant\u003Cbool\u002C0\u003E integralConstantBool0_2;
    // ISSUE: cpblk instruction
    __memcpy(ref integralConstantBool0_2, ref integralConstantBool0_1, 1);
    return integralConstantBool0_2;
  }

  internal static unsafe void std\u002E_Fill_unchecked1\u003Cunsigned\u0020char\u0020\u002A\u002Cint\u003E(byte* _First, byte* _Last, int* _Val, integral_constant\u003Cbool\u002C0\u003E __unnamed003)
  {
    if (_First == _Last)
      return;
    do
    {
      *_First = (byte) *_Val;
      ++_First;
    }
    while (_First != _Last);
  }

  internal static unsafe FileSystemBuddyHeap.PageList** std\u002Eforward\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileSystemBuddyHeap\u003A\u003APageList\u0020\u002A\u0020\u0026\u003E(FileSystemBuddyHeap.PageList** _Arg)
  {
    return _Arg;
  }

  internal static unsafe void std\u002Eallocator\u003Cchar\u003E\u002Edestroy\u003Cchar\u0020\u002A\u003E([In] allocator\u003Cchar\u003E* obj0, sbyte** _Ptr)
  {
  }

  internal static unsafe void std\u002Eallocator\u003Cchar\u003E\u002Econstruct\u003Cchar\u0020\u002A\u002Cchar\u0020\u002A\u0020\u0026\u003E([In] allocator\u003Cchar\u003E* obj0, sbyte** _Ptr, sbyte** _param2)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    *(int*) _Ptr = *(int*) _param2;
  }

  internal static uint nn\u002Efssystem\u002ENcaHeader\u002EByteToSector(ulong @byte)
  {
    return (uint) (@byte >> 9);
  }

  internal static char* PtrToStringChars(string s)
  {
    // ISSUE: cast to a reference type
    // ISSUE: variable of a reference type
    byte* local = (byte*) s;
    if (local != null)
    {
      // ISSUE: cast to a reference type
      local = (byte*) (RuntimeHelpers.OffsetToStringData + (IntPtr) local);
    }
    // ISSUE: cast to a reference type
    return (char&) local;
  }

  internal static unsafe uint msclr\u002Einterop\u002Edetails\u002EGetAnsiStringSize(string _str)
  {
    // ISSUE: cast to a reference type
    // ISSUE: variable of a reference type
    byte* local = (byte*) _str;
    if (local != null)
    {
      // ISSUE: cast to a reference type
      local = (byte*) (RuntimeHelpers.OffsetToStringData + (IntPtr) local);
    }
    // ISSUE: explicit reference operation
    fixed (byte* numPtr = &^local)
    {
      uint multiByte = (uint) \u003CModule\u003E.WideCharToMultiByte(3U, 1024U, (char*) numPtr, _str.Length, (sbyte*) 0, 0, (sbyte*) 0, (int*) 0);
      if (multiByte == 0U && _str.Length != 0)
        throw new ArgumentException("Conversion from WideChar to MultiByte failed.  Please check the content of the string and/or locale settings.");
      return multiByte + 1U;
    }
  }

  internal static unsafe void msclr\u002Einterop\u002Edetails\u002EWriteAnsiString(sbyte* _buf, uint _size, string _str)
  {
    // ISSUE: cast to a reference type
    // ISSUE: variable of a reference type
    byte* local = (byte*) _str;
    if (local != null)
    {
      // ISSUE: cast to a reference type
      local = (byte*) (RuntimeHelpers.OffsetToStringData + (IntPtr) local);
    }
    // ISSUE: explicit reference operation
    fixed (byte* numPtr = &^local)
    {
      if (_size > (uint) int.MaxValue)
        throw new ArgumentOutOfRangeException("Size of string exceeds INT_MAX.");
      uint multiByte = (uint) \u003CModule\u003E.WideCharToMultiByte(3U, 1024U, (char*) numPtr, _str.Length, _buf, (int) _size, (sbyte*) 0, (int*) 0);
      if (multiByte >= _size || multiByte == 0U && _size != 1U)
        throw new ArgumentException("Conversion from WideChar to MultiByte failed.  Please check the content of the string and/or locale settings.");
      *(sbyte*) ((int) multiByte + (IntPtr) _buf) = (sbyte) 0;
    }
  }

  internal static unsafe NcaFsHeader* std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002Eget([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E* obj0)
  {
    return (NcaFsHeader*) *(int*) obj0;
  }

  internal static unsafe NcaFsHeader* std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002E\u002D\u003E([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E* obj0)
  {
    return (NcaFsHeader*) *(int*) obj0;
  }

  internal static unsafe void std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E* obj0)
  {
    int num = *(int*) obj0;
    if (num == 0)
      return;
    \u003CModule\u003E.delete((void*) num, 512U);
  }

  internal static unsafe unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E* std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E* obj0, NcaFsHeader* _Ptr)
  {
    *(int*) obj0 = (int) _Ptr;
    return obj0;
  }

  internal static unsafe NcaHeader* std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E\u002Eget([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E* obj0)
  {
    return (NcaHeader*) *(int*) obj0;
  }

  internal static unsafe NcaHeader* std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E\u002E\u002D\u003E([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E* obj0)
  {
    return (NcaHeader*) *(int*) obj0;
  }

  internal static unsafe void std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E* obj0)
  {
    int num = *(int*) obj0;
    if (num == 0)
      return;
    \u003CModule\u003E.delete((void*) num, 1024U);
  }

  internal static unsafe unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E* std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E* obj0, NcaHeader* _Ptr)
  {
    *(int*) obj0 = (int) _Ptr;
    return obj0;
  }

  internal static unsafe sbyte* msclr\u002Einterop\u002Edetails\u002Echar_buffer\u003Cchar\u003E\u002Erelease([In] char_buffer\u003Cchar\u003E* obj0)
  {
    int num = *(int*) obj0;
    *(int*) obj0 = 0;
    return (sbyte*) num;
  }

  internal static unsafe sbyte* msclr\u002Einterop\u002Edetails\u002Echar_buffer\u003Cchar\u003E\u002Eget([In] char_buffer\u003Cchar\u003E* obj0)
  {
    return (sbyte*) *(int*) obj0;
  }

  internal static unsafe void msclr\u002Einterop\u002Edetails\u002Echar_buffer\u003Cchar\u003E\u002E\u007Bdtor\u007D([In] char_buffer\u003Cchar\u003E* obj0)
  {
    \u003CModule\u003E.delete\u005B\u005D((void*) *(int*) obj0);
  }

  internal static unsafe char_buffer\u003Cchar\u003E* msclr\u002Einterop\u002Edetails\u002Echar_buffer\u003Cchar\u003E\u002E\u007Bctor\u007D([In] char_buffer\u003Cchar\u003E* obj0, uint _size)
  {
    *(int*) obj0 = (int) \u003CModule\u003E.new\u005B\u005D(_size);
    return obj0;
  }

  internal static unsafe NcaHeader* std\u002Epointer_traits\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u003E\u002Epointer_to(NcaHeader* _Val)
  {
    return _Val;
  }

  internal static unsafe NcaFsHeader* std\u002Epointer_traits\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u003E\u002Epointer_to(NcaFsHeader* _Val)
  {
    return _Val;
  }

  internal static unsafe NcaFsHeader** std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002E_Myptr([In] _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E* obj0)
  {
    return (NcaFsHeader**) obj0;
  }

  internal static unsafe default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E* std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002Eget_deleter([In] _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E* obj0)
  {
    return (default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E*) obj0;
  }

  internal static unsafe NcaFsHeader* std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002E\u002A([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E* obj0)
  {
    return (NcaFsHeader*) *(int*) obj0;
  }

  internal static unsafe void std\u002Edefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u002E\u0028\u0029([In] default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E* obj0, NcaFsHeader* _Ptr)
  {
    \u003CModule\u003E.delete((void*) _Ptr, 512U);
  }

  internal static unsafe NcaHeader** std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E\u002E_Myptr([In] _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E* obj0)
  {
    return (NcaHeader**) obj0;
  }

  internal static unsafe default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E* std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E\u002Eget_deleter([In] _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E* obj0)
  {
    return (default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E*) obj0;
  }

  internal static unsafe NcaHeader* std\u002Eunique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E\u002E\u002A([In] unique_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E* obj0)
  {
    return (NcaHeader*) *(int*) obj0;
  }

  internal static unsafe void std\u002Edefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u002E\u0028\u0029([In] default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E* obj0, NcaHeader* _Ptr)
  {
    \u003CModule\u003E.delete((void*) _Ptr, 1024U);
  }

  internal static unsafe NcaFsHeader** std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u002C1\u003E* obj0)
  {
    return (NcaFsHeader**) obj0;
  }

  internal static unsafe default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u002C1\u003E* obj0)
  {
    return (default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E*) obj0;
  }

  internal static unsafe NcaHeader** std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u002C1\u003E* obj0)
  {
    return (NcaHeader**) obj0;
  }

  internal static unsafe default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u002C1\u003E* obj0)
  {
    return (default_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E*) obj0;
  }

  internal static unsafe int* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cint\u003E(object obj, int* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe byte[]* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Ccli\u003A\u003Aarray\u003Cunsigned\u0020char\u0020\u003E\u005E\u003E(object obj, byte[]* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E* std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u003E([In] _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u0020\u003E* obj0, NcaFsHeader* _Ptr)
  {
    *(int*) obj0 = (int) _Ptr;
    return obj0;
  }

  internal static unsafe _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E* std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u003E([In] _Unique_ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u0020\u003E* obj0, NcaHeader* _Ptr)
  {
    *(int*) obj0 = (int) _Ptr;
    return obj0;
  }

  internal static unsafe NcaHeader* std\u002Eaddressof\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E(NcaHeader* _Val)
  {
    return _Val;
  }

  internal static unsafe NcaFsHeader* std\u002Eaddressof\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E(NcaFsHeader* _Val)
  {
    return _Val;
  }

  internal static unsafe _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u002C1\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u002C1\u003E\u002E\u007Bctor\u007D\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u0020\u0026\u003E([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u002C1\u003E* obj0, _Zero_then_variadic_args_t __unnamed000, NcaFsHeader** _param2)
  {
    *(int*) obj0 = *(int*) _param2;
    return obj0;
  }

  internal static unsafe _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u002C1\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u002C1\u003E\u002E\u007Bctor\u007D\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u0020\u0026\u003E([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u003E\u002Cnn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u002C1\u003E* obj0, _Zero_then_variadic_args_t __unnamed000, NcaHeader** _param2)
  {
    *(int*) obj0 = *(int*) _param2;
    return obj0;
  }

  internal static unsafe NcaFsHeader** std\u002Eforward\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003ANcaFsHeader\u0020\u002A\u0020\u0026\u003E(NcaFsHeader** _Arg)
  {
    return _Arg;
  }

  internal static unsafe NcaHeader** std\u002Eforward\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003ANcaHeader\u0020\u002A\u0020\u0026\u003E(NcaHeader** _Arg)
  {
    return _Arg;
  }

  internal static unsafe long nn\u002Encm\u002EContentInfo\u002EGetSize([In] ContentInfo* obj0)
  {
    return (long) *(ushort*) ((IntPtr) obj0 + 20) * 4294967296L + (long) (uint) *(int*) ((IntPtr) obj0 + 16);
  }

  internal static unsafe ContentInfo nn\u002Encm\u002EContentInfo\u002EMake(ContentId id, long size, nn.ncm.ContentType type)
  {
    ContentInfo contentInfo;
    // ISSUE: cpblk instruction
    __memcpy(ref contentInfo, ref id, 16);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &contentInfo + 16) = (int) size;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ((IntPtr) &contentInfo + 20) = (short) (int) (size >> 32);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &contentInfo + 22) = (sbyte) type;
    // ISSUE: cast to a reference type
    // ISSUE: initblk instruction
    __memset((ContentInfo&) ((IntPtr) &contentInfo + 23), 0, 1);
    return contentInfo;
  }

  internal static unsafe void nn\u002Esf\u002Edetail\u002ESharedPointerBase\u002EAddReferenceImpl([In] SharedPointerBase* obj0)
  {
    uint num1 = (uint) *(int*) obj0;
    if (num1 == 0U)
      return;
    int num2 = (int) num1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    __calli((__FnPtr<void (IntPtr)>) *(int*) *(int*) num2)((IntPtr) num2);
  }

  [SpecialName]
  internal static unsafe SharedPointerBase* nn\u002Esf\u002Edetail\u002ESharedPointerBase\u002E\u007Bctor\u007D([In] SharedPointerBase* obj0, SharedPointerBase* x)
  {
    int num1 = *(int*) x;
    *(int*) obj0 = num1;
    if (num1 != 0)
    {
      int num2 = num1;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      __calli((__FnPtr<void (IntPtr)>) *(int*) *(int*) num2)((IntPtr) num2);
    }
    return obj0;
  }

  internal static unsafe ContentId* nn\u002Encm\u002EPackagedContentInfo\u002EGetId([In] PackagedContentInfo* obj0)
  {
    return (ContentId*) ((IntPtr) obj0 + 32);
  }

  internal static unsafe nn.ncm.ContentType nn\u002Encm\u002EPackagedContentInfo\u002EGetType([In] PackagedContentInfo* obj0)
  {
    return (nn.ncm.ContentType) *(byte*) ((IntPtr) obj0 + 54);
  }

  internal static unsafe ContentMetaInfo nn\u002Encm\u002EContentMetaInfo\u002EMake(ulong id, uint version, ContentMetaType type, byte attributes)
  {
    ContentMetaInfo contentMetaInfo;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(long&) ref contentMetaInfo = (long) id;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &contentMetaInfo + 8) = (int) version;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &contentMetaInfo + 12) = (sbyte) type;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &contentMetaInfo + 13) = (sbyte) attributes;
    // ISSUE: cast to a reference type
    // ISSUE: initblk instruction
    __memset((ContentMetaInfo&) ((IntPtr) &contentMetaInfo + 14), 0, 2);
    return contentMetaInfo;
  }

  internal static unsafe PackagedContentMetaReader* nn\u002Encm\u002EPackagedContentMetaReader\u002E\u007Bctor\u007D([In] PackagedContentMetaReader* obj0, void* data, uint size)
  {
    *(sbyte*) obj0 = (sbyte) 1;
    *(int*) ((IntPtr) obj0 + 4) = (int) data;
    *(int*) ((IntPtr) obj0 + 8) = (int) size;
    return obj0;
  }

  internal static unsafe PackagedContentMetaWriter* nn\u002Encm\u002EPackagedContentMetaWriter\u002E\u007Bctor\u007D([In] PackagedContentMetaWriter* obj0, void* buffer, uint size)
  {
    *(sbyte*) obj0 = (sbyte) 0;
    *(int*) ((IntPtr) obj0 + 4) = (int) buffer;
    *(int*) ((IntPtr) obj0 + 8) = (int) size;
    return obj0;
  }

  internal static uint nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002ECalculateSize(ContentMetaType type, int contentCount, int contentMetaCount)
  {
    uint num1;
    int num2;
    switch (type)
    {
      case (ContentMetaType) 128:
        num1 = 16U;
        goto label_6;
      case (ContentMetaType) 129:
        num1 = 16U;
        goto label_6;
      case (ContentMetaType) 130:
        num2 = 16;
        break;
      default:
        num2 = 0;
        break;
    }
    num1 = (uint) num2;
label_6:
    return (uint) (contentCount * 56 + ((int) num1 + (contentMetaCount + 4) * 16));
  }

  internal static unsafe PackagedContentInfo* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetWritableContentInfo([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, int index)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    int num1 = *(int*) ((IntPtr) obj0 + 4);
    if (index >= (int) *(ushort*) (num1 + 16))
      \u003CModule\u003E.abort();
    uint num2 = (uint) (num1 + 32);
    return (PackagedContentInfo*) (index * 56 + ((int) num2 + (int) *(ushort*) (num1 + 14)));
  }

  internal static unsafe void nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EWriteDigest([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, Hash* digest)
  {
    // ISSUE: cpblk instruction
    __memcpy((int) \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetDigestAddress(obj0), (IntPtr) digest, 32);
  }

  internal static unsafe void nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EWriteContentMetaInfo([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, ContentMetaInfo* contentMetaInfo, int index)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    if ((uint) (ushort) index >= (uint) *(ushort*) (*(int*) ((IntPtr) obj0 + 4) + 18))
      \u003CModule\u003E.abort();
    // ISSUE: cpblk instruction
    __memcpy((int) \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentMetaInfoHeadAddress(obj0) + index * 16, (IntPtr) contentMetaInfo, 16);
  }

  internal static unsafe void nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EWriteContentInfo([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, PackagedContentInfo* contentInfo, int index)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    int num1 = *(int*) ((IntPtr) obj0 + 4);
    if ((uint) (ushort) index >= (uint) *(ushort*) (num1 + 16))
      \u003CModule\u003E.abort();
    uint num2 = (uint) (num1 + 32);
    // ISSUE: cpblk instruction
    __memcpy(index * 56 + ((int) num2 + (int) *(ushort*) (num1 + 14)), (IntPtr) contentInfo, 56);
  }

  internal static unsafe void nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EWriteHeader([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, ulong id, uint version, ContentMetaType type, byte attributes, uint requiredDownloadSystemVersion, int contentCount, int contentMetaCount)
  {
    if (*(byte*) obj0 != (byte) 0)
      \u003CModule\u003E.abort();
    int num1 = *(int*) ((IntPtr) obj0 + 8);
    uint num2;
    int num3;
    switch (type)
    {
      case (ContentMetaType) 128:
        num2 = 16U;
        goto label_8;
      case (ContentMetaType) 129:
        num2 = 16U;
        goto label_8;
      case (ContentMetaType) 130:
        num3 = 16;
        break;
      default:
        num3 = 0;
        break;
    }
    num2 = (uint) num3;
label_8:
    int num4 = contentCount * 56 + ((int) num2 + (contentMetaCount + 4) * 16);
    if ((uint) num1 < (uint) num4)
      \u003CModule\u003E.abort();
    PackagedContentMetaHeader contentMetaHeader;
    // ISSUE: initblk instruction
    __memset(ref contentMetaHeader, 0, 32);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(long&) ref contentMetaHeader = (long) id;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &contentMetaHeader + 8) = (int) version;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &contentMetaHeader + 12) = (sbyte) type;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &contentMetaHeader + 20) = (sbyte) attributes;
    uint num5;
    int num6;
    switch (type)
    {
      case (ContentMetaType) 128:
        num5 = 16U;
        goto label_16;
      case (ContentMetaType) 129:
        num5 = 16U;
        goto label_16;
      case (ContentMetaType) 130:
        num6 = 16;
        break;
      default:
        num6 = 0;
        break;
    }
    num5 = (uint) num6;
label_16:
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ((IntPtr) &contentMetaHeader + 14) = (short) (ushort) num5;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ((IntPtr) &contentMetaHeader + 16) = (short) (ushort) contentCount;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ((IntPtr) &contentMetaHeader + 18) = (short) (ushort) contentMetaCount;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &contentMetaHeader + 24) = (int) requiredDownloadSystemVersion;
    // ISSUE: cpblk instruction
    __memcpy(*(int*) ((IntPtr) obj0 + 4), ref contentMetaHeader, 32);
    *(sbyte*) obj0 = (sbyte) 1;
  }

  internal static unsafe uint nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetDigestAddress([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    int num = (int) *(ushort*) (*(int*) ((IntPtr) obj0 + 4) + 18);
    return \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentMetaInfoHeadAddress(obj0) + (uint) (num * 16);
  }

  internal static unsafe ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002E\u007Bctor\u007D([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, void* data, uint size)
  {
    *(sbyte*) obj0 = (sbyte) 0;
    *(int*) ((IntPtr) obj0 + 4) = (int) data;
    *(int*) ((IntPtr) obj0 + 8) = (int) size;
    return obj0;
  }

  internal static unsafe ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002E\u007Bctor\u007D([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, void* data, uint size)
  {
    *(sbyte*) obj0 = (sbyte) 1;
    *(int*) ((IntPtr) obj0 + 4) = (int) data;
    *(int*) ((IntPtr) obj0 + 8) = (int) size;
    return obj0;
  }

  internal static unsafe Hash* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetDigest([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    return (Hash*) \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetDigestAddress(obj0);
  }

  internal static unsafe ContentMetaInfo* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentMetaInfo([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, int index)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    if (index >= (int) *(ushort*) (*(int*) ((IntPtr) obj0 + 4) + 18))
      \u003CModule\u003E.abort();
    return (ContentMetaInfo*) ((int) \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentMetaInfoHeadAddress(obj0) + index * 16);
  }

  internal static unsafe PackagedContentInfo* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentInfo([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, int index)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    if (index >= (int) *(ushort*) (*(int*) ((IntPtr) obj0 + 4) + 16))
      \u003CModule\u003E.abort();
    return \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetWritableContentInfo(obj0, index);
  }

  internal static unsafe int nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002ECountContentMeta([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    return (int) *(ushort*) (*(int*) ((IntPtr) obj0 + 4) + 18);
  }

  internal static unsafe int nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002ECountContent([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    return (int) *(ushort*) (*(int*) ((IntPtr) obj0 + 4) + 16);
  }

  internal static unsafe PackagedContentMetaHeader* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetHeader([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    return (PackagedContentMetaHeader*) *(int*) ((IntPtr) obj0 + 4);
  }

  internal static unsafe uint nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetSize([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    return (uint) *(int*) ((IntPtr) obj0 + 8);
  }

  internal static unsafe void* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetData([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    return (void*) *(int*) ((IntPtr) obj0 + 4);
  }

  internal static uint nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetExtendedHeaderSize(ContentMetaType type)
  {
    switch (type)
    {
      case (ContentMetaType) 128:
        return 16;
      case (ContentMetaType) 129:
        return 16;
      case (ContentMetaType) 130:
        return 16;
      default:
        return 0;
    }
  }

  internal static unsafe uint nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentMetaInfoAddress([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, int index)
  {
    return \u003CModule\u003E.nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentMetaInfoHeadAddress(obj0) + (uint) (index * 16);
  }

  internal static unsafe uint nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentInfoAddress([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, int index)
  {
    uint num1 = (uint) *(int*) ((IntPtr) obj0 + 4);
    uint num2 = num1 + 32U;
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    return (uint) (index * 56 + ((int) num2 + (int) *(ushort*) ((int) num1 + 14)));
  }

  internal static unsafe void* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetWritableData([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    return (void*) *(int*) ((IntPtr) obj0 + 4);
  }

  internal static unsafe uint nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentMetaInfoHeadAddress([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    int num1 = *(int*) ((IntPtr) obj0 + 4);
    int num2 = (int) *(ushort*) (num1 + 16);
    uint num3 = (uint) (num1 + 32);
    int num4 = 56;
    return (uint) (num2 * num4 + ((int) num3 + (int) *(ushort*) (num1 + 14)));
  }

  internal static unsafe uint nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetContentInfoHeadAddress([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    uint num1 = (uint) *(int*) ((IntPtr) obj0 + 4);
    uint num2 = num1 + 32U;
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    return (uint) *(ushort*) ((int) num1 + 14) + num2;
  }

  internal static unsafe uint nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetExtendedHeaderAddress([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    return (uint) (*(int*) ((IntPtr) obj0 + 4) + 32);
  }

  internal static unsafe uint* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cunsigned\u0020int\u003E(object obj, uint* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe string* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020System\u003A\u003AString\u0020\u005E\u003E(object obj, string* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe ulong* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cunsigned\u0020__int64\u003E(object obj, ulong* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe byte* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cunsigned\u0020char\u003E(object obj, byte* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe List<NintendoContentInfo>* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020System\u003A\u003ACollections\u003A\u003AGeneric\u003A\u003AList\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003ANintendoContentInfo\u0020\u005E\u003E\u0020\u005E\u003E(object obj, List<NintendoContentInfo>* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe List<NintendoContentMetaInfo>* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020System\u003A\u003ACollections\u003A\u003AGeneric\u003A\u003AList\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003ANintendoContentMetaInfo\u0020\u005E\u003E\u0020\u005E\u003E(object obj, List<NintendoContentMetaInfo>* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe ApplicationMetaExtendedHeader* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetExtendedHeader\u003Cstruct\u0020nn\u003A\u003Ancm\u003A\u003AApplicationMetaExtendedHeader\u003E([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    return (ApplicationMetaExtendedHeader*) (*(int*) ((IntPtr) obj0 + 4) + 32);
  }

  internal static unsafe NintendoApplicationExtendedHeader* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003ANintendoApplicationExtendedHeader\u0020\u005E\u003E(object obj, NintendoApplicationExtendedHeader* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe PatchMetaExtendedHeader* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetExtendedHeader\u003Cstruct\u0020nn\u003A\u003Ancm\u003A\u003APatchMetaExtendedHeader\u003E([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    return (PatchMetaExtendedHeader*) (*(int*) ((IntPtr) obj0 + 4) + 32);
  }

  internal static unsafe NintendoPatchExtendedHeader* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003ANintendoPatchExtendedHeader\u0020\u005E\u003E(object obj, NintendoPatchExtendedHeader* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe AddOnContentMetaExtendedHeader* nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EGetExtendedHeader\u003Cstruct\u0020nn\u003A\u003Ancm\u003A\u003AAddOnContentMetaExtendedHeader\u003E([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0)
  {
    return (AddOnContentMetaExtendedHeader*) (*(int*) ((IntPtr) obj0 + 4) + 32);
  }

  internal static unsafe NintendoAddOnContentExtendedHeader* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003ANintendoAddOnContentExtendedHeader\u0020\u005E\u003E(object obj, NintendoAddOnContentExtendedHeader* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static uint nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002ERecalculateSizeTemplate\u003Cstruct\u0020nn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cstruct\u0020nn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E(uint extendedHeaderSize, int contentCount, int contentMetaCount)
  {
    return (uint) (contentCount * 56 + ((int) extendedHeaderSize + (contentMetaCount + 4) * 16));
  }

  internal static unsafe void nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EWriteExtendedHeader\u003Cstruct\u0020nn\u003A\u003Ancm\u003A\u003AApplicationMetaExtendedHeader\u003E([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, ApplicationMetaExtendedHeader* data)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    // ISSUE: cpblk instruction
    __memcpy(*(int*) ((IntPtr) obj0 + 4) + 32, (IntPtr) data, 16);
  }

  internal static unsafe void nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EWriteExtendedHeader\u003Cstruct\u0020nn\u003A\u003Ancm\u003A\u003AAddOnContentMetaExtendedHeader\u003E([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, AddOnContentMetaExtendedHeader* data)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    // ISSUE: cpblk instruction
    __memcpy(*(int*) ((IntPtr) obj0 + 4) + 32, (IntPtr) data, 16);
  }

  internal static unsafe void nn\u002Encm\u002EContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E\u002EWriteExtendedHeader\u003Cstruct\u0020nn\u003A\u003Ancm\u003A\u003APatchMetaExtendedHeader\u003E([In] ContentMetaAccessorBase\u003Cnn\u003A\u003Ancm\u003A\u003APackagedContentMetaHeader\u002Cnn\u003A\u003Ancm\u003A\u003APackagedContentInfo\u003E* obj0, PatchMetaExtendedHeader* data)
  {
    if (*(byte*) obj0 == (byte) 0)
      \u003CModule\u003E.abort();
    // ISSUE: cpblk instruction
    __memcpy(*(int*) ((IntPtr) obj0 + 4) + 32, (IntPtr) data, 16);
  }

  internal static unsafe void std\u002E_Init_atomic_counter(uint* _Counter, uint _Value)
  {
    *_Counter = _Value;
  }

  internal static unsafe _Ref_count_base* std\u002E_Ref_count_base\u002E\u007Bctor\u007D([In] _Ref_count_base* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    *(int*) ((IntPtr) obj0 + 4) = 1;
    *(int*) ((IntPtr) obj0 + 8) = 1;
    return obj0;
  }

  internal static unsafe void std\u002E_Ref_count_base\u002E\u007Bdtor\u007D([In] _Ref_count_base* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
  }

  internal static unsafe void* std\u002E_Ref_count_base\u002E_Get_deleter([In] _Ref_count_base* obj0, type_info* A_0)
  {
    return (void*) 0;
  }

  internal static unsafe void* std\u002E_Ref_count_base\u002E__vecDelDtor([In] _Ref_count_base* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      _Ref_count_base* refCountBasePtr1 = (_Ref_count_base*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 12U, (uint) *(int*) refCountBasePtr1, (__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_base\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        _Ref_count_base* refCountBasePtr2 = refCountBasePtr1;
        int num = *(int*) refCountBasePtr2 * 12 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) refCountBasePtr2, (uint) num);
      }
      return (void*) refCountBasePtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 12U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002E_Enable_shared(void* A_0, void* A_1)
  {
  }

  internal static unsafe void nn\u002EMemoryResource\u002E\u007Bdtor\u007D([In] MemoryResource* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryResource\u0040nn\u0040\u00406B\u0040;
  }

  internal static unsafe void* nn\u002EMemoryResource\u002E__vecDelDtor([In] MemoryResource* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      MemoryResource* memoryResourcePtr1 = (MemoryResource*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 4U, (uint) *(int*) memoryResourcePtr1, (__FnPtr<void (void*)>) __methodptr(nn\u002EMemoryResource\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        MemoryResource* memoryResourcePtr2 = memoryResourcePtr1;
        int num = *(int*) memoryResourcePtr2 * 4 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) memoryResourcePtr2, (uint) num);
      }
      return (void*) memoryResourcePtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryResource\u0040nn\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 4U);
    return (void*) obj0;
  }

  internal static unsafe uint nn\u002EResult\u002EGetInnerValueForDebug([In] Result* obj0)
  {
    return (uint) *(int*) obj0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002EResult\u002EIsFailure([In] Result* obj0)
  {
    return *(int*) obj0 != 0;
  }

  internal static unsafe ManagedStreamStorage* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EManagedStreamStorage\u002E\u007Bctor\u007D([In] ManagedStreamStorage* obj0, Stream stream)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7ManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
      *(int*) ((IntPtr) obj0 + 4) = (int) (IntPtr) GCHandle.Alloc((object) stream).ToPointer();
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EManagedStreamStorage\u002E\u007Bdtor\u007D([In] ManagedStreamStorage* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7ManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E\u002E\u007Bdtor\u007D((gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E*) ((IntPtr) obj0 + 4));
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  }

  internal static unsafe Result* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EManagedStreamStorage\u002ERead([In] ManagedStreamStorage* obj0, [In] Result* obj1, long offset, void* buffer, uint size)
  {
    ManagedStreamStorage* managedStreamStoragePtr = (ManagedStreamStorage*) ((IntPtr) obj0 + 4);
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E\u002E\u002D\u003E((gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E*) managedStreamStoragePtr).Seek(offset, SeekOrigin.Begin);
    byte[] numArray = new byte[(int) size];
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E\u002E\u002D\u003E((gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E*) managedStreamStoragePtr).Read(numArray, 0, (int) size);
    IntPtr destination = (IntPtr) buffer;
    Marshal.Copy(numArray, 0, destination, (int) size);
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EManagedStreamStorage\u002EGetSize([In] ManagedStreamStorage* obj0, [In] Result* obj1, long* outValue)
  {
    *outValue = \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E\u002E\u002D\u003E((gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E*) ((IntPtr) obj0 + 4)).Length;
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe void* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EManagedStreamStorage\u002E__vecDelDtor([In] ManagedStreamStorage* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      ManagedStreamStorage* managedStreamStoragePtr1 = (ManagedStreamStorage*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 8U, (uint) *(int*) managedStreamStoragePtr1, (__FnPtr<void (void*)>) __methodptr(Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EManagedStreamStorage\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        ManagedStreamStorage* managedStreamStoragePtr2 = managedStreamStoragePtr1;
        int num = *(int*) managedStreamStoragePtr2 * 8 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) managedStreamStoragePtr2, (uint) num);
      }
      return (void*) managedStreamStoragePtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7ManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E\u002E\u007Bdtor\u007D((gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E*) ((IntPtr) obj0 + 4));
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 8U);
    return (void*) obj0;
  }

  internal static unsafe void* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDefaultMemoryResource\u002Edo_allocate([In] DefaultMemoryResource* obj0, uint bytes, uint alignment)
  {
    return \u003CModule\u003E.malloc(bytes);
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDefaultMemoryResource\u002Edo_deallocate([In] DefaultMemoryResource* obj0, void* p, uint bytes, uint alignment)
  {
    \u003CModule\u003E.free(p);
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDefaultMemoryResource\u002Edo_is_equal([In] DefaultMemoryResource* obj0, MemoryResource* other)
  {
    return false;
  }

  internal static unsafe NintendoContentArchiveReaderImpl* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002E\u007Bctor\u007D([In] NintendoContentArchiveReaderImpl* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* storage, byte[][] key)
  {
    shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr1;
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E((shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E*) obj0);
      // ISSUE: fault handler
      try
      {
        DefaultMemoryResource* defaultMemoryResourcePtr1 = (DefaultMemoryResource*) \u003CModule\u003E.@new(4U);
        DefaultMemoryResource* defaultMemoryResourcePtr2;
        if ((IntPtr) defaultMemoryResourcePtr1 != IntPtr.Zero)
        {
          // ISSUE: initblk instruction
          __memset((IntPtr) defaultMemoryResourcePtr1, 0, 4);
          *(int*) defaultMemoryResourcePtr1 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryResource\u0040nn\u0040\u00406B\u0040;
          // ISSUE: fault handler
          try
          {
            *(int*) defaultMemoryResourcePtr1 = (int) &\u003CModule\u003E.\u003F\u003F_7DefaultMemoryResource\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002EMemoryResource\u002E\u007Bdtor\u007D), (void*) defaultMemoryResourcePtr1);
          }
          defaultMemoryResourcePtr2 = defaultMemoryResourcePtr1;
        }
        else
          defaultMemoryResourcePtr2 = (DefaultMemoryResource*) 0;
        *(int*) ((IntPtr) obj0 + 8) = (int) defaultMemoryResourcePtr2;
        NcaCryptoConfiguration* cryptoConfiguration1 = \u003CModule\u003E.nn\u002Efssrv\u002EGetNcaDefaultCryptoConfiguration(false);
        NcaCryptoConfiguration cryptoConfiguration2;
        // ISSUE: cpblk instruction
        __memcpy(ref cryptoConfiguration2, (IntPtr) cryptoConfiguration1, 364);
        if (key.Length > 2)
          throw new ArgumentException(string.Format("Failed to Initialize NcaReader. Invalid KeyConfiguration."));
        int index = 0;
        int num = (int) ((IntPtr) &cryptoConfiguration2 + 278);
        do
        {
          byte[] numArray = key[index];
          if (numArray != null)
          {
            fixed (byte* numPtr = &numArray[0])
            {
              // ISSUE: cast to a reference type
              // ISSUE: cpblk instruction
              __memcpy(num, (byte*) numPtr, 16);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(sbyte&) (index + ((IntPtr) &cryptoConfiguration2 + 260)) = (sbyte) 1;
            }
          }
          ++index;
          num += 16;
        }
        while (index < 2);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &cryptoConfiguration2 + 360) = (int) \u003CModule\u003E.__unep\u0040\u003FGenerateKeyWin\u0040detail\u0040fs\u0040nn\u0040\u0040\u0024\u0024FYAXPAXIPBXIW4NcaKeyIndex\u0040fssystem\u00403\u0040ABUNcaCryptoConfiguration\u004053\u0040\u0040Z;
        shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage;
        shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr2 = &sharedPtrNnFsIstorage;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref sharedPtrNnFsIstorage = *(int*) storage;
        sharedPtrNnFsIstoragePtr1 = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) storage + 4);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4) = *(int*) sharedPtrNnFsIstoragePtr1;
        *(int*) storage = 0;
        *(int*) sharedPtrNnFsIstoragePtr1 = 0;
        NcaReader* ncaReaderPtr;
        // ISSUE: fault handler
        try
        {
          ncaReaderPtr = (NcaReader*) *(int*) obj0;
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) sharedPtrNnFsIstoragePtr2);
        }
        Result result1;
        \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EInitialize(ncaReaderPtr, &result1, &sharedPtrNnFsIstorage, &cryptoConfiguration2);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result1 != 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          throw new ArgumentException(string.Format("Failed to Initialize NcaReader 0x{0:X8}.", (object) (uint) ^(int&) ref result1));
        }
        byte* numPtr1 = (byte*) \u003CModule\u003E.new\u005B\u005D(4194304U);
        FileSystemBufferManager* systemBufferManagerPtr1 = (FileSystemBufferManager*) \u003CModule\u003E.@new(144U);
        FileSystemBufferManager* systemBufferManagerPtr2 = (IntPtr) systemBufferManagerPtr1 == IntPtr.Zero ? (FileSystemBufferManager*) 0 : \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBufferManager\u002E\u007Bctor\u007D(systemBufferManagerPtr1);
        *(int*) ((IntPtr) obj0 + 376) = (int) systemBufferManagerPtr2;
        Result result2;
        \u003CModule\u003E.nn\u002Efssystem\u002EFileSystemBufferManager\u002EInitialize(systemBufferManagerPtr2, &result2, 1024, (uint) numPtr1, 4194304U, 4096U);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) storage);
    }
    int num1 = *(int*) sharedPtrNnFsIstoragePtr1;
    if (num1 != 0)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num1);
    return obj0;
  }

  internal static unsafe List<Tuple<int, long>> Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EListFsInfo([In] NintendoContentArchiveReaderImpl* obj0)
  {
    List<Tuple<int, long>> tupleList = new List<Tuple<int, long>>();
    int num1 = 0;
    if (0 < \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetFsCount((NcaReader*) *(int*) obj0))
    {
      NintendoContentArchiveReaderImpl* archiveReaderImplPtr1 = (NintendoContentArchiveReaderImpl*) ((IntPtr) obj0 + 376);
      NintendoContentArchiveReaderImpl* archiveReaderImplPtr2 = (NintendoContentArchiveReaderImpl*) ((IntPtr) obj0 + 8);
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage;
      Result result1;
      NcaReader* ncaReaderPtr1;
      do
      {
        NcaReader* ncaReaderPtr2 = (NcaReader*) *(int*) obj0;
        NcaFileSystemDriver fileSystemDriver;
        \u003CModule\u003E.nn\u002Efssystem\u002ENcaFileSystemDriver\u002E\u007Bctor\u007D(&fileSystemDriver, ncaReaderPtr2, (MemoryResource*) *(int*) archiveReaderImplPtr2, (IBufferManager*) *(int*) archiveReaderImplPtr1);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref sharedPtrNnFsIstorage = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4) = 0;
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.nn\u002Efssystem\u002ENcaFileSystemDriver\u002EOpenStorage(&fileSystemDriver, &result1, &sharedPtrNnFsIstorage, num1);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result1 == 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            int num2 = ^(int&) ref sharedPtrNnFsIstorage;
            Result result2;
            ref Result local1 = ref result2;
            long num3;
            ref long local2 = ref num3;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a function pointer type
            // ISSUE: function pointer call
            int num4 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long*)>) *(int*) (*(int*) ^(int&) ref sharedPtrNnFsIstorage + 20))((long*) num2, (Result*) ref local1, (IntPtr) ref local2);
            // ISSUE: cpblk instruction
            __memcpy(ref result1, num4, 4);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if (^(int&) ref result1 == 0)
              tupleList.Add(Tuple.Create<int, long>(num1, num3));
            else
              goto label_12;
          }
          else
            goto label_10;
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) &sharedPtrNnFsIstorage);
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4) != 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4));
        }
        ++num1;
        ncaReaderPtr1 = (NcaReader*) *(int*) obj0;
      }
      while (num1 < \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetFsCount(ncaReaderPtr1));
      goto label_14;
label_10:
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        throw new ArgumentException(string.Format("Failed to OpenStorage 0x{0:X8}.", (object) (uint) ^(int&) ref result1));
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) &sharedPtrNnFsIstorage);
      }
label_12:
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        throw new ArgumentException(string.Format("Failed to GetSize 0x{0:X8}.", (object) (uint) ^(int&) ref result1));
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) &sharedPtrNnFsIstorage);
      }
    }
label_14:
    return tupleList;
  }

  internal static unsafe byte Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EGetDistributionType([In] NintendoContentArchiveReaderImpl* obj0)
  {
    return (byte) \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetDistributionType((NcaReader*) *(int*) obj0);
  }

  internal static unsafe byte Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EGetContentType([In] NintendoContentArchiveReaderImpl* obj0)
  {
    return (byte) \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetContentType((NcaReader*) *(int*) obj0);
  }

  internal static unsafe byte Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EGetKeyGeneration([In] NintendoContentArchiveReaderImpl* obj0)
  {
    return \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetKeyGeneration((NcaReader*) *(int*) obj0);
  }

  internal static unsafe byte Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EGetKeyIndex([In] NintendoContentArchiveReaderImpl* obj0)
  {
    return \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetKeyIndex((NcaReader*) *(int*) obj0);
  }

  internal static unsafe ulong Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EGetProgramId([In] NintendoContentArchiveReaderImpl* obj0)
  {
    return \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetProgramId((NcaReader*) *(int*) obj0);
  }

  internal static unsafe uint Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EGetContentIndex([In] NintendoContentArchiveReaderImpl* obj0)
  {
    return \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetContentIndex((NcaReader*) *(int*) obj0);
  }

  internal static unsafe uint Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EGetSdkAddonVersion([In] NintendoContentArchiveReaderImpl* obj0)
  {
    return \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetSdkAddonVersion((NcaReader*) *(int*) obj0);
  }

  internal static unsafe int Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EGetFsCount([In] NintendoContentArchiveReaderImpl* obj0)
  {
    return \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002EGetFsCount((NcaReader*) *(int*) obj0);
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002EOpenStorage([In] NintendoContentArchiveReaderImpl* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* outValue, NcaFsHeaderReader* outFsHeaderReader, int index)
  {
    NcaReader* ncaReaderPtr = (NcaReader*) *(int*) obj0;
    NcaFileSystemDriver fileSystemDriver;
    \u003CModule\u003E.nn\u002Efssystem\u002ENcaFileSystemDriver\u002E\u007Bctor\u007D(&fileSystemDriver, ncaReaderPtr, (MemoryResource*) *(int*) ((IntPtr) obj0 + 8), (IBufferManager*) *(int*) ((IntPtr) obj0 + 376));
    shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E fssystemNcaReader;
    shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* fssystemNcaReaderPtr = &fssystemNcaReader;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref fssystemNcaReader = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &fssystemNcaReader + 4) = 0;
    \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E((_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E*) &fssystemNcaReader, (_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E*) obj0);
    Result result;
    \u003CModule\u003E.nn\u002Efssystem\u002ENcaFileSystemDriver\u002EOpenStorage(&fileSystemDriver, &result, outValue, outFsHeaderReader, &fssystemNcaReader, index);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result != 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      throw new ArgumentException(string.Format("Failed to OpenStorage 0x{0:X8}.", (object) (uint) ^(int&) ref result));
    }
  }

  internal static unsafe DefaultMemoryResource* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDefaultMemoryResource\u002E\u007Bctor\u007D([In] DefaultMemoryResource* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryResource\u0040nn\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7DefaultMemoryResource\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u00406B\u0040;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002EMemoryResource\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDefaultMemoryResource\u002E__vecDelDtor([In] DefaultMemoryResource* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      DefaultMemoryResource* defaultMemoryResourcePtr1 = (DefaultMemoryResource*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 4U, (uint) *(int*) defaultMemoryResourcePtr1, (__FnPtr<void (void*)>) __methodptr(Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDefaultMemoryResource\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        DefaultMemoryResource* defaultMemoryResourcePtr2 = defaultMemoryResourcePtr1;
        int num = *(int*) defaultMemoryResourcePtr2 * 4 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) defaultMemoryResourcePtr2, (uint) num);
      }
      return (void*) defaultMemoryResourcePtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryResource\u0040nn\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 4U);
    return (void*) obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EDefaultMemoryResource\u002E\u007Bdtor\u007D([In] DefaultMemoryResource* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryResource\u0040nn\u0040\u00406B\u0040;
  }

  internal static unsafe MemoryResource* nn\u002EMemoryResource\u002E\u007Bctor\u007D([In] MemoryResource* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryResource\u0040nn\u0040\u00406B\u0040;
    return obj0;
  }

  internal static unsafe void* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002E__delDtor([In] NintendoContentArchiveReaderImpl* obj0, uint A_0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 380U);
    return (void*) obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ENintendoContentArchiveReaderImpl\u002E\u007Bdtor\u007D([In] NintendoContentArchiveReaderImpl* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  [SecuritySafeCritical]
  internal static unsafe Stream gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E\u002E\u002D\u003E([In] gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E* obj0)
  {
    return (Stream) (GCHandle) new IntPtr((void*) *(int*) obj0).Target;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E\u002E\u007Bdtor\u007D([In] gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E* obj0)
  {
    (GCHandle) new IntPtr((void*) *(int*) obj0).Free();
    *(int*) obj0 = 0;
  }

  internal static unsafe gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E* gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E\u002E\u007Bctor\u007D([In] gcroot\u003CSystem\u003A\u003AIO\u003A\u003AStream\u0020\u005E\u003E* obj0, Stream t)
  {
    IntPtr num = (IntPtr) GCHandle.Alloc((object) t);
    *(int*) obj0 = (int) num.ToPointer();
    return obj0;
  }

  internal static unsafe NcaReader* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u002D\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    return (NcaReader*) *(int*) obj0;
  }

  internal static unsafe NcaReader* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002Eget([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    return (NcaReader*) *(int*) obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bdtor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  [SpecialName]
  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* _Other)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E((_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E*) obj0, (_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E*) _Other);
    return obj0;
  }

  internal static unsafe IStorage* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u002D\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0)
  {
    return (IStorage*) *(int*) obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Decref([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe NcaReader* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Get([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    return (NcaReader*) *(int*) obj0;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe IStorage* std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Get([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0)
  {
    return (IStorage*) *(int*) obj0;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    uint num1;
    // ISSUE: fault handler
    try
    {
      num1 = 0U;
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* fssystemNcaReaderPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E*) \u003CModule\u003E.@new(1144U);
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* fssystemNcaReaderPtr2;
      // ISSUE: fault handler
      try
      {
        fssystemNcaReaderPtr2 = (IntPtr) fssystemNcaReaderPtr1 == IntPtr.Zero ? (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E*) 0 : \u003CModule\u003E.std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bctor\u007D\u003C\u003E(fssystemNcaReaderPtr1);
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) fssystemNcaReaderPtr1, 1144U);
      }
      *(int*) obj0 = 0;
      shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* fssystemNcaReaderPtr3 = (shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E*) ((IntPtr) obj0 + 4);
      *(int*) fssystemNcaReaderPtr3 = 0;
      num1 = 1U;
      uint num2 = (uint) *(int*) fssystemNcaReaderPtr3;
      if (num2 != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num2);
      *(int*) fssystemNcaReaderPtr3 = (int) fssystemNcaReaderPtr2;
      *(int*) obj0 = (int) ((IntPtr) fssystemNcaReaderPtr2 + 12);
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* std\u002Emove\u003Cclass\u0020std\u003A\u003Ashared_ptr\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AIStorage\u003E\u0020\u0026\u003E(shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, ManagedStreamStorage* _Px)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    \u003CModule\u003E.std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Resetp\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E(obj0, _Px);
    return obj0;
  }

  internal static unsafe List<Tuple<int, long>>* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020System\u003A\u003ACollections\u003A\u003AGeneric\u003A\u003AList\u003Cclass\u0020System\u003A\u003ATuple\u003Cint\u002C__int64\u003E\u0020\u005E\u003E\u0020\u005E\u003E(object obj, List<Tuple<int, long>>* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe IFileSystemArchiveReader* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cstruct\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AIFileSystemArchiveReader\u0020\u005E\u003E(object obj, IFileSystemArchiveReader* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe RomFsFileSystemArchiveReader* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003ARomFsFileSystemArchiveReader\u0020\u005E\u003E(object obj, RomFsFileSystemArchiveReader* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe PartitionFileSystemArchiveReader* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003APartitionFileSystemArchiveReader\u0020\u005E\u003E(object obj, PartitionFileSystemArchiveReader* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe ArgumentException* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020System\u003A\u003AArgumentException\u0020\u005E\u003E(object obj, ArgumentException* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* _Other)
  {
    _Ref_count_base* refCountBasePtr = (_Ref_count_base*) *(int*) ((IntPtr) _Other + 4);
    NcaReader* ncaReaderPtr = (NcaReader*) *(int*) _Other;
    if ((IntPtr) refCountBasePtr != IntPtr.Zero)
    {
      // ISSUE: cast to a reference type
      Interlocked.Increment((int&) ((IntPtr) refCountBasePtr + 4));
    }
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) refCountBasePtr;
    *(int*) obj0 = (int) ncaReaderPtr;
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Delete_this([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    if ((IntPtr) obj0 == IntPtr.Zero)
      return;
    _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* fssystemNcaReaderPtr = obj0;
    int num = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) (*(int*) obj0 + 8))((uint) fssystemNcaReaderPtr, (IntPtr) num);
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Destroy([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002E__delDtor((NcaReader*) ((IntPtr) obj0 + 12), 0U);
  }

  internal static unsafe NcaReader* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Getptr([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    return (NcaReader*) ((IntPtr) obj0 + 12);
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Reset([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0, NcaReader* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    if ((IntPtr) _Other_rep != IntPtr.Zero)
    {
      // ISSUE: cast to a reference type
      Interlocked.Increment((int&) ((IntPtr) _Other_rep + 4));
    }
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe void* nn\u002Efssystem\u002ENcaReader\u002E__delDtor([In] NcaReader* obj0, uint A_0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 1120 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    if (((int) A_0 & 1) != 0)
    {
      if (((int) A_0 & 4) == 0)
        \u003CModule\u003E.nn\u002Efs\u002Edetail\u002EDeallocate((void*) obj0, 1132U);
      else
        \u003CModule\u003E.delete((void*) obj0, 1132U);
    }
    return (void*) obj0;
  }

  internal static unsafe void nn\u002Efssystem\u002ENcaReader\u002E\u007Bdtor\u007D([In] NcaReader* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 1120 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Reset0([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0, NcaReader* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bctor\u007D\u003C\u003E([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    *(int*) ((IntPtr) obj0 + 4) = 1;
    *(int*) ((IntPtr) obj0 + 8) = 1;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7\u003F\u0024_Ref_count_obj\u0040VNcaReader\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
      NcaReader* ncaReaderPtr = (NcaReader*) ((IntPtr) obj0 + 12);
      if ((IntPtr) ncaReaderPtr != IntPtr.Zero)
        \u003CModule\u003E.nn\u002Efssystem\u002ENcaReader\u002E\u007Bctor\u007D(ncaReaderPtr);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_base\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E_Resetp0\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0, NcaReader* _Px, _Ref_count_base* _Rx)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Rx;
    *(int*) obj0 = (int) _Px;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Resetp\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, ManagedStreamStorage* _Px)
  {
    // ISSUE: untyped stack allocation
    int num1 = (int) __untypedstackalloc(\u003CModule\u003E.__CxxQueryExceptionSize());
    try
    {
      _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* managedStreamStoragePtr1 = (_Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E*) \u003CModule\u003E.@new(16U);
      _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* managedStreamStoragePtr2;
      // ISSUE: fault handler
      try
      {
        if ((IntPtr) managedStreamStoragePtr1 != IntPtr.Zero)
        {
          *(int*) managedStreamStoragePtr1 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
          *(int*) ((IntPtr) managedStreamStoragePtr1 + 4) = 1;
          *(int*) ((IntPtr) managedStreamStoragePtr1 + 8) = 1;
          // ISSUE: fault handler
          try
          {
            *(int*) managedStreamStoragePtr1 = (int) &\u003CModule\u003E.\u003F\u003F_7\u003F\u0024_Ref_count\u0040VManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0040std\u0040\u00406B\u0040;
            *(int*) ((IntPtr) managedStreamStoragePtr1 + 12) = (int) _Px;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_base\u002E\u007Bdtor\u007D), (void*) managedStreamStoragePtr1);
          }
          managedStreamStoragePtr2 = managedStreamStoragePtr1;
        }
        else
          managedStreamStoragePtr2 = (_Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E*) 0;
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) managedStreamStoragePtr1, 16U);
      }
      uint num2 = (uint) *(int*) ((IntPtr) obj0 + 4);
      if (num2 != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num2);
      *(int*) ((IntPtr) obj0 + 4) = (int) managedStreamStoragePtr2;
      *(int*) obj0 = (int) _Px;
    }
    catch (Exception ex1) when (
    {
      // ISSUE: unable to correctly present filter
      uint exceptionCode = (uint) Marshal.GetExceptionCode();
      if (\u003CModule\u003E.__CxxExceptionFilter((void*) Marshal.GetExceptionPointers(), (void*) 0, 0, (void*) 0) != 0)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      uint num2 = 0;
      \u003CModule\u003E.__CxxRegisterExceptionObject((void*) Marshal.GetExceptionPointers(), (void*) num1);
      try
      {
        try
        {
          void* voidPtr;
          if ((IntPtr) _Px != IntPtr.Zero)
          {
            ManagedStreamStorage* managedStreamStoragePtr = _Px;
            int num3 = 1;
            // ISSUE: cast to a function pointer type
            // ISSUE: function pointer call
            voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) _Px)((uint) managedStreamStoragePtr, (IntPtr) num3);
          }
          else
            voidPtr = (void*) 0;
          \u003CModule\u003E._CxxThrowException((void*) 0, (_s__ThrowInfo*) 0);
        }
        catch (Exception ex2) when (
        {
          // ISSUE: unable to correctly present filter
          num2 = (uint) \u003CModule\u003E.__CxxDetectRethrow((void*) Marshal.GetExceptionPointers());
          if (num2 != 0U)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
        }
        if (num2 == 0U)
          return;
        throw;
      }
      finally
      {
        \u003CModule\u003E.__CxxUnregisterExceptionObject((void*) num1, (int) num2);
      }
    }
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* std\u002Emove\u003Cclass\u0020std\u003A\u003Ashared_ptr\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u0020\u0026\u003E(shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe void* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E__vecDelDtor([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* fssystemNcaReaderPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 1144U, (uint) *(int*) fssystemNcaReaderPtr1, (__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* fssystemNcaReaderPtr2 = fssystemNcaReaderPtr1;
        int num = *(int*) fssystemNcaReaderPtr2 * 1144 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) fssystemNcaReaderPtr2, (uint) num);
      }
      return (void*) fssystemNcaReaderPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 1144U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E\u002E\u007Bdtor\u007D([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
  }

  internal static unsafe void std\u002E_Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E\u002E_Delete_this([In] _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* obj0)
  {
    if ((IntPtr) obj0 == IntPtr.Zero)
      return;
    _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* managedStreamStoragePtr = obj0;
    int num = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) (*(int*) obj0 + 8))((uint) managedStreamStoragePtr, (IntPtr) num);
  }

  internal static unsafe void std\u002E_Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E\u002E_Destroy([In] _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* obj0)
  {
    ManagedStreamStorage* managedStreamStoragePtr1 = (ManagedStreamStorage*) *(int*) ((IntPtr) obj0 + 12);
    if ((IntPtr) managedStreamStoragePtr1 == IntPtr.Zero)
      return;
    ManagedStreamStorage* managedStreamStoragePtr2 = managedStreamStoragePtr1;
    int num = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) managedStreamStoragePtr1)((uint) managedStreamStoragePtr2, (IntPtr) num);
  }

  internal static unsafe _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* std\u002E_Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E\u002E\u007Bctor\u007D([In] _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* obj0, ManagedStreamStorage* _Px)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    *(int*) ((IntPtr) obj0 + 4) = 1;
    *(int*) ((IntPtr) obj0 + 8) = 1;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7\u003F\u0024_Ref_count\u0040VManagedStreamStorage\u0040FileSystemMetaLibrary\u0040Authoring\u0040Nintendo\u0040\u0040\u0040std\u0040\u00406B\u0040;
      *(int*) ((IntPtr) obj0 + 12) = (int) _Px;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_base\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void* std\u002E_Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E\u002E__vecDelDtor([In] _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* managedStreamStoragePtr1 = (_Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 16U, (uint) *(int*) managedStreamStoragePtr1, (__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* managedStreamStoragePtr2 = managedStreamStoragePtr1;
        int num = *(int*) managedStreamStoragePtr2 * 16 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) managedStreamStoragePtr2, (uint) num);
      }
      return (void*) managedStreamStoragePtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 16U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002E_Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E\u002E\u007Bdtor\u007D([In] _Ref_count\u003CNintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Resetp0\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AManagedStreamStorage\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, ManagedStreamStorage* _Px, _Ref_count_base* _Rx)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Rx;
    *(int*) obj0 = (int) _Px;
  }

  internal static unsafe NintendoContentArchiveReader* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003ANintendoContentArchiveReader\u0020\u005E\u003E(object obj, NintendoContentArchiveReader* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe uint \u003FA0x9d8ee27c\u002Estrnlen_s(sbyte* _String, uint _MaxCount)
  {
    if ((IntPtr) _String == IntPtr.Zero)
      return 0;
    return \u003CModule\u003E.strnlen(_String, _MaxCount);
  }

  internal static unsafe uint std\u002Echar_traits\u003Cchar\u003E\u002Elength(sbyte* _First)
  {
    uint num;
    if (*_First == (sbyte) 0)
    {
      num = 0U;
    }
    else
    {
      sbyte* numPtr = _First;
      do
      {
        ++numPtr;
      }
      while (*numPtr != (sbyte) 0);
      num = (uint) ((IntPtr) numPtr - (IntPtr) _First);
    }
    return num;
  }

  internal static uint nn\u002Eresult\u002Edetail\u002EResultTraits\u002EGetBitsValue(uint value, int offset, int count)
  {
    return value >> offset & (uint) ~(-1 << count);
  }

  internal static uint nn\u002Eresult\u002Edetail\u002EResultTraits\u002EGetModuleFromValue(uint value)
  {
    return value & 511U;
  }

  internal static uint nn\u002Eresult\u002Edetail\u002EResultTraits\u002EGetDescriptionFromValue(uint value)
  {
    return value >> 9 & 8191U;
  }

  internal static unsafe Result* nn\u002EResult\u002E\u007Bctor\u007D([In] Result* obj0)
  {
    return obj0;
  }

  internal static unsafe int nn\u002EResult\u002EGetModule([In] Result* obj0)
  {
    return *(int*) obj0 & 511;
  }

  internal static unsafe int nn\u002EResult\u002EGetDescription([In] Result* obj0)
  {
    return (int) ((uint) *(int*) obj0 >> 9) & 8191;
  }

  internal static ReadOption nn\u002Efs\u002EReadOption\u002EMakeValue(int reserved)
  {
    ReadOption readOption;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref readOption = 0;
    return readOption;
  }

  internal static unsafe Result* nn\u002Efs\u002Efsa\u002EIFileSystem\u002EOpenFile([In] nn.fs.fsa.IFileSystem* obj0, [In] Result* obj1, unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* outValue, sbyte* path, OpenMode mode)
  {
    if ((IntPtr) path != IntPtr.Zero)
    {
      if ((IntPtr) outValue != IntPtr.Zero)
      {
        if ((mode & (OpenMode) 3) != (OpenMode) 0)
        {
          nn.fs.fsa.IFileSystem* ifileSystemPtr = obj0;
          Result result;
          ref Result local = ref result;
          unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* deleteNnFsFsaIfilePtr = outValue;
          sbyte* numPtr = path;
          int num1 = (int) mode;
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          int num2 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E*, sbyte*, OpenMode)>) *(int*) (*(int*) obj0 + 44))((OpenMode) ifileSystemPtr, (sbyte*) ref local, deleteNnFsFsaIfilePtr, (Result*) numPtr, (IntPtr) num1);
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, num2, 4);
          return obj1;
        }
        *(int*) obj1 = 3072514;
        return obj1;
      }
      *(int*) obj1 = 3104258;
      return obj1;
    }
    *(int*) obj1 = 3073026;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efs\u002Efsa\u002EIFileSystem\u002EOpenDirectory([In] nn.fs.fsa.IFileSystem* obj0, [In] Result* obj1, unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* outValue, sbyte* path, OpenDirectoryMode mode)
  {
    if ((IntPtr) path != IntPtr.Zero)
    {
      if ((IntPtr) outValue != IntPtr.Zero)
      {
        nn.fs.fsa.IFileSystem* ifileSystemPtr = obj0;
        Result result;
        ref Result local = ref result;
        unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* nnFsFsaIdirectoryPtr = outValue;
        sbyte* numPtr = path;
        int num1 = (int) mode;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        int num2 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E*, sbyte*, OpenDirectoryMode)>) *(int*) (*(int*) obj0 + 48))((OpenDirectoryMode) ifileSystemPtr, (sbyte*) ref local, nnFsFsaIdirectoryPtr, (Result*) numPtr, (IntPtr) num1);
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) obj1, num2, 4);
        return obj1;
      }
      *(int*) obj1 = 3104258;
      return obj1;
    }
    *(int*) obj1 = 3073026;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efs\u002Efsa\u002EIFile\u002ERead([In] nn.fs.fsa.IFile* obj0, [In] Result* obj1, uint* outValue, long offset, void* buffer, uint size, ReadOption* option)
  {
    if ((IntPtr) outValue != IntPtr.Zero)
    {
      if (size == 0U)
      {
        *outValue = 0U;
        *(int*) obj1 = 0;
        return obj1;
      }
      if ((IntPtr) buffer != IntPtr.Zero)
      {
        if (offset >= 0L)
        {
          nn.fs.fsa.IFile* ifilePtr = obj0;
          Result result;
          ref Result local = ref result;
          uint* numPtr = outValue;
          long num1 = offset;
          void* voidPtr = buffer;
          int num2 = (int) size;
          ReadOption* readOptionPtr = option;
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          int num3 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, uint*, long, void*, uint, ReadOption*)>) *(int*) (*(int*) obj0 + 4))((ReadOption*) ifilePtr, (uint) ref local, (void*) numPtr, num1, (uint*) voidPtr, (Result*) num2, (IntPtr) readOptionPtr);
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, num3, 4);
          return obj1;
        }
        *(int*) obj1 = 1538562;
        return obj1;
      }
      *(int*) obj1 = 3104258;
      return obj1;
    }
    *(int*) obj1 = 3104258;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efs\u002Efsa\u002EIFile\u002EGetSize([In] nn.fs.fsa.IFile* obj0, [In] Result* obj1, long* outValue)
  {
    if ((IntPtr) outValue != IntPtr.Zero)
    {
      nn.fs.fsa.IFile* ifilePtr = obj0;
      Result result;
      ref Result local = ref result;
      long* numPtr = outValue;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long*)>) *(int*) (*(int*) obj0 + 20))((long*) ifilePtr, (Result*) ref local, (IntPtr) numPtr);
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, num, 4);
      return obj1;
    }
    *(int*) obj1 = 3104258;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efs\u002Efsa\u002EIDirectory\u002ERead([In] nn.fs.fsa.IDirectory* obj0, [In] Result* obj1, long* outValue, nn.fs.DirectoryEntry* outEntries, long count)
  {
    if ((IntPtr) outValue != IntPtr.Zero)
    {
      if (count == 0L)
      {
        *outValue = 0L;
        *(int*) obj1 = 0;
        return obj1;
      }
      if ((IntPtr) outEntries != IntPtr.Zero)
      {
        if (count > 0L)
        {
          nn.fs.fsa.IDirectory* idirectoryPtr = obj0;
          Result result;
          ref Result local = ref result;
          long* numPtr = outValue;
          nn.fs.DirectoryEntry* directoryEntryPtr = outEntries;
          long num1 = count;
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          int num2 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long*, nn.fs.DirectoryEntry*, long)>) *(int*) (*(int*) obj0 + 4))((long) idirectoryPtr, (nn.fs.DirectoryEntry*) ref local, numPtr, (Result*) directoryEntryPtr, (IntPtr) num1);
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, num2, 4);
          return obj1;
        }
        *(int*) obj1 = 3072514;
        return obj1;
      }
      *(int*) obj1 = 3104258;
      return obj1;
    }
    *(int*) obj1 = 3104258;
    return obj1;
  }

  internal static unsafe FileSystemArchiveReaderImplBase* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002E\u007Bctor\u007D([In] FileSystemArchiveReaderImplBase* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* storage)
  {
    shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = *(int*) storage;
      sharedPtrNnFsIstoragePtr = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) storage + 4);
      *(int*) ((IntPtr) obj0 + 4) = *(int*) sharedPtrNnFsIstoragePtr;
      *(int*) storage = 0;
      *(int*) sharedPtrNnFsIstoragePtr = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) storage);
    }
    int num = *(int*) sharedPtrNnFsIstoragePtr;
    if (num != 0)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    return obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EInitialize([In] FileSystemArchiveReaderImplBase* obj0, nn.fs.fsa.IFileSystem* fileSystem)
  {
    *(int*) ((IntPtr) obj0 + 8) = (int) fileSystem;
  }

  internal static unsafe List<Tuple<string, long>> Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EListFileInfo([In] FileSystemArchiveReaderImplBase* obj0)
  {
    return \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EListFileInfo(obj0, string.Empty);
  }

  internal static unsafe List<Tuple<string, long>> Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EListFileInfo([In] FileSystemArchiveReaderImplBase* obj0, string rootPath)
  {
    sbyte* pointer = (sbyte*) \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetUtf8CharsFromString(rootPath).ToPointer();
    \u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E obj1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref obj1 = (int) &pointer;
    ScopeExitHolder\u003C\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E obj2;
    \u003CModule\u003E.nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E(&obj2, (ScopeExitHolderMarker) 0, &obj1);
    List<Tuple<string, long>> list;
    // ISSUE: fault handler
    try
    {
      list = new List<Tuple<string, long>>();
      nn.fs.DirectoryEntry directoryEntry;
      // ISSUE: initblk instruction
      __memset(ref directoryEntry, 0, 784);
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Left = \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_01KMDKNFGN\u0040\u003F1\u003F\u0024AA\u0040);
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.std\u002Eoperator\u002B\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E(&stdAllocatorChar2, _Left, pointer);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      // ISSUE: fault handler
      try
      {
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar1, true, 0U);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        sbyte* numPtr = 16U <= (uint) ^(int&) ((IntPtr) &stdAllocatorChar2 + 20) ? (sbyte*) ^(int&) ref stdAllocatorChar2 : (sbyte*) (int) &stdAllocatorChar2;
        \u0024ArrayType\u0024\u0024\u0024BY0DAA\u0040D arrayTypeBy0DaaD;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.strncpy_s((sbyte*) &arrayTypeBy0DaaD, 768U, numPtr, (uint) ^(int&) ((IntPtr) &stdAllocatorChar2 + 16));
        \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EListFileInfoRecursive(obj0, list, &directoryEntry, (sbyte*) &arrayTypeBy0DaaD, 768U);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
      }
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar2, true, 0U);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &obj2);
    }
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(byte&) ((IntPtr) &obj2 + 4) != (byte) 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) ^(int&) ref obj2));
    }
    return list;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EListFileInfo\u002E\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u002E\u0028\u0029([In] \u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E* obj0)
  {
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe \u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EListFileInfo\u002E\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u002E\u007Bctor\u007D([In] \u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E* obj0, sbyte** _param1)
  {
    *(int*) obj0 = (int) _param1;
    return obj0;
  }

  internal static unsafe long Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetFileSize([In] FileSystemArchiveReaderImplBase* obj0, string fileName)
  {
    sbyte* pointer = (sbyte*) \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetUtf8CharsFromString(fileName).ToPointer();
    \u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E obj1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref obj1 = (int) &pointer;
    ScopeExitHolder\u003C\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E obj2;
    \u003CModule\u003E.nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E(&obj2, (ScopeExitHolderMarker) 0, &obj1);
    long num1;
    // ISSUE: fault handler
    try
    {
      unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E deleteNnFsFsaIfile;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref deleteNnFsFsaIfile = 0;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Left = \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_01KMDKNFGN\u0040\u003F1\u003F\u0024AA\u0040);
        Result result1;
        // ISSUE: fault handler
        try
        {
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.std\u002Eoperator\u002B\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E(&stdAllocatorChar2, _Left, pointer);
          // ISSUE: fault handler
          try
          {
            sbyte* path = 16U > (uint) *(int*) ((IntPtr) stdAllocatorCharPtr + 20) ? (sbyte*) stdAllocatorCharPtr : (sbyte*) *(int*) stdAllocatorCharPtr;
            \u003CModule\u003E.nn\u002Efs\u002Efsa\u002EIFileSystem\u002EOpenFile((nn.fs.fsa.IFileSystem*) *(int*) ((IntPtr) obj0 + 8), &result1, &deleteNnFsFsaIfile, path, (OpenMode) 1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
          }
          // ISSUE: fault handler
          try
          {
            \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar2, true, 0U);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
          }
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
        }
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar1, true, 0U);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result1 != 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          throw new ArgumentException(string.Format("Failed to OpenFile 0x{0:X8}.", (object) (uint) ^(int&) ref result1));
        }
        long num2 = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        int num3 = ^(int&) ref deleteNnFsFsaIfile;
        Result result2;
        ref Result local1 = ref result2;
        ref long local2 = ref num2;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        int num4 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long*)>) *(int*) (*(int*) ^(int&) ref deleteNnFsFsaIfile + 20))((long*) num3, (Result*) ref local1, (IntPtr) ref local2);
        Result result3;
        // ISSUE: cpblk instruction
        __memcpy(ref result3, num4, 4);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result3 != 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          throw new ArgumentException(string.Format("Failed to GetSize 0x{0:X8}.", (object) (uint) ^(int&) ref result3));
        }
        num1 = num2;
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteNnFsFsaIfile);
      }
      \u003CModule\u003E.std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteNnFsFsaIfile);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &obj2);
    }
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(byte&) ((IntPtr) &obj2 + 4) != (byte) 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) ^(int&) ref obj2));
    }
    return num1;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetFileSize\u002E\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u002E\u0028\u0029([In] \u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E* obj0)
  {
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe \u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetFileSize\u002E\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u002E\u007Bctor\u007D([In] \u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E* obj0, sbyte** _param1)
  {
    *(int*) obj0 = (int) _param1;
    return obj0;
  }

  internal static unsafe byte[] Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EReadFile([In] FileSystemArchiveReaderImplBase* obj0, string fileName, long offset, long size)
  {
    byte[] array = (byte[]) null;
    if (size >= (long) int.MaxValue)
      throw new InvalidOperationException("Input size is too large.");
    if (size < 0L)
      throw new InvalidOperationException("Input size must be positive.");
    sbyte* pointer = (sbyte*) \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetUtf8CharsFromString(fileName).ToPointer();
    \u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E c51f9eb15b91ff9e52151ff4c2124292_1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref c51f9eb15b91ff9e52151ff4c2124292_1 = (int) &pointer;
    ScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E c51f9eb15b91ff9e52151ff4c2124292_2;
    \u003CModule\u003E.nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E(&c51f9eb15b91ff9e52151ff4c2124292_2, (ScopeExitHolderMarker) 0, &c51f9eb15b91ff9e52151ff4c2124292_1);
    unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E deleteNnFsFsaIfile;
    Result result1;
    uint size1;
    byte[] numArray1;
    // ISSUE: fault handler
    try
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref deleteNnFsFsaIfile = 0;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Left = \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_01KMDKNFGN\u0040\u003F1\u003F\u0024AA\u0040);
        // ISSUE: fault handler
        try
        {
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.std\u002Eoperator\u002B\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E(&stdAllocatorChar2, _Left, pointer);
          // ISSUE: fault handler
          try
          {
            sbyte* path = 16U > (uint) *(int*) ((IntPtr) stdAllocatorCharPtr + 20) ? (sbyte*) stdAllocatorCharPtr : (sbyte*) *(int*) stdAllocatorCharPtr;
            \u003CModule\u003E.nn\u002Efs\u002Efsa\u002EIFileSystem\u002EOpenFile((nn.fs.fsa.IFileSystem*) *(int*) ((IntPtr) obj0 + 8), &result1, &deleteNnFsFsaIfile, path, (OpenMode) 1);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
          }
          // ISSUE: fault handler
          try
          {
            \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar2, true, 0U);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
          }
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
        }
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar1, true, 0U);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result1 != 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          throw new ArgumentException(string.Format("Failed to OpenFile 0x{0:X8}.", (object) (uint) ^(int&) ref result1));
        }
        size1 = (uint) (int) size;
        array = new byte[(int) size1];
        if (size == 0L)
          numArray1 = array;
        else
          goto label_25;
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteNnFsFsaIfile);
      }
      \u003CModule\u003E.std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteNnFsFsaIfile);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &c51f9eb15b91ff9e52151ff4c2124292_2);
    }
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(byte&) ((IntPtr) &c51f9eb15b91ff9e52151ff4c2124292_2 + 4) != (byte) 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) ^(int&) ref c51f9eb15b91ff9e52151ff4c2124292_2));
    }
    return numArray1;
label_25:
    byte[] numArray2;
    // ISSUE: fault handler
    try
    {
      // ISSUE: fault handler
      try
      {
        uint num = 0;
        fixed (byte* numPtr = &array[0])
        {
          ReadOption readOption;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ref readOption = 0;
          Result result2;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          Result* resultPtr = \u003CModule\u003E.nn\u002Efs\u002Efsa\u002EIFile\u002ERead((nn.fs.fsa.IFile*) ^(int&) ref deleteNnFsFsaIfile, &result2, &num, offset, (void*) numPtr, size1, &readOption);
          // ISSUE: cpblk instruction
          __memcpy(ref result1, (IntPtr) resultPtr, 4);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result1 != 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            throw new ArgumentException(string.Format("Failed to ReadFile 0x{0:X8}.", (object) (uint) ^(int&) ref result1));
          }
          if (size1 > num)
            Array.Resize<byte>(ref array, (int) num);
          numArray2 = array;
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &deleteNnFsFsaIfile);
      }
      \u003CModule\u003E.std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&deleteNnFsFsaIfile);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &c51f9eb15b91ff9e52151ff4c2124292_2);
    }
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(byte&) ((IntPtr) &c51f9eb15b91ff9e52151ff4c2124292_2 + 4) != (byte) 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) ^(int&) ref c51f9eb15b91ff9e52151ff4c2124292_2));
    }
    return numArray2;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EReadFile\u002E\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u002E\u0028\u0029([In] \u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E* obj0)
  {
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe \u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EReadFile\u002E\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u002E\u007Bctor\u007D([In] \u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E* obj0, sbyte** _param1)
  {
    *(int*) obj0 = (int) _param1;
    return obj0;
  }

  internal static unsafe long Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetBaseSize([In] FileSystemArchiveReaderImplBase* obj0)
  {
    long num1 = 0;
    int num2 = *(int*) obj0;
    int num3 = num2;
    Result result1;
    ref Result local1 = ref result1;
    ref long local2 = ref num1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num4 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long*)>) *(int*) (*(int*) num2 + 20))((long*) num3, (Result*) ref local1, (IntPtr) ref local2);
    Result result2;
    // ISSUE: cpblk instruction
    __memcpy(ref result2, num4, 4);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result2 != 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      throw new ArgumentException(string.Format("Failed to GetSize 0x{0:X8}.", (object) (uint) ^(int&) ref result2));
    }
    return num1;
  }

  internal static unsafe byte[] Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EReadBase([In] FileSystemArchiveReaderImplBase* obj0, long offset, long size)
  {
    if (size >= (long) int.MaxValue)
      throw new InvalidOperationException("Input size is too large.");
    if (size < 0L)
      throw new InvalidOperationException("Input size must be positive.");
    uint num1 = (uint) (int) size;
    byte[] numArray = new byte[(int) num1];
    if (size == 0L)
      return numArray;
    fixed (byte* numPtr = &numArray[0])
    {
      // ISSUE: cast to a reference type
      // ISSUE: initblk instruction
      __memset((byte*) numPtr, 0, (int) num1);
      int num2 = *(int*) obj0;
      int num3 = num2;
      Result result1;
      ref Result local1 = ref result1;
      long num4 = offset;
      // ISSUE: cast to a reference type
      // ISSUE: variable of a reference type
      byte* local2 = (byte*) numPtr;
      int num5 = (int) num1;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num6 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 4))((uint) num3, (void*) ref local1, num4, (Result*) local2, (IntPtr) num5);
      Result result2;
      // ISSUE: cpblk instruction
      __memcpy(ref result2, num6, 4);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        throw new ArgumentException(string.Format("Failed to ReadFile 0x{0:X8}.", (object) (uint) ^(int&) ref result2));
      }
      return numArray;
    }
  }

  internal static IntPtr Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetUtf8CharsFromString(string str)
  {
    byte[] bytes = Encoding.UTF8.GetBytes(str);
    IntPtr num = Marshal.AllocHGlobal(bytes.Length + 1);
    Marshal.Copy(bytes, 0, num, bytes.Length);
    Marshal.WriteByte(num, bytes.Length, (byte) 0);
    return num;
  }

  internal static unsafe string Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetStringFromUtf8Chars(sbyte* pChar, uint size)
  {
    byte[] bytes = new byte[(int) size];
    fixed (byte* numPtr = &bytes[0])
    {
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((byte*) numPtr, (IntPtr) pChar, (int) size);
      return Encoding.UTF8.GetString(bytes);
    }
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EListFileInfoRecursive([In] FileSystemArchiveReaderImplBase* obj0, List<Tuple<string, long>> list, nn.fs.DirectoryEntry* entry, sbyte* path, uint pathSize)
  {
    unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E nnFsFsaIdirectory;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref nnFsFsaIdirectory = 0;
    Result result1;
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.nn\u002Efs\u002Efsa\u002EIFileSystem\u002EOpenDirectory((nn.fs.fsa.IFileSystem*) *(int*) ((IntPtr) obj0 + 8), &result1, &nnFsFsaIdirectory, path, (OpenDirectoryMode) 3);
      if (!\u003CModule\u003E.nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C1\u002C2\u003E\u002EIncludes(result1))
        goto label_4;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &nnFsFsaIdirectory);
    }
    \u003CModule\u003E.std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&nnFsFsaIdirectory);
    goto label_15;
label_4:
    // ISSUE: fault handler
    try
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result1 != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        throw new ArgumentException(string.Format("Failed to OpenDirectory 0x{0:X8}.", (object) (uint) ^(int&) ref result1));
      }
      while (true)
      {
        long num1 = 0;
        Result result2;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Result* resultPtr = \u003CModule\u003E.nn\u002Efs\u002Efsa\u002EIDirectory\u002ERead((nn.fs.fsa.IDirectory*) ^(int&) ref nnFsFsaIdirectory, &result2, &num1, entry, 1L);
        // ISSUE: cpblk instruction
        __memcpy(ref result1, (IntPtr) resultPtr, 4);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result1 == 0)
        {
          if (num1 != 0L)
          {
            uint num2 = (IntPtr) path != IntPtr.Zero ? \u003CModule\u003E.strnlen(path, pathSize) : 0U;
            \u003CModule\u003E.strncat_s(path, pathSize, (sbyte*) entry, pathSize - num2);
            if (*(sbyte*) ((IntPtr) entry + 772) == (sbyte) 0)
            {
              uint num3 = \u003CModule\u003E.strnlen((sbyte*) entry, pathSize);
              \u003CModule\u003E.strncat_s(path, pathSize, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_01KMDKNFGN\u0040\u003F1\u003F\u0024AA\u0040, pathSize - num2 - num3);
              \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EListFileInfoRecursive(obj0, list, entry, path, pathSize);
            }
            else
            {
              uint num3 = \u003CModule\u003E.strnlen((sbyte*) entry, pathSize);
              string stringFromUtf8Chars = \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetStringFromUtf8Chars(path, num3 + num2);
              char[] chArray = new char[1]{ '/' };
              list.Add(Tuple.Create<string, long>(stringFromUtf8Chars.Trim(chArray), *(long*) ((IntPtr) entry + 776)));
            }
            *(sbyte*) ((int) num2 + (IntPtr) path) = (sbyte) 0;
          }
          else
            goto label_14;
        }
        else
          break;
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      throw new ArgumentException(string.Format("Failed to ReadDirectory 0x{0:X8}.", (object) (uint) ^(int&) ref result1));
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &nnFsFsaIdirectory);
    }
label_14:
    \u003CModule\u003E.std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E\u007Bdtor\u007D(&nnFsFsaIdirectory);
label_15:
    // ISSUE: fault handler
    try
    {
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &nnFsFsaIdirectory);
    }
  }

  internal static unsafe PartitionFileSystemArchiveReaderImpl* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EPartitionFileSystemArchiveReaderImpl\u002E\u007Bctor\u007D([In] PartitionFileSystemArchiveReaderImpl* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* storage)
  {
    shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr1;
    // ISSUE: fault handler
    try
    {
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage1;
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr2 = &sharedPtrNnFsIstorage1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref sharedPtrNnFsIstorage1 = *(int*) storage;
      sharedPtrNnFsIstoragePtr1 = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) storage + 4);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) = *(int*) sharedPtrNnFsIstoragePtr1;
      *(int*) storage = 0;
      *(int*) sharedPtrNnFsIstoragePtr1 = 0;
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr3 = &sharedPtrNnFsIstorage1;
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(int*) obj0 = ^(int&) ref sharedPtrNnFsIstorage1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(int*) ((IntPtr) obj0 + 4) = ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref sharedPtrNnFsIstorage1 = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) = 0;
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) sharedPtrNnFsIstoragePtr3);
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4));
      }
      // ISSUE: fault handler
      try
      {
        PartitionFileSystemArchiveReaderImpl* archiveReaderImplPtr = (PartitionFileSystemArchiveReaderImpl*) ((IntPtr) obj0 + 12);
        \u003CModule\u003E.std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E((shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E*) archiveReaderImplPtr);
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EEnsureBufferPool();
          shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage2;
          shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr4 = &sharedPtrNnFsIstorage2;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ref sharedPtrNnFsIstorage2 = 0;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ((IntPtr) &sharedPtrNnFsIstorage2 + 4) = 0;
          \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AIStorage\u003E((_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) &sharedPtrNnFsIstorage2, (_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) obj0);
          PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* fileSystemFormatPtr1;
          // ISSUE: fault handler
          try
          {
            fileSystemFormatPtr1 = (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E*) *(int*) archiveReaderImplPtr;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) sharedPtrNnFsIstoragePtr4);
          }
          Result result;
          \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u002EInitialize(fileSystemFormatPtr1, &result, &sharedPtrNnFsIstorage2);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result != 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            throw new ArgumentException(string.Format("Failed to Initialize PartitionFileSystem 0x{0:X8}.", (object) (uint) ^(int&) ref result));
          }
          PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* fileSystemFormatPtr2 = (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E*) *(int*) archiveReaderImplPtr;
          *(int*) ((IntPtr) obj0 + 8) = (int) fileSystemFormatPtr2;
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) ((IntPtr) obj0 + 12));
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) storage);
    }
    int num = *(int*) sharedPtrNnFsIstoragePtr1;
    if (num != 0)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    return obj0;
  }

  internal static unsafe List<Tuple<long, long>> Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EPartitionFileSystemArchiveReaderImpl\u002EGetFileFragmentList([In] PartitionFileSystemArchiveReaderImpl* obj0, string fileName)
  {
    sbyte* pointer = (sbyte*) \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetUtf8CharsFromString(fileName).ToPointer();
    \u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E obj1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref obj1 = (int) &pointer;
    ScopeExitHolder\u003C\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E obj2;
    \u003CModule\u003E.nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E(&obj2, (ScopeExitHolderMarker) 0, &obj1);
    List<Tuple<long, long>> tupleList;
    // ISSUE: fault handler
    try
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Left = \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_01KMDKNFGN\u0040\u003F1\u003F\u0024AA\u0040);
      Result result;
      long num;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.std\u002Eoperator\u002B\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E(&stdAllocatorChar2, _Left, pointer);
        // ISSUE: fault handler
        try
        {
          sbyte* numPtr = 16U > (uint) *(int*) ((IntPtr) stdAllocatorCharPtr + 20) ? (sbyte*) stdAllocatorCharPtr : (sbyte*) *(int*) stdAllocatorCharPtr;
          \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u002EGetFileBaseOffset((PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E*) *(int*) ((IntPtr) obj0 + 12), &result, &num, numPtr);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar2, true, 0U);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar1, true, 0U);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        throw new ArgumentException(string.Format("Failed to OpenFileStorage 0x{0:X8}.", (object) (uint) ^(int&) ref result));
      }
      tupleList = new List<Tuple<long, long>>();
      tupleList.Add(new Tuple<long, long>(num, \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetFileSize((FileSystemArchiveReaderImplBase*) obj0, fileName)));
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &obj2);
    }
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(byte&) ((IntPtr) &obj2 + 4) != (byte) 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) ^(int&) ref obj2));
    }
    return tupleList;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EPartitionFileSystemArchiveReaderImpl\u002EGetFileFragmentList\u002E\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u002E\u0028\u0029([In] \u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E* obj0)
  {
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe \u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EPartitionFileSystemArchiveReaderImpl\u002EGetFileFragmentList\u002E\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u002E\u007Bctor\u007D([In] \u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E* obj0, sbyte** _param1)
  {
    *(int*) obj0 = (int) _param1;
    return obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EPartitionFileSystemArchiveReaderImpl\u002EOpenFileStorage([In] PartitionFileSystemArchiveReaderImpl* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* outValue, string fileName)
  {
    sbyte* pointer = (sbyte*) \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetUtf8CharsFromString(fileName).ToPointer();
    \u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E obj1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref obj1 = (int) &pointer;
    ScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E obj2;
    \u003CModule\u003E.nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E(&obj2, (ScopeExitHolderMarker) 0, &obj1);
    shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E storageBasedFileSystem;
    shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E fileSystemFormat;
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E(&storageBasedFileSystem);
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref fileSystemFormat = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &fileSystemFormat + 4) = 0;
        \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E((_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E*) &fileSystemFormat, (_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E*) ((IntPtr) obj0 + 12));
        // ISSUE: fault handler
        try
        {
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Left = \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_01KMDKNFGN\u0040\u003F1\u003F\u0024AA\u0040);
          Result result;
          // ISSUE: fault handler
          try
          {
            basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
            basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.std\u002Eoperator\u002B\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E(&stdAllocatorChar2, _Left, pointer);
            // ISSUE: fault handler
            try
            {
              shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E fsFsaIfileSystem;
              shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* fsFsaIfileSystemPtr = &fsFsaIfileSystem;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ref fsFsaIfileSystem = ^(int&) ref fileSystemFormat;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ((IntPtr) &fsFsaIfileSystem + 4) = ^(int&) ((IntPtr) &fileSystemFormat + 4);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ref fileSystemFormat = 0;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ((IntPtr) &fileSystemFormat + 4) = 0;
              sbyte* numPtr;
              // ISSUE: fault handler
              try
              {
                numPtr = 16U > (uint) *(int*) ((IntPtr) stdAllocatorCharPtr + 20) ? (sbyte*) stdAllocatorCharPtr : (sbyte*) *(int*) stdAllocatorCharPtr;
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E\u007Bdtor\u007D), (void*) fsFsaIfileSystemPtr);
              }
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              \u003CModule\u003E.nn\u002Efssystem\u002EFileStorageBasedFileSystem\u002EInitialize((FileStorageBasedFileSystem*) ^(int&) ref storageBasedFileSystem, &result, &fsFsaIfileSystem, numPtr, (OpenMode) 1);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
            }
            // ISSUE: fault handler
            try
            {
              \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar2, true, 0U);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
            }
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
          }
          // ISSUE: fault handler
          try
          {
            \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar1, true, 0U);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
          }
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result != 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            throw new ArgumentException(string.Format("Failed to OpenFileStorage 0x{0:X8}.", (object) (uint) ^(int&) ref result));
          }
          \u003CModule\u003E.std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002Eoperator\u003D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E(outValue, &storageBasedFileSystem);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &fileSystemFormat);
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ((IntPtr) &fileSystemFormat + 4) != 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &fileSystemFormat + 4));
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bdtor\u007D), (void*) &storageBasedFileSystem);
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ((IntPtr) &storageBasedFileSystem + 4) != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &storageBasedFileSystem + 4));
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &obj2);
    }
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(byte&) ((IntPtr) &obj2 + 4) != (byte) 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) ^(int&) ref obj2));
    }
    // ISSUE: fault handler
    try
    {
      // ISSUE: fault handler
      try
      {
        // ISSUE: fault handler
        try
        {
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &fileSystemFormat);
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bdtor\u007D), (void*) &storageBasedFileSystem);
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &obj2);
    }
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EPartitionFileSystemArchiveReaderImpl\u002EOpenFileStorage\u002E\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u002E\u0028\u0029([In] \u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E* obj0)
  {
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe \u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EPartitionFileSystemArchiveReaderImpl\u002EOpenFileStorage\u002E\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u002E\u007Bctor\u007D([In] \u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E* obj0, sbyte** _param1)
  {
    *(int*) obj0 = (int) _param1;
    return obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002E\u007Bdtor\u007D([In] FileSystemArchiveReaderImplBase* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe void* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EPartitionFileSystemArchiveReaderImpl\u002E__delDtor([In] PartitionFileSystemArchiveReaderImpl* obj0, uint A_0)
  {
    \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EPartitionFileSystemArchiveReaderImpl\u002E\u007Bdtor\u007D(obj0);
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 20U);
    return (void*) obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EPartitionFileSystemArchiveReaderImpl\u002E\u007Bdtor\u007D([In] PartitionFileSystemArchiveReaderImpl* obj0)
  {
    // ISSUE: fault handler
    try
    {
      uint num = (uint) *(int*) ((IntPtr) obj0 + 12 + 4);
      if (num != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    uint num1 = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num1 == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num1);
  }

  internal static unsafe FileStorageBasedFileSystem* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u002D\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    return (FileStorageBasedFileSystem*) *(int*) obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bdtor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe void nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] ScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E* obj0)
  {
    if (*(byte*) ((IntPtr) obj0 + 4) == (byte) 0)
      return;
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe void nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] ScopeExitHolder\u003C\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E* obj0)
  {
    if (*(byte*) ((IntPtr) obj0 + 4) == (byte) 0)
      return;
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u002D\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E*) *(int*) obj0;
  }

  internal static unsafe PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002Eget([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E*) *(int*) obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  [SpecialName]
  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* _Other)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E((_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E*) obj0, (_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E*) _Other);
    return obj0;
  }

  internal static unsafe void nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] ScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E* obj0)
  {
    if (*(byte*) ((IntPtr) obj0 + 4) == (byte) 0)
      return;
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe void nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] ScopeExitHolder\u003C\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E* obj0)
  {
    if (*(byte*) ((IntPtr) obj0 + 4) == (byte) 0)
      return;
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe void nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] ScopeExitHolder\u003C\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E* obj0)
  {
    if (*(byte*) ((IntPtr) obj0 + 4) == (byte) 0)
      return;
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E\u007Bdtor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  [SpecialName]
  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* _Other)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E((_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E*) obj0, (_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E*) _Other);
    return obj0;
  }

  internal static unsafe nn.fs.fsa.IDirectory* std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E\u002D\u003E([In] unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* obj0)
  {
    return (nn.fs.fsa.IDirectory*) *(int*) obj0;
  }

  internal static unsafe void std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* obj0)
  {
    int num1 = *(int*) obj0;
    if (num1 == 0)
      return;
    nn.fs.fsa.IDirectory* idirectoryPtr1 = (nn.fs.fsa.IDirectory*) num1;
    nn.fs.fsa.IDirectory* idirectoryPtr2 = idirectoryPtr1;
    int num2 = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) idirectoryPtr1)((uint) idirectoryPtr2, (IntPtr) num2);
  }

  internal static unsafe unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = 0;
    return obj0;
  }

  internal static unsafe nn.fs.fsa.IFile* std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u002D\u003E([In] unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* obj0)
  {
    return (nn.fs.fsa.IFile*) *(int*) obj0;
  }

  internal static unsafe void std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* obj0)
  {
    int num1 = *(int*) obj0;
    if (num1 == 0)
      return;
    nn.fs.fsa.IFile* ifilePtr1 = (nn.fs.fsa.IFile*) num1;
    nn.fs.fsa.IFile* ifilePtr2 = ifilePtr1;
    int num2 = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) ifilePtr1)((uint) ifilePtr2, (IntPtr) num2);
  }

  internal static unsafe unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = 0;
    return obj0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C1\u002C2\u003E\u002EIncludes(Result result)
  {
    int num1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if ((^(int&) ref result & 511) == 2)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      uint num2 = (uint) ^(int&) ref result >> 9 & 8191U;
      if (1 <= (int) num2 && (int) num2 < 2)
      {
        num1 = 1;
        goto label_4;
      }
    }
    num1 = 0;
label_4:
    return num1 != 0;
  }

  internal static unsafe int nn\u002Eresult\u002Edetail\u002EResultBase\u003Cnn\u003A\u003AResult\u003E\u002EGetDescription([In] ResultBase\u003Cnn\u003A\u003AResult\u003E* obj0)
  {
    return (int) ((uint) *(int*) obj0 >> 9) & 8191;
  }

  internal static unsafe int nn\u002Eresult\u002Edetail\u002EResultBase\u003Cnn\u003A\u003AResult\u003E\u002EGetModule([In] ResultBase\u003Cnn\u003A\u003AResult\u003E* obj0)
  {
    return *(int*) obj0 & 511;
  }

  internal static unsafe uint std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Elength([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0)
  {
    return (uint) *(int*) ((IntPtr) obj0 + 16);
  }

  internal static unsafe sbyte* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Ec_str([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0)
  {
    if (16U <= (uint) *(int*) ((IntPtr) obj0 + 20))
      return (sbyte*) *(int*) obj0;
    return (sbyte*) obj0;
  }

  internal static unsafe basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eappend([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, sbyte* _Ptr)
  {
    uint _Count;
    if (*_Ptr == (sbyte) 0)
    {
      _Count = 0U;
    }
    else
    {
      sbyte* numPtr = _Ptr;
      do
      {
        ++numPtr;
      }
      while (*numPtr != (sbyte) 0);
      _Count = (uint) ((IntPtr) numPtr - (IntPtr) _Ptr);
    }
    return \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eappend(obj0, _Ptr, _Count);
  }

  internal static unsafe basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Right)
  {
    // ISSUE: fault handler
    try
    {
      *(int*) ((IntPtr) obj0 + 16) = 0;
      *(int*) ((IntPtr) obj0 + 20) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(obj0, false, 0U);
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Assign_rv(obj0, _Right);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, sbyte* _Ptr)
  {
    // ISSUE: fault handler
    try
    {
      *(int*) ((IntPtr) obj0 + 16) = 0;
      *(int*) ((IntPtr) obj0 + 20) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(obj0, false, 0U);
      uint _Count;
      if (*_Ptr == (sbyte) 0)
      {
        _Count = 0U;
      }
      else
      {
        sbyte* numPtr = _Ptr;
        do
        {
          ++numPtr;
        }
        while (*numPtr != (sbyte) 0);
        _Count = (uint) ((IntPtr) numPtr - (IntPtr) _Ptr);
      }
      \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eassign(obj0, _Ptr, _Count);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe nn.fs.fsa.IFile* std\u002Epointer_traits\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u003E\u002Epointer_to(nn.fs.fsa.IFile* _Val)
  {
    return _Val;
  }

  internal static unsafe nn.fs.fsa.IDirectory* std\u002Epointer_traits\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u003E\u002Epointer_to(nn.fs.fsa.IDirectory* _Val)
  {
    return _Val;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E_Decref([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe FileStorageBasedFileSystem* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E_Get([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    return (FileStorageBasedFileSystem*) *(int*) obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Decref([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Get([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E*) *(int*) obj0;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe default_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E* std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002Eget_deleter([In] _Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* obj0)
  {
    return (default_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E*) obj0;
  }

  internal static unsafe default_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E* std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002Eget_deleter([In] _Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* obj0)
  {
    return (default_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E*) obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E_Decref([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe nn.fs.fsa.IDirectory* std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002Eget([In] unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* obj0)
  {
    return (nn.fs.fsa.IDirectory*) *(int*) obj0;
  }

  internal static unsafe nn.fs.fsa.IDirectory* std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E\u002A([In] unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* obj0)
  {
    return (nn.fs.fsa.IDirectory*) *(int*) obj0;
  }

  internal static unsafe void std\u002Edefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u002E\u0028\u0029([In] default_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E* obj0, nn.fs.fsa.IDirectory* _Ptr)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    nn.fs.fsa.IDirectory* idirectoryPtr = _Ptr;
    int num = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) _Ptr)((uint) idirectoryPtr, (IntPtr) num);
  }

  internal static unsafe nn.fs.fsa.IFile* std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002Eget([In] unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* obj0)
  {
    return (nn.fs.fsa.IFile*) *(int*) obj0;
  }

  internal static unsafe nn.fs.fsa.IFile* std\u002Eunique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u002A([In] unique_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* obj0)
  {
    return (nn.fs.fsa.IFile*) *(int*) obj0;
  }

  internal static unsafe void std\u002Edefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u002E\u0028\u0029([In] default_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E* obj0, nn.fs.fsa.IFile* _Ptr)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    nn.fs.fsa.IFile* ifilePtr = _Ptr;
    int num = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) _Ptr)((uint) ifilePtr, (IntPtr) num);
  }

  internal static unsafe _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    // ISSUE: fault handler
    try
    {
      *(int*) ((IntPtr) obj0 + 16) = 0;
      *(int*) ((IntPtr) obj0 + 20) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eassign([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, sbyte* _Ptr)
  {
    uint _Count;
    if (*_Ptr == (sbyte) 0)
    {
      _Count = 0U;
    }
    else
    {
      sbyte* numPtr = _Ptr;
      do
      {
        ++numPtr;
      }
      while (*numPtr != (sbyte) 0);
      _Count = (uint) ((IntPtr) numPtr - (IntPtr) _Ptr);
    }
    return \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eassign(obj0, _Ptr, _Count);
  }

  internal static basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eassign([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, sbyte* _Ptr, uint _Count)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eappend([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, sbyte* _Ptr, uint _Count)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eappend([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Right, uint _Roff, uint _Count)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static unsafe void std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Assign_rv([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Right)
  {
    if ((uint) *(int*) ((IntPtr) _Right + 20) < 16U)
    {
      uint num = (uint) (*(int*) ((IntPtr) _Right + 16) + 1);
      if (num != 0U)
        \u003CModule\u003E.memmove((void*) obj0, (void*) _Right, num);
    }
    else
    {
      if ((IntPtr) obj0 != IntPtr.Zero)
        *(int*) obj0 = *(int*) _Right;
      *(int*) _Right = 0;
    }
    *(int*) ((IntPtr) obj0 + 16) = *(int*) ((IntPtr) _Right + 16);
    *(int*) ((IntPtr) obj0 + 20) = *(int*) ((IntPtr) _Right + 20);
    \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(_Right, false, 0U);
  }

  internal static unsafe default_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u002C1\u003E* obj0)
  {
    return (default_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E*) obj0;
  }

  internal static unsafe nn.fs.fsa.IDirectory** std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E_Myptr([In] _Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* obj0)
  {
    return (nn.fs.fsa.IDirectory**) obj0;
  }

  internal static unsafe default_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u002C1\u003E* obj0)
  {
    return (default_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E*) obj0;
  }

  internal static unsafe nn.fs.fsa.IFile** std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E_Myptr([In] _Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* obj0)
  {
    return (nn.fs.fsa.IFile**) obj0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Inside([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, sbyte* _Ptr)
  {
    if ((IntPtr) _Ptr != IntPtr.Zero)
    {
      uint num = (uint) *(int*) ((IntPtr) obj0 + 20);
      sbyte* numPtr1 = 16U > num ? (sbyte*) obj0 : (sbyte*) *(int*) obj0;
      if (_Ptr >= numPtr1)
      {
        sbyte* numPtr2 = 16U > num ? (sbyte*) obj0 : (sbyte*) *(int*) obj0;
        if ((UIntPtr) *(int*) ((IntPtr) obj0 + 16) + (UIntPtr) numPtr2 > (UIntPtr) _Ptr)
          return true;
      }
    }
    return false;
  }

  internal static unsafe nn.fs.fsa.IDirectory** std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u002C1\u003E* obj0)
  {
    return (nn.fs.fsa.IDirectory**) obj0;
  }

  internal static unsafe nn.fs.fsa.IFile** std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u002C1\u003E* obj0)
  {
    return (nn.fs.fsa.IFile**) obj0;
  }

  internal static unsafe ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidPath\u003E* nn\u002Eresult\u002Edetail\u002EMakeResultAutoConverter\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AResultInvalidPath\u003E([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidPath\u003E* obj0, ResultInvalidPath* result, void* __unnamed001)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 1);
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidPath\u003E\u002Eoperator\u003Cclass\u0020nn\u003A\u003AResult\u003E([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidPath\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 3073026;
    return obj1;
  }

  internal static unsafe ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultOutOfRange\u003E* nn\u002Eresult\u002Edetail\u002EMakeResultAutoConverter\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AResultOutOfRange\u003E([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultOutOfRange\u003E* obj0, ResultOutOfRange* result, void* __unnamed001)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 1);
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultOutOfRange\u003E\u002Eoperator\u003Cclass\u0020nn\u003A\u003AResult\u003E([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultOutOfRange\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 1538562;
    return obj1;
  }

  internal static unsafe ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultNullptrArgument\u003E* nn\u002Eresult\u002Edetail\u002EMakeResultAutoConverter\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AResultNullptrArgument\u003E([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultNullptrArgument\u003E* obj0, ResultNullptrArgument* result, void* __unnamed001)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 1);
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultNullptrArgument\u003E\u002Eoperator\u003Cclass\u0020nn\u003A\u003AResult\u003E([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultNullptrArgument\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 3104258;
    return obj1;
  }

  internal static unsafe ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidArgument\u003E* nn\u002Eresult\u002Edetail\u002EMakeResultAutoConverter\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AResultInvalidArgument\u003E([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidArgument\u003E* obj0, ResultInvalidArgument* result, void* __unnamed001)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 1);
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidArgument\u003E\u002Eoperator\u003Cclass\u0020nn\u003A\u003AResult\u003E([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidArgument\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 3072514;
    return obj1;
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E([In] ScopeExitHolder\u003C\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E* obj0, ScopeExitHolderMarker __unnamed000, \u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E* f)
  {
    uint num1 = 0;
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    // ISSUE: fault handler
    try
    {
      num1 = 1U;
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Eoperator\u002B\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E([In] basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0, basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Left, sbyte* _Right)
  {
    uint num1 = 0;
    uint _Count;
    if (*_Right == (sbyte) 0)
    {
      _Count = 0U;
    }
    else
    {
      sbyte* numPtr = _Right;
      do
      {
        ++numPtr;
      }
      while (*numPtr != (sbyte) 0);
      _Count = (uint) ((IntPtr) numPtr - (IntPtr) _Right);
    }
    basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Right1 = \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Eappend(_Left, _Right, _Count);
    // ISSUE: fault handler
    try
    {
      // ISSUE: fault handler
      try
      {
        *(int*) ((IntPtr) obj0 + 16) = 0;
        *(int*) ((IntPtr) obj0 + 20) = 0;
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D), (void*) obj0);
      }
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(obj0, false, 0U);
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Assign_rv(obj0, _Right1);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
      num1 = 1U;
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe int strncpy_s\u003C768\u003E(\u0024ArrayType\u0024\u0024\u0024BY0DAA\u0040D* _Destination, sbyte* _Source, uint _Count)
  {
    return \u003CModule\u003E.strncpy_s((sbyte*) _Destination, 768U, _Source, _Count);
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E([In] ScopeExitHolder\u003C\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E* obj0, ScopeExitHolderMarker __unnamed000, \u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E* f)
  {
    uint num1 = 0;
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    // ISSUE: fault handler
    try
    {
      num1 = 1U;
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E([In] ScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E* obj0, ScopeExitHolderMarker __unnamed000, \u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E* f)
  {
    uint num1 = 0;
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    // ISSUE: fault handler
    try
    {
      num1 = 1U;
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    uint num1;
    // ISSUE: fault handler
    try
    {
      num1 = 0U;
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* fileSystemFormatPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E*) \u003CModule\u003E.@new(40U);
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* fileSystemFormatPtr2;
      // ISSUE: fault handler
      try
      {
        fileSystemFormatPtr2 = (IntPtr) fileSystemFormatPtr1 == IntPtr.Zero ? (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E*) 0 : \u003CModule\u003E.std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003C\u003E(fileSystemFormatPtr1);
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) fileSystemFormatPtr1, 40U);
      }
      *(int*) obj0 = 0;
      shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* fileSystemFormatPtr3 = (shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E*) ((IntPtr) obj0 + 4);
      *(int*) fileSystemFormatPtr3 = 0;
      num1 = 1U;
      uint num2 = (uint) *(int*) fileSystemFormatPtr3;
      if (num2 != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num2);
      *(int*) fileSystemFormatPtr3 = (int) fileSystemFormatPtr2;
      *(int*) obj0 = (int) ((IntPtr) fileSystemFormatPtr2 + 12);
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E([In] ScopeExitHolder\u003C\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E* obj0, ScopeExitHolderMarker __unnamed000, \u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E* f)
  {
    uint num1 = 0;
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    // ISSUE: fault handler
    try
    {
      num1 = 1U;
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E([In] ScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E* obj0, ScopeExitHolderMarker __unnamed000, \u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E* f)
  {
    uint num1 = 0;
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    // ISSUE: fault handler
    try
    {
      num1 = 1U;
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    uint num1;
    // ISSUE: fault handler
    try
    {
      num1 = 0U;
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* storageBasedFileSystemPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E*) \u003CModule\u003E.@new(48U);
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* storageBasedFileSystemPtr2;
      // ISSUE: fault handler
      try
      {
        storageBasedFileSystemPtr2 = (IntPtr) storageBasedFileSystemPtr1 == IntPtr.Zero ? (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E*) 0 : \u003CModule\u003E.std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bctor\u007D\u003C\u003E(storageBasedFileSystemPtr1);
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) storageBasedFileSystemPtr1, 48U);
      }
      *(int*) obj0 = 0;
      shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* storageBasedFileSystemPtr3 = (shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E*) ((IntPtr) obj0 + 4);
      *(int*) storageBasedFileSystemPtr3 = 0;
      num1 = 1U;
      uint num2 = (uint) *(int*) storageBasedFileSystemPtr3;
      if (num2 != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num2);
      *(int*) storageBasedFileSystemPtr3 = (int) storageBasedFileSystemPtr2;
      *(int*) obj0 = (int) ((IntPtr) storageBasedFileSystemPtr2 + 16);
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* std\u002Emove\u003Cclass\u0020std\u003A\u003Ashared_ptr\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u0020\u0026\u003E(shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u002Cvoid\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* std\u002Emove\u003Cclass\u0020std\u003A\u003Ashared_ptr\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u0020\u0026\u003E(shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002Eoperator\u003D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* _Right)
  {
    shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref sharedPtrNnFsIstorage = *(int*) _Right;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    // ISSUE: fault handler
    try
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      _Ref_count_base* refCountBasePtr = (_Ref_count_base*) ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4) = *(int*) ((IntPtr) obj0 + 4);
      *(int*) ((IntPtr) obj0 + 4) = (int) refCountBasePtr;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      IStorage* istoragePtr = (IStorage*) ^(int&) ref sharedPtrNnFsIstorage;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref sharedPtrNnFsIstorage = *(int*) obj0;
      *(int*) obj0 = (int) istoragePtr;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) &sharedPtrNnFsIstorage);
    }
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4) != 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4));
    }
    return obj0;
  }

  internal static unsafe List<Tuple<string, long>>* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020System\u003A\u003ACollections\u003A\u003AGeneric\u003A\u003AList\u003Cclass\u0020System\u003A\u003ATuple\u003Cclass\u0020System\u003A\u003AString\u0020\u005E\u002C__int64\u003E\u0020\u005E\u003E\u0020\u005E\u003E(object obj, List<Tuple<string, long>>* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe List<Tuple<long, long>>* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020System\u003A\u003ACollections\u003A\u003AGeneric\u003A\u003AList\u003Cclass\u0020System\u003A\u003ATuple\u003C__int64\u002C__int64\u003E\u0020\u005E\u003E\u0020\u005E\u003E(object obj, List<Tuple<long, long>>* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe long* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003C__int64\u003E(object obj, long* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* _Other)
  {
    _Ref_count_base* refCountBasePtr = (_Ref_count_base*) *(int*) ((IntPtr) _Other + 4);
    PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* fileSystemFormatPtr = (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E*) *(int*) _Other;
    if ((IntPtr) refCountBasePtr != IntPtr.Zero)
    {
      // ISSUE: cast to a reference type
      Interlocked.Increment((int&) ((IntPtr) refCountBasePtr + 4));
    }
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) refCountBasePtr;
    *(int*) obj0 = (int) fileSystemFormatPtr;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* _Other)
  {
    _Ref_count_base* refCountBasePtr = (_Ref_count_base*) *(int*) ((IntPtr) _Other + 4);
    nn.fs.fsa.IFileSystem* ifileSystemPtr = (nn.fs.fsa.IFileSystem*) *(int*) _Other;
    if ((IntPtr) refCountBasePtr != IntPtr.Zero)
    {
      // ISSUE: cast to a reference type
      Interlocked.Increment((int&) ((IntPtr) refCountBasePtr + 4));
    }
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) refCountBasePtr;
    *(int*) obj0 = (int) ifileSystemPtr;
  }

  internal static unsafe _Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u003E([In] _Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u0020\u003E* obj0, nn.fs.fsa.IDirectory* _Ptr)
  {
    *(int*) obj0 = (int) _Ptr;
    return obj0;
  }

  internal static unsafe _Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* std\u002E_Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u003E([In] _Unique_ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u002Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u0020\u003E* obj0, nn.fs.fsa.IFile* _Ptr)
  {
    *(int*) obj0 = (int) _Ptr;
    return obj0;
  }

  internal static unsafe basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Eforward\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E(basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe nn.fs.fsa.IFile* std\u002Eaddressof\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E(nn.fs.fsa.IFile* _Val)
  {
    return _Val;
  }

  internal static unsafe nn.fs.fsa.IDirectory* std\u002Eaddressof\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E(nn.fs.fsa.IDirectory* _Val)
  {
    return _Val;
  }

  internal static unsafe _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E\u002E\u007Bctor\u007D\u003C\u003E([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002Cstd\u003A\u003A_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002C1\u003E* obj0, _Zero_then_variadic_args_t A_0)
  {
    // ISSUE: fault handler
    try
    {
      *(int*) ((IntPtr) obj0 + 16) = 0;
      *(int*) ((IntPtr) obj0 + 20) = 0;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_val\u003Cstd\u003A\u003A_Simple_types\u003Cchar\u003E\u0020\u003E\u002E_Bxty\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E_Delete_this([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    if ((IntPtr) obj0 == IntPtr.Zero)
      return;
    _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* storageBasedFileSystemPtr = obj0;
    int num = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) (*(int*) obj0 + 8))((uint) storageBasedFileSystemPtr, (IntPtr) num);
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E_Destroy([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* storageBasedFileSystemPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E*) ((IntPtr) obj0 + 16);
    _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* storageBasedFileSystemPtr2 = storageBasedFileSystemPtr1;
    int num = 0;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) storageBasedFileSystemPtr1)((uint) storageBasedFileSystemPtr2, (IntPtr) num);
  }

  internal static unsafe FileStorageBasedFileSystem* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E_Getptr([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    return (FileStorageBasedFileSystem*) ((IntPtr) obj0 + 16);
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Delete_this([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    if ((IntPtr) obj0 == IntPtr.Zero)
      return;
    _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* fileSystemFormatPtr = obj0;
    int num = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) (*(int*) obj0 + 8))((uint) fileSystemFormatPtr, (IntPtr) num);
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Destroy([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* fileSystemFormatPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E*) ((IntPtr) obj0 + 12);
    _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* fileSystemFormatPtr2 = fileSystemFormatPtr1;
    int num = 0;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) fileSystemFormatPtr1)((uint) fileSystemFormatPtr2, (IntPtr) num);
  }

  internal static unsafe PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Getptr([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E*) ((IntPtr) obj0 + 12);
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultToReturnTypeConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidArgument\u002Cnn\u003A\u003AResult\u002Cvoid\u003E\u002EConvert([In] Result* obj0, ResultInvalidArgument* result)
  {
    *(int*) obj0 = 3072514;
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultToReturnTypeConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultNullptrArgument\u002Cnn\u003A\u003AResult\u002Cvoid\u003E\u002EConvert([In] Result* obj0, ResultNullptrArgument* result)
  {
    *(int*) obj0 = 3104258;
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultToReturnTypeConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultOutOfRange\u002Cnn\u003A\u003AResult\u002Cvoid\u003E\u002EConvert([In] Result* obj0, ResultOutOfRange* result)
  {
    *(int*) obj0 = 1538562;
    return obj0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EResultToReturnTypeConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidPath\u002Cnn\u003A\u003AResult\u002Cvoid\u003E\u002EConvert([In] Result* obj0, ResultInvalidPath* result)
  {
    *(int*) obj0 = 3073026;
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] ScopeExitHolder\u003C\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E* obj0, \u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E* f)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    return obj0;
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] ScopeExitHolder\u003C\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E* obj0, \u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E* f)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Reset([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0, PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    if ((IntPtr) _Other_rep != IntPtr.Zero)
    {
      // ISSUE: cast to a reference type
      Interlocked.Increment((int&) ((IntPtr) _Other_rep + 4));
    }
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] ScopeExitHolder\u003C\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E* obj0, \u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E* f)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    return obj0;
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] ScopeExitHolder\u003C\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E* obj0, \u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E* f)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    return obj0;
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] ScopeExitHolder\u003C\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E* obj0, \u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E* f)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E_Reset([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0, nn.fs.fsa.IFileSystem* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    if ((IntPtr) _Other_rep != IntPtr.Zero)
    {
      // ISSUE: cast to a reference type
      Interlocked.Increment((int&) ((IntPtr) _Other_rep + 4));
    }
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002Eswap([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* _Other)
  {
    _Ref_count_base* refCountBasePtr = (_Ref_count_base*) *(int*) ((IntPtr) obj0 + 4);
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Other + 4);
    *(int*) ((IntPtr) _Other + 4) = (int) refCountBasePtr;
    IStorage* istoragePtr = (IStorage*) *(int*) obj0;
    *(int*) obj0 = *(int*) _Other;
    *(int*) _Other = (int) istoragePtr;
  }

  internal static unsafe ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidArgument\u003E* nn\u002Eresult\u002Edetail\u002EResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidArgument\u003E\u002E\u007Bctor\u007D([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidArgument\u003E* obj0, ResultInvalidArgument* result)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 1);
    return obj0;
  }

  internal static unsafe ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultNullptrArgument\u003E* nn\u002Eresult\u002Edetail\u002EResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultNullptrArgument\u003E\u002E\u007Bctor\u007D([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultNullptrArgument\u003E* obj0, ResultNullptrArgument* result)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 1);
    return obj0;
  }

  internal static unsafe ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultOutOfRange\u003E* nn\u002Eresult\u002Edetail\u002EResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultOutOfRange\u003E\u002E\u007Bctor\u007D([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultOutOfRange\u003E* obj0, ResultOutOfRange* result)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 1);
    return obj0;
  }

  internal static unsafe ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidPath\u003E* nn\u002Eresult\u002Edetail\u002EResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidPath\u003E\u002E\u007Bctor\u007D([In] ResultAutoConverter\u003Cnn\u003A\u003Afs\u003A\u003AResultInvalidPath\u003E* obj0, ResultInvalidPath* result)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) result, 1);
    return obj0;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* obj0)
  {
    return obj0;
  }

  internal static unsafe allocator\u003Cchar\u003E* std\u002Eallocator\u003Cchar\u003E\u002E\u007Bctor\u007D([In] allocator\u003Cchar\u003E* obj0)
  {
    return obj0;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Reset0([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0, PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E_Reset0([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0, nn.fs.fsa.IFileSystem* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Swap([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* _Right)
  {
    _Ref_count_base* refCountBasePtr = (_Ref_count_base*) *(int*) ((IntPtr) obj0 + 4);
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) ((IntPtr) _Right + 4) = (int) refCountBasePtr;
    IStorage* istoragePtr = (IStorage*) *(int*) obj0;
    *(int*) obj0 = *(int*) _Right;
    *(int*) _Right = (int) istoragePtr;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C6002\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C6002\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 3073026;
    return obj1;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C6001\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C6001\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 3072514;
    return obj1;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u002Cvoid\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe \u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E* std\u002Eforward\u003Cclass\u0020\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u003E(\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* std\u002Emove\u003Cclass\u0020std\u003A\u003Abasic_string\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u0026\u003E(basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe \u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E* std\u002Eforward\u003Cclass\u0020\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u003E(\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe \u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E* std\u002Eforward\u003Cclass\u0020\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u003E(\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003C\u003E([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    *(int*) ((IntPtr) obj0 + 4) = 1;
    *(int*) ((IntPtr) obj0 + 8) = 1;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040V\u003F\u0024PartitionFileSystemMetaCore\u0040VPartitionFileSystemFormat\u0040detail\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
      PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* fileSystemFormatPtr = (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E*) ((IntPtr) obj0 + 12);
      if ((IntPtr) fileSystemFormatPtr != IntPtr.Zero)
        \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u002E\u007Bctor\u007D(fileSystemFormatPtr);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_base\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E_Resetp0\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0, PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* _Px, _Ref_count_base* _Rx)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Rx;
    *(int*) obj0 = (int) _Px;
  }

  internal static unsafe \u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E* std\u002Eforward\u003Cclass\u0020\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u003E(\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe \u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E* std\u002Eforward\u003Cclass\u0020\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u003E(\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bctor\u007D\u003C\u003E([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    *(int*) ((IntPtr) obj0 + 4) = 1;
    *(int*) ((IntPtr) obj0 + 8) = 1;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7\u003F\u0024_Ref_count_obj\u0040VFileStorageBasedFileSystem\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
      FileStorageBasedFileSystem* storageBasedFileSystemPtr = (FileStorageBasedFileSystem*) ((IntPtr) obj0 + 16);
      if ((IntPtr) storageBasedFileSystemPtr != IntPtr.Zero)
        \u003CModule\u003E.nn\u002Efssystem\u002EFileStorageBasedFileSystem\u002E\u007Bctor\u007D(storageBasedFileSystemPtr);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_base\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E_Resetp0\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0, FileStorageBasedFileSystem* _Px, _Ref_count_base* _Rx)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Rx;
    *(int*) obj0 = (int) _Px;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u002C1\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u002C1\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u0020\u0026\u003E([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u002C1\u003E* obj0, _Zero_then_variadic_args_t __unnamed000, nn.fs.fsa.IDirectory** _param2)
  {
    *(int*) obj0 = *(int*) _param2;
    return obj0;
  }

  internal static unsafe _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u002C1\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u002C1\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u0020\u0026\u003E([In] _Compressed_pair\u003Cstd\u003A\u003Adefault_delete\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u003E\u002Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u002C1\u003E* obj0, _Zero_then_variadic_args_t __unnamed000, nn.fs.fsa.IFile** _param2)
  {
    *(int*) obj0 = *(int*) _param2;
    return obj0;
  }

  internal static unsafe \u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E* std\u002Emove\u003Cclass\u0020\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E\u0020\u0026\u003E(\u003Clambda_345278fa5d661ab5bfd86be2c9a12383\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe \u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E* std\u002Emove\u003Cclass\u0020\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E\u0020\u0026\u003E(\u003Clambda_121cb09055f688d222f3b5a091acc8a4\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe \u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E* std\u002Emove\u003Cclass\u0020\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E\u0020\u0026\u003E(\u003Clambda_c51f9eb15b91ff9e52151ff4c2124292\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe \u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E* std\u002Emove\u003Cclass\u0020\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E\u0020\u0026\u003E(\u003Clambda_78840cdeafdb1555ab5b36cdd65670ef\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe \u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E* std\u002Emove\u003Cclass\u0020\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E\u0020\u0026\u003E(\u003Clambda_79a6c3d54be2534f29f8bf16232d2316\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe void std\u002Eswap\u003Cclass\u0020std\u003A\u003A_Ref_count_base\u0020\u002A\u002Cvoid\u003E(_Ref_count_base** _Left, _Ref_count_base** _Right)
  {
    _Ref_count_base* refCountBasePtr = (_Ref_count_base*) *(int*) _Left;
    *(int*) _Left = *(int*) _Right;
    *(int*) _Right = (int) refCountBasePtr;
  }

  internal static unsafe void std\u002Eswap\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AIStorage\u0020\u002A\u002Cvoid\u003E(IStorage** _Left, IStorage** _Right)
  {
    IStorage* istoragePtr = (IStorage*) *(int*) _Left;
    *(int*) _Left = *(int*) _Right;
    *(int*) _Right = (int) istoragePtr;
  }

  internal static unsafe void* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E__vecDelDtor([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* fileSystemFormatPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 40U, (uint) *(int*) fileSystemFormatPtr1, (__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* fileSystemFormatPtr2 = fileSystemFormatPtr1;
        int num = *(int*) fileSystemFormatPtr2 * 40 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) fileSystemFormatPtr2, (uint) num);
      }
      return (void*) fileSystemFormatPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 40U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
  }

  internal static unsafe void* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E__vecDelDtor([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* storageBasedFileSystemPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 48U, (uint) *(int*) storageBasedFileSystemPtr1, (__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* storageBasedFileSystemPtr2 = storageBasedFileSystemPtr1;
        int num = *(int*) storageBasedFileSystemPtr2 * 48 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) storageBasedFileSystemPtr2, (uint) num);
      }
      return (void*) storageBasedFileSystemPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 48U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bdtor\u007D([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E_Reset0([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* obj0, FileStorageBasedFileSystem* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe nn.fs.fsa.IDirectory** std\u002Eforward\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIDirectory\u0020\u002A\u0020\u0026\u003E(nn.fs.fsa.IDirectory** _Arg)
  {
    return _Arg;
  }

  internal static unsafe nn.fs.fsa.IFile** std\u002Eforward\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFile\u0020\u002A\u0020\u0026\u003E(nn.fs.fsa.IFile** _Arg)
  {
    return _Arg;
  }

  internal static unsafe _Ref_count_base** std\u002Emove\u003Cclass\u0020std\u003A\u003A_Ref_count_base\u0020\u002A\u0020\u0026\u003E(_Ref_count_base** _Arg)
  {
    return _Arg;
  }

  internal static unsafe IStorage** std\u002Emove\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AIStorage\u0020\u002A\u0020\u0026\u003E(IStorage** _Arg)
  {
    return _Arg;
  }

  internal static unsafe void std\u002E_Container_base0\u002E_Orphan_all([In] _Container_base0* obj0)
  {
  }

  internal static unsafe nn.fssystem.Sha256PartitionFileSystemMeta* nn\u002Efssystem\u002ESha256PartitionFileSystemMeta\u002E\u007Bctor\u007D([In] nn.fssystem.Sha256PartitionFileSystemMeta* obj0)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E\u002E\u007Bctor\u007D((PartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E*) obj0);
    return obj0;
  }

  internal static unsafe void nn\u002Efssystem\u002ESha256PartitionFileSystemMeta\u002E\u007Bdtor\u007D([In] nn.fssystem.Sha256PartitionFileSystemMeta* obj0)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E\u002E\u007Bdtor\u007D((PartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E*) obj0);
  }

  internal static unsafe PartitionFileSystemFormat.FileEntryForConstruct* std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Edata([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemFormat.FileEntryForConstruct*) *(int*) obj0;
  }

  internal static unsafe PartitionFileSystemFormat.FileEntryForConstruct* std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u005B\u005D([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, uint _Pos)
  {
    return (PartitionFileSystemFormat.FileEntryForConstruct*) ((int) _Pos * 792 + *(int*) obj0);
  }

  internal static unsafe uint std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Esize([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    return (uint) ((*(int*) ((IntPtr) obj0 + 4) - *(int*) obj0) / 792);
  }

  internal static unsafe void std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    \u003CModule\u003E.std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Tidy(obj0);
  }

  internal static unsafe vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, uint _Count)
  {
    // ISSUE: untyped stack allocation
    int num1 = (int) __untypedstackalloc(\u003CModule\u003E.__CxxQueryExceptionSize());
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    if (\u003CModule\u003E.std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Buy(obj0, _Count))
    {
      try
      {
        integral_constant\u003Cbool\u002C0\u003E __unnamed003;
        \u003CModule\u003E.std\u002E_Uninitialized_default_fill_n1\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u002Cunsigned\u0020int\u002Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E((PartitionFileSystemFormat.FileEntryForConstruct*) *(int*) obj0, _Count, (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0, __unnamed003);
        *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) obj0 + 4) + (int) _Count * 792;
      }
      catch (Exception ex1) when (
      {
        // ISSUE: unable to correctly present filter
        uint exceptionCode = (uint) Marshal.GetExceptionCode();
        if (\u003CModule\u003E.__CxxExceptionFilter((void*) Marshal.GetExceptionPointers(), (void*) 0, 0, (void*) 0) != 0)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        uint num2 = 0;
        \u003CModule\u003E.__CxxRegisterExceptionObject((void*) Marshal.GetExceptionPointers(), (void*) num1);
        try
        {
          try
          {
            \u003CModule\u003E.std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Tidy(obj0);
            \u003CModule\u003E._CxxThrowException((void*) 0, (_s__ThrowInfo*) 0);
          }
          catch (Exception ex2) when (
          {
            // ISSUE: unable to correctly present filter
            num2 = (uint) \u003CModule\u003E.__CxxDetectRethrow((void*) Marshal.GetExceptionPointers());
            if (num2 != 0U)
            {
              SuccessfulFiltering;
            }
            else
              throw;
          }
          )
          {
          }
          if (num2 != 0U)
            throw;
        }
        finally
        {
          \u003CModule\u003E.__CxxUnregisterExceptionObject((void*) num1, (int) num2);
        }
      }
    }
    return obj0;
  }

  internal static unsafe Sha256PartitionFileSystemFormat.FileEntryForConstruct* std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Edata([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    return (Sha256PartitionFileSystemFormat.FileEntryForConstruct*) *(int*) obj0;
  }

  internal static unsafe Sha256PartitionFileSystemFormat.FileEntryForConstruct* std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u005B\u005D([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, uint _Pos)
  {
    return (Sha256PartitionFileSystemFormat.FileEntryForConstruct*) ((int) _Pos * 832 + *(int*) obj0);
  }

  internal static unsafe uint std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Esize([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    return (uint) ((*(int*) ((IntPtr) obj0 + 4) - *(int*) obj0) / 832);
  }

  internal static unsafe void std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    \u003CModule\u003E.std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Tidy(obj0);
  }

  internal static unsafe vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, uint _Count)
  {
    // ISSUE: untyped stack allocation
    int num1 = (int) __untypedstackalloc(\u003CModule\u003E.__CxxQueryExceptionSize());
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    if (\u003CModule\u003E.std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Buy(obj0, _Count))
    {
      try
      {
        integral_constant\u003Cbool\u002C0\u003E __unnamed003;
        \u003CModule\u003E.std\u002E_Uninitialized_default_fill_n1\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u002Cunsigned\u0020int\u002Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E((Sha256PartitionFileSystemFormat.FileEntryForConstruct*) *(int*) obj0, _Count, (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0, __unnamed003);
        *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) obj0 + 4) + (int) _Count * 832;
      }
      catch (Exception ex1) when (
      {
        // ISSUE: unable to correctly present filter
        uint exceptionCode = (uint) Marshal.GetExceptionCode();
        if (\u003CModule\u003E.__CxxExceptionFilter((void*) Marshal.GetExceptionPointers(), (void*) 0, 0, (void*) 0) != 0)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        uint num2 = 0;
        \u003CModule\u003E.__CxxRegisterExceptionObject((void*) Marshal.GetExceptionPointers(), (void*) num1);
        try
        {
          try
          {
            \u003CModule\u003E.std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Tidy(obj0);
            \u003CModule\u003E._CxxThrowException((void*) 0, (_s__ThrowInfo*) 0);
          }
          catch (Exception ex2) when (
          {
            // ISSUE: unable to correctly present filter
            num2 = (uint) \u003CModule\u003E.__CxxDetectRethrow((void*) Marshal.GetExceptionPointers());
            if (num2 != 0U)
            {
              SuccessfulFiltering;
            }
            else
              throw;
          }
          )
          {
          }
          if (num2 != 0U)
            throw;
        }
        finally
        {
          \u003CModule\u003E.__CxxUnregisterExceptionObject((void*) num1, (int) num2);
        }
      }
    }
    return obj0;
  }

  internal static unsafe PartitionFileSystemFormat.FileEntryForConstruct** std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Mylast([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemFormat.FileEntryForConstruct**) ((IntPtr) obj0 + 4);
  }

  internal static unsafe PartitionFileSystemFormat.FileEntryForConstruct** std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Mylast([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemFormat.FileEntryForConstruct**) ((IntPtr) obj0 + 4);
  }

  internal static unsafe PartitionFileSystemFormat.FileEntryForConstruct** std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Myfirst([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemFormat.FileEntryForConstruct**) obj0;
  }

  internal static unsafe PartitionFileSystemFormat.FileEntryForConstruct** std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Myfirst([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemFormat.FileEntryForConstruct**) obj0;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Getal([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    return obj0;
  }

  internal static unsafe void std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Tidy([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    uint num = (uint) *(int*) obj0;
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Deallocate((void*) num, (uint) ((*(int*) ((IntPtr) obj0 + 8) - (int) num) / 792), 792U);
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Buy([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, uint _Capacity)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    if (_Capacity == 0U)
      return false;
    if (5422938U < _Capacity)
      \u003CModule\u003E.std\u002E_Xlength_error((sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_0BD\u0040OLBABOEK\u0040vector\u003F\u0024DMT\u003F\u0024DO\u003F5too\u003F5long\u003F\u0024AA\u0040);
    void* voidPtr = \u003CModule\u003E.std\u002E_Allocate(_Capacity, 792U, true);
    *(int*) obj0 = (int) voidPtr;
    *(int*) ((IntPtr) obj0 + 4) = (int) voidPtr;
    *(int*) ((IntPtr) obj0 + 8) = (int) ((int) _Capacity * 792 + (IntPtr) voidPtr);
    return true;
  }

  internal static unsafe Sha256PartitionFileSystemFormat.FileEntryForConstruct** std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Mylast([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (Sha256PartitionFileSystemFormat.FileEntryForConstruct**) ((IntPtr) obj0 + 4);
  }

  internal static unsafe Sha256PartitionFileSystemFormat.FileEntryForConstruct** std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Mylast([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (Sha256PartitionFileSystemFormat.FileEntryForConstruct**) ((IntPtr) obj0 + 4);
  }

  internal static unsafe Sha256PartitionFileSystemFormat.FileEntryForConstruct** std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Myfirst([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (Sha256PartitionFileSystemFormat.FileEntryForConstruct**) obj0;
  }

  internal static unsafe Sha256PartitionFileSystemFormat.FileEntryForConstruct** std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Myfirst([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (Sha256PartitionFileSystemFormat.FileEntryForConstruct**) obj0;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Getal([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    return obj0;
  }

  internal static unsafe void std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Tidy([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    uint num = (uint) *(int*) obj0;
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Deallocate((void*) num, (uint) ((*(int*) ((IntPtr) obj0 + 8) - (int) num) / 832), 832U);
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Buy([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, uint _Capacity)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    if (_Capacity == 0U)
      return false;
    if (5162220U < _Capacity)
      \u003CModule\u003E.std\u002E_Xlength_error((sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_0BD\u0040OLBABOEK\u0040vector\u003F\u0024DMT\u003F\u0024DO\u003F5too\u003F5long\u003F\u0024AA\u0040);
    void* voidPtr = \u003CModule\u003E.std\u002E_Allocate(_Capacity, 832U, true);
    *(int*) obj0 = (int) voidPtr;
    *(int*) ((IntPtr) obj0 + 4) = (int) voidPtr;
    *(int*) ((IntPtr) obj0 + 8) = (int) ((int) _Capacity * 832 + (IntPtr) voidPtr);
    return true;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe void std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Edeallocate([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, PartitionFileSystemFormat.FileEntryForConstruct* _Ptr, uint _Count)
  {
    \u003CModule\u003E.std\u002E_Deallocate((void*) _Ptr, _Count, 792U);
  }

  internal static unsafe PartitionFileSystemFormat.FileEntryForConstruct* std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Eallocate([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, uint _Count)
  {
    return (PartitionFileSystemFormat.FileEntryForConstruct*) \u003CModule\u003E.std\u002E_Allocate(_Count, 792U, true);
  }

  internal static unsafe PartitionFileSystemFormat.FileEntryForConstruct** std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Myend([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemFormat.FileEntryForConstruct**) ((IntPtr) obj0 + 8);
  }

  internal static unsafe _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Get_data([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Get_data([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe void std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Orphan_all([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
  }

  internal static unsafe void std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Xlen([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    \u003CModule\u003E.std\u002E_Xlength_error((sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_0BD\u0040OLBABOEK\u0040vector\u003F\u0024DMT\u003F\u0024DO\u003F5too\u003F5long\u003F\u0024AA\u0040);
  }

  internal static unsafe void std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Destroy([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, PartitionFileSystemFormat.FileEntryForConstruct* _First, PartitionFileSystemFormat.FileEntryForConstruct* _Last)
  {
  }

  internal static unsafe uint std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Emax_size([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    return 5422938;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe void std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Edeallocate([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, Sha256PartitionFileSystemFormat.FileEntryForConstruct* _Ptr, uint _Count)
  {
    \u003CModule\u003E.std\u002E_Deallocate((void*) _Ptr, _Count, 832U);
  }

  internal static unsafe Sha256PartitionFileSystemFormat.FileEntryForConstruct* std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Eallocate([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, uint _Count)
  {
    return (Sha256PartitionFileSystemFormat.FileEntryForConstruct*) \u003CModule\u003E.std\u002E_Allocate(_Count, 832U, true);
  }

  internal static unsafe Sha256PartitionFileSystemFormat.FileEntryForConstruct** std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Myend([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (Sha256PartitionFileSystemFormat.FileEntryForConstruct**) ((IntPtr) obj0 + 8);
  }

  internal static unsafe _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Get_data([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Get_data([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe void std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Orphan_all([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
  }

  internal static unsafe void std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Xlen([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    \u003CModule\u003E.std\u002E_Xlength_error((sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_0BD\u0040OLBABOEK\u0040vector\u003F\u0024DMT\u003F\u0024DO\u003F5too\u003F5long\u003F\u0024AA\u0040);
  }

  internal static unsafe void std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E_Destroy([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, Sha256PartitionFileSystemFormat.FileEntryForConstruct* _First, Sha256PartitionFileSystemFormat.FileEntryForConstruct* _Last)
  {
  }

  internal static unsafe uint std\u002Evector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Emax_size([In] vector\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    return 5162220;
  }

  internal static unsafe _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe uint std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Emax_size([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, _Nil A_0)
  {
    return 5422938;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Getal([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe PartitionFileSystemFormat.FileEntryForConstruct* std\u002Eallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Eallocate([In] allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* obj0, uint _Count)
  {
    return (PartitionFileSystemFormat.FileEntryForConstruct*) \u003CModule\u003E.std\u002E_Allocate(_Count, 792U, true);
  }

  internal static unsafe void std\u002Eallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Edeallocate([In] allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* obj0, PartitionFileSystemFormat.FileEntryForConstruct* _Ptr, uint _Count)
  {
    \u003CModule\u003E.std\u002E_Deallocate((void*) _Ptr, _Count, 792U);
  }

  internal static unsafe _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E\u002E_Get_second([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe uint std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Emax_size([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, _Nil A_0)
  {
    return 5162220;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E\u002E_Getal([In] _Vector_alloc\u003Cstd\u003A\u003A_Vec_base_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u002Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u0020\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe Sha256PartitionFileSystemFormat.FileEntryForConstruct* std\u002Eallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Eallocate([In] allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* obj0, uint _Count)
  {
    return (Sha256PartitionFileSystemFormat.FileEntryForConstruct*) \u003CModule\u003E.std\u002E_Allocate(_Count, 832U, true);
  }

  internal static unsafe void std\u002Eallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Edeallocate([In] allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* obj0, Sha256PartitionFileSystemFormat.FileEntryForConstruct* _Ptr, uint _Count)
  {
    \u003CModule\u003E.std\u002E_Deallocate((void*) _Ptr, _Count, 832U);
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe uint std\u002Eallocator_traits\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Emax_size(allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* _Al)
  {
    return 5422938;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E\u002E_Get_first([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* obj0)
  {
    return (_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E*) obj0;
  }

  internal static unsafe uint std\u002Eallocator_traits\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Emax_size(allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* _Al)
  {
    return 5162220;
  }

  internal static unsafe uint std\u002Eallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Emax_size([In] allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* obj0)
  {
    return 5422938;
  }

  internal static unsafe uint std\u002Eallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Emax_size([In] allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* obj0)
  {
    return 5162220;
  }

  internal static unsafe PartitionFileSystemFormat.FileEntryForConstruct* std\u002E_Unfancy\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E(PartitionFileSystemFormat.FileEntryForConstruct* _Ptr)
  {
    return _Ptr;
  }

  internal static unsafe void std\u002E_Uninitialized_default_fill_n\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u002Cunsigned\u0020int\u002Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E(PartitionFileSystemFormat.FileEntryForConstruct* _First, uint _Count, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* _Al)
  {
    integral_constant\u003Cbool\u002C0\u003E __unnamed003;
    \u003CModule\u003E.std\u002E_Uninitialized_default_fill_n1\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u002Cunsigned\u0020int\u002Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E(_First, _Count, _Al, __unnamed003);
  }

  internal static unsafe Sha256PartitionFileSystemFormat.FileEntryForConstruct* std\u002E_Unfancy\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E(Sha256PartitionFileSystemFormat.FileEntryForConstruct* _Ptr)
  {
    return _Ptr;
  }

  internal static unsafe void std\u002E_Uninitialized_default_fill_n\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u002Cunsigned\u0020int\u002Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E(Sha256PartitionFileSystemFormat.FileEntryForConstruct* _First, uint _Count, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* _Al)
  {
    integral_constant\u003Cbool\u002C0\u003E __unnamed003;
    \u003CModule\u003E.std\u002E_Uninitialized_default_fill_n1\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u002Cunsigned\u0020int\u002Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E(_First, _Count, _Al, __unnamed003);
  }

  internal static unsafe _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E\u002E\u007Bctor\u007D\u003C\u003E([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* obj0, _Zero_then_variadic_args_t A_0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    return obj0;
  }

  internal static unsafe _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* std\u002E_Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E\u002E\u007Bctor\u007D\u003C\u003E([In] _Compressed_pair\u003Cstd\u003A\u003A_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Cstd\u003A\u003A_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002C1\u003E* obj0, _Zero_then_variadic_args_t A_0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    return obj0;
  }

  internal static unsafe void std\u002E_Destroy_range\u003Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u003E(PartitionFileSystemFormat.FileEntryForConstruct* _First, PartitionFileSystemFormat.FileEntryForConstruct* _Last, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* _Al)
  {
  }

  internal static unsafe void std\u002E_Destroy_range\u003Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u003E(Sha256PartitionFileSystemFormat.FileEntryForConstruct* _First, Sha256PartitionFileSystemFormat.FileEntryForConstruct* _Last, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* _Al)
  {
  }

  internal static unsafe _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    return obj0;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    return obj0;
  }

  internal static unsafe _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Vector_val\u003Cstd\u003A\u003A_Simple_types\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    return obj0;
  }

  internal static unsafe _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0)
  {
    return obj0;
  }

  internal static unsafe allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* std\u002Eallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002E\u007Bctor\u007D([In] allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* obj0)
  {
    return obj0;
  }

  internal static unsafe allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* std\u002Eallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002E\u007Bctor\u007D([In] allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* obj0)
  {
    return obj0;
  }

  internal static unsafe void std\u002E_Uninitialized_default_fill_n1\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u002Cunsigned\u0020int\u002Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E(PartitionFileSystemFormat.FileEntryForConstruct* _First, uint _Count, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* _Al, integral_constant\u003Cbool\u002C0\u003E __unnamed003)
  {
    // ISSUE: untyped stack allocation
    int num1 = (int) __untypedstackalloc(\u003CModule\u003E.__CxxQueryExceptionSize());
    try
    {
      while (0U < _Count)
      {
        PartitionFileSystemFormat.FileEntryForConstruct* entryForConstructPtr;
        if ((IntPtr) _First != IntPtr.Zero)
        {
          // ISSUE: initblk instruction
          __memset((IntPtr) _First, 0, 792);
          entryForConstructPtr = _First;
        }
        else
          entryForConstructPtr = (PartitionFileSystemFormat.FileEntryForConstruct*) 0;
        --_Count;
        _First += 792;
      }
    }
    catch (Exception ex1) when (
    {
      // ISSUE: unable to correctly present filter
      uint exceptionCode = (uint) Marshal.GetExceptionCode();
      if (\u003CModule\u003E.__CxxExceptionFilter((void*) Marshal.GetExceptionPointers(), (void*) 0, 0, (void*) 0) != 0)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      uint num2 = 0;
      \u003CModule\u003E.__CxxRegisterExceptionObject((void*) Marshal.GetExceptionPointers(), (void*) num1);
      try
      {
        try
        {
          \u003CModule\u003E._CxxThrowException((void*) 0, (_s__ThrowInfo*) 0);
        }
        catch (Exception ex2) when (
        {
          // ISSUE: unable to correctly present filter
          num2 = (uint) \u003CModule\u003E.__CxxDetectRethrow((void*) Marshal.GetExceptionPointers());
          if (num2 != 0U)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
        }
        if (num2 == 0U)
          return;
        throw;
      }
      finally
      {
        \u003CModule\u003E.__CxxUnregisterExceptionObject((void*) num1, (int) num2);
      }
    }
  }

  internal static unsafe void std\u002E_Uninitialized_default_fill_n1\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u002Cunsigned\u0020int\u002Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E(Sha256PartitionFileSystemFormat.FileEntryForConstruct* _First, uint _Count, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* _Al, integral_constant\u003Cbool\u002C0\u003E __unnamed003)
  {
    // ISSUE: untyped stack allocation
    int num1 = (int) __untypedstackalloc(\u003CModule\u003E.__CxxQueryExceptionSize());
    try
    {
      while (0U < _Count)
      {
        Sha256PartitionFileSystemFormat.FileEntryForConstruct* entryForConstructPtr;
        if ((IntPtr) _First != IntPtr.Zero)
        {
          // ISSUE: initblk instruction
          __memset((IntPtr) _First, 0, 832);
          entryForConstructPtr = _First;
        }
        else
          entryForConstructPtr = (Sha256PartitionFileSystemFormat.FileEntryForConstruct*) 0;
        --_Count;
        _First += 832;
      }
    }
    catch (Exception ex1) when (
    {
      // ISSUE: unable to correctly present filter
      uint exceptionCode = (uint) Marshal.GetExceptionCode();
      if (\u003CModule\u003E.__CxxExceptionFilter((void*) Marshal.GetExceptionPointers(), (void*) 0, 0, (void*) 0) != 0)
      {
        SuccessfulFiltering;
      }
      else
        throw;
    }
    )
    {
      uint num2 = 0;
      \u003CModule\u003E.__CxxRegisterExceptionObject((void*) Marshal.GetExceptionPointers(), (void*) num1);
      try
      {
        try
        {
          \u003CModule\u003E._CxxThrowException((void*) 0, (_s__ThrowInfo*) 0);
        }
        catch (Exception ex2) when (
        {
          // ISSUE: unable to correctly present filter
          num2 = (uint) \u003CModule\u003E.__CxxDetectRethrow((void*) Marshal.GetExceptionPointers());
          if (num2 != 0U)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
        }
        if (num2 == 0U)
          return;
        throw;
      }
      finally
      {
        \u003CModule\u003E.__CxxUnregisterExceptionObject((void*) num1, (int) num2);
      }
    }
  }

  internal static unsafe void std\u002E_Destroy_range1\u003Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u003E(PartitionFileSystemFormat.FileEntryForConstruct* A_0, PartitionFileSystemFormat.FileEntryForConstruct* A_1, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* A_2, integral_constant\u003Cbool\u002C1\u003E A_3)
  {
  }

  internal static unsafe void std\u002E_Destroy_range1\u003Cclass\u0020std\u003A\u003Aallocator\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u0020\u002A\u003E(Sha256PartitionFileSystemFormat.FileEntryForConstruct* A_0, Sha256PartitionFileSystemFormat.FileEntryForConstruct* A_1, _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* A_2, integral_constant\u003Cbool\u002C1\u003E A_3)
  {
  }

  internal static unsafe void std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Econstruct\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, PartitionFileSystemFormat.FileEntryForConstruct* _Ptr)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    // ISSUE: initblk instruction
    __memset((IntPtr) _Ptr, 0, 792);
  }

  internal static unsafe void std\u002E_Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Econstruct\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E([In] _Wrap_alloc\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E* obj0, Sha256PartitionFileSystemFormat.FileEntryForConstruct* _Ptr)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    // ISSUE: initblk instruction
    __memset((IntPtr) _Ptr, 0, 832);
  }

  internal static unsafe void std\u002Eallocator_traits\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Econstruct\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E(allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* _Al, PartitionFileSystemFormat.FileEntryForConstruct* _Ptr)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    // ISSUE: initblk instruction
    __memset((IntPtr) _Ptr, 0, 792);
  }

  internal static unsafe void std\u002Eallocator_traits\u003Cstd\u003A\u003Aallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u0020\u003E\u002Econstruct\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E(allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* _Al, Sha256PartitionFileSystemFormat.FileEntryForConstruct* _Ptr)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    // ISSUE: initblk instruction
    __memset((IntPtr) _Ptr, 0, 832);
  }

  internal static unsafe void std\u002Eallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Econstruct\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E([In] allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* obj0, PartitionFileSystemFormat.FileEntryForConstruct* _Ptr)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    // ISSUE: initblk instruction
    __memset((IntPtr) _Ptr, 0, 792);
  }

  internal static unsafe void std\u002Eallocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E\u002Econstruct\u003Cstruct\u0020nn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E([In] allocator\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003A\u003AFileEntryForConstruct\u003E* obj0, Sha256PartitionFileSystemFormat.FileEntryForConstruct* _Ptr)
  {
    if ((IntPtr) _Ptr == IntPtr.Zero)
      return;
    // ISSUE: initblk instruction
    __memset((IntPtr) _Ptr, 0, 832);
  }

  internal static unsafe uint \u003FA0x66815878\u002Estrnlen_s(sbyte* _String, uint _MaxCount)
  {
    if ((IntPtr) _String == IntPtr.Zero)
      return 0;
    return \u003CModule\u003E.strnlen(_String, _MaxCount);
  }

  internal static unsafe RomFsFileSystemArchiveReaderImpl* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002E\u007Bctor\u007D([In] RomFsFileSystemArchiveReaderImpl* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* storage)
  {
    shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr1;
    // ISSUE: fault handler
    try
    {
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage;
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr2 = &sharedPtrNnFsIstorage;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref sharedPtrNnFsIstorage = *(int*) storage;
      sharedPtrNnFsIstoragePtr1 = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) storage + 4);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4) = *(int*) sharedPtrNnFsIstoragePtr1;
      *(int*) storage = 0;
      *(int*) sharedPtrNnFsIstoragePtr1 = 0;
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr3 = &sharedPtrNnFsIstorage;
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(int*) obj0 = ^(int&) ref sharedPtrNnFsIstorage;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(int*) ((IntPtr) obj0 + 4) = ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref sharedPtrNnFsIstorage = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4) = 0;
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) sharedPtrNnFsIstoragePtr3);
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4) != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &sharedPtrNnFsIstorage + 4));
      }
      // ISSUE: fault handler
      try
      {
        RomFsFileSystemArchiveReaderImpl* archiveReaderImplPtr = (RomFsFileSystemArchiveReaderImpl*) ((IntPtr) obj0 + 12);
        \u003CModule\u003E.std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E((shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E*) archiveReaderImplPtr);
        // ISSUE: fault handler
        try
        {
          IStorage* istoragePtr = (IStorage*) *(int*) obj0;
          Result result;
          \u003CModule\u003E.nn\u002Efs\u002ERomFsFileSystem\u002EInitialize((RomFsFileSystem*) *(int*) archiveReaderImplPtr, &result, istoragePtr, (void*) 0, 0U, false);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result != 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            throw new ArgumentException(string.Format("Failed to Initialize RomFsFileSystem 0x{0}.", (object) (uint) ^(int&) ref result));
          }
          RomFsFileSystem* romFsFileSystemPtr = (RomFsFileSystem*) *(int*) archiveReaderImplPtr;
          *(int*) ((IntPtr) obj0 + 8) = (int) romFsFileSystemPtr;
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bdtor\u007D), (void*) ((IntPtr) obj0 + 12));
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) storage);
    }
    int num = *(int*) sharedPtrNnFsIstoragePtr1;
    if (num != 0)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    return obj0;
  }

  internal static unsafe List<Tuple<long, long>> Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002EGetFileFragmentList([In] RomFsFileSystemArchiveReaderImpl* obj0, string fileName)
  {
    sbyte* pointer = (sbyte*) \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetUtf8CharsFromString(fileName).ToPointer();
    \u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E obj1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref obj1 = (int) &pointer;
    ScopeExitHolder\u003C\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E obj2;
    \u003CModule\u003E.nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E(&obj2, (ScopeExitHolderMarker) 0, &obj1);
    List<Tuple<long, long>> tupleList;
    // ISSUE: fault handler
    try
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Left = \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_01KMDKNFGN\u0040\u003F1\u003F\u0024AA\u0040);
      Result result;
      long num;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.std\u002Eoperator\u002B\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E(&stdAllocatorChar2, _Left, pointer);
        // ISSUE: fault handler
        try
        {
          sbyte* numPtr = 16U > (uint) *(int*) ((IntPtr) stdAllocatorCharPtr + 20) ? (sbyte*) stdAllocatorCharPtr : (sbyte*) *(int*) stdAllocatorCharPtr;
          \u003CModule\u003E.nn\u002Efs\u002ERomFsFileSystem\u002EGetFileBaseOffset((RomFsFileSystem*) *(int*) ((IntPtr) obj0 + 12), &result, &num, numPtr);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar2, true, 0U);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar1, true, 0U);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        throw new ArgumentException(string.Format("Failed to OpenFileStorage 0x{0:X8}.", (object) (uint) ^(int&) ref result));
      }
      tupleList = new List<Tuple<long, long>>();
      tupleList.Add(new Tuple<long, long>(num, \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetFileSize((FileSystemArchiveReaderImplBase*) obj0, fileName)));
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &obj2);
    }
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(byte&) ((IntPtr) &obj2 + 4) != (byte) 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) ^(int&) ref obj2));
    }
    return tupleList;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002EGetFileFragmentList\u002E\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u002E\u0028\u0029([In] \u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E* obj0)
  {
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe \u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002EGetFileFragmentList\u002E\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u002E\u007Bctor\u007D([In] \u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E* obj0, sbyte** _param1)
  {
    *(int*) obj0 = (int) _param1;
    return obj0;
  }

  internal static unsafe void* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002E__delDtor([In] RomFsFileSystemArchiveReaderImpl* obj0, uint A_0)
  {
    \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002E\u007Bdtor\u007D(obj0);
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 20U);
    return (void*) obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ERomFsFileSystemArchiveReaderImpl\u002E\u007Bdtor\u007D([In] RomFsFileSystemArchiveReaderImpl* obj0)
  {
    // ISSUE: fault handler
    try
    {
      uint num = (uint) *(int*) ((IntPtr) obj0 + 12 + 4);
      if (num != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    uint num1 = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num1 == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num1);
  }

  internal static unsafe void nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] ScopeExitHolder\u003C\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E* obj0)
  {
    if (*(byte*) ((IntPtr) obj0 + 4) == (byte) 0)
      return;
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe RomFsFileSystem* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u002D\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    return (RomFsFileSystem*) *(int*) obj0;
  }

  internal static unsafe RomFsFileSystem* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002Eget([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    return (RomFsFileSystem*) *(int*) obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bdtor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe IStorage* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002Eget([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0)
  {
    return (IStorage*) *(int*) obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E_Decref([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe RomFsFileSystem* std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E_Get([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    return (RomFsFileSystem*) *(int*) obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    uint num1;
    // ISSUE: fault handler
    try
    {
      num1 = 0U;
      _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* fsRomFsFileSystemPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E*) \u003CModule\u003E.@new(232U);
      _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* fsRomFsFileSystemPtr2;
      // ISSUE: fault handler
      try
      {
        fsRomFsFileSystemPtr2 = (IntPtr) fsRomFsFileSystemPtr1 == IntPtr.Zero ? (_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E*) 0 : \u003CModule\u003E.std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bctor\u007D\u003C\u003E(fsRomFsFileSystemPtr1);
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) fsRomFsFileSystemPtr1, 232U);
      }
      *(int*) obj0 = 0;
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* fsRomFsFileSystemPtr3 = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E*) ((IntPtr) obj0 + 4);
      *(int*) fsRomFsFileSystemPtr3 = 0;
      num1 = 1U;
      uint num2 = (uint) *(int*) fsRomFsFileSystemPtr3;
      if (num2 != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num2);
      *(int*) fsRomFsFileSystemPtr3 = (int) fsRomFsFileSystemPtr2;
      *(int*) obj0 = (int) ((IntPtr) fsRomFsFileSystemPtr2 + 16);
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E([In] ScopeExitHolder\u003C\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E* obj0, ScopeExitHolderMarker __unnamed000, \u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E* f)
  {
    uint num1 = 0;
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    // ISSUE: fault handler
    try
    {
      num1 = 1U;
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E_Delete_this([In] _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    if ((IntPtr) obj0 == IntPtr.Zero)
      return;
    _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* fsRomFsFileSystemPtr = obj0;
    int num = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) (*(int*) obj0 + 8))((uint) fsRomFsFileSystemPtr, (IntPtr) num);
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E_Destroy([In] _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* fsRomFsFileSystemPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E*) ((IntPtr) obj0 + 16);
    _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* fsRomFsFileSystemPtr2 = fsRomFsFileSystemPtr1;
    int num = 0;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) fsRomFsFileSystemPtr1)((uint) fsRomFsFileSystemPtr2, (IntPtr) num);
  }

  internal static unsafe RomFsFileSystem* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E_Getptr([In] _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    return (RomFsFileSystem*) ((IntPtr) obj0 + 16);
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] ScopeExitHolder\u003C\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E* obj0, \u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E* f)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bctor\u007D\u003C\u003E([In] _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    *(int*) ((IntPtr) obj0 + 4) = 1;
    *(int*) ((IntPtr) obj0 + 8) = 1;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7\u003F\u0024_Ref_count_obj\u0040VRomFsFileSystem\u0040fs\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
      RomFsFileSystem* romFsFileSystemPtr = (RomFsFileSystem*) ((IntPtr) obj0 + 16);
      if ((IntPtr) romFsFileSystemPtr != IntPtr.Zero)
        \u003CModule\u003E.nn\u002Efs\u002ERomFsFileSystem\u002E\u007Bctor\u007D(romFsFileSystemPtr);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_base\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E_Resetp0\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0, RomFsFileSystem* _Px, _Ref_count_base* _Rx)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Rx;
    *(int*) obj0 = (int) _Px;
  }

  internal static unsafe \u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E* std\u002Eforward\u003Cclass\u0020\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u003E(\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe \u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E* std\u002Emove\u003Cclass\u0020\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E\u0020\u0026\u003E(\u003Clambda_1e0386d37e8e6757907d136b4bbf05e1\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* std\u002Emove\u003Cclass\u0020std\u003A\u003Ashared_ptr\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u0020\u0026\u003E(shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe void* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E__vecDelDtor([In] _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* fsRomFsFileSystemPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 232U, (uint) *(int*) fsRomFsFileSystemPtr1, (__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* fsRomFsFileSystemPtr2 = fsRomFsFileSystemPtr1;
        int num = *(int*) fsRomFsFileSystemPtr2 * 232 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) fsRomFsFileSystemPtr2, (uint) num);
      }
      return (void*) fsRomFsFileSystemPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 232U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E\u007Bdtor\u007D([In] _Ref_count_obj\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E\u002E_Reset0([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003ARomFsFileSystem\u003E* obj0, RomFsFileSystem* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe void nn\u002Efssystem\u002ES64\u002ESet([In] S64* obj0, long value)
  {
    *(long*) obj0 = value;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002Efssystem\u002ERomPathTool\u002EIsCurrentDirectory(RomEntryName* dirName)
  {
    return *(int*) dirName == 1 && *(sbyte*) *(int*) ((IntPtr) dirName + 4) == (sbyte) 46;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002Efssystem\u002ERomPathTool\u002EIsEqualPath(sbyte* pExtraKey1, sbyte* pExtraKey2, uint length)
  {
    return \u003CModule\u003E.strncmp(pExtraKey1, pExtraKey2, length) == 0;
  }

  internal static unsafe void nn\u002Efssystem\u002ERomPathTool\u002EInitEntryName(RomEntryName* pName)
  {
    *(int*) pName = 0;
  }

  internal static uint nn\u002Efssystem\u002EAlignROMAddress(uint x)
  {
    return (uint) ((int) x + 3 & -4);
  }

  internal static unsafe nn.fssystem.MemoryStorage* nn\u002Efssystem\u002EMemoryStorage\u002E\u007Bctor\u007D([In] nn.fssystem.MemoryStorage* obj0, void* buffer, long size)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7MemoryStorage\u0040fssystem\u0040nn\u0040\u00406B\u0040;
      *(int*) ((IntPtr) obj0 + 4) = (int) buffer;
      *(long*) ((IntPtr) obj0 + 8) = size;
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Efs\u002EIStorage\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EMemoryStorage\u002ERead([In] nn.fssystem.MemoryStorage* obj0, [In] Result* obj1, long offset, void* buffer, uint size)
  {
    if (offset >= 0L && *(long*) ((IntPtr) obj0 + 8) >= (long) size + offset)
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) buffer, (int) offset + *(int*) ((IntPtr) obj0 + 4), (int) size);
      *(int*) obj1 = 0;
      return obj1;
    }
    *(int*) obj1 = 1538562;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EMemoryStorage\u002EWrite([In] nn.fssystem.MemoryStorage* obj0, [In] Result* obj1, long offset, void* buffer, uint size)
  {
    if (offset >= 0L && *(long*) ((IntPtr) obj0 + 8) >= (long) size + offset)
    {
      // ISSUE: cpblk instruction
      __memcpy((int) offset + *(int*) ((IntPtr) obj0 + 4), (IntPtr) buffer, (int) size);
      *(int*) obj1 = 0;
      return obj1;
    }
    *(int*) obj1 = 1538562;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EMemoryStorage\u002EFlush([In] nn.fssystem.MemoryStorage* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EMemoryStorage\u002EGetSize([In] nn.fssystem.MemoryStorage* obj0, [In] Result* obj1, long* outValue)
  {
    *outValue = *(long*) ((IntPtr) obj0 + 8);
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe void* nn\u002Efssystem\u002EMemoryStorage\u002E__vecDelDtor([In] nn.fssystem.MemoryStorage* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      nn.fssystem.MemoryStorage* memoryStoragePtr1 = (nn.fssystem.MemoryStorage*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 16U, (uint) *(int*) memoryStoragePtr1, (__FnPtr<void (void*)>) __methodptr(nn\u002Efssystem\u002EMemoryStorage\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        nn.fssystem.MemoryStorage* memoryStoragePtr2 = memoryStoragePtr1;
        int num = *(int*) memoryStoragePtr2 * 16 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) memoryStoragePtr2, (uint) num);
      }
      return (void*) memoryStoragePtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 16U);
    return (void*) obj0;
  }

  internal static unsafe void nn\u002Efssystem\u002EMemoryStorage\u002E\u007Bdtor\u007D([In] nn.fssystem.MemoryStorage* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7IStorage\u0040fs\u0040nn\u0040\u00406B\u0040;
  }

  internal static string Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002EGetDirectoryName(string path)
  {
    string directoryName = System.IO.Path.GetDirectoryName(path);
    if (string.IsNullOrEmpty(directoryName))
      return directoryName;
    return directoryName.Replace("\\", "/");
  }

  internal static int Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002ECalculateBucketCount(int entryCount)
  {
    int num1 = entryCount;
    if (entryCount < 3)
      num1 = 3;
    else if (entryCount <= 19)
    {
      num1 = entryCount | 1;
    }
    else
    {
      while (true)
      {
        if (num1 % 2 != 0)
        {
          int num2 = num1;
          if (num2 - num2 / 3 * 3 != 0)
          {
            int num3 = num1;
            if (num3 - num3 / 5 * 5 != 0)
            {
              int num4 = num1;
              if (num4 - num4 / 7 * 7 != 0)
              {
                int num5 = num1;
                if (num5 - num5 / 11 * 11 != 0)
                {
                  int num6 = num1;
                  if (num6 - num6 / 13 * 13 != 0)
                  {
                    int num7 = num1;
                    if (num7 - num7 / 17 * 17 != 0)
                      break;
                  }
                }
              }
            }
          }
        }
        ++num1;
      }
    }
    return num1;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002ECreateFileW(HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* pTable, RomFsFileSystemInfo.EntryInfo* entry)
  {
    RomFileInfo romFileInfo;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(long&) ref romFileInfo = (long) entry->offset;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(long&) ((IntPtr) &romFileInfo + 8) = (long) entry->size;
    // ISSUE: cast to a reference type
    // ISSUE: variable of a reference type
    byte* local1 = (byte*) entry->name;
    if (local1 != null)
    {
      // ISSUE: cast to a reference type
      local1 = (byte*) (RuntimeHelpers.OffsetToStringData + (IntPtr) local1);
    }
    // ISSUE: cast to a reference type
    // ISSUE: variable of a reference type
    char* local2 = (char*) local1;
    \u0024ArrayType\u0024\u0024\u0024BY0DAA\u0040D arrayTypeBy0DaaD;
    \u003CModule\u003E.WideCharToMultiByte(65001U, 0U, (char*) local2, -1, (sbyte*) &arrayTypeBy0DaaD, 768, (sbyte*) 0, (int*) 0);
    int num = 0;
    Result result;
    if (*(int*) \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002ECreateFileW(pTable, &result, &num, (sbyte*) &arrayTypeBy0DaaD, &romFileInfo) != 0)
      throw new Exception("Failed to create a file entry: " + entry->name);
    // ISSUE: cast to a reference type
    local2 = (char*) null;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002ECreateDirectoryRecursively(HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* pTable, string path)
  {
    if (string.IsNullOrEmpty(path))
      return;
    \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002ECreateDirectoryRecursively(pTable, \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002E\u003FA0x6255fc99\u002EGetDirectoryName(path));
    // ISSUE: cast to a reference type
    // ISSUE: variable of a reference type
    byte* local1 = (byte*) path;
    if (local1 != null)
    {
      // ISSUE: cast to a reference type
      local1 = (byte*) (RuntimeHelpers.OffsetToStringData + (IntPtr) local1);
    }
    // ISSUE: cast to a reference type
    // ISSUE: variable of a reference type
    char* local2 = (char*) local1;
    \u0024ArrayType\u0024\u0024\u0024BY0DAA\u0040D arrayTypeBy0DaaD;
    \u003CModule\u003E.WideCharToMultiByte(65001U, 0U, (char*) local2, -1, (sbyte*) &arrayTypeBy0DaaD, 768, (sbyte*) 0, (int*) 0);
    Result result1;
    RomDirectoryInfo romDirectoryInfo;
    \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetDirectoryInformation(pTable, &result1, &romDirectoryInfo, (sbyte*) &arrayTypeBy0DaaD);
    if (\u003CModule\u003E.nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7901\u002C7905\u003E\u002EIncludes(result1))
    {
      int num = 0;
      Result result2;
      if (*(int*) \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002ECreateDirectory(pTable, &result2, &num, (sbyte*) &arrayTypeBy0DaaD, &romDirectoryInfo) != 0)
        throw new Exception("Failed to create a directory entry: " + path);
    }
    else
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result1 != 0)
        throw new Exception("Failed to create a directory entry: " + path);
    }
    // ISSUE: cast to a reference type
    local2 = (char*) null;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7901\u002C7905\u003E\u002EIncludes(Result result)
  {
    int num1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if ((^(int&) ref result & 511) == 2)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      uint num2 = (uint) ^(int&) ref result >> 9 & 8191U;
      if (7901 <= (int) num2 && (int) num2 < 7905)
      {
        num1 = 1;
        goto label_4;
      }
    }
    num1 = 0;
label_4:
    return num1 != 0;
  }

  internal static uint nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EQueryDirectoryEntryStorageSize(uint countDirectoryEntry)
  {
    return (uint) (((int) countDirectoryEntry + 1) * 793);
  }

  internal static uint nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EQueryFileEntryStorageSize(uint countFileEntry)
  {
    return countFileEntry * 801U;
  }

  internal static uint nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EQueryDirectoryEntryBucketStorageSize(uint countDirectoryBucket)
  {
    return countDirectoryBucket << 2;
  }

  internal static uint nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EQueryFileEntryBucketStorageSize(uint countFileBucket)
  {
    return countFileBucket << 2;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFormat([In] Result* obj0, IStorage* pDirectoryBucket, long offsetDirectoryBucket, uint sizeDirectoryBucket, IStorage* pDirectoryEntry, long offsetDirectoryEntry, uint sizeDirectoryEntry, IStorage* pFileBucket, long offsetFileBucket, uint sizeFileBucket, IStorage* pFileEntry, long offsetFileEntry, uint sizeFileEntry)
  {
    Result result1;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EFormat(&result1, pDirectoryBucket, offsetDirectoryBucket, sizeDirectoryBucket >> 2, pDirectoryEntry, offsetDirectoryEntry, sizeDirectoryEntry);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      Result result2;
      \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EFormat(&result2, pFileBucket, offsetFileBucket, sizeFileBucket >> 2, pFileEntry, offsetFileEntry, sizeFileEntry);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 == 0)
      {
        *(int*) obj0 = 0;
        return obj0;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj0, ref result2, 4);
      return obj0;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, ref result1, 4);
    return obj0;
  }

  internal static unsafe HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bctor\u007D([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002E\u007Bctor\u007D((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0);
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002E\u007Bctor\u007D((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) ((IntPtr) obj0 + 40));
    return obj0;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EInitialize([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, IStorage* pDirectoryBucket, long offsetDirectoryBucket, uint sizeDirectoryBucket, IStorage* pDirectoryEntry, long offsetDirectoryEntry, uint sizeDirectoryEntry, IStorage* pFileBucket, long offsetFileBucket, uint sizeFileBucket, IStorage* pFileEntry, long offsetFileEntry, uint sizeFileEntry)
  {
    *(int*) ((IntPtr) obj0 + 12) = (int) pDirectoryBucket;
    *(long*) obj0 = offsetDirectoryBucket;
    *(int*) ((IntPtr) obj0 + 8) = (int) (sizeDirectoryBucket >> 2);
    *(int*) ((IntPtr) obj0 + 28) = (int) pDirectoryEntry;
    *(long*) ((IntPtr) obj0 + 16) = offsetDirectoryEntry;
    *(int*) ((IntPtr) obj0 + 24) = (int) sizeDirectoryEntry;
    *(int*) ((IntPtr) obj0 + 40 + 12) = (int) pFileBucket;
    *(long*) ((IntPtr) obj0 + 40) = offsetFileBucket;
    *(int*) ((IntPtr) obj0 + 40 + 8) = (int) (sizeFileBucket >> 2);
    *(int*) ((IntPtr) obj0 + 40 + 28) = (int) pFileEntry;
    *(long*) ((IntPtr) obj0 + 40 + 16) = offsetFileEntry;
    *(int*) ((IntPtr) obj0 + 40 + 24) = (int) sizeFileEntry;
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002ECreateRootDirectory([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1)
  {
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey entryKey;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref entryKey = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &entryKey + 4) = 0;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref directoryEntry = -1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &directoryEntry + 4) = -1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &directoryEntry + 8) = -1;
    uint num;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EAddInternal((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0, obj1, &num, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey*) &entryKey, \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash(&entryKey), (void*) ^(int&) ((IntPtr) &entryKey + 8), 0U, &directoryEntry);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002ECreateDirectory([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, int* pDirId, sbyte* pFullPath, RomDirectoryInfo* dirInfo)
  {
    Result result1;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey entryKey1;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry1;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey entryKey2;
    \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFindPathRecursive(obj0, &result1, &entryKey1, &directoryEntry1, &entryKey2, true, pFullPath);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      Result resultIfExist;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref resultIfExist = 4047874;
      Result result2;
      \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002ECheckSameEntryExists(obj0, &result2, &entryKey2, resultIfExist);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 == 0)
      {
        HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry2;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref directoryEntry2 = -1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &directoryEntry2 + 4) = -1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &directoryEntry2 + 8) = -1;
        Result result3;
        uint num;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EAddInternal((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0, &result3, &num, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey*) &entryKey2, \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash(&entryKey2), (void*) ^(int&) ((IntPtr) &entryKey2 + 8), (uint) ^(int&) ((IntPtr) &entryKey2 + 4), &directoryEntry2);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result3 != 0)
        {
          if (\u003CModule\u003E.nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7907\u002C7908\u003E\u002EIncludes(result3))
          {
            *(int*) obj1 = 4048898;
            return obj1;
          }
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, ref result3, 4);
          return obj1;
        }
        *pDirId = (int) num;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ((IntPtr) &directoryEntry1 + 4) == -1)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ((IntPtr) &directoryEntry1 + 4) = (int) num;
          WriteOption writeOption;
          // ISSUE: initblk instruction
          __memset(ref writeOption, 0, 4);
          WriteOption option = writeOption;
          Result result4;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002ESetByPosition((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0, &result4, (uint) ^(int&) ref entryKey2, &directoryEntry1, option);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result4 != 0)
          {
            // ISSUE: cpblk instruction
            __memcpy((IntPtr) obj1, ref result4, 4);
            return obj1;
          }
        }
        else
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          uint pos = (uint) ^(int&) ((IntPtr) &directoryEntry1 + 4);
          Result result4;
          HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry3;
          while (true)
          {
            HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey romEntryKey;
            \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EGetByPosition((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0, &result4, &romEntryKey, &directoryEntry3, (void*) 0, (uint*) 0, pos);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if (^(int&) ref result4 == 0)
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if (^(int&) ref directoryEntry3 != -1)
              {
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                pos = (uint) ^(int&) ref directoryEntry3;
              }
              else
                break;
            }
            else
              goto label_16;
          }
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ref directoryEntry3 = (int) num;
          WriteOption writeOption;
          // ISSUE: initblk instruction
          __memset(ref writeOption, 0, 4);
          WriteOption option = writeOption;
          Result result5;
          \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002ESetByPosition((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0, &result5, pos, &directoryEntry3, option);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result5 != 0)
          {
            // ISSUE: cpblk instruction
            __memcpy((IntPtr) obj1, ref result5, 4);
            return obj1;
          }
          goto label_14;
label_16:
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, ref result4, 4);
          return obj1;
        }
label_14:
        *(int*) obj1 = 0;
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result2, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002ECreateFileW([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, int* pFileId, sbyte* pFullPath, RomFileInfo* fileInfo)
  {
    Result result1;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey entryKey1;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey entryKey2;
    \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFindPathRecursive(obj0, &result1, &entryKey1, &directoryEntry, &entryKey2, false, pFullPath);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      Result resultIfExist;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref resultIfExist = 4047874;
      Result result2;
      \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002ECheckSameEntryExists(obj0, &result2, &entryKey2, resultIfExist);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 == 0)
      {
        HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry fileEntry1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref fileEntry1 = -1;
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy((HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry&) ((IntPtr) &fileEntry1 + 4), (IntPtr) fileInfo, 16);
        uint maxValue = uint.MaxValue;
        HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* istorageNnFsIstoragePtr = (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) obj0 + 40);
        Result result3;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EAddInternal((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) istorageNnFsIstoragePtr, &result3, &maxValue, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey*) &entryKey2, \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash(&entryKey2), (void*) ^(int&) ((IntPtr) &entryKey2 + 8), (uint) ^(int&) ((IntPtr) &entryKey2 + 4), &fileEntry1);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result3 != 0)
        {
          if (\u003CModule\u003E.nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7907\u002C7908\u003E\u002EIncludes(result3))
          {
            *(int*) obj1 = 4049410;
            return obj1;
          }
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, ref result3, 4);
          return obj1;
        }
        *pFileId = (int) maxValue;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ((IntPtr) &directoryEntry + 8) == -1)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ((IntPtr) &directoryEntry + 8) = (int) maxValue;
          WriteOption writeOption;
          // ISSUE: initblk instruction
          __memset(ref writeOption, 0, 4);
          WriteOption option = writeOption;
          Result result4;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002ESetByPosition((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0, &result4, (uint) ^(int&) ref entryKey2, &directoryEntry, option);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result4 != 0)
          {
            // ISSUE: cpblk instruction
            __memcpy((IntPtr) obj1, ref result4, 4);
            return obj1;
          }
        }
        else
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          uint pos = (uint) ^(int&) ((IntPtr) &directoryEntry + 8);
          Result result4;
          HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry fileEntry2;
          while (true)
          {
            HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey romEntryKey;
            \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EGetByPosition((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) istorageNnFsIstoragePtr, &result4, &romEntryKey, &fileEntry2, (void*) 0, (uint*) 0, pos);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if (^(int&) ref result4 == 0)
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if (^(int&) ref fileEntry2 != -1)
              {
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                pos = (uint) ^(int&) ref fileEntry2;
              }
              else
                break;
            }
            else
              goto label_16;
          }
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ref fileEntry2 = (int) maxValue;
          WriteOption writeOption;
          // ISSUE: initblk instruction
          __memset(ref writeOption, 0, 4);
          WriteOption option = writeOption;
          Result result5;
          \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002ESetByPosition((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) istorageNnFsIstoragePtr, &result5, pos, &fileEntry2, option);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result5 != 0)
          {
            // ISSUE: cpblk instruction
            __memcpy((IntPtr) obj1, ref result5, 4);
            return obj1;
          }
          goto label_14;
label_16:
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, ref result4, 4);
          return obj1;
        }
label_14:
        *(int*) obj1 = 0;
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result2, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetDirectoryInformation([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, RomDirectoryInfo* pDirInfo, sbyte* pFullPath)
  {
    Result result1;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey entryKey1;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry1;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey entryKey2;
    \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFindPathRecursive(obj0, &result1, &entryKey1, &directoryEntry1, &entryKey2, true, pFullPath);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      Result result2;
      uint num;
      HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry2;
      \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetDirectoryEntry(obj0, &result2, &num, &directoryEntry2, &entryKey2);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 == 0)
      {
        *(int*) obj1 = 0;
      }
      else
      {
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) obj1, ref result2, 4);
      }
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EQueryRomFileSystemSize([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, uint* pSizeDirectoryEntry, uint* pSizeFileEntry)
  {
    *pSizeDirectoryEntry = (uint) *(int*) ((IntPtr) obj0 + 32);
    *pSizeFileEntry = (uint) *(int*) ((IntPtr) obj0 + 72);
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static ulong nn\u002Eutil\u002Ealign_up\u003Cunsigned\u0020__int64\u003E(ulong x, uint align)
  {
    ulong num = (ulong) (align - 1U);
    return (ulong) ((long) num + (long) x & ~(long) num);
  }

  internal static uint nn\u002Eutil\u002Ealign_up\u003Cunsigned\u0020int\u003E(uint x, uint align)
  {
    uint num = align - 1U;
    return (uint) ((int) num + (int) x & ~(int) num);
  }

  internal static unsafe RomFsFileSystemMetaInfo* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003ARomFsFileSystemMetaInfo\u0020\u005E\u003E(object obj, RomFsFileSystemMetaInfo* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static unsafe HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E\u002E\u007Bctor\u007D([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E* obj0)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002E\u007Bctor\u007D((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0);
    return obj0;
  }

  internal static unsafe HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E\u002E\u007Bctor\u007D([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E* obj0)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002E\u007Bctor\u007D((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) obj0);
    return obj0;
  }

  internal static unsafe uint nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EGetTotalEntrySize([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0)
  {
    return (uint) *(int*) ((IntPtr) obj0 + 32);
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EInitialize([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, IStorage* pBucket, long offsetBucket, uint countBucket, IStorage* pKeyValue, long offsetKeyValue, uint sizeKeyValue)
  {
    *(int*) ((IntPtr) obj0 + 12) = (int) pBucket;
    *(long*) obj0 = offsetBucket;
    *(int*) ((IntPtr) obj0 + 8) = (int) countBucket;
    *(int*) ((IntPtr) obj0 + 28) = (int) pKeyValue;
    *(long*) ((IntPtr) obj0 + 16) = offsetKeyValue;
    *(int*) ((IntPtr) obj0 + 24) = (int) sizeKeyValue;
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002E\u007Bctor\u007D([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0)
  {
    *(long*) obj0 = 0L;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    *(int*) ((IntPtr) obj0 + 12) = 0;
    *(long*) ((IntPtr) obj0 + 16) = 0L;
    *(int*) ((IntPtr) obj0 + 24) = 0;
    *(int*) ((IntPtr) obj0 + 28) = 0;
    *(int*) ((IntPtr) obj0 + 32) = 0;
    *(int*) ((IntPtr) obj0 + 36) = 0;
    return obj0;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EFormat([In] Result* obj0, IStorage* pBucket, long offsetBucket, uint countBucket, IStorage* pKeyValue, long offsetKeyValue, uint sizeKeyValue)
  {
    long maxValue = (long) uint.MaxValue;
    uint num1 = 0;
    if (0U < countBucket)
    {
      uint num2 = 0;
      Result result;
      do
      {
        IStorage* istoragePtr = pBucket;
        ref Result local1 = ref result;
        long num3 = (long) num2 + offsetBucket;
        ref long local2 = ref maxValue;
        int num4 = 4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        Result* resultPtr = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) pBucket + 8))((uint) istoragePtr, (void*) ref local1, num3, (Result*) ref local2, (IntPtr) num4);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result == 0)
        {
          ++num1;
          num2 += 4U;
        }
        else
          goto label_4;
      }
      while (num1 < countBucket);
      goto label_5;
label_4:
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj0, ref result, 4);
      return obj0;
    }
label_5:
    *(int*) obj0 = 0;
    return obj0;
  }

  internal static uint nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EQueryKeyValueStorageSize(uint countKeyValue)
  {
    return countKeyValue * 32U;
  }

  internal static uint nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EQueryBucketCount(uint size)
  {
    return size >> 2;
  }

  internal static uint nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EQueryBucketStorageSize(uint countBucket)
  {
    return countBucket << 2;
  }

  internal static unsafe uint nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EGetTotalEntrySize([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0)
  {
    return (uint) *(int*) ((IntPtr) obj0 + 32);
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EInitialize([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, IStorage* pBucket, long offsetBucket, uint countBucket, IStorage* pKeyValue, long offsetKeyValue, uint sizeKeyValue)
  {
    *(int*) ((IntPtr) obj0 + 12) = (int) pBucket;
    *(long*) obj0 = offsetBucket;
    *(int*) ((IntPtr) obj0 + 8) = (int) countBucket;
    *(int*) ((IntPtr) obj0 + 28) = (int) pKeyValue;
    *(long*) ((IntPtr) obj0 + 16) = offsetKeyValue;
    *(int*) ((IntPtr) obj0 + 24) = (int) sizeKeyValue;
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002E\u007Bctor\u007D([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0)
  {
    *(long*) obj0 = 0L;
    *(int*) ((IntPtr) obj0 + 8) = 0;
    *(int*) ((IntPtr) obj0 + 12) = 0;
    *(long*) ((IntPtr) obj0 + 16) = 0L;
    *(int*) ((IntPtr) obj0 + 24) = 0;
    *(int*) ((IntPtr) obj0 + 28) = 0;
    *(int*) ((IntPtr) obj0 + 32) = 0;
    *(int*) ((IntPtr) obj0 + 36) = 0;
    return obj0;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EFormat([In] Result* obj0, IStorage* pBucket, long offsetBucket, uint countBucket, IStorage* pKeyValue, long offsetKeyValue, uint sizeKeyValue)
  {
    long maxValue = (long) uint.MaxValue;
    uint num1 = 0;
    if (0U < countBucket)
    {
      uint num2 = 0;
      Result result;
      do
      {
        IStorage* istoragePtr = pBucket;
        ref Result local1 = ref result;
        long num3 = (long) num2 + offsetBucket;
        ref long local2 = ref maxValue;
        int num4 = 4;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        Result* resultPtr = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) pBucket + 8))((uint) istoragePtr, (void*) ref local1, num3, (Result*) ref local2, (IntPtr) num4);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result == 0)
        {
          ++num1;
          num2 += 4U;
        }
        else
          goto label_4;
      }
      while (num1 < countBucket);
      goto label_5;
label_4:
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj0, ref result, 4);
      return obj0;
    }
label_5:
    *(int*) obj0 = 0;
    return obj0;
  }

  internal static uint nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EQueryKeyValueStorageSize(uint countKeyValue)
  {
    return countKeyValue * 24U;
  }

  internal static uint nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EQueryBucketStorageSize(uint countBucket)
  {
    return countBucket << 2;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E\u002ESetByPosition([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E* obj0, [In] Result* obj1, uint pos, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry* value, WriteOption option)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002ESetByPosition((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) obj0, obj1, pos, value, option);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E\u002EGetByPosition([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E* obj0, [In] Result* obj1, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* pKey, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry* pValue, void* pExtraKey, uint* pExtraSize, uint pos)
  {
    Result result;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement storageElement;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EReadKeyValue((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) obj0, &result, &storageElement, pExtraKey, pExtraSize, pos);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pKey, ref storageElement, 4);
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pValue, (KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), 20);
      *(int*) obj1 = 0;
    }
    else
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result, 4);
    }
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E\u002EAdd([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E* obj0, [In] Result* obj1, uint* pOutPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* key, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry* value)
  {
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E* istorageFileEntryPtr = obj0;
    Result* resultPtr = obj1;
    uint* pPosition = pOutPosition;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* entryKeyPtr = key;
    int num1 = (int) \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash(entryKeyPtr);
    int num2 = *(int*) ((IntPtr) key + 8);
    int num3 = *(int*) ((IntPtr) key + 4);
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry* fileEntryPtr = value;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EAddInternal((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) istorageFileEntryPtr, resultPtr, pPosition, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey*) entryKeyPtr, (uint) num1, (void*) num2, (uint) num3, fileEntryPtr);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E\u002ESetByPosition([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E* obj0, [In] Result* obj1, uint pos, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* value, WriteOption option)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002ESetByPosition((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0, obj1, pos, value, option);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E\u002EGetByPosition([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E* obj0, [In] Result* obj1, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* pKey, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pValue, void* pExtraKey, uint* pExtraSize, uint pos)
  {
    Result result;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement storageElement;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EReadKeyValue((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0, &result, &storageElement, pExtraKey, pExtraSize, pos);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pKey, ref storageElement, 4);
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pValue, (KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), 12);
      *(int*) obj1 = 0;
    }
    else
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result, 4);
    }
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E\u002EAdd([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E* obj0, [In] Result* obj1, uint* pOutPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* key, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* value)
  {
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E* istorageDirectoryEntryPtr = obj0;
    Result* resultPtr = obj1;
    uint* pPosition = pOutPosition;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* entryKeyPtr = key;
    int num1 = (int) \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash(entryKeyPtr);
    int num2 = *(int*) ((IntPtr) key + 8);
    int num3 = *(int*) ((IntPtr) key + 4);
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* directoryEntryPtr = value;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EAddInternal((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) istorageDirectoryEntryPtr, resultPtr, pPosition, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey*) entryKeyPtr, (uint) num1, (void*) num2, (uint) num3, directoryEntryPtr);
    return obj1;
  }

  internal static int nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EPositionToDirectoryId(uint pos)
  {
    return (int) pos;
  }

  internal static int nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EPositionToFileId(uint pos)
  {
    return (int) pos;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C7909\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C7909\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 4049410;
    return obj1;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C7908\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C7908\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 4048898;
    return obj1;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7907\u002C7908\u003E\u002EIncludes(Result result)
  {
    int num1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if ((^(int&) ref result & 511) == 2)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      uint num2 = (uint) ^(int&) ref result >> 9 & 8191U;
      if (7907 <= (int) num2 && (int) num2 < 7908)
      {
        num1 = 1;
        goto label_4;
      }
    }
    num1 = 0;
label_4:
    return num1 != 0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C7906\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C7906\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 4047874;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002ESetByPosition([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, uint pos, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry* value, WriteOption option)
  {
    Result result;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement storageElement;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EReadKeyValue(obj0, &result, &storageElement, (void*) 0, (uint*) 0, pos);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), (IntPtr) value, 20);
      \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EWriteKeyValue(obj0, obj1, &storageElement, pos, (void*) 0, 0U, option);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EGetByPosition([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* pKey, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry* pValue, void* pExtraKey, uint* pExtraSize, uint pos)
  {
    Result result;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement storageElement;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EReadKeyValue(obj0, &result, &storageElement, pExtraKey, pExtraSize, pos);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pKey, ref storageElement, 4);
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pValue, (KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), 20);
      *(int*) obj1 = 0;
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EAddInternal([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* key, uint hashKey, void* pExtraKey, uint extraSize, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry* value)
  {
    Result result1;
    uint pos;
    uint num1;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement storageElement;
    Result* resultPtr = \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EFindInternal(obj0, &result1, &pos, &num1, &storageElement, key, hashKey, pExtraKey, extraSize);
    Result result2;
    // ISSUE: cpblk instruction
    __memcpy(ref result2, (IntPtr) resultPtr, 4);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result2 == 0)
    {
      *(int*) obj1 = 4047874;
      return obj1;
    }
    if (!\u003CModule\u003E.nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7902\u002C7903\u003E\u002EIncludes(result2))
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result2, 4);
      return obj1;
    }
    Result result3;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EAllocateEntry(obj0, &result3, &pos, extraSize);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result3 == 0)
    {
      Result result4;
      uint num2;
      \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002ELinkEntry(obj0, &result4, &num2, pos, hashKey);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result4 == 0)
      {
        // ISSUE: cpblk instruction
        __memcpy(ref storageElement, (IntPtr) key, 4);
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), (IntPtr) value, 20);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &storageElement + 24) = (int) num2;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &storageElement + 28) = (int) extraSize;
        *pPosition = pos;
        WriteOption option;
        // ISSUE: initblk instruction
        __memset(ref option, 0, 4);
        Result result5;
        \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EWriteKeyValue(obj0, &result5, &storageElement, pos, pExtraKey, extraSize, option);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result5 == 0)
        {
          *(int*) ((IntPtr) obj0 + 36) = *(int*) ((IntPtr) obj0 + 36) + 1;
          *(int*) obj1 = 0;
          return obj1;
        }
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) obj1, ref result5, 4);
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result4, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result3, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002ESetByPosition([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, uint pos, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* value, WriteOption option)
  {
    Result result;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement storageElement;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EReadKeyValue(obj0, &result, &storageElement, (void*) 0, (uint*) 0, pos);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), (IntPtr) value, 12);
      \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EWriteKeyValue(obj0, obj1, &storageElement, pos, (void*) 0, 0U, option);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EGetByPosition([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* pKey, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pValue, void* pExtraKey, uint* pExtraSize, uint pos)
  {
    Result result;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement storageElement;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EReadKeyValue(obj0, &result, &storageElement, pExtraKey, pExtraSize, pos);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pKey, ref storageElement, 4);
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pValue, (KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), 12);
      *(int*) obj1 = 0;
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EAddInternal([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* key, uint hashKey, void* pExtraKey, uint extraSize, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* value)
  {
    Result result1;
    uint pos;
    uint num1;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement storageElement;
    Result* resultPtr = \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EFindInternal(obj0, &result1, &pos, &num1, &storageElement, key, hashKey, pExtraKey, extraSize);
    Result result2;
    // ISSUE: cpblk instruction
    __memcpy(ref result2, (IntPtr) resultPtr, 4);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result2 == 0)
    {
      *(int*) obj1 = 4047874;
      return obj1;
    }
    if (!\u003CModule\u003E.nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7902\u002C7903\u003E\u002EIncludes(result2))
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result2, 4);
      return obj1;
    }
    Result result3;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EAllocateEntry(obj0, &result3, &pos, extraSize);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result3 == 0)
    {
      Result result4;
      uint num2;
      \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002ELinkEntry(obj0, &result4, &num2, pos, hashKey);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result4 == 0)
      {
        // ISSUE: cpblk instruction
        __memcpy(ref storageElement, (IntPtr) key, 4);
        // ISSUE: cast to a reference type
        // ISSUE: cpblk instruction
        __memcpy((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), (IntPtr) value, 12);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &storageElement + 16) = (int) num2;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &storageElement + 20) = (int) extraSize;
        *pPosition = pos;
        WriteOption option;
        // ISSUE: initblk instruction
        __memset(ref option, 0, 4);
        Result result5;
        \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EWriteKeyValue(obj0, &result5, &storageElement, pos, pExtraKey, extraSize, option);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result5 == 0)
        {
          *(int*) ((IntPtr) obj0 + 36) = *(int*) ((IntPtr) obj0 + 36) + 1;
          *(int*) obj1 = 0;
          return obj1;
        }
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) obj1, ref result5, 4);
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result4, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result3, 4);
    return obj1;
  }

  internal static unsafe uint nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* obj0)
  {
    uint num = (uint) (*(int*) obj0 ^ 123456789);
    sbyte* numPtr1 = (sbyte*) *(int*) ((IntPtr) obj0 + 8);
    sbyte* numPtr2 = (sbyte*) (*(int*) ((IntPtr) obj0 + 4) + (IntPtr) numPtr1);
    if (numPtr1 < numPtr2)
    {
      do
      {
        num = (num << 27 | num >> 5) ^ (uint) (byte) *numPtr1;
        ++numPtr1;
      }
      while (numPtr1 < numPtr2);
    }
    return num;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EWriteKeyValue([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement* pElement, uint pos, void* pExtraKey, uint extraSize, WriteOption option)
  {
    long num1 = *(long*) ((IntPtr) obj0 + 16) + (long) pos;
    int num2 = *(int*) ((IntPtr) obj0 + 28);
    int num3 = num2;
    Result result1;
    ref Result local1 = ref result1;
    long num4 = num1;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement* storageElementPtr = pElement;
    int num5 = 32;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    Result* resultPtr1 = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 8))((uint) num3, (void*) ref local1, num4, (Result*) storageElementPtr, (IntPtr) num5);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      if ((IntPtr) pExtraKey != IntPtr.Zero && extraSize > 0U)
      {
        int num6 = *(int*) ((IntPtr) obj0 + 28);
        int num7 = num6;
        Result result2;
        ref Result local2 = ref result2;
        long num8 = num1 + 32L;
        void* voidPtr = pExtraKey;
        int num9 = (int) extraSize;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        Result* resultPtr2 = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num6 + 8))((uint) num7, (void*) ref local2, num8, (Result*) voidPtr, (IntPtr) num9);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result2 != 0)
        {
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, ref result2, 4);
          return obj1;
        }
      }
      *(int*) obj1 = 0;
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EReadKeyValue([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement* pElement, void* pExtraKey, uint* pExtraSize, uint pos)
  {
    long num1 = *(long*) ((IntPtr) obj0 + 16) + (long) pos;
    int num2 = *(int*) ((IntPtr) obj0 + 28);
    int num3 = num2;
    Result result1;
    ref Result local1 = ref result1;
    long num4 = num1;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement* storageElementPtr = pElement;
    int num5 = 32;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    Result* resultPtr1 = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 4))((uint) num3, (void*) ref local1, num4, (Result*) storageElementPtr, (IntPtr) num5);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      if ((IntPtr) pExtraKey != IntPtr.Zero && (IntPtr) pExtraSize != IntPtr.Zero)
      {
        *pExtraSize = (uint) *(int*) ((IntPtr) pElement + 28);
        uint num6 = (uint) *(int*) ((IntPtr) pElement + 28);
        if (num6 > 0U)
        {
          int num7 = *(int*) ((IntPtr) obj0 + 28);
          int num8 = num7;
          Result result2;
          ref Result local2 = ref result2;
          long num9 = num1 + 32L;
          void* voidPtr = pExtraKey;
          int num10 = (int) num6;
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          Result* resultPtr2 = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num7 + 4))((uint) num8, (void*) ref local2, num9, (Result*) voidPtr, (IntPtr) num10);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result2 != 0)
          {
            // ISSUE: cpblk instruction
            __memcpy((IntPtr) obj1, ref result2, 4);
            return obj1;
          }
        }
      }
      *(int*) obj1 = 0;
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002ELinkEntry([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pPrevPosition, uint pos, uint hashKey)
  {
    long num1 = (long) (hashKey % (uint) *(int*) ((IntPtr) obj0 + 8) << 2);
    long num2 = num1 + *(long*) obj0;
    int num3 = *(int*) ((IntPtr) obj0 + 12);
    int num4 = num3;
    Result result1;
    ref Result local1 = ref result1;
    long num5 = num2;
    uint num6;
    ref uint local2 = ref num6;
    int num7 = 4;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num8 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num3 + 4))((uint) num4, (void*) ref local1, num5, (Result*) ref local2, (IntPtr) num7);
    Result result2;
    // ISSUE: cpblk instruction
    __memcpy(ref result2, num8, 4);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result2 == 0)
    {
      uint num9 = pos;
      long num10 = num1 + *(long*) obj0;
      int num11 = *(int*) ((IntPtr) obj0 + 12);
      int num12 = num11;
      Result result3;
      ref Result local3 = ref result3;
      long num13 = num10;
      ref uint local4 = ref num9;
      int num14 = 4;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num15 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num11 + 8))((uint) num12, (void*) ref local3, num13, (Result*) ref local4, (IntPtr) num14);
      Result result4;
      // ISSUE: cpblk instruction
      __memcpy(ref result4, num15, 4);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result4 == 0)
      {
        *pPrevPosition = num6;
        *(int*) obj1 = 0;
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result4, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result2, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EAllocateEntry([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pEntry, uint extraSize)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 32);
    if ((uint) ((int) extraSize + (int) num + 32) > (uint) *(int*) ((IntPtr) obj0 + 24))
    {
      *(int*) obj1 = 4048386;
      return obj1;
    }
    *pEntry = num;
    *(int*) ((IntPtr) obj0 + 32) = *(int*) ((IntPtr) obj0 + 32) + (int) extraSize + 35 & -4;
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EFindInternal([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pPosition, uint* pPreviousPosition, KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement* pStoreElement, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* key, uint hashKey, void* pExtraKey, uint extraSize)
  {
    *pPosition = 0U;
    *pPreviousPosition = 0U;
    long num1 = (long) (hashKey % (uint) *(int*) ((IntPtr) obj0 + 8) << 2) + *(long*) obj0;
    int num2 = *(int*) ((IntPtr) obj0 + 12);
    int num3 = num2;
    Result result1;
    ref Result local1 = ref result1;
    long num4 = num1;
    uint num5;
    ref uint local2 = ref num5;
    int num6 = 4;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num7 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 4))((uint) num3, (void*) ref local1, num4, (Result*) ref local2, (IntPtr) num6);
    Result result2;
    // ISSUE: cpblk instruction
    __memcpy(ref result2, num7, 4);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result2 == 0)
    {
      if (num5 == uint.MaxValue)
      {
        *(int*) obj1 = 4045826;
        return obj1;
      }
      uint pos = num5;
      Result result3;
      do
      {
        uint num8 = 0;
        \u0024ArrayType\u0024\u0024\u0024BY0DAA\u0040E arrayTypeBy0DaaE;
        \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EReadKeyValue(obj0, &result3, pStoreElement, (void*) &arrayTypeBy0DaaE, &num8, pos);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result3 == 0)
        {
          if (*(int*) key != *(int*) pStoreElement || (int) extraSize != (int) num8 || \u003CModule\u003E.strncmp((sbyte*) pExtraKey, (sbyte*) &arrayTypeBy0DaaE, extraSize) != 0)
          {
            *pPreviousPosition = pos;
            pos = (uint) *(int*) ((IntPtr) pStoreElement + 24);
          }
          else
            goto label_7;
        }
        else
          goto label_9;
      }
      while (uint.MaxValue != pos);
      goto label_8;
label_7:
      *pPosition = pos;
      *(int*) obj1 = 0;
      return obj1;
label_8:
      *(int*) obj1 = 4045826;
      return obj1;
label_9:
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result3, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result2, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EWriteKeyValue([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement* pElement, uint pos, void* pExtraKey, uint extraSize, WriteOption option)
  {
    long num1 = *(long*) ((IntPtr) obj0 + 16) + (long) pos;
    int num2 = *(int*) ((IntPtr) obj0 + 28);
    int num3 = num2;
    Result result1;
    ref Result local1 = ref result1;
    long num4 = num1;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement* storageElementPtr = pElement;
    int num5 = 24;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    Result* resultPtr1 = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 8))((uint) num3, (void*) ref local1, num4, (Result*) storageElementPtr, (IntPtr) num5);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      if ((IntPtr) pExtraKey != IntPtr.Zero && extraSize > 0U)
      {
        int num6 = *(int*) ((IntPtr) obj0 + 28);
        int num7 = num6;
        Result result2;
        ref Result local2 = ref result2;
        long num8 = num1 + 24L;
        void* voidPtr = pExtraKey;
        int num9 = (int) extraSize;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        Result* resultPtr2 = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num6 + 8))((uint) num7, (void*) ref local2, num8, (Result*) voidPtr, (IntPtr) num9);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result2 != 0)
        {
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, ref result2, 4);
          return obj1;
        }
      }
      *(int*) obj1 = 0;
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EReadKeyValue([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement* pElement, void* pExtraKey, uint* pExtraSize, uint pos)
  {
    long num1 = *(long*) ((IntPtr) obj0 + 16) + (long) pos;
    int num2 = *(int*) ((IntPtr) obj0 + 28);
    int num3 = num2;
    Result result1;
    ref Result local1 = ref result1;
    long num4 = num1;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement* storageElementPtr = pElement;
    int num5 = 24;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    Result* resultPtr1 = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 4))((uint) num3, (void*) ref local1, num4, (Result*) storageElementPtr, (IntPtr) num5);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      if ((IntPtr) pExtraKey != IntPtr.Zero && (IntPtr) pExtraSize != IntPtr.Zero)
      {
        *pExtraSize = (uint) *(int*) ((IntPtr) pElement + 20);
        uint num6 = (uint) *(int*) ((IntPtr) pElement + 20);
        if (num6 > 0U)
        {
          int num7 = *(int*) ((IntPtr) obj0 + 28);
          int num8 = num7;
          Result result2;
          ref Result local2 = ref result2;
          long num9 = num1 + 24L;
          void* voidPtr = pExtraKey;
          int num10 = (int) num6;
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          Result* resultPtr2 = __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num7 + 4))((uint) num8, (void*) ref local2, num9, (Result*) voidPtr, (IntPtr) num10);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result2 != 0)
          {
            // ISSUE: cpblk instruction
            __memcpy((IntPtr) obj1, ref result2, 4);
            return obj1;
          }
        }
      }
      *(int*) obj1 = 0;
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002ELinkEntry([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pPrevPosition, uint pos, uint hashKey)
  {
    long num1 = (long) (hashKey % (uint) *(int*) ((IntPtr) obj0 + 8) << 2);
    long num2 = num1 + *(long*) obj0;
    int num3 = *(int*) ((IntPtr) obj0 + 12);
    int num4 = num3;
    Result result1;
    ref Result local1 = ref result1;
    long num5 = num2;
    uint num6;
    ref uint local2 = ref num6;
    int num7 = 4;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num8 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num3 + 4))((uint) num4, (void*) ref local1, num5, (Result*) ref local2, (IntPtr) num7);
    Result result2;
    // ISSUE: cpblk instruction
    __memcpy(ref result2, num8, 4);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result2 == 0)
    {
      uint num9 = pos;
      long num10 = num1 + *(long*) obj0;
      int num11 = *(int*) ((IntPtr) obj0 + 12);
      int num12 = num11;
      Result result3;
      ref Result local3 = ref result3;
      long num13 = num10;
      ref uint local4 = ref num9;
      int num14 = 4;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num15 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num11 + 8))((uint) num12, (void*) ref local3, num13, (Result*) ref local4, (IntPtr) num14);
      Result result4;
      // ISSUE: cpblk instruction
      __memcpy(ref result4, num15, 4);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result4 == 0)
      {
        *pPrevPosition = num6;
        *(int*) obj1 = 0;
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result4, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result2, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EAllocateEntry([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pEntry, uint extraSize)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 32);
    if ((uint) ((int) extraSize + (int) num + 24) > (uint) *(int*) ((IntPtr) obj0 + 24))
    {
      *(int*) obj1 = 4048386;
      return obj1;
    }
    *pEntry = num;
    *(int*) ((IntPtr) obj0 + 32) = *(int*) ((IntPtr) obj0 + 32) + (int) extraSize + 27 & -4;
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EFindInternal([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pPosition, uint* pPreviousPosition, KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement* pStoreElement, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* key, uint hashKey, void* pExtraKey, uint extraSize)
  {
    *pPosition = 0U;
    *pPreviousPosition = 0U;
    long num1 = (long) (hashKey % (uint) *(int*) ((IntPtr) obj0 + 8) << 2) + *(long*) obj0;
    int num2 = *(int*) ((IntPtr) obj0 + 12);
    int num3 = num2;
    Result result1;
    ref Result local1 = ref result1;
    long num4 = num1;
    uint num5;
    ref uint local2 = ref num5;
    int num6 = 4;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num7 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 4))((uint) num3, (void*) ref local1, num4, (Result*) ref local2, (IntPtr) num6);
    Result result2;
    // ISSUE: cpblk instruction
    __memcpy(ref result2, num7, 4);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result2 == 0)
    {
      if (num5 == uint.MaxValue)
      {
        *(int*) obj1 = 4045826;
        return obj1;
      }
      uint pos = num5;
      Result result3;
      do
      {
        uint num8 = 0;
        \u0024ArrayType\u0024\u0024\u0024BY0DAA\u0040E arrayTypeBy0DaaE;
        \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EReadKeyValue(obj0, &result3, pStoreElement, (void*) &arrayTypeBy0DaaE, &num8, pos);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result3 == 0)
        {
          if (*(int*) key != *(int*) pStoreElement || (int) extraSize != (int) num8 || \u003CModule\u003E.strncmp((sbyte*) pExtraKey, (sbyte*) &arrayTypeBy0DaaE, extraSize) != 0)
          {
            *pPreviousPosition = pos;
            pos = (uint) *(int*) ((IntPtr) pStoreElement + 16);
          }
          else
            goto label_7;
        }
        else
          goto label_9;
      }
      while (uint.MaxValue != pos);
      goto label_8;
label_7:
      *pPosition = pos;
      *(int*) obj1 = 0;
      return obj1;
label_8:
      *(int*) obj1 = 4045826;
      return obj1;
label_9:
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result3, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result2, 4);
    return obj1;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7902\u002C7903\u003E\u002EIncludes(Result result)
  {
    int num1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if ((^(int&) ref result & 511) == 2)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      uint num2 = (uint) ^(int&) ref result >> 9 & 8191U;
      if (7902 <= (int) num2 && (int) num2 < 7903)
      {
        num1 = 1;
        goto label_4;
      }
    }
    num1 = 0;
label_4:
    return num1 != 0;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EWriteBucket([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, uint KvStorePosition, uint index, WriteOption option)
  {
    long num1 = (long) (index << 2) + *(long*) obj0;
    int num2 = *(int*) ((IntPtr) obj0 + 12);
    int num3 = num2;
    Result result;
    ref Result local1 = ref result;
    long num4 = num1;
    ref uint local2 = ref KvStorePosition;
    int num5 = 4;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num6 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 8))((uint) num3, (void*) ref local1, num4, (Result*) ref local2, (IntPtr) num5);
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, num6, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EReadBucket([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pKvStorePosition, uint index)
  {
    long num1 = (long) (index << 2) + *(long*) obj0;
    int num2 = *(int*) ((IntPtr) obj0 + 12);
    int num3 = num2;
    Result result;
    ref Result local = ref result;
    long num4 = num1;
    uint* numPtr = pKvStorePosition;
    int num5 = 4;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num6 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 4))((uint) num3, (void*) ref local, num4, (Result*) numPtr, (IntPtr) num5);
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, num6, 4);
    return obj1;
  }

  internal static unsafe uint nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EHashToBucket([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, uint hashKey)
  {
    return hashKey % (uint) *(int*) ((IntPtr) obj0 + 8);
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EWriteBucket([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, uint KvStorePosition, uint index, WriteOption option)
  {
    long num1 = (long) (index << 2) + *(long*) obj0;
    int num2 = *(int*) ((IntPtr) obj0 + 12);
    int num3 = num2;
    Result result;
    ref Result local1 = ref result;
    long num4 = num1;
    ref uint local2 = ref KvStorePosition;
    int num5 = 4;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num6 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 8))((uint) num3, (void*) ref local1, num4, (Result*) ref local2, (IntPtr) num5);
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, num6, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EReadBucket([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pKvStorePosition, uint index)
  {
    long num1 = (long) (index << 2) + *(long*) obj0;
    int num2 = *(int*) ((IntPtr) obj0 + 12);
    int num3 = num2;
    Result result;
    ref Result local = ref result;
    long num4 = num1;
    uint* numPtr = pKvStorePosition;
    int num5 = 4;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num6 = (int) __calli((__FnPtr<Result* (IntPtr, Result*, long, void*, uint)>) *(int*) (*(int*) num2 + 4))((uint) num3, (void*) ref local, num4, (Result*) numPtr, (IntPtr) num5);
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, num6, 4);
    return obj1;
  }

  internal static unsafe uint nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EHashToBucket([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, uint hashKey)
  {
    return hashKey % (uint) *(int*) ((IntPtr) obj0 + 8);
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002ERomEntryKey\u002EIsEqual([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* obj0, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* rKey, void* pExtraKey1, uint extraSize1, void* pExtraKey2, uint extraSize2)
  {
    if (*(int*) obj0 != *(int*) rKey || (int) extraSize1 != (int) extraSize2)
      return false;
    return \u003CModule\u003E.strncmp((sbyte*) pExtraKey1, (sbyte*) pExtraKey2, extraSize1) == 0;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C7907\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C7907\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 4048386;
    return obj1;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C7902\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C7902\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 4045826;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetDirectoryInformation([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, RomDirectoryInfo* pDirInfo, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* dirKey)
  {
    Result result;
    uint num;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry;
    \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetDirectoryEntry(obj0, &result, &num, &directoryEntry, dirKey);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      *(int*) obj1 = 0;
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFindDirectoryRecursive([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* pParentDirKey, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pParentDirEntry, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* pDirKey, sbyte* pFullPath)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFindPathRecursive(obj0, obj1, pParentDirKey, pParentDirEntry, pDirKey, true, pFullPath);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFindFileRecursive([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* pParentDirKey, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pParentDirEntry, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* pFileKey, sbyte* pFullPath)
  {
    \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFindPathRecursive(obj0, obj1, pParentDirKey, pParentDirEntry, pFileKey, false, pFullPath);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002ECheckSameEntryExists([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* key, Result resultIfExist)
  {
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* istorageNnFsIstoragePtr = obj0;
    Result result1;
    ref Result local1 = ref result1;
    uint num1;
    ref uint local2 = ref num1;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry;
    ref HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry local3 = ref directoryEntry;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* entryKeyPtr = key;
    int num2 = (int) \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash(entryKeyPtr);
    int num3 = *(int*) ((IntPtr) key + 8);
    int num4 = *(int*) ((IntPtr) key + 4);
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EGetInternal((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) istorageNnFsIstoragePtr, (Result*) ref local1, (uint*) ref local2, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry*) ref local3, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey*) entryKeyPtr, (uint) num2, (void*) num3, (uint) num4);
    if (!\u003CModule\u003E.nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7902\u002C7903\u003E\u002EIncludes(result1))
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result1 != 0)
      {
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) obj1, ref result1, 4);
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref resultIfExist, 4);
      return obj1;
    }
    Result result2;
    uint num5;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry fileEntry;
    \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E\u002EGet((HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E*) ((IntPtr) obj0 + 40), &result2, &num5, &fileEntry, key);
    if (!\u003CModule\u003E.nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7902\u002C7903\u003E\u002EIncludes(result2))
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 != 0)
      {
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) obj1, ref result2, 4);
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref resultIfExist, 4);
      return obj1;
    }
    *(int*) obj1 = 0;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E\u002EGet([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u003E* obj0, [In] Result* obj1, uint* pOutPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry* pValue, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* key)
  {
    uint extraSize = (uint) *(int*) ((IntPtr) key + 4);
    void* pExtraKey = (void*) *(int*) ((IntPtr) key + 8);
    uint hashKey = \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash(key);
    Result result;
    uint num1;
    uint num2;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement storageElement;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EFindInternal((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) obj0, &result, &num1, &num2, &storageElement, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey*) key, hashKey, pExtraKey, extraSize);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      *pOutPosition = num1;
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pValue, (KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), 20);
      *(int*) obj1 = 0;
    }
    else
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result, 4);
    }
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E\u002EGet([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryMapTable\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u003E* obj0, [In] Result* obj1, uint* pOutPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pValue, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* key)
  {
    uint extraSize = (uint) *(int*) ((IntPtr) key + 4);
    void* pExtraKey = (void*) *(int*) ((IntPtr) key + 8);
    uint hashKey = \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash(key);
    Result result;
    uint num1;
    uint num2;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement storageElement;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EFindInternal((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0, &result, &num1, &num2, &storageElement, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey*) key, hashKey, pExtraKey, extraSize);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      *pOutPosition = num1;
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pValue, (KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), 12);
      *(int*) obj1 = 0;
    }
    else
    {
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result, 4);
    }
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EGetInternal([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry* pValue, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* key, uint hashKey, void* pExtraKey, uint extraSize)
  {
    Result result;
    uint num1;
    uint num2;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement storageElement;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EFindInternal(obj0, &result, &num1, &num2, &storageElement, key, hashKey, pExtraKey, extraSize);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      *pPosition = num1;
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pValue, (KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), 20);
      *(int*) obj1 = 0;
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EGetInternal([In] KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E* obj0, [In] Result* obj1, uint* pPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pValue, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey* key, uint hashKey, void* pExtraKey, uint extraSize)
  {
    Result result;
    uint num1;
    uint num2;
    KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement storageElement;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EFindInternal(obj0, &result, &num1, &num2, &storageElement, key, hashKey, pExtraKey, extraSize);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result == 0)
    {
      *pPosition = num1;
      // ISSUE: cast to a reference type
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) pValue, (KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E.StorageElement&) ((IntPtr) &storageElement + 4), 12);
      *(int*) obj1 = 0;
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFindPathRecursive([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* pParentDirKey, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pParentDirEntry, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* pKey, [MarshalAs(UnmanagedType.U1)] bool bFindDir, sbyte* pFullPath)
  {
    PathParser pathParser;
    \u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002E\u007Bctor\u007D(&pathParser);
    Result result1;
    \u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EInitialize(&pathParser, &result1, pFullPath);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      uint num1 = 0;
      Result result2;
      \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFindParentDirRecursive(obj0, &result2, &num1, pParentDirKey, pParentDirEntry, &pathParser, pFullPath);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 == 0)
      {
        if (bFindDir)
        {
          Result result3;
          RomEntryName romEntryName;
          \u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EGetAsDirectoryName(&pathParser, &result3, &romEntryName);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result3 == 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ((^(int&) ref romEntryName != 1 || *(sbyte*) ^(int&) ((IntPtr) &romEntryName + 4) != (sbyte) 46 ? 0 : 1) != 0)
            {
              // ISSUE: cpblk instruction
              __memcpy((IntPtr) pKey, (IntPtr) pParentDirKey, 12);
              uint pos = (uint) *(int*) pKey;
              if (pos != 0U)
              {
                Result result4;
                uint num2;
                \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetGrandparent(obj0, &result4, &num2, pParentDirKey, pParentDirEntry, pos, *(RomEntryName*) ((IntPtr) pKey + 4), pFullPath);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if (^(int&) ref result4 != 0)
                {
                  // ISSUE: cpblk instruction
                  __memcpy((IntPtr) obj1, ref result4, 4);
                  return obj1;
                }
              }
            }
            else if (\u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EIsParentDirectory(&romEntryName))
            {
              if (num1 == 0U)
              {
                *(int*) obj1 = 4051970;
                return obj1;
              }
              Result result4;
              uint num2;
              HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry;
              \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetGrandparent(obj0, &result4, &num2, pKey, &directoryEntry, (uint) *(int*) pParentDirKey, *(RomEntryName*) ((IntPtr) pParentDirKey + 4), pFullPath);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if (^(int&) ref result4 == 0)
              {
                uint pos = (uint) *(int*) pKey;
                if (pos != 0U)
                {
                  Result result5;
                  \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetGrandparent(obj0, &result5, &num2, pParentDirKey, pParentDirEntry, pos, *(RomEntryName*) ((IntPtr) pKey + 4), pFullPath);
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if (^(int&) ref result5 != 0)
                  {
                    // ISSUE: cpblk instruction
                    __memcpy((IntPtr) obj1, ref result5, 4);
                    return obj1;
                  }
                }
              }
              else
              {
                // ISSUE: cpblk instruction
                __memcpy((IntPtr) obj1, ref result4, 4);
                return obj1;
              }
            }
            else
            {
              // ISSUE: cpblk instruction
              __memcpy((IntPtr) pKey + 4, ref romEntryName, 8);
              uint num2 = (uint) *(int*) ((IntPtr) pKey + 4) > 0U ? num1 : 0U;
              *(int*) pKey = (int) num2;
            }
          }
          else
          {
            // ISSUE: cpblk instruction
            __memcpy((IntPtr) obj1, ref result3, 4);
            return obj1;
          }
        }
        else
        {
          if (\u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EIsDirectoryPath(&pathParser))
          {
            *(int*) obj1 = 4051970;
            return obj1;
          }
          *(int*) pKey = (int) num1;
          Result result3;
          \u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EGetAsFileName(&pathParser, &result3, (RomEntryName*) ((IntPtr) pKey + 4));
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result3 != 0)
          {
            // ISSUE: cpblk instruction
            __memcpy((IntPtr) obj1, ref result3, 4);
            return obj1;
          }
        }
        *(int*) obj1 = 0;
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result2, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetDirectoryEntry([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, uint* pPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pEntry, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* key)
  {
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* istorageNnFsIstoragePtr = obj0;
    Result result1;
    ref Result local1 = ref result1;
    uint* pPosition1 = pPosition;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pValue = pEntry;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* entryKeyPtr1 = key;
    int num1 = (int) \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash(entryKeyPtr1);
    int num2 = *(int*) ((IntPtr) key + 8);
    int num3 = *(int*) ((IntPtr) key + 4);
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EGetInternal((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) istorageNnFsIstoragePtr, (Result*) ref local1, pPosition1, pValue, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey*) entryKeyPtr1, (uint) num1, (void*) num2, (uint) num3);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 != 0 && \u003CModule\u003E.nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7902\u002C7903\u003E\u002EIncludes(result1))
    {
      IntPtr num4 = (IntPtr) obj0 + 40;
      Result result2;
      ref Result local2 = ref result2;
      uint num5;
      ref uint local3 = ref num5;
      HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry fileEntry;
      ref HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry local4 = ref fileEntry;
      HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* entryKeyPtr2 = key;
      int num6 = (int) \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EEntryKey\u002EHash(entryKeyPtr2);
      int num7 = *(int*) ((IntPtr) key + 8);
      int num8 = *(int*) ((IntPtr) key + 4);
      \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E\u002EGetInternal((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003AFileEntry\u002C768\u003E*) num4, (Result*) ref local2, (uint*) ref local3, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.FileEntry*) ref local4, (HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey*) entryKeyPtr2, (uint) num6, (void*) num7, (uint) num8);
      Result result3 = result2;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 != 0)
      {
        if (!\u003CModule\u003E.nn\u002Eresult\u002Edetail\u002EErrorRange\u003C2\u002C7902\u002C7903\u003E\u002EIncludes(result3))
        {
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, ref result3, 4);
          return obj1;
        }
        *(int*) obj1 = 4046850;
        return obj1;
      }
      *(int*) obj1 = 4051970;
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C7914\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C7914\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 4051970;
    return obj1;
  }

  internal static unsafe Result* nn\u002Eresult\u002Edetail\u002EErrorResultBase\u003C2\u002C7904\u003E\u002E\u002E\u003FAVResult\u0040nn\u0040\u0040([In] ErrorResultBase\u003C2\u002C7904\u003E* obj0, [In] Result* obj1)
  {
    *(int*) obj1 = 4046850;
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetGrandparent([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, uint* pPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* pDirKey, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pDirEntry, uint pos, RomEntryName name, sbyte* pFullPath)
  {
    Result result1;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.RomEntryKey romEntryKey;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry;
    \u003CModule\u003E.nn\u002Efssystem\u002EKeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E\u002EGetByPosition((KeyValueRomStorageTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ARomEntryKey\u002Cnn\u003A\u003Afssystem\u003A\u003AHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u003A\u003ADirectoryEntry\u002C768\u003E*) obj0, &result1, &romEntryKey, &directoryEntry, (void*) 0, (uint*) 0, pos);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      *(int*) pDirKey = ^(int&) ref romEntryKey;
      Result result2;
      \u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EGetParentDirectoryName(&result2, (RomEntryName*) ((IntPtr) pDirKey + 4), &name, pFullPath);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 == 0)
      {
        Result result3;
        \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetDirectoryEntry(obj0, &result3, pPosition, pDirEntry, pDirKey);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ref result3 == 0)
        {
          *(int*) obj1 = 0;
          return obj1;
        }
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) obj1, ref result3, 4);
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result2, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe Result* nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EFindParentDirRecursive([In] HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj0, [In] Result* obj1, uint* pParentPosition, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey* pParentDirKey, HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry* pParentDirEntry, PathParser* parser, sbyte* pFullPath)
  {
    uint num1 = 0;
    HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey entryKey1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref entryKey1 = 0;
    Result result1;
    \u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EGetNextDirectoryName(parser, &result1, (RomEntryName*) ((IntPtr) &entryKey1 + 4));
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(int&) ref result1 == 0)
    {
      Result result2;
      HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.DirectoryEntry directoryEntry;
      \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetDirectoryEntry(obj0, &result2, &num1, &directoryEntry, &entryKey1);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result2 == 0)
      {
        uint num2 = num1;
        if (!\u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EIsParseFinished(parser))
        {
          Result result3;
          Result result4;
          Result result5;
          do
          {
            HierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E.EntryKey entryKey2 = entryKey1;
            \u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EGetNextDirectoryName(parser, &result3, (RomEntryName*) ((IntPtr) &entryKey1 + 4));
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if (^(int&) ref result3 == 0)
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ((^(int&) ((IntPtr) &entryKey1 + 4) != 1 || *(sbyte*) ^(int&) ((IntPtr) &entryKey1 + 8) != (sbyte) 46 ? 0 : 1) != 0)
                entryKey1 = entryKey2;
              else if (\u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EIsParentDirectory((RomEntryName*) ((IntPtr) &entryKey1 + 4)))
              {
                if (num2 != 0U)
                {
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetGrandparent(obj0, &result4, &num2, &entryKey1, &directoryEntry, (uint) ^(int&) ref entryKey1, ^(RomEntryName&) ((IntPtr) &entryKey1 + 4), pFullPath);
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if (^(int&) ref result4 != 0)
                    goto label_13;
                }
                else
                  goto label_12;
              }
              else
              {
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                ^(int&) ref entryKey1 = (int) num2;
                \u003CModule\u003E.nn\u002Efssystem\u002EHierarchicalRomFileTableTemplate\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u002Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002EGetDirectoryEntry(obj0, &result5, &num1, &directoryEntry, &entryKey1);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if (^(int&) ref result5 == 0)
                  num2 = num1;
                else
                  goto label_14;
              }
            }
            else
              goto label_15;
          }
          while (!\u003CModule\u003E.nn\u002Efssystem\u002ERomPathTool\u002EPathParser\u002EIsParseFinished(parser));
          goto label_16;
label_12:
          *(int*) obj1 = 4051970;
          return obj1;
label_13:
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, ref result4, 4);
          return obj1;
label_14:
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, ref result5, 4);
          return obj1;
label_15:
          // ISSUE: cpblk instruction
          __memcpy((IntPtr) obj1, ref result3, 4);
          return obj1;
        }
label_16:
        *pParentPosition = num2;
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) pParentDirKey, ref entryKey1, 12);
        // ISSUE: cpblk instruction
        __memcpy((IntPtr) pParentDirEntry, ref directoryEntry, 12);
        *(int*) obj1 = 0;
        return obj1;
      }
      // ISSUE: cpblk instruction
      __memcpy((IntPtr) obj1, ref result2, 4);
      return obj1;
    }
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj1, ref result1, 4);
    return obj1;
  }

  internal static unsafe uint \u003FA0xc0e70115\u002Estrnlen_s(sbyte* _String, uint _MaxCount)
  {
    if ((IntPtr) _String == IntPtr.Zero)
      return 0;
    return \u003CModule\u003E.strnlen(_String, _MaxCount);
  }

  internal static unsafe Sha256PartitionFileSystemArchiveReaderImpl* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ESha256PartitionFileSystemArchiveReaderImpl\u002E\u007Bctor\u007D([In] Sha256PartitionFileSystemArchiveReaderImpl* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* storage)
  {
    shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr1;
    // ISSUE: fault handler
    try
    {
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage1;
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr2 = &sharedPtrNnFsIstorage1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ref sharedPtrNnFsIstorage1 = *(int*) storage;
      sharedPtrNnFsIstoragePtr1 = (shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) ((IntPtr) storage + 4);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) = *(int*) sharedPtrNnFsIstoragePtr1;
      *(int*) storage = 0;
      *(int*) sharedPtrNnFsIstoragePtr1 = 0;
      shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr3 = &sharedPtrNnFsIstorage1;
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(int*) obj0 = ^(int&) ref sharedPtrNnFsIstorage1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        *(int*) ((IntPtr) obj0 + 4) = ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref sharedPtrNnFsIstorage1 = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) = 0;
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) sharedPtrNnFsIstoragePtr3);
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4) != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &sharedPtrNnFsIstorage1 + 4));
      }
      // ISSUE: fault handler
      try
      {
        Sha256PartitionFileSystemArchiveReaderImpl* archiveReaderImplPtr = (Sha256PartitionFileSystemArchiveReaderImpl*) ((IntPtr) obj0 + 12);
        \u003CModule\u003E.std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E((shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E*) archiveReaderImplPtr);
        // ISSUE: fault handler
        try
        {
          shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E sharedPtrNnFsIstorage2;
          shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* sharedPtrNnFsIstoragePtr4 = &sharedPtrNnFsIstorage2;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ref sharedPtrNnFsIstorage2 = 0;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          ^(int&) ((IntPtr) &sharedPtrNnFsIstorage2 + 4) = 0;
          \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afs\u003A\u003AIStorage\u003E((_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) &sharedPtrNnFsIstorage2, (_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E*) obj0);
          PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* partitionFileSystemMetaPtr1;
          // ISSUE: fault handler
          try
          {
            partitionFileSystemMetaPtr1 = (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E*) *(int*) archiveReaderImplPtr;
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) sharedPtrNnFsIstoragePtr4);
          }
          Result result;
          \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u002EInitialize(partitionFileSystemMetaPtr1, &result, &sharedPtrNnFsIstorage2);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result != 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            throw new ArgumentException(string.Format("Failed to Initialize Sha256PartitionFileSystem 0x{0:X8}.", (object) (uint) ^(int&) ref result));
          }
          PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* partitionFileSystemMetaPtr2 = (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E*) *(int*) archiveReaderImplPtr;
          *(int*) ((IntPtr) obj0 + 8) = (int) partitionFileSystemMetaPtr2;
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) ((IntPtr) obj0 + 12));
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002E\u007Bdtor\u007D), (void*) storage);
    }
    int num = *(int*) sharedPtrNnFsIstoragePtr1;
    if (num != 0)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    return obj0;
  }

  internal static unsafe List<Tuple<long, long>> Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ESha256PartitionFileSystemArchiveReaderImpl\u002EGetFileFragmentList([In] Sha256PartitionFileSystemArchiveReaderImpl* obj0, string fileName)
  {
    sbyte* pointer = (sbyte*) \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetUtf8CharsFromString(fileName).ToPointer();
    \u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E obj1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref obj1 = (int) &pointer;
    ScopeExitHolder\u003C\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E obj2;
    \u003CModule\u003E.nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E(&obj2, (ScopeExitHolderMarker) 0, &obj1);
    List<Tuple<long, long>> tupleList;
    // ISSUE: fault handler
    try
    {
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
      basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Left = \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_01KMDKNFGN\u0040\u003F1\u003F\u0024AA\u0040);
      Result result;
      long num;
      // ISSUE: fault handler
      try
      {
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
        basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.std\u002Eoperator\u002B\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E(&stdAllocatorChar2, _Left, pointer);
        // ISSUE: fault handler
        try
        {
          sbyte* numPtr = 16U > (uint) *(int*) ((IntPtr) stdAllocatorCharPtr + 20) ? (sbyte*) stdAllocatorCharPtr : (sbyte*) *(int*) stdAllocatorCharPtr;
          \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u002EGetFileBaseOffset((PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E*) *(int*) ((IntPtr) obj0 + 12), &result, &num, numPtr);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
        // ISSUE: fault handler
        try
        {
          \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar2, true, 0U);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      // ISSUE: fault handler
      try
      {
        \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar1, true, 0U);
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ref result != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        throw new ArgumentException(string.Format("Failed to OpenFileStorage 0x{0:X8}.", (object) (uint) ^(int&) ref result));
      }
      tupleList = new List<Tuple<long, long>>();
      tupleList.Add(new Tuple<long, long>(num, \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetFileSize((FileSystemArchiveReaderImplBase*) obj0, fileName)));
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &obj2);
    }
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(byte&) ((IntPtr) &obj2 + 4) != (byte) 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) ^(int&) ref obj2));
    }
    return tupleList;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ESha256PartitionFileSystemArchiveReaderImpl\u002EGetFileFragmentList\u002E\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u002E\u0028\u0029([In] \u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E* obj0)
  {
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe \u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ESha256PartitionFileSystemArchiveReaderImpl\u002EGetFileFragmentList\u002E\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u002E\u007Bctor\u007D([In] \u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E* obj0, sbyte** _param1)
  {
    *(int*) obj0 = (int) _param1;
    return obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ESha256PartitionFileSystemArchiveReaderImpl\u002EOpenFileStorage([In] Sha256PartitionFileSystemArchiveReaderImpl* obj0, shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* outValue, string fileName)
  {
    sbyte* pointer = (sbyte*) \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002EGetUtf8CharsFromString(fileName).ToPointer();
    \u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E f1e97b280eb22cf23d24f2d1f9f330a7_1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ref f1e97b280eb22cf23d24f2d1f9f330a7_1 = (int) &pointer;
    ScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E f1e97b280eb22cf23d24f2d1f9f330a7_2;
    \u003CModule\u003E.nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E(&f1e97b280eb22cf23d24f2d1f9f330a7_2, (ScopeExitHolderMarker) 0, &f1e97b280eb22cf23d24f2d1f9f330a7_1);
    shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E storageBasedFileSystem;
    shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E partitionFileSystemMeta;
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E(&storageBasedFileSystem);
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ref partitionFileSystemMeta = 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ^(int&) ((IntPtr) &partitionFileSystemMeta + 4) = 0;
        \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E((_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E*) &partitionFileSystemMeta, (_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E*) ((IntPtr) obj0 + 12));
        // ISSUE: fault handler
        try
        {
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar1;
          basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* _Left = \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bctor\u007D(&stdAllocatorChar1, (sbyte*) &\u003CModule\u003E.\u003F\u003F_C\u0040_01KMDKNFGN\u0040\u003F1\u003F\u0024AA\u0040);
          Result result;
          // ISSUE: fault handler
          try
          {
            basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E stdAllocatorChar2;
            basic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E* stdAllocatorCharPtr = \u003CModule\u003E.std\u002Eoperator\u002B\u003Cchar\u002Cstruct\u0020std\u003A\u003Achar_traits\u003Cchar\u003E\u002Cclass\u0020std\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E(&stdAllocatorChar2, _Left, pointer);
            // ISSUE: fault handler
            try
            {
              shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E fsFsaIfileSystem;
              shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* fsFsaIfileSystemPtr = &fsFsaIfileSystem;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ref fsFsaIfileSystem = ^(int&) ref partitionFileSystemMeta;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ((IntPtr) &fsFsaIfileSystem + 4) = ^(int&) ((IntPtr) &partitionFileSystemMeta + 4);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ref partitionFileSystemMeta = 0;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              ^(int&) ((IntPtr) &partitionFileSystemMeta + 4) = 0;
              sbyte* numPtr;
              // ISSUE: fault handler
              try
              {
                numPtr = 16U > (uint) *(int*) ((IntPtr) stdAllocatorCharPtr + 20) ? (sbyte*) stdAllocatorCharPtr : (sbyte*) *(int*) stdAllocatorCharPtr;
              }
              __fault
              {
                // ISSUE: method pointer
                // ISSUE: cast to a function pointer type
                \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E\u007Bdtor\u007D), (void*) fsFsaIfileSystemPtr);
              }
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              \u003CModule\u003E.nn\u002Efssystem\u002EFileStorageBasedFileSystem\u002EInitialize((FileStorageBasedFileSystem*) ^(int&) ref storageBasedFileSystem, &result, &fsFsaIfileSystem, numPtr, (OpenMode) 1);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
            }
            // ISSUE: fault handler
            try
            {
              \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar2, true, 0U);
            }
            __fault
            {
              // ISSUE: method pointer
              // ISSUE: cast to a function pointer type
              \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar2);
            }
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
          }
          // ISSUE: fault handler
          try
          {
            \u003CModule\u003E.std\u002Ebasic_string\u003Cchar\u002Cstd\u003A\u003Achar_traits\u003Cchar\u003E\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u002E_Tidy(&stdAllocatorChar1, true, 0U);
          }
          __fault
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_String_alloc\u003Cstd\u003A\u003A_String_base_types\u003Cchar\u002Cstd\u003A\u003Aallocator\u003Cchar\u003E\u0020\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &stdAllocatorChar1);
          }
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if (^(int&) ref result != 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            throw new ArgumentException(string.Format("Failed to OpenFileStorage 0x{0:X8}.", (object) (uint) ^(int&) ref result));
          }
          \u003CModule\u003E.std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E\u002Eoperator\u003D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E(outValue, &storageBasedFileSystem);
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &partitionFileSystemMeta);
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (^(int&) ((IntPtr) &partitionFileSystemMeta + 4) != 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &partitionFileSystemMeta + 4));
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bdtor\u007D), (void*) &storageBasedFileSystem);
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (^(int&) ((IntPtr) &storageBasedFileSystem + 4) != 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) ^(int&) ((IntPtr) &storageBasedFileSystem + 4));
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &f1e97b280eb22cf23d24f2d1f9f330a7_2);
    }
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    if (^(byte&) ((IntPtr) &f1e97b280eb22cf23d24f2d1f9f330a7_2 + 4) != (byte) 0)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) ^(int&) ref f1e97b280eb22cf23d24f2d1f9f330a7_2));
    }
    // ISSUE: fault handler
    try
    {
      // ISSUE: fault handler
      try
      {
        // ISSUE: fault handler
        try
        {
        }
        __fault
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &partitionFileSystemMeta);
        }
      }
      __fault
      {
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003AFileStorageBasedFileSystem\u003E\u002E\u007Bdtor\u007D), (void*) &storageBasedFileSystem);
      }
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) &f1e97b280eb22cf23d24f2d1f9f330a7_2);
    }
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ESha256PartitionFileSystemArchiveReaderImpl\u002EOpenFileStorage\u002E\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u002E\u0028\u0029([In] \u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E* obj0)
  {
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe \u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ESha256PartitionFileSystemArchiveReaderImpl\u002EOpenFileStorage\u002E\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u002E\u007Bctor\u007D([In] \u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E* obj0, sbyte** _param1)
  {
    *(int*) obj0 = (int) _param1;
    return obj0;
  }

  internal static unsafe void* Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ESha256PartitionFileSystemArchiveReaderImpl\u002E__delDtor([In] Sha256PartitionFileSystemArchiveReaderImpl* obj0, uint A_0)
  {
    \u003CModule\u003E.Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ESha256PartitionFileSystemArchiveReaderImpl\u002E\u007Bdtor\u007D(obj0);
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 20U);
    return (void*) obj0;
  }

  internal static unsafe void Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002ESha256PartitionFileSystemArchiveReaderImpl\u002E\u007Bdtor\u007D([In] Sha256PartitionFileSystemArchiveReaderImpl* obj0)
  {
    // ISSUE: fault handler
    try
    {
      uint num = (uint) *(int*) ((IntPtr) obj0 + 12 + 4);
      if (num != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(Nintendo\u002EAuthoring\u002EFileSystemMetaLibrary\u002EFileSystemArchiveReaderImplBase\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    uint num1 = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num1 == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num1);
  }

  internal static unsafe void nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] ScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E* obj0)
  {
    if (*(byte*) ((IntPtr) obj0 + 4) == (byte) 0)
      return;
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe void nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] ScopeExitHolder\u003C\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E* obj0)
  {
    if (*(byte*) ((IntPtr) obj0 + 4) == (byte) 0)
      return;
    Marshal.FreeHGlobal((IntPtr) ((void*) *(int*) *(int*) obj0));
  }

  internal static unsafe PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u002D\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E*) *(int*) obj0;
  }

  internal static unsafe PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002Eget([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E*) *(int*) obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  [SpecialName]
  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* _Other)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    \u003CModule\u003E.std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E((_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E*) obj0, (_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E*) _Other);
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Decref([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num == 0U)
      return;
    \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
  }

  internal static unsafe PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Get([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E*) *(int*) obj0;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* std\u002Emake_shared\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    uint num1;
    // ISSUE: fault handler
    try
    {
      num1 = 0U;
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* partitionFileSystemMetaPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E*) \u003CModule\u003E.@new(40U);
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* partitionFileSystemMetaPtr2;
      // ISSUE: fault handler
      try
      {
        partitionFileSystemMetaPtr2 = (IntPtr) partitionFileSystemMetaPtr1 == IntPtr.Zero ? (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E*) 0 : \u003CModule\u003E.std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003C\u003E(partitionFileSystemMetaPtr1);
      }
      __fault
      {
        \u003CModule\u003E.delete((void*) partitionFileSystemMetaPtr1, 40U);
      }
      *(int*) obj0 = 0;
      shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* partitionFileSystemMetaPtr3 = (shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E*) ((IntPtr) obj0 + 4);
      *(int*) partitionFileSystemMetaPtr3 = 0;
      num1 = 1U;
      uint num2 = (uint) *(int*) partitionFileSystemMetaPtr3;
      if (num2 != 0U)
        \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num2);
      *(int*) partitionFileSystemMetaPtr3 = (int) partitionFileSystemMetaPtr2;
      *(int*) obj0 = (int) ((IntPtr) partitionFileSystemMetaPtr2 + 12);
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E([In] ScopeExitHolder\u003C\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E* obj0, ScopeExitHolderMarker __unnamed000, \u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E* f)
  {
    uint num1 = 0;
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    // ISSUE: fault handler
    try
    {
      num1 = 1U;
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002Eoperator\u002B\u003Cclass\u0020\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E([In] ScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E* obj0, ScopeExitHolderMarker __unnamed000, \u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E* f)
  {
    uint num1 = 0;
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    // ISSUE: fault handler
    try
    {
      num1 = 1U;
      return obj0;
    }
    __fault
    {
      if (((int) num1 & 1) != 0)
      {
        uint num2 = num1 & 4294967294U;
        // ISSUE: method pointer
        // ISSUE: cast to a function pointer type
        \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E\u002E\u007Bdtor\u007D), (void*) obj0);
      }
    }
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* std\u002Emove\u003Cclass\u0020std\u003A\u003Ashared_ptr\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u0020\u0026\u003E(shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u002Cvoid\u003E([In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Reset\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* _Other)
  {
    _Ref_count_base* refCountBasePtr = (_Ref_count_base*) *(int*) ((IntPtr) _Other + 4);
    PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* partitionFileSystemMetaPtr = (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E*) *(int*) _Other;
    if ((IntPtr) refCountBasePtr != IntPtr.Zero)
    {
      // ISSUE: cast to a reference type
      Interlocked.Increment((int&) ((IntPtr) refCountBasePtr + 4));
    }
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) refCountBasePtr;
    *(int*) obj0 = (int) partitionFileSystemMetaPtr;
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Delete_this([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    if ((IntPtr) obj0 == IntPtr.Zero)
      return;
    _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* partitionFileSystemMetaPtr = obj0;
    int num = 1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) (*(int*) obj0 + 8))((uint) partitionFileSystemMetaPtr, (IntPtr) num);
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Destroy([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* partitionFileSystemMetaPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E*) ((IntPtr) obj0 + 12);
    _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* partitionFileSystemMetaPtr2 = partitionFileSystemMetaPtr1;
    int num = 0;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    void* voidPtr = __calli((__FnPtr<void* (IntPtr, uint)>) *(int*) *(int*) partitionFileSystemMetaPtr1)((uint) partitionFileSystemMetaPtr2, (IntPtr) num);
  }

  internal static unsafe PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Getptr([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    return (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E*) ((IntPtr) obj0 + 12);
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] ScopeExitHolder\u003C\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E* obj0, \u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E* f)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    return obj0;
  }

  internal static unsafe ScopeExitHolder\u003C\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E* nn\u002Eutil\u002Edetail\u002EScopeExitHolder\u003C\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] ScopeExitHolder\u003C\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E* obj0, \u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E* f)
  {
    // ISSUE: cpblk instruction
    __memcpy((IntPtr) obj0, (IntPtr) f, 4);
    *(sbyte*) ((IntPtr) obj0 + 4) = (sbyte) 1;
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Reset([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0, PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    if ((IntPtr) _Other_rep != IntPtr.Zero)
    {
      // ISSUE: cast to a reference type
      Interlocked.Increment((int&) ((IntPtr) _Other_rep + 4));
    }
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0, shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = 0;
    *(int*) ((IntPtr) obj0 + 4) = 0;
    return obj0;
  }

  internal static unsafe void std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Reset0([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0, PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* _Other_ptr, _Ref_count_base* _Other_rep)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Other_rep;
    *(int*) obj0 = (int) _Other_ptr;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bctor\u007D\u003C\u003E([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    *(int*) ((IntPtr) obj0 + 4) = 1;
    *(int*) ((IntPtr) obj0 + 8) = 1;
    // ISSUE: fault handler
    try
    {
      *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7\u003F\u0024_Ref_count_obj\u0040V\u003F\u0024PartitionFileSystemCore\u0040VSha256PartitionFileSystemMeta\u0040fssystem\u0040nn\u0040\u0040\u0040fssystem\u0040nn\u0040\u0040\u0040std\u0040\u00406B\u0040;
      PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* partitionFileSystemMetaPtr = (PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E*) ((IntPtr) obj0 + 12);
      if ((IntPtr) partitionFileSystemMetaPtr != IntPtr.Zero)
        \u003CModule\u003E.nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u002E\u007Bctor\u007D(partitionFileSystemMetaPtr);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_base\u002E\u007Bdtor\u007D), (void*) obj0);
    }
    return obj0;
  }

  internal static unsafe void std\u002Eshared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E_Resetp0\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E([In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0, PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* _Px, _Ref_count_base* _Rx)
  {
    uint num = (uint) *(int*) ((IntPtr) obj0 + 4);
    if (num != 0U)
      \u003CModule\u003E.std\u002E_Ref_count_base\u002E_Decref((_Ref_count_base*) num);
    *(int*) ((IntPtr) obj0 + 4) = (int) _Rx;
    *(int*) obj0 = (int) _Px;
  }

  internal static unsafe \u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E* std\u002Eforward\u003Cclass\u0020\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u003E(\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe \u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E* std\u002Eforward\u003Cclass\u0020\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u003E(\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* std\u002E_Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E\u002E\u007Bctor\u007D\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cclass\u0020nn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E([In] _Ptr_base\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj0, _Ptr_base\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* _Right)
  {
    *(int*) obj0 = *(int*) _Right;
    *(int*) ((IntPtr) obj0 + 4) = *(int*) ((IntPtr) _Right + 4);
    *(int*) _Right = 0;
    *(int*) ((IntPtr) _Right + 4) = 0;
    return obj0;
  }

  internal static unsafe \u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E* std\u002Emove\u003Cclass\u0020\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E\u0020\u0026\u003E(\u003Clambda_f1e97b280eb22cf23d24f2d1f9f330a7\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe \u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E* std\u002Emove\u003Cclass\u0020\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E\u0020\u0026\u003E(\u003Clambda_857b3f906e621650b87bd244f45db5c2\u003E* _Arg)
  {
    return _Arg;
  }

  internal static unsafe void* std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E__vecDelDtor([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0, uint A_0)
  {
    if (((int) A_0 & 2) != 0)
    {
      _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* partitionFileSystemMetaPtr1 = (_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 40U, (uint) *(int*) partitionFileSystemMetaPtr1, (__FnPtr<void (void*)>) __methodptr(std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bdtor\u007D));
      if (((int) A_0 & 1) != 0)
      {
        _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* partitionFileSystemMetaPtr2 = partitionFileSystemMetaPtr1;
        int num = *(int*) partitionFileSystemMetaPtr2 * 40 + 4;
        \u003CModule\u003E.delete\u005B\u005D((void*) partitionFileSystemMetaPtr2, (uint) num);
      }
      return (void*) partitionFileSystemMetaPtr1;
    }
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
    if (((int) A_0 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0, 40U);
    return (void*) obj0;
  }

  internal static unsafe void std\u002E_Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E\u002E\u007Bdtor\u007D([In] _Ref_count_obj\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u0020\u003E* obj0)
  {
    *(int*) obj0 = (int) &\u003CModule\u003E.\u003F\u003F_7_Ref_count_base\u0040std\u0040\u00406B\u0040;
  }

  internal static unsafe void nn\u002Eutil\u002EBitPack\u003Cunsigned\u0020char\u002Cvoid\u003E\u002ESet\u003Cstruct\u0020nn\u003A\u003Autil\u003A\u003ABitPack\u003Cunsigned\u0020char\u002Cvoid\u003E\u003A\u003AField\u003C0\u002C4\u002Cunsigned\u0020char\u003E\u0020\u003E([In] BitPack\u003Cunsigned\u0020char\u002Cvoid\u003E* obj0, byte value)
  {
    BitPack\u003Cunsigned\u0020char\u002Cvoid\u003E* unsignedCharVoidPtr = obj0;
    int num = (int) *(byte*) unsignedCharVoidPtr & 240 | (int) value;
    *(sbyte*) unsignedCharVoidPtr = (sbyte) num;
  }

  internal static unsafe byte nn\u002Eutil\u002EBitPack\u003Cunsigned\u0020char\u002Cvoid\u003E\u002EGet\u003Cstruct\u0020nn\u003A\u003Autil\u003A\u003ABitPack\u003Cunsigned\u0020char\u002Cvoid\u003E\u003A\u003AField\u003C0\u002C4\u002Cunsigned\u0020char\u003E\u0020\u003E([In] BitPack\u003Cunsigned\u0020char\u002Cvoid\u003E* obj0)
  {
    return (byte) ((uint) *(byte*) obj0 & 15U);
  }

  internal static unsafe byte nn\u002Eutil\u002EBitPack\u003Cunsigned\u0020char\u002Cvoid\u003E\u002EGet\u003Cstruct\u0020nn\u003A\u003Autil\u003A\u003ABitPack\u003Cunsigned\u0020char\u002Cvoid\u003E\u003A\u003AField\u003C4\u002C4\u002Cunsigned\u0020char\u003E\u0020\u003E([In] BitPack\u003Cunsigned\u0020char\u002Cvoid\u003E* obj0)
  {
    return (byte) ((uint) *(byte*) obj0 >> 4);
  }

  internal static unsafe void nn\u002Eutil\u002EBitPack\u003Cunsigned\u0020char\u002Cvoid\u003E\u002ESetMaskedBits([In] BitPack\u003Cunsigned\u0020char\u002Cvoid\u003E* obj0, int mask, int value)
  {
    BitPack\u003Cunsigned\u0020char\u002Cvoid\u003E* unsignedCharVoidPtr = obj0;
    int num = (int) *(byte*) unsignedCharVoidPtr & ~mask | value;
    *(sbyte*) unsignedCharVoidPtr = (sbyte) num;
  }

  internal static unsafe void nn\u002Eutil\u002EBitPack\u003Cunsigned\u0020char\u002Cvoid\u003E\u002EReadValue\u003Cunsigned\u0020char\u003E([In] BitPack\u003Cunsigned\u0020char\u002Cvoid\u003E* obj0, byte* pValue, int mask, int pos)
  {
    *pValue = (byte) (((uint) *(byte*) obj0 & (uint) mask) >> pos);
  }

  internal static unsafe int nn\u002Eutil\u002EBitPack\u003Cunsigned\u0020char\u002Cvoid\u003E\u002EGetMaskedBits([In] BitPack\u003Cunsigned\u0020char\u002Cvoid\u003E* obj0, int mask)
  {
    return (int) *(byte*) obj0 & mask;
  }

  internal static unsafe XciPartitionReader* Nintendo\u002EAuthoring\u002EUtil\u002EReturnAndDeclareAlive\u003Cclass\u0020Nintendo\u003A\u003AAuthoring\u003A\u003AFileSystemMetaLibrary\u003A\u003AXciPartitionReader\u0020\u005E\u003E(object obj, XciPartitionReader* retValue)
  {
    GC.KeepAlive(obj);
    return retValue;
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(Exception innerException, Exception nestedException)
  {
    throw new ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(string errorMessage)
  {
    throw new ModuleLoadException(errorMessage);
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(string errorMessage, Exception innerException)
  {
    throw new ModuleLoadException(errorMessage, innerException);
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002ERegisterModuleUninitializer(EventHandler handler)
  {
    ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
  }

  [SecuritySafeCritical]
  internal static unsafe Guid \u003CCrtImplementationDetails\u003E\u002EFromGUID(_GUID* guid)
  {
    return new Guid((uint) *(int*) guid, *(ushort*) ((IntPtr) guid + 4), *(ushort*) ((IntPtr) guid + 6), *(byte*) ((IntPtr) guid + 8), *(byte*) ((IntPtr) guid + 9), *(byte*) ((IntPtr) guid + 10), *(byte*) ((IntPtr) guid + 11), *(byte*) ((IntPtr) guid + 12), *(byte*) ((IntPtr) guid + 13), *(byte*) ((IntPtr) guid + 14), *(byte*) ((IntPtr) guid + 15));
  }

  [SecurityCritical]
  internal static unsafe int __get_default_appdomain(IUnknown** ppUnk)
  {
    ICorRuntimeHost* icorRuntimeHostPtr1 = (ICorRuntimeHost*) 0;
    int num1;
    try
    {
      Guid riid = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EFromGUID((_GUID*) &\u003CModule\u003E._GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e);
      icorRuntimeHostPtr1 = (ICorRuntimeHost*) RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EFromGUID((_GUID*) &\u003CModule\u003E._GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e), riid).ToPointer();
      goto label_4;
    }
    catch (Exception ex)
    {
      num1 = Marshal.GetHRForException(ex);
    }
    if (num1 < 0)
      goto label_5;
label_4:
    ICorRuntimeHost* icorRuntimeHostPtr2 = icorRuntimeHostPtr1;
    IUnknown** iunknownPtr = ppUnk;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    num1 = __calli((__FnPtr<int (IntPtr, IUnknown**)>) *(int*) (*(int*) icorRuntimeHostPtr1 + 52))((IUnknown**) icorRuntimeHostPtr2, (IntPtr) iunknownPtr);
    ICorRuntimeHost* icorRuntimeHostPtr3 = icorRuntimeHostPtr1;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num2 = (int) __calli((__FnPtr<uint (IntPtr)>) *(int*) (*(int*) icorRuntimeHostPtr3 + 8))((IntPtr) icorRuntimeHostPtr3);
label_5:
    return num1;
  }

  internal static unsafe void __release_appdomain(IUnknown* ppUnk)
  {
    IUnknown* iunknownPtr = ppUnk;
    // ISSUE: cast to a function pointer type
    // ISSUE: function pointer call
    int num = (int) __calli((__FnPtr<uint (IntPtr)>) *(int*) (*(int*) iunknownPtr + 8))((IntPtr) iunknownPtr);
  }

  [SecurityCritical]
  internal static unsafe AppDomain \u003CCrtImplementationDetails\u003E\u002EGetDefaultDomain()
  {
    IUnknown* ppUnk = (IUnknown*) 0;
    int defaultAppdomain = \u003CModule\u003E.__get_default_appdomain(&ppUnk);
    if (defaultAppdomain >= 0)
    {
      try
      {
        return (AppDomain) Marshal.GetObjectForIUnknown(new IntPtr((void*) ppUnk));
      }
      finally
      {
        \u003CModule\u003E.__release_appdomain(ppUnk);
      }
    }
    else
    {
      Marshal.ThrowExceptionForHR(defaultAppdomain);
      return (AppDomain) null;
    }
  }

  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EDoCallBackInDefaultDomain(__FnPtr<int (void*)> function, void* cookie)
  {
    Guid riid = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EFromGUID((_GUID*) &\u003CModule\u003E._GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02);
    ICLRRuntimeHost* pointer = (ICLRRuntimeHost*) RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EFromGUID((_GUID*) &\u003CModule\u003E._GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02), riid).ToPointer();
    try
    {
      AppDomain defaultDomain = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EGetDefaultDomain();
      ICLRRuntimeHost* iclrRuntimeHostPtr = pointer;
      int id = defaultDomain.Id;
      __FnPtr<int (void*)> local = function;
      void* voidPtr = cookie;
      // ISSUE: cast to a function pointer type
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int errorCode = __calli((__FnPtr<int (IntPtr, uint, __FnPtr<int (void*)>, void*)>) *(int*) (*(int*) pointer + 32))((void*) iclrRuntimeHostPtr, (__FnPtr<int (void*)>) id, (uint) local, (IntPtr) voidPtr);
      if (errorCode >= 0)
        return;
      Marshal.ThrowExceptionForHR(errorCode);
    }
    finally
    {
      ICLRRuntimeHost* iclrRuntimeHostPtr = pointer;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      int num = (int) __calli((__FnPtr<uint (IntPtr)>) *(int*) (*(int*) iclrRuntimeHostPtr + 8))((IntPtr) iclrRuntimeHostPtr);
    }
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool __scrt_is_safe_for_managed_code()
  {
    return \u003CModule\u003E.__scrt_native_dllmain_reason > 1U;
  }

  [SecuritySafeCritical]
  internal static unsafe int \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EDoNothing(void* cookie)
  {
    GC.KeepAlive((object) int.MaxValue);
    return 0;
  }

  [SecuritySafeCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasPerProcess()
  {
    if (\u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A != (TriBool) 2)
      return \u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A == (TriBool) -1;
    void** voidPtr = (void**) &\u003CModule\u003E.__xc_mp_a;
    if (ref \u003CModule\u003E.__xc_mp_a < ref \u003CModule\u003E.__xc_mp_z)
    {
      while (*(int*) voidPtr == 0)
      {
        voidPtr += 4;
        if ((IntPtr) voidPtr >= ref \u003CModule\u003E.__xc_mp_z)
          goto label_5;
      }
      \u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A = (TriBool) -1;
      return true;
    }
label_5:
    \u003CModule\u003E.\u003FhasPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A = (TriBool) 0;
    return false;
  }

  [SecuritySafeCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasNative()
  {
    if (\u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A != (TriBool) 2)
      return \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A == (TriBool) -1;
    void** voidPtr1 = (void**) &\u003CModule\u003E.__xi_a;
    if (ref \u003CModule\u003E.__xi_a < ref \u003CModule\u003E.__xi_z)
    {
      while (*(int*) voidPtr1 == 0)
      {
        voidPtr1 += 4;
        if ((IntPtr) voidPtr1 >= ref \u003CModule\u003E.__xi_z)
          goto label_5;
      }
      \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A = (TriBool) -1;
      return true;
    }
label_5:
    void** voidPtr2 = (void**) &\u003CModule\u003E.__xc_a;
    if (ref \u003CModule\u003E.__xc_a < ref \u003CModule\u003E.__xc_z)
    {
      while (*(int*) voidPtr2 == 0)
      {
        voidPtr2 += 4;
        if ((IntPtr) voidPtr2 >= ref \u003CModule\u003E.__xc_z)
          goto label_9;
      }
      \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A = (TriBool) -1;
      return true;
    }
label_9:
    \u003CModule\u003E.\u003FhasNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00400W4TriBool\u00402\u0040A = (TriBool) 0;
    return false;
  }

  [SecuritySafeCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsInitialization()
  {
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasPerProcess() && !\u003CModule\u003E.\u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA || \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EHasNative() && !\u003CModule\u003E.\u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA && \u003CModule\u003E.__scrt_current_native_startup_state == (__scrt_native_startup_state) 0;
  }

  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsUninitialization()
  {
    return \u003CModule\u003E.\u003FEntered\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA;
  }

  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EInitialize()
  {
    // ISSUE: cast to a function pointer type
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDoCallBackInDefaultDomain((__FnPtr<int (void*)>) (IntPtr) \u003CModule\u003E.__unep\u0040\u003FDoNothing\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z, (void*) 0);
  }

  internal static void \u003FA0x13efd873\u002E\u003F\u003F__E\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 0;
  }

  internal static void \u003FA0x13efd873\u002E\u003F\u003F__E\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 0;
  }

  internal static void \u003FA0x13efd873\u002E\u003F\u003F__E\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA = false;
  }

  internal static void \u003FA0x13efd873\u002E\u003F\u003F__E\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 0;
  }

  internal static void \u003FA0x13efd873\u002E\u003F\u003F__E\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 0;
  }

  internal static void \u003FA0x13efd873\u002E\u003F\u003F__E\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 0;
  }

  internal static void \u003FA0x13efd873\u002E\u003F\u003F__E\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 0;
  }

  [SecuritySafeCritical]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeVtables([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during vtable initialization.\n");
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 1;
    \u003CModule\u003E._initterm_m((__FnPtr<void* ()>*) &\u003CModule\u003E.__xi_vt_a, (__FnPtr<void* ()>*) &\u003CModule\u003E.__xi_vt_z);
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 2;
  }

  [SecuritySafeCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeDefaultAppDomain([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002EInitialize();
  }

  [SecuritySafeCritical]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeNative([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during native initialization.\n");
    \u003CModule\u003E.__security_init_cookie();
    \u003CModule\u003E.\u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
    if (!\u003CModule\u003E.__scrt_is_safe_for_managed_code())
      \u003CModule\u003E.abort();
    if (\u003CModule\u003E.__scrt_current_native_startup_state == (__scrt_native_startup_state) 1)
      \u003CModule\u003E.abort();
    if (\u003CModule\u003E.__scrt_current_native_startup_state != (__scrt_native_startup_state) 0)
      return;
    \u003CModule\u003E.\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 1;
    \u003CModule\u003E.__scrt_current_native_startup_state = (__scrt_native_startup_state) 1;
    if (\u003CModule\u003E._initterm_e((__FnPtr<int ()>*) &\u003CModule\u003E.__xi_a, (__FnPtr<int ()>*) &\u003CModule\u003E.__xi_z) != 0)
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0));
    \u003CModule\u003E._initterm((__FnPtr<void ()>*) &\u003CModule\u003E.__xc_a, (__FnPtr<void ()>*) &\u003CModule\u003E.__xc_z);
    \u003CModule\u003E.__scrt_current_native_startup_state = (__scrt_native_startup_state) 2;
    \u003CModule\u003E.\u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
    \u003CModule\u003E.\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 2;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerProcess([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during process initialization.\n");
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 1;
    \u003CModule\u003E._initatexit_m();
    \u003CModule\u003E._initterm_m((__FnPtr<void* ()>*) &\u003CModule\u003E.__xc_mp_a, (__FnPtr<void* ()>*) &\u003CModule\u003E.__xc_mp_z);
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 2;
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerAppDomain([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during appdomain initialization.\n");
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 1;
    \u003CModule\u003E._initatexit_app_domain();
    \u003CModule\u003E._initterm_m((__FnPtr<void* ()>*) &\u003CModule\u003E.__xc_ma_a, (__FnPtr<void* ()>*) &\u003CModule\u003E.__xc_ma_z);
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4Progress\u00402\u0040A = (Progress) 2;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeUninitializer([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during registration for the unload events.\n");
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ERegisterModuleUninitializer(new EventHandler(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EDomainUnload));
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_Initialize([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA = AppDomain.CurrentDomain.IsDefaultAppDomain();
    if (\u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA)
      \u003CModule\u003E.\u003FEntered\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = true;
    void* fiberPtrId = \u003CModule\u003E._getFiberPtrId();
    int num1 = 0;
    int num2 = 0;
    int num3 = 0;
    RuntimeHelpers.PrepareConstrainedRegions();
    try
    {
      while (num2 == 0)
      {
        try
        {
        }
        finally
        {
          IntPtr comparand = (IntPtr) 0;
          IntPtr num4 = (IntPtr) fiberPtrId;
          // ISSUE: cast to a reference type
          void* voidPtr = (void*) Interlocked.CompareExchange((IntPtr&) ref \u003CModule\u003E.__scrt_native_startup_lock, num4, comparand);
          if ((IntPtr) voidPtr == IntPtr.Zero)
            num2 = 1;
          else if (voidPtr == fiberPtrId)
          {
            num1 = 1;
            num2 = 1;
          }
        }
        if (num2 == 0)
          \u003CModule\u003E.Sleep(1000U);
      }
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeVtables(obj0);
      if (\u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA)
      {
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeNative(obj0);
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerProcess(obj0);
      }
      else if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsInitialization())
        num3 = 1;
    }
    finally
    {
      if (num1 == 0)
      {
        IntPtr num4 = (IntPtr) 0;
        // ISSUE: cast to a reference type
        Interlocked.Exchange((IntPtr&) ref \u003CModule\u003E.__scrt_native_startup_lock, num4);
      }
    }
    if (num3 != 0)
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeDefaultAppDomain(obj0);
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerAppDomain(obj0);
    \u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 1;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeUninitializer(obj0);
  }

  [SecurityCritical]
  internal static void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeAppDomain()
  {
    \u003CModule\u003E._app_exit_callback();
  }

  [SecurityCritical]
  internal static unsafe int \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_UninitializeDefaultDomain(void* cookie)
  {
    \u003CModule\u003E._exit_callback();
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = false;
    if (\u003CModule\u003E.\u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA)
    {
      \u003CModule\u003E._cexit();
      \u003CModule\u003E.__scrt_current_native_startup_state = (__scrt_native_startup_state) 0;
      \u003CModule\u003E.\u003FInitializedNativeFromCCTOR\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = false;
    }
    \u003CModule\u003E.\u003FInitializedNative\u0040DefaultDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402_NA = false;
    return 0;
  }

  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeDefaultDomain()
  {
    if (!\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDefaultDomain\u002ENeedsUninitialization())
      return;
    if (AppDomain.CurrentDomain.IsDefaultAppDomain())
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_UninitializeDefaultDomain((void*) 0);
    }
    else
    {
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EDoCallBackInDefaultDomain((__FnPtr<int (void*)>) (IntPtr) \u003CModule\u003E.__unep\u0040\u003F_UninitializeDefaultDomain\u0040LanguageSupport\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024FCGJPAX\u0040Z, (void*) 0);
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [PrePrepareMethod]
  [SecurityCritical]
  internal static void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EDomainUnload(object A_0, EventArgs A_1)
  {
    if (\u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA == 0 || Interlocked.Exchange(ref \u003CModule\u003E.\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA, 1) != 0)
      return;
    int num = Interlocked.Decrement(ref \u003CModule\u003E.\u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA) == 0 ? 1 : 0;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeAppDomain();
    if ((byte) num == (byte) 0)
      return;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeDefaultDomain();
  }

  [DebuggerStepThrough]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup([In] LanguageSupport* obj0, Exception innerException)
  {
    try
    {
      bool flag = Interlocked.Decrement(ref \u003CModule\u003E.\u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA) == 0;
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeAppDomain();
      if (!flag)
        return;
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeDefaultDomain();
    }
    catch (Exception ex)
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(innerException, ex);
    }
    catch
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(innerException, (Exception) null);
    }
  }

  [SecurityCritical]
  internal static unsafe LanguageSupport* \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bctor\u007D([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bctor\u007D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0);
    return obj0;
  }

  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bdtor\u007D([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bdtor\u007D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0);
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitialize([In] LanguageSupport* obj0)
  {
    bool flag = false;
    RuntimeHelpers.PrepareConstrainedRegions();
    try
    {
      \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load.\n");
      RuntimeHelpers.PrepareConstrainedRegions();
      try
      {
      }
      finally
      {
        Interlocked.Increment(ref \u003CModule\u003E.\u003FCount\u0040AllDomains\u0040\u003CCrtImplementationDetails\u003E\u0040\u00402HA);
        flag = true;
      }
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_Initialize(obj0);
    }
    catch (Exception ex)
    {
      if (flag)
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup(obj0, ex);
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0), ex);
    }
    catch
    {
      if (flag)
        \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup(obj0, (Exception) null);
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0), (Exception) null);
    }
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  static unsafe \u003CModule\u003E()
  {
    LanguageSupport languageSupport;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bctor\u007D(&languageSupport);
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitialize(&languageSupport);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bdtor\u007D), (void*) &languageSupport);
    }
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bdtor\u007D(&languageSupport);
  }

  [SecuritySafeCritical]
  internal static unsafe string gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    return (string) (GCHandle) new IntPtr((void*) *(int*) obj0).Target;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0, string t)
  {
    (GCHandle) new IntPtr((void*) *(int*) obj0).Target = (object) t;
    return obj0;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bdtor\u007D([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    (GCHandle) new IntPtr((void*) *(int*) obj0).Free();
    *(int*) obj0 = 0;
  }

  [SecuritySafeCritical]
  [DebuggerStepThrough]
  internal static unsafe gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bctor\u007D([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    IntPtr num = (IntPtr) GCHandle.Alloc((object) null);
    *(int*) obj0 = (int) num.ToPointer();
    return obj0;
  }

  [HandleProcessCorruptedStateExceptions]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  internal static unsafe void __ehvec_dtor(void* ptr, uint size, uint count, __FnPtr<void (void*)> destructor)
  {
    bool flag = false;
    ptr = (void*) ((int) size * (int) count + (IntPtr) ptr);
    try
    {
      while (true)
      {
        int num1 = (int) count;
        --count;
        int num2 = 0;
        if ((uint) num1 > (uint) num2)
        {
          ptr -= (int) size;
          void* voidPtr = ptr;
          // ISSUE: function pointer call
          __calli(destructor)(voidPtr);
        }
        else
          break;
      }
      flag = true;
    }
    finally
    {
      if (!flag)
        \u003CModule\u003E.__ArrayUnwind(ptr, size, count, destructor);
    }
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe int \u003FA0xf45b0832\u002EArrayUnwindFilter(_EXCEPTION_POINTERS* pExPtrs)
  {
    if (*(int*) *(int*) pExPtrs != -529697949)
      return 0;
    \u003CModule\u003E.terminate();
    return 0;
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [HandleProcessCorruptedStateExceptions]
  internal static unsafe void __ArrayUnwind(void* ptr, uint size, uint count, __FnPtr<void (void*)> destructor)
  {
    try
    {
      for (uint index = 0; (int) index != (int) count; ++index)
      {
        ptr -= (int) size;
        void* voidPtr = ptr;
        // ISSUE: function pointer call
        __calli(destructor)(voidPtr);
      }
    }
    catch (Exception ex) when (\u003CModule\u003E.\u003FA0xf45b0832\u002EArrayUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  internal static unsafe void __ehvec_dtor(void* ptr, uint size, int count, __FnPtr<void (void*)> destructor)
  {
    \u003CModule\u003E.__ehvec_dtor(ptr, size, (uint) count, destructor);
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [HandleProcessCorruptedStateExceptions]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ___CxxCallUnwindDtor(__FnPtr<void (void*)> pDtor, void* pThis)
  {
    try
    {
      void* voidPtr = pThis;
      // ISSUE: function pointer call
      __calli(pDtor)(voidPtr);
    }
    catch (Exception ex) when (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [HandleProcessCorruptedStateExceptions]
  [SecurityCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ___CxxCallUnwindDelDtor(__FnPtr<void (void*)> pDtor, void* pThis)
  {
    try
    {
      void* voidPtr = pThis;
      // ISSUE: function pointer call
      __calli(pDtor)(voidPtr);
    }
    catch (Exception ex) when (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ___CxxCallUnwindVecDtor(__FnPtr<void (void*, uint, int, __FnPtr<void (void*)>)> pVecDtor, void* ptr, uint size, int count, __FnPtr<void (void*)> pDtor)
  {
    try
    {
      void* voidPtr = ptr;
      int num1 = (int) size;
      int num2 = count;
      __FnPtr<void (void*)> local = pDtor;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      __calli(pVecDtor)((__FnPtr<void (void*)>) (IntPtr) voidPtr, num1, (uint) num2, (void*) local);
    }
    catch (Exception ex) when (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe ValueType \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle()
  {
    if ((IntPtr) \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA != IntPtr.Zero)
      return (ValueType) GCHandle.FromIntPtr(new IntPtr(\u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA));
    return (ValueType) null;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Construct(object value)
  {
    \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA = (void*) 0;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Set(value);
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Set(object value)
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle();
    if (valueType == null)
      \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA = GCHandle.ToIntPtr(GCHandle.Alloc(value)).ToPointer();
    else
      ((GCHandle) valueType).Target = value;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static object \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get()
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle();
    if (valueType != null)
      return ((GCHandle) valueType).Target;
    return (object) null;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Destruct()
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle();
    if (valueType == null)
      return;
    ((GCHandle) valueType).Free();
    \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA = (void*) 0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized()
  {
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get() != null;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EAddRef()
  {
    if (!\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Construct(new object());
      \u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA = 0;
    }
    ++\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002ERemoveRef()
  {
    --\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA;
    if (\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA != 0)
      return;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Destruct();
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EEnter()
  {
    Monitor.Enter(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get());
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EExit()
  {
    Monitor.Exit(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get());
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003FA0x27925454\u002E__global_lock()
  {
    bool flag = false;
    if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EEnter();
      flag = true;
    }
    return flag;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003FA0x27925454\u002E__global_unlock()
  {
    bool flag = false;
    if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EExit();
      flag = true;
    }
    return flag;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003FA0x27925454\u002E__alloc_global_lock()
  {
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EAddRef();
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized();
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void \u003FA0x27925454\u002E__dealloc_global_lock()
  {
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002ERemoveRef();
  }

  [SecurityCritical]
  internal static unsafe int _atexit_helper(__FnPtr<void ()> func, uint* __pexit_list_size, __FnPtr<void ()>** __ponexitend_e, __FnPtr<void ()>** __ponexitbegin_e)
  {
    // ISSUE: cast to a function pointer type
    __FnPtr<void ()> local1 = (__FnPtr<void ()>) 0;
    if (func == null)
      return -1;
    int num1;
    if (\u003CModule\u003E.\u003FA0x27925454\u002E__global_lock())
    {
      try
      {
        __FnPtr<void ()>* local2 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) *(int*) __ponexitbegin_e);
        __FnPtr<void ()>* local3 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) *(int*) __ponexitend_e);
        int num2 = (int) ((IntPtr) local3 - (IntPtr) local2);
        if (*__pexit_list_size - 1U < (uint) num2 >> 2)
        {
          try
          {
            uint num3 = *__pexit_list_size * 4U;
            uint num4 = num3 >= 2048U ? 2048U : num3;
            IntPtr cb = new IntPtr((int) num3 + (int) num4);
            IntPtr num5 = Marshal.ReAllocHGlobal(new IntPtr((void*) local2), cb);
            local3 = (__FnPtr<void ()>*) ((IntPtr) num5.ToPointer() + num2);
            local2 = (__FnPtr<void ()>*) num5.ToPointer();
            uint num6 = *__pexit_list_size;
            uint num7 = 512U >= num6 ? num6 : 512U;
            *__pexit_list_size = num6 + num7;
          }
          catch (OutOfMemoryException ex)
          {
            IntPtr cb = new IntPtr((int) *__pexit_list_size * 4 + 8);
            IntPtr num3 = Marshal.ReAllocHGlobal(new IntPtr((void*) local2), cb);
            local3 = (__FnPtr<void ()>*) ((IntPtr) num3.ToPointer() - (IntPtr) local2 + (IntPtr) local3);
            local2 = (__FnPtr<void ()>*) num3.ToPointer();
            uint* numPtr = __pexit_list_size;
            int num4 = (int) *numPtr + 4;
            *numPtr = (uint) num4;
          }
        }
        *(int*) local3 = (int) func;
        __FnPtr<void ()>* local4 = (__FnPtr<void ()>*) ((IntPtr) local3 + 4);
        local1 = func;
        *(int*) __ponexitbegin_e = (int) \u003CModule\u003E.EncodePointer((void*) local2);
        *(int*) __ponexitend_e = (int) \u003CModule\u003E.EncodePointer((void*) local4);
      }
      catch (OutOfMemoryException ex)
      {
      }
      finally
      {
        \u003CModule\u003E.\u003FA0x27925454\u002E__global_unlock();
      }
      if (local1 != null)
      {
        num1 = 0;
        goto label_12;
      }
    }
    num1 = -1;
label_12:
    return num1;
  }

  [SecurityCritical]
  internal static unsafe void _exit_callback()
  {
    if (\u003CModule\u003E.\u003FA0x27925454\u002E__exit_list_size == 0U)
      return;
    __FnPtr<void ()>* local1 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.\u003FA0x27925454\u002E__onexitbegin_m);
    __FnPtr<void ()>* local2 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.\u003FA0x27925454\u002E__onexitend_m);
    if ((IntPtr) local1 != new IntPtr(-1) && (IntPtr) local1 != IntPtr.Zero && (IntPtr) local2 != IntPtr.Zero)
    {
      __FnPtr<void ()>* local3 = local1;
      __FnPtr<void ()>* local4 = local2;
      while (true)
      {
        __FnPtr<void ()>* local5;
        __FnPtr<void ()>* local6;
        do
        {
          do
          {
            local2 -= 4;
            if (local2 < local1)
              goto label_7;
          }
          while ((IntPtr) *(int*) local2 == (IntPtr) \u003CModule\u003E.EncodePointer((void*) 0));
          void* voidPtr = \u003CModule\u003E.DecodePointer((void*) *(int*) local2);
          *(int*) local2 = (int) \u003CModule\u003E.EncodePointer((void*) 0);
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          __calli((__FnPtr<void ()>) (IntPtr) voidPtr)();
          local5 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.\u003FA0x27925454\u002E__onexitbegin_m);
          local6 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.\u003FA0x27925454\u002E__onexitend_m);
        }
        while (local3 == local5 && local4 == local6);
        local3 = local5;
        local1 = local5;
        local4 = local6;
        local2 = local6;
      }
label_7:
      Marshal.FreeHGlobal(new IntPtr((void*) local1));
    }
    \u003CModule\u003E.\u003FA0x27925454\u002E__dealloc_global_lock();
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe int _initatexit_m()
  {
    int num = 0;
    if (!\u003CModule\u003E.\u003FA0x27925454\u002E__alloc_global_lock())
      return num;
    \u003CModule\u003E.\u003FA0x27925454\u002E__onexitbegin_m = (__FnPtr<void ()>*) \u003CModule\u003E.EncodePointer(Marshal.AllocHGlobal(128).ToPointer());
    \u003CModule\u003E.\u003FA0x27925454\u002E__onexitend_m = \u003CModule\u003E.\u003FA0x27925454\u002E__onexitbegin_m;
    \u003CModule\u003E.\u003FA0x27925454\u002E__exit_list_size = 32U;
    return 1;
  }

  internal static __FnPtr<int ()> _onexit_m(__FnPtr<int ()> _Function)
  {
    // ISSUE: cast to a function pointer type
    if (\u003CModule\u003E._atexit_m((__FnPtr<void ()>) _Function) != -1)
      return _Function;
    // ISSUE: cast to a function pointer type
    return (__FnPtr<int ()>) 0;
  }

  [SecurityCritical]
  internal static unsafe int _atexit_m(__FnPtr<void ()> func)
  {
    // ISSUE: cast to a function pointer type
    return \u003CModule\u003E._atexit_helper((__FnPtr<void ()>) (IntPtr) \u003CModule\u003E.EncodePointer((void*) func), &\u003CModule\u003E.\u003FA0x27925454\u002E__exit_list_size, &\u003CModule\u003E.\u003FA0x27925454\u002E__onexitend_m, &\u003CModule\u003E.\u003FA0x27925454\u002E__onexitbegin_m);
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe int _initatexit_app_domain()
  {
    if (\u003CModule\u003E.\u003FA0x27925454\u002E__alloc_global_lock())
    {
      \u003CModule\u003E.__onexitbegin_app_domain = (__FnPtr<void ()>*) \u003CModule\u003E.EncodePointer(Marshal.AllocHGlobal(128).ToPointer());
      \u003CModule\u003E.__onexitend_app_domain = \u003CModule\u003E.__onexitbegin_app_domain;
      \u003CModule\u003E.__exit_list_size_app_domain = 32U;
    }
    return 1;
  }

  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  internal static unsafe void _app_exit_callback()
  {
    if (\u003CModule\u003E.__exit_list_size_app_domain == 0U)
      return;
    __FnPtr<void ()>* local1 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitbegin_app_domain);
    __FnPtr<void ()>* local2 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitend_app_domain);
    try
    {
      if ((IntPtr) local1 == new IntPtr(-1) || (IntPtr) local1 == IntPtr.Zero || (IntPtr) local2 == IntPtr.Zero)
        return;
      __FnPtr<void ()>* local3 = local1;
      __FnPtr<void ()>* local4 = local2;
      while (true)
      {
        __FnPtr<void ()>* local5;
        __FnPtr<void ()>* local6;
        do
        {
          do
          {
            local2 -= 4;
          }
          while (local2 >= local1 && (IntPtr) *(int*) local2 == (IntPtr) \u003CModule\u003E.EncodePointer((void*) 0));
          if (local2 >= local1)
          {
            // ISSUE: cast to a function pointer type
            __FnPtr<void ()> local7 = (__FnPtr<void ()>) (IntPtr) \u003CModule\u003E.DecodePointer((void*) *(int*) local2);
            *(int*) local2 = (int) \u003CModule\u003E.EncodePointer((void*) 0);
            // ISSUE: function pointer call
            __calli(local7)();
            local5 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitbegin_app_domain);
            local6 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitend_app_domain);
          }
          else
            goto label_12;
        }
        while (local3 == local5 && local4 == local6);
        local3 = local5;
        local1 = local5;
        local4 = local6;
        local2 = local6;
      }
label_12:;
    }
    finally
    {
      Marshal.FreeHGlobal(new IntPtr((void*) local1));
      \u003CModule\u003E.\u003FA0x27925454\u002E__dealloc_global_lock();
    }
  }

  [SecurityCritical]
  internal static __FnPtr<int ()> _onexit_m_appdomain(__FnPtr<int ()> _Function)
  {
    // ISSUE: cast to a function pointer type
    if (\u003CModule\u003E._atexit_m_appdomain((__FnPtr<void ()>) _Function) != -1)
      return _Function;
    // ISSUE: cast to a function pointer type
    return (__FnPtr<int ()>) 0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe int _atexit_m_appdomain(__FnPtr<void ()> func)
  {
    // ISSUE: cast to a function pointer type
    return \u003CModule\u003E._atexit_helper((__FnPtr<void ()>) (IntPtr) \u003CModule\u003E.EncodePointer((void*) func), &\u003CModule\u003E.__exit_list_size_app_domain, &\u003CModule\u003E.__onexitend_app_domain, &\u003CModule\u003E.__onexitbegin_app_domain);
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll")]
  public static extern unsafe void* DecodePointer(void* _Ptr);

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll")]
  public static extern unsafe void* EncodePointer(void* _Ptr);

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe int _initterm_e(__FnPtr<int ()>* pfbegin, __FnPtr<int ()>* pfend)
  {
    int num1 = 0;
    if (pfbegin < pfend)
    {
      while (num1 == 0)
      {
        uint num2 = (uint) *(int*) pfbegin;
        if (num2 != 0U)
        {
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          num1 = __calli((__FnPtr<int ()>) (int) num2)();
        }
        pfbegin += 4;
        if (pfbegin >= pfend)
          break;
      }
    }
    return num1;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void _initterm(__FnPtr<void ()>* pfbegin, __FnPtr<void ()>* pfend)
  {
    if (pfbegin >= pfend)
      return;
    do
    {
      uint num = (uint) *(int*) pfbegin;
      if (num != 0U)
      {
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        __calli((__FnPtr<void ()>) (int) num)();
      }
      pfbegin += 4;
    }
    while (pfbegin < pfend);
  }

  [DebuggerStepThrough]
  internal static ModuleHandle \u003CCrtImplementationDetails\u003E\u002EThisModule\u002EHandle()
  {
    return typeof (ThisModule).Module.ModuleHandle;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void _initterm_m(__FnPtr<void* ()>* pfbegin, __FnPtr<void* ()>* pfend)
  {
    if (pfbegin >= pfend)
      return;
    do
    {
      uint num = (uint) *(int*) pfbegin;
      if (num != 0U)
      {
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        void* voidPtr = __calli(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThisModule\u002EResolveMethod\u003Cvoid\u0020const\u0020\u002A\u0020__clrcall\u0028void\u0029\u003E((__FnPtr<void* ()>) (int) num))();
      }
      pfbegin += 4;
    }
    while (pfbegin < pfend);
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe __FnPtr<void* ()> \u003CCrtImplementationDetails\u003E\u002EThisModule\u002EResolveMethod\u003Cvoid\u0020const\u0020\u002A\u0020__clrcall\u0028void\u0029\u003E(__FnPtr<void* ()> methodToken)
  {
    // ISSUE: cast to a function pointer type
    return (__FnPtr<void* ()>) (IntPtr) \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThisModule\u002EHandle().ResolveMethodHandle((int) methodToken).GetFunctionPointer().ToPointer();
  }

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EInitializeBufferPool([In] Result* obj0, [In] sbyte* obj1, [In] uint obj2);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void __ExceptionPtrDestroy([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void delete([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void __std_exception_copy([In] __std_exception_data* obj0, [In] __std_exception_data* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void __ExceptionPtrCopy([In] void* obj0, [In] void* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern void abort();

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void delete\u005B\u005D([In] void* obj0, [In] uint obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void __std_exception_destroy([In] __std_exception_data* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern void _invalid_parameter_noinfo_noreturn();

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void* nn\u002Efs\u002Edetail\u002EAllocate([In] uint obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void nn\u002Efs\u002Edetail\u002EDeallocate([In] void* obj0, [In] uint obj1);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void nn\u002Eos\u002EFinalizeMutex([In] MutexType* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void nn\u002Eos\u002EInitializeMutex([In] MutexType* obj0, [MarshalAs(UnmanagedType.U1)] bool _param1, [In] int obj2);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe IntegrityRomFsStorage* nn\u002Efssystem\u002EIntegrityRomFsStorage\u002E\u007Bctor\u007D([In] IntegrityRomFsStorage* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EIntegrityRomFsStorage\u002EInitialize([In] IntegrityRomFsStorage* obj0, [In] Result* obj1, [In] SubStorage* obj2, [In] SubStorage* obj3, [In] IBufferManager* obj4);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe FileSystemBufferManager.CacheHandleTable* nn\u002Efssystem\u002EFileSystemBufferManager\u002ECacheHandleTable\u002E\u007Bctor\u007D([In] FileSystemBufferManager.CacheHandleTable* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void nn\u002Efssystem\u002EFileSystemBufferManager\u002ECacheHandleTable\u002E\u007Bdtor\u007D([In] FileSystemBufferManager.CacheHandleTable* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EFileSystemBufferManager\u002ECacheHandleTable\u002EInitialize([In] FileSystemBufferManager.CacheHandleTable* obj0, [In] Result* obj1, [In] int obj2);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorageControlArea\u002EQuerySize([In] Result* obj0, [In] HierarchicalIntegrityVerificationSizeSet* obj1, [In] HierarchicalIntegrityVerificationStorageControlArea.InputParam* obj2, [In] int obj3, [In] long obj4);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorageControlArea\u002EFormat([In] Result* obj0, [In] SubStorage* obj1, [In] HierarchicalIntegrityVerificationMetaInformation* obj2);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorageControlArea\u002EInitialize([In] HierarchicalIntegrityVerificationStorageControlArea* obj0, [In] Result* obj1, [In] SubStorage* obj2);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorage\u002ECommit([In] nn.fssystem.save.HierarchicalIntegrityVerificationStorage* obj0, [In] Result* obj1);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern void nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationStorage\u002ESetGenerateRandomFunction([In] __FnPtr<void (void*, uint)> obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void nn\u002Efssystem\u002Esave\u002EHierarchicalIntegrityVerificationMetaInformation\u002EFormat([In] HierarchicalIntegrityVerificationMetaInformation* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern int nn\u002Efssystem\u002EFileSystemBuddyHeap\u002EQueryOrderMax([In] uint obj0, [In] uint obj1);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EFileSystemBuddyHeap\u002EInitialize([In] FileSystemBuddyHeap* obj0, [In] Result* obj1, [In] uint obj2, [In] uint obj3, [In] uint obj4, [In] int obj5);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe uint nn\u002Efssystem\u002EFileSystemBuddyHeap\u002EGetTotalFreeSize([In] FileSystemBuddyHeap* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern int __CxxQueryExceptionSize();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void _CxxThrowException([In] void* obj0, [In] _s__ThrowInfo* obj1);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void* new\u005B\u005D([In] uint obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe int __CxxDetectRethrow([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void __CxxUnregisterExceptionObject([In] void* obj0, [In] int obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe int __CxxExceptionFilter([In] void* obj0, [In] void* obj1, [In] int obj2, [In] void* obj3);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void delete([In] void* obj0, [In] uint obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void std\u002E_Xlength_error([In] sbyte* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void std\u002E_Xout_of_range([In] sbyte* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern void std\u002E_Xbad_alloc();

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void* @new([In] uint obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe int __CxxRegisterExceptionObject([In] void* obj0, [In] void* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void* memmove([In] void* obj0, [In] void* obj1, [In] uint obj2);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe int WideCharToMultiByte([In] uint obj0, [In] uint obj1, [In] char* obj2, [In] int obj3, [In] sbyte* obj4, [In] int obj5, [In] sbyte* obj6, [In] int* obj7);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void delete\u005B\u005D([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void* malloc([In] uint obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe NcaCryptoConfiguration* nn\u002Efssrv\u002EGetNcaDefaultCryptoConfiguration([MarshalAs(UnmanagedType.U1)] bool _param0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe NcaFsHeaderReader* nn\u002Efssystem\u002ENcaFsHeaderReader\u002E\u007Bctor\u007D([In] NcaFsHeaderReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe ushort nn\u002Efssystem\u002ENcaFsHeaderReader\u002EGetVersion([In] NcaFsHeaderReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe NcaFsHeader.FsType nn\u002Efssystem\u002ENcaFsHeaderReader\u002EGetFsType([In] NcaFsHeaderReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe NcaFsHeader.HashType nn\u002Efssystem\u002ENcaFsHeaderReader\u002EGetHashType([In] NcaFsHeaderReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe NcaFsHeader.EncryptionType nn\u002Efssystem\u002ENcaFsHeaderReader\u002EGetEncryptionType([In] NcaFsHeaderReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe NcaReader* nn\u002Efssystem\u002ENcaReader\u002E\u007Bctor\u007D([In] NcaReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002ENcaReader\u002EInitialize([In] NcaReader* obj0, [In] Result* obj1, [In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj2, [In] NcaCryptoConfiguration* obj3);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe NcaHeader.DistributionType nn\u002Efssystem\u002ENcaReader\u002EGetDistributionType([In] NcaReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe NcaHeader.ContentType nn\u002Efssystem\u002ENcaReader\u002EGetContentType([In] NcaReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe byte nn\u002Efssystem\u002ENcaReader\u002EGetKeyGeneration([In] NcaReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe byte nn\u002Efssystem\u002ENcaReader\u002EGetKeyIndex([In] NcaReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe ulong nn\u002Efssystem\u002ENcaReader\u002EGetProgramId([In] NcaReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe uint nn\u002Efssystem\u002ENcaReader\u002EGetContentIndex([In] NcaReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe uint nn\u002Efssystem\u002ENcaReader\u002EGetSdkAddonVersion([In] NcaReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe int nn\u002Efssystem\u002ENcaReader\u002EGetFsCount([In] NcaReader* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe NcaFileSystemDriver* nn\u002Efssystem\u002ENcaFileSystemDriver\u002E\u007Bctor\u007D([In] NcaFileSystemDriver* obj0, [In] NcaReader* obj1, [In] MemoryResource* obj2, [In] IBufferManager* obj3);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002ENcaFileSystemDriver\u002EOpenStorage([In] NcaFileSystemDriver* obj0, [In] Result* obj1, [In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj2, [In] NcaFsHeaderReader* obj3, [In] shared_ptr\u003Cnn\u003A\u003Afssystem\u003A\u003ANcaReader\u003E* obj4, [In] int obj5);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002ENcaFileSystemDriver\u002EOpenStorage([In] NcaFileSystemDriver* obj0, [In] Result* obj1, [In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj2, [In] int obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void free([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u002EInitialize([In] PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* obj0, [In] Result* obj1, [In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj2);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u002E\u007Bctor\u007D([In] PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E\u002EGetFileBaseOffset([In] PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003APartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u0020\u003E* obj0, [In] Result* obj1, [In] long* obj2, [In] sbyte* obj3);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe FileStorageBasedFileSystem* nn\u002Efssystem\u002EFileStorageBasedFileSystem\u002E\u007Bctor\u007D([In] FileStorageBasedFileSystem* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EFileStorageBasedFileSystem\u002EInitialize([In] FileStorageBasedFileSystem* obj0, [In] Result* obj1, [In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003Afsa\u003A\u003AIFileSystem\u003E* obj2, [In] sbyte* obj3, [In] OpenMode obj4);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe uint strnlen([In] sbyte* obj0, [In] uint obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe int strncpy_s([In] sbyte* obj0, [In] uint obj1, [In] sbyte* obj2, [In] uint obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe int strncat_s([In] sbyte* obj0, [In] uint obj1, [In] sbyte* obj2, [In] uint obj3);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe PartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E* nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u002E\u007Bctor\u007D([In] PartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u002E\u007Bdtor\u007D([In] PartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u002EQueryMetaDataSize([In] Result* obj0, [In] uint* obj1, [In] PartitionFileSystemFormat.FileEntryForConstruct* obj2, [In] int obj3);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003APartitionFileSystemFormat\u003E\u002EConstructMetaData([In] Result* obj0, [In] void* obj1, [In] uint obj2, [In] PartitionFileSystemFormat.FileEntryForConstruct* obj3, [In] int obj4);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe PartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E* nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E\u002E\u007Bctor\u007D([In] PartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E\u002E\u007Bdtor\u007D([In] PartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E\u002EQueryMetaDataSize([In] Result* obj0, [In] uint* obj1, [In] Sha256PartitionFileSystemFormat.FileEntryForConstruct* obj2, [In] int obj3);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EPartitionFileSystemMetaCore\u003Cnn\u003A\u003Afssystem\u003A\u003Adetail\u003A\u003ASha256PartitionFileSystemFormat\u003E\u002EConstructMetaData([In] Result* obj0, [In] void* obj1, [In] uint obj2, [In] Sha256PartitionFileSystemFormat.FileEntryForConstruct* obj3, [In] int obj4);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe RomFsFileSystem* nn\u002Efs\u002ERomFsFileSystem\u002E\u007Bctor\u007D([In] RomFsFileSystem* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efs\u002ERomFsFileSystem\u002EInitialize([In] RomFsFileSystem* obj0, [In] Result* obj1, [In] IStorage* obj2, [In] void* obj3, [In] uint obj4, [MarshalAs(UnmanagedType.U1)] bool _param5);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efs\u002ERomFsFileSystem\u002EGetFileBaseOffset([In] RomFsFileSystem* obj0, [In] Result* obj1, [In] long* obj2, [In] sbyte* obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe int strncmp([In] sbyte* obj0, [In] sbyte* obj1, [In] uint obj2);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u002EInitialize([In] PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* obj0, [In] Result* obj1, [In] shared_ptr\u003Cnn\u003A\u003Afs\u003A\u003AIStorage\u003E* obj2);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u002E\u007Bctor\u007D([In] PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe Result* nn\u002Efssystem\u002EPartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E\u002EGetFileBaseOffset([In] PartitionFileSystemCore\u003Cnn\u003A\u003Afssystem\u003A\u003ASha256PartitionFileSystemMeta\u003E* obj0, [In] Result* obj1, [In] long* obj2, [In] sbyte* obj3);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe void* _getFiberPtrId();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern void _cexit();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern void Sleep([In] uint obj0);

  [SuppressUnmanagedCodeSecurity]
  [MethodImpl(MethodImplOptions.Unmanaged | MethodImplOptions.PreserveSig, MethodCodeType = MethodCodeType.Native)]
  internal static extern void __security_init_cookie();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern void terminate();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("", EntryPoint = "", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  [MethodImpl(MethodImplOptions.Unmanaged, MethodCodeType = MethodCodeType.Native)]
  internal static extern unsafe int __FrameUnwindFilter([In] _EXCEPTION_POINTERS* obj0);
}
