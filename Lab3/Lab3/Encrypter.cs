using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class Encrypter
    {
        public static event Action<string, string> BlockHashed;
        public static event Action<double, double, double> AllFileHashed;
        public static async Task Encrypt(Stream stream, long length)
        {
            int step = (int)Math.Ceiling(length / 100d);

            int readBytes;
            var readTime = new Stopwatch();
            var SHA256Time = new Stopwatch();
            var KHATime = new Stopwatch();

            do
            {
                byte[] blockBytes = new byte[step];
                
                readTime.Start();
                readBytes = await stream.ReadAsync(blockBytes, 0, step);
                readTime.Stop();

                if (readBytes != step) blockBytes = blockBytes.Take(readBytes).ToArray();

                SHA256Time.Start();
                string kha = await GetKHA(blockBytes);
                SHA256Time.Stop();

                KHATime.Start();
                string sha256 = await GetSHA512(blockBytes);
                KHATime.Stop();

                BlockHashed?.Invoke(
                    kha,
                    sha256);
                
            } while (readBytes > 0);

            var lengthKb = length / 1000.0;
            AllFileHashed?.Invoke(
                lengthKb / readTime.ElapsedMilliseconds,
                lengthKb / KHATime.ElapsedMilliseconds,
                lengthKb / SHA256Time.ElapsedMilliseconds
                );
        }

        private static Task<string> GetEncryptedBytes(byte[] array, HashAlgorithm algorithm) => Task.Run(() =>
        {
            byte[] hash;
            using (algorithm)
                hash = algorithm.ComputeHash(array);
            return String.Join("", hash);
        });

        private static Task<string> GetSHA512(byte[] array) => GetEncryptedBytes(array, SHA256.Create());
        
        private static Task<string> GetKHA(byte[] array) => GetEncryptedBytes(array, KeyedHashAlgorithm.Create());
    }
}

