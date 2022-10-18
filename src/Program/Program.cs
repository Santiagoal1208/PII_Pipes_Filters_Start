using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            // PREGUNTAS 1-3
            // PictureProvider provider = new PictureProvider();
            // IPicture picture = provider.GetPicture(@"luke.jpg");
            // IFilter guardar= new FilterSave(@"luke_3.jpg");
            // IFilter twiter= new FilterTwitter(@"luke_3.jpg");
            
            // IFilter gris= new FilterGreyscale();
            // IFilter negativo= new FilterNegative();
            // IPipe ultimo_paso= new PipeNull();
            // IPipe casi_ultimo_paso= new PipeSerial(twiter,ultimo_paso);
            // IPipe segundo_paso= new PipeSerial(negativo,casi_ultimo_paso);
            // IPipe nuevo_segundo=new PipeSerial(guardar,segundo_paso);

            // IPipe primer_paso= new PipeSerial(gris,nuevo_segundo);
            
            // provider.SavePicture(primer_paso.Send(picture), @"luke_2.jpg");
            

            //PREGUNTA 4
            // PictureProvider provider = new PictureProvider();
            // IPicture picture = provider.GetPicture(@"luke.jpg");
            // IPicture picture_2 = provider.GetPicture(@"beer.jpg");
            // IFilter guardar= new FilterSave(@"luke_3.jpg");
            // IFilter twiter= new FilterTwitter(@"luke_3.jpg");
            
            // IFilter gris= new FilterGreyscale();
            // IFilter negativo= new FilterNegative();
            // IPipe ultimo_paso= new PipeNull();
            // IPipe opcion_1= new PipeSerial(twiter,ultimo_paso);
            // IPipe opcion_2= new PipeSerial(negativo,ultimo_paso);
            // IPipe segundo_paso= new PipeFork(opcion_1,opcion_2);
            // IPipe primer_paso= new PipeSerial(gris,segundo_paso);
            
            // provider.SavePicture(primer_paso.Send(picture), @"luke_2.jpg");
            // provider.SavePicture(primer_paso.Send(picture_2), @"beer_2.jpg");
            

            // EXTRA
            


        }
    }
}
