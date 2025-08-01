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
            MessageBox.Show("osu!.db�t�@�C����������܂���ł����B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        SaveFileDialog dialog = new()
        {
            Filter = "DB�t�@�C��|*.db;",
            Title = "�V�K�f�[�^�x�[�X�t�@�C���̕ۑ����I�����Ă�������",
            FileName = "new_osu!.db",
            InitialDirectory = new DirectoryInfo(osuDbPath).Parent?.FullName ?? Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        };

        if (dialog.ShowDialog() != DialogResult.OK) return;

        OsuDatabase fixedOsu = OsuUtils.FixGrades(osuDbPath);
        fixedOsu.Save(dialog.FileName);

        MessageBox.Show("�o�͂��������܂����I\nosu!.db��osu!.db.old�Ȃǂɉ������A�V����������t�@�C����osu!.db�Ƃ��邱�ƂŕύX�����f����܂��I", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void OpenFile_Click(object sender, EventArgs e)
    {
        OpenFileDialog dialog = new()
        {
            Filter = "�f�[�^�ׁ[�X�t�@�C��|*.db",
            Title = "osu!.db�t�@�C����I�����Ă�������"
        };

        if (dialog.ShowDialog() != DialogResult.OK) return;
        osuDatabasePath.Text = dialog.FileName;
    }
}
