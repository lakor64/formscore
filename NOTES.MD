# Notes
- [Mono](https://github.com/mono/mono) git commit: 04859508c54a7ac25547bc5bcf4a019f0517aa0b
- [Winforms](https://github.com/dotnet/winforms) git commit: 1744f623071b1b46e647db29bb655f508a380a30

## File sync
| File name | Source |
| --------- | ------ |
| src\FormsCore\misc\MultitargetUtil.cs | winforms\src\System.Windows.Forms\src\misc\MultitargetUtil.cs |
| src\FormsCore\System\Drawing\Design\* | winforms\src\System.Windows.Forms\src\System\Drawing\Design |
| src\FormsCore\System\Resources\* | winforms\src\System.Windows.Forms\src\System\Resources |
| src\FormsCore\Accessibility\* | mono\mcs\class\Accessibility\Accessibility |
| src\FormsCore\mcs\MonoTODOAttribute.cs | mono\mcs\build\common\MonoTODOAttribute.cs |
| src\FormsCore\mcs\MonoToolsLocator.cs | mono\mcs\class\System\System\MonoToolsLocator.cs |
| FormsCore\Assembly\AssemblyRef.cs | winforms\src\System.Windows.Forms\src\AssemblyRef.cs |
| FormsCore\resources\SR.resx | winforms\src\System.Windows.Forms\src\Resources\SR.resx |
| src\FormsCore\System\Windows\Forms\Internal\ClientUtils.cs | winforms\src\System.Windows.Forms.Primitives\src\System\Windows\Forms\Internals |
| src\FormsCore\Resources | src\System.Windows.Forms\src\Resources |
| src\Mono.Posix | mono\mcs\class\Mono.Posix |

## Disabled things
- WebBrowser*
- X11Gtk backend
