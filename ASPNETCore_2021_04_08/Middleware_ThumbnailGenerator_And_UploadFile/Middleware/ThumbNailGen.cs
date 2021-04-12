using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware_ThumbnailGenerator_And_UploadFile.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ThumbNailGen
    {
        private readonly RequestDelegate _next;

        public ThumbNailGen(RequestDelegate next)
        {
            _next = next;
        }

        //public async Task Invoke(HttpContext context)
        //{
        //    //Logikpart
        //    var fileNameOfPicture = context.Request.Query["img"][0]; //Hier wird ein Bildpfad übergeben

        //    var absolutePicturePath = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + fileNameOfPicture;

        //    using (var sr = new FileStream (absolutePicturePath, FileMode.Open))
        //    {
        //        using (var image = new Bitmap(sr))
        //        {
        //            var resized = new Bitmap(300, 200);

        //            using (var graphics = Graphics.FromImage(resized))
        //            {
        //                graphics.DrawImage(image, 0, 0, 300, 200);

        //                var ms = new MemoryStream();

        //                resized.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);


        //                await context.Response.Body.WriteAsync(ms.ToArray());
        //            }
        //        }
        //    }
        //}


        public async Task Invoke(HttpContext context)
        {
            var fileNameOfPicture = context.Request.Query["img"][0];
            var absoluterPicturePath = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + fileNameOfPicture;

            using (var sr = new FileStream(absoluterPicturePath, FileMode.Open))
            {
                using (var image = new Bitmap(sr))
                {
                    var resized = new Bitmap(300, 200);

                    using (var graphics = Graphics.FromImage(resized))
                    {
                        graphics.DrawImage(image, 0, 0, 300, 200);
                        var ms = new MemoryStream();

                        resized.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                        await context.Response.Body.WriteAsync(ms.ToArray());
                    }
                }
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ThumbNailGenExtensions
    {
        public static IApplicationBuilder UseThumbNailGen(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ThumbNailGen>();
        }
    }
}
