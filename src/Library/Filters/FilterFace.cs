
using System;
using System.Drawing;

namespace CompAndDel
{
    /// <summary>
    /// Un filtro que recibe una imagen y retorna su negativo.
    /// </remarks>
    public class FilterFace
    {

        /// Un filtro que retorna el negativo de la imagen recibida.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida pero en negativo.</returns>
        public FilterFace()
        {


        }
        public  bool Filter(IPicture image)
        {
            IPicture result = image.Clone();

            PictureProvider provider = new PictureProvider();
            provider.SavePicture(image, @"temporal.jpg");
            CognitiveFace cog = new CognitiveFace(false);
            cog.Recognize(@"temporal.jpg");
            bool resultado=cog.FaceFound;
            System.IO.File.Delete(@"temporal.jpg");
            return resultado;
        }
    }
}