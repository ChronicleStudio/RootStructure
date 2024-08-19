# Discription
This is, simply speaking, the Root Structure of the prodject. This repository is not a mod, and does have any practical use for Vintage story in and of it's self. This does, however, allow for easy testing of multiple mods or Mod Projects with in Visual Studio 2022. It specifies the neccasary structure of the directorys to allow for the bin folder to be in a shared directory. By having the build folder shared, this allows for the mods to be ran/tested at the same time. By default, when a mod is created via the [template](https://github.com/anegostudios/vsmodtemplate), only that mod can be ran within Vintage Story, requiring, by default, the secondary mod to be packaged as a relase and moved to the mod fold for the game. Although, there may be other ways to surcomvent this issue, this was the simplest way of modifiying the directory structure to allow for easier develpment and testing of multiple mods.

As well as benifits of testing, since the Mod Template generates a .sln file for each mod, and also includes a CakeBuild prodject for each mod. This allows for the mods to be moved to one solution file. Allowing for the development of multiple mods within the same solution has the benifit of being able to switch between mods without having to close down the solution, and just being able to switch between the prodjects in Visual Studio. This expeditates the process of developement by allowing for easy copy pasting of code between the projects, or allows the testing of multiple prodjects at once (as listed above). all within one session of Vissual Studio.

This also allos for the removeal of duplicate CakeBuilds, as the code is typically included with every mod. Along with the customization of CakeBuild, this allows CakeBuild to only be needed once, cleaning up the prodject folder.

# Setting Up Solution
1. Clone the Root Structure to directory of your choice, this will generate all the neccasary subfolders.
    - In the relevent subfolders will be the target folder for the other repositories.
    - By default Git Hub Desktop will clone repository and create a subfolder with the name of the repository. Meaning if `C:\Test` was selected, the solution file and subfolders would then be in `C:\Test\RootStructure` by default.
2. Run the `setup.bat` script to setup windows enviroment veribles, install .Net SDK 7.0 (if needed) and setup the default templates.
    - In Windows Command Prompt, use `cd` commands to navigate to the repo directory, and run `setup.bat`.
    - Question one will ask if Vintage Story is installed to default directory. If so type, `yes`. Otherwise type `no` and enter in the folder path.
    - Question two will ask if .NET SDK 7.0. The script will output a list of sdks installed, if you don't see 7.0.* installed, simply enter `no` and script will install the sdk.
    - The script will automaticaly install the Vintage Mod Templates such that Visual Studio 2022 will have the default modding template.
4. You would then need to clone the other repositories to this new directory.
    - When using the Choose location and browsing to the folder `C:\Test\RootStructure`, you should see the local path being set as `C:\Test\RootStructure\CakeBuild`, if however, you select `C:\Test\RootStructure\CakeBuild`, it may show as `C:\Test\RootStructure\CakeBuild\CakeBuild`.
    - If there are to many Subdirctories within the prodject, CakeBuild, the Build and Debug Features, and even the prodjects themselves will not load. 
5. Once the Repository secesfully downloads, you should see the `License` and `Readme` for each prodject, under `C:\Test\RootStructure\CakeBuild\`, and the relevent `.csproj` under `C:\Test\RootStructure\CakeBuild\CakeBuild`. 

> ***Note:*** Where `CakeBuild` shows in the file structures above, this would be replaced by a given Prodject/Repository name.
> ***Note:*** If you have issues with depencies showing as not loaded, ensure that the Install location for Vintage Story was selected correctly. If so, then double click on a given project and add a space to the bottom of the file, save the .csproj file, remove the space and save again. This should refresh the solution and builds should then show up as valid, if further steps are needed, reach out to Sauran The White on discord for assiatnce with troubleshooting.

# Credits
- `setup.bat` and `setup.ps1` where created by [Saruan The White](https://github.com/JonathanArendt)
- `dontnet-install.ps1` is found on [Microsoft's Learn .NET Website](https://learn.microsoft.com/en-us/dotnet/core/install/windows#install-with-powershell) 
