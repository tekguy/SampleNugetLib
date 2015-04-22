$project_name = 'SampleNugetLib'
$solution_name = 'SampleNugetLib.sln'
$nuget_packageVersion = '1.0.1'
$nuget_packageName = 'SampleNugetLib'
$nuget_apikey = 'YOUR_API_KEY'
$nuget_server = 'https://www.nuget.org/api/v2/package'
$build_mode = 'Release' 

if(!$build_mode){
    Write-Error "Cannot find build mode"
}else{
	# Run MSBuild
	msbuild.exe _build\build.proj `
	    /p:Build_Number=$version `
	    /p:Environment=$env `
	    /p:ProjectName=$project_name `
	    /p:SolutionName=$solution_name `
	    /p:NugetApiKey=$nuget_apikey `
	    /p:NugetServer=$nuget_server `
	    /p:NugetPackageName=$nuget_packageName `
	    /p:NugetPackageVersion=$nuget_packageVersion `
	    /p:ProjectBuildMode=$build_mode `
	    /ToolsVersion:12.0
}
