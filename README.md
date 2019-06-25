# Alpha2Greyscale
Takes the alpha channel of an image and creates a greyscale representation. Great to extract alpha for use with certain renderers.

Can be used to extract the alpha channel from a texture if a PBR property such as roughness was put into the A channel. Useful for platforms where direct channel manipulation is not possible such as Sketchfab.

## How to use
Launch the executable for your platform by dragging the image of choice onto it. This will launch and perform the conversion on this file. Converted file is placed in the same directory as the original.
### Via CLI
Launch the executable and pass the file path/name as the first argument (0).
