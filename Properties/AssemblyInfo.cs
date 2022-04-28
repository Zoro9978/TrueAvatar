using MelonLoader;
using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("BTD6 Mod Template")]//---------------------------!!!!!!!!!!!!change this to your mod's name!!!!!!!!!!!!!!!!!!!
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("BTD6 Mod Template")]//-------------------------!!!!!!!!!!!!change this to your mod's name!!!!!!!!!!!!!!!!!!!
[assembly: AssemblyCopyright("Copyright ©  2021")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: MelonInfo(typeof(1.Main), "2", "3", "4")] // !!!!!!!!!!!IMPORTANT!!!!!!!!!!!!!!!!! change these using the guide located on the next few lines!!!!!!!!!!!!!!!!!
                                                     // replace "1" with your project name(NOT MOD NAME) which is the name of your folder containing source code. In Visual Studio if you start typing the name, it will pop up. If your file containing the code: "public class Main : MelonMod" is not named Main.cs, change the .main to the name of your main file, excluding the file type, and keeping the capitalization.
                                                     // replace "2" with the name of your mod, it can be different from "1".
                                                     // replace "3" with the file version name, see the last few lines in this file for the format you should use.
                                                     // replace "4" with your public name (username) that you go by, DO NOT use your real name, unless you want that to be shared with everyone that downloads your mod.

                                                     // Example: [assembly: MelonInfo(typeof(BTD6 Mod Template.Main), "ModTemplate", "1.0.0", "Not_Graham")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("1b3d0572-d9aa-4a6f-b003-0592f948f96a")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
