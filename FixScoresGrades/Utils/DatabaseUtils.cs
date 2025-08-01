using OsuParsers.Database;
using OsuParsers.Decoders;

namespace FixScoresGrades.Utils;

internal static class DatabaseUtils
{
    internal static OsuDatabase ReadOsuData(string path)
        => DatabaseDecoder.DecodeOsu(path);
}
