using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SNAKEGAME
{
    internal class Images
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource Body = LoadImage("Bodyy.png");
        public readonly static ImageSource Head = LoadImage("Head.png");
        public readonly static ImageSource Food = LoadImage("Food.png");
        public readonly static ImageSource DeadBody = LoadImage("DeadBody.png");
        public readonly static ImageSource DeadHead = LoadImage("DeadHead.png");
        public readonly static ImageSource kanye = LoadImage("kanye.png");
        public readonly static ImageSource kanyesad = LoadImage("kanyeded.png");
        public readonly static ImageSource back = LoadImage("Background.jpg");
        public readonly static ImageSource Bgrey = LoadImage("Bgrey.png");

        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"/Assets/{ fileName }", UriKind.Relative));
        }
    }
}
