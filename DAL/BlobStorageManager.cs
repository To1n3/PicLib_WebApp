using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace DAL
{
    public class BlobStorageManager
    {
        CloudBlobClient blobClient;
        CloudBlobContainer container;
        public BlobStorageManager(CloudStorageAccount StorageAccount)
        {
            blobClient = StorageAccount.CreateCloudBlobClient();
            container = blobClient.GetContainerReference("pictures");
            container.CreateIfNotExists();
        }

        public System.Uri UploadPicture(string localFilePath)
        {
            try
            {
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(localFilePath);
                using (var fileStream = System.IO.File.OpenWrite(localFilePath))
                {
                    blockBlob.UploadFromStream(fileStream);
                }
                return blockBlob.Uri;
            }
            catch (Exception )
            {
                throw;
            }
            
        }
    }
}
