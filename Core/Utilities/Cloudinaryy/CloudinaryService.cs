using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Cloudinaryy
{
    public class CloudinaryService
    {
        Cloudinary cloudinary;
        public CloudinaryService()
        {

            Account account = new Account(

            "ahmettanrikulu",
            "257197552189564",
            "BlvS40igEj8apEVeOBYktBqAu_E");

            cloudinary = new Cloudinary(account);
            cloudinary.Api.Secure = true;
        }

        public ImageUploadResult Upload(ImageUploadParams file)
        {
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.File.FileName,file.File.FilePath),
                //transformation code here
                Transformation = new Transformation().Width(200).Height(200).Crop("thumb").Gravity("face")
            };

            var uploadResult = cloudinary.Upload(uploadParams);

            return uploadResult;
        }

    }
}
