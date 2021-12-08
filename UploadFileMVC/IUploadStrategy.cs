namespace UploadFileMVC
{
    public interface IUploadStrategy
    {
        public bool ExecuteUpload(File file);
    }
}
