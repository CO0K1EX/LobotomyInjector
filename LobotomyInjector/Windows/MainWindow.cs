using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using ForlornApi;
using LobotomyInjector.Models;

namespace LobotomyInjector
{
    public partial class MainWindow : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private string scriptsFolderPath = Path.Combine(Application.StartupPath, "Scripts");

        public MainWindow()
        {
            InitializeComponent();

            CheckFont();

            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;

            contextMenuStripMenu.Renderer = new DraculaStyleRender.DraculaStyleRenderMenu();

            labelProgramName.Text = this.Text + " Beta";

            LoadFilesFromDirectory();
        }

        private void CheckFont()
        {
            string fontToCheck = "Fira Code";

            if (!FontChecker.IsFontInstalled(fontToCheck))
            {
                MessageBox.Show($"{fontToCheck} is not installed on the computer.\nInstall the {fontToCheck} before proceeding.", "Font not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        
        private void LoadFilesFromDirectory()
        {
            string exeDirectory = Application.StartupPath;

            string scriptsFolder = Path.Combine(exeDirectory, "Scripts");

            if (!Directory.Exists(scriptsFolder))
            {
                try
                {
                    Directory.CreateDirectory(scriptsFolder);
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                string[] files = Directory.GetFiles(scriptsFolder, "*.txt", SearchOption.TopDirectoryOnly);

                listBoxSaveScripts.Items.Clear();

                foreach (var scriptFile in files)
                {
                    listBoxSaveScripts.Items.Add(Path.GetFileName(scriptFile));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void SaveScriptToTxtFile(string name)
        {
            if (name.Length < 1)
            {
                MessageBox.Show("The field must not be empty.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (!name.Contains("."))
            {
                name += ".txt";
            }

            try
            {
                StreamWriter streamWriter = new StreamWriter(Path.Combine(scriptsFolderPath,name));

                streamWriter.Write(richTextBox_ScriptInput.Text);
                streamWriter.Close();

                listBoxSaveScripts.Items.Add(name);
                textBoxScriptNameInput.Text = string.Empty;
                richTextBox_ScriptInput.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadScriptFile()
        {
            if (listBoxSaveScripts.SelectedIndex != -1)
            {
                string selectedFileName = listBoxSaveScripts.SelectedItem.ToString();
                string selectedFilePath = Path.Combine(scriptsFolderPath, selectedFileName);

                if (File.Exists(selectedFilePath))
                {
                    try
                    {
                        string fileContent = File.ReadAllText(selectedFilePath);
                        richTextBox_ScriptInput.Text = fileContent;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void RemoveScriptFile()
        {
            if (listBoxSaveScripts.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected script?\nThis action cannot be undone.", "Delete script",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                string selectedFileName = listBoxSaveScripts.SelectedItem.ToString();
                string selectedFilePath = Path.Combine (scriptsFolderPath, selectedFileName);

                if (File.Exists(selectedFilePath))
                {
                    try
                    {
                        File.Delete(selectedFilePath);

                        listBoxSaveScripts.Items.Remove(selectedFileName);
                        richTextBox_ScriptInput.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void buttonClearRichTextBox_Click(object sender, EventArgs e)
        {
            if (richTextBox_ScriptInput.Text != string.Empty)
            {
                if (MessageBox.Show("The text field will be cleared. Are you absolutely sure?", "Confirmation of cleaning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    richTextBox_ScriptInput.Clear();
                }
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (richTextBox_ScriptInput.Text == string.Empty)
            {
                MessageBox.Show("The field must not be empty.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                ForlornApi.Api.ExecuteScript(richTextBox_ScriptInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonInject_Click(object sender, EventArgs e)
        {
            if (!ForlornApi.Api.IsRobloxOpen())
            {
                MessageBox.Show("The game process was not found, make sure that the game is running.\nThe injector does not work with the game installed from the Microsoft Store.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ForlornApi.Api.Inject();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            int x = buttonMenu.Location.X + buttonMenu.Width;
            int y = buttonMenu.Location.Y + buttonMenu.Height + 5;

            contextMenuStripMenu.Show(this, new Point(x, y));
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point offset = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(offset));
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBoxWindow aboutBoxForm = new AboutBoxWindow();
            aboutBoxForm.ShowDialog();
        }

        private void buttonAddScript_Click(object sender, EventArgs e)
        {
            SaveScriptToTxtFile(textBoxScriptNameInput.Text);
        }

        private void listBoxSaveScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadScriptFile();
        }

        private void buttonRemoveScript_Click(object sender, EventArgs e)
        {
            RemoveScriptFile();
        }

        private void processKillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ForlornApi.Api.IsRobloxOpen())
            {
                MessageBox.Show("The game process was not found.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            ForlornApi.Api.KillRoblox();
        }
    }
}
