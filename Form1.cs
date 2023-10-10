using sd9tool_front_end.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sd9tool_front_end
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            SD9File obj = new SD9File();


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "%UserProfile%\\";
                openFileDialog.Filter = "SD9 files (*.sd9)|*.sd9*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    //Addg text string to near texbox
                    txtSD9File.Text = filePath;

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    bool fileLoad = obj.SD9Load(filePath);


                    var variables = new Dictionary<string, string>();
                    variables["script_path"] = @"path to the tools.py";
                    variables["filePath"] = openFileDialog.FileName;

                    var comando = CommandTemplates.CreateCommand(CommandKeys.ANALIZE, variables);

                    txtOutput.Text = ToolCommands.EjecutarComando("python", comando);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void File_Opening(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void importwavbrowse_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "%UserProfile%\\";
                openFileDialog.Filter = "MS ADPCM wave files (*.wav)|*.wav*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    //Addg text string to near texbox
                    importwavfield.Text = filePath;

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PythonTextPath_Click(object sender, EventArgs e)
        {

        }

        private void BrowsePython_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PythonPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void txtSD9File_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Overdrive_Click(object sender, EventArgs e)
        {

        }

        private void Main_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
    public class SD9File
    {
        static byte[] Header = new byte[] { 0x53, 0x44, 0x39, 0x00 };
        byte[] SD9_HEADER = Header;

        // Define parameters
        private byte[] header = new byte[] { 0x53, 0x44, 0x39, 0x00 };      // SD9 header ID
        private byte[] headerSize = new byte[] { 0x20, 0x00, 0x00, 0x00 };  // Should never change
        private byte[] audioSize = new byte[] { 0x00, 0x00, 0x00, 0x00 };   // Byte length of wav file
        private byte[] fluff1 = new byte[] { 0x31, 0x32, 0x01, 0x00 };      // Should be replaced with whatever is in the existing file
        private byte[] fluff2 = new byte[] { 0x40, 0x00 };                  // Is always 0x40 0x00, changing it breaks
        private byte volume = 0x00;                                         // Scale is reverse where 0 is loudest
        private byte fluff3 = 0x00;                                         // Possibly related to volume
        private byte[] loopStart = new byte[] { 0x00, 0x00, 0x00, 0x00 };   // Control where the loop cycle starts in # of samples
        private byte[] loopEnd = new byte[] { 0x00, 0x00, 0x00, 0x00 };     // Control where the loop cycle ends in # of samples
        private byte loop = 0x00;                                           // Loop enabled, 0=off 1=on
        private byte fluff4 = 0x00;                                         // Loop end flag?
        private byte[] index = new byte[] { 0x00, 0x00 };                   // Unique sound index, must be same as file replacing
        private byte[] audio = new byte[0];                                 // Audio file in Microsoft ADPCM format

        private bool fileLoaded = false;
        private bool clobber;

        // Build
        public SD9File(string filename = null, bool clobber = false)
        {
            this.clobber = clobber;

            if (!string.IsNullOrEmpty(filename))
            {
                this.fileLoaded = this.SD9Load(filename);
            }
        }

        string filename = string.Empty;
        string exportname = string.Empty;
        public bool SD9Load(string filename)
        {
            /*
            '''
            Function : sd9_load
            Purpose  : Load SD9 header and audio data from a file
            '''
            */

            this.filename = filename;
            if (this.clobber)
            {
                this.exportname = filename;
            }
            else
            {
                this.exportname = filename + "_out";
            }

            try
            {
                using (FileStream sd9 = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    // Read variables from the binary

                    this.header = new byte[4];
                    sd9.Read(this.header, 0, 4);

                    this.headerSize = new byte[4];
                    sd9.Read(this.headerSize, 0, 4);

                    this.audioSize = new byte[4];
                    sd9.Read(this.audioSize, 0, 4);

                    this.fluff1 = new byte[4];
                    sd9.Read(this.fluff1, 0, 4);

                    this.fluff2 = new byte[2];
                    sd9.Read(this.fluff2, 0, 2);

                    this.volume = (byte)sd9.ReadByte();
                    this.fluff3 = (byte)sd9.ReadByte();

                    this.loopStart = new byte[4];
                    sd9.Read(this.loopStart, 0, 4);

                    this.loopEnd = new byte[4];
                    sd9.Read(this.loopEnd, 0, 4);

                    this.loop = (byte)sd9.ReadByte();
                    this.fluff4 = (byte)sd9.ReadByte();

                    this.index = new byte[2];
                    sd9.Read(this.index, 0, 2);

                    int audioSize = BitConverter.ToInt32(this.audioSize, 0);
                    this.audio = new byte[audioSize];
                    sd9.Read(this.audio, 0, audioSize);
                }

                if (!ByteArraysAreEqual(this.header, this.SD9_HEADER))
                {
                    Console.WriteLine("ERROR: SD9 file provided is invalid");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Could not load SD9: {ex.Message}");
                return false;
            }
        }

        // 
        public bool ByteArraysAreEqual(byte[] arr1, byte[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }


    }
}
