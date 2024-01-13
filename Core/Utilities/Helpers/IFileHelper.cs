using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace Core.Utilities.Helpers
{
    public interface IFileHelper
    {
        string Upload(IFormFile file,string root);
        void Delete (string filePath);
        string Update(IFormFile file,string filePath,string root);
       
    }
}