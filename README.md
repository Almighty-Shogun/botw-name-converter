<h1 align="center">
<img src='https://cdn.shogunate.tools/assets/logo/png/Almighty_Shogun_Stars_Thick_Small.png'>
<br>botw-name-converter</br>
</h1>

A simple script in C# that converts the icon names from The Legend of Zelda - Breath of the Wild to the actual item name.

# Note
This is an old project that I wrote a long time ago. I have converted the code from using .NET 5 to .NET 6 and published the code here on GitHub. I have no use for the code anymore and it might be useful so someone in the future. This is one of my first C# application that I wrote. If the code doesn't work or you need help with it feel free to contact me.

# Information
This is an C# console application that simply scans all the files in the `files` folder and renames the image name to the actual item name in the game. For example `Animal_Insect_A.png` will be renamed to `Hot-Footed Frog.png`.

# How to use/build
**How to use**
- Download .NET 6 [here](//dotnet.microsoft.com/download/dotnet/6.0).
- Download the latest release [here](//github.com/Almighty-Shogun/botw-name-converter/releases/latest).
- Get all icon files and place them in the `files` folder.
  - The icon files have to be a `.png` file.
- Start the application.

**How to build**
- Download .NET 6 [here](//dotnet.microsoft.com/download/dotnet/6.0).
- Download/fork the code and open it with any C# IDE (Visual Studio or JetBrains Rider).
- Get all icon files and place them in the `files` folder.
    - The icon files have to be a `.png` file.
- Check if `Newtonsoft.Json` version `13.0.1` or higher is installed (normally the IDE will do this automatically).
