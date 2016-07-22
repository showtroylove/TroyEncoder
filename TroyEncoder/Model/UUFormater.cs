using System.IO;
using Awalsh128.Text;

namespace TroyEncoder.Model
{
    public class UUFormater
    {
        private const int BufferSize = 1048576; //(1MB)

        public string EncodeFile(string decodedFilePath, string encodedFilePath = null)
        {
            var filename = encodedFilePath ?? $"{ decodedFilePath }.uue";
            using (var decodedFileStream = File.OpenRead(decodedFilePath))
            {
                using (var unbuffered = new MemoryStream())
                {
                    using (var encodedStream = new BufferedStream(unbuffered, 1 << 2))
                    {
                        using (var encodeStream = new UUEncodeStream(encodedStream, fileName: decodedFilePath))
                        {
                            decodedFileStream.CopyTo(encodeStream);
                        }
                    }

                    var actualEncoded = unbuffered.ToArray();
                    File.WriteAllBytes(filename, actualEncoded);
                }
            }

            return filename;
        }

        ///<summary>Decodes a File with the UUEncode algorithm.</summary>
        ///<param name="encodedFilePath">A string containing the filename to decode.</param>
        ///<param name="outputPath">A string containing the path to save the decoded file to.</param>
        ///<returns>The name of the decoded file.</returns>
        public string DecodeFile(string encodedFilePath, string outputPath)
        {
            var filename = Path.GetFileNameWithoutExtension(encodedFilePath);

            using (var encodedFileStream = File.OpenRead(encodedFilePath))
            using (var decodeStream = new UUDecodeStream(encodedFileStream))
            {
                using (var unbuffered = new MemoryStream())
                {
                    using (var decodedFileStream = new BufferedStream(unbuffered, BufferSize))
                    {
                        decodeStream.CopyTo(decodedFileStream);
                    }

                    var actualDecoded = unbuffered.ToArray();

                    if (filename != null)
                    {
                        filename = decodeStream.FileName ?? Path.Combine(outputPath, filename);
                        File.WriteAllBytes(filename, actualDecoded);
                    }
                }
            }
            return filename;
        }
    }
}
