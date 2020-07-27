using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridGetFileExtension
{
    public interface IController
    {
        void sendFileNames(string[] filenames);
        void sendIndexesAndFileNamesInJsonToAnalyze(string[] itemsInJson);
        void sendIndexesAndFileNamesInJsonToEdit(string[] items);
        void sendIndexesAndFileNamesInJsonToOpen(string[] vs);
    }
}
