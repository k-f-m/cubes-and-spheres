# Cubes And Spheres
This program reads some parameters including the objects, their colors, and coordinates from a number of objects such as sphere and cube from a text file. Consequently, it will locate the objects in the space. The objects can be viewed in a 2D perspective either as orthographic or perspective projection. After the demonstration, by pressing any key, the scene will disappear, and the system time will be demonstrated instead. At this point, by pressing the escape key, the application will be closed.

# Task Requirements:
## Task description:
In Unity, program a 2D scene that reads parameters from a file, loads the described 3D objects (e.g. spheres/cubes) and displays them on the screen at random locations. The scene is shown until the user presses a key-- at which point the scene exits and the program returns the time that the scene was displayed for.

## Hints:

1. Create an input file with 10 green cubes, 10 green spheres and 1 red cube at various locations (use some 3D coordinates).

2. Prepare code for reading the input file, display the scene (in orthographic or perspective projection in 2D) and add user input (key press for exiting the scene). 

## Further notes:
The program reads the coordinates from a spreadsheet file (.csv) and demonstrates the results on the screen as perspective or orthographic projection. The coordinates for each object are given in 3 dimensions. The position of the camera can also be set via the corresponding parameters in the spreadsheet. As a consequence, objects and relevant parameters can be added and altered by the customer easily and as desired using the common spreadsheet management software as well as a simple text editor. The spreadsheet file with the name "ObjectsProperties.csv" can be found under Assets -> Resources directory and modified accordingly. The file is already filled with some semi-random coordinates for demonstration purposes.

An already built software (with a perspective view) for Windows platform can be downloaded and tested. The executable "2D_scene.exe" can be found under the "Build" directory.

Moreover, sample pictures from the 2D scene in perspective and orthographic projections can be found under the images directory.
