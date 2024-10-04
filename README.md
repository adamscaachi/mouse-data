# Mouse Data

Human mouse data could be used to:
1) Further our understanding of human mouse movement dynamics, improving our ability to detect artificially generated mouse movement.
2) Train bots to artificially generate more realistic mouse movement, improving their ability to evade bot detection.

Both of the above applications are interesting areas for further study and motivate the collection of human mouse data.

## Data Collection

An object clicking simulation is made using Unity. 

A vector (x, y, t) is logged each frame, where x and y represent the mouse position and t is the time since the last object was clicked. When clicking an object, the logged vectors are written to a text file, and a new object is instantiated at a random position within the frustum of the camera.

<p align="center">
  <img src="https://github.com/user-attachments/assets/a5599f3e-eb4d-4950-9263-62743e2d6e24" width="350" />
</p>

## Data Visualisation

The collected data is visualised through a series of plots: <br>
1) X and Y positions of the mouse during 20 click events. Coloured circles are plotted over the mouse trajectory every 50 ms, and black outlined circles are plotted between each event.
2) The distance between the initial mouse position and an object compared with the time taken for that object to be clicked.
3) A histogram showing the distribution of time taken for an object to be clicked.
4) A histogram showing the distribution of distances between the initial mouse position and the instantiated object.
5) The velocity at which the mouse moves during 10 click events. Vertical red dashed lines are plotted between each event.

<p align="center">
  <img src="https://github.com/user-attachments/assets/8866c8ea-bd4a-4dc1-9031-67d9af5f7534" width="650" />
</p>
