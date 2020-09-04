//using BlazorInputFile;
//using CugemderPortal.Server.Services;
//using Microsoft.AspNetCore.Hosting;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CugemderPortal.Server.Data
//{
//    public class FileUpload : IFileUpload
//    {
//        private readonly IWebHostEnvironment _webHostEnvironment;

//        public FileUpload(IWebHostEnvironment webHostEnvironment)
//        {
//            _webHostEnvironment = webHostEnvironment;
//        }
//        public Task  Upload(IFileListEntry file)
//        {
//            string encodedStr = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{file.Name}"));
//            var path = Path.Combine(_webHostEnvironment.ContentRootPath, "UploadedContent", encodedStr);

//            var memoryStream = new MemoryStream();

//            file.Data.CopyToAsync(memoryStream);

//            using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
//            {
//                memoryStream.WriteTo(fs);
//            }
//        }
//    }
//}
