namespace WinFormsDialogsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fontDialog.ShowColor = true;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = openFileDialog.FileName;
            string text = File.ReadAllText(fileName);
            txtEditor.Text = text;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            string fileName = saveFileDialog.FileName;
            File.WriteAllText(fileName, txtEditor.Text);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.Cancel) return;

            txtEditor.Font = fontDialog.Font;
            txtEditor.ForeColor = fontDialog.Color;
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel) return;

            txtEditor.BackColor = colorDialog.Color;
        }

        private void openStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = openFileDialog.FileName;
            string text = File.ReadAllText(fileName);
            txtEditor.Text = text;
        }
    }
}