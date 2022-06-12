using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Abstractions.Storage
{
    public class FilePath
    {
        public FilePath(string directoryOrContainer,string fileName)
        {
            FileName = fileName;
            DirectoryOrContainer = directoryOrContainer;
        }
        public string DirectoryOrContainer { get;}
        public string FileName { get;}
        public string FullPath { get => Path.Combine(DirectoryOrContainer,FileName); }
    }
}
