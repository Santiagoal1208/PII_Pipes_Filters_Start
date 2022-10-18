using System;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Un filtro que recibe una imagen y retorna su negativo.
    /// </remarks>
    public class FilterTwitter : IFilter
    {
        protected string Path;
        /// Un filtro que retorna el negativo de la imagen recibida.
        /// </summary>
        /// <param name="image">La imagen a la cual se le va a aplicar el filtro.</param>
        /// <returns>La imagen recibida pero en negativo.</returns>
        public FilterTwitter(string path)
        {
            this.Path = path;

        }
        public IPicture Filter(IPicture image)
        {
            IPicture result = image.Clone();

            
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter($"", this.Path));
            return result;
        }
    }
}
