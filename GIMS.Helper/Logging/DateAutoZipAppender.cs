using System.IO.Compression;
using System.Linq;
using log4net.Appender;

namespace GIMS.Helper.Logging
{
    public class DateAutoZipAppender : RollingFileAppender
    {
        protected override void AdjustFileBeforeAppend()
        {
            var previousFile = File;
            base.AdjustFileBeforeAppend();
            if (File != previousFile)
            {
                using (ZipArchive zip = ZipFile.Open(previousFile.Replace(".log", ".zip"), ZipArchiveMode.Create))
                {
                    zip.CreateEntryFromFile(previousFile, previousFile.Split('\\').Last());
                    System.IO.File.Delete(previousFile);
                }
            }
        }
    }
}


