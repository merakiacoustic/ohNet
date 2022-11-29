# Prerequisites
## Install dependencies
Install the latest [conan](https://pypi.org/project/conan/) via pip (at least version 1.54.0)


If [libb64]((https://conan.io/center/libb64)) is available on [conan center](https://conan.io/center/), you can skip this step.
If not, then you need to build the package locally.
```sh
🐧 git clone git@github.com:KGrzeg/libb64-conan.git # clone the repo
🐧 cd libb64-conan
🐧 direnv allow # or manually setup cmake and gcc
🐧 git checkout 1.2.1-conanfile # switch to proper tag
🐧 conan create . libb64/1.2.1@ # install package to conan's cache

# verify that package is successfully installed
🐧λ conan search libb64
Existing package recipes:

libb64/1.2.1

# if everything is ok, you can delete the directory
🐧 cd ..
🐧 rm -rf libb64-conan
```


# Build and compile (Windows, Linux, MacOS)
```sh
🐧 mkdir build
🐧 cd build
🐧 conan install .. --build missing
🐧 cmake .. -DCMAKE_BUILD_TYPE=Release
#optionally "🐧 cmake .. -DCMAKE_BUILD_TYPE=Release -GNinja" for quicker builds
🐧 cmake --build . -v
```

# Cross compilation (Raspberry PI)
Install ARM compiler, for example in ubuntu type in:
```sh
🐧 sudo apt install gcc-arm-linux-gnueabihf g++-arm-linux-gnueabihf
```

## Setup target system's libraries
Before you can compile for the target system, you need to copy some headers and libs to the host filesystem. Assuming you have mounted the SD Card with installed Raspbian as `/mnt/rpi`, you can type in:
```sh
🐧 mkdir -p "$HOME/rpi/rootfs" # choose the path as you wish
🐧 cp /mnt/rpi/lib "$HOME/rpi/rootfs" -rv
🐧 cp /mnt/rpi/usr "$HOME/rpi/rootfs" -rv
🐧 cp /mnt/rpi/opt/vc "$HOME/rpi/rootfs/opt" -rv
```
Then use your chosen path in the build command.

# Build and compile
```sh
🐧 mkdir build-rpi
🐧 cd build-rpi
🐧 cmake -D CMAKE_TOOLCHAIN_FILE="../CMake/Toolchain-RaspberryPi.cmake" \
          -D RPI_FS:STRING="$HOME/my/custom/rpifs" \ # if used preferred path, can omit this
          ..
🐧 cmake --build . -v
```

# Don't read further.

ohNet library
------------
ohNet is a library for the discovery, monitoring, manipulation and implementation
of UPnP devices, generalized to be extensible to other similar protocols.

Prerequisites
-------------
On Windows:
    Microsoft Visual Studio
    (Express versions are okay. Versions earlier than 2010 will have to edit Types.h to
    include content equivalent to stdint.h.)
    Microsoft .NET 4.0 SDK (optional, required for C# bindings and all changes to service descriptions)
    Java (optional, required for building Java bindings)

On Linux:
    Mono (optional, required for changes to service descriptions)
    Java (optional, required for building Java bindings)

Building
--------
    make

Note: On Windows, ensure you are in a visual studio command prompt or have otherwise set Visual
Studio's environment variables.

If you have a .NET runtime available and want to regenerate makefiles, proxies or providers, run
    make generate-makefiles uset4=yes
    make GenAll uset4=yes

Installing
----------
See "INSTALL.txt".

Directories
-----------
Build/
    Generated during the build process. Build artefacts go here.

Build/Obj/Windows/
Build/Obj/Posix/
    Binaries and shared libraries are built to here during a build.

Build/Tools/
    Binaries that are required by the build process are built to here.

Build/Include/OpenHome
    Header files needed by users of the library are copied here during the build.

Build/Include/OpenHome/Net/C
    Header files for C language bindings.

Build/Include/OpenHome/Net/Cpp
    Header files for C++ language bindings.

Build/Include/OpenHome/Net/Core
Build/Include/OpenHome/Net/Private
    Not intended for external use.

OpenHome
    Base source code.

OpenHome/Net
    Source code shared by Control Point and Device stacks.

OpenHome/Net/ControlPoint
    Control Point stack.

OpenHome/Net/Device
    Device stack.

OpenHome/Net/Bindings
    Language bindings (for C++, C#, Java, JavaScript & C).


Make targets
------------
all
    This is the default target. It (should) build everything.

ohNet.net.dll
    ohNet as a dll/shared object plus C# bindings

ohNetJavaAll
    ohNet as a dll/shared object plus Java bindings

generate-makefiles
    This regenerates the makefiles in Generated/ that are derived from the
    service descriptions. GNU make will detect these changes automatically,
    but Microsoft's nmake doesn't handle this, so Windows users will need
    to use this target when the service descriptions or T4 templates for
    the makefiles have been changed.

install
    See "INSTALL.txt".

uninstall
    See "INSTALL.txt".

clean
    Removes files from Build/Obj/$platform/ and Build/Include/

mostlyclean
    Also removes the auto-generated makefiles from Generated/

maintainer-clean
    Also removes Build/Tools/
    (Should - but doesn't yet - remove auto-generated source files too.)
