namespace RealEstateWebApi.Application;

public interface IZipService
{
    public byte[] ZipFiles(string folderpath);

}
