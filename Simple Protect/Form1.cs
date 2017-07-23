using System;
using System.IO;
using System.Windows.Forms;
using Mono.Cecil;

namespace Simple_Protect
{
    public partial class fMain : Form
    {
        private AssemblyDefinition asm;
        public fMain()
        {
            InitializeComponent();
        }

        private void fOpen_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Filter = ".exe|*.exe";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    fPath.Text = open.FileName;
                    asm = AssemblyDefinition.ReadAssembly(fPath.Text);
                }
            }
        }

        private void RenameType(AssemblyDefinition assembly)
        {
            TypeDefinition mytype = null;
            foreach (TypeDefinition t in assembly.MainModule.Types)
            {
                if (t.Name != "<Module>")
                {
                    t.Name = RandomMix(12);
                }
            }
        }

        private void RenameMethod(AssemblyDefinition assembly)
        {
            MethodDefinition mymethod = null;
            TypeDefinition mytype = null;
            foreach (TypeDefinition t in assembly.MainModule.Types)
            {
                foreach (MethodDefinition m in t.Methods) // t est un Type
                {
                    if (t.Name != "<Module>")
                    {
                        m.Name = RandomMix(12);
                    }
                }
            }
        }

        private readonly Random rnd = new Random();
        private const string mix = "դгжфֆйবբтзհֆխնйռցтդհўমցсрфўзтгйфবсবтўізռնжтխссհжз৯зৰжжгռз৯сзռдсд৯ցচցтітբзуռհіৰնৰтհрխіমуарпռзджնդ৯ৰпբпфуֆйпբтցўդব৯৯ռհшমৰֆаі";
        private const string eng = "ABCDIFGHEJKLOMPNRSTQWZadsadioaigysdLOMPNshdnuwqeuyigysdLOMPNRSTQWZadsa";

        public string RandomMix(int size)
        {
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = mix[rnd.Next(mix.Length)];
            }
            return new string(buffer);
        }

        public string RandomEng(int size)
        {
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = eng[rnd.Next(eng.Length)];
            }
            return new string(buffer);
        }

        private void fSave_Click(object sender, EventArgs e)
        {
            using (var save = new SaveFileDialog())
            {
                save.Filter = ".exe|*.exe";
                save.FileName = String.Format("{0}_obf", Path.GetFileNameWithoutExtension(fPath.Text));

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (checkBox1.Checked)
                        RenameType(asm);
                    if (checkBox2.Checked)
                        RenameMethod(asm);
                    
                    asm.Write(save.FileName);

                    MessageBox.Show("Done ;)", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
