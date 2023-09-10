using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EveDash3.backend
{


    /// <summary>
    /// Provides functions that arent catagorized anywhere else
    /// </summary>
    public static class MiscFunctions
    {

        public static string TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(
                currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory.FullName;
        }
        /// <summary>
        /// partitions lists into chunks of n
        /// https://www.techiedelight.com/split-a-list-into-sublists-of-size-n-in-csharp/
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="chunkSize"></param>
        /// <returns></returns>
        public static List<List<T>> partition<T>(this List<T> values, int chunkSize)
        {
            return values.Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

    }
}
