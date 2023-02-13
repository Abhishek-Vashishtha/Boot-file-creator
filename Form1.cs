using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Xml;
using System.Runtime.InteropServices;

namespace Boot_file_creator
{
    public partial class Bootfile_Creator : Form
    {
        public Bootfile_Creator()
        {
            InitializeComponent();
        }

        public string bin_file_path = null;
        public string boot_file_path = null;

        private void Button_select_fw_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog fwfile = new OpenFileDialog();
            fwfile.Title = "Browse the Fimrware bin file";
            fwfile.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            fwfile.ShowDialog();
            Button_select_fw_file.Text = fwfile.SafeFileName;
            bin_file_path = fwfile.FileName;
            try
            {
                FileStream file_fw = new FileStream(fwfile.FileName,FileMode.Open,FileAccess.Read);
                Label_bootfle_size.Text = file_fw.Length.ToString()+ " Bytes";
                if (file_fw.Length != 262144)
                {
                    MessageBox.Show("Invalid size of file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                file_fw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Button_select_fw_file.Text = " Browse Fw bin File";
            }
        }

        private void Button_create_bootfile_Click(object sender, EventArgs e)
        {
            if (Button_select_fw_file.Text == "File Size")
            {
                MessageBox.Show("Please select bin file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Chkbox_Optical.Checked == false && ChkBox_Rj45.Checked == false)
            {
                MessageBox.Show("Please select mode of communication", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileStream fw_bin_file, boot_bin_file;
                byte[] temp_array = new byte[1024];
                string temp_string = string.Empty;
                string boot_file_final = string.Empty;

                boot_file_path = Path.GetDirectoryName(Application.ExecutablePath);
                if (Chkbox_Optical.Checked == true)
                {
                    boot_file_path += "\\Boot_files\\GDEV72_BOOT_OPTICAL.bin";
                }
                else
                {
                    boot_file_path += "\\Boot_files\\GDEV72_BOOT_RJ_45.bin";
                }
                boot_bin_file = new FileStream(boot_file_path, FileMode.Open, FileAccess.Read);
                fw_bin_file = new FileStream(bin_file_path, FileMode.Open, FileAccess.Read);

                // creating combined boot file
                boot_file_final = fw_bin_file.Name.Replace(".bin", "_BL.txt");
                StreamWriter boot_file = new StreamWriter(boot_file_final);

                // clearing the boot file if already exists
                if (boot_file.BaseStream.Length != 0)
                    boot_file.Flush();

                /* Reading and writing bootloader bin file*/
                for (int i = 0; i < 4; i++)
                {
                    /* reading 1024 bytes */

                    boot_bin_file.Read(temp_array, 0, 1024);

                    /* converting byte array to hex string */
                    temp_string = Class1.byte_array_to_hex_string_spaced(temp_array, 1024);

                    /* writing bin file into the memory*/
                    boot_file.Write(temp_string, temp_string.Length);
                }
                /* Reading and writing firmware bin file*/
                for (int i = 0; i < 256; i++)
                {
                    /*reading 1024 bytes at a time */
                    fw_bin_file.Read(temp_array, 0, 1024);

                    /* conversion*/
                    temp_string = Class1.byte_array_to_hex_string_spaced(temp_array, 1024);

                    /* Writing fw file*/
                    boot_file.Write(temp_string, temp_string.Length);
                }
                boot_file.Close();
                MessageBox.Show("Bootloader File created sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Label_bootfle_size.Text = "File Size";
                boot_bin_file.Close();
                fw_bin_file.Close();
                Button_select_fw_file.Text = "Browse Fw Bin File";
                bin_file_path = null;
                boot_file_path = null;
            }

        }

        private void Label_bootfle_size_Click(object sender, EventArgs e)
        {

        }

        private void Btn_HowToUse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please follow below steps :\n1. Go to project settings->output converter.\n2. Select output format as bin.\n3. build the project.\n4. Browse the f/w bin file and click on create boot file.\n5. If success message come boot file created in bin file folder.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);                                         
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A small to create boot file for renesas I1C.\nPlease share your feedback at abhishek.vashishtha@genus.in","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ChkBox_Rj45_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkbox_Optical.Checked == true)
            {
                Chkbox_Optical.Checked = false;
            }
        }

        private void Chkbox_Optical_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBox_Rj45.Checked == true)
            {
                ChkBox_Rj45.Checked = false;
            }
        }
    }
}
