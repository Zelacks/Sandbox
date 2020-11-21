using System.Reflection;
using System.Runtime.InteropServices;


[assembly: AssemblyProduct("Sandbox")]
[assembly: AssemblyCompany("Zelacks")]
[assembly: AssemblyCopyright("Copyright © 2020 Zelacks")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyTitle("Sandbox")]
[assembly: AssemblyDescription("")]
//[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("FE82077D-EA92-4DAA-9219-7BEFA6060CD2")]

// Version information for an assembly consists of the following four values:
// Major Version
// Minor Version
// Build Number
// Revision
[assembly: AssemblyVersion("1.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
//[assembly: AssemblyInformationalVersion("VERSIONSTRING")]