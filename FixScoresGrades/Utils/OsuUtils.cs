using OsuParsers.Database;
using OsuParsers.Enums;
using OsuParsers.Enums.Database;

namespace FixScoresGrades.Utils;

internal static class OsuUtils
{
    internal static OsuDatabase FixGrades(string osuDatabasePath)
    {
        OsuDatabase osuDatabase = DatabaseUtils.ReadOsuData(osuDatabasePath);

        foreach (var beatmap in osuDatabase.Beatmaps)
        {
            if (beatmap.Ruleset == Ruleset.Standard) continue;
            Grade highestGrade = Grade.N;

            if (beatmap.StandardGrade < highestGrade) highestGrade = beatmap.StandardGrade;
            if (beatmap.TaikoGrade < highestGrade) highestGrade = beatmap.TaikoGrade;
            if (beatmap.CatchGrade < highestGrade) highestGrade = beatmap.CatchGrade;
            if (beatmap.ManiaGrade < highestGrade) highestGrade = beatmap.ManiaGrade;

            if (highestGrade == Grade.N) continue;

            beatmap.StandardGrade = highestGrade;
            beatmap.TaikoGrade = highestGrade;
            beatmap.CatchGrade = highestGrade;
            beatmap.ManiaGrade = highestGrade;
        }

        return osuDatabase;
    }
}
