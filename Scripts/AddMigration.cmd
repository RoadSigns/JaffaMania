pushd ..\SourceCode\JaffaMania.Data
dotnet ef --startup-project ../JaffaMania.Website migrations add %1
dotnet ef --startup-project ../JaffaMania.Website database update
popd