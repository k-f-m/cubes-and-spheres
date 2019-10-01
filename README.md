# Cubes And Spheres
This program reads some parameters including the object names, their colors, and coordinates from a text file. Consequently, it will locate and place the objects in a three-dimensional space. The objects can be either viewed in a two-dimensional perspective or orthographic projection. After the demonstration of the scene, by pressing any key, the scene will disappear, and the system time indicating the scene closing time will be demonstrated instead. At this point, by pressing the escape key, the application will be closed.

# Task Requirements:
## Task description:
In Unity, program a 2D scene that reads parameters from a file, loads the described 3D objects (e.g. spheres/cubes) and displays them on the screen at random locations. The scene is shown until the user presses a key-- at which point the scene exits and the program returns the time that the scene was displayed for.

## Hints:

1. Create an input file with 10 green cubes, 10 green spheres and 1 red cube at various locations (use some 3D coordinates).

2. Prepare code for reading the input file, display the scene (in orthographic or perspective projection in 2D) and add user input (key press for exiting the scene). 

## Further notes:
The program reads the coordinates from a spreadsheet file (.csv) and demonstrates the results on the screen as perspective or orthographic projection. The coordinates for each object are given in three dimensions. The position of the camera can also be set via the corresponding parameters in the spreadsheet. As a consequence, objects and relevant parameters can be added and altered by the user easily and as desired using the common spreadsheet management software, as well as a simple text editor. The spreadsheet file with the name "ObjectsProperties.csv" can be found under Assets ->  Resources directory and modified accordingly. The file is already filled with some semi-random coordinates for demonstration purposes.

A pre-built software (with a perspective view) for Windows platform can be downloaded and tested; the executable "2D_scene.exe" can be found under the "Build" directory. In order to run the program, the executable with the corresponding dependencies have to be downloaded (located in "Build" directory).

Moreover, sample pictures from the 2D scene in perspective and orthographic projections can be found under the "Images" directory.

----Update 01.10.2019----
### New builds
New builds for Windows platform and WebGL are released. Now it is possible to run the program on common web browsers such as Mozilla Firefox and Google Chrome, and Microsoft Edge.  However, due to security considerations, it is not possible to run the program locally under the default settings of Mozilla Firefox and Google Chrome; Microsoft Edge can run the program without any configuration change. In general, the program has to be executed on a HTTP server. In order to run the program locally, a local HTTP server has to be installed. By using "Build and Run" functionality of Unity, the program will be executed on a local HTTP server. Executables can be found under the "Build" directory.
