using FixScoresGrades.Utils;
using OsuParsers.Database;

namespace FixScoresGrades;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    private void FixMode_Click(object sender, EventArgs e)
    {
        string osuDbPath = osuDatabasePath.Text;

        if (!File.Exists(osuDbPath))
        {
            MessageBox.Show("osu!.dbファイルが見つかりませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        SaveFileDialog dialog = new()
        {
            Filter = "DBファイル|*.db;",
            Title = "新規データベースファイルの保存先を選択してください",
            FileName = "new_osu!.db",
            InitialDirectory = new DirectoryInfo(osuDbPath).Parent?.FullName ?? Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        };

        if (dialog.ShowDialog() != DialogResult.OK) return;

        OsuDatabase fixedOsu = OsuUtils.FixGrades(osuDbPath);
        fixedOsu.Save(dialog.FileName);

        MessageBox.Show("出力が完了しました！\nosu!.dbをosu!.db.oldなどに改名し、新しく作ったファイルをosu!.dbとすることで変更が反映されます！", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void OpenFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog dialog = new()
        {
            Filter = "データべースファイル|*.db",
            Title = "osu!.dbファイルを選択してください"
        };

        if (dialog.ShowDialog() != DialogResult.OK) return;
        osuDatabasePath.Text = dialog.FileName;
    }
}
