using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BB2020.Core.Services
{
public interface IFileService
    {
        Task<IEnumerable<File>> GetFiles();
        Task<File> GetFileById(int id);
        Task<File> CreateFile(File file);
        Task UpdateFile(File fileToBeUpdated, File file);
        Task DeleteFile(File file);

    }
}
