set outputdir="Z:\SteamLibrary\steamapps\common\RimWorld\Mods\ToolkitAlienVsPredatorPatch"

rm -r %outputdir%
mkdir %outputdir%

xcopy /E /Y "..\About" %outputdir%\About\
xcopy /E /Y "..\Defs" %outputdir%\Defs\
xcopy /E /Y "..\Assemblies" %outputdir%\Assemblies\