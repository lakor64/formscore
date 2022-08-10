# Notes
- [Mono](https://github.com/mono/mono) git commit: 3d11ccdce6df39bb63c783af28ec9756d1b32db1
- [Winforms](https://github.com/dotnet/winforms) git commit: 1744f623071b1b46e647db29bb655f508a380a30

## File sync
| File name | Source | Notes |
| --------- | ------ | ----- |
| src\FormsCore\misc\MultitargetUtil.cs | winforms\src\System.Windows.Forms\src\misc\MultitargetUtil.cs | |
| src\FormsCore\System\Drawing\Design\* | winforms\src\System.Windows.Forms\src\System\Drawing\Design\* | |
| src\FormsCore\System\Resources\* | winforms\src\System.Windows.Forms\src\System\Resources\* | |
| src\FormsCore\Accessibility\* | mono\mcs\class\Accessibility\Accessibility\* | |
| src\FormsCore\mcs\MonoTODOAttribute.cs | mono\mcs\build\common\MonoTODOAttribute.cs | |
| src\FormsCore\mcs\MonoToolsLocator.cs | mono\mcs\class\System\System\MonoToolsLocator.cs | |
| src\FormsCore\Properties\AssemblyRef.cs | winforms\src\System.Windows.Forms\src\AssemblyRef.cs | File modified |
| src\FormsCore\Resources\* | winforms\src\System.Windows.Forms\src\Resources\* | MSR.resx does not come from MS Winforms |
| src\FormsCore\System\Windows\Forms\Primitives\ClientUtils.cs | winforms\src\System.Windows.Forms.Primitives\src\System\Windows\Forms\Internals\ClientUtils.cs | |
| src\Mono.Posix | mono\mcs\class\Mono.Posix | |
| src\FormsCore\SRCategoryAttribute.cs | winforms\src\System.Windows.Forms\SRCategoryAttribute.cs | |
| src\FormsCore\SRDescriptionAttribute.cs | winforms\src\System.Windows.Forms\SRDescriptionAttribute.cs | |

## Disabled things
- WebBrowser*
- X11Gtk backend
