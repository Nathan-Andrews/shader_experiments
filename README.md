# Shader Experiments in GLSL
## Table of Contents
[Introduction](#introduction)  
[Features](#features)  
[Technologies Used](#technologies-used)  
[Prerequisites](#prerequisites)  
[Getting Started](#getting-started)  
[Contact](#contact)  

## Introduction
This project is a compilation of a few shaders that I wrote as I was learning about computer graphics.
This uses the OpenTK graphics library in C#, and the shaders were written in GLSL.
All of these shaders are simple, but interesting to look at.
These shaders are passed a list of 2d points in the uniform, and each shader uses those points in a different way

## Features
- The Visualize class
  - This is a class that creates an OpenTK window that other classes can interact with and send shaders too.
- The PointVisualizer class
  - This class controls any shader that handles points.  It is used in all the examples to pass the list of points to the uniform
- Shader examples
  - Example #1
    - Chosen Shader: `nearest_point_rand_color`  
      Point Count: `100`  
      Particle Speed: `0.000025f`  
      Colors: `(1f, 0.89f, 0.459f,1.0f), (1f, 0.412f, 0.459f, 1.0f)`  
    ![gif example 1](https://github.com/user-attachments/assets/dfd0b437-575e-4ecc-9bef-eb09f6333eff)
  - Example #2
    - Chosen Shader: `nearest_point_gradient_fill`  
      Point Count: `100`  
      Particle Speed: `0.000025f`  
      Colors: `(0.286f, 0.471f, 0.941f, 1.0f), (0.471f, 0.796f, 1.0f, 1.0f)`  
    ![gif example 2](https://github.com/user-attachments/assets/5928c03c-bb1f-492b-8ba9-626f4681d2d8)
  - Example #3
    - Chosen Shader: `nearest_point_edge_distance`  
      Point Count: `100`  
      Particle Speed: `0.0001f`  
      Colors: `(0.286f, 0.471f, 0.941f, 1.0f), (0.471f, 0.796f, 1.0f, 1.0f)`
    ![gif example 3](https://github.com/user-attachments/assets/c684db50-9511-430b-8451-543848736e57)
  - Example #4
    - Chosen Shader: `second_nearest_point`  
      Point Count: `100`  
      Particle Speed: `0.000025f`  
      Colors: `(0.961f, 0.588f, 0.831f,1.0f), (0.639f, 0.361f, 0.839f, 1.0f)`
    ![gif example 4](https://github.com/user-attachments/assets/efbba209-73f2-47ee-9220-0343d84a8e72)


## Technologies Used

Languages: [C#](https://learn.microsoft.com/en-us/dotnet/csharp/), [GLSL](https://www.khronos.org/opengl/wiki/Core_Language_(GLSL))  
Libraries: [OpenTK](https://opentk.net/)

## Prerequisites
[dotnet 7.0.1](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

## Getting Started

```
1. Clone the repository
   git clone https://github.com/Nathan-Andrews/shader_experiments.git
2. Navigate to the project directory
   cd shader_experiments
3. Install dependencies
   dotnet restore
4. Start the project
   dotnet run
```

## Contact

Nathan Andrews - andrewsnathan2003@gmail.com  
Project Link: [https://github.com/Nathan-Andrews/handwritten-digit-recognition-NN](https://github.com/Nathan-Andrews/handwritten-digit-recognition-NN)

