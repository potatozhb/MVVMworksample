// XAML Map Control - http://xamlmapcontrol.codeplex.com/
// © 2016 Clemens Fischer
// Licensed under the Microsoft Public License (Ms-PL)

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Media.Imaging;

namespace MapControl
{
    internal static class ImageLoader
    {
        public static BitmapSource FromStream(Stream stream)
        {
            var bitmap = new BitmapImage();

            bitmap.BeginInit();
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.StreamSource = stream;
            bitmap.EndInit();
            bitmap.Freeze();

            return bitmap;
        }

        public static BitmapSource FromUri(Uri uri, String HttpUserAgent = null)
        {
            BitmapSource bitmap = null;

            try
            {
                var request = WebRequest.CreateHttp(uri);
                if (!String.IsNullOrEmpty(HttpUserAgent))
                {
                    request.UserAgent = HttpUserAgent;
                }

                using (var response = request.GetResponse())
                using (var responseStream = response.GetResponseStream())
                using (var memoryStream = new MemoryStream())
                {
                    responseStream.CopyTo(memoryStream);
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    bitmap = FromStream(memoryStream);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return bitmap;
        }
    }
}
