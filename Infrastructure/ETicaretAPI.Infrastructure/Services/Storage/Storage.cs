using ETicaretAPI.Infrastructure.StaticServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrastructure.Services.Storage
{
    public class Storage
    {
        protected delegate List<string> GetFiles(string pathOrContainerName);
        protected delegate bool HasFile(string pathOrContainerName, string fileName);
        protected async Task<string> FileRenameAsync(string pathOrContainerName, string fileName, GetFiles getFilesMethod, HasFile hasFileMehod)
        {
            string newFileName = await Task.Run<string>(() =>
            {
                string extension = Path.GetExtension(fileName);
                string oldName = Path.GetFileNameWithoutExtension(fileName);
                string regulatedFileName = RenameHelper.CharacterRegulatory(oldName);

                if (!hasFileMehod(pathOrContainerName, regulatedFileName + "-1" + extension))
                    return Task.FromResult(regulatedFileName + "-1" + extension); //Demek ki bu isimde ilk kez dosya yükleniyor.

                List<string> files = getFilesMethod(pathOrContainerName).Where(files => files.StartsWith(regulatedFileName)).ToList();//bu isimle başlayan tüm dosyaları bulur               

                int[] fileNumbers = new int[files.Count];  //Dosya numaralarını buraya alıp en yükseğini bulucaz.
                int lastHyphenIndex;
                for (int i = 0; i < files.Count; i++)
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
