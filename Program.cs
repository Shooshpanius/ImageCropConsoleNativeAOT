//using System.Drawing;
//using System.Drawing.Imaging;


using ImageMagick;

class Program
{
    static void Main(string[] args)
    {

#if !DEBUG
        string pathIn = args[0];
        string pathOut = args[1];
#else
        string pathIn = "D:\\1.png";
        string pathOut = "D:\\2.png";
#endif

        try
        {

            using (var image = new MagickImage(pathIn))
            {
                image.Trim();
                image.Write(pathOut);
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Thread.Sleep(5000);
        }

    }
}
