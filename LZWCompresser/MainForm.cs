using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text;


namespace LZWCompresser
{
    public partial class MainForm : Form
    {
        string[] MyDictionary = new string[1000];
        
        int AllCharsCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        public void Encode()
        {
            string P = null, C = null, EncodedTxt = null;

            AllCharsCounter();

            P = txtOriginal.Text[0].ToString();

            int CharsCount = 0;
            while (CharsCount < AllCharsCount - 1)
            {
                C = txtOriginal.Text[CharsCount + 1].ToString();
                if (ExistInStringTable(P + C) == true)
                {
                    P = P + C;
                }
                else
                {
                    EncodedTxt += GetCode(P) + ",";
                    AddToStringTable(P + C);
                    P = C;
                }

                CharsCount++;

                bgNormal.ReportProgress((CharsCount * 100) / AllCharsCount);

                if (bgNormal.CancellationPending == true)
                    break;
            }
            EncodedTxt += GetCode(P);

            if (bgNormal.CancellationPending == true)
                SaveFile.FileName = "";
            else
            {
                txtCompressed.Text = EncodedTxt;
                SaveFile.Filter = "Compressed File (*.LZW)|*.lzw";
            }
        }

        public void Decode()
        {
            string S = null, C = null, DecodedTxt = null;
            int OLD = 0, NEW = 0, Index = 0;

            AllCharsCounter();

            string O = null;
            foreach (char c in txtOriginal.Text)
            {
                if (c != ',')
                {
                    O += c;
                    Index++;
                }
                else
                {
                    OLD = int.Parse(O);
                    break;
                }
            }
            DecodedTxt = MyDictionary[OLD];

            int NumOfCodes = 0;
            foreach (char c in txtOriginal.Text)
            {
                if (c == ',')
                    NumOfCodes++;
            }

            for (int r = 0; r < NumOfCodes; r++)
            {
                string N = "";
                for (int Q = Index + 1; Q <= AllCharsCount; Q++)
                {
                    if (Q != txtOriginal.Text.Length)
                    {
                        if (txtOriginal.Text[Q] != ',')
                        {
                            N += txtOriginal.Text[Q];
                        }
                        else
                        {
                            Index = Q;
                            NEW = int.Parse(N);
                            break;
                        }
                    }
                    else
                        NEW = int.Parse(N);
                }

                if (MyDictionary[NEW] == "")
                {
                    S = MyDictionary[OLD];
                    S = S + C;
                }
                else
                {
                    S = MyDictionary[NEW];
                }

                DecodedTxt += S;
                C = S[0].ToString();
                AddToStringTable(MyDictionary[OLD] + C);
                OLD = NEW;

                bgNormal.ReportProgress((r * 100) / AllCharsCount);
                if (bgNormal.CancellationPending == true)
                    break;
            }

            if (bgNormal.CancellationPending == true)
                SaveFile.FileName = "";
            else
            {
                txtCompressed.Text = DecodedTxt;
                SaveFile.Filter = "Text File (*.txt)|*.txt";
            }
        }

        public int GetCode(string s)
        {
            int Code = -1;
            for (int Index = 0; Index < MyDictionary.Length; Index++)
            {
                if (MyDictionary[Index] == s)
                {
                    Code = Index;
                    break;
                }
            }

            if (Code != -1)
                return Code;
            else
                return -1;
        }

        public bool ExistInStringTable(string s)
        {
            bool Exist = false;
            for (int Index = 0; Index < MyDictionary.Length; Index++)
            {
                if (MyDictionary[Index] == s)
                {
                    Exist = true;
                    break;
                }
            }

            if (Exist == true)
                return true;
            else
                return false;

        }

        public void AddToStringTable(string s)
        {
            for (int index = 256; index < MyDictionary.Length; index++)
            {
                if (MyDictionary[index] == "")
                {
                    MyDictionary[index] = s;
                    break;
                }
            }
        }

        public void AllCharsCounter()
        {
            AllCharsCount = 0;
            while (AllCharsCount < txtOriginal.Text.Length)
                AllCharsCount++;
        }

        public void Save()
        {
            StreamWriter FileCreator = new StreamWriter(SaveFile.FileName);
            FileCreator.Write(txtCompressed.Text);
            FileCreator.Close();
        }

        public void Read()
        {
            StreamReader FileReader = new StreamReader(OpenFile.FileName);
            txtOriginal.Text = FileReader.ReadToEnd();
            FileReader.Close();
        }

        public void Clear()
        {
            AllCharsCount = 0;
            lblOriginal.Text = "";
            lblCompressed.Text = "";
            txtOriginal.Text = "";
            txtCompressed.Text = "";
            txtPath.Text = "";
            btnCompress.Text = "Compress";
            txtOriginal.ReadOnly = true;
            txtOriginal.WordWrap = true;
            Progress.Value = 0;
            Progress.Visible = false;
        }

        public void InitializeDictionary()
        {
            for (int i = 0; i < 256; i++)
            {
                MyDictionary[i] = System.Text.Encoding.ASCII.GetString(new byte[1] { Convert.ToByte(i) });
            }

            for (int i = 256; i < MyDictionary.Length; i++)
            {
                MyDictionary[i] = "";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnCompress.Enabled = false;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            int x = this.PointToClient(new Point(e.X, e.Y)).X;
            int y = this.PointToClient(new Point(e.X, e.Y)).Y;
            if (x >= txtOriginal.Location.X && x <= txtOriginal.Location.X + txtOriginal.Width && y >= txtOriginal.Location.Y && y <= txtOriginal.Location.Y + txtOriginal.Height)
            {
                Clear();
                string[] DroppedFile = ((string[])e.Data.GetData(DataFormats.FileDrop));
                if (DroppedFile[0].EndsWith(".lzw"))
                {
                    txtOriginal.WordWrap = true;
                    txtCompressed.WordWrap = false;
                    btnCompress.Text = "Decompress";
                    lblOriginal.Text = "Compressed";
                    lblCompressed.Text = "Original";
                }
                else
                {
                    txtOriginal.WordWrap = false;
                    txtCompressed.WordWrap = true;
                    btnCompress.Text = "Compress";
                    lblOriginal.Text = "Original";
                    lblCompressed.Text = "Compressed";
                }


                OpenFile.FileName = DroppedFile[0];
                Read();

                txtPath.Text = DroppedFile[0];
                btnCompress.Enabled = true;
            }
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            AboutForm About = new AboutForm();
            About.ShowDialog();
        }

        private void txtPath_DoubleClick(object sender, EventArgs e)
        {
            txtPath.SelectAll();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFile.Filter = "Text and Compressed Files (*.lzw,*.txt)|*.txt;*.lzw|Text Files (*.txt)|*.txt|Compressed Files (*.lzw)|*.lzw";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Clear();
                if (OpenFile.FileName.EndsWith(".lzw") == true)
                {
                    txtOriginal.WordWrap = true;
                    txtCompressed.WordWrap = false;
                    btnCompress.Text = "Decompress";
                    lblOriginal.Text = "Compressed";
                    lblCompressed.Text = "Original";
                }
                else
                {
                    txtOriginal.WordWrap = false;
                    txtCompressed.WordWrap = true;
                    btnCompress.Text = "Compress";
                    lblOriginal.Text = "Original";
                    lblCompressed.Text = "Compressed";
                }

                Read();
                InitializeDictionary();

                txtPath.Text = OpenFile.FileName;
                btnCompress.Enabled = true;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            if (btnCompress.Text == "Cancel")
            {
                bgNormal.CancelAsync();
                Progress.Visible = false;
                txtCompressed.Text = "";
            }
            else
            {
                if (btnCompress.Text == "Save")
                {
                    if (SaveFile.ShowDialog() == DialogResult.OK)
                    {
                        Save();
                    }
                    Clear();
                    btnCompress.Enabled = false;
                }
                else
                {
                    btnOpen.Enabled = false;
                    Progress.Visible = true;
                    bgNormal.RunWorkerAsync();
                }
            }
        }

        private void bgNormal_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (bgNormal.CancellationPending == true)
            {
                e.Cancel = true;
                btnCompress.Text = "Compress";
            }
            else
            {
                string TempOp = btnCompress.Text;
                btnCompress.Text = "Cancel";
                if (TempOp == "Compress")
                    Encode();
                else
                    Decode();
            }
        }

        private void bgNormal_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage <= 100)
                Progress.Value = e.ProgressPercentage;
        }

        private void bgNormal_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (txtCompressed.Text != "")
                btnCompress.Text = "Save";
            else
            {
                btnCompress.Text = "Compress";
                btnCompress.Enabled = false;
            }

            Progress.Value = 0;
            Progress.Visible = false;
            btnOpen.Enabled = true;
        }

    }
}