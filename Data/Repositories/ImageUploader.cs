using ComponentesMexica.Data.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentesMexica.Data.Repositories
{
    public class ImageUploader
    {
        public string UploadEmployeePic(EmployeeViewModel vm,IWebHostEnvironment webHostEnvironment)
        {
            string fileName = null;
            if (vm.Imagen != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "UploadImages");
                fileName = Guid.NewGuid().ToString() + "-" + vm.Imagen.FileName;
                string FilePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    vm.Imagen.CopyTo(fileStream);
                }
            }
            return fileName;
        }
        public string UploadComponentPic(ComponenteViewModel vm, IWebHostEnvironment webHostEnvironment)
        {
            string fileName = null;
            if (vm.Imagen != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "UploadImages");
                fileName = Guid.NewGuid().ToString() + "-" + vm.Imagen.FileName;
                string FilePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    vm.Imagen.CopyTo(fileStream);
                }
            }
            return fileName;
        }
        public string UploadPCMRPic(PCMRViewModel vm, IWebHostEnvironment webHostEnvironment)
        {
            string fileName = null;
            if (vm.Imagen != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "UploadImages");
                fileName = Guid.NewGuid().ToString() + "-" + vm.Imagen.FileName;
                string FilePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    vm.Imagen.CopyTo(fileStream);
                }
            }
            return fileName;
        }
        public string UploadSoftwarePic(SoftwareViewModel vm, IWebHostEnvironment webHostEnvironment)
        {
            string fileName = null;
            if (vm.Imagen != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "UploadImages");
                fileName = Guid.NewGuid().ToString() + "-" + vm.Imagen.FileName;
                string FilePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    vm.Imagen.CopyTo(fileStream);
                }
            }
            return fileName;
        }
        public string UploadSHPic(SecondHandViewModel vm, IWebHostEnvironment webHostEnvironment)
        {
            string fileName = null;
            if (vm.Imagen != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "UploadSHImages");
                fileName = Guid.NewGuid().ToString() + "-" + vm.Imagen.FileName;
                string FilePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    vm.Imagen.CopyTo(fileStream);
                }
            }
            return fileName;
        }
        public string UploadSelleInePic(VendedorViewModel vm, IWebHostEnvironment webHostEnvironment)
        {
            string fileName = null;
            if (vm.ImagenINE != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "SellerImages");
                fileName = Guid.NewGuid().ToString() + "-" + vm.ImagenINE.FileName;
                string FilePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    vm.ImagenINE.CopyTo(fileStream);
                }
            }
            return fileName;
        }
        public string UploadEvidence1(ReporteViewModel vm, IWebHostEnvironment webHostEnvironment)
        {
            string fileName = null;
            if (vm.Evidencia1 != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "Reportes");
                fileName = Guid.NewGuid().ToString() + "-" + vm.Evidencia1.FileName;
                string FilePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    vm.Evidencia1.CopyTo(fileStream);
                }
            }
            return fileName;
        }
        public string UploadEvidence2(ReporteViewModel vm, IWebHostEnvironment webHostEnvironment)
        {
            string fileName = null;
            if (vm.Evidencia2 != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "Reportes");
                fileName = Guid.NewGuid().ToString() + "-" + vm.Evidencia2.FileName;
                string FilePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    vm.Evidencia2.CopyTo(fileStream);
                }
            }
            return fileName;
        }public string UploadEvidence3(ReporteViewModel vm, IWebHostEnvironment webHostEnvironment)
        {
            string fileName = null;
            if (vm.Evidencia3 != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "Reportes");
                fileName = Guid.NewGuid().ToString() + "-" + vm.Evidencia3.FileName;
                string FilePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    vm.Evidencia3.CopyTo(fileStream);
                }
            }
            return fileName;
        }
        
    }
}
