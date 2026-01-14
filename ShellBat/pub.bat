dotnet publish /p:Platform=x64 -p:PublishProfile=Properties\PublishProfiles\FolderProfile.x64.pubxml
upx bin\X64\Release\net10.0\publish\win-x64\ShellBat.x64.exe
dotnet publish /p:Platform=ARM64 -p:PublishProfile=Properties\PublishProfiles\FolderProfile.ARM64.pubxml
dotnet publish /p:Platform=x86 -p:PublishProfile=Properties\PublishProfiles\FolderProfile.x86.pubxml