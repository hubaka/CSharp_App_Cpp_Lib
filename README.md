# C++ lib linked with C# application

This CMake example demontrates how to link/call C++ functionality from C# application.

* Create static library using the C++ source files
    C++ source files inside "algo/filter" are used to create filer_d.lib static library.
    
* Create CLR dll and link C++ static library
    CLR dll acts as a bridge between C++ code and C# code. CLR dll is created using the source files inside "cppclr/clrapp". CMake function "install_shared_module_lib" creates the CLR dll.
    
* Create C# application and link CLR dll
    Create C# application and add the previously created CLR dll as reference to this C# application.

