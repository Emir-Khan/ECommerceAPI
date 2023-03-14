using ECommerceAPI.Infrastructure.StaticServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Infrastructure.Services
{
    public class FileService
    {
        private static async Task<string> FileRenameAsync(string path, string fileName)
        {
            string newFileName = await Task.Run(() =>
            {
                string extension = Path.GetExtension(fileName);
                string oldName = Path.GetFileNameWithoutExtension(fileName);
                string regulatedFileName = RenameHelper.CharacterRegulatory(oldName);

                var files = Directory.GetFiles(path, regulatedFileName + "*"); //bu isimle başlayan tüm dosyaları bulur

                if (files.Length == 0) return Task.FromResult(regulatedFileName + "-1" + extension); //Demek ki bu isimde ilk kez dosya yükleniyor.

                int[] fileNumbers = new int[files.Length];  //Dosya numaralarını buraya alıp en yükseğini bulucaz.
                int lastHyphenIndex;
                for (int i = 0; i < files.Length; i++)
                {
                    lastHyphenIndex = files[i].LastIndexOf("-");
                    fileNumbers[i] = int.Parse(files[i].Substring(lastHyphenIndex + 1, files[i].Length - extension.Length - lastHyphenIndex - 1));
                }
                var biggestNumber = fileNumbers.Max(); //en yüksek sayıyı bulduk
                biggestNumber++;
                return Task.FromResult(regulatedFileName + "-" + biggestNumber + extension); //bir artırıp dönüyoruz
            });
            return newFileName;
        }
    }
}
