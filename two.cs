
// cat two
using System.Drawing;

// Create a new bitmap with the desired width and height
Bitmap catImage = new Bitmap(width, height);

// Create a graphics object from the bitmap
using (Graphics graphics = Graphics.FromImage(catImage))
{
    // Draw the cat image onto the graphics object
    using (Image cat = Image.FromFile("cat.jpg")) // Replace "cat.jpg" with the path to your cat image file
    {
        graphics.DrawImage(cat, 0, 0, width, height);
    }
}

// Save the cat image to a file
catImage.Save("cat_image.jpg"); // Replace "cat_image.jpg" with the desired file path and name

